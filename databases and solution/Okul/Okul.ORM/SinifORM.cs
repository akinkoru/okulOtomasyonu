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
    public class SinifORM:ORMBase<Sinif>
    {
        Tools tools = new Tools();

        public DataTable sinifGetir(Sinif o)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Sinif_sinifidGetir", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@sinif", o.sinif_adi);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public short sinifidgetir(string adi)
        {
            short id = 0;
            SqlDataAdapter adp = new SqlDataAdapter("prc_Sinif_SinifIDgetir", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@sinifadi", adi);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 0) return 0;
            Personel Pgiris = new Personel();
            foreach (DataRow dr in dt.Rows)
            {
                id = (short)dr["id"];
            }
            return id;
        }
    }
}
