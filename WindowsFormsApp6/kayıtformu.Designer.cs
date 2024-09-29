namespace WindowsFormsApp6
{
    partial class kayıtformu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.masketelefon = new System.Windows.Forms.MaskedTextBox();
            this.rdbbay = new System.Windows.Forms.RadioButton();
            this.rdbbayan = new System.Windows.Forms.RadioButton();
            this.btniptal = new System.Windows.Forms.Button();
            this.btntamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "soyisim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(142, 19);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(126, 20);
            this.txtisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "isim";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(142, 56);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(126, 20);
            this.txtsoyisim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "telefon";
            // 
            // masketelefon
            // 
            this.masketelefon.Location = new System.Drawing.Point(142, 102);
            this.masketelefon.Mask = "(999) 000-0000";
            this.masketelefon.Name = "masketelefon";
            this.masketelefon.Size = new System.Drawing.Size(126, 20);
            this.masketelefon.TabIndex = 2;
            // 
            // rdbbay
            // 
            this.rdbbay.AutoSize = true;
            this.rdbbay.Checked = true;
            this.rdbbay.Location = new System.Drawing.Point(84, 146);
            this.rdbbay.Name = "rdbbay";
            this.rdbbay.Size = new System.Drawing.Size(42, 17);
            this.rdbbay.TabIndex = 3;
            this.rdbbay.TabStop = true;
            this.rdbbay.Text = "bay";
            this.rdbbay.UseVisualStyleBackColor = true;
            // 
            // rdbbayan
            // 
            this.rdbbayan.AutoSize = true;
            this.rdbbayan.Location = new System.Drawing.Point(193, 146);
            this.rdbbayan.Name = "rdbbayan";
            this.rdbbayan.Size = new System.Drawing.Size(54, 17);
            this.rdbbayan.TabIndex = 4;
            this.rdbbayan.Text = "bayan";
            this.rdbbayan.UseVisualStyleBackColor = true;
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(84, 169);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 5;
            this.btniptal.Text = "iptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btntamam
            // 
            this.btntamam.Location = new System.Drawing.Point(193, 169);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(75, 23);
            this.btntamam.TabIndex = 6;
            this.btntamam.Text = "tamam";
            this.btntamam.UseVisualStyleBackColor = true;
            this.btntamam.Click += new System.EventHandler(this.btntamam_Click);
            // 
            // kayıtformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 274);
            this.Controls.Add(this.btntamam);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.rdbbayan);
            this.Controls.Add(this.rdbbay);
            this.Controls.Add(this.masketelefon);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayıtformu";
            this.Text = "kayıtformu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btntamam;
        public System.Windows.Forms.TextBox txtisim;
        public System.Windows.Forms.TextBox txtsoyisim;
        public System.Windows.Forms.MaskedTextBox masketelefon;
        public System.Windows.Forms.RadioButton rdbbay;
        public System.Windows.Forms.RadioButton rdbbayan;
    }
}