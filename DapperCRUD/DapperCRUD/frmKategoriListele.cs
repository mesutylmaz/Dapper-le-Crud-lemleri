using Dapper;       //DynamicParameters için
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        //string sql = "";




        private void Form1_Load(object sender, EventArgs e)
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




        //void CUD(DynamicParameters dynamic=null)    
        //{
        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }
        //    connection.Execute(sql, dynamic, commandType: CommandType.Text);
        //    connection.Close();

        //    foreach (Control item in this.Controls)
        //    {
        //        if(item is TextBox)
        //        {
        //            item.Text = "";
        //        }
        //    }
        //    dgvKategoriler.DataSource = connection.Query<Kategori>("Select * From Kategoris");
        //}





        //private void btnEkle_Click(object sender, EventArgs e)
        //{
        //    DynamicParameters param = new DynamicParameters();
        //    param.Add("@p1", txtKategoriAdi.Text);      //txtKategoriAdi alanındaki veriyi p1 parametresi kabul et
        //    //param.Add("@p2", txtKategoriDurumu.Text);     //Eklenen her kategori aktif olsun diye alttaki satırı ekledim.
        //    param.Add("@p2", 1);
        //    param.Add("@p3", nudKategoriKapasitesi.Text);

        //    if(txtKategoriAdi.Text != null && nudKategoriKapasitesi.Value >= 1 && nudKategoriKapasitesi.Value <= 10000)
        //    {
        //        sql = "Insert into Kategoris values(@p1, @p2, @p3)";
        //        CUD(param);
        //    }
        //    else if(txtKategoriAdi.Text == null || txtKategoriAdi.Text == "")
        //    {
        //        MessageBox.Show("Kategori adı boş bırakılamaz!");
        //    }
        //    else if(nudKategoriKapasitesi.Value < 1)
        //    {
        //        MessageBox.Show("Kategori kapasitesi 1'den küçük olamaz!");
        //    }
        //    else if(nudKategoriKapasitesi.Value > 10000)
        //    {
        //        MessageBox.Show("Kategori kapasitesi 10000'den büyük olamaz!");
        //    }

        //}




        //private void btnSil_Click(object sender, EventArgs e)
        //{
        //    int toplam = int.Parse("Select Count(KategoriID) From Kategoris");
        //    CUD();

        //    if(toplam >= nudKategoriID.Value && nudKategoriID.Value>0 && Convert.ToString(nudKategoriID.Value) != null && Convert.ToString(nudKategoriID.Value) != "")
        //    {
        //        sql = "Delete From Kategoris Where KategoriID = ' " + int.Parse(nudKategoriID.Text) + " '    ";
        //        CUD();
        //    }
        //    else if (nudKategoriID.Value < 1)
        //    {
        //        MessageBox.Show("Kategori ID'si 1'den küçük olamaz!");
        //    }
        //    else if (nudKategoriID.Value > 10000)
        //    {
        //        MessageBox.Show("Kategori ID'si 10000'den büyük olamaz!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Kategori ID boş bırakılamaz!");
        //    }
        //}




        //private void btnGuncelle_Click(object sender, EventArgs e)
        //{
        //    DynamicParameters param = new DynamicParameters();
        //    param.Add("@p1", txtKategoriAdi.Text);
        //    //param.Add("@p2", txtKategoriDurumu.Text);
        //    param.Add("@p3", nudKategoriKapasitesi.Value);
        //    param.Add("@p4", nudKategoriID.Value);

        //    int toplam = int.Parse("Select Count(KategoriID) From Kategoris");

        //    if (toplam >= nudKategoriID.Value && nudKategoriID.Value > 0 && Convert.ToString(nudKategoriID.Value) != null && Convert.ToString(nudKategoriID.Value) != "")
        //    {
        //        if(txtKategoriAdi.Text != null && nudKategoriKapasitesi.Value >0 && nudKategoriKapasitesi.Value <= 10000)
        //        {
        //            sql = "Update Kategoris Set KategoriAdi=@p1, KategoriKapasitesi=@p3 Where KategoriID=@p4";
        //            CUD(param);
        //        }
        //        if (txtKategoriAdi.Text != null && Convert.ToString(nudKategoriKapasitesi.Value) =="" && Convert.ToString(nudKategoriKapasitesi.Value) == null)
        //        {
        //            sql = "Update Kategoris Set KategoriAdi=@p1 Where KategoriID=@p4";
        //            CUD(param);
        //        }
        //        if (txtKategoriAdi.Text == null && nudKategoriKapasitesi.Value > 0 && nudKategoriKapasitesi.Value <= 10000)
        //        {
        //            sql = "Update Kategoris Set KategoriKapasitesi=@p3 Where KategoriID=@p4";
        //            CUD(param);
        //        }
        //    }

        //}
    }
}
