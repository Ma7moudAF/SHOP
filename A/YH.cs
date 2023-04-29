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
    public class YH : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOK")]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button1")]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;

        public YH()
        {
            base.FormClosed += new FormClosedEventHandler(this.A);
            base.Load += new EventHandler(this.P);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label1 = new Label();
            this.ButtonOK = new Button();
            this.Button1 = new Button();
            this.Label2 = new Label();
            base.SuspendLayout();
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label1.Image = F.ImWarining;
            this.Label1.ImageAlign = ContentAlignment.TopCenter;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x2df, 0x7a);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "انت تستخدم نسخة تجريبية، يمكنك شراء النظام لتفعيل معظم العمليات وازالة قيود عدد السجلات";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOK.BackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = F.Im_LogOk;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(12, 0x5d);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x2c7, 0x37);
            this.ButtonOK.TabIndex = 15;
            this.ButtonOK.Text = "امتلك الرقم المتسلسل، انقر هنا لإدخال الرقم";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.Button1.BackColor = Color.WhiteSmoke;
            this.Button1.FlatAppearance.BorderColor = Color.Green;
            this.Button1.FlatAppearance.CheckedBackColor = Color.White;
            this.Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Button1.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.Button1.FlatStyle = FlatStyle.Flat;
            this.Button1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Button1.Image = F.ImAbout;
            this.Button1.ImageAlign = ContentAlignment.MiddleLeft;
            this.Button1.Location = new Point(12, 0xea);
            this.Button1.Margin = new Padding(3, 4, 3, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x2c7, 0x37);
            this.Button1.TabIndex = 0x10;
            this.Button1.Text = "عرض الأسعار وطريقة الحصول على الرقم والتفعيل";
            this.Button1.UseVisualStyleBackColor = false;
            this.Label2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(12, 0xa1);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x2c7, 0x36);
            this.Label2.TabIndex = 0x11;
            this.Label2.Text = "الدفع لهذا الجهاز لمرة واحدة شامل الدعم والتحديثات ولا اي مبالغ اخرى مستقبلاً، عملية تفعيل وإدخال الرقم المتسلسل تحتاج ان يكون هذا الجهاز متصل في الانترنت";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2df, 0x133);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.Button1);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SerialNeed";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "   ";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            if (!PR.P)
            {
                D.A.A.ShowDialog();
            }
            else
            {
                D.A.A.ShowDialog();
                base.Dispose();
            }
        }

        private void A(object A, FormClosedEventArgs R)
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

        private void P(object A, EventArgs R)
        {
        }

        private void R(object A, EventArgs R)
        {
            if (PR.Q)
            {
                Interaction.MsgBox("اتصل على رقم المندوب\r\n" + PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/GetSerialAr.aspx");
                base.Dispose();
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

        internal virtual Button ButtonOK
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

        internal virtual Button Button1
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

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }
    }
}

