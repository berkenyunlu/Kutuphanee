using Kutuphanee.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.DB.Entity;
using System.Data.Entity;
using Kutuphanee.Helpers;


namespace Kutuphanee.Formlar.Kitaplar
{
    public partial class FrmKitapEkle : MetroFramework.Forms.MetroForm
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
            //FormTasarim tasarim = new FormTasarim(this);
        }
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();
        //public int? Kitapid { get; set; }
        private void FrmKitapEkle_Load(object sender, EventArgs e)
        {
            KitapTurGetir();
            FormHelpers.DilGetir(metroComboBox1);
        }
        public void KitapTurGetir()
        {
            var Liste = db.TBLTUR.Select(x => x.TURADI).ToArray();
            _KitapTuru.Items.Clear();
            _KitapTuru.Items.AddRange(Liste);

        }

        private void _KitapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            String secilen_Tur = "";
            foreach (var item in _KitapTuru.CheckedItems)
            {
                secilen_Tur += item.ToString() + ", ";
            }
            _KitapTuru.Text = secilen_Tur;
            metroTextBox2.Text = secilen_Tur;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }



        private void txtBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                e.Handled = true;
        }

        private void txtKitapAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                e.Handled = true;
        }

        private void txtYazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                e.Handled = true;
        }

        private void txtYayinevi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                e.Handled = true;
        }

        private void txtSayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                e.Handled = true;
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var secilenKitapTuru = metroTextBox2.Text;
                if (String.IsNullOrEmpty(secilenKitapTuru))
                {
                    MessageBox.Show("Lütfen Önce Ekipdekileri Seçiniz.", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtKitapAdi.Text == "")
                {
                    MessageBox.Show("Lütfen Kitap Adı Giriniz");
                    return;
                }
                db = new DB_KutuphaneEntities();
                TBLKITAP Yeni = new TBLKITAP();
                Yeni.BARKOD = txtBarkod.Text;
                Yeni.KITAPAD = txtKitapAdi.Text;
                Yeni.KITAPYAZARI = txtYazar.Text;
                Yeni.KITAPYAYINEVI = txtYayinevi.Text;
                Yeni.KITAPBASIMYIL = Convert.ToInt32(txtBasimYili.Text);
                Yeni.KITAPSAYFASAYI = Convert.ToInt32(txtBasimYili.Text);
                Yeni.KITAPACIKLAMA = richTextBox1.Text;
                Yeni.KITAPDIL = Convert.ToInt32(metroComboBox1.SelectedValue);
                Yeni.EKLEYEN = Oturum.KullaniciID;
                Yeni.ADET = Convert.ToInt32(metroTextBox1.Text);
                Yeni.KAYITTARIHI = Convert.ToDateTime(DateTime.Now);
                Yeni.KITAPTURU = secilenKitapTuru;
                db.TBLKITAP.Add(Yeni);
                db.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(this, new EventArgs());
        }
    }
}
