
namespace DapperCRUD
{
    partial class frmIslemMenusu
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
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListele.BackColor = System.Drawing.Color.Brown;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Location = new System.Drawing.Point(40, 40);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(177, 94);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Kategori Listesi";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKategoriEkle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriEkle.Location = new System.Drawing.Point(267, 40);
            this.btnKategoriEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(177, 94);
            this.btnKategoriEkle.TabIndex = 1;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKategoriGuncelle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKategoriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(40, 178);
            this.btnKategoriGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(177, 94);
            this.btnKategoriGuncelle.TabIndex = 2;
            this.btnKategoriGuncelle.Text = "Kategori Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKategoriSil.BackColor = System.Drawing.Color.DarkOrange;
            this.btnKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriSil.Location = new System.Drawing.Point(267, 178);
            this.btnKategoriSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(177, 94);
            this.btnKategoriSil.TabIndex = 3;
            this.btnKategoriSil.Text = "Kategori Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCikis.BackColor = System.Drawing.Color.DarkViolet;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Location = new System.Drawing.Point(152, 315);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(177, 94);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmIslemMenusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(484, 447);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.btnListele);
            this.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIslemMenusu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIslemMenusu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnCikis;
    }
}