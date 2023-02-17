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
    public class DisiplinORM:ORMBase<Disiplin>
    {
        Tools tools = new Tools();
        public DataTable Cezalı()
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Disiplin_Cezalılar", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
