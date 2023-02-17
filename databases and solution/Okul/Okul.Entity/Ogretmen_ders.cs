using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
   public class Ogretmen_ders : EntityBase
    {
        public int id { get; set; }
        public int personel_id { get; set; }
        public int ders_id { get; set; }
        public override string PrimaryKey
        { get { return "id"; } }
    }
}
