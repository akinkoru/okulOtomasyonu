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
    public class Okul_GirisORM:ORMBase<Okul_Giris>
    {
        Tools tools = new Tools();
        public DataTable OkulGirisBugun()
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Okul_Giris_Bugün", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
