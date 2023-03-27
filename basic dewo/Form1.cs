using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_dewo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_full_Enter(object sender, EventArgs e)
        {
            txt_full.Text = txt_fname.Text + " " + txt_mname.Text + " " + txt_lname.Text;
        }
    }
}
