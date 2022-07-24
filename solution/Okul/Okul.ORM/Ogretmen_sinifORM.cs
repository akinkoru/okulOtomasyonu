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
    public class Ogretmen_sinifORM:ORMBase<Ogretmen_sinif>
    {
        Tools tools = new Tools();
        public DataTable sinifGetir(Ogretmen_sinif o)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Ogretmen_sinif_SinifGetir", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@personelid", o.personel_id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }

}
