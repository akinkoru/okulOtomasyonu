using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
    public class Veli:EntityBase
    {
        public short id { get; set; }
        public string tc { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tel_no { get; set; }
        public string e_posta { get; set; }
        public int ogrenci_no { get; set; }
        public override string PrimaryKey
        { get { return "id"; } }


    }
}
