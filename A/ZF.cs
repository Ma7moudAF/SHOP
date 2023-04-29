namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class ZF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTResult")]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1"), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("TxTCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSMS")]
        private Button A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("ButtonOk"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonExite")]
        private Button P;
        private SqlConnection A;
        private decimal A;
        private decimal R;
        private decimal P;
        private decimal Q;

        public ZF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.GroupBox2 = new GroupBox();
            this.TxTResult = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.TxTCode = new Label();
            this.ButtonSMS = new Button();
            this.TxTTitle = new Label();
            this.ButtonOk = new Button();
            this.ButtonExite = new Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.GroupBox2.Controls.Add(this.ButtonSMS);
            this.GroupBox2.Controls.Add(this.TxTResult);
            this.GroupBox2.Dock = DockStyle.Top;
            this.GroupBox2.Location = new Point(0, 0x6a);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x28f, 0x4c);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "رمز فك القفل";
            this.TxTResult.BackColor = SystemColors.Info;
            this.TxTResult.BorderStyle = BorderStyle.FixedSingle;
            this.TxTResult.Font = new Font("Tahoma", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTResult.Location = new Point(0xed, 0x1b);
            this.TxTResult.Name = "TxTResult";
            this.TxTResult.RightToLeft = RightToLeft.No;
            this.TxTResult.Size = new Size(0x19f, 40);
            this.TxTResult.TabIndex = 0;
            this.TxTResult.TextAlign = HorizontalAlignment.Center;
            this.GroupBox1.Controls.Add(this.TxTCode);
            this.GroupBox1.Dock = DockStyle.Top;
            this.GroupBox1.Location = new Point(0, 0x2d);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x28f, 0x3d);
            this.GroupBox1.TabIndex = 0x42;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "رمز الهوية/ ارسل رمز الهوية لمركز الدعم ان لم تستلم اي رسالة نصية";
            this.TxTCode.BackColor = Color.White;
            this.TxTCode.Dock = DockStyle.Fill;
            this.TxTCode.Font = new Font("Tahoma", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTCode.ForeColor = Color.Blue;
            this.TxTCode.Location = new Point(3, 0x13);
            this.TxTCode.Name = "TxTCode";
            this.TxTCode.RightToLeft = RightToLeft.No;
            this.TxTCode.Size = new Size(0x289, 0x27);
            this.TxTCode.TabIndex = 0x37;
            this.TxTCode.Text = "ارسل الكود التالي لمركز الدعم";
            this.TxTCode.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonSMS.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSMS.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSMS.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSMS.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSMS.FlatStyle = FlatStyle.Flat;
            this.ButtonSMS.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSMS.Image = F.EmailButton;
            this.ButtonSMS.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSMS.Location = new Point(12, 0x17);
            this.ButtonSMS.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSMS.Name = "ButtonSMS";
            this.ButtonSMS.Size = new Size(0xdb, 0x2c);
            this.ButtonSMS.TabIndex = 0x41;
            this.ButtonSMS.Text = "الحصول على رمز فك القفل";
            this.ButtonSMS.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x28f, 0x2d);
            this.TxTTitle.TabIndex = 0x40;
            this.TxTTitle.Text = "اعادة ضبط كلمة المرور";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(9, 0xbd);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x1cf, 0x2c);
            this.ButtonOk.TabIndex = 0x3f;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonExite.DialogResult = DialogResult.Cancel;
            this.ButtonExite.FlatAppearance.BorderColor = Color.Green;
            this.ButtonExite.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonExite.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonExite.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonExite.FlatStyle = FlatStyle.Flat;
            this.ButtonExite.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonExite.Image = F.ImExit;
            this.ButtonExite.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonExite.Location = new Point(0x1ec, 0xbd);
            this.ButtonExite.Margin = new Padding(3, 4, 3, 4);
            this.ButtonExite.Name = "ButtonExite";
            this.ButtonExite.Size = new Size(0x97, 0x2c);
            this.ButtonExite.TabIndex = 0x3e;
            this.ButtonExite.Text = "خروج";
            this.ButtonExite.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x28f, 0xf4);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.ButtonExite);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "RestPassword";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اعادة ضبط كلمة المرور";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
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

        private void P(object A, EventArgs R)
        {
            if (Conversion.Val(PR.Z) > 1200.0)
            {
                Process.Start("http://yazsys.com/SMSPassword.aspx?SR=" + PR.Z.ToString() + "&CO=" + this.TxTCode.Text);
            }
            else
            {
                Interaction.MsgBox("لا يوجد ترخيص مسجل حتى الأن", MsgBoxStyle.ApplicationModal, null);
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void Q(object A, EventArgs R)
        {
            ProjectData.EndApp();
        }

        private void R(object A, EventArgs R)
        {
            if (!(Conversion.Val(this.TxTResult.Text) == Convert.ToDouble(this.Q)))
            {
                Interaction.MsgBox("خطأ في رمز الدخول", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                AR.E = "";
                D.A.A.IsForgetPass.Checked = true;
                D.A.A.ShowDialog();
                base.Dispose();
            }
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

        internal virtual TextBox TxTResult
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label TxTCode
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonSMS
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonOk
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

        internal virtual Button ButtonExite
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

