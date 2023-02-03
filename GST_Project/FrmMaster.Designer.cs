namespace GST_Project
{
    partial class FrmMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVMaster = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn3mastdelete = new System.Windows.Forms.Button();
            this.btn2matupdate = new System.Windows.Forms.Button();
            this.btn1mastadd = new System.Windows.Forms.Button();
            this.Txt6Selling = new System.Windows.Forms.TextBox();
            this.Txt5purrate = new System.Windows.Forms.TextBox();
            this.Txt4SGST = new System.Windows.Forms.TextBox();
            this.Txt3CGST = new System.Windows.Forms.TextBox();
            this.Txt2Iniqut = new System.Windows.Forms.TextBox();
            this.Txt1name = new System.Windows.Forms.TextBox();
            this.lab6mastsell = new System.Windows.Forms.Label();
            this.lab5mastpurc = new System.Windows.Forms.Label();
            this.lab4mastsgst = new System.Windows.Forms.Label();
            this.lab3mastcgst = new System.Windows.Forms.Label();
            this.lab2mastini = new System.Windows.Forms.Label();
            this.lab1mastname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gro2masterfor = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaster)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gro2masterfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVMaster
            // 
            this.DGVMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGVMaster.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DGVMaster.Location = new System.Drawing.Point(13, 20);
            this.DGVMaster.Name = "DGVMaster";
            this.DGVMaster.Size = new System.Drawing.Size(855, 416);
            this.DGVMaster.TabIndex = 15;
            this.DGVMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGVMaster.Click += new System.EventHandler(this.DGVMaster_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.Txt6Selling);
            this.groupBox2.Controls.Add(this.Txt5purrate);
            this.groupBox2.Controls.Add(this.Txt4SGST);
            this.groupBox2.Controls.Add(this.Txt3CGST);
            this.groupBox2.Controls.Add(this.Txt2Iniqut);
            this.groupBox2.Controls.Add(this.Txt1name);
            this.groupBox2.Controls.Add(this.lab6mastsell);
            this.groupBox2.Controls.Add(this.lab5mastpurc);
            this.groupBox2.Controls.Add(this.lab4mastsgst);
            this.groupBox2.Controls.Add(this.lab3mastcgst);
            this.groupBox2.Controls.Add(this.lab2mastini);
            this.groupBox2.Controls.Add(this.lab1mastname);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 448);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Master form";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn3mastdelete);
            this.panel2.Controls.Add(this.btn2matupdate);
            this.panel2.Controls.Add(this.btn1mastadd);
            this.panel2.Location = new System.Drawing.Point(6, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 53);
            this.panel2.TabIndex = 36;
            // 
            // btn3mastdelete
            // 
            this.btn3mastdelete.Location = new System.Drawing.Point(231, 8);
            this.btn3mastdelete.Name = "btn3mastdelete";
            this.btn3mastdelete.Size = new System.Drawing.Size(75, 35);
            this.btn3mastdelete.TabIndex = 25;
            this.btn3mastdelete.Text = "Delete";
            this.btn3mastdelete.UseVisualStyleBackColor = true;
            this.btn3mastdelete.Click += new System.EventHandler(this.btn3mastdelete_Click);
            // 
            // btn2matupdate
            // 
            this.btn2matupdate.Location = new System.Drawing.Point(126, 8);
            this.btn2matupdate.Name = "btn2matupdate";
            this.btn2matupdate.Size = new System.Drawing.Size(75, 35);
            this.btn2matupdate.TabIndex = 24;
            this.btn2matupdate.Text = "Update";
            this.btn2matupdate.UseVisualStyleBackColor = true;
            this.btn2matupdate.Click += new System.EventHandler(this.btn2matupdate_Click);
            // 
            // btn1mastadd
            // 
            this.btn1mastadd.Location = new System.Drawing.Point(13, 8);
            this.btn1mastadd.Name = "btn1mastadd";
            this.btn1mastadd.Size = new System.Drawing.Size(75, 35);
            this.btn1mastadd.TabIndex = 23;
            this.btn1mastadd.Text = "Add";
            this.btn1mastadd.UseVisualStyleBackColor = true;
            this.btn1mastadd.Click += new System.EventHandler(this.btn1mastadd_Click);
            // 
            // Txt6Selling
            // 
            this.Txt6Selling.Location = new System.Drawing.Point(159, 292);
            this.Txt6Selling.Name = "Txt6Selling";
            this.Txt6Selling.Size = new System.Drawing.Size(154, 22);
            this.Txt6Selling.TabIndex = 35;
            // 
            // Txt5purrate
            // 
            this.Txt5purrate.Location = new System.Drawing.Point(159, 245);
            this.Txt5purrate.Name = "Txt5purrate";
            this.Txt5purrate.Size = new System.Drawing.Size(154, 22);
            this.Txt5purrate.TabIndex = 34;
            // 
            // Txt4SGST
            // 
            this.Txt4SGST.Location = new System.Drawing.Point(159, 195);
            this.Txt4SGST.Name = "Txt4SGST";
            this.Txt4SGST.Size = new System.Drawing.Size(154, 22);
            this.Txt4SGST.TabIndex = 33;
            // 
            // Txt3CGST
            // 
            this.Txt3CGST.Location = new System.Drawing.Point(159, 144);
            this.Txt3CGST.Name = "Txt3CGST";
            this.Txt3CGST.Size = new System.Drawing.Size(154, 22);
            this.Txt3CGST.TabIndex = 32;
            // 
            // Txt2Iniqut
            // 
            this.Txt2Iniqut.Location = new System.Drawing.Point(159, 91);
            this.Txt2Iniqut.Name = "Txt2Iniqut";
            this.Txt2Iniqut.Size = new System.Drawing.Size(154, 22);
            this.Txt2Iniqut.TabIndex = 31;
            // 
            // Txt1name
            // 
            this.Txt1name.Location = new System.Drawing.Point(159, 47);
            this.Txt1name.Name = "Txt1name";
            this.Txt1name.Size = new System.Drawing.Size(154, 22);
            this.Txt1name.TabIndex = 30;
            // 
            // lab6mastsell
            // 
            this.lab6mastsell.AutoSize = true;
            this.lab6mastsell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab6mastsell.Location = new System.Drawing.Point(17, 298);
            this.lab6mastsell.Name = "lab6mastsell";
            this.lab6mastsell.Size = new System.Drawing.Size(93, 16);
            this.lab6mastsell.TabIndex = 29;
            this.lab6mastsell.Text = "Selling Rate";
            // 
            // lab5mastpurc
            // 
            this.lab5mastpurc.AutoSize = true;
            this.lab5mastpurc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab5mastpurc.Location = new System.Drawing.Point(17, 245);
            this.lab5mastpurc.Name = "lab5mastpurc";
            this.lab5mastpurc.Size = new System.Drawing.Size(116, 16);
            this.lab5mastpurc.TabIndex = 28;
            this.lab5mastpurc.Text = "Purchasing rate";
            // 
            // lab4mastsgst
            // 
            this.lab4mastsgst.AutoSize = true;
            this.lab4mastsgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab4mastsgst.Location = new System.Drawing.Point(17, 195);
            this.lab4mastsgst.Name = "lab4mastsgst";
            this.lab4mastsgst.Size = new System.Drawing.Size(49, 16);
            this.lab4mastsgst.TabIndex = 27;
            this.lab4mastsgst.Text = "SGST";
            // 
            // lab3mastcgst
            // 
            this.lab3mastcgst.AutoSize = true;
            this.lab3mastcgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3mastcgst.Location = new System.Drawing.Point(17, 144);
            this.lab3mastcgst.Name = "lab3mastcgst";
            this.lab3mastcgst.Size = new System.Drawing.Size(49, 16);
            this.lab3mastcgst.TabIndex = 26;
            this.lab3mastcgst.Text = "CGST";
            // 
            // lab2mastini
            // 
            this.lab2mastini.AutoSize = true;
            this.lab2mastini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2mastini.Location = new System.Drawing.Point(17, 91);
            this.lab2mastini.Name = "lab2mastini";
            this.lab2mastini.Size = new System.Drawing.Size(103, 16);
            this.lab2mastini.TabIndex = 25;
            this.lab2mastini.Text = "Initial quantity";
            // 
            // lab1mastname
            // 
            this.lab1mastname.AutoSize = true;
            this.lab1mastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1mastname.Location = new System.Drawing.Point(17, 47);
            this.lab1mastname.Name = "lab1mastname";
            this.lab1mastname.Size = new System.Drawing.Size(106, 16);
            this.lab1mastname.TabIndex = 24;
            this.lab1mastname.Text = "Product Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 346);
            this.panel1.TabIndex = 37;
            // 
            // gro2masterfor
            // 
            this.gro2masterfor.Controls.Add(this.DGVMaster);
            this.gro2masterfor.Controls.Add(this.panel3);
            this.gro2masterfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gro2masterfor.Location = new System.Drawing.Point(380, 15);
            this.gro2masterfor.Name = "gro2masterfor";
            this.gro2masterfor.Size = new System.Drawing.Size(878, 448);
            this.gro2masterfor.TabIndex = 21;
            this.gro2masterfor.TabStop = false;
            this.gro2masterfor.Text = "Master details";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(6, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 429);
            this.panel3.TabIndex = 16;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Initial Quantity";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CGST";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SGST";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Purchase Rate";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Selling Rate";
            this.Column6.Name = "Column6";
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1261, 469);
            this.Controls.Add(this.gro2masterfor);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 180);
            this.Name = "FrmMaster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmMaster";
            this.Load += new System.EventHandler(this.FrmMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMaster)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gro2masterfor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMaster;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt6Selling;
        private System.Windows.Forms.TextBox Txt5purrate;
        private System.Windows.Forms.TextBox Txt4SGST;
        private System.Windows.Forms.TextBox Txt3CGST;
        private System.Windows.Forms.TextBox Txt2Iniqut;
        private System.Windows.Forms.TextBox Txt1name;
        private System.Windows.Forms.Label lab6mastsell;
        private System.Windows.Forms.Label lab5mastpurc;
        private System.Windows.Forms.Label lab4mastsgst;
        private System.Windows.Forms.Label lab3mastcgst;
        private System.Windows.Forms.Label lab2mastini;
        private System.Windows.Forms.Label lab1mastname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn3mastdelete;
        private System.Windows.Forms.Button btn2matupdate;
        private System.Windows.Forms.Button btn1mastadd;
        private System.Windows.Forms.GroupBox gro2masterfor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;

    }
}