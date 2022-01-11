//6955 Laikin Barnard

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace PRG521Summitive6955
{
    //6955 Laikin Barnard
    public partial class FrmLogistics : Form
    {
        public FrmLogistics()
        {
            InitializeComponent();
        }

        private void LinkToAddresses()
        {
            this.Hide();
            FrmAdresses frmadresses = new FrmAdresses();
            frmadresses.Show();
        }
        public void LinkToCustomers()
        {
            this.Hide();
            FrmCustomers FrmCustomers = new FrmCustomers();
            FrmCustomers.Show();
        }
        public void LinkToDrivers()
        {
            this.Hide();
            FrmDriver FrmDriver = new FrmDriver();
            FrmDriver.Show();
        }
        public void LinkToFreight()
        {
            this.Hide();
            FrmFreight FrmFreight = new FrmFreight();
            FrmFreight.Show();
        }
        public void LinkToStatus()
        {
            this.Hide();
            FrmStatus FrmStatus = new FrmStatus();
            FrmStatus.Show();
        }
        public void AppExit()
        {
            Application.Exit();
        }
        public void btnAdresses_Click(object sender, EventArgs e)
        {
            LinkToAddresses();
        }
        public void FrmLogistics_Load(object sender, EventArgs e)
        {
            btnAdresses.Focus();
        }
        private void btnAdresses_Click_1(object sender, EventArgs e)
        {
            LinkToAddresses();
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LinkToCustomers();
        }
        private void btnFreight_Click(object sender, EventArgs e)
        {
            LinkToFreight();
        }
        private void btnDriver_Click(object sender, EventArgs e)
        {
            LinkToDrivers();
        }
        private void btnStatus_Click(object sender, EventArgs e)
        {
            LinkToStatus();
        }
    }
}
//6955 Laikin Barnard
