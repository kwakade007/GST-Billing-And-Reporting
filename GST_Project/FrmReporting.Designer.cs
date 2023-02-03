namespace GST_Project
{
    partial class FrmReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporting));
            this.lab2cumdelname = new System.Windows.Forms.Label();
            this.CmbName = new System.Windows.Forms.ComboBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.gro1repdisbilin = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn3disprint = new System.Windows.Forms.Button();
            this.btn4disaddacc = new System.Windows.Forms.Button();
            this.TxtInvoicw = new System.Windows.Forms.TextBox();
            this.lab1isbilno = new System.Windows.Forms.Label();
            this.btn2dispriit = new System.Windows.Forms.Button();
            this.btn1disall = new System.Windows.Forms.Button();
            this.DGVdisbilin = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtAddres = new System.Windows.Forms.TextBox();
            this.TxtBillDate = new System.Windows.Forms.TextBox();
            this.TxtInvoiceNo = new System.Windows.Forms.TextBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtRemain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTotalAmt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtVat5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lab3cumdelbilno = new System.Windows.Forms.Label();
            this.lab6umdelphone = new System.Windows.Forms.Label();
            this.gro2cumdel = new System.Windows.Forms.GroupBox();
            this.lab5cumdelAdd = new System.Windows.Forms.Label();
            this.lab4cumdelTxtDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.gro1repdisbilin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdisbilin)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gro2cumdel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab2cumdelname
            // 
            this.lab2cumdelname.AutoSize = true;
            this.lab2cumdelname.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2cumdelname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab2cumdelname.Location = new System.Drawing.Point(12, 32);
            this.lab2cumdelname.Name = "lab2cumdelname";
            this.lab2cumdelname.Size = new System.Drawing.Size(53, 20);
            this.lab2cumdelname.TabIndex = 27;
            this.lab2cumdelname.Text = "Name";
            // 
            // CmbName
            // 
            this.CmbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbName.FormattingEnabled = true;
            this.CmbName.Location = new System.Drawing.Point(184, 25);
            this.CmbName.Name = "CmbName";
            this.CmbName.Size = new System.Drawing.Size(198, 27);
            this.CmbName.TabIndex = 26;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPhoneNumber.Location = new System.Drawing.Point(184, 162);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(198, 26);
            this.TxtPhoneNumber.TabIndex = 12;
            // 
            // gro1repdisbilin
            // 
            this.gro1repdisbilin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gro1repdisbilin.Controls.Add(this.panel2);
            this.gro1repdisbilin.Controls.Add(this.DGVdisbilin);
            this.gro1repdisbilin.Controls.Add(this.panel1);
            this.gro1repdisbilin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gro1repdisbilin.ForeColor = System.Drawing.Color.Black;
            this.gro1repdisbilin.Location = new System.Drawing.Point(19, 8);
            this.gro1repdisbilin.Name = "gro1repdisbilin";
            this.gro1repdisbilin.Size = new System.Drawing.Size(788, 504);
            this.gro1repdisbilin.TabIndex = 20;
            this.gro1repdisbilin.TabStop = false;
            this.gro1repdisbilin.Text = "Display Bill Info";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn3disprint);
            this.panel2.Controls.Add(this.btn4disaddacc);
            this.panel2.Controls.Add(this.TxtInvoicw);
            this.panel2.Controls.Add(this.lab1isbilno);
            this.panel2.Controls.Add(this.btn2dispriit);
            this.panel2.Controls.Add(this.btn1disall);
            this.panel2.Location = new System.Drawing.Point(7, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 51);
            this.panel2.TabIndex = 20;
            // 
            // btn3disprint
            // 
            this.btn3disprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3disprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn3disprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn3disprint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3disprint.ForeColor = System.Drawing.Color.Black;
            this.btn3disprint.Location = new System.Drawing.Point(505, 11);
            this.btn3disprint.Name = "btn3disprint";
            this.btn3disprint.Size = new System.Drawing.Size(92, 28);
            this.btn3disprint.TabIndex = 18;
            this.btn3disprint.Text = "Print";
            this.btn3disprint.UseVisualStyleBackColor = true;
            // 
            // btn4disaddacc
            // 
            this.btn4disaddacc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4disaddacc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn4disaddacc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn4disaddacc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4disaddacc.ForeColor = System.Drawing.Color.Black;
            this.btn4disaddacc.Location = new System.Drawing.Point(603, 11);
            this.btn4disaddacc.Name = "btn4disaddacc";
            this.btn4disaddacc.Size = new System.Drawing.Size(160, 28);
            this.btn4disaddacc.TabIndex = 17;
            this.btn4disaddacc.Text = "Add To Account";
            this.btn4disaddacc.UseVisualStyleBackColor = true;
            // 
            // TxtInvoicw
            // 
            this.TxtInvoicw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInvoicw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtInvoicw.Location = new System.Drawing.Point(105, 10);
            this.TxtInvoicw.Name = "TxtInvoicw";
            this.TxtInvoicw.Size = new System.Drawing.Size(149, 26);
            this.TxtInvoicw.TabIndex = 16;
            // 
            // lab1isbilno
            // 
            this.lab1isbilno.AutoSize = true;
            this.lab1isbilno.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1isbilno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab1isbilno.Location = new System.Drawing.Point(3, 15);
            this.lab1isbilno.Name = "lab1isbilno";
            this.lab1isbilno.Size = new System.Drawing.Size(61, 20);
            this.lab1isbilno.TabIndex = 15;
            this.lab1isbilno.Text = "Bill No";
            // 
            // btn2dispriit
            // 
            this.btn2dispriit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2dispriit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn2dispriit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn2dispriit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2dispriit.ForeColor = System.Drawing.Color.Black;
            this.btn2dispriit.Location = new System.Drawing.Point(404, 10);
            this.btn2dispriit.Name = "btn2dispriit";
            this.btn2dispriit.Size = new System.Drawing.Size(92, 28);
            this.btn2dispriit.TabIndex = 14;
            this.btn2dispriit.Text = "Print IT";
            this.btn2dispriit.UseVisualStyleBackColor = true;
            // 
            // btn1disall
            // 
            this.btn1disall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1disall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn1disall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn1disall.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1disall.ForeColor = System.Drawing.Color.Black;
            this.btn1disall.Location = new System.Drawing.Point(260, 9);
            this.btn1disall.Name = "btn1disall";
            this.btn1disall.Size = new System.Drawing.Size(137, 31);
            this.btn1disall.TabIndex = 13;
            this.btn1disall.Text = "Display All";
            this.btn1disall.UseVisualStyleBackColor = true;
            // 
            // DGVdisbilin
            // 
            this.DGVdisbilin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVdisbilin.BackgroundColor = System.Drawing.Color.White;
            this.DGVdisbilin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdisbilin.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGVdisbilin.Location = new System.Drawing.Point(14, 84);
            this.DGVdisbilin.Name = "DGVdisbilin";
            this.DGVdisbilin.Size = new System.Drawing.Size(756, 409);
            this.DGVdisbilin.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 418);
            this.panel1.TabIndex = 19;
            // 
            // TxtAddres
            // 
            this.TxtAddres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtAddres.Location = new System.Drawing.Point(184, 128);
            this.TxtAddres.Name = "TxtAddres";
            this.TxtAddres.Size = new System.Drawing.Size(198, 26);
            this.TxtAddres.TabIndex = 11;
            // 
            // TxtBillDate
            // 
            this.TxtBillDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBillDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtBillDate.Location = new System.Drawing.Point(184, 94);
            this.TxtBillDate.Name = "TxtBillDate";
            this.TxtBillDate.Size = new System.Drawing.Size(198, 26);
            this.TxtBillDate.TabIndex = 9;
            // 
            // TxtInvoiceNo
            // 
            this.TxtInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInvoiceNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtInvoiceNo.Location = new System.Drawing.Point(184, 60);
            this.TxtInvoiceNo.Name = "TxtInvoiceNo";
            this.TxtInvoiceNo.Size = new System.Drawing.Size(198, 26);
            this.TxtInvoiceNo.TabIndex = 8;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel4);
            this.groupBox6.Location = new System.Drawing.Point(835, 273);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(405, 239);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TxtRemain);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.TxtPaid);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.TxtTotalAmt);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.TxtVat5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.TxtTotal);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(8, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 217);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // TxtRemain
            // 
            this.TxtRemain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRemain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtRemain.Location = new System.Drawing.Point(166, 173);
            this.TxtRemain.Name = "TxtRemain";
            this.TxtRemain.Size = new System.Drawing.Size(216, 26);
            this.TxtRemain.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(7, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Balance";
            // 
            // TxtPaid
            // 
            this.TxtPaid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPaid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtPaid.Location = new System.Drawing.Point(166, 134);
            this.TxtPaid.Name = "TxtPaid";
            this.TxtPaid.Size = new System.Drawing.Size(216, 26);
            this.TxtPaid.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(7, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Paid";
            // 
            // TxtTotalAmt
            // 
            this.TxtTotalAmt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalAmt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTotalAmt.Location = new System.Drawing.Point(166, 95);
            this.TxtTotalAmt.Name = "TxtTotalAmt";
            this.TxtTotalAmt.Size = new System.Drawing.Size(216, 26);
            this.TxtTotalAmt.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(7, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Gross Total";
            // 
            // TxtVat5
            // 
            this.TxtVat5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVat5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtVat5.Location = new System.Drawing.Point(166, 56);
            this.TxtVat5.Name = "TxtVat5";
            this.TxtVat5.Size = new System.Drawing.Size(216, 26);
            this.TxtVat5.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtTotal.Location = new System.Drawing.Point(166, 17);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(216, 26);
            this.TxtTotal.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(7, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Hamali";
            // 
            // lab3cumdelbilno
            // 
            this.lab3cumdelbilno.AutoSize = true;
            this.lab3cumdelbilno.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3cumdelbilno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab3cumdelbilno.Location = new System.Drawing.Point(12, 65);
            this.lab3cumdelbilno.Name = "lab3cumdelbilno";
            this.lab3cumdelbilno.Size = new System.Drawing.Size(61, 20);
            this.lab3cumdelbilno.TabIndex = 0;
            this.lab3cumdelbilno.Text = "Bill No";
            // 
            // lab6umdelphone
            // 
            this.lab6umdelphone.AutoSize = true;
            this.lab6umdelphone.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab6umdelphone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab6umdelphone.Location = new System.Drawing.Point(5, 146);
            this.lab6umdelphone.Name = "lab6umdelphone";
            this.lab6umdelphone.Size = new System.Drawing.Size(85, 20);
            this.lab6umdelphone.TabIndex = 4;
            this.lab6umdelphone.Text = " Phone No";
            // 
            // gro2cumdel
            // 
            this.gro2cumdel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gro2cumdel.Controls.Add(this.lab2cumdelname);
            this.gro2cumdel.Controls.Add(this.CmbName);
            this.gro2cumdel.Controls.Add(this.TxtPhoneNumber);
            this.gro2cumdel.Controls.Add(this.TxtAddres);
            this.gro2cumdel.Controls.Add(this.TxtBillDate);
            this.gro2cumdel.Controls.Add(this.TxtInvoiceNo);
            this.gro2cumdel.Controls.Add(this.lab5cumdelAdd);
            this.gro2cumdel.Controls.Add(this.lab4cumdelTxtDate);
            this.gro2cumdel.Controls.Add(this.lab3cumdelbilno);
            this.gro2cumdel.Controls.Add(this.panel3);
            this.gro2cumdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gro2cumdel.ForeColor = System.Drawing.Color.Black;
            this.gro2cumdel.Location = new System.Drawing.Point(835, 9);
            this.gro2cumdel.Name = "gro2cumdel";
            this.gro2cumdel.Size = new System.Drawing.Size(405, 257);
            this.gro2cumdel.TabIndex = 21;
            this.gro2cumdel.TabStop = false;
            this.gro2cumdel.Text = "Customer Details";
            // 
            // lab5cumdelAdd
            // 
            this.lab5cumdelAdd.AutoSize = true;
            this.lab5cumdelAdd.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab5cumdelAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab5cumdelAdd.Location = new System.Drawing.Point(15, 129);
            this.lab5cumdelAdd.Name = "lab5cumdelAdd";
            this.lab5cumdelAdd.Size = new System.Drawing.Size(68, 20);
            this.lab5cumdelAdd.TabIndex = 3;
            this.lab5cumdelAdd.Text = "Address";
            // 
            // lab4cumdelTxtDate
            // 
            this.lab4cumdelTxtDate.AutoSize = true;
            this.lab4cumdelTxtDate.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab4cumdelTxtDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab4cumdelTxtDate.Location = new System.Drawing.Point(15, 96);
            this.lab4cumdelTxtDate.Name = "lab4cumdelTxtDate";
            this.lab4cumdelTxtDate.Size = new System.Drawing.Size(44, 20);
            this.lab4cumdelTxtDate.TabIndex = 1;
            this.lab4cumdelTxtDate.Text = "Date\r\n";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lab6umdelphone);
            this.panel3.Location = new System.Drawing.Point(9, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 214);
            this.panel3.TabIndex = 28;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FrmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1261, 520);
            this.Controls.Add(this.gro1repdisbilin);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gro2cumdel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 180);
            this.Name = "FrmReporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmReporting";
            this.Load += new System.EventHandler(this.FrmReporting_Load);
            this.gro1repdisbilin.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdisbilin)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gro2cumdel.ResumeLayout(false);
            this.gro2cumdel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab2cumdelname;
        public System.Windows.Forms.ComboBox CmbName;
        public System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.GroupBox gro1repdisbilin;
        public System.Windows.Forms.TextBox TxtAddres;
        public System.Windows.Forms.TextBox TxtBillDate;
        public System.Windows.Forms.TextBox TxtInvoiceNo;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lab3cumdelbilno;
        private System.Windows.Forms.Label lab6umdelphone;
        private System.Windows.Forms.GroupBox gro2cumdel;
        private System.Windows.Forms.Label lab5cumdelAdd;
        private System.Windows.Forms.Label lab4cumdelTxtDate;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn3disprint;
        private System.Windows.Forms.Button btn4disaddacc;
        public System.Windows.Forms.TextBox TxtInvoicw;
        private System.Windows.Forms.Label lab1isbilno;
        private System.Windows.Forms.Button btn2dispriit;
        private System.Windows.Forms.Button btn1disall;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox TxtRemain;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TxtPaid;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtTotalAmt;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtVat5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView DGVdisbilin;

    }
}