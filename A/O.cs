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
    public class O : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonRenw")]
        private Button R;

        public O()
        {
            base.Load += new EventHandler(this.P);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.ButtonFinish = new Button();
            this.TxTTitle = new Label();
            this.ButtonRenw = new Button();
            base.SuspendLayout();
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = F.ImCloseOrang;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(0x1dd, 0x6f);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0xb8, 0x2e);
            this.ButtonFinish.TabIndex = 0x8a;
            this.ButtonFinish.Text = "اغلاق";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x2a1, 0x67);
            this.TxTTitle.TabIndex = 140;
            this.TxTTitle.Text = "الاشتراك في الخدمة السحابية انتهت لديك، يجب عليك اعادة تجديدها";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonRenw.FlatAppearance.BorderColor = Color.Green;
            this.ButtonRenw.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonRenw.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonRenw.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonRenw.FlatStyle = FlatStyle.Flat;
            this.ButtonRenw.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonRenw.Image = F.ImLUpdate;
            this.ButtonRenw.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonRenw.Location = new Point(12, 0x6f);
            this.ButtonRenw.Margin = new Padding(3, 4, 3, 4);
            this.ButtonRenw.Name = "ButtonRenw";
            this.ButtonRenw.Size = new Size(0x1cb, 0x2e);
            this.ButtonRenw.TabIndex = 0x8d;
            this.ButtonRenw.Text = "تجديد الاشتراك الأن";
            this.ButtonRenw.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2a1, 0xa6);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonRenw);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ButtonFinish);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CheckCloudEnd";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "انتهاء الاشتراك في الخدمة السحابية";
            base.TopMost = true;
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            if (AR.H <= 20)
            {
                AR.H++;
                base.Dispose();
            }
            else
            {
                PR.E = true;
                AR.H++;
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
        }

        private void R(object A, EventArgs R)
        {
            // Invalid method body.
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

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonRenw
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
    }
}

