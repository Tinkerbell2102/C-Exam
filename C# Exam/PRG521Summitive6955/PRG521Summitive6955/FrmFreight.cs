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
    public partial class FrmFreight : Form
    {
        public FrmFreight()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2AAM5H7\\SQLEXPRESS;Initial Catalog=DBCtuLogistics;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        int FreightID;


        public void displaydata()
        {
            SqlDataAdapter SQLAddapt;
            DataTable dattbl;

            connection.Open();
            SQLAddapt = new SqlDataAdapter("Select * From frmFreight", connection);
            dattbl = new DataTable();
            SQLAddapt.Fill(dattbl);
            dtgFreight.DataSource = dattbl;
            connection.Close();
        }

        public void TextboxClear()
        {
            txtHeight.Clear();
            txtWeight.Clear();
            txtLenght.Clear();
            txtOrginAdd.Clear();
            txtDest.Clear();
            txtCustNum.Clear();
            cmbStatus.Text = "";
            txtCustNum.Focus();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var dates = dtpFreight.Value.ToShortDateString();
            
            connection.Open();
            cmd = new SqlCommand("INSERT INTO frmFreight (CustomerID,Height,Weight,Lenght,DestanationAdressID,OrginAdressID,StatusID,FreightDate)" +
                "VALUES(" + 2 + ",'" + txtHeight.Text + "', '" + txtWeight.Text + "', '" + txtLenght.Text + "', '" + txtDest.Text + "', '" + txtOrginAdd.Text + "', '" + cmbStatus.Text + "', '" + dates + "')", connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Address Details Saved Successfully");
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
            var dates = dtpFreight.Value.ToShortDateString();
            
            try
            {
                connection.Open();
                cmd = new SqlCommand("Update frmFreight set CustomerID = '" + txtCustNum.Text + "',Height = '" + txtHeight.Text + "',Weight = '" + txtWeight.Text + "',Lenght = '" + txtLenght.Text + "',DestanationAdressID = '" + txtDest.Text + "',OrginAdressID = '" + txtOrginAdd.Text + "',StatusID = '" + cmbStatus.Text + "',FreightDate = '" + dates + "' where ID = '" + FreightID + "'", connection);
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
            var dates = dtpFreight.Value.ToShortDateString();
            
            connection.Open();
            cmd = new SqlCommand("delete from frmFreight where ID = '" + FreightID + "'", connection);
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

        private void dtgFreight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dates = dtpFreight.Value.ToShortDateString();

            FreightID = Convert.ToInt32(dtgFreight.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtHeight.Text = dtgFreight.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtWeight.Text = dtgFreight.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLenght.Text = dtgFreight.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDest.Text = dtgFreight.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtOrginAdd.Text = dtgFreight.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCustNum.Text = dtgFreight.Rows[e.RowIndex].Cells[1].Value.ToString();
            dates = dtgFreight.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbStatus.Text = dtgFreight.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void FrmFreight_Load(object sender, EventArgs e)
        {
            txtCustNum.Focus();
        }
    }
}
//6955 Laikin Barnard
