using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class RefrigeratorUI : Form
    {
        private Refrigerator aRefrigerator;
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator=new Refrigerator(Convert.ToDouble(capacityTextBox.Text));
            itemNoTextBox.Text = "";
            itemWeightTextBox.Text = "";
            currentWeightTextBox.Text = "0";
            remainingTextBox.Text = capacityTextBox.Text;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {

                
                aRefrigerator.Addweight(Convert.ToDouble(itemNoTextBox.Text)*Convert.ToDouble(itemWeightTextBox.Text));
                currentWeightTextBox.Text = aRefrigerator.CurrentCapacity.ToString();
                remainingTextBox.Text = (aRefrigerator.FullCapacity - aRefrigerator.CurrentCapacity).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
