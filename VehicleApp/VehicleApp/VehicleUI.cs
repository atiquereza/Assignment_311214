using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleUI : Form
    {
        private Vehicle aVehicle;
        public VehicleUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle=new Vehicle(nameTextBox.Text,regTextBox.Text);
            MessageBox.Show("Vehicle: " + nameTextBox.Text + " created");
            speedTextBox.Text = "";
            minSpeedTextBox.Text = "";
            maxSpeedTextBox.Text = "";
            avgSpeedTextBox.Text = "";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicle.AddSpeed(Convert.ToDouble(speedTextBox.Text));
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVehicle.MinSpeedReturn().ToString();
            maxSpeedTextBox.Text = aVehicle.MaxSpeedReturn().ToString();
            avgSpeedTextBox.Text = aVehicle.AvgSpeed().ToString();
        }
    }
}
