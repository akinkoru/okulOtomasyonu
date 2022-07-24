using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
  public  class Pozisyon:EntityBase
    {
        public short pozisyon_id { get; set; }
        public string pozisyon_adi { get; set; }
        public short yetki_id { get; set; }
        public override string PrimaryKey
        { get { return "id"; } }
    }
}
