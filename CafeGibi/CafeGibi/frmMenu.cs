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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMasaSiparis_Click(object sender, EventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            this.Close();
            frm.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezerve frm = new frmRezerve();
            this.Close();
            frm.Show();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            frmPaketServis frm = new frmPaketServis();
            this.Close();
            frm.Show();
        }

        private void btnKasaIslemleri_Click(object sender, EventArgs e)
        {
            frmKasaIslemleri frm = new frmKasaIslemleri();
            this.Close();
            frm.Show();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();
            this.Close();
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            this.Close();
            frm.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            this.Close();
            frm.Show();
        }

        private void btnKilitle_Click(object sender, EventArgs e)
        {
            frmKilitle frm = new frmKilitle();
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

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            this.Close();
            frm.Show();
        }
    }
}
