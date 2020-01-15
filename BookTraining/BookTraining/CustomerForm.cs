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
    
    public partial class CustomerForm : Form
    {
        public string username = "";
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();
            string quary = "select [FROM],[TO],TRIP_NUM from TRIP where [From]= '"+textBox1.Text+"' and [TO]= '"+textBox2.Text+"' and [DATE&TIME]='"+dateTimePicker1.Value+"'";       
            SqlDataAdapter sqlcommand = new SqlDataAdapter(quary, sqlconnection);
            DataTable datatable = new DataTable();
            sqlcommand.Fill(datatable);
            quary = "select train.AVILABLESEATS from train where T_ID in(select T_ID from ticket,trip where trip.TRIP_NUM=ticket.TRIP_NUM and TRIP.[TO]='" + textBox2.Text + "' and TRIP.[FROM]='" + textBox1.Text + "' and TRIP.[DATE&TIME]='" + dateTimePicker1.Value + "')";
            SqlCommand sqlCommand3 = new SqlCommand();
            sqlCommand3.CommandText = quary;
            sqlCommand3.Connection = sqlconnection;
            int avilabeseate = 0;
            try
            {
                 avilabeseate = int.Parse(sqlCommand3.ExecuteScalar().ToString());
            }
            catch(Exception)
            {
                avilabeseate = 0;
            }
            if (datatable.Rows.Count != 0 && avilabeseate > 0)
            {

                SqlCommand sqlcommand1 = new SqlCommand();
                sqlcommand1.Connection = sqlconnection;
                sqlcommand1.CommandText = "select TRIP.TRIP_NUM from TRIP where[From]= '" + textBox1.Text + "' and [TO]= '" + textBox2.Text + "' and [DATE&TIME]= '" + dateTimePicker1.Value + "'";
               
                int TRIP_NUM =int.Parse( sqlcommand1.ExecuteScalar().ToString());
                
               sqlcommand1.CommandText = "select TICKET.PRICE from TICKET,TRIP where TRIP.TRIP_NUM=TICKET.TRIP_NUM and TRIP.TRIP_NUM="+ TRIP_NUM + "";

                float PRICE = float.Parse(sqlcommand1.ExecuteScalar().ToString());
                sqlcommand1.CommandText = "select TICKET.TICKET_ID from TICKET,TRIP where TRIP.TRIP_NUM=TICKET.TRIP_NUM and TRIP.TRIP_NUM=" + TRIP_NUM + "";
                int TICKETID = int.Parse(sqlcommand1.ExecuteScalar().ToString());
                sqlcommand1.CommandText = "select T_ID from TICKET where TICKET_ID="+TICKETID+"";
                int TRAINID = int.Parse(sqlcommand1.ExecuteScalar().ToString());
               // sqlcommand1.CommandText = "select AVILABLESEATS from train where T_ID=" + TRAINID;
                try
                {
                    sqlcommand1.CommandText = "insert into BOOK values(" + TRIP_NUM + ",'" + username + "',"+ avilabeseate + ")";
                    sqlcommand1.ExecuteNonQuery();
                    sqlcommand1.CommandText = "update HISTORY set BOOKFORTRIP=BOOKFORTRIP+1,TOTALPRICESPEND=TOTALPRICESPEND+" + PRICE + " where C_USERNAME='" + username + "'";
                    sqlcommand1.ExecuteNonQuery();

                    sqlcommand1.CommandText = "update TRAIN set AVILABLESEATS=AVILABLESEATS-1 where T_ID="+TRAINID+" ";
                    sqlcommand1.ExecuteNonQuery();
                    MessageBox.Show("DONE!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error U BOKED BEFOR TO  THIS TRIP..!");
                }
           
            }
            else
            {
                

                MessageBox.Show("Ur trip is Not Found To See thie time of this trip press OK!");
                TripsLists trips = new TripsLists();
                trips.to_ = textBox2.Text;
                
                trips.from_ = textBox1.Text;
                trips.username = this.username;
                trips.Show();

            }
            sqlconnection.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();

            try
            {

                DataTable datatable = new DataTable();
                string quary = "select *from BOOK where C_USERNAME='" + username + "' and TRIP_NUM=" + textBox3.Text + "";
                SqlDataAdapter sqlcommand = new SqlDataAdapter(quary, sqlconnection);

                sqlcommand.Fill(datatable);
                if (datatable.Rows.Count != 0)
                {

                    SqlCommand sqlcommand1 = new SqlCommand();
                    sqlcommand1.Connection = sqlconnection;

                    sqlcommand1.CommandText = "select TICKET_ID_ from BOOK where C_USERNAME='" + username + "' and TRIP_NUM=" + textBox3.Text + "";

                    int TicketId = int.Parse(sqlcommand1.ExecuteScalar().ToString());
                    sqlcommand1.CommandText = "delete from book where TRIP_NUM=" + textBox3.Text + " and C_USERNAME= '" + username + "' and TICKET_ID_=" + TicketId + "";
                    sqlcommand1.ExecuteNonQuery();
                    sqlcommand1.CommandText = "select T_ID from TICKET where TICKET_ID=" + textBox3.Text;
                    sqlcommand1.CommandText = "update TRAIN set AVILABLESEATS=AVILABLESEATS+1 where T_ID =" + sqlcommand1.ExecuteScalar().ToString() + "";
                    sqlcommand1.ExecuteNonQuery();
                    sqlcommand1.CommandText = "select PRICE from TICKET where TICKET_ID=" + textBox3.Text + "";
                    int ticketprice = int.Parse(sqlcommand1.ExecuteScalar().ToString());
                    sqlcommand1.CommandText = "update HISTORY set TOTALPRICESPEND=TOTALPRICESPEND- " + ticketprice + " ,BOOKFORTRIP=BOOKFORTRIP-1 where C_USERNAME='" + username + "'";
                    sqlcommand1.ExecuteNonQuery();
                    MessageBox.Show("DONE!");
                }
                else
                {
                    MessageBox.Show("U didn't book this trip..!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You Should put a num");
            }


            

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UpdateCustomerProfile updatecustomerform = new UpdateCustomerProfile();
            updatecustomerform.username = this.username;
            updatecustomerform.Show(); 

        }
    }
}
