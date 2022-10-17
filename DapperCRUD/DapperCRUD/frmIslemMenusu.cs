using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperCRUD
{
    public partial class frmIslemMenusu : Form
    {
        public frmIslemMenusu()
        {
            InitializeComponent();
        }



        frmKategoriEkle kategoriEkle;
        frmKategoriGuncelle kategoriGuncelle;
        frmKategoriSil kategoriSil;
        Form1 form1;




        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (kategoriEkle == null || kategoriEkle.IsDisposed)
            {
                kategoriEkle = new frmKategoriEkle();
                kategoriEkle.Show();
            }
            else
            {
                MessageBox.Show("Kategori Ekleme Sayfası Zaten Açık!");
            }
        }




        private void btnListele_Click(object sender, EventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new Form1();
                form1.Show();
                //this.Visible = false;
            }
            else
            {
                MessageBox.Show("Kategori Listeleme Sayfası Zaten Açık!");
            }
        }




        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (kategoriGuncelle == null || kategoriGuncelle.IsDisposed)
            {
                kategoriGuncelle = new frmKategoriGuncelle();
                kategoriGuncelle.Show();
                //this.Visible = false;
            }
            else
            {
                MessageBox.Show("Kategori Güncelleme Sayfası Zaten Açık!");
            }
        }




        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (kategoriSil == null || kategoriSil.IsDisposed)
            {
                kategoriSil = new frmKategoriSil();
                kategoriSil.Show();
                //this.Visible = false;
            }
            else
            {
                MessageBox.Show("Kategori Silme Sayfası Zaten Açık!");
            }
        }
    }
}
