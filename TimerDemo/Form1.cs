using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(lbl_main.Text=="Kamani")
            {
                lbl_main.Text = "Science";
            }
            else
            {
                lbl_main.Text = "Kamani";
                if(lbl_main.BackColor == Color.Yellow)
                {
                    lbl_main.BackColor = Color.Red;
                }
                else
                {
                    lbl_main.BackColor= Color.Yellow;
                }
            }
        }
    }
}
