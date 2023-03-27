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
namespace CRUD
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="E:\C# Windows Programming\CRUD\Database1.mdf";Integrated Security=True
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\C# Windows Programming\CRUD\Database1.mdf';Integrated Security=True");
                conn.Open();
                if(conn.State == ConnectionState.Open)
                {
                    label1.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                label1.BackColor = Color.Red;
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from users where id = '" + txt_id.Text + "' ", conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_uname.Text = dt.Rows[0][1].ToString();
                txt_pass.Text = dt.Rows[0]["password"].ToString();

            }
            else
            {
                MessageBox.Show("No Data Found For Id =" + txt_id.Text);
                txt_id.Text = " ";
                txt_uname.Text = " ";
                txt_pass.Text = " ";

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cmd= new SqlCommand ("insert into users(username , password) values ('"+txt_uname.Text+ "' , '" + txt_pass.Text + "')", conn);
            cmd.ExecuteNonQuery();
            txt_pass.Clear();
            txt_uname.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update users set username = '" + txt_uname.Text + "' , password = '" + txt_pass.Text + "' where Id = "+txt_id.Text+"", conn);
            cmd.ExecuteNonQuery ();
            MessageBox.Show("Updated");


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
             cmd = new SqlCommand("delete from users where id = '" + txt_id.Text + "' ", conn);
          
            cmd.ExecuteNonQuery () ;
            txt_id.Clear();
            MessageBox.Show("Deleted");
        }
    }
}
