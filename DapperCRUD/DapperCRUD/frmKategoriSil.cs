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
    public partial class frmKategoriSil : Form
    {
        public frmKategoriSil()
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





        private void frmKategoriSil_Load(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = connection.Query<Kategori>("Select * From Kategoris");

            //Satırlardaki hücrelere tıklandığında düzenlebilir olmaması için;
            dgvKategoriler.Columns["KategoriID"].ReadOnly = true;
            dgvKategoriler.Columns["KategoriAdi"].ReadOnly = true;
            dgvKategoriler.Columns["KategoriDurumu"].ReadOnly = true;
            dgvKategoriler.Columns["KategoriKapasitesi"].ReadOnly = true;
        }





        private void btnSil_Click(object sender, EventArgs e)
        {
            //int toplam = int.Parse("Select Count(KategoriID) From Kategoris");
            //CUD();

            if (/*toplam >= nudKategoriID.Value &&*/ nudKategoriID.Value > 0 && Convert.ToString(nudKategoriID.Value) != null && Convert.ToString(nudKategoriID.Value) != "")
            {
                sql = "Delete From Kategoris Where KategoriID = ' " + int.Parse(nudKategoriID.Text) + " '    ";
                CUD();
                MessageBox.Show("Silme işlemi gerçekleştirildi.");
                FormuTemizle();
            }
            else if (nudKategoriID.Value < 1)
            {
                MessageBox.Show("Kategori ID'si 1'den küçük olamaz!");
                FormuTemizle();
            }
            else if (nudKategoriID.Value > 10000)
            {
                MessageBox.Show("Kategori ID'si 10000'den büyük olamaz!");
                FormuTemizle();
            }
            else
            {
                MessageBox.Show("Kategori ID boş bırakılamaz!");
                FormuTemizle();
            }
        }







        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void FormuTemizle()
        {
            nudKategoriID.Value=1;
        }







        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }
    }
}
