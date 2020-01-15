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
    public partial class TripsLists : Form
    {
        public string to_="";
        public string from_ = "";
        public string username = "";
        public TripsLists()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedtime = listBox1.SelectedItem.ToString();


                SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
                sqlconnection.Open();
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconnection;
                try
                {
                    sqlcommand.CommandText = "select TRIP_NUM from TRIP where [TO]='" + to_ + "' and [from]='" + from_ + "' and [DATE&TIME]='" + selectedtime + "'";
                    int TRIP_NUM = int.Parse(sqlcommand.ExecuteScalar().ToString());
                    sqlcommand.CommandText = "select TICKET.PRICE from TICKET,TRIP where TRIP.TRIP_NUM=TICKET.TRIP_NUM and TRIP.TRIP_NUM=" + TRIP_NUM + "";

                    float PRICE = float.Parse(sqlcommand.ExecuteScalar().ToString());
                    sqlcommand.CommandText = "select TICKET.TICKET_ID from TICKET,TRIP where TRIP.TRIP_NUM=TICKET.TRIP_NUM and TRIP.TRIP_NUM=" + TRIP_NUM + "";
                    int TICKETID = int.Parse(sqlcommand.ExecuteScalar().ToString());
                    sqlcommand.CommandText = "select T_ID from TICKET where TICKET_ID=" + TICKETID + "";
                    int TRAINID = int.Parse(sqlcommand.ExecuteScalar().ToString());
                    sqlcommand.CommandText = "select AVILABLESEATS from train where T_ID=" + TRAINID;
                    int freeseat = int.Parse(sqlcommand.ExecuteScalar().ToString());
                    if (freeseat > 0)
                    {
                        try
                        {
                            sqlcommand.CommandText = "insert into BOOK values(" + TRIP_NUM + ",'" + username + "'," + TICKETID + ")";
                            sqlcommand.ExecuteNonQuery();
                            sqlcommand.CommandText = "update HISTORY set BOOKFORTRIP=BOOKFORTRIP+1,TOTALPRICESPEND=TOTALPRICESPEND+" + PRICE + " where C_USERNAME='" + username + "'";
                            sqlcommand.ExecuteNonQuery();

                            sqlcommand.CommandText = "update TRAIN set AVILABLESEATS=AVILABLESEATS-1 where T_ID=" + freeseat + " ";
                            sqlcommand.ExecuteNonQuery();
                            MessageBox.Show("DONE!");
                            this.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error U BOKED BEFOR TO  THIS TRIP..!");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR..!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thier Is No Selected Element");
            }

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();
            listBox1.Items.Clear();
                
            string quary = "select TRIP.[DATE&TIME] from TRIP,TICKET,TRAIN where TRIP.[TO]='" + to_ + "'and TRIP.[FROM]='" + from_ + "' and TRIP.TRIP_NUM=TICKET.TRIP_NUM and TICKET.T_ID=TRAIN.T_ID and AVILABLESEATS>0";
            SqlDataAdapter sqlcommand = new SqlDataAdapter(quary, sqlconnection);
            DataTable dt = new DataTable();
            sqlcommand.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                listBox1.Items.Add(row["DATE&TIME"].ToString());
            }
        }
    }
}
