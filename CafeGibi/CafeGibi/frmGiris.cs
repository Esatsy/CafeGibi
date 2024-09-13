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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._personelId = p.PersonelId;
            cGenel._gorevId = p.PersonelGorevId;
        }
        
        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetInformation(cbKullanici);
            

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            cPersoneller p = new cPersoneller();
            
            bool result = p.personelEntryControl(txtSifre.Text, cGenel._personelId);
            if (result)
            {

                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGenel._personelId;
                ch.Islem = "Giriş Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?","Uyarı !!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)Keys.Enter)
            {
                btnGiris.PerformClick();

            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
