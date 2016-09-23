using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string leftside = textBox1.Text.Split('=')[0];
            string rightside = textBox1.Text.Split('=')[1];
            var result1 = dt.Compute(leftside, "");
            var result2 = dt.Compute(rightside, "");
            if (Convert.ToDouble(result1) == Convert.ToDouble(result2))
            {
                //MessageBox.Show(result1.ToString()+" "+ result2.ToString());
                MessageBox.Show("this is correct");
            }
            else
            {
                MessageBox.Show("this is false");
            }

        }
    }
}
