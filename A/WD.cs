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
    public class WD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("LabelFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("ComboBoxCenterTo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [AccessedThroughProperty("ButtonOk"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("GroupBox4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("GvM"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [AccessedThroughProperty("GVG"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView R;
        [AccessedThroughProperty("TimerG"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("TxTGropName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("TxTGroupID"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("GroupBox6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("GroupBox7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("MaterialName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [AccessedThroughProperty("MaterialBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [AccessedThroughProperty("GroupBox8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [AccessedThroughProperty("MaterialQuantity"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [AccessedThroughProperty("GroupBox9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [AccessedThroughProperty("MaterialUnit"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox D;
        [AccessedThroughProperty("GroupBox10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [AccessedThroughProperty("MaterialPricCost"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox F;
        [AccessedThroughProperty("GroupBox11"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox X;
        [AccessedThroughProperty("MaterialPricLess"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox H;
        [AccessedThroughProperty("GroupBox12"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox G;
        [AccessedThroughProperty("MaterialPricSale"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox T;
        [AccessedThroughProperty("GroupBox13"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox E;
        [AccessedThroughProperty("GroupBox14"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [AccessedThroughProperty("MaterialExpDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox X;
        [AccessedThroughProperty("GroupBox15"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox U;
        [AccessedThroughProperty("MaterialNote"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox G;
        [AccessedThroughProperty("GroupBox16"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox L;
        [AccessedThroughProperty("MaterialQuantityLess"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox E;
        [AccessedThroughProperty("GroupBox17"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox N;
        [AccessedThroughProperty("MaterialQuantityPakeg"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox K;
        [AccessedThroughProperty("MaterialIsStop"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("TimerM"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [AccessedThroughProperty("TimerStart"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [AccessedThroughProperty("ButtonAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("AutoStop"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox R;
        [AccessedThroughProperty("StatusStrip1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StatusStrip A;
        [AccessedThroughProperty("ToolStripStatusLabel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripStatusLabel A;
        [AccessedThroughProperty("LBRR"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripStatusLabel R;
        [AccessedThroughProperty("ProssBar"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("MaterialNotIsView"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox P;
        [AccessedThroughProperty("MaterialQuantityOffer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox U;
        [AccessedThroughProperty("MaterialDisMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox L;
        [AccessedThroughProperty("MaterialDarMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox N;
        [AccessedThroughProperty("MaterialOtherBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox V;
        [AccessedThroughProperty("MaterialMultBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Y;
        [AccessedThroughProperty("MaterialDisExpDat"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox O;
        private int A;
        private int R;
        private bool A;
        private DataSet A;
        private string A;
        private SqlConnection A;

        public WD()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.R);
            base.Closed += new EventHandler(this.X);
            this.A = new DataSet();
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.GroupBox1 = new GroupBox();
            this.LabelFrom = new Label();
            this.GroupBox2 = new GroupBox();
            this.ComboBoxCenterTo = new ComboBox();
            this.Label2 = new Label();
            this.GroupBox6 = new GroupBox();
            this.MaterialBarCode = new TextBox();
            this.GroupBox7 = new GroupBox();
            this.MaterialName = new TextBox();
            this.GroupBox8 = new GroupBox();
            this.MaterialQuantity = new TextBox();
            this.ButtonAdd = new Button();
            this.GroupBox10 = new GroupBox();
            this.MaterialPricCost = new TextBox();
            this.GroupBox11 = new GroupBox();
            this.MaterialPricLess = new TextBox();
            this.GroupBox12 = new GroupBox();
            this.MaterialPricSale = new TextBox();
            this.GroupBox5 = new GroupBox();
            this.GvM = new DataGridView();
            this.GroupBox4 = new GroupBox();
            this.GVG = new DataGridView();
            this.TxTGropName = new TextBox();
            this.TimerG = new Timer(this.A);
            this.TxTGroupID = new TextBox();
            this.GroupBox9 = new GroupBox();
            this.MaterialUnit = new TextBox();
            this.GroupBox13 = new GroupBox();
            this.MaterialIsStop = new CheckBox();
            this.GroupBox14 = new GroupBox();
            this.MaterialExpDate = new TextBox();
            this.GroupBox15 = new GroupBox();
            this.MaterialNote = new TextBox();
            this.GroupBox16 = new GroupBox();
            this.MaterialQuantityLess = new TextBox();
            this.GroupBox17 = new GroupBox();
            this.MaterialQuantityPakeg = new TextBox();
            this.TimerM = new Timer(this.A);
            this.TimerStart = new Timer(this.A);
            this.AutoStop = new CheckBox();
            this.StatusStrip1 = new StatusStrip();
            this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
            this.LBRR = new ToolStripStatusLabel();
            this.ProssBar = new ToolStripProgressBar();
            this.ButtonOk = new Button();
            this.MaterialNotIsView = new CheckBox();
            this.MaterialQuantityOffer = new TextBox();
            this.MaterialDisMiWi = new TextBox();
            this.MaterialDarMiWi = new TextBox();
            this.MaterialOtherBarCode = new TextBox();
            this.MaterialMultBarCode = new TextBox();
            this.MaterialDisExpDat = new TextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            ((ISupportInitialize) this.GvM).BeginInit();
            this.GroupBox4.SuspendLayout();
            ((ISupportInitialize) this.GVG).BeginInit();
            this.GroupBox9.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            base.SuspendLayout();
            this.GroupBox1.Controls.Add(this.LabelFrom);
            this.GroupBox1.Location = new Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x132, 50);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "نسخ بيانات المستودع من الفرع/المستودع:";
            this.LabelFrom.Dock = DockStyle.Fill;
            this.LabelFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.LabelFrom.ForeColor = Color.Green;
            this.LabelFrom.Location = new Point(3, 0x13);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new Size(300, 0x1c);
            this.LabelFrom.TabIndex = 0;
            this.LabelFrom.Text = "LabelFrom";
            this.LabelFrom.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox2.Controls.Add(this.ComboBoxCenterTo);
            this.GroupBox2.Location = new Point(0x17a, 13);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x11d, 50);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "إلى الفرع/المستودع:";
            this.ComboBoxCenterTo.Dock = DockStyle.Fill;
            this.ComboBoxCenterTo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxCenterTo.FormattingEnabled = true;
            this.ComboBoxCenterTo.Location = new Point(3, 0x13);
            this.ComboBoxCenterTo.Name = "ComboBoxCenterTo";
            this.ComboBoxCenterTo.Size = new Size(0x117, 0x18);
            this.ComboBoxCenterTo.TabIndex = 2;
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Tahoma", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0x144, 0x20);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = RightToLeft.No;
            this.Label2.Size = new Size(40, 0x18);
            this.Label2.TabIndex = 0x47;
            this.Label2.Text = "<<";
            this.GroupBox6.Controls.Add(this.MaterialBarCode);
            this.GroupBox6.Location = new Point(0x232, 0x133);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(200, 0x31);
            this.GroupBox6.TabIndex = 2;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "رقم/ كود المادة";
            this.MaterialBarCode.Dock = DockStyle.Fill;
            this.MaterialBarCode.Enabled = false;
            this.MaterialBarCode.Location = new Point(3, 0x13);
            this.MaterialBarCode.Name = "MaterialBarCode";
            this.MaterialBarCode.RightToLeft = RightToLeft.No;
            this.MaterialBarCode.Size = new Size(0xc2, 0x17);
            this.MaterialBarCode.TabIndex = 0;
            this.MaterialBarCode.TextAlign = HorizontalAlignment.Center;
            this.GroupBox7.Controls.Add(this.MaterialName);
            this.GroupBox7.Location = new Point(0x164, 0x133);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(200, 0x31);
            this.GroupBox7.TabIndex = 3;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "اسم المادة";
            this.MaterialName.Dock = DockStyle.Fill;
            this.MaterialName.Enabled = false;
            this.MaterialName.Location = new Point(3, 0x13);
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Size = new Size(0xc2, 0x17);
            this.MaterialName.TabIndex = 0;
            this.MaterialName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox8.Controls.Add(this.MaterialQuantity);
            this.GroupBox8.Location = new Point(150, 0x133);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(200, 0x31);
            this.GroupBox8.TabIndex = 4;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "الكمية";
            this.MaterialQuantity.Dock = DockStyle.Fill;
            this.MaterialQuantity.Location = new Point(3, 0x13);
            this.MaterialQuantity.Name = "MaterialQuantity";
            this.MaterialQuantity.RightToLeft = RightToLeft.No;
            this.MaterialQuantity.Size = new Size(0xc2, 0x17);
            this.MaterialQuantity.TabIndex = 0;
            this.MaterialQuantity.TextAlign = HorizontalAlignment.Center;
            this.ButtonAdd.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Popup;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(0x11c, 0x1b7);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0x7a, 0x2d);
            this.ButtonAdd.TabIndex = 0x54;
            this.ButtonAdd.Text = "استمرار";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.GroupBox10.Controls.Add(this.MaterialPricCost);
            this.GroupBox10.Location = new Point(0x232, 0x16a);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(200, 0x31);
            this.GroupBox10.TabIndex = 0x4c;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "سعر التكلفة";
            this.MaterialPricCost.Dock = DockStyle.Fill;
            this.MaterialPricCost.Location = new Point(3, 0x13);
            this.MaterialPricCost.Name = "MaterialPricCost";
            this.MaterialPricCost.RightToLeft = RightToLeft.No;
            this.MaterialPricCost.Size = new Size(0xc2, 0x17);
            this.MaterialPricCost.TabIndex = 0;
            this.MaterialPricCost.TextAlign = HorizontalAlignment.Center;
            this.GroupBox11.Controls.Add(this.MaterialPricLess);
            this.GroupBox11.Location = new Point(0x164, 0x16a);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(200, 0x31);
            this.GroupBox11.TabIndex = 0x4d;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "سعر البيع المخفض";
            this.MaterialPricLess.Dock = DockStyle.Fill;
            this.MaterialPricLess.Location = new Point(3, 0x13);
            this.MaterialPricLess.Name = "MaterialPricLess";
            this.MaterialPricLess.RightToLeft = RightToLeft.No;
            this.MaterialPricLess.Size = new Size(0xc2, 0x17);
            this.MaterialPricLess.TabIndex = 0;
            this.MaterialPricLess.TextAlign = HorizontalAlignment.Center;
            this.GroupBox12.Controls.Add(this.MaterialPricSale);
            this.GroupBox12.Location = new Point(0x99, 0x16a);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(200, 0x31);
            this.GroupBox12.TabIndex = 0x4e;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "سعر البيع";
            this.MaterialPricSale.Dock = DockStyle.Fill;
            this.MaterialPricSale.Location = new Point(3, 0x13);
            this.MaterialPricSale.Name = "MaterialPricSale";
            this.MaterialPricSale.RightToLeft = RightToLeft.No;
            this.MaterialPricSale.Size = new Size(0xc2, 0x17);
            this.MaterialPricSale.TabIndex = 0;
            this.MaterialPricSale.TextAlign = HorizontalAlignment.Center;
            this.GroupBox5.Controls.Add(this.GvM);
            this.GroupBox5.Enabled = false;
            this.GroupBox5.Location = new Point(0x21d, 0x1b2);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(130, 0x35);
            this.GroupBox5.TabIndex = 1;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "المواد";
            this.GvM.AllowUserToAddRows = false;
            this.GvM.AllowUserToDeleteRows = false;
            this.GvM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GvM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvM.Dock = DockStyle.Fill;
            this.GvM.Location = new Point(3, 0x13);
            this.GvM.MultiSelect = false;
            this.GvM.Name = "GvM";
            this.GvM.ReadOnly = true;
            this.GvM.RowHeadersVisible = false;
            this.GvM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GvM.Size = new Size(0x7c, 0x1f);
            this.GvM.TabIndex = 0x45;
            this.GroupBox4.Controls.Add(this.GVG);
            this.GroupBox4.Enabled = false;
            this.GroupBox4.Location = new Point(0x62, 0x19b);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x76, 0x4c);
            this.GroupBox4.TabIndex = 0;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "المجموعات";
            this.GVG.AllowUserToAddRows = false;
            this.GVG.AllowUserToDeleteRows = false;
            this.GVG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVG.Dock = DockStyle.Fill;
            this.GVG.Location = new Point(3, 0x13);
            this.GVG.MultiSelect = false;
            this.GVG.Name = "GVG";
            this.GVG.ReadOnly = true;
            this.GVG.RowHeadersVisible = false;
            this.GVG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVG.Size = new Size(0x70, 0x36);
            this.GVG.TabIndex = 0x44;
            this.TxTGropName.Location = new Point(0x2c, 0x233);
            this.TxTGropName.Name = "TxTGropName";
            this.TxTGropName.Size = new Size(0x12d, 0x17);
            this.TxTGropName.TabIndex = 2;
            this.TimerG.Interval = 500;
            this.TxTGroupID.BackColor = SystemColors.Info;
            this.TxTGroupID.Location = new Point(0x2c, 0x216);
            this.TxTGroupID.Name = "TxTGroupID";
            this.TxTGroupID.Size = new Size(0x12d, 0x17);
            this.TxTGroupID.TabIndex = 3;
            this.GroupBox9.Controls.Add(this.MaterialUnit);
            this.GroupBox9.Location = new Point(0x25e, 0x250);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(200, 0x31);
            this.GroupBox9.TabIndex = 0x4b;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "الوحدة";
            this.MaterialUnit.Dock = DockStyle.Fill;
            this.MaterialUnit.Location = new Point(3, 0x13);
            this.MaterialUnit.Name = "MaterialUnit";
            this.MaterialUnit.Size = new Size(0xc2, 0x17);
            this.MaterialUnit.TabIndex = 0;
            this.GroupBox13.Controls.Add(this.MaterialIsStop);
            this.GroupBox13.Location = new Point(0xa4, 0x250);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x59, 0x31);
            this.GroupBox13.TabIndex = 0x4f;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "اعفاء ضريبي";
            this.MaterialIsStop.Dock = DockStyle.Fill;
            this.MaterialIsStop.Location = new Point(3, 0x13);
            this.MaterialIsStop.Name = "MaterialIsStop";
            this.MaterialIsStop.Size = new Size(0x53, 0x1b);
            this.MaterialIsStop.TabIndex = 0;
            this.MaterialIsStop.Text = "نعم معفاه من الضريبة";
            this.MaterialIsStop.UseVisualStyleBackColor = true;
            this.GroupBox14.Controls.Add(this.MaterialExpDate);
            this.GroupBox14.Location = new Point(0x195, 0x1fc);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0x97, 0x31);
            this.GroupBox14.TabIndex = 80;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "تاريخ الانتهاء";
            this.MaterialExpDate.Dock = DockStyle.Fill;
            this.MaterialExpDate.Location = new Point(3, 0x13);
            this.MaterialExpDate.Name = "MaterialExpDate";
            this.MaterialExpDate.Size = new Size(0x91, 0x17);
            this.MaterialExpDate.TabIndex = 0;
            this.GroupBox15.Controls.Add(this.MaterialNote);
            this.GroupBox15.Location = new Point(0x1ec, 0x249);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x59, 0x31);
            this.GroupBox15.TabIndex = 0x51;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "ملاحظات";
            this.MaterialNote.Dock = DockStyle.Fill;
            this.MaterialNote.Location = new Point(3, 0x13);
            this.MaterialNote.Name = "MaterialNote";
            this.MaterialNote.Size = new Size(0x53, 0x17);
            this.MaterialNote.TabIndex = 0;
            this.GroupBox16.Controls.Add(this.MaterialQuantityLess);
            this.GroupBox16.Location = new Point(0x11c, 0x263);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(0x8a, 0x31);
            this.GroupBox16.TabIndex = 0x52;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "الحد الأدنى للكمية";
            this.MaterialQuantityLess.Dock = DockStyle.Fill;
            this.MaterialQuantityLess.Location = new Point(3, 0x13);
            this.MaterialQuantityLess.Name = "MaterialQuantityLess";
            this.MaterialQuantityLess.Size = new Size(0x84, 0x17);
            this.MaterialQuantityLess.TabIndex = 0;
            this.GroupBox17.Controls.Add(this.MaterialQuantityPakeg);
            this.GroupBox17.Location = new Point(0x25e, 0x1fc);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(0x93, 0x31);
            this.GroupBox17.TabIndex = 0x53;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "الكمية في الكرتونة، الرزمة، الحزمة: ، باكيت ";
            this.MaterialQuantityPakeg.Dock = DockStyle.Fill;
            this.MaterialQuantityPakeg.Location = new Point(3, 0x13);
            this.MaterialQuantityPakeg.Name = "MaterialQuantityPakeg";
            this.MaterialQuantityPakeg.Size = new Size(0x8d, 0x17);
            this.MaterialQuantityPakeg.TabIndex = 0;
            this.TimerM.Interval = 500;
            this.TimerStart.Interval = 500;
            this.AutoStop.BackColor = Color.Gainsboro;
            this.AutoStop.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.AutoStop.Location = new Point(4, 0x127);
            this.AutoStop.Margin = new Padding(8);
            this.AutoStop.Name = "AutoStop";
            this.AutoStop.Padding = new Padding(10);
            this.AutoStop.Size = new Size(0x344, 30);
            this.AutoStop.TabIndex = 0x55;
            this.AutoStop.Text = "توقف عند كل مادة واترك لي حرية التعديل";
            this.AutoStop.UseVisualStyleBackColor = false;
            this.StatusStrip1.BackColor = Color.WhiteSmoke;
            this.StatusStrip1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripStatusLabel1, this.LBRR, this.ProssBar };
            this.StatusStrip1.Items.AddRange(toolStripItems);
            this.StatusStrip1.Location = new Point(0, 0x88);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new Size(0x2ab, 0x18);
            this.StatusStrip1.TabIndex = 0x56;
            this.StatusStrip1.Text = "StatusStrip1";
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new Size(0x52, 0x13);
            this.ToolStripStatusLabel1.Text = "عدد المواد:";
            this.LBRR.ForeColor = Color.Green;
            this.LBRR.Name = "LBRR";
            this.LBRR.Size = new Size(0x12, 0x13);
            this.LBRR.Text = "0";
            this.ProssBar.Name = "ProssBar";
            this.ProssBar.Size = new Size(100, 0x12);
            this.ProssBar.Visible = false;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(12, 80);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x28b, 0x29);
            this.ButtonOk.TabIndex = 70;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.MaterialNotIsView.Location = new Point(0x9c, 0x287);
            this.MaterialNotIsView.Name = "MaterialNotIsView";
            this.MaterialNotIsView.Size = new Size(0x53, 0x1b);
            this.MaterialNotIsView.TabIndex = 0x57;
            this.MaterialNotIsView.Text = "MaterialNotIsView";
            this.MaterialNotIsView.UseVisualStyleBackColor = true;
            this.MaterialQuantityOffer.Location = new Point(730, 0x295);
            this.MaterialQuantityOffer.Name = "MaterialQuantityOffer";
            this.MaterialQuantityOffer.Size = new Size(100, 0x17);
            this.MaterialQuantityOffer.TabIndex = 0x58;
            this.MaterialDisMiWi.Location = new Point(0x220, 0x295);
            this.MaterialDisMiWi.Name = "MaterialDisMiWi";
            this.MaterialDisMiWi.Size = new Size(100, 0x17);
            this.MaterialDisMiWi.TabIndex = 0;
            this.MaterialDarMiWi.Location = new Point(0x1aa, 670);
            this.MaterialDarMiWi.Name = "MaterialDarMiWi";
            this.MaterialDarMiWi.Size = new Size(100, 0x17);
            this.MaterialDarMiWi.TabIndex = 0x59;
            this.MaterialOtherBarCode.Location = new Point(0x13f, 670);
            this.MaterialOtherBarCode.Name = "MaterialOtherBarCode";
            this.MaterialOtherBarCode.Size = new Size(100, 0x17);
            this.MaterialOtherBarCode.TabIndex = 90;
            this.MaterialMultBarCode.Location = new Point(0x1d5, 0x2e0);
            this.MaterialMultBarCode.Name = "MaterialMultBarCode";
            this.MaterialMultBarCode.Size = new Size(100, 0x17);
            this.MaterialMultBarCode.TabIndex = 0x5b;
            this.MaterialDisExpDat.Location = new Point(0x18c, 0x1df);
            this.MaterialDisExpDat.Name = "MaterialDisExpDat";
            this.MaterialDisExpDat.Size = new Size(0x81, 0x17);
            this.MaterialDisExpDat.TabIndex = 0x5c;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2ab, 160);
            base.Controls.Add(this.MaterialDisExpDat);
            base.Controls.Add(this.MaterialMultBarCode);
            base.Controls.Add(this.MaterialOtherBarCode);
            base.Controls.Add(this.MaterialDarMiWi);
            base.Controls.Add(this.MaterialDisMiWi);
            base.Controls.Add(this.MaterialQuantityOffer);
            base.Controls.Add(this.MaterialNotIsView);
            base.Controls.Add(this.ButtonAdd);
            base.Controls.Add(this.GroupBox6);
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.GroupBox7);
            base.Controls.Add(this.GroupBox8);
            base.Controls.Add(this.GroupBox9);
            base.Controls.Add(this.AutoStop);
            base.Controls.Add(this.GroupBox10);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.GroupBox11);
            base.Controls.Add(this.GroupBox17);
            base.Controls.Add(this.GroupBox12);
            base.Controls.Add(this.GroupBox16);
            base.Controls.Add(this.GroupBox15);
            base.Controls.Add(this.GroupBox14);
            base.Controls.Add(this.GroupBox13);
            base.Controls.Add(this.TxTGroupID);
            base.Controls.Add(this.TxTGropName);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.StatusStrip1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialCopy";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "نسخ بيانات المستودع";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            ((ISupportInitialize) this.GvM).EndInit();
            this.GroupBox4.ResumeLayout(false);
            ((ISupportInitialize) this.GVG).EndInit();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox14.PerformLayout();
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox15.PerformLayout();
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox16.PerformLayout();
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox17.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            try
            {
                this.LabelFrom.Text = PR.KR.ToString();
                DataSet dataSet = new DataSet();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string selectCommandText = "SELECT CenterID, CenterSubName FROM TaNNCenters WHERE (CenterID <> @CenterID)";
                dataSet.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterID", PR.GR);
                adapter.Fill(dataSet, "TaNNCenters");
                this.A.Close();
                this.ComboBoxCenterTo.DataSource = dataSet.Tables[0];
                this.ComboBoxCenterTo.ValueMember = "CenterID";
                this.ComboBoxCenterTo.DisplayMember = "CenterSubName";
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                Interaction.MsgBox(R.ToString(), MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
                ProjectData.ClearProjectError();
            }
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

        private void D(object A, EventArgs R)
        {
            this.TimerStart.Enabled = false;
            if (this.GVG.Rows.Count > 0)
            {
                this.A = "SELECT * FROM [TaNNMaterial] WHERE CenterFrontID = @CenterFrontID AND GroupIDFrontID = @GroupIDFrontID";
                this.I();
                this.TimerG.Enabled = true;
            }
            else
            {
                this.A = "SELECT * FROM [TaNNMaterial] WHERE CenterFrontID = @CenterFrontID AND GroupIDFrontID = 0";
                this.I();
                this.A = true;
                this.TimerM.Enabled = true;
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
            if ((this.TxTGroupID.Text == null) | (this.TxTGroupID.Text == ""))
            {
                this.A = 0;
            }
        }

        private void H(object A, EventArgs R)
        {
            this.Q();
        }

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            try
            {
                DataSet dataSet = new DataSet();
                DataSet set2 = new DataSet();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string selectCommandText = "SELECT * FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)";
                dataSet.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", this.ComboBoxCenterTo.SelectedValue);
                adapter.Fill(dataSet, "TaNNMaterial");
                string str2 = "SELECT * FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)";
                set2.Clear();
                SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                adapter2.SelectCommand.Parameters.AddWithValue("CenterFrontID", this.ComboBoxCenterTo.SelectedValue);
                adapter2.Fill(set2, "TaNNMaterialGroup");
                this.A.Close();
                if (dataSet.Tables[0].Rows.Count <= 0)
                {
                    if (set2.Tables[0].Rows.Count <= 0)
                    {
                        this.GroupBox2.Enabled = false;
                        this.ButtonOk.Enabled = false;
                    }
                    else
                    {
                        Interaction.MsgBox("يجب ان يكون المستودع / الفرع الذي تريد نسخ البيانات اليه خالي من المجموعات والمواد", MsgBoxStyle.ApplicationModal, null);
                        return;
                    }
                }
                else
                {
                    Interaction.MsgBox("يجب ان يكون المستودع / الفرع الذي تريد نسخ البيانات اليه خالي من المجموعات والمواد", MsgBoxStyle.ApplicationModal, null);
                    return;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
                ProjectData.ClearProjectError();
            }
            try
            {
                DataSet dataSet = new DataSet();
                string selectCommandText = "SELECT * FROM [TaNNMaterial] WHERE CenterFrontID = @CenterFrontID";
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                dataSet.Clear();
                SqlDataAdapter adapter3 = new SqlDataAdapter(selectCommandText, this.A);
                adapter3.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter3.Fill(dataSet, "TaNNMaterial");
                this.A.Close();
                this.GvM.DataSource = dataSet;
                this.GvM.DataMember = "TaNNMaterial";
                this.GvM.Refresh();
                this.R = this.GvM.Rows.Count;
                this.LBRR.Text = Conversions.ToString(this.R);
                this.ProssBar.Maximum = this.R + 10;
                this.ProssBar.Visible = true;
                this.TimerStart.Enabled = true;
            }
            catch (Exception exception3)
            {
                Exception ex = exception3;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        public void P()
        {
            if (!this.AutoStop.Checked)
            {
                this.ButtonAdd.Enabled = false;
                this.Q();
            }
            else
            {
                this.TimerM.Enabled = false;
                this.TimerG.Enabled = false;
                this.TimerStart.Enabled = false;
                this.ButtonAdd.Enabled = true;
            }
        }

        private void P(object A, EventArgs R)
        {
            this.TimerM.Enabled = false;
            if (this.GvM.RowCount > 0)
            {
                this.P();
            }
            else if (this.A)
            {
                this.ProssBar.Visible = false;
                Interaction.MsgBox("انتهى النسخ", MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
            }
            else if (this.GVG.RowCount > 0)
            {
                this.GVG.Rows.Remove(this.GVG.SelectedRows[0]);
                this.TimerStart.Enabled = true;
            }
        }

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void Q()
        {
            try
            {
                decimal num = new decimal(Conversion.Val(this.MaterialQuantity.Text.Replace(",", "")));
                decimal num2 = new decimal(Conversion.Val(this.MaterialPricCost.Text.Replace(",", "")));
                decimal num3 = new decimal(Conversion.Val(this.MaterialPricSale.Text.Replace(",", "")));
                decimal num4 = new decimal(Conversion.Val(this.MaterialPricLess.Text.Replace(",", "")));
                decimal num5 = new decimal(Conversion.Val(this.MaterialQuantityOffer.Text.Replace(",", "")));
                decimal num6 = new decimal(Conversion.Val(this.MaterialQuantityLess.Text.Replace(",", "")));
                decimal num7 = new decimal(Conversion.Val(this.MaterialQuantityPakeg.Text.Replace(",", "")));
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("INSERT INTO TaNNMaterial(CenterFrontID, GroupIDFrontID, MaterialBarCode, MaterialName, MaterialQuantity, MaterialUnit, MaterialPricCost, MaterialPricLess, MaterialPricSale, MaterialIsStop, MaterialExpDate, MaterialNote, MaterialNotIsView, MaterialQuantityLess, MaterialQuantityPakeg, MaterialQuantityOffer, MaterialDisMiWi, MaterialDarMiWi, MaterialOtherBarCode, MaterialMultBarCode, MaterialBarcodeBlock, MaterialDisExpDat) VALUES (@CenterFrontID, @GroupIDFrontID, @MaterialBarCode, @MaterialName, @MaterialQuantity, @MaterialUnit, @MaterialPricCost, @MaterialPricLess, @MaterialPricSale, @MaterialIsStop, @MaterialExpDate, @MaterialNote, @MaterialNotIsView, @MaterialQuantityLess, @MaterialQuantityPakeg, @MaterialQuantityOffer, @MaterialDisMiWi, @MaterialDarMiWi, @MaterialOtherBarCode, @MaterialMultBarCode, @MaterialBarcodeBlock, @MaterialDisExpDat)", this.A);
                command.Parameters.AddWithValue("CenterFrontID", this.ComboBoxCenterTo.SelectedValue);
                command.Parameters.AddWithValue("GroupIDFrontID", this.A);
                command.Parameters.AddWithValue("MaterialBarCode", this.MaterialBarCode.Text.Trim());
                command.Parameters.AddWithValue("MaterialName", this.MaterialName.Text.Trim());
                command.Parameters.AddWithValue("MaterialQuantity", num.ToString(PR.OR));
                command.Parameters.AddWithValue("MaterialUnit", this.MaterialUnit.Text.Trim());
                command.Parameters.AddWithValue("MaterialPricCost", num2.ToString(PR.VR));
                command.Parameters.AddWithValue("MaterialPricSale", num3.ToString(PR.VR));
                command.Parameters.AddWithValue("MaterialPricLess", num4.ToString(PR.VR));
                command.Parameters.AddWithValue("MaterialIsStop", this.MaterialIsStop.Checked);
                if ((this.MaterialExpDate.Text == null) | (this.MaterialExpDate.Text == ""))
                {
                    command.Parameters.AddWithValue("@MaterialExpDate", DBNull.Value);
                }
                else
                {
                    DateTime time = Conversions.ToDate(this.MaterialExpDate.Text);
                    command.Parameters.AddWithValue("@MaterialExpDate", time.ToString("yyyy/MM/dd"));
                }
                command.Parameters.AddWithValue("MaterialNote", this.MaterialNote.Text.Trim());
                command.Parameters.AddWithValue("MaterialNotIsView", this.MaterialNotIsView.Checked);
                command.Parameters.AddWithValue("MaterialQuantityLess", num6.ToString(PR.OR));
                command.Parameters.AddWithValue("MaterialQuantityPakeg", num7.ToString(PR.OR));
                command.Parameters.AddWithValue("MaterialQuantityOffer", num5.ToString(PR.OR));
                command.Parameters.AddWithValue("MaterialDisMiWi", Conversion.Val(this.MaterialDisMiWi.Text));
                command.Parameters.AddWithValue("MaterialDarMiWi", Conversion.Val(this.MaterialDarMiWi.Text));
                command.Parameters.AddWithValue("MaterialOtherBarCode", this.MaterialOtherBarCode.Text.Trim());
                command.Parameters.AddWithValue("MaterialMultBarCode", this.MaterialMultBarCode.Text.Trim());
                if ((this.MaterialDisExpDat.Text == null) | (this.MaterialDisExpDat.Text == ""))
                {
                    command.Parameters.AddWithValue("@MaterialDisExpDat", DBNull.Value);
                }
                else
                {
                    DateTime time2 = Conversions.ToDate(this.MaterialDisExpDat.Text);
                    command.Parameters.AddWithValue("@MaterialDisExpDat", time2.ToString("yyyy/MM/dd"));
                }
                command.Parameters.AddWithValue("MaterialBarcodeBlock", this.ComboBoxCenterTo.SelectedValue.ToString() + this.MaterialBarCode.Text.Trim());
                command.ExecuteNonQuery();
                this.A.Close();
                this.ProssBar.Value = (int) Math.Round((double) (Conversion.Val(this.ProssBar.Value) + 1.0));
                this.LBRR.Text = Conversions.ToString((double) (Conversion.Val(this.LBRR.Text) - 1.0));
                if (this.GvM.RowCount > 0)
                {
                    this.GvM.Rows.Remove(this.GvM.SelectedRows[0]);
                    this.TimerM.Enabled = true;
                }
                else
                {
                    this.GVG.Rows.Remove(this.GVG.SelectedRows[0]);
                    this.TimerStart.Enabled = true;
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
            this.TimerG.Enabled = false;
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("INSERT INTO TaNNMaterialGroup (CenterFrontID, GroupName) VALUES (@CenterFrontID, @GroupName); SELECT GroupID FROM TaNNMaterialGroup WHERE (GroupID = SCOPE_IDENTITY())", this.A);
                command.Parameters.AddWithValue("@CenterFrontID", this.ComboBoxCenterTo.SelectedValue);
                command.Parameters.AddWithValue("@GroupName", this.TxTGropName.Text.Trim());
                this.A = Conversions.ToInteger(command.ExecuteScalar());
                this.A.Close();
                if (this.GVG.Rows.Count > 0)
                {
                    this.I();
                    this.TimerM.Enabled = true;
                }
                else
                {
                    this.GVG.Rows.Remove(this.GVG.SelectedRows[0]);
                    this.TimerStart.Enabled = true;
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

        private void Q(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void R()
        {
            try
            {
                DataSet dataSet = new DataSet();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string selectCommandText = "SELECT * FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)";
                dataSet.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataSet, "TaNNMaterialGroup");
                this.A.Close();
                this.TxTGropName.DataBindings.Clear();
                this.TxTGroupID.DataBindings.Clear();
                this.TxTGropName.DataBindings.Add("Text", dataSet, "TaNNMaterialGroup.GroupName");
                this.TxTGroupID.DataBindings.Add("Text", dataSet, "TaNNMaterialGroup.GroupID");
                this.GVG.DataSource = dataSet;
                this.GVG.DataMember = "TaNNMaterialGroup";
                this.GVG.Refresh();
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
                Interaction.MsgBox("لا يوجد لديك فروع", MsgBoxStyle.ApplicationModal, null);
                this.ButtonOk.Enabled = false;
            }
            this.R();
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void T(object A, EventArgs R)
        {
            if (this.AutoStop.Checked && ((this.MaterialBarCode.Text == null) | (this.MaterialBarCode.Text == "")))
            {
                this.ButtonAdd.Enabled = false;
            }
        }

        private void X(object A, EventArgs R)
        {
            base.Dispose();
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

        internal virtual Label LabelFrom
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual ComboBox ComboBoxCenterTo
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonOk
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

        internal virtual Label Label2
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

        internal virtual DataGridView GvM
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DataGridView GVG
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Timer TimerG
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual TextBox TxTGropName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTGroupID
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                TextBox r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
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

        internal virtual TextBox MaterialName
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox MaterialBarCode
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.TextChanged -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.TextChanged += handler;
                }
            }
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

        internal virtual TextBox MaterialQuantity
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox i = this.I;
                if (i != null)
                {
                    i.KeyPress -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.KeyPress += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox MaterialUnit
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TextBox MaterialPricCost
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.R);
                TextBox f = this.F;
                if (f != null)
                {
                    f.KeyPress -= handler;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.KeyPress += handler;
                }
            }
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

        internal virtual TextBox MaterialPricLess
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.P);
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

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TextBox MaterialPricSale
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.Q);
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

        internal virtual GroupBox GroupBox13
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
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual TextBox MaterialExpDate
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual TextBox MaterialNote
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual TextBox MaterialQuantityLess
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual TextBox MaterialQuantityPakeg
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Timer TimerM
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                Timer r = this.R;
                if (r != null)
                {
                    r.Tick -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.Tick += handler;
                }
            }
        }

        internal virtual Timer TimerStart
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                Timer p = this.P;
                if (p != null)
                {
                    p.Tick -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.Tick += handler;
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
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual CheckBox AutoStop
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual StatusStrip StatusStrip1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripStatusLabel ToolStripStatusLabel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripStatusLabel LBRR
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripProgressBar ProssBar
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual TextBox MaterialQuantityOffer
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual TextBox MaterialDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual TextBox MaterialDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual TextBox MaterialOtherBarCode
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual TextBox MaterialMultBarCode
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual TextBox MaterialDisExpDat
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }
    }
}

