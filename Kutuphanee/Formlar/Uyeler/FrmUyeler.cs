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
using System.Collections;

namespace Kutuphanee.Formlar.Uyeler
{
    public partial class FrmUyeler : MetroFramework.Forms.MetroForm
    {
        public FrmUyeler()
        {
            InitializeComponent();
        }
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();
        private int sayfano = 1;
        private int syfKayitSayi = 50;
        private double toplamsayfa = 0;
        private void FrmUyeler_Load(object sender, EventArgs e)
        {
            _dataVeriler.RowTemplate.DefaultCellStyle.Font = FormHelpers.DataGridViewFont;
            _dataVeriler.ColumnHeadersDefaultCellStyle.Font = FormHelpers.DataGridViewFont;
            _dataVeriler.EnableHeadersVisualStyles = false;
            _dataVeriler.Rows.Clear();
            _dataVeriler.Columns.Clear();
            _dataVeriler.ColumnCount = 5;
            _dataVeriler.Columns[0].Name = "ID";
            _dataVeriler.Columns[1].Name = "AD SOYAD";
            _dataVeriler.Columns[2].Name = "TELEFON";
            _dataVeriler.Columns[3].Name = "EPOSTA";
            _dataVeriler.Columns[4].Name = "ADRES";         
            _dataVeriler.Columns[0].Visible = false;
            _dataVeriler.Columns[2].Width = 150;
            _dataVeriler.Columns[3].Width = 220;
            Listele();
 
        }
        public void Listele(int? sno=1)
        {
            _dataVeriler.Rows.Clear();
            db = new DB_KutuphaneEntities();
            ArrayList row = new ArrayList();
            int toplamkayit = 0;
            int atla = ((int)sno - 1) * syfKayitSayi;
            lblhangikayit.Text = atla + "-" + (atla + syfKayitSayi) + " arası kayıtlar";
            List<TBLUYE> uyeler = new List<TBLUYE>();           
            if (_ara.Text != "")
            {
                uyeler = db.TBLUYE.Where(x => x.UYEADSOYAD.Contains(_ara.Text)).OrderByDescending(x => x.UYEADSOYAD).Skip(atla).Take(syfKayitSayi).ToList();
                toplamkayit = db.TBLUYE.Count();
            }            
            else
            {
                uyeler = db.TBLUYE.Select(x=>x).OrderByDescending(x => x.UYEADSOYAD).Skip(atla).Take(syfKayitSayi).ToList();
                toplamkayit = db.TBLUYE.Count();
            }

            _adet.Text = toplamkayit.ToString() + " adet kitap bulundu.";

            toplamsayfa = (double)toplamkayit / syfKayitSayi;
            toplamsayfa = Math.Ceiling(toplamsayfa);
            sayfaLabel.Text = "/ " + toplamsayfa.ToString();

            sayfano = (int)sno;
            foreach (var item in uyeler)
            {
                row = new ArrayList();
                row.Add(item.UYEID);
                row.Add(item.UYEADSOYAD);
                row.Add(item.UYETEL);
                row.Add(item.UYEEPOSTA);
                row.Add(item.UYEADRES);
                _dataVeriler.Rows.Add(row.ToArray());
            }
        }

      

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            FrmUyeEkle ekle = new FrmUyeEkle();
            ekle.ShowDialog();
            Listele();
        }

        private void _dataVeriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kayitid = (int)_dataVeriler.SelectedRows[0].Cells[0].Value;
            FrmUyeDetay detay = new FrmUyeDetay();
            detay.KayitID = kayitid;
            detay.ShowDialog();
            Listele();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void _ara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Listele();
        }
    }
}
