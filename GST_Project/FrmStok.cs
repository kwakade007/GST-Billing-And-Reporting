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
    public partial class FrmStok : Form
    {
        MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=gstb;UID=root;PASSWORD='';");
        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {

        }
    }
}
