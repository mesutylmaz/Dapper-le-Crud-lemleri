
namespace DapperCRUD
{
    partial class frmKategoriGuncelle
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
            this.nudKategoriKapasitesi = new System.Windows.Forms.NumericUpDown();
            this.nudKategoriID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKategoriKapasitesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKategoriID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // nudKategoriKapasitesi
            // 
            this.nudKategoriKapasitesi.BackColor = System.Drawing.Color.Silver;
            this.nudKategoriKapasitesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudKategoriKapasitesi.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKategoriKapasitesi.Location = new System.Drawing.Point(149, 343);
            this.nudKategoriKapasitesi.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKategoriKapasitesi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKategoriKapasitesi.Name = "nudKategoriKapasitesi";
            this.nudKategoriKapasitesi.Size = new System.Drawing.Size(629, 26);
            this.nudKategoriKapasitesi.TabIndex = 14;
            this.nudKategoriKapasitesi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudKategoriID
            // 
            this.nudKategoriID.BackColor = System.Drawing.Color.Silver;
            this.nudKategoriID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudKategoriID.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKategoriID.Location = new System.Drawing.Point(149, 282);
            this.nudKategoriID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKategoriID.Name = "nudKategoriID";
            this.nudKategoriID.Size = new System.Drawing.Size(629, 26);
            this.nudKategoriID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Kategori Kapasitesi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kategori Adı :";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.BackColor = System.Drawing.Color.Silver;
            this.txtKategoriAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKategoriAdi.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKategoriAdi.Location = new System.Drawing.Point(150, 313);
            this.txtKategoriAdi.Multiline = true;
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(628, 25);
            this.txtKategoriAdi.TabIndex = 12;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(209, 389);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 38);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "&Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategori ID :";
            // 
            // dgvKategoriler
            // 
            this.dgvKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKategoriler.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategoriler.Location = new System.Drawing.Point(0, 0);
            this.dgvKategoriler.Name = "dgvKategoriler";
            this.dgvKategoriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKategoriler.Size = new System.Drawing.Size(790, 262);
            this.dgvKategoriler.TabIndex = 10;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.HotPink;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(490, 389);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 38);
            this.btnCikis.TabIndex = 18;
            this.btnCikis.Text = "&Kapat";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(350, 389);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(89, 38);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "&Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmKategoriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.nudKategoriKapasitesi);
            this.Controls.Add(this.nudKategoriID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKategoriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKategoriGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKategoriGuncelle";
            this.Load += new System.EventHandler(this.frmKategoriGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKategoriKapasitesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKategoriID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudKategoriKapasitesi;
        private System.Windows.Forms.NumericUpDown nudKategoriID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
    }
}