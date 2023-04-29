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
    public class AT : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [CompilerGenerated, AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("ButtonGoSQL"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("ButtonRunSQL"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [CompilerGenerated, AccessedThroughProperty("ButtonV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label5")]
        private Label Q;
        [CompilerGenerated, AccessedThroughProperty("ButtonNew"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage3")]
        private TabPage R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button2")]
        private Button I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button1")]
        private Button D;
        [AccessedThroughProperty("Label6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [CompilerGenerated, AccessedThroughProperty("Button3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button F;

        public AT()
        {
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(AT));
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.ButtonRunSQL = new Button();
            this.ButtonGoSQL = new Button();
            this.Label1 = new Label();
            this.GroupBox2 = new GroupBox();
            this.ButtonV = new Button();
            this.Label5 = new Label();
            this.GroupBox1 = new GroupBox();
            this.ButtonNew = new Button();
            this.Label2 = new Label();
            this.TabPage3 = new TabPage();
            this.Button2 = new Button();
            this.Button1 = new Button();
            this.Label6 = new Label();
            this.TxTTitle = new Label();
            this.Button3 = new Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            base.SuspendLayout();
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 10);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x34a, 0x1a5);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 1;
            this.TabPage1.Controls.Add(this.ButtonRunSQL);
            this.TabPage1.Controls.Add(this.ButtonGoSQL);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Location = new Point(4, 0x27);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x342, 0x17a);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الربط ضمن شبكة محلية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtonRunSQL.FlatStyle = FlatStyle.Flat;
            this.ButtonRunSQL.ForeColor = Color.Green;
            this.ButtonRunSQL.Location = new Point(6, 0xde);
            this.ButtonRunSQL.Name = "ButtonRunSQL";
            this.ButtonRunSQL.Size = new Size(0x332, 0x57);
            this.ButtonRunSQL.TabIndex = 5;
            this.ButtonRunSQL.Text = "شرح طريقة ربط النظام بأكثر من نقطة بيع ضمن الشبكة المحلية - فيديو";
            this.ButtonRunSQL.UseVisualStyleBackColor = true;
            this.ButtonGoSQL.FlatStyle = FlatStyle.Flat;
            this.ButtonGoSQL.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.ButtonGoSQL.Location = new Point(6, 0x8e);
            this.ButtonGoSQL.Name = "ButtonGoSQL";
            this.ButtonGoSQL.Size = new Size(0x332, 0x4a);
            this.ButtonGoSQL.TabIndex = 1;
            this.ButtonGoSQL.Text = "رابط تحميل وتنصيب Sql Server Management Studio 2014 ";
            this.ButtonGoSQL.UseVisualStyleBackColor = true;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Location = new Point(3, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x33c, 0x88);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "اذا كنت تريد تشغيل النظام على اكثر من نقطة بيع/ جهاز، ضمن شبكة محلية يمكنك استخدام (Sql Server Management Studio 2014) بهدف ارفاق قاعدة البيانات من خلاله والحصول على جملة الاتصال وربط الأجهزة.";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox2.Controls.Add(this.ButtonV);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Location = new Point(12, 0x1f6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x179, 0xa6);
            this.GroupBox2.TabIndex = 4;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "إدارة الاشتراك الحالي";
            this.ButtonV.Location = new Point(6, 0x75);
            this.ButtonV.Name = "ButtonV";
            this.ButtonV.Size = new Size(0x16d, 0x23);
            this.ButtonV.TabIndex = 2;
            this.ButtonV.Text = "عرض معلومات الترخيص";
            this.ButtonV.UseVisualStyleBackColor = true;
            this.Label5.Dock = DockStyle.Top;
            this.Label5.Location = new Point(3, 0x13);
            this.Label5.Name = "Label5";
            this.Label5.Size = new Size(0x173, 0x51);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "اذا كان لديك اشتراك حالي يمكنك استخراج معلومات الاتصال مع قاعدة البيانات او إدارة قاعدة البيانات";
            this.Label5.TextAlign = ContentAlignment.MiddleLeft;
            this.GroupBox1.Controls.Add(this.ButtonNew);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new Point(0x197, 0x1f6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x1a1, 0xa6);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "اشتراك جديد";
            this.ButtonNew.Enabled = false;
            this.ButtonNew.Location = new Point(6, 0x75);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new Size(0x195, 0x23);
            this.ButtonNew.TabIndex = 1;
            this.ButtonNew.Text = "انشاء اشتراك جديد";
            this.ButtonNew.UseVisualStyleBackColor = true;
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Location = new Point(3, 0x13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x19b, 0x5e);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "1- دفع قيمة الاشتراك\r\n2- تحديد الرقم المتسلسل الخاص بالمتجر لانشاء الاشتراك\r\n3- انشاء قاعدة البيانات او رفع قاعدة البيانات الحالية\r\n4- الحصول على معلومات الربط وبناء جملة الاتصال مع قاعدة البيانات";
            this.Label2.TextAlign = ContentAlignment.MiddleLeft;
            this.TabPage3.Controls.Add(this.Button3);
            this.TabPage3.Controls.Add(this.Button2);
            this.TabPage3.Controls.Add(this.Button1);
            this.TabPage3.Controls.Add(this.Label6);
            this.TabPage3.Location = new Point(4, 0x27);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new Padding(3);
            this.TabPage3.Size = new Size(0x342, 0x17a);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "ربط نسخة الويب | الجوال";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.Button2.Location = new Point(0xeb, 0xe3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new Size(0x16d, 0x23);
            this.Button2.TabIndex = 4;
            this.Button2.Text = "الدخول الى نسخة الويب";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button1.Location = new Point(0xeb, 0xac);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x16d, 0x23);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "ضبط جملة الاتصال لنسخة الويب";
            this.Button1.UseVisualStyleBackColor = true;
            this.Label6.Dock = DockStyle.Top;
            this.Label6.Location = new Point(3, 3);
            this.Label6.Name = "Label6";
            this.Label6.Size = new Size(0x33c, 0x88);
            this.Label6.TabIndex = 1;
            this.Label6.Text = manager.GetString("Label6.Text");
            this.Label6.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x34a, 0x22);
            this.TxTTitle.TabIndex = 100;
            this.TxTTitle.Text = "حدد طريقة الربط";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Button3.Location = new Point(0xeb, 0x119);
            this.Button3.Name = "Button3";
            this.Button3.Size = new Size(0x16d, 0x23);
            this.Button3.TabIndex = 5;
            this.Button3.Text = "تفاصيل اكثر";
            this.Button3.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x34a, 470);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "StartPointRunSQL";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "شرح الربط بين الأجهزة";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            Process.Start("https://yazsys.com/RFSSMS.aspx");
        }

        private void D(object A, EventArgs R)
        {
            Process.Start("https://yazsys.com/POS/");
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
            if (PR.Q)
            {
                Interaction.MsgBox("اتصل في المندوب\r\n" + PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/SPDetails.aspx?ID=39");
            }
        }

        private void I(object A, EventArgs R)
        {
            if (PR.Z == null)
            {
                Interaction.MsgBox("يجب ان يكون لديك رقم متسلسل. وان تكون هذه النسخة مرخصة", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/POS/DBSetOut.aspx?DBSerialNumber=" + PR.Z.ToString());
            }
        }

        private void P(object A, EventArgs R)
        {
            if (PR.Z == null)
            {
                Interaction.MsgBox("يجب ان يكون لديك رقم متسلسل. وان تكون هذه النسخة مرخصة", MsgBoxStyle.ApplicationModal, null);
            }
            else if (PR.Q)
            {
                Interaction.MsgBox("اتصل في المندوب\r\n" + PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/NNSSActiveQLinSer.aspx?DBSerialNumber=" + PR.Z.ToString());
            }
        }

        private void Q(object A, EventArgs R)
        {
            if (PR.Q)
            {
                Interaction.MsgBox("اتصل في المندوب\r\n" + PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/GetDBAr.aspx");
            }
        }

        private void R(object A, EventArgs R)
        {
            Process.Start("https://yazsys.com/SPDetails.aspx?ID=15");
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonGoSQL
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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

        internal virtual Button ButtonRunSQL
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

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonV
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

        internal virtual Label Label5
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonNew
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button Button2
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

        internal virtual Button Button1
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

        internal virtual Label Label6
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Button Button3
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
    }
}

