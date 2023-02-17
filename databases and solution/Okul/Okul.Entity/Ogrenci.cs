using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
   public class Ogrenci:EntityBase
    {
        public int Ogrenci_no { get; set; }
        public string tc{ get; set; }
        public string ad{ get; set; }
        public string soyad{ get; set; }
        public int sinifi { get; set; }
        public override string PrimaryKey
        { get { return "Ogrenci_no"; } }
    }
}
