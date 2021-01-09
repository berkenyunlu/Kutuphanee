
namespace Kutuphanee.Formlar.Emanet
{
    partial class FrmEmanetEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.e = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtIadeTarihi = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtVerilmeTarihi = new MetroFramework.Controls.MetroDateTime();
            this.txtEmanetNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbKitapAd = new MetroFramework.Controls.MetroComboBox();
            this.cmbUyeAd = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.e.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // e
            // 
            this.e.Controls.Add(this.metroLabel5);
            this.e.Controls.Add(this.txtIadeTarihi);
            this.e.Controls.Add(this.metroLabel4);
            this.e.Controls.Add(this.txtVerilmeTarihi);
            this.e.Controls.Add(this.txtEmanetNo);
            this.e.Controls.Add(this.metroLabel3);
            this.e.Controls.Add(this.cmbKitapAd);
            this.e.Controls.Add(this.cmbUyeAd);
            this.e.Controls.Add(this.button1);
            this.e.Controls.Add(this.metroLabel2);
            this.e.Controls.Add(this.metroLabel1);
            this.e.HorizontalScrollbarBarColor = true;
            this.e.HorizontalScrollbarHighlightOnWheel = false;
            this.e.HorizontalScrollbarSize = 8;
            this.e.Location = new System.Drawing.Point(4, 38);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(357, 272);
            this.e.TabIndex = 0;
            this.e.Text = "Emanet Bilgileri";
            this.e.VerticalScrollbarBarColor = true;
            this.e.VerticalScrollbarHighlightOnWheel = false;
            this.e.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 171);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 138;
            this.metroLabel5.Text = "İade Tarihi";
            // 
            // txtIadeTarihi
            // 
            this.txtIadeTarihi.Location = new System.Drawing.Point(93, 170);
            this.txtIadeTarihi.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtIadeTarihi.Name = "txtIadeTarihi";
            this.txtIadeTarihi.Size = new System.Drawing.Size(261, 29);
            this.txtIadeTarihi.TabIndex = 137;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(-2, 137);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.TabIndex = 136;
            this.metroLabel4.Text = "Verilme Tarihi";
            // 
            // txtVerilmeTarihi
            // 
            this.txtVerilmeTarihi.Location = new System.Drawing.Point(93, 133);
            this.txtVerilmeTarihi.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtVerilmeTarihi.Name = "txtVerilmeTarihi";
            this.txtVerilmeTarihi.Size = new System.Drawing.Size(261, 29);
            this.txtVerilmeTarihi.TabIndex = 135;
            this.txtVerilmeTarihi.ValueChanged += new System.EventHandler(this.txtVerilmeTarihi_ValueChanged);
            // 
            // txtEmanetNo
            // 
            // 
            // 
            // 
            this.txtEmanetNo.CustomButton.Image = null;
            this.txtEmanetNo.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.txtEmanetNo.CustomButton.Name = "";
            this.txtEmanetNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmanetNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmanetNo.CustomButton.TabIndex = 1;
            this.txtEmanetNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmanetNo.CustomButton.UseSelectable = true;
            this.txtEmanetNo.CustomButton.Visible = false;
            this.txtEmanetNo.Enabled = false;
            this.txtEmanetNo.Lines = new string[0];
            this.txtEmanetNo.Location = new System.Drawing.Point(93, 22);
            this.txtEmanetNo.MaxLength = 32767;
            this.txtEmanetNo.Name = "txtEmanetNo";
            this.txtEmanetNo.PasswordChar = '\0';
            this.txtEmanetNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmanetNo.SelectedText = "";
            this.txtEmanetNo.SelectionLength = 0;
            this.txtEmanetNo.SelectionStart = 0;
            this.txtEmanetNo.ShortcutsEnabled = true;
            this.txtEmanetNo.Size = new System.Drawing.Size(261, 23);
            this.txtEmanetNo.TabIndex = 134;
            this.txtEmanetNo.UseSelectable = true;
            this.txtEmanetNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmanetNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 133;
            this.metroLabel3.Text = "Emanet No";
            // 
            // cmbKitapAd
            // 
            this.cmbKitapAd.FormattingEnabled = true;
            this.cmbKitapAd.ItemHeight = 23;
            this.cmbKitapAd.Location = new System.Drawing.Point(93, 96);
            this.cmbKitapAd.Name = "cmbKitapAd";
            this.cmbKitapAd.Size = new System.Drawing.Size(261, 29);
            this.cmbKitapAd.TabIndex = 132;
            this.cmbKitapAd.UseSelectable = true;
            // 
            // cmbUyeAd
            // 
            this.cmbUyeAd.FormattingEnabled = true;
            this.cmbUyeAd.ItemHeight = 23;
            this.cmbUyeAd.Location = new System.Drawing.Point(93, 59);
            this.cmbUyeAd.Name = "cmbUyeAd";
            this.cmbUyeAd.Size = new System.Drawing.Size(261, 29);
            this.cmbUyeAd.TabIndex = 131;
            this.cmbUyeAd.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(144, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 129;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Kitap Adı";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Ad Soyad";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.e);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(365, 314);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // FrmEmanetEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 394);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmanetEkle";
            this.Text = "Emanet Kitap Ver";
            this.Load += new System.EventHandler(this.FrmEmanetEkle_Load);
            this.e.ResumeLayout(false);
            this.e.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabPage e;
        private MetroFramework.Controls.MetroTextBox txtEmanetNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbKitapAd;
        private MetroFramework.Controls.MetroComboBox cmbUyeAd;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime txtIadeTarihi;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime txtVerilmeTarihi;
    }
}