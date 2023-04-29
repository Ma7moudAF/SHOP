namespace A
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class ZH : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTConnetion")]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonOk")]
        private Button R;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("TextBoxUser"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxServer")]
        private ComboBox A;
        [CompilerGenerated, AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxDataSource")]
        private ComboBox R;
        [CompilerGenerated, AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ComboBoxDataName")]
        private ComboBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label4")]
        private Label Q;
        [AccessedThroughProperty("Label5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [AccessedThroughProperty("TextBoxPassword"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [AccessedThroughProperty("ButtonRe"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("txtCommand"), CompilerGenerated]
        private TextBox Q;
        [AccessedThroughProperty("TxTResutl"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [AccessedThroughProperty("TimerRBuild"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private System.Windows.Forms.Timer A;
        [AccessedThroughProperty("CheckIntegratedSecurity"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("CheckBoxAddUser"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox R;

        public ZH()
        {
            base.Load += new EventHandler(this.U);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(ZH));
            this.GroupBox1 = new GroupBox();
            this.TxTConnetion = new TextBox();
            this.ButtonClose = new Button();
            this.ButtonOk = new Button();
            this.Label1 = new Label();
            this.TextBoxUser = new TextBox();
            this.ComboBoxServer = new ComboBox();
            this.Label2 = new Label();
            this.ComboBoxDataSource = new ComboBox();
            this.Label3 = new Label();
            this.ComboBoxDataName = new ComboBox();
            this.Label4 = new Label();
            this.Label5 = new Label();
            this.TextBoxPassword = new TextBox();
            this.ButtonRe = new Button();
            this.txtCommand = new TextBox();
            this.TxTResutl = new TextBox();
            this.TimerRBuild = new System.Windows.Forms.Timer(this.A);
            this.CheckIntegratedSecurity = new CheckBox();
            this.CheckBoxAddUser = new CheckBox();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.GroupBox1.Controls.Add(this.TxTConnetion);
            this.GroupBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox1.Location = new Point(9, 0xc0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x2a9, 0xa1);
            this.GroupBox1.TabIndex = 0x23;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "جملة الاتصال";
            this.TxTConnetion.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTConnetion.Location = new Point(7, 0x19);
            this.TxTConnetion.Multiline = true;
            this.TxTConnetion.Name = "TxTConnetion";
            this.TxTConnetion.RightToLeft = RightToLeft.No;
            this.TxTConnetion.Size = new Size(0x298, 0x7b);
            this.TxTConnetion.TabIndex = 5;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImFinish;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x227, 0x167);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x8b, 0x2d);
            this.ButtonClose.TabIndex = 0x22;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(9, 0x167);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(230, 0x2d);
            this.ButtonOk.TabIndex = 8;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(0x233, 0x13);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.No;
            this.Label1.Size = new Size(0x33, 0x10);
            this.Label1.TabIndex = 0x24;
            this.Label1.Text = "Server:";
            this.TextBoxUser.BackColor = SystemColors.Info;
            this.TextBoxUser.Location = new Point(0x48, 0x6c);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.RightToLeft = RightToLeft.No;
            this.TextBoxUser.Size = new Size(0x1e5, 0x17);
            this.TextBoxUser.TabIndex = 3;
            this.ComboBoxServer.BackColor = SystemColors.Info;
            this.ComboBoxServer.FormattingEnabled = true;
            object[] items = new object[] { @"(LocalDB)\MSSQLLocalDB", @"(LocalDB)\YAZSYS", @".\SQLEXPRESS", @".\SQLEXPRESS,1433", "92.205.29.131", "92.205.29.131,1433", @"PCYAZ\SQLEXPRESS,1433", @"PCYAZ\SQLEXPRESS" };
            this.ComboBoxServer.Items.AddRange(items);
            this.ComboBoxServer.Location = new Point(0x48, 0x10);
            this.ComboBoxServer.Name = "ComboBoxServer";
            this.ComboBoxServer.RightToLeft = RightToLeft.No;
            this.ComboBoxServer.Size = new Size(0x1e5, 0x18);
            this.ComboBoxServer.TabIndex = 0;
            this.ComboBoxServer.Text = @"(LocalDB)\MSSQLLocalDB";
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0x233, 0x30);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            this.Label2.Size = new Size(0x53, 0x10);
            this.Label2.TabIndex = 0x27;
            this.Label2.Text = "Data Source:";
            this.ComboBoxDataSource.BackColor = SystemColors.Info;
            this.ComboBoxDataSource.FormattingEnabled = true;
            object[] objArray2 = new object[] { "AttachDbFilename", "Initial Catalog" };
            this.ComboBoxDataSource.Items.AddRange(objArray2);
            this.ComboBoxDataSource.Location = new Point(0x48, 0x2d);
            this.ComboBoxDataSource.Name = "ComboBoxDataSource";
            this.ComboBoxDataSource.RightToLeft = RightToLeft.No;
            this.ComboBoxDataSource.Size = new Size(0x1e5, 0x18);
            this.ComboBoxDataSource.TabIndex = 1;
            this.ComboBoxDataSource.Text = "AttachDbFilename";
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(0x233, 0x51);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = RightToLeft.No;
            this.Label3.Size = new Size(0x4c, 0x10);
            this.Label3.TabIndex = 0x29;
            this.Label3.Text = "Data Name:";
            this.ComboBoxDataName.BackColor = SystemColors.Info;
            this.ComboBoxDataName.FormattingEnabled = true;
            object[] objArray3 = new object[] { @"|DataDirectory|\DB\DB.mdf" };
            this.ComboBoxDataName.Items.AddRange(objArray3);
            this.ComboBoxDataName.Location = new Point(0x48, 0x4e);
            this.ComboBoxDataName.Name = "ComboBoxDataName";
            this.ComboBoxDataName.RightToLeft = RightToLeft.No;
            this.ComboBoxDataName.Size = new Size(0x1e5, 0x18);
            this.ComboBoxDataName.TabIndex = 2;
            this.Label4.AutoSize = true;
            this.Label4.Location = new Point(0x236, 0x6f);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = RightToLeft.No;
            this.Label4.Size = new Size(0x4c, 0x10);
            this.Label4.TabIndex = 0x2b;
            this.Label4.Text = "User Name:";
            this.Label5.AutoSize = true;
            this.Label5.Location = new Point(0x236, 140);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = RightToLeft.No;
            this.Label5.Size = new Size(0x44, 0x10);
            this.Label5.TabIndex = 0x2d;
            this.Label5.Text = "Password:";
            this.TextBoxPassword.BackColor = SystemColors.Info;
            this.TextBoxPassword.Location = new Point(0x48, 0x89);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.RightToLeft = RightToLeft.No;
            this.TextBoxPassword.Size = new Size(0x1e5, 0x17);
            this.TextBoxPassword.TabIndex = 4;
            this.ButtonRe.FlatAppearance.BorderColor = Color.Green;
            this.ButtonRe.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonRe.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonRe.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonRe.FlatStyle = FlatStyle.Flat;
            this.ButtonRe.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonRe.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonRe.Location = new Point(0xf5, 0x167);
            this.ButtonRe.Name = "ButtonRe";
            this.ButtonRe.Size = new Size(300, 0x2d);
            this.ButtonRe.TabIndex = 0x35;
            this.ButtonRe.Text = "ضبط البيانات الافتراضية";
            this.ButtonRe.UseVisualStyleBackColor = true;
            this.txtCommand.Location = new Point(0xf8, 0x200);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.RightToLeft = RightToLeft.No;
            this.txtCommand.Size = new Size(0x1a3, 0x7f);
            this.txtCommand.TabIndex = 0x36;
            this.txtCommand.Text = "sqllocaldb stop MSSQLLocalDB\r\n\r\nsqllocaldb delete MSSQLLocalDB\r\n\r\nsqllocaldb create MSSQLLocalDB\r\n\r\nsqllocaldb start MSSQLLocalDB";
            this.TxTResutl.Location = new Point(12, 0x200);
            this.TxTResutl.Multiline = true;
            this.TxTResutl.Name = "TxTResutl";
            this.TxTResutl.Size = new Size(0xe5, 0xa9);
            this.TxTResutl.TabIndex = 0x37;
            this.TimerRBuild.Interval = 500;
            this.CheckIntegratedSecurity.AutoSize = true;
            this.CheckIntegratedSecurity.Location = new Point(0x1a5, 0xab);
            this.CheckIntegratedSecurity.Name = "CheckIntegratedSecurity";
            this.CheckIntegratedSecurity.RightToLeft = RightToLeft.No;
            this.CheckIntegratedSecurity.Size = new Size(0x88, 20);
            this.CheckIntegratedSecurity.TabIndex = 0x38;
            this.CheckIntegratedSecurity.Text = "Integrated Security";
            this.CheckIntegratedSecurity.UseVisualStyleBackColor = true;
            this.CheckBoxAddUser.AutoSize = true;
            this.CheckBoxAddUser.Location = new Point(0x10a, 0xab);
            this.CheckBoxAddUser.Name = "CheckBoxAddUser";
            this.CheckBoxAddUser.RightToLeft = RightToLeft.No;
            this.CheckBoxAddUser.Size = new Size(0x91, 20);
            this.CheckBoxAddUser.TabIndex = 0x39;
            this.CheckBoxAddUser.Text = "Add Local UserName";
            this.CheckBoxAddUser.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2be, 0x1a1);
            base.ControlBox = false;
            base.Controls.Add(this.CheckBoxAddUser);
            base.Controls.Add(this.CheckIntegratedSecurity);
            base.Controls.Add(this.TxTResutl);
            base.Controls.Add(this.txtCommand);
            base.Controls.Add(this.ButtonRe);
            base.Controls.Add(this.Label5);
            base.Controls.Add(this.TextBoxPassword);
            base.Controls.Add(this.Label4);
            base.Controls.Add(this.ComboBoxDataName);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.ComboBoxDataSource);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.ComboBoxServer);
            base.Controls.Add(this.TextBoxUser);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.ButtonOk);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.HelpButton = true;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "StartPointBuildCon";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "بناء جملة الاتصال";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.ComboBoxDataSource.Text = !((this.ComboBoxServer.Text == @"(LocalDB)\MSSQLLocalDB") | (this.ComboBoxServer.Text == @"(LocalDB)\YAZSYS")) ? "Initial Catalog" : "AttachDbFilename";
            this.R();
        }

        private void A(object A, MouseEventArgs R)
        {
            this.ComboBoxDataSource.Text = !((this.ComboBoxServer.Text == @"(LocalDB)\MSSQLLocalDB") | (this.ComboBoxServer.Text == @"(LocalDB)\YAZSYS")) ? "Initial Catalog" : "AttachDbFilename";
        }

        private void D(object A, EventArgs R)
        {
            this.R();
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

        private void E(object A, EventArgs R)
        {
            this.R();
        }

        private void F(object A, EventArgs R)
        {
            this.R();
        }

        private void G(object A, EventArgs R)
        {
            this.R();
        }

        private void H(object A, EventArgs R)
        {
            this.R();
        }

        private void I(object A, EventArgs R)
        {
            this.R();
        }

        private void K(object A, EventArgs R)
        {
            this.R();
        }

        private void L(object A, EventArgs R)
        {
            this.ComboBoxServer.Text = this.ComboBoxServer.Text.Replace(".1433", ",1433");
        }

        private void N(object A, EventArgs R)
        {
            this.R();
        }

        private void P(object A, EventArgs R)
        {
            this.R();
        }

        private void Q(object A, EventArgs R)
        {
            if (this.ComboBoxDataSource.Text == "AttachDbFilename")
            {
                this.CheckIntegratedSecurity.Enabled = true;
            }
            else
            {
                this.CheckIntegratedSecurity.Enabled = false;
                this.CheckIntegratedSecurity.Checked = false;
            }
            this.R();
        }

        public void R()
        {
            string[] textArray1 = new string[] { "Data Source=", this.ComboBoxServer.Text, "; ", this.ComboBoxDataSource.Text, "=", this.ComboBoxDataName.Text };
            this.TxTConnetion.Text = string.Concat(textArray1);
            if (this.TextBoxUser.Text.Trim() != null)
            {
                this.TxTConnetion.Text = this.TxTConnetion.Text + "; User ID=" + this.TextBoxUser.Text;
            }
            if (this.TextBoxPassword.Text.Trim() != null)
            {
                this.TxTConnetion.Text = this.TxTConnetion.Text + "; Password=" + this.TextBoxPassword.Text;
            }
            if (this.CheckIntegratedSecurity.Checked)
            {
                this.TxTConnetion.Text = this.TxTConnetion.Text + "; Integrated Security = True";
            }
            this.TxTConnetion.Text = this.TxTConnetion.Text + ";";
        }

        private void R(object A, EventArgs R)
        {
            this.R();
        }

        private void T(object A, EventArgs R)
        {
            A.D.A.A.TxTConnetion.Text = this.TxTConnetion.Text;
            AR.P = this.ComboBoxServer.Text;
            AR.Q = this.ComboBoxDataSource.Text;
            AR.I = this.ComboBoxDataName.Text;
            AR.D = this.TextBoxUser.Text;
            AR.F = this.TextBoxPassword.Text;
            A.D.A.A.ButtonTest.Enabled = true;
            base.Dispose();
        }

        private void U(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void V(object A, EventArgs R)
        {
            this.TextBoxUser.Text = !this.CheckBoxAddUser.Checked ? null : Dns.GetHostName().ToString();
            this.R();
        }

        private void X(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void Y(object A, EventArgs R)
        {
            // Invalid method body.
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

        internal virtual TextBox TxTConnetion
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
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual Button ButtonOk
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TextBoxUser
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                TextBox r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
                }
            }
        }

        internal virtual ComboBox ComboBoxServer
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
                EventHandler handler2 = new EventHandler(this.R);
                MouseEventHandler handler3 = new MouseEventHandler(this.A);
                EventHandler handler4 = new EventHandler(this.L);
                ComboBox a = this.A;
                if (a != null)
                {
                    a.SelectedIndexChanged -= handler;
                    a.TextChanged -= handler2;
                    a.MouseClick -= handler3;
                    a.Leave -= handler4;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.SelectedIndexChanged += handler;
                    a.TextChanged += handler2;
                    a.MouseClick += handler3;
                    a.Leave += handler4;
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

        internal virtual ComboBox ComboBoxDataSource
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                EventHandler handler2 = new EventHandler(this.Q);
                ComboBox r = this.R;
                if (r != null)
                {
                    r.SelectedIndexChanged -= handler;
                    r.TextChanged -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.SelectedIndexChanged += handler;
                    r.TextChanged += handler2;
                }
            }
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

        internal virtual ComboBox ComboBoxDataName
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                EventHandler handler2 = new EventHandler(this.D);
                ComboBox p = this.P;
                if (p != null)
                {
                    p.SelectedIndexChanged -= handler;
                    p.TextChanged -= handler2;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.SelectedIndexChanged += handler;
                    p.TextChanged += handler2;
                }
            }
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label Label5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox TextBoxPassword
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                TextBox p = this.P;
                if (p != null)
                {
                    p.TextChanged -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.TextChanged += handler;
                }
            }
        }

        internal virtual Button ButtonRe
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
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

        internal virtual TextBox txtCommand
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTResutl
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual System.Windows.Forms.Timer TimerRBuild
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckIntegratedSecurity
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
                CheckBox a = this.A;
                if (a != null)
                {
                    a.CheckedChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBoxAddUser
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
                CheckBox r = this.R;
                if (r != null)
                {
                    r.CheckedChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.CheckedChanged += handler;
                }
            }
        }
    }
}

