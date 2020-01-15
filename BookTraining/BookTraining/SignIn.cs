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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            string quary = "select*from [ADMIN] where USERNAME='"+textBox1.Text+"'and ADMIN_PW='"+textBox2.Text+"'";
            SqlDataAdapter sqlcommand = new SqlDataAdapter(quary, sqlconnection);
            DataTable datatable = new DataTable();
            sqlcommand.Fill(datatable);
            if (datatable.Rows.Count == 1)
            {
                AdminForm adminform = new AdminForm();
                adminform.Show();
                adminform.username = textBox1.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Check your username and password..!");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            string quary = "select*from [Customer] where C_USERNAME='" + textBox1.Text + "'and C_PW='" + textBox2.Text + "'";
            SqlDataAdapter sqlcommand = new SqlDataAdapter(quary, sqlconnection);
            DataTable datatable = new DataTable();
            sqlcommand.Fill(datatable);
            if (datatable.Rows.Count == 1)
            {
                CustomerForm customerform = new CustomerForm();
                customerform.username = textBox1.Text;
                customerform.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Check your username and password..!");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
