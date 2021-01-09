using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kutuphane.DB.Entity;
using System.Data.Entity;

namespace Kutuphanee.Helpers
{
    class FormHelpers
    {
        public static Font DataGridViewFont = new System.Drawing.Font("Calibri", 12F,
          System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        public class CMB_List
        {
            public int? Value { get; set; }
            public string Text { get; set; }
        }

        public static void DilGetir(ComboBox cmb)
        {
            DB_KutuphaneEntities db = new DB_KutuphaneEntities();
            List<CMB_List> datasource = new List<CMB_List>();

            var diller = db.TBLDIL.OrderBy(x => x.DILAD).ToList();
            foreach (var item in diller)
                datasource.Add(new CMB_List() { Value = item.DILID, Text = item.DILAD });
            if (cmb.Items.Count > 0) cmb.SelectedValue = 0;
            cmb.DataSource = datasource;
            cmb.ValueMember = "Value";
            cmb.DisplayMember = "Text";
        }
        public static void UyeGetir(ComboBox cmb)
        {
            DB_KutuphaneEntities db = new DB_KutuphaneEntities();
            List<CMB_List> datasource = new List<CMB_List>();

            var uyeler = db.TBLUYE.OrderBy(x => x.UYEADSOYAD).ToList();
            foreach (var item in uyeler)
                datasource.Add(new CMB_List() { Value = item.UYEID, Text = item.UYEADSOYAD });
            if (cmb.Items.Count > 0) cmb.SelectedValue = 0;
            cmb.DataSource = datasource;
            cmb.ValueMember = "Value";
            cmb.DisplayMember = "Text";
        }
        public static void KitapGetir(ComboBox cmb)
        {
            DB_KutuphaneEntities db = new DB_KutuphaneEntities();
            List<CMB_List> datasource = new List<CMB_List>();

            var uyeler = db.TBLKITAP.OrderBy(x => x.KITAPAD).ToList();
            foreach (var item in uyeler)
                datasource.Add(new CMB_List() { Value = item.KITAPID, Text = item.KITAPAD });
            if (cmb.Items.Count > 0) cmb.SelectedValue = 0;
            cmb.DataSource = datasource;
            cmb.ValueMember = "Value";
            cmb.DisplayMember = "Text";
        }

        public static string TarihFormat = "dd.MM.yyyy";
    }
}
