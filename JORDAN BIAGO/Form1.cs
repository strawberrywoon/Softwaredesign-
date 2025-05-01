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

namespace JORDAN_BIAGO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button4.Visible = false;
            pictureBox1.Visible = false; // Initially hide pictureBox1
            pictureBox2.Visible = false;
            button5.Visible = false; // Initially hide button5
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Show pictureBox2 and button4
            pictureBox2.Visible = true;
            button4.Visible = true;
            button5.Visible = true; // Show button5

            // Hide all other controls
            foreach (Control control in this.Controls)
            {
                if (control != pictureBox2 && control != button4 && control != button5)
                {
                    control.Visible = false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show pictureBox1 and hide all other PictureBox controls
            pictureBox1.Visible = true;
            button2.Visible = false;
            button4.Visible = true;
            button5.Visible = true; // Show button5
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && pictureBox != pictureBox1)
                {
                    pictureBox.Visible = false;
                }
            }

            // Remove label1, label2, and button1 from the form
            this.Controls.Remove(label1);
            this.Controls.Remove(label2);
            this.Controls.Remove(button1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Restore the initial state
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            // Re-add label1, label2, and button1 to the form
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(button1);

            // Ensure they are visible
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = true;

            // Show button2
            button2.Visible = true;

            // Hide button4 again
            button4.Visible = false;
            button5.Visible = false; // Hide button5 again
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Show the message box
            MessageBox.Show("Thank you for choosing this room.", "Room Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Restore the initial state
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            // Re-add label1, label2, and button1 to the form
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(button1);

            // Ensure they are visible
            label1.Visible = true;
            label2.Visible = true;
            button1.Visible = true;

            // Show button2
            button2.Visible = true;

            // Hide button4 again
            button4.Visible = false;
            this.Close(); // Close the form after showing the message box
        }
    }
}


