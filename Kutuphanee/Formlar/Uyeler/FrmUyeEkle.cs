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

namespace Kutuphanee.Formlar.Uyeler
{
    public partial class FrmUyeEkle : MetroFramework.Forms.MetroForm
    {
        public FrmUyeEkle()
        {
            InitializeComponent();
        }
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();      
        private void FrmUyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLUYE uyeler = new TBLUYE();
            uyeler.UYEADSOYAD = txtAdSoyad.Text;
            uyeler.UYETEL = txtTel.Text;
            uyeler.UYEEPOSTA = txtMail.Text;
            uyeler.UYEADRES = txtAdres.Text;
            uyeler.KAYITTARIHI = Convert.ToDateTime(DateTime.Now);
            uyeler.EKLEYEN = Oturum.KullaniciID;
            db.TBLUYE.Add(uyeler);
            db.SaveChanges();
            this.Close();
        }
    }
}
