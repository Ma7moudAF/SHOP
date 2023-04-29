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
    public class BD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("GroupBoxType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("InvType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("GroupBoxC"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [AccessedThroughProperty("ComboBoxCustomer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [AccessedThroughProperty("GroupBoxUsers"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("ComboBoxUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox P;
        [AccessedThroughProperty("GroupBoxNT"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("TxTNoSe"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("GroupBoxPty"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("InvPayType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox Q;
        [AccessedThroughProperty("GroupBoxSt"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("InvStatus"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox I;
        [AccessedThroughProperty("TimersStartUp"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("ButtonOK"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("CheckBoxType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("CheckBoxUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox R;
        [AccessedThroughProperty("CheckBoxCustomer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox P;
        [AccessedThroughProperty("CheckBoxDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox Q;
        [AccessedThroughProperty("CheckBoxNote"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox I;
        [AccessedThroughProperty("CheckBoxPayType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox D;
        [AccessedThroughProperty("CheckBoxState"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox F;
        [AccessedThroughProperty("GroupBoxDF"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [AccessedThroughProperty("DateTimePickerFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker R;
        [AccessedThroughProperty("GroupBoxDT"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [AccessedThroughProperty("DateTimePickerTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker P;
        [AccessedThroughProperty("PickerTimeTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker Q;
        private SqlConnection A;
        private string A;

        public BD()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = "SELECT TaNNInvSale.*, TaNNCustomers.CustomerName FROM TaNNInvSale LEFT OUTER JOIN TaNNCustomers ON TaNNInvSale.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSale.CenterFrontID = @CenterFrontID)";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.GroupBoxType = new GroupBox();
            this.InvType = new ComboBox();
            this.GroupBoxC = new GroupBox();
            this.ComboBoxCustomer = new ComboBox();
            this.GroupBoxUsers = new GroupBox();
            this.ComboBoxUser = new ComboBox();
            this.GroupBoxNT = new GroupBox();
            this.TxTNoSe = new TextBox();
            this.GroupBoxPty = new GroupBox();
            this.InvPayType = new ComboBox();
            this.GroupBoxSt = new GroupBox();
            this.InvStatus = new ComboBox();
            this.TimersStartUp = new Timer(this.A);
            this.TxTTitle = new Label();
            this.CheckBoxType = new CheckBox();
            this.CheckBoxUser = new CheckBox();
            this.CheckBoxCustomer = new CheckBox();
            this.CheckBoxDate = new CheckBox();
            this.CheckBoxNote = new CheckBox();
            this.CheckBoxPayType = new CheckBox();
            this.CheckBoxState = new CheckBox();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.GroupBoxDF = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBoxDT = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.GroupBoxType.SuspendLayout();
            this.GroupBoxC.SuspendLayout();
            this.GroupBoxUsers.SuspendLayout();
            this.GroupBoxNT.SuspendLayout();
            this.GroupBoxPty.SuspendLayout();
            this.GroupBoxSt.SuspendLayout();
            this.GroupBoxDF.SuspendLayout();
            this.GroupBoxDT.SuspendLayout();
            base.SuspendLayout();
            this.GroupBoxType.Controls.Add(this.InvType);
            this.GroupBoxType.Enabled = false;
            this.GroupBoxType.Location = new Point(12, 0x25);
            this.GroupBoxType.Name = "GroupBoxType";
            this.GroupBoxType.Size = new Size(0x166, 0x35);
            this.GroupBoxType.TabIndex = 0x1ed36cd;
            this.GroupBoxType.TabStop = false;
            this.GroupBoxType.Text = "نوع الفاتورة";
            this.InvType.Dock = DockStyle.Fill;
            this.InvType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvType.FormattingEnabled = true;
            object[] items = new object[] { "فاتورة مبيعات", "فاتورة مرتجع مبيعات" };
            this.InvType.Items.AddRange(items);
            this.InvType.Location = new Point(3, 0x13);
            this.InvType.Name = "InvType";
            this.InvType.Size = new Size(0x160, 0x18);
            this.InvType.TabIndex = 0x2c;
            this.GroupBoxC.Controls.Add(this.ComboBoxCustomer);
            this.GroupBoxC.Enabled = false;
            this.GroupBoxC.Location = new Point(12, 0xb0);
            this.GroupBoxC.Name = "GroupBoxC";
            this.GroupBoxC.Size = new Size(0x166, 0x36);
            this.GroupBoxC.TabIndex = 0x1ed36d0;
            this.GroupBoxC.TabStop = false;
            this.GroupBoxC.Text = "العميل";
            this.ComboBoxCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxCustomer.Dock = DockStyle.Fill;
            this.ComboBoxCustomer.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxCustomer.FormattingEnabled = true;
            this.ComboBoxCustomer.IntegralHeight = false;
            this.ComboBoxCustomer.Location = new Point(3, 0x13);
            this.ComboBoxCustomer.Name = "ComboBoxCustomer";
            this.ComboBoxCustomer.Size = new Size(0x160, 0x18);
            this.ComboBoxCustomer.TabIndex = 0x44;
            this.GroupBoxUsers.Controls.Add(this.ComboBoxUser);
            this.GroupBoxUsers.Enabled = false;
            this.GroupBoxUsers.Location = new Point(12, 0xec);
            this.GroupBoxUsers.Name = "GroupBoxUsers";
            this.GroupBoxUsers.Size = new Size(0x166, 0x35);
            this.GroupBoxUsers.TabIndex = 0x1ed36d1;
            this.GroupBoxUsers.TabStop = false;
            this.GroupBoxUsers.Text = "الموظف";
            this.ComboBoxUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxUser.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxUser.Dock = DockStyle.Top;
            this.ComboBoxUser.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxUser.FormattingEnabled = true;
            this.ComboBoxUser.IntegralHeight = false;
            this.ComboBoxUser.Location = new Point(3, 0x13);
            this.ComboBoxUser.Name = "ComboBoxUser";
            this.ComboBoxUser.Size = new Size(0x160, 0x1b);
            this.ComboBoxUser.TabIndex = 0x3b;
            this.GroupBoxNT.Controls.Add(this.TxTNoSe);
            this.GroupBoxNT.Enabled = false;
            this.GroupBoxNT.Location = new Point(12, 0x127);
            this.GroupBoxNT.Name = "GroupBoxNT";
            this.GroupBoxNT.Size = new Size(360, 0x34);
            this.GroupBoxNT.TabIndex = 0x1ed36d2;
            this.GroupBoxNT.TabStop = false;
            this.GroupBoxNT.Text = "الملاحظات";
            this.TxTNoSe.BackColor = SystemColors.Info;
            this.TxTNoSe.Dock = DockStyle.Fill;
            this.TxTNoSe.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTNoSe.Location = new Point(3, 0x13);
            this.TxTNoSe.Name = "TxTNoSe";
            this.TxTNoSe.RightToLeft = RightToLeft.No;
            this.TxTNoSe.Size = new Size(0x162, 0x1b);
            this.TxTNoSe.TabIndex = 0x1ed36cc;
            this.TxTNoSe.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxPty.Controls.Add(this.InvPayType);
            this.GroupBoxPty.Enabled = false;
            this.GroupBoxPty.Location = new Point(12, 0x161);
            this.GroupBoxPty.Name = "GroupBoxPty";
            this.GroupBoxPty.Size = new Size(360, 0x33);
            this.GroupBoxPty.TabIndex = 0x1ed36d3;
            this.GroupBoxPty.TabStop = false;
            this.GroupBoxPty.Text = "طريقة الدفع";
            this.InvPayType.Dock = DockStyle.Fill;
            this.InvPayType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvPayType.FormattingEnabled = true;
            object[] objArray2 = new object[] { "نقدا", "ذمم", "شبكة", "تحويل", "الرصيد المدور", "شيك", "إئتمان" };
            this.InvPayType.Items.AddRange(objArray2);
            this.InvPayType.Location = new Point(3, 0x13);
            this.InvPayType.Name = "InvPayType";
            this.InvPayType.Size = new Size(0x162, 0x18);
            this.InvPayType.TabIndex = 0x1ed36cc;
            this.GroupBoxSt.Controls.Add(this.InvStatus);
            this.GroupBoxSt.Enabled = false;
            this.GroupBoxSt.Location = new Point(12, 410);
            this.GroupBoxSt.Name = "GroupBoxSt";
            this.GroupBoxSt.Size = new Size(360, 0x33);
            this.GroupBoxSt.TabIndex = 0x1ed36d4;
            this.GroupBoxSt.TabStop = false;
            this.GroupBoxSt.Text = "حالة الفاتورة";
            this.InvStatus.Dock = DockStyle.Fill;
            this.InvStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvStatus.FormattingEnabled = true;
            object[] objArray3 = new object[] { "مكتملة", "معلقة", "قيد التعديل", "معدلة" };
            this.InvStatus.Items.AddRange(objArray3);
            this.InvStatus.Location = new Point(3, 0x13);
            this.InvStatus.Name = "InvStatus";
            this.InvStatus.Size = new Size(0x162, 0x18);
            this.InvStatus.TabIndex = 0x1ed36cc;
            this.TimersStartUp.Interval = 0x3e8;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1e2, 0x22);
            this.TxTTitle.TabIndex = 0x1ed36d5;
            this.TxTTitle.Text = "الفرز المتقدم لفواتير المبيعات/ مرتجع المبيعات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.CheckBoxType.AutoSize = true;
            this.CheckBoxType.Checked = true;
            this.CheckBoxType.CheckState = CheckState.Checked;
            this.CheckBoxType.Enabled = false;
            this.CheckBoxType.Location = new Point(0x178, 0x3a);
            this.CheckBoxType.Name = "CheckBoxType";
            this.CheckBoxType.Size = new Size(0x58, 20);
            this.CheckBoxType.TabIndex = 0x1ed36d9;
            this.CheckBoxType.Text = "تضمين ذلك";
            this.CheckBoxType.UseVisualStyleBackColor = true;
            this.CheckBoxUser.AutoSize = true;
            this.CheckBoxUser.Location = new Point(0x178, 260);
            this.CheckBoxUser.Name = "CheckBoxUser";
            this.CheckBoxUser.Size = new Size(0x58, 20);
            this.CheckBoxUser.TabIndex = 0x1ed36da;
            this.CheckBoxUser.Text = "تضمين ذلك";
            this.CheckBoxUser.UseVisualStyleBackColor = true;
            this.CheckBoxCustomer.AutoSize = true;
            this.CheckBoxCustomer.Location = new Point(0x178, 0xc5);
            this.CheckBoxCustomer.Name = "CheckBoxCustomer";
            this.CheckBoxCustomer.Size = new Size(0x58, 20);
            this.CheckBoxCustomer.TabIndex = 0x1ed36db;
            this.CheckBoxCustomer.Text = "تضمين ذلك";
            this.CheckBoxCustomer.UseVisualStyleBackColor = true;
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.Location = new Point(0x178, 0x75);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Size = new Size(0x58, 20);
            this.CheckBoxDate.TabIndex = 0x1ed36dc;
            this.CheckBoxDate.Text = "تضمين ذلك";
            this.CheckBoxDate.UseVisualStyleBackColor = true;
            this.CheckBoxNote.AutoSize = true;
            this.CheckBoxNote.Location = new Point(0x178, 0x13f);
            this.CheckBoxNote.Name = "CheckBoxNote";
            this.CheckBoxNote.Size = new Size(0x58, 20);
            this.CheckBoxNote.TabIndex = 0x1ed36dd;
            this.CheckBoxNote.Text = "تضمين ذلك";
            this.CheckBoxNote.UseVisualStyleBackColor = true;
            this.CheckBoxPayType.AutoSize = true;
            this.CheckBoxPayType.Location = new Point(0x17a, 0x176);
            this.CheckBoxPayType.Name = "CheckBoxPayType";
            this.CheckBoxPayType.Size = new Size(0x58, 20);
            this.CheckBoxPayType.TabIndex = 0x1ed36de;
            this.CheckBoxPayType.Text = "تضمين ذلك";
            this.CheckBoxPayType.UseVisualStyleBackColor = true;
            this.CheckBoxState.AutoSize = true;
            this.CheckBoxState.Location = new Point(0x17a, 0x1af);
            this.CheckBoxState.Name = "CheckBoxState";
            this.CheckBoxState.Size = new Size(0x58, 20);
            this.CheckBoxState.TabIndex = 0x1ed36df;
            this.CheckBoxState.Text = "تضمين ذلك";
            this.CheckBoxState.UseVisualStyleBackColor = true;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(12, 0x1d4);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0xeb, 0x2c);
            this.ButtonOK.TabIndex = 0x1ed36d7;
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
            this.ButtonClose.Location = new Point(0xfd, 0x1d4);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x74, 0x2c);
            this.ButtonClose.TabIndex = 0x1ed36d8;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.GroupBoxDF.Controls.Add(this.DateTimePickerFrom);
            this.GroupBoxDF.Controls.Add(this.PickerTimeFrom);
            this.GroupBoxDF.Enabled = false;
            this.GroupBoxDF.Location = new Point(12, 0x60);
            this.GroupBoxDF.Name = "GroupBoxDF";
            this.GroupBoxDF.Size = new Size(0xb0, 0x4a);
            this.GroupBoxDF.TabIndex = 0x1ed36f8;
            this.GroupBoxDF.TabStop = false;
            this.GroupBoxDF.Text = "من تاريخ";
            this.DateTimePickerFrom.CustomFormat = "";
            this.DateTimePickerFrom.Dock = DockStyle.Fill;
            this.DateTimePickerFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePickerFrom.Format = DateTimePickerFormat.Short;
            this.DateTimePickerFrom.Location = new Point(3, 0x13);
            this.DateTimePickerFrom.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.RightToLeft = RightToLeft.No;
            this.DateTimePickerFrom.Size = new Size(170, 0x17);
            this.DateTimePickerFrom.TabIndex = 0x40;
            this.PickerTimeFrom.CustomFormat = "hh:mm tt";
            this.PickerTimeFrom.Dock = DockStyle.Bottom;
            this.PickerTimeFrom.Format = DateTimePickerFormat.Custom;
            this.PickerTimeFrom.Location = new Point(3, 0x30);
            this.PickerTimeFrom.Name = "PickerTimeFrom";
            this.PickerTimeFrom.ShowUpDown = true;
            this.PickerTimeFrom.Size = new Size(170, 0x17);
            this.PickerTimeFrom.TabIndex = 0x1ed36d3;
            this.GroupBoxDT.Controls.Add(this.DateTimePickerTo);
            this.GroupBoxDT.Controls.Add(this.PickerTimeTo);
            this.GroupBoxDT.Enabled = false;
            this.GroupBoxDT.Location = new Point(0xbf, 0x62);
            this.GroupBoxDT.Name = "GroupBoxDT";
            this.GroupBoxDT.Size = new Size(0xb0, 0x48);
            this.GroupBoxDT.TabIndex = 0x1ed36f9;
            this.GroupBoxDT.TabStop = false;
            this.GroupBoxDT.Text = "الى تاريخ";
            this.DateTimePickerTo.CustomFormat = "";
            this.DateTimePickerTo.Dock = DockStyle.Fill;
            this.DateTimePickerTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePickerTo.Format = DateTimePickerFormat.Short;
            this.DateTimePickerTo.Location = new Point(3, 0x13);
            this.DateTimePickerTo.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.RightToLeft = RightToLeft.No;
            this.DateTimePickerTo.Size = new Size(170, 0x17);
            this.DateTimePickerTo.TabIndex = 70;
            this.PickerTimeTo.CustomFormat = "hh:mm tt";
            this.PickerTimeTo.Dock = DockStyle.Bottom;
            this.PickerTimeTo.Format = DateTimePickerFormat.Custom;
            this.PickerTimeTo.Location = new Point(3, 0x2e);
            this.PickerTimeTo.Name = "PickerTimeTo";
            this.PickerTimeTo.ShowUpDown = true;
            this.PickerTimeTo.Size = new Size(170, 0x17);
            this.PickerTimeTo.TabIndex = 0x1ed36d4;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x1e2, 0x209);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBoxDF);
            base.Controls.Add(this.GroupBoxDT);
            base.Controls.Add(this.CheckBoxState);
            base.Controls.Add(this.CheckBoxPayType);
            base.Controls.Add(this.CheckBoxNote);
            base.Controls.Add(this.CheckBoxDate);
            base.Controls.Add(this.CheckBoxCustomer);
            base.Controls.Add(this.CheckBoxUser);
            base.Controls.Add(this.CheckBoxType);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.GroupBoxSt);
            base.Controls.Add(this.GroupBoxPty);
            base.Controls.Add(this.GroupBoxNT);
            base.Controls.Add(this.GroupBoxUsers);
            base.Controls.Add(this.GroupBoxC);
            base.Controls.Add(this.GroupBoxType);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "InvoiceSaleListSearch";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "الفرز المتقدم لفواتير المبيعات/ مرتجع المبيعات";
            this.GroupBoxType.ResumeLayout(false);
            this.GroupBoxC.ResumeLayout(false);
            this.GroupBoxUsers.ResumeLayout(false);
            this.GroupBoxNT.ResumeLayout(false);
            this.GroupBoxNT.PerformLayout();
            this.GroupBoxPty.ResumeLayout(false);
            this.GroupBoxSt.ResumeLayout(false);
            this.GroupBoxDF.ResumeLayout(false);
            this.GroupBoxDT.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.PickerTimeFrom.Value = Conversions.ToDate(DateTime.Now.Date.ToString("yyyy/MM/dd 00:00"));
            this.PickerTimeTo.Value = Conversions.ToDate(DateTime.Now.Date.ToString("yyyy/MM/dd 23:59"));
            this.InvType.SelectedIndex = 0;
            this.TimersStartUp.Enabled = true;
        }

        private void D(object A, EventArgs R)
        {
            if (this.CheckBoxCustomer.Checked)
            {
                this.GroupBoxC.Enabled = true;
            }
            else
            {
                this.GroupBoxC.Enabled = false;
                this.ComboBoxCustomer.Text = null;
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

        private void F(object A, EventArgs R)
        {
            if (this.CheckBoxUser.Checked)
            {
                this.GroupBoxUsers.Enabled = true;
            }
            else
            {
                this.GroupBoxUsers.Enabled = false;
                this.ComboBoxUser.Text = null;
            }
        }

        private void G(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void H(object A, EventArgs R)
        {
            if (this.CheckBoxNote.Checked)
            {
                this.GroupBoxNT.Enabled = true;
            }
            else
            {
                this.GroupBoxNT.Enabled = false;
                this.TxTNoSe.Text = null;
            }
        }

        private void I(object A, EventArgs R)
        {
            if (this.CheckBoxDate.Checked)
            {
                this.GroupBoxDF.Enabled = true;
                this.GroupBoxDT.Enabled = true;
            }
            else
            {
                this.GroupBoxDF.Enabled = false;
                this.GroupBoxDT.Enabled = false;
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
                string selectCommandText = "SELECT [CustomerID], [CustomerName] FROM TaNNCustomers";
                dataTable.Clear();
                new SqlDataAdapter(selectCommandText, this.A).Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxCustomer.ValueMember = "CustomerID";
                    this.ComboBoxCustomer.DisplayMember = "CustomerName";
                    this.ComboBoxCustomer.DataSource = dataTable;
                    this.ComboBoxCustomer.SelectedIndex = -1;
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
            if (this.CheckBoxType.Checked)
            {
                if ((this.InvType.SelectedIndex == 0) | (this.InvType.SelectedIndex == 1))
                {
                    this.A = this.A + " AND (TaNNInvSale.InvSaleType = @InvSaleType)";
                }
                A.D.A.A.InvSaleType.SelectedIndex = this.InvType.SelectedIndex;
            }
            if (this.CheckBoxDate.Checked)
            {
                this.A = this.A + "  AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT)";
                A.D.A.A.DateTimePickerTo.Value = this.DateTimePickerTo.Value;
                A.D.A.A.DateTimePickerFrom.Value = this.DateTimePickerFrom.Value;
                A.D.A.A.PickerTimeFrom.Value = this.PickerTimeFrom.Value;
                A.D.A.A.PickerTimeTo.Value = this.PickerTimeTo.Value;
            }
            if (this.CheckBoxCustomer.Checked)
            {
                this.A = this.A + " AND (TaNNInvSale.CustomerFrontID = @CustomerFrontID)";
                A.D.A.A.ComboBoxCustomer.SelectedValue = this.ComboBoxCustomer.SelectedValue;
            }
            if (this.CheckBoxUser.Checked)
            {
                this.A = this.A + " AND (TaNNInvSale.InvSaleUserAddBy = @InvSaleUserAddBy)";
                A.D.A.A.ComboBoxUser.Text = this.ComboBoxUser.Text;
            }
            if (this.CheckBoxPayType.Checked)
            {
                this.A = this.A + " AND (TaNNInvSale.InvSalePayType = @InvSalePayType)";
                A.D.A.A.InvSalePayType.SelectedIndex = this.InvPayType.SelectedIndex;
            }
            if (this.CheckBoxState.Checked)
            {
                this.A = this.A + " AND (TaNNInvSale.InvSaleStatus = @InvSaleStatus)";
                A.D.A.A.InvSaleStatus.SelectedIndex = this.InvStatus.SelectedIndex;
            }
            if (this.CheckBoxNote.Checked)
            {
                this.A = this.A + " AND (TaNNInvSale.InvSaleNote LIKE '%' + @InvSaleNote + '%')";
                A.D.A.A.TxTNoSe.Text = this.TxTNoSe.Text;
            }
            OD.R = this.A;
            A.D.A.A.TimerLoadData.Enabled = true;
            base.Dispose();
        }

        private void Q(object A, EventArgs R)
        {
            if (this.CheckBoxType.Checked)
            {
                this.GroupBoxType.Enabled = true;
            }
            else
            {
                this.GroupBoxType.Enabled = false;
                this.InvType.SelectedIndex = 2;
            }
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
            this.TimersStartUp.Enabled = false;
            this.R();
            this.P();
            this.TxTTitle.Text = this.Text;
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Font = new Font("Tahoma", 12f);
        }

        private void T(object A, EventArgs R)
        {
            if (this.CheckBoxPayType.Checked)
            {
                this.GroupBoxPty.Enabled = true;
            }
            else
            {
                this.GroupBoxPty.Enabled = false;
                this.InvPayType.Text = null;
            }
        }

        private void X(object A, EventArgs R)
        {
            if (this.CheckBoxState.Checked)
            {
                this.GroupBoxSt.Enabled = true;
            }
            else
            {
                this.GroupBoxSt.Enabled = false;
                this.InvStatus.Text = null;
            }
        }

        internal virtual GroupBox GroupBoxType
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox InvType
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBoxC
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ComboBox ComboBoxCustomer
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBoxUsers
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ComboBox ComboBoxUser
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBoxNT
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTNoSe
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBoxPty
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ComboBox InvPayType
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBoxSt
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual ComboBox InvStatus
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Timer TimersStartUp
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual CheckBox CheckBoxType
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual CheckBox CheckBoxUser
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual CheckBox CheckBoxCustomer
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

        internal virtual CheckBox CheckBoxDate
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual CheckBox CheckBoxNote
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                CheckBox i = this.I;
                if (i != null)
                {
                    i.CheckedChanged -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBoxPayType
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                CheckBox d = this.D;
                if (d != null)
                {
                    d.CheckedChanged -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBoxState
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                CheckBox f = this.F;
                if (f != null)
                {
                    f.CheckedChanged -= handler;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.CheckedChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBoxDF
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual DateTimePicker DateTimePickerFrom
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DateTimePicker PickerTimeFrom
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBoxDT
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual DateTimePicker DateTimePickerTo
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual DateTimePicker PickerTimeTo
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

