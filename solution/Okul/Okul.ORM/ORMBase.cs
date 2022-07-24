using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Okul.ORM
{
   public class ORMBase<TT> : IORM<TT>
    {
        Tools tools = new Tools();
        Type TipGetir
        {
            get
            {
                return typeof(TT);
            }
        }
        public bool Ekle(TT entity)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("prc_{0}_Insert", TipGetir.Name);
            cmd.Connection = tools.Baglanti;
            cmd.CommandType = CommandType.StoredProcedure;
            //reflection
            PropertyInfo[] propertys = TipGetir.GetProperties();
            foreach (PropertyInfo pi in propertys)
            {
                string padi=pi.Name;
                if (padi=="PrimaryKey")continue;
                object deger = pi.GetValue(entity);
                cmd.Parameters.AddWithValue(padi, deger);
            }
            return Tools.BaglantiKontrol(cmd);
        }

        public bool Guncelle(TT entity)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("prc_{0}_Update", TipGetir.Name);
            cmd.Connection = tools.Baglanti;
            cmd.CommandType = CommandType.StoredProcedure;
            //reflection
            PropertyInfo[] propertys = TipGetir.GetProperties();
            foreach (PropertyInfo pi in propertys)
            {
                string padi = pi.Name;
                if (padi == "PrimaryKey") continue;
                object deger = pi.GetValue(entity);
                cmd.Parameters.AddWithValue(padi, deger);
            }
            return Tools.BaglantiKontrol(cmd);
        }

        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = tools.Baglanti;
            cmd.CommandText = string.Format("prc_{0}_Select",TipGetir.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public DataTable arat(string getir)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = tools.Baglanti;
            cmd.CommandText = string.Format("prc_{0}_Like", TipGetir.Name);
            cmd.Parameters.AddWithValue("@ara", getir);
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Sil(int id)
        {
            TT t = Activator.CreateInstance<TT>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("prc_{0}_Delete", TipGetir.Name);
            cmd.Connection = tools.Baglanti;
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo PrimaryKey = TipGetir.GetProperty("PrimaryKey");
            string padi = "@"+PrimaryKey.GetValue(t);
            cmd.Parameters.AddWithValue(padi, id);
            return Tools.BaglantiKontrol(cmd);
        }
    }
}
