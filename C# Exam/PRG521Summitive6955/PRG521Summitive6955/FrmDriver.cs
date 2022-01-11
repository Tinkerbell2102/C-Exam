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
    public partial class FrmDriver : Form
    {
        public FrmDriver()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2AAM5H7\\SQLEXPRESS;Initial Catalog=DBCtuLogistics;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        int DriverID;

        public void displaydata()
        {
            SqlDataAdapter SQLAddapt;
            DataTable dattbl;

            connection.Open();
            SQLAddapt = new SqlDataAdapter("Select * From frmDriver", connection);
            dattbl = new DataTable();
            SQLAddapt.Fill(dattbl);
            dtgDriver.DataSource = dattbl;
            connection.Close();
        }

        public void TextboxClear()
        {
            txtDFullname.Clear();
            cmbLicenseType.Text = "";
            txtDFullname.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String Owner = "";
            bool isChecked = rbtnOYes.Checked;
            if (isChecked)
                Owner = rbtnOYes.Text;
            else
                Owner = rbtnONo.Text;

            connection.Open();
            cmd = new SqlCommand("INSERT INTO frmDriver (FullName, LicenseType, Owner) " +
                "VALUES('" + txtDFullname.Text + "', '" + cmbLicenseType.Text + "','" + Owner + "')", connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Details Saved Successfully");
            connection.Close();
            displaydata();
            TextboxClear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Owner = "";
            bool isChecked = rbtnOYes.Checked;
            if (isChecked)
                Owner = rbtnOYes.Text;
            else
                Owner = rbtnONo.Text;

            try
            {
                connection.Open();
                cmd = new SqlCommand("Update frmDriver set FullName= '" + txtDFullname.Text + "',LicenseType = '" + cmbLicenseType.Text + "',Owner = '" + Owner + "' where DriverID = '" + DriverID + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
                connection.Close();
                displaydata();
                TextboxClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("delete from frmDriver where DriverID = " + DriverID + "", connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            connection.Close();
            displaydata();
            TextboxClear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgDriver_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Owner = "";
            bool isChecked = rbtnOYes.Checked;
            if (isChecked)
                Owner = rbtnOYes.Text;
            else
                Owner = rbtnONo.Text;

            DriverID = Convert.ToInt32(dtgDriver.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDFullname.Text = dtgDriver.Rows[e.RowIndex].Cells[1].Value.ToString();
            Owner = dtgDriver.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbLicenseType.Text = dtgDriver.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void FrmDriver_Load(object sender, EventArgs e)
        {
            txtDFullname.Focus();
        }
    }
}
//6955 Laikin Barnard
