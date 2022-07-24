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
    //prc_Ogretmen_ders_DersGetir
    public class Ogretmen_dersORM:ORMBase<Ogretmen_ders>
    {
        Tools tools = new Tools();
        public DataTable sinifGetir(int personel_id)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Ogretmen_ders_DersGetir", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@personelid", personel_id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
