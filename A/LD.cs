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
    public class LD : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("GroupBoxFirst"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonSelect")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTBarCodeSelect")]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSearch"), CompilerGenerated]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonOK")]
        private Button P;
        [AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label17")]
        private Label R;
        [AccessedThroughProperty("PurchMaterialDisMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("PurchMaterialDarMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PurchMaterialPricCost"), CompilerGenerated]
        private TextBox Q;
        [AccessedThroughProperty("MaterialExpDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("PurchMaterialNote")]
        private TextBox I;
        [AccessedThroughProperty("GroupBoxBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [CompilerGenerated, AccessedThroughProperty("PurchMaterialBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxName"), CompilerGenerated]
        private GroupBox P;
        [CompilerGenerated, AccessedThroughProperty("PurchMaterialName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("PurchMaterialUnit")]
        private ComboBox R;
        [AccessedThroughProperty("GroupBoxSecound"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("GroupBoxUnit"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox5"), CompilerGenerated]
        private GroupBox D;
        [AccessedThroughProperty("PurchMaterialQuantity"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox F;
        [CompilerGenerated, AccessedThroughProperty("UserIsPurchApplStore"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxEmpty"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LabelState"), CompilerGenerated]
        private Label P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1")]
        private GroupBox F;
        [CompilerGenerated, AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox6")]
        private GroupBox T;
        [AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PurchMaterialDisVAL")]
        private TextBox H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox7")]
        private GroupBox X;
        [AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label4")]
        private Label D;
        [AccessedThroughProperty("PurchMaterialDarVAL"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox8")]
        private GroupBox G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PurchMaterialPricTotal")]
        private TextBox X;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox E;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ChKActiveDate")]
        private CheckBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox4"), CompilerGenerated]
        private GroupBox K;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PurchMaterialSalePrice")]
        private TextBox G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label F;
        [AccessedThroughProperty("CheckBoxDarWith"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox Q;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxAutoCount"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxGr")]
        private GroupBox U;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxGroup"), CompilerGenerated]
        private ComboBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonFX")]
        private Button I;
        [AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox L;
        [CompilerGenerated, AccessedThroughProperty("TaMaterialQuantity"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox E;
        private SqlConnection A;
        private string A;
        private TextBox K;
        private TextBox U;
        private TextBox L;

        public LD()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = "*";
            this.K = new TextBox();
            this.U = new TextBox();
            this.L = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.GroupBoxFirst = new GroupBox();
            this.ButtonSearch = new Button();
            this.ButtonSelect = new Button();
            this.TxTBarCodeSelect = new TextBox();
            this.ButtonOK = new Button();
            this.ButtonFinish = new Button();
            this.Label17 = new Label();
            this.PurchMaterialDisMiWi = new TextBox();
            this.PurchMaterialDarMiWi = new TextBox();
            this.PurchMaterialPricCost = new TextBox();
            this.PurchMaterialNote = new TextBox();
            this.MaterialExpDate = new DateTimePicker();
            this.GroupBoxBarCode = new GroupBox();
            this.PurchMaterialBarCode = new TextBox();
            this.GroupBoxName = new GroupBox();
            this.PurchMaterialName = new ComboBox();
            this.PurchMaterialUnit = new ComboBox();
            this.GroupBoxSecound = new GroupBox();
            this.GroupBox9 = new GroupBox();
            this.TaMaterialQuantity = new TextBox();
            this.GroupBoxGr = new GroupBox();
            this.ComboBoxGroup = new ComboBox();
            this.GroupBox4 = new GroupBox();
            this.Label1 = new Label();
            this.PurchMaterialSalePrice = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.GroupBoxUnit = new GroupBox();
            this.GroupBox8 = new GroupBox();
            this.PurchMaterialPricTotal = new TextBox();
            this.GroupBox5 = new GroupBox();
            this.PurchMaterialQuantity = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.ChKActiveDate = new CheckBox();
            this.GroupBox2 = new GroupBox();
            this.GroupBox7 = new GroupBox();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.PurchMaterialDarVAL = new TextBox();
            this.GroupBox6 = new GroupBox();
            this.Label2 = new Label();
            this.PurchMaterialDisVAL = new TextBox();
            this.UserIsPurchApplStore = new CheckBox();
            this.CheckBoxEmpty = new CheckBox();
            this.LabelState = new Label();
            this.CheckBoxDarWith = new CheckBox();
            this.CheckBoxAutoCount = new CheckBox();
            this.ButtonFX = new Button();
            this.GroupBoxFirst.SuspendLayout();
            this.GroupBoxBarCode.SuspendLayout();
            this.GroupBoxName.SuspendLayout();
            this.GroupBoxSecound.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBoxGr.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBoxUnit.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x2b3, 0x22);
            this.TxTTitle.TabIndex = 0x1d;
            this.TxTTitle.Text = "إدخال/ارجاع مواد المشتريات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxFirst.BackColor = Color.White;
            this.GroupBoxFirst.Controls.Add(this.ButtonSearch);
            this.GroupBoxFirst.Controls.Add(this.ButtonSelect);
            this.GroupBoxFirst.Controls.Add(this.TxTBarCodeSelect);
            this.GroupBoxFirst.Dock = DockStyle.Top;
            this.GroupBoxFirst.Location = new Point(0, 0x22);
            this.GroupBoxFirst.Name = "GroupBoxFirst";
            this.GroupBoxFirst.Size = new Size(0x2b3, 0x44);
            this.GroupBoxFirst.TabIndex = 0;
            this.GroupBoxFirst.TabStop = false;
            this.GroupBoxFirst.Text = "حدد المادة المطلوب ادخالها/ ارجاعها ";
            this.ButtonSearch.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSearch.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSearch.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSearch.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSearch.FlatStyle = FlatStyle.Flat;
            this.ButtonSearch.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSearch.Image = A.F.ImSearch;
            this.ButtonSearch.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSearch.Location = new Point(12, 0x13);
            this.ButtonSearch.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new Size(160, 0x2b);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "بحث متقدم";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSelect.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSelect.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSelect.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSelect.FlatStyle = FlatStyle.Flat;
            this.ButtonSelect.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSelect.Image = A.F.ImOK;
            this.ButtonSelect.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSelect.Location = new Point(0xb2, 0x13);
            this.ButtonSelect.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new Size(0x84, 0x2b);
            this.ButtonSelect.TabIndex = 1;
            this.ButtonSelect.Text = "موافق";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.TxTBarCodeSelect.BackColor = SystemColors.Info;
            this.TxTBarCodeSelect.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTBarCodeSelect.Location = new Point(0x149, 0x1d);
            this.TxTBarCodeSelect.MaxLength = 50;
            this.TxTBarCodeSelect.Name = "TxTBarCodeSelect";
            this.TxTBarCodeSelect.RightToLeft = RightToLeft.No;
            this.TxTBarCodeSelect.Size = new Size(0x152, 0x17);
            this.TxTBarCodeSelect.TabIndex = 0;
            this.TxTBarCodeSelect.TextAlign = HorizontalAlignment.Center;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(14, 0x234);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x15c, 0x2c);
            this.ButtonOK.TabIndex = 0x1f;
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
            this.ButtonFinish.Location = new Point(0x218, 0x232);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x94, 0x2c);
            this.ButtonFinish.TabIndex = 0x20;
            this.ButtonFinish.Text = "انهاء";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.Label17.AutoSize = true;
            this.Label17.Location = new Point(0x88, 0x21);
            this.Label17.Name = "Label17";
            this.Label17.Size = new Size(0x36, 0x10);
            this.Label17.TabIndex = 20;
            this.Label17.Text = "نسبة %";
            this.PurchMaterialDisMiWi.BackColor = Color.White;
            this.PurchMaterialDisMiWi.Location = new Point(6, 0x1b);
            this.PurchMaterialDisMiWi.MaxLength = 20;
            this.PurchMaterialDisMiWi.Name = "PurchMaterialDisMiWi";
            this.PurchMaterialDisMiWi.RightToLeft = RightToLeft.No;
            this.PurchMaterialDisMiWi.Size = new Size(0x7c, 0x17);
            this.PurchMaterialDisMiWi.TabIndex = 0x10;
            this.PurchMaterialDisMiWi.TextAlign = HorizontalAlignment.Center;
            this.PurchMaterialDarMiWi.BackColor = Color.White;
            this.PurchMaterialDarMiWi.Location = new Point(6, 0x1b);
            this.PurchMaterialDarMiWi.MaxLength = 20;
            this.PurchMaterialDarMiWi.Name = "PurchMaterialDarMiWi";
            this.PurchMaterialDarMiWi.RightToLeft = RightToLeft.No;
            this.PurchMaterialDarMiWi.Size = new Size(0x7c, 0x17);
            this.PurchMaterialDarMiWi.TabIndex = 15;
            this.PurchMaterialDarMiWi.TextAlign = HorizontalAlignment.Center;
            this.PurchMaterialPricCost.BackColor = Color.White;
            this.PurchMaterialPricCost.Dock = DockStyle.Fill;
            this.PurchMaterialPricCost.Location = new Point(3, 0x13);
            this.PurchMaterialPricCost.MaxLength = 20;
            this.PurchMaterialPricCost.Name = "PurchMaterialPricCost";
            this.PurchMaterialPricCost.RightToLeft = RightToLeft.No;
            this.PurchMaterialPricCost.Size = new Size(0xb0, 0x17);
            this.PurchMaterialPricCost.TabIndex = 13;
            this.PurchMaterialPricCost.TextAlign = HorizontalAlignment.Center;
            this.PurchMaterialNote.Dock = DockStyle.Fill;
            this.PurchMaterialNote.Location = new Point(3, 0x13);
            this.PurchMaterialNote.MaxLength = 0xbb8;
            this.PurchMaterialNote.Multiline = true;
            this.PurchMaterialNote.Name = "PurchMaterialNote";
            this.PurchMaterialNote.RightToLeft = RightToLeft.No;
            this.PurchMaterialNote.Size = new Size(0x109, 80);
            this.PurchMaterialNote.TabIndex = 0x888915;
            this.PurchMaterialNote.TextAlign = HorizontalAlignment.Center;
            this.MaterialExpDate.CustomFormat = "yyyy/MM/dd";
            this.MaterialExpDate.Dock = DockStyle.Top;
            this.MaterialExpDate.Enabled = false;
            this.MaterialExpDate.Format = DateTimePickerFormat.Custom;
            this.MaterialExpDate.Location = new Point(3, 0x13);
            this.MaterialExpDate.Margin = new Padding(3, 4, 3, 4);
            this.MaterialExpDate.Name = "MaterialExpDate";
            this.MaterialExpDate.RightToLeft = RightToLeft.No;
            this.MaterialExpDate.Size = new Size(0xb3, 0x17);
            this.MaterialExpDate.TabIndex = 0xcac;
            this.GroupBoxBarCode.Controls.Add(this.PurchMaterialBarCode);
            this.GroupBoxBarCode.Location = new Point(0x1ab, 0x13);
            this.GroupBoxBarCode.Name = "GroupBoxBarCode";
            this.GroupBoxBarCode.Size = new Size(0xfd, 0x38);
            this.GroupBoxBarCode.TabIndex = 6;
            this.GroupBoxBarCode.TabStop = false;
            this.GroupBoxBarCode.Text = "باركود رقم المادة";
            this.PurchMaterialBarCode.BackColor = SystemColors.Info;
            this.PurchMaterialBarCode.Dock = DockStyle.Fill;
            this.PurchMaterialBarCode.Enabled = false;
            this.PurchMaterialBarCode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.PurchMaterialBarCode.Location = new Point(3, 0x13);
            this.PurchMaterialBarCode.MaxLength = 250;
            this.PurchMaterialBarCode.Name = "PurchMaterialBarCode";
            this.PurchMaterialBarCode.RightToLeft = RightToLeft.No;
            this.PurchMaterialBarCode.Size = new Size(0xf7, 0x17);
            this.PurchMaterialBarCode.TabIndex = 1;
            this.PurchMaterialBarCode.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxName.Controls.Add(this.PurchMaterialName);
            this.GroupBoxName.Location = new Point(0x9e, 0x13);
            this.GroupBoxName.Name = "GroupBoxName";
            this.GroupBoxName.Size = new Size(0x10a, 0x38);
            this.GroupBoxName.TabIndex = 8;
            this.GroupBoxName.TabStop = false;
            this.GroupBoxName.Text = "اسم المادة";
            this.PurchMaterialName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.PurchMaterialName.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.PurchMaterialName.BackColor = SystemColors.Info;
            this.PurchMaterialName.Dock = DockStyle.Fill;
            this.PurchMaterialName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.PurchMaterialName.FormattingEnabled = true;
            object[] items = new object[] { "" };
            this.PurchMaterialName.Items.AddRange(items);
            this.PurchMaterialName.Location = new Point(3, 0x13);
            this.PurchMaterialName.MaxLength = 300;
            this.PurchMaterialName.Name = "PurchMaterialName";
            this.PurchMaterialName.Size = new Size(260, 0x18);
            this.PurchMaterialName.TabIndex = 5;
            this.PurchMaterialUnit.Dock = DockStyle.Fill;
            this.PurchMaterialUnit.FormattingEnabled = true;
            object[] objArray2 = new object[0x19];
            objArray2[0] = "";
            objArray2[1] = "خدمة";
            objArray2[2] = "مساعده";
            objArray2[3] = "وجبة";
            objArray2[4] = "بطاقات";
            objArray2[5] = "شحن";
            objArray2[6] = "صيانة";
            objArray2[7] = "جهاز";
            objArray2[8] = "غرام";
            objArray2[9] = "كيلو";
            objArray2[10] = "رطل";
            objArray2[11] = "طن";
            objArray2[12] = "كرتونة";
            objArray2[13] = "كيس";
            objArray2[14] = "طبق";
            objArray2[15] = "علبة";
            objArray2[0x10] = "صندوق";
            objArray2[0x11] = "باكيت";
            objArray2[0x12] = "قطعة";
            objArray2[0x13] = "درزن";
            objArray2[20] = "متر";
            objArray2[0x15] = "سم";
            objArray2[0x16] = "حبة";
            objArray2[0x17] = "صندوق";
            objArray2[0x18] = "اكتب اي شي اخر";
            this.PurchMaterialUnit.Items.AddRange(objArray2);
            this.PurchMaterialUnit.Location = new Point(3, 0x13);
            this.PurchMaterialUnit.MaxLength = 20;
            this.PurchMaterialUnit.Name = "PurchMaterialUnit";
            this.PurchMaterialUnit.Size = new Size(140, 0x18);
            this.PurchMaterialUnit.TabIndex = 7;
            this.GroupBoxSecound.Controls.Add(this.GroupBox9);
            this.GroupBoxSecound.Controls.Add(this.GroupBoxGr);
            this.GroupBoxSecound.Controls.Add(this.GroupBox4);
            this.GroupBoxSecound.Controls.Add(this.GroupBox3);
            this.GroupBoxSecound.Controls.Add(this.GroupBoxUnit);
            this.GroupBoxSecound.Controls.Add(this.GroupBox8);
            this.GroupBoxSecound.Controls.Add(this.GroupBoxBarCode);
            this.GroupBoxSecound.Controls.Add(this.GroupBoxName);
            this.GroupBoxSecound.Controls.Add(this.GroupBox5);
            this.GroupBoxSecound.Controls.Add(this.GroupBox1);
            this.GroupBoxSecound.Controls.Add(this.GroupBox2);
            this.GroupBoxSecound.Controls.Add(this.GroupBox7);
            this.GroupBoxSecound.Controls.Add(this.GroupBox6);
            this.GroupBoxSecound.Dock = DockStyle.Top;
            this.GroupBoxSecound.Enabled = false;
            this.GroupBoxSecound.Location = new Point(0, 0x83);
            this.GroupBoxSecound.Name = "GroupBoxSecound";
            this.GroupBoxSecound.Size = new Size(0x2b3, 0x160);
            this.GroupBoxSecound.TabIndex = 4;
            this.GroupBoxSecound.TabStop = false;
            this.GroupBox9.Controls.Add(this.TaMaterialQuantity);
            this.GroupBox9.Location = new Point(9, 0x86);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x100, 0x34);
            this.GroupBox9.TabIndex = 11;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "الكمية السابقة";
            this.TaMaterialQuantity.BackColor = SystemColors.Info;
            this.TaMaterialQuantity.Dock = DockStyle.Fill;
            this.TaMaterialQuantity.Enabled = false;
            this.TaMaterialQuantity.Location = new Point(3, 0x13);
            this.TaMaterialQuantity.MaxLength = 20;
            this.TaMaterialQuantity.Name = "TaMaterialQuantity";
            this.TaMaterialQuantity.RightToLeft = RightToLeft.No;
            this.TaMaterialQuantity.Size = new Size(250, 0x17);
            this.TaMaterialQuantity.TabIndex = 6;
            this.TaMaterialQuantity.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxGr.Controls.Add(this.ComboBoxGroup);
            this.GroupBoxGr.Location = new Point(0x163, 0x51);
            this.GroupBoxGr.Name = "GroupBoxGr";
            this.GroupBoxGr.Size = new Size(0x145, 0x34);
            this.GroupBoxGr.TabIndex = 0x2e;
            this.GroupBoxGr.TabStop = false;
            this.GroupBoxGr.Text = "حدد المجموعة";
            this.ComboBoxGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxGroup.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxGroup.Dock = DockStyle.Fill;
            this.ComboBoxGroup.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxGroup.FormattingEnabled = true;
            this.ComboBoxGroup.IntegralHeight = false;
            object[] objArray3 = new object[] { "" };
            this.ComboBoxGroup.Items.AddRange(objArray3);
            this.ComboBoxGroup.Location = new Point(3, 0x13);
            this.ComboBoxGroup.Name = "ComboBoxGroup";
            this.ComboBoxGroup.Size = new Size(0x13f, 0x18);
            this.ComboBoxGroup.TabIndex = 3;
            this.GroupBox4.Controls.Add(this.Label1);
            this.GroupBox4.Controls.Add(this.PurchMaterialSalePrice);
            this.GroupBox4.Location = new Point(480, 0xf1);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(200, 0x69);
            this.GroupBox4.TabIndex = 0x2d;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "السعر الافرادي/ سعر البيع";
            this.Label1.Dock = DockStyle.Bottom;
            this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(3, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0xc2, 0x34);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "سعر البيع اختياري، حيث يمكنك ادخال سعر البيع ليتم تطبيق السعر في المستودع او حفظه في كرت المادة لتطبيقه لاحقاً";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.PurchMaterialSalePrice.BackColor = Color.White;
            this.PurchMaterialSalePrice.Dock = DockStyle.Fill;
            this.PurchMaterialSalePrice.Location = new Point(3, 0x13);
            this.PurchMaterialSalePrice.MaxLength = 20;
            this.PurchMaterialSalePrice.Name = "PurchMaterialSalePrice";
            this.PurchMaterialSalePrice.RightToLeft = RightToLeft.No;
            this.PurchMaterialSalePrice.Size = new Size(0xc2, 0x17);
            this.PurchMaterialSalePrice.TabIndex = 13;
            this.PurchMaterialSalePrice.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.PurchMaterialNote);
            this.GroupBox3.Location = new Point(12, 0xf1);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x10f, 0x66);
            this.GroupBox3.TabIndex = 0x29;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "ملاحظات عامة";
            this.GroupBoxUnit.Controls.Add(this.PurchMaterialUnit);
            this.GroupBoxUnit.Location = new Point(6, 0x13);
            this.GroupBoxUnit.Name = "GroupBoxUnit";
            this.GroupBoxUnit.Size = new Size(0x92, 0x38);
            this.GroupBoxUnit.TabIndex = 11;
            this.GroupBoxUnit.TabStop = false;
            this.GroupBoxUnit.Text = "الوحدة";
            this.GroupBox8.Controls.Add(this.PurchMaterialPricTotal);
            this.GroupBox8.Location = new Point(6, 0x52);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x9b, 50);
            this.GroupBox8.TabIndex = 0x2d;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "مجموع سعر الشراء";
            this.PurchMaterialPricTotal.BackColor = Color.White;
            this.PurchMaterialPricTotal.Dock = DockStyle.Fill;
            this.PurchMaterialPricTotal.Location = new Point(3, 0x13);
            this.PurchMaterialPricTotal.MaxLength = 20;
            this.PurchMaterialPricTotal.Name = "PurchMaterialPricTotal";
            this.PurchMaterialPricTotal.RightToLeft = RightToLeft.No;
            this.PurchMaterialPricTotal.Size = new Size(0x95, 0x17);
            this.PurchMaterialPricTotal.TabIndex = 13;
            this.PurchMaterialPricTotal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox5.Controls.Add(this.PurchMaterialQuantity);
            this.GroupBox5.Location = new Point(9, 0xbd);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x100, 0x34);
            this.GroupBox5.TabIndex = 10;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "الكمية الجديدة";
            this.PurchMaterialQuantity.BackColor = SystemColors.Info;
            this.PurchMaterialQuantity.Dock = DockStyle.Fill;
            this.PurchMaterialQuantity.Location = new Point(3, 0x13);
            this.PurchMaterialQuantity.MaxLength = 20;
            this.PurchMaterialQuantity.Name = "PurchMaterialQuantity";
            this.PurchMaterialQuantity.RightToLeft = RightToLeft.No;
            this.PurchMaterialQuantity.Size = new Size(250, 0x17);
            this.PurchMaterialQuantity.TabIndex = 6;
            this.PurchMaterialQuantity.TextAlign = HorizontalAlignment.Center;
            this.GroupBox1.Controls.Add(this.ChKActiveDate);
            this.GroupBox1.Controls.Add(this.MaterialExpDate);
            this.GroupBox1.Location = new Point(0x121, 0xf1);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb9, 0x66);
            this.GroupBox1.TabIndex = 40;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "تاريخ الانتهاء";
            this.ChKActiveDate.Dock = DockStyle.Top;
            this.ChKActiveDate.Location = new Point(3, 0x2a);
            this.ChKActiveDate.Name = "ChKActiveDate";
            this.ChKActiveDate.Size = new Size(0xb3, 0x1d);
            this.ChKActiveDate.TabIndex = 0x51ec4;
            this.ChKActiveDate.Text = "تفعيل تاريخ الانتهاء";
            this.ChKActiveDate.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.PurchMaterialPricCost);
            this.GroupBox2.Location = new Point(0xa7, 0x52);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xb6, 50);
            this.GroupBox2.TabIndex = 0x2c;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "السعر الافرادي/ سعر الشراء";
            this.GroupBox7.Controls.Add(this.Label3);
            this.GroupBox7.Controls.Add(this.Label4);
            this.GroupBox7.Controls.Add(this.PurchMaterialDarVAL);
            this.GroupBox7.Controls.Add(this.PurchMaterialDarMiWi);
            this.GroupBox7.Location = new Point(0x10f, 0x86);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(200, 0x65);
            this.GroupBox7.TabIndex = 0x2b;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "ضريبة الشراء";
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(0x88, 0x3b);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x21, 0x10);
            this.Label3.TabIndex = 0x18;
            this.Label3.Text = "مبلغ";
            this.Label4.AutoSize = true;
            this.Label4.Location = new Point(0x88, 30);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x36, 0x10);
            this.Label4.TabIndex = 0x17;
            this.Label4.Text = "نسبة %";
            this.PurchMaterialDarVAL.BackColor = Color.White;
            this.PurchMaterialDarVAL.Location = new Point(6, 0x38);
            this.PurchMaterialDarVAL.MaxLength = 20;
            this.PurchMaterialDarVAL.Name = "PurchMaterialDarVAL";
            this.PurchMaterialDarVAL.RightToLeft = RightToLeft.No;
            this.PurchMaterialDarVAL.Size = new Size(0x7c, 0x17);
            this.PurchMaterialDarVAL.TabIndex = 0x10;
            this.PurchMaterialDarVAL.TextAlign = HorizontalAlignment.Center;
            this.GroupBox6.Controls.Add(this.Label2);
            this.GroupBox6.Controls.Add(this.PurchMaterialDisVAL);
            this.GroupBox6.Controls.Add(this.Label17);
            this.GroupBox6.Controls.Add(this.PurchMaterialDisMiWi);
            this.GroupBox6.Location = new Point(480, 0x86);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(200, 0x65);
            this.GroupBox6.TabIndex = 0x2a;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "خصم الشراء";
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0x88, 0x3b);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x21, 0x10);
            this.Label2.TabIndex = 0x16;
            this.Label2.Text = "مبلغ";
            this.PurchMaterialDisVAL.BackColor = Color.White;
            this.PurchMaterialDisVAL.Location = new Point(6, 0x38);
            this.PurchMaterialDisVAL.MaxLength = 20;
            this.PurchMaterialDisVAL.Name = "PurchMaterialDisVAL";
            this.PurchMaterialDisVAL.RightToLeft = RightToLeft.No;
            this.PurchMaterialDisVAL.Size = new Size(0x7c, 0x17);
            this.PurchMaterialDisVAL.TabIndex = 0x15;
            this.PurchMaterialDisVAL.TextAlign = HorizontalAlignment.Center;
            this.UserIsPurchApplStore.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.UserIsPurchApplStore.Dock = DockStyle.Top;
            this.UserIsPurchApplStore.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.UserIsPurchApplStore.Location = new Point(0, 0x1e3);
            this.UserIsPurchApplStore.Name = "UserIsPurchApplStore";
            this.UserIsPurchApplStore.Padding = new Padding(5);
            this.UserIsPurchApplStore.Size = new Size(0x2b3, 0x3b);
            this.UserIsPurchApplStore.TabIndex = 3;
            this.UserIsPurchApplStore.Text = "تطبيق الاجراء على المستودع، في حال كانت المادة غير موجودة ادخلها، وفي حال كانت موجودة مسبقاً قم بتحديث البيانات الجديدة.";
            this.UserIsPurchApplStore.UseVisualStyleBackColor = false;
            this.CheckBoxEmpty.AutoSize = true;
            this.CheckBoxEmpty.BackColor = Color.WhiteSmoke;
            this.CheckBoxEmpty.Checked = true;
            this.CheckBoxEmpty.CheckState = CheckState.Checked;
            this.CheckBoxEmpty.Dock = DockStyle.Bottom;
            this.CheckBoxEmpty.Location = new Point(0, 0x29d);
            this.CheckBoxEmpty.Name = "CheckBoxEmpty";
            this.CheckBoxEmpty.Padding = new Padding(2);
            this.CheckBoxEmpty.Size = new Size(0x2b3, 0x18);
            this.CheckBoxEmpty.TabIndex = 0x26;
            this.CheckBoxEmpty.Text = "تفريغ الحقول بعد الاضافة";
            this.CheckBoxEmpty.UseVisualStyleBackColor = false;
            this.LabelState.Dock = DockStyle.Top;
            this.LabelState.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelState.ForeColor = Color.Red;
            this.LabelState.Location = new Point(0, 0x66);
            this.LabelState.Name = "LabelState";
            this.LabelState.Size = new Size(0x2b3, 0x1d);
            this.LabelState.TabIndex = 0x27;
            this.LabelState.Text = "-";
            this.LabelState.TextAlign = ContentAlignment.MiddleCenter;
            this.CheckBoxDarWith.AutoSize = true;
            this.CheckBoxDarWith.BackColor = Color.WhiteSmoke;
            this.CheckBoxDarWith.Dock = DockStyle.Bottom;
            this.CheckBoxDarWith.Location = new Point(0, 0x285);
            this.CheckBoxDarWith.Name = "CheckBoxDarWith";
            this.CheckBoxDarWith.Padding = new Padding(2);
            this.CheckBoxDarWith.Size = new Size(0x2b3, 0x18);
            this.CheckBoxDarWith.TabIndex = 0x29;
            this.CheckBoxDarWith.Text = "احسب الضريبة على اساس ان سعر الشراء شامل الضريبة";
            this.CheckBoxDarWith.UseVisualStyleBackColor = false;
            this.CheckBoxAutoCount.AutoSize = true;
            this.CheckBoxAutoCount.BackColor = Color.WhiteSmoke;
            this.CheckBoxAutoCount.Dock = DockStyle.Bottom;
            this.CheckBoxAutoCount.Location = new Point(0, 0x26d);
            this.CheckBoxAutoCount.Name = "CheckBoxAutoCount";
            this.CheckBoxAutoCount.Padding = new Padding(2);
            this.CheckBoxAutoCount.Size = new Size(0x2b3, 0x18);
            this.CheckBoxAutoCount.TabIndex = 0x2a;
            this.CheckBoxAutoCount.Text = "احسب المجاميع تلقائي";
            this.CheckBoxAutoCount.UseVisualStyleBackColor = false;
            this.ButtonFX.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFX.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFX.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFX.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFX.FlatStyle = FlatStyle.Flat;
            this.ButtonFX.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFX.Image = A.F.ImCalculater;
            this.ButtonFX.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFX.Location = new Point(0x170, 0x232);
            this.ButtonFX.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFX.Name = "ButtonFX";
            this.ButtonFX.Size = new Size(0x9c, 0x2e);
            this.ButtonFX.TabIndex = 0x2b;
            this.ButtonFX.Text = "حاسبة المعادلات";
            this.ButtonFX.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2b3, 0x2b5);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonFX);
            base.Controls.Add(this.CheckBoxAutoCount);
            base.Controls.Add(this.CheckBoxDarWith);
            base.Controls.Add(this.UserIsPurchApplStore);
            base.Controls.Add(this.CheckBoxEmpty);
            base.Controls.Add(this.GroupBoxSecound);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.LabelState);
            base.Controls.Add(this.GroupBoxFirst);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "InvoicePurchMaterialAdd";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "إدخال/ارجاع مواد المشتريات";
            this.GroupBoxFirst.ResumeLayout(false);
            this.GroupBoxFirst.PerformLayout();
            this.GroupBoxBarCode.ResumeLayout(false);
            this.GroupBoxBarCode.PerformLayout();
            this.GroupBoxName.ResumeLayout(false);
            this.GroupBoxSecound.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.GroupBoxGr.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBoxUnit.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonSelect.PerformClick();
            }
            else if ((Strings.Asc(R.KeyChar) != 8) && !@"1234567890.-qwertyuiopasdfghjklzxcvbnm /*\!#$%^*(-)=+[{]};:'\.0><?".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox("رقم او كود المادة غير مدعوم يجب ان يتضمن ( حروف انجليزية، ارقام، رموز) فقط", MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void B(object A, EventArgs R)
        {
            this.F();
        }

        private void C(object A, EventArgs R)
        {
            this.F();
        }

        public void D()
        {
            try
            {
                decimal num6 = new decimal(Conversion.Val(this.PurchMaterialSalePrice.Text.Replace(",", "")));
                decimal num = decimal.Multiply(new decimal(Conversion.Val(this.PurchMaterialQuantity.Text.Replace(",", ""))), decimal.One);
                decimal num2 = decimal.Multiply(new decimal(Conversion.Val(this.PurchMaterialPricCost.Text.Replace(",", ""))), decimal.One);
                decimal num3 = decimal.Multiply(new decimal(Conversion.Val(this.PurchMaterialDisVAL.Text.Replace(",", ""))), decimal.One);
                decimal num4 = decimal.Multiply(new decimal(Conversion.Val(this.PurchMaterialDarVAL.Text.Replace(",", ""))), decimal.One);
                decimal num5 = decimal.Multiply(new decimal(Conversion.Val(this.PurchMaterialPricTotal.Text.Replace(",", ""))), decimal.One);
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("INSERT INTO [TaNNInvPurchItems] ([CenterFrontID], [InvPurchIDFrontID], [InvPurchType], [SuplierFrontID], [InvPurchPurchDate], [PurchMaterialBarCode], [PurchMaterialName], [PurchMaterialQuantity], [PurchMaterialUnit], [PurchMaterialPricCost], [PurchMaterialDisMiWi], [PurchMaterialDisVAL], [PurchMaterialDarMiWi], [PurchMaterialDarVAL], [PurchMaterialPricTotal], [PurchMaterialSalePrice], [PurchMaterialExpDate], [PurchMaterialNote], [PurchIsApplyStor], [PurchUserAddBy]) VALUES (@CenterFrontID, @InvPurchIDFrontID, @InvPurchType, @SuplierFrontID, @InvPurchPurchDate, @PurchMaterialBarCode, @PurchMaterialName, @PurchMaterialQuantity, @PurchMaterialUnit, @PurchMaterialPricCost, @PurchMaterialDisMiWi, @PurchMaterialDisVAL, @PurchMaterialDarMiWi, @PurchMaterialDarVAL, @PurchMaterialPricTotal, @PurchMaterialSalePrice, @PurchMaterialExpDate, @PurchMaterialNote, @PurchIsApplyStor, @PurchUserAddBy)", this.A);
                command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                command.Parameters.AddWithValue("InvPurchIDFrontID", A.D.A.A.InvPurchID.Text.Trim());
                command.Parameters.AddWithValue("InvPurchType", A.D.A.A.InvPurchType.SelectedIndex);
                command.Parameters.AddWithValue("SuplierFrontID", A.D.A.A.ComboBoxSuplier.SelectedValue);
                command.Parameters.AddWithValue("InvPurchPurchDate", A.D.A.A.InvPurchDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                command.Parameters.AddWithValue("PurchMaterialBarCode", this.PurchMaterialBarCode.Text.Trim());
                command.Parameters.AddWithValue("PurchMaterialName", this.PurchMaterialName.Text.Trim());
                command.Parameters.AddWithValue("PurchMaterialQuantity", num.ToString(PR.OR));
                command.Parameters.AddWithValue("PurchMaterialUnit", this.PurchMaterialUnit.Text.Trim());
                command.Parameters.AddWithValue("PurchMaterialPricCost", num2.ToString(PR.VR));
                if (!this.ChKActiveDate.Checked)
                {
                    command.Parameters.AddWithValue("PurchMaterialExpDate", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("PurchMaterialExpDate", this.MaterialExpDate.Value.ToString("yyyy/MM/dd"));
                }
                command.Parameters.AddWithValue("PurchMaterialDisMiWi", Conversion.Val(this.PurchMaterialDisMiWi.Text));
                command.Parameters.AddWithValue("PurchMaterialDisVAL", num3.ToString(PR.VR));
                command.Parameters.AddWithValue("PurchMaterialDarMiWi", Conversion.Val(this.PurchMaterialDarMiWi.Text));
                command.Parameters.AddWithValue("PurchMaterialDarVAL", num4.ToString(PR.VR));
                command.Parameters.AddWithValue("PurchMaterialPricTotal", num5.ToString(PR.VR));
                command.Parameters.AddWithValue("PurchMaterialSalePrice", num6.ToString(PR.VR));
                command.Parameters.AddWithValue("PurchMaterialNote", this.PurchMaterialNote.Text);
                command.Parameters.AddWithValue("PurchIsApplyStor", this.UserIsPurchApplStore.Checked);
                command.Parameters.AddWithValue("PurchUserAddBy", A.D.A.A.TxTUserName.Text);
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.CheckBoxEmpty.Checked)
                {
                    this.PurchMaterialBarCode.Text = null;
                    this.PurchMaterialName.Text = null;
                    this.PurchMaterialPricCost.Text = null;
                    this.PurchMaterialUnit.Text = null;
                    this.PurchMaterialQuantity.Text = null;
                    this.ChKActiveDate.Checked = false;
                    this.PurchMaterialDarMiWi.Text = null;
                    this.PurchMaterialDisMiWi.Text = null;
                    this.PurchMaterialDarVAL.Text = null;
                    this.PurchMaterialDisVAL.Text = null;
                    this.PurchMaterialNote.Text = null;
                    this.PurchMaterialSalePrice.Text = null;
                }
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TxTBarCodeSelect.Text = null;
                this.TxTBarCodeSelect.Focus();
                this.GroupBoxFirst.Enabled = true;
                this.GroupBoxSecound.Enabled = false;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
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
            this.F();
        }

        public void F()
        {
            // Invalid method body.
        }

        private void F(object A, EventArgs R)
        {
            this.GroupBoxSecound.Enabled = false;
        }

        private void G(object A, EventArgs R)
        {
        }

        private void H(object A, EventArgs R)
        {
            this.MaterialExpDate.Enabled = this.ChKActiveDate.Checked;
        }

        public void I()
        {
            try
            {
                decimal num = new decimal(Conversion.Val(this.PurchMaterialQuantity.Text.Replace(",", "")));
                decimal num2 = new decimal(Conversion.Val(this.TaMaterialQuantity.Text.Replace(",", "")));
                decimal num3 = 0M;
                decimal num4 = 0M;
                decimal num5 = 0M;
                if (A.D.A.A.InvPurchType.SelectedIndex == 0)
                {
                    num3 = decimal.Add(num2, num);
                    num4 = new decimal(Conversion.Val(this.PurchMaterialPricCost.Text.Replace(",", "")));
                    num5 = new decimal(Conversion.Val(this.PurchMaterialSalePrice.Text.Replace(",", "")));
                }
                else if (A.D.A.A.InvPurchType.SelectedIndex == 1)
                {
                    num3 = decimal.Subtract(num2, num);
                    num4 = new decimal(Conversion.Val(this.PurchMaterialPricCost.Text.Replace(",", "")));
                    num5 = new decimal(Conversion.Val(this.PurchMaterialSalePrice.Text.Replace(",", "")));
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string cmdText = "";
                if (this.A == "Update")
                {
                    cmdText = "UPDATE [TaNNMaterial] SET [CenterFrontID] = @CenterFrontID, [MaterialBarCode] = @MaterialBarCode, [MaterialName] = @MaterialName, [MaterialQuantity] = @MaterialQuantity, [MaterialUnit] = @MaterialUnit, [MaterialPricCost] = @MaterialPricCost, [MaterialPricSale] = @MaterialPricSale, [MaterialExpDate] = @MaterialExpDate, [MaterialNote] = @MaterialNote, [MaterialNotIsView] = @MaterialNotIsView, [MaterialBarcodeBlock] = @MaterialBarcodeBlock WHERE [MaterialID] = @MaterialID";
                }
                else if (this.A == "Insert")
                {
                    cmdText = "INSERT INTO TaNNMaterial(CenterFrontID, GroupIDFrontID, MaterialBarCode, MaterialName, MaterialQuantity, MaterialUnit, MaterialPricCost, MaterialPricLess, MaterialPricSale, MaterialIsStop, MaterialExpDate, MaterialNote, MaterialNotIsView, MaterialQuantityLess, MaterialQuantityPakeg, MaterialQuantityOffer, MaterialDisMiWi, MaterialDarMiWi, MaterialOtherBarCode, MaterialMultBarCode, MaterialBarcodeBlock) VALUES (@CenterFrontID, @GroupIDFrontID, @MaterialBarCode, @MaterialName, @MaterialQuantity, @MaterialUnit, @MaterialPricCost, @MaterialPricLess, @MaterialPricSale, @MaterialIsStop, @MaterialExpDate, @MaterialNote, @MaterialNotIsView, @MaterialQuantityLess, @MaterialQuantityPakeg, @MaterialQuantityOffer, @MaterialDisMiWi, @MaterialDarMiWi, @MaterialOtherBarCode, @MaterialMultBarCode, @MaterialBarcodeBlock)";
                }
                SqlCommand command = new SqlCommand(cmdText, this.A);
                command.Parameters.AddWithValue("MaterialID", this.K.Text);
                command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.ComboBoxGroup.SelectedValue, null, false))
                {
                    command.Parameters.AddWithValue("GroupIDFrontID", "0");
                }
                else
                {
                    command.Parameters.AddWithValue("GroupIDFrontID", this.ComboBoxGroup.SelectedValue);
                }
                command.Parameters.AddWithValue("MaterialBarCode", this.PurchMaterialBarCode.Text.Trim());
                command.Parameters.AddWithValue("MaterialName", this.PurchMaterialName.Text.Trim());
                command.Parameters.AddWithValue("MaterialQuantity", num3.ToString(PR.OR));
                command.Parameters.AddWithValue("MaterialUnit", this.PurchMaterialUnit.Text.Trim());
                command.Parameters.AddWithValue("MaterialPricCost", num4.ToString(PR.VR));
                command.Parameters.AddWithValue("MaterialPricSale", num5.ToString(PR.VR));
                command.Parameters.AddWithValue("MaterialPricLess", 0.ToString(PR.VR));
                command.Parameters.AddWithValue("MaterialIsStop", false);
                if (!this.ChKActiveDate.Checked)
                {
                    command.Parameters.AddWithValue("MaterialExpDate", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("MaterialExpDate", this.MaterialExpDate.Value.ToString("yyyy/MM/dd"));
                }
                command.Parameters.AddWithValue("MaterialNote", this.PurchMaterialNote.Text.Trim());
                command.Parameters.AddWithValue("MaterialNotIsView", false);
                command.Parameters.AddWithValue("MaterialQuantityLess", 0.ToString(PR.OR));
                command.Parameters.AddWithValue("MaterialQuantityPakeg", 0.ToString(PR.OR));
                command.Parameters.AddWithValue("MaterialQuantityOffer", 0.ToString(PR.OR));
                command.Parameters.AddWithValue("MaterialDisMiWi", 0.ToString(PR.VR));
                command.Parameters.AddWithValue("MaterialDarMiWi", 0.ToString(PR.VR));
                command.Parameters.AddWithValue("MaterialOtherBarCode", "");
                command.Parameters.AddWithValue("MaterialMultBarCode", "");
                command.Parameters.AddWithValue("MaterialBarcodeBlock", PR.GR.ToString() + this.PurchMaterialBarCode.Text.Trim());
                command.ExecuteNonQuery();
                this.A.Close();
                this.D();
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

        private void I(object A, EventArgs R)
        {
            if ((this.PurchMaterialBarCode.Text == null) | (this.PurchMaterialName.Text == null))
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else if (this.UserIsPurchApplStore.Checked)
            {
                this.I();
            }
            else
            {
                if (this.A == "Insert")
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO TaNNMaterial(CenterFrontID, GroupIDFrontID, MaterialBarCode, MaterialName, MaterialQuantity, MaterialUnit, MaterialPricCost, MaterialPricLess, MaterialPricSale, MaterialIsStop, MaterialExpDate, MaterialNote, MaterialNotIsView, MaterialQuantityLess, MaterialQuantityPakeg, MaterialQuantityOffer, MaterialDisMiWi, MaterialDarMiWi, MaterialOtherBarCode, MaterialMultBarCode, MaterialBarcodeBlock, MaterialDisExpDat) VALUES (@CenterFrontID, @GroupIDFrontID, @MaterialBarCode, @MaterialName, @MaterialQuantity, @MaterialUnit, @MaterialPricCost, @MaterialPricLess, @MaterialPricSale, @MaterialIsStop, @MaterialExpDate, @MaterialNote, @MaterialNotIsView, @MaterialQuantityLess, @MaterialQuantityPakeg, @MaterialQuantityOffer, @MaterialDisMiWi, @MaterialDarMiWi, @MaterialOtherBarCode, @MaterialMultBarCode, @MaterialBarcodeBlock, @MaterialDisExpDat)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.ComboBoxGroup.SelectedValue, null, false))
                    {
                        command.Parameters.AddWithValue("GroupIDFrontID", "0");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("GroupIDFrontID", this.ComboBoxGroup.SelectedValue);
                    }
                    command.Parameters.AddWithValue("MaterialBarCode", this.PurchMaterialBarCode.Text.Trim());
                    command.Parameters.AddWithValue("MaterialName", this.PurchMaterialName.Text.Trim());
                    command.Parameters.AddWithValue("MaterialQuantity", 0.ToString(PR.OR));
                    command.Parameters.AddWithValue("MaterialUnit", this.PurchMaterialUnit.Text.Trim());
                    command.Parameters.AddWithValue("MaterialPricCost", 0.ToString(PR.VR));
                    command.Parameters.AddWithValue("MaterialPricLess", 0.ToString(PR.VR));
                    command.Parameters.AddWithValue("MaterialPricSale", 0.ToString(PR.VR));
                    command.Parameters.AddWithValue("MaterialIsStop", false);
                    command.Parameters.AddWithValue("MaterialExpDate", DBNull.Value);
                    command.Parameters.AddWithValue("MaterialNote", "");
                    command.Parameters.AddWithValue("MaterialNotIsView", false);
                    command.Parameters.AddWithValue("MaterialQuantityLess", 0.ToString(PR.OR));
                    command.Parameters.AddWithValue("MaterialQuantityPakeg", 0.ToString(PR.OR));
                    command.Parameters.AddWithValue("MaterialQuantityOffer", 0.ToString(PR.OR));
                    command.Parameters.AddWithValue("MaterialDisMiWi", 0.ToString(PR.VR));
                    command.Parameters.AddWithValue("MaterialDarMiWi", 0.ToString(PR.VR));
                    command.Parameters.AddWithValue("MaterialOtherBarCode", "");
                    command.Parameters.AddWithValue("MaterialMultBarCode", "");
                    command.Parameters.AddWithValue("MaterialBarcodeBlock", PR.GR.ToString() + this.PurchMaterialBarCode.Text.Trim());
                    command.Parameters.AddWithValue("MaterialDisExpDat", DBNull.Value);
                    command.ExecuteNonQuery();
                    this.A.Close();
                }
                this.D();
            }
        }

        private void J(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void K(object A, EventArgs R)
        {
        }

        private void L(object A, EventArgs R)
        {
        }

        private void M(object A, EventArgs R)
        {
            this.F();
        }

        private void N(object A, EventArgs R)
        {
            this.F();
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

        private void P(object A, EventArgs R)
        {
            if (AR.LR && (Strings.Len(this.TxTBarCodeSelect.Text) > 0x10))
            {
                this.TxTBarCodeSelect.Text = Strings.Left(this.TxTBarCodeSelect.Text, 15);
            }
            this.Q();
        }

        public void Q()
        {
            // Invalid method body.
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
                string selectCommandText = "SELECT MaterialID, MaterialName FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.PurchMaterialName.ValueMember = "MaterialID";
                    this.PurchMaterialName.DisplayMember = "MaterialName";
                    this.PurchMaterialName.DataSource = dataTable;
                }
                this.PurchMaterialName.SelectedIndex = -1;
                this.PurchMaterialBarCode.Focus();
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
            A.D.A.A.P();
            base.Dispose();
        }

        private void S(object A, EventArgs R)
        {
        }

        private void T(object A, EventArgs R)
        {
        }

        private void U(object A, EventArgs R)
        {
            this.F();
        }

        private void V(object A, EventArgs R)
        {
        }

        private void X(object A, EventArgs R)
        {
        }

        private void Y(object A, EventArgs R)
        {
            this.F();
        }

        private void Z(object A, EventArgs R)
        {
            this.F();
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

        internal virtual GroupBox GroupBoxFirst
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                GroupBox a = this.A;
                if (a != null)
                {
                    a.Enter -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Enter += handler;
                }
            }
        }

        internal virtual Button ButtonSelect
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

        internal virtual TextBox TxTBarCodeSelect
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                EventHandler handler2 = new EventHandler(this.F);
                EventHandler handler3 = new EventHandler(this.X);
                TextBox a = this.A;
                if (a != null)
                {
                    a.KeyPress -= handler;
                    a.GotFocus -= handler2;
                    a.TextChanged -= handler3;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.KeyPress += handler;
                    a.GotFocus += handler2;
                    a.TextChanged += handler3;
                }
            }
        }

        internal virtual Button ButtonSearch
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual Button ButtonOK
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Button ButtonFinish
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

        internal virtual Label Label17
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox PurchMaterialDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                EventHandler handler2 = new EventHandler(this.U);
                TextBox r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                    r.Leave -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
                    r.Leave += handler2;
                }
            }
        }

        internal virtual TextBox PurchMaterialDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
                EventHandler handler2 = new EventHandler(this.Y);
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

        internal virtual TextBox PurchMaterialPricCost
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
                EventHandler handler2 = new EventHandler(this.Z);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.TextChanged -= handler;
                    q.Leave -= handler2;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.TextChanged += handler;
                    q.Leave += handler2;
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

        internal virtual TextBox PurchMaterialNote
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBoxBarCode
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox PurchMaterialBarCode
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBoxName
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ComboBox PurchMaterialName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox PurchMaterialUnit
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBoxSecound
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBoxUnit
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual TextBox PurchMaterialQuantity
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                EventHandler handler2 = new EventHandler(this.E);
                TextBox f = this.F;
                if (f != null)
                {
                    f.TextChanged -= handler;
                    f.Leave -= handler2;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.TextChanged += handler;
                    f.Leave += handler2;
                }
            }
        }

        internal virtual CheckBox UserIsPurchApplStore
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxEmpty
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label LabelState
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox PurchMaterialDisVAL
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
                EventHandler handler2 = new EventHandler(this.N);
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

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox PurchMaterialDarVAL
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
                EventHandler handler2 = new EventHandler(this.B);
                TextBox t = this.T;
                if (t != null)
                {
                    t.TextChanged -= handler;
                    t.Leave -= handler2;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.TextChanged += handler;
                    t.Leave += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TextBox PurchMaterialPricTotal
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual GroupBox GroupBox2
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual TextBox PurchMaterialSalePrice
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
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

        internal virtual CheckBox CheckBoxDarWith
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.C);
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

        internal virtual CheckBox CheckBoxAutoCount
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.M);
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

        internal virtual GroupBox GroupBoxGr
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual ComboBox ComboBoxGroup
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonFX
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.J);
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

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual TextBox TaMaterialQuantity
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }
    }
}

