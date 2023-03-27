using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            i = i+ timer1.Interval;
            if (i == 1000)
            {
                lbl_main.Text = "Science";
                lbl_main.BackColor = Color.Red;
            }
            else if (i == 2000)
            {
                lbl_main.Text = "Kamani";
                lbl_main.BackColor = Color.Gray;

            }
            else
            {
                i = 0;
            }
        }
    }
}
