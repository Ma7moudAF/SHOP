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
    public class XF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("TxTNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("TxTQMove"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("GropDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox P;
        [AccessedThroughProperty("DateTimePicker"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private System.Windows.Forms.DateTimePicker A;
        [AccessedThroughProperty("MaterialName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("MaterialQuantity"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        private SqlConnection A;
        public static int A;
        private TextBox Q;
        private TextBox I;
        private TextBox D;
        private TextBox F;

        public XF()
        {
            base.Load += new EventHandler(this.R);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.Q = new TextBox();
            this.I = new TextBox();
            this.D = new TextBox();
            this.F = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.ButtonOK = new Button();
            this.ButtonFinish = new Button();
            this.GroupBox4 = new GroupBox();
            this.TxTNote = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.TxTQMove = new TextBox();
            this.GropDate = new GroupBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MaterialName = new Label();
            this.GroupBox5 = new GroupBox();
            this.MaterialQuantity = new TextBox();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GropDate.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(670, 0x22);
            this.TxTTitle.TabIndex = 30;
            this.TxTTitle.Text = "اضافة حركة اتلاف كمية";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(9, 0x182);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x1f1, 0x2c);
            this.ButtonOK.TabIndex = 0x20;
            this.ButtonOK.Text = "موافق";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonFinish.DialogResult = DialogResult.Cancel;
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = A.F.ImFinish;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(0x200, 0x182);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x94, 0x2c);
            this.ButtonFinish.TabIndex = 0x21;
            this.ButtonFinish.Text = "انهاء";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.GroupBox4.Controls.Add(this.TxTNote);
            this.GroupBox4.Location = new Point(12, 0x105);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x28b, 0x6b);
            this.GroupBox4.TabIndex = 0x888926;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "اضافة ملاحظة على الحركات والمادة، مثلا رقم المستند:";
            this.TxTNote.BackColor = SystemColors.Info;
            this.TxTNote.Location = new Point(6, 0x16);
            this.TxTNote.MaxLength = 300;
            this.TxTNote.Multiline = true;
            this.TxTNote.Name = "TxTNote";
            this.TxTNote.RightToLeft = RightToLeft.No;
            this.TxTNote.Size = new Size(0x27f, 0x4f);
            this.TxTNote.TabIndex = 1;
            this.TxTNote.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.TxTQMove);
            this.GroupBox3.Location = new Point(12, 200);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x28b, 0x37);
            this.GroupBox3.TabIndex = 0x888925;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الكمية المطلوب اتلافها:";
            this.TxTQMove.BackColor = SystemColors.Info;
            this.TxTQMove.Location = new Point(6, 0x16);
            this.TxTQMove.MaxLength = 20;
            this.TxTQMove.Name = "TxTQMove";
            this.TxTQMove.RightToLeft = RightToLeft.No;
            this.TxTQMove.Size = new Size(0x27f, 0x17);
            this.TxTQMove.TabIndex = 1;
            this.TxTQMove.TextAlign = HorizontalAlignment.Center;
            this.GropDate.Controls.Add(this.DateTimePicker);
            this.GropDate.Location = new Point(12, 0x4f);
            this.GropDate.Name = "GropDate";
            this.GropDate.Size = new Size(0x28b, 50);
            this.GropDate.TabIndex = 0x888927;
            this.GropDate.TabStop = false;
            this.GropDate.Text = "التاريخ";
            this.DateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DateTimePicker.Dock = DockStyle.Fill;
            this.DateTimePicker.Format = DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new Point(3, 0x13);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.RightToLeft = RightToLeft.No;
            this.DateTimePicker.Size = new Size(0x285, 0x17);
            this.DateTimePicker.TabIndex = 2;
            this.MaterialName.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.MaterialName.Location = new Point(9, 0x22);
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Size = new Size(0x28e, 0x2a);
            this.MaterialName.TabIndex = 0x888928;
            this.MaterialName.Text = "---";
            this.MaterialName.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox5.Controls.Add(this.MaterialQuantity);
            this.GroupBox5.Location = new Point(12, 0x87);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x28b, 0x37);
            this.GroupBox5.TabIndex = 0x888929;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "الكمية الحالية:";
            this.MaterialQuantity.BackColor = SystemColors.Info;
            this.MaterialQuantity.Dock = DockStyle.Fill;
            this.MaterialQuantity.Enabled = false;
            this.MaterialQuantity.Location = new Point(3, 0x13);
            this.MaterialQuantity.MaxLength = 20;
            this.MaterialQuantity.Name = "MaterialQuantity";
            this.MaterialQuantity.RightToLeft = RightToLeft.No;
            this.MaterialQuantity.Size = new Size(0x285, 0x17);
            this.MaterialQuantity.TabIndex = 0x3880;
            this.MaterialQuantity.TextAlign = HorizontalAlignment.Center;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonFinish;
            base.ClientSize = new Size(670, 0x1b6);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.MaterialName);
            base.Controls.Add(this.GropDate);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialTransferDestroyAddD";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة حركة اتلاف كمية";
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GropDate.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
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

        public void P()
        {
            try
            {
                decimal num = new decimal(Conversion.Val(this.TxTQMove.Text.Replace(",", "")));
                decimal num2 = new decimal(Conversion.Val(this.MaterialQuantity.Text.Replace(",", "")));
                if (decimal.Compare(num, num2) > 0)
                {
                    Interaction.MsgBox("الكمية المطلوب اتلافها اكبر من الكمية الموجودة في المستودع", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    decimal num3 = decimal.Subtract(num2, num);
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                    command.Parameters.AddWithValue("MaterialID", this.Q.Text);
                    command.Parameters.AddWithValue("MaterialQuantity", num3.ToString(PR.OR));
                    command.ExecuteNonQuery();
                    this.A.Close();
                    decimal num4 = new decimal(Conversion.Val(this.F.Text.Replace(",", "")));
                    decimal num5 = decimal.Multiply(num4, num);
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command2 = new SqlCommand("INSERT INTO [TaNNMaterialTrDs] ([CenterFrontID], [TrDsType], [TrDsDateTime], [TrDsBarCode], [TrDsName], [TrDsUnit], [TrDsPrice], [TrDsQuantity], [TrDsPriceTotal], [TrDsNote], [TrDsUserAddBy]) VALUES (@CenterFrontID, @TrDsType, @TrDsDateTime, @TrDsBarCode, @TrDsName, @TrDsUnit, @TrDsPrice, @TrDsQuantity, @TrDsPriceTotal, @TrDsNote, @TrDsUserAddBy)", this.A);
                    command2.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command2.Parameters.AddWithValue("TrDsType", "1");
                    command2.Parameters.AddWithValue("TrDsDateTime", this.DateTimePicker.Value.ToString("yyyy/MM/dd HH:mm"));
                    command2.Parameters.AddWithValue("TrDsBarCode", this.I.Text.Trim());
                    command2.Parameters.AddWithValue("TrDsName", this.MaterialName.Text.Trim());
                    command2.Parameters.AddWithValue("TrDsUnit", this.D.Text.Trim());
                    command2.Parameters.AddWithValue("TrDsPrice", num4.ToString(PR.VR));
                    command2.Parameters.AddWithValue("TrDsQuantity", num.ToString(PR.OR));
                    command2.Parameters.AddWithValue("TrDsPriceTotal", num5.ToString(PR.VR));
                    command2.Parameters.AddWithValue("TrDsNote", this.TxTNote.Text);
                    command2.Parameters.AddWithValue("TrDsUserAddBy", A.D.A.A.TxTUserName.Text);
                    command2.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    A.D.A.A.TimerLoadData.Enabled = true;
                    base.Dispose();
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

        private void P(object A, EventArgs R)
        {
            if (this.TxTQMove.Text != null)
            {
                this.P();
            }
            else
            {
                Interaction.MsgBox("حدد الكمية المطلوب اتلافها", MsgBoxStyle.ApplicationModal, null);
                this.TxTQMove.Focus();
            }
        }

        private void Q(object A, EventArgs R)
        {
            A.D.A.A.TimerLoadData.Enabled = true;
            base.Dispose();
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
                string selectCommandText = "SELECT * FROM TaNNMaterial WHERE (MaterialID = @MaterialID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("MaterialID", A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.Q.Text = dataTable.Rows[0]["MaterialID"].ToString();
                    this.I.Text = dataTable.Rows[0]["MaterialBarCode"].ToString();
                    this.MaterialName.Text = dataTable.Rows[0]["MaterialName"].ToString();
                    this.MaterialQuantity.Text = dataTable.Rows[0]["MaterialQuantity"].ToString();
                    this.F.Text = dataTable.Rows[0]["MaterialPricCost"].ToString();
                    this.D.Text = dataTable.Rows[0]["MaterialUnit"].ToString();
                }
                this.TxTQMove.Focus();
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
            this.DateTimePicker.Enabled = PR.RQ;
            this.R();
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

        internal virtual Button ButtonFinish
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTNote
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

        internal virtual TextBox TxTQMove
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                    r.KeyPress -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
                    r.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GropDate
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual Label MaterialName
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox MaterialQuantity
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }
    }
}

