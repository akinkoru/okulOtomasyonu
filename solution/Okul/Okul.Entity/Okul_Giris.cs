using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
    public class Okul_Giris:EntityBase
    {
        public int id { get; set; }
        public string kart_no { get; set; }
        public DateTime tarih{ get; set; }
        public string saat{ get; set; }
        public string dakika{ get; set; }

        public override string PrimaryKey
        { get { return "id"; } }
    }
}
