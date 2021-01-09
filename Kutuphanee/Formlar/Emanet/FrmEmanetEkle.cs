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

namespace Kutuphanee.Formlar.Emanet
{
    public partial class FrmEmanetEkle : MetroFramework.Forms.MetroForm
    {
        public FrmEmanetEkle()
        {
            InitializeComponent();
        }
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();
        private void FrmEmanetEkle_Load(object sender, EventArgs e)
        {
            string onid = "";
            FormHelpers.UyeGetir(cmbUyeAd);
            FormHelpers.KitapGetir(cmbKitapAd);
            var stokkodu = db.TBLREFERANSNO
                            .Where(x => x.AD == "EMANET").FirstOrDefault();
            for (int i = 0; i < 9 - (stokkodu.SAYAC + 1).ToString().Length; i++) onid += "0";
            txtEmanetNo.Text = "KTP"  + onid + (stokkodu.SAYAC + 1);
            DateTime tarih1 = txtVerilmeTarihi.Value;
            txtIadeTarihi.Value = tarih1.AddDays(3);  
        }

        private void txtVerilmeTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTime tarih1 = txtVerilmeTarihi.Value;
            txtIadeTarihi.Value = tarih1.AddDays(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtIadeTarihi.Value<txtVerilmeTarihi.Value)
            {
                MessageBox.Show("İade Tarihi Verilme Tarihinden Önce Olmaz");
                return;
            }
            if(cmbKitapAd.Text=="")
            {
                MessageBox.Show("Lütfen Kitap Seçiniz");
                return;
            }
            if(cmbUyeAd.Text=="")
            {
                MessageBox.Show("Lütfen Üye Seçiniz");
                return;
            }
            TBLEMANET Yeni = new TBLEMANET();
            Yeni.UYENO = Convert.ToInt32(cmbUyeAd.SelectedValue);
            Yeni.KITAPNO = Convert.ToInt32(cmbKitapAd.SelectedValue);
            Yeni.VERILMETTARIHI = txtVerilmeTarihi.Value;
            Yeni.IADETARIHI = txtIadeTarihi.Value;
            Yeni.EKLEYEN = Oturum.KullaniciID;
            Yeni.EMANETNO = txtEmanetNo.Text;
            Yeni.TESLIMEDILDI = false;
            var no = db.TBLREFERANSNO.Find(1);
            int deger = Convert.ToInt32(no.SAYAC);
            deger++;
            no.SAYAC = deger;
            db.SaveChanges();
            db.TBLEMANET.Add(Yeni);
            db.SaveChanges();
            this.Close();
        }
    }
}
