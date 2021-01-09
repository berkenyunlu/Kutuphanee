
using Kutuphane.DB.Entity;
using Kutuphanee.Formlar;
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

namespace Kutuphanee
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        DB_KutuphaneEntities db = new DB_KutuphaneEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                TBLKULLANICILAR kontrol = new TBLKULLANICILAR();
                kontrol = db.TBLKULLANICILAR.FirstOrDefault(x => x.KADI == txtUserName.Text && x.KSIFRE == txtpassword.Text);
                if (kontrol != null)
                {
                    Oturum.KullaniciID = kontrol.ID;
                    Oturum.Adi = kontrol.ADSOYAD;
                    Oturum.Gorevi = kontrol.GOREV;
                    Oturum.Yetki = Convert.ToInt32(kontrol.YETKI);
                    Hide();
                    using (AnaForm fd = new AnaForm())
                    {
                        fd.ShowDialog();                      
                    }
                    Show();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi Lütfen Kontrol Edin");
                    txtpassword.Clear();
                }
            }
            catch (Exception)
            {


            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                button1_Click(this, new EventArgs());
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                e.Handled = true;
        }
    }
}
