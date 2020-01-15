namespace BookTraining
{
    partial class UpdateTrain
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label t_IDLabel;
            System.Windows.Forms.Label nUMOFSEATSLabel;
            System.Windows.Forms.Label mODELLabel;
            System.Windows.Forms.Label aVILABLESEATSLabel;
            System.Windows.Forms.Label tOLabel;
            System.Windows.Forms.Label fROMLabel;
            System.Windows.Forms.Label label2;
            this.train_BookingDataSet = new BookTraining.Train_BookingDataSet();
            this.tRAINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRAINTableAdapter = new BookTraining.Train_BookingDataSetTableAdapters.TRAINTableAdapter();
            this.tableAdapterManager = new BookTraining.Train_BookingDataSetTableAdapters.TableAdapterManager();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.t_IDTextBox = new System.Windows.Forms.TextBox();
            this.nUMOFSEATSTextBox = new System.Windows.Forms.TextBox();
            this.mODELTextBox = new System.Windows.Forms.TextBox();
            this.aVILABLESEATSTextBox = new System.Windows.Forms.TextBox();
            this.tOTextBox = new System.Windows.Forms.TextBox();
            this.fROMTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            t_IDLabel = new System.Windows.Forms.Label();
            nUMOFSEATSLabel = new System.Windows.Forms.Label();
            mODELLabel = new System.Windows.Forms.Label();
            aVILABLESEATSLabel = new System.Windows.Forms.Label();
            tOLabel = new System.Windows.Forms.Label();
            fROMLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.train_BookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 253);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 20);
            label1.TabIndex = 31;
            label1.Text = "DATE:";
            // 
            // t_IDLabel
            // 
            t_IDLabel.AutoSize = true;
            t_IDLabel.Location = new System.Drawing.Point(12, 28);
            t_IDLabel.Name = "t_IDLabel";
            t_IDLabel.Size = new System.Drawing.Size(69, 20);
            t_IDLabel.TabIndex = 18;
            t_IDLabel.Text = "Train ID:";
            // 
            // nUMOFSEATSLabel
            // 
            nUMOFSEATSLabel.AutoSize = true;
            nUMOFSEATSLabel.Location = new System.Drawing.Point(12, 92);
            nUMOFSEATSLabel.Name = "nUMOFSEATSLabel";
            nUMOFSEATSLabel.Size = new System.Drawing.Size(124, 20);
            nUMOFSEATSLabel.TabIndex = 20;
            nUMOFSEATSLabel.Text = "NUMOFSEATS:";
            // 
            // mODELLabel
            // 
            mODELLabel.AutoSize = true;
            mODELLabel.Location = new System.Drawing.Point(12, 124);
            mODELLabel.Name = "mODELLabel";
            mODELLabel.Size = new System.Drawing.Size(70, 20);
            mODELLabel.TabIndex = 22;
            mODELLabel.Text = "MODEL:";
            // 
            // aVILABLESEATSLabel
            // 
            aVILABLESEATSLabel.AutoSize = true;
            aVILABLESEATSLabel.Location = new System.Drawing.Point(12, 156);
            aVILABLESEATSLabel.Name = "aVILABLESEATSLabel";
            aVILABLESEATSLabel.Size = new System.Drawing.Size(144, 20);
            aVILABLESEATSLabel.TabIndex = 24;
            aVILABLESEATSLabel.Text = "AVILABLESEATS:";
            // 
            // tOLabel
            // 
            tOLabel.AutoSize = true;
            tOLabel.Location = new System.Drawing.Point(12, 220);
            tOLabel.Name = "tOLabel";
            tOLabel.Size = new System.Drawing.Size(34, 20);
            tOLabel.TabIndex = 26;
            tOLabel.Text = "TO:";
            // 
            // fROMLabel
            // 
            fROMLabel.AutoSize = true;
            fROMLabel.Location = new System.Drawing.Point(12, 188);
            fROMLabel.Name = "fROMLabel";
            fROMLabel.Size = new System.Drawing.Size(60, 20);
            fROMLabel.TabIndex = 28;
            fROMLabel.Text = "FROM:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 20);
            label2.TabIndex = 33;
            label2.Text = "NewTrain ID:";
            // 
            // train_BookingDataSet
            // 
            this.train_BookingDataSet.DataSetName = "Train_BookingDataSet";
            this.train_BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRAINBindingSource
            // 
            this.tRAINBindingSource.DataMember = "TRAIN";
            this.tRAINBindingSource.DataSource = this.train_BookingDataSet;
            // 
            // tRAINTableAdapter
            // 
            this.tRAINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKTableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.HISTORYTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.TRAINTableAdapter = this.tRAINTableAdapter;
            this.tableAdapterManager.TRIPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BookTraining.Train_BookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd - HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 248);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 26);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.Value = new System.DateTime(2019, 5, 4, 1, 48, 0, 0);
            // 
            // t_IDTextBox
            // 
            this.t_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRAINBindingSource, "T_ID", true));
            this.t_IDTextBox.Location = new System.Drawing.Point(162, 25);
            this.t_IDTextBox.Name = "t_IDTextBox";
            this.t_IDTextBox.Size = new System.Drawing.Size(290, 26);
            this.t_IDTextBox.TabIndex = 19;
            // 
            // nUMOFSEATSTextBox
            // 
            this.nUMOFSEATSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRAINBindingSource, "NUMOFSEATS", true));
            this.nUMOFSEATSTextBox.Location = new System.Drawing.Point(162, 89);
            this.nUMOFSEATSTextBox.Name = "nUMOFSEATSTextBox";
            this.nUMOFSEATSTextBox.Size = new System.Drawing.Size(290, 26);
            this.nUMOFSEATSTextBox.TabIndex = 21;
            // 
            // mODELTextBox
            // 
            this.mODELTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRAINBindingSource, "MODEL", true));
            this.mODELTextBox.Location = new System.Drawing.Point(162, 121);
            this.mODELTextBox.Name = "mODELTextBox";
            this.mODELTextBox.Size = new System.Drawing.Size(290, 26);
            this.mODELTextBox.TabIndex = 23;
            // 
            // aVILABLESEATSTextBox
            // 
            this.aVILABLESEATSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRAINBindingSource, "AVILABLESEATS", true));
            this.aVILABLESEATSTextBox.Location = new System.Drawing.Point(162, 153);
            this.aVILABLESEATSTextBox.Name = "aVILABLESEATSTextBox";
            this.aVILABLESEATSTextBox.Size = new System.Drawing.Size(290, 26);
            this.aVILABLESEATSTextBox.TabIndex = 25;
            // 
            // tOTextBox
            // 
            this.tOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRAINBindingSource, "TO", true));
            this.tOTextBox.Location = new System.Drawing.Point(162, 217);
            this.tOTextBox.Name = "tOTextBox";
            this.tOTextBox.Size = new System.Drawing.Size(290, 26);
            this.tOTextBox.TabIndex = 27;
            // 
            // fROMTextBox
            // 
            this.fROMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRAINBindingSource, "FROM", true));
            this.fROMTextBox.Location = new System.Drawing.Point(162, 185);
            this.fROMTextBox.Name = "fROMTextBox";
            this.fROMTextBox.Size = new System.Drawing.Size(290, 26);
            this.fROMTextBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(436, 40);
            this.button1.TabIndex = 32;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRAINBindingSource, "T_ID", true));
            this.textBox1.Location = new System.Drawing.Point(162, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 26);
            this.textBox1.TabIndex = 34;
            // 
            // UpdateTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 363);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(t_IDLabel);
            this.Controls.Add(this.t_IDTextBox);
            this.Controls.Add(nUMOFSEATSLabel);
            this.Controls.Add(this.nUMOFSEATSTextBox);
            this.Controls.Add(mODELLabel);
            this.Controls.Add(this.mODELTextBox);
            this.Controls.Add(aVILABLESEATSLabel);
            this.Controls.Add(this.aVILABLESEATSTextBox);
            this.Controls.Add(tOLabel);
            this.Controls.Add(this.tOTextBox);
            this.Controls.Add(fROMLabel);
            this.Controls.Add(this.fROMTextBox);
            this.Name = "UpdateTrain";
            this.Text = "UpdateTrain";
            this.Load += new System.EventHandler(this.UpdateTrain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.train_BookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRAINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Train_BookingDataSet train_BookingDataSet;
        private System.Windows.Forms.BindingSource tRAINBindingSource;
        private Train_BookingDataSetTableAdapters.TRAINTableAdapter tRAINTableAdapter;
        private Train_BookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox t_IDTextBox;
        private System.Windows.Forms.TextBox nUMOFSEATSTextBox;
        private System.Windows.Forms.TextBox mODELTextBox;
        private System.Windows.Forms.TextBox aVILABLESEATSTextBox;
        private System.Windows.Forms.TextBox tOTextBox;
        private System.Windows.Forms.TextBox fROMTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}