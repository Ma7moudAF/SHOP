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
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class UH : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("PictureBoxDefult"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PictureBox A;
        [CompilerGenerated, AccessedThroughProperty("CenterImHedar"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PictureBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterImLogo"), CompilerGenerated]
        private PictureBox P;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("ComboBoxCenters"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("ButtonOk"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose"), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("TxTSortCenterID"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        private SqlConnection A;
        private DataSet A;
        private string A;

        public UH()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = new DataSet();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(UH));
            this.TxTTitle = new Label();
            this.ComboBoxCenters = new ComboBox();
            this.TxTSortCenterID = new TextBox();
            this.ButtonOk = new Button();
            this.ButtonClose = new Button();
            this.PictureBoxDefult = new PictureBox();
            this.CenterImHedar = new PictureBox();
            this.CenterImLogo = new PictureBox();
            ((ISupportInitialize) this.PictureBoxDefult).BeginInit();
            ((ISupportInitialize) this.CenterImHedar).BeginInit();
            ((ISupportInitialize) this.CenterImLogo).BeginInit();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x238, 0x2f);
            this.TxTTitle.TabIndex = 0x33;
            this.TxTTitle.Text = "تبديل الفرع / المستودع";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ComboBoxCenters.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxCenters.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxCenters.FormattingEnabled = true;
            this.ComboBoxCenters.Location = new Point(12, 0x4c);
            this.ComboBoxCenters.Name = "ComboBoxCenters";
            this.ComboBoxCenters.Size = new Size(0x220, 0x1b);
            this.ComboBoxCenters.TabIndex = 50;
            this.TxTSortCenterID.BackColor = SystemColors.Info;
            this.TxTSortCenterID.Location = new Point(0x1f2, 0x110);
            this.TxTSortCenterID.Name = "TxTSortCenterID";
            this.TxTSortCenterID.RightToLeft = RightToLeft.No;
            this.TxTSortCenterID.Size = new Size(100, 0x17);
            this.TxTSortCenterID.TabIndex = 0x6d;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(12, 120);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x14b, 0x2c);
            this.ButtonOk.TabIndex = 0x31;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x15d, 120);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xcf, 0x2c);
            this.ButtonClose.TabIndex = 0x30;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.PictureBoxDefult.Image = (Image) manager.GetObject("PictureBoxDefult.Image");
            this.PictureBoxDefult.Location = new Point(0xa6, 0x110);
            this.PictureBoxDefult.Name = "PictureBoxDefult";
            this.PictureBoxDefult.Size = new Size(100, 80);
            this.PictureBoxDefult.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PictureBoxDefult.TabIndex = 0x4a;
            this.PictureBoxDefult.TabStop = false;
            this.CenterImHedar.Location = new Point(0x110, 0x110);
            this.CenterImHedar.Name = "CenterImHedar";
            this.CenterImHedar.Size = new Size(100, 80);
            this.CenterImHedar.TabIndex = 0x49;
            this.CenterImHedar.TabStop = false;
            this.CenterImLogo.Location = new Point(0x17a, 0x110);
            this.CenterImLogo.Name = "CenterImLogo";
            this.CenterImLogo.Size = new Size(100, 80);
            this.CenterImLogo.TabIndex = 0x48;
            this.CenterImLogo.TabStop = false;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x238, 0xab);
            base.ControlBox = false;
            base.Controls.Add(this.TxTSortCenterID);
            base.Controls.Add(this.PictureBoxDefult);
            base.Controls.Add(this.CenterImHedar);
            base.Controls.Add(this.CenterImLogo);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ComboBoxCenters);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.ButtonClose);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "LoginSelectSetting";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تبديل الفرع / المستودع";
            ((ISupportInitialize) this.PictureBoxDefult).EndInit();
            ((ISupportInitialize) this.CenterImHedar).EndInit();
            ((ISupportInitialize) this.CenterImLogo).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                this.A = "SELECT * FROM TaNNCenters";
                this.A.Clear();
                new SqlDataAdapter(this.A, this.A).Fill(this.A, "TaNNCenters");
                this.A.Close();
                this.ComboBoxCenters.ValueMember = "CenterID";
                this.ComboBoxCenters.DisplayMember = "CenterSubName";
                this.ComboBoxCenters.DataSource = this.A.Tables[0];
                this.ComboBoxCenters.SelectedValue = PR.GR;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                Interaction.MsgBox("مشكلة في الأتصال مع قاعدة البيانات ارجو العمل على إعادة التحقق من جملة الاتصال او الخادم", MsgBoxStyle.ApplicationModal, null);
                D.A.A.TimerStart.Enabled = false;
                D.A.A.ToolStripButtonOption.Visible = true;
                D.A.A.ButtonFixCon.Visible = true;
                D.A.A.ProgressBar.Visible = false;
                D.A.A.ProgressBar.Value = 0;
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

        private void P(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            this.TxTSortCenterID.Text = Conversions.ToString(this.ComboBoxCenters.SelectedValue);
            this.R();
        }

        internal virtual PictureBox PictureBoxDefult
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual PictureBox CenterImLogo
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox ComboBoxCenters
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonOk
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

        internal virtual Button ButtonClose
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

        internal virtual TextBox TxTSortCenterID
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }
    }
}

