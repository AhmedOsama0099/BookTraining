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
    public partial class signupadmin : Form
    {
        public signupadmin()
        {
            InitializeComponent();
        }

        private void ADMINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aDMINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trainBookingDataSet);

        }

        private void Signupadmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'train_BookingDataSet.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter1.Fill(this.train_BookingDataSet.ADMIN);
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;


            try
            {
                sqlconnection.Open();
                sqlcommand.CommandText = "insert into ADMIN values('" + uSERNAMETextBox.Text + "','" + aDMIN_PWTextBox.Text + "'," + aGETextBox.Text + ",'" + gENDERTextBox.Text + "','" + pHONETextBox.Text + "'," + sTREET_NUMTextBox.Text + ",'" + cITYTextBox.Text + "')";
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("Sign Up Is Completed");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("The User Name is already made before");
            }
            uSERNAMETextBox.Clear();
            aDMIN_PWTextBox.Clear();
            aGETextBox.Clear();
            gENDERTextBox.Clear();
            pHONETextBox.Clear();
            sTREET_NUMTextBox.Clear();
            cITYTextBox.Clear();
            sqlconnection.Close();
            
        }

        private void USERNAMETextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
