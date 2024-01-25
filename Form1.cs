using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using Zeroconf;
using System.Net.Http;
using System.Text;
using System.ComponentModel;

namespace BD_Switcher
{
    public partial class Form1 : Form
    {
        private readonly BindingList<MdnsItem> ndiSources = new BindingList<MdnsItem>();
        private readonly BindingList<MdnsItem> birdDogSources = new BindingList<MdnsItem>();

        public Form1()
        {
            InitializeComponent();

            // Set the initial text for the DataGridViews
            sourceDataGridView.DataSource = ndiSources;
            destinationDataGridView.DataSource = birdDogSources;

            // Start the async searches for NDI and BirdDog sources
            SearchForNDISources();
            SearchForBirdDogSources();
        }

        private async void SearchForNDISources()
        {
            try
            {
                // Add the "Display No Source" option at the top
                ndiSources.Add(new MdnsItem { Name = "None" });

                IReadOnlyList<IZeroconfHost> results = await ZeroconfResolver.ResolveAsync("_ndi._tcp.local.");
                foreach (var result in results)
                {
                    // Create a new MdnsItem and populate it with IP address and name
                    var mdnsItem = new MdnsItem
                    {
                        IPAddress = result.IPAddress,
                        Name = result.DisplayName
                    };

                    ndiSources.Add(mdnsItem);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the search
                MessageBox.Show($"Error searching for NDI sources: {ex.Message}");
            }
        }

        private async void SearchForBirdDogSources()
        {
            try
            {
                IReadOnlyList<IZeroconfHost> results = await ZeroconfResolver.ResolveAsync("_birddog._tcp.local.");
                foreach (var result in results)
                {
                    // Create a new MdnsItem and populate it with IP address and name
                    var mdnsItem = new MdnsItem
                    {
                        IPAddress = result.IPAddress,
                        Name = result.DisplayName
                    };

                    birdDogSources.Add(mdnsItem);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the search
                MessageBox.Show($"Error searching for BirdDog sources: {ex.Message}");
            }
        }

        // Handle the "Route" button click event here
        private async void routeButton_Click(object sender, EventArgs e)
        {
            // Retrieve the selected MDNS items
            MdnsItem selectedSourceItem = ndiSources.FirstOrDefault(item => item.Name == sourceDataGridView.SelectedCells[0].Value?.ToString());
            MdnsItem selectedDestinationItem = birdDogSources.FirstOrDefault(item => item.Name == destinationDataGridView.SelectedCells[0].Value?.ToString());

            // Check if both source and destination are selected
            if (selectedSourceItem != null && selectedDestinationItem != null)
            {
                // Construct the API URL with the selected destination's IP address and port 8080
                string apiUrl = $"http://{selectedDestinationItem.IPAddress}:8080/connectTo";

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show($"Do you want to route:\n" +
                                                        $"{selectedSourceItem.Name} ({selectedSourceItem.IPAddress}) \n" +
                                                        $"to\n" +
                                                        $"{selectedDestinationItem.Name} ({selectedDestinationItem.IPAddress})?\n\n",
                                                      "Confirm Routing", MessageBoxButtons.OKCancel);

                // Check the user's choice in the dialog
                if (result == DialogResult.OK)
                {
                    // Create a JSON payload with the sourceName
                    string jsonPayload = $"{{ \"sourceName\": \"{selectedSourceItem.Name}\" }}";

                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            // Create a StringContent object with the JSON payload
                            StringContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                            // Send the HTTP POST request
                            HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                            // Check the response status
                            if (response.IsSuccessStatusCode)
                            {
                            }
                            else
                            {
                                MessageBox.Show($"Error routing: {response.ReasonPhrase}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error during API request: {ex.Message}");
                    }
                }
                else
                {
                    // User clicked "Cancel" in the confirmation dialog, no action needed
                }
            }
            else
            {
                MessageBox.Show("Please select both a source and a destination.");
            }
        }
        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            // Filter the sourceDataGridView based on the entered text
            string filterText = filterTextBox.Text.ToLower();
            sourceDataGridView.DataSource = new BindingList<MdnsItem>(ndiSources.Where(item => item.Name.ToLower().Contains(filterText)).ToList());

            // Filter the destinationDataGridView based on the entered text
            filterText = filterTextBox.Text.ToLower();
            destinationDataGridView.DataSource = new BindingList<MdnsItem>(birdDogSources.Where(item => item.Name.ToLower().Contains(filterText)).ToList());
        }

        private void refreshSourcesButton_Click(object sender, EventArgs e)
        {
            // Clear the ndiSources list to remove old entries
            ndiSources.Clear();

            // Start the async search for NDI sources
            SearchForNDISources();
        }

        private void refreshDestinationsButton_Click(object sender, EventArgs e)
        {
            // Clear the birdDogSources list to remove old entries
            birdDogSources.Clear();

            // Start the async search for BirdDog sources
            SearchForBirdDogSources();
        }

    }

    // Custom class to represent MDNS items with IP address and name
    public class MdnsItem
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
    }
}
