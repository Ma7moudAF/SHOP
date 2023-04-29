namespace A
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class B : Form
    {
        private IContainer A;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("TimerStart"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("TimerClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("WebBrowserCheckDomin")]
        private WebBrowser A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("WebBrowserCheckUpdate")]
        private WebBrowser R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("WebBrowserCheckIsOk")]
        private WebBrowser P;
        [CompilerGenerated, AccessedThroughProperty("WebBrowserCeckCloud"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private WebBrowser Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerSteps")]
        private Timer P;
        private SqlConnection A;
        private int A;

        public B()
        {
            base.Load += new EventHandler(this.R);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = 0;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.Label1 = new Label();
            this.ButtonClose = new Button();
            this.TimerStart = new Timer(this.A);
            this.TimerClose = new Timer(this.A);
            this.WebBrowserCheckDomin = new WebBrowser();
            this.WebBrowserCheckUpdate = new WebBrowser();
            this.WebBrowserCheckIsOk = new WebBrowser();
            this.WebBrowserCeckCloud = new WebBrowser();
            this.TimerSteps = new Timer(this.A);
            base.SuspendLayout();
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x2a7, 0x103);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "انتظر... فحص التحديثات";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.Enabled = false;
            this.ButtonClose.Location = new Point(0, 0x107);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x2a7, 0x2e);
            this.ButtonClose.TabIndex = 2;
            this.ButtonClose.Text = "انتظر ...";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.TimerClose.Enabled = true;
            this.TimerClose.Interval = 0x7530;
            this.WebBrowserCheckDomin.Location = new Point(0x1fd, 0x18a);
            this.WebBrowserCheckDomin.MinimumSize = new Size(20, 20);
            this.WebBrowserCheckDomin.Name = "WebBrowserCheckDomin";
            this.WebBrowserCheckDomin.ScriptErrorsSuppressed = true;
            this.WebBrowserCheckDomin.Size = new Size(0x94, 0x67);
            this.WebBrowserCheckDomin.TabIndex = 3;
            this.WebBrowserCheckUpdate.Location = new Point(0x151, 0x18a);
            this.WebBrowserCheckUpdate.MinimumSize = new Size(20, 20);
            this.WebBrowserCheckUpdate.Name = "WebBrowserCheckUpdate";
            this.WebBrowserCheckUpdate.ScriptErrorsSuppressed = true;
            this.WebBrowserCheckUpdate.Size = new Size(0x94, 0x67);
            this.WebBrowserCheckUpdate.TabIndex = 4;
            this.WebBrowserCheckIsOk.Location = new Point(0x9e, 0x18a);
            this.WebBrowserCheckIsOk.MinimumSize = new Size(20, 20);
            this.WebBrowserCheckIsOk.Name = "WebBrowserCheckIsOk";
            this.WebBrowserCheckIsOk.ScriptErrorsSuppressed = true;
            this.WebBrowserCheckIsOk.Size = new Size(0x94, 0x67);
            this.WebBrowserCheckIsOk.TabIndex = 5;
            this.WebBrowserCeckCloud.Location = new Point(0, 0x18a);
            this.WebBrowserCeckCloud.MinimumSize = new Size(20, 20);
            this.WebBrowserCeckCloud.Name = "WebBrowserCeckCloud";
            this.WebBrowserCeckCloud.ScriptErrorsSuppressed = true;
            this.WebBrowserCeckCloud.Size = new Size(0x94, 0x67);
            this.WebBrowserCeckCloud.TabIndex = 6;
            this.TimerSteps.Enabled = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2a7, 0x135);
            base.ControlBox = false;
            base.Controls.Add(this.WebBrowserCeckCloud);
            base.Controls.Add(this.WebBrowserCheckIsOk);
            base.Controls.Add(this.WebBrowserCheckUpdate);
            base.Controls.Add(this.WebBrowserCheckDomin);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.Name = "CheckInternet";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            base.TopMost = true;
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void A(object A, WebBrowserDocumentCompletedEventArgs R)
        {
            // Invalid method body.
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
            if (this.A == 3)
            {
                base.Dispose();
            }
        }

        private void P(object A, EventArgs R)
        {
            this.ButtonClose.Text = "الغاء";
            this.ButtonClose.Enabled = true;
        }

        private void P(object A, WebBrowserDocumentCompletedEventArgs R)
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerStart.Enabled = false;
            this.R();
        }

        private void Q(object A, WebBrowserDocumentCompletedEventArgs R)
        {
            // Invalid method body.
        }

        public void R()
        {
            this.WebBrowserCheckDomin.Navigate("https://yazsys.com/Test.aspx");
        }

        private void R(object A, EventArgs R)
        {
            this.TimerStart.Enabled = true;
        }

        private void R(object A, WebBrowserDocumentCompletedEventArgs R)
        {
            // Invalid method body.
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

        internal virtual Button ButtonClose
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

        internal virtual Timer TimerStart
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual Timer TimerClose
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                Timer r = this.R;
                if (r != null)
                {
                    r.Tick -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.Tick += handler;
                }
            }
        }

        internal virtual WebBrowser WebBrowserCheckDomin
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

        internal virtual WebBrowser WebBrowserCheckUpdate
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                WebBrowserDocumentCompletedEventHandler handler = new WebBrowserDocumentCompletedEventHandler(this.R);
                WebBrowser r = this.R;
                if (r != null)
                {
                    r.DocumentCompleted -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.DocumentCompleted += handler;
                }
            }
        }

        internal virtual WebBrowser WebBrowserCheckIsOk
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                WebBrowserDocumentCompletedEventHandler handler = new WebBrowserDocumentCompletedEventHandler(this.P);
                WebBrowser p = this.P;
                if (p != null)
                {
                    p.DocumentCompleted -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.DocumentCompleted += handler;
                }
            }
        }

        internal virtual WebBrowser WebBrowserCeckCloud
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                WebBrowserDocumentCompletedEventHandler handler = new WebBrowserDocumentCompletedEventHandler(this.Q);
                WebBrowser q = this.Q;
                if (q != null)
                {
                    q.DocumentCompleted -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.DocumentCompleted += handler;
                }
            }
        }

        internal virtual Timer TimerSteps
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                Timer p = this.P;
                if (p != null)
                {
                    p.Tick -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.Tick += handler;
                }
            }
        }
    }
}

