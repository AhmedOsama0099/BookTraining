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
    public partial class ADDTrain : Form
    {
        public string username = "";
        public ADDTrain()
        {
            InitializeComponent();
        }

        private void ADDTrain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'train_BookingDataSet.TRAIN' table. You can move, or remove it, as needed.
           // this.tRAINTableAdapter.Fill(this.train_BookingDataSet.TRAIN);
            // TODO: This line of code loads data into the 'train_BookingDataSet.TRAIN' table. You can move, or remove it, as needed.
            //this.tRAINTableAdapter.Fill(this.train_BookingDataSet.TRAIN);

        }

        private void TRAINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRAINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.train_BookingDataSet);

        }

        private void TRAINBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tRAINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.train_BookingDataSet);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            try
            {
                sqlcommand.CommandText = "insert into TRAIN values(" + t_IDTextBox.Text + ",'" + username + "'," + nUMOFSEATSTextBox.Text + ",'" + mODELTextBox.Text + "'," + aVILABLESEATSTextBox.Text + ",'" + tOTextBox.Text + "','" + fROMTextBox.Text + "','" + dateTimePicker1.Value + "')";
                sqlcommand.ExecuteNonQuery();
               
                MessageBox.Show("DONE..!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR..!");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
