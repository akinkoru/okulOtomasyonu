using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
    public class Izin:EntityBase
    {
        public int id { get; set; }
        public int ogrenci_no { get; set; }
        public string izin_nedeni { get; set; }
        public DateTime izin_baslangic { get; set; }
        public DateTime izin_bitis { get; set; }

        public override string PrimaryKey
        { get { return "id"; } }
    }
}
