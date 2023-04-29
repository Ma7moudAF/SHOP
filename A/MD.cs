namespace A
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class MD : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("ButtonFinish"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("ButtonNew"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerEn"), CompilerGenerated]
        private Timer A;

        public MD()
        {
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.ButtonFinish = new Button();
            this.ButtonNew = new Button();
            this.TimerEn = new Timer(this.A);
            base.SuspendLayout();
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Red;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x2ad, 0x33);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "تحذير";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = Color.FromArgb(0x40, 0x40, 0x40);
            this.Label2.Location = new Point(0, 0x33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x2ad, 0x68);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "  يوجد نسخة مفتوحة الأن من النظام، لا يجوز تكرار تشغيل النظام بنفس الوقت على نفس الجهاز، هذا قد يؤدي الى تلف وتكرار البيانات.";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = F.ImCloseOrang;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(0x1eb, 170);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0xb6, 0x2e);
            this.ButtonFinish.TabIndex = 0x94;
            this.ButtonFinish.Text = "اغلاق";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.ButtonNew.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonNew.Enabled = false;
            this.ButtonNew.FlatStyle = FlatStyle.Flat;
            this.ButtonNew.Image = F.ImWarining;
            this.ButtonNew.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonNew.Location = new Point(12, 170);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new Size(0x1d9, 0x2e);
            this.ButtonNew.TabIndex = 0x95;
            this.ButtonNew.Text = "انتظر ....";
            this.ButtonNew.UseVisualStyleBackColor = false;
            this.TimerEn.Enabled = true;
            this.TimerEn.Interval = 0xbb8;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2ad, 0xed);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.ButtonNew);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.Name = "IsOpenOk";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "خطأ تكرار تشغيل النظام";
            base.TopMost = true;
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            this.TimerEn.Enabled = false;
            this.ButtonNew.Enabled = true;
            this.ButtonNew.Text = "الاستمرار على كل حال !";
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
            D.A.A.TimerStart.Enabled = true;
            base.Dispose();
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void R(object A, EventArgs R)
        {
            ProjectData.EndApp();
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

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonFinish
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

        internal virtual Button ButtonNew
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

        internal virtual Timer TimerEn
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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
    }
}

