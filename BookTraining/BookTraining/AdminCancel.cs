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
    public partial class AdminCancel : Form
    {
        public AdminCancel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            try {
                sqlcommand.CommandText = "select price from ticket where T_ID=" + textBox1.Text;
                int price = int.Parse(sqlcommand.ExecuteScalar().ToString());
                sqlcommand.CommandText = "select TRIP_NUM from TICKET where T_ID=" + textBox1.Text;
                int TRIP_NUM = int.Parse(sqlcommand.ExecuteScalar().ToString());
                string quary = "select C_USERNAME from BOOK where TRIP_NUM=" + TRIP_NUM;
                SqlDataAdapter sqlcommand1 = new SqlDataAdapter(quary, sqlconnection);
                DataTable dt = new DataTable();
                sqlcommand1.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string user = (row["C_USERNAME"].ToString());
                    sqlcommand.CommandText = "update HISTORY set BOOKFORTRIP=BOOKFORTRIP-1,TOTALPRICESPEND=TOTALPRICESPEND-" + price + " where C_USERNAME= '" + user + "'";
                    sqlcommand.ExecuteNonQuery();
                }
                sqlcommand.CommandText = "DELETE FROM TRIP WHERE TRIP_NUM IN(SELECT TRIP_NUM FROM TICKET WHERE T_ID = " + textBox1.Text + ")";
                sqlcommand.ExecuteNonQuery();
                sqlcommand.CommandText = "DELETE FROM TRAIN WHERE T_ID = " + textBox1.Text;
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("DONE..!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR..!");

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlconnection;
            try
            {
                sqlcommand.CommandText = "select price from TICKET where TRIP_NUM=" + textBox2.Text;
                int price = int.Parse(sqlcommand.ExecuteScalar().ToString());
                string quary = "select C_USERNAME from BOOK where TRIP_NUM=" + textBox2.Text;
                SqlDataAdapter sqlcommand1 = new SqlDataAdapter(quary, sqlconnection);
                DataTable dt = new DataTable();
                sqlcommand1.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string user = (row["C_USERNAME"].ToString());
                    sqlcommand.CommandText = "update HISTORY set BOOKFORTRIP=BOOKFORTRIP-1,TOTALPRICESPEND=TOTALPRICESPEND-" + price + " where C_USERNAME= '" + user + "'";
                    sqlcommand.ExecuteNonQuery();
                }
                sqlcommand.CommandText = "select train.T_ID from train,trip,ticket where train.T_ID=TICKET.T_ID and ticket.TRIP_NUM=" + textBox2.Text;
                int trainid = int.Parse(sqlcommand.ExecuteScalar().ToString());
                sqlcommand.CommandText = "update train set AVILABLESEATS=NUMOFSEATS where T_ID="+trainid;
                sqlcommand.ExecuteNonQuery();
                sqlcommand.CommandText = "DELETE FROM TRIP  WHERE TRIP_NUM  = " + textBox2.Text;
                sqlcommand.ExecuteNonQuery();
                MessageBox.Show("DONE..!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ERROR..!");
            }
        }
    }
}
