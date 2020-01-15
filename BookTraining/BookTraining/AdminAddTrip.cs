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
    public partial class AdminAddTrip : Form
    {
        public AdminAddTrip()
        {
            InitializeComponent();
        }

        private void TRIPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRIPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Train_Booking_DataSet);

        }

        private void AdminAddTrip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Train_Booking_DataSet.TRIP' table. You can move, or remove it, as needed.
            this.tRIPTableAdapter.Fill(this._Train_Booking_DataSet.TRIP);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();
            string quary = "select * from [TRAIN] where T_ID='" + textBox3.Text + "'";
            SqlDataAdapter sqlcommand1 = new SqlDataAdapter(quary, sqlconnection);
            DataTable datatable = new DataTable();
            sqlcommand1.Fill(datatable);
            quary = "select * from [TRAIN] where [DATE&TIME]>='"+ dateTimePicker1.Value+"' and T_ID="+textBox3.Text;
            sqlcommand1 = new SqlDataAdapter(quary, sqlconnection);
            DataTable datatable1 = new DataTable();
            sqlcommand1.Fill(datatable1);
            if (datatable.Rows.Count !=0&&datatable1.Rows.Count!=0)
            {
                try
                {
                    SqlCommand sqlcommand = new SqlCommand();
                    sqlcommand.Connection = sqlconnection;
                    sqlcommand.CommandText = "select [FROM] from TRAIN where T_ID=" + textBox3.Text;
                    string from = sqlcommand.ExecuteScalar().ToString();
                    sqlcommand.CommandText = "select [to] from TRAIN where T_ID=" + textBox3.Text;
                    string to = sqlcommand.ExecuteScalar().ToString();
                    int x = int.Parse(textBox2.Text);
                    sqlcommand.CommandText = "INSERT INTO  TRIP VALUES(" + tRIP_NUMTextBox.Text + ",'" + from + "','" + to + "','" + dateTimePicker1.Value + "')";
                    sqlcommand.ExecuteNonQuery();

                    sqlcommand.CommandText = "INSERT INTO TICKET VALUES(" + textBox2.Text + "," + tRIP_NUMTextBox.Text + "," + textBox3.Text + "," + tRIP_NUMTextBox.Text + ")";
                    sqlcommand.ExecuteNonQuery();
                    MessageBox.Show("Done!");
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR!");
                }
            }
            else
            {
                MessageBox.Show("the train was not found Or Has the Trip in the same Time");
            }
            
        }
    }
}
