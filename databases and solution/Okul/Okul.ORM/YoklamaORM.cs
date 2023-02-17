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
    public class YoklamaORM:ORMBase<Yoklama>
    {
        Tools tools = new Tools();

        public DataTable yoklamaogrencigetir(int numara)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Yoklama_ogrenciGetir", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@ogrencino", numara);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public int total(int numara)
        {
            int devamsizlik = -1;
            SqlDataAdapter adp = new SqlDataAdapter("prc_Yoklama_ogrenciTotal", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@ogrencino", numara);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 0) return devamsizlik;
            foreach (DataRow dr in dt.Rows)
            {
                devamsizlik =Convert.ToInt32(dr["total"]);
            }
            return devamsizlik;
        }
    }
}
