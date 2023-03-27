using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            txt_ans.Text = ((Int32.Parse(txt_x.Text)) + (Int32.Parse(txt_y.Text))).ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            txt_ans.Text = ((Int32.Parse(txt_x.Text)) - (Int32.Parse(txt_y.Text))).ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            txt_ans.Text = ((Int32.Parse(txt_x.Text)) * (Int32.Parse(txt_y.Text))).ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            txt_ans.Text = ((Int32.Parse(txt_x.Text)) % (Int32.Parse(txt_y.Text))).ToString();
        }

        private void btn_odd_even_Click(object sender, EventArgs e)
        {
            if((Int32.Parse(txt_x.Text)%2==0) && (Int32.Parse(txt_y.Text) % 2 == 0))
            {
                txt_ans.Text = " X is Even number , Y is Even Number ";
            }
            else if((Int32.Parse(txt_x.Text)% 2 == 1 )&& (Int32.Parse(txt_y.Text) % 2 == 1))
                    {
                txt_ans.Text = " X is Odd number , Y is Odd Number ";
            }
            else if ((Int32.Parse(txt_x.Text)% 2 == 0 )&& (Int32.Parse(txt_y.Text) % 2 == 1))
            {
                txt_ans.Text = " X is Even number , Y is Odd Number ";
            }
            else if ((Int32.Parse(txt_x.Text)% 2 == 1 ) && (Int32.Parse(txt_y.Text) % 2 == 0))
            {
                txt_ans.Text = " X is Odd number , Y is Even Number ";
            }
            else
            {
                txt_ans.Text = "hahaha";
            }
        }

        private void btn_min_max_Click(object sender, EventArgs e)
        {
            if ((Int32.Parse(txt_x.Text)) > (Int32.Parse(txt_y.Text)))
            {
                txt_ans.Text = " X is Max " + txt_x.Text + " And Y is Min " + txt_y.Text;
            }
            else if ((Int32.Parse(txt_x.Text)) < (Int32.Parse(txt_y.Text)))
            {
                txt_ans.Text = " X is Min " + txt_x.Text + " And Y is Max " + txt_y.Text;
            }
            else
            {
                txt_ans.Text = "Both Are Same";
            }
        }

        private void btn_swap_Click(object sender, EventArgs e)
        {
            //int temp = (Int32.Parse(txt_x.Text));
            // int x = (Int32.Parse(txt_y.Text));
            // int y = temp;
            txt_ans.Text = "X is  : " + txt_y.Text + "          Y is : " + txt_x.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_x.Clear();
            txt_y.Clear();
            txt_ans.Clear();
        }
    }
}

