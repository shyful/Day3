using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateInterestApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bankname = comboBox1.Text;
            decimal amount = Convert.ToDecimal(textBox2.Text);
            decimal year = Convert.ToDecimal(textBox1.Text);
            if (bankname=="BRACBank")
            {
              
             
                decimal interest = (amount*6*year)/100;
                string result = Convert.ToString(interest);
                textBox3.Text = result;

            }
            else if(bankname == "DBBLBank")
            {
                
         
                decimal interest = (amount * 7* year) / 100;
                string result = Convert.ToString(interest);
                textBox3.Text = result;

            }
            else if (bankname=="HSBCBank")
            {
               
                decimal interest = (amount*8*year)/100;
                string result = Convert.ToString(interest);
                textBox3.Text = result;

            }





        }
    }
}
