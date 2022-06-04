namespace WindowsFormsAdoNet
{
    partial class Form1
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
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_emailadres = new System.Windows.Forms.Label();
            this.txt_emailadres = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_telefonno = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_kayitekle = new System.Windows.Forms.Button();
            this.btn_kayitguncelle = new System.Windows.Forms.Button();
            this.btn_kayitsil = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(29, 183);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(28, 13);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "İsim:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(118, 175);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(29, 224);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(45, 13);
            this.lbl_soyisim.TabIndex = 0;
            this.lbl_soyisim.Text = "Soyisim:";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(118, 216);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 20);
            this.txt_soyisim.TabIndex = 1;
            // 
            // lbl_emailadres
            // 
            this.lbl_emailadres.AutoSize = true;
            this.lbl_emailadres.Location = new System.Drawing.Point(29, 269);
            this.lbl_emailadres.Name = "lbl_emailadres";
            this.lbl_emailadres.Size = new System.Drawing.Size(35, 13);
            this.lbl_emailadres.TabIndex = 0;
            this.lbl_emailadres.Text = "Email:";
            // 
            // txt_emailadres
            // 
            this.txt_emailadres.Location = new System.Drawing.Point(118, 261);
            this.txt_emailadres.Name = "txt_emailadres";
            this.txt_emailadres.Size = new System.Drawing.Size(100, 20);
            this.txt_emailadres.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 156);
            this.dataGridView1.TabIndex = 2;
            // 
            // lbl_telefonno
            // 
            this.lbl_telefonno.AutoSize = true;
            this.lbl_telefonno.Location = new System.Drawing.Point(29, 309);
            this.lbl_telefonno.Name = "lbl_telefonno";
            this.lbl_telefonno.Size = new System.Drawing.Size(46, 13);
            this.lbl_telefonno.TabIndex = 0;
            this.lbl_telefonno.Text = "Telefon:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(516, 183);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(556, 175);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            // 
            // btn_kayitekle
            // 
            this.btn_kayitekle.Location = new System.Drawing.Point(293, 298);
            this.btn_kayitekle.Name = "btn_kayitekle";
            this.btn_kayitekle.Size = new System.Drawing.Size(75, 23);
            this.btn_kayitekle.TabIndex = 3;
            this.btn_kayitekle.Text = "Kayıt Ekle";
            this.btn_kayitekle.UseVisualStyleBackColor = true;
            this.btn_kayitekle.Click += new System.EventHandler(this.btn_kayitekle_Click);
            // 
            // btn_kayitguncelle
            // 
            this.btn_kayitguncelle.Location = new System.Drawing.Point(374, 298);
            this.btn_kayitguncelle.Name = "btn_kayitguncelle";
            this.btn_kayitguncelle.Size = new System.Drawing.Size(104, 23);
            this.btn_kayitguncelle.TabIndex = 3;
            this.btn_kayitguncelle.Text = "Kayıt Güncelle";
            this.btn_kayitguncelle.UseVisualStyleBackColor = true;
            this.btn_kayitguncelle.Click += new System.EventHandler(this.btn_kayitguncelle_Click);
            // 
            // btn_kayitsil
            // 
            this.btn_kayitsil.Location = new System.Drawing.Point(484, 298);
            this.btn_kayitsil.Name = "btn_kayitsil";
            this.btn_kayitsil.Size = new System.Drawing.Size(75, 23);
            this.btn_kayitsil.TabIndex = 3;
            this.btn_kayitsil.Text = "Kayıt Sil";
            this.btn_kayitsil.UseVisualStyleBackColor = true;
            this.btn_kayitsil.Click += new System.EventHandler(this.btn_kayitsil_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(118, 302);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 354);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_kayitsil);
            this.Controls.Add(this.btn_kayitguncelle);
            this.Controls.Add(this.btn_kayitekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_telefonno);
            this.Controls.Add(this.txt_emailadres);
            this.Controls.Add(this.lbl_emailadres);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.lbl_soyisim);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.lbl_isim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label lbl_emailadres;
        private System.Windows.Forms.TextBox txt_emailadres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_telefonno;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_kayitekle;
        private System.Windows.Forms.Button btn_kayitguncelle;
        private System.Windows.Forms.Button btn_kayitsil;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

