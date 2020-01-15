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
    public partial class signupcustomer : Form
    {
        public signupcustomer()
        {
            InitializeComponent();
        }

        private void CUSTOMERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cUSTOMERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainBookingDataSet);

        }

        private void Signupcustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'train_BookingDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter1.Fill(this.train_BookingDataSet.CUSTOMER);
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;

            
            try
            {
                sqlconnection.Open();
                sqlcommand.CommandText = "insert into CUSTOMER values('"+ c_USERNAMETextBox.Text+"','"+ c_PWTextBox.Text+"',"+ aGETextBox.Text+",'"+ pHONETextBox.Text+"','"+ gENDERTextBox.Text+"')";
                sqlcommand.ExecuteNonQuery();
                sqlcommand.CommandText = "insert into History values('" + c_USERNAMETextBox.Text + "',0,0.0,getdate())";
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("Sign Up Is Completed");
                this.Close();
            }
            catch(Exception)
            {
                
                MessageBox.Show("The User Name is already made befor");
            }
            c_USERNAMETextBox.Clear();
            c_PWTextBox.Clear();
            aGETextBox.Clear();
            pHONETextBox.Clear();
            gENDERTextBox.Clear();
            sqlconnection.Close();
            
        }
    }
}
