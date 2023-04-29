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
    public class RD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button1")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button2"), CompilerGenerated]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TextBox1")]
        private TextBox A;
        [AccessedThroughProperty("TextBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("Saleb50"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Saleb100")]
        private TextBox Q;

        public RD()
        {
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label1 = new Label();
            this.Button1 = new Button();
            this.Button2 = new Button();
            this.TextBox1 = new TextBox();
            this.TextBox2 = new TextBox();
            this.Saleb50 = new TextBox();
            this.Saleb100 = new TextBox();
            base.SuspendLayout();
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x290, 0x79);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "يجب إعادة تنسيق ضبط صيغة التاريخ وتنسيق الآرقام في إعدادات الويندوز لديك\r\n\r\n-  التاريخ الهجري غير مدعوم، استخدم التاريخ الميلادي.\r\n- الارقام العشرية للارقام خطأ.";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.Button1.Location = new Point(12, 0x93);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x199, 0x22);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "شاهد فيديو لطريقة اصلاح المشكلة";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button2.Location = new Point(0x1ab, 0x93);
            this.Button2.Name = "Button2";
            this.Button2.Size = new Size(0xd9, 0x22);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "اعادة التشغيل";
            this.Button2.UseVisualStyleBackColor = true;
            this.TextBox1.Location = new Point(0x214, 0xe7);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new Size(0x45, 0x17);
            this.TextBox1.TabIndex = 3;
            this.TextBox2.Location = new Point(0x214, 0x105);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new Size(0x45, 0x17);
            this.TextBox2.TabIndex = 4;
            this.Saleb50.Location = new Point(0xf9, 0x107);
            this.Saleb50.Name = "Saleb50";
            this.Saleb50.Size = new Size(100, 0x17);
            this.Saleb50.TabIndex = 5;
            this.Saleb100.Location = new Point(0xf9, 0x125);
            this.Saleb100.Name = "Saleb100";
            this.Saleb100.Size = new Size(100, 0x17);
            this.Saleb100.TabIndex = 6;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            base.ClientSize = new Size(0x290, 190);
            base.ControlBox = false;
            base.Controls.Add(this.Saleb100);
            base.Controls.Add(this.Saleb50);
            base.Controls.Add(this.TextBox2);
            base.Controls.Add(this.TextBox1);
            base.Controls.Add(this.Button2);
            base.Controls.Add(this.Button1);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FixNumberDate";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ضبط الويندوز";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            D.A.A.Show();
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

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            Process.Start("https://yazsys.com/SPDetails.aspx?ID=31");
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

        internal virtual Button Button1
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

        internal virtual Button Button2
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

        internal virtual TextBox TextBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TextBox2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox Saleb50
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox Saleb100
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }
    }
}

