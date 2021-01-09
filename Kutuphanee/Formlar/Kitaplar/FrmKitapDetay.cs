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
using System.Collections;

namespace Kutuphanee.Formlar.Kitaplar
{
    public partial class FrmKitapDetay : MetroFramework.Forms.MetroForm
    {
        public FrmKitapDetay()
        {
            InitializeComponent();
        }
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();
        public int? KayitID { get; set; }
        public void KitapTurGetir()
        {
            var Liste = db.TBLTUR.Select(x => x.TURADI).ToArray();
            _KitapTuru.Items.Clear();
            _KitapTuru.Items.AddRange(Liste);

        }
        private void FrmKitapDetay_Load(object sender, EventArgs e)
        {
            if (KayitID.HasValue)
            {
                KitapTurGetir();
                FormHelpers.DilGetir(metroComboBox1);
                var kitapbilgileri = db.TBLKITAP.Find(KayitID);
                txtBarkod.Text = kitapbilgileri.BARKOD;
                txtKitapAdi.Text = kitapbilgileri.KITAPAD;
                txtYazar.Text = kitapbilgileri.KITAPYAZARI;
                txtYayinevi.Text = kitapbilgileri.KITAPYAYINEVI;
                txtBasimYili.Text = Convert.ToString(kitapbilgileri.KITAPBASIMYIL);
                txtSayfa.Text = Convert.ToString(kitapbilgileri.KITAPSAYFASAYI);
                metroComboBox1.SelectedValue = kitapbilgileri.KITAPDIL;
                metroTextBox1.Text = kitapbilgileri.ADET.ToString();
                string[] Turu = kitapbilgileri.KITAPTURU.Split(new String[] { ", " }, StringSplitOptions.None);
                foreach (var item in Turu)
                {
                    int index = _KitapTuru.FindString(item);
                    if (index == -1 || String.IsNullOrEmpty(item))
                        continue;
                    _KitapTuru.SetItemChecked(index, true);
                }
                metroTextBox2.Text = kitapbilgileri.KITAPTURU;
                richTextBox1.Text = kitapbilgileri.KITAPACIKLAMA;

                _dataVeriler.RowTemplate.DefaultCellStyle.Font = FormHelpers.DataGridViewFont;
                _dataVeriler.ColumnHeadersDefaultCellStyle.Font = FormHelpers.DataGridViewFont;
                _dataVeriler.EnableHeadersVisualStyles = false;
                _dataVeriler.Rows.Clear();
                _dataVeriler.Columns.Clear();
                _dataVeriler.ColumnCount = 7;
                _dataVeriler.Columns[0].Name = "ID";
                _dataVeriler.Columns[1].Name = "ÜYE ADI";
                _dataVeriler.Columns[2].Name = "VERİLME TARİHİ";
                _dataVeriler.Columns[3].Name = "İADE TARİHİ";
                _dataVeriler.Columns[4].Name = "İŞLEM TARİHİ";
                _dataVeriler.Columns[5].Name = "EMANET NUMARASI";
                _dataVeriler.Columns[6].Name = "DURUMU";
                _dataVeriler.Columns[0].Visible = false;
                _dataVeriler.Columns[2].Width = 100;
                _dataVeriler.Columns[3].Width = 100;
                _dataVeriler.Columns[4].Width = 100;
                _dataVeriler.Columns[2].DefaultCellStyle.Format = FormHelpers.TarihFormat;
                _dataVeriler.Columns[3].DefaultCellStyle.Format = FormHelpers.TarihFormat;
                _dataVeriler.Columns[4].DefaultCellStyle.Format = FormHelpers.TarihFormat;
                Listele();
            }
        }
        public void Listele()
        {
            var kayit = db.TBLEMANET.Where(x => x.KITAPNO == KayitID).ToList();
            ArrayList row = new ArrayList();
            foreach (var item in kayit)
            {
                row = new ArrayList();
                var uyebul = db.TBLUYE.Find(item.UYENO);
                row.Add(item.EMANETID);
                row.Add(uyebul.UYEADSOYAD);
                row.Add(item.VERILMETTARIHI);
                row.Add(item.IADETARIHI);
                row.Add(item.ISLEMTARIH);
                row.Add(item.EMANETNO);
                if (item.TESLIMEDILDI == true)
                    row.Add("Teslim Edildi");
                else
                    row.Add("Teslim Edilmedi");
                _dataVeriler.Rows.Add(row.ToArray());
            }

        }

        private void button1_Click(object sender, EventArgs e)
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
            var guncelle = db.TBLKITAP.Find(KayitID);
            guncelle.ADET = Convert.ToInt32(metroTextBox1.Text);
            guncelle.BARKOD = txtBarkod.Text;
            guncelle.KITAPAD = txtKitapAdi.Text;
            guncelle.KITAPYAZARI = txtYazar.Text;
            guncelle.KITAPYAYINEVI = txtYayinevi.Text;
            guncelle.KITAPBASIMYIL = Convert.ToInt32(txtBasimYili.Text);
            guncelle.KITAPSAYFASAYI = Convert.ToInt32(txtBasimYili.Text);
            guncelle.KITAPACIKLAMA = richTextBox1.Text;
            guncelle.KITAPDIL = Convert.ToInt32(metroComboBox1.SelectedValue);
            guncelle.EKLEYEN = Oturum.KullaniciID;
            guncelle.KITAPTURU = secilenKitapTuru;
            db.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(this, new EventArgs());
        }
    }
}
