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
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class RT : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("SuplierNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox4")]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("SuplierPhone"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("SuplierAddress"), CompilerGenerated]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2"), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("SuplierName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3"), CompilerGenerated]
        private GroupBox P;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOK"), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("TabControl1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage2")]
        private TabPage R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1"), CompilerGenerated]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox14"), CompilerGenerated]
        private GroupBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label3")]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("SuplierEmail"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        private SqlConnection A;
        public static int A;

        public RT()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.Q);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.SuplierNote = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.Label1 = new Label();
            this.SuplierPhone = new TextBox();
            this.SuplierAddress = new TextBox();
            this.GroupBox2 = new GroupBox();
            this.SuplierName = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.GroupBox1 = new GroupBox();
            this.ButtonOK = new Button();
            this.TxTTitle = new Label();
            this.ButtonClose = new Button();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox14 = new GroupBox();
            this.Label3 = new Label();
            this.SuplierEmail = new TextBox();
            this.TabPage2 = new TabPage();
            this.GroupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.TabPage2.SuspendLayout();
            base.SuspendLayout();
            this.SuplierNote.BackColor = Color.White;
            this.SuplierNote.Dock = DockStyle.Bottom;
            this.SuplierNote.Location = new Point(3, 0x3b);
            this.SuplierNote.MaxLength = 0x9c4;
            this.SuplierNote.Multiline = true;
            this.SuplierNote.Name = "SuplierNote";
            this.SuplierNote.Size = new Size(0x199, 0xc9);
            this.SuplierNote.TabIndex = 4;
            this.SuplierNote.TextAlign = HorizontalAlignment.Center;
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.Controls.Add(this.SuplierNote);
            this.GroupBox4.Dock = DockStyle.Fill;
            this.GroupBox4.Location = new Point(3, 3);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x19f, 0x107);
            this.GroupBox4.TabIndex = 0x33;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "ملاحظات";
            this.Label1.ForeColor = SystemColors.AppWorkspace;
            this.Label1.Location = new Point(0, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x192, 0x24);
            this.Label1.TabIndex = 0x34;
            this.Label1.Text = "الرقم الضريبي: 1234\r\nالموقع الالكتروني: www.--.com";
            this.SuplierPhone.BackColor = Color.White;
            this.SuplierPhone.Dock = DockStyle.Fill;
            this.SuplierPhone.Location = new Point(3, 0x13);
            this.SuplierPhone.MaxLength = 50;
            this.SuplierPhone.Name = "SuplierPhone";
            this.SuplierPhone.RightToLeft = RightToLeft.No;
            this.SuplierPhone.Size = new Size(0x18f, 0x17);
            this.SuplierPhone.TabIndex = 2;
            this.SuplierPhone.TextAlign = HorizontalAlignment.Center;
            this.SuplierAddress.BackColor = Color.White;
            this.SuplierAddress.Dock = DockStyle.Fill;
            this.SuplierAddress.Location = new Point(3, 0x13);
            this.SuplierAddress.MaxLength = 50;
            this.SuplierAddress.Name = "SuplierAddress";
            this.SuplierAddress.Size = new Size(0x18f, 0x17);
            this.SuplierAddress.TabIndex = 1;
            this.SuplierAddress.TextAlign = HorizontalAlignment.Center;
            this.GroupBox2.Controls.Add(this.SuplierAddress);
            this.GroupBox2.Location = new Point(6, 0x47);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x195, 0x33);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "العنوان";
            this.SuplierName.BackColor = SystemColors.Info;
            this.SuplierName.Dock = DockStyle.Fill;
            this.SuplierName.Location = new Point(3, 0x13);
            this.SuplierName.MaxLength = 300;
            this.SuplierName.Name = "SuplierName";
            this.SuplierName.Size = new Size(0x18f, 0x17);
            this.SuplierName.TabIndex = 0;
            this.SuplierName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.SuplierPhone);
            this.GroupBox3.Location = new Point(6, 0x80);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x195, 0x33);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم الهاتف";
            this.GroupBox1.Controls.Add(this.SuplierName);
            this.GroupBox1.Location = new Point(6, 0x10);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x195, 0x31);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "اسم المورد";
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(0x11, 0x16b);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x10a, 0x2c);
            this.ButtonOK.TabIndex = 0x2f;
            this.ButtonOK.Text = "موافق";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1ad, 0x30);
            this.TxTTitle.TabIndex = 0x2e;
            this.TxTTitle.Text = "اضافة/ تعديل مورد";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x121, 0x16b);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x85, 0x2c);
            this.ButtonClose.TabIndex = 0x34;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x30);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(8, 8);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x1ad, 0x134);
            this.TabControl1.TabIndex = 0x35;
            this.TabPage1.Controls.Add(this.GroupBox14);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Location = new Point(4, 0x23);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x1a5, 0x10d);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "معلومات المورد";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox14.Controls.Add(this.Label3);
            this.GroupBox14.Controls.Add(this.SuplierEmail);
            this.GroupBox14.Location = new Point(6, 0xb9);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0x195, 0x47);
            this.GroupBox14.TabIndex = 3;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "البريد الالكتروني للعميل الخاص في ارسال الاشعارات";
            this.Label3.Dock = DockStyle.Bottom;
            this.Label3.ForeColor = SystemColors.ButtonShadow;
            this.Label3.Location = new Point(3, 0x2d);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x18f, 0x17);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "سيتم ارسال الفاتورة او وصل الدقع بصيغة PDF للمورد ان وجد البريد";
            this.SuplierEmail.BackColor = SystemColors.Info;
            this.SuplierEmail.Dock = DockStyle.Fill;
            this.SuplierEmail.Location = new Point(3, 0x13);
            this.SuplierEmail.MaxLength = 300;
            this.SuplierEmail.Name = "SuplierEmail";
            this.SuplierEmail.RightToLeft = RightToLeft.No;
            this.SuplierEmail.Size = new Size(0x18f, 0x17);
            this.SuplierEmail.TabIndex = 3;
            this.SuplierEmail.TextAlign = HorizontalAlignment.Center;
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Location = new Point(4, 0x23);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x1a5, 0x10d);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "تفاصيل اخرى/ ملاحظات";
            this.TabPage2.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x1ad, 0x1a0);
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SuplierAddEdit";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة/ تعديل مورد";
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox14.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonOK.PerformClick();
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
            if (Application.OpenForms.OfType<DT>().Any<DT>())
            {
                D.A.A.TimerLoadData.Enabled = true;
            }
            base.Dispose();
        }

        private void Q(object A, EventArgs R)
        {
            this.SuplierName.Focus();
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            try
            {
                int num = 0;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string cmdText = "";
                cmdText = (RT.A <= 0) ? "INSERT INTO TaNNSupliers(CenterFrontID, SuplierName, SuplierPhone, SuplierAddress, SuplierNote, SuplierDateConfigur, SuplierUserAddBy, SuplierEmail) VALUES (@CenterFrontID, @SuplierName, @SuplierPhone, @SuplierAddress, @SuplierNote, @SuplierDateConfigur, @SuplierUserAddBy, @SuplierEmail); SELECT SuplierID FROM TaNNSupliers WHERE (SuplierID = SCOPE_IDENTITY())" : "UPDATE [TaNNSupliers] SET [SuplierName] = @SuplierName, [SuplierPhone] = @SuplierPhone, [SuplierAddress] = @SuplierAddress, [SuplierNote] = @SuplierNote, [SuplierDateConfigur] = @SuplierDateConfigur, [SuplierUserAddBy] = @SuplierUserAddBy, [SuplierEmail] = @SuplierEmail WHERE [SuplierID] = @SuplierID";
                SqlCommand command = new SqlCommand(cmdText, this.A);
                command.Parameters.AddWithValue("SuplierID", RT.A);
                command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                command.Parameters.AddWithValue("SuplierName", this.SuplierName.Text.Trim());
                command.Parameters.AddWithValue("SuplierAddress", this.SuplierAddress.Text.Trim());
                command.Parameters.AddWithValue("SuplierPhone", this.SuplierPhone.Text.Trim());
                command.Parameters.AddWithValue("SuplierNote", this.SuplierNote.Text.Trim());
                command.Parameters.AddWithValue("SuplierDateConfigur", DateTime.Now.ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("SuplierUserAddBy", D.A.A.TxTUserName.Text);
                command.Parameters.AddWithValue("SuplierEmail", this.SuplierEmail.Text.Trim());
                num = Conversions.ToInteger(command.ExecuteScalar());
                this.A.Close();
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                if (Application.OpenForms.OfType<XD>().Any<XD>())
                {
                    D.A.A.R();
                    D.A.A.ComboBoxSuplier.SelectedValue = num;
                    base.Dispose();
                }
                if (RT.A == 0)
                {
                    this.SuplierName.Text = null;
                    this.SuplierPhone.Text = null;
                    this.SuplierAddress.Text = null;
                    this.SuplierNote.Text = null;
                    this.SuplierEmail.Text = null;
                    this.SuplierName.Focus();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                Interaction.MsgBox("خطأ في عملية الحفظ، قد يكون السبب في تكرار اسم المورد", MsgBoxStyle.ApplicationModal, null);
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        internal virtual TextBox SuplierNote
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox SuplierPhone
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox SuplierAddress
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual TextBox SuplierName
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonOK
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                Button a = this.A;
                if (a != null)
                {
                    a.Click -= handler;
                    a.KeyPress -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Click += handler;
                    a.KeyPress += handler2;
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

        internal virtual Button ButtonClose
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

        internal virtual TabControl TabControl1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual TextBox SuplierEmail
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }
    }
}

