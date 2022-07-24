using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
    public class Disiplin:EntityBase
    {
        public int id { get; set; }
        public string ogrenci_no { get; set; }
        public string ceza { get; set; }
        public DateTime ceza_baslangic { get; set; }
        public DateTime ceza_bitis { get; set; }

        public override string PrimaryKey
        { get { return "id"; } }
    }
}
