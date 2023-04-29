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
    public class DR : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonD")]
        private Button R;
        [AccessedThroughProperty("GroupBox1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("TxTErorr"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [CompilerGenerated, AccessedThroughProperty("ButtonCheck"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;

        public DR()
        {
            base.Load += new EventHandler(this.Q);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label1 = new Label();
            this.ButtonD = new Button();
            this.GroupBox1 = new GroupBox();
            this.TxTErorr = new TextBox();
            this.ButtonFinish = new Button();
            this.ButtonCheck = new Button();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.Label1.Dock = DockStyle.Top;
            this.Label1.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x29a, 0x29);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "لقد حدث خطأ في عملية الطباعة، قد يكون السبب في حزمة (Crystal Report) التي تدعم الطباعة، او خلل في الطابعة.";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonD.FlatStyle = FlatStyle.Flat;
            this.ButtonD.ForeColor = Color.Blue;
            this.ButtonD.Image = F.ImWarining;
            this.ButtonD.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonD.Location = new Point(12, 0x2c);
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Size = new Size(0x135, 0x29);
            this.ButtonD.TabIndex = 0x5b;
            this.ButtonD.Text = "تحميل حزمة Crystal Report";
            this.ButtonD.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.TxTErorr);
            this.GroupBox1.Dock = DockStyle.Bottom;
            this.GroupBox1.Location = new Point(0, 140);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x29a, 0x130);
            this.GroupBox1.TabIndex = 0x5c;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "رسالة الخطأ";
            this.TxTErorr.Dock = DockStyle.Fill;
            this.TxTErorr.Location = new Point(3, 0x13);
            this.TxTErorr.Multiline = true;
            this.TxTErorr.Name = "TxTErorr";
            this.TxTErorr.RightToLeft = RightToLeft.No;
            this.TxTErorr.Size = new Size(660, 0x11a);
            this.TxTErorr.TabIndex = 0;
            this.ButtonFinish.DialogResult = DialogResult.Cancel;
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = F.ImCloseOrang;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(12, 0x5c);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x282, 0x29);
            this.ButtonFinish.TabIndex = 0x59;
            this.ButtonFinish.Text = "اغلاق";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.ButtonCheck.FlatStyle = FlatStyle.Flat;
            this.ButtonCheck.ForeColor = Color.Blue;
            this.ButtonCheck.Image = F.ImLMyFile;
            this.ButtonCheck.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCheck.Location = new Point(0x159, 0x2c);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new Size(0x135, 0x29);
            this.ButtonCheck.TabIndex = 0x5d;
            this.ButtonCheck.Text = "فحص حزمة Crystal Report";
            this.ButtonCheck.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonFinish;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonFinish;
            base.ClientSize = new Size(0x29a, 0x1bc);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonCheck);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.ButtonD);
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CRHelp";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "خطأ";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
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

        private void I(object A, EventArgs R)
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
                this.ButtonD.Visible = true;
                ProjectData.ClearProjectError();
            }
        }

        private void P(object A, EventArgs R)
        {
            Interaction.MsgBox("يجب عليك اغلاق النظام بعد تحميل وتثبيت الحزمة", MsgBoxStyle.ApplicationModal, null);
            Process.Start("https://yazsys.com/RFCrystalReportDefult.aspx");
        }

        private void Q(object A, EventArgs R)
        {
            string text = this.TxTErorr.Text;
            this.ButtonD.Visible = text.Contains("The system cannot find the file specified") | text.Contains("PublickeyToken");
        }

        private void R(object A, EventArgs R)
        {
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

        internal virtual Button ButtonFinish
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

        internal virtual Button ButtonD
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTErorr
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonCheck
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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
    }
}

