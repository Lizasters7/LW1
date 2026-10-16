using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var res = Calculator.Evaluate(textBox1.Text);
                if (res is bool b)
                {
                    label1.Text = b ? "True" : "False";
                }
                else
                {
                    label1.Text = res.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "The mistake in the expression");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
