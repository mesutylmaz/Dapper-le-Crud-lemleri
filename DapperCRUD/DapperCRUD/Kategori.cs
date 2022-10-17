using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCRUD
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public bool KategoriDurumu { get; set; }
        public int KategoriKapasitesi { get; set; }
    }
}
