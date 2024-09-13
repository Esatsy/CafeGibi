using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeGibi
{
    class cAdisyon
    {
        #region fields
        private int _ID;
        private int _ServisTurNo;
        private decimal _Tutar;
        private DateTime _Tarih;
        private int _PersonelId;
        private bool _Durum;
        private int _MasaId;
        #endregion
        #region properties
        public int ID { get => _ID; set => _ID = value; }
        public int ServisTurNo { get => _ServisTurNo; set => _ServisTurNo = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public bool Durum { get => _Durum; set => _Durum = value; }
        public int MasaId { get => _MasaId; set => _MasaId = value; }
        #endregion
        cGenel gnl = new cGenel();
        public int getByAddition(int MasaId)

        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 ID From adisyon Where MasaId=@MasaId Order by ID desc", con);
            cmd.Parameters.Add("MasaId", SqlDbType.Int).Value = MasaId;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                MasaId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Close();
            }
            return MasaId; 
        }
        //Açık Olan Masanın Adisyon Numarası
        public bool setByAdditionNew(cAdisyon Bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Insert Into Adisyon(ServisTurNo,Tarih,PersonelID,MasaId,Durum) VALUES(@ServisTurNo,@Tarih,@PersonelID,@MasaId,@Durum)",con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@ServisTurNo", SqlDbType.Int).Value = Bilgiler.ServisTurNo;
                cmd.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Bilgiler.Tarih;
                cmd.Parameters.Add("@PersonelID", SqlDbType.Int).Value = Bilgiler.PersonelId;
                cmd.Parameters.Add("@MasaId", SqlDbType.Int).Value = Bilgiler.MasaId;
                cmd.Parameters.Add("@Durum", SqlDbType.Bit).Value = Bilgiler.Durum;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
            return sonuc;
        }
        public void AdditionClose(int adisyonID, int durum)
        {
            
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("UPDATE adisyon set durum = @durum where  ID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("adisyonId", SqlDbType.Int).Value = adisyonID;
                cmd.Parameters.Add("durum", SqlDbType.Int).Value = durum;
                cmd.ExecuteNonQuery();

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

    }
}
