namespace etl
{
    partial class Changes
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
            this.tablesBox = new System.Windows.Forms.ListBox();
            this.columnsBox = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.columnsTitleLable = new System.Windows.Forms.Label();
            this.tablesTitleLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tablesBox
            // 
            this.tablesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesBox.FormattingEnabled = true;
            this.tablesBox.HorizontalScrollbar = true;
            this.tablesBox.ItemHeight = 15;
            this.tablesBox.Location = new System.Drawing.Point(12, 89);
            this.tablesBox.Name = "tablesBox";
            this.tablesBox.ScrollAlwaysVisible = true;
            this.tablesBox.Size = new System.Drawing.Size(250, 289);
            this.tablesBox.TabIndex = 0;
            // 
            // columnsBox
            // 
            this.columnsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsBox.FormattingEnabled = true;
            this.columnsBox.ItemHeight = 15;
            this.columnsBox.Location = new System.Drawing.Point(292, 89);
            this.columnsBox.Name = "columnsBox";
            this.columnsBox.Size = new System.Drawing.Size(250, 289);
            this.columnsBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(148, 456);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(114, 39);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(292, 456);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 39);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(156, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(258, 24);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Those changes will be made:";
            // 
            // columnsTitleLable
            // 
            this.columnsTitleLable.AutoSize = true;
            this.columnsTitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsTitleLable.Location = new System.Drawing.Point(289, 60);
            this.columnsTitleLable.Name = "columnsTitleLable";
            this.columnsTitleLable.Size = new System.Drawing.Size(117, 18);
            this.columnsTitleLable.TabIndex = 5;
            this.columnsTitleLable.Text = "Columns to add:";
            // 
            // tablesTitleLabel
            // 
            this.tablesTitleLabel.AutoSize = true;
            this.tablesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesTitleLabel.Location = new System.Drawing.Point(9, 60);
            this.tablesTitleLabel.Name = "tablesTitleLabel";
            this.tablesTitleLabel.Size = new System.Drawing.Size(101, 18);
            this.tablesTitleLabel.TabIndex = 6;
            this.tablesTitleLabel.Text = "Tables to add:";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalLabel.Location = new System.Drawing.Point(156, 416);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(258, 18);
            this.finalLabel.TabIndex = 7;
            this.finalLabel.Text = "Do you want to make those changes?";
            // 
            // Changes
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(554, 520);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.tablesTitleLabel);
            this.Controls.Add(this.columnsTitleLable);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.columnsBox);
            this.Controls.Add(this.tablesBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Changes";
            this.Text = "Changes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tablesBox;
        private System.Windows.Forms.ListBox columnsBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label columnsTitleLable;
        private System.Windows.Forms.Label tablesTitleLabel;
        private System.Windows.Forms.Label finalLabel;
    }
}