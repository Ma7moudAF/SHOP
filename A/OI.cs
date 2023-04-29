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
    public class OI : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonOK")]
        private Button A;
        [AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerName"), CompilerGenerated]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2")]
        private GroupBox R;
        [AccessedThroughProperty("CustomerAddress"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox P;
        [AccessedThroughProperty("CustomerPhone"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox4"), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("CustomerNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Q;
        [AccessedThroughProperty("CustomerPoints"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerApplyIfPoints")]
        private TextBox D;
        [CompilerGenerated, AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [AccessedThroughProperty("CustomerDiscount"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox F;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage1")]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage2"), CompilerGenerated]
        private TabPage R;
        [AccessedThroughProperty("TabPage3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [AccessedThroughProperty("CustomerPriceType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("TabPage4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage Q;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerGiftBarcode"), CompilerGenerated]
        private TextBox H;
        [AccessedThroughProperty("GroupBox9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [CompilerGenerated, AccessedThroughProperty("CustomerGiftExpDate"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox11")]
        private GroupBox X;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerGiftDisVal")]
        private TextBox T;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox10")]
        private GroupBox G;
        [AccessedThroughProperty("CustomerGiftDisMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox X;
        [AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox E;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerGiftCount")]
        private TextBox G;
        [AccessedThroughProperty("GroupBox13"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerGiftNote"), CompilerGenerated]
        private TextBox E;
        [CompilerGenerated, AccessedThroughProperty("GroupBox14"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox U;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerEmail")]
        private TextBox K;
        [CompilerGenerated, AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [CompilerGenerated, AccessedThroughProperty("TabPage5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox22")]
        private GroupBox L;
        [AccessedThroughProperty("CuCountrySubentity"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox U;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox21"), CompilerGenerated]
        private GroupBox N;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CuCityName")]
        private TextBox L;
        [AccessedThroughProperty("GroupBox20"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox V;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CuCitySubdivisionName")]
        private TextBox N;
        [AccessedThroughProperty("GroupBox19"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Y;
        [AccessedThroughProperty("CuPlotIdentification"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox V;
        [CompilerGenerated, AccessedThroughProperty("GroupBox18"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox O;
        [AccessedThroughProperty("CuBuildingNumber"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Y;
        [AccessedThroughProperty("GroupBox17"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox B;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CuStreetName"), CompilerGenerated]
        private TextBox O;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox16")]
        private GroupBox S;
        [AccessedThroughProperty("CuSchemeID"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox B;
        [AccessedThroughProperty("GroupBox15"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Z;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CuSchemeTy")]
        private ComboBox R;
        [CompilerGenerated, AccessedThroughProperty("Label4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox23")]
        private GroupBox M;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ChKActiveDate")]
        private CheckBox A;
        [AccessedThroughProperty("CuExpDat"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox24"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox C;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CuCompanyID"), CompilerGenerated]
        private TextBox S;
        [CompilerGenerated, AccessedThroughProperty("ButtoPrintGift"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [AccessedThroughProperty("GroupBox25"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox J;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CuPostCode")]
        private TextBox Z;
        [AccessedThroughProperty("GroupBox26"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox W;
        [AccessedThroughProperty("CuMorID"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox M;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonHelp")]
        private Button Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox27")]
        private GroupBox AR;
        [AccessedThroughProperty("CusLimitDebit"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox C;
        private SqlConnection A;
        public static int A;
        public bool A;

        public OI()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.X);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = false;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.GroupBox1 = new GroupBox();
            this.CustomerName = new TextBox();
            this.GroupBox2 = new GroupBox();
            this.CustomerAddress = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.CustomerPhone = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.Label1 = new Label();
            this.CustomerNote = new TextBox();
            this.CustomerPoints = new TextBox();
            this.CustomerApplyIfPoints = new TextBox();
            this.GroupBox6 = new GroupBox();
            this.GroupBox7 = new GroupBox();
            this.GroupBox8 = new GroupBox();
            this.CustomerDiscount = new TextBox();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox14 = new GroupBox();
            this.Label3 = new Label();
            this.CustomerEmail = new TextBox();
            this.TabPage2 = new TabPage();
            this.TabPage3 = new TabPage();
            this.CustomerPriceType = new ComboBox();
            this.TabPage4 = new TabPage();
            this.ButtoPrintGift = new Button();
            this.GroupBox13 = new GroupBox();
            this.CustomerGiftNote = new TextBox();
            this.GroupBox12 = new GroupBox();
            this.CustomerGiftCount = new TextBox();
            this.GroupBox11 = new GroupBox();
            this.CustomerGiftDisVal = new TextBox();
            this.GroupBox10 = new GroupBox();
            this.CustomerGiftDisMiWi = new TextBox();
            this.Label2 = new Label();
            this.GroupBox9 = new GroupBox();
            this.CustomerGiftExpDate = new DateTimePicker();
            this.GroupBox5 = new GroupBox();
            this.CustomerGiftBarcode = new TextBox();
            this.TabPage5 = new TabPage();
            this.GroupBox26 = new GroupBox();
            this.CuMorID = new TextBox();
            this.GroupBox25 = new GroupBox();
            this.CuPostCode = new TextBox();
            this.GroupBox23 = new GroupBox();
            this.ChKActiveDate = new CheckBox();
            this.CuExpDat = new DateTimePicker();
            this.GroupBox24 = new GroupBox();
            this.CuCompanyID = new TextBox();
            this.GroupBox22 = new GroupBox();
            this.CuCountrySubentity = new TextBox();
            this.GroupBox21 = new GroupBox();
            this.CuCityName = new TextBox();
            this.GroupBox20 = new GroupBox();
            this.CuCitySubdivisionName = new TextBox();
            this.GroupBox19 = new GroupBox();
            this.CuPlotIdentification = new TextBox();
            this.GroupBox17 = new GroupBox();
            this.CuStreetName = new TextBox();
            this.GroupBox16 = new GroupBox();
            this.CuSchemeID = new TextBox();
            this.GroupBox18 = new GroupBox();
            this.CuBuildingNumber = new TextBox();
            this.GroupBox15 = new GroupBox();
            this.ButtonHelp = new Button();
            this.CuSchemeTy = new ComboBox();
            this.Label4 = new Label();
            this.GroupBox27 = new GroupBox();
            this.CusLimitDebit = new TextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox26.SuspendLayout();
            this.GroupBox25.SuspendLayout();
            this.GroupBox23.SuspendLayout();
            this.GroupBox24.SuspendLayout();
            this.GroupBox22.SuspendLayout();
            this.GroupBox21.SuspendLayout();
            this.GroupBox20.SuspendLayout();
            this.GroupBox19.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox18.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox27.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x263, 0x30);
            this.TxTTitle.TabIndex = 0x1d;
            this.TxTTitle.Text = "اضافة/ تعديل عميل";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(12, 0x1c7);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x1aa, 0x2c);
            this.ButtonOK.TabIndex = 30;
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
            this.ButtonClose.Location = new Point(0x1bc, 0x1c7);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(140, 0x2c);
            this.ButtonClose.TabIndex = 0x1f;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.CustomerName);
            this.GroupBox1.Location = new Point(8, 0x1a);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x236, 0x31);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "اسم العميل";
            this.CustomerName.BackColor = SystemColors.Info;
            this.CustomerName.Dock = DockStyle.Fill;
            this.CustomerName.Location = new Point(3, 0x13);
            this.CustomerName.MaxLength = 300;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new Size(560, 0x17);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox2.Controls.Add(this.CustomerAddress);
            this.GroupBox2.Location = new Point(8, 0x51);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x236, 0x33);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "العنوان";
            this.CustomerAddress.BackColor = Color.White;
            this.CustomerAddress.Dock = DockStyle.Fill;
            this.CustomerAddress.Location = new Point(3, 0x13);
            this.CustomerAddress.MaxLength = 50;
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new Size(560, 0x17);
            this.CustomerAddress.TabIndex = 1;
            this.CustomerAddress.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.CustomerPhone);
            this.GroupBox3.Location = new Point(8, 0x8a);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x236, 0x33);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم الهاتف";
            this.CustomerPhone.BackColor = Color.White;
            this.CustomerPhone.Dock = DockStyle.Fill;
            this.CustomerPhone.Location = new Point(3, 0x13);
            this.CustomerPhone.MaxLength = 50;
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.RightToLeft = RightToLeft.No;
            this.CustomerPhone.Size = new Size(560, 0x17);
            this.CustomerPhone.TabIndex = 2;
            this.CustomerPhone.TextAlign = HorizontalAlignment.Center;
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.Controls.Add(this.CustomerNote);
            this.GroupBox4.Location = new Point(11, 9);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x239, 0x13c);
            this.GroupBox4.TabIndex = 0x23;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "ملاحظات/ معلومات اخرى ضع بينهما سطر لتظهر في الفاتورة مثال";
            this.Label1.Dock = DockStyle.Top;
            this.Label1.ForeColor = SystemColors.AppWorkspace;
            this.Label1.Location = new Point(3, 0x13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x233, 0x24);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "الرقم الضريبي: 1234\r\nالموقع الالكتروني: www.---.com";
            this.CustomerNote.BackColor = Color.White;
            this.CustomerNote.Dock = DockStyle.Bottom;
            this.CustomerNote.Location = new Point(3, 0x3a);
            this.CustomerNote.MaxLength = 0x9c4;
            this.CustomerNote.Multiline = true;
            this.CustomerNote.Name = "CustomerNote";
            this.CustomerNote.Size = new Size(0x233, 0xff);
            this.CustomerNote.TabIndex = 4;
            this.CustomerNote.TextAlign = HorizontalAlignment.Center;
            this.CustomerPoints.Dock = DockStyle.Fill;
            this.CustomerPoints.Location = new Point(3, 0x13);
            this.CustomerPoints.MaxLength = 20;
            this.CustomerPoints.Name = "CustomerPoints";
            this.CustomerPoints.RightToLeft = RightToLeft.No;
            this.CustomerPoints.Size = new Size(0x236, 0x17);
            this.CustomerPoints.TabIndex = 0x24;
            this.CustomerPoints.TextAlign = HorizontalAlignment.Center;
            this.CustomerApplyIfPoints.Dock = DockStyle.Fill;
            this.CustomerApplyIfPoints.Location = new Point(3, 0x13);
            this.CustomerApplyIfPoints.MaxLength = 20;
            this.CustomerApplyIfPoints.Name = "CustomerApplyIfPoints";
            this.CustomerApplyIfPoints.RightToLeft = RightToLeft.No;
            this.CustomerApplyIfPoints.Size = new Size(0x236, 0x17);
            this.CustomerApplyIfPoints.TabIndex = 40;
            this.CustomerApplyIfPoints.TextAlign = HorizontalAlignment.Center;
            this.GroupBox6.Controls.Add(this.CustomerApplyIfPoints);
            this.GroupBox6.Location = new Point(8, 0x80);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x23c, 0x34);
            this.GroupBox6.TabIndex = 0x2a;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "طبق نسبة الخصم في حال وصلت عدد النقاط الى";
            this.GroupBox7.Controls.Add(this.CustomerPoints);
            this.GroupBox7.Location = new Point(8, 0xba);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x23c, 0x33);
            this.GroupBox7.TabIndex = 0x2b;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "عدد النقاط الحالية";
            this.GroupBox8.Controls.Add(this.CustomerDiscount);
            this.GroupBox8.Location = new Point(8, 70);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x23c, 0x34);
            this.GroupBox8.TabIndex = 0x2c;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "نسبة الخصم %";
            this.CustomerDiscount.Dock = DockStyle.Fill;
            this.CustomerDiscount.Location = new Point(3, 0x13);
            this.CustomerDiscount.MaxLength = 20;
            this.CustomerDiscount.Name = "CustomerDiscount";
            this.CustomerDiscount.RightToLeft = RightToLeft.No;
            this.CustomerDiscount.Size = new Size(0x236, 0x17);
            this.CustomerDiscount.TabIndex = 0x24;
            this.CustomerDiscount.TextAlign = HorizontalAlignment.Center;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x30);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(8, 8);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x263, 0x183);
            this.TabControl1.TabIndex = 0x2d;
            this.TabPage1.Controls.Add(this.GroupBox27);
            this.TabPage1.Controls.Add(this.GroupBox14);
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new Point(4, 0x23);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x25b, 0x15c);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "معلومات العميل";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox14.Controls.Add(this.Label3);
            this.GroupBox14.Controls.Add(this.CustomerEmail);
            this.GroupBox14.Location = new Point(8, 0xc3);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0x236, 0x47);
            this.GroupBox14.TabIndex = 3;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "البريد الالكتروني للعميل الخاص في ارسال الاشعارات";
            this.Label3.Dock = DockStyle.Bottom;
            this.Label3.ForeColor = SystemColors.ButtonShadow;
            this.Label3.Location = new Point(3, 0x2d);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(560, 0x17);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "سيتم ارسال الفاتورة او وصل الدفع بصيغة PDF للعميل ان وجد البريد";
            this.Label3.TextAlign = ContentAlignment.MiddleCenter;
            this.CustomerEmail.BackColor = SystemColors.Info;
            this.CustomerEmail.Dock = DockStyle.Fill;
            this.CustomerEmail.Location = new Point(3, 0x13);
            this.CustomerEmail.MaxLength = 300;
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.RightToLeft = RightToLeft.No;
            this.CustomerEmail.Size = new Size(560, 0x17);
            this.CustomerEmail.TabIndex = 3;
            this.CustomerEmail.TextAlign = HorizontalAlignment.Center;
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Location = new Point(4, 0x23);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x25b, 0x15c);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "تفاصيل اخرى/ملاحظات";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.TabPage3.Controls.Add(this.GroupBox7);
            this.TabPage3.Controls.Add(this.CustomerPriceType);
            this.TabPage3.Controls.Add(this.GroupBox8);
            this.TabPage3.Controls.Add(this.GroupBox6);
            this.TabPage3.Location = new Point(4, 0x23);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new Padding(3);
            this.TabPage3.Size = new Size(0x25b, 0x15c);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "السعر الافتراضي والخصم";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.CustomerPriceType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CustomerPriceType.FormattingEnabled = true;
            object[] items = new object[] { "تطبيق سعر البيع الافتراضي العادي", "تطبيق سعر البيع المخفض", "تطبيق سعر التكلفة" };
            this.CustomerPriceType.Items.AddRange(items);
            this.CustomerPriceType.Location = new Point(8, 0x1f);
            this.CustomerPriceType.Name = "CustomerPriceType";
            this.CustomerPriceType.Size = new Size(0x23c, 0x18);
            this.CustomerPriceType.TabIndex = 0;
            this.TabPage4.Controls.Add(this.ButtoPrintGift);
            this.TabPage4.Controls.Add(this.GroupBox13);
            this.TabPage4.Controls.Add(this.GroupBox12);
            this.TabPage4.Controls.Add(this.GroupBox11);
            this.TabPage4.Controls.Add(this.GroupBox10);
            this.TabPage4.Controls.Add(this.Label2);
            this.TabPage4.Controls.Add(this.GroupBox9);
            this.TabPage4.Controls.Add(this.GroupBox5);
            this.TabPage4.Location = new Point(4, 0x23);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x25b, 0x15c);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "بطاقة الهدية";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.ButtoPrintGift.FlatAppearance.BorderColor = Color.Green;
            this.ButtoPrintGift.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtoPrintGift.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtoPrintGift.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtoPrintGift.FlatStyle = FlatStyle.Flat;
            this.ButtoPrintGift.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtoPrintGift.Image = A.F.ImPrint;
            this.ButtoPrintGift.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtoPrintGift.Location = new Point(0x12b, 0x129);
            this.ButtoPrintGift.Margin = new Padding(3, 4, 3, 4);
            this.ButtoPrintGift.Name = "ButtoPrintGift";
            this.ButtoPrintGift.Size = new Size(0x119, 0x2e);
            this.ButtoPrintGift.TabIndex = 0x2e;
            this.ButtoPrintGift.Text = "اطبع البطاقة A4";
            this.ButtoPrintGift.UseVisualStyleBackColor = true;
            this.GroupBox13.Controls.Add(this.CustomerGiftNote);
            this.GroupBox13.Location = new Point(14, 0xb5);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x117, 0xa3);
            this.GroupBox13.TabIndex = 0x30;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "ملاحظات البطاقة";
            this.CustomerGiftNote.Dock = DockStyle.Bottom;
            this.CustomerGiftNote.Location = new Point(3, 0x1a);
            this.CustomerGiftNote.MaxLength = 0xbb8;
            this.CustomerGiftNote.Multiline = true;
            this.CustomerGiftNote.Name = "CustomerGiftNote";
            this.CustomerGiftNote.RightToLeft = RightToLeft.No;
            this.CustomerGiftNote.Size = new Size(0x111, 0x86);
            this.CustomerGiftNote.TabIndex = 0x24;
            this.CustomerGiftNote.TextAlign = HorizontalAlignment.Center;
            this.GroupBox12.Controls.Add(this.CustomerGiftCount);
            this.GroupBox12.Location = new Point(14, 0x7b);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x236, 0x34);
            this.GroupBox12.TabIndex = 0x2f;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "عدد مرات الاستخدام المسموح بها";
            this.CustomerGiftCount.Dock = DockStyle.Bottom;
            this.CustomerGiftCount.Location = new Point(3, 0x1a);
            this.CustomerGiftCount.MaxLength = 20;
            this.CustomerGiftCount.Name = "CustomerGiftCount";
            this.CustomerGiftCount.RightToLeft = RightToLeft.No;
            this.CustomerGiftCount.Size = new Size(560, 0x17);
            this.CustomerGiftCount.TabIndex = 0x24;
            this.CustomerGiftCount.Text = "1";
            this.CustomerGiftCount.TextAlign = HorizontalAlignment.Center;
            this.GroupBox11.Controls.Add(this.CustomerGiftDisVal);
            this.GroupBox11.Location = new Point(0x12b, 0xef);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x119, 0x34);
            this.GroupBox11.TabIndex = 0x2f;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "مبلغ الخصم";
            this.CustomerGiftDisVal.Dock = DockStyle.Bottom;
            this.CustomerGiftDisVal.Location = new Point(3, 0x1a);
            this.CustomerGiftDisVal.MaxLength = 20;
            this.CustomerGiftDisVal.Name = "CustomerGiftDisVal";
            this.CustomerGiftDisVal.RightToLeft = RightToLeft.No;
            this.CustomerGiftDisVal.Size = new Size(0x113, 0x17);
            this.CustomerGiftDisVal.TabIndex = 0x24;
            this.CustomerGiftDisVal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox10.Controls.Add(this.CustomerGiftDisMiWi);
            this.GroupBox10.Location = new Point(0x12b, 0xb5);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x119, 0x34);
            this.GroupBox10.TabIndex = 0x2e;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "نسبة الخصم %";
            this.CustomerGiftDisMiWi.Dock = DockStyle.Bottom;
            this.CustomerGiftDisMiWi.Location = new Point(3, 0x1a);
            this.CustomerGiftDisMiWi.MaxLength = 4;
            this.CustomerGiftDisMiWi.Name = "CustomerGiftDisMiWi";
            this.CustomerGiftDisMiWi.RightToLeft = RightToLeft.No;
            this.CustomerGiftDisMiWi.Size = new Size(0x113, 0x17);
            this.CustomerGiftDisMiWi.TabIndex = 0x24;
            this.CustomerGiftDisMiWi.TextAlign = HorizontalAlignment.Center;
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = Color.Green;
            this.Label2.Location = new Point(0, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x25b, 0x34);
            this.Label2.TabIndex = 0x6f;
            this.Label2.Text = "يمكن لآي شخص حامل البطاقة الاستفادة منها حيث يمكن استخدامها في شاشة البيع لإجراء عملية الخصم على اجمالي قيمة الفاتورة";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox9.Controls.Add(this.CustomerGiftExpDate);
            this.GroupBox9.Location = new Point(14, 0x42);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x117, 0x33);
            this.GroupBox9.TabIndex = 0x3a;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "تاريخ الانتهاء";
            this.CustomerGiftExpDate.CustomFormat = "";
            this.CustomerGiftExpDate.Dock = DockStyle.Bottom;
            this.CustomerGiftExpDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CustomerGiftExpDate.Format = DateTimePickerFormat.Short;
            this.CustomerGiftExpDate.Location = new Point(3, 0x19);
            this.CustomerGiftExpDate.Margin = new Padding(3, 4, 3, 4);
            this.CustomerGiftExpDate.Name = "CustomerGiftExpDate";
            this.CustomerGiftExpDate.RightToLeft = RightToLeft.No;
            this.CustomerGiftExpDate.Size = new Size(0x111, 0x17);
            this.CustomerGiftExpDate.TabIndex = 3;
            this.GroupBox5.Controls.Add(this.CustomerGiftBarcode);
            this.GroupBox5.Location = new Point(0x128, 0x41);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x11c, 0x34);
            this.GroupBox5.TabIndex = 0x2d;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "رقم/ باركود البطاقة";
            this.CustomerGiftBarcode.Dock = DockStyle.Bottom;
            this.CustomerGiftBarcode.Location = new Point(3, 0x1a);
            this.CustomerGiftBarcode.MaxLength = 50;
            this.CustomerGiftBarcode.Name = "CustomerGiftBarcode";
            this.CustomerGiftBarcode.RightToLeft = RightToLeft.No;
            this.CustomerGiftBarcode.Size = new Size(0x116, 0x17);
            this.CustomerGiftBarcode.TabIndex = 0x24;
            this.CustomerGiftBarcode.TextAlign = HorizontalAlignment.Center;
            this.TabPage5.Controls.Add(this.GroupBox26);
            this.TabPage5.Controls.Add(this.GroupBox25);
            this.TabPage5.Controls.Add(this.GroupBox23);
            this.TabPage5.Controls.Add(this.GroupBox24);
            this.TabPage5.Controls.Add(this.GroupBox22);
            this.TabPage5.Controls.Add(this.GroupBox21);
            this.TabPage5.Controls.Add(this.GroupBox20);
            this.TabPage5.Controls.Add(this.GroupBox19);
            this.TabPage5.Controls.Add(this.GroupBox17);
            this.TabPage5.Controls.Add(this.GroupBox16);
            this.TabPage5.Controls.Add(this.GroupBox18);
            this.TabPage5.Controls.Add(this.GroupBox15);
            this.TabPage5.Controls.Add(this.Label4);
            this.TabPage5.Location = new Point(4, 0x23);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new Padding(3);
            this.TabPage5.Size = new Size(0x25b, 0x15c);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "تفاصيل قانونية";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.GroupBox26.Controls.Add(this.CuMorID);
            this.GroupBox26.Location = new Point(6, 0xe8);
            this.GroupBox26.Name = "GroupBox26";
            this.GroupBox26.Size = new Size(0x182, 0x47);
            this.GroupBox26.TabIndex = 6;
            this.GroupBox26.TabStop = false;
            this.GroupBox26.Text = "تفاصيل اخرى";
            this.CuMorID.Dock = DockStyle.Bottom;
            this.CuMorID.Location = new Point(3, 0x16);
            this.CuMorID.MaxLength = 50;
            this.CuMorID.Multiline = true;
            this.CuMorID.Name = "CuMorID";
            this.CuMorID.RightToLeft = RightToLeft.No;
            this.CuMorID.Size = new Size(380, 0x2e);
            this.CuMorID.TabIndex = 5;
            this.CuMorID.TextAlign = HorizontalAlignment.Center;
            this.GroupBox25.Controls.Add(this.CuPostCode);
            this.GroupBox25.Location = new Point(0x102, 0xa5);
            this.GroupBox25.Name = "GroupBox25";
            this.GroupBox25.Size = new Size(0x86, 0x34);
            this.GroupBox25.TabIndex = 6;
            this.GroupBox25.TabStop = false;
            this.GroupBox25.Text = "الرمز البريدي";
            this.CuPostCode.Dock = DockStyle.Bottom;
            this.CuPostCode.Location = new Point(3, 0x1a);
            this.CuPostCode.MaxLength = 50;
            this.CuPostCode.Name = "CuPostCode";
            this.CuPostCode.RightToLeft = RightToLeft.No;
            this.CuPostCode.Size = new Size(0x80, 0x17);
            this.CuPostCode.TabIndex = 5;
            this.CuPostCode.TextAlign = HorizontalAlignment.Center;
            this.GroupBox23.Controls.Add(this.ChKActiveDate);
            this.GroupBox23.Controls.Add(this.CuExpDat);
            this.GroupBox23.Location = new Point(0x18e, 0xdf);
            this.GroupBox23.Name = "GroupBox23";
            this.GroupBox23.Size = new Size(0xbd, 80);
            this.GroupBox23.TabIndex = 0x76;
            this.GroupBox23.TabStop = false;
            this.GroupBox23.Text = "تاريخ الانتهاء ووقف التعامل";
            this.ChKActiveDate.AutoSize = true;
            this.ChKActiveDate.Location = new Point(0x57, 0x1b);
            this.ChKActiveDate.Name = "ChKActiveDate";
            this.ChKActiveDate.Size = new Size(0x60, 20);
            this.ChKActiveDate.TabIndex = 0x51ec5;
            this.ChKActiveDate.Text = "تفعيل التاريخ";
            this.ChKActiveDate.UseVisualStyleBackColor = true;
            this.CuExpDat.CustomFormat = "yyyy/MM/dd";
            this.CuExpDat.Dock = DockStyle.Bottom;
            this.CuExpDat.Enabled = false;
            this.CuExpDat.Format = DateTimePickerFormat.Custom;
            this.CuExpDat.Location = new Point(3, 0x36);
            this.CuExpDat.Margin = new Padding(3, 4, 3, 4);
            this.CuExpDat.Name = "CuExpDat";
            this.CuExpDat.RightToLeft = RightToLeft.No;
            this.CuExpDat.Size = new Size(0xb7, 0x17);
            this.CuExpDat.TabIndex = 0x51ec4;
            this.GroupBox24.Controls.Add(this.CuCompanyID);
            this.GroupBox24.Location = new Point(6, 0x31);
            this.GroupBox24.Name = "GroupBox24";
            this.GroupBox24.Size = new Size(0xe3, 0x34);
            this.GroupBox24.TabIndex = 1;
            this.GroupBox24.TabStop = false;
            this.GroupBox24.Text = "الرقم الضريبي";
            this.CuCompanyID.Dock = DockStyle.Bottom;
            this.CuCompanyID.Location = new Point(3, 0x1a);
            this.CuCompanyID.MaxLength = 50;
            this.CuCompanyID.Name = "CuCompanyID";
            this.CuCompanyID.RightToLeft = RightToLeft.No;
            this.CuCompanyID.Size = new Size(0xdd, 0x17);
            this.CuCompanyID.TabIndex = 1;
            this.CuCompanyID.TextAlign = HorizontalAlignment.Center;
            this.GroupBox22.Controls.Add(this.CuCountrySubentity);
            this.GroupBox22.Location = new Point(0xc4, 0x6b);
            this.GroupBox22.Name = "GroupBox22";
            this.GroupBox22.Size = new Size(0xaf, 0x34);
            this.GroupBox22.TabIndex = 3;
            this.GroupBox22.TabStop = false;
            this.GroupBox22.Text = "البلد الفرعي";
            this.CuCountrySubentity.Dock = DockStyle.Bottom;
            this.CuCountrySubentity.Location = new Point(3, 0x1a);
            this.CuCountrySubentity.MaxLength = 50;
            this.CuCountrySubentity.Name = "CuCountrySubentity";
            this.CuCountrySubentity.RightToLeft = RightToLeft.No;
            this.CuCountrySubentity.Size = new Size(0xa9, 0x17);
            this.CuCountrySubentity.TabIndex = 3;
            this.CuCountrySubentity.TextAlign = HorizontalAlignment.Center;
            this.GroupBox21.Controls.Add(this.CuCityName);
            this.GroupBox21.Location = new Point(0x179, 0x6b);
            this.GroupBox21.Name = "GroupBox21";
            this.GroupBox21.Size = new Size(0xd3, 0x34);
            this.GroupBox21.TabIndex = 2;
            this.GroupBox21.TabStop = false;
            this.GroupBox21.Text = "اسم المدينة";
            this.CuCityName.Dock = DockStyle.Bottom;
            this.CuCityName.Location = new Point(3, 0x1a);
            this.CuCityName.MaxLength = 50;
            this.CuCityName.Name = "CuCityName";
            this.CuCityName.RightToLeft = RightToLeft.No;
            this.CuCityName.Size = new Size(0xcd, 0x17);
            this.CuCityName.TabIndex = 2;
            this.CuCityName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox20.Controls.Add(this.CuCitySubdivisionName);
            this.GroupBox20.Location = new Point(6, 0x6b);
            this.GroupBox20.Name = "GroupBox20";
            this.GroupBox20.Size = new Size(0xb8, 0x34);
            this.GroupBox20.TabIndex = 4;
            this.GroupBox20.TabStop = false;
            this.GroupBox20.Text = "الحي";
            this.CuCitySubdivisionName.Dock = DockStyle.Bottom;
            this.CuCitySubdivisionName.Location = new Point(3, 0x1a);
            this.CuCitySubdivisionName.MaxLength = 50;
            this.CuCitySubdivisionName.Name = "CuCitySubdivisionName";
            this.CuCitySubdivisionName.RightToLeft = RightToLeft.No;
            this.CuCitySubdivisionName.Size = new Size(0xb2, 0x17);
            this.CuCitySubdivisionName.TabIndex = 4;
            this.CuCitySubdivisionName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox19.Controls.Add(this.CuPlotIdentification);
            this.GroupBox19.Location = new Point(6, 0xa5);
            this.GroupBox19.Name = "GroupBox19";
            this.GroupBox19.Size = new Size(120, 0x34);
            this.GroupBox19.TabIndex = 6;
            this.GroupBox19.TabStop = false;
            this.GroupBox19.Text = "رقم الطابق";
            this.CuPlotIdentification.Dock = DockStyle.Bottom;
            this.CuPlotIdentification.Location = new Point(3, 0x1a);
            this.CuPlotIdentification.MaxLength = 50;
            this.CuPlotIdentification.Name = "CuPlotIdentification";
            this.CuPlotIdentification.RightToLeft = RightToLeft.No;
            this.CuPlotIdentification.Size = new Size(0x72, 0x17);
            this.CuPlotIdentification.TabIndex = 6;
            this.CuPlotIdentification.TextAlign = HorizontalAlignment.Center;
            this.GroupBox17.Controls.Add(this.CuStreetName);
            this.GroupBox17.Location = new Point(0x18e, 0xa5);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(190, 0x34);
            this.GroupBox17.TabIndex = 5;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "اسم الشارع";
            this.CuStreetName.Dock = DockStyle.Bottom;
            this.CuStreetName.Location = new Point(3, 0x1a);
            this.CuStreetName.MaxLength = 50;
            this.CuStreetName.Name = "CuStreetName";
            this.CuStreetName.RightToLeft = RightToLeft.No;
            this.CuStreetName.Size = new Size(0xb8, 0x17);
            this.CuStreetName.TabIndex = 5;
            this.CuStreetName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox16.Controls.Add(this.CuSchemeID);
            this.GroupBox16.Location = new Point(0xef, 0x31);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(0xbb, 0x34);
            this.GroupBox16.TabIndex = 1;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "رقم التسجيل/ التسلسل";
            this.CuSchemeID.Dock = DockStyle.Bottom;
            this.CuSchemeID.Location = new Point(3, 0x1a);
            this.CuSchemeID.MaxLength = 50;
            this.CuSchemeID.Name = "CuSchemeID";
            this.CuSchemeID.RightToLeft = RightToLeft.No;
            this.CuSchemeID.Size = new Size(0xb5, 0x17);
            this.CuSchemeID.TabIndex = 1;
            this.CuSchemeID.TextAlign = HorizontalAlignment.Center;
            this.GroupBox18.Controls.Add(this.CuBuildingNumber);
            this.GroupBox18.Location = new Point(0x84, 0xa5);
            this.GroupBox18.Name = "GroupBox18";
            this.GroupBox18.Size = new Size(120, 0x34);
            this.GroupBox18.TabIndex = 7;
            this.GroupBox18.TabStop = false;
            this.GroupBox18.Text = "رقم البناء";
            this.CuBuildingNumber.Dock = DockStyle.Bottom;
            this.CuBuildingNumber.Location = new Point(3, 0x1a);
            this.CuBuildingNumber.MaxLength = 50;
            this.CuBuildingNumber.Name = "CuBuildingNumber";
            this.CuBuildingNumber.RightToLeft = RightToLeft.No;
            this.CuBuildingNumber.Size = new Size(0x72, 0x17);
            this.CuBuildingNumber.TabIndex = 7;
            this.CuBuildingNumber.TextAlign = HorizontalAlignment.Center;
            this.GroupBox15.Controls.Add(this.ButtonHelp);
            this.GroupBox15.Controls.Add(this.CuSchemeTy);
            this.GroupBox15.Location = new Point(0x1b0, 0x31);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x9b, 0x34);
            this.GroupBox15.TabIndex = 0;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "نوع التسجيل";
            this.ButtonHelp.Location = new Point(120, 0x18);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new Size(0x1d, 0x1b);
            this.ButtonHelp.TabIndex = 0x77;
            this.ButtonHelp.Text = "?";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.CuSchemeTy.FormattingEnabled = true;
            object[] objArray2 = new object[10];
            objArray2[0] = "SAG";
            objArray2[1] = "CRN";
            objArray2[2] = "MOM";
            objArray2[3] = "MLS";
            objArray2[4] = "OTH";
            objArray2[5] = "NAT";
            objArray2[6] = "PAS";
            objArray2[7] = "GCC";
            objArray2[8] = "MOM";
            objArray2[9] = "IQA";
            this.CuSchemeTy.Items.AddRange(objArray2);
            this.CuSchemeTy.Location = new Point(6, 0x19);
            this.CuSchemeTy.Name = "CuSchemeTy";
            this.CuSchemeTy.RightToLeft = RightToLeft.No;
            this.CuSchemeTy.Size = new Size(0x6f, 0x18);
            this.CuSchemeTy.TabIndex = 0;
            this.CuSchemeTy.Text = "NAT";
            this.Label4.Dock = DockStyle.Top;
            this.Label4.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = Color.Red;
            this.Label4.Location = new Point(3, 3);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x255, 0x21);
            this.Label4.TabIndex = 0x70;
            this.Label4.Text = "تظهر البيانات التالية في طباعة الفواتير الضريبية والفواتير الإلكترونية";
            this.Label4.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox27.Controls.Add(this.CusLimitDebit);
            this.GroupBox27.Location = new Point(11, 0x119);
            this.GroupBox27.Name = "GroupBox27";
            this.GroupBox27.Size = new Size(0x236, 0x33);
            this.GroupBox27.TabIndex = 4;
            this.GroupBox27.TabStop = false;
            this.GroupBox27.Text = "وقف التعامل مع هذا العميل عندما يصبح رصيده الذمم يساوي او اكبر من";
            this.CusLimitDebit.BackColor = Color.White;
            this.CusLimitDebit.Dock = DockStyle.Fill;
            this.CusLimitDebit.Location = new Point(3, 0x13);
            this.CusLimitDebit.MaxLength = 20;
            this.CusLimitDebit.Name = "CusLimitDebit";
            this.CusLimitDebit.RightToLeft = RightToLeft.No;
            this.CusLimitDebit.Size = new Size(560, 0x17);
            this.CusLimitDebit.TabIndex = 2;
            this.CusLimitDebit.TextAlign = HorizontalAlignment.Center;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x263, 510);
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CustomerAddEdit";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة/ تعديل عميل";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox14.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox13.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.GroupBox26.ResumeLayout(false);
            this.GroupBox26.PerformLayout();
            this.GroupBox25.ResumeLayout(false);
            this.GroupBox25.PerformLayout();
            this.GroupBox23.ResumeLayout(false);
            this.GroupBox23.PerformLayout();
            this.GroupBox24.ResumeLayout(false);
            this.GroupBox24.PerformLayout();
            this.GroupBox22.ResumeLayout(false);
            this.GroupBox22.PerformLayout();
            this.GroupBox21.ResumeLayout(false);
            this.GroupBox21.PerformLayout();
            this.GroupBox20.ResumeLayout(false);
            this.GroupBox20.PerformLayout();
            this.GroupBox19.ResumeLayout(false);
            this.GroupBox19.PerformLayout();
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox17.PerformLayout();
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox16.PerformLayout();
            this.GroupBox18.ResumeLayout(false);
            this.GroupBox18.PerformLayout();
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox27.ResumeLayout(false);
            this.GroupBox27.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
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
        }

        private void D(object A, KeyPressEventArgs R)
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

        private void E(object A, EventArgs R)
        {
            if (!this.A)
            {
                Interaction.MsgBox("اضغط على زر موافق اولاً لحفظ المدخلات قبل الطباعة", MsgBoxStyle.ApplicationModal, null);
            }
            else if (this.CustomerGiftBarcode.Text == null)
            {
                Interaction.MsgBox("لا يوجد بطاقة هدية للعميل، يمكنك انشاء بطاقة من اجراء تعديل العميل في قائمة العملاء", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                FR.A = OI.A;
                FR.Q = this.CustomerGiftBarcode.Text;
                A.D.A.A.I();
            }
        }

        private void F(object A, EventArgs R)
        {
        }

        private void F(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void G(object A, EventArgs R)
        {
            this.CuExpDat.Enabled = this.ChKActiveDate.Checked;
        }

        private void H(object A, EventArgs R)
        {
        }

        private void H(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void I(object A, EventArgs R)
        {
        }

        private void I(object A, KeyPressEventArgs R)
        {
            if ((Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8) && !@"1234567890.-qwertyuiopasdfghjklzxcvbnm /*\!#$%^*(-)=+[{]};:'\.0><?".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox("رقم او كود المادة غير مدعوم يجب ان يتضمن ( حروف انجليزية، ارقام، رموز) فقط", MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void K(object A, EventArgs R)
        {
            Interaction.MsgBox("نوع التسجل مطلوب وهو نوع الرقم المسجل هل هو (CRN - رقم السجل التجاري)، (NAT - الرقم الوطني)، (PAS - رقم جواز السفر)، (TIN - رقم ضريبي)..الخ", MsgBoxStyle.ApplicationModal, null);
        }

        private void P(object A, EventArgs R)
        {
            if (Application.OpenForms.OfType<MI>().Any<MI>())
            {
                A.D.A.A.TimerLoadData.Enabled = true;
            }
            base.Dispose();
        }

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void Q(object A, EventArgs R)
        {
        }

        private void Q(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonOK.PerformClick();
            }
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            try
            {
                if ((OI.A == 0) & (this.CustomerPhone.Text != null))
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable dataTable = new DataTable();
                    string selectCommandText = "SELECT [CustomerName] FROM TaNNCustomers WHERE (CustomerPhone = @CustomerPhone)";
                    dataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CustomerPhone", this.CustomerPhone.Text);
                    adapter.Fill(dataTable);
                    this.A.Close();
                    TextBox box = new TextBox();
                    if (dataTable.Rows.Count > 0)
                    {
                        box.Text = dataTable.Rows[0]["CustomerName"].ToString();
                        if (Interaction.MsgBox("رقم الهاتف مدخل مسبقا مع اسم العميل: " + box.Text + " هل تريد الاستمرار على اي حال؟", MsgBoxStyle.OkCancel, "") == MsgBoxResult.Cancel)
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
                return;
            }
            try
            {
                if (this.CustomerGiftBarcode.Text != null)
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable dataTable = new DataTable();
                    string selectCommandText = (OI.A <= 0) ? "SELECT TOP(1) [CustomerName] FROM TaNNCustomers WHERE (CustomerGiftBarcode = @CustomerGiftBarcode)" : "SELECT TOP(1) [CustomerName] FROM TaNNCustomers WHERE (CustomerID <> @CustomerID) AND (CustomerGiftBarcode = @CustomerGiftBarcode)";
                    dataTable.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(selectCommandText, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CustomerID", OI.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CustomerGiftBarcode", this.CustomerGiftBarcode.Text);
                    adapter2.Fill(dataTable);
                    this.A.Close();
                    if (dataTable.Rows.Count <= 0)
                    {
                        if ((Conversion.Val(this.CustomerGiftDisMiWi.Text) > 0.0) & (Conversion.Val(this.CustomerGiftDisVal.Text) > 0.0))
                        {
                            Interaction.MsgBox("بطاقة الهدية يجب تحديد الخصم اما نسبة او مبلغ فقط", MsgBoxStyle.ApplicationModal, null);
                            return;
                        }
                    }
                    else
                    {
                        Interaction.MsgBox("رقم بطاقة الهدية مكرر مع بطاقة عميل اخر " + dataTable.Rows[0]["CustomerName"].ToString(), MsgBoxStyle.ApplicationModal, null);
                        return;
                    }
                }
                int num = 0;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string cmdText = "";
                cmdText = (OI.A <= 0) ? "INSERT INTO TaNNCustomers(CenterFrontID, CustomerName, CustomerPhone, CustomerAddress, CustomerNote, CustomerDiscount, CustomerPoints, CustomerPriceType, CustomerApplyIfPoints, CustomerDateConfigur, CustomerUserAddBy, CustomerGiftBarcode, CustomerGiftExpDate, CustomerGiftDisMiWi, CustomerGiftDisVal, CustomerGiftCount, CustomerGiftNote, CustomerEmail, CuSchemeID, CuSchemeTy, CuStreetName, CuBuildingNumber, CuPlotIdentification, CuCitySubdivisionName, CuCityName, CuCountrySubentity, CuCompanyID, CuExpDat, CuPostCode, CuMorID, CusLimitDebit) VALUES (@CenterFrontID, @CustomerName, @CustomerPhone, @CustomerAddress, @CustomerNote, @CustomerDiscount, @CustomerPoints, @CustomerPriceType, @CustomerApplyIfPoints, @CustomerDateConfigur, @CustomerUserAddBy, @CustomerGiftBarcode , @CustomerGiftExpDate,  @CustomerGiftDisMiWi, @CustomerGiftDisVal, @CustomerGiftCount, @CustomerGiftNote, @CustomerEmail, @CuSchemeID, @CuSchemeTy, @CuStreetName, @CuBuildingNumber, @CuPlotIdentification, @CuCitySubdivisionName, @CuCityName, @CuCountrySubentity, @CuCompanyID, @CuExpDat, @CuPostCode, @CuMorID, @CusLimitDebit); SELECT CustomerID FROM TaNNCustomers WHERE (CustomerID = SCOPE_IDENTITY())" : "UPDATE [TaNNCustomers] SET [CustomerName] = @CustomerName, [CustomerPhone] = @CustomerPhone, [CustomerAddress] = @CustomerAddress, [CustomerNote] = @CustomerNote, [CustomerDiscount] = @CustomerDiscount,  [CustomerPoints] = @CustomerPoints, [CustomerPriceType] = @CustomerPriceType, [CustomerApplyIfPoints] = @CustomerApplyIfPoints, [CustomerDateConfigur] = @CustomerDateConfigur, [CustomerUserAddBy] = @CustomerUserAddBy, [CustomerGiftBarcode] = @CustomerGiftBarcode, [CustomerGiftExpDate] = @CustomerGiftExpDate, [CustomerGiftDisMiWi] = @CustomerGiftDisMiWi, [CustomerGiftDisVal] = @CustomerGiftDisVal, [CustomerGiftCount] = @CustomerGiftCount, [CustomerGiftNote] = @CustomerGiftNote, [CustomerEmail] = @CustomerEmail, [CuSchemeID] = @CuSchemeID, [CuSchemeTy] = @CuSchemeTy, [CuStreetName] = @CuStreetName, [CuBuildingNumber] = @CuBuildingNumber, [CuPlotIdentification] = @CuPlotIdentification, [CuCitySubdivisionName] = @CuCitySubdivisionName, [CuCityName] = @CuCityName, [CuCountrySubentity] = @CuCountrySubentity, [CuCompanyID] = @CuCompanyID, [CuExpDat] = @CuExpDat, [CuPostCode] = @CuPostCode, [CuMorID] = @CuMorID, [CusLimitDebit] = @CusLimitDebit WHERE [CustomerID] = @CustomerID";
                SqlCommand command = new SqlCommand(cmdText, this.A);
                command.Parameters.AddWithValue("CustomerID", OI.A);
                command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                command.Parameters.AddWithValue("CustomerName", this.CustomerName.Text.Trim());
                command.Parameters.AddWithValue("CustomerAddress", this.CustomerAddress.Text.Trim());
                command.Parameters.AddWithValue("CustomerPhone", this.CustomerPhone.Text.Trim());
                command.Parameters.AddWithValue("CustomerNote", this.CustomerNote.Text.Trim());
                command.Parameters.AddWithValue("CustomerDiscount", this.CustomerDiscount.Text.Trim());
                command.Parameters.AddWithValue("CustomerPoints", this.CustomerPoints.Text.Trim());
                command.Parameters.AddWithValue("CustomerPriceType", this.CustomerPriceType.SelectedIndex);
                command.Parameters.AddWithValue("CustomerApplyIfPoints", this.CustomerApplyIfPoints.Text.Trim());
                command.Parameters.AddWithValue("CustomerDateConfigur", DateTime.Now.ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("CustomerUserAddBy", A.D.A.A.TxTUserName.Text);
                command.Parameters.AddWithValue("CustomerGiftBarcode", this.CustomerGiftBarcode.Text.Trim());
                command.Parameters.AddWithValue("CustomerGiftExpDate", this.CustomerGiftExpDate.Value.ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("CustomerGiftDisMiWi", Conversion.Val(this.CustomerGiftDisMiWi.Text));
                command.Parameters.AddWithValue("CustomerGiftDisVal", Conversion.Val(this.CustomerGiftDisVal.Text));
                command.Parameters.AddWithValue("CustomerGiftCount", Conversion.Val(this.CustomerGiftCount.Text));
                command.Parameters.AddWithValue("CustomerGiftNote", this.CustomerGiftNote.Text.Trim());
                command.Parameters.AddWithValue("CustomerEmail", this.CustomerEmail.Text.Trim());
                command.Parameters.AddWithValue("CuSchemeID", this.CuSchemeID.Text.Trim());
                command.Parameters.AddWithValue("CuSchemeTy", this.CuSchemeTy.Text.Trim());
                command.Parameters.AddWithValue("CuStreetName", this.CuStreetName.Text.Trim());
                command.Parameters.AddWithValue("CuBuildingNumber", this.CuBuildingNumber.Text.Trim());
                command.Parameters.AddWithValue("CuPlotIdentification", this.CuPlotIdentification.Text.Trim());
                command.Parameters.AddWithValue("CuCitySubdivisionName", this.CuCitySubdivisionName.Text.Trim());
                command.Parameters.AddWithValue("CuCityName", this.CuCityName.Text.Trim());
                command.Parameters.AddWithValue("CuCountrySubentity", this.CuCountrySubentity.Text.Trim());
                command.Parameters.AddWithValue("CuCompanyID", this.CuCompanyID.Text.Trim());
                if (!this.ChKActiveDate.Checked)
                {
                    command.Parameters.AddWithValue("CuExpDat", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("CuExpDat", this.CuExpDat.Value.ToString("yyyy/MM/dd"));
                }
                command.Parameters.AddWithValue("CuPostCode", this.CuPostCode.Text.Trim());
                command.Parameters.AddWithValue("CuMorID", this.CuMorID.Text.Trim());
                decimal num2 = new decimal(Conversion.Val(this.CusLimitDebit.Text.Trim()));
                if (decimal.Compare(num2, decimal.Zero) > 0)
                {
                    num2 = decimal.Multiply(num2, decimal.MinusOne);
                }
                command.Parameters.AddWithValue("CusLimitDebit", num2);
                num = Conversions.ToInteger(command.ExecuteScalar());
                this.A.Close();
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.A = true;
                this.CustomerPriceType.SelectedIndex = 0;
                if (Application.OpenForms.OfType<IH>().Any<IH>())
                {
                    A.D.A.A.P();
                    A.D.A.A.ComboBoxCustomer.SelectedValue = num;
                    base.Dispose();
                }
                if (Application.OpenForms.OfType<QH>().Any<QH>())
                {
                    A.D.A.A.B();
                    A.D.A.A.ComboBoxCustomer.SelectedValue = num;
                    base.Dispose();
                }
                if (OI.A == 0)
                {
                    this.CustomerName.Text = null;
                    this.CustomerPhone.Text = null;
                    this.CustomerAddress.Text = null;
                    this.CustomerNote.Text = null;
                    this.CustomerEmail.Text = null;
                    this.CustomerName.Focus();
                }
            }
            catch (Exception exception3)
            {
                Exception ex = exception3;
                ProjectData.SetProjectError(ex);
                Exception exception2 = ex;
                Interaction.MsgBox("خطأ في عملية الحفظ، قد يكون السبب في تكرار اسم العميل", MsgBoxStyle.ApplicationModal, null);
                Interaction.MsgBox(exception2.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void T(object A, EventArgs R)
        {
        }

        private void T(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void U(object A, EventArgs R)
        {
        }

        private void X(object A, EventArgs R)
        {
            this.CustomerName.Focus();
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox CustomerName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox CustomerAddress
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox CustomerPhone
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual TextBox CustomerNote
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox CustomerPoints
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox i = this.I;
                if (i != null)
                {
                    i.TextChanged -= handler;
                    i.KeyPress -= handler2;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.TextChanged += handler;
                    i.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox CustomerApplyIfPoints
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
                TextBox d = this.D;
                if (d != null)
                {
                    d.TextChanged -= handler;
                    d.KeyPress -= handler2;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.TextChanged += handler;
                    d.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox CustomerDiscount
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
                TextBox f = this.F;
                if (f != null)
                {
                    f.TextChanged -= handler;
                    f.KeyPress -= handler2;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.TextChanged += handler;
                    f.KeyPress += handler2;
                }
            }
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

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ComboBox CustomerPriceType
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox CustomerGiftBarcode
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.I);
                TextBox h = this.H;
                if (h != null)
                {
                    h.TextChanged -= handler;
                    h.KeyPress -= handler2;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.TextChanged += handler;
                    h.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual DateTimePicker CustomerGiftExpDate
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TextBox CustomerGiftDisVal
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.D);
                TextBox t = this.T;
                if (t != null)
                {
                    t.KeyPress -= handler;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.KeyPress += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TextBox CustomerGiftDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.F);
                TextBox x = this.X;
                if (x != null)
                {
                    x.KeyPress -= handler;
                }
                this.X = value;
                x = this.X;
                if (x != null)
                {
                    x.KeyPress += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual TextBox CustomerGiftCount
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.H);
                TextBox g = this.G;
                if (g != null)
                {
                    g.TextChanged -= handler;
                    g.KeyPress -= handler2;
                }
                this.G = value;
                g = this.G;
                if (g != null)
                {
                    g.TextChanged += handler;
                    g.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual TextBox CustomerGiftNote
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual TextBox CustomerEmail
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox22
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual TextBox CuCountrySubentity
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual GroupBox GroupBox21
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual TextBox CuCityName
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual GroupBox GroupBox20
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual TextBox CuCitySubdivisionName
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual GroupBox GroupBox19
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual TextBox CuPlotIdentification
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual GroupBox GroupBox18
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual TextBox CuBuildingNumber
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual TextBox CuStreetName
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual TextBox CuSchemeID
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual ComboBox CuSchemeTy
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox23
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual CheckBox ChKActiveDate
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

        internal virtual DateTimePicker CuExpDat
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox24
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual TextBox CuCompanyID
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual Button ButtoPrintGift
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual GroupBox GroupBox25
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual TextBox CuPostCode
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual GroupBox GroupBox26
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }

        internal virtual TextBox CuMorID
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual Button ButtonHelp
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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

        internal virtual GroupBox GroupBox27
        {
            [CompilerGenerated]
            get => 
                this.AR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.AR = value);
        }

        internal virtual TextBox CusLimitDebit
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.T);
                TextBox c = this.C;
                if (c != null)
                {
                    c.TextChanged -= handler;
                    c.KeyPress -= handler2;
                }
                this.C = value;
                c = this.C;
                if (c != null)
                {
                    c.TextChanged += handler;
                    c.KeyPress += handler2;
                }
            }
        }
    }
}

