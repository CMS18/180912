namespace HelloWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddAgeButton = new System.Windows.Forms.Button();
            this.AvarageAgeLabel = new System.Windows.Forms.Label();
            this.AgeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(38, 55);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(434, 31);
            this.AgeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ange ålder:";
            // 
            // AddAgeButton
            // 
            this.AddAgeButton.Location = new System.Drawing.Point(38, 93);
            this.AddAgeButton.Name = "AddAgeButton";
            this.AddAgeButton.Size = new System.Drawing.Size(182, 52);
            this.AddAgeButton.TabIndex = 2;
            this.AddAgeButton.Text = "Lägg till";
            this.AddAgeButton.UseVisualStyleBackColor = true;
            this.AddAgeButton.Click += new System.EventHandler(this.AddAgeButton_Click);
            // 
            // AvarageAgeLabel
            // 
            this.AvarageAgeLabel.AutoSize = true;
            this.AvarageAgeLabel.Location = new System.Drawing.Point(43, 173);
            this.AvarageAgeLabel.Name = "AvarageAgeLabel";
            this.AvarageAgeLabel.Size = new System.Drawing.Size(173, 25);
            this.AvarageAgeLabel.TabIndex = 3;
            this.AvarageAgeLabel.Text = "Medelvärde: ???";
            // 
            // AgeListBox
            // 
            this.AgeListBox.FormattingEnabled = true;
            this.AgeListBox.ItemHeight = 25;
            this.AgeListBox.Location = new System.Drawing.Point(563, 55);
            this.AgeListBox.Name = "AgeListBox";
            this.AgeListBox.Size = new System.Drawing.Size(286, 354);
            this.AgeListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.AgeListBox);
            this.Controls.Add(this.AvarageAgeLabel);
            this.Controls.Add(this.AddAgeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeTextBox);
            this.Name = "Form1";
            this.Text = "Hej WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAgeButton;
        private System.Windows.Forms.Label AvarageAgeLabel;
        private System.Windows.Forms.ListBox AgeListBox;
    }
}

