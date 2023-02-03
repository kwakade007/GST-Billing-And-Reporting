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
    public partial class FrmPurchising : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=gstb;UID=root;PASSWORD='';");
        public FrmPurchising()
        {
            
            InitializeComponent();
        }

        private void FrmPurchising_Load(object sender, EventArgs e)
        {

        }

        private void btn2itnext_Click(object sender, EventArgs e)
        {
            //'"+textboxname.text+"' for varchar
            //"+textboxname.text+" for other than  varchar

            connection.Open();
            string query = "INSERT INTO customer_record (Bill_No,Date,Sr_No,Product,Qty,Total_Amt,CGST,SGST,Gross_Total_Amt) VALUES('" +TxtBillno.Text+ "','" + TxtDate.Text + "','" + TxtSrNo.Text + "','" + CmbItem.Text + "','" + TxtQty.Text + "','" + TxtTotalAmt.Text + "','" + TxtCGST.Text + "''" + TxtSGST.Text + "','" + TxtGrossTA.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //Execute command
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted");
            connection.Close();
        }

        
        

    }
}
