
namespace DapperCRUD
{
    partial class frmKategoriSil
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
            this.btnSil = new System.Windows.Forms.Button();
            this.nudKategoriID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKategoriler = new System.Windows.Forms.DataGridView();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKategoriID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(409, 274);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 38);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "&Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // nudKategoriID
            // 
            this.nudKategoriID.BackColor = System.Drawing.Color.Silver;
            this.nudKategoriID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudKategoriID.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKategoriID.Location = new System.Drawing.Point(147, 280);
            this.nudKategoriID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKategoriID.Name = "nudKategoriID";
            this.nudKategoriID.Size = new System.Drawing.Size(174, 26);
            this.nudKategoriID.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 26;
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
            this.dgvKategoriler.TabIndex = 24;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.HotPink;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(665, 274);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(89, 38);
            this.btnCikis.TabIndex = 27;
            this.btnCikis.Text = "&Kapat";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTemizle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(538, 274);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(97, 38);
            this.btnTemizle.TabIndex = 28;
            this.btnTemizle.Text = "&Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmKategoriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(790, 327);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.nudKategoriID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKategoriler);
            this.Controls.Add(this.btnSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKategoriSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKategoriSil";
            this.Load += new System.EventHandler(this.frmKategoriSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKategoriID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.NumericUpDown nudKategoriID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKategoriler;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
    }
}