using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueSwap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_1st_Enter(object sender, EventArgs e)
        {
            txt_1st.Text = "Welcome";
            txt_2nd.Text = " Bye ";
        }

        private void txt_2nd_Enter(object sender, EventArgs e)
        {
            txt_1st.Text = "Bye";
            txt_2nd.Text = " Welcome ";
        }
    }
}
