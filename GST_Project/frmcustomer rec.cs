using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GST_Project
{
    public partial class frmcustomer_rec : Form
    {
        MySqlConnection connection= new MySqlConnection("SERVER=localhost;DATABASE=gstb;UID=root;PASSWORD='';");
          
        public frmcustomer_rec()
        {
            InitializeComponent();
        }

        private void llable3_Click(object sender, EventArgs e)
        {

        }

        private void cmb1custselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lab4disp_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datag1Dispaly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1custadd_Click(object sender, EventArgs e)
        {
            //'"+textboxname.text+"' for varchar
            //"+textboxname.text+" for other than  varchar

            connection.Open();
            string query = "INSERT INTO customer_record (Name,Address,City,Phone_No) VALUES('" +TxtName.Text + "','" + TxtAdress.Text + "','" + comboBox1.Text + "','" + TxtContact.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted");
            connection.Close();
        }

        private void frmcustomer_rec_Load(object sender, EventArgs e)
        {

        }
    }
}
