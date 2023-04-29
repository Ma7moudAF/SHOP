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
    public class GF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("ComboBoxCenterTo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [CompilerGenerated, AccessedThroughProperty("LabelFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox5")]
        private GroupBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MaterialQuantity")]
        private TextBox A;
        [AccessedThroughProperty("GroupBox4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTNote")]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxAddIF")]
        private CheckBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3"), CompilerGenerated]
        private GroupBox I;
        [AccessedThroughProperty("TxTQMove"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GropDate")]
        private GroupBox D;
        [AccessedThroughProperty("DateTimePicker"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private System.Windows.Forms.DateTimePicker A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("MaterialName")]
        private Label Q;
        private SqlConnection A;
        public static int A;
        private TextBox Q;
        private TextBox I;
        private TextBox D;
        private TextBox F;
        private TextBox H;
        private TextBox T;
        private TextBox X;
        private CheckBox R;
        private TextBox G;
        private TextBox E;
        private CheckBox P;
        private TextBox K;
        private TextBox U;
        private TextBox L;
        private TextBox N;
        private TextBox V;
        private TextBox Y;

        public GF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.Q = new TextBox();
            this.I = new TextBox();
            this.D = new TextBox();
            this.F = new TextBox();
            this.H = new TextBox();
            this.T = new TextBox();
            this.X = new TextBox();
            this.R = new CheckBox();
            this.G = new TextBox();
            this.E = new TextBox();
            this.P = new CheckBox();
            this.K = new TextBox();
            this.U = new TextBox();
            this.L = new TextBox();
            this.N = new TextBox();
            this.V = new TextBox();
            this.Y = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.ButtonOK = new Button();
            this.ButtonFinish = new Button();
            this.Label2 = new Label();
            this.GroupBox2 = new GroupBox();
            this.ComboBoxCenterTo = new ComboBox();
            this.GroupBox1 = new GroupBox();
            this.LabelFrom = new Label();
            this.GroupBox5 = new GroupBox();
            this.MaterialQuantity = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.TxTNote = new TextBox();
            this.CheckBoxAddIF = new CheckBox();
            this.GroupBox3 = new GroupBox();
            this.TxTQMove = new TextBox();
            this.GropDate = new GroupBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MaterialName = new Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GropDate.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x2a7, 0x22);
            this.TxTTitle.TabIndex = 0x1d;
            this.TxTTitle.Text = "اضافة حركة ترحيل كمية";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(0x13, 0x203);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x1f1, 0x2c);
            this.ButtonOK.TabIndex = 30;
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
            this.ButtonFinish.Location = new Point(0x20a, 0x203);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x94, 0x2c);
            this.ButtonFinish.TabIndex = 0x1f;
            this.ButtonFinish.Text = "انهاء";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Tahoma", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0x144, 0x47);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            this.Label2.Size = new Size(40, 0x18);
            this.Label2.TabIndex = 0x66;
            this.Label2.Text = "<<";
            this.GroupBox2.Controls.Add(this.ComboBoxCenterTo);
            this.GroupBox2.Location = new Point(0x17a, 0x34);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x11d, 50);
            this.GroupBox2.TabIndex = 0x65;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "إلى الفرع/المستودع:";
            this.ComboBoxCenterTo.Dock = DockStyle.Fill;
            this.ComboBoxCenterTo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxCenterTo.FormattingEnabled = true;
            this.ComboBoxCenterTo.Location = new Point(3, 0x13);
            this.ComboBoxCenterTo.Name = "ComboBoxCenterTo";
            this.ComboBoxCenterTo.Size = new Size(0x117, 0x18);
            this.ComboBoxCenterTo.TabIndex = 2;
            this.GroupBox1.Controls.Add(this.LabelFrom);
            this.GroupBox1.Location = new Point(12, 0x33);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x132, 50);
            this.GroupBox1.TabIndex = 100;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "ترحيل نقل الكمية من الفرع/المستودع:";
            this.LabelFrom.Dock = DockStyle.Fill;
            this.LabelFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LabelFrom.ForeColor = Color.Green;
            this.LabelFrom.Location = new Point(3, 0x13);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new Size(300, 0x1c);
            this.LabelFrom.TabIndex = 0;
            this.LabelFrom.Text = "LabelFrom";
            this.LabelFrom.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox5.Controls.Add(this.MaterialQuantity);
            this.GroupBox5.Location = new Point(0x10, 0xdd);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x28b, 0x37);
            this.GroupBox5.TabIndex = 0x888925;
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
            this.GroupBox4.Controls.Add(this.TxTNote);
            this.GroupBox4.Location = new Point(0x10, 0x157);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x28b, 0x5f);
            this.GroupBox4.TabIndex = 0x888924;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "اضافة ملاحظة على الحركات والمادة، مثلا رقم المستند:";
            this.TxTNote.BackColor = SystemColors.Info;
            this.TxTNote.Location = new Point(6, 0x16);
            this.TxTNote.MaxLength = 0xbb8;
            this.TxTNote.Multiline = true;
            this.TxTNote.Name = "TxTNote";
            this.TxTNote.RightToLeft = RightToLeft.No;
            this.TxTNote.Size = new Size(0x27f, 0x43);
            this.TxTNote.TabIndex = 1;
            this.TxTNote.TextAlign = HorizontalAlignment.Center;
            this.CheckBoxAddIF.AutoSize = true;
            this.CheckBoxAddIF.Location = new Point(0x13, 0x1cf);
            this.CheckBoxAddIF.Name = "CheckBoxAddIF";
            this.CheckBoxAddIF.Size = new Size(0x1b5, 20);
            this.CheckBoxAddIF.TabIndex = 0x888923;
            this.CheckBoxAddIF.Text = "في حال عدم وجود المادة في المستودع الأخر قم بإضافتها مع الكمية الجديدة";
            this.CheckBoxAddIF.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.TxTQMove);
            this.GroupBox3.Location = new Point(0x10, 0x11a);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x28b, 0x37);
            this.GroupBox3.TabIndex = 0x888922;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الكمية المطلوب نقلها:";
            this.TxTQMove.BackColor = SystemColors.Info;
            this.TxTQMove.Location = new Point(6, 0x16);
            this.TxTQMove.MaxLength = 20;
            this.TxTQMove.Name = "TxTQMove";
            this.TxTQMove.RightToLeft = RightToLeft.No;
            this.TxTQMove.Size = new Size(0x27f, 0x17);
            this.TxTQMove.TabIndex = 1;
            this.TxTQMove.TextAlign = HorizontalAlignment.Center;
            this.GropDate.Controls.Add(this.DateTimePicker);
            this.GropDate.Location = new Point(0x10, 0xa5);
            this.GropDate.Name = "GropDate";
            this.GropDate.Size = new Size(0x28b, 50);
            this.GropDate.TabIndex = 0x888926;
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
            this.MaterialName.Location = new Point(0x10, 0x74);
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Size = new Size(0x28e, 0x2e);
            this.MaterialName.TabIndex = 0x888927;
            this.MaterialName.Text = "---";
            this.MaterialName.TextAlign = ContentAlignment.MiddleCenter;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonFinish;
            base.ClientSize = new Size(0x2a7, 0x23c);
            base.ControlBox = false;
            base.Controls.Add(this.MaterialName);
            base.Controls.Add(this.GropDate);
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.CheckBoxAddIF);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialTransferDestroyAddT";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة حركة ترحيل كمية";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GropDate.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.DateTimePicker.Enabled = PR.RQ;
            this.LabelFrom.Text = PR.KR.ToString();
            this.R();
            this.P();
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

        public void D()
        {
            try
            {
                decimal num = new decimal(Conversion.Val(this.TxTQMove.Text.Replace(",", "")));
                decimal num4 = decimal.Subtract(new decimal(Conversion.Val(this.MaterialQuantity.Text.Replace(",", ""))), num);
                decimal num5 = decimal.Add(new decimal(Conversion.Val(this.Y.Text.Replace(",", ""))), num);
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                command.Parameters.AddWithValue("MaterialID", this.Q.Text);
                command.Parameters.AddWithValue("MaterialQuantity", num4.ToString(PR.OR));
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("INSERT INTO TaNNMaterial(CenterFrontID, GroupIDFrontID, MaterialBarCode, MaterialName, MaterialQuantity, MaterialUnit, MaterialPricCost, MaterialPricLess, MaterialPricSale, MaterialIsStop, MaterialExpDate, MaterialNote, MaterialNotIsView, MaterialQuantityLess, MaterialQuantityPakeg, MaterialQuantityOffer, MaterialDisMiWi, MaterialDarMiWi, MaterialOtherBarCode, MaterialMultBarCode, MaterialBarcodeBlock) VALUES (@CenterFrontID, @GroupIDFrontID, @MaterialBarCode, @MaterialName, @MaterialQuantity, @MaterialUnit, @MaterialPricCost, @MaterialPricLess, @MaterialPricSale, @MaterialIsStop, @MaterialExpDate, @MaterialNote, @MaterialNotIsView, @MaterialQuantityLess, @MaterialQuantityPakeg, @MaterialQuantityOffer, @MaterialDisMiWi, @MaterialDarMiWi, @MaterialOtherBarCode, @MaterialMultBarCode, @MaterialBarcodeBlock)", this.A);
                command2.Parameters.AddWithValue("CenterFrontID", this.ComboBoxCenterTo.SelectedValue);
                command2.Parameters.AddWithValue("GroupIDFrontID", "0");
                command2.Parameters.AddWithValue("MaterialBarCode", this.D.Text.Trim());
                command2.Parameters.AddWithValue("MaterialName", this.MaterialName.Text.Trim());
                command2.Parameters.AddWithValue("MaterialQuantity", num.ToString(PR.OR));
                command2.Parameters.AddWithValue("MaterialUnit", this.F.Text.Trim());
                command2.Parameters.AddWithValue("MaterialPricCost", 0.ToString(PR.VR));
                command2.Parameters.AddWithValue("MaterialPricSale", 0.ToString(PR.VR));
                command2.Parameters.AddWithValue("MaterialPricLess", 0.ToString(PR.VR));
                command2.Parameters.AddWithValue("MaterialIsStop", false);
                command2.Parameters.AddWithValue("MaterialExpDate", DBNull.Value);
                command2.Parameters.AddWithValue("MaterialNote", "");
                command2.Parameters.AddWithValue("MaterialNotIsView", false);
                command2.Parameters.AddWithValue("MaterialQuantityLess", 0.ToString(PR.OR));
                command2.Parameters.AddWithValue("MaterialQuantityPakeg", 0.ToString(PR.OR));
                command2.Parameters.AddWithValue("MaterialQuantityOffer", 0.ToString(PR.OR));
                command2.Parameters.AddWithValue("MaterialDisMiWi", "0");
                command2.Parameters.AddWithValue("MaterialDarMiWi", "0");
                command2.Parameters.AddWithValue("MaterialOtherBarCode", "");
                command2.Parameters.AddWithValue("MaterialMultBarCode", "");
                command2.Parameters.AddWithValue("MaterialBarcodeBlock", this.ComboBoxCenterTo.SelectedValue.ToString() + this.D.Text.Trim());
                command2.ExecuteNonQuery();
                this.A.Close();
                decimal num6 = new decimal(Conversion.Val(this.H.Text.Replace(",", "")));
                decimal num7 = decimal.Multiply(num6, num);
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string cmdText = "INSERT INTO [TaNNMaterialTrDs] ([CenterFrontID], [TrDsType], [TrDsDateTime], [TrDsBarCode], [TrDsName], [TrDsUnit], [TrDsPrice], [TrDsQuantity], [TrDsPriceTotal], [TrDsNote], [TrDsUserAddBy]) VALUES (@CenterFrontID, @TrDsType, @TrDsDateTime, @TrDsBarCode, @TrDsName, @TrDsUnit, @TrDsPrice, @TrDsQuantity, @TrDsPriceTotal, @TrDsNote, @TrDsUserAddBy)";
                SqlCommand command3 = new SqlCommand(cmdText, this.A);
                command3.Parameters.AddWithValue("CenterFrontID", PR.GR);
                command3.Parameters.AddWithValue("TrDsType", "0");
                command3.Parameters.AddWithValue("TrDsDateTime", this.DateTimePicker.Value.ToString("yyyy/MM/dd HH:mm"));
                command3.Parameters.AddWithValue("TrDsBarCode", this.D.Text.Trim());
                command3.Parameters.AddWithValue("TrDsName", this.MaterialName.Text.Trim());
                command3.Parameters.AddWithValue("TrDsUnit", this.F.Text.Trim());
                command3.Parameters.AddWithValue("TrDsPrice", num6.ToString(PR.VR));
                command3.Parameters.AddWithValue("TrDsQuantity", num.ToString(PR.OR));
                command3.Parameters.AddWithValue("TrDsPriceTotal", num7.ToString(PR.VR));
                string[] textArray1 = new string[] { "من: ", this.LabelFrom.Text, " الى: ", this.ComboBoxCenterTo.Text, " ", this.TxTNote.Text };
                command3.Parameters.AddWithValue("TrDsNote", string.Concat(textArray1));
                command3.Parameters.AddWithValue("TrDsUserAddBy", A.D.A.A.TxTUserName.Text);
                command3.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command4 = new SqlCommand(cmdText, this.A);
                command4.Parameters.AddWithValue("CenterFrontID", this.ComboBoxCenterTo.SelectedValue);
                command4.Parameters.AddWithValue("TrDsType", "0");
                command4.Parameters.AddWithValue("TrDsDateTime", this.DateTimePicker.Value.ToString("yyyy/MM/dd HH:mm"));
                command4.Parameters.AddWithValue("TrDsBarCode", this.D.Text.Trim());
                command4.Parameters.AddWithValue("TrDsName", this.MaterialName.Text.Trim());
                command4.Parameters.AddWithValue("TrDsUnit", this.F.Text.Trim());
                command4.Parameters.AddWithValue("TrDsPrice", num6.ToString(PR.VR));
                command4.Parameters.AddWithValue("TrDsQuantity", num.ToString(PR.OR));
                command4.Parameters.AddWithValue("TrDsPriceTotal", num7.ToString(PR.VR));
                string[] textArray2 = new string[] { "من: ", this.LabelFrom.Text, " الى: ", this.ComboBoxCenterTo.Text, " ", this.TxTNote.Text };
                command4.Parameters.AddWithValue("TrDsNote", string.Concat(textArray2));
                command4.Parameters.AddWithValue("TrDsUserAddBy", A.D.A.A.TxTUserName.Text);
                command4.ExecuteNonQuery();
                this.A.Close();
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                A.D.A.A.TimerLoadData.Enabled = true;
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

        public void I()
        {
            try
            {
                decimal num = new decimal(Conversion.Val(this.TxTQMove.Text.Replace(",", "")));
                decimal num4 = decimal.Subtract(new decimal(Conversion.Val(this.MaterialQuantity.Text.Replace(",", ""))), num);
                decimal num5 = decimal.Add(new decimal(Conversion.Val(this.Y.Text.Replace(",", ""))), num);
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                command.Parameters.AddWithValue("@MaterialID", this.Q.Text);
                command.Parameters.AddWithValue("@MaterialQuantity", num4.ToString(PR.OR));
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                command2.Parameters.AddWithValue("@MaterialID", this.N.Text);
                command2.Parameters.AddWithValue("@MaterialQuantity", num5.ToString(PR.OR));
                command2.ExecuteNonQuery();
                this.A.Close();
                decimal num6 = new decimal(Conversion.Val(this.H.Text.Replace(",", "")));
                decimal num7 = decimal.Multiply(num6, num);
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string cmdText = "INSERT INTO [TaNNMaterialTrDs] ([CenterFrontID], [TrDsType], [TrDsDateTime], [TrDsBarCode], [TrDsName], [TrDsUnit], [TrDsPrice], [TrDsQuantity], [TrDsPriceTotal], [TrDsNote], [TrDsUserAddBy]) VALUES (@CenterFrontID, @TrDsType, @TrDsDateTime, @TrDsBarCode, @TrDsName, @TrDsUnit, @TrDsPrice, @TrDsQuantity, @TrDsPriceTotal, @TrDsNote, @TrDsUserAddBy)";
                SqlCommand command3 = new SqlCommand(cmdText, this.A);
                command3.Parameters.AddWithValue("CenterFrontID", PR.GR);
                command3.Parameters.AddWithValue("TrDsType", "0");
                command3.Parameters.AddWithValue("TrDsDateTime", this.DateTimePicker.Value.ToString("yyyy/MM/dd HH:mm"));
                command3.Parameters.AddWithValue("TrDsBarCode", this.D.Text.Trim());
                command3.Parameters.AddWithValue("TrDsName", this.MaterialName.Text.Trim());
                command3.Parameters.AddWithValue("TrDsUnit", this.F.Text.Trim());
                command3.Parameters.AddWithValue("TrDsPrice", num6.ToString(PR.VR));
                command3.Parameters.AddWithValue("TrDsQuantity", num.ToString(PR.OR));
                command3.Parameters.AddWithValue("TrDsPriceTotal", num7.ToString(PR.VR));
                string[] textArray1 = new string[] { "من: ", this.LabelFrom.Text, " الى: ", this.ComboBoxCenterTo.Text, " ", this.TxTNote.Text };
                command3.Parameters.AddWithValue("TrDsNote", string.Concat(textArray1));
                command3.Parameters.AddWithValue("TrDsUserAddBy", A.D.A.A.TxTUserName.Text);
                command3.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command4 = new SqlCommand(cmdText, this.A);
                command4.Parameters.AddWithValue("CenterFrontID", this.ComboBoxCenterTo.SelectedValue);
                command4.Parameters.AddWithValue("TrDsType", "0");
                command4.Parameters.AddWithValue("TrDsDateTime", this.DateTimePicker.Value.ToString("yyyy/MM/dd HH:mm"));
                command4.Parameters.AddWithValue("TrDsBarCode", this.D.Text.Trim());
                command4.Parameters.AddWithValue("TrDsName", this.MaterialName.Text.Trim());
                command4.Parameters.AddWithValue("TrDsUnit", this.F.Text.Trim());
                command4.Parameters.AddWithValue("TrDsPrice", num6.ToString(PR.VR));
                command4.Parameters.AddWithValue("TrDsQuantity", num.ToString(PR.OR));
                command4.Parameters.AddWithValue("TrDsPriceTotal", num7.ToString(PR.VR));
                string[] textArray2 = new string[] { "من: ", this.LabelFrom.Text, " الى: ", this.ComboBoxCenterTo.Text, " ", this.TxTNote.Text };
                command4.Parameters.AddWithValue("TrDsNote", string.Concat(textArray2));
                command4.Parameters.AddWithValue("TrDsUserAddBy", A.D.A.A.TxTUserName.Text);
                command4.ExecuteNonQuery();
                this.A.Close();
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                A.D.A.A.TimerLoadData.Enabled = true;
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

        public void P()
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
                    this.D.Text = dataTable.Rows[0]["MaterialBarCode"].ToString();
                    this.MaterialName.Text = dataTable.Rows[0]["MaterialName"].ToString();
                    this.MaterialQuantity.Text = dataTable.Rows[0]["MaterialQuantity"].ToString();
                    this.H.Text = dataTable.Rows[0]["MaterialPricCost"].ToString();
                    this.X.Text = dataTable.Rows[0]["MaterialPricSale"].ToString();
                    this.F.Text = dataTable.Rows[0]["MaterialUnit"].ToString();
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
            A.D.A.A.TimerLoadData.Enabled = true;
            base.Dispose();
        }

        public void Q()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT * FROM TaNNMaterial WHERE (CenterFrontID =@CenterFrontID) AND (MaterialBarCode = @MaterialBarCode)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", this.ComboBoxCenterTo.SelectedValue);
                adapter.SelectCommand.Parameters.AddWithValue("MaterialBarCode", this.D.Text);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.N.Text = dataTable.Rows[0]["MaterialID"].ToString();
                    this.Y.Text = dataTable.Rows[0]["MaterialQuantity"].ToString();
                }
                if (decimal.Compare(new decimal(Conversion.Val(this.TxTQMove.Text.Replace(",", ""))), new decimal(Conversion.Val(this.MaterialQuantity.Text.Replace(",", "")))) > 0)
                {
                    Interaction.MsgBox("الكمية المطلوب ترحيلها اكبر من الكمية الحالية في المستودع", MsgBoxStyle.ApplicationModal, null);
                }
                else if (dataTable.Rows.Count > 0)
                {
                    this.I();
                }
                else if (this.CheckBoxAddIF.Checked)
                {
                    this.D();
                }
                else
                {
                    Interaction.MsgBox("لم يتم العثور على المادة في المستودع الأخر", MsgBoxStyle.ApplicationModal, null);
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
                string selectCommandText = "SELECT CenterID, CenterSubName FROM TaNNCenters WHERE (CenterID <> @CenterID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxCenterTo.ValueMember = "CenterID";
                    this.ComboBoxCenterTo.DisplayMember = "CenterSubName";
                    this.ComboBoxCenterTo.DataSource = dataTable;
                    this.ComboBoxCenterTo.SelectedIndex = -1;
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
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.ComboBoxCenterTo.SelectedValue, null, false))
            {
                Interaction.MsgBox("حدد الفرع/ المستودع", MsgBoxStyle.ApplicationModal, null);
            }
            else if (this.TxTQMove.Text != null)
            {
                this.Q();
            }
            else
            {
                Interaction.MsgBox("حدد الكمية المطلوب ترحيلها", MsgBoxStyle.ApplicationModal, null);
                this.TxTQMove.Focus();
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

        internal virtual Button ButtonFinish
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

        internal virtual Label Label2
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox ComboBoxCenterTo
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

        internal virtual Label LabelFrom
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox MaterialQuantity
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTNote
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual CheckBox CheckBoxAddIF
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox TxTQMove
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox p = this.P;
                if (p != null)
                {
                    p.TextChanged -= handler;
                    p.KeyPress -= handler2;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.TextChanged += handler;
                    p.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GropDate
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }
    }
}

