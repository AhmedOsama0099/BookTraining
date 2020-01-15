namespace BookTraining
{
    partial class signupadmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label uSERNAMELabel;
            System.Windows.Forms.Label aDMIN_PWLabel;
            System.Windows.Forms.Label aGELabel;
            System.Windows.Forms.Label gENDERLabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label sTREET_NUMLabel;
            System.Windows.Forms.Label cITYLabel;
            this.trainBookingDataSet = new BookTraining.TrainBookingDataSet();
            this.aDMINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINTableAdapter = new BookTraining.TrainBookingDataSetTableAdapters.ADMINTableAdapter();
            this.tableAdapterManager = new BookTraining.TrainBookingDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.train_BookingDataSet = new BookTraining.Train_BookingDataSet();
            this.aDMINBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aDMINTableAdapter1 = new BookTraining.Train_BookingDataSetTableAdapters.ADMINTableAdapter();
            this.tableAdapterManager1 = new BookTraining.Train_BookingDataSetTableAdapters.TableAdapterManager();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.aDMIN_PWTextBox = new System.Windows.Forms.TextBox();
            this.aGETextBox = new System.Windows.Forms.TextBox();
            this.gENDERTextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.sTREET_NUMTextBox = new System.Windows.Forms.TextBox();
            this.cITYTextBox = new System.Windows.Forms.TextBox();
            uSERNAMELabel = new System.Windows.Forms.Label();
            aDMIN_PWLabel = new System.Windows.Forms.Label();
            aGELabel = new System.Windows.Forms.Label();
            gENDERLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            sTREET_NUMLabel = new System.Windows.Forms.Label();
            cITYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.train_BookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uSERNAMELabel
            // 
            uSERNAMELabel.AutoSize = true;
            uSERNAMELabel.Location = new System.Drawing.Point(21, 35);
            uSERNAMELabel.Name = "uSERNAMELabel";
            uSERNAMELabel.Size = new System.Drawing.Size(105, 20);
            uSERNAMELabel.TabIndex = 17;
            uSERNAMELabel.Text = "USERNAME:";
            // 
            // aDMIN_PWLabel
            // 
            aDMIN_PWLabel.AutoSize = true;
            aDMIN_PWLabel.Location = new System.Drawing.Point(21, 67);
            aDMIN_PWLabel.Name = "aDMIN_PWLabel";
            aDMIN_PWLabel.Size = new System.Drawing.Size(94, 20);
            aDMIN_PWLabel.TabIndex = 19;
            aDMIN_PWLabel.Text = "ADMIN PW:";
            // 
            // aGELabel
            // 
            aGELabel.AutoSize = true;
            aGELabel.Location = new System.Drawing.Point(21, 99);
            aGELabel.Name = "aGELabel";
            aGELabel.Size = new System.Drawing.Size(48, 20);
            aGELabel.TabIndex = 21;
            aGELabel.Text = "AGE:";
            // 
            // gENDERLabel
            // 
            gENDERLabel.AutoSize = true;
            gENDERLabel.Location = new System.Drawing.Point(21, 131);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(83, 20);
            gENDERLabel.TabIndex = 23;
            gENDERLabel.Text = "GENDER:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(21, 163);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(69, 20);
            pHONELabel.TabIndex = 25;
            pHONELabel.Text = "PHONE:";
            // 
            // sTREET_NUMLabel
            // 
            sTREET_NUMLabel.AutoSize = true;
            sTREET_NUMLabel.Location = new System.Drawing.Point(21, 195);
            sTREET_NUMLabel.Name = "sTREET_NUMLabel";
            sTREET_NUMLabel.Size = new System.Drawing.Size(116, 20);
            sTREET_NUMLabel.TabIndex = 27;
            sTREET_NUMLabel.Text = "STREET NUM:";
            // 
            // cITYLabel
            // 
            cITYLabel.AutoSize = true;
            cITYLabel.Location = new System.Drawing.Point(21, 227);
            cITYLabel.Name = "cITYLabel";
            cITYLabel.Size = new System.Drawing.Size(49, 20);
            cITYLabel.TabIndex = 29;
            cITYLabel.Text = "CITY:";
            // 
            // trainBookingDataSet
            // 
            this.trainBookingDataSet.DataSetName = "TrainBookingDataSet";
            this.trainBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDMINBindingSource
            // 
            this.aDMINBindingSource.DataMember = "ADMIN";
            this.aDMINBindingSource.DataSource = this.trainBookingDataSet;
            // 
            // aDMINTableAdapter
            // 
            this.aDMINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = this.aDMINTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKTableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.HISTORYTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.TRAINTableAdapter = null;
            this.tableAdapterManager.TRIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BookTraining.TrainBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // train_BookingDataSet
            // 
            this.train_BookingDataSet.DataSetName = "Train_BookingDataSet";
            this.train_BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDMINBindingSource1
            // 
            this.aDMINBindingSource1.DataMember = "ADMIN";
            this.aDMINBindingSource1.DataSource = this.train_BookingDataSet;
            // 
            // aDMINTableAdapter1
            // 
            this.aDMINTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ADMINTableAdapter = this.aDMINTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BOOKTableAdapter = null;
            this.tableAdapterManager1.CUSTOMERTableAdapter = null;
            this.tableAdapterManager1.HISTORYTableAdapter = null;
            this.tableAdapterManager1.TICKETTableAdapter = null;
            this.tableAdapterManager1.TRAINTableAdapter = null;
            this.tableAdapterManager1.TRIPTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = BookTraining.Train_BookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource1, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(143, 32);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(274, 26);
            this.uSERNAMETextBox.TabIndex = 18;
            // 
            // aDMIN_PWTextBox
            // 
            this.aDMIN_PWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource1, "ADMIN_PW", true));
            this.aDMIN_PWTextBox.Location = new System.Drawing.Point(143, 64);
            this.aDMIN_PWTextBox.Name = "aDMIN_PWTextBox";
            this.aDMIN_PWTextBox.Size = new System.Drawing.Size(274, 26);
            this.aDMIN_PWTextBox.TabIndex = 20;
            this.aDMIN_PWTextBox.UseSystemPasswordChar = true;
            // 
            // aGETextBox
            // 
            this.aGETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource1, "AGE", true));
            this.aGETextBox.Location = new System.Drawing.Point(143, 96);
            this.aGETextBox.Name = "aGETextBox";
            this.aGETextBox.Size = new System.Drawing.Size(274, 26);
            this.aGETextBox.TabIndex = 22;
            // 
            // gENDERTextBox
            // 
            this.gENDERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource1, "GENDER", true));
            this.gENDERTextBox.Location = new System.Drawing.Point(143, 128);
            this.gENDERTextBox.Name = "gENDERTextBox";
            this.gENDERTextBox.Size = new System.Drawing.Size(274, 26);
            this.gENDERTextBox.TabIndex = 24;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource1, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(143, 160);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(274, 26);
            this.pHONETextBox.TabIndex = 26;
            // 
            // sTREET_NUMTextBox
            // 
            this.sTREET_NUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource1, "STREET_NUM", true));
            this.sTREET_NUMTextBox.Location = new System.Drawing.Point(143, 192);
            this.sTREET_NUMTextBox.Name = "sTREET_NUMTextBox";
            this.sTREET_NUMTextBox.Size = new System.Drawing.Size(274, 26);
            this.sTREET_NUMTextBox.TabIndex = 28;
            // 
            // cITYTextBox
            // 
            this.cITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aDMINBindingSource1, "CITY", true));
            this.cITYTextBox.Location = new System.Drawing.Point(143, 224);
            this.cITYTextBox.Name = "cITYTextBox";
            this.cITYTextBox.Size = new System.Drawing.Size(274, 26);
            this.cITYTextBox.TabIndex = 30;
            // 
            // signupadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 345);
            this.Controls.Add(uSERNAMELabel);
            this.Controls.Add(this.uSERNAMETextBox);
            this.Controls.Add(aDMIN_PWLabel);
            this.Controls.Add(this.aDMIN_PWTextBox);
            this.Controls.Add(aGELabel);
            this.Controls.Add(this.aGETextBox);
            this.Controls.Add(gENDERLabel);
            this.Controls.Add(this.gENDERTextBox);
            this.Controls.Add(pHONELabel);
            this.Controls.Add(this.pHONETextBox);
            this.Controls.Add(sTREET_NUMLabel);
            this.Controls.Add(this.sTREET_NUMTextBox);
            this.Controls.Add(cITYLabel);
            this.Controls.Add(this.cITYTextBox);
            this.Controls.Add(this.button1);
            this.Name = "signupadmin";
            this.Text = "Admin SignUp";
            this.Load += new System.EventHandler(this.Signupadmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.train_BookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDMINBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrainBookingDataSet trainBookingDataSet;
        private System.Windows.Forms.BindingSource aDMINBindingSource;
        private TrainBookingDataSetTableAdapters.ADMINTableAdapter aDMINTableAdapter;
        private TrainBookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private Train_BookingDataSet train_BookingDataSet;
        private System.Windows.Forms.BindingSource aDMINBindingSource1;
        private Train_BookingDataSetTableAdapters.ADMINTableAdapter aDMINTableAdapter1;
        private Train_BookingDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox aDMIN_PWTextBox;
        private System.Windows.Forms.TextBox aGETextBox;
        private System.Windows.Forms.TextBox gENDERTextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox sTREET_NUMTextBox;
        private System.Windows.Forms.TextBox cITYTextBox;
    }
}