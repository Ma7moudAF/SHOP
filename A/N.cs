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
    public class N : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonClose")]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("RadioButton1")]
        private RadioButton A;
        [AccessedThroughProperty("RadioButton0"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RadioButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PayMony"), CompilerGenerated]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox5")]
        private GroupBox R;
        [AccessedThroughProperty("DateTimePickerDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CashNote")]
        private TextBox R;
        [AccessedThroughProperty("GroupBox3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("CashDesic"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [AccessedThroughProperty("GroupBoxUsers"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("ComboBoxUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("DateTimePickerTime"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker R;
        private SqlConnection A;

        public N()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.GroupBox7 = new GroupBox();
            this.RadioButton1 = new RadioButton();
            this.RadioButton0 = new RadioButton();
            this.PayMony = new TextBox();
            this.GroupBox5 = new GroupBox();
            this.DateTimePickerTime = new DateTimePicker();
            this.DateTimePickerDate = new DateTimePicker();
            this.GroupBox4 = new GroupBox();
            this.CashNote = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.CashDesic = new TextBox();
            this.GroupBoxUsers = new GroupBox();
            this.ComboBoxUser = new ComboBox();
            this.GroupBox7.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBoxUsers.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x19e, 0x22);
            this.TxTTitle.TabIndex = 0;
            this.TxTTitle.Text = "اضافة / سحب مبلغ خزينة من الكاش";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(4, 0x180);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(260, 0x2c);
            this.ButtonOK.TabIndex = 0x30;
            this.ButtonOK.Text = "موافق";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x111, 0x180);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x85, 0x2c);
            this.ButtonClose.TabIndex = 0x31;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.GroupBox7.Controls.Add(this.RadioButton1);
            this.GroupBox7.Controls.Add(this.RadioButton0);
            this.GroupBox7.Controls.Add(this.PayMony);
            this.GroupBox7.Location = new Point(7, 0xfb);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x195, 0x34);
            this.GroupBox7.TabIndex = 3;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "مبلغ الدفعة";
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.ForeColor = Color.Red;
            this.RadioButton1.Location = new Point(0x5d, 20);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new Size(60, 20);
            this.RadioButton1.TabIndex = 0x1ed36c5;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "سحب";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton0.AutoSize = true;
            this.RadioButton0.Checked = true;
            this.RadioButton0.ForeColor = Color.Blue;
            this.RadioButton0.Location = new Point(0x9f, 20);
            this.RadioButton0.Name = "RadioButton0";
            this.RadioButton0.Size = new Size(0x33, 20);
            this.RadioButton0.TabIndex = 0x35;
            this.RadioButton0.TabStop = true;
            this.RadioButton0.Text = "ايداع";
            this.RadioButton0.UseVisualStyleBackColor = true;
            this.PayMony.BackColor = SystemColors.Info;
            this.PayMony.Dock = DockStyle.Right;
            this.PayMony.Location = new Point(0xd8, 0x13);
            this.PayMony.MaxLength = 20;
            this.PayMony.Name = "PayMony";
            this.PayMony.RightToLeft = RightToLeft.No;
            this.PayMony.Size = new Size(0xba, 0x17);
            this.PayMony.TabIndex = 0;
            this.PayMony.TextAlign = HorizontalAlignment.Center;
            this.GroupBox5.Controls.Add(this.DateTimePickerTime);
            this.GroupBox5.Controls.Add(this.DateTimePickerDate);
            this.GroupBox5.Location = new Point(7, 0x99);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x195, 0x4f);
            this.GroupBox5.TabIndex = 2;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "التاريخ والوقت";
            this.DateTimePickerTime.CustomFormat = "hh:mm tt";
            this.DateTimePickerTime.Dock = DockStyle.Bottom;
            this.DateTimePickerTime.Format = DateTimePickerFormat.Custom;
            this.DateTimePickerTime.Location = new Point(3, 0x35);
            this.DateTimePickerTime.Name = "DateTimePickerTime";
            this.DateTimePickerTime.ShowUpDown = true;
            this.DateTimePickerTime.Size = new Size(0x18f, 0x17);
            this.DateTimePickerTime.TabIndex = 0x1ed36d5;
            this.DateTimePickerDate.CustomFormat = "";
            this.DateTimePickerDate.Dock = DockStyle.Top;
            this.DateTimePickerDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePickerDate.Format = DateTimePickerFormat.Short;
            this.DateTimePickerDate.Location = new Point(3, 0x13);
            this.DateTimePickerDate.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePickerDate.Name = "DateTimePickerDate";
            this.DateTimePickerDate.RightToLeft = RightToLeft.No;
            this.DateTimePickerDate.Size = new Size(0x18f, 0x17);
            this.DateTimePickerDate.TabIndex = 3;
            this.GroupBox4.Controls.Add(this.CashNote);
            this.GroupBox4.Location = new Point(4, 0x135);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x195, 0x44);
            this.GroupBox4.TabIndex = 4;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "ملاحظات";
            this.CashNote.BackColor = Color.White;
            this.CashNote.Dock = DockStyle.Fill;
            this.CashNote.Location = new Point(3, 0x13);
            this.CashNote.MaxLength = 0x9c4;
            this.CashNote.Multiline = true;
            this.CashNote.Name = "CashNote";
            this.CashNote.Size = new Size(0x18f, 0x2e);
            this.CashNote.TabIndex = 5;
            this.CashNote.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.CashDesic);
            this.GroupBox3.Location = new Point(7, 0x60);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x195, 0x33);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "العنوان/ الوصف";
            this.CashDesic.BackColor = Color.White;
            this.CashDesic.Dock = DockStyle.Fill;
            this.CashDesic.Location = new Point(3, 0x13);
            this.CashDesic.MaxLength = 50;
            this.CashDesic.Name = "CashDesic";
            this.CashDesic.Size = new Size(0x18f, 0x17);
            this.CashDesic.TabIndex = 2;
            this.CashDesic.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxUsers.Controls.Add(this.ComboBoxUser);
            this.GroupBoxUsers.Location = new Point(7, 0x25);
            this.GroupBoxUsers.Name = "GroupBoxUsers";
            this.GroupBoxUsers.Size = new Size(0x195, 0x35);
            this.GroupBoxUsers.TabIndex = 0x72;
            this.GroupBoxUsers.TabStop = false;
            this.GroupBoxUsers.Text = "قيد الحركة على الموظف";
            this.ComboBoxUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxUser.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxUser.Dock = DockStyle.Top;
            this.ComboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxUser.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxUser.FormattingEnabled = true;
            this.ComboBoxUser.IntegralHeight = false;
            this.ComboBoxUser.Location = new Point(3, 0x13);
            this.ComboBoxUser.Name = "ComboBoxUser";
            this.ComboBoxUser.Size = new Size(0x18f, 0x1b);
            this.ComboBoxUser.TabIndex = 0x3b;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x19e, 0x1b4);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBoxUsers);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.GroupBox7);
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CashAdd";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة / سحب مبلغ خزينة من الكاش";
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBoxUsers.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            if (PR.RQ)
            {
                this.DateTimePickerDate.Enabled = true;
                this.DateTimePickerTime.Enabled = true;
            }
            else
            {
                this.DateTimePickerDate.Enabled = false;
                this.DateTimePickerTime.Enabled = false;
            }
            this.R();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
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
            base.Dispose();
        }

        private void Q(object A, EventArgs R)
        {
        }

        public void R()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT [UserID], [UserName] FROM TaNNUsers WHERE (CenterFrontID = @CenterFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxUser.ValueMember = "UserID";
                    this.ComboBoxUser.DisplayMember = "UserName";
                    this.ComboBoxUser.DataSource = dataTable;
                    this.ComboBoxUser.SelectedIndex = -1;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, EventArgs R)
        {
            if ((this.PayMony.Text == null) | (this.ComboBoxUser.Text == null))
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    decimal num = new decimal(Conversion.Val(this.PayMony.Text.Replace(",", "")));
                    int num2 = 0;
                    if (this.RadioButton0.Checked && (decimal.Compare(num, decimal.Zero) < 0))
                    {
                        num = decimal.Multiply(num, decimal.One);
                        num2 = 0;
                    }
                    if (this.RadioButton1.Checked && (decimal.Compare(num, decimal.Zero) > 0))
                    {
                        num = decimal.Multiply(num, decimal.MinusOne);
                        num2 = 1;
                    }
                    DateTime time = Conversions.ToDate(this.DateTimePickerDate.Value.ToString("yyyy/MM/dd") + " " + this.DateTimePickerTime.Value.ToString("HH:mm"));
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO [TaNNCash] ([CenterFrontID], [CashDateTime], [CashType], [CashDesic], [CashAmont], [CashNote], [CashUserAddBy]) VALUES (@CenterFrontID, @CashDateTime, @CashType, @CashDesic, @CashAmont, @CashNote, @CashUserAddBy)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("CashDateTime", time.ToString("yyyy/MM/dd HH:mm"));
                    command.Parameters.AddWithValue("CashType", num2);
                    command.Parameters.AddWithValue("CashDesic", this.CashDesic.Text.Trim());
                    command.Parameters.AddWithValue("CashNote", this.CashNote.Text.Trim());
                    command.Parameters.AddWithValue("CashAmont", num.ToString(PR.VR));
                    command.Parameters.AddWithValue("CashUserAddBy", this.ComboBoxUser.Text);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    D.A.A.TimerLoadData.Enabled = true;
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

        internal virtual Label TxTTitle
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

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual TextBox PayMony
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox a = this.A;
                if (a != null)
                {
                    a.TextChanged -= handler;
                    a.KeyPress -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.TextChanged += handler;
                    a.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual DateTimePicker DateTimePickerDate
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox CashNote
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox CashDesic
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBoxUsers
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ComboBox ComboBoxUser
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DateTimePicker DateTimePickerTime
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

