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
    public partial class frmDealersRec : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=gstb;UID=root;PASSWORD='';");
          
        public frmDealersRec()
        {
            InitializeComponent();
        }

        private void lab2deladd_Click(object sender, EventArgs e)
        {

        }

        private void lab4delcity_Click(object sender, EventArgs e)
        {

        }

        private void lab5delph_Click(object sender, EventArgs e)
        {

        }

        private void grocustomerre_Enter(object sender, EventArgs e)
        {

        }

        private void gru3deldisdetails_Enter(object sender, EventArgs e)
        {

        }

        private void btn1deladd_Click(object sender, EventArgs e)
        {

            //'"+textboxname.text+"' for varchar
            //"+textboxname.text+" for other than  varchar

            connection.Open();
            string query = "INSERT INTO dealer_record (Name,Product,Address,City,Phone_N0,GST_NO) VALUES('" +TxtName.Text + "','"+TxtProduct.Text+"','" + TxtAdress.Text + "','" + cmb1city.Text + "','" + TxtContact.Text+ "','"+Txt4GSTno.Text+"')";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted");
            connection.Close();

            
            /////////////////////////////////////////////////////////////////////////////////////////////// displaying data ///////////////////////////////


            connection.Open();

            string query3 = "select * from dealer_record";
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);

            MySqlDataReader rd;
            rd = cmd3.ExecuteReader();
            DGV1delDispaly.Rows.Clear();
            while (rd.Read())
            {
                DGV1delDispaly.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);

            }

            connection.Close();
           
        }

        private void frmDealersRec_Load(object sender, EventArgs e)
        {
            connection.Open();

            string query = "select * from  dealer_record";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            DGV1delDispaly.Rows.Clear();
            while (rd.Read())
            {
                DGV1delDispaly.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);

            }

            connection.Close();
        }

        private void DGV1delDispaly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  MessageBox.Show("sdf");

            if (DGV1delDispaly.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                TxtName.Text = DGV1delDispaly.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxtProduct. Text = DGV1delDispaly.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxtAdress. Text = DGV1delDispaly.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmb1city.Text = DGV1delDispaly.Rows[e.RowIndex].Cells[3].Value.ToString();
                TxtContact.Text = DGV1delDispaly.Rows[e.RowIndex].Cells[4].Value.ToString();
                Txt4GSTno.Text = DGV1delDispaly.Rows[e.RowIndex].Cells[0].Value.ToString();



            }
        }

        private void btn2delupdate_Click(object sender, EventArgs e)
        {
            connection.Open();

            string query3 = "update dealer_record set Initial_quantity='" + Txt2Iniqut.Text + "',CGST='" + Txt3CGST.Text + "',SGST='" + Txt4SGST.Text + "',Purchising_rate='" + Txt5purrate.Text + "',Selling_rate='" + Txt6Selling.Text + "'  where Name='" + Txt1name.Text + "'";
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("record update");
            connection.Close();
        }
    }
}
