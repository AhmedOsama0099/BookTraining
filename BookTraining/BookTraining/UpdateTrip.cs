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
    public partial class UpdateTrip : Form
    {
        public UpdateTrip()
        {
            InitializeComponent();
        }

        private void TRIPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRIPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Train_Booking_DataSet);

        }

        private void UpdateTrip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Train_Booking_DataSet.TRIP' table. You can move, or remove it, as needed.
            this.tRIPTableAdapter.Fill(this._Train_Booking_DataSet.TRIP);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();
            try
            {
                string quary = "select *from TRIP where TRIP_NUM="+ tRIP_NUMTextBox.Text;
                SqlDataAdapter sqlcommand1 = new SqlDataAdapter(quary, sqlconnection);
                DataTable datatable = new DataTable();
                sqlcommand1.Fill(datatable);
                if (datatable.Rows.Count == 1)
                {
                    
                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlcommand.CommandText = "update trip set Trip_NUM=" + textBox1.Text + " ,[DATE&TIME]='" + dateTimePicker1.Value + "' where TRIP_NUM=" + tRIP_NUMTextBox.Text;
                    sqlcommand.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("this old trip num wasn't found..!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!");
            }

        }
    }
}
