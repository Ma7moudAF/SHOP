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
    public class MH : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LabelTxT"), CompilerGenerated]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTConnetion")]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label3"), CompilerGenerated]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label P;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose"), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("ButtonAddDefultCon"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("ButtonTest"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerTryCon"), CompilerGenerated]
        private Timer A;
        [CompilerGenerated, AccessedThroughProperty("CheckBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;

        public MH()
        {
            base.Load += new EventHandler(this.A);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(MH));
            this.LabelTxT = new Label();
            this.TxTConnetion = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.CheckBox1 = new CheckBox();
            this.ButtonAddDefultCon = new Button();
            this.ButtonTest = new Button();
            this.Label3 = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.TimerTryCon = new Timer(this.A);
            this.ButtonClose = new Button();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.LabelTxT.BackColor = Color.WhiteSmoke;
            this.LabelTxT.Dock = DockStyle.Bottom;
            this.LabelTxT.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelTxT.Location = new Point(0, 450);
            this.LabelTxT.Name = "LabelTxT";
            this.LabelTxT.Size = new Size(0x2d2, 0x2f);
            this.LabelTxT.TabIndex = 0x1b;
            this.LabelTxT.Text = "في حال الاتصال مع الخادم سيتوقف النظام عن اخذ النسخ الاحتياطية لقاعدة البيانات بشكل تلقائي";
            this.LabelTxT.TextAlign = ContentAlignment.MiddleLeft;
            this.TxTConnetion.Enabled = false;
            this.TxTConnetion.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTConnetion.Location = new Point(8, 0x18);
            this.TxTConnetion.Margin = new Padding(3, 4, 3, 4);
            this.TxTConnetion.Multiline = true;
            this.TxTConnetion.Name = "TxTConnetion";
            this.TxTConnetion.RightToLeft = RightToLeft.No;
            this.TxTConnetion.Size = new Size(0x2ab, 0x54);
            this.TxTConnetion.TabIndex = 5;
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Controls.Add(this.TxTConnetion);
            this.GroupBox1.Controls.Add(this.ButtonAddDefultCon);
            this.GroupBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox1.Location = new Point(12, 0xa6);
            this.GroupBox1.Margin = new Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new Size(700, 0xd0);
            this.GroupBox1.TabIndex = 0x1f;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "جملة الاتصال";
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = CheckState.Checked;
            this.CheckBox1.Enabled = false;
            this.CheckBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CheckBox1.Location = new Point(0x22b, 180);
            this.CheckBox1.Margin = new Padding(3, 4, 3, 4);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new Size(0x88, 20);
            this.CheckBox1.TabIndex = 0x20;
            this.CheckBox1.Text = "تشفير جملة الاتصال";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.ButtonAddDefultCon.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAddDefultCon.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAddDefultCon.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAddDefultCon.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAddDefultCon.FlatStyle = FlatStyle.Flat;
            this.ButtonAddDefultCon.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAddDefultCon.Image = (Image) manager.GetObject("ButtonAddDefultCon.Image");
            this.ButtonAddDefultCon.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAddDefultCon.Location = new Point(8, 0x74);
            this.ButtonAddDefultCon.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAddDefultCon.Name = "ButtonAddDefultCon";
            this.ButtonAddDefultCon.Size = new Size(0x2ab, 0x37);
            this.ButtonAddDefultCon.TabIndex = 0x18;
            this.ButtonAddDefultCon.Text = "بناء جملة الاتصال";
            this.ButtonAddDefultCon.UseVisualStyleBackColor = true;
            this.ButtonTest.Enabled = false;
            this.ButtonTest.FlatAppearance.BorderColor = Color.Green;
            this.ButtonTest.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonTest.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonTest.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonTest.FlatStyle = FlatStyle.Flat;
            this.ButtonTest.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonTest.Image = F.ImDataOk;
            this.ButtonTest.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonTest.Location = new Point(12, 0x17e);
            this.ButtonTest.Margin = new Padding(3, 4, 3, 4);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new Size(0x20b, 0x37);
            this.ButtonTest.TabIndex = 0x17;
            this.ButtonTest.Text = "موافق";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.Label3.Dock = DockStyle.Top;
            this.Label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label3.Location = new Point(0, 110);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x2d2, 0x34);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "اذا كان لديك خادم/ سيرفر لاستضافة قواعد البيانات من نوع SQL Server يمكنك رفع قاعدة بيانات النظام عليه وربطها من خلال جملة الاتصال";
            this.Label3.TextAlign = ContentAlignment.MiddleCenter;
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0, 0x3a);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x2d2, 0x34);
            this.Label2.TabIndex = 0x1d;
            this.Label2.Text = "يمكنك الاتصال مع قاعدة بيانات اخرى لتعمل كشبكة او اكثر من نقطة بيع (محلية او على نطاق بعيد)، ادخل جملة الاتصال مع قاعدة البيانات التي قمت بتجهيزها على الخادم المحلي او العالمي ";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.DarkGreen;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x2d2, 0x3a);
            this.Label1.TabIndex = 0x1c;
            this.Label1.Text = "معالج الاتصال مع قاعدة البيانات";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.TimerTryCon.Interval = 500;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImFinish;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(550, 0x17e);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xa2, 0x37);
            this.ButtonClose.TabIndex = 0x1a;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2d2, 0x1f1);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonTest);
            base.Controls.Add(this.LabelTxT);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.ButtonClose);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "StartPointCon";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "معالج الاتصال مع قاعدة البيانات";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            this.TxTConnetion.Text = H.Settings.DBConnectionString.ToString();
            if (!PR.LR)
            {
                this.TxTConnetion.Enabled = false;
                this.TxTConnetion.Multiline = false;
                this.TxTConnetion.UseSystemPasswordChar = true;
            }
            else
            {
                this.TxTConnetion.Enabled = true;
                this.TxTConnetion.Multiline = true;
                this.TxTConnetion.UseSystemPasswordChar = false;
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

        private void I(object A, EventArgs R)
        {
            Application.DoEvents();
            this.TimerTryCon.Enabled = false;
            try
            {
                SqlConnection connection = new SqlConnection(this.TxTConnetion.Text.Trim());
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                connection.Close();
                Interaction.MsgBox("اتصال ناجح، سيتم حفظ بيانات الاتصال يجب عليك إعادة تشغيل النظام", MsgBoxStyle.ApplicationModal, null);
                this.R();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.ButtonTest.Text = "موافق";
                D.A.A.TextBoxError.Text = exception.ToString();
                D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        private void P(object A, EventArgs R)
        {
            Application.DoEvents();
            this.ButtonTest.Text = PR.A.ToString();
            this.TimerTryCon.Enabled = true;
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void R()
        {
            Application.DoEvents();
            try
            {
                D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SettingApp\SetDBCon.txt", Z.A(this.TxTConnetion.Text.Trim(), "1200"), false);
                D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SettingApp\SetDBServ.txt", AR.P, false);
                D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SettingApp\SetDBSoc.txt", AR.Q, false);
                D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SettingApp\SetDBNam.txt", AR.I, false);
                D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SettingApp\SetDBLog.txt", AR.D, false);
                if (AR.F != null)
                {
                    D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SettingApp\SetDBPas.txt", Z.A(AR.F, "1200"), false);
                }
                else
                {
                    D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SettingApp\SetDBPas.txt", "", false);
                }
                Interaction.MsgBox("لتأكيد الاتصال يجب اعادة تشغيل النظام", MsgBoxStyle.ApplicationModal, null);
                D.A.A.Show();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, EventArgs R)
        {
            D.A.A.ShowDialog();
        }

        internal virtual Label LabelTxT
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTConnetion
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual Button ButtonAddDefultCon
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual Button ButtonTest
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual Timer TimerTryCon
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                Timer a = this.A;
                if (a != null)
                {
                    a.Tick -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Tick += handler;
                }
            }
        }

        internal virtual CheckBox CheckBox1
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

