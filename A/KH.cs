namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class KH : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TabControl1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [CompilerGenerated, AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonView")]
        private Button A;
        [AccessedThroughProperty("ButtonSave"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("ButtonDelete"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CenterImLogo")]
        private PictureBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage2")]
        private TabPage R;
        [AccessedThroughProperty("ButtonHeBrows"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [AccessedThroughProperty("ButtonHedSave"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button I;
        [AccessedThroughProperty("ButtonHedDel"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterImHedar"), CompilerGenerated]
        private PictureBox R;
        [AccessedThroughProperty("OpenFileDialog1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OpenFileDialog A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("OpenFileDialog2")]
        private OpenFileDialog R;
        [CompilerGenerated, AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("OpenFileDialog3"), CompilerGenerated]
        private OpenFileDialog P;
        private SqlConnection A;
        private DataSet A;
        private string A;
        private DataSet R;
        private string R;

        public KH()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataSet();
            this.R = new DataSet();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.ButtonView = new Button();
            this.ButtonSave = new Button();
            this.ButtonDelete = new Button();
            this.CenterImLogo = new PictureBox();
            this.TabPage2 = new TabPage();
            this.ButtonHeBrows = new Button();
            this.ButtonHedSave = new Button();
            this.ButtonHedDel = new Button();
            this.CenterImHedar = new PictureBox();
            this.OpenFileDialog1 = new OpenFileDialog();
            this.OpenFileDialog2 = new OpenFileDialog();
            this.ButtonClose = new Button();
            this.OpenFileDialog3 = new OpenFileDialog();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((ISupportInitialize) this.CenterImLogo).BeginInit();
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize) this.CenterImHedar).BeginInit();
            base.SuspendLayout();
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new Point(1, 0x15);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(15, 3);
            this.TabControl1.RightToLeft = RightToLeft.Yes;
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x203, 0x173);
            this.TabControl1.TabIndex = 15;
            this.TabPage1.Controls.Add(this.ButtonView);
            this.TabPage1.Controls.Add(this.ButtonSave);
            this.TabPage1.Controls.Add(this.ButtonDelete);
            this.TabPage1.Controls.Add(this.CenterImLogo);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x1fb, 0x156);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "تعديل صورة الشعار";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtonView.FlatAppearance.BorderColor = Color.Green;
            this.ButtonView.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonView.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonView.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonView.FlatStyle = FlatStyle.Flat;
            this.ButtonView.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonView.Image = A.F.ImView;
            this.ButtonView.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonView.Location = new Point(280, 0x2a);
            this.ButtonView.Margin = new Padding(3, 4, 3, 4);
            this.ButtonView.Name = "ButtonView";
            this.ButtonView.Size = new Size(220, 0x2c);
            this.ButtonView.TabIndex = 10;
            this.ButtonView.Text = "استعراض الملفات";
            this.ButtonView.UseVisualStyleBackColor = true;
            this.ButtonSave.Enabled = false;
            this.ButtonSave.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSave.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSave.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSave.FlatStyle = FlatStyle.Flat;
            this.ButtonSave.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSave.Image = A.F.ImSave;
            this.ButtonSave.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new Point(280, 0x5e);
            this.ButtonSave.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new Size(220, 0x2c);
            this.ButtonSave.TabIndex = 9;
            this.ButtonSave.Text = "حفظ الشعار";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonDelete.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDelete.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDelete.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDelete.FlatStyle = FlatStyle.Flat;
            this.ButtonDelete.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDelete.Image = A.F.ImDelete;
            this.ButtonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new Point(280, 0x92);
            this.ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new Size(220, 0x2c);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "حذف الشعار";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.CenterImLogo.BackColor = Color.WhiteSmoke;
            this.CenterImLogo.BackgroundImageLayout = ImageLayout.Center;
            this.CenterImLogo.BorderStyle = BorderStyle.FixedSingle;
            this.CenterImLogo.Location = new Point(6, 0x2a);
            this.CenterImLogo.Name = "CenterImLogo";
            this.CenterImLogo.Size = new Size(0x10c, 0xb3);
            this.CenterImLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.CenterImLogo.TabIndex = 0;
            this.CenterImLogo.TabStop = false;
            this.TabPage2.Controls.Add(this.ButtonHeBrows);
            this.TabPage2.Controls.Add(this.ButtonHedSave);
            this.TabPage2.Controls.Add(this.ButtonHedDel);
            this.TabPage2.Controls.Add(this.CenterImHedar);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x1fb, 0x156);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "تعديل الترويسه";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonHeBrows.FlatAppearance.BorderColor = Color.Green;
            this.ButtonHeBrows.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonHeBrows.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonHeBrows.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonHeBrows.FlatStyle = FlatStyle.Flat;
            this.ButtonHeBrows.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonHeBrows.Image = A.F.ImView;
            this.ButtonHeBrows.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonHeBrows.Location = new Point(0xfb, 0x9c);
            this.ButtonHeBrows.Margin = new Padding(3, 4, 3, 4);
            this.ButtonHeBrows.Name = "ButtonHeBrows";
            this.ButtonHeBrows.Size = new Size(0xf6, 0x2c);
            this.ButtonHeBrows.TabIndex = 14;
            this.ButtonHeBrows.Text = "استعراض الملفات";
            this.ButtonHeBrows.UseVisualStyleBackColor = true;
            this.ButtonHedSave.Enabled = false;
            this.ButtonHedSave.FlatAppearance.BorderColor = Color.Green;
            this.ButtonHedSave.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonHedSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonHedSave.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonHedSave.FlatStyle = FlatStyle.Flat;
            this.ButtonHedSave.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonHedSave.Image = A.F.ImSave;
            this.ButtonHedSave.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonHedSave.Location = new Point(0xfb, 0xd0);
            this.ButtonHedSave.Margin = new Padding(3, 4, 3, 4);
            this.ButtonHedSave.Name = "ButtonHedSave";
            this.ButtonHedSave.Size = new Size(0xf6, 0x2c);
            this.ButtonHedSave.TabIndex = 13;
            this.ButtonHedSave.Text = "حفظ الترويسه";
            this.ButtonHedSave.UseVisualStyleBackColor = true;
            this.ButtonHedDel.FlatAppearance.BorderColor = Color.Green;
            this.ButtonHedDel.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonHedDel.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonHedDel.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonHedDel.FlatStyle = FlatStyle.Flat;
            this.ButtonHedDel.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonHedDel.Image = A.F.ImDelete;
            this.ButtonHedDel.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonHedDel.Location = new Point(3, 0x9c);
            this.ButtonHedDel.Margin = new Padding(3, 4, 3, 4);
            this.ButtonHedDel.Name = "ButtonHedDel";
            this.ButtonHedDel.Size = new Size(0xd4, 0x60);
            this.ButtonHedDel.TabIndex = 12;
            this.ButtonHedDel.Text = "حذف الترويسه";
            this.ButtonHedDel.UseVisualStyleBackColor = true;
            this.CenterImHedar.BackColor = Color.WhiteSmoke;
            this.CenterImHedar.BackgroundImageLayout = ImageLayout.Center;
            this.CenterImHedar.BorderStyle = BorderStyle.FixedSingle;
            this.CenterImHedar.Location = new Point(6, 6);
            this.CenterImHedar.Name = "CenterImHedar";
            this.CenterImHedar.Size = new Size(0x1ef, 0x83);
            this.CenterImHedar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.CenterImHedar.TabIndex = 11;
            this.CenterImHedar.TabStop = false;
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.OpenFileDialog2.FileName = "OpenFileDialog2";
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x135, 0x18f);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xcf, 0x2c);
            this.ButtonClose.TabIndex = 0x10;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.OpenFileDialog3.FileName = "OpenFileDialog3";
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x20c, 0x1c8);
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ButtonClose);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CenterImageLogoHedar";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تعديل الصور";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((ISupportInitialize) this.CenterImLogo).EndInit();
            this.TabPage2.ResumeLayout(false);
            ((ISupportInitialize) this.CenterImHedar).EndInit();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            try
            {
                FileStream input = new FileStream(this.OpenFileDialog2.FileName, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[((int) input.Length) + 1];
                new BinaryReader(input).Read(buffer, 0, (int) input.Length);
                input.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE TaNNCenters SET CenterImHedar =@CenterImHedar WHERE (CenterID = @CenterID)", this.A);
                command.Parameters.AddWithValue("CenterID", PR.GR);
                command.Parameters.AddWithValue("CenterImHedar", buffer);
                command.ExecuteNonQuery();
                this.A.Close();
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.A != null))
                {
                    this.A.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void F(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    byte[] buffer = new MemoryStream().ToArray();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE TaNNCenters SET CenterImHedar =@CenterImHedar WHERE (CenterID = @CenterID)", this.A);
                    command.Parameters.AddWithValue("CenterID", PR.GR);
                    command.Parameters.AddWithValue("CenterImHedar", buffer);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void H(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void I(object A, EventArgs R)
        {
            this.OpenFileDialog2.Filter = "Image Files (*.bmp;*.jpg;*.png;*.JPG;*.jpeg)|*.bmp;*.jpg;*.png;*.JPG;*.jpeg";
            if (this.OpenFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.CenterImHedar.Image = Image.FromFile(this.OpenFileDialog2.FileName);
                this.ButtonHedSave.Enabled = true;
            }
        }

        private void P(object A, EventArgs R)
        {
            try
            {
                FileStream input = new FileStream(this.OpenFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[((int) input.Length) + 1];
                new BinaryReader(input).Read(buffer, 0, (int) input.Length);
                input.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE TaNNCenters SET CenterImLogo =@CenterImLogo WHERE (CenterID = @CenterID)", this.A);
                command.Parameters.AddWithValue("CenterID", PR.GR);
                command.Parameters.AddWithValue("CenterImLogo", buffer);
                command.ExecuteNonQuery();
                this.A.Close();
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                A.D.A.A.ImLogoHome.Image = (this.CenterImLogo.Image != null) ? this.CenterImLogo.Image : A.D.A.A.PictureBoxDefult.Image;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void Q(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    byte[] buffer = new MemoryStream().ToArray();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE TaNNCenters SET CenterImLogo =@CenterImLogo WHERE (CenterID = @CenterID)", this.A);
                    command.Parameters.AddWithValue("CenterID", PR.GR);
                    command.Parameters.AddWithValue("CenterImLogo", buffer);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    A.D.A.A.ImLogoHome = null;
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void R(object A, EventArgs R)
        {
            this.OpenFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.png;*.JPG;*.jpeg)|*.bmp;*.jpg;*.png;*.JPG;*.jpeg";
            if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.CenterImLogo.Image = Image.FromFile(this.OpenFileDialog1.FileName);
                this.ButtonSave.Enabled = true;
            }
        }

        internal virtual TabControl TabControl1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonView
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                Button a = this.A;
                if (a != null)
                {
                    a.Click -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Click += handler;
                }
            }
        }

        internal virtual Button ButtonSave
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                Button r = this.R;
                if (r != null)
                {
                    r.Click -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.Click += handler;
                }
            }
        }

        internal virtual Button ButtonDelete
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                Button p = this.P;
                if (p != null)
                {
                    p.Click -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.Click += handler;
                }
            }
        }

        internal virtual PictureBox CenterImLogo
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonHeBrows
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                Button q = this.Q;
                if (q != null)
                {
                    q.Click -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.Click += handler;
                }
            }
        }

        internal virtual Button ButtonHedSave
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                Button i = this.I;
                if (i != null)
                {
                    i.Click -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.Click += handler;
                }
            }
        }

        internal virtual Button ButtonHedDel
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                Button d = this.D;
                if (d != null)
                {
                    d.Click -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.Click += handler;
                }
            }
        }

        internal virtual PictureBox CenterImHedar
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual OpenFileDialog OpenFileDialog1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual OpenFileDialog OpenFileDialog2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                Button f = this.F;
                if (f != null)
                {
                    f.Click -= handler;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.Click += handler;
                }
            }
        }

        internal virtual OpenFileDialog OpenFileDialog3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }
    }
}

