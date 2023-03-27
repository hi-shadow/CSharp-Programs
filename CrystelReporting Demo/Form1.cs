using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CrystelReporting_Demo
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=E:\C# Windows Programming\CrystelReporting Demo\CrystelReportingDemo.mdb");
            con.Open();
            try
            {
                if (con.State == ConnectionState.Open)
                {

                    label1.BackColor = Color.Green;
                }
            }

            catch (Exception ex)
            {
                label1.BackColor = Color.Red;
            }
        
}

private void btn_save_Click(object sender, EventArgs e)
        {

        }

    
    }
}
