namespace BD_Switcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sourceListBox = new ListBox();
            destinationListBox = new ListBox();
            routeButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            refreshSourcesButton = new Button();
            refreshDestinationsButton = new Button();
            SuspendLayout();
            // 
            // sourceListBox
            // 
            sourceListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sourceListBox.Enabled = false;
            sourceListBox.FormattingEnabled = true;
            sourceListBox.ItemHeight = 25;
            sourceListBox.Location = new Point(8, 116);
            sourceListBox.Name = "sourceListBox";
            sourceListBox.Size = new Size(300, 404);
            sourceListBox.TabIndex = 0;
            // 
            // destinationListBox
            // 
            destinationListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            destinationListBox.Enabled = false;
            destinationListBox.FormattingEnabled = true;
            destinationListBox.ItemHeight = 25;
            destinationListBox.Location = new Point(368, 116);
            destinationListBox.Name = "destinationListBox";
            destinationListBox.Size = new Size(300, 404);
            destinationListBox.TabIndex = 1;
            // 
            // routeButton
            // 
            routeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            routeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            routeButton.Location = new Point(710, 116);
            routeButton.Name = "routeButton";
            routeButton.Size = new Size(134, 45);
            routeButton.TabIndex = 2;
            routeButton.Text = "ROUTE";
            routeButton.UseVisualStyleBackColor = true;
            routeButton.Click += routeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 3;
            label1.Text = "NDI Sources";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(370, 83);
            label2.Name = "label2";
            label2.Size = new Size(251, 25);
            label2.TabIndex = 4;
            label2.Text = "BirdDog Player Destinations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(252, 54);
            label3.TabIndex = 5;
            label3.Text = "BD Switcher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 32);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 6;
            label4.Text = "by Matt Gray";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(314, 116);
            label5.Name = "label5";
            label5.Size = new Size(47, 32);
            label5.TabIndex = 7;
            label5.Text = "➡️";
            // 
            // refreshSourcesButton
            // 
            refreshSourcesButton.Anchor = AnchorStyles.Bottom;
            refreshSourcesButton.Location = new Point(8, 522);
            refreshSourcesButton.Name = "refreshSourcesButton";
            refreshSourcesButton.Size = new Size(300, 34);
            refreshSourcesButton.TabIndex = 8;
            refreshSourcesButton.Text = "Refresh NDI Sources";
            refreshSourcesButton.UseVisualStyleBackColor = true;
            refreshSourcesButton.Click += refreshSourcesButton_Click;
            // 
            // refreshDestinationsButton
            // 
            refreshDestinationsButton.Anchor = AnchorStyles.Bottom;
            refreshDestinationsButton.Location = new Point(368, 522);
            refreshDestinationsButton.Name = "refreshDestinationsButton";
            refreshDestinationsButton.Size = new Size(300, 34);
            refreshDestinationsButton.TabIndex = 9;
            refreshDestinationsButton.Text = "Refresh BirdDog Destinations";
            refreshDestinationsButton.UseVisualStyleBackColor = true;
            refreshDestinationsButton.Click += refreshDestinationsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 568);
            Controls.Add(refreshDestinationsButton);
            Controls.Add(refreshSourcesButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(routeButton);
            Controls.Add(destinationListBox);
            Controls.Add(sourceListBox);
            MaximumSize = new Size(900, 2000);
            MinimumSize = new Size(900, 300);
            Name = "Form1";
            Text = "BD Switcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox sourceListBox;
        private ListBox destinationListBox;
        private Button routeButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button refreshSourcesButton;
        private Button refreshDestinationsButton;
    }
}
