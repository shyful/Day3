using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetdoubleValueApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Finf_2_Times_Number_Click(object sender, EventArgs e)
        {
            
            decimal inputnumer = Convert.ToDecimal(inputNumber.Text);
            decimal outputnumber = 2*inputnumer;
            outputNumber.Text = outputnumber.ToString();


        }
    }
}
