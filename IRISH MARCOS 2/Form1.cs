using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IRISH_MARCOS_2
{
    public partial class Musiczz : Form
    {
        public Musiczz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            double result = n1 * 0.99;
            label4.Text = "The total download: " + result.ToString("F2") + " $";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Assuming the intent is to close the form
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
