using Kutuphanee.Formlar.Emanet;
using Kutuphanee.Formlar.Kitaplar;
using Kutuphanee.Formlar.Uyeler;
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

namespace Kutuphanee.Formlar
{
    public partial class AnaForm : MetroFramework.Forms.MetroForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
     
        private void AnaForm_Load(object sender, EventArgs e)
        {
          
            
        }

        private void buttonGirisKitapEkle_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonGirisUyeEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGirisEmanetListele_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            FrmKitaplar frmkitap = new FrmKitaplar();
            frmkitap.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            FrmEmanet frmemanet = new FrmEmanet();
            frmemanet.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            FrmUyeler frmuye = new FrmUyeler();
            frmuye.ShowDialog();
        }
    }
}
