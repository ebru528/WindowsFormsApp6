namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbotobüs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbnerede = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbnereye = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtptarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.nudfiyat = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(576, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(621, 468);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "müşteri";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "telefon";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "cinsiyet";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "nereden";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "nereye";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "koltuk no";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "tarih";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "otobüs seçiniz";
            // 
            // cmbotobüs
            // 
            this.cmbotobüs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbotobüs.FormattingEnabled = true;
            this.cmbotobüs.Items.AddRange(new object[] {
            "Travego",
            "Setra",
            "Neoplan"});
            this.cmbotobüs.Location = new System.Drawing.Point(390, 12);
            this.cmbotobüs.Name = "cmbotobüs";
            this.cmbotobüs.Size = new System.Drawing.Size(121, 21);
            this.cmbotobüs.TabIndex = 2;
            this.cmbotobüs.SelectedIndexChanged += new System.EventHandler(this.cmbotobüs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nereye";
            // 
            // cmbnerede
            // 
            this.cmbnerede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnerede.FormattingEnabled = true;
            this.cmbnerede.Items.AddRange(new object[] {
            "istanbul",
            "ankara",
            "adana",
            "antalya",
            "mersin",
            "izmir",
            "muğla",
            "trabzon",
            "diyarbakır",
            "konya"});
            this.cmbnerede.Location = new System.Drawing.Point(79, 19);
            this.cmbnerede.Name = "cmbnerede";
            this.cmbnerede.Size = new System.Drawing.Size(121, 21);
            this.cmbnerede.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "nereden";
            // 
            // cmbnereye
            // 
            this.cmbnereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnereye.FormattingEnabled = true;
            this.cmbnereye.Items.AddRange(new object[] {
            "istanbul",
            "ankara",
            "adana",
            "antalya",
            "mersin",
            "izmir",
            "muğla",
            "trabzon",
            "diyarbakır",
            "konya"});
            this.cmbnereye.Location = new System.Drawing.Point(79, 62);
            this.cmbnereye.Name = "cmbnereye";
            this.cmbnereye.Size = new System.Drawing.Size(121, 21);
            this.cmbnereye.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tarih";
            // 
            // dtptarih
            // 
            this.dtptarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptarih.Location = new System.Drawing.Point(384, 152);
            this.dtptarih.Name = "dtptarih";
            this.dtptarih.Size = new System.Drawing.Size(120, 20);
            this.dtptarih.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "fiyat";
            // 
            // nudfiyat
            // 
            this.nudfiyat.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.nudfiyat.Location = new System.Drawing.Point(384, 193);
            this.nudfiyat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudfiyat.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudfiyat.Name = "nudfiyat";
            this.nudfiyat.Size = new System.Drawing.Size(120, 20);
            this.nudfiyat.TabIndex = 6;
            this.nudfiyat.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudfiyat.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(390, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "kaydet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbnerede);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbnereye);
            this.groupBox1.Location = new System.Drawing.Point(314, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "istikamet";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rezerveEtToolStripMenuItem.Text = "rezerve et";
            this.rezerveEtToolStripMenuItem.Click += new System.EventHandler(this.rezerveEtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.mavi_otobüs;
            this.ClientSize = new System.Drawing.Size(1195, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtptarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbotobüs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudfiyat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbotobüs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbnerede;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbnereye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtptarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudfiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
    }
}

