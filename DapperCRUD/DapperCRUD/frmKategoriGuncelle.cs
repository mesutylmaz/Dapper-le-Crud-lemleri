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
    public partial class frmKategoriGuncelle : Form
    {
        public frmKategoriGuncelle()
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



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@p1", txtKategoriAdi.Text);
            //param.Add("@p2", txtKategoriDurumu.Text);
            param.Add("@p3", nudKategoriKapasitesi.Value);
            param.Add("@p4", nudKategoriID.Value);

            //int toplam = int.Parse("Select Count(KategoriID) From Kategoris");

            if (/*toplam >= nudKategoriID.Value &&*/ nudKategoriID.Value > 0 && Convert.ToString(nudKategoriID.Value) != null && Convert.ToString(nudKategoriID.Value) != "")
            {
                if (txtKategoriAdi.Text != null && nudKategoriKapasitesi.Value > 0 && nudKategoriKapasitesi.Value <= 10000)
                {
                    sql = "Update Kategoris Set KategoriAdi=@p1, KategoriKapasitesi=@p3 Where KategoriID=@p4";
                    CUD(param);
                    MessageBox.Show("Güncelleme işlemi gerçekleştirildi.");
                    FormuTemizle();
                }
                if (txtKategoriAdi.Text != null && Convert.ToString(nudKategoriKapasitesi.Value) == "" && Convert.ToString(nudKategoriKapasitesi.Value) == null)
                {
                    sql = "Update Kategoris Set KategoriAdi=@p1 Where KategoriID=@p4";
                    CUD(param);
                    MessageBox.Show("Güncelleme işlemi gerçekleştirildi.");
                    FormuTemizle();
                }
                if (txtKategoriAdi.Text == null && nudKategoriKapasitesi.Value > 0 && nudKategoriKapasitesi.Value <= 10000)
                {
                    sql = "Update Kategoris Set KategoriKapasitesi=@p3 Where KategoriID=@p4";
                    CUD(param);
                    MessageBox.Show("Güncelleme işlemi gerçekleştirildi.");
                    FormuTemizle();
                }
            }
        }

        private void frmKategoriGuncelle_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = connection.Query<Kategori>("Select * From Kategoris");

            //Satırlardaki hücrelere tıklandığında düzenlebilir olmaması için;
            dgvKategoriler.Columns["KategoriID"].ReadOnly = true;
            dgvKategoriler.Columns["KategoriAdi"].ReadOnly = true;
            dgvKategoriler.Columns["KategoriDurumu"].ReadOnly = true;
            dgvKategoriler.Columns["KategoriKapasitesi"].ReadOnly = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void FormuTemizle()
        {
            txtKategoriAdi.Clear();
            nudKategoriID.Value = 1;
            nudKategoriKapasitesi.Value  = 1;
        }





        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }
    }
}
