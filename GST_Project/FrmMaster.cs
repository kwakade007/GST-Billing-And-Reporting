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
    public partial class FrmMaster : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=gstb;UID=root;PASSWORD='';");

        public FrmMaster()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmMaster_Load(object sender, EventArgs e)
        {
            connection.Open();

            string query = "select * from  master";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader rd;
            rd = cmd.ExecuteReader();
            DGVMaster.Rows.Clear();
            while (rd.Read())
            {
                DGVMaster.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);
            
            }

            connection.Close();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  MessageBox.Show("sdf");

            if (DGVMaster.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Txt1name.Text = DGVMaster.Rows[e.RowIndex].Cells[0].Value.ToString();
                Txt2Iniqut.Text  = DGVMaster.Rows[e.RowIndex].Cells[1].Value.ToString();
                Txt3CGST.Text  = DGVMaster.Rows[e.RowIndex].Cells[2].Value.ToString();
                Txt4SGST.Text  = DGVMaster.Rows[e.RowIndex].Cells[3].Value.ToString();
                Txt5purrate.Text  = DGVMaster.Rows[e.RowIndex].Cells[4].Value.ToString();
                Txt6Selling.Text  = DGVMaster.Rows[e.RowIndex].Cells[0].Value.ToString();


              
            }
           
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn1mastadd_Click(object sender, EventArgs e)
        {
            //'"+textboxname.text+"' for varchar
            //"+textboxname.text+" for other than  varchar

            connection.Open();
            string query = "INSERT INTO master (Name,Initial_quantity,CGST,SGST,Purchising_rate,Selling_rate) VALUES('" +Txt1name.Text+ "','" + Txt2Iniqut.Text + "','" +Txt3CGST.Text + "','" + Txt4SGST.Text + "','" +Txt5purrate.Text + "','" + Txt6Selling.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, connection);
           
            //Execute command
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Data inserted");
            connection.Close();


            ///////////////////////////////////////////////////////////////////////// Adding data in master ////////////////////////////////////////////

            connection.Open();
            string query2 = "INSERT INTO stock (Prod_Name,Qty) VALUES('" + Txt1name.Text + "','" + Txt2Iniqut.Text + "')";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);

            //Execute command
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Data inserted");
            connection.Close();
            /////////////////////////////////////////////////////////////////////////////////////////////// displaying data ///////////////////////////////


            connection.Open();

            string query3 = "select * from  master";
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);

            MySqlDataReader rd;
            rd = cmd3.ExecuteReader();
            DGVMaster.Rows.Clear();
            while (rd.Read())
            {
                DGVMaster.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);

            }

            connection.Close();
           



        }

        

        private void DGVMaster_Click_1(object sender, EventArgs e)
        {
            foreach(DataGridView row in DGVMaster.SelectedRows)
            {

            string i = row[0, 1].Value.ToString();
            MessageBox.Show(i);
             
            }

        }

        private void btn3mastdelete_Click(object sender, EventArgs e)
        {
            connection.Open();

            string query3 = "delete  from  master where Name='" + Txt1name.Text + "'";
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("record deleted");
            connection.Close();

            /////////////////////////////////////////////////////////////////////////////////////////////// displaying data ///////////////////////////////


            connection.Open();

            string query4 = "select * from  master";
            MySqlCommand cmd4 = new MySqlCommand(query4, connection);

            MySqlDataReader rd;
            rd = cmd4.ExecuteReader();
            DGVMaster.Rows.Clear();
            while (rd.Read())
            {
                DGVMaster.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);

            }

            connection.Close();
        }

        private void btn2matupdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            //string query = "INSERT INTO master (Name,Initial_quantity,CGST,SGST,Purchising_rate,Selling_rate) VALUES('" + Txt1name.Text + "','" + Txt2Iniqut.Text + "','" + Txt3CGST.Text + "','" + Txt4SGST.Text + "','" + Txt5purrate.Text + "','" + Txt6Selling.Text + "')";


            string query3 = "update master set Initial_quantity='" + Txt2Iniqut.Text + "',CGST='" + Txt3CGST.Text + "',SGST='" + Txt4SGST.Text + "',Purchising_rate='" + Txt5purrate.Text + "',Selling_rate='" + Txt6Selling.Text + "'  where Name='" + Txt1name.Text + "'";
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("record update");
            connection.Close();

            /////////////////////////////////////////////////////////////////////////////////////////////// displaying data ///////////////////////////////


            connection.Open();

            string query4 = "select * from  master";
            MySqlCommand cmd4 = new MySqlCommand(query4, connection);

            MySqlDataReader rd;
            rd = cmd4.ExecuteReader();
            DGVMaster.Rows.Clear();
            while (rd.Read())
            {
                DGVMaster.Rows.Add(rd[0], rd[1], rd[2], rd[3], rd[4], rd[5]);

            }

            connection.Close();
        }
    }
}
