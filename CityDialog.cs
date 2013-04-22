using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelingSalesman
{
    public partial class CityDialog : Form
    {
        public string result
        {
            get
            {
                return cityNameTextBox.Text;
            }
        }

        public CityDialog(string windowName, string labelText, string buttonText)
        {
            InitializeComponent();

            this.Text = windowName;
            label1.Text = labelText;

            button1.Text = buttonText;

            this.ShowDialog();
        }

        private void addCityButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
