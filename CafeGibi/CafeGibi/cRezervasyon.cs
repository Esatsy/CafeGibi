using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CafeGibi
{
    class cRezervasyon
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _ID;
        private int _TableId;
        private int _CliendId;
        private DateTime _Date;
        private int _CleintCount;
        private string _Description;
        private int _AdditionId;
        #endregion
        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int TableId { get => _TableId; set => _TableId = value; }
        public int CliendId { get => _CliendId; set => _CliendId = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public int CleintCount { get => _CleintCount; set => _CleintCount = value; }
        public string Description { get => _Description; set => _Description = value; }
        public int AdditionId { get => _AdditionId; set => _AdditionId = value; }
        #endregion
        //MusteriId masa numarasına göre
        public int getByClientIdFromRezervasyon(int tableId)
        {
            int clientId = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT top 1 MUSTERIID from Rezervasyonlar where MASAID=@masaid order by MUSTERIID Desc", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("masaİd", SqlDbType.Int).Value = tableId;
                
                clientId = Convert.ToInt32(cmd.ExecuteNonQuery());

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


            return clientId;

        }
        //Hesap kapatırken rezervasyonlu masayı kapattık
        public bool rezervationclose(int adisyonID)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("UPDATE Rezervasyonlar set durum = 0 where  ADISYONID=@adisyonId", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("adisyonId", SqlDbType.Int).Value = adisyonID;
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
