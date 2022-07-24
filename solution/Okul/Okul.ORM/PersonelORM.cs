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
    public class PersonelORM:ORMBase<Personel>
    {
        public static Personel kullanici;
        Tools tools = new Tools();
        public Personel girisYap(Personel p)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Personel_Giris", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@ka", p.k_adi);
            adp.SelectCommand.Parameters.AddWithValue("@psw", p.sifre);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count==0) return null;
            Personel Pgiris = new Personel();
            foreach (DataRow dr in dt.Rows)
            {
                Pgiris.id = (short)dr["id"];
                Pgiris.ad = dr["ad"].ToString();
                Pgiris.soyad= dr["soyad"].ToString();
                Pgiris.k_adi = dr["k_adi"].ToString();
                Pgiris.sifre= dr["sifre"].ToString();
                Pgiris.pozisyon = (short)dr["pozisyon"];}
            return Pgiris;
        }
        public DataTable adsoyadgetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Personel_adsoyadGetir", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
      }
}
