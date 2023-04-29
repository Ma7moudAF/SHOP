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
    public class YD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("CheckBoxNote"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("CheckBoxDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox R;
        [AccessedThroughProperty("CheckBoxCustomer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox P;
        [AccessedThroughProperty("CheckBoxUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox Q;
        [AccessedThroughProperty("CheckBoxType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox I;
        [AccessedThroughProperty("ButtonOK"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("GroupBoxNT"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("TxTNoSe"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("GroupBoxUsers"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [AccessedThroughProperty("ComboBoxUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("GroupBoxC"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("ComboBoxCustomer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [AccessedThroughProperty("GroupBoxType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("InvType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox P;
        [AccessedThroughProperty("CheckBoxBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox D;
        [AccessedThroughProperty("CheckBoxMaterialName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox F;
        [AccessedThroughProperty("GroupBoxMaterialName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("ComboBoxMName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox Q;
        [AccessedThroughProperty("GroupBoxBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("ComboBoxMBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox I;
        [AccessedThroughProperty("CheckBoxGroup"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox H;
        [AccessedThroughProperty("GroupBoxGroup"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [AccessedThroughProperty("ComboBoxGrop"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox D;
        [AccessedThroughProperty("TimersStartUp"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("GroupBoxDF"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [AccessedThroughProperty("DateTimePickerFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker R;
        [AccessedThroughProperty("GroupBoxDT"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [AccessedThroughProperty("DateTimePickerTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker P;
        [AccessedThroughProperty("PickerTimeTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker Q;
        [AccessedThroughProperty("GroupBoxMAX"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox X;
        [AccessedThroughProperty("Label2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [AccessedThroughProperty("TxTMaxSerch2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("TxTMaxSerch1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [AccessedThroughProperty("CheckBoxMAX"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox T;
        private SqlConnection A;
        private string A;

        public YD()
        {
            base.Load += new EventHandler(this.R);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = "SELECT TaNNInvSaleItems.*, TaNNCustomers.CustomerName FROM TaNNInvSaleItems LEFT OUTER JOIN TaNNCustomers ON TaNNInvSaleItems.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSaleItems.CenterFrontID = @CenterFrontID)";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.TxTTitle = new Label();
            this.CheckBoxNote = new CheckBox();
            this.CheckBoxDate = new CheckBox();
            this.CheckBoxCustomer = new CheckBox();
            this.CheckBoxUser = new CheckBox();
            this.CheckBoxType = new CheckBox();
            this.GroupBoxNT = new GroupBox();
            this.TxTNoSe = new TextBox();
            this.GroupBoxUsers = new GroupBox();
            this.ComboBoxUser = new ComboBox();
            this.GroupBoxC = new GroupBox();
            this.ComboBoxCustomer = new ComboBox();
            this.GroupBoxType = new GroupBox();
            this.InvType = new ComboBox();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.CheckBoxBarCode = new CheckBox();
            this.CheckBoxMaterialName = new CheckBox();
            this.GroupBoxMaterialName = new GroupBox();
            this.ComboBoxMName = new ComboBox();
            this.GroupBoxBarCode = new GroupBox();
            this.ComboBoxMBarCode = new ComboBox();
            this.CheckBoxGroup = new CheckBox();
            this.GroupBoxGroup = new GroupBox();
            this.ComboBoxGrop = new ComboBox();
            this.TimersStartUp = new Timer(this.A);
            this.GroupBoxDF = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBoxDT = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.GroupBoxMAX = new GroupBox();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.TxTMaxSerch2 = new TextBox();
            this.TxTMaxSerch1 = new TextBox();
            this.CheckBoxMAX = new CheckBox();
            this.GroupBoxNT.SuspendLayout();
            this.GroupBoxUsers.SuspendLayout();
            this.GroupBoxC.SuspendLayout();
            this.GroupBoxType.SuspendLayout();
            this.GroupBoxMaterialName.SuspendLayout();
            this.GroupBoxBarCode.SuspendLayout();
            this.GroupBoxGroup.SuspendLayout();
            this.GroupBoxDF.SuspendLayout();
            this.GroupBoxDT.SuspendLayout();
            this.GroupBoxMAX.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1e6, 0x22);
            this.TxTTitle.TabIndex = 0x1ed36d6;
            this.TxTTitle.Text = "الفرز المتقدم لسجل المبيعات/ مرتجع المبيعات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.CheckBoxNote.AutoSize = true;
            this.CheckBoxNote.Location = new Point(0x179, 0x23e);
            this.CheckBoxNote.Name = "CheckBoxNote";
            this.CheckBoxNote.Size = new Size(0x58, 20);
            this.CheckBoxNote.TabIndex = 0x1ed36ee;
            this.CheckBoxNote.Text = "تضمين ذلك";
            this.CheckBoxNote.UseVisualStyleBackColor = true;
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.Location = new Point(0x178, 0x83);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Size = new Size(0x58, 20);
            this.CheckBoxDate.TabIndex = 0x1ed36ed;
            this.CheckBoxDate.Text = "تضمين ذلك";
            this.CheckBoxDate.UseVisualStyleBackColor = true;
            this.CheckBoxCustomer.AutoSize = true;
            this.CheckBoxCustomer.Location = new Point(0x17b, 0x1c1);
            this.CheckBoxCustomer.Name = "CheckBoxCustomer";
            this.CheckBoxCustomer.Size = new Size(0x58, 20);
            this.CheckBoxCustomer.TabIndex = 0x1ed36ec;
            this.CheckBoxCustomer.Text = "تضمين ذلك";
            this.CheckBoxCustomer.UseVisualStyleBackColor = true;
            this.CheckBoxUser.AutoSize = true;
            this.CheckBoxUser.Location = new Point(0x179, 510);
            this.CheckBoxUser.Name = "CheckBoxUser";
            this.CheckBoxUser.Size = new Size(0x58, 20);
            this.CheckBoxUser.TabIndex = 0x1ed36eb;
            this.CheckBoxUser.Text = "تضمين ذلك";
            this.CheckBoxUser.UseVisualStyleBackColor = true;
            this.CheckBoxType.AutoSize = true;
            this.CheckBoxType.Checked = true;
            this.CheckBoxType.CheckState = CheckState.Checked;
            this.CheckBoxType.Enabled = false;
            this.CheckBoxType.Location = new Point(0x177, 0x3e);
            this.CheckBoxType.Name = "CheckBoxType";
            this.CheckBoxType.Size = new Size(0x58, 20);
            this.CheckBoxType.TabIndex = 0x1ed36ea;
            this.CheckBoxType.Text = "تضمين ذلك";
            this.CheckBoxType.UseVisualStyleBackColor = true;
            this.GroupBoxNT.Controls.Add(this.TxTNoSe);
            this.GroupBoxNT.Enabled = false;
            this.GroupBoxNT.Location = new Point(11, 550);
            this.GroupBoxNT.Name = "GroupBoxNT";
            this.GroupBoxNT.Size = new Size(360, 0x34);
            this.GroupBoxNT.TabIndex = 0x1ed36e5;
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
            this.GroupBoxUsers.Controls.Add(this.ComboBoxUser);
            this.GroupBoxUsers.Enabled = false;
            this.GroupBoxUsers.Location = new Point(11, 0x1e6);
            this.GroupBoxUsers.Name = "GroupBoxUsers";
            this.GroupBoxUsers.Size = new Size(0x166, 0x35);
            this.GroupBoxUsers.TabIndex = 0x1ed36e4;
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
            this.GroupBoxC.Controls.Add(this.ComboBoxCustomer);
            this.GroupBoxC.Enabled = false;
            this.GroupBoxC.Location = new Point(11, 0x1aa);
            this.GroupBoxC.Name = "GroupBoxC";
            this.GroupBoxC.Size = new Size(0x166, 0x36);
            this.GroupBoxC.TabIndex = 0x1ed36e3;
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
            this.GroupBoxType.Controls.Add(this.InvType);
            this.GroupBoxType.Enabled = false;
            this.GroupBoxType.Location = new Point(11, 0x27);
            this.GroupBoxType.Name = "GroupBoxType";
            this.GroupBoxType.Size = new Size(0x166, 0x35);
            this.GroupBoxType.TabIndex = 0x1ed36e0;
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
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(13, 0x269);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0xeb, 0x2c);
            this.ButtonOK.TabIndex = 0x1ed36e8;
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
            this.ButtonClose.Location = new Point(0xfe, 0x269);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x74, 0x2c);
            this.ButtonClose.TabIndex = 0x1ed36e9;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.CheckBoxBarCode.AutoSize = true;
            this.CheckBoxBarCode.Location = new Point(0x179, 0xc7);
            this.CheckBoxBarCode.Name = "CheckBoxBarCode";
            this.CheckBoxBarCode.Size = new Size(0x58, 20);
            this.CheckBoxBarCode.TabIndex = 0x1ed36f3;
            this.CheckBoxBarCode.Text = "تضمين ذلك";
            this.CheckBoxBarCode.UseVisualStyleBackColor = true;
            this.CheckBoxMaterialName.AutoSize = true;
            this.CheckBoxMaterialName.Location = new Point(0x179, 0x106);
            this.CheckBoxMaterialName.Name = "CheckBoxMaterialName";
            this.CheckBoxMaterialName.Size = new Size(0x58, 20);
            this.CheckBoxMaterialName.TabIndex = 0x1ed36f2;
            this.CheckBoxMaterialName.Text = "تضمين ذلك";
            this.CheckBoxMaterialName.UseVisualStyleBackColor = true;
            this.GroupBoxMaterialName.Controls.Add(this.ComboBoxMName);
            this.GroupBoxMaterialName.Enabled = false;
            this.GroupBoxMaterialName.Location = new Point(11, 0xee);
            this.GroupBoxMaterialName.Name = "GroupBoxMaterialName";
            this.GroupBoxMaterialName.Size = new Size(0x166, 0x35);
            this.GroupBoxMaterialName.TabIndex = 0x1ed36f1;
            this.GroupBoxMaterialName.TabStop = false;
            this.GroupBoxMaterialName.Text = "اسم المادة";
            this.ComboBoxMName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxMName.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxMName.Dock = DockStyle.Top;
            this.ComboBoxMName.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxMName.FormattingEnabled = true;
            this.ComboBoxMName.IntegralHeight = false;
            this.ComboBoxMName.Location = new Point(3, 0x13);
            this.ComboBoxMName.Name = "ComboBoxMName";
            this.ComboBoxMName.Size = new Size(0x160, 0x1b);
            this.ComboBoxMName.TabIndex = 0x3b;
            this.GroupBoxBarCode.Controls.Add(this.ComboBoxMBarCode);
            this.GroupBoxBarCode.Enabled = false;
            this.GroupBoxBarCode.Location = new Point(11, 0xb2);
            this.GroupBoxBarCode.Name = "GroupBoxBarCode";
            this.GroupBoxBarCode.Size = new Size(0x166, 0x36);
            this.GroupBoxBarCode.TabIndex = 0x1ed36f0;
            this.GroupBoxBarCode.TabStop = false;
            this.GroupBoxBarCode.Text = "رقم/ باركود المادة";
            this.ComboBoxMBarCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxMBarCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxMBarCode.Dock = DockStyle.Fill;
            this.ComboBoxMBarCode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxMBarCode.FormattingEnabled = true;
            this.ComboBoxMBarCode.IntegralHeight = false;
            object[] objArray2 = new object[] { "تم اجراء حركات عليهم", "لم يتم اجراء حركات عليهم" };
            this.ComboBoxMBarCode.Items.AddRange(objArray2);
            this.ComboBoxMBarCode.Location = new Point(3, 0x13);
            this.ComboBoxMBarCode.Name = "ComboBoxMBarCode";
            this.ComboBoxMBarCode.Size = new Size(0x160, 0x18);
            this.ComboBoxMBarCode.TabIndex = 0x44;
            this.CheckBoxGroup.AutoSize = true;
            this.CheckBoxGroup.Location = new Point(0x178, 0x185);
            this.CheckBoxGroup.Name = "CheckBoxGroup";
            this.CheckBoxGroup.Size = new Size(0x58, 20);
            this.CheckBoxGroup.TabIndex = 0x1ed36f5;
            this.CheckBoxGroup.Text = "تضمين ذلك";
            this.CheckBoxGroup.UseVisualStyleBackColor = true;
            this.GroupBoxGroup.Controls.Add(this.ComboBoxGrop);
            this.GroupBoxGroup.Enabled = false;
            this.GroupBoxGroup.Location = new Point(11, 0x16e);
            this.GroupBoxGroup.Name = "GroupBoxGroup";
            this.GroupBoxGroup.Size = new Size(0x166, 0x36);
            this.GroupBoxGroup.TabIndex = 0x1ed36f4;
            this.GroupBoxGroup.TabStop = false;
            this.GroupBoxGroup.Text = "المجموعة";
            this.ComboBoxGrop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxGrop.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxGrop.Dock = DockStyle.Fill;
            this.ComboBoxGrop.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxGrop.FormattingEnabled = true;
            this.ComboBoxGrop.IntegralHeight = false;
            this.ComboBoxGrop.Location = new Point(3, 0x13);
            this.ComboBoxGrop.Name = "ComboBoxGrop";
            this.ComboBoxGrop.Size = new Size(0x160, 0x18);
            this.ComboBoxGrop.TabIndex = 0x45;
            this.TimersStartUp.Interval = 0x3e8;
            this.GroupBoxDF.Controls.Add(this.DateTimePickerFrom);
            this.GroupBoxDF.Controls.Add(this.PickerTimeFrom);
            this.GroupBoxDF.Enabled = false;
            this.GroupBoxDF.Location = new Point(11, 0x62);
            this.GroupBoxDF.Name = "GroupBoxDF";
            this.GroupBoxDF.Size = new Size(0xb0, 0x4a);
            this.GroupBoxDF.TabIndex = 0x1ed36f6;
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
            this.GroupBoxDT.Location = new Point(0xc5, 0x62);
            this.GroupBoxDT.Name = "GroupBoxDT";
            this.GroupBoxDT.Size = new Size(0xb0, 0x48);
            this.GroupBoxDT.TabIndex = 0x1ed36f7;
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
            this.GroupBoxMAX.BackColor = Color.White;
            this.GroupBoxMAX.Controls.Add(this.Label2);
            this.GroupBoxMAX.Controls.Add(this.Label1);
            this.GroupBoxMAX.Controls.Add(this.TxTMaxSerch2);
            this.GroupBoxMAX.Controls.Add(this.TxTMaxSerch1);
            this.GroupBoxMAX.Enabled = false;
            this.GroupBoxMAX.Location = new Point(11, 0x129);
            this.GroupBoxMAX.Name = "GroupBoxMAX";
            this.GroupBoxMAX.Size = new Size(0x167, 0x3b);
            this.GroupBoxMAX.TabIndex = 0x1ed36f8;
            this.GroupBoxMAX.TabStop = false;
            this.GroupBoxMAX.Text = "البحث في تسلسل الفواتير";
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0x72, 0x1c);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x21, 0x10);
            this.Label2.TabIndex = 0x53;
            this.Label2.Text = "الى:";
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(0x139, 0x1b);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(30, 0x10);
            this.Label1.TabIndex = 0x52;
            this.Label1.Text = "من:";
            this.TxTMaxSerch2.BackColor = Color.White;
            this.TxTMaxSerch2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMaxSerch2.Location = new Point(0x12, 0x15);
            this.TxTMaxSerch2.Name = "TxTMaxSerch2";
            this.TxTMaxSerch2.RightToLeft = RightToLeft.No;
            this.TxTMaxSerch2.Size = new Size(90, 0x1b);
            this.TxTMaxSerch2.TabIndex = 0x51;
            this.TxTMaxSerch2.TextAlign = HorizontalAlignment.Center;
            this.TxTMaxSerch1.BackColor = Color.White;
            this.TxTMaxSerch1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMaxSerch1.Location = new Point(0xd9, 0x16);
            this.TxTMaxSerch1.Name = "TxTMaxSerch1";
            this.TxTMaxSerch1.RightToLeft = RightToLeft.No;
            this.TxTMaxSerch1.Size = new Size(90, 0x1b);
            this.TxTMaxSerch1.TabIndex = 80;
            this.TxTMaxSerch1.TextAlign = HorizontalAlignment.Center;
            this.CheckBoxMAX.AutoSize = true;
            this.CheckBoxMAX.Location = new Point(0x179, 0x146);
            this.CheckBoxMAX.Name = "CheckBoxMAX";
            this.CheckBoxMAX.Size = new Size(0x58, 20);
            this.CheckBoxMAX.TabIndex = 0x1ed36f9;
            this.CheckBoxMAX.Text = "تضمين ذلك";
            this.CheckBoxMAX.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x1e6, 0x29d);
            base.ControlBox = false;
            base.Controls.Add(this.CheckBoxMAX);
            base.Controls.Add(this.GroupBoxMAX);
            base.Controls.Add(this.GroupBoxDF);
            base.Controls.Add(this.GroupBoxDT);
            base.Controls.Add(this.CheckBoxGroup);
            base.Controls.Add(this.GroupBoxGroup);
            base.Controls.Add(this.CheckBoxBarCode);
            base.Controls.Add(this.CheckBoxMaterialName);
            base.Controls.Add(this.GroupBoxMaterialName);
            base.Controls.Add(this.GroupBoxBarCode);
            base.Controls.Add(this.CheckBoxNote);
            base.Controls.Add(this.CheckBoxDate);
            base.Controls.Add(this.CheckBoxCustomer);
            base.Controls.Add(this.CheckBoxUser);
            base.Controls.Add(this.CheckBoxType);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.GroupBoxNT);
            base.Controls.Add(this.GroupBoxUsers);
            base.Controls.Add(this.GroupBoxC);
            base.Controls.Add(this.GroupBoxType);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "InvoiceSaleItemsSearch";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "الفرز المتقدم لسجل المبيعات/ مرتجع المبيعات";
            this.GroupBoxNT.ResumeLayout(false);
            this.GroupBoxNT.PerformLayout();
            this.GroupBoxUsers.ResumeLayout(false);
            this.GroupBoxC.ResumeLayout(false);
            this.GroupBoxType.ResumeLayout(false);
            this.GroupBoxMaterialName.ResumeLayout(false);
            this.GroupBoxBarCode.ResumeLayout(false);
            this.GroupBoxGroup.ResumeLayout(false);
            this.GroupBoxDF.ResumeLayout(false);
            this.GroupBoxDT.ResumeLayout(false);
            this.GroupBoxMAX.ResumeLayout(false);
            this.GroupBoxMAX.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void D(object A, EventArgs R)
        {
            if (this.CheckBoxBarCode.Checked)
            {
                this.GroupBoxBarCode.Enabled = true;
            }
            else
            {
                this.GroupBoxBarCode.Enabled = false;
                this.ComboBoxMBarCode.Text = null;
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

        private void E(object A, EventArgs R)
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

        private void F(object A, EventArgs R)
        {
            if (this.CheckBoxMaterialName.Checked)
            {
                this.GroupBoxMaterialName.Enabled = true;
            }
            else
            {
                this.GroupBoxMaterialName.Enabled = false;
                this.ComboBoxMName.Text = null;
            }
        }

        private void G(object A, EventArgs R)
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

        private void H(object A, EventArgs R)
        {
            if (this.CheckBoxGroup.Checked)
            {
                this.GroupBoxGroup.Enabled = true;
            }
            else
            {
                this.GroupBoxGroup.Enabled = false;
                this.ComboBoxGrop.Text = null;
            }
        }

        public void I()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT [MaterialBarCode], [MaterialName] FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxMBarCode.ValueMember = "MaterialBarCode";
                    this.ComboBoxMBarCode.DisplayMember = "MaterialBarCode";
                    this.ComboBoxMBarCode.DataSource = dataTable;
                    this.ComboBoxMBarCode.SelectedIndex = -1;
                    this.ComboBoxMName.ValueMember = "MaterialBarCode";
                    this.ComboBoxMName.DisplayMember = "MaterialName";
                    this.ComboBoxMName.DataSource = dataTable;
                    this.ComboBoxMName.SelectedIndex = -1;
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

        private void K(object A, EventArgs R)
        {
            this.GroupBoxMAX.Enabled = this.CheckBoxMAX.Checked;
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
            this.TimersStartUp.Enabled = false;
            this.R();
            this.P();
            this.Q();
            this.I();
            this.TxTTitle.Text = this.Text;
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Font = new Font("Tahoma", 12f);
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
                string selectCommandText = "SELECT [GroupID], [GroupName] FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxGrop.ValueMember = "GroupID";
                    this.ComboBoxGrop.DisplayMember = "GroupName";
                    this.ComboBoxGrop.DataSource = dataTable;
                    this.ComboBoxGrop.SelectedIndex = -1;
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
            if (this.CheckBoxType.Checked)
            {
                if ((this.InvType.SelectedIndex == 0) | (this.InvType.SelectedIndex == 1))
                {
                    this.A = this.A + " AND (TaNNInvSaleItems.HSaleType = @HSaleType)";
                }
                A.D.A.A.HSaleType.SelectedIndex = this.InvType.SelectedIndex;
            }
            if (this.CheckBoxDate.Checked)
            {
                this.A = this.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT)";
                A.D.A.A.DateTimePickerTo.Value = this.DateTimePickerTo.Value;
                A.D.A.A.DateTimePickerFrom.Value = this.DateTimePickerFrom.Value;
                A.D.A.A.PickerTimeFrom.Value = this.PickerTimeFrom.Value;
                A.D.A.A.PickerTimeFrom.Value = this.PickerTimeFrom.Value;
            }
            if (this.CheckBoxBarCode.Checked)
            {
                this.A = this.A + " AND (TaNNInvSaleItems.HSaleBarCode = @HSaleBarCode)";
                A.D.A.A.TxTMaterialBarcode.Text = this.ComboBoxMBarCode.Text;
            }
            if (this.CheckBoxMaterialName.Checked)
            {
                this.A = this.A + " AND (TaNNInvSaleItems.HSaleName LIKE '%' + @HSaleName + '%')";
                A.D.A.A.TxTMaterialName.Text = this.ComboBoxMBarCode.Text;
            }
            if (this.CheckBoxGroup.Checked)
            {
                this.A = this.A + " AND (TaNNInvSaleItems.GroupIDFrontID = @GroupIDFrontID)";
                A.D.A.A.ComboBoxGrop.SelectedIndex = this.ComboBoxGrop.SelectedIndex;
            }
            if (this.CheckBoxCustomer.Checked)
            {
                this.A = this.A + " AND (TaNNInvSaleItems.CustomerFrontID = @CustomerFrontID)";
                A.D.A.A.ComboBoxCustomer.SelectedValue = this.ComboBoxCustomer.SelectedValue;
            }
            if (this.CheckBoxUser.Checked)
            {
                this.A = this.A + " AND (TaNNInvSaleItems.HSaleUserAddBy = @HSaleUserAddBy)";
                A.D.A.A.ComboBoxUser.Text = this.ComboBoxUser.Text;
            }
            if (this.CheckBoxNote.Checked)
            {
                this.A = this.A + " AND (TaNNInvSaleItems.HSaleNote LIKE '%' + @HSaleNote + '%')";
                A.D.A.A.TxTNoSe.Text = this.TxTNoSe.Text;
            }
            if (this.CheckBoxMAX.Checked)
            {
                this.A = this.A + " AND (TaNNInvSaleItems.HInvSaleIDMAX BETWEEN @MAXDF and @MAXDT)";
                A.D.A.A.TxTMaxSerch1.Text = this.TxTMaxSerch1.Text;
                A.D.A.A.TxTMaxSerch2.Text = this.TxTMaxSerch2.Text;
            }
            VD.R = this.A;
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
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.PickerTimeFrom.Value = Conversions.ToDate(DateTime.Now.Date.ToString("yyyy/MM/dd 00:00"));
            this.PickerTimeTo.Value = Conversions.ToDate(DateTime.Now.Date.ToString("yyyy/MM/dd 23:59"));
            this.TimersStartUp.Enabled = true;
            this.InvType.SelectedIndex = 0;
        }

        private void T(object A, EventArgs R)
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

        private void X(object A, EventArgs R)
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

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxNote
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual CheckBox CheckBoxDate
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

        internal virtual CheckBox CheckBoxCustomer
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual CheckBox CheckBoxUser
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual CheckBox CheckBoxType
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual Button ButtonOK
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual GroupBox GroupBoxNT
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual GroupBox GroupBoxUsers
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual GroupBox GroupBoxC
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual GroupBox GroupBoxType
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ComboBox InvType
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual CheckBox CheckBoxBarCode
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual CheckBox CheckBoxMaterialName
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual GroupBox GroupBoxMaterialName
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ComboBox ComboBoxMName
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBoxBarCode
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual ComboBox ComboBoxMBarCode
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox CheckBoxGroup
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                CheckBox h = this.H;
                if (h != null)
                {
                    h.CheckedChanged -= handler;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.CheckedChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBoxGroup
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual ComboBox ComboBoxGrop
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Timer TimersStartUp
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual GroupBox GroupBoxDF
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
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

        internal virtual GroupBox GroupBoxMAX
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTMaxSerch2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTMaxSerch1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual CheckBox CheckBoxMAX
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                CheckBox t = this.T;
                if (t != null)
                {
                    t.CheckedChanged -= handler;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.CheckedChanged += handler;
                }
            }
        }
    }
}

