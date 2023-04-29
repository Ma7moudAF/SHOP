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
    public class WI : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("PayMony"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DateTimePicker")]
        private System.Windows.Forms.DateTimePicker A;
        [AccessedThroughProperty("CheckBoxCash"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox4")]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("PayNote")]
        private TextBox R;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ComboBoxExTitle")]
        private ComboBox A;
        [AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        private SqlConnection A;

        public WI()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.GroupBox7 = new GroupBox();
            this.PayMony = new TextBox();
            this.GroupBox5 = new GroupBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckBoxCash = new CheckBox();
            this.GroupBox4 = new GroupBox();
            this.PayNote = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.ComboBoxExTitle = new ComboBox();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.TxTTitle = new Label();
            this.GroupBox7.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.GroupBox7.Controls.Add(this.PayMony);
            this.GroupBox7.Location = new Point(15, 0x9e);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x195, 0x34);
            this.GroupBox7.TabIndex = 0x35;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "المبلغ";
            this.PayMony.BackColor = SystemColors.Info;
            this.PayMony.Dock = DockStyle.Fill;
            this.PayMony.Location = new Point(3, 0x13);
            this.PayMony.MaxLength = 20;
            this.PayMony.Name = "PayMony";
            this.PayMony.RightToLeft = RightToLeft.No;
            this.PayMony.Size = new Size(0x18f, 0x17);
            this.PayMony.TabIndex = 0;
            this.PayMony.TextAlign = HorizontalAlignment.Center;
            this.GroupBox5.Controls.Add(this.DateTimePicker);
            this.GroupBox5.Location = new Point(15, 0x5c);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x195, 0x33);
            this.GroupBox5.TabIndex = 0x39;
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
            this.DateTimePicker.Size = new Size(0x18f, 0x17);
            this.DateTimePicker.TabIndex = 3;
            this.CheckBoxCash.AutoSize = true;
            this.CheckBoxCash.Checked = true;
            this.CheckBoxCash.CheckState = CheckState.Checked;
            this.CheckBoxCash.Location = new Point(15, 0x132);
            this.CheckBoxCash.Name = "CheckBoxCash";
            this.CheckBoxCash.Size = new Size(200, 20);
            this.CheckBoxCash.TabIndex = 0x3e;
            this.CheckBoxCash.Text = "قيد وتسجيل الحركة على الكاش";
            this.CheckBoxCash.UseVisualStyleBackColor = true;
            this.GroupBox4.Controls.Add(this.PayNote);
            this.GroupBox4.Location = new Point(15, 0xe1);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x195, 0x44);
            this.GroupBox4.TabIndex = 0x3a;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "ملاحظات";
            this.PayNote.BackColor = Color.White;
            this.PayNote.Dock = DockStyle.Fill;
            this.PayNote.Location = new Point(3, 0x13);
            this.PayNote.MaxLength = 0x9c4;
            this.PayNote.Multiline = true;
            this.PayNote.Name = "PayNote";
            this.PayNote.Size = new Size(0x18f, 0x2e);
            this.PayNote.TabIndex = 5;
            this.PayNote.TextAlign = HorizontalAlignment.Center;
            this.GroupBox1.Controls.Add(this.ComboBoxExTitle);
            this.GroupBox1.Location = new Point(15, 0x25);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x195, 0x31);
            this.GroupBox1.TabIndex = 0x36;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "العنوان/الوصف";
            this.ComboBoxExTitle.BackColor = SystemColors.Info;
            this.ComboBoxExTitle.Dock = DockStyle.Fill;
            this.ComboBoxExTitle.FormattingEnabled = true;
            object[] items = new object[9];
            items[0] = "اجور شحن";
            items[1] = "اجور مخازن";
            items[2] = "وجبة فطور";
            items[3] = "وجبة غداء";
            items[4] = "وجبة عشاء";
            items[5] = "فاتورة كهرباء";
            items[6] = "فاتورة مياه";
            items[7] = "رواتب";
            items[8] = "اخرى، اكتب اي شيء";
            this.ComboBoxExTitle.Items.AddRange(items);
            this.ComboBoxExTitle.Location = new Point(3, 0x13);
            this.ComboBoxExTitle.MaxLength = 300;
            this.ComboBoxExTitle.Name = "ComboBoxExTitle";
            this.ComboBoxExTitle.Size = new Size(0x18f, 0x18);
            this.ComboBoxExTitle.TabIndex = 0;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(15, 0x151);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x10a, 0x2c);
            this.ButtonOK.TabIndex = 0x3b;
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
            this.ButtonClose.Location = new Point(0x11f, 0x151);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x85, 0x2c);
            this.ButtonClose.TabIndex = 60;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1ac, 0x22);
            this.TxTTitle.TabIndex = 110;
            this.TxTTitle.Text = "اضافة مصروفات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x1ac, 0x18e);
            base.ControlBox = false;
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.GroupBox7);
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.CheckBoxCash);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ExpensesAdd";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة مصروفات";
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
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

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void R(object A, EventArgs R)
        {
            if ((this.PayMony.Text == null) | (this.ComboBoxExTitle.Text == null))
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                decimal num = new decimal(Conversion.Val(this.PayMony.Text.Replace(",", "")));
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO [TaNNExpenses] ([CenterFrontID], [ExDate], [ExTitle], [ExMoney], [ExNote], [ExUserAddBy], [ExIsCashCount]) VALUES (@CenterFrontID, @ExDate, @ExTitle, @ExMoney, @ExNote, @ExUserAddBy, @ExIsCashCount)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("ExDate", this.DateTimePicker.Value.ToString("yyyy/MM/dd HH:mm"));
                    command.Parameters.AddWithValue("ExTitle", this.ComboBoxExTitle.Text);
                    command.Parameters.AddWithValue("ExMoney", num.ToString(PR.VR));
                    command.Parameters.AddWithValue("ExNote", this.PayNote.Text);
                    command.Parameters.AddWithValue("ExUserAddBy", D.A.A.TxTUserName.Text);
                    command.Parameters.AddWithValue("ExIsCashCount", this.CheckBoxCash.Checked);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    if (Application.OpenForms.OfType<AD>().Any<AD>())
                    {
                        D.A.A.TimerLoadData.Enabled = true;
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

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox PayMony
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual System.Windows.Forms.DateTimePicker DateTimePicker
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox PayNote
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual ComboBox ComboBoxExTitle
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
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }
    }
}

