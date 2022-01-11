
namespace PRG521Summitive6955
{
    partial class FrmLogistics
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogistics));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnFreight = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.btnAdresses = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnStatus);
            this.panel1.Controls.Add(this.btnFreight);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnDriver);
            this.panel1.Controls.Add(this.btnAdresses);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 312);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(477, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 133);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnStatus.Image")));
            this.btnStatus.Location = new System.Drawing.Point(477, 16);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(227, 135);
            this.btnStatus.TabIndex = 9;
            this.btnStatus.Text = "Manage Statuses";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnFreight
            // 
            this.btnFreight.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFreight.Image = ((System.Drawing.Image)(resources.GetObject("btnFreight.Image")));
            this.btnFreight.Location = new System.Drawing.Point(244, 157);
            this.btnFreight.Name = "btnFreight";
            this.btnFreight.Size = new System.Drawing.Size(227, 133);
            this.btnFreight.TabIndex = 10;
            this.btnFreight.Text = "Manage Freight";
            this.btnFreight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFreight.UseVisualStyleBackColor = false;
            this.btnFreight.Click += new System.EventHandler(this.btnFreight_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.Location = new System.Drawing.Point(244, 16);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(227, 135);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.Text = "Manage Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDriver.Image = ((System.Drawing.Image)(resources.GetObject("btnDriver.Image")));
            this.btnDriver.Location = new System.Drawing.Point(11, 157);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(227, 133);
            this.btnDriver.TabIndex = 7;
            this.btnDriver.Text = "Manage Drivers";
            this.btnDriver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDriver.UseVisualStyleBackColor = false;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // btnAdresses
            // 
            this.btnAdresses.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdresses.Image = ((System.Drawing.Image)(resources.GetObject("btnAdresses.Image")));
            this.btnAdresses.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdresses.Location = new System.Drawing.Point(11, 16);
            this.btnAdresses.Name = "btnAdresses";
            this.btnAdresses.Size = new System.Drawing.Size(227, 135);
            this.btnAdresses.TabIndex = 6;
            this.btnAdresses.Text = "Manage Adressess";
            this.btnAdresses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdresses.UseVisualStyleBackColor = false;
            this.btnAdresses.Click += new System.EventHandler(this.btnAdresses_Click_1);
            // 
            // FrmLogistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(741, 336);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogistics";
            this.Text = "CTU_Logistics";
            this.Load += new System.EventHandler(this.FrmLogistics_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFreight;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button btnAdresses;
    }
}

