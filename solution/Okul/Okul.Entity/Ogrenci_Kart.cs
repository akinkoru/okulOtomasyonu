using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
    public class Ogrenci_Kart:EntityBase
    {
        public int id { get; set; }
        public int Ogrenci_no { get; set; }
        public string kart_no { get; set; }
        public override string PrimaryKey
        { get { return "id"; } }
    }
}
