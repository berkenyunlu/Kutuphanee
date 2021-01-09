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

namespace Kutuphanee.Formlar.Emanet
{
    public partial class FrmEmanetDetay : MetroFramework.Forms.MetroForm
    {
        public FrmEmanetDetay()
        {
            InitializeComponent();
        }
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();
        public int? KayitID { get; set; }
        private void FrmEmanetDetay_Load(object sender, EventArgs e)
        {
            FormHelpers.KitapGetir(cmbKitapAd);
            FormHelpers.UyeGetir(cmbUyeAd);
            var kayitlar = db.TBLEMANET.Find(KayitID);
            var uye = db.TBLUYE.Find(kayitlar.UYENO);
            var kitap = db.TBLKITAP.Find(kayitlar.KITAPNO);
            txtEmanetNo.Text = kayitlar.EMANETNO;
            txtIadeTarihi.Value = Convert.ToDateTime(kayitlar.IADETARIHI);
            txtVerilmeTarihi.Value = Convert.ToDateTime(kayitlar.VERILMETTARIHI);
            cmbUyeAd.SelectedValue = kayitlar.UYENO;
            cmbKitapAd.SelectedValue = kayitlar.KITAPNO;
            if (kayitlar.TESLIMEDILDI == true)
                metroRadioButton1.Checked = true;
            else
                metroRadioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtIadeTarihi.Value<txtVerilmeTarihi.Value)
            {
                MessageBox.Show("İade Tarihi Verilme Tarihinden Önce Olamaz.");
                return;
            }
            var guncelle = db.TBLEMANET.Find(KayitID);
            guncelle.EMANETNO = txtEmanetNo.Text;
            guncelle.IADETARIHI = txtIadeTarihi.Value;
            guncelle.VERILMETTARIHI = txtVerilmeTarihi.Value;
            guncelle.UYENO = Convert.ToInt32(cmbUyeAd.SelectedValue);
            guncelle.KITAPNO = Convert.ToInt32(cmbKitapAd.SelectedValue);
            if (metroRadioButton1.Checked)
            {
                guncelle.ISLEMTARIH = DateTime.Now;
                guncelle.TESLIMEDILDI = true;
            }
            else
                guncelle.TESLIMEDILDI = false;
            db.SaveChanges();
            this.Close();

        }
    }
}
