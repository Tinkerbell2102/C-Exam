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
    public partial class FrmCustomers : Form
    {

        public FrmCustomers()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2AAM5H7\\SQLEXPRESS;Initial Catalog=DBCtuLogistics;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        int CustomerID;
        String AddID = "";

        public void displaydata()
        {
            SqlDataAdapter SQLAddapt;
            DataTable dattbl;

            connection.Open();
            SQLAddapt = new SqlDataAdapter("Select * From frmCustomer", connection);
            dattbl = new DataTable();
            SQLAddapt.Fill(dattbl);
            dtgCustomer.DataSource = dattbl;
            connection.Close();
        }

        public void TextboxClear()
        {
            txtCustName.Clear();
            txtCustNumber.Clear();
            txtCustEmail.Clear();
            txtCustName.Focus();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            connection.Open();

            cmd = new SqlCommand("INSERT INTO  frmCustomer (Fullname,ContactNumber,Email,AdressId) " +
                "VALUES('" + txtCustName.Text + "', '" + txtCustNumber.Text + "', '" + txtCustEmail.Text + "', 1 )", connection);
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
            try
            {
                connection.Open();
                cmd = new SqlCommand("Update frmCustomer set Fullname= '" + txtCustName.Text + "',ContactNumber= '" + txtCustNumber.Text + "',Email= '" + txtCustEmail.Text + "', AdressID = '" + AddID + "' where CustomerID = '" + CustomerID + "'", connection);
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
            cmd = new SqlCommand("delete from frmCustomer where CustomerID = " + CustomerID + "", connection);
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

        private void dtgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerID = Convert.ToInt32(dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCustName.Text = dtgCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCustNumber.Text = dtgCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCustEmail.Text = dtgCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            txtCustName.Focus();
        }
    }
}
//6955 Laikin Barnard
