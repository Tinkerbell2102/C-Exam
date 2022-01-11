
namespace PRG521Summitive6955
{
    partial class FrmDriver
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgDriver = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rbtnONo = new System.Windows.Forms.RadioButton();
            this.rbtnOYes = new System.Windows.Forms.RadioButton();
            this.cmbLicenseType = new System.Windows.Forms.ComboBox();
            this.txtDFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.dtgDriver);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.rbtnONo);
            this.panel1.Controls.Add(this.rbtnOYes);
            this.panel1.Controls.Add(this.cmbLicenseType);
            this.panel1.Controls.Add(this.txtDFullname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 425);
            this.panel1.TabIndex = 0;
            // 
            // dtgDriver
            // 
            this.dtgDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDriver.Location = new System.Drawing.Point(25, 187);
            this.dtgDriver.Name = "dtgDriver";
            this.dtgDriver.RowTemplate.Height = 25;
            this.dtgDriver.Size = new System.Drawing.Size(314, 224);
            this.dtgDriver.TabIndex = 24;
            this.dtgDriver.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDriver_CellClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(281, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(217, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(153, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(89, 158);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(58, 23);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(25, 158);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(58, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rbtnONo
            // 
            this.rbtnONo.AutoSize = true;
            this.rbtnONo.Location = new System.Drawing.Point(166, 114);
            this.rbtnONo.Name = "rbtnONo";
            this.rbtnONo.Size = new System.Drawing.Size(41, 19);
            this.rbtnONo.TabIndex = 7;
            this.rbtnONo.TabStop = true;
            this.rbtnONo.Text = "No";
            this.rbtnONo.UseVisualStyleBackColor = true;
            // 
            // rbtnOYes
            // 
            this.rbtnOYes.AutoSize = true;
            this.rbtnOYes.Location = new System.Drawing.Point(106, 115);
            this.rbtnOYes.Name = "rbtnOYes";
            this.rbtnOYes.Size = new System.Drawing.Size(42, 19);
            this.rbtnOYes.TabIndex = 6;
            this.rbtnOYes.TabStop = true;
            this.rbtnOYes.Text = "Yes";
            this.rbtnOYes.UseVisualStyleBackColor = true;
            // 
            // cmbLicenseType
            // 
            this.cmbLicenseType.FormattingEnabled = true;
            this.cmbLicenseType.Items.AddRange(new object[] {
            "A1 Motorcycles (-125cc)",
            "A Motorcycles (+125cc)",
            "B Vehicles",
            "C Buses and goods vehicles",
            "EB Articulated vehicles"});
            this.cmbLicenseType.Location = new System.Drawing.Point(106, 87);
            this.cmbLicenseType.Name = "cmbLicenseType";
            this.cmbLicenseType.Size = new System.Drawing.Size(233, 23);
            this.cmbLicenseType.TabIndex = 5;
            // 
            // txtDFullname
            // 
            this.txtDFullname.Location = new System.Drawing.Point(106, 58);
            this.txtDFullname.Name = "txtDFullname";
            this.txtDFullname.Size = new System.Drawing.Size(233, 23);
            this.txtDFullname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Owner:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver Information:";
            // 
            // FrmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDriver";
            this.Text = "Driver Information";
            this.Load += new System.EventHandler(this.FrmDriver_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rbtnONo;
        private System.Windows.Forms.RadioButton rbtnOYes;
        private System.Windows.Forms.ComboBox cmbLicenseType;
        private System.Windows.Forms.TextBox txtDFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgDriver;
    }
}