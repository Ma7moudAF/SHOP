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
    public class BI : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("PayNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3")]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerPhone"), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("GroupBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("CustomerAddress"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1")]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerName"), CompilerGenerated]
        private TextBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOK")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose"), CompilerGenerated]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxCash")]
        private CheckBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox5")]
        private GroupBox I;
        [CompilerGenerated, AccessedThroughProperty("DateTimePicker"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private System.Windows.Forms.DateTimePicker A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxPrint")]
        private CheckBox R;
        [AccessedThroughProperty("GroupBox6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("CustomerBalance"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox7"), CompilerGenerated]
        private GroupBox F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PayMony"), CompilerGenerated]
        private TextBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonCurr")]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("RadioButton1"), CompilerGenerated]
        private RadioButton A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("RadioButton0")]
        private RadioButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxEmailSend"), CompilerGenerated]
        private CheckBox P;
        [AccessedThroughProperty("ComboBoxSize"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [AccessedThroughProperty("CheckBoxWats"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox Q;
        private SqlConnection A;
        public static int A;
        private TextBox D;
        private int R;

        public BI()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.F);
            base.KeyUp += new KeyEventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.D = new TextBox();
            this.R = 0;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.GroupBox4 = new GroupBox();
            this.PayNote = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.CustomerPhone = new TextBox();
            this.GroupBox2 = new GroupBox();
            this.CustomerAddress = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.CustomerName = new TextBox();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.CheckBoxCash = new CheckBox();
            this.GroupBox5 = new GroupBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckBoxPrint = new CheckBox();
            this.GroupBox6 = new GroupBox();
            this.CustomerBalance = new Label();
            this.GroupBox7 = new GroupBox();
            this.RadioButton1 = new RadioButton();
            this.RadioButton0 = new RadioButton();
            this.ButtonCurr = new Button();
            this.PayMony = new TextBox();
            this.CheckBoxEmailSend = new CheckBox();
            this.ComboBoxSize = new ComboBox();
            this.CheckBoxWats = new CheckBox();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x2c3, 0x22);
            this.TxTTitle.TabIndex = 30;
            this.TxTTitle.Text = "اضافة/سحب دفعة لحساب العميل";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox4.Controls.Add(this.PayNote);
            this.GroupBox4.Location = new Point(0x165, 0xb5);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x153, 0x4f);
            this.GroupBox4.TabIndex = 5;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "ملاحظات الدفعة";
            this.PayNote.BackColor = Color.White;
            this.PayNote.Dock = DockStyle.Fill;
            this.PayNote.Location = new Point(3, 0x13);
            this.PayNote.MaxLength = 0x9c4;
            this.PayNote.Multiline = true;
            this.PayNote.Name = "PayNote";
            this.PayNote.Size = new Size(0x14d, 0x39);
            this.PayNote.TabIndex = 5;
            this.PayNote.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.CustomerPhone);
            this.GroupBox3.Location = new Point(12, 0x98);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x153, 0x33);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم الهاتف";
            this.CustomerPhone.BackColor = Color.White;
            this.CustomerPhone.Dock = DockStyle.Fill;
            this.CustomerPhone.Location = new Point(3, 0x13);
            this.CustomerPhone.MaxLength = 50;
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.RightToLeft = RightToLeft.No;
            this.CustomerPhone.Size = new Size(0x14d, 0x17);
            this.CustomerPhone.TabIndex = 2;
            this.CustomerPhone.TextAlign = HorizontalAlignment.Center;
            this.GroupBox2.Controls.Add(this.CustomerAddress);
            this.GroupBox2.Location = new Point(12, 0x5f);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x153, 0x33);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "العنوان";
            this.CustomerAddress.BackColor = Color.White;
            this.CustomerAddress.Dock = DockStyle.Fill;
            this.CustomerAddress.Location = new Point(3, 0x13);
            this.CustomerAddress.MaxLength = 50;
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new Size(0x14d, 0x17);
            this.CustomerAddress.TabIndex = 1;
            this.CustomerAddress.TextAlign = HorizontalAlignment.Center;
            this.GroupBox1.Controls.Add(this.CustomerName);
            this.GroupBox1.Location = new Point(12, 40);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x153, 0x31);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "اسم العميل";
            this.CustomerName.BackColor = SystemColors.Info;
            this.CustomerName.Dock = DockStyle.Fill;
            this.CustomerName.Enabled = false;
            this.CustomerName.Location = new Point(3, 0x13);
            this.CustomerName.MaxLength = 50;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new Size(0x14d, 0x17);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.TextAlign = HorizontalAlignment.Center;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(0x165, 0x11a);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x152, 0x2c);
            this.ButtonOK.TabIndex = 0x2e;
            this.ButtonOK.Text = "موافق";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x165, 0x150);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x150, 0x2c);
            this.ButtonClose.TabIndex = 0x2f;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.CheckBoxCash.AutoSize = true;
            this.CheckBoxCash.Checked = true;
            this.CheckBoxCash.CheckState = CheckState.Checked;
            this.CheckBoxCash.Location = new Point(15, 280);
            this.CheckBoxCash.Name = "CheckBoxCash";
            this.CheckBoxCash.Size = new Size(200, 20);
            this.CheckBoxCash.TabIndex = 0x33;
            this.CheckBoxCash.Text = "قيد وتسجيل الحركة على الكاش";
            this.CheckBoxCash.UseVisualStyleBackColor = true;
            this.GroupBox5.Controls.Add(this.DateTimePicker);
            this.GroupBox5.Location = new Point(0x165, 40);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x153, 0x33);
            this.GroupBox5.TabIndex = 3;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "التاريخ";
            this.DateTimePicker.CustomFormat = "";
            this.DateTimePicker.Dock = DockStyle.Bottom;
            this.DateTimePicker.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePicker.Format = DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new Point(3, 0x19);
            this.DateTimePicker.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.RightToLeft = RightToLeft.No;
            this.DateTimePicker.Size = new Size(0x14d, 0x17);
            this.DateTimePicker.TabIndex = 3;
            this.CheckBoxPrint.AutoSize = true;
            this.CheckBoxPrint.Checked = true;
            this.CheckBoxPrint.CheckState = CheckState.Checked;
            this.CheckBoxPrint.Location = new Point(15, 0x166);
            this.CheckBoxPrint.Name = "CheckBoxPrint";
            this.CheckBoxPrint.Size = new Size(0x58, 20);
            this.CheckBoxPrint.TabIndex = 0x34;
            this.CheckBoxPrint.Text = "طباعة وصل";
            this.CheckBoxPrint.UseVisualStyleBackColor = true;
            this.GroupBox6.Controls.Add(this.CustomerBalance);
            this.GroupBox6.Location = new Point(12, 0xd1);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x153, 0x33);
            this.GroupBox6.TabIndex = 50;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "الرصيد الحالي";
            this.CustomerBalance.Dock = DockStyle.Fill;
            this.CustomerBalance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CustomerBalance.Location = new Point(3, 0x13);
            this.CustomerBalance.Name = "CustomerBalance";
            this.CustomerBalance.RightToLeft = RightToLeft.No;
            this.CustomerBalance.Size = new Size(0x14d, 0x1d);
            this.CustomerBalance.TabIndex = 0;
            this.CustomerBalance.Text = "0";
            this.CustomerBalance.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox7.Controls.Add(this.RadioButton1);
            this.GroupBox7.Controls.Add(this.RadioButton0);
            this.GroupBox7.Controls.Add(this.ButtonCurr);
            this.GroupBox7.Controls.Add(this.PayMony);
            this.GroupBox7.Location = new Point(0x169, 0x61);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x14c, 0x4e);
            this.GroupBox7.TabIndex = 0;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "مبلغ الدفعة";
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.ForeColor = Color.Red;
            this.RadioButton1.Location = new Point(0x71, 0x2f);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new Size(60, 20);
            this.RadioButton1.TabIndex = 0x1ed36c5;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "سحب";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton0.AutoSize = true;
            this.RadioButton0.Checked = true;
            this.RadioButton0.ForeColor = Color.Blue;
            this.RadioButton0.Location = new Point(0x54, 0x15);
            this.RadioButton0.Name = "RadioButton0";
            this.RadioButton0.Size = new Size(0x59, 20);
            this.RadioButton0.TabIndex = 0x35;
            this.RadioButton0.TabStop = true;
            this.RadioButton0.Text = "سداد/ ايداع";
            this.RadioButton0.UseVisualStyleBackColor = true;
            this.ButtonCurr.BackColor = Color.WhiteSmoke;
            this.ButtonCurr.FlatAppearance.BorderColor = Color.Green;
            this.ButtonCurr.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonCurr.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonCurr.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonCurr.FlatStyle = FlatStyle.Flat;
            this.ButtonCurr.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonCurr.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCurr.Location = new Point(6, 0x1b);
            this.ButtonCurr.Margin = new Padding(3, 4, 3, 4);
            this.ButtonCurr.Name = "ButtonCurr";
            this.ButtonCurr.Size = new Size(0x42, 30);
            this.ButtonCurr.TabIndex = 0x1ed36c4;
            this.ButtonCurr.Text = "عملات";
            this.ButtonCurr.UseVisualStyleBackColor = false;
            this.PayMony.BackColor = SystemColors.Info;
            this.PayMony.Location = new Point(180, 0x1f);
            this.PayMony.MaxLength = 20;
            this.PayMony.Name = "PayMony";
            this.PayMony.RightToLeft = RightToLeft.No;
            this.PayMony.Size = new Size(0x92, 0x17);
            this.PayMony.TabIndex = 0;
            this.PayMony.TextAlign = HorizontalAlignment.Center;
            this.CheckBoxEmailSend.AutoSize = true;
            this.CheckBoxEmailSend.Location = new Point(15, 0x132);
            this.CheckBoxEmailSend.Name = "CheckBoxEmailSend";
            this.CheckBoxEmailSend.Size = new Size(0xfb, 20);
            this.CheckBoxEmailSend.TabIndex = 0x5fe;
            this.CheckBoxEmailSend.Text = "ارسال اشعار بريد الكتروني للعميل ان وجد";
            this.CheckBoxEmailSend.UseVisualStyleBackColor = true;
            this.ComboBoxSize.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxSize.FormattingEnabled = true;
            object[] items = new object[] { "ورق قياس A4", "ورق قياس 80 حراري" };
            this.ComboBoxSize.Items.AddRange(items);
            this.ComboBoxSize.Location = new Point(0x6d, 0x164);
            this.ComboBoxSize.Name = "ComboBoxSize";
            this.ComboBoxSize.Size = new Size(0xd4, 0x18);
            this.ComboBoxSize.TabIndex = 0x5ff;
            this.CheckBoxWats.AutoSize = true;
            this.CheckBoxWats.Location = new Point(15, 0x14c);
            this.CheckBoxWats.Name = "CheckBoxWats";
            this.CheckBoxWats.Size = new Size(0xde, 20);
            this.CheckBoxWats.TabIndex = 0x600;
            this.CheckBoxWats.Text = "ارسال اشعار واتساب للعميل ان وجد";
            this.CheckBoxWats.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x2c3, 0x18c);
            base.ControlBox = false;
            base.Controls.Add(this.CheckBoxWats);
            base.Controls.Add(this.ComboBoxSize);
            base.Controls.Add(this.CheckBoxEmailSend);
            base.Controls.Add(this.GroupBox7);
            base.Controls.Add(this.GroupBox6);
            base.Controls.Add(this.CheckBoxPrint);
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.CheckBoxCash);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CustomerAddPays";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة/سحب دفعة لحساب العميل";
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.ComboBoxSize.SelectedIndex = 0;
            if (PR.JP)
            {
                this.CheckBoxCash.Enabled = true;
                this.CheckBoxCash.Checked = true;
            }
            else
            {
                this.CheckBoxCash.Enabled = false;
                this.CheckBoxCash.Checked = true;
            }
            this.DateTimePicker.Enabled = PR.RQ;
            this.CheckBoxEmailSend.Checked = AR.IR;
            this.CheckBoxWats.Checked = AR.ER;
            if (!this.CheckBoxPrint.Checked)
            {
                this.CheckBoxEmailSend.Checked = false;
            }
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT * FROM TaNNCustomers WHERE (CustomerID = @CustomerID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CustomerID", BI.A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.CustomerName.Text = dataTable.Rows[0]["CustomerName"].ToString();
                    this.CustomerAddress.Text = dataTable.Rows[0]["CustomerAddress"].ToString();
                    this.CustomerPhone.Text = dataTable.Rows[0]["CustomerPhone"].ToString();
                    this.CustomerBalance.Text = dataTable.Rows[0]["CustomerBalance"].ToString();
                    this.D.Text = dataTable.Rows[0]["CustomerEmail"].ToString();
                }
                this.CustomerBalance.Text = new decimal(Conversion.Val(this.CustomerBalance.Text.Replace(",", ""))).ToString(PR.YR);
                this.PayMony.Focus();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
                ProjectData.ClearProjectError();
            }
        }

        private void A(object A, KeyEventArgs R)
        {
            if (R.KeyCode == Keys.F1)
            {
                W.A();
            }
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void D(object A, EventArgs R)
        {
            AR.IR = this.CheckBoxEmailSend.Checked;
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
            if (PR.V)
            {
                base.Dispose();
            }
        }

        private void H(object A, EventArgs R)
        {
            AR.ER = this.CheckBoxWats.Checked;
        }

        private void I(object A, EventArgs R)
        {
            if (this.CheckBoxPrint.Checked)
            {
                this.CheckBoxEmailSend.Enabled = true;
            }
            else
            {
                this.CheckBoxEmailSend.Checked = false;
                this.CheckBoxEmailSend.Enabled = false;
            }
        }

        private void P(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void Q(object A, EventArgs R)
        {
            A.D.A.A.TxTMaster.Text = this.PayMony.Text;
            A.D.A.A.Show();
        }

        private void R(object A, EventArgs R)
        {
            this.ButtonOK.Enabled = false;
            if (this.R == 0)
            {
                if (this.PayMony.Text == null)
                {
                    Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.ButtonOK.Enabled = true;
                    this.PayMony.Focus();
                }
                else
                {
                    try
                    {
                        decimal num = new decimal(Conversion.Val(this.PayMony.Text.Replace(",", "")));
                        decimal num2 = new decimal(Conversion.Val(this.CustomerBalance.Text.Replace(",", "")));
                        if (this.RadioButton0.Checked && (decimal.Compare(num, decimal.Zero) < 0))
                        {
                            num = decimal.Multiply(num, decimal.One);
                        }
                        if (this.RadioButton1.Checked && (decimal.Compare(num, decimal.Zero) > 0))
                        {
                            num = decimal.Multiply(num, decimal.MinusOne);
                        }
                        decimal num3 = decimal.Add(num2, num);
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNCustomers] SET [CustomerPhone] = @CustomerPhone, [CustomerAddress] = @CustomerAddress, [CustomerDateConfigur] = @CustomerDateConfigur, [CustomerBalance] = @CustomerBalance, [CustomerUserAddBy] = @CustomerUserAddBy WHERE [CustomerID] = @CustomerID", this.A);
                        command.Parameters.AddWithValue("CustomerID", BI.A);
                        command.Parameters.AddWithValue("CustomerAddress", this.CustomerAddress.Text.Trim());
                        command.Parameters.AddWithValue("CustomerPhone", this.CustomerPhone.Text.Trim());
                        command.Parameters.AddWithValue("CustomerBalance", num3.ToString(PR.VR));
                        command.Parameters.AddWithValue("CustomerDateConfigur", DateTime.Now.ToString("yyyy/MM/dd"));
                        command.Parameters.AddWithValue("CustomerUserAddBy", A.D.A.A.TxTUserName.Text);
                        command.ExecuteNonQuery();
                        this.A.Close();
                        int num4 = 500;
                        string str2 = "";
                        if (this.RadioButton0.Checked)
                        {
                            str2 = "حركة مضافة ايداع";
                        }
                        if (this.RadioButton1.Checked)
                        {
                            str2 = "حركة مضافة سحب";
                        }
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command2 = new SqlCommand("INSERT INTO [TaNNCustomersPay] ([CenterFrontID], [CustomerFrontID], [InvSaleIDFront], [PayType], [PayDateTimer], [PayDesic], [PayMony], [PayEmploy], [PayNote], [PayIsCashCount]) VALUES (@CenterFrontID, @CustomerFrontID, @InvSaleIDFront, @PayType, @PayDateTimer, @PayDesic, @PayMony, @PayEmploy, @PayNote, @PayIsCashCount); SELECT CustomerPayID FROM TaNNCustomersPay WHERE (CustomerPayID = SCOPE_IDENTITY())", this.A);
                        command2.Parameters.AddWithValue("CenterFrontID", PR.GR);
                        command2.Parameters.AddWithValue("InvSaleIDFront", "0");
                        command2.Parameters.AddWithValue("CustomerFrontID", BI.A);
                        command2.Parameters.AddWithValue("PayType", num4);
                        command2.Parameters.AddWithValue("PayDateTimer", this.DateTimePicker.Value.ToString("yyyy/MM/dd HH:mm"));
                        command2.Parameters.AddWithValue("PayDesic", str2.ToString());
                        command2.Parameters.AddWithValue("PayMony", num.ToString(PR.VR));
                        command2.Parameters.AddWithValue("PayNote", this.PayNote.Text);
                        command2.Parameters.AddWithValue("PayEmploy", A.D.A.A.TxTUserName.Text);
                        command2.Parameters.AddWithValue("PayIsCashCount", this.CheckBoxCash.Checked);
                        this.R = Conversions.ToInteger(command2.ExecuteScalar());
                        this.A.Close();
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        if ((this.D.Text != null) & this.CheckBoxEmailSend.Checked)
                        {
                            decimal num5 = new decimal(Conversion.Val(num3.ToString().Replace(",", "")));
                            string str4 = this.CustomerName.Text.Trim();
                            PR.HR = this.D.Text;
                            PR.TR = "Notice Receipt";
                            string[] textArray1 = new string[11];
                            textArray1[0] = str4.ToString();
                            textArray1[1] = " A transaction has been credited to your account ";
                            textArray1[2] = str2.ToString();
                            textArray1[3] = " ";
                            textArray1[4] = num.ToString(PR.VR);
                            textArray1[5] = " Date ";
                            textArray1[6] = this.DateTimePicker.Value.ToString("yyyy/MM/dd HH:mm");
                            textArray1[7] = " To be your balance ";
                            textArray1[8] = num5.ToString(PR.VR);
                            textArray1[9] = " Thank you ";
                            textArray1[10] = PR.ER.ToString();
                            PR.XR = string.Concat(textArray1);
                            A.D.A.A.Show();
                        }
                        if (this.CheckBoxPrint.Checked)
                        {
                            FR.A = BI.A;
                            FR.R = this.R;
                            if (this.ComboBoxSize.SelectedIndex == 0)
                            {
                                A.D.A.A.P();
                            }
                            else if (this.ComboBoxSize.SelectedIndex == 1)
                            {
                                A.D.A.A.Q();
                            }
                        }
                        if (this.CheckBoxWats.Checked)
                        {
                            decimal num6 = new decimal(Conversion.Val(num3.ToString().Replace(",", "")));
                            string str6 = this.CustomerName.Text.Trim();
                            string[] textArray2 = new string[11];
                            textArray2[0] = str6.ToString();
                            textArray2[1] = " تم قيد حركة في حسابكم ";
                            textArray2[2] = str2.ToString();
                            textArray2[3] = " ";
                            textArray2[4] = num.ToString(PR.VR);
                            textArray2[5] = " بتاريخ ";
                            textArray2[6] = this.DateTimePicker.Value.ToString("yyyy/MM/dd HH:mm");
                            textArray2[7] = " ليصبح رصيدكم ";
                            textArray2[8] = num6.ToString(PR.VR);
                            textArray2[9] = " شكرا لك ";
                            textArray2[10] = PR.ER.ToString();
                            string str7 = string.Concat(textArray2);
                            GT.A = this.CustomerPhone.Text.Trim().ToString();
                            GT.R = str7.ToString();
                            A.D.A.A.R();
                        }
                        if (Application.OpenForms.OfType<SI>().Any<SI>())
                        {
                            A.D.A.A.TimerLoadData.Enabled = true;
                            base.Dispose();
                        }
                        base.Dispose();
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox PayNote
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox CustomerPhone
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox CustomerAddress
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

        internal virtual TextBox CustomerName
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

        internal virtual CheckBox CheckBoxCash
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual System.Windows.Forms.DateTimePicker DateTimePicker
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxPrint
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label CustomerBalance
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox PayMony
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox i = this.I;
                if (i != null)
                {
                    i.KeyPress -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.KeyPress += handler;
                }
            }
        }

        internal virtual Button ButtonCurr
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

        internal virtual RadioButton RadioButton1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual RadioButton RadioButton0
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual CheckBox CheckBoxEmailSend
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                CheckBox p = this.P;
                if (p != null)
                {
                    p.CheckedChanged -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.CheckedChanged += handler;
                }
            }
        }

        internal virtual ComboBox ComboBoxSize
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxWats
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                CheckBox q = this.Q;
                if (q != null)
                {
                    q.CheckedChanged -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.CheckedChanged += handler;
                }
            }
        }
    }
}

