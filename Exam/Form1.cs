using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exam
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd; 
        DataTable dt;
        SqlDataAdapter da;
        string a;
        string b;
       
        public Form1()
        {
            if(rdo_bg_red.Checked==true)
            {
                a = "Red";
            }
            else if (rdo_bg_yellow.Checked == true)
            {
                a = "Yellow";

            }
            else if (rdo_bg_blue.Checked == true)
            {
                a = "Blue";
            }

            if (rdo_fc_red.Checked == true)
            {
                b = "Red";
            }
            else if (rdo_fc_yellow.Checked == true)
            {
                b = "Yellow";

            }
            else if (rdo_fc_blue.Checked == true)
            {
               b = "Blue";
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Windows Programming\Exam\ExamDB.mdf;Integrated Security=True");
            conn.Open();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Examtable (name , city , backcolor , forecolor ) values ('"+txt_name.Text+ "' , '" + txt_city.Text+ "' , '"+a+"','"+b+"')", conn);
            cmd.ExecuteNonQuery();
            

        }
    }
}
