
namespace FIRE
{
    partial class AddressIpInputForm
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
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressUserInput = new System.Windows.Forms.Button();
            this.AddressUserInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(12, 137);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(368, 31);
            this.AddressTextBox.TabIndex = 0;
            // 
            // AddressUserInput
            // 
            this.AddressUserInput.Location = new System.Drawing.Point(386, 137);
            this.AddressUserInput.Name = "AddressUserInput";
            this.AddressUserInput.Size = new System.Drawing.Size(145, 31);
            this.AddressUserInput.TabIndex = 1;
            this.AddressUserInput.Text = "Search";
            this.AddressUserInput.UseVisualStyleBackColor = true;
            this.AddressUserInput.Click += new System.EventHandler(this.AddressUserInput_Click);
            // 
            // AddressUserInputLabel
            // 
            this.AddressUserInputLabel.AutoSize = true;
            this.AddressUserInputLabel.Location = new System.Drawing.Point(12, 93);
            this.AddressUserInputLabel.Name = "AddressUserInputLabel";
            this.AddressUserInputLabel.Size = new System.Drawing.Size(245, 25);
            this.AddressUserInputLabel.TabIndex = 2;
            this.AddressUserInputLabel.Text = "Enter IP Address or Webpage";
            // 
            // AddressIpInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 288);
            this.Controls.Add(this.AddressUserInputLabel);
            this.Controls.Add(this.AddressUserInput);
            this.Controls.Add(this.AddressTextBox);
            this.Name = "AddressIpInputForm";
            this.Text = "IP Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Button AddressUserInput;
        private System.Windows.Forms.Label AddressUserInputLabel;
    }
}