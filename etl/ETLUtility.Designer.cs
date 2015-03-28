namespace etl
{
    partial class ETLUtility
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
            this.txtSourceIP = new System.Windows.Forms.TextBox();
            this.txtSourcePassword = new System.Windows.Forms.TextBox();
            this.txtSourceUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSourceDBName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSourceDMS = new System.Windows.Forms.ComboBox();
            this.saveSource = new System.Windows.Forms.Button();
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveDestination = new System.Windows.Forms.Button();
            this.cmbDestinationDMS = new System.Windows.Forms.ComboBox();
            this.txtDestinationIP = new System.Windows.Forms.TextBox();
            this.txtDestinationPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDestinationUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestinationDBName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lstFavourites = new System.Windows.Forms.ListBox();
            this.grpFavourites = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSetDestination = new System.Windows.Forms.Button();
            this.btnSetSource = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.beginTransfer = new System.Windows.Forms.Button();
            this.odbcBox = new System.Windows.Forms.TextBox();
            this.odbcLabel = new System.Windows.Forms.Label();
            this.grpSource.SuspendLayout();
            this.grpDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpFavourites.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSourceIP
            // 
            this.txtSourceIP.Location = new System.Drawing.Point(122, 28);
            this.txtSourceIP.Name = "txtSourceIP";
            this.txtSourceIP.Size = new System.Drawing.Size(146, 20);
            this.txtSourceIP.TabIndex = 0;
            // 
            // txtSourcePassword
            // 
            this.txtSourcePassword.Location = new System.Drawing.Point(122, 106);
            this.txtSourcePassword.Name = "txtSourcePassword";
            this.txtSourcePassword.Size = new System.Drawing.Size(146, 20);
            this.txtSourcePassword.TabIndex = 3;
            // 
            // txtSourceUsername
            // 
            this.txtSourceUsername.Location = new System.Drawing.Point(122, 80);
            this.txtSourceUsername.Name = "txtSourceUsername";
            this.txtSourceUsername.Size = new System.Drawing.Size(146, 20);
            this.txtSourceUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DB Name";
            // 
            // txtSourceDBName
            // 
            this.txtSourceDBName.Location = new System.Drawing.Point(122, 134);
            this.txtSourceDBName.Name = "txtSourceDBName";
            this.txtSourceDBName.Size = new System.Drawing.Size(146, 20);
            this.txtSourceDBName.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check Connection";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grpSource
            // 
            this.grpSource.Controls.Add(this.label9);
            this.grpSource.Controls.Add(this.cmbSourceDMS);
            this.grpSource.Controls.Add(this.saveSource);
            this.grpSource.Controls.Add(this.txtSourceIP);
            this.grpSource.Controls.Add(this.txtSourcePassword);
            this.grpSource.Controls.Add(this.button1);
            this.grpSource.Controls.Add(this.txtSourceUsername);
            this.grpSource.Controls.Add(this.label1);
            this.grpSource.Controls.Add(this.txtSourceDBName);
            this.grpSource.Controls.Add(this.label2);
            this.grpSource.Controls.Add(this.label4);
            this.grpSource.Controls.Add(this.label3);
            this.grpSource.Location = new System.Drawing.Point(25, 22);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(302, 227);
            this.grpSource.TabIndex = 10;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "DMS";
            // 
            // cmbSourceDMS
            // 
            this.cmbSourceDMS.FormattingEnabled = true;
            this.cmbSourceDMS.Items.AddRange(new object[] {
            "MySQL",
            "MSSQL"});
            this.cmbSourceDMS.Location = new System.Drawing.Point(122, 53);
            this.cmbSourceDMS.Name = "cmbSourceDMS";
            this.cmbSourceDMS.Size = new System.Drawing.Size(146, 21);
            this.cmbSourceDMS.TabIndex = 1;
            // 
            // saveSource
            // 
            this.saveSource.Location = new System.Drawing.Point(34, 171);
            this.saveSource.Name = "saveSource";
            this.saveSource.Size = new System.Drawing.Size(103, 32);
            this.saveSource.TabIndex = 5;
            this.saveSource.Text = "Save";
            this.saveSource.UseVisualStyleBackColor = true;
            this.saveSource.Click += new System.EventHandler(this.saveSource_Click);
            // 
            // grpDestination
            // 
            this.grpDestination.Controls.Add(this.label10);
            this.grpDestination.Controls.Add(this.saveDestination);
            this.grpDestination.Controls.Add(this.cmbDestinationDMS);
            this.grpDestination.Controls.Add(this.txtDestinationIP);
            this.grpDestination.Controls.Add(this.txtDestinationPassword);
            this.grpDestination.Controls.Add(this.button2);
            this.grpDestination.Controls.Add(this.txtDestinationUsername);
            this.grpDestination.Controls.Add(this.label5);
            this.grpDestination.Controls.Add(this.txtDestinationDBName);
            this.grpDestination.Controls.Add(this.label6);
            this.grpDestination.Controls.Add(this.label7);
            this.grpDestination.Controls.Add(this.label8);
            this.grpDestination.Location = new System.Drawing.Point(355, 22);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(302, 227);
            this.grpDestination.TabIndex = 11;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Destination";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "DMS";
            // 
            // saveDestination
            // 
            this.saveDestination.Location = new System.Drawing.Point(43, 171);
            this.saveDestination.Name = "saveDestination";
            this.saveDestination.Size = new System.Drawing.Size(103, 32);
            this.saveDestination.TabIndex = 12;
            this.saveDestination.Text = "Save";
            this.saveDestination.UseVisualStyleBackColor = true;
            this.saveDestination.Click += new System.EventHandler(this.saveDestination_Click);
            // 
            // cmbDestinationDMS
            // 
            this.cmbDestinationDMS.FormattingEnabled = true;
            this.cmbDestinationDMS.Items.AddRange(new object[] {
            "MySQL",
            "MSSQL"});
            this.cmbDestinationDMS.Location = new System.Drawing.Point(122, 54);
            this.cmbDestinationDMS.Name = "cmbDestinationDMS";
            this.cmbDestinationDMS.Size = new System.Drawing.Size(146, 21);
            this.cmbDestinationDMS.TabIndex = 8;
            // 
            // txtDestinationIP
            // 
            this.txtDestinationIP.Location = new System.Drawing.Point(122, 28);
            this.txtDestinationIP.Name = "txtDestinationIP";
            this.txtDestinationIP.Size = new System.Drawing.Size(146, 20);
            this.txtDestinationIP.TabIndex = 7;
            // 
            // txtDestinationPassword
            // 
            this.txtDestinationPassword.Location = new System.Drawing.Point(122, 106);
            this.txtDestinationPassword.Name = "txtDestinationPassword";
            this.txtDestinationPassword.Size = new System.Drawing.Size(146, 20);
            this.txtDestinationPassword.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Check Connection";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtDestinationUsername
            // 
            this.txtDestinationUsername.Location = new System.Drawing.Point(122, 80);
            this.txtDestinationUsername.Name = "txtDestinationUsername";
            this.txtDestinationUsername.Size = new System.Drawing.Size(146, 20);
            this.txtDestinationUsername.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "IP Address";
            // 
            // txtDestinationDBName
            // 
            this.txtDestinationDBName.Location = new System.Drawing.Point(122, 134);
            this.txtDestinationDBName.Name = "txtDestinationDBName";
            this.txtDestinationDBName.Size = new System.Drawing.Size(146, 20);
            this.txtDestinationDBName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DB Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Username";
            // 
            // lstFavourites
            // 
            this.lstFavourites.FormattingEnabled = true;
            this.lstFavourites.Location = new System.Drawing.Point(19, 31);
            this.lstFavourites.Name = "lstFavourites";
            this.lstFavourites.Size = new System.Drawing.Size(137, 173);
            this.lstFavourites.TabIndex = 13;
            // 
            // grpFavourites
            // 
            this.grpFavourites.Controls.Add(this.btnDelete);
            this.grpFavourites.Controls.Add(this.btnSetDestination);
            this.grpFavourites.Controls.Add(this.btnSetSource);
            this.grpFavourites.Controls.Add(this.lstFavourites);
            this.grpFavourites.Location = new System.Drawing.Point(25, 270);
            this.grpFavourites.Name = "grpFavourites";
            this.grpFavourites.Size = new System.Drawing.Size(302, 227);
            this.grpFavourites.TabIndex = 14;
            this.grpFavourites.TabStop = false;
            this.grpFavourites.Text = "Favourites";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(167, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 32);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSetDestination
            // 
            this.btnSetDestination.Location = new System.Drawing.Point(167, 69);
            this.btnSetDestination.Name = "btnSetDestination";
            this.btnSetDestination.Size = new System.Drawing.Size(117, 32);
            this.btnSetDestination.TabIndex = 16;
            this.btnSetDestination.Text = "Load Destination";
            this.btnSetDestination.UseVisualStyleBackColor = true;
            this.btnSetDestination.Click += new System.EventHandler(this.btnSetDestination_Click);
            // 
            // btnSetSource
            // 
            this.btnSetSource.Location = new System.Drawing.Point(167, 31);
            this.btnSetSource.Name = "btnSetSource";
            this.btnSetSource.Size = new System.Drawing.Size(117, 32);
            this.btnSetSource.TabIndex = 15;
            this.btnSetSource.Text = "Load Source";
            this.btnSetSource.UseVisualStyleBackColor = true;
            this.btnSetSource.Click += new System.EventHandler(this.btnSetSource_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.odbcLabel);
            this.groupBox1.Controls.Add(this.odbcBox);
            this.groupBox1.Controls.Add(this.mainProgressBar);
            this.groupBox1.Controls.Add(this.beginTransfer);
            this.groupBox1.Location = new System.Drawing.Point(355, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 227);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer";
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Location = new System.Drawing.Point(91, 139);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(120, 23);
            this.mainProgressBar.TabIndex = 17;
            // 
            // beginTransfer
            // 
            this.beginTransfer.Location = new System.Drawing.Point(91, 93);
            this.beginTransfer.Name = "beginTransfer";
            this.beginTransfer.Size = new System.Drawing.Size(120, 40);
            this.beginTransfer.TabIndex = 16;
            this.beginTransfer.Text = "Begin Transfer";
            this.beginTransfer.UseVisualStyleBackColor = true;
            this.beginTransfer.Click += new System.EventHandler(this.beginTransfer_Click);
            // 
            // odbcBox
            // 
            this.odbcBox.Location = new System.Drawing.Point(91, 58);
            this.odbcBox.Name = "odbcBox";
            this.odbcBox.Size = new System.Drawing.Size(120, 20);
            this.odbcBox.TabIndex = 18;
            this.odbcBox.Text = "5.3 ANSI";
            // 
            // odbcLabel
            // 
            this.odbcLabel.AutoSize = true;
            this.odbcLabel.Location = new System.Drawing.Point(91, 31);
            this.odbcLabel.Name = "odbcLabel";
            this.odbcLabel.Size = new System.Drawing.Size(128, 13);
            this.odbcLabel.TabIndex = 19;
            this.odbcLabel.Text = "Enter ODBC drive version";
            // 
            // ETLUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFavourites);
            this.Controls.Add(this.grpDestination);
            this.Controls.Add(this.grpSource);
            this.Name = "ETLUtility";
            this.Text = "ETL Utility";
            this.Load += new System.EventHandler(this.ETLUtility_Load);
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpFavourites.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceIP;
        private System.Windows.Forms.TextBox txtSourcePassword;
        private System.Windows.Forms.TextBox txtSourceUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourceDBName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.TextBox txtDestinationIP;
        private System.Windows.Forms.TextBox txtDestinationPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDestinationUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDestinationDBName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSourceDMS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbDestinationDMS;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox lstFavourites;
        private System.Windows.Forms.GroupBox grpFavourites;
        private System.Windows.Forms.Button btnSetSource;
        private System.Windows.Forms.Button btnSetDestination;
        private System.Windows.Forms.Button saveSource;
        private System.Windows.Forms.Button saveDestination;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button beginTransfer;
        private System.Windows.Forms.ProgressBar mainProgressBar;
        private System.Windows.Forms.Label odbcLabel;
        private System.Windows.Forms.TextBox odbcBox;
    }
}

