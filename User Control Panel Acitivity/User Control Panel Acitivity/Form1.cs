using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control_Panel_Acitivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string InPutWan
        {
            set
            { 
                textBox1.Text = value;
            }
        }
        public string InPutToo
        {
            set
            {
                textBox2.Text = value;
            }
        }

        private void palButt1_Click(object sender, EventArgs e)
        {
            panel11.Show();
            panel11.BringToFront();

            panel21.Hide();
        }

        private void palButt2_Click(object sender, EventArgs e)
        {
            panel21.Show();
            panel21.BringToFront();

            panel11.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel11.Show();
            panel11.BringToFront();

            panel21.Hide();
        }
    }
}
