using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1sr_button_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            txt_full.Text = txt_fname.Text +" "+txt_lname.Text;
        }
    }
}
