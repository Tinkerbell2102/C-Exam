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
    public partial class FrmAdresses : Form
    {
        
        public FrmAdresses()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2AAM5H7\\SQLEXPRESS;Initial Catalog=DBCtuLogistics;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        int AdressID;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            connection.Open();

            cmd = new SqlCommand("INSERT INTO frmAddress (ComplexNumber,ComplexName,Street,Suburb,City,Provice,Country,PostalCode)" +
                " VALUES ('" + txtCompNumber.Text + "', '" + txtCompName.Text + "', '" + txtStreet.Text + "', '" + txtSub.Text + "', '" + txtCity.Text + "', '" +  txtProvince.Text + "', '" + txtCountry.Text + "', " + txtPostalCode.Text + ")", connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Details Saved Successfully");
            connection.Close();

            displaydata();
            TextboxClear();
        }

        public void displaydata()
        {
            SqlDataAdapter SQLAddapt;
            DataTable dattbl;
            connection.Open();
            SQLAddapt = new SqlDataAdapter("Select * From frmAddress", connection);
            dattbl = new DataTable();
            SQLAddapt.Fill(dattbl);
            dtGridAdress.DataSource = dattbl;
            connection.Close();
        }

        public void TextboxClear()
        {
            txtCompNumber.Clear();
            txtCompName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtPostalCode.Clear();
            txtProvince.Clear();
            txtSub.Clear();
            txtCompNumber.Focus();
        }


        private void FrmAdresses_Load(object sender, EventArgs e)
        {
            txtCompNumber.Focus();
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
                cmd = new SqlCommand("Update frmAddress set ComplexNumber= '" + txtCompNumber.Text + "',ComplexName= '" + txtCompName.Text + "',Street= '" + txtStreet.Text + "',Suburb= '" + txtSub.Text + "',City= '" + txtCity.Text + "',Provice= '" + txtProvince.Text + "',Country= '" + txtCountry.Text + "',PostalCode= '" + txtPostalCode.Text + "' where ID = '" + AdressID + "'", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
                connection.Close();
                displaydata();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            cmd = new SqlCommand("delete from frmAddress where ID = "+ AdressID, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            connection.Close();
            displaydata();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtGridAdress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdressID = Convert.ToInt32(dtGridAdress.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCompNumber.Text = dtGridAdress.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStreet.Text = dtGridAdress.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCity.Text = dtGridAdress.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCountry.Text = dtGridAdress.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtProvince.Text = dtGridAdress.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSub.Text = dtGridAdress.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCompName.Text = dtGridAdress.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPostalCode.Text = dtGridAdress.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
//6955 Laikin Barnard
