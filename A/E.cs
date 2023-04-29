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
    public class E : Form
    {
        private IContainer A;
        [AccessedThroughProperty("PictureBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label3")]
        private Label P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Button1")]
        private Button A;

        public E()
        {
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(E));
            this.PictureBox1 = new PictureBox();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Button1 = new Button();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            base.SuspendLayout();
            this.PictureBox1.Dock = DockStyle.Top;
            this.PictureBox1.Image = F.ImWarining;
            this.PictureBox1.Location = new Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x3a1, 0x42);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Red;
            this.Label1.Location = new Point(0, 0x42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x3a1, 0x2d);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "تحذير";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = Color.Black;
            this.Label2.Location = new Point(0, 0x6f);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x3a1, 0x5f);
            this.Label2.TabIndex = 2;
            this.Label2.Text = manager.GetString("Label2.Text");
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.Label3.Dock = DockStyle.Top;
            this.Label3.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = Color.Red;
            this.Label3.Location = new Point(0, 0xce);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x3a1, 0x2d);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "وعلى مسؤوليتك الشخصية";
            this.Label3.TextAlign = ContentAlignment.MiddleCenter;
            this.Button1.Dock = DockStyle.Bottom;
            this.Button1.Location = new Point(0, 0x108);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x3a1, 0x4f);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "موافق";
            this.Button1.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3a1, 0x157);
            base.ControlBox = false;
            base.Controls.Add(this.Button1);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.PictureBox1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "BackUpWarning";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "  ";
            ((ISupportInitialize) this.PictureBox1).EndInit();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            AR.Q = true;
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

        internal virtual PictureBox PictureBox1
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

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button Button1
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
    }
}

