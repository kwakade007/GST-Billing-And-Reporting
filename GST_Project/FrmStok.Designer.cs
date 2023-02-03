namespace GST_Project
{
    partial class FrmStok
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
            this.lab1proname = new System.Windows.Forms.Label();
            this.combox1proname = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.gro1stockdel = new System.Windows.Forms.GroupBox();
            this.DGVprodel = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gro1stockdel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVprodel)).BeginInit();
            this.SuspendLayout();
            // 
            // lab1proname
            // 
            this.lab1proname.AutoSize = true;
            this.lab1proname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1proname.Location = new System.Drawing.Point(22, 17);
            this.lab1proname.Name = "lab1proname";
            this.lab1proname.Size = new System.Drawing.Size(106, 16);
            this.lab1proname.TabIndex = 0;
            this.lab1proname.Text = "Product Name";
            // 
            // combox1proname
            // 
            this.combox1proname.FormattingEnabled = true;
            this.combox1proname.Location = new System.Drawing.Point(211, 15);
            this.combox1proname.Name = "combox1proname";
            this.combox1proname.Size = new System.Drawing.Size(311, 28);
            this.combox1proname.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.combox1proname);
            this.panel1.Controls.Add(this.lab1proname);
            this.panel1.Location = new System.Drawing.Point(66, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 57);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dispaly All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gro1stockdel
            // 
            this.gro1stockdel.Controls.Add(this.DGVprodel);
            this.gro1stockdel.Controls.Add(this.panel1);
            this.gro1stockdel.Controls.Add(this.panel2);
            this.gro1stockdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gro1stockdel.Location = new System.Drawing.Point(12, 12);
            this.gro1stockdel.Name = "gro1stockdel";
            this.gro1stockdel.Size = new System.Drawing.Size(902, 521);
            this.gro1stockdel.TabIndex = 3;
            this.gro1stockdel.TabStop = false;
            this.gro1stockdel.Text = "Product details";
            // 
            // DGVprodel
            // 
            this.DGVprodel.BackgroundColor = System.Drawing.Color.White;
            this.DGVprodel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVprodel.Location = new System.Drawing.Point(12, 92);
            this.DGVprodel.Name = "DGVprodel";
            this.DGVprodel.Size = new System.Drawing.Size(880, 419);
            this.DGVprodel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(8, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 427);
            this.panel2.TabIndex = 4;
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(921, 545);
            this.Controls.Add(this.gro1stockdel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 180);
            this.Name = "FrmStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmStok";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gro1stockdel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVprodel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab1proname;
        private System.Windows.Forms.ComboBox combox1proname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gro1stockdel;
        private System.Windows.Forms.DataGridView DGVprodel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}