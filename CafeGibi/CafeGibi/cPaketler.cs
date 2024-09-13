using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CafeGibi
{
    class cPaketler
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _AdditionID;
        private int _CliendId;
        private string _Description;
        private int _State;
        private int __PaytypeId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int AdditionID { get => _AdditionID; set => _AdditionID = value; }
        public int CliendId { get => _CliendId; set => _CliendId = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int State { get => _State; set => _State = value; }
        public int PaytypeId { get => __PaytypeId; set => __PaytypeId = value; }
        #endregion
        //Paket Servis Açma
        public bool OrderSeriveceOpen(cPaketler order)
        {
            bool result;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into paketSiparis(ADISYONID,MUSTERIID,ODEMETURUID,ACIKLAMA,Durum) Values (@ADISYONID,@MUSTERIID,@ODEMETURID,@ACIKLAMA)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = order._AdditionID;
                cmd.Parameters.Add("MUSTERID", SqlDbType.Int).Value = order._CliendId;
                cmd.Parameters.Add("@ODEMETURID", SqlDbType.Int).Value = order.__PaytypeId;
                cmd.Parameters.Add("@ACIKLAMA", SqlDbType.VarChar).Value = order._Description;
                result = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }
        //Paket Servisi kapatma
        public void OrderSeriveceClose(int AdditionID)
        {
            
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update paketSiparis set paketSiparis.durum=1 from paketSiparis Inner Join on paketSiparis.ADISYONID=adisyonlar.ID WHERE paketSiparis.ADISYONID=@AdditionID", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ADISYONID", SqlDbType.Int).Value = AdditionID;
                
                Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            
        }
        //Açılan Adisyon ve paket sipariş ait ön girilen odeme tur Id
        public int OdemeTurIdGetir(int adisyonId)
        {
            int odemeTurID = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select paketSiparis.ODEMETURUID from PaketSiparis Inner Join Adisyon on paketSiparis.ADISYONID=Adisyon.ID where adisyon.ID=@adisyonId)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@adisyonId", SqlDbType.Int).Value = adisyonId;
                odemeTurID = Convert.ToInt32(cmd.ExecuteScalar());
              

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return odemeTurID;
        }
        //Sipariş Kontrol için Müşteriye Ait Açık olan en son adisyon getirme
        //bir müşteriye ait 2 tane siparişin açık olamayacağını belirtiyor.
        public int musteriSonAdisyonGetir(int musteriID)
        {
            int no = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select adisyon.ID from adisyon Inner Join Adisyon on paketSiparis.ADISYONID=Adisyon.ID where (adisyon.Durum=0) AND (paketSiparis.Durum=0) and paketSiparis.MUSTERIID=@musteriID adisyon.ID=@adisyonId)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@musteriID", SqlDbType.Int).Value = musteriID;
                no = Convert.ToInt32(cmd.ExecuteScalar());


            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return no;
        }
        //Müşteri Arama Ekranında adisyonbul butonu adisyon açık mı değil mi kontrol.
        public bool getCheckOpenAdditionId(int additionID)
        {
            bool result;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From adisyon Where (Durum=0) and (ID=@additionID)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@additionID", SqlDbType.Int).Value = additionID;
                
                result = Convert.ToBoolean(cmd.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return result;
        }

    }
}
