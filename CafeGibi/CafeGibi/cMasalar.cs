﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeGibi
{
    class cMasalar
    {
        #region Fields
        private int _ID;
        private int _KAPASITE;
        private int _DURUM;
        private int _ONAY;
        #endregion
        #region porperties
        public int ID { get => _ID; set => _ID = value; }
        public int KAPASITE { get => _KAPASITE; set => _KAPASITE = value; }
        public int DURUM { get => _DURUM; set => _DURUM = value; }
        public int ONAY { get => _ONAY; set => _ONAY = value; }
        #endregion
        cGenel gnl = new cGenel();
        public string SessionSum(int state,string masaId)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("SELECT Tarih,MasaId from adisyon Right Join Masalar on adisyon.MasaId=masalar.ID WHERE masalar.DURUM=@durum and adisyon.Durum = 0 and masalar.ID=@masaId", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@masaId", SqlDbType.Int).Value = Convert.ToInt32(masaId);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["Tarih"]).ToString();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }
        public int TableGetbyNumber(string TableValue)
        {
            string aa = TableValue;
            int length = aa.Length;
            if (length > 8)
            {
                return Convert.ToInt32(aa.Substring(length - 2, 2));

            }
            else
            {
                return Convert.ToInt32(aa.Substring(length - 1, 1));
            }
            

        }
        public bool TableGetbyState(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select durum From Masalar Where Id=@TableId and DURUM=@state",con);
            cmd.Parameters.Add("@TableId", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
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
        public void setChangeTableState(string ButonName, int state)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Update masalar Set DURUM=@Durum where ID=@MasaNo", con);
            string masaNo="";
                if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = ButonName; ;
            int uzunluk = aa.Length;
            
            cmd.Parameters.Add("@Durum", SqlDbType.Int).Value = state;
            if (uzunluk>8)
            {
                masaNo = aa.Substring(uzunluk - 2, 2);
                
            }
            else
            {
                masaNo = aa.Substring(uzunluk - 1, 1);
            }
            cmd.Parameters.Add("@MasaNo", SqlDbType.Int).Value = masaNo;
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }
    }
}
