using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookTraining
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=Train_Booking;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;

            sqlconnection.Open();
            sqlcommand.CommandText = "select *from select *from CUSTOMER";
            sqlconnection.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            signupcustomer form2 = new signupcustomer();
            form2.Show();
        
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            signupadmin form3 = new signupadmin();
            form3.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.Show();
            this.WindowState = FormWindowState.Minimized;

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            
            Report report = new Report();
            report.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Quary quary = new Quary();
            quary.Show();
        }
    }
}
