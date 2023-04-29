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
    public class XD : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxCustomer"), CompilerGenerated]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1")]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTSuplierLastBalance")]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSerch")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonAdd"), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("ComboBoxSuplier"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2"), CompilerGenerated]
        private GroupBox P;
        [CompilerGenerated, AccessedThroughProperty("TxTPayNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("GroupBoxDebit"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [CompilerGenerated, AccessedThroughProperty("TxTInvPurchMonDem"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBoxRandom")]
        private GroupBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTInvPurchMonRod")]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("GroupBoxReturn"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxIsRandomX"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("TxTInvPurchMonBak"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("GroupBoxNetInvoice"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxPay")]
        private GroupBox H;
        [AccessedThroughProperty("InvPurchPayType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchNote")]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox5"), CompilerGenerated]
        private GroupBox X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchType"), CompilerGenerated]
        private ComboBox P;
        [CompilerGenerated, AccessedThroughProperty("GroupBox11"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxDis")]
        private GroupBox E;
        [AccessedThroughProperty("InvPurchDisVal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [CompilerGenerated, AccessedThroughProperty("InvPurchDisMaWi"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label11")]
        private Label I;
        [AccessedThroughProperty("Label10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTInvPurchTotalNET"), CompilerGenerated]
        private TextBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTPay")]
        private TextBox D;
        [AccessedThroughProperty("GroupBox7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [AccessedThroughProperty("TxTInvPurchTotalAmount"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox F;
        [AccessedThroughProperty("GroupBox8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox U;
        [AccessedThroughProperty("InvPurchDarVal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchDarMiWi"), CompilerGenerated]
        private TextBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label F;
        [CompilerGenerated, AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchItems")]
        private TextBox X;
        [AccessedThroughProperty("InvPurchDateTime"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker A;
        [AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox L;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox4")]
        private GroupBox N;
        [AccessedThroughProperty("InvPurchNumber"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxCash"), CompilerGenerated]
        private CheckBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonClose")]
        private Button P;
        [AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [CompilerGenerated, AccessedThroughProperty("ButtonCurr"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button I;
        [AccessedThroughProperty("GroupBox10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox V;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchOtherCuru")]
        private TextBox E;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label T;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxAutoCount"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxDarWith")]
        private CheckBox Q;
        private SqlConnection A;
        private decimal A;
        private decimal R;
        private decimal P;
        private decimal Q;
        private decimal I;
        private decimal D;
        private decimal F;
        private decimal H;
        private decimal T;
        private decimal X;
        private decimal G;
        private decimal E;
        private string A;
        public static int A;

        public XD()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.AR);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = 0M;
            this.R = 0M;
            this.P = 0M;
            this.Q = 0M;
            this.I = 0M;
            this.D = 0M;
            this.F = 0M;
            this.H = 0M;
            this.T = 0M;
            this.X = 0M;
            this.G = 0M;
            this.E = 0M;
            this.A = "*";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.GroupBoxCustomer = new GroupBox();
            this.GroupBox1 = new GroupBox();
            this.TxTSuplierLastBalance = new Label();
            this.ButtonSerch = new Button();
            this.ButtonAdd = new Button();
            this.ComboBoxSuplier = new ComboBox();
            this.GroupBox2 = new GroupBox();
            this.TxTPayNote = new TextBox();
            this.GroupBoxDebit = new GroupBox();
            this.TxTInvPurchMonDem = new Label();
            this.GroupBoxRandom = new GroupBox();
            this.TxTInvPurchMonRod = new Label();
            this.GroupBoxReturn = new GroupBox();
            this.CheckBoxIsRandomX = new CheckBox();
            this.TxTInvPurchMonBak = new Label();
            this.GroupBoxNetInvoice = new GroupBox();
            this.TxTInvPurchTotalNET = new TextBox();
            this.GroupBoxPay = new GroupBox();
            this.TxTPay = new TextBox();
            this.InvPurchPayType = new ComboBox();
            this.GroupBox3 = new GroupBox();
            this.InvPurchNote = new TextBox();
            this.GroupBox5 = new GroupBox();
            this.InvPurchType = new ComboBox();
            this.GroupBox11 = new GroupBox();
            this.InvPurchItems = new TextBox();
            this.GroupBoxDis = new GroupBox();
            this.InvPurchDisVal = new TextBox();
            this.InvPurchDisMaWi = new TextBox();
            this.Label11 = new Label();
            this.Label10 = new Label();
            this.GroupBox7 = new GroupBox();
            this.TxTInvPurchTotalAmount = new TextBox();
            this.GroupBox8 = new GroupBox();
            this.InvPurchDarVal = new TextBox();
            this.InvPurchDarMiWi = new TextBox();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.InvPurchDateTime = new DateTimePicker();
            this.GroupBox9 = new GroupBox();
            this.GroupBox4 = new GroupBox();
            this.InvPurchNumber = new TextBox();
            this.CheckBoxCash = new CheckBox();
            this.ButtonClose = new Button();
            this.ButtonOK = new Button();
            this.ButtonCurr = new Button();
            this.GroupBox10 = new GroupBox();
            this.InvPurchOtherCuru = new TextBox();
            this.TxTTitle = new Label();
            this.CheckBoxAutoCount = new CheckBox();
            this.CheckBoxDarWith = new CheckBox();
            this.GroupBoxCustomer.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBoxDebit.SuspendLayout();
            this.GroupBoxRandom.SuspendLayout();
            this.GroupBoxReturn.SuspendLayout();
            this.GroupBoxNetInvoice.SuspendLayout();
            this.GroupBoxPay.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBoxDis.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            base.SuspendLayout();
            this.GroupBoxCustomer.Controls.Add(this.GroupBox1);
            this.GroupBoxCustomer.Controls.Add(this.ButtonSerch);
            this.GroupBoxCustomer.Controls.Add(this.ButtonAdd);
            this.GroupBoxCustomer.Controls.Add(this.ComboBoxSuplier);
            this.GroupBoxCustomer.Location = new Point(12, 0x17f);
            this.GroupBoxCustomer.Name = "GroupBoxCustomer";
            this.GroupBoxCustomer.Size = new Size(0x1a0, 0xa5);
            this.GroupBoxCustomer.TabIndex = 9;
            this.GroupBoxCustomer.TabStop = false;
            this.GroupBoxCustomer.Text = "المورد";
            this.GroupBox1.Controls.Add(this.TxTSuplierLastBalance);
            this.GroupBox1.Location = new Point(5, 0x61);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(400, 0x38);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "رصيد المورد السابق";
            this.TxTSuplierLastBalance.Dock = DockStyle.Top;
            this.TxTSuplierLastBalance.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTSuplierLastBalance.Location = new Point(3, 0x13);
            this.TxTSuplierLastBalance.Name = "TxTSuplierLastBalance";
            this.TxTSuplierLastBalance.RightToLeft = RightToLeft.No;
            this.TxTSuplierLastBalance.Size = new Size(0x18a, 0x1f);
            this.TxTSuplierLastBalance.TabIndex = 12;
            this.TxTSuplierLastBalance.Text = "0";
            this.TxTSuplierLastBalance.TextAlign = ContentAlignment.MiddleCenter;
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
            this.ButtonAdd.Size = new Size(0xed, 0x29);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "اضافة مورد";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ComboBoxSuplier.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.ComboBoxSuplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxSuplier.BackColor = SystemColors.Info;
            this.ComboBoxSuplier.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxSuplier.FormattingEnabled = true;
            this.ComboBoxSuplier.Location = new Point(8, 0x12);
            this.ComboBoxSuplier.Name = "ComboBoxSuplier";
            this.ComboBoxSuplier.Size = new Size(0x18d, 0x1a);
            this.ComboBoxSuplier.TabIndex = 11;
            this.GroupBox2.Controls.Add(this.TxTPayNote);
            this.GroupBox2.Location = new Point(0x1ba, 0x14c);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(300, 0x45);
            this.GroupBox2.TabIndex = 0x1c;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ملاحظات على الدفعة في حساب المورد";
            this.TxTPayNote.Dock = DockStyle.Fill;
            this.TxTPayNote.Location = new Point(3, 0x13);
            this.TxTPayNote.Margin = new Padding(5);
            this.TxTPayNote.MaxLength = 0xbb8;
            this.TxTPayNote.Multiline = true;
            this.TxTPayNote.Name = "TxTPayNote";
            this.TxTPayNote.Size = new Size(0x126, 0x2f);
            this.TxTPayNote.TabIndex = 0x16;
            this.GroupBoxDebit.Controls.Add(this.TxTInvPurchMonDem);
            this.GroupBoxDebit.Location = new Point(0x1ba, 0x110);
            this.GroupBoxDebit.Name = "GroupBoxDebit";
            this.GroupBoxDebit.Size = new Size(300, 0x36);
            this.GroupBoxDebit.TabIndex = 0x1b;
            this.GroupBoxDebit.TabStop = false;
            this.GroupBoxDebit.Text = "ذمم على الفاتورة";
            this.TxTInvPurchMonDem.Dock = DockStyle.Fill;
            this.TxTInvPurchMonDem.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInvPurchMonDem.ForeColor = Color.Red;
            this.TxTInvPurchMonDem.Location = new Point(3, 0x13);
            this.TxTInvPurchMonDem.Name = "TxTInvPurchMonDem";
            this.TxTInvPurchMonDem.RightToLeft = RightToLeft.No;
            this.TxTInvPurchMonDem.Size = new Size(0x126, 0x20);
            this.TxTInvPurchMonDem.TabIndex = 11;
            this.TxTInvPurchMonDem.Text = "0";
            this.TxTInvPurchMonDem.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxRandom.Controls.Add(this.TxTInvPurchMonRod);
            this.GroupBoxRandom.Location = new Point(0x1bb, 0xd4);
            this.GroupBoxRandom.Name = "GroupBoxRandom";
            this.GroupBoxRandom.Size = new Size(300, 0x36);
            this.GroupBoxRandom.TabIndex = 0x1a;
            this.GroupBoxRandom.TabStop = false;
            this.GroupBoxRandom.Text = "الباقي المدور لرصيد المورد";
            this.TxTInvPurchMonRod.Dock = DockStyle.Fill;
            this.TxTInvPurchMonRod.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInvPurchMonRod.ForeColor = Color.Blue;
            this.TxTInvPurchMonRod.Location = new Point(3, 0x13);
            this.TxTInvPurchMonRod.Name = "TxTInvPurchMonRod";
            this.TxTInvPurchMonRod.RightToLeft = RightToLeft.No;
            this.TxTInvPurchMonRod.Size = new Size(0x126, 0x20);
            this.TxTInvPurchMonRod.TabIndex = 11;
            this.TxTInvPurchMonRod.Text = "0";
            this.TxTInvPurchMonRod.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxReturn.Controls.Add(this.CheckBoxIsRandomX);
            this.GroupBoxReturn.Controls.Add(this.TxTInvPurchMonBak);
            this.GroupBoxReturn.Location = new Point(0x1bb, 130);
            this.GroupBoxReturn.Name = "GroupBoxReturn";
            this.GroupBoxReturn.Size = new Size(0x12b, 0x4c);
            this.GroupBoxReturn.TabIndex = 0x19;
            this.GroupBoxReturn.TabStop = false;
            this.GroupBoxReturn.Text = "الباقي المرتجع";
            this.CheckBoxIsRandomX.AutoSize = true;
            this.CheckBoxIsRandomX.BackColor = Color.Ivory;
            this.CheckBoxIsRandomX.Dock = DockStyle.Bottom;
            this.CheckBoxIsRandomX.Location = new Point(3, 0x31);
            this.CheckBoxIsRandomX.Name = "CheckBoxIsRandomX";
            this.CheckBoxIsRandomX.Padding = new Padding(2);
            this.CheckBoxIsRandomX.Size = new Size(0x125, 0x18);
            this.CheckBoxIsRandomX.TabIndex = 0x15;
            this.CheckBoxIsRandomX.Text = "تدوير المبلغ الزائد رصيد لي عند المورد";
            this.CheckBoxIsRandomX.UseVisualStyleBackColor = false;
            this.TxTInvPurchMonBak.Dock = DockStyle.Top;
            this.TxTInvPurchMonBak.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInvPurchMonBak.Location = new Point(3, 0x13);
            this.TxTInvPurchMonBak.Name = "TxTInvPurchMonBak";
            this.TxTInvPurchMonBak.RightToLeft = RightToLeft.No;
            this.TxTInvPurchMonBak.Size = new Size(0x125, 30);
            this.TxTInvPurchMonBak.TabIndex = 11;
            this.TxTInvPurchMonBak.Text = "0";
            this.TxTInvPurchMonBak.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxNetInvoice.Controls.Add(this.TxTInvPurchTotalNET);
            this.GroupBoxNetInvoice.Location = new Point(0xdf, 0x143);
            this.GroupBoxNetInvoice.Name = "GroupBoxNetInvoice";
            this.GroupBoxNetInvoice.Size = new Size(0xcd, 0x36);
            this.GroupBoxNetInvoice.TabIndex = 8;
            this.GroupBoxNetInvoice.TabStop = false;
            this.GroupBoxNetInvoice.Text = "صافي مبلغ الفاتورة";
            this.TxTInvPurchTotalNET.BackColor = SystemColors.Info;
            this.TxTInvPurchTotalNET.Dock = DockStyle.Top;
            this.TxTInvPurchTotalNET.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInvPurchTotalNET.Location = new Point(3, 0x13);
            this.TxTInvPurchTotalNET.MaxLength = 20;
            this.TxTInvPurchTotalNET.Name = "TxTInvPurchTotalNET";
            this.TxTInvPurchTotalNET.RightToLeft = RightToLeft.No;
            this.TxTInvPurchTotalNET.Size = new Size(0xc7, 0x17);
            this.TxTInvPurchTotalNET.TabIndex = 8;
            this.TxTInvPurchTotalNET.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxPay.Controls.Add(this.TxTPay);
            this.GroupBoxPay.Location = new Point(0x1bb, 0x25);
            this.GroupBoxPay.Name = "GroupBoxPay";
            this.GroupBoxPay.Size = new Size(0x12b, 0x31);
            this.GroupBoxPay.TabIndex = 10;
            this.GroupBoxPay.TabStop = false;
            this.GroupBoxPay.Text = "المبلغ المدفوع الفعلي الأن";
            this.TxTPay.BackColor = SystemColors.Info;
            this.TxTPay.Dock = DockStyle.Top;
            this.TxTPay.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTPay.Location = new Point(3, 0x13);
            this.TxTPay.MaxLength = 20;
            this.TxTPay.Name = "TxTPay";
            this.TxTPay.RightToLeft = RightToLeft.No;
            this.TxTPay.Size = new Size(0x125, 0x17);
            this.TxTPay.TabIndex = 12;
            this.TxTPay.TextAlign = HorizontalAlignment.Center;
            this.InvPurchPayType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvPurchPayType.FormattingEnabled = true;
            object[] items = new object[] { "نقدا", "ذمم", "شبكة", "تحويل", "الرصيد المدور", "شيك", "إئتمان" };
            this.InvPurchPayType.Items.AddRange(items);
            this.InvPurchPayType.Location = new Point(0x1bb, 0x5f);
            this.InvPurchPayType.Name = "InvPurchPayType";
            this.InvPurchPayType.Size = new Size(0xd5, 0x18);
            this.InvPurchPayType.TabIndex = 0x15;
            this.GroupBox3.Controls.Add(this.InvPurchNote);
            this.GroupBox3.Location = new Point(12, 0x98);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x19e, 0x45);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "ملاحظات على الفاتورة";
            this.InvPurchNote.Dock = DockStyle.Fill;
            this.InvPurchNote.Location = new Point(3, 0x13);
            this.InvPurchNote.Margin = new Padding(5);
            this.InvPurchNote.MaxLength = 0xbb8;
            this.InvPurchNote.Multiline = true;
            this.InvPurchNote.Name = "InvPurchNote";
            this.InvPurchNote.Size = new Size(0x198, 0x2f);
            this.InvPurchNote.TabIndex = 4;
            this.GroupBox5.Controls.Add(this.InvPurchType);
            this.GroupBox5.Location = new Point(12, 0x25);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0xf1, 0x35);
            this.GroupBox5.TabIndex = 0x1ed36ca;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "نوع الفاتورة";
            this.InvPurchType.Dock = DockStyle.Fill;
            this.InvPurchType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvPurchType.FormattingEnabled = true;
            object[] objArray2 = new object[] { "فاتورة مشتريات", "فاتورة مرتجع مشتريات" };
            this.InvPurchType.Items.AddRange(objArray2);
            this.InvPurchType.Location = new Point(3, 0x13);
            this.InvPurchType.Name = "InvPurchType";
            this.InvPurchType.Size = new Size(0xeb, 0x18);
            this.InvPurchType.TabIndex = 0;
            this.GroupBox11.BackColor = Color.White;
            this.GroupBox11.Controls.Add(this.InvPurchItems);
            this.GroupBox11.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox11.Location = new Point(0x100, 0x5f);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(170, 0x33);
            this.GroupBox11.TabIndex = 3;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "عدد المواد";
            this.InvPurchItems.BackColor = SystemColors.Info;
            this.InvPurchItems.Dock = DockStyle.Fill;
            this.InvPurchItems.Location = new Point(3, 0x13);
            this.InvPurchItems.MaxLength = 20;
            this.InvPurchItems.Name = "InvPurchItems";
            this.InvPurchItems.RightToLeft = RightToLeft.No;
            this.InvPurchItems.Size = new Size(0xa4, 0x17);
            this.InvPurchItems.TabIndex = 3;
            this.InvPurchItems.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxDis.Controls.Add(this.InvPurchDisVal);
            this.GroupBoxDis.Controls.Add(this.InvPurchDisMaWi);
            this.GroupBoxDis.Controls.Add(this.Label11);
            this.GroupBoxDis.Controls.Add(this.Label10);
            this.GroupBoxDis.Location = new Point(12, 0xe3);
            this.GroupBoxDis.Name = "GroupBoxDis";
            this.GroupBoxDis.Size = new Size(0x9a, 0x56);
            this.GroupBoxDis.TabIndex = 5;
            this.GroupBoxDis.TabStop = false;
            this.GroupBoxDis.Text = "الخصم";
            this.InvPurchDisVal.ForeColor = Color.DarkGreen;
            this.InvPurchDisVal.Location = new Point(6, 0x35);
            this.InvPurchDisVal.MaxLength = 20;
            this.InvPurchDisVal.Name = "InvPurchDisVal";
            this.InvPurchDisVal.RightToLeft = RightToLeft.No;
            this.InvPurchDisVal.Size = new Size(100, 0x17);
            this.InvPurchDisVal.TabIndex = 6;
            this.InvPurchDisVal.Text = "0";
            this.InvPurchDisVal.TextAlign = HorizontalAlignment.Center;
            this.InvPurchDisMaWi.ForeColor = Color.DarkGreen;
            this.InvPurchDisMaWi.Location = new Point(6, 0x18);
            this.InvPurchDisMaWi.MaxLength = 5;
            this.InvPurchDisMaWi.Name = "InvPurchDisMaWi";
            this.InvPurchDisMaWi.RightToLeft = RightToLeft.No;
            this.InvPurchDisMaWi.Size = new Size(100, 0x17);
            this.InvPurchDisMaWi.TabIndex = 5;
            this.InvPurchDisMaWi.Text = "0";
            this.InvPurchDisMaWi.TextAlign = HorizontalAlignment.Center;
            this.Label11.ForeColor = Color.DarkGreen;
            this.Label11.Location = new Point(0x70, 0x1b);
            this.Label11.Name = "Label11";
            this.Label11.Size = new Size(0x26, 0x10);
            this.Label11.TabIndex = 0;
            this.Label11.Text = "نسبة";
            this.Label11.TextAlign = ContentAlignment.TopCenter;
            this.Label10.ForeColor = Color.DarkGreen;
            this.Label10.Location = new Point(0x70, 0x38);
            this.Label10.Name = "Label10";
            this.Label10.Size = new Size(0x21, 0x10);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "مبلغ";
            this.Label10.TextAlign = ContentAlignment.MiddleLeft;
            this.GroupBox7.Controls.Add(this.TxTInvPurchTotalAmount);
            this.GroupBox7.Location = new Point(12, 0x143);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0xcd, 0x36);
            this.GroupBox7.TabIndex = 7;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "اجمالي مبلغ الفاتورة";
            this.TxTInvPurchTotalAmount.BackColor = SystemColors.Info;
            this.TxTInvPurchTotalAmount.Dock = DockStyle.Top;
            this.TxTInvPurchTotalAmount.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInvPurchTotalAmount.Location = new Point(3, 0x13);
            this.TxTInvPurchTotalAmount.MaxLength = 20;
            this.TxTInvPurchTotalAmount.Name = "TxTInvPurchTotalAmount";
            this.TxTInvPurchTotalAmount.RightToLeft = RightToLeft.No;
            this.TxTInvPurchTotalAmount.Size = new Size(0xc7, 0x17);
            this.TxTInvPurchTotalAmount.TabIndex = 9;
            this.TxTInvPurchTotalAmount.TextAlign = HorizontalAlignment.Center;
            this.GroupBox8.Controls.Add(this.InvPurchDarVal);
            this.GroupBox8.Controls.Add(this.InvPurchDarMiWi);
            this.GroupBox8.Controls.Add(this.Label1);
            this.GroupBox8.Controls.Add(this.Label2);
            this.GroupBox8.Location = new Point(0xac, 0xe3);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x9d, 0x56);
            this.GroupBox8.TabIndex = 6;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "الضريبة";
            this.InvPurchDarVal.ForeColor = Color.DarkGreen;
            this.InvPurchDarVal.Location = new Point(10, 0x35);
            this.InvPurchDarVal.MaxLength = 20;
            this.InvPurchDarVal.Name = "InvPurchDarVal";
            this.InvPurchDarVal.RightToLeft = RightToLeft.No;
            this.InvPurchDarVal.Size = new Size(100, 0x17);
            this.InvPurchDarVal.TabIndex = 8;
            this.InvPurchDarVal.Text = "0";
            this.InvPurchDarVal.TextAlign = HorizontalAlignment.Center;
            this.InvPurchDarMiWi.ForeColor = Color.DarkGreen;
            this.InvPurchDarMiWi.Location = new Point(10, 0x18);
            this.InvPurchDarMiWi.MaxLength = 5;
            this.InvPurchDarMiWi.Name = "InvPurchDarMiWi";
            this.InvPurchDarMiWi.RightToLeft = RightToLeft.No;
            this.InvPurchDarMiWi.Size = new Size(100, 0x17);
            this.InvPurchDarMiWi.TabIndex = 7;
            this.InvPurchDarMiWi.Text = "0";
            this.InvPurchDarMiWi.TextAlign = HorizontalAlignment.Center;
            this.Label1.ForeColor = Color.DarkGreen;
            this.Label1.Location = new Point(0x74, 0x1b);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x26, 0x10);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "نسبة";
            this.Label1.TextAlign = ContentAlignment.TopCenter;
            this.Label2.ForeColor = Color.DarkGreen;
            this.Label2.Location = new Point(0x74, 0x38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x21, 0x10);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "مبلغ";
            this.Label2.TextAlign = ContentAlignment.MiddleLeft;
            this.InvPurchDateTime.CustomFormat = "yyyy/MM/dd";
            this.InvPurchDateTime.Dock = DockStyle.Fill;
            this.InvPurchDateTime.Format = DateTimePickerFormat.Custom;
            this.InvPurchDateTime.Location = new Point(3, 0x13);
            this.InvPurchDateTime.Name = "InvPurchDateTime";
            this.InvPurchDateTime.RightToLeft = RightToLeft.No;
            this.InvPurchDateTime.Size = new Size(0xeb, 0x17);
            this.InvPurchDateTime.TabIndex = 2;
            this.GroupBox9.Controls.Add(this.InvPurchDateTime);
            this.GroupBox9.Location = new Point(12, 0x60);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0xf1, 50);
            this.GroupBox9.TabIndex = 2;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "التاريخ";
            this.GroupBox4.BackColor = Color.White;
            this.GroupBox4.Controls.Add(this.InvPurchNumber);
            this.GroupBox4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox4.Location = new Point(0x100, 0x27);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(170, 0x33);
            this.GroupBox4.TabIndex = 1;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "رقم الفاتورة";
            this.InvPurchNumber.BackColor = SystemColors.Info;
            this.InvPurchNumber.Dock = DockStyle.Fill;
            this.InvPurchNumber.Location = new Point(3, 0x13);
            this.InvPurchNumber.MaxLength = 20;
            this.InvPurchNumber.Name = "InvPurchNumber";
            this.InvPurchNumber.RightToLeft = RightToLeft.No;
            this.InvPurchNumber.Size = new Size(0xa4, 0x17);
            this.InvPurchNumber.TabIndex = 1;
            this.InvPurchNumber.TextAlign = HorizontalAlignment.Center;
            this.CheckBoxCash.AutoSize = true;
            this.CheckBoxCash.Checked = true;
            this.CheckBoxCash.CheckState = CheckState.Checked;
            this.CheckBoxCash.Location = new Point(0x1bd, 0x1f3);
            this.CheckBoxCash.Name = "CheckBoxCash";
            this.CheckBoxCash.Size = new Size(200, 20);
            this.CheckBoxCash.TabIndex = 0x1ed36d1;
            this.CheckBoxCash.Text = "قيد وتسجيل الحركة على الكاش";
            this.CheckBoxCash.UseVisualStyleBackColor = true;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x256, 0x22b);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x90, 40);
            this.ButtonClose.TabIndex = 0x1ed36d2;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonOK.BackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(12, 0x22b);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(580, 40);
            this.ButtonOK.TabIndex = 0x1ed36d3;
            this.ButtonOK.Text = "التالي";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonCurr.BackColor = Color.WhiteSmoke;
            this.ButtonCurr.FlatAppearance.BorderColor = Color.Green;
            this.ButtonCurr.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonCurr.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonCurr.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonCurr.FlatStyle = FlatStyle.Flat;
            this.ButtonCurr.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonCurr.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCurr.Location = new Point(0x296, 0x5d);
            this.ButtonCurr.Margin = new Padding(3, 4, 3, 4);
            this.ButtonCurr.Name = "ButtonCurr";
            this.ButtonCurr.Size = new Size(80, 30);
            this.ButtonCurr.TabIndex = 0x1ed36d4;
            this.ButtonCurr.Text = "عملات F11";
            this.ButtonCurr.UseVisualStyleBackColor = false;
            this.GroupBox10.Controls.Add(this.InvPurchOtherCuru);
            this.GroupBox10.Location = new Point(0x1bb, 0x196);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(300, 0x45);
            this.GroupBox10.TabIndex = 0x1ed36d5;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "عملات اخرى";
            this.InvPurchOtherCuru.Dock = DockStyle.Fill;
            this.InvPurchOtherCuru.Location = new Point(3, 0x13);
            this.InvPurchOtherCuru.Margin = new Padding(5);
            this.InvPurchOtherCuru.MaxLength = 0xbb8;
            this.InvPurchOtherCuru.Multiline = true;
            this.InvPurchOtherCuru.Name = "InvPurchOtherCuru";
            this.InvPurchOtherCuru.Size = new Size(0x126, 0x2f);
            this.InvPurchOtherCuru.TabIndex = 0x17;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(750, 0x22);
            this.TxTTitle.TabIndex = 0x1ed36d6;
            this.TxTTitle.Text = "اضافة/ تعديل فاتورة مشتريات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.CheckBoxAutoCount.AutoSize = true;
            this.CheckBoxAutoCount.BackColor = Color.WhiteSmoke;
            this.CheckBoxAutoCount.Dock = DockStyle.Bottom;
            this.CheckBoxAutoCount.Location = new Point(0, 0x25e);
            this.CheckBoxAutoCount.Name = "CheckBoxAutoCount";
            this.CheckBoxAutoCount.Padding = new Padding(2);
            this.CheckBoxAutoCount.Size = new Size(750, 0x18);
            this.CheckBoxAutoCount.TabIndex = 0x3e505a8f;
            this.CheckBoxAutoCount.Text = "احسب المجاميع تلقائي";
            this.CheckBoxAutoCount.UseVisualStyleBackColor = false;
            this.CheckBoxDarWith.AutoSize = true;
            this.CheckBoxDarWith.BackColor = Color.WhiteSmoke;
            this.CheckBoxDarWith.Dock = DockStyle.Bottom;
            this.CheckBoxDarWith.Location = new Point(0, 630);
            this.CheckBoxDarWith.Name = "CheckBoxDarWith";
            this.CheckBoxDarWith.Padding = new Padding(2);
            this.CheckBoxDarWith.Size = new Size(750, 0x18);
            this.CheckBoxDarWith.TabIndex = 0x3e505a8e;
            this.CheckBoxDarWith.Text = "احسب الضريبة على اساس ان سعر الشراء شامل الضريبة";
            this.CheckBoxDarWith.UseVisualStyleBackColor = false;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(750, 0x28e);
            base.ControlBox = false;
            base.Controls.Add(this.CheckBoxAutoCount);
            base.Controls.Add(this.CheckBoxDarWith);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.InvPurchPayType);
            base.Controls.Add(this.GroupBox10);
            base.Controls.Add(this.ButtonCurr);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.CheckBoxCash);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.GroupBox9);
            base.Controls.Add(this.GroupBox8);
            base.Controls.Add(this.GroupBox7);
            base.Controls.Add(this.GroupBoxDis);
            base.Controls.Add(this.GroupBox11);
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.GroupBoxPay);
            base.Controls.Add(this.GroupBoxNetInvoice);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.GroupBoxDebit);
            base.Controls.Add(this.GroupBoxRandom);
            base.Controls.Add(this.GroupBoxReturn);
            base.Controls.Add(this.GroupBoxCustomer);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "InvoicePurchAdd";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة/ تعديل فاتورة مشتريات";
            this.GroupBoxCustomer.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBoxDebit.ResumeLayout(false);
            this.GroupBoxRandom.ResumeLayout(false);
            this.GroupBoxReturn.ResumeLayout(false);
            this.GroupBoxReturn.PerformLayout();
            this.GroupBoxNetInvoice.ResumeLayout(false);
            this.GroupBoxNetInvoice.PerformLayout();
            this.GroupBoxPay.ResumeLayout(false);
            this.GroupBoxPay.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBoxDis.ResumeLayout(false);
            this.GroupBoxDis.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.InvPurchType.SelectedIndex = 0;
            this.InvPurchPayType.SelectedIndex = 0;
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
            this.R();
            if (XD.A <= 0)
            {
                this.ButtonOK.Text = "التالي";
            }
            else
            {
                this.ButtonOK.Text = "موافق";
                this.InvPurchType.Enabled = false;
                this.Q();
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

        private void AR(object A, EventArgs R)
        {
        }

        private void B(object A, EventArgs R)
        {
            this.D();
        }

        private void C(object A, EventArgs R)
        {
            this.D();
        }

        public void D()
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
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
            base.Dispose();
        }

        private void F(object A, EventArgs R)
        {
            if (!PR.GP)
            {
                Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                RT.A = 0;
                A.D.A.A.ShowDialog();
            }
        }

        private void G(object A, EventArgs R)
        {
            if (this.ComboBoxSuplier.Text == null)
            {
                this.ComboBoxSuplier.SelectedValue = 0;
                this.TxTSuplierLastBalance.Text = null;
            }
        }

        private void H(object A, EventArgs R)
        {
            this.I();
        }

        public void I()
        {
            this.Q = new decimal(Conversion.Val(this.InvPurchDisVal.Text.Replace(",", "")));
            this.I = new decimal(Conversion.Val(this.InvPurchDarVal.Text.Replace(",", "")));
            this.R = new decimal(Conversion.Val(this.TxTInvPurchTotalAmount.Text.Replace(",", "")));
            this.A = new decimal(Conversion.Val(this.TxTInvPurchTotalNET.Text.Replace(",", "")));
            this.P = new decimal(Conversion.Val(this.TxTPay.Text.Replace(",", "")));
            if (this.InvPurchType.SelectedIndex != 0)
            {
                if (this.InvPurchType.SelectedIndex == 1)
                {
                    this.CheckBoxIsRandomX.Checked = false;
                    this.CheckBoxIsRandomX.Enabled = false;
                    this.D = this.P;
                    this.F = 0M;
                    this.T = 0M;
                    this.H = 0M;
                    this.X = new decimal(Conversion.Val(this.A) * 1.0);
                    this.G = new decimal(Conversion.Val(this.D) * -1.0);
                    this.E = new decimal(Conversion.Val(this.T) * -1.0);
                }
            }
            else
            {
                if (decimal.Compare(this.P, this.A) == 0)
                {
                    this.D = this.P;
                    this.F = 0M;
                    this.H = 0M;
                    this.T = 0M;
                }
                if (decimal.Compare(this.P, this.A) <= 0)
                {
                    this.CheckBoxIsRandomX.Enabled = false;
                    this.CheckBoxIsRandomX.Checked = false;
                }
                else
                {
                    this.D = this.A;
                    this.CheckBoxIsRandomX.Enabled = true;
                    if (!this.CheckBoxIsRandomX.Checked)
                    {
                        this.F = decimal.Subtract(this.P, this.A);
                        this.T = 0M;
                        this.H = 0M;
                    }
                    else
                    {
                        this.F = 0M;
                        this.T = decimal.Subtract(this.P, this.A);
                        this.H = 0M;
                    }
                }
                if (decimal.Compare(this.P, this.A) < 0)
                {
                    this.D = this.P;
                    this.F = 0M;
                    this.T = 0M;
                    this.H = decimal.Subtract(this.A, this.P);
                }
                this.X = new decimal(Conversion.Val(this.A) * -1.0);
                this.G = new decimal(Conversion.Val(this.D) * 1.0);
                this.E = new decimal(Conversion.Val(this.T) * 1.0);
            }
            this.TxTInvPurchMonBak.Text = this.F.ToString(PR.YR);
            this.TxTInvPurchMonRod.Text = this.T.ToString(PR.YR);
            this.TxTInvPurchMonDem.Text = this.H.ToString(PR.YR);
        }

        private void I(object A, EventArgs R)
        {
            if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.ComboBoxSuplier.SelectedValue, null, false), this.ComboBoxSuplier.Text == null)))
            {
                this.TxTSuplierLastBalance.Text = null;
            }
            else
            {
                this.P();
            }
        }

        private void I(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void J(object A, EventArgs R)
        {
            this.D();
        }

        private void K(object A, EventArgs R)
        {
            this.TxTInvPurchTotalNET.Text = this.TxTInvPurchTotalAmount.Text;
            this.I();
        }

        private void L(object A, EventArgs R)
        {
        }

        private void M(object A, EventArgs R)
        {
            this.D();
        }

        private void N(object A, EventArgs R)
        {
            if (this.InvPurchPayType.SelectedIndex != 4)
            {
                this.TxTPay.Text = this.TxTInvPurchTotalNET.Text;
                this.TxTPayNote.Text = this.TxTPayNote.Text.Replace(this.A.ToString(), "").Trim();
                this.InvPurchNote.Text = this.InvPurchNote.Text.Replace(this.A.ToString(), "").Trim();
                this.TxTPay.Enabled = true;
                this.TxTPayNote.Enabled = true;
                this.InvPurchNote.Enabled = true;
                this.CheckBoxIsRandomX.Checked = true;
                this.CheckBoxIsRandomX.Enabled = true;
            }
            else
            {
                this.TxTPay.Enabled = false;
                this.TxTPayNote.Enabled = false;
                this.InvPurchNote.Enabled = false;
                this.TxTPay.Text = "0";
                this.A = "تم دفع مبلغ الفاتورة رقم " + this.InvPurchNumber.Text + " من الرصيد المدور وذلك بمبلغ " + this.TxTInvPurchTotalNET.Text;
                this.TxTPayNote.Text = this.TxTPayNote.Text.Trim() + " " + this.A.ToString();
                this.InvPurchNote.Text = this.InvPurchNote.Text.Trim() + " " + this.A.ToString();
                this.CheckBoxIsRandomX.Checked = false;
                this.CheckBoxIsRandomX.Enabled = false;
            }
        }

        private void O(object A, EventArgs R)
        {
            this.D();
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
                string selectCommandText = "SELECT [SuplierID], [SuplierName], [SuplierBalance] FROM TaNNSupliers WHERE (SuplierID = @SuplierID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("SuplierID", this.ComboBoxSuplier.SelectedValue);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.TxTSuplierLastBalance.Text = dataTable.Rows[0]["SuplierBalance"].ToString();
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
            this.I();
        }

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void Q()
        {
            Application.DoEvents();
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNInvPurch] WHERE ([InvPurchID] = @InvPurchID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("InvPurchID", A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxSuplier.SelectedValue = dataTable.Rows[0]["SuplierFrontID"].ToString();
                    this.InvPurchNumber.Text = dataTable.Rows[0]["InvPurchNumber"].ToString();
                    this.InvPurchDateTime.Value = Conversions.ToDate(dataTable.Rows[0]["InvPurchDateTime"].ToString());
                    this.InvPurchType.SelectedIndex = Conversions.ToInteger(dataTable.Rows[0]["InvPurchType"].ToString());
                    this.InvPurchPayType.SelectedIndex = Conversions.ToInteger(dataTable.Rows[0]["InvPurchPayType"].ToString());
                    this.InvPurchItems.Text = dataTable.Rows[0]["InvPurchItems"].ToString();
                    this.TxTInvPurchTotalAmount.Text = dataTable.Rows[0]["InvPurchTotalAmount"].ToString();
                    this.InvPurchDisMaWi.Text = dataTable.Rows[0]["InvPurchDisMaWi"].ToString();
                    this.InvPurchDisVal.Text = dataTable.Rows[0]["InvPurchDisVal"].ToString();
                    this.InvPurchDarMiWi.Text = dataTable.Rows[0]["InvPurchDarMiWi"].ToString();
                    this.InvPurchDarVal.Text = dataTable.Rows[0]["InvPurchDarVal"].ToString();
                    this.TxTInvPurchTotalNET.Text = dataTable.Rows[0]["InvPurchTotalNET"].ToString();
                    this.TxTPay.Text = dataTable.Rows[0]["InvPurchMonBas"].ToString();
                    this.CheckBoxIsRandomX.Checked = Conversions.ToBoolean(dataTable.Rows[0]["InvPurchIsMonRod"].ToString());
                    this.InvPurchNote.Text = dataTable.Rows[0]["InvPurchNote"].ToString();
                    this.InvPurchOtherCuru.Text = dataTable.Rows[0]["InvPurchOtherCuru"].ToString();
                }
                decimal num = new decimal(Conversion.Val(this.TxTInvPurchTotalAmount.Text.Replace(",", "")));
                decimal num2 = new decimal(Conversion.Val(this.InvPurchDisVal.Text.Replace(",", "")));
                decimal num3 = new decimal(Conversion.Val(this.InvPurchDarVal.Text.Replace(",", "")));
                decimal num4 = new decimal(Conversion.Val(this.TxTInvPurchTotalNET.Text.Replace(",", "")));
                this.TxTInvPurchTotalAmount.Text = num.ToString(PR.YR);
                this.InvPurchDisVal.Text = num2.ToString(PR.YR);
                this.InvPurchDarVal.Text = num3.ToString(PR.YR);
                this.TxTInvPurchTotalNET.Text = num4.ToString(PR.YR);
                if (this.InvPurchType.SelectedIndex == 1)
                {
                    this.CheckBoxIsRandomX.Checked = false;
                    this.CheckBoxIsRandomX.Enabled = false;
                }
                this.InvPurchType.Enabled = false;
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
            if (this.InvPurchType.SelectedIndex == 0)
            {
                this.GroupBoxPay.ForeColor = Color.Blue;
                this.GroupBoxNetInvoice.ForeColor = Color.Blue;
                this.TxTPay.ForeColor = Color.Black;
                this.TxTInvPurchTotalNET.ForeColor = Color.Black;
                this.CheckBoxIsRandomX.Enabled = true;
                this.CheckBoxIsRandomX.Checked = true;
            }
            else if (!PR.OP)
            {
                Interaction.MsgBox("غير مسموح لك بأضافة مرتجع مشتريات من مدير المتجر", MsgBoxStyle.ApplicationModal, null);
                this.InvPurchType.SelectedIndex = 0;
            }
            else
            {
                this.GroupBoxPay.ForeColor = Color.Red;
                this.GroupBoxNetInvoice.ForeColor = Color.Red;
                this.TxTPay.ForeColor = Color.Red;
                this.TxTInvPurchTotalNET.ForeColor = Color.Red;
                this.CheckBoxIsRandomX.Enabled = false;
                this.CheckBoxIsRandomX.Checked = false;
            }
            this.I();
        }

        private void Q(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
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
                string selectCommandText = "SELECT [SuplierID], [SuplierName], [SuplierBalance] FROM TaNNSupliers";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxSuplier.ValueMember = "SuplierID";
                    this.ComboBoxSuplier.DisplayMember = "SuplierName";
                    this.ComboBoxSuplier.DataSource = dataTable;
                    this.ComboBoxSuplier.SelectedIndex = -1;
                    this.TxTSuplierLastBalance.Text = null;
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
            this.I();
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void S(object A, EventArgs R)
        {
            this.D();
        }

        private void T(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                if (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.ComboBoxSuplier.SelectedValue, null, false), this.ComboBoxSuplier.Text == null)))
                {
                    if (!(((((this.InvPurchNumber.Text == null) | (this.InvPurchItems.Text == null)) | (this.TxTInvPurchTotalAmount.Text == null)) | (this.TxTPay.Text == null)) | (this.TxTInvPurchTotalNET.Text == null)))
                    {
                        if (this.InvPurchPayType.SelectedIndex == 4)
                        {
                            if (this.InvPurchType.SelectedIndex != 1)
                            {
                                if (!(Conversion.Val(this.TxTSuplierLastBalance.Text.Replace(",", "")) == 0.0))
                                {
                                    if (Conversion.Val(this.TxTSuplierLastBalance.Text.Replace(",", "")) < Conversion.Val(this.TxTInvPurchTotalNET.Text.Replace(",", "")))
                                    {
                                        Interaction.MsgBox("مبلغ الفاتورة اكبر من رصيد المورد المدور", MsgBoxStyle.ApplicationModal, null);
                                        this.InvPurchPayType.SelectedIndex = 0;
                                        base.Opacity = 100.0;
                                        return;
                                    }
                                }
                                else
                                {
                                    Interaction.MsgBox("لا يوجد مورد محدد/ او ان رصيد المورد المحدد صفر", MsgBoxStyle.ApplicationModal, null);
                                    this.InvPurchPayType.SelectedIndex = 0;
                                    base.Opacity = 100.0;
                                    return;
                                }
                            }
                            else
                            {
                                Interaction.MsgBox("لا يمكن التعامل مع الرصيد المدور في حال مرتجع المشتريات", MsgBoxStyle.ApplicationModal, null);
                                this.InvPurchPayType.SelectedIndex = 0;
                                base.Opacity = 100.0;
                                return;
                            }
                        }
                        if ((this.InvPurchType.SelectedIndex == 1) && (Conversion.Val(this.TxTPay.Text.Replace(",", "")) > Conversion.Val(this.TxTInvPurchTotalNET.Text.Replace(",", ""))))
                        {
                            Interaction.MsgBox("في حال مرتجع المشتريات يجب ادخال مبلغ اقل او يساوي من مبلغ الفاتورة", MsgBoxStyle.ApplicationModal, null);
                            base.Opacity = 100.0;
                        }
                        else if ((this.InvPurchPayType.SelectedIndex == 1) & (Conversion.Val(this.TxTPay.Text.Replace(",", "")) == Conversion.Val(this.TxTInvPurchTotalNET.Text.Replace(",", ""))))
                        {
                            Interaction.MsgBox("يجب تحديد المبلغ المدفوع (صفر او اقل او جزء) من مبلغ الفاتورة، لأنك حددت طريقة الدفع ذمم", MsgBoxStyle.ApplicationModal, null);
                            base.Opacity = 100.0;
                            this.TxTPay.Focus();
                        }
                        else
                        {
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            string cmdText = "";
                            cmdText = (XD.A <= 0) ? "INSERT INTO [TaNNInvPurch] ([CenterFrontID], [SuplierFrontID], [InvPurchNumber], [InvPurchDateTime], [InvPurchType], [InvPurchStatus], [InvPurchPayType], [InvPurchItems], [InvPurchTotalAmount], [InvPurchDisMaWi], [InvPurchDisVal], [InvPurchDarMiWi], [InvPurchDarVal], [InvPurchTotalNET], [InvPurchMonBas], [InvPurchMonPay], [InvPurchMonBak], [InvPurchMonDem], [InvPurchMonRod], [InvPurchIsMonRod], [InvPurchOtherCuru], [InvPurchNote], [InvPurchUserAddBy], [InvPurchIsCashCount]) VALUES (@CenterFrontID, @SuplierFrontID, @InvPurchNumber, @InvPurchDateTime, @InvPurchType, @InvPurchStatus, @InvPurchPayType, @InvPurchItems, @InvPurchTotalAmount, @InvPurchDisMaWi, @InvPurchDisVal, @InvPurchDarMiWi, @InvPurchDarVal, @InvPurchTotalNET, @InvPurchMonBas, @InvPurchMonPay, @InvPurchMonBak, @InvPurchMonDem, @InvPurchMonRod, @InvPurchIsMonRod, @InvPurchOtherCuru, @InvPurchNote, @InvPurchUserAddBy, @InvPurchIsCashCount); SELECT InvPurchID FROM TaNNInvPurch WHERE (InvPurchID = SCOPE_IDENTITY())" : "UPDATE [TaNNInvPurch] SET [CenterFrontID] = @CenterFrontID, [SuplierFrontID] = @SuplierFrontID, [InvPurchNumber] = @InvPurchNumber, [InvPurchDateTime] = @InvPurchDateTime, [InvPurchType] = @InvPurchType, [InvPurchStatus] = @InvPurchStatus, [InvPurchPayType] = @InvPurchPayType, [InvPurchItems] = @InvPurchItems, [InvPurchTotalAmount] = @InvPurchTotalAmount, [InvPurchDisMaWi] = @InvPurchDisMaWi, [InvPurchDisVal] = @InvPurchDisVal, [InvPurchDarMiWi] = @InvPurchDarMiWi, [InvPurchDarVal] = @InvPurchDarVal, [InvPurchTotalNET] = @InvPurchTotalNET, [InvPurchMonBas] = @InvPurchMonBas, [InvPurchMonPay] = @InvPurchMonPay, [InvPurchMonBak] = @InvPurchMonBak, [InvPurchMonDem] = @InvPurchMonDem, [InvPurchMonRod] = @InvPurchMonRod, [InvPurchIsMonRod] = @InvPurchIsMonRod, [InvPurchOtherCuru] = @InvPurchOtherCuru, [InvPurchNote] = @InvPurchNote, [InvPurchUserAddBy] = @InvPurchUserAddBy, [InvPurchIsCashCount] = @InvPurchIsCashCount WHERE [InvPurchID] = @InvPurchID";
                            SqlCommand command = new SqlCommand(cmdText, this.A);
                            command.Parameters.AddWithValue("@InvPurchID", XD.A);
                            command.Parameters.AddWithValue("@CenterFrontID", PR.GR);
                            command.Parameters.AddWithValue("@SuplierFrontID", this.ComboBoxSuplier.SelectedValue);
                            command.Parameters.AddWithValue("@InvPurchNumber", this.InvPurchNumber.Text.Trim());
                            command.Parameters.AddWithValue("@InvPurchDateTime", this.InvPurchDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                            command.Parameters.AddWithValue("@InvPurchType", this.InvPurchType.SelectedIndex);
                            if (XD.A > 0)
                            {
                                command.Parameters.AddWithValue("@InvPurchStatus", "3");
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@InvPurchStatus", "0");
                            }
                            command.Parameters.AddWithValue("@InvPurchPayType", this.InvPurchPayType.SelectedIndex);
                            command.Parameters.AddWithValue("@InvPurchItems", this.InvPurchItems.Text.Trim());
                            command.Parameters.AddWithValue("@InvPurchTotalAmount", this.R.ToString(PR.VR));
                            command.Parameters.AddWithValue("@InvPurchDisMaWi", Conversion.Val(this.InvPurchDisMaWi.Text));
                            command.Parameters.AddWithValue("@InvPurchDisVal", this.Q.ToString(PR.VR));
                            command.Parameters.AddWithValue("@InvPurchDarMiWi", Conversion.Val(this.InvPurchDarMiWi.Text));
                            command.Parameters.AddWithValue("@InvPurchDarVal", this.I.ToString(PR.VR));
                            command.Parameters.AddWithValue("@InvPurchTotalNET", this.A.ToString(PR.VR));
                            command.Parameters.AddWithValue("@InvPurchMonBas", this.P.ToString(PR.VR));
                            command.Parameters.AddWithValue("@InvPurchMonPay", this.D.ToString(PR.VR));
                            command.Parameters.AddWithValue("@InvPurchMonBak", this.F.ToString(PR.VR));
                            command.Parameters.AddWithValue("@InvPurchMonDem", this.H.ToString(PR.VR));
                            command.Parameters.AddWithValue("@InvPurchMonRod", this.T.ToString(PR.VR));
                            command.Parameters.AddWithValue("@InvPurchIsMonRod", this.CheckBoxIsRandomX.Checked);
                            command.Parameters.AddWithValue("@InvPurchOtherCuru", this.InvPurchOtherCuru.Text.Trim());
                            command.Parameters.AddWithValue("@InvPurchNote", this.InvPurchNote.Text.Trim());
                            command.Parameters.AddWithValue("@InvPurchUserAddBy", A.D.A.A.TxTUserName.Text);
                            command.Parameters.AddWithValue("@InvPurchIsCashCount", this.CheckBoxCash.Checked);
                            if (XD.A > 0)
                            {
                                command.ExecuteNonQuery();
                            }
                            else
                            {
                                XD.A = Conversions.ToInteger(command.ExecuteScalar());
                            }
                            this.A.Close();
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command2 = new SqlCommand("UPDATE [TaNNInvPurchItems] SET [SuplierFrontID] = @SuplierFrontID, [InvPurchType] =@InvPurchType, [InvPurchPurchDate] = @InvPurchPurchDate, [PurchUserAddBy] = @PurchUserAddBy WHERE [InvPurchIDFrontID] = @InvPurchIDFrontID", this.A);
                            command2.Parameters.AddWithValue("InvPurchIDFrontID", XD.A);
                            command2.Parameters.AddWithValue("SuplierFrontID", this.ComboBoxSuplier.SelectedValue);
                            command2.Parameters.AddWithValue("InvPurchType", this.InvPurchType.SelectedIndex);
                            command2.Parameters.AddWithValue("InvPurchPurchDate", this.InvPurchDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                            command2.Parameters.AddWithValue("PurchUserAddBy", A.D.A.A.TxTUserName.Text);
                            command2.ExecuteNonQuery();
                            this.A.Close();
                            int num = 0;
                            string str3 = "";
                            if (this.InvPurchType.SelectedIndex == 0)
                            {
                                num = 100;
                                str3 = "فاتورة مشتريات رقم " + this.InvPurchNumber.Text;
                            }
                            else if (this.InvPurchType.SelectedIndex == 1)
                            {
                                num = 200;
                                str3 = "فاتورة مرتجع مشتريات رقم " + this.InvPurchNumber.Text;
                            }
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command3 = new SqlCommand("INSERT INTO [TaNNSupliersPay] ([CenterFrontID], [SuplierFrontID], [InvPurchIDFront], [PayType], [PayMethods], [PayDateTimer], [PayDesic], [PayMony], [PayEmploy], [PayNote], [PayIsCashCount]) VALUES (@CenterFrontID, @SuplierFrontID, @InvPurchIDFront, @PayType, @PayMethods, @PayDateTimer, @PayDesic, @PayMony, @PayEmploy, @PayNote, @PayIsCashCount)", this.A);
                            command3.Parameters.AddWithValue("CenterFrontID", PR.GR);
                            command3.Parameters.AddWithValue("InvPurchIDFront", XD.A);
                            command3.Parameters.AddWithValue("SuplierFrontID", this.ComboBoxSuplier.SelectedValue);
                            command3.Parameters.AddWithValue("PayType", num);
                            command3.Parameters.AddWithValue("PayMethods", this.InvPurchPayType.SelectedIndex);
                            command3.Parameters.AddWithValue("PayDateTimer", this.InvPurchDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                            command3.Parameters.AddWithValue("PayDesic", str3.ToString());
                            command3.Parameters.AddWithValue("PayMony", this.X.ToString(PR.VR));
                            command3.Parameters.AddWithValue("PayNote", this.TxTPayNote.Text);
                            command3.Parameters.AddWithValue("PayEmploy", A.D.A.A.TxTUserName.Text);
                            command3.Parameters.AddWithValue("PayIsCashCount", this.CheckBoxCash.Checked);
                            command3.ExecuteNonQuery();
                            this.A.Close();
                            if (this.InvPurchType.SelectedIndex == 0)
                            {
                                num = 0x65;
                                str3 = "دفعة عن فاتورة مشتريات رقم " + this.InvPurchNumber.Text;
                            }
                            else if (this.InvPurchType.SelectedIndex == 1)
                            {
                                num = 0xc9;
                                str3 = "دفعة عن فاتورة مرتجع مشتريات رقم " + this.InvPurchNumber.Text;
                            }
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command4 = new SqlCommand("INSERT INTO [TaNNSupliersPay] ([CenterFrontID], [SuplierFrontID], [InvPurchIDFront], [PayType], [PayMethods], [PayDateTimer], [PayDesic], [PayMony], [PayEmploy], [PayNote], [PayIsCashCount]) VALUES (@CenterFrontID, @SuplierFrontID, @InvPurchIDFront, @PayType, @PayMethods, @PayDateTimer, @PayDesic, @PayMony, @PayEmploy, @PayNote, @PayIsCashCount)", this.A);
                            command4.Parameters.AddWithValue("CenterFrontID", PR.GR);
                            command4.Parameters.AddWithValue("InvPurchIDFront", XD.A);
                            command4.Parameters.AddWithValue("SuplierFrontID", this.ComboBoxSuplier.SelectedValue);
                            command4.Parameters.AddWithValue("PayType", num);
                            command4.Parameters.AddWithValue("PayMethods", this.InvPurchPayType.SelectedIndex);
                            command4.Parameters.AddWithValue("PayDateTimer", this.InvPurchDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                            command4.Parameters.AddWithValue("PayDesic", str3.ToString());
                            command4.Parameters.AddWithValue("PayMony", this.G.ToString(PR.VR));
                            command4.Parameters.AddWithValue("PayNote", this.TxTPayNote.Text);
                            command4.Parameters.AddWithValue("PayEmploy", A.D.A.A.TxTUserName.Text);
                            command4.Parameters.AddWithValue("PayIsCashCount", this.CheckBoxCash.Checked);
                            command4.ExecuteNonQuery();
                            this.A.Close();
                            if (decimal.Compare(this.E, decimal.Zero) > 0)
                            {
                                num = 500;
                                str3 = "رصيد مدور باقي دفعة فاتورة مشتريات رقم " + this.InvPurchNumber.Text;
                                if (this.A.State == ConnectionState.Closed)
                                {
                                    this.A.Open();
                                }
                                SqlCommand command6 = new SqlCommand("INSERT INTO [TaNNSupliersPay] ([CenterFrontID], [SuplierFrontID], [InvPurchIDFront], [PayType], [PayMethods], [PayDateTimer], [PayDesic], [PayMony], [PayEmploy], [PayNote], [PayIsCashCount]) VALUES (@CenterFrontID, @SuplierFrontID, @InvPurchIDFront, @PayType, @PayMethods, @PayDateTimer, @PayDesic, @PayMony, @PayEmploy, @PayNote, @PayIsCashCount)", this.A);
                                command6.Parameters.AddWithValue("CenterFrontID", PR.GR);
                                command6.Parameters.AddWithValue("InvPurchIDFront", XD.A);
                                command6.Parameters.AddWithValue("SuplierFrontID", this.ComboBoxSuplier.SelectedValue);
                                command6.Parameters.AddWithValue("PayType", num);
                                command6.Parameters.AddWithValue("PayMethods", this.InvPurchPayType.SelectedIndex);
                                command6.Parameters.AddWithValue("PayDateTimer", this.InvPurchDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                                command6.Parameters.AddWithValue("PayDesic", str3.ToString());
                                command6.Parameters.AddWithValue("PayMony", this.E.ToString(PR.VR));
                                command6.Parameters.AddWithValue("PayNote", this.TxTPayNote.Text);
                                command6.Parameters.AddWithValue("PayEmploy", A.D.A.A.TxTUserName.Text);
                                command6.Parameters.AddWithValue("PayIsCashCount", this.CheckBoxCash.Checked);
                                command6.ExecuteNonQuery();
                                this.A.Close();
                            }
                            decimal num2 = new decimal(((Conversion.Val(this.TxTSuplierLastBalance.Text.Replace(",", "")) + Convert.ToDouble(this.X)) + Convert.ToDouble(this.G)) + Convert.ToDouble(this.E));
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command5 = new SqlCommand("UPDATE [TaNNSupliers] SET [SuplierBalance] = @SuplierBalance, [SuplierDateConfigur] = @SuplierDateConfigur, [SuplierUserAddBy] = @SuplierUserAddBy WHERE [SuplierID] = @SuplierID", this.A);
                            command5.Parameters.AddWithValue("SuplierID", this.ComboBoxSuplier.SelectedValue);
                            command5.Parameters.AddWithValue("SuplierBalance", num2.ToString(PR.VR));
                            command5.Parameters.AddWithValue("SuplierDateConfigur", DateTime.Now.ToString("yyyy/MM/dd"));
                            command5.Parameters.AddWithValue("SuplierUserAddBy", A.D.A.A.TxTUserName.Text);
                            command5.ExecuteNonQuery();
                            this.A.Close();
                            GD.A = XD.A;
                            A.D.A.A.ShowDialog();
                            base.Dispose();
                        }
                    }
                    else
                    {
                        Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
                    }
                }
                else
                {
                    Interaction.MsgBox("يجب تحديد المورد", MsgBoxStyle.ApplicationModal, null);
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

        private void U(object A, EventArgs R)
        {
        }

        private void V(object A, EventArgs R)
        {
            A.D.A.A.TxTMaster.Text = this.TxTPay.Text;
            A.D.A.A.Show();
        }

        private void W(object A, EventArgs R)
        {
            this.D();
        }

        private void X(object A, EventArgs R)
        {
        }

        private void Y(object A, EventArgs R)
        {
        }

        private void Z(object A, EventArgs R)
        {
        }

        internal virtual GroupBox GroupBoxCustomer
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

        internal virtual Label TxTSuplierLastBalance
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonSerch
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual ComboBox ComboBoxSuplier
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                EventHandler handler2 = new EventHandler(this.X);
                EventHandler handler3 = new EventHandler(this.G);
                ComboBox a = this.A;
                if (a != null)
                {
                    a.SelectedValueChanged -= handler;
                    a.SelectedIndexChanged -= handler2;
                    a.TextChanged -= handler3;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.SelectedValueChanged += handler;
                    a.SelectedIndexChanged += handler2;
                    a.TextChanged += handler3;
                }
            }
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

        internal virtual TextBox TxTPayNote
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBoxDebit
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTInvPurchMonDem
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label TxTInvPurchMonRod
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBoxReturn
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual CheckBox CheckBoxIsRandomX
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual Label TxTInvPurchMonBak
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBoxNetInvoice
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual GroupBox GroupBoxPay
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual ComboBox InvPurchPayType
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
                ComboBox r = this.R;
                if (r != null)
                {
                    r.SelectedIndexChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.SelectedIndexChanged += handler;
                }
            }
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

        internal virtual TextBox InvPurchNote
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
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual ComboBox InvPurchType
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual GroupBox GroupBoxDis
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual TextBox InvPurchDisVal
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
                EventHandler handler2 = new EventHandler(this.B);
                TextBox p = this.P;
                if (p != null)
                {
                    p.TextChanged -= handler;
                    p.Leave -= handler2;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.TextChanged += handler;
                    p.Leave += handler2;
                }
            }
        }

        internal virtual TextBox InvPurchDisMaWi
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
                EventHandler handler3 = new EventHandler(this.O);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.TextChanged -= handler;
                    q.KeyPress -= handler2;
                    q.Leave -= handler3;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.TextChanged += handler;
                    q.KeyPress += handler2;
                    q.Leave += handler3;
                }
            }
        }

        internal virtual Label Label11
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label Label10
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox TxTInvPurchTotalNET
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual TextBox TxTPay
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.I);
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

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual TextBox TxTInvPurchTotalAmount
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
                EventHandler handler3 = new EventHandler(this.C);
                TextBox f = this.F;
                if (f != null)
                {
                    f.TextChanged -= handler;
                    f.KeyPress -= handler2;
                    f.Leave -= handler3;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.TextChanged += handler;
                    f.KeyPress += handler2;
                    f.Leave += handler3;
                }
            }
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual TextBox InvPurchDarVal
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Z);
                EventHandler handler2 = new EventHandler(this.M);
                TextBox h = this.H;
                if (h != null)
                {
                    h.TextChanged -= handler;
                    h.Leave -= handler2;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.TextChanged += handler;
                    h.Leave += handler2;
                }
            }
        }

        internal virtual TextBox InvPurchDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
                EventHandler handler3 = new EventHandler(this.S);
                TextBox t = this.T;
                if (t != null)
                {
                    t.TextChanged -= handler;
                    t.KeyPress -= handler2;
                    t.Leave -= handler3;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.TextChanged += handler;
                    t.KeyPress += handler2;
                    t.Leave += handler3;
                }
            }
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox InvPurchItems
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual DateTimePicker InvPurchDateTime
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual TextBox InvPurchNumber
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual CheckBox CheckBoxCash
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonClose
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

        internal virtual Button ButtonOK
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual Button ButtonCurr
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
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

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual TextBox InvPurchOtherCuru
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual CheckBox CheckBoxAutoCount
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.J);
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

        internal virtual CheckBox CheckBoxDarWith
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.W);
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

