namespace OTELUYGULAMASIODEVI
{
    partial class Stoklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stoklar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAtistirma = new System.Windows.Forms.TextBox();
            this.txtIcecek = new System.Windows.Forms.TextBox();
            this.txtGıda = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonkaydet2 = new System.Windows.Forms.Button();
            this.txtinternet = new System.Windows.Forms.Label();
            this.txtSu = new System.Windows.Forms.Label();
            this.txtElektrik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAtistirma);
            this.groupBox1.Controls.Add(this.txtIcecek);
            this.groupBox1.Controls.Add(this.txtGıda);
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 544);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mutfak";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 252);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gıdalar";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İçecekler";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Atıştırmalıklar";
            this.columnHeader3.Width = 114;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Brown;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(312, 208);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 48);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "ATISTIRMALIKLAR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(71, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "ICECEK TUTARI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(95, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "GIDA TUTARI:";
            // 
            // txtAtistirma
            // 
            this.txtAtistirma.Location = new System.Drawing.Point(312, 166);
            this.txtAtistirma.Name = "txtAtistirma";
            this.txtAtistirma.Size = new System.Drawing.Size(69, 22);
            this.txtAtistirma.TabIndex = 10;
            this.txtAtistirma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtistirma_KeyPress);
            // 
            // txtIcecek
            // 
            this.txtIcecek.Location = new System.Drawing.Point(312, 105);
            this.txtIcecek.Name = "txtIcecek";
            this.txtIcecek.Size = new System.Drawing.Size(69, 22);
            this.txtIcecek.TabIndex = 9;
            this.txtIcecek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtistirma_KeyPress);
            // 
            // txtGıda
            // 
            this.txtGıda.Location = new System.Drawing.Point(312, 45);
            this.txtGıda.Name = "txtGıda";
            this.txtGıda.Size = new System.Drawing.Size(69, 22);
            this.txtGıda.TabIndex = 8;
            this.txtGıda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtistirma_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.buttonkaydet2);
            this.groupBox2.Controls.Add(this.txtinternet);
            this.groupBox2.Controls.Add(this.txtSu);
            this.groupBox2.Controls.Add(this.txtElektrik);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(805, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 543);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faturalar";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(9, 279);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(433, 252);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Elektrik";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Su";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "İnternet";
            this.columnHeader6.Width = 114;
            // 
            // buttonkaydet2
            // 
            this.buttonkaydet2.BackColor = System.Drawing.Color.Brown;
            this.buttonkaydet2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonkaydet2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonkaydet2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonkaydet2.Location = new System.Drawing.Point(289, 207);
            this.buttonkaydet2.Name = "buttonkaydet2";
            this.buttonkaydet2.Size = new System.Drawing.Size(153, 48);
            this.buttonkaydet2.TabIndex = 21;
            this.buttonkaydet2.Text = "KAYDET";
            this.buttonkaydet2.UseVisualStyleBackColor = false;
            this.buttonkaydet2.Click += new System.EventHandler(this.buttonkaydet2_Click);
            // 
            // txtinternet
            // 
            this.txtinternet.AutoSize = true;
            this.txtinternet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtinternet.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinternet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtinternet.Location = new System.Drawing.Point(78, 155);
            this.txtinternet.Name = "txtinternet";
            this.txtinternet.Size = new System.Drawing.Size(138, 39);
            this.txtinternet.TabIndex = 20;
            this.txtinternet.Text = "INTERNET:";
            // 
            // txtSu
            // 
            this.txtSu.AutoSize = true;
            this.txtSu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSu.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSu.Location = new System.Drawing.Point(161, 94);
            this.txtSu.Name = "txtSu";
            this.txtSu.Size = new System.Drawing.Size(55, 39);
            this.txtSu.TabIndex = 19;
            this.txtSu.Text = "SU:";
            // 
            // txtElektrik
            // 
            this.txtElektrik.AutoSize = true;
            this.txtElektrik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtElektrik.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElektrik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtElektrik.Location = new System.Drawing.Point(76, 27);
            this.txtElektrik.Name = "txtElektrik";
            this.txtElektrik.Size = new System.Drawing.Size(140, 39);
            this.txtElektrik.TabIndex = 18;
            this.txtElektrik.Text = "ELEKTRIK:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtistirma_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(289, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 22);
            this.textBox2.TabIndex = 16;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtistirma_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(289, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 22);
            this.textBox3.TabIndex = 15;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtistirma_KeyPress);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Brown;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnasayfa.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnasayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnasayfa.Location = new System.Drawing.Point(588, 496);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(153, 48);
            this.btnAnasayfa.TabIndex = 28;
            this.btnAnasayfa.Text = "ANASAYFA";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // Stoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1308, 556);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Stoklar";
            this.Text = "Stoklar";
            this.Load += new System.EventHandler(this.Stoklar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAtistirma;
        private System.Windows.Forms.TextBox txtIcecek;
        private System.Windows.Forms.TextBox txtGıda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonkaydet2;
        private System.Windows.Forms.Label txtinternet;
        private System.Windows.Forms.Label txtSu;
        private System.Windows.Forms.Label txtElektrik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAnasayfa;
    }
}