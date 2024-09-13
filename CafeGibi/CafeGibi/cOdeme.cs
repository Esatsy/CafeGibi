using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CafeGibi
{
    class cOdeme
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _OdemeID;
        private int _AdisyonID;
        private int _OdemeTurId;
        private decimal _AraToplam;
        private decimal _Indirim;
        private decimal _KdvTutari;
        private decimal _GenelToplam;
        private DateTime _Tarih;
        private int _MusteriId;
        #endregion
        #region Properties
        public int OdemeID { get => _OdemeID; set => _OdemeID = value; }
        public int AdisyonID { get => _AdisyonID; set => _AdisyonID = value; }
        public int OdemeTurId { get => _OdemeTurId; set => _OdemeTurId = value; }
        public decimal AraToplam { get => _AraToplam; set => _AraToplam = value; }
        public decimal Indirim { get => _Indirim; set => _Indirim = value; }
        public decimal KdvTutari { get => _KdvTutari; set => _KdvTutari = value; }
        public decimal GenelToplam { get => _GenelToplam; set => _GenelToplam = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        #endregion
        //Müşteri Masa Hesabını Kapat
        public bool billClose(cOdeme bill)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into hesapOdemeleri(ADISYONID,ODEMETURID,MUSTERIID,ARATOPLAM,KDVTUTARI,TOPLAMTUTAR,INDIRIM) Values(@ADISYONID,@ODEMETURID,@MUSTERIID,@ARATOPLAM,@KDVTUTARI,@TOPLAMTUTAR,@INDIRIM)", con);

            try
            {
                if (con.State== ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("ADISYONID", SqlDbType.Int).Value = bill._AdisyonID;
                cmd.Parameters.Add("ODEMETURID", SqlDbType.Int).Value = bill._OdemeTurId;
                cmd.Parameters.Add("MUSTERIID", SqlDbType.Int).Value = bill._MusteriId;
                cmd.Parameters.Add("ARATOPLAM", SqlDbType.Money).Value = bill._AraToplam;
                cmd.Parameters.Add("KDVTUTARI", SqlDbType.Money).Value = bill._KdvTutari;
                cmd.Parameters.Add("TOPLAMTUTAR", SqlDbType.Money).Value = bill._GenelToplam;
                cmd.Parameters.Add("INDIRIM", SqlDbType.Money).Value = bill._Indirim;
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

        //Müşterinin toplam harcamasını bul.
        public decimal sumTotalforCliendId(int cliendId)
        {
            decimal total = 0;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select sum(TOPLAMTUTAR) as total from hesapOdemeleri Where MUSTERIID=@cliendId", con);
            
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("cliendId", SqlDbType.Int).Value = cliendId;
                total = Convert.ToDecimal(cmd.ExecuteScalar());
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
            return total;
        }


    }
}
