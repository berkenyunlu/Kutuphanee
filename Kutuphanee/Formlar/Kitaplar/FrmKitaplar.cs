using Kutuphane.DB.Entity;
using Kutuphanee.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphanee.Formlar.Kitaplar
{
    public partial class FrmKitaplar : MetroFramework.Forms.MetroForm
    {
        public FrmKitaplar()
        {
            InitializeComponent();
        }
        private int sayfano = 1;
        private int syfKayitSayi = 50;
        private double toplamsayfa = 0;
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();
        private void FrmKitaplar_Load(object sender, EventArgs e)
        {
            _dataVeriler.RowTemplate.DefaultCellStyle.Font = FormHelpers.DataGridViewFont;
            _dataVeriler.ColumnHeadersDefaultCellStyle.Font = FormHelpers.DataGridViewFont;
            _dataVeriler.EnableHeadersVisualStyles = false;
            _dataVeriler.Rows.Clear();
            _dataVeriler.Columns.Clear();
            _dataVeriler.ColumnCount = 9;
            _dataVeriler.Columns[0].Name = "ID";
            _dataVeriler.Columns[1].Name = "ADI";
            _dataVeriler.Columns[2].Name = "YAZARI";
            _dataVeriler.Columns[3].Name = "YILI";
            _dataVeriler.Columns[4].Name = "SAYFA SAYISI";
            _dataVeriler.Columns[5].Name = "DİLİ";
            _dataVeriler.Columns[6].Name = "YAYIN EVİ";
            _dataVeriler.Columns[7].Name = "ADET";
            _dataVeriler.Columns[8].Name = "BARKOD";
            _dataVeriler.Columns[0].Visible = false;
            _dataVeriler.Columns[3].Width = 75;
            _dataVeriler.Columns[4].Width = 80;
            _dataVeriler.Columns[5].Width = 75;
            _dataVeriler.Columns[7].Width = 60;
            _dataVeriler.Columns[8].Width = 120;

            ListeleStokGrup();
            Listele();

        }
        public void ListeleStokGrup()
        {
            _cmbStokGrubu.Items.Clear();
            _cmbStokGrubu.Items.Add("TÜMÜ");
            using (var context = new DB_KutuphaneEntities())
            {
                var query = from st in context.TBLTUR
                            orderby st.TURADI
                            select st;
                var gruplar = query.ToArray<TBLTUR>();
                foreach (var item in gruplar)
                    _cmbStokGrubu.Items.Add(item.TURADI);
            }
            _cmbStokGrubu.SelectedIndex = 0;
        }
        public void Listele(int? sno = 1)
        {
            _dataVeriler.Rows.Clear();
            db = new DB_KutuphaneEntities();
            ArrayList row = new ArrayList();
            int toplamkayit = 0;
            int atla = ((int)sno - 1) * syfKayitSayi;
            lblhangikayit.Text = atla + "-" + (atla + syfKayitSayi) + " arası kayıtlar";
            List<TBLKITAP> kitaplar = new List<TBLKITAP>();

            if (_ara.Text != "" && _cmbStokGrubu.Text != "TÜMÜ")
            {
                kitaplar = db.TBLKITAP.Where(x => (x.KITAPTURU.Contains(_cmbStokGrubu.Text) && x.KITAPAD.Contains(_ara.Text)) || (x.KITAPTURU.Contains(_cmbStokGrubu.Text) && x.BARKOD.Contains(_ara.Text)) || (x.KITAPTURU.Contains(_cmbStokGrubu.Text) && x.KITAPYAZARI.Contains(_ara.Text)) || (x.KITAPTURU.Contains(_cmbStokGrubu.Text) && x.KITAPYAYINEVI.Contains(_ara.Text))).OrderByDescending(x => x.KITAPAD).Skip(atla).Take(syfKayitSayi).ToList();
                toplamkayit = db.TBLKITAP.Where(x => x.KITAPAD.Contains(_ara.Text) && x.KITAPTURU.Contains(_cmbStokGrubu.Text)).Count();
            }
            else if (_ara.Text != "")
            {
                kitaplar = db.TBLKITAP.Where(x => x.KITAPAD.Contains(_ara.Text) || x.KITAPYAZARI.Contains(_ara.Text) || x.KITAPYAYINEVI.Contains(_ara.Text) || x.BARKOD.Contains(_ara.Text) ).OrderByDescending(x => x.KITAPID).Skip(atla).Take(syfKayitSayi).ToList();
                toplamkayit = db.TBLKITAP.Count();
            }
            else if (_cmbStokGrubu.Text == "TÜMÜ")
            {
                kitaplar = db.TBLKITAP.OrderByDescending(x => x.KITAPID).Skip(atla).Take(syfKayitSayi).ToList();
                toplamkayit = db.TBLKITAP.Count();
            }
            else
            {
                kitaplar = db.TBLKITAP.Where(x => x.KITAPTURU.Contains(_cmbStokGrubu.Text)).OrderByDescending(x => x.KITAPID).Skip(atla).Take(syfKayitSayi).ToList();
                toplamkayit = db.TBLKITAP.Count();
            }

            _adet.Text = toplamkayit.ToString() + " adet kitap bulundu.";

            toplamsayfa = (double)toplamkayit / syfKayitSayi;
            toplamsayfa = Math.Ceiling(toplamsayfa);
            sayfaLabel.Text = "/ " + toplamsayfa.ToString();

            sayfano = (int)sno;
            foreach (var item in kitaplar)
            {
                var emanet = db.TBLEMANET.Where(x => x.KITAPNO == item.KITAPID && x.TESLIMEDILDI==false).ToList(); 
                var dil = db.TBLDIL.Find(item.KITAPDIL);
                row = new ArrayList();
                row.Add(item.KITAPID);
                row.Add(item.KITAPAD);
                row.Add(item.KITAPYAZARI);
                row.Add(item.KITAPBASIMYIL);
                row.Add(item.KITAPSAYFASAYI);
                row.Add(dil.DILAD);
                row.Add(item.KITAPYAYINEVI);
                if (emanet.Count > 0)
                    row.Add(item.ADET - emanet.Count);
                else
                    row.Add(item.ADET);
                row.Add(item.BARKOD);
                _dataVeriler.Rows.Add(row.ToArray());
            }
           Tara();
        }
        public void Tara()
        {
            for (int i = 0; i < _dataVeriler.Rows.Count; i++)
            {
                _dataVeriler.Rows[i].Height = 25;
                //if (i % 2 == 0)
                //    _dataVeriler.Rows[i].DefaultCellStyle.BackColor = Color.White;
                //else
                    _dataVeriler.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            }
            //TaraAnlasma();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }


       

        private void _dataVeriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kayitid = (int)_dataVeriler.SelectedRows[0].Cells[0].Value;
            FrmKitapDetay ekle = new FrmKitapDetay();
            ekle.KayitID = kayitid;
            ekle.ShowDialog();
            Listele();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmKitapEkle kitapekle = new FrmKitapEkle();
            kitapekle.ShowDialog();
            Listele();
        }

        private void btnStokEkle_Click(object sender, EventArgs e)
        {
            FrmKitapEkle ekle = new FrmKitapEkle();
            ekle.ShowDialog();
            Listele();
        }

        private void _cmbStokGrubu_SelectedValueChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void _ara_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Listele();
        }
    }
}
