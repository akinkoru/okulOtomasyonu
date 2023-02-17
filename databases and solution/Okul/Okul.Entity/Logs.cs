using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity
{
    public class Logs : EntityBase
    {
        public Logs() { }   
        public short id { get; set; }
        public string yapilan_is { get; set; }
        public short kimin_tarafindan { get; set; }
        public DateTime tarih { get; set; }
        public override string PrimaryKey
        { get { return "id"; } }
    }
}
