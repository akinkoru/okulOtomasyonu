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
    public class OgrenciORM : ORMBase<Ogrenci>
    {
        Tools tools = new Tools();
        public bool ogrenciEkle(Ogrenci ogr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "prc_Ogrenci_Insert";
            cmd.Connection = tools.Baglanti;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ogrenci_no", ogr.Ogrenci_no);
            cmd.Parameters.AddWithValue("@tc", ogr.tc);
            cmd.Parameters.AddWithValue("@ad", ogr.ad);
            cmd.Parameters.AddWithValue("@soyad", ogr.soyad);
            cmd.Parameters.AddWithValue("@sinifi", ogr.sinifi);
            return Tools.BaglantiKontrol(cmd);

        }
        public Ogrenci ogrenciGetir(Ogrenci o,int i)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Ogrenci_Select", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            Ogrenci oGetir = new Ogrenci();
            foreach (DataRow dr in dt.Rows)
            {
                oGetir.Ogrenci_no = Convert.ToInt32(dr["Ogrenci_No"]);
                oGetir.ad = dr["ad"].ToString();
                oGetir.soyad = dr["soyad"].ToString();
            }
            return oGetir;
        }
        public DataTable SinifGetir(int id)
        {
            SqlDataAdapter adp = new SqlDataAdapter("prc_Ogrenci_sinifgetir", tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@sinif_id", id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
    }
}
