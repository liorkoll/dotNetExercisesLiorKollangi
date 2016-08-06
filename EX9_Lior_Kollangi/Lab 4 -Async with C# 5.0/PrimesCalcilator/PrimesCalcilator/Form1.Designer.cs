namespace PrimesCalcilator
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
            this.StartNumberTextBox = new System.Windows.Forms.TextBox();
            this.EndNumberTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PrimesListBox = new System.Windows.Forms.ListBox();
            this.Cancel1Button = new System.Windows.Forms.Button();
            this.Cancel2Button = new System.Windows.Forms.Button();
            this.StartNumber2TextBox = new System.Windows.Forms.TextBox();
            this.EndNumber2TextBox = new System.Windows.Forms.TextBox();
            this.OutputFileTextBox = new System.Windows.Forms.TextBox();
            this.Calculate2Button = new System.Windows.Forms.Button();
            this.TotalPrimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartNumberTextBox
            // 
            this.StartNumberTextBox.Location = new System.Drawing.Point(13, 26);
            this.StartNumberTextBox.Name = "StartNumberTextBox";
            this.StartNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.StartNumberTextBox.TabIndex = 0;
            // 
            // EndNumberTextBox
            // 
            this.EndNumberTextBox.Location = new System.Drawing.Point(119, 26);
            this.EndNumberTextBox.Name = "EndNumberTextBox";
            this.EndNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.EndNumberTextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 72);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrimesListBox
            // 
            this.PrimesListBox.FormattingEnabled = true;
            this.PrimesListBox.Location = new System.Drawing.Point(22, 127);
            this.PrimesListBox.Name = "PrimesListBox";
            this.PrimesListBox.Size = new System.Drawing.Size(120, 95);
            this.PrimesListBox.TabIndex = 3;
            // 
            // Cancel1Button
            // 
            this.Cancel1Button.Location = new System.Drawing.Point(93, 72);
            this.Cancel1Button.Name = "Cancel1Button";
            this.Cancel1Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel1Button.TabIndex = 4;
            this.Cancel1Button.Text = "Cancel1";
            this.Cancel1Button.UseVisualStyleBackColor = true;
            this.Cancel1Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cancel2Button
            // 
            this.Cancel2Button.Location = new System.Drawing.Point(174, 72);
            this.Cancel2Button.Name = "Cancel2Button";
            this.Cancel2Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel2Button.TabIndex = 5;
            this.Cancel2Button.Text = "Cancel2";
            this.Cancel2Button.UseVisualStyleBackColor = true;
            this.Cancel2Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // StartNumber2TextBox
            // 
            this.StartNumber2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.StartNumber2TextBox.Location = new System.Drawing.Point(22, 245);
            this.StartNumber2TextBox.Name = "StartNumber2TextBox";
            this.StartNumber2TextBox.Size = new System.Drawing.Size(100, 20);
            this.StartNumber2TextBox.TabIndex = 6;
            this.StartNumber2TextBox.Text = "1";
            this.StartNumber2TextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // EndNumber2TextBox
            // 
            this.EndNumber2TextBox.Location = new System.Drawing.Point(128, 245);
            this.EndNumber2TextBox.Name = "EndNumber2TextBox";
            this.EndNumber2TextBox.Size = new System.Drawing.Size(100, 20);
            this.EndNumber2TextBox.TabIndex = 7;
            this.EndNumber2TextBox.Text = "10";
            // 
            // OutputFileTextBox
            // 
            this.OutputFileTextBox.Location = new System.Drawing.Point(234, 245);
            this.OutputFileTextBox.Name = "OutputFileTextBox";
            this.OutputFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputFileTextBox.TabIndex = 8;
            this.OutputFileTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Calculate2Button
            // 
            this.Calculate2Button.Location = new System.Drawing.Point(22, 310);
            this.Calculate2Button.Name = "Calculate2Button";
            this.Calculate2Button.Size = new System.Drawing.Size(75, 23);
            this.Calculate2Button.TabIndex = 9;
            this.Calculate2Button.Text = "Calculate";
            this.Calculate2Button.UseVisualStyleBackColor = true;
            this.Calculate2Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // TotalPrimeLabel
            // 
            this.TotalPrimeLabel.AutoSize = true;
            this.TotalPrimeLabel.Location = new System.Drawing.Point(133, 320);
            this.TotalPrimeLabel.Name = "TotalPrimeLabel";
            this.TotalPrimeLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalPrimeLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 375);
            this.Controls.Add(this.TotalPrimeLabel);
            this.Controls.Add(this.Calculate2Button);
            this.Controls.Add(this.OutputFileTextBox);
            this.Controls.Add(this.EndNumber2TextBox);
            this.Controls.Add(this.StartNumber2TextBox);
            this.Controls.Add(this.Cancel2Button);
            this.Controls.Add(this.Cancel1Button);
            this.Controls.Add(this.PrimesListBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.EndNumberTextBox);
            this.Controls.Add(this.StartNumberTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartNumberTextBox;
        private System.Windows.Forms.TextBox EndNumberTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ListBox PrimesListBox;
        private System.Windows.Forms.Button Cancel1Button;
        private System.Windows.Forms.Button Cancel2Button;
        private System.Windows.Forms.TextBox StartNumber2TextBox;
        private System.Windows.Forms.TextBox EndNumber2TextBox;
        private System.Windows.Forms.TextBox OutputFileTextBox;
        private System.Windows.Forms.Button Calculate2Button;
        private System.Windows.Forms.Label TotalPrimeLabel;
    }
}

