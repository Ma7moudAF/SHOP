namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class JH : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTResutl")]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("txtCommand"), CompilerGenerated]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerRestSQLLOCALDB")]
        private Timer A;
        [AccessedThroughProperty("TimerSetOFFLINE"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [AccessedThroughProperty("TimerSetOnline"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer P;
        [AccessedThroughProperty("TimerSetUserSingle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerUserMulti")]
        private Timer I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose")]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("TimerTstSQL"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerTstDB"), CompilerGenerated]
        private Timer F;
        [AccessedThroughProperty("TimerClerCash"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1"), CompilerGenerated]
        private TabControl A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage2")]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage3")]
        private TabPage R;
        [AccessedThroughProperty("ButtonFixDN"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("ButtonDowCry"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [CompilerGenerated, AccessedThroughProperty("ButtonTestCry"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerShrink")]
        private Timer T;
        [AccessedThroughProperty("TabPage4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonDQR")]
        private Button I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonD39"), CompilerGenerated]
        private Button D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage1"), CompilerGenerated]
        private TabPage Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button1")]
        private Button F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label2"), CompilerGenerated]
        private Label P;

        public JH()
        {
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.TxTTitle = new Label();
            this.Label1 = new Label();
            this.TxTResutl = new TextBox();
            this.txtCommand = new TextBox();
            this.TimerRestSQLLOCALDB = new Timer(this.A);
            this.TimerSetOFFLINE = new Timer(this.A);
            this.TimerSetOnline = new Timer(this.A);
            this.TimerSetUserSingle = new Timer(this.A);
            this.TimerUserMulti = new Timer(this.A);
            this.ButtonClose = new Button();
            this.TimerTstSQL = new Timer(this.A);
            this.TimerTstDB = new Timer(this.A);
            this.TimerClerCash = new Timer(this.A);
            this.TabControl1 = new TabControl();
            this.TabPage2 = new TabPage();
            this.ButtonFixDN = new Button();
            this.TabPage3 = new TabPage();
            this.ButtonDowCry = new Button();
            this.ButtonTestCry = new Button();
            this.TabPage4 = new TabPage();
            this.ButtonDQR = new Button();
            this.ButtonD39 = new Button();
            this.TabPage1 = new TabPage();
            this.Button1 = new Button();
            this.Label2 = new Label();
            this.TimerShrink = new Timer(this.A);
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage1.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x380, 0x35);
            this.TxTTitle.TabIndex = 100;
            this.TxTTitle.Text = "ادوات الصيانة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Label1.Dock = DockStyle.Bottom;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Red;
            this.Label1.Location = new Point(0, 530);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x380, 0x34);
            this.Label1.TabIndex = 0x65;
            this.Label1.Text = "تحذير: يجب استخدام الادوات اعلاه بحذر ، مع العلم ان الأدوات التالية تستخدم فقط مع قاعدة البيانات المحلية الافتراضية فقط وليس مع قواعد البيانات الموجودة على خادم";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTResutl.BackColor = Color.Black;
            this.TxTResutl.ForeColor = Color.Lime;
            this.TxTResutl.Location = new Point(0x28c, 0x2c3);
            this.TxTResutl.Multiline = true;
            this.TxTResutl.Name = "TxTResutl";
            this.TxTResutl.ScrollBars = ScrollBars.Vertical;
            this.TxTResutl.Size = new Size(0xf4, 0x76);
            this.TxTResutl.TabIndex = 0x66;
            this.txtCommand.BackColor = SystemColors.Info;
            this.txtCommand.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCommand.Location = new Point(0x1c4, 0x2c3);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.RightToLeft = RightToLeft.No;
            this.txtCommand.Size = new Size(0xc2, 0x43);
            this.txtCommand.TabIndex = 0x67;
            this.txtCommand.Text = "sqllocaldb stop MSSQLLocalDB\r\nsqllocaldb delete MSSQLLocalDB\r\nsqllocaldb create MSSQLLocalDB\r\nsqllocaldb start MSSQLLocalDB";
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.Location = new Point(0, 0x1d8);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x380, 0x3a);
            this.ButtonClose.TabIndex = 0x72;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x35);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 10);
            this.TabControl1.RightToLeft = RightToLeft.Yes;
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x380, 0x196);
            this.TabControl1.TabIndex = 0x74;
            this.TabPage2.Controls.Add(this.ButtonFixDN);
            this.TabPage2.Location = new Point(4, 0x27);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x378, 0x16b);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "الويندوز";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonFixDN.Location = new Point(0x10b, 0x86);
            this.ButtonFixDN.Name = "ButtonFixDN";
            this.ButtonFixDN.Size = new Size(0x19b, 0x3a);
            this.ButtonFixDN.TabIndex = 0x74;
            this.ButtonFixDN.Text = "ضبط التاريخ وتنسيق الارقام";
            this.ButtonFixDN.UseVisualStyleBackColor = true;
            this.TabPage3.Controls.Add(this.ButtonDowCry);
            this.TabPage3.Controls.Add(this.ButtonTestCry);
            this.TabPage3.Location = new Point(4, 0x27);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x378, 0x16b);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "الطباعة";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.ButtonDowCry.Location = new Point(0xe9, 150);
            this.ButtonDowCry.Name = "ButtonDowCry";
            this.ButtonDowCry.Size = new Size(0x19b, 0x3a);
            this.ButtonDowCry.TabIndex = 0x77;
            this.ButtonDowCry.Text = "تحميل حزمة دعم الطباعة كريستال ريبورت";
            this.ButtonDowCry.UseVisualStyleBackColor = true;
            this.ButtonTestCry.Location = new Point(0xe9, 0x43);
            this.ButtonTestCry.Name = "ButtonTestCry";
            this.ButtonTestCry.Size = new Size(0x19b, 0x3a);
            this.ButtonTestCry.TabIndex = 0x76;
            this.ButtonTestCry.Text = "فحص حزمة دعم الطباعة كريستال ريبورت";
            this.ButtonTestCry.UseVisualStyleBackColor = true;
            this.TabPage4.Controls.Add(this.ButtonDQR);
            this.TabPage4.Controls.Add(this.ButtonD39);
            this.TabPage4.Location = new Point(4, 0x27);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x378, 0x16b);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "روابط تحميل الملحقات";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.ButtonDQR.Location = new Point(0x1c, 0x5f);
            this.ButtonDQR.Name = "ButtonDQR";
            this.ButtonDQR.Size = new Size(0x345, 0x2c);
            this.ButtonDQR.TabIndex = 1;
            this.ButtonDQR.Text = "تحميل ملف صانع رمز الاستجابة السريع QR";
            this.ButtonDQR.UseVisualStyleBackColor = true;
            this.ButtonD39.Location = new Point(0x1c, 0x2d);
            this.ButtonD39.Name = "ButtonD39";
            this.ButtonD39.Size = new Size(0x345, 0x2c);
            this.ButtonD39.TabIndex = 0;
            this.ButtonD39.Text = "تحميل ملف دعم خطوط الباركود Font39";
            this.ButtonD39.UseVisualStyleBackColor = true;
            this.TabPage1.Controls.Add(this.Button1);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Location = new Point(4, 0x27);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x378, 0x16b);
            this.TabPage1.TabIndex = 4;
            this.TabPage1.Text = "فحص الوصول الى الخادم";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.Button1.Location = new Point(0x141, 0x88);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x102, 0x33);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "فحص الاتصال";
            this.Button1.UseVisualStyleBackColor = true;
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(3, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x372, 0x37);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "قد يكون لديك تقييد على خدمات الموقع بسبب اعدادات الويندوز لديك، يعتمد هذا النظام على متصفح internet explorer في معالجة بعض الاوامر مع الخادم، في حال عدم الوصول يجب عليك ضبط اعدادات الويندوز.";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x380, 0x246);
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTResutl);
            base.Controls.Add(this.txtCommand);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "StartPointFixNew";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ادوات الاصلاح";
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void D(object A, EventArgs R)
        {
            base.Dispose();
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
            A.D.A.A.ShowDialog();
        }

        private void I(object A, EventArgs R)
        {
            Process.Start("https://yazsys.com/RFFontBarCode.aspx");
        }

        private void P(object A, EventArgs R)
        {
            Interaction.MsgBox("يجب عليك اغلاق النظام بعد تحميل وتثبيت الحزمة", MsgBoxStyle.ApplicationModal, null);
            Process.Start("https://yazsys.com/RFCrystalReportDefult.aspx");
        }

        private void Q(object A, EventArgs R)
        {
            Process.Start("https://yazsys.com/RFQRBarCode.aspx");
        }

        private void R(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                KP kp = new KP();
                new HR { CRViewer = { ReportSource = kp } }.ShowDialog();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                Interaction.MsgBox("حزمة كريستال ريبورت لدعم طباعة التقارير مفقودة", MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTResutl
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox txtCommand
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Timer TimerRestSQLLOCALDB
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Timer TimerSetOFFLINE
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Timer TimerSetOnline
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Timer TimerSetUserSingle
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Timer TimerUserMulti
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual Timer TimerTstSQL
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Timer TimerTstDB
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Timer TimerClerCash
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonFixDN
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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

        internal virtual Button ButtonDowCry
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

        internal virtual Button ButtonTestCry
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual Timer TimerShrink
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonDQR
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual Button ButtonD39
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button Button1
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual Label Label2
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

