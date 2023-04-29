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
    public class VF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("RemDetials"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("GroupBoxRem"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DateTimePickerTime"), CompilerGenerated]
        private DateTimePicker A;
        [AccessedThroughProperty("DateTimePickerDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOK"), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("CheckBoxNo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        private SqlConnection A;

        public VF()
        {
            base.Load += new EventHandler(this.R);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.GroupBox3 = new GroupBox();
            this.RemDetials = new TextBox();
            this.GroupBoxRem = new GroupBox();
            this.DateTimePickerTime = new DateTimePicker();
            this.DateTimePickerDate = new DateTimePicker();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.TxTTitle = new Label();
            this.CheckBoxNo = new CheckBox();
            this.GroupBox3.SuspendLayout();
            this.GroupBoxRem.SuspendLayout();
            base.SuspendLayout();
            this.GroupBox3.Controls.Add(this.RemDetials);
            this.GroupBox3.Location = new Point(10, 0x31);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x195, 0x89);
            this.GroupBox3.TabIndex = 0x74;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "العنوان/ الوصف";
            this.RemDetials.BackColor = SystemColors.Info;
            this.RemDetials.Dock = DockStyle.Fill;
            this.RemDetials.Location = new Point(3, 0x13);
            this.RemDetials.MaxLength = 0xbb8;
            this.RemDetials.Multiline = true;
            this.RemDetials.Name = "RemDetials";
            this.RemDetials.Size = new Size(0x18f, 0x73);
            this.RemDetials.TabIndex = 2;
            this.RemDetials.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxRem.Controls.Add(this.DateTimePickerTime);
            this.GroupBoxRem.Controls.Add(this.DateTimePickerDate);
            this.GroupBoxRem.Enabled = false;
            this.GroupBoxRem.Location = new Point(10, 0xe3);
            this.GroupBoxRem.Name = "GroupBoxRem";
            this.GroupBoxRem.Size = new Size(0x195, 0x58);
            this.GroupBoxRem.TabIndex = 0x75;
            this.GroupBoxRem.TabStop = false;
            this.GroupBoxRem.Text = "تاريخ ووقت التنبيه";
            this.DateTimePickerTime.CustomFormat = "hh tt";
            this.DateTimePickerTime.Dock = DockStyle.Bottom;
            this.DateTimePickerTime.Format = DateTimePickerFormat.Custom;
            this.DateTimePickerTime.Location = new Point(3, 0x3e);
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
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(10, 0x152);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(260, 0x2c);
            this.ButtonOK.TabIndex = 120;
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
            this.ButtonClose.Location = new Point(0x117, 0x152);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x85, 0x2c);
            this.ButtonClose.TabIndex = 0x79;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1a8, 0x22);
            this.TxTTitle.TabIndex = 0x73;
            this.TxTTitle.Text = "اضافة ملاحظة او تنبيه";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.CheckBoxNo.AutoSize = true;
            this.CheckBoxNo.Location = new Point(13, 0xc9);
            this.CheckBoxNo.Name = "CheckBoxNo";
            this.CheckBoxNo.Size = new Size(0xaf, 20);
            this.CheckBoxNo.TabIndex = 0x7a;
            this.CheckBoxNo.Text = "تفعيل المنبه لهذه الملاحظة";
            this.CheckBoxNo.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x1a8, 0x183);
            base.ControlBox = false;
            base.Controls.Add(this.CheckBoxNo);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.GroupBoxRem);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "RememberAdd";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة ملاحظة او تنبيه";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBoxRem.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.GroupBoxRem.Enabled = this.CheckBoxNo.Checked;
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
            if (this.RemDetials.Text == null)
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                DateTime time = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:00"));
                DateTime time2 = Conversions.ToDate(this.DateTimePickerDate.Value.ToString("yyyy/MM/dd") + " " + this.DateTimePickerTime.Value.ToString("HH:00"));
                if (this.CheckBoxNo.Checked && (DateTime.Compare(time, time2) >= 0))
                {
                    Interaction.MsgBox("يجب ان تحدد تاريخ وساعة اكبر من الوقت الحالي للتنبيه", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    try
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("INSERT INTO [TaNNRemember] ([CenterFrontID], [RemeDateTimeAdd], [RemeDateTimeBeeb], [RemeDatils], [RemeIsBeeb], [RemeUserAddBy]) VALUES (@CenterFrontID, @RemeDateTimeAdd, @RemeDateTimeBeeb, @RemeDatils, @RemeIsBeeb, @RemeUserAddBy)", this.A);
                        command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                        command.Parameters.AddWithValue("RemeDateTimeAdd", DateTime.Now.ToString("yyyy/MM/dd HH:mm"));
                        if (this.CheckBoxNo.Checked)
                        {
                            command.Parameters.AddWithValue("RemeDateTimeBeeb", time2.ToString("yyyy/MM/dd HH:00"));
                        }
                        else
                        {
                            command.Parameters.AddWithValue("RemeDateTimeBeeb", DBNull.Value);
                        }
                        command.Parameters.AddWithValue("RemeDatils", this.RemDetials.Text.Trim());
                        if (this.CheckBoxNo.Checked)
                        {
                            command.Parameters.AddWithValue("RemeIsBeeb", false);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("RemeIsBeeb", true);
                        }
                        command.Parameters.AddWithValue("RemeUserAddBy", D.A.A.TxTUserName.Text);
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
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void R(object A, EventArgs R)
        {
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

        internal virtual TextBox RemDetials
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBoxRem
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual DateTimePicker DateTimePickerTime
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DateTimePicker DateTimePickerDate
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonOK
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

        internal virtual CheckBox CheckBoxNo
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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
    }
}

