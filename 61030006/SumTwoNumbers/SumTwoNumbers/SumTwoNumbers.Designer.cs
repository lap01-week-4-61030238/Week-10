namespace SumTwoNumbers
{
    partial class SumTwoNumbers
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
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Location = new System.Drawing.Point(149, 93);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(89, 17);
            this.firstNumberLabel.TabIndex = 0;
            this.firstNumberLabel.Text = "First Number";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Location = new System.Drawing.Point(149, 140);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(110, 17);
            this.secondNumberLabel.TabIndex = 1;
            this.secondNumberLabel.Text = "Second Number";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(337, 93);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.firstNumberTextBox.TabIndex = 2;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(337, 140);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.secondNumberTextBox.TabIndex = 3;
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(223, 182);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(44, 17);
            this.sumLabel.TabIndex = 4;
            this.sumLabel.Text = "Sum :";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(226, 212);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(147, 39);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Sum";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // SumTwoNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.secondNumberLabel);
            this.Controls.Add(this.firstNumberLabel);
            this.Name = "SumTwoNumbers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

