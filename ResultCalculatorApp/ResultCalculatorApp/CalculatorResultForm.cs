using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultCalculatorApp
{
    public partial class CalculateResultUI : Form
    {
        public CalculateResultUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Result calcResult=new Result();
            try
            {
                double avg;
                avg=calcResult.GetAverageResult(Convert.ToDouble(physicsTextBox.Text), Convert.ToDouble(chemistryTextBox.Text), Convert.ToDouble(mathTextBox.Text));
                gradeTextBox.Text = calcResult.GetGrade(avg);
                averageTextBox.Text = avg.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+""+ex.InnerException);
                physicsTextBox.Text = "";
                chemistryTextBox.Text = "";
                mathTextBox.Text = "";
            }
        }
    }
}
