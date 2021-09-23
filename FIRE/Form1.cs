using FIRE.FIRE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIRE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string UserInput = inputBox.Text; //User Input from the inputBox
            FireOutput Fire = new FireOutput(UserInput); // Sends it to the FireOutput Class
            string Result = Fire.GetOutput(); // Takes the result from FireOutput
            inputBox.Clear();
            outputBox.Items.Add("User:");    // 
            outputBox.Items.Add(UserInput); // Adds to the listbox the user input
            outputBox.Items.Add("Fire " );
            outputBox.Items.Add(Result); // Adds the result from FireOutput
            
        }

        
    }
}
