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
            SuspendLayout();
            // 
            // sourceListBox
            // 
            sourceListBox.FormattingEnabled = true;
            sourceListBox.ItemHeight = 25;
            sourceListBox.Location = new Point(31, 125);
            sourceListBox.Name = "sourceListBox";
            sourceListBox.Size = new Size(250, 554);
            sourceListBox.TabIndex = 0;
            // 
            // destinationListBox
            // 
            destinationListBox.FormattingEnabled = true;
            destinationListBox.ItemHeight = 25;
            destinationListBox.Location = new Point(311, 125);
            destinationListBox.Name = "destinationListBox";
            destinationListBox.Size = new Size(250, 554);
            destinationListBox.TabIndex = 1;
            // 
            // routeButton
            // 
            routeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            routeButton.Location = new Point(623, 282);
            routeButton.Name = "routeButton";
            routeButton.Size = new Size(112, 70);
            routeButton.TabIndex = 2;
            routeButton.Text = "ROUTE";
            routeButton.UseVisualStyleBackColor = true;
            routeButton.Click += routeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 97);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 3;
            label1.Text = "NDI Sources";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 97);
            label2.Name = "label2";
            label2.Size = new Size(251, 25);
            label2.TabIndex = 4;
            label2.Text = "BirdDog Player Destinations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 22);
            label3.Name = "label3";
            label3.Size = new Size(252, 54);
            label3.TabIndex = 5;
            label3.Text = "BD Switcher";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 829);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(routeButton);
            Controls.Add(destinationListBox);
            Controls.Add(sourceListBox);
            Name = "Form1";
            Text = "Form1";
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
    }
}
