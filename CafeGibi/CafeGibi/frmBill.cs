using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeGibi
{
    public partial class frmBill : Form
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Close();
            frm.Show();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        cSiparis cs = new cSiparis();
        int odemeTurId = 0;
        private void frmBill_Load(object sender, EventArgs e)
        {
            
            if (cGenel._ServisTurNo==1)
            {
                lbAdisyonId.Text = cGenel._AdisyonId;
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lbAdisyonId.Text));
                if (lvUrunler.Items.Count>0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);

                    }
                    lbToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lbOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lbOdenecek.Text) * 18 / 100;
                    lbKdv.Text = string.Format("{0:0.000}", kdv);

                }
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
            else if (cGenel._ServisTurNo == 2)
            {
                lbAdisyonId.Text = cGenel._AdisyonId;
                cPaketler pc = new cPaketler();
                odemeTurId= pc.OdemeTurIdGetir(Convert.ToInt32(lbAdisyonId.Text));
                txtIndirimTutari.TextChanged += new EventHandler(txtIndirimTutari_TextChanged);
                cs.getByOrder(lvUrunler, Convert.ToInt32(lbAdisyonId.Text));

                if (odemeTurId==1)
                {
                    rbKredi.Checked = true;
                }
                else if (odemeTurId==2)
                {
                    rbNakit.Checked = true;
                }
                else if (odemeTurId==3)
                {
                    rbTicket.Checked = true;
                }


                if (lvUrunler.Items.Count > 0)
                {
                    decimal toplam = 0;
                    for (int i = 0; i < lvUrunler.Items.Count; i++)
                    {
                        toplam += Convert.ToDecimal(lvUrunler.Items[i].SubItems[3].Text);

                    }
                    lbToplamTutar.Text = string.Format("{0:0.000}", toplam);
                    lbOdenecek.Text = string.Format("{0:0.000}", toplam);
                    decimal kdv = Convert.ToDecimal(lbOdenecek.Text) * 18 / 100;
                    lbKdv.Text = string.Format("{0:0.000}", kdv);

                }
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
        }

        private void txtIndirimTutari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtIndirimTutari.Text) < Convert.ToDecimal(lbToplamTutar.Text))
                {
                    try
                    {
                        lbIndirim.Text = string.Format("{0:0.000}", Convert.ToDecimal(txtIndirimTutari.Text));
                    }
                    catch (Exception)
                    {
                        lbIndirim.Text = string.Format("{0:0.000}", 0);
                        
                    }
                }
                else
                {
                    MessageBox.Show("İndirim Tutarı Toplam Tutardan Fazla Olamaz !!!");
                }
            }
            catch (Exception)
            {

                lbIndirim.Text = string.Format("{0:0.000}", 0);
            }
        }

        private void ChkIndirim_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkIndirim.Checked)
            {
                gbIndirim.Visible = true;
                txtIndirimTutari.Clear();
            }
            else
            {
                gbIndirim.Visible = false;
                txtIndirimTutari.Clear();
            }
        }

        private void lbIndirim_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lbIndirim.Text)>0)
            {
                decimal odenecek = 0;
                lbOdenecek.Text = lbToplamTutar.Text;
                odenecek = Convert.ToDecimal(lbOdenecek.Text) - Convert.ToDecimal(lbIndirim.Text);
                lbOdenecek.Text = string.Format("{0:0.000}", odenecek);
            }
            decimal kdv = Convert.ToDecimal(lbOdenecek.Text)*18/100;
            lbKdv.Text = string.Format("{0:0.000}", kdv);
        }
        cMasalar masalar = new cMasalar();
        cRezervasyon rezerve = new cRezervasyon();

        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {
            if (cGenel._ServisTurNo == 1)
            {
                int masaid = masalar.TableGetbyNumber(cGenel._ButtonName);
                int musteriId = 0;
                if (masalar.TableGetbyState(masaid, 4) == true)
                {
                    musteriId = rezerve.getByClientIdFromRezervasyon(masaid);

                }
                else
                {
                    musteriId = 1;
                }
                int odemeTurId = 0;
                if (rbNakit.Checked)
                {
                    odemeTurId = 1;
                }
                if (rbKredi.Checked)
                {
                    odemeTurId = 2;
                }
                if (rbTicket.Checked)
                {
                    odemeTurId = 3;
                }
                cOdeme odeme = new cOdeme();
                //ADISYONID,ODEMETURID,MUSTERIID,ARATOPLAM,KDVTUTARI,TOPLAMTUTAR,INDIRIM
                odeme.AdisyonID = Convert.ToInt32(lbAdisyonId.Text);
                odeme.OdemeTurId = odemeTurId;
                odeme.MusteriId = musteriId;
                odeme.AraToplam = Convert.ToDecimal(lbOdenecek.Text);
                odeme.KdvTutari = Convert.ToDecimal(lbKdv.Text);
                odeme.GenelToplam = Convert.ToDecimal(lbToplamTutar.Text);
                odeme.Indirim = Convert.ToDecimal(lbIndirim.Text);
                bool result = odeme.billClose(odeme);
                if (result)
                {
                    MessageBox.Show("Hesap Kapatılmıştır.");
                    masalar.setChangeTableState(Convert.ToString(masaid), 1);
                    cRezervasyon c = new cRezervasyon();
                    c.rezervationclose(Convert.ToInt32(lbAdisyonId.Text));
                    cAdisyon a = new cAdisyon();
                    a.AdditionClose(Convert.ToInt32(lbAdisyonId.Text), 0);
                    this.Close();
                    frmMasalar frm = new frmMasalar();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Hesap Kapatılırken bir hata oluştu.");
                }
                
            }
        }
    }
}
