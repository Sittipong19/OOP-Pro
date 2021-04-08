using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            beveragesControl11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuControl11.BringToFront();
        }
    }
}
