using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIztBox_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_city_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0 ; i < first_left.Items.Count; i++)
            {
                if(first_left[i].ToString == txt_city.Text)
                {
                    cnt = 1;
                    MessageBox.Show("Already Exists");
                }
                if(cnt==0)
                {
                    first_left.Items.Add(txt_city.Text);txt_city.Clear();
                    txt_city.Focus();

                }

            }
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<first_left.Items.Count; i++)
            {
                second_right.Items.Add(first_left.Items[i].ToString());
                //second_right.Items.Add(s);

            }
        }
    }
}
