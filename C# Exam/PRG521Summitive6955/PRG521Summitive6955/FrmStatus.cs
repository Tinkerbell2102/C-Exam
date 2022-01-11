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
using System.IO;


namespace PRG521Summitive6955
{
    public partial class FrmStatus : Form
    {
        //6955 Laikin Barnard
        public FrmStatus()
        {
            InitializeComponent();
        }

        public void displaydata()
        {
        }

        public void TextboxClear()
        {
            txtDriverID.Clear();
            txtStatusID.Clear();
            txtStatusID.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                bool filestatus = (System.IO.File.Exists("d:\\tmp\\status.txt"));
                if (filestatus == true)
                {
                    MessageBox.Show("File Already Exists!");
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter("d:\\tmp\\status.txt", true))
                    {
                    writer.WriteLine(rtxtStatus.Text);
                    }
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TextboxClear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                rtxtStatus.Text = System.IO.File.ReadAllText(@"d:\\tmp\\status.txt");
            }
            catch
            {
                using (StreamWriter writer = new StreamWriter("d:\\tmp\\status.txt", false))
                {
                   writer.WriteLine("");
                }
            }
            TextboxClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var datePickUp = dtpPickedup.Value.ToShortDateString();
            var dateDeliv = dtpDelivered.Value.ToShortDateString();
            string statId = txtStatusID.Text;
            string drivId = txtDriverID.Text;
            string statdetails;

            statdetails = "Status Id: "+ statId + " " + Environment.NewLine + "Driver Id: " + drivId + " " + Environment.NewLine + "Date Picked up: "+ datePickUp + " " + Environment.NewLine + "Date deliverd:" + dateDeliv + Environment.NewLine + Environment.NewLine;
            rtxtStatus.Text = rtxtStatus.Text + statdetails;


            using (StreamWriter writer = new StreamWriter("d:\\tmp\\status.txt", true))
            {
                writer.WriteLine(statdetails);
            }
            TextboxClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            rtxtStatus.Text = "";
            using (StreamWriter writer = new StreamWriter("d:\\tmp\\status.txt", false))
            {
                writer.WriteLine(rtxtStatus.Text);
            }
            TextboxClear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmStatus_Load(object sender, EventArgs e)
        {
            TextboxClear();
            String stsInfo = "Status information: " + Environment.NewLine;
            rtxtStatus.Text = stsInfo;

            using (StreamWriter writer = new StreamWriter("d:\\tmp\\status.txt", true))
            {
                writer.WriteLine(stsInfo);
            }
        }
    }
}
//6955 Laikin Barnard
