using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSQL
{
    public partial class V_info : Form
    {
        public V_info()
        {
            InitializeComponent();

            type_comboBox.Items.Add("Motorbike");
            type_comboBox.Items.Add("SUV/Van");
            type_comboBox.Items.Add("Sedan");
        }

        private void ok_button_Click(object sender, EventArgs e)
        {

        }

        private void brand_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_comboBox.SelectedItem == "Motorbike")
            {
                brand_comboBox.Items.Clear(); // Clear existing items
                brand_comboBox.Items.Add("Brand A");
                brand_comboBox.Items.Add("Brand B");
                brand_comboBox.Items.Add("Brand C");
                brand_comboBox.Items.Add("Brand D");
                brand_comboBox.Items.Add("Brand E");
            }
            else if (type_comboBox.SelectedItem == "SUV/Van")
            {
                brand_comboBox.Items.Clear(); // Clear existing items
                brand_comboBox.Items.Add("Brand X");
                brand_comboBox.Items.Add("Brand Y");
                brand_comboBox.Items.Add("Brand Z");
                // Add more brands for SUV/Van as needed
            }
            else if (type_comboBox.SelectedItem == "Sedan")
            {
                brand_comboBox.Items.Clear(); // Clear existing items
                brand_comboBox.Items.Add("Brand 1");
                brand_comboBox.Items.Add("Brand 2");
                brand_comboBox.Items.Add("Brand 3");
                // Add more brands for Sedan as needed
            }
        }

    }
}
