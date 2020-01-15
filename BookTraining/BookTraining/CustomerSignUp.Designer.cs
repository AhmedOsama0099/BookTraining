namespace BookTraining
{
    partial class signupcustomer
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
            System.Windows.Forms.Label gENDERLabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label aGELabel;
            System.Windows.Forms.Label c_PWLabel;
            System.Windows.Forms.Label c_USERNAMELabel;
            this.trainBookingDataSet = new BookTraining.TrainBookingDataSet();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new BookTraining.TrainBookingDataSetTableAdapters.CUSTOMERTableAdapter();
            this.tableAdapterManager = new BookTraining.TrainBookingDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.train_BookingDataSet = new BookTraining.Train_BookingDataSet();
            this.cUSTOMERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter1 = new BookTraining.Train_BookingDataSetTableAdapters.CUSTOMERTableAdapter();
            this.tableAdapterManager1 = new BookTraining.Train_BookingDataSetTableAdapters.TableAdapterManager();
            this.gENDERTextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.aGETextBox = new System.Windows.Forms.TextBox();
            this.c_PWTextBox = new System.Windows.Forms.TextBox();
            this.c_USERNAMETextBox = new System.Windows.Forms.TextBox();
            gENDERLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            aGELabel = new System.Windows.Forms.Label();
            c_PWLabel = new System.Windows.Forms.Label();
            c_USERNAMELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.train_BookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gENDERLabel
            // 
            gENDERLabel.AutoSize = true;
            gENDERLabel.Location = new System.Drawing.Point(12, 172);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(67, 20);
            gENDERLabel.TabIndex = 18;
            gENDERLabel.Text = "Gender:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(12, 140);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(59, 20);
            pHONELabel.TabIndex = 16;
            pHONELabel.Text = "Phone:";
            // 
            // aGELabel
            // 
            aGELabel.AutoSize = true;
            aGELabel.Location = new System.Drawing.Point(12, 108);
            aGELabel.Name = "aGELabel";
            aGELabel.Size = new System.Drawing.Size(42, 20);
            aGELabel.TabIndex = 14;
            aGELabel.Text = "Age:";
            // 
            // c_PWLabel
            // 
            c_PWLabel.AutoSize = true;
            c_PWLabel.Location = new System.Drawing.Point(12, 76);
            c_PWLabel.Name = "c_PWLabel";
            c_PWLabel.Size = new System.Drawing.Size(82, 20);
            c_PWLabel.TabIndex = 12;
            c_PWLabel.Text = "Password:";
            // 
            // c_USERNAMELabel
            // 
            c_USERNAMELabel.AutoSize = true;
            c_USERNAMELabel.Location = new System.Drawing.Point(12, 44);
            c_USERNAMELabel.Name = "c_USERNAMELabel";
            c_USERNAMELabel.Size = new System.Drawing.Size(93, 20);
            c_USERNAMELabel.TabIndex = 10;
            c_USERNAMELabel.Text = "User Name:";
            // 
            // trainBookingDataSet
            // 
            this.trainBookingDataSet.DataSetName = "TrainBookingDataSet";
            this.trainBookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.trainBookingDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKTableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter;
            this.tableAdapterManager.HISTORYTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.TRAINTableAdapter = null;
            this.tableAdapterManager.TRIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BookTraining.TrainBookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "SignUp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // train_BookingDataSet
            // 
            this.train_BookingDataSet.DataSetName = "Train_BookingDataSet";
            this.train_BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource1
            // 
            this.cUSTOMERBindingSource1.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource1.DataSource = this.train_BookingDataSet;
            // 
            // cUSTOMERTableAdapter1
            // 
            this.cUSTOMERTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ADMINTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BOOKTableAdapter = null;
            this.tableAdapterManager1.CUSTOMERTableAdapter = this.cUSTOMERTableAdapter1;
            this.tableAdapterManager1.HISTORYTableAdapter = null;
            this.tableAdapterManager1.TICKETTableAdapter = null;
            this.tableAdapterManager1.TRAINTableAdapter = null;
            this.tableAdapterManager1.TRIPTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = BookTraining.Train_BookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gENDERTextBox
            // 
            this.gENDERTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "GENDER", true));
            this.gENDERTextBox.Location = new System.Drawing.Point(138, 169);
            this.gENDERTextBox.Name = "gENDERTextBox";
            this.gENDERTextBox.Size = new System.Drawing.Size(295, 26);
            this.gENDERTextBox.TabIndex = 19;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(138, 137);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(295, 26);
            this.pHONETextBox.TabIndex = 17;
            // 
            // aGETextBox
            // 
            this.aGETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "AGE", true));
            this.aGETextBox.Location = new System.Drawing.Point(138, 105);
            this.aGETextBox.Name = "aGETextBox";
            this.aGETextBox.Size = new System.Drawing.Size(295, 26);
            this.aGETextBox.TabIndex = 15;
            // 
            // c_PWTextBox
            // 
            this.c_PWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "C_PW", true));
            this.c_PWTextBox.Location = new System.Drawing.Point(138, 73);
            this.c_PWTextBox.Name = "c_PWTextBox";
            this.c_PWTextBox.Size = new System.Drawing.Size(295, 26);
            this.c_PWTextBox.TabIndex = 13;
            this.c_PWTextBox.UseSystemPasswordChar = true;
            // 
            // c_USERNAMETextBox
            // 
            this.c_USERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cUSTOMERBindingSource1, "C_USERNAME", true));
            this.c_USERNAMETextBox.Location = new System.Drawing.Point(138, 41);
            this.c_USERNAMETextBox.Name = "c_USERNAMETextBox";
            this.c_USERNAMETextBox.Size = new System.Drawing.Size(295, 26);
            this.c_USERNAMETextBox.TabIndex = 11;
            // 
            // signupcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 275);
            this.Controls.Add(c_USERNAMELabel);
            this.Controls.Add(this.c_USERNAMETextBox);
            this.Controls.Add(c_PWLabel);
            this.Controls.Add(this.c_PWTextBox);
            this.Controls.Add(aGELabel);
            this.Controls.Add(this.aGETextBox);
            this.Controls.Add(pHONELabel);
            this.Controls.Add(this.pHONETextBox);
            this.Controls.Add(gENDERLabel);
            this.Controls.Add(this.gENDERTextBox);
            this.Controls.Add(this.button1);
            this.Name = "signupcustomer";
            this.Text = "Customer SignUp";
            this.Load += new System.EventHandler(this.Signupcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainBookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.train_BookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrainBookingDataSet trainBookingDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private TrainBookingDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private TrainBookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private Train_BookingDataSet train_BookingDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource1;
        private Train_BookingDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter1;
        private Train_BookingDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox gENDERTextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox aGETextBox;
        private System.Windows.Forms.TextBox c_PWTextBox;
        private System.Windows.Forms.TextBox c_USERNAMETextBox;
    }
}