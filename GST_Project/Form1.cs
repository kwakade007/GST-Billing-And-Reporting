using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GST_Project
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel2.Visible = false;

            string un, pwd;

            //un = TxtUserName.Text;
            //pwd = TxtPassword.Text;
            //if (un == "Tirupati" && pwd == "1234")
            //{
            //    MessageBox.Show("Login sucessfull");
            //    panel1.Visible = true;
            //    panel2.Visible = false;
            //    //Form2 frm = new Form2();
            //    //frm.Show();


            //}
            //else
            //{
            //    MessageBox.Show("Login unsucessfull");

            //    TxtUserName.Text = "";
            //    TxtPassword.Text = "";
            //}

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnmaster_Click(object sender, EventArgs e)
        {
            FrmMaster frm = new FrmMaster();
            frm.Show();
        }

        private void btncustomersrec_Click(object sender, EventArgs e)
        {
            frmcustomer_rec frm=new frmcustomer_rec();
            frm.Show();
        }

        private void btndealersrec_Click(object sender, EventArgs e)
        {
            frmDealersRec frm = new frmDealersRec();
            frm.Show();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            FrmStok frm = new FrmStok();
            frm.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnselling_Click(object sender, EventArgs e)
        {
            frmSelling frm = new frmSelling();
            frm.Show();
        }

        private void btnreporting_Click(object sender, EventArgs e)
        {
            FrmReporting frm = new FrmReporting();
            frm.Show();

        }

        private void btnpurchising_Click(object sender, EventArgs e)
        {
            FrmPurchising frm = new FrmPurchising();
            frm.Show();
        }
    }
}
