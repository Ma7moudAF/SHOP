namespace A
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class PD : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Timer1Send"), CompilerGenerated]
        private Timer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label A;
        [AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Timer1Close")]
        private Timer R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Panel1"), CompilerGenerated]
        private Panel A;

        public PD()
        {
            base.Load += new EventHandler(this.A);
            base.Closed += new EventHandler(this.R);
            base.Disposed += new EventHandler(this.P);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.Timer1Send = new Timer(this.A);
            this.Label1 = new Label();
            this.ButtonClose = new Button();
            this.Timer1Close = new Timer(this.A);
            this.Panel1 = new Panel();
            this.Panel1.SuspendLayout();
            base.SuspendLayout();
            this.Timer1Send.Interval = 500;
            this.Label1.Dock = DockStyle.Right;
            this.Label1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0x174, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x210, 0x7a);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "يتم الان ارسال البريد الالكتروني ... انتظر";
            this.Label1.TextAlign = ContentAlignment.MiddleRight;
            this.ButtonClose.Dock = DockStyle.Left;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Popup;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImCloseOrang;
            this.ButtonClose.Location = new Point(5, 5);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x8f, 0x7a);
            this.ButtonClose.TabIndex = 0x5c;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.Timer1Close.Interval = 0x3e8;
            this.Panel1.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.Panel1.BorderStyle = BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.ButtonClose);
            this.Panel1.Dock = DockStyle.Fill;
            this.Panel1.Location = new Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Padding = new Padding(5);
            this.Panel1.Size = new Size(0x38d, 0x88);
            this.Panel1.TabIndex = 0x5e;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            base.ClientSize = new Size(0x38d, 0x88);
            base.Controls.Add(this.Panel1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FormEmailSend";
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.Manual;
            this.Text = "Sending Email ...";
            base.TopMost = true;
            this.Panel1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            base.Width = Screen.PrimaryScreen.Bounds.Width;
            Screen screen = Screen.FromPoint(base.Location);
            base.Location = new Point(screen.WorkingArea.Right - base.Width, screen.WorkingArea.Top);
            this.Timer1Send.Enabled = true;
        }

        private void A(object A, PaintEventArgs R)
        {
        }

        private void D(object A, EventArgs R)
        {
            PR.HR = null;
            PR.TR = null;
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

        private void I(object A, EventArgs R)
        {
            PR.HR = null;
            PR.TR = null;
            base.Dispose();
        }

        private void P(object A, EventArgs R)
        {
            PR.HR = null;
            PR.TR = null;
        }

        private void Q(object A, EventArgs R)
        {
            this.Timer1Send.Enabled = false;
            this.R();
        }

        public void R()
        {
            try
            {
                if (PR.HR == null)
                {
                    base.Dispose();
                }
                else
                {
                    string str = PR.ER.ToString() + " " + PR.TR.ToString();
                    string str2 = PR.XR.ToString();
                    byte[] bytes = Convert.FromBase64String(PR.K.ToString());
                    Process.Start(Encoding.UTF8.GetString(bytes).Replace("XXEEXX", PR.HR.ToString()).Replace("XXSSXX", str.ToString()).Replace("XXBBXX", str2.ToString()).ToString());
                    this.Label1.Text = "تم الارسال";
                    this.Label1.ForeColor = Color.Blue;
                    PR.HR = null;
                    PR.TR = null;
                    this.Timer1Close.Enabled = true;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                AR.DR = false;
                AR.IR = false;
                this.Label1.Text = "فشل ارسال البريد الالكتروني";
                this.Label1.ForeColor = Color.Red;
                base.Dispose();
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, EventArgs R)
        {
            PR.HR = null;
            PR.TR = null;
            base.Dispose();
        }

        internal virtual Timer Timer1Send
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
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Timer Timer1Close
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual Panel Panel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                PaintEventHandler handler = new PaintEventHandler(this.A);
                Panel a = this.A;
                if (a != null)
                {
                    a.Paint -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Paint += handler;
                }
            }
        }
    }
}

