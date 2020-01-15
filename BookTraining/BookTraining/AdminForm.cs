using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookTraining
{
    public partial class AdminForm : Form
    {
        public string username = "";
        public AdminForm()
        {
            InitializeComponent();
        }

        private void TRAINBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRAINBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.train_BookingDataSet);

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'train_BookingDataSet.TRAIN' table. You can move, or remove it, as needed.
            //this.tRAINTableAdapter.Fill(this.train_BookingDataSet.TRAIN);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ADDTrain addtrain = new ADDTrain();
            addtrain.Show();
            addtrain.username = this.username;
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UpdateTrain updatetrain = new UpdateTrain();
            updatetrain.Show();
            updatetrain.username = this.username;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AdminCancel admincancel = new AdminCancel();
            admincancel.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AdminAddTrip addtrip = new AdminAddTrip();
            addtrip.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            UpdateTrip updatetrip = new UpdateTrip();
            updatetrip.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TrainDetails traindetails = new TrainDetails();
            traindetails.Show();
        }
    }
}
