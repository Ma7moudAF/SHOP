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
    public class WH : Form
    {
        private IContainer A;
        [AccessedThroughProperty("ButtonExite"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label7")]
        private Label A;
        [AccessedThroughProperty("TxTUserName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("PictureBox1")]
        private PictureBox A;
        [AccessedThroughProperty("TxTUserPass"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label10"), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("Label8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label P;
        [AccessedThroughProperty("TxTUserLog"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("ButtonOk"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CenterPhone")]
        private TextBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterLocation")]
        private TextBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1"), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("CenterSubName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label I;
        [AccessedThroughProperty("CenterName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox F;
        [AccessedThroughProperty("Label3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox P;
        [AccessedThroughProperty("Label4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonBackUp")]
        private Button P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonChange")]
        private Button Q;
        private SqlConnection A;
        private M A;

        public WH()
        {
            base.Load += new EventHandler(this.R);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new M();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(WH));
            this.ButtonExite = new Button();
            this.Label7 = new Label();
            this.TxTUserName = new TextBox();
            this.TxTUserPass = new TextBox();
            this.Label10 = new Label();
            this.Label8 = new Label();
            this.TxTUserLog = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.PictureBox1 = new PictureBox();
            this.ButtonOk = new Button();
            this.GroupBox2 = new GroupBox();
            this.CenterPhone = new TextBox();
            this.CenterLocation = new TextBox();
            this.Label1 = new Label();
            this.CenterSubName = new TextBox();
            this.Label2 = new Label();
            this.CenterName = new TextBox();
            this.Label3 = new Label();
            this.GroupBox1 = new GroupBox();
            this.Label4 = new Label();
            this.TxTTitle = new Label();
            this.ButtonBackUp = new Button();
            this.ButtonChange = new Button();
            this.GroupBox3.SuspendLayout();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.ButtonExite.DialogResult = DialogResult.Cancel;
            this.ButtonExite.FlatAppearance.BorderColor = Color.Green;
            this.ButtonExite.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonExite.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonExite.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonExite.FlatStyle = FlatStyle.Flat;
            this.ButtonExite.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonExite.Image = A.F.ImExit;
            this.ButtonExite.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonExite.Location = new Point(0x242, 0xf5);
            this.ButtonExite.Margin = new Padding(3, 4, 3, 4);
            this.ButtonExite.Name = "ButtonExite";
            this.ButtonExite.Size = new Size(0xbb, 0x2c);
            this.ButtonExite.TabIndex = 10;
            this.ButtonExite.Text = "خروج";
            this.ButtonExite.UseVisualStyleBackColor = true;
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.Location = new Point(0x113, 0x23);
            this.Label7.Name = "Label7";
            this.Label7.Size = new Size(0x2e, 0x10);
            this.Label7.TabIndex = 0x1f;
            this.Label7.Text = "الأسم:";
            this.TxTUserName.BackColor = SystemColors.Info;
            this.TxTUserName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTUserName.Location = new Point(20, 0x20);
            this.TxTUserName.MaxLength = 50;
            this.TxTUserName.Name = "TxTUserName";
            this.TxTUserName.Size = new Size(0xf4, 0x17);
            this.TxTUserName.TabIndex = 6;
            this.TxTUserName.TextAlign = HorizontalAlignment.Center;
            this.TxTUserPass.BackColor = SystemColors.Info;
            this.TxTUserPass.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTUserPass.Location = new Point(13, 0x3d);
            this.TxTUserPass.MaxLength = 50;
            this.TxTUserPass.Name = "TxTUserPass";
            this.TxTUserPass.RightToLeft = RightToLeft.No;
            this.TxTUserPass.Size = new Size(0xce, 0x17);
            this.TxTUserPass.TabIndex = 8;
            this.TxTUserPass.TextAlign = HorizontalAlignment.Center;
            this.Label10.AutoSize = true;
            this.Label10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label10.Location = new Point(0xe2, 0x40);
            this.Label10.Name = "Label10";
            this.Label10.Size = new Size(0x45, 0x10);
            this.Label10.TabIndex = 0x22;
            this.Label10.Text = "كلمة السر:";
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label8.Location = new Point(0xe2, 0x1c);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(0x47, 0x10);
            this.Label8.TabIndex = 0x20;
            this.Label8.Text = "رمز الدخول:";
            this.TxTUserLog.BackColor = SystemColors.Info;
            this.TxTUserLog.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTUserLog.Location = new Point(13, 0x19);
            this.TxTUserLog.MaxLength = 50;
            this.TxTUserLog.Name = "TxTUserLog";
            this.TxTUserLog.RightToLeft = RightToLeft.No;
            this.TxTUserLog.Size = new Size(0xce, 0x17);
            this.TxTUserLog.TabIndex = 7;
            this.TxTUserLog.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.PictureBox1);
            this.GroupBox3.Controls.Add(this.TxTUserPass);
            this.GroupBox3.Controls.Add(this.Label10);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.TxTUserLog);
            this.GroupBox3.Location = new Point(7, 0x44);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x16a, 0x68);
            this.GroupBox3.TabIndex = 0x24;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "بيانات الدخول";
            this.PictureBox1.Image = A.F.ImLogin;
            this.PictureBox1.Location = new Point(0x13f, 0x29);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x20, 0x20);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 0x26;
            this.PictureBox1.TabStop = false;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(12, 0xf5);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(560, 0x2c);
            this.ButtonOk.TabIndex = 9;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.TxTUserName);
            this.GroupBox2.Location = new Point(0x18a, 0x34);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x177, 0xba);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "بيانات المدير العام";
            this.CenterPhone.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CenterPhone.Location = new Point(11, 0x8d);
            this.CenterPhone.MaxLength = 50;
            this.CenterPhone.Name = "CenterPhone";
            this.CenterPhone.Size = new Size(250, 0x17);
            this.CenterPhone.TabIndex = 4;
            this.CenterPhone.TextAlign = HorizontalAlignment.Center;
            this.CenterLocation.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CenterLocation.Location = new Point(11, 0x68);
            this.CenterLocation.MaxLength = 50;
            this.CenterLocation.Name = "CenterLocation";
            this.CenterLocation.Size = new Size(250, 0x17);
            this.CenterLocation.TabIndex = 3;
            this.CenterLocation.TextAlign = HorizontalAlignment.Center;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0x10c, 0x23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x4c, 0x10);
            this.Label1.TabIndex = 0x15;
            this.Label1.Text = "اسم المتجر:";
            this.CenterSubName.BackColor = SystemColors.Info;
            this.CenterSubName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CenterSubName.Location = new Point(11, 0x44);
            this.CenterSubName.MaxLength = 50;
            this.CenterSubName.Name = "CenterSubName";
            this.CenterSubName.Size = new Size(250, 0x17);
            this.CenterSubName.TabIndex = 2;
            this.CenterSubName.Text = "الرئيسي";
            this.CenterSubName.TextAlign = HorizontalAlignment.Center;
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0x10c, 0x47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x63, 0x10);
            this.Label2.TabIndex = 0x16;
            this.Label2.Text = "الفرع/المستودع:";
            this.CenterName.BackColor = SystemColors.Info;
            this.CenterName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CenterName.Location = new Point(11, 0x20);
            this.CenterName.MaxLength = 50;
            this.CenterName.Name = "CenterName";
            this.CenterName.Size = new Size(250, 0x17);
            this.CenterName.TabIndex = 1;
            this.CenterName.TextAlign = HorizontalAlignment.Center;
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.Location = new Point(0x10c, 0x90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(70, 0x10);
            this.Label3.TabIndex = 0x17;
            this.Label3.Text = "رقم الهاتف:";
            this.GroupBox1.Controls.Add(this.CenterPhone);
            this.GroupBox1.Controls.Add(this.CenterLocation);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.CenterSubName);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.CenterName);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox1.Location = new Point(12, 0x34);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.RightToLeft = RightToLeft.Yes;
            this.GroupBox1.Size = new Size(0x178, 0xba);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "معلومات المتجر الأساسية";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.Location = new Point(0x10c, 0x6b);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x31, 0x10);
            this.Label4.TabIndex = 0x18;
            this.Label4.Text = "العنوان:";
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x309, 0x2b);
            this.TxTTitle.TabIndex = 0x26;
            this.TxTTitle.Text = "تهيئة النظام";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonBackUp.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonBackUp.Dock = DockStyle.Bottom;
            this.ButtonBackUp.FlatAppearance.BorderColor = Color.Green;
            this.ButtonBackUp.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonBackUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonBackUp.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonBackUp.FlatStyle = FlatStyle.Flat;
            this.ButtonBackUp.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonBackUp.Image = A.F.ImDataError;
            this.ButtonBackUp.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonBackUp.Location = new Point(0, 0x138);
            this.ButtonBackUp.Margin = new Padding(3, 4, 3, 4);
            this.ButtonBackUp.Name = "ButtonBackUp";
            this.ButtonBackUp.Size = new Size(0x309, 0x2c);
            this.ButtonBackUp.TabIndex = 0x27;
            this.ButtonBackUp.Text = "استعادة نسخة احتياطية لقاعدة البيانات";
            this.ButtonBackUp.UseVisualStyleBackColor = false;
            this.ButtonChange.BackColor = Color.FromArgb(0xff, 0xe0, 0xc0);
            this.ButtonChange.Dock = DockStyle.Bottom;
            this.ButtonChange.FlatAppearance.BorderColor = Color.Green;
            this.ButtonChange.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonChange.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonChange.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonChange.FlatStyle = FlatStyle.Flat;
            this.ButtonChange.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonChange.Image = A.F.ImNetWork;
            this.ButtonChange.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonChange.Location = new Point(0, 0x164);
            this.ButtonChange.Margin = new Padding(3, 4, 3, 4);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new Size(0x309, 0x2c);
            this.ButtonChange.TabIndex = 40;
            this.ButtonChange.Text = "تبديل الاتصال مغ قاعدة البيانات";
            this.ButtonChange.UseVisualStyleBackColor = false;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonExite;
            base.ClientSize = new Size(0x309, 400);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonBackUp);
            base.Controls.Add(this.ButtonExite);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ButtonChange);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "StartPointNew";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((ISupportInitialize) this.PictureBox1).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            if (((((this.CenterName.Text.Trim() == null) | (this.CenterSubName.Text.Trim() == null)) | (this.TxTUserName.Text.Trim() == null)) | (this.TxTUserLog.Text.Trim() == null)) | (this.TxTUserPass.Text.Trim() == null))
            {
                Interaction.MsgBox("ادخل الحقول الاجبارية", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO [TaNNCenters] ([CenterID], [CenterName], [CenterSubName], [CenterPhone], [CenterLocation]) VALUES (@CenterID, @CenterName, @CenterSubName, @CenterPhone, @CenterLocation)", this.A);
                    command.Parameters.AddWithValue("@CenterID", "1100");
                    command.Parameters.AddWithValue("@CenterName", this.CenterName.Text.Trim());
                    command.Parameters.AddWithValue("@CenterSubName", this.CenterSubName.Text.Trim());
                    command.Parameters.AddWithValue("@CenterPhone", this.CenterPhone.Text.Trim());
                    command.Parameters.AddWithValue("@CenterLocation", this.CenterLocation.Text.Trim());
                    SqlCommand command2 = new SqlCommand("INSERT INTO [TaNNUsers] ([CenterFrontID], [UserName], [UserLog], [UserPass], [UserIsAdmin]) VALUES (@CenterFrontID, @UserName, @UserLog, @UserPass, @UserIsAdmin)", this.A);
                    command2.Parameters.AddWithValue("@CenterFrontID", "1100");
                    command2.Parameters.AddWithValue("@UserName", this.TxTUserName.Text.Trim());
                    command2.Parameters.AddWithValue("@UserLog", this.TxTUserLog.Text.Trim());
                    command2.Parameters.AddWithValue("@UserPass", this.A.A(this.TxTUserPass.Text.Trim()));
                    command2.Parameters.AddWithValue("@UserIsAdmin", "1");
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox("تم تنفيذ الأمر بنجاح سيتم اعادة تشغيل النظام", MsgBoxStyle.ApplicationModal, null);
                    this.R();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890asdfghjklzxcvbnmqwertyuiop".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.I.ToString(), MsgBoxStyle.Exclamation, null);
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

        private void I(object A, EventArgs R)
        {
            base.TopMost = false;
            A.D.A.A.ShowDialog();
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void P(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            base.TopMost = false;
            A.D.A.A.ShowDialog();
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
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
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890asdfghjklzxcvbnmqwertyuiop".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.I.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        internal virtual Button ButtonExite
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

        internal virtual Label Label7
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTUserName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual TextBox TxTUserPass
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.R);
                TextBox r = this.R;
                if (r != null)
                {
                    r.KeyPress -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.KeyPress += handler;
                }
            }
        }

        internal virtual Label Label10
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label8
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTUserLog
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox p = this.P;
                if (p != null)
                {
                    p.KeyPress -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.KeyPress += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox CenterPhone
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox CenterLocation
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox CenterSubName
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox CenterName
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Button ButtonBackUp
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

        internal virtual Button ButtonChange
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                Button q = this.Q;
                if (q != null)
                {
                    q.Click -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.Click += handler;
                }
            }
        }
    }
}

