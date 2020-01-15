namespace BookTraining
{
    partial class UpdateTrip
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
            System.Windows.Forms.Label tRIP_NUMLabel;
            System.Windows.Forms.Label dATE_TIMELabel;
            System.Windows.Forms.Label label1;
            this._Train_Booking_DataSet = new BookTraining._Train_Booking_DataSet();
            this.tRIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRIPTableAdapter = new BookTraining._Train_Booking_DataSetTableAdapters.TRIPTableAdapter();
            this.tableAdapterManager = new BookTraining._Train_Booking_DataSetTableAdapters.TableAdapterManager();
            this.tRIP_NUMTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            tRIP_NUMLabel = new System.Windows.Forms.Label();
            dATE_TIMELabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Train_Booking_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tRIP_NUMLabel
            // 
            tRIP_NUMLabel.AutoSize = true;
            tRIP_NUMLabel.Location = new System.Drawing.Point(12, 20);
            tRIP_NUMLabel.Name = "tRIP_NUMLabel";
            tRIP_NUMLabel.Size = new System.Drawing.Size(117, 20);
            tRIP_NUMLabel.TabIndex = 1;
            tRIP_NUMLabel.Text = "Old TRIP NUM:";
            // 
            // dATE_TIMELabel
            // 
            dATE_TIMELabel.AutoSize = true;
            dATE_TIMELabel.Location = new System.Drawing.Point(12, 117);
            dATE_TIMELabel.Name = "dATE_TIMELabel";
            dATE_TIMELabel.Size = new System.Drawing.Size(117, 20);
            dATE_TIMELabel.TabIndex = 7;
            dATE_TIMELabel.Text = "New Date&Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 20);
            label1.TabIndex = 9;
            label1.Text = "New TRIP NUM:";
            // 
            // _Train_Booking_DataSet
            // 
            this._Train_Booking_DataSet.DataSetName = "_Train_Booking_DataSet";
            this._Train_Booking_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRIPBindingSource
            // 
            this.tRIPBindingSource.DataMember = "TRIP";
            this.tRIPBindingSource.DataSource = this._Train_Booking_DataSet;
            // 
            // tRIPTableAdapter
            // 
            this.tRIPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKTableAdapter = null;
            this.tableAdapterManager.CUSTOMERTableAdapter = null;
            this.tableAdapterManager.HISTORYTableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.TRAINTableAdapter = null;
            this.tableAdapterManager.TRIPTableAdapter = this.tRIPTableAdapter;
            this.tableAdapterManager.UpdateOrder = BookTraining._Train_Booking_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tRIP_NUMTextBox
            // 
            this.tRIP_NUMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRIPBindingSource, "TRIP_NUM", true));
            this.tRIP_NUMTextBox.Location = new System.Drawing.Point(140, 17);
            this.tRIP_NUMTextBox.Name = "tRIP_NUMTextBox";
            this.tRIP_NUMTextBox.Size = new System.Drawing.Size(209, 26);
            this.tRIP_NUMTextBox.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRIPBindingSource, "TRIP_NUM", true));
            this.textBox1.Location = new System.Drawing.Point(140, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 26);
            this.textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd - HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 117);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 26);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2019, 5, 4, 1, 48, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // UpdateTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(tRIP_NUMLabel);
            this.Controls.Add(this.tRIP_NUMTextBox);
            this.Controls.Add(dATE_TIMELabel);
            this.Name = "UpdateTrip";
            this.Text = "UpdateTrip";
            this.Load += new System.EventHandler(this.UpdateTrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Train_Booking_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRIPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Train_Booking_DataSet _Train_Booking_DataSet;
        private System.Windows.Forms.BindingSource tRIPBindingSource;
        private _Train_Booking_DataSetTableAdapters.TRIPTableAdapter tRIPTableAdapter;
        private _Train_Booking_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tRIP_NUMTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}