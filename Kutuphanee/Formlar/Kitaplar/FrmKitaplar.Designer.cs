
namespace Kutuphanee.Formlar.Kitaplar
{
    partial class FrmKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitaplar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._ara = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this._cmbStokGrubu = new MetroFramework.Controls.MetroComboBox();
            this._dataVeriler = new MetroFramework.Controls.MetroGrid();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.lblhangikayit = new System.Windows.Forms.Label();
            this.sayfaLabel = new System.Windows.Forms.Label();
            this.sayfa = new System.Windows.Forms.TextBox();
            this.Geri = new System.Windows.Forms.Button();
            this.ileri = new System.Windows.Forms.Button();
            this._adet = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._ara);
            this.groupBox1.Controls.Add(this.metroPanel2);
            this.groupBox1.Controls.Add(this.metroPanel1);
            this.groupBox1.Controls.Add(this._cmbStokGrubu);
            this.groupBox1.Controls.Add(this._dataVeriler);
            this.groupBox1.Controls.Add(this.btnStokEkle);
            this.groupBox1.Controls.Add(this.btnBul);
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1215, 544);
            this.groupBox1.TabIndex = 186;
            this.groupBox1.TabStop = false;
            // 
            // _ara
            // 
            // 
            // 
            // 
            this._ara.CustomButton.Image = null;
            this._ara.CustomButton.Location = new System.Drawing.Point(516, 1);
            this._ara.CustomButton.Name = "";
            this._ara.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._ara.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._ara.CustomButton.TabIndex = 1;
            this._ara.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._ara.CustomButton.UseSelectable = true;
            this._ara.CustomButton.Visible = false;
            this._ara.Lines = new string[0];
            this._ara.Location = new System.Drawing.Point(622, 23);
            this._ara.MaxLength = 32767;
            this._ara.Name = "_ara";
            this._ara.PasswordChar = '\0';
            this._ara.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._ara.SelectedText = "";
            this._ara.SelectionLength = 0;
            this._ara.SelectionStart = 0;
            this._ara.ShortcutsEnabled = true;
            this._ara.Size = new System.Drawing.Size(538, 23);
            this._ara.TabIndex = 194;
            this._ara.UseSelectable = true;
            this._ara.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._ara.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._ara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._ara_KeyPress_1);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(528, 18);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(88, 29);
            this.metroPanel2.TabIndex = 193;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Aranan Bilgi";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(248, 18);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(88, 29);
            this.metroPanel1.TabIndex = 192;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Kitap Türü";
            // 
            // _cmbStokGrubu
            // 
            this._cmbStokGrubu.FormattingEnabled = true;
            this._cmbStokGrubu.ItemHeight = 23;
            this._cmbStokGrubu.Location = new System.Drawing.Point(342, 18);
            this._cmbStokGrubu.Name = "_cmbStokGrubu";
            this._cmbStokGrubu.Size = new System.Drawing.Size(180, 29);
            this._cmbStokGrubu.TabIndex = 191;
            this._cmbStokGrubu.UseSelectable = true;
            this._cmbStokGrubu.SelectedValueChanged += new System.EventHandler(this._cmbStokGrubu_SelectedValueChanged);
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
            this._dataVeriler.Location = new System.Drawing.Point(10, 55);
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
            this._dataVeriler.Size = new System.Drawing.Size(1195, 482);
            this._dataVeriler.TabIndex = 190;
            this._dataVeriler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dataVeriler_CellDoubleClick);
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStokEkle.BackColor = System.Drawing.Color.White;
            this.btnStokEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokEkle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokEkle.Image = global::Kutuphanee.Properties.Resources.add;
            this.btnStokEkle.Location = new System.Drawing.Point(10, 10);
            this.btnStokEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(110, 39);
            this.btnStokEkle.TabIndex = 186;
            this.btnStokEkle.Text = "KİTAP EKLE";
            this.btnStokEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStokEkle.UseVisualStyleBackColor = false;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBul.Image = ((System.Drawing.Image)(resources.GetObject("btnBul.Image")));
            this.btnBul.Location = new System.Drawing.Point(1167, 12);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(40, 37);
            this.btnBul.TabIndex = 17;
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // lblhangikayit
            // 
            this.lblhangikayit.AutoSize = true;
            this.lblhangikayit.Location = new System.Drawing.Point(538, 631);
            this.lblhangikayit.Name = "lblhangikayit";
            this.lblhangikayit.Size = new System.Drawing.Size(35, 13);
            this.lblhangikayit.TabIndex = 200;
            this.lblhangikayit.Text = "label1";
            // 
            // sayfaLabel
            // 
            this.sayfaLabel.AutoSize = true;
            this.sayfaLabel.Location = new System.Drawing.Point(982, 634);
            this.sayfaLabel.Name = "sayfaLabel";
            this.sayfaLabel.Size = new System.Drawing.Size(27, 13);
            this.sayfaLabel.TabIndex = 199;
            this.sayfaLabel.Text = "/ 10";
            // 
            // sayfa
            // 
            this.sayfa.Location = new System.Drawing.Point(930, 631);
            this.sayfa.Name = "sayfa";
            this.sayfa.Size = new System.Drawing.Size(46, 20);
            this.sayfa.TabIndex = 198;
            this.sayfa.Text = "1";
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(849, 631);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(75, 23);
            this.Geri.TabIndex = 197;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            // 
            // ileri
            // 
            this.ileri.Location = new System.Drawing.Point(1037, 631);
            this.ileri.Name = "ileri";
            this.ileri.Size = new System.Drawing.Size(75, 23);
            this.ileri.TabIndex = 196;
            this.ileri.Text = "İleri";
            this.ileri.UseVisualStyleBackColor = true;
            // 
            // _adet
            // 
            this._adet.AutoSize = true;
            this._adet.Location = new System.Drawing.Point(189, 631);
            this._adet.Name = "_adet";
            this._adet.Size = new System.Drawing.Size(110, 13);
            this._adet.TabIndex = 195;
            this._adet.Text = "0 adet  kitap  bulundu";
            // 
            // FrmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 681);
            this.Controls.Add(this.lblhangikayit);
            this.Controls.Add(this.sayfaLabel);
            this.Controls.Add(this.sayfa);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.ileri);
            this.Controls.Add(this._adet);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.FrmKitaplar_Load);
            this.groupBox1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataVeriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid _dataVeriler;
        private System.Windows.Forms.Label lblhangikayit;
        private System.Windows.Forms.Label sayfaLabel;
        private System.Windows.Forms.TextBox sayfa;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button ileri;
        private System.Windows.Forms.Label _adet;
        private MetroFramework.Controls.MetroTextBox _ara;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox _cmbStokGrubu;
        private System.Windows.Forms.Button btnStokEkle;
    }
}