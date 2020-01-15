namespace BookTraining
{
    partial class UpdateCustomerProfile
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
            System.Windows.Forms.Label c_USERNAMELabel;
            System.Windows.Forms.Label c_PWLabel;
            System.Windows.Forms.Label aGELabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label gENDERLabel;
            this.c_USERNAMETextBox = new System.Windows.Forms.TextBox();
            this.c_PWTextBox = new System.Windows.Forms.TextBox();
            this.aGETextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.gENDERTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            c_USERNAMELabel = new System.Windows.Forms.Label();
            c_PWLabel = new System.Windows.Forms.Label();
            aGELabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            gENDERLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c_USERNAMELabel
            // 
            c_USERNAMELabel.AutoSize = true;
            c_USERNAMELabel.Location = new System.Drawing.Point(12, 32);
            c_USERNAMELabel.Name = "c_USERNAMELabel";
            c_USERNAMELabel.Size = new System.Drawing.Size(93, 20);
            c_USERNAMELabel.TabIndex = 20;
            c_USERNAMELabel.Text = "User Name:";
            // 
            // c_PWLabel
            // 
            c_PWLabel.AutoSize = true;
            c_PWLabel.Location = new System.Drawing.Point(12, 64);
            c_PWLabel.Name = "c_PWLabel";
            c_PWLabel.Size = new System.Drawing.Size(82, 20);
            c_PWLabel.TabIndex = 22;
            c_PWLabel.Text = "Password:";
            // 
            // aGELabel
            // 
            aGELabel.AutoSize = true;
            aGELabel.Location = new System.Drawing.Point(12, 96);
            aGELabel.Name = "aGELabel";
            aGELabel.Size = new System.Drawing.Size(42, 20);
            aGELabel.TabIndex = 24;
            aGELabel.Text = "Age:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(12, 128);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(59, 20);
            pHONELabel.TabIndex = 26;
            pHONELabel.Text = "Phone:";
            // 
            // gENDERLabel
            // 
            gENDERLabel.AutoSize = true;
            gENDERLabel.Location = new System.Drawing.Point(12, 160);
            gENDERLabel.Name = "gENDERLabel";
            gENDERLabel.Size = new System.Drawing.Size(67, 20);
            gENDERLabel.TabIndex = 28;
            gENDERLabel.Text = "Gender:";
            // 
            // c_USERNAMETextBox
            // 
            this.c_USERNAMETextBox.Location = new System.Drawing.Point(138, 29);
            this.c_USERNAMETextBox.Name = "c_USERNAMETextBox";
            this.c_USERNAMETextBox.Size = new System.Drawing.Size(314, 26);
            this.c_USERNAMETextBox.TabIndex = 21;
            // 
            // c_PWTextBox
            // 
            this.c_PWTextBox.Location = new System.Drawing.Point(138, 61);
            this.c_PWTextBox.Name = "c_PWTextBox";
            this.c_PWTextBox.Size = new System.Drawing.Size(314, 26);
            this.c_PWTextBox.TabIndex = 23;
            this.c_PWTextBox.UseSystemPasswordChar = true;
            // 
            // aGETextBox
            // 
            this.aGETextBox.Location = new System.Drawing.Point(138, 93);
            this.aGETextBox.Name = "aGETextBox";
            this.aGETextBox.Size = new System.Drawing.Size(314, 26);
            this.aGETextBox.TabIndex = 25;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.Location = new System.Drawing.Point(138, 125);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(314, 26);
            this.pHONETextBox.TabIndex = 27;
            // 
            // gENDERTextBox
            // 
            this.gENDERTextBox.Location = new System.Drawing.Point(138, 157);
            this.gENDERTextBox.Name = "gENDERTextBox";
            this.gENDERTextBox.Size = new System.Drawing.Size(314, 26);
            this.gENDERTextBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(436, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // UpdateCustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 259);
            this.Controls.Add(this.button1);
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
            this.Name = "UpdateCustomerProfile";
            this.Text = "UpdateProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox c_USERNAMETextBox;
        private System.Windows.Forms.TextBox c_PWTextBox;
        private System.Windows.Forms.TextBox aGETextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox gENDERTextBox;
        private System.Windows.Forms.Button button1;
    }
}