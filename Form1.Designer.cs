using System.ComponentModel;

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
            sourceDataGridView = new DataGridView();
            destinationDataGridView = new DataGridView();
            filterTextBox = new TextBox();
            routeButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            refreshSourcesButton = new Button();
            refreshDestinationsButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            ((ISupportInitialize)sourceDataGridView).BeginInit();
            ((ISupportInitialize)destinationDataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // sourceDataGridView
            // 
            sourceDataGridView.AllowUserToAddRows = false;
            sourceDataGridView.AllowUserToDeleteRows = false;
            sourceDataGridView.AllowUserToResizeRows = false;
            sourceDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sourceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sourceDataGridView.ColumnHeadersHeight = 34;
            sourceDataGridView.Location = new Point(3, 95);
            sourceDataGridView.MultiSelect = false;
            sourceDataGridView.Name = "sourceDataGridView";
            sourceDataGridView.ReadOnly = true;
            sourceDataGridView.RowHeadersWidth = 62;
            sourceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sourceDataGridView.Size = new Size(389, 355);
            sourceDataGridView.TabIndex = 10;
            // 
            // destinationDataGridView
            // 
            destinationDataGridView.AllowUserToAddRows = false;
            destinationDataGridView.AllowUserToDeleteRows = false;
            destinationDataGridView.AllowUserToResizeRows = false;
            destinationDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            destinationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            destinationDataGridView.ColumnHeadersHeight = 34;
            destinationDataGridView.Location = new Point(445, 95);
            destinationDataGridView.MultiSelect = false;
            destinationDataGridView.Name = "destinationDataGridView";
            destinationDataGridView.ReadOnly = true;
            destinationDataGridView.RowHeadersVisible = false;
            destinationDataGridView.RowHeadersWidth = 62;
            destinationDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            destinationDataGridView.Size = new Size(389, 355);
            destinationDataGridView.TabIndex = 11;
            // 
            // filterTextBox
            // 
            filterTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(filterTextBox, 3);
            filterTextBox.Location = new Point(3, 3);
            filterTextBox.MaxLength = 255;
            filterTextBox.Name = "filterTextBox";
            filterTextBox.PlaceholderText = "Filter Source / Destination Names";
            filterTextBox.Size = new Size(831, 31);
            filterTextBox.TabIndex = 12;
            filterTextBox.TextChanged += FilterTextBox_TextChanged;
            // 
            // routeButton
            // 
            routeButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            routeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            routeButton.Location = new Point(860, 52);
            routeButton.Name = "routeButton";
            routeButton.Size = new Size(291, 37);
            routeButton.TabIndex = 2;
            routeButton.Text = "ROUTE";
            routeButton.UseVisualStyleBackColor = true;
            routeButton.Click += routeButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 3;
            label1.Text = "NDI Sources";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 37);
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
            label5.Location = new Point(398, 92);
            label5.Name = "label5";
            label5.Size = new Size(41, 361);
            label5.TabIndex = 7;
            label5.Text = "➡️";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // refreshSourcesButton
            // 
            refreshSourcesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            refreshSourcesButton.Location = new Point(290, 3);
            refreshSourcesButton.Name = "refreshSourcesButton";
            refreshSourcesButton.Size = new Size(96, 31);
            refreshSourcesButton.TabIndex = 8;
            refreshSourcesButton.Text = "Refresh";
            refreshSourcesButton.UseVisualStyleBackColor = true;
            refreshSourcesButton.Click += refreshSourcesButton_Click;
            // 
            // refreshDestinationsButton
            // 
            refreshDestinationsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            refreshDestinationsButton.Location = new Point(286, 3);
            refreshDestinationsButton.Name = "refreshDestinationsButton";
            refreshDestinationsButton.Size = new Size(100, 31);
            refreshDestinationsButton.TabIndex = 9;
            refreshDestinationsButton.Text = "Refresh";
            refreshDestinationsButton.UseVisualStyleBackColor = true;
            refreshDestinationsButton.Click += refreshDestinationsButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 297F));
            tableLayoutPanel1.Controls.Add(filterTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Controls.Add(sourceDataGridView, 0, 3);
            tableLayoutPanel1.Controls.Add(destinationDataGridView, 2, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 2);
            tableLayoutPanel1.Controls.Add(routeButton, 4, 2);
            tableLayoutPanel1.Location = new Point(12, 95);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 361F));
            tableLayoutPanel1.Size = new Size(1154, 437);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.8095245F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.1904755F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(refreshSourcesButton, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 52);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(389, 37);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.11881F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8811874F));
            tableLayoutPanel3.Controls.Add(refreshDestinationsButton, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Location = new Point(445, 52);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(389, 37);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 70);
            label6.Name = "label6";
            label6.Size = new Size(732, 25);
            label6.TabIndex = 14;
            label6.Text = "In most cases, you must be on the same subnet as your NDI devices for this utility to work.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 544);
            Controls.Add(label6);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label3);
            MinimumSize = new Size(1200, 600);
            Name = "Form1";
            Text = "BD Switcher";
            ((ISupportInitialize)sourceDataGridView).EndInit();
            ((ISupportInitialize)destinationDataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView sourceDataGridView;
        private DataGridView destinationDataGridView;
        private TextBox filterTextBox;
        private Button routeButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button refreshSourcesButton;
        private Button refreshDestinationsButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
    }
}
