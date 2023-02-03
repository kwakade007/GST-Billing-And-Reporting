namespace GST_Project
{
    partial class frmcustomer_rec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grocustomerre = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn3custdelete = new System.Windows.Forms.Button();
            this.btn2custupdate = new System.Windows.Forms.Button();
            this.btn1custadd = new System.Windows.Forms.Button();
            this.gro2Dispalyc = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb1custselect = new System.Windows.Forms.ComboBox();
            this.lab4disp = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.labcuscity = new System.Windows.Forms.Label();
            this.lab3cusph = new System.Windows.Forms.Label();
            this.lab2custadd = new System.Windows.Forms.Label();
            this.lab1custname = new System.Windows.Forms.Label();
            this.gro3Dispdet = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datag1Dispaly = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.grocustomerre.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gro2Dispalyc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gro3Dispdet.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datag1Dispaly)).BeginInit();
            this.SuspendLayout();
            // 
            // grocustomerre
            // 
            this.grocustomerre.Controls.Add(this.comboBox1);
            this.grocustomerre.Controls.Add(this.panel1);
            this.grocustomerre.Controls.Add(this.gro2Dispalyc);
            this.grocustomerre.Controls.Add(this.TxtAdress);
            this.grocustomerre.Controls.Add(this.TxtName);
            this.grocustomerre.Controls.Add(this.panel2);
            this.grocustomerre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grocustomerre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grocustomerre.Location = new System.Drawing.Point(12, 12);
            this.grocustomerre.Name = "grocustomerre";
            this.grocustomerre.Size = new System.Drawing.Size(363, 496);
            this.grocustomerre.TabIndex = 0;
            this.grocustomerre.TabStop = false;
            this.grocustomerre.Text = "Customer record";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn3custdelete);
            this.panel1.Controls.Add(this.btn2custupdate);
            this.panel1.Controls.Add(this.btn1custadd);
            this.panel1.Location = new System.Drawing.Point(6, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 54);
            this.panel1.TabIndex = 9;
            // 
            // btn3custdelete
            // 
            this.btn3custdelete.Location = new System.Drawing.Point(235, 12);
            this.btn3custdelete.Name = "btn3custdelete";
            this.btn3custdelete.Size = new System.Drawing.Size(75, 23);
            this.btn3custdelete.TabIndex = 2;
            this.btn3custdelete.Text = "Delete";
            this.btn3custdelete.UseVisualStyleBackColor = true;
            // 
            // btn2custupdate
            // 
            this.btn2custupdate.Location = new System.Drawing.Point(129, 12);
            this.btn2custupdate.Name = "btn2custupdate";
            this.btn2custupdate.Size = new System.Drawing.Size(75, 23);
            this.btn2custupdate.TabIndex = 1;
            this.btn2custupdate.Text = "Update";
            this.btn2custupdate.UseVisualStyleBackColor = true;
            // 
            // btn1custadd
            // 
            this.btn1custadd.Location = new System.Drawing.Point(27, 12);
            this.btn1custadd.Name = "btn1custadd";
            this.btn1custadd.Size = new System.Drawing.Size(75, 23);
            this.btn1custadd.TabIndex = 0;
            this.btn1custadd.Text = "Add";
            this.btn1custadd.UseVisualStyleBackColor = true;
            this.btn1custadd.Click += new System.EventHandler(this.btn1custadd_Click);
            // 
            // gro2Dispalyc
            // 
            this.gro2Dispalyc.Controls.Add(this.comboBox2);
            this.gro2Dispalyc.Controls.Add(this.label2);
            this.gro2Dispalyc.Controls.Add(this.cmb1custselect);
            this.gro2Dispalyc.Controls.Add(this.lab4disp);
            this.gro2Dispalyc.Controls.Add(this.panel3);
            this.gro2Dispalyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gro2Dispalyc.Location = new System.Drawing.Point(0, 346);
            this.gro2Dispalyc.Name = "gro2Dispalyc";
            this.gro2Dispalyc.Size = new System.Drawing.Size(357, 143);
            this.gro2Dispalyc.TabIndex = 1;
            this.gro2Dispalyc.TabStop = false;
            this.gro2Dispalyc.Text = "Display Choices";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search By City";
            // 
            // cmb1custselect
            // 
            this.cmb1custselect.FormattingEnabled = true;
            this.cmb1custselect.Location = new System.Drawing.Point(167, 45);
            this.cmb1custselect.Name = "cmb1custselect";
            this.cmb1custselect.Size = new System.Drawing.Size(156, 24);
            this.cmb1custselect.TabIndex = 1;
            this.cmb1custselect.SelectedIndexChanged += new System.EventHandler(this.cmb1custselect_SelectedIndexChanged);
            // 
            // lab4disp
            // 
            this.lab4disp.AutoSize = true;
            this.lab4disp.Location = new System.Drawing.Point(33, 47);
            this.lab4disp.Name = "lab4disp";
            this.lab4disp.Size = new System.Drawing.Size(128, 16);
            this.lab4disp.TabIndex = 0;
            this.lab4disp.Text = "Search By  Name";
            this.lab4disp.Click += new System.EventHandler(this.lab4disp_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(6, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 115);
            this.panel3.TabIndex = 4;
            // 
            // TxtAdress
            // 
            this.TxtAdress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtAdress.Location = new System.Drawing.Point(141, 93);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(198, 26);
            this.TxtAdress.TabIndex = 6;
            // 
            // TxtName
            // 
            this.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtName.Location = new System.Drawing.Point(141, 38);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(198, 26);
            this.TxtName.TabIndex = 4;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TxtContact);
            this.panel2.Controls.Add(this.labcuscity);
            this.panel2.Controls.Add(this.lab3cusph);
            this.panel2.Controls.Add(this.lab2custadd);
            this.panel2.Controls.Add(this.lab1custname);
            this.panel2.Location = new System.Drawing.Point(6, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 246);
            this.panel2.TabIndex = 11;
            // 
            // TxtContact
            // 
            this.TxtContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtContact.Location = new System.Drawing.Point(134, 185);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(198, 26);
            this.TxtContact.TabIndex = 7;
            // 
            // labcuscity
            // 
            this.labcuscity.AutoSize = true;
            this.labcuscity.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcuscity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labcuscity.Location = new System.Drawing.Point(25, 136);
            this.labcuscity.Name = "labcuscity";
            this.labcuscity.Size = new System.Drawing.Size(41, 20);
            this.labcuscity.TabIndex = 10;
            this.labcuscity.Text = "City";
            // 
            // lab3cusph
            // 
            this.lab3cusph.AutoSize = true;
            this.lab3cusph.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3cusph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab3cusph.Location = new System.Drawing.Point(20, 191);
            this.lab3cusph.Name = "lab3cusph";
            this.lab3cusph.Size = new System.Drawing.Size(85, 20);
            this.lab3cusph.TabIndex = 8;
            this.lab3cusph.Text = "Phone No:";
            this.lab3cusph.Click += new System.EventHandler(this.llable3_Click);
            // 
            // lab2custadd
            // 
            this.lab2custadd.AutoSize = true;
            this.lab2custadd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2custadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab2custadd.Location = new System.Drawing.Point(20, 83);
            this.lab2custadd.Name = "lab2custadd";
            this.lab2custadd.Size = new System.Drawing.Size(68, 20);
            this.lab2custadd.TabIndex = 5;
            this.lab2custadd.Text = "Address";
            // 
            // lab1custname
            // 
            this.lab1custname.AutoSize = true;
            this.lab1custname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1custname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab1custname.Location = new System.Drawing.Point(24, 22);
            this.lab1custname.Name = "lab1custname";
            this.lab1custname.Size = new System.Drawing.Size(53, 20);
            this.lab1custname.TabIndex = 3;
            this.lab1custname.Text = "Name";
            // 
            // gro3Dispdet
            // 
            this.gro3Dispdet.Controls.Add(this.panel4);
            this.gro3Dispdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gro3Dispdet.Location = new System.Drawing.Point(390, 13);
            this.gro3Dispdet.Name = "gro3Dispdet";
            this.gro3Dispdet.Size = new System.Drawing.Size(859, 495);
            this.gro3Dispdet.TabIndex = 2;
            this.gro3Dispdet.TabStop = false;
            this.gro3Dispdet.Text = "Display Detail";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.datag1Dispaly);
            this.panel4.Location = new System.Drawing.Point(6, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(847, 474);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // datag1Dispaly
            // 
            this.datag1Dispaly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datag1Dispaly.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.datag1Dispaly.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datag1Dispaly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datag1Dispaly.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.datag1Dispaly.Location = new System.Drawing.Point(5, 5);
            this.datag1Dispaly.Name = "datag1Dispaly";
            this.datag1Dispaly.Size = new System.Drawing.Size(837, 463);
            this.datag1Dispaly.TabIndex = 0;
            this.datag1Dispaly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datag1Dispaly_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Address";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "City";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone No.";
            this.Column4.Name = "Column4";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 520);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // frmcustomer_rec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1261, 520);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gro3Dispdet);
            this.Controls.Add(this.grocustomerre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 180);
            this.Name = "frmcustomer_rec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmcustomer_rec";
            this.Load += new System.EventHandler(this.frmcustomer_rec_Load);
            this.grocustomerre.ResumeLayout(false);
            this.grocustomerre.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gro2Dispalyc.ResumeLayout(false);
            this.gro2Dispalyc.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gro3Dispdet.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datag1Dispaly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grocustomerre;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lab3cusph;
        private System.Windows.Forms.Label lab2custadd;
        private System.Windows.Forms.Label lab1custname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn3custdelete;
        private System.Windows.Forms.Button btn2custupdate;
        private System.Windows.Forms.Button btn1custadd;
        private System.Windows.Forms.GroupBox gro2Dispalyc;
        private System.Windows.Forms.ComboBox cmb1custselect;
        private System.Windows.Forms.Label lab4disp;
        private System.Windows.Forms.GroupBox gro3Dispdet;
        private System.Windows.Forms.DataGridView datag1Dispaly;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labcuscity;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}