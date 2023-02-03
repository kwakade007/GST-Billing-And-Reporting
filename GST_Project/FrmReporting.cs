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
    public partial class FrmReporting : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=gstb;UID=root;PASSWORD='';");
        public FrmReporting()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void FrmReporting_Load(object sender, EventArgs e)
        {

        }
    }
}
