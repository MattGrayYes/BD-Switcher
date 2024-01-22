using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using Zeroconf;
using System.Net.Http;
using System.Text;

namespace BD_Switcher
{
    public partial class Form1 : Form
    {
        private readonly List<MdnsItem> ndiSources = new List<MdnsItem>();
        private readonly List<MdnsItem> birdDogSources = new List<MdnsItem>();

        public Form1()
        {
            InitializeComponent();

            // Set the initial text for the ListBoxes
            sourceListBox.Items.Add("Searching for sources...");
            destinationListBox.Items.Add("Searching for destinations...");

            // Start the async searches for NDI and BirdDog sources
            SearchForNDISources();
            SearchForBirdDogSources();
        }

        private async void SearchForNDISources()
        {
            try
            {
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
                RefreshListBox(sourceListBox, ndiSources.Select(item => item.Name).ToList());
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
                RefreshListBox(destinationListBox, birdDogSources.Select(item => item.Name).ToList());
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the search
                MessageBox.Show($"Error searching for BirdDog sources: {ex.Message}");
            }
        }

        private void RefreshListBox(ListBox listBox, List<string> items)
        {
            listBox.BeginUpdate();
            listBox.Items.Clear(); // Clear the "Searching for [sources/destinations]" message
            if (items.Count == 0)
            {
                listBox.Items.Add($"No {listBox.Name} found");
            }
            else
            {
                listBox.Items.AddRange(items.ToArray());
            }
            listBox.EndUpdate();
        }

        // Handle the "Route" button click event here
        private async void routeButton_Click(object sender, EventArgs e)
        {
            // Retrieve the selected MDNS items
            MdnsItem selectedSourceItem = ndiSources.FirstOrDefault(item => item.Name == sourceListBox.SelectedItem as string);
            MdnsItem selectedDestinationItem = birdDogSources.FirstOrDefault(item => item.Name == destinationListBox.SelectedItem as string);

            // Check if both source and destination are selected
            if (selectedSourceItem != null && selectedDestinationItem != null)
            {
                // Display a confirmation dialog
                DialogResult result = MessageBox.Show($"Do you want to route '{selectedSourceItem.Name}' to '{selectedDestinationItem.Name}'?", "Confirm Routing", MessageBoxButtons.OKCancel);

                // Check the user's choice in the dialog
                if (result == DialogResult.OK)
                {
                    // Construct the API URL with the selected destination's IP address and port 8080
                    string apiUrl = $"http://{selectedDestinationItem.IPAddress}:8080/connectTo";
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
                                MessageBox.Show($"Routing '{selectedSourceItem.Name}' to '{selectedDestinationItem.Name}' using url '{apiUrl}' successful!");
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
    }

    // Custom class to represent MDNS items with IP address and name
    public class MdnsItem
    {
        public string IPAddress { get; set; }
        public string Name { get; set; }
    }
}
