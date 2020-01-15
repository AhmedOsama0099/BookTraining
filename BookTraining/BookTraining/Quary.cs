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
    public partial class Quary : Form
    {
        public Quary()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-UFFDEKU\SQLEXPRESS;Initial Catalog=_Train_Booking_;Integrated Security=True");
            sqlconnection.Open();
            string quary = "SELECT [ADMIN].USERNAME , T_ID FROM TRAIN INNER JOIN [ADMIN] ON TRAIN.USERNAME = ADMIN.USERNAME";
            SqlDataAdapter sqlcommand = new SqlDataAdapter(quary, sqlconnection);
            DataTable dt = new DataTable();
            sqlcommand.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
