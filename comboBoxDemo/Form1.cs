using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comboBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cmb_city.Items.Add(txt_city.Text);
            txt_city.Clear();
            txt_city.Focus();
        }

       
        private void btn_remove_Click_1(object sender, EventArgs e)
        {
            cmb_city.Items.Remove(txt_city.Text);
            txt_city.Clear();
            txt_city.Focus();
        }
    }
}
