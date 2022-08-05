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

namespace phoneContact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string conString =
            "server name...;" +
            "database name...;" + 
            "Trusted_Connection = True;";

        SqlConnection connect = new SqlConnection(conString);

        private void getData()
        {
            connect.Open();

            string reg = "SELECT * from tblUsers"; 

            SqlCommand command = new SqlCommand(reg, connect);

            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void srch_btn_Click(object sender, EventArgs e)
        {
            connect.Open();
            string reg = "SELECT * from tblUsers where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(reg, connect);
            command.Parameters.AddWithValue("@PersonID", search_lbl.Text);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string reg = 
                "Update tblUsers Set FirstName=@FirstName," +
                "LastName=@LastName," +
                "Phone=@Phone Where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(reg, connect);
            command.Parameters.AddWithValue("@PersonID", Convert.ToInt32(id_lbl.Text));
            command.Parameters.AddWithValue("@FirstName", name_lbl.Text);
            command.Parameters.AddWithValue("@LastName", last_lbl.Text);
            command.Parameters.AddWithValue("@Phone", phone_lbl.Text);

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            getData();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string reg = "Insert into tblUsers " +
                "(FirstName,LastName,Phone) values " +
                "(@FirstName,@LastName,@Phone)";
            SqlCommand command = new SqlCommand(reg, connect);
            command.Parameters.AddWithValue("@FirstName", name_lbl.Text);
            command.Parameters.AddWithValue("@LastName", last_lbl.Text);
            command.Parameters.AddWithValue("@Phone", phone_lbl.Text);

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            getData();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            string reg = "Delete From tblUsers Where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(reg, connect);
            command.Parameters.AddWithValue("@PersonID", Convert.ToInt32(id_lbl.Text));

            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
            getData();
        }
    }
}