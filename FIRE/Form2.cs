using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FIRE
{

    public partial class AddressIpInputForm : Form
    {
        private string IpUserInput;
        public AddressIpInputForm()
        {
            InitializeComponent();
        }

        private void AddressUserInput_Click(object sender, EventArgs e)
        {
            IpUserInput = AddressTextBox.Text;
            this.Close();

        }
        public string GetIpUserInput()
        {
            return IpUserInput;
        }

    }
}
