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

namespace Kutuphanee.Formlar.Emanet
{
    public partial class FrmEmanet : MetroFramework.Forms.MetroForm
    {
        public FrmEmanet()
        {
            InitializeComponent();
        }
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();
        private void FrmEmanet_Load(object sender, EventArgs e)
        {
            _dataVeriler.RowTemplate.DefaultCellStyle.Font = FormHelpers.DataGridViewFont;
            _dataVeriler.ColumnHeadersDefaultCellStyle.Font = FormHelpers.DataGridViewFont;
            _dataVeriler.EnableHeadersVisualStyles = false;
            _dataVeriler.Rows.Clear();
            _dataVeriler.Columns.Clear();
            _dataVeriler.ColumnCount = 8;
            _dataVeriler.Columns[0].Name = "ID";
            _dataVeriler.Columns[1].Name = "KİTAP";
            _dataVeriler.Columns[2].Name = "ÜYE";
            _dataVeriler.Columns[3].Name = "VERİLME TARİHİ";
            _dataVeriler.Columns[4].Name = "İADE TARİHİ";
            _dataVeriler.Columns[5].Name = "İŞLEM TARİHİ";
            _dataVeriler.Columns[6].Name = "EMANET NO";
            _dataVeriler.Columns[7].Name = "DURUMU";
            _dataVeriler.Columns[0].Visible = false;
            _dataVeriler.Columns[3].Width = 70;
            _dataVeriler.Columns[4].Width = 70;
            _dataVeriler.Columns[5].Width = 70;
            _dataVeriler.Columns[6].Width = 70;
            _dataVeriler.Columns[7].Width = 120;
            _dataVeriler.Columns[3].DefaultCellStyle.Format = FormHelpers.TarihFormat;
            _dataVeriler.Columns[4].DefaultCellStyle.Format = FormHelpers.TarihFormat;
            _dataVeriler.Columns[5].DefaultCellStyle.Format = FormHelpers.TarihFormat;
            Listele();
        }
        public void Listele()
        {
            db = new DB_KutuphaneEntities();
            _dataVeriler.Rows.Clear();
            var kayit = db.TBLEMANET.Select(x => x).OrderBy(x=>x.EMANETID).ToList();
            ArrayList row = new ArrayList();
            foreach (var item in kayit)
            {
                row = new ArrayList();
                var kitapbul = db.TBLKITAP.Find(item.KITAPNO);
                var uyebul = db.TBLUYE.Find(item.UYENO);
                row.Add(item.EMANETID);
                row.Add(kitapbul.KITAPAD);
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
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            FrmEmanetEkle ekle = new FrmEmanetEkle();
            ekle.ShowDialog();
            Listele();
        }

        private void _dataVeriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kayitid = (int)_dataVeriler.SelectedRows[0].Cells[0].Value;
            FrmEmanetDetay detay = new FrmEmanetDetay();
            detay.KayitID = kayitid;
            detay.ShowDialog();
            Listele();
        }
    }
}
