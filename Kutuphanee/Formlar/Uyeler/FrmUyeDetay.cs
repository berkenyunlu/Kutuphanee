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

namespace Kutuphanee.Formlar.Uyeler
{
    public partial class FrmUyeDetay : MetroFramework.Forms.MetroForm
    {
        public FrmUyeDetay()
        {
            InitializeComponent();
        }
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();
        public int? KayitID { get; set; }
        private void FrmUyeDetay_Load(object sender, EventArgs e)
        {
            if(KayitID.HasValue)
            {
                var kayitlarigetir = db.TBLUYE.Find(KayitID);
                txtAdSoyad.Text = kayitlarigetir.UYEADSOYAD;
                txtTel.Text = kayitlarigetir.UYETEL;
                txtMail.Text = kayitlarigetir.UYEEPOSTA;
                txtAdres.Text = kayitlarigetir.UYEADRES;

                _dataVeriler.RowTemplate.DefaultCellStyle.Font = FormHelpers.DataGridViewFont;
                _dataVeriler.ColumnHeadersDefaultCellStyle.Font = FormHelpers.DataGridViewFont;
                _dataVeriler.EnableHeadersVisualStyles = false;
                _dataVeriler.Rows.Clear();
                _dataVeriler.Columns.Clear();
                _dataVeriler.ColumnCount = 7;
                _dataVeriler.Columns[0].Name = "ID";
                _dataVeriler.Columns[1].Name = "KITAP ADI";
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
            else
            {
                this.Close();
            }
        }
        public void Listele()
        {
            
            var kayit = db.TBLEMANET.Where(x => x.UYENO == KayitID).ToList();
            ArrayList row = new ArrayList();
            foreach (var item in kayit)
            {
                row = new ArrayList();
                var kitapbul = db.TBLKITAP.Find(item.KITAPNO);
                row.Add(item.EMANETID);
                row.Add(kitapbul.KITAPAD);
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
            var guncelle = db.TBLUYE.Find(KayitID);
            guncelle.UYEADSOYAD = txtAdSoyad.Text;
            guncelle.UYETEL = txtTel.Text;
            guncelle.UYEEPOSTA = txtMail.Text;
            guncelle.UYEADRES = txtAdres.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarı İle Gerçekleşti");
        }
    }
}
