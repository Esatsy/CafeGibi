using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeGibi
{
    class cUrunCesitleri
    {
        cGenel gnl = new cGenel();
        #region Fields
        private int _UrunTurNo;
        private string _KategoriAd;
        private string _Aciklama;
        #endregion
        #region Properties
        public int UrunTurNo { get => _UrunTurNo; set => _UrunTurNo = value; }
        public string KategoriAd { get => _KategoriAd; set => _KategoriAd = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        #endregion
        public void getByProductTypes(ListView Cesitler, Button btn)
        {
            Cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select URUNADI,FIYAT,urunler.ID From kategoriler Inner Join urunler on kategoriler.ID=urunler.KATEGORIID Where urunler.KATEGORIID=@KATEGORIID", conn);
            string aa = btn.Name;
            int uzunluk = aa.Length;
            comm.Parameters.Add("@KATEGORIID", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if (conn.State== ConnectionState.Closed)
            {
                conn.Open();

            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNADI"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
        public void getByProductSearch(ListView Cesitler, int txt)
        {
            Cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("Select * From urunler Where ID=@ID", conn);

            comm.Parameters.Add("@ID", SqlDbType.Int).Value = txt;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Cesitler.Items.Add(dr["URUNADI"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                Cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
    }
}
