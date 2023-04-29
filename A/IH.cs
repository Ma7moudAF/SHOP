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
    using System.Text;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class IH : Form
    {
        private IContainer A;
        [AccessedThroughProperty("GroupBoxNetInvoice"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("TxTInvSaleTotalNET"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxPay"), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("TxTPay"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxReturn")]
        private GroupBox P;
        [AccessedThroughProperty("CheckBoxIsRandomX"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTInvSaleMonBak"), CompilerGenerated]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("GroupBoxRandom"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTInvSaleMonRod")]
        private Label P;
        [AccessedThroughProperty("GroupBoxDebit"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [CompilerGenerated, AccessedThroughProperty("TxTInvSaleMonDem"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [AccessedThroughProperty("GroupBoxCustomer"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [CompilerGenerated, AccessedThroughProperty("ButtonSerch"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("ButtonAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxCustomer"), CompilerGenerated]
        private ComboBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonCurr")]
        private Button P;
        [AccessedThroughProperty("InvSalePayType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [AccessedThroughProperty("TxTPayNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("GroupBox3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [AccessedThroughProperty("InvSaleNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxPrintQAuto"), CompilerGenerated]
        private CheckBox R;
        [CompilerGenerated, AccessedThroughProperty("ComboBoxNPrinterSize"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxPrintNAuto"), CompilerGenerated]
        private CheckBox P;
        [AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [AccessedThroughProperty("ButtonBack"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox4")]
        private GroupBox X;
        [AccessedThroughProperty("InvSaleOtherCuru"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Q;
        [CompilerGenerated, AccessedThroughProperty("TxTCustomerLastBalance"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxCash")]
        private CheckBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerFinish"), CompilerGenerated]
        private Timer A;
        [AccessedThroughProperty("CheckBoxEmailSend"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox5")]
        private GroupBox G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBoxQR")]
        private PictureBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxWatsApp")]
        private CheckBox D;
        private SqlConnection A;
        public static int A;
        public static bool A;
        private TextBox I;
        private decimal A;
        private decimal R;
        private decimal P;
        private decimal Q;
        private decimal I;
        private decimal D;
        private decimal F;
        private decimal H;
        private decimal T;
        private TextBox D;
        private TextBox F;
        private TextBox H;
        private TextBox T;
        private TextBox X;
        private TextBox G;
        private TextBox E;
        private TextBox K;
        private TextBox U;
        private TextBox L;
        private string A;
        private string R;
        private Button D;
        private bool R;

        public IH()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.Q);
            base.KeyUp += new KeyEventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.I = new TextBox();
            this.A = 0M;
            this.R = 0M;
            this.P = 0M;
            this.Q = 0M;
            this.I = 0M;
            this.D = 0M;
            this.F = 0M;
            this.H = 0M;
            this.T = 0M;
            this.D = new TextBox();
            this.F = new TextBox();
            this.H = new TextBox();
            this.T = new TextBox();
            this.X = new TextBox();
            this.G = new TextBox();
            this.E = new TextBox();
            this.K = new TextBox();
            this.U = new TextBox();
            this.L = new TextBox();
            this.A = "*";
            this.R = "";
            this.D = new Button();
            this.R = false;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.GroupBoxNetInvoice = new GroupBox();
            this.TxTInvSaleTotalNET = new Label();
            this.GroupBoxPay = new GroupBox();
            this.ButtonCurr = new Button();
            this.InvSalePayType = new ComboBox();
            this.TxTPay = new TextBox();
            this.GroupBoxReturn = new GroupBox();
            this.CheckBoxIsRandomX = new CheckBox();
            this.TxTInvSaleMonBak = new Label();
            this.GroupBoxRandom = new GroupBox();
            this.TxTInvSaleMonRod = new Label();
            this.GroupBoxDebit = new GroupBox();
            this.TxTInvSaleMonDem = new Label();
            this.GroupBoxCustomer = new GroupBox();
            this.GroupBox1 = new GroupBox();
            this.TxTCustomerLastBalance = new Label();
            this.ButtonSerch = new Button();
            this.ButtonAdd = new Button();
            this.ComboBoxCustomer = new ComboBox();
            this.GroupBox2 = new GroupBox();
            this.TxTPayNote = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.InvSaleNote = new TextBox();
            this.CheckBoxPrintQAuto = new CheckBox();
            this.ComboBoxNPrinterSize = new ComboBox();
            this.CheckBoxPrintNAuto = new CheckBox();
            this.ButtonOK = new Button();
            this.ButtonBack = new Button();
            this.GroupBox4 = new GroupBox();
            this.InvSaleOtherCuru = new TextBox();
            this.CheckBoxCash = new CheckBox();
            this.TimerFinish = new Timer(this.A);
            this.CheckBoxEmailSend = new CheckBox();
            this.GroupBox5 = new GroupBox();
            this.PictureBoxQR = new PictureBox();
            this.CheckBoxWatsApp = new CheckBox();
            this.GroupBoxNetInvoice.SuspendLayout();
            this.GroupBoxPay.SuspendLayout();
            this.GroupBoxReturn.SuspendLayout();
            this.GroupBoxRandom.SuspendLayout();
            this.GroupBoxDebit.SuspendLayout();
            this.GroupBoxCustomer.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            ((ISupportInitialize) this.PictureBoxQR).BeginInit();
            base.SuspendLayout();
            this.GroupBoxNetInvoice.Controls.Add(this.TxTInvSaleTotalNET);
            this.GroupBoxNetInvoice.Location = new Point(0x17e, 12);
            this.GroupBoxNetInvoice.Name = "GroupBoxNetInvoice";
            this.GroupBoxNetInvoice.Size = new Size(0x162, 0x36);
            this.GroupBoxNetInvoice.TabIndex = 20;
            this.GroupBoxNetInvoice.TabStop = false;
            this.GroupBoxNetInvoice.Text = "صافي قيمة الفاتورة";
            this.TxTInvSaleTotalNET.Dock = DockStyle.Fill;
            this.TxTInvSaleTotalNET.Font = new Font("Tahoma", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInvSaleTotalNET.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.TxTInvSaleTotalNET.Location = new Point(3, 0x13);
            this.TxTInvSaleTotalNET.Name = "TxTInvSaleTotalNET";
            this.TxTInvSaleTotalNET.RightToLeft = RightToLeft.No;
            this.TxTInvSaleTotalNET.Size = new Size(0x15c, 0x20);
            this.TxTInvSaleTotalNET.TabIndex = 10;
            this.TxTInvSaleTotalNET.Text = "0";
            this.TxTInvSaleTotalNET.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxPay.Controls.Add(this.ButtonCurr);
            this.GroupBoxPay.Controls.Add(this.InvSalePayType);
            this.GroupBoxPay.Controls.Add(this.TxTPay);
            this.GroupBoxPay.Location = new Point(0x17e, 0x48);
            this.GroupBoxPay.Name = "GroupBoxPay";
            this.GroupBoxPay.Size = new Size(0x162, 0x69);
            this.GroupBoxPay.TabIndex = 1;
            this.GroupBoxPay.TabStop = false;
            this.GroupBoxPay.Text = "المبلغ المدفوع الفعلي الأن";
            this.ButtonCurr.BackColor = Color.WhiteSmoke;
            this.ButtonCurr.FlatAppearance.BorderColor = Color.Green;
            this.ButtonCurr.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonCurr.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonCurr.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonCurr.FlatStyle = FlatStyle.Flat;
            this.ButtonCurr.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonCurr.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCurr.Location = new Point(3, 0x3f);
            this.ButtonCurr.Margin = new Padding(3, 4, 3, 4);
            this.ButtonCurr.Name = "ButtonCurr";
            this.ButtonCurr.Size = new Size(80, 30);
            this.ButtonCurr.TabIndex = 0x1ed36c3;
            this.ButtonCurr.Text = "عملات F11";
            this.ButtonCurr.UseVisualStyleBackColor = false;
            this.InvSalePayType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvSalePayType.FormattingEnabled = true;
            object[] items = new object[] { "نقدا", "ذمم", "شبكة", "تحويل", "الرصيد المدور", "شيك", "إئتمان" };
            this.InvSalePayType.Items.AddRange(items);
            this.InvSalePayType.Location = new Point(0x5d, 0x43);
            this.InvSalePayType.Name = "InvSalePayType";
            this.InvSalePayType.Size = new Size(0xff, 0x18);
            this.InvSalePayType.TabIndex = 0x2c;
            this.TxTPay.BackColor = SystemColors.Info;
            this.TxTPay.Dock = DockStyle.Top;
            this.TxTPay.Font = new Font("Tahoma", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTPay.Location = new Point(3, 0x13);
            this.TxTPay.Name = "TxTPay";
            this.TxTPay.RightToLeft = RightToLeft.No;
            this.TxTPay.Size = new Size(0x15c, 40);
            this.TxTPay.TabIndex = 0;
            this.TxTPay.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxReturn.Controls.Add(this.CheckBoxIsRandomX);
            this.GroupBoxReturn.Controls.Add(this.TxTInvSaleMonBak);
            this.GroupBoxReturn.Location = new Point(15, 0xb7);
            this.GroupBoxReturn.Name = "GroupBoxReturn";
            this.GroupBoxReturn.Size = new Size(0x161, 0x4c);
            this.GroupBoxReturn.TabIndex = 2;
            this.GroupBoxReturn.TabStop = false;
            this.GroupBoxReturn.Text = "الباقي المرتجع للعميل";
            this.CheckBoxIsRandomX.AutoSize = true;
            this.CheckBoxIsRandomX.BackColor = Color.Ivory;
            this.CheckBoxIsRandomX.Dock = DockStyle.Top;
            this.CheckBoxIsRandomX.Location = new Point(3, 0x31);
            this.CheckBoxIsRandomX.Name = "CheckBoxIsRandomX";
            this.CheckBoxIsRandomX.Padding = new Padding(2);
            this.CheckBoxIsRandomX.Size = new Size(0x15b, 0x18);
            this.CheckBoxIsRandomX.TabIndex = 0x15;
            this.CheckBoxIsRandomX.Text = "تدوير الباقي المرتجع لرصيد العميل";
            this.CheckBoxIsRandomX.UseVisualStyleBackColor = false;
            this.TxTInvSaleMonBak.Dock = DockStyle.Top;
            this.TxTInvSaleMonBak.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInvSaleMonBak.Location = new Point(3, 0x13);
            this.TxTInvSaleMonBak.Name = "TxTInvSaleMonBak";
            this.TxTInvSaleMonBak.RightToLeft = RightToLeft.No;
            this.TxTInvSaleMonBak.Size = new Size(0x15b, 30);
            this.TxTInvSaleMonBak.TabIndex = 11;
            this.TxTInvSaleMonBak.Text = "0";
            this.TxTInvSaleMonBak.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxRandom.Controls.Add(this.TxTInvSaleMonRod);
            this.GroupBoxRandom.Location = new Point(15, 0x109);
            this.GroupBoxRandom.Name = "GroupBoxRandom";
            this.GroupBoxRandom.Size = new Size(0x162, 0x36);
            this.GroupBoxRandom.TabIndex = 3;
            this.GroupBoxRandom.TabStop = false;
            this.GroupBoxRandom.Text = "الباقي المدور لرصيد العميل";
            this.TxTInvSaleMonRod.Dock = DockStyle.Fill;
            this.TxTInvSaleMonRod.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInvSaleMonRod.ForeColor = Color.Blue;
            this.TxTInvSaleMonRod.Location = new Point(3, 0x13);
            this.TxTInvSaleMonRod.Name = "TxTInvSaleMonRod";
            this.TxTInvSaleMonRod.RightToLeft = RightToLeft.No;
            this.TxTInvSaleMonRod.Size = new Size(0x15c, 0x20);
            this.TxTInvSaleMonRod.TabIndex = 11;
            this.TxTInvSaleMonRod.Text = "0";
            this.TxTInvSaleMonRod.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxDebit.Controls.Add(this.TxTInvSaleMonDem);
            this.GroupBoxDebit.Location = new Point(14, 0x145);
            this.GroupBoxDebit.Name = "GroupBoxDebit";
            this.GroupBoxDebit.Size = new Size(0x162, 0x36);
            this.GroupBoxDebit.TabIndex = 4;
            this.GroupBoxDebit.TabStop = false;
            this.GroupBoxDebit.Text = "ذمم على الفاتورة";
            this.TxTInvSaleMonDem.Dock = DockStyle.Fill;
            this.TxTInvSaleMonDem.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInvSaleMonDem.ForeColor = Color.Red;
            this.TxTInvSaleMonDem.Location = new Point(3, 0x13);
            this.TxTInvSaleMonDem.Name = "TxTInvSaleMonDem";
            this.TxTInvSaleMonDem.RightToLeft = RightToLeft.No;
            this.TxTInvSaleMonDem.Size = new Size(0x15c, 0x20);
            this.TxTInvSaleMonDem.TabIndex = 11;
            this.TxTInvSaleMonDem.Text = "0";
            this.TxTInvSaleMonDem.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxCustomer.Controls.Add(this.GroupBox1);
            this.GroupBoxCustomer.Controls.Add(this.ButtonSerch);
            this.GroupBoxCustomer.Controls.Add(this.ButtonAdd);
            this.GroupBoxCustomer.Controls.Add(this.ComboBoxCustomer);
            this.GroupBoxCustomer.Location = new Point(15, 12);
            this.GroupBoxCustomer.Name = "GroupBoxCustomer";
            this.GroupBoxCustomer.Size = new Size(0x161, 0xa5);
            this.GroupBoxCustomer.TabIndex = 0x17;
            this.GroupBoxCustomer.TabStop = false;
            this.GroupBoxCustomer.Text = "العميل";
            this.GroupBox1.Controls.Add(this.TxTCustomerLastBalance);
            this.GroupBox1.Location = new Point(8, 0x61);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x152, 0x38);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "رصيد العميل السابق";
            this.TxTCustomerLastBalance.Dock = DockStyle.Top;
            this.TxTCustomerLastBalance.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTCustomerLastBalance.Location = new Point(3, 0x13);
            this.TxTCustomerLastBalance.Name = "TxTCustomerLastBalance";
            this.TxTCustomerLastBalance.RightToLeft = RightToLeft.No;
            this.TxTCustomerLastBalance.Size = new Size(0x14c, 0x1f);
            this.TxTCustomerLastBalance.TabIndex = 12;
            this.TxTCustomerLastBalance.Text = "0";
            this.TxTCustomerLastBalance.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonSerch.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSerch.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSerch.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSerch.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSerch.FlatStyle = FlatStyle.Flat;
            this.ButtonSerch.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSerch.Image = A.F.ImView;
            this.ButtonSerch.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSerch.Location = new Point(7, 0x31);
            this.ButtonSerch.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSerch.Name = "ButtonSerch";
            this.ButtonSerch.Size = new Size(0x98, 0x29);
            this.ButtonSerch.TabIndex = 8;
            this.ButtonSerch.Text = "بحث متقدم";
            this.ButtonSerch.UseVisualStyleBackColor = true;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Flat;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.Image = A.F.ImCustomerAdd;
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(0xa8, 0x31);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0xb2, 0x29);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "اضافة عميل";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ComboBoxCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.ComboBoxCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxCustomer.BackColor = SystemColors.Info;
            this.ComboBoxCustomer.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxCustomer.FormattingEnabled = true;
            this.ComboBoxCustomer.Location = new Point(8, 0x12);
            this.ComboBoxCustomer.Name = "ComboBoxCustomer";
            this.ComboBoxCustomer.Size = new Size(0x152, 0x1a);
            this.ComboBoxCustomer.TabIndex = 0;
            this.GroupBox2.Controls.Add(this.TxTPayNote);
            this.GroupBox2.Location = new Point(14, 0x181);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x162, 0x45);
            this.GroupBox2.TabIndex = 0x18;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ملاحظات على الدفعة في حساب العميل";
            this.TxTPayNote.Dock = DockStyle.Fill;
            this.TxTPayNote.Location = new Point(3, 0x13);
            this.TxTPayNote.Margin = new Padding(5);
            this.TxTPayNote.MaxLength = 0xbb8;
            this.TxTPayNote.Multiline = true;
            this.TxTPayNote.Name = "TxTPayNote";
            this.TxTPayNote.Size = new Size(0x15c, 0x2f);
            this.TxTPayNote.TabIndex = 1;
            this.GroupBox3.Controls.Add(this.InvSaleNote);
            this.GroupBox3.Location = new Point(0x17e, 250);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x162, 0x42);
            this.GroupBox3.TabIndex = 0x19;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "ملاحظات على الفاتورة";
            this.InvSaleNote.Dock = DockStyle.Fill;
            this.InvSaleNote.Location = new Point(3, 0x13);
            this.InvSaleNote.Margin = new Padding(5);
            this.InvSaleNote.MaxLength = 0xbb8;
            this.InvSaleNote.Multiline = true;
            this.InvSaleNote.Name = "InvSaleNote";
            this.InvSaleNote.Size = new Size(0x15c, 0x2c);
            this.InvSaleNote.TabIndex = 2;
            this.CheckBoxPrintQAuto.AutoSize = true;
            this.CheckBoxPrintQAuto.Location = new Point(0x17e, 0x193);
            this.CheckBoxPrintQAuto.Name = "CheckBoxPrintQAuto";
            this.CheckBoxPrintQAuto.Size = new Size(0x77, 20);
            this.CheckBoxPrintQAuto.TabIndex = 0x5fb;
            this.CheckBoxPrintQAuto.Text = "اطبع الطلبية ايضا";
            this.CheckBoxPrintQAuto.UseVisualStyleBackColor = true;
            this.ComboBoxNPrinterSize.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxNPrinterSize.FormattingEnabled = true;
            object[] objArray2 = new object[] { "عربي قياس A4", "عربي قياس A5", "عربي حراري قياس 80", "انجليزي قياس A4", "انجليزي قياس A5", "انجليزي حراري قياس 80", "ضريبية عربي A4", "ضريبية انجليزي A4" };
            this.ComboBoxNPrinterSize.Items.AddRange(objArray2);
            this.ComboBoxNPrinterSize.Location = new Point(0x1fc, 0x141);
            this.ComboBoxNPrinterSize.Name = "ComboBoxNPrinterSize";
            this.ComboBoxNPrinterSize.Size = new Size(0xe0, 0x18);
            this.ComboBoxNPrinterSize.TabIndex = 0x5fa;
            this.CheckBoxPrintNAuto.AutoSize = true;
            this.CheckBoxPrintNAuto.Location = new Point(0x17e, 0x147);
            this.CheckBoxPrintNAuto.Name = "CheckBoxPrintNAuto";
            this.CheckBoxPrintNAuto.Size = new Size(120, 20);
            this.CheckBoxPrintNAuto.TabIndex = 0x5f9;
            this.CheckBoxPrintNAuto.Text = "اطبع فاتورة قياس";
            this.CheckBoxPrintNAuto.UseVisualStyleBackColor = true;
            this.ButtonOK.BackColor = Color.WhiteSmoke;
            this.ButtonOK.Enabled = false;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(15, 0x1cd);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x20b, 0x37);
            this.ButtonOK.TabIndex = 0x5f8;
            this.ButtonOK.Text = "إنهاء F2";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonBack.FlatAppearance.BorderColor = Color.Green;
            this.ButtonBack.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonBack.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonBack.FlatStyle = FlatStyle.Flat;
            this.ButtonBack.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonBack.Image = A.F.ImsaleFinish;
            this.ButtonBack.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonBack.Location = new Point(0x220, 0x1cd);
            this.ButtonBack.Margin = new Padding(3, 4, 3, 4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new Size(0xc0, 0x37);
            this.ButtonBack.TabIndex = 0x5f7;
            this.ButtonBack.Text = "   رجوع F3";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.GroupBox4.Controls.Add(this.InvSaleOtherCuru);
            this.GroupBox4.Location = new Point(0x17e, 0xbb);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x162, 0x38);
            this.GroupBox4.TabIndex = 0x1a;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "عملات اخرى";
            this.InvSaleOtherCuru.Dock = DockStyle.Fill;
            this.InvSaleOtherCuru.Location = new Point(3, 0x13);
            this.InvSaleOtherCuru.Margin = new Padding(5);
            this.InvSaleOtherCuru.MaxLength = 0xbb8;
            this.InvSaleOtherCuru.Multiline = true;
            this.InvSaleOtherCuru.Name = "InvSaleOtherCuru";
            this.InvSaleOtherCuru.Size = new Size(0x15c, 0x22);
            this.InvSaleOtherCuru.TabIndex = 2;
            this.CheckBoxCash.AutoSize = true;
            this.CheckBoxCash.Checked = true;
            this.CheckBoxCash.CheckState = CheckState.Checked;
            this.CheckBoxCash.Location = new Point(0x17e, 0x1ad);
            this.CheckBoxCash.Name = "CheckBoxCash";
            this.CheckBoxCash.Size = new Size(200, 20);
            this.CheckBoxCash.TabIndex = 0x5fc;
            this.CheckBoxCash.Text = "قيد وتسجيل الحركة على الكاش";
            this.CheckBoxCash.UseVisualStyleBackColor = true;
            this.CheckBoxEmailSend.AutoSize = true;
            this.CheckBoxEmailSend.Location = new Point(0x17e, 0x179);
            this.CheckBoxEmailSend.Name = "CheckBoxEmailSend";
            this.CheckBoxEmailSend.Size = new Size(0xfb, 20);
            this.CheckBoxEmailSend.TabIndex = 0x5fd;
            this.CheckBoxEmailSend.Text = "ارسال اشعار بريد الكتروني للعميل ان وجد";
            this.CheckBoxEmailSend.UseVisualStyleBackColor = true;
            this.GroupBox5.Controls.Add(this.PictureBoxQR);
            this.GroupBox5.Location = new Point(0x19e, 0x236);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x142, 0x89);
            this.GroupBox5.TabIndex = 0x1ed36f3;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "QR Setting";
            this.PictureBoxQR.BackColor = Color.White;
            this.PictureBoxQR.BackgroundImageLayout = ImageLayout.Center;
            this.PictureBoxQR.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBoxQR.Location = new Point(0x70, 20);
            this.PictureBoxQR.Margin = new Padding(3, 4, 3, 4);
            this.PictureBoxQR.Name = "PictureBoxQR";
            this.PictureBoxQR.Size = new Size(0xcc, 110);
            this.PictureBoxQR.SizeMode = PictureBoxSizeMode.CenterImage;
            this.PictureBoxQR.TabIndex = 0x1ed36ef;
            this.PictureBoxQR.TabStop = false;
            this.CheckBoxWatsApp.AutoSize = true;
            this.CheckBoxWatsApp.Location = new Point(0x17e, 0x15f);
            this.CheckBoxWatsApp.Name = "CheckBoxWatsApp";
            this.CheckBoxWatsApp.Size = new Size(0xde, 20);
            this.CheckBoxWatsApp.TabIndex = 0x1ed36f4;
            this.CheckBoxWatsApp.Text = "ارسال اشعار واتساب للعميل ان وجد";
            this.CheckBoxWatsApp.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonBack;
            base.ClientSize = new Size(0x2eb, 0x210);
            base.ControlBox = false;
            base.Controls.Add(this.CheckBoxWatsApp);
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.CheckBoxEmailSend);
            base.Controls.Add(this.ComboBoxNPrinterSize);
            base.Controls.Add(this.CheckBoxPrintNAuto);
            base.Controls.Add(this.ButtonBack);
            base.Controls.Add(this.CheckBoxPrintQAuto);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.CheckBoxCash);
            base.Controls.Add(this.GroupBoxPay);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.GroupBoxCustomer);
            base.Controls.Add(this.GroupBoxDebit);
            base.Controls.Add(this.GroupBoxRandom);
            base.Controls.Add(this.GroupBoxReturn);
            base.Controls.Add(this.GroupBoxNetInvoice);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleFormFinish";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "إنهاء الفاتورة";
            this.GroupBoxNetInvoice.ResumeLayout(false);
            this.GroupBoxPay.ResumeLayout(false);
            this.GroupBoxPay.PerformLayout();
            this.GroupBoxReturn.ResumeLayout(false);
            this.GroupBoxReturn.PerformLayout();
            this.GroupBoxRandom.ResumeLayout(false);
            this.GroupBoxDebit.ResumeLayout(false);
            this.GroupBoxCustomer.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            ((ISupportInitialize) this.PictureBoxQR).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public static byte[] A(string A)
        {
            A = A.Replace("-", "");
            byte[] buffer2 = new byte[((int) Math.Round((double) ((((double) A.Length) / 2.0) - 1.0))) + 1];
            int num = buffer2.Length - 1;
            for (int i = 0; i <= num; i++)
            {
                buffer2[i] = Convert.ToByte(A.Substring(i * 2, 2), 0x10);
            }
            return buffer2;
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
            this.ComboBoxNPrinterSize.SelectedIndex = AR.R;
            this.CheckBoxPrintNAuto.Checked = AR.K;
            this.CheckBoxPrintQAuto.Checked = AR.N;
            this.CheckBoxEmailSend.Checked = AR.IR;
            if (!this.CheckBoxPrintNAuto.Checked)
            {
                this.CheckBoxEmailSend.Checked = false;
            }
            this.CheckBoxWatsApp.Checked = AR.ER;
            this.P();
            base.Opacity = 0.0;
        }

        private void A(object A, KeyEventArgs R)
        {
            if (R.KeyCode == Keys.F1)
            {
                W.A();
            }
            if (R.KeyCode == Keys.F2)
            {
                this.ButtonOK.PerformClick();
                this.ButtonOK.Enabled = false;
            }
            if (R.KeyCode == Keys.F3)
            {
                this.ButtonBack.PerformClick();
            }
            if (R.KeyCode == Keys.F11)
            {
                this.ButtonCurr.PerformClick();
            }
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

        private void B(object A, EventArgs R)
        {
            base.AcceptButton = this.D;
        }

        private void D(object A, EventArgs R)
        {
            if (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(decimal.Compare(this.I, decimal.Zero) != 0, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.ComboBoxCustomer.SelectedValue, null, false))))
            {
                if (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(decimal.Compare(this.D, decimal.Zero) != 0, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.ComboBoxCustomer.SelectedValue, null, false))))
                {
                    if (this.InvSalePayType.SelectedIndex == 4)
                    {
                        if (A.D.A.A.InvSaleType.SelectedIndex != 1)
                        {
                            if (!(Conversion.Val(this.TxTCustomerLastBalance.Text.Replace(",", "")) == 0.0))
                            {
                                if (Conversion.Val(this.TxTCustomerLastBalance.Text.Replace(",", "")) < Conversion.Val(this.TxTInvSaleTotalNET.Text.Replace(",", "")))
                                {
                                    Interaction.MsgBox("مبلغ الفاتورة اكبر من رصيد العميل المدور", MsgBoxStyle.ApplicationModal, null);
                                    this.InvSalePayType.SelectedIndex = 0;
                                    base.Opacity = 100.0;
                                    this.ButtonOK.Enabled = true;
                                    return;
                                }
                            }
                            else
                            {
                                Interaction.MsgBox("لا يوجد عميل محدد/ او ان رصيد العميل المحدد صفر", MsgBoxStyle.ApplicationModal, null);
                                this.InvSalePayType.SelectedIndex = 0;
                                base.Opacity = 100.0;
                                this.ButtonOK.Enabled = true;
                                return;
                            }
                        }
                        else
                        {
                            Interaction.MsgBox("لا يمكن التعامل مع الرصيد المدور في حال مرتجع المبيعات", MsgBoxStyle.ApplicationModal, null);
                            this.InvSalePayType.SelectedIndex = 0;
                            base.Opacity = 100.0;
                            this.ButtonOK.Enabled = true;
                            return;
                        }
                    }
                    if ((A.D.A.A.InvSaleType.SelectedIndex == 1) && (Conversion.Val(this.TxTPay.Text.Replace(",", "")) > Conversion.Val(this.TxTInvSaleTotalNET.Text.Replace(",", ""))))
                    {
                        Interaction.MsgBox("في حال مرتجع المبيعات يجب ادخال مبلغ اقل او يساوي من مبلغ الفاتورة", MsgBoxStyle.ApplicationModal, null);
                        base.Opacity = 100.0;
                        this.ButtonOK.Enabled = true;
                    }
                    else if ((this.InvSalePayType.SelectedIndex == 1) & (Conversion.Val(this.TxTPay.Text.Replace(",", "")) == Conversion.Val(this.TxTInvSaleTotalNET.Text.Replace(",", ""))))
                    {
                        Interaction.MsgBox("يجب تحديد المبلغ المدفوع (صفر او اقل او جزء) من مبلغ الفاتورة، لأنك حددت طريقة الدفع ذمم", MsgBoxStyle.ApplicationModal, null);
                        base.Opacity = 100.0;
                        this.ButtonOK.Enabled = true;
                        this.TxTPay.Focus();
                    }
                    else if (((this.ComboBoxCustomer.Text.Trim() != null) && (!IH.A && !(Conversion.Val(this.E.Text.Replace(",", "")) == 0.0))) && (Conversion.Val(this.E.Text.Replace(",", "")) >= Conversion.Val(this.K.Text.Replace(",", ""))))
                    {
                        Interaction.MsgBox("لا يمكن التعامل مع هذا العميل لأنه تجاوز الحد المسموح برصيد الذمم", MsgBoxStyle.ApplicationModal, null);
                        this.InvSalePayType.SelectedIndex = 0;
                        base.Opacity = 100.0;
                        this.ButtonOK.Enabled = true;
                    }
                    else
                    {
                        this.ButtonOK.Text = "في انتظار استجابة الأمر | الطابعات  | الانهاء";
                        this.ButtonOK.Enabled = false;
                        try
                        {
                            if (PR.DR)
                            {
                                if (!PR.KR)
                                {
                                    this.R = PR.XP;
                                }
                                else
                                {
                                    string str = "01";
                                    string str2 = "02";
                                    string str3 = "03";
                                    string str4 = "04";
                                    string str5 = "05";
                                    DateTime time = Conversions.ToDate(this.H.Text);
                                    string expression = PR.WR.ToString();
                                    string str8 = time.ToString("yyyy-MM-dd HH:mm:ss");
                                    string str9 = this.TxTInvSaleTotalNET.Text.Replace(",", "");
                                    string str10 = this.L.Text.Replace(",", "");
                                    string str11 = "";
                                    string str12 = "";
                                    string str13 = "";
                                    string str14 = "";
                                    string str15 = "";
                                    string s = PR.ER.ToString().ToString();
                                    StringBuilder builder = new StringBuilder();
                                    byte[] bytes = Encoding.UTF8.GetBytes(s);
                                    int num6 = bytes.Length - 1;
                                    int index = 0;
                                    while (true)
                                    {
                                        if (index > num6)
                                        {
                                            string str17 = expression.ToString();
                                            StringBuilder builder2 = new StringBuilder();
                                            byte[] buffer2 = Encoding.ASCII.GetBytes(str17);
                                            int num8 = buffer2.Length - 1;
                                            int num9 = 0;
                                            while (true)
                                            {
                                                if (num9 > num8)
                                                {
                                                    string str18 = str8.ToString();
                                                    StringBuilder builder3 = new StringBuilder();
                                                    byte[] buffer3 = Encoding.ASCII.GetBytes(str18);
                                                    int num10 = buffer3.Length - 1;
                                                    int num11 = 0;
                                                    while (true)
                                                    {
                                                        if (num11 > num10)
                                                        {
                                                            string str19 = str9.ToString();
                                                            StringBuilder builder4 = new StringBuilder();
                                                            byte[] buffer4 = Encoding.ASCII.GetBytes(str19);
                                                            int num12 = buffer4.Length - 1;
                                                            int num13 = 0;
                                                            while (true)
                                                            {
                                                                if (num13 > num12)
                                                                {
                                                                    string str20 = str10.ToString();
                                                                    StringBuilder builder5 = new StringBuilder();
                                                                    byte[] buffer5 = Encoding.ASCII.GetBytes(str20);
                                                                    int num14 = buffer5.Length - 1;
                                                                    int num15 = 0;
                                                                    while (true)
                                                                    {
                                                                        if (num15 > num14)
                                                                        {
                                                                            int number = Strings.Len(expression);
                                                                            int num2 = Strings.Len(str8);
                                                                            int num3 = Strings.Len(str9);
                                                                            int num4 = Strings.Len(str10);
                                                                            string str22 = Conversion.Hex(((int) Math.Round((double) (Conversions.ToDouble(Conversions.ToString(Strings.Len(builder.ToString()))) / 2.0))).ToString());
                                                                            if (Strings.Len(str22) == 1)
                                                                            {
                                                                                str22 = "0" + str22;
                                                                            }
                                                                            string str23 = Conversion.Hex(number);
                                                                            if (Strings.Len(str23) == 1)
                                                                            {
                                                                                str23 = "0" + str23;
                                                                            }
                                                                            string str24 = Conversion.Hex(num2);
                                                                            if (Strings.Len(str24) == 1)
                                                                            {
                                                                                str24 = "0" + str24;
                                                                            }
                                                                            string str25 = Conversion.Hex(num3);
                                                                            if (Strings.Len(str25) == 1)
                                                                            {
                                                                                str25 = "0" + str25;
                                                                            }
                                                                            string str26 = Conversion.Hex(num4);
                                                                            if (Strings.Len(str26) == 1)
                                                                            {
                                                                                str26 = "0" + str26;
                                                                            }
                                                                            str11 = str.ToString() + str22.ToString() + builder.ToString();
                                                                            str12 = str2.ToString() + str23.ToString() + builder2.ToString();
                                                                            str13 = str3.ToString() + str24.ToString() + builder3.ToString();
                                                                            str14 = str4.ToString() + str25.ToString() + builder4.ToString();
                                                                            str15 = str5.ToString() + str26.ToString() + builder5.ToString();
                                                                            string[] textArray1 = new string[] { str11.ToString(), str12.ToString(), str13.ToString(), str14.ToString(), str15.ToString() };
                                                                            string str29 = Convert.ToBase64String(IH.A(string.Concat(textArray1)));
                                                                            this.R = str29;
                                                                            break;
                                                                        }
                                                                        builder5.Append(buffer5[num15].ToString("x"));
                                                                        num15++;
                                                                    }
                                                                    break;
                                                                }
                                                                builder4.Append(buffer4[num13].ToString("x"));
                                                                num13++;
                                                            }
                                                            break;
                                                        }
                                                        builder3.Append(buffer3[num11].ToString("x"));
                                                        num11++;
                                                    }
                                                    break;
                                                }
                                                builder2.Append(buffer2[num9].ToString("x"));
                                                num9++;
                                            }
                                            break;
                                        }
                                        builder.Append(bytes[index].ToString("x"));
                                        index++;
                                    }
                                }
                            }
                        }
                        catch (Exception exception1)
                        {
                            Exception ex = exception1;
                            ProjectData.SetProjectError(ex);
                            Exception exception = ex;
                            base.Opacity = 100.0;
                            Interaction.MsgBox("خطأ في نظام صانع QR باركود" + exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                            ProjectData.ClearProjectError();
                        }
                        this.TimerFinish.Enabled = true;
                    }
                }
                else
                {
                    Interaction.MsgBox("هناك مبلغ مدور يجب تحديد العميل", MsgBoxStyle.ApplicationModal, null);
                    base.Opacity = 100.0;
                    this.ButtonOK.Enabled = true;
                }
            }
            else
            {
                Interaction.MsgBox("هناك مبلغ ذمم يجب تحديد العميل", MsgBoxStyle.ApplicationModal, null);
                base.Opacity = 100.0;
                this.ButtonOK.Enabled = true;
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
            AR.N = this.CheckBoxPrintQAuto.Checked;
        }

        private void F(object A, EventArgs R)
        {
            A.D.A.A.ButtonFinishSave.Enabled = true;
            A.D.A.A.ButtonFinishSave.Text = "حفظ التعديلات F5";
            A.D.A.A.ButtonFinishIn.Enabled = true;
            A.D.A.A.ButtonFinishIn.Text = "   إنهاء البيع وفتح الصندوق | العملاء | اجراءات F2";
            A.D.A.A.TimerFocus.Enabled = true;
            base.Dispose();
        }

        private void G(object A, EventArgs R)
        {
            if (this.CheckBoxPrintNAuto.Checked)
            {
                this.CheckBoxEmailSend.Enabled = true;
            }
            else
            {
                this.CheckBoxEmailSend.Checked = false;
                this.CheckBoxEmailSend.Enabled = false;
            }
            AR.K = this.CheckBoxPrintNAuto.Checked;
        }

        private void H(object A, EventArgs R)
        {
            if (this.InvSalePayType.SelectedIndex == 4)
            {
                this.TxTPay.Enabled = false;
                this.TxTPayNote.Enabled = false;
                this.InvSaleNote.Enabled = false;
                this.TxTPay.Text = "0";
                this.A = "تم دفع مبلغ الفاتورة رقم " + this.F.Text + " من الرصيد المدور وذلك بمبلغ " + this.TxTInvSaleTotalNET.Text;
                this.TxTPayNote.Text = this.TxTPayNote.Text.Trim() + " " + this.A.ToString();
                this.InvSaleNote.Text = this.InvSaleNote.Text.Trim() + " " + this.A.ToString();
                this.CheckBoxIsRandomX.Checked = false;
                this.CheckBoxIsRandomX.Enabled = false;
            }
            else if (this.InvSalePayType.SelectedIndex == 1)
            {
                if (!IH.A)
                {
                    this.TxTPay.Text = "0";
                }
            }
            else
            {
                this.TxTPay.Text = this.TxTInvSaleTotalNET.Text;
                this.TxTPayNote.Text = this.TxTPayNote.Text.Replace(this.A.ToString(), "").Trim();
                this.InvSaleNote.Text = this.InvSaleNote.Text.Replace(this.A.ToString(), "").Trim();
                this.TxTPay.Enabled = true;
                this.TxTPayNote.Enabled = true;
                this.InvSaleNote.Enabled = true;
                this.CheckBoxIsRandomX.Checked = true;
                this.CheckBoxIsRandomX.Enabled = true;
            }
        }

        public void I()
        {
            Application.DoEvents();
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNInvSale] WHERE ([InvSaleID] = @InvSaleID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleID", A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxCustomer.SelectedValue = dataTable.Rows[0]["CustomerFrontID"].ToString();
                    this.F.Text = dataTable.Rows[0]["InvSaleIDMAX"].ToString();
                    this.H.Text = dataTable.Rows[0]["InvSaleDateTime"].ToString();
                    this.InvSalePayType.SelectedIndex = Conversions.ToInteger(dataTable.Rows[0]["InvSalePayType"].ToString());
                    this.U.Text = dataTable.Rows[0]["InvSaleDisVal"].ToString();
                    this.L.Text = dataTable.Rows[0]["InvSaleDarVal"].ToString();
                    this.TxTInvSaleTotalNET.Text = dataTable.Rows[0]["InvSaleTotalNET"].ToString();
                    this.I.Text = dataTable.Rows[0]["InvSaleMonBas"].ToString();
                    this.CheckBoxIsRandomX.Checked = Conversions.ToBoolean(dataTable.Rows[0]["InvSaleIsMonRod"].ToString());
                    this.InvSaleNote.Text = dataTable.Rows[0]["InvSaleNote"].ToString();
                    this.InvSaleOtherCuru.Text = dataTable.Rows[0]["InvSaleOtherCuru"].ToString();
                }
                this.TxTInvSaleTotalNET.Text = new decimal(Conversion.Val(this.TxTInvSaleTotalNET.Text.Replace(",", ""))).ToString(PR.YR);
                if (A.D.A.A.InvSaleType.SelectedIndex == 0)
                {
                    this.GroupBoxPay.Text = "المبلغ المدفوع الفعلي الأن";
                    this.TxTInvSaleTotalNET.ForeColor = Color.Blue;
                    this.TxTPay.ForeColor = Color.Blue;
                    this.GroupBoxPay.ForeColor = Color.Blue;
                }
                else if (A.D.A.A.InvSaleType.SelectedIndex == 1)
                {
                    this.GroupBoxPay.Text = "المبلغ المرتجع للعميل";
                    this.TxTInvSaleTotalNET.ForeColor = Color.Red;
                    this.TxTPay.ForeColor = Color.Red;
                    this.GroupBoxPay.ForeColor = Color.Red;
                }
                if (this.InvSalePayType.SelectedIndex != 1)
                {
                    this.TxTPay.Text = this.TxTInvSaleTotalNET.Text;
                }
                else if (!A)
                {
                    this.TxTPay.Text = "0";
                }
                if (A)
                {
                    this.TxTPay.Text = this.I.Text;
                }
                this.R();
                this.TxTPay.Focus();
                this.TxTPay.SelectAll();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                base.Opacity = 100.0;
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
            if (A)
            {
                base.Opacity = 100.0;
            }
            else if (AR.E)
            {
                base.Opacity = 100.0;
            }
            else if (this.InvSalePayType.SelectedIndex == 1)
            {
                base.Opacity = 100.0;
            }
            else
            {
                base.Opacity = 0.0;
                this.ButtonOK.PerformClick();
            }
        }

        private void I(object A, EventArgs R)
        {
            if (!PR.FP)
            {
                Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                OI.A = 0;
                A.D.A.A.ShowDialog();
            }
        }

        private void K(object A, EventArgs R)
        {
            AR.R = this.ComboBoxNPrinterSize.SelectedIndex;
        }

        private void L(object A, EventArgs R)
        {
            A.D.A.A.TxTMaster.Text = this.TxTPay.Text;
            A.D.A.A.Show();
        }

        private void N(object A, EventArgs R)
        {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.ComboBoxCustomer.SelectedValue, null, false), this.ComboBoxCustomer.Text == null)))
            {
                this.TxTCustomerLastBalance.Text = null;
            }
            else
            {
                this.Q();
            }
        }

        private void O(object A, EventArgs R)
        {
            AR.IR = this.CheckBoxEmailSend.Checked;
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
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxCustomer.ValueMember = "CustomerID";
                    this.ComboBoxCustomer.DisplayMember = "CustomerName";
                    this.ComboBoxCustomer.DataSource = dataTable;
                    this.ComboBoxCustomer.SelectedIndex = -1;
                    this.TxTCustomerLastBalance.Text = null;
                    this.D.Text = null;
                    this.T.Text = null;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                base.Opacity = 100.0;
                ProjectData.ClearProjectError();
            }
        }

        private void P(object A, EventArgs R)
        {
            this.R();
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
                string selectCommandText = "SELECT [CustomerID], [CustomerName], [CustomerBalance], [CustomerPoints], [CustomerEmail], [CustomerPhone], [CuExpDat], [CusLimitDebit], [CustomerBalance] FROM TaNNCustomers WHERE (CustomerID = @CustomerID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CustomerID", this.ComboBoxCustomer.SelectedValue);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.TxTCustomerLastBalance.Text = dataTable.Rows[0]["CustomerBalance"].ToString();
                    this.D.Text = dataTable.Rows[0]["CustomerPoints"].ToString();
                    this.T.Text = dataTable.Rows[0]["CustomerEmail"].ToString();
                    this.X.Text = dataTable.Rows[0]["CustomerPhone"].ToString();
                    this.E.Text = dataTable.Rows[0]["CusLimitDebit"].ToString();
                    this.K.Text = dataTable.Rows[0]["CustomerBalance"].ToString();
                    if (!A)
                    {
                        this.G.Text = dataTable.Rows[0]["CuExpDat"].ToString();
                        if (this.G.Text != null)
                        {
                            DateTime time = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd"));
                            DateTime time2 = Conversions.ToDate(this.G.Text);
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(time.ToString("yyyy/MM/dd"), time2.ToString("yyyy/MM/dd"), false) >= 0)
                            {
                                Interaction.MsgBox("تاريخ التعامل مع بيانات العميل القانونية منتهي", MsgBoxStyle.ApplicationModal, null);
                                this.ComboBoxCustomer.SelectedIndex = -1;
                            }
                        }
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                base.Opacity = 100.0;
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void Q(object A, EventArgs R)
        {
            this.I();
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            this.R();
        }

        private void S(object A, EventArgs R)
        {
            AR.ER = this.CheckBoxWatsApp.Checked;
        }

        private void T(object A, EventArgs R)
        {
            if ((this.InvSalePayType.SelectedIndex == 2) && (Conversion.Val(PR.TP) > 0.0))
            {
                Interaction.MsgBox("هناك عمولة دفع بالشبكة يجب العودة لشاشة البيع ان اردت تغيير طريقة الدفعة شبكة", MsgBoxStyle.ApplicationModal, null);
                this.InvSalePayType.SelectedIndex = 0;
                base.Opacity = 100.0;
            }
        }

        private void U(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void V(object A, EventArgs R)
        {
            if (this.ComboBoxCustomer.Text == null)
            {
                this.ComboBoxCustomer.SelectedValue = 0;
                this.TxTCustomerLastBalance.Text = null;
            }
        }

        private void X(object A, EventArgs R)
        {
            this.TimerFinish.Enabled = false;
            try
            {
                DateTime time = Conversions.ToDate(this.H.Text);
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [TaNNInvSale] SET [CustomerFrontID] = @CustomerFrontID, [InvSaleDateTime] = @InvSaleDateTime, [InvSaleStatus] = @InvSaleStatus, [InvSalePayType] = @InvSalePayType, [InvSaleMonPay] = @InvSaleMonPay, [InvSaleMonBas] = @InvSaleMonBas, [InvSaleMonBak] = @InvSaleMonBak, [InvSaleMonDem] = @InvSaleMonDem, [InvSaleMonRod] = @InvSaleMonRod, [InvSaleIsMonRod] = @InvSaleIsMonRod, [InvSaleNote] = @InvSaleNote, [InvSaleUserAddBy] = @InvSaleUserAddBy, [InvSaleOtherCuru] = @InvSaleOtherCuru, [InvSaleIsCashCount] = @InvSaleIsCashCount, [InvSaleCusLastBalance] = @InvSaleCusLastBalance, [HashQR] =@HashQR WHERE [InvSaleID] = @InvSaleID", this.A);
                command.Parameters.AddWithValue("InvSaleID", IH.A);
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.ComboBoxCustomer.SelectedValue, null, false))
                {
                    command.Parameters.AddWithValue("CustomerFrontID", "0");
                }
                else
                {
                    command.Parameters.AddWithValue("CustomerFrontID", this.ComboBoxCustomer.SelectedValue);
                }
                command.Parameters.AddWithValue("InvSaleDateTime", time.ToString("yyyy/MM/dd HH:mm:ss"));
                if (!IH.A)
                {
                    command.Parameters.AddWithValue("InvSaleStatus", "0");
                }
                else
                {
                    command.Parameters.AddWithValue("InvSaleStatus", "3");
                }
                command.Parameters.AddWithValue("InvSalePayType", this.InvSalePayType.SelectedIndex);
                command.Parameters.AddWithValue("InvSaleMonBas", this.R.ToString(PR.VR));
                command.Parameters.AddWithValue("InvSaleMonPay", this.P.ToString(PR.VR));
                command.Parameters.AddWithValue("InvSaleMonBak", this.Q.ToString(PR.VR));
                command.Parameters.AddWithValue("InvSaleMonDem", this.I.ToString(PR.VR));
                command.Parameters.AddWithValue("InvSaleMonRod", this.D.ToString(PR.VR));
                command.Parameters.AddWithValue("InvSaleIsMonRod", this.CheckBoxIsRandomX.Checked);
                command.Parameters.AddWithValue("InvSaleNote", this.InvSaleNote.Text);
                command.Parameters.AddWithValue("InvSaleUserAddBy", A.D.A.A.TxTUserName.Text);
                command.Parameters.AddWithValue("InvSaleOtherCuru", this.InvSaleOtherCuru.Text);
                command.Parameters.AddWithValue("InvSaleIsCashCount", this.CheckBoxCash.Checked);
                command.Parameters.AddWithValue("InvSaleCusLastBalance", this.TxTCustomerLastBalance.Text);
                command.Parameters.AddWithValue("HashQR", this.R.ToString());
                command.ExecuteNonQuery();
                this.A.Close();
                PR.A = Conversions.ToInteger(this.F.Text);
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("UPDATE [TaNNInvSaleItems] SET [CustomerFrontID] = @CustomerFrontID, [HSaleType] = @HSaleType, [HSaleDateTime] = @HSaleDateTime, [HSaleUserAddBy] = @HSaleUserAddBy WHERE [InvSaleFrontID] = @InvSaleFrontID", this.A);
                command2.Parameters.AddWithValue("InvSaleFrontID", IH.A);
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.ComboBoxCustomer.SelectedValue, null, false))
                {
                    command2.Parameters.AddWithValue("CustomerFrontID", "0");
                }
                else
                {
                    command2.Parameters.AddWithValue("CustomerFrontID", this.ComboBoxCustomer.SelectedValue);
                }
                command2.Parameters.AddWithValue("HSaleType", A.D.A.A.InvSaleType.SelectedIndex);
                command2.Parameters.AddWithValue("HSaleDateTime", time.ToString("yyyy/MM/dd HH:mm:ss"));
                command2.Parameters.AddWithValue("HSaleUserAddBy", A.D.A.A.TxTUserName.Text);
                command2.ExecuteNonQuery();
                this.A.Close();
                if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectNotEqual(this.ComboBoxCustomer.SelectedValue, null, false), Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectGreater(this.ComboBoxCustomer.SelectedValue, 0, false))) && !this.R)
                {
                    int num = 0;
                    string str3 = "";
                    if (A.D.A.A.InvSaleType.SelectedIndex == 0)
                    {
                        num = 100;
                        str3 = "فاتورة مبيعات رقم " + this.F.Text;
                    }
                    else if (A.D.A.A.InvSaleType.SelectedIndex == 1)
                    {
                        num = 200;
                        str3 = "فاتورة مرتجع مبيعات رقم " + this.F.Text;
                    }
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command3 = new SqlCommand("INSERT INTO [TaNNCustomersPay] ([CenterFrontID], [CustomerFrontID], [InvSaleIDFront], [PayType], [PayMethods], [PayDateTimer], [PayDesic], [PayMony], [PayEmploy], [PayNote], [PayIsCashCount]) VALUES (@CenterFrontID, @CustomerFrontID, @InvSaleIDFront, @PayType, @PayMethods, @PayDateTimer, @PayDesic, @PayMony, @PayEmploy, @PayNote, @PayIsCashCount)", this.A);
                    command3.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command3.Parameters.AddWithValue("InvSaleIDFront", IH.A);
                    command3.Parameters.AddWithValue("CustomerFrontID", this.ComboBoxCustomer.SelectedValue);
                    command3.Parameters.AddWithValue("PayType", num);
                    command3.Parameters.AddWithValue("PayMethods", this.InvSalePayType.SelectedIndex);
                    command3.Parameters.AddWithValue("PayDateTimer", time.ToString("yyyy/MM/dd HH:mm:ss"));
                    command3.Parameters.AddWithValue("PayDesic", str3.ToString());
                    command3.Parameters.AddWithValue("PayMony", this.F.ToString(PR.VR));
                    command3.Parameters.AddWithValue("PayNote", this.TxTPayNote.Text);
                    command3.Parameters.AddWithValue("PayEmploy", A.D.A.A.TxTUserName.Text);
                    command3.Parameters.AddWithValue("PayIsCashCount", this.CheckBoxCash.Checked);
                    command3.ExecuteNonQuery();
                    this.A.Close();
                    if (A.D.A.A.InvSaleType.SelectedIndex == 0)
                    {
                        num = 0x65;
                        str3 = "دفعة عن فاتورة مبيعات رقم " + this.F.Text;
                    }
                    else if (A.D.A.A.InvSaleType.SelectedIndex == 1)
                    {
                        num = 0xc9;
                        str3 = "دفعة عن فاتورة مرتجع مبيعات رقم " + this.F.Text;
                    }
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command4 = new SqlCommand("INSERT INTO [TaNNCustomersPay] ([CenterFrontID], [CustomerFrontID], [InvSaleIDFront], [PayType], [PayMethods], [PayDateTimer], [PayDesic], [PayMony], [PayEmploy], [PayNote], [PayIsCashCount]) VALUES (@CenterFrontID, @CustomerFrontID, @InvSaleIDFront, @PayType, @PayMethods, @PayDateTimer, @PayDesic, @PayMony, @PayEmploy, @PayNote, @PayIsCashCount)", this.A);
                    command4.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command4.Parameters.AddWithValue("InvSaleIDFront", IH.A);
                    command4.Parameters.AddWithValue("CustomerFrontID", this.ComboBoxCustomer.SelectedValue);
                    command4.Parameters.AddWithValue("PayType", num);
                    command4.Parameters.AddWithValue("PayMethods", this.InvSalePayType.SelectedIndex);
                    command4.Parameters.AddWithValue("PayDateTimer", time.ToString("yyyy/MM/dd HH:mm:ss"));
                    command4.Parameters.AddWithValue("PayDesic", str3.ToString());
                    command4.Parameters.AddWithValue("PayMony", this.H.ToString(PR.VR));
                    command4.Parameters.AddWithValue("PayNote", this.TxTPayNote.Text);
                    command4.Parameters.AddWithValue("PayEmploy", A.D.A.A.TxTUserName.Text);
                    command4.Parameters.AddWithValue("PayIsCashCount", this.CheckBoxCash.Checked);
                    command4.ExecuteNonQuery();
                    this.A.Close();
                    if (decimal.Compare(this.T, decimal.Zero) > 0)
                    {
                        num = 500;
                        str3 = "رصيد مدور باقي دفعة فاتورة مبيعات رقم " + this.F.Text;
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command6 = new SqlCommand("INSERT INTO [TaNNCustomersPay] ([CenterFrontID], [CustomerFrontID], [InvSaleIDFront], [PayType], [PayMethods], [PayDateTimer], [PayDesic], [PayMony], [PayEmploy], [PayNote], [PayIsCashCount]) VALUES (@CenterFrontID, @CustomerFrontID, @InvSaleIDFront, @PayType, @PayMethods, @PayDateTimer, @PayDesic, @PayMony, @PayEmploy, @PayNote, @PayIsCashCount)", this.A);
                        command6.Parameters.AddWithValue("CenterFrontID", PR.GR);
                        command6.Parameters.AddWithValue("InvSaleIDFront", IH.A);
                        command6.Parameters.AddWithValue("CustomerFrontID", this.ComboBoxCustomer.SelectedValue);
                        command6.Parameters.AddWithValue("PayType", num);
                        command6.Parameters.AddWithValue("PayMethods", this.InvSalePayType.SelectedIndex);
                        command6.Parameters.AddWithValue("PayDateTimer", time.ToString("yyyy/MM/dd HH:mm:ss"));
                        command6.Parameters.AddWithValue("PayDesic", str3.ToString());
                        command6.Parameters.AddWithValue("PayMony", this.T.ToString(PR.VR));
                        command6.Parameters.AddWithValue("PayNote", this.TxTPayNote.Text);
                        command6.Parameters.AddWithValue("PayEmploy", A.D.A.A.TxTUserName.Text);
                        command6.Parameters.AddWithValue("PayIsCashCount", this.CheckBoxCash.Checked);
                        command6.ExecuteNonQuery();
                        this.A.Close();
                    }
                    if (Conversion.Val(this.TxTInvSaleTotalNET.Text.Replace(",", "")) >= Conversion.Val(PR.GP))
                    {
                        if (A.D.A.A.InvSaleType.SelectedIndex == 0)
                        {
                            this.D.Text = Conversions.ToString((double) (Conversion.Val(this.D.Text) + 1.0));
                        }
                        else if (A.D.A.A.InvSaleType.SelectedIndex == 1)
                        {
                            this.D.Text = Conversions.ToString((double) (Conversion.Val(this.D.Text) - 1.0));
                        }
                    }
                    decimal num2 = new decimal(((Conversion.Val(this.TxTCustomerLastBalance.Text.Replace(",", "")) + Convert.ToDouble(this.F)) + Convert.ToDouble(this.H)) + Convert.ToDouble(this.T));
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command5 = new SqlCommand("UPDATE [TaNNCustomers] SET [CustomerBalance] = @CustomerBalance, [CustomerPoints] =@CustomerPoints, [CustomerDateConfigur] = @CustomerDateConfigur, [CustomerUserAddBy] = @CustomerUserAddBy WHERE [CustomerID] = @CustomerID", this.A);
                    command5.Parameters.AddWithValue("CustomerID", this.ComboBoxCustomer.SelectedValue);
                    command5.Parameters.AddWithValue("CustomerBalance", num2.ToString(PR.VR));
                    command5.Parameters.AddWithValue("CustomerPoints", Conversion.Val(this.D.Text));
                    command5.Parameters.AddWithValue("CustomerDateConfigur", DateTime.Now.ToString("yyyy/MM/dd"));
                    command5.Parameters.AddWithValue("CustomerUserAddBy", A.D.A.A.TxTUserName.Text);
                    command5.ExecuteNonQuery();
                    this.A.Close();
                    this.R = true;
                }
                if (PR.O)
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command7 = new SqlCommand("UPDATE TaNNTables SET InvSaleFrontID =@InvSaleFrontID, TableIsBooking =@TableIsBooking WHERE (TableID = @TableID)", this.A);
                    command7.Parameters.AddWithValue("TableID", QH.LR.Text);
                    command7.Parameters.AddWithValue("InvSaleFrontID", DBNull.Value);
                    command7.Parameters.AddWithValue("TableIsBooking", false);
                    command7.ExecuteNonQuery();
                    this.A.Close();
                }
                if (IH.A)
                {
                    A.D.A.A.TimerLoadData.Enabled = true;
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    A.D.A.A.Dispose();
                    base.Dispose();
                }
                else
                {
                    try
                    {
                        if (this.CheckBoxPrintNAuto.Checked)
                        {
                            LF.A = IH.A;
                            if (this.ComboBoxNPrinterSize.SelectedIndex == 0)
                            {
                                A.D.A.A.Q();
                            }
                            else if (this.ComboBoxNPrinterSize.SelectedIndex == 1)
                            {
                                A.D.A.A.I();
                            }
                            else if (this.ComboBoxNPrinterSize.SelectedIndex == 2)
                            {
                                A.D.A.A.D();
                            }
                            else if (this.ComboBoxNPrinterSize.SelectedIndex == 3)
                            {
                                A.D.A.A.F();
                            }
                            else if (this.ComboBoxNPrinterSize.SelectedIndex == 4)
                            {
                                A.D.A.A.H();
                            }
                            else if (this.ComboBoxNPrinterSize.SelectedIndex == 5)
                            {
                                A.D.A.A.T();
                            }
                            else if (this.ComboBoxNPrinterSize.SelectedIndex == 6)
                            {
                                A.D.A.A.X();
                            }
                            else if (this.ComboBoxNPrinterSize.SelectedIndex == 7)
                            {
                                A.D.A.A.G();
                            }
                        }
                    }
                    catch (Exception exception1)
                    {
                        Exception ex = exception1;
                        ProjectData.SetProjectError(ex);
                        Exception exception = ex;
                        base.Opacity = 100.0;
                        Interaction.MsgBox("جدث خطأ في اوامر طباعة الفاتورة " + exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                        base.Dispose();
                        ProjectData.ClearProjectError();
                    }
                    try
                    {
                        if (this.CheckBoxPrintQAuto.Checked)
                        {
                            if (AR.AR)
                            {
                                if (this.A.State == ConnectionState.Closed)
                                {
                                    this.A.Open();
                                }
                                SqlCommand command8 = new SqlCommand("INSERT INTO TaNNCloudPrint (CenterFrontID, InvID, TypID) VALUES (@CenterFrontID, @InvID, @TypID)", this.A);
                                command8.Parameters.AddWithValue("@CenterFrontID", PR.GR);
                                command8.Parameters.AddWithValue("@InvID", IH.A);
                                command8.Parameters.AddWithValue("@TypID", "2");
                                command8.ExecuteNonQuery();
                                this.A.Close();
                            }
                            else if (AR.W)
                            {
                                A.D.A.A.TxTInvoicID.Text = Conversions.ToString(IH.A);
                                A.D.A.A.R();
                            }
                            else
                            {
                                LF.A = IH.A;
                                A.D.A.A.P();
                            }
                        }
                    }
                    catch (Exception exception4)
                    {
                        Exception ex = exception4;
                        ProjectData.SetProjectError(ex);
                        Exception exception2 = ex;
                        base.Opacity = 100.0;
                        Interaction.MsgBox("جدث خطأ في اوامر طباعة الطلبية " + exception2.ToString(), MsgBoxStyle.ApplicationModal, null);
                        base.Dispose();
                        ProjectData.ClearProjectError();
                    }
                    string str9 = "";
                    if (A.D.A.A.InvSaleType.SelectedIndex == 0)
                    {
                        str9 = "مبيعات";
                    }
                    else if (A.D.A.A.InvSaleType.SelectedIndex == 1)
                    {
                        str9 = "مرتجع مبيعات";
                    }
                    string[] textArray1 = new string[12];
                    textArray1[0] = "اشعار فاتورة ";
                    textArray1[1] = this.ComboBoxCustomer.Text.ToString();
                    textArray1[2] = " ";
                    textArray1[3] = str9.ToString();
                    textArray1[4] = " رقم ";
                    textArray1[5] = this.F.Text.ToString();
                    textArray1[6] = " تاريخ ";
                    textArray1[7] = time.ToString("yyyy/MM/dd HH:mm");
                    textArray1[8] = " مبلغ ";
                    textArray1[9] = this.TxTInvSaleTotalNET.Text.ToString();
                    textArray1[10] = " شكرا لك ";
                    textArray1[11] = PR.ER.ToString();
                    string str10 = string.Concat(textArray1);
                    if (this.CheckBoxEmailSend.Checked && (this.T.Text != null))
                    {
                        PR.HR = this.T.Text;
                        PR.TR = PR.ER.ToString() + "  | " + str9.ToString();
                        PR.XR = str10.ToString();
                        A.D.A.A.Show();
                    }
                    if (this.CheckBoxWatsApp.Checked && (this.ComboBoxCustomer.Text != null))
                    {
                        GT.A = this.X.Text.Trim();
                        GT.R = str10.ToString();
                        A.D.A.A.R();
                    }
                    if (IH.A == AR.T)
                    {
                        AR.T = 0;
                    }
                    base.Opacity = 0.0;
                    if (!AR.P)
                    {
                        A.D.A.A.TimerNewOrOpenInvoice.Enabled = true;
                        base.Dispose();
                    }
                    else
                    {
                        A.D.A.A.PanelStand.Visible = true;
                        A.D.A.A.Dispose();
                        base.Dispose();
                    }
                    base.Dispose();
                }
            }
            catch (Exception exception5)
            {
                Exception ex = exception5;
                ProjectData.SetProjectError(ex);
                Exception exception3 = ex;
                base.Opacity = 100.0;
                Interaction.MsgBox("تحذير ... لقد حدث خطأ في عملية حفظ الفاتورة " + exception3.ToString(), MsgBoxStyle.ApplicationModal, null);
                A.D.A.A.ButtonFinishIn.Enabled = true;
                A.D.A.A.ButtonFinishIn.Text = "   إنهاء البيع وفتح الصندوق | العملاء | اجراءات F2";
                base.Dispose();
                ProjectData.ClearProjectError();
            }
        }

        private void Y(object A, EventArgs R)
        {
            if (AR.PR)
            {
                CD cd2 = new CD {
                    R = this.TxTPay
                };
                cd2.SetDesktopLocation(this.TxTPay.Location.X - this.TxTPay.PointToClient(new Point(this.TxTPay.Cursor.HotSpot.X, this.TxTPay.Cursor.HotSpot.Y)).X, (this.TxTPay.Location.Y - this.TxTPay.PointToClient(new Point(this.TxTPay.Cursor.HotSpot.X, this.TxTPay.Cursor.HotSpot.Y)).Y) + 0x16);
                cd2.ShowDialog();
                cd2 = null;
            }
        }

        internal virtual GroupBox GroupBoxNetInvoice
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label TxTInvSaleTotalNET
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBoxPay
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTPay
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                EventHandler handler3 = new EventHandler(this.Y);
                TextBox a = this.A;
                if (a != null)
                {
                    a.TextChanged -= handler;
                    a.KeyPress -= handler2;
                    a.Click -= handler3;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.TextChanged += handler;
                    a.KeyPress += handler2;
                    a.Click += handler3;
                }
            }
        }

        internal virtual GroupBox GroupBoxReturn
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual CheckBox CheckBoxIsRandomX
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual Label TxTInvSaleMonBak
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBoxRandom
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTInvSaleMonRod
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBoxDebit
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label TxTInvSaleMonDem
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBoxCustomer
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Button ButtonSerch
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual Button ButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual ComboBox ComboBoxCustomer
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
                EventHandler handler2 = new EventHandler(this.V);
                EventHandler handler3 = new EventHandler(this.B);
                ComboBox a = this.A;
                if (a != null)
                {
                    a.SelectedValueChanged -= handler;
                    a.TextChanged -= handler2;
                    a.GotFocus -= handler3;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.SelectedValueChanged += handler;
                    a.TextChanged += handler2;
                    a.GotFocus += handler3;
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
                EventHandler handler = new EventHandler(this.L);
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

        internal virtual ComboBox InvSalePayType
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                EventHandler handler2 = new EventHandler(this.T);
                ComboBox r = this.R;
                if (r != null)
                {
                    r.SelectedIndexChanged -= handler;
                    r.Click -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.SelectedIndexChanged += handler;
                    r.Click += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox TxTPayNote
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
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TextBox InvSaleNote
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual CheckBox CheckBoxPrintQAuto
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual ComboBox ComboBoxNPrinterSize
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                ComboBox p = this.P;
                if (p != null)
                {
                    p.SelectedIndexChanged -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual CheckBox CheckBoxPrintNAuto
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual Button ButtonOK
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual Button ButtonBack
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                Button i = this.I;
                if (i != null)
                {
                    i.Click -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.Click += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TextBox InvSaleOtherCuru
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTCustomerLastBalance
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox CheckBoxCash
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Timer TimerFinish
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual CheckBox CheckBoxEmailSend
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
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

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual PictureBox PictureBoxQR
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxWatsApp
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
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
    }
}

