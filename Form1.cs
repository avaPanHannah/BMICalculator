using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI計算機NEWNEWNEW
{
    public partial class BMI計算機 : Form
    {
        public BMI計算機()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void grpOutput_Enter(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string strHeight = txtHeight.Text;
            string strWeight = txtWeight.Text;

            double height = Convert.ToDouble(strHeight);
            double weight = Convert.ToDouble(strWeight) / 100;

            double bmi = weight / (height * height);

            string strResult = "";
            if (bmi < 16.5)
            {
                strResult = "過輕";
            }
            else if (bmi < 20 && bmi > 16.5)
            {
                strResult = "適中";
            }
            else
            {
                strResult = "過重";

            }
        }
    }
}
