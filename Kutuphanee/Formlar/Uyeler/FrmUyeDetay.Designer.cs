
namespace Kutuphanee.Formlar.Uyeler
{
    partial class FrmUyeDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.e = new MetroFramework.Controls.MetroTabPage();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.txtTel = new MetroFramework.Controls.MetroTextBox();
            this.txtAdSoyad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this._dataVeriler = new MetroFramework.Controls.MetroGrid();
            this.metroTabControl1.SuspendLayout();
            this.e.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.e);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(894, 370);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // e
            // 
            this.e.Controls.Add(this.txtAdres);
            this.e.Controls.Add(this.button1);
            this.e.Controls.Add(this.metroLabel8);
            this.e.Controls.Add(this.txtMail);
            this.e.Controls.Add(this.txtTel);
            this.e.Controls.Add(this.txtAdSoyad);
            this.e.Controls.Add(this.metroLabel3);
            this.e.Controls.Add(this.metroLabel2);
            this.e.Controls.Add(this.metroLabel1);
            this.e.HorizontalScrollbarBarColor = true;
            this.e.HorizontalScrollbarHighlightOnWheel = false;
            this.e.HorizontalScrollbarSize = 8;
            this.e.Location = new System.Drawing.Point(4, 38);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(886, 328);
            this.e.TabIndex = 0;
            this.e.Text = "Üye Bilgileri";
            this.e.VerticalScrollbarBarColor = true;
            this.e.VerticalScrollbarHighlightOnWheel = false;
            this.e.VerticalScrollbarSize = 10;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(310, 145);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(236, 121);
            this.txtAdres.TabIndex = 139;
            this.txtAdres.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(375, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 138;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(261, 145);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(43, 19);
            this.metroLabel8.TabIndex = 137;
            this.metroLabel8.Text = "Adres";
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(310, 105);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(236, 25);
            this.txtMail.TabIndex = 136;
            this.txtMail.UseSelectable = true;
            this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTel
            // 
            // 
            // 
            // 
            this.txtTel.CustomButton.Image = null;
            this.txtTel.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txtTel.CustomButton.Name = "";
            this.txtTel.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTel.CustomButton.TabIndex = 1;
            this.txtTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTel.CustomButton.UseSelectable = true;
            this.txtTel.CustomButton.Visible = false;
            this.txtTel.Lines = new string[0];
            this.txtTel.Location = new System.Drawing.Point(310, 71);
            this.txtTel.MaxLength = 32767;
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTel.SelectedText = "";
            this.txtTel.SelectionLength = 0;
            this.txtTel.SelectionStart = 0;
            this.txtTel.ShortcutsEnabled = true;
            this.txtTel.Size = new System.Drawing.Size(236, 25);
            this.txtTel.TabIndex = 135;
            this.txtTel.UseSelectable = true;
            this.txtTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdSoyad
            // 
            // 
            // 
            // 
            this.txtAdSoyad.CustomButton.Image = null;
            this.txtAdSoyad.CustomButton.Location = new System.Drawing.Point(212, 1);
            this.txtAdSoyad.CustomButton.Name = "";
            this.txtAdSoyad.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAdSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdSoyad.CustomButton.TabIndex = 1;
            this.txtAdSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdSoyad.CustomButton.UseSelectable = true;
            this.txtAdSoyad.CustomButton.Visible = false;
            this.txtAdSoyad.Lines = new string[0];
            this.txtAdSoyad.Location = new System.Drawing.Point(310, 37);
            this.txtAdSoyad.MaxLength = 32767;
            this.txtAdSoyad.Multiline = true;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.PasswordChar = '\0';
            this.txtAdSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdSoyad.SelectedText = "";
            this.txtAdSoyad.SelectionLength = 0;
            this.txtAdSoyad.SelectionStart = 0;
            this.txtAdSoyad.ShortcutsEnabled = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(236, 25);
            this.txtAdSoyad.TabIndex = 134;
            this.txtAdSoyad.UseSelectable = true;
            this.txtAdSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdSoyad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(257, 105);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 133;
            this.metroLabel3.Text = "E-mail";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(254, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 132;
            this.metroLabel2.Text = "Telefon";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(238, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 131;
            this.metroLabel1.Text = "Ad Soyad";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this._dataVeriler);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(886, 328);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Kitap Geçmişi";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // _dataVeriler
            // 
            this._dataVeriler.AllowUserToAddRows = false;
            this._dataVeriler.AllowUserToDeleteRows = false;
            this._dataVeriler.AllowUserToResizeRows = false;
            this._dataVeriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataVeriler.BackgroundColor = System.Drawing.Color.White;
            this._dataVeriler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._dataVeriler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this._dataVeriler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataVeriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataVeriler.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataVeriler.EnableHeadersVisualStyles = false;
            this._dataVeriler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._dataVeriler.GridColor = System.Drawing.Color.White;
            this._dataVeriler.Location = new System.Drawing.Point(3, 3);
            this._dataVeriler.MultiSelect = false;
            this._dataVeriler.Name = "_dataVeriler";
            this._dataVeriler.ReadOnly = true;
            this._dataVeriler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataVeriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._dataVeriler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._dataVeriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataVeriler.Size = new System.Drawing.Size(883, 322);
            this._dataVeriler.TabIndex = 191;
            // 
            // FrmUyeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUyeDetay";
            this.Text = "Üye Detay";
            this.Load += new System.EventHandler(this.FrmUyeDetay_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.e.ResumeLayout(false);
            this.e.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataVeriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage e;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private MetroFramework.Controls.MetroTextBox txtTel;
        private MetroFramework.Controls.MetroTextBox txtAdSoyad;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroGrid _dataVeriler;
    }
}