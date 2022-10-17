using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperCRUD
{
    public partial class frmKategoriEkle : Form
    {
        public frmKategoriEkle()
        {
            InitializeComponent();
        }






        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        string sql = "";




        void CUD(DynamicParameters dynamic = null)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            connection.Execute(sql, dynamic, commandType: CommandType.Text);
            connection.Close();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            dgvKategoriler.DataSource = connection.Query<Kategori>("Select * From Kategoris");
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@p1", txtKategoriAdi.Text);      //txtKategoriAdi alanındaki veriyi p1 parametresi kabul et
            //param.Add("@p2", txtKategoriDurumu.Text);     //Eklenen her kategori aktif olsun diye alttaki satırı ekledim.
            param.Add("@p2", 1);
            param.Add("@p3", nudKategoriKapasitesi.Text);

            if (txtKategoriAdi.Text != null && nudKategoriKapasitesi.Value >= 1 && nudKategoriKapasitesi.Value <= 10000)
            {
                sql = "Insert into Kategoris values(@p1, @p2, @p3)";
                CUD(param);
                MessageBox.Show("Ekleme işlemi gerçekleştirildi.");
                FormuTemizle();
            }
            else if (txtKategoriAdi.Text == null || txtKategoriAdi.Text == "")
            {
                MessageBox.Show("Kategori adı boş bırakılamaz!");
                FormuTemizle();
            }
            else if (nudKategoriKapasitesi.Value < 1)
            {
                MessageBox.Show("Kategori kapasitesi 1'den küçük olamaz!");
                FormuTemizle();
            }
            else if (nudKategoriKapasitesi.Value > 10000)
            {
                MessageBox.Show("Kategori kapasitesi 10000'den büyük olamaz!");
                FormuTemizle();
            }
        }





        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void frmKategoriEkle_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = connection.Query<Kategori>("Select * From Kategoris");

            //Satırlardaki hücrelere tıklandığında düzenlebilir olmaması için;
            dgvKategoriler.Columns["KategoriID"].ReadOnly = true;
            dgvKategoriler.Columns["KategoriAdi"].ReadOnly = true;
            dgvKategoriler.Columns["KategoriDurumu"].ReadOnly = true;
            dgvKategoriler.Columns["KategoriKapasitesi"].ReadOnly = true;

            
        }



        private void FormuTemizle()
        {
            txtKategoriAdi.Clear();
            nudKategoriKapasitesi.Value = 1;
        }




        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }
    }
}
 