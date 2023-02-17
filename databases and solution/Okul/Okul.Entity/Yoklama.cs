using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
    public class Yoklama:EntityBase
    {
        public int id { get; set; }
        public short ders_id { get; set; }
        public int ogrenci_no { get; set; }
        public DateTime tarih { get; set; }
        public string durum { get; set; }

        public override string PrimaryKey
        { get { return "id"; } }
    }
}
