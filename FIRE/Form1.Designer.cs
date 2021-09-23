
namespace FIRE
{
    partial class Main
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
            this.outputBox = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.ItemHeight = 25;
            this.outputBox.Location = new System.Drawing.Point(12, 13);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(776, 354);
            this.outputBox.TabIndex = 0;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(13, 374);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(482, 31);
            this.inputBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(501, 374);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(112, 34);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.outputBox);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button sendButton;
    }
}

