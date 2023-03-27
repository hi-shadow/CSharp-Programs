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

namespace CRUD2nd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C# Windows Programming\CRUD2nd\Database2.mdf;Integrated Security=True");
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    label4.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                label4.BackColor = Color.Red;
                MessageBox.Show("Not Connected");
            }
            
         }
        private void btn_save_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into exam (username , password) values ('"+txt_user.Text+"' , '"+txt_pass.Text+"')",con);
            cmd.ExecuteNonQuery();
            txt_pass.Clear();
            txt_user.Clear();
        }

        
    }
}
