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
    public class ID : Form
    {
        private IContainer A;
        [AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2")]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button2")]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Button1")]
        private Button P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TextBox1")]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("WebBrowser1")]
        private WebBrowser A;

        public ID()
        {
            base.Load += new EventHandler(this.A);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label2 = new Label();
            this.ButtonClose = new Button();
            this.Label1 = new Label();
            this.GroupBox2 = new GroupBox();
            this.Button2 = new Button();
            this.Button1 = new Button();
            this.TextBox1 = new TextBox();
            this.WebBrowser1 = new WebBrowser();
            this.GroupBox2.SuspendLayout();
            base.SuspendLayout();
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = Color.Red;
            this.Label2.Location = new Point(0, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x399, 0x2e);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "اتصال مع الخادم";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.Location = new Point(0, 0x2b7);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x399, 0x3a);
            this.ButtonClose.TabIndex = 0x73;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0, 0x2e);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x399, 0x37);
            this.Label1.TabIndex = 0x74;
            this.Label1.Text = "قد يكون لديك تقييد على خدمات الموقع بسبب اعدادات الويندوز لديك، يعتمد هذا النظام على متصفح internet explorer في معالجة بعض الاوامر مع الخادم، في حال عدم الوصول يجب عليك ضبط اعدادات الويندوز.";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox2.Controls.Add(this.Button2);
            this.GroupBox2.Controls.Add(this.Button1);
            this.GroupBox2.Controls.Add(this.TextBox1);
            this.GroupBox2.Dock = DockStyle.Top;
            this.GroupBox2.Location = new Point(0, 0x65);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x399, 70);
            this.GroupBox2.TabIndex = 0x75;
            this.GroupBox2.TabStop = false;
            this.Button2.Location = new Point(0x27e, 13);
            this.Button2.Name = "Button2";
            this.Button2.Size = new Size(0x114, 0x33);
            this.Button2.TabIndex = 12;
            this.Button2.Text = "مساعدة ضبط الاعدادت";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button1.Location = new Point(0x193, 13);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0xe5, 0x33);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "فحص الاتصال";
            this.Button1.UseVisualStyleBackColor = true;
            this.TextBox1.BackColor = SystemColors.Info;
            this.TextBox1.Location = new Point(9, 0x1c);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.RightToLeft = RightToLeft.No;
            this.TextBox1.Size = new Size(0x184, 0x16);
            this.TextBox1.TabIndex = 10;
            this.TextBox1.Text = "https://yazsys.com/Test.aspx";
            this.WebBrowser1.Dock = DockStyle.Fill;
            this.WebBrowser1.Location = new Point(0, 0xab);
            this.WebBrowser1.MinimumSize = new Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.ScriptErrorsSuppressed = true;
            this.WebBrowser1.Size = new Size(0x399, 0x20c);
            this.WebBrowser1.TabIndex = 0x76;
            base.AutoScaleDimensions = new SizeF(7f, 14f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x399, 0x2f1);
            base.ControlBox = false;
            base.Controls.Add(this.WebBrowser1);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.Label2);
            this.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FormWebCheck";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "فحص الاتصال مع الخادم";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
        }

        private void A(object A, WebBrowserDocumentCompletedEventArgs R)
        {
            if (this.WebBrowser1.DocumentTitle == "OK")
            {
                PR.P = true;
                Interaction.MsgBox("اتصال ناجح مع الخادم", MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
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
            Process.Start("https://youtu.be/9y2S0vRY4BQ");
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void R(object A, EventArgs R)
        {
            this.WebBrowser1.Navigate(this.TextBox1.Text);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button Button2
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

        internal virtual Button Button1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual TextBox TextBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual WebBrowser WebBrowser1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                WebBrowserDocumentCompletedEventHandler handler = new WebBrowserDocumentCompletedEventHandler(this.A);
                WebBrowser a = this.A;
                if (a != null)
                {
                    a.DocumentCompleted -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.DocumentCompleted += handler;
                }
            }
        }
    }
}

