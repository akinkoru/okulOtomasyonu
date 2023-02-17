using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
    public class Sinif:EntityBase
    {
        public short id { get; set; }
        public string sinif_adi { get; set; }
        public override string PrimaryKey
        { get { return "id"; } }
    }
}
