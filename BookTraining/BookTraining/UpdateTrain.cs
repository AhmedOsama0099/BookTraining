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
    public partial class UpdateTrain : Form
    {
        public string username = "";
        public UpdateTrain()
        {
            InitializeComponent();
        }

        private void TRAINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRAINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.train_BookingDataSet);

        }

        private void UpdateTrain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'train_BookingDataSet.TRAIN' table. You can move, or remove it, as needed.
            //this.tRAINTableAdapter.Fill(this.train_BookingDataSet.TRAIN);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconnection;
                sqlcommand.CommandText = "UPDATE  TRAIN  SET T_ID = " + textBox1.Text + " ,NUMOFSEATS =" + nUMOFSEATSTextBox.Text + " ,MODEL = '" + mODELTextBox.Text + "',AVILABLESEATS = " + aVILABLESEATSTextBox.Text + ", TRAIN.[TO] = '" + tOTextBox.Text + "',TRAIN.[FROM] = '" + fROMTextBox.Text + "', TRAIN.[DATE&TIME] =  '" + dateTimePicker1.Value + "'  WHERE USERNAME = '" + username + "' and T_ID=" + t_IDTextBox.Text;
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("DONE..!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR..!");
            }

        }
    }
}
