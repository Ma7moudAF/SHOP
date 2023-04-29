namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class LH : Form
    {
        private IContainer A;
        [AccessedThroughProperty("UserPass"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserLog")]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("UserName"), CompilerGenerated]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterFrontID"), CompilerGenerated]
        private TextBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonExite"), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBox1"), CompilerGenerated]
        private PictureBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("IsSaveLogin")]
        private CheckBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTUserPass")]
        private TextBox I;
        [AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOk"), CompilerGenerated]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [AccessedThroughProperty("TimerLog"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTUserLog")]
        private ComboBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonViewP")]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LinkRestPassword"), CompilerGenerated]
        private LinkLabel A;
        private CheckBox R;
        private CheckBox P;
        private CheckBox Q;
        private CheckBox I;
        private CheckBox D;
        private CheckBox F;
        private CheckBox H;
        private CheckBox T;
        private CheckBox X;
        private CheckBox G;
        private CheckBox E;
        private CheckBox K;
        private CheckBox U;
        private CheckBox L;
        private CheckBox N;
        private CheckBox V;
        private CheckBox Y;
        private CheckBox O;
        private CheckBox B;
        private CheckBox S;
        private CheckBox Z;
        private CheckBox M;
        private CheckBox C;
        private CheckBox J;
        private CheckBox W;
        private CheckBox AR;
        private CheckBox PR;
        private CheckBox QR;
        private CheckBox IR;
        private CheckBox DR;
        private CheckBox FR;
        private CheckBox HR;
        private CheckBox TR;
        private CheckBox XR;
        private CheckBox GR;
        private CheckBox ER;
        private CheckBox KR;
        private CheckBox UR;
        private CheckBox LR;
        private CheckBox NR;
        private CheckBox VR;
        private CheckBox YR;
        private CheckBox OR;
        private SqlConnection A;
        private A.M A;

        public LH()
        {
            base.Load += new EventHandler(this.R);
            this.R = new CheckBox();
            this.P = new CheckBox();
            this.Q = new CheckBox();
            this.I = new CheckBox();
            this.D = new CheckBox();
            this.F = new CheckBox();
            this.H = new CheckBox();
            this.T = new CheckBox();
            this.X = new CheckBox();
            this.G = new CheckBox();
            this.E = new CheckBox();
            this.K = new CheckBox();
            this.U = new CheckBox();
            this.L = new CheckBox();
            this.N = new CheckBox();
            this.V = new CheckBox();
            this.Y = new CheckBox();
            this.O = new CheckBox();
            this.B = new CheckBox();
            this.S = new CheckBox();
            this.Z = new CheckBox();
            this.M = new CheckBox();
            this.C = new CheckBox();
            this.J = new CheckBox();
            this.W = new CheckBox();
            this.AR = new CheckBox();
            this.PR = new CheckBox();
            this.QR = new CheckBox();
            this.IR = new CheckBox();
            this.DR = new CheckBox();
            this.FR = new CheckBox();
            this.HR = new CheckBox();
            this.TR = new CheckBox();
            this.XR = new CheckBox();
            this.GR = new CheckBox();
            this.ER = new CheckBox();
            this.KR = new CheckBox();
            this.UR = new CheckBox();
            this.LR = new CheckBox();
            this.NR = new CheckBox();
            this.VR = new CheckBox();
            this.YR = new CheckBox();
            this.OR = new CheckBox();
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new A.M();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(LH));
            this.UserPass = new TextBox();
            this.UserLog = new TextBox();
            this.UserName = new TextBox();
            this.CenterFrontID = new TextBox();
            this.ButtonExite = new Button();
            this.PictureBox1 = new PictureBox();
            this.IsSaveLogin = new CheckBox();
            this.TxTUserPass = new TextBox();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.ButtonOk = new Button();
            this.GroupBox1 = new GroupBox();
            this.LinkRestPassword = new LinkLabel();
            this.ButtonViewP = new Button();
            this.TxTUserLog = new ComboBox();
            this.TxTTitle = new Label();
            this.TimerLog = new Timer(this.A);
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.UserPass.Location = new Point(0x1a5, 360);
            this.UserPass.Name = "UserPass";
            this.UserPass.RightToLeft = RightToLeft.No;
            this.UserPass.Size = new Size(100, 0x17);
            this.UserPass.TabIndex = 0x39;
            this.UserLog.Location = new Point(0x1a5, 330);
            this.UserLog.Name = "UserLog";
            this.UserLog.RightToLeft = RightToLeft.No;
            this.UserLog.Size = new Size(100, 0x17);
            this.UserLog.TabIndex = 0x37;
            this.UserName.Location = new Point(0x1a5, 0x12b);
            this.UserName.Name = "UserName";
            this.UserName.RightToLeft = RightToLeft.No;
            this.UserName.Size = new Size(100, 0x17);
            this.UserName.TabIndex = 0x36;
            this.CenterFrontID.Location = new Point(0x1a5, 0x10c);
            this.CenterFrontID.Name = "CenterFrontID";
            this.CenterFrontID.RightToLeft = RightToLeft.No;
            this.CenterFrontID.Size = new Size(100, 0x17);
            this.CenterFrontID.TabIndex = 0x35;
            this.ButtonExite.DialogResult = DialogResult.Cancel;
            this.ButtonExite.FlatAppearance.BorderColor = Color.Green;
            this.ButtonExite.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonExite.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonExite.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonExite.FlatStyle = FlatStyle.Flat;
            this.ButtonExite.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonExite.Image = A.F.ImExit;
            this.ButtonExite.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonExite.Location = new Point(0x162, 0xca);
            this.ButtonExite.Margin = new Padding(3, 4, 3, 4);
            this.ButtonExite.Name = "ButtonExite";
            this.ButtonExite.Size = new Size(0xa7, 0x2c);
            this.ButtonExite.TabIndex = 0x33;
            this.ButtonExite.Text = "خروج";
            this.ButtonExite.UseVisualStyleBackColor = true;
            this.PictureBox1.Image = A.F.ImLogin;
            this.PictureBox1.Location = new Point(0x1c9, 0x21);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x29, 40);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            this.IsSaveLogin.AutoSize = true;
            this.IsSaveLogin.Checked = true;
            this.IsSaveLogin.CheckState = CheckState.Checked;
            this.IsSaveLogin.Location = new Point(0xa7, 0x57);
            this.IsSaveLogin.Name = "IsSaveLogin";
            this.IsSaveLogin.Size = new Size(0xae, 20);
            this.IsSaveLogin.TabIndex = 2;
            this.IsSaveLogin.Text = "حفظ بيانات تسجيل الدخول";
            this.IsSaveLogin.UseVisualStyleBackColor = true;
            this.TxTUserPass.BackColor = SystemColors.Info;
            this.TxTUserPass.Location = new Point(0x2d, 0x36);
            this.TxTUserPass.Name = "TxTUserPass";
            this.TxTUserPass.RightToLeft = RightToLeft.No;
            this.TxTUserPass.Size = new Size(0x12e, 0x17);
            this.TxTUserPass.TabIndex = 1;
            this.TxTUserPass.UseSystemPasswordChar = true;
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0x160, 0x39);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x49, 0x10);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "كلمة المرور:";
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(0x160, 0x16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(100, 0x10);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "اسم المستخدم:";
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(180, 0xca);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0xa7, 0x2c);
            this.ButtonOk.TabIndex = 50;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.LinkRestPassword);
            this.GroupBox1.Controls.Add(this.ButtonViewP);
            this.GroupBox1.Controls.Add(this.TxTUserLog);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.IsSaveLogin);
            this.GroupBox1.Controls.Add(this.TxTUserPass);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new Point(4, 0x2d);
            this.GroupBox1.Margin = new Padding(3, 4, 3, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new Padding(3, 4, 3, 4);
            this.GroupBox1.Size = new Size(0x205, 0x94);
            this.GroupBox1.TabIndex = 0x31;
            this.GroupBox1.TabStop = false;
            this.LinkRestPassword.AutoSize = true;
            this.LinkRestPassword.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LinkRestPassword.LinkBehavior = LinkBehavior.HoverUnderline;
            this.LinkRestPassword.Location = new Point(0xe9, 0x74);
            this.LinkRestPassword.Name = "LinkRestPassword";
            this.LinkRestPassword.Size = new Size(0x6f, 0x10);
            this.LinkRestPassword.TabIndex = 0x68;
            this.LinkRestPassword.TabStop = true;
            this.LinkRestPassword.Text = "نسيت كلمة السر !";
            this.ButtonViewP.FlatStyle = FlatStyle.Flat;
            this.ButtonViewP.Image = A.F.ImView;
            this.ButtonViewP.Location = new Point(7, 0x36);
            this.ButtonViewP.Name = "ButtonViewP";
            this.ButtonViewP.Size = new Size(0x20, 0x17);
            this.ButtonViewP.TabIndex = 0x65;
            this.ButtonViewP.UseVisualStyleBackColor = true;
            this.TxTUserLog.BackColor = SystemColors.Info;
            this.TxTUserLog.FormattingEnabled = true;
            this.TxTUserLog.Location = new Point(7, 0x13);
            this.TxTUserLog.Name = "TxTUserLog";
            this.TxTUserLog.RightToLeft = RightToLeft.No;
            this.TxTUserLog.Size = new Size(340, 0x18);
            this.TxTUserLog.TabIndex = 7;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x20c, 0x29);
            this.TxTTitle.TabIndex = 0x34;
            this.TxTTitle.Text = "تسجيل الدخول";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonExite;
            base.ClientSize = new Size(0x20c, 0xfc);
            base.ControlBox = false;
            base.Controls.Add(this.UserPass);
            base.Controls.Add(this.UserLog);
            base.Controls.Add(this.UserName);
            base.Controls.Add(this.CenterFrontID);
            base.Controls.Add(this.ButtonExite);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "LoginUsers";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            ((ISupportInitialize) this.PictureBox1).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            if (this.TxTUserLog.Text == "")
            {
                this.TxTUserLog.Focus();
            }
            else if (this.TxTUserPass.Text == "")
            {
                this.TxTUserPass.Focus();
            }
            else
            {
                this.TxTTitle.Text = A.PR.A.ToString();
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 13f);
                this.TimerLog.Enabled = true;
            }
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if ((Strings.Asc(R.KeyChar) != 8) && !"1234567890asdfghjklzxcvbnmqwertyuiop*".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.I.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void A(object A, LinkLabelLinkClickedEventArgs R)
        {
            this.TxTTitle.Text = this.Text;
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Font = new Font("Tahoma", 12f);
            A.D.A.A.ShowDialog();
        }

        private void D(object A, EventArgs R)
        {
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

        private void F(object A, EventArgs R)
        {
            this.TimerLog.Enabled = false;
            this.R();
        }

        private void H(object A, EventArgs R)
        {
        }

        private void I(object A, EventArgs R)
        {
            if (!A.PR.I)
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("DELETE FROM TaNNTempNetwork WHERE (NetWorkName = @NetWorkName)", this.A);
                command.Parameters.AddWithValue("NetWorkName", 0x4b0);
                command.ExecuteNonQuery();
            }
            A.D.A.A.Show();
        }

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
        }

        private void Q(object A, EventArgs R)
        {
            if (this.IsSaveLogin.Checked)
            {
                A.AR.A = this.TxTUserLog.Text;
                A.AR.R = this.TxTUserPass.Text;
                A.AR.A = true;
            }
            else
            {
                this.TxTUserLog.Text = "";
                this.TxTUserPass.Text = "";
                A.AR.A = "";
                A.AR.R = "";
                A.AR.A = false;
                this.TxTUserLog.Focus();
            }
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if ((Strings.Asc(R.KeyChar) != 8) && !"1234567890asdfghjklzxcvbnmqwertyuiop*".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.I.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void T(object A, EventArgs R)
        {
            this.TxTUserPass.UseSystemPasswordChar = false;
        }

        internal virtual TextBox UserPass
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox UserLog
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox UserName
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox CenterFrontID
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonExite
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

        internal virtual PictureBox PictureBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox IsSaveLogin
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                EventHandler handler2 = new EventHandler(this.Q);
                CheckBox a = this.A;
                if (a != null)
                {
                    a.CheckedChanged -= handler;
                    a.Click -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.CheckedChanged += handler;
                    a.Click += handler2;
                }
            }
        }

        internal virtual TextBox TxTUserPass
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.R);
                EventHandler handler2 = new EventHandler(this.H);
                TextBox i = this.I;
                if (i != null)
                {
                    i.KeyPress -= handler;
                    i.TextChanged -= handler2;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.KeyPress += handler;
                    i.TextChanged += handler2;
                }
            }
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

        internal virtual Label Label1
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Timer TimerLog
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual ComboBox TxTUserLog
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonViewP
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual LinkLabel LinkRestPassword
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.A);
                LinkLabel a = this.A;
                if (a != null)
                {
                    a.LinkClicked -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.LinkClicked += handler;
                }
            }
        }
    }
}

