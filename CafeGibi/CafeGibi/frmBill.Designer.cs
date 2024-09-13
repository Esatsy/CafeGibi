
namespace CafeGibi
{
    partial class frmBill
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
            this.gbOzelIndirim = new System.Windows.Forms.GroupBox();
            this.ChkIndirim = new System.Windows.Forms.CheckBox();
            this.gbIndirim = new System.Windows.Forms.GroupBox();
            this.txtIndirimTutari = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOdenecek = new System.Windows.Forms.Label();
            this.lbToplamTutar = new System.Windows.Forms.Label();
            this.lbKdv = new System.Windows.Forms.Label();
            this.lbIndirim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.rbKredi = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.btnHesapOzeti = new System.Windows.Forms.Button();
            this.lbAdisyonId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbOzelIndirim.SuspendLayout();
            this.gbIndirim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOzelIndirim
            // 
            this.gbOzelIndirim.BackColor = System.Drawing.Color.Transparent;
            this.gbOzelIndirim.Controls.Add(this.ChkIndirim);
            this.gbOzelIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbOzelIndirim.ForeColor = System.Drawing.Color.White;
            this.gbOzelIndirim.Location = new System.Drawing.Point(1225, 124);
            this.gbOzelIndirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOzelIndirim.Name = "gbOzelIndirim";
            this.gbOzelIndirim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOzelIndirim.Size = new System.Drawing.Size(367, 171);
            this.gbOzelIndirim.TabIndex = 0;
            this.gbOzelIndirim.TabStop = false;
            this.gbOzelIndirim.Text = "Özel İndirim";
            // 
            // ChkIndirim
            // 
            this.ChkIndirim.AutoSize = true;
            this.ChkIndirim.Location = new System.Drawing.Point(20, 57);
            this.ChkIndirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkIndirim.Name = "ChkIndirim";
            this.ChkIndirim.Size = new System.Drawing.Size(199, 33);
            this.ChkIndirim.TabIndex = 0;
            this.ChkIndirim.Text = "İndirim Uygula\r\n";
            this.ChkIndirim.UseVisualStyleBackColor = true;
            this.ChkIndirim.CheckedChanged += new System.EventHandler(this.ChkIndirim_CheckedChanged);
            // 
            // gbIndirim
            // 
            this.gbIndirim.BackColor = System.Drawing.Color.Transparent;
            this.gbIndirim.Controls.Add(this.txtIndirimTutari);
            this.gbIndirim.Controls.Add(this.label9);
            this.gbIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbIndirim.ForeColor = System.Drawing.Color.White;
            this.gbIndirim.Location = new System.Drawing.Point(1639, 124);
            this.gbIndirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIndirim.Name = "gbIndirim";
            this.gbIndirim.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIndirim.Size = new System.Drawing.Size(493, 171);
            this.gbIndirim.TabIndex = 0;
            this.gbIndirim.TabStop = false;
            this.gbIndirim.Text = "Özel Aktivite";
            this.gbIndirim.Visible = false;
            // 
            // txtIndirimTutari
            // 
            this.txtIndirimTutari.Location = new System.Drawing.Point(36, 96);
            this.txtIndirimTutari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIndirimTutari.Name = "txtIndirimTutari";
            this.txtIndirimTutari.Size = new System.Drawing.Size(343, 35);
            this.txtIndirimTutari.TabIndex = 1;
            this.txtIndirimTutari.TextChanged += new System.EventHandler(this.txtIndirimTutari_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "İndirim Tutarı Giriniz";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbOdenecek);
            this.groupBox3.Controls.Add(this.lbToplamTutar);
            this.groupBox3.Controls.Add(this.lbKdv);
            this.groupBox3.Controls.Add(this.lbIndirim);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(548, 441);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(421, 258);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ara Toplam";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CafeGibi.Properties.Resources.ÇIKIŞ_YAP__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-93, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 41);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "KDV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "TL";
            // 
            // lbOdenecek
            // 
            this.lbOdenecek.AutoSize = true;
            this.lbOdenecek.Location = new System.Drawing.Point(209, 209);
            this.lbOdenecek.Name = "lbOdenecek";
            this.lbOdenecek.Size = new System.Drawing.Size(27, 29);
            this.lbOdenecek.TabIndex = 0;
            this.lbOdenecek.Text = "0";
            // 
            // lbToplamTutar
            // 
            this.lbToplamTutar.AutoSize = true;
            this.lbToplamTutar.Location = new System.Drawing.Point(209, 158);
            this.lbToplamTutar.Name = "lbToplamTutar";
            this.lbToplamTutar.Size = new System.Drawing.Size(27, 29);
            this.lbToplamTutar.TabIndex = 0;
            this.lbToplamTutar.Text = "0";
            // 
            // lbKdv
            // 
            this.lbKdv.AutoSize = true;
            this.lbKdv.Location = new System.Drawing.Point(209, 106);
            this.lbKdv.Name = "lbKdv";
            this.lbKdv.Size = new System.Drawing.Size(27, 29);
            this.lbKdv.TabIndex = 0;
            this.lbKdv.Text = "0";
            this.lbKdv.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbIndirim
            // 
            this.lbIndirim.AutoSize = true;
            this.lbIndirim.Location = new System.Drawing.Point(209, 57);
            this.lbIndirim.Name = "lbIndirim";
            this.lbIndirim.Size = new System.Drawing.Size(27, 29);
            this.lbIndirim.TabIndex = 0;
            this.lbIndirim.Text = "0";
            this.lbIndirim.TextChanged += new System.EventHandler(this.lbIndirim_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "TL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirim";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbTicket);
            this.groupBox4.Controls.Add(this.rbKredi);
            this.groupBox4.Controls.Add(this.rbNakit);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(976, 485);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(299, 215);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ödeme Türü";
            // 
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Location = new System.Drawing.Point(51, 145);
            this.rbTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(103, 33);
            this.rbTicket.TabIndex = 0;
            this.rbTicket.TabStop = true;
            this.rbTicket.Text = "Ticket";
            this.rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbKredi
            // 
            this.rbKredi.AutoSize = true;
            this.rbKredi.Location = new System.Drawing.Point(51, 92);
            this.rbKredi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbKredi.Name = "rbKredi";
            this.rbKredi.Size = new System.Drawing.Size(155, 33);
            this.rbKredi.TabIndex = 0;
            this.rbKredi.TabStop = true;
            this.rbKredi.Text = "Kredi Kartı";
            this.rbKredi.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(51, 44);
            this.rbNakit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(91, 33);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUrunler.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.HideSelection = false;
            this.lvUrunler.Location = new System.Drawing.Point(548, 110);
            this.lvUrunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(641, 326);
            this.lvUrunler.TabIndex = 1;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adı";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UrunId";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SatisId";
            this.columnHeader5.Width = 154;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackgroundImage = global::CafeGibi.Properties.Resources.ÇIKIŞ_YAP__1_;
            this.btnCikisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikisYap.Location = new System.Drawing.Point(369, 900);
            this.btnCikisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(73, 70);
            this.btnCikisYap.TabIndex = 2;
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackgroundImage = global::CafeGibi.Properties.Resources.Adsız_tasarım__11_;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.Location = new System.Drawing.Point(288, 900);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(76, 70);
            this.btnGeriDon.TabIndex = 2;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.BackgroundImage = global::CafeGibi.Properties.Resources.HesapKapat;
            this.btnHesapKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapKapat.Location = new System.Drawing.Point(1416, 598);
            this.btnHesapKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(296, 132);
            this.btnHesapKapat.TabIndex = 2;
            this.btnHesapKapat.UseVisualStyleBackColor = true;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.BackgroundImage = global::CafeGibi.Properties.Resources.Hesap_Özeti;
            this.btnHesapOzeti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapOzeti.Location = new System.Drawing.Point(1416, 450);
            this.btnHesapOzeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(296, 132);
            this.btnHesapOzeti.TabIndex = 2;
            this.btnHesapOzeti.UseVisualStyleBackColor = true;
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // lbAdisyonId
            // 
            this.lbAdisyonId.AutoSize = true;
            this.lbAdisyonId.BackColor = System.Drawing.Color.Transparent;
            this.lbAdisyonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAdisyonId.ForeColor = System.Drawing.Color.Red;
            this.lbAdisyonId.Location = new System.Drawing.Point(701, 69);
            this.lbAdisyonId.Name = "lbAdisyonId";
            this.lbAdisyonId.Size = new System.Drawing.Size(29, 25);
            this.lbAdisyonId.TabIndex = 3;
            this.lbAdisyonId.Text = "Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(572, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Siparişler";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeGibi.Properties.Resources.Brown_Simple_Paper_Torn_Happy_Birthday_Invitation__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbAdisyonId);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnHesapOzeti);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.gbIndirim);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbOzelIndirim);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.gbOzelIndirim.ResumeLayout(false);
            this.gbOzelIndirim.PerformLayout();
            this.gbIndirim.ResumeLayout(false);
            this.gbIndirim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOzelIndirim;
        private System.Windows.Forms.CheckBox ChkIndirim;
        private System.Windows.Forms.GroupBox gbIndirim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbOdenecek;
        private System.Windows.Forms.Label lbToplamTutar;
        private System.Windows.Forms.Label lbIndirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton rbKredi;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbKdv;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.TextBox txtIndirimTutari;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.Button btnHesapOzeti;
        private System.Windows.Forms.Label lbAdisyonId;
        private System.Windows.Forms.Label label11;
    }
}