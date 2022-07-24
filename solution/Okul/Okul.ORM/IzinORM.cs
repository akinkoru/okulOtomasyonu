using Okul.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.ORM
{
    public class IzinORM:ORMBase<Izin>
    {
        Tools tools = new Tools();
        public DataTable mevcutizinliler()
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Izın_MevcutIzinliler", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
