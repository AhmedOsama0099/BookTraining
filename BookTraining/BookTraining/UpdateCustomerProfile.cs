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
    public partial class UpdateCustomerProfile : Form
    {
        public string username="";
        public UpdateCustomerProfile()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();
            string quary = "select*from [Customer] where C_USERNAME='"+c_USERNAMETextBox.Text+"'";
            SqlDataAdapter sqlcommand = new SqlDataAdapter(quary, sqlconnection);
            DataTable datatable = new DataTable();
            sqlcommand.Fill(datatable);
            if (datatable.Rows.Count == 0)//to make sure that name wasn't entered befor
            {
                try
                {
                    SqlCommand sqlcommand1 = new SqlCommand();
                    sqlcommand1.Connection = sqlconnection;
                    sqlcommand1.CommandText = "update [CUSTOMER]  set [C_USERNAME]='" + c_USERNAMETextBox.Text + "', [C_PW]='" + c_PWTextBox.Text + "',[AGE]=" + aGETextBox.Text + ",[PHONE]='" + pHONETextBox.Text + "',[GENDER]='" + gENDERTextBox.Text + "' where  [C_USERNAME]='" + username + "'";
                    sqlcommand1.ExecuteNonQuery();
                    username = c_USERNAMETextBox.Text;
                    MessageBox.Show("DONE!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR!");
                }
            }
            else
            {
                MessageBox.Show("THIS USER NAME WAS TAKEN BEFOR");
            }
        }
    }
}
