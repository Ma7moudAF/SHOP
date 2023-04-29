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
    public class JD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TabPage5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [AccessedThroughProperty("Label12"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("MaterialPricLess"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [AccessedThroughProperty("Label5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("MaterialPricCost"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("Label6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label P;
        [AccessedThroughProperty("MaterialPricSale"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("LabTot"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("Label10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [AccessedThroughProperty("MaterialUnit"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label D;
        [AccessedThroughProperty("Label4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label F;
        [AccessedThroughProperty("MaterialQuantity"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Q;
        [AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("TimerRestTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer A;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("ButtonRandom"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button P;
        [AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label H;
        [AccessedThroughProperty("MaterialBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox I;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label T;
        [AccessedThroughProperty("GroupBoxGr"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox P;
        [AccessedThroughProperty("ButtonGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [AccessedThroughProperty("ComboBoxGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox R;
        [AccessedThroughProperty("GroupBoxDt"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage R;
        [AccessedThroughProperty("MaterialNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox D;
        [AccessedThroughProperty("Label8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label X;
        [AccessedThroughProperty("Label9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label G;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage P;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label E;
        [AccessedThroughProperty("ChKActiveDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox A;
        [CompilerGenerated, AccessedThroughProperty("MaterialExpDate"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [AccessedThroughProperty("TabPage3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage Q;
        [AccessedThroughProperty("MaterialQuantityLess"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox F;
        [AccessedThroughProperty("Label19"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label K;
        [AccessedThroughProperty("MaterialIsStop"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox R;
        [AccessedThroughProperty("MaterialNotIsView"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox P;
        [AccessedThroughProperty("MaterialName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox P;
        [AccessedThroughProperty("CheckBoxEmpty"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox Q;
        [AccessedThroughProperty("Label13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label U;
        [AccessedThroughProperty("MaterialQuantityOffer"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox H;
        [AccessedThroughProperty("Label15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label L;
        [AccessedThroughProperty("TabPage6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage I;
        [AccessedThroughProperty("Label16"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label N;
        [AccessedThroughProperty("MaterialDarMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox T;
        [AccessedThroughProperty("TabPage7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage D;
        [AccessedThroughProperty("MaterialDisMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox X;
        [AccessedThroughProperty("Label7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label V;
        [AccessedThroughProperty("MaterialQuantityPakeg"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox G;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [AccessedThroughProperty("MaterialOtherBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox E;
        [AccessedThroughProperty("TabPage4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage F;
        [AccessedThroughProperty("MaterialMultBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox K;
        [AccessedThroughProperty("Label14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Y;
        [AccessedThroughProperty("ButtonFX"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button I;
        [AccessedThroughProperty("DateTimePickerDis"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker R;
        [AccessedThroughProperty("Label18"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label O;
        [AccessedThroughProperty("DateTimePickerDisChe"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox I;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [AccessedThroughProperty("Label11"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label B;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        private SqlConnection A;
        public static int A;
        private Button D;
        private bool A;

        public JD()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.D);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.D = new Button();
            this.A = true;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.Label15 = new Label();
            this.Label13 = new Label();
            this.MaterialQuantityOffer = new TextBox();
            this.Label12 = new Label();
            this.MaterialPricLess = new TextBox();
            this.TabPage5 = new TabPage();
            this.Label7 = new Label();
            this.MaterialQuantityPakeg = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.MaterialOtherBarCode = new TextBox();
            this.Label5 = new Label();
            this.MaterialPricCost = new TextBox();
            this.Label6 = new Label();
            this.MaterialPricSale = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.LabTot = new Label();
            this.Label10 = new Label();
            this.MaterialUnit = new ComboBox();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.MaterialQuantity = new TextBox();
            this.TimerRestTitle = new Timer(this.A);
            this.GroupBox1 = new GroupBox();
            this.ButtonRandom = new Button();
            this.Label2 = new Label();
            this.MaterialBarCode = new TextBox();
            this.TxTTitle = new Label();
            this.GroupBoxGr = new GroupBox();
            this.ButtonGroup = new Button();
            this.ComboBoxGroup = new ComboBox();
            this.GroupBoxDt = new GroupBox();
            this.MaterialName = new ComboBox();
            this.TabControl1 = new TabControl();
            this.TabPage6 = new TabPage();
            this.ButtonFX = new Button();
            this.MaterialIsStop = new CheckBox();
            this.TabPage3 = new TabPage();
            this.Label16 = new Label();
            this.MaterialDarMiWi = new TextBox();
            this.TabPage7 = new TabPage();
            this.GroupBox5 = new GroupBox();
            this.Label11 = new Label();
            this.MaterialDisMiWi = new TextBox();
            this.DateTimePickerDis = new DateTimePicker();
            this.Label18 = new Label();
            this.DateTimePickerDisChe = new CheckBox();
            this.GroupBox2 = new GroupBox();
            this.TabPage2 = new TabPage();
            this.MaterialQuantityLess = new TextBox();
            this.Label19 = new Label();
            this.Label1 = new Label();
            this.ChKActiveDate = new CheckBox();
            this.MaterialExpDate = new DateTimePicker();
            this.TabPage1 = new TabPage();
            this.MaterialNotIsView = new CheckBox();
            this.MaterialNote = new TextBox();
            this.Label8 = new Label();
            this.Label9 = new Label();
            this.TabPage4 = new TabPage();
            this.Label14 = new Label();
            this.MaterialMultBarCode = new TextBox();
            this.ButtonOK = new Button();
            this.ButtonFinish = new Button();
            this.CheckBoxEmpty = new CheckBox();
            this.TabPage5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBoxGr.SuspendLayout();
            this.GroupBoxDt.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage4.SuspendLayout();
            base.SuspendLayout();
            this.Label15.AutoSize = true;
            this.Label15.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label15.ForeColor = Color.Gray;
            this.Label15.Location = new Point(0x3b, 0x70);
            this.Label15.Name = "Label15";
            this.Label15.Size = new Size(0x35, 13);
            this.Label15.TabIndex = 0x92b;
            this.Label15.Text = "< اختياري";
            this.Label13.AutoSize = true;
            this.Label13.Location = new Point(0xe5, 110);
            this.Label13.Name = "Label13";
            this.Label13.Size = new Size(0x15c, 0x10);
            this.Label13.TabIndex = 0x92a;
            this.Label13.Text = "اضافة سعر الخصم عندما تكون الكمية المباعة اكبر او يساوي من";
            this.MaterialQuantityOffer.BackColor = Color.White;
            this.MaterialQuantityOffer.Location = new Point(0x7b, 0x6b);
            this.MaterialQuantityOffer.MaxLength = 20;
            this.MaterialQuantityOffer.Name = "MaterialQuantityOffer";
            this.MaterialQuantityOffer.RightToLeft = RightToLeft.No;
            this.MaterialQuantityOffer.Size = new Size(100, 0x17);
            this.MaterialQuantityOffer.TabIndex = 0x929;
            this.MaterialQuantityOffer.TextAlign = HorizontalAlignment.Center;
            this.Label12.Dock = DockStyle.Bottom;
            this.Label12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label12.ForeColor = Color.Gray;
            this.Label12.Location = new Point(3, 0x42);
            this.Label12.Name = "Label12";
            this.Label12.Size = new Size(220, 15);
            this.Label12.TabIndex = 0x928;
            this.Label12.Text = " اختياري - الحد الأدنى لسعر البيع - الجملة";
            this.MaterialPricLess.BackColor = Color.White;
            this.MaterialPricLess.Location = new Point(6, 0x16);
            this.MaterialPricLess.MaxLength = 20;
            this.MaterialPricLess.Name = "MaterialPricLess";
            this.MaterialPricLess.RightToLeft = RightToLeft.No;
            this.MaterialPricLess.Size = new Size(0xd0, 0x17);
            this.MaterialPricLess.TabIndex = 4;
            this.MaterialPricLess.TextAlign = HorizontalAlignment.Center;
            this.TabPage5.Controls.Add(this.Label7);
            this.TabPage5.Controls.Add(this.MaterialQuantityPakeg);
            this.TabPage5.Controls.Add(this.GroupBox4);
            this.TabPage5.Location = new Point(4, 0x19);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new Padding(3);
            this.TabPage5.Size = new Size(0x24f, 150);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "ربط الوحدات";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.Label7.AutoSize = true;
            this.Label7.Location = new Point(0x1a6, 0x6a);
            this.Label7.Name = "Label7";
            this.Label7.Size = new Size(0x9a, 0x10);
            this.Label7.TabIndex = 0x386d;
            this.Label7.Text = "الكمية التي سيتم تزويدها:";
            this.MaterialQuantityPakeg.BackColor = Color.White;
            this.MaterialQuantityPakeg.Location = new Point(0x13c, 0x67);
            this.MaterialQuantityPakeg.MaxLength = 20;
            this.MaterialQuantityPakeg.Name = "MaterialQuantityPakeg";
            this.MaterialQuantityPakeg.RightToLeft = RightToLeft.No;
            this.MaterialQuantityPakeg.Size = new Size(100, 0x17);
            this.MaterialQuantityPakeg.TabIndex = 20;
            this.MaterialQuantityPakeg.TextAlign = HorizontalAlignment.Center;
            this.GroupBox4.Controls.Add(this.MaterialOtherBarCode);
            this.GroupBox4.Location = new Point(15, 0x10);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x234, 0x3b);
            this.GroupBox4.TabIndex = 0x16;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "رقم/ باركود المادة ذات الوحدة الأكبر في المستودع التي سيتم تزويد الكمية منها";
            this.MaterialOtherBarCode.BackColor = Color.White;
            this.MaterialOtherBarCode.Location = new Point(6, 0x1a);
            this.MaterialOtherBarCode.MaxLength = 250;
            this.MaterialOtherBarCode.Name = "MaterialOtherBarCode";
            this.MaterialOtherBarCode.RightToLeft = RightToLeft.No;
            this.MaterialOtherBarCode.Size = new Size(0x228, 0x17);
            this.MaterialOtherBarCode.TabIndex = 20;
            this.MaterialOtherBarCode.TextAlign = HorizontalAlignment.Center;
            this.Label5.AutoSize = true;
            this.Label5.Location = new Point(0x1dd, 0x1f);
            this.Label5.Name = "Label5";
            this.Label5.Size = new Size(0x4f, 0x10);
            this.Label5.TabIndex = 0x11;
            this.Label5.Text = "سعر التكلفة:";
            this.MaterialPricCost.BackColor = SystemColors.Info;
            this.MaterialPricCost.Location = new Point(0x160, 0x1c);
            this.MaterialPricCost.MaxLength = 20;
            this.MaterialPricCost.Name = "MaterialPricCost";
            this.MaterialPricCost.RightToLeft = RightToLeft.No;
            this.MaterialPricCost.Size = new Size(0x77, 0x17);
            this.MaterialPricCost.TabIndex = 0;
            this.MaterialPricCost.TextAlign = HorizontalAlignment.Center;
            this.Label6.AutoSize = true;
            this.Label6.Location = new Point(0x1dd, 0x41);
            this.Label6.Name = "Label6";
            this.Label6.Size = new Size(0x42, 0x10);
            this.Label6.TabIndex = 0x734;
            this.Label6.Text = "سعر البيع:";
            this.MaterialPricSale.BackColor = SystemColors.Info;
            this.MaterialPricSale.Location = new Point(0x160, 0x3e);
            this.MaterialPricSale.MaxLength = 20;
            this.MaterialPricSale.Name = "MaterialPricSale";
            this.MaterialPricSale.RightToLeft = RightToLeft.No;
            this.MaterialPricSale.Size = new Size(0x77, 0x17);
            this.MaterialPricSale.TabIndex = 1;
            this.MaterialPricSale.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.LabTot);
            this.GroupBox3.Location = new Point(0xc0, 0x12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x9a, 0x43);
            this.GroupBox3.TabIndex = 0x1dd2f1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الربح";
            this.LabTot.Dock = DockStyle.Top;
            this.LabTot.Font = new Font("Tahoma", 10f, FontStyle.Bold);
            this.LabTot.ForeColor = Color.Red;
            this.LabTot.Location = new Point(3, 0x13);
            this.LabTot.Name = "LabTot";
            this.LabTot.RightToLeft = RightToLeft.No;
            this.LabTot.Size = new Size(0x94, 0x1f);
            this.LabTot.TabIndex = 0;
            this.LabTot.Text = "00.00";
            this.LabTot.TextAlign = ContentAlignment.MiddleCenter;
            this.Label10.AutoSize = true;
            this.Label10.Location = new Point(0x92, 0x47);
            this.Label10.Name = "Label10";
            this.Label10.Size = new Size(0x30, 0x10);
            this.Label10.TabIndex = 0xab8;
            this.Label10.Text = "الوحده:";
            this.MaterialUnit.FormattingEnabled = true;
            object[] items = new object[0x19];
            items[0] = "";
            items[1] = "خدمة";
            items[2] = "مساعده";
            items[3] = "وجبة";
            items[4] = "بطاقات";
            items[5] = "شحن";
            items[6] = "صيانة";
            items[7] = "جهاز";
            items[8] = "غرام";
            items[9] = "كيلو";
            items[10] = "رطل";
            items[11] = "طن";
            items[12] = "كرتونة";
            items[13] = "كيس";
            items[14] = "طبق";
            items[15] = "علبة";
            items[0x10] = "صندوق";
            items[0x11] = "باكيت";
            items[0x12] = "قطعة";
            items[0x13] = "درزن";
            items[20] = "متر";
            items[0x15] = "سم";
            items[0x16] = "حبة";
            items[0x17] = "صندوق";
            items[0x18] = "اكتب اي شي اخر";
            this.MaterialUnit.Items.AddRange(items);
            this.MaterialUnit.Location = new Point(0x19, 0x44);
            this.MaterialUnit.MaxLength = 20;
            this.MaterialUnit.Name = "MaterialUnit";
            this.MaterialUnit.Size = new Size(0x73, 0x18);
            this.MaterialUnit.TabIndex = 7;
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(0x1eb, 0x25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x49, 0x10);
            this.Label3.TabIndex = 0x2cb4;
            this.Label3.Text = "اسم المادة:";
            this.Label4.AutoSize = true;
            this.Label4.Location = new Point(0x1eb, 0x47);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x5d, 0x10);
            this.Label4.TabIndex = 0x386c;
            this.Label4.Text = "الكمية المتوفرة:";
            this.MaterialQuantity.BackColor = SystemColors.Info;
            this.MaterialQuantity.Location = new Point(0x15f, 0x44);
            this.MaterialQuantity.MaxLength = 20;
            this.MaterialQuantity.Name = "MaterialQuantity";
            this.MaterialQuantity.RightToLeft = RightToLeft.No;
            this.MaterialQuantity.Size = new Size(0x7c, 0x17);
            this.MaterialQuantity.TabIndex = 6;
            this.MaterialQuantity.TextAlign = HorizontalAlignment.Center;
            this.TimerRestTitle.Interval = 0x3e8;
            this.GroupBox1.Controls.Add(this.ButtonRandom);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.MaterialBarCode);
            this.GroupBox1.Location = new Point(9, 0x25);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x257, 0x61);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "ادخل باركود/كود/ رقم الماده ثم اضغط Enter";
            this.ButtonRandom.BackColor = Color.WhiteSmoke;
            this.ButtonRandom.FlatStyle = FlatStyle.Flat;
            this.ButtonRandom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonRandom.Image = A.F.ImBarcode2;
            this.ButtonRandom.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonRandom.Location = new Point(0x13, 0x17);
            this.ButtonRandom.Name = "ButtonRandom";
            this.ButtonRandom.Size = new Size(0xb9, 0x20);
            this.ButtonRandom.TabIndex = 0x21e9d8;
            this.ButtonRandom.Text = "  كود عشوائي";
            this.ButtonRandom.UseVisualStyleBackColor = false;
            this.Label2.Dock = DockStyle.Bottom;
            this.Label2.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = Color.DarkGreen;
            this.Label2.Location = new Point(3, 0x39);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x251, 0x25);
            this.Label2.TabIndex = 0x254c9d;
            this.Label2.Text = "يمكنك إدخال الرقم من خلال الجهاز او إدخاله بشكل يدوي او ادخال اي رقم عشوائي تريده، يمكنك اضافة اكثر من رقم باركود بحيث يكون بين كل رقم باركود مسافة";
            this.MaterialBarCode.BackColor = SystemColors.Info;
            this.MaterialBarCode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.MaterialBarCode.Location = new Point(210, 0x1c);
            this.MaterialBarCode.MaxLength = 250;
            this.MaterialBarCode.Name = "MaterialBarCode";
            this.MaterialBarCode.RightToLeft = RightToLeft.No;
            this.MaterialBarCode.Size = new Size(0x17f, 0x17);
            this.MaterialBarCode.TabIndex = 1;
            this.MaterialBarCode.TextAlign = HorizontalAlignment.Center;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x266, 0x22);
            this.TxTTitle.TabIndex = 0x1c;
            this.TxTTitle.Text = "اضافة /تعديل مادة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxGr.Controls.Add(this.ButtonGroup);
            this.GroupBoxGr.Controls.Add(this.ComboBoxGroup);
            this.GroupBoxGr.Location = new Point(9, 0x9a);
            this.GroupBoxGr.Name = "GroupBoxGr";
            this.GroupBoxGr.Size = new Size(0x257, 0x3d);
            this.GroupBoxGr.TabIndex = 2;
            this.GroupBoxGr.TabStop = false;
            this.GroupBoxGr.Text = "حدد المجموعة";
            this.ButtonGroup.BackColor = Color.WhiteSmoke;
            this.ButtonGroup.FlatStyle = FlatStyle.Flat;
            this.ButtonGroup.Image = A.F.ImGroup;
            this.ButtonGroup.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonGroup.Location = new Point(6, 0x12);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Size = new Size(0x89, 0x22);
            this.ButtonGroup.TabIndex = 0x20550;
            this.ButtonGroup.Text = "إدارة";
            this.ButtonGroup.UseVisualStyleBackColor = false;
            this.ComboBoxGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxGroup.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxGroup.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxGroup.FormattingEnabled = true;
            this.ComboBoxGroup.IntegralHeight = false;
            object[] objArray2 = new object[] { "" };
            this.ComboBoxGroup.Items.AddRange(objArray2);
            this.ComboBoxGroup.Location = new Point(0x95, 0x17);
            this.ComboBoxGroup.Name = "ComboBoxGroup";
            this.ComboBoxGroup.Size = new Size(0x1b3, 0x18);
            this.ComboBoxGroup.TabIndex = 3;
            this.GroupBoxDt.Controls.Add(this.MaterialName);
            this.GroupBoxDt.Controls.Add(this.Label10);
            this.GroupBoxDt.Controls.Add(this.MaterialUnit);
            this.GroupBoxDt.Controls.Add(this.Label3);
            this.GroupBoxDt.Controls.Add(this.Label4);
            this.GroupBoxDt.Controls.Add(this.MaterialQuantity);
            this.GroupBoxDt.Location = new Point(9, 0xdd);
            this.GroupBoxDt.Name = "GroupBoxDt";
            this.GroupBoxDt.Size = new Size(0x257, 0x6a);
            this.GroupBoxDt.TabIndex = 4;
            this.GroupBoxDt.TabStop = false;
            this.GroupBoxDt.Text = "معلومات المادة";
            this.MaterialName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.MaterialName.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.MaterialName.BackColor = SystemColors.Info;
            this.MaterialName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.MaterialName.FormattingEnabled = true;
            object[] objArray3 = new object[] { "" };
            this.MaterialName.Items.AddRange(objArray3);
            this.MaterialName.Location = new Point(0x19, 0x22);
            this.MaterialName.MaxLength = 300;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Size = new Size(450, 0x18);
            this.MaterialName.TabIndex = 5;
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage7);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new Point(9, 0x14d);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x257, 0xb3);
            this.TabControl1.TabIndex = 7;
            this.TabPage6.Controls.Add(this.ButtonFX);
            this.TabPage6.Controls.Add(this.GroupBox3);
            this.TabPage6.Controls.Add(this.Label5);
            this.TabPage6.Controls.Add(this.MaterialIsStop);
            this.TabPage6.Controls.Add(this.MaterialPricSale);
            this.TabPage6.Controls.Add(this.MaterialPricCost);
            this.TabPage6.Controls.Add(this.Label6);
            this.TabPage6.Location = new Point(4, 0x19);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new Padding(3);
            this.TabPage6.Size = new Size(0x24f, 150);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "السعر";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.ButtonFX.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFX.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFX.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFX.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFX.FlatStyle = FlatStyle.Flat;
            this.ButtonFX.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFX.Image = A.F.ImCalculater;
            this.ButtonFX.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFX.Location = new Point(15, 0x1c);
            this.ButtonFX.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFX.Name = "ButtonFX";
            this.ButtonFX.Size = new Size(0x94, 0x39);
            this.ButtonFX.TabIndex = 0x1f;
            this.ButtonFX.Text = "حاسبة المعادلات";
            this.ButtonFX.UseVisualStyleBackColor = true;
            this.MaterialIsStop.AutoSize = true;
            this.MaterialIsStop.Location = new Point(340, 0x6b);
            this.MaterialIsStop.Name = "MaterialIsStop";
            this.MaterialIsStop.Size = new Size(0x83, 20);
            this.MaterialIsStop.TabIndex = 15;
            this.MaterialIsStop.Text = "وقف بيع هذه المادة";
            this.MaterialIsStop.UseVisualStyleBackColor = true;
            this.TabPage3.Controls.Add(this.Label16);
            this.TabPage3.Controls.Add(this.MaterialDarMiWi);
            this.TabPage3.Location = new Point(4, 0x19);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x24f, 150);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "الضريبة";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.Label16.AutoSize = true;
            this.Label16.Location = new Point(0x1b2, 0x2e);
            this.Label16.Name = "Label16";
            this.Label16.Size = new Size(0x69, 0x10);
            this.Label16.TabIndex = 0x12;
            this.Label16.Text = "نسبة الضريبة % :";
            this.MaterialDarMiWi.BackColor = SystemColors.Info;
            this.MaterialDarMiWi.Location = new Point(0x135, 0x2b);
            this.MaterialDarMiWi.MaxLength = 20;
            this.MaterialDarMiWi.Name = "MaterialDarMiWi";
            this.MaterialDarMiWi.RightToLeft = RightToLeft.No;
            this.MaterialDarMiWi.Size = new Size(0x77, 0x17);
            this.MaterialDarMiWi.TabIndex = 10;
            this.MaterialDarMiWi.TextAlign = HorizontalAlignment.Center;
            this.TabPage7.Controls.Add(this.GroupBox5);
            this.TabPage7.Controls.Add(this.GroupBox2);
            this.TabPage7.Controls.Add(this.Label15);
            this.TabPage7.Controls.Add(this.Label13);
            this.TabPage7.Controls.Add(this.MaterialQuantityOffer);
            this.TabPage7.Location = new Point(4, 0x19);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Size = new Size(0x24f, 150);
            this.TabPage7.TabIndex = 6;
            this.TabPage7.Text = "الخصم";
            this.TabPage7.UseVisualStyleBackColor = true;
            this.GroupBox5.Controls.Add(this.Label11);
            this.GroupBox5.Controls.Add(this.MaterialDisMiWi);
            this.GroupBox5.Controls.Add(this.DateTimePickerDis);
            this.GroupBox5.Controls.Add(this.Label18);
            this.GroupBox5.Controls.Add(this.DateTimePickerDisChe);
            this.GroupBox5.Location = new Point(0x107, 9);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x137, 0x54);
            this.GroupBox5.TabIndex = 0xcb1;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "الخصم نسبة %";
            this.Label11.AutoSize = true;
            this.Label11.Location = new Point(0xdf, 0x1b);
            this.Label11.Name = "Label11";
            this.Label11.Size = new Size(0x52, 0x10);
            this.Label11.TabIndex = 0xcb0;
            this.Label11.Text = "نسبة الخصم:";
            this.MaterialDisMiWi.BackColor = SystemColors.Info;
            this.MaterialDisMiWi.Location = new Point(70, 0x18);
            this.MaterialDisMiWi.MaxLength = 20;
            this.MaterialDisMiWi.Name = "MaterialDisMiWi";
            this.MaterialDisMiWi.RightToLeft = RightToLeft.No;
            this.MaterialDisMiWi.Size = new Size(0x93, 0x17);
            this.MaterialDisMiWi.TabIndex = 0x13;
            this.MaterialDisMiWi.TextAlign = HorizontalAlignment.Center;
            this.DateTimePickerDis.CustomFormat = "yyyy/MM/dd";
            this.DateTimePickerDis.Enabled = false;
            this.DateTimePickerDis.Format = DateTimePickerFormat.Custom;
            this.DateTimePickerDis.Location = new Point(70, 0x36);
            this.DateTimePickerDis.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePickerDis.Name = "DateTimePickerDis";
            this.DateTimePickerDis.RightToLeft = RightToLeft.No;
            this.DateTimePickerDis.Size = new Size(0x93, 0x17);
            this.DateTimePickerDis.TabIndex = 0xcad;
            this.Label18.AutoSize = true;
            this.Label18.Location = new Point(0xe0, 0x3b);
            this.Label18.Name = "Label18";
            this.Label18.Size = new Size(0x44, 0x10);
            this.Label18.TabIndex = 0xcae;
            this.Label18.Text = "لغاية تاريخ:";
            this.DateTimePickerDisChe.AutoSize = true;
            this.DateTimePickerDisChe.Location = new Point(6, 0x39);
            this.DateTimePickerDisChe.Name = "DateTimePickerDisChe";
            this.DateTimePickerDisChe.Size = new Size(0x3a, 20);
            this.DateTimePickerDisChe.TabIndex = 0xcaf;
            this.DateTimePickerDisChe.Text = "تفعيل";
            this.DateTimePickerDisChe.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.MaterialPricLess);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Location = new Point(15, 9);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xe2, 0x54);
            this.GroupBox2.TabIndex = 0xcb0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "سعر بيع مخفض/العرض/الخصم";
            this.TabPage2.Controls.Add(this.MaterialQuantityLess);
            this.TabPage2.Controls.Add(this.Label19);
            this.TabPage2.Controls.Add(this.Label1);
            this.TabPage2.Controls.Add(this.ChKActiveDate);
            this.TabPage2.Controls.Add(this.MaterialExpDate);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x24f, 150);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "التنبيه";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.MaterialQuantityLess.Location = new Point(310, 0x44);
            this.MaterialQuantityLess.MaxLength = 20;
            this.MaterialQuantityLess.Name = "MaterialQuantityLess";
            this.MaterialQuantityLess.RightToLeft = RightToLeft.No;
            this.MaterialQuantityLess.Size = new Size(0x7c, 0x17);
            this.MaterialQuantityLess.TabIndex = 0x51ec5;
            this.MaterialQuantityLess.TextAlign = HorizontalAlignment.Center;
            this.Label19.AutoSize = true;
            this.Label19.Location = new Point(440, 0x47);
            this.Label19.Name = "Label19";
            this.Label19.Size = new Size(0x6d, 0x10);
            this.Label19.TabIndex = 0x51ec4;
            this.Label19.Text = "الحد الأدنى للكمية";
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(0x1bb, 0x20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x4a, 0x10);
            this.Label1.TabIndex = 0x1d;
            this.Label1.Text = "تاريخ الانتهاء";
            this.ChKActiveDate.AutoSize = true;
            this.ChKActiveDate.Location = new Point(0x19, 0x1f);
            this.ChKActiveDate.Name = "ChKActiveDate";
            this.ChKActiveDate.Size = new Size(0x10f, 20);
            this.ChKActiveDate.TabIndex = 0x51ec3;
            this.ChKActiveDate.Text = "تفعيل التاريخ ومنع البيع في حال انتهاء التاريخ";
            this.ChKActiveDate.UseVisualStyleBackColor = true;
            this.MaterialExpDate.CustomFormat = "yyyy/MM/dd";
            this.MaterialExpDate.Enabled = false;
            this.MaterialExpDate.Format = DateTimePickerFormat.Custom;
            this.MaterialExpDate.Location = new Point(310, 0x1d);
            this.MaterialExpDate.Margin = new Padding(3, 4, 3, 4);
            this.MaterialExpDate.Name = "MaterialExpDate";
            this.MaterialExpDate.RightToLeft = RightToLeft.No;
            this.MaterialExpDate.Size = new Size(0x7c, 0x17);
            this.MaterialExpDate.TabIndex = 0xcac;
            this.TabPage1.Controls.Add(this.MaterialNotIsView);
            this.TabPage1.Controls.Add(this.MaterialNote);
            this.TabPage1.Controls.Add(this.Label8);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x24f, 150);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "ملاحظات";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.MaterialNotIsView.AutoSize = true;
            this.MaterialNotIsView.Location = new Point(0x72, 0x5e);
            this.MaterialNotIsView.Name = "MaterialNotIsView";
            this.MaterialNotIsView.Size = new Size(0x14c, 20);
            this.MaterialNotIsView.TabIndex = 0x888916;
            this.MaterialNotIsView.Text = "عرض ملاحظة هذه المادة بشكل تلقائي في شاشة البيع";
            this.MaterialNotIsView.UseVisualStyleBackColor = true;
            this.MaterialNote.Location = new Point(0x9e, 0x19);
            this.MaterialNote.MaxLength = 250;
            this.MaterialNote.Multiline = true;
            this.MaterialNote.Name = "MaterialNote";
            this.MaterialNote.RightToLeft = RightToLeft.No;
            this.MaterialNote.Size = new Size(0x120, 0x3f);
            this.MaterialNote.TabIndex = 0x888915;
            this.MaterialNote.TextAlign = HorizontalAlignment.Center;
            this.Label8.AutoSize = true;
            this.Label8.Location = new Point(0x1c4, 0x1c);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(0x57, 0x10);
            this.Label8.TabIndex = 0x19;
            this.Label8.Text = "ملاحظات عامة";
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = SystemColors.AppWorkspace;
            this.Label9.Location = new Point(0x55, 0x1c);
            this.Label9.Name = "Label9";
            this.Label9.Size = new Size(50, 0x10);
            this.Label9.TabIndex = 0x13a;
            this.Label9.Text = "اختياري";
            this.TabPage4.Controls.Add(this.Label14);
            this.TabPage4.Controls.Add(this.MaterialMultBarCode);
            this.TabPage4.Location = new Point(4, 0x19);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new Padding(3);
            this.TabPage4.Size = new Size(0x24f, 150);
            this.TabPage4.TabIndex = 7;
            this.TabPage4.Text = "باركود متعدد";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.Label14.Dock = DockStyle.Top;
            this.Label14.Location = new Point(3, 3);
            this.Label14.Name = "Label14";
            this.Label14.Size = new Size(0x249, 0x3e);
            this.Label14.TabIndex = 3;
            this.Label14.Text = "يمكنك ادخال اكثر من رقم باركود للمادة على ان يتم الفصل بين كل رقم بنجة وبدون اي مسافات مثلا\r\n*1111*2222*3333*4444*";
            this.Label14.TextAlign = ContentAlignment.MiddleCenter;
            this.MaterialMultBarCode.BackColor = SystemColors.Info;
            this.MaterialMultBarCode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.MaterialMultBarCode.Location = new Point(0x15, 0x44);
            this.MaterialMultBarCode.MaxLength = 250;
            this.MaterialMultBarCode.Multiline = true;
            this.MaterialMultBarCode.Name = "MaterialMultBarCode";
            this.MaterialMultBarCode.RightToLeft = RightToLeft.No;
            this.MaterialMultBarCode.Size = new Size(0x22c, 0x42);
            this.MaterialMultBarCode.TabIndex = 2;
            this.MaterialMultBarCode.TextAlign = HorizontalAlignment.Center;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(9, 0x207);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x138, 0x2c);
            this.ButtonOK.TabIndex = 10;
            this.ButtonOK.Text = "موافق";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = A.F.ImFinish;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(0x1c9, 0x207);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x94, 0x2c);
            this.ButtonFinish.TabIndex = 0x1b;
            this.ButtonFinish.Text = "انهاء";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.CheckBoxEmpty.AutoSize = true;
            this.CheckBoxEmpty.BackColor = Color.WhiteSmoke;
            this.CheckBoxEmpty.Checked = true;
            this.CheckBoxEmpty.CheckState = CheckState.Checked;
            this.CheckBoxEmpty.Dock = DockStyle.Bottom;
            this.CheckBoxEmpty.Location = new Point(0, 0x23f);
            this.CheckBoxEmpty.Name = "CheckBoxEmpty";
            this.CheckBoxEmpty.Size = new Size(0x266, 20);
            this.CheckBoxEmpty.TabIndex = 30;
            this.CheckBoxEmpty.Text = "تفريغ الحقول بعد الاضافة";
            this.CheckBoxEmpty.UseVisualStyleBackColor = false;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x266, 0x253);
            base.ControlBox = false;
            base.Controls.Add(this.CheckBoxEmpty);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.GroupBoxGr);
            base.Controls.Add(this.GroupBoxDt);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialAddEdit";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة /تعديل مادة";
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBoxGr.ResumeLayout(false);
            this.GroupBoxDt.ResumeLayout(false);
            this.GroupBoxDt.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void D()
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            if (JD.A > 0)
            {
                this.Q();
            }
            if (PR.V)
            {
                base.Dispose();
            }
            if (JD.A > 0)
            {
                this.MaterialName.Focus();
            }
            else
            {
                this.MaterialBarCode.Focus();
            }
        }

        private void D(object A, KeyPressEventArgs R)
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

        private void E(object A, EventArgs R)
        {
            this.MaterialExpDate.Enabled = this.ChKActiveDate.Checked;
        }

        private void F()
        {
            if ((A > 0) && this.A)
            {
                this.A = false;
                this.MaterialBarCode.BackColor = Color.DarkRed;
                this.MaterialBarCode.ForeColor = Color.Yellow;
                Interaction.MsgBox("تعديل الرقم/ الباركود قد يؤدي الى نتائج سلبية لهذه المادة خصوصاً ام كان لها سجلات مرتبطة كسجل المبيعات او المرتجع مبيعات او الترحيل او الاتلاف الخ، لأن عمليات الفرز تتم على اساس الباركود ", MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void F(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void F(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void G(object A, EventArgs R)
        {
        }

        private void H(object A, EventArgs R)
        {
            if (AR.LR && (Strings.Len(this.MaterialBarCode.Text) > 0x10))
            {
                this.MaterialBarCode.Text = Strings.Left(this.MaterialBarCode.Text, 15);
            }
            this.I();
        }

        private void H(object A, KeyPressEventArgs R)
        {
            if ((Strings.Asc(R.KeyChar) != 8) && !@"1234567890.-qwertyuiopasdfghjklzxcvbnm /*\!#$%^*(-)=+[{]};:'\.0><?".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox("رقم او كود المادة غير مدعوم يجب ان يتضمن ( حروف انجليزية، ارقام، رموز) فقط", MsgBoxStyle.ApplicationModal, null);
            }
        }

        public void I()
        {
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DataTable dataTable = new DataTable();
            string selectCommandText = (A <= 0) ? "SELECT TOP(1) [MaterialName] FROM TaNNMaterial WHERE ((CenterFrontID = @CenterFrontID) AND (MaterialBarCode = @MaterialBarCode))" : "SELECT TOP(1) [MaterialName] FROM TaNNMaterial WHERE ((MaterialID <> @MaterialID) AND (CenterFrontID = @CenterFrontID) AND (MaterialBarCode = @MaterialBarCode))";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("MaterialID", A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("MaterialBarCode", this.MaterialBarCode.Text);
            adapter.Fill(dataTable);
            this.A.Close();
            if (dataTable.Rows.Count <= 0)
            {
                this.ButtonOK.Enabled = true;
            }
            else
            {
                Interaction.MsgBox("رقم المادة مكرر مع مادة اخرى " + dataTable.Rows[0]["MaterialName"].ToString(), MsgBoxStyle.ApplicationModal, null);
                this.ButtonOK.Enabled = false;
            }
        }

        private void I(object A, EventArgs R)
        {
            if (this.MaterialName.Text != null)
            {
                if (!(((((this.MaterialBarCode.Text == null) | (this.MaterialName.Text == null)) | (this.MaterialPricSale.Text == null)) | (this.MaterialQuantity.Text == null)) | (this.MaterialPricCost.Text == null)))
                {
                    if (Conversion.Val(this.MaterialPricCost.Text.Replace(",", "")) > Conversion.Val(this.MaterialPricSale.Text.Replace(",", "")))
                    {
                        Interaction.MsgBox("خطأ، في احتساب الربح لأن سعر التكلفة اكبر من سعر ##البيع## وهذا يسبب خسارة", MsgBoxStyle.Exclamation, null);
                        if (Interaction.MsgBox("هل تريد الاستمرار على اي حال؟", MsgBoxStyle.OkCancel, "") == MsgBoxResult.Cancel)
                        {
                            return;
                        }
                    }
                    if (!(Conversion.Val(this.MaterialPricLess.Text.Replace(",", "")) == 0.0) && (Conversion.Val(this.MaterialPricCost.Text.Replace(",", "")) > Conversion.Val(this.MaterialPricLess.Text.Replace(",", ""))))
                    {
                        Interaction.MsgBox("خطأ، في احتساب الربح لأن سعر التكلفة اكبر من السعر ##المخفض## وهذا يسبب خسارة", MsgBoxStyle.Exclamation, null);
                        if (Interaction.MsgBox("هل تريد الاستمرار على اي حال؟", MsgBoxStyle.OkCancel, "") == MsgBoxResult.Cancel)
                        {
                            return;
                        }
                    }
                    if (Conversion.Val(this.MaterialDisMiWi.Text) > 0.0)
                    {
                        decimal num = new decimal(Conversion.Val(this.MaterialPricSale.Text.Replace(",", "")) * (Conversion.Val(this.MaterialDisMiWi.Text) / 100.0));
                        decimal num2 = new decimal(Conversion.Val(this.MaterialPricSale.Text.Replace(",", "")) - Convert.ToDouble(num));
                        if (Conversion.Val(this.MaterialPricCost.Text.Replace(",", "")) > Convert.ToDouble(num2))
                        {
                            Interaction.MsgBox("خطأ، في احتساب الربح لأن نسبة الخصم كبيرة وتسبب خسارة", MsgBoxStyle.Exclamation, null);
                            if (Interaction.MsgBox("هل تريد الاستمرار على اي حال؟", MsgBoxStyle.OkCancel, "") == MsgBoxResult.Cancel)
                            {
                                return;
                            }
                        }
                    }
                    if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(this.ComboBoxGroup.Text != null, Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.ComboBoxGroup.SelectedValue, null, false))))
                    {
                        Interaction.MsgBox("خطأ في تحديد المجموعة ", MsgBoxStyle.Exclamation, null);
                        this.ComboBoxGroup.Focus();
                    }
                    else
                    {
                        try
                        {
                            decimal num3 = new decimal(Conversion.Val(this.MaterialQuantity.Text.Replace(",", "")));
                            decimal num4 = new decimal(Conversion.Val(this.MaterialPricCost.Text.Replace(",", "")));
                            decimal num5 = new decimal(Conversion.Val(this.MaterialPricSale.Text.Replace(",", "")));
                            decimal num6 = new decimal(Conversion.Val(this.MaterialPricLess.Text.Replace(",", "")));
                            decimal num7 = new decimal(Conversion.Val(this.MaterialQuantityOffer.Text.Replace(",", "")));
                            decimal num8 = new decimal(Conversion.Val(this.MaterialQuantityLess.Text.Replace(",", "")));
                            decimal num9 = new decimal(Conversion.Val(this.MaterialQuantityPakeg.Text.Replace(",", "")));
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            string cmdText = "";
                            cmdText = (JD.A <= 0) ? "INSERT INTO TaNNMaterial(CenterFrontID, GroupIDFrontID, MaterialBarCode, MaterialName, MaterialQuantity, MaterialUnit, MaterialPricCost, MaterialPricLess, MaterialPricSale, MaterialIsStop, MaterialExpDate, MaterialNote, MaterialNotIsView, MaterialQuantityLess, MaterialQuantityPakeg, MaterialQuantityOffer, MaterialDisMiWi, MaterialDarMiWi, MaterialOtherBarCode, MaterialMultBarCode, MaterialBarcodeBlock, MaterialDisExpDat) VALUES (@CenterFrontID, @GroupIDFrontID, @MaterialBarCode, @MaterialName, @MaterialQuantity, @MaterialUnit, @MaterialPricCost, @MaterialPricLess, @MaterialPricSale, @MaterialIsStop, @MaterialExpDate, @MaterialNote, @MaterialNotIsView, @MaterialQuantityLess, @MaterialQuantityPakeg, @MaterialQuantityOffer, @MaterialDisMiWi, @MaterialDarMiWi, @MaterialOtherBarCode, @MaterialMultBarCode, @MaterialBarcodeBlock, @MaterialDisExpDat)" : "UPDATE [TaNNMaterial] SET [CenterFrontID] = @CenterFrontID, [GroupIDFrontID] = @GroupIDFrontID, [MaterialBarCode] = @MaterialBarCode, [MaterialName] = @MaterialName, [MaterialQuantity] = @MaterialQuantity, [MaterialUnit] = @MaterialUnit, [MaterialPricCost] = @MaterialPricCost, [MaterialPricLess] = @MaterialPricLess, [MaterialPricSale] = @MaterialPricSale, [MaterialIsStop] = @MaterialIsStop, [MaterialExpDate] = @MaterialExpDate, [MaterialNote] = @MaterialNote, [MaterialNotIsView] = @MaterialNotIsView, [MaterialQuantityLess] = @MaterialQuantityLess, [MaterialQuantityPakeg] = @MaterialQuantityPakeg, [MaterialQuantityOffer] = @MaterialQuantityOffer, [MaterialDisMiWi] = @MaterialDisMiWi, [MaterialDarMiWi] = @MaterialDarMiWi, [MaterialOtherBarCode] = @MaterialOtherBarCode, [MaterialMultBarCode] = @MaterialMultBarCode, [MaterialBarcodeBlock] = @MaterialBarcodeBlock, [MaterialDisExpDat] =@MaterialDisExpDat WHERE [MaterialID] = @MaterialID";
                            SqlCommand command = new SqlCommand(cmdText, this.A);
                            command.Parameters.AddWithValue("MaterialID", JD.A);
                            command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.ComboBoxGroup.SelectedValue, null, false))
                            {
                                command.Parameters.AddWithValue("GroupIDFrontID", "0");
                            }
                            else
                            {
                                command.Parameters.AddWithValue("GroupIDFrontID", this.ComboBoxGroup.SelectedValue);
                            }
                            command.Parameters.AddWithValue("MaterialBarCode", this.MaterialBarCode.Text.Trim());
                            command.Parameters.AddWithValue("MaterialName", this.MaterialName.Text.Trim());
                            command.Parameters.AddWithValue("MaterialQuantity", num3.ToString(PR.OR));
                            command.Parameters.AddWithValue("MaterialUnit", this.MaterialUnit.Text.Trim());
                            command.Parameters.AddWithValue("MaterialPricCost", num4.ToString(PR.VR));
                            command.Parameters.AddWithValue("MaterialPricSale", num5.ToString(PR.VR));
                            command.Parameters.AddWithValue("MaterialPricLess", num6.ToString(PR.VR));
                            command.Parameters.AddWithValue("MaterialIsStop", this.MaterialIsStop.Checked);
                            if (!this.ChKActiveDate.Checked)
                            {
                                command.Parameters.AddWithValue("MaterialExpDate", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("MaterialExpDate", this.MaterialExpDate.Value.ToString("yyyy/MM/dd"));
                            }
                            command.Parameters.AddWithValue("MaterialNote", this.MaterialNote.Text.Trim());
                            command.Parameters.AddWithValue("MaterialNotIsView", this.MaterialNotIsView.Checked);
                            command.Parameters.AddWithValue("MaterialQuantityLess", num8.ToString(PR.OR));
                            command.Parameters.AddWithValue("MaterialQuantityPakeg", num9.ToString(PR.OR));
                            command.Parameters.AddWithValue("MaterialQuantityOffer", num7.ToString(PR.OR));
                            command.Parameters.AddWithValue("MaterialDisMiWi", Conversion.Val(this.MaterialDisMiWi.Text));
                            command.Parameters.AddWithValue("MaterialDarMiWi", Conversion.Val(this.MaterialDarMiWi.Text));
                            command.Parameters.AddWithValue("MaterialOtherBarCode", this.MaterialOtherBarCode.Text.Trim());
                            command.Parameters.AddWithValue("MaterialMultBarCode", this.MaterialMultBarCode.Text.Trim());
                            command.Parameters.AddWithValue("MaterialBarcodeBlock", PR.GR.ToString() + this.MaterialBarCode.Text.Trim());
                            if (!this.DateTimePickerDisChe.Checked)
                            {
                                command.Parameters.AddWithValue("MaterialDisExpDat", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("MaterialDisExpDat", this.DateTimePickerDis.Value.ToString("yyyy/MM/dd"));
                            }
                            command.ExecuteNonQuery();
                            this.A.Close();
                            if (JD.A > 0)
                            {
                                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                                A.D.A.A.TimerLoadData.Enabled = true;
                                base.Dispose();
                            }
                            else
                            {
                                this.P();
                                if (this.CheckBoxEmpty.Checked)
                                {
                                    this.MaterialBarCode.Text = null;
                                    this.MaterialName.Text = null;
                                    this.MaterialPricCost.Text = null;
                                    this.MaterialPricSale.Text = null;
                                    this.MaterialQuantity.Text = null;
                                    this.MaterialQuantityLess.Text = null;
                                    this.MaterialQuantityPakeg.Text = null;
                                    this.MaterialQuantityOffer.Text = null;
                                    this.MaterialNote.Text = null;
                                    this.MaterialNotIsView.Checked = false;
                                    this.MaterialOtherBarCode.Text = null;
                                    this.MaterialIsStop.Checked = false;
                                    this.ChKActiveDate.Checked = false;
                                    this.MaterialOtherBarCode.Text = null;
                                    this.MaterialDarMiWi.Text = null;
                                    this.MaterialDisMiWi.Text = null;
                                    this.MaterialMultBarCode.Text = null;
                                }
                                this.MaterialBarCode.Text = null;
                                this.TxTTitle.Text = PR.P.ToString();
                                this.TxTTitle.ForeColor = Color.Blue;
                                this.TxTTitle.Font = new Font("Tahoma", 20f);
                                this.ButtonOK.Enabled = false;
                                this.TimerRestTitle.Enabled = true;
                            }
                        }
                        catch (Exception exception1)
                        {
                            Exception ex = exception1;
                            ProjectData.SetProjectError(ex);
                            Exception exception = ex;
                            Interaction.MsgBox("خطأ في عملية الحفظ، قد يكون السبب في تكرار رقم/باركود المادة مع مادة اخرى", MsgBoxStyle.ApplicationModal, null);
                            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                            ProjectData.ClearProjectError();
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.Exclamation, null);
                }
            }
            else
            {
                this.MaterialName.Focus();
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

        private void K(object A, EventArgs R)
        {
            base.AcceptButton = this.D;
        }

        private void L(object A, EventArgs R)
        {
            this.F();
        }

        private void N(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void O(object A, EventArgs R)
        {
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
                string selectCommandText = "SELECT MaterialID, MaterialName FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.MaterialName.ValueMember = "MaterialID";
                    this.MaterialName.DisplayMember = "MaterialName";
                    this.MaterialName.DataSource = dataTable;
                }
                this.MaterialName.SelectedIndex = -1;
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
            this.TimerRestTitle.Enabled = false;
            this.TxTTitle.Text = this.Text;
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Font = new Font("Tahoma", 12f);
            this.ButtonOK.Enabled = true;
            if (JD.A > 0)
            {
                this.MaterialName.Focus();
            }
            else
            {
                this.MaterialBarCode.Focus();
            }
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
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            A.D.A.A.TimerLoadData.Enabled = true;
            base.Dispose();
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
                string selectCommandText = "SELECT [GroupID], [GroupName] FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxGroup.ValueMember = "GroupID";
                    this.ComboBoxGroup.DisplayMember = "GroupName";
                    this.ComboBoxGroup.DataSource = dataTable;
                    this.ComboBoxGroup.SelectedIndex = -1;
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
            this.ComboBoxGroup.DataBindings.Clear();
            A.D.A.A.ShowDialog();
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

        private void T(object A, EventArgs R)
        {
            this.D();
        }

        private void U(object A, EventArgs R)
        {
        }

        private void V(object A, EventArgs R)
        {
            this.DateTimePickerDis.Enabled = this.DateTimePickerDisChe.Checked;
        }

        private void X(object A, EventArgs R)
        {
            this.D();
        }

        private void Y(object A, EventArgs R)
        {
        }

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label Label12
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox MaterialPricLess
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.D);
                TextBox a = this.A;
                if (a != null)
                {
                    a.KeyPress -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.KeyPress += handler;
                }
            }
        }

        internal virtual Label Label5
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox MaterialPricCost
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
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

        internal virtual Label Label6
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox MaterialPricSale
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label LabTot
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label Label10
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ComboBox MaterialUnit
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox MaterialQuantity
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.TextChanged -= handler;
                    q.KeyPress -= handler2;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.TextChanged += handler;
                    q.KeyPress += handler2;
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
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Timer TimerRestTitle
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonRandom
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox MaterialBarCode
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.H);
                EventHandler handler3 = new EventHandler(this.L);
                EventHandler handler4 = new EventHandler(this.O);
                TextBox i = this.I;
                if (i != null)
                {
                    i.Leave -= handler;
                    i.KeyPress -= handler2;
                    i.GotFocus -= handler3;
                    i.TextChanged -= handler4;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.Leave += handler;
                    i.KeyPress += handler2;
                    i.GotFocus += handler3;
                    i.TextChanged += handler4;
                }
            }
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

        internal virtual GroupBox GroupBoxGr
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonGroup
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual ComboBox ComboBoxGroup
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBoxDt
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox MaterialNote
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label Label8
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual Label Label9
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual CheckBox ChKActiveDate
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual DateTimePicker MaterialExpDate
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox MaterialQuantityLess
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label Label19
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual CheckBox MaterialIsStop
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual CheckBox MaterialNotIsView
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ComboBox MaterialName
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual CheckBox CheckBoxEmpty
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label Label13
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual TextBox MaterialQuantityOffer
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.F);
                TextBox h = this.H;
                if (h != null)
                {
                    h.KeyPress -= handler;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.KeyPress += handler;
                }
            }
        }

        internal virtual Label Label15
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual TabPage TabPage6
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label Label16
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual TextBox MaterialDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.Q);
                EventHandler handler2 = new EventHandler(this.Y);
                TextBox t = this.T;
                if (t != null)
                {
                    t.KeyPress -= handler;
                    t.TextChanged -= handler2;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.KeyPress += handler;
                    t.TextChanged += handler2;
                }
            }
        }

        internal virtual TabPage TabPage7
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox MaterialDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.I);
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

        internal virtual Label Label7
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual TextBox MaterialQuantityPakeg
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox MaterialOtherBarCode
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox MaterialMultBarCode
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                EventHandler handler2 = new EventHandler(this.U);
                TextBox k = this.K;
                if (k != null)
                {
                    k.GotFocus -= handler;
                    k.Leave -= handler2;
                }
                this.K = value;
                k = this.K;
                if (k != null)
                {
                    k.GotFocus += handler;
                    k.Leave += handler2;
                }
            }
        }

        internal virtual Label Label14
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual Button ButtonFX
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
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

        internal virtual DateTimePicker DateTimePickerDis
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label18
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual CheckBox DateTimePickerDisChe
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
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
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label Label11
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }
    }
}

