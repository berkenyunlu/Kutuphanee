using Kutuphanee.Kontrols;
using Kutuphanee.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphanee.Helpers
{
    public class FormTasarim
    {
        public Label Baslik;
        Form formx;
        Panel i1;
        Panel i2;
        Panel i3;
        Panel i4;
        public Button btnBildirim;
        Color cache;

        public FormTasarim(Form form)
        {
            form.Padding = new Padding(1, 1, 1, 1);
            form.Paint += Border_Paint;
            int v1 = 7;
            Color color = Color.FromArgb(70, 130, 180);
            formx = form;
            i1 = new Panel();
            i1.SendToBack();
            i1.BackColor = color;
            i1.Size = new Size(0, 30);
            i1.Dock = DockStyle.Top;
            //i1.Cursor = Cursors.SizeAll;
            i2 = new Panel();
            i2.SendToBack();
            i2.BackColor = color;
            i2.Size = new Size(0, v1);
            i2.Dock = DockStyle.Bottom;
            i3 = new Panel();
            i3.SendToBack();
            i3.BackColor = color;
            i3.Size = new Size(v1, 0);
            i3.Dock = DockStyle.Left;
            i4 = new Panel();
            i4.SendToBack();
            i4.BackColor = color;
            i4.Size = new Size(v1, 0);
            i4.Dock = DockStyle.Right;

            Button button = new Button();
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            //button.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button.Dock = DockStyle.Right;
            button.Size = new Size(50, 30);
            button.Image = Resources.cross_mark_on_a_black_circle_background;
            button.Click += delegate { form.Close(); };

            //btnBildirim = new Button();
            //btnBildirim.Tag = form.Text;
            //btnBildirim.FlatStyle = FlatStyle.Flat;
            //btnBildirim.FlatAppearance.BorderSize = 0;
            //btnBildirim.Dock = DockStyle.Right;
            //btnBildirim.Size = new Size(50, 30);
            //btnBildirim.Image = Resources.envelope_of_white_paper;
            //btnBildirim.Click += GeriBildirim;

            Baslik = new Label();
            Baslik.Text = form.Text;
            Baslik.AutoSize = true;
            Baslik.Location = new Point(16, v1);
            Baslik.ForeColor = Color.White;
            i1.Controls.Add(btnBildirim);
            i1.Controls.Add(button);
            i1.Controls.Add(Baslik);
            form.Controls.Add(i1);
            form.Controls.Add(i2);
            form.Controls.Add(i3);
            form.Controls.Add(i4);
            DragControl dragControl1 = new DragControl();
            form.Controls.Add(dragControl1.SelectControl = i1);
            form.Size = new Size(form.Width + v1 + v1, form.Height + 30 + v1);
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterScreen;
            // form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 10, 10));
            //form.Icon = Resources.Photoshop;
            form.KeyPreview = true;
            form.KeyDown += FormClose_KeyDown;
            form.Activated += Form_Activated;
            form.Leave += Form_Leave;
            //form.ShowInTaskbar = false;
            //form.BackColor= ColorTranslator.FromHtml("#99b4d1");
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is Control)
                    {
                        control.Location = new Point(control.Location.X + v1, control.Location.Y + 30);
                        if (control.Anchor == (AnchorStyles.Top | AnchorStyles.Right))
                        {
                            control.Location = new Point(control.Location.X - v1 - v1, control.Location.Y);
                        }
                        if (control.Anchor == (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right))
                        {
                            control.Location = new Point(control.Location.X - v1 - v1, control.Location.Y);
                        }
                        if (control.Anchor == (AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right))
                        {
                            control.Location = new Point(control.Location.X, control.Location.Y - 30 - v1);
                        }
                        if (control.Anchor == (AnchorStyles.Left | AnchorStyles.Bottom))
                        {
                            control.Location = new Point(control.Location.X, control.Location.Y - 30 - v1);
                        }
                        if (control.Anchor == (AnchorStyles.Left | AnchorStyles.Right))
                        {
                            control.Location = new Point(control.Location.X, control.Location.Y - 25);
                        }
                        if (control.Anchor == (AnchorStyles.Top | AnchorStyles.Bottom))
                        {
                            control.Location = new Point(control.Location.X - v1, control.Location.Y);
                        }
                        if (control.Anchor == (AnchorStyles.Bottom | AnchorStyles.Right))
                        {
                            control.Location = new Point(control.Location.X - 14, control.Location.Y - 30 - v1);
                        }
                        if (control.Anchor == (AnchorStyles.Bottom | AnchorStyles.Top |
                        AnchorStyles.Left | AnchorStyles.Right))
                        {
                            control.Size = new Size(control.Size.Width - 14, control.Size.Height - 30 - v1);
                        }
                        if (control.Anchor == (AnchorStyles.Top |
                        AnchorStyles.Left | AnchorStyles.Right))
                        {
                            control.Size = new Size(control.Size.Width - 14, control.Size.Height);
                        }
                    }
                    if (control is TextBox)
                    {
                        control.Enter += delegate { control.BackColor = Color.FromArgb(255, 255, 128); };
                        control.Leave += delegate { control.BackColor = Color.White; };
                    }
                    if (control is GroupBox)
                    {
                        foreach (Control ctr in control.Controls)
                        {
                            if (ctr is TextBox)
                            {
                                ctr.Enter += delegate { ctr.BackColor = Color.FromArgb(255, 255, 128); };
                                ctr.Leave += delegate { ctr.BackColor = Color.White; };
                            }
                            if (ctr is TabControl)
                            {
                                foreach (Control ct in ctr.Controls)
                                {
                                    foreach (Control c in ct.Controls)
                                    {
                                        if (c is TextBox)
                                        {
                                            c.Enter += delegate { c.BackColor = Color.FromArgb(255, 255, 128); };
                                            c.Leave += delegate { c.BackColor = Color.White; };

                                        }
                                    }

                                }
                            }
                        }
                    }
                    if (control is TabControl)
                    {
                        foreach (Control ct in control.Controls)
                        {
                            foreach (Control c in ct.Controls)
                            {
                                if (c is TextBox)
                                {
                                    c.Enter += delegate { c.BackColor = Color.FromArgb(255, 255, 128); };
                                    c.Leave += delegate { c.BackColor = Color.White; };

                                }
                            }

                        }
                    }
                }
            };
            func(form.Controls);
            //form.StartPosition = FormStartPosition.Manual;
            //form.Location = new Point(200, 100);
            Random rnd = new Random();
            Color randomColor = Color.FromArgb(85, 99, 126);
            i1.BackColor = randomColor;
            i2.BackColor = randomColor;
            i3.BackColor = randomColor;
            i4.BackColor = randomColor;
            cache = randomColor;
        }

        public void Renklendir(Color color)
        {
            cache = color;
            i1.BackColor = color;
            i2.BackColor = color;
            i3.BackColor = color;
            i4.BackColor = color;
        }

        private void FormClose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                formx.Close();
            }
        }

        //private void GeriBildirim(object sender, EventArgs e)
        //{
        //    GeriBildirimForm FA = new GeriBildirimForm();
        //    FA.ShowDialog();
        //}

        private void Border_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, formx.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void Form_Leave(object sender, EventArgs e)
        {
            cache = i1.BackColor;
            Renklendir(Color.DimGray);
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            Renklendir(cache);
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
       private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}
