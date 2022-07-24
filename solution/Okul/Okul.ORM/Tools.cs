using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.ORM
{
    public class Tools
    {
        //singelton pattern (her çağırıldığında newlenmesini engelliyoruz)
        private SqlConnection baglanti;

        public SqlConnection Baglanti
        {
            get {
                if (baglanti==null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
                }
                return baglanti;
            }
            set { baglanti = value; }
        }
        public static bool BaglantiKontrol(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State==ConnectionState.Closed) cmd.Connection.Open();
                int etkilenen = cmd.ExecuteNonQuery();
                if (etkilenen > 0) return true;
                else return false;
            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
        }


    }
}
