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
    public class HF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [AccessedThroughProperty("XTxTBarCodeLink"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [AccessedThroughProperty("ToolStripButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator A;
        [AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton R;
        [AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("ToolStripLabel1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripLabel A;
        [AccessedThroughProperty("TxTGVRowCount"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripLabel R;
        [AccessedThroughProperty("ToolStripSeparator1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator P;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("ComboBoxSerachWat"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("TxTSerach"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("ButtonSearchCodeName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("TimerLoadData"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer P;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox P;
        [AccessedThroughProperty("MaterialBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("MaterialName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label P;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [AccessedThroughProperty("MaterialQuantity"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [AccessedThroughProperty("MaterialPricCost"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MaterialPricSale"), CompilerGenerated]
        private Label D;
        [AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox H;
        [AccessedThroughProperty("GroupBox13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox T;
        [AccessedThroughProperty("GroupBoxDis"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox X;
        [AccessedThroughProperty("MaterialDisMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label F;
        [AccessedThroughProperty("GroupBox11"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox G;
        [AccessedThroughProperty("MaterialDarMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label H;
        [AccessedThroughProperty("GroupBox10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox E;
        [AccessedThroughProperty("MaterialUnit"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label T;
        [AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox K;
        [AccessedThroughProperty("MaterialPricLess"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label X;
        [AccessedThroughProperty("GroupBox16"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox U;
        [AccessedThroughProperty("MaterialQuantityOffer"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label G;
        [AccessedThroughProperty("GroupBox15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox L;
        [AccessedThroughProperty("MaterialExpDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label E;
        [AccessedThroughProperty("MaterialIsStop"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox A;
        [AccessedThroughProperty("GroupBox17"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox N;
        [AccessedThroughProperty("MaterialNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label K;
        [AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView A;
        [AccessedThroughProperty("GroupBox14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox V;
        [AccessedThroughProperty("MSTotal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label U;
        [AccessedThroughProperty("TimerFocus"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer Q;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage R;
        [AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Y;
        [AccessedThroughProperty("ComboBoxGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox R;
        [AccessedThroughProperty("ButtonSortGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        private SqlConnection A;
        private DataTable A;
        private string A;

        public HF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A = "SELECT * FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox2 = new GroupBox();
            this.ComboBoxSerachWat = new ComboBox();
            this.GroupBox1 = new GroupBox();
            this.TxTSerach = new TextBox();
            this.ButtonSearchCodeName = new Button();
            this.XTxTBarCodeLink = new TextBox();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonOK = new ToolStripButton();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowCount = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TimerFillGV = new Timer(this.A);
            this.GroupBox3 = new GroupBox();
            this.MaterialBarCode = new Label();
            this.GroupBox4 = new GroupBox();
            this.MaterialName = new Label();
            this.GroupBox5 = new GroupBox();
            this.MaterialQuantity = new Label();
            this.GroupBox6 = new GroupBox();
            this.MaterialPricCost = new Label();
            this.GroupBox7 = new GroupBox();
            this.MaterialPricSale = new Label();
            this.GroupBox8 = new GroupBox();
            this.GroupBox14 = new GroupBox();
            this.MSTotal = new Label();
            this.GroupBox17 = new GroupBox();
            this.MaterialNote = new Label();
            this.GroupBox16 = new GroupBox();
            this.MaterialQuantityOffer = new Label();
            this.GroupBox15 = new GroupBox();
            this.MaterialExpDate = new Label();
            this.GroupBox13 = new GroupBox();
            this.MaterialIsStop = new CheckBox();
            this.GroupBoxDis = new GroupBox();
            this.MaterialDisMiWi = new Label();
            this.GroupBox11 = new GroupBox();
            this.MaterialDarMiWi = new Label();
            this.GroupBox10 = new GroupBox();
            this.MaterialUnit = new Label();
            this.GroupBox9 = new GroupBox();
            this.MaterialPricLess = new Label();
            this.GV = new DataGridView();
            this.TimerFocus = new Timer(this.A);
            this.TabPage2 = new TabPage();
            this.GroupBox12 = new GroupBox();
            this.ComboBoxGroup = new ComboBox();
            this.ButtonSortGroup = new Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBoxDis.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.TabPage2.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3bd, 0x22);
            this.TxTTitle.TabIndex = 0x3e;
            this.TxTTitle.Text = "استعلام عن مادة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3bd, 0x6f);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 0x3f;
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.ButtonSearchCodeName);
            this.TabPage1.Controls.Add(this.XTxTBarCodeLink);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3b5, 0x52);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "بحث";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.ComboBoxSerachWat);
            this.GroupBox2.Location = new Point(0x27e, 0x11);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x128, 0x33);
            this.GroupBox2.TabIndex = 0x13;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "البحث في";
            this.ComboBoxSerachWat.Dock = DockStyle.Fill;
            this.ComboBoxSerachWat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxSerachWat.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxSerachWat.FormattingEnabled = true;
            object[] items = new object[] { "باركود/ رقم المادة / باركود متعدد", "اسم الماده", "الملاحظات", "باركود متعدد" };
            this.ComboBoxSerachWat.Items.AddRange(items);
            this.ComboBoxSerachWat.Location = new Point(3, 0x13);
            this.ComboBoxSerachWat.Name = "ComboBoxSerachWat";
            this.ComboBoxSerachWat.Size = new Size(290, 0x18);
            this.ComboBoxSerachWat.TabIndex = 12;
            this.GroupBox1.Controls.Add(this.TxTSerach);
            this.GroupBox1.Location = new Point(0xcb, 0x11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x1ad, 0x33);
            this.GroupBox1.TabIndex = 0x12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "نص البحث";
            this.TxTSerach.Dock = DockStyle.Fill;
            this.TxTSerach.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTSerach.Location = new Point(3, 0x13);
            this.TxTSerach.Name = "TxTSerach";
            this.TxTSerach.Size = new Size(0x1a7, 0x1b);
            this.TxTSerach.TabIndex = 11;
            this.ButtonSearchCodeName.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSearchCodeName.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSearchCodeName.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSearchCodeName.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSearchCodeName.FlatStyle = FlatStyle.Flat;
            this.ButtonSearchCodeName.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSearchCodeName.Image = A.F.ImSearch;
            this.ButtonSearchCodeName.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSearchCodeName.Location = new Point(0x1a, 0x18);
            this.ButtonSearchCodeName.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSearchCodeName.Name = "ButtonSearchCodeName";
            this.ButtonSearchCodeName.Size = new Size(0xab, 0x2c);
            this.ButtonSearchCodeName.TabIndex = 0x11;
            this.ButtonSearchCodeName.Text = "بحث";
            this.ButtonSearchCodeName.UseVisualStyleBackColor = true;
            this.XTxTBarCodeLink.Location = new Point(850, 80);
            this.XTxTBarCodeLink.Name = "XTxTBarCodeLink";
            this.XTxTBarCodeLink.Size = new Size(0, 0x17);
            this.XTxTBarCodeLink.TabIndex = 14;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonOK, this.ToolStripSeparator6, this.ToolStripButtonClose, this.ToolStripSeparator7 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x28b);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3bd, 0x2f);
            this.ToolStripButtons.TabIndex = 0x54;
            this.ToolStripButtonOK.Image = A.F.ImOK;
            this.ToolStripButtonOK.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonOK.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonOK.Name = "ToolStripButtonOK";
            this.ToolStripButtonOK.Size = new Size(0x4d, 0x2c);
            this.ToolStripButtonOK.Text = "موافق";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new Size(6, 0x2f);
            this.ToolStripButtonClose.Image = A.F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x2c);
            this.ToolStripButtonClose.Text = "اغلاق";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(6, 0x2f);
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray2);
            this.ToolStripStatus.Location = new Point(0, 0x2ba);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3bd, 0x19);
            this.ToolStripStatus.TabIndex = 0x53;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x44, 0x16);
            this.ToolStripLabel1.Text = "عدد المواد:";
            this.TxTGVRowCount.ForeColor = Color.DarkGreen;
            this.TxTGVRowCount.Name = "TxTGVRowCount";
            this.TxTGVRowCount.RightToLeft = RightToLeft.No;
            this.TxTGVRowCount.Size = new Size(0x16, 0x16);
            this.TxTGVRowCount.Text = "00";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
            this.GroupBox3.Controls.Add(this.MaterialBarCode);
            this.GroupBox3.Location = new Point(0x2e7, 0x21);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(210, 0x3b);
            this.GroupBox3.TabIndex = 0x55;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم/باركود المادة";
            this.MaterialBarCode.Dock = DockStyle.Fill;
            this.MaterialBarCode.Location = new Point(3, 0x13);
            this.MaterialBarCode.Name = "MaterialBarCode";
            this.MaterialBarCode.RightToLeft = RightToLeft.No;
            this.MaterialBarCode.Size = new Size(0xcc, 0x25);
            this.MaterialBarCode.TabIndex = 0;
            this.MaterialBarCode.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox4.Controls.Add(this.MaterialName);
            this.GroupBox4.Location = new Point(0x1d3, 0x21);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x111, 0x3b);
            this.GroupBox4.TabIndex = 0x56;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "اسم المادة/ الوصف";
            this.MaterialName.Dock = DockStyle.Fill;
            this.MaterialName.Location = new Point(3, 0x13);
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.RightToLeft = RightToLeft.No;
            this.MaterialName.Size = new Size(0x10b, 0x25);
            this.MaterialName.TabIndex = 0;
            this.MaterialName.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox5.Controls.Add(this.MaterialQuantity);
            this.GroupBox5.Location = new Point(0x336, 0x62);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x83, 0x3b);
            this.GroupBox5.TabIndex = 0x57;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "الكمية الحالية";
            this.MaterialQuantity.Dock = DockStyle.Fill;
            this.MaterialQuantity.Location = new Point(3, 0x13);
            this.MaterialQuantity.Name = "MaterialQuantity";
            this.MaterialQuantity.RightToLeft = RightToLeft.No;
            this.MaterialQuantity.Size = new Size(0x7d, 0x25);
            this.MaterialQuantity.TabIndex = 0;
            this.MaterialQuantity.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox6.Controls.Add(this.MaterialPricCost);
            this.GroupBox6.Location = new Point(0x2b0, 0x62);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x83, 0x3b);
            this.GroupBox6.TabIndex = 0x58;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "سعر التكلفة";
            this.MaterialPricCost.Dock = DockStyle.Fill;
            this.MaterialPricCost.Location = new Point(3, 0x13);
            this.MaterialPricCost.Name = "MaterialPricCost";
            this.MaterialPricCost.RightToLeft = RightToLeft.No;
            this.MaterialPricCost.Size = new Size(0x7d, 0x25);
            this.MaterialPricCost.TabIndex = 0;
            this.MaterialPricCost.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox7.Controls.Add(this.MaterialPricSale);
            this.GroupBox7.Location = new Point(420, 0x62);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x83, 0x3b);
            this.GroupBox7.TabIndex = 0x59;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "سعر البيع";
            this.MaterialPricSale.Dock = DockStyle.Fill;
            this.MaterialPricSale.Location = new Point(3, 0x13);
            this.MaterialPricSale.Name = "MaterialPricSale";
            this.MaterialPricSale.RightToLeft = RightToLeft.No;
            this.MaterialPricSale.Size = new Size(0x7d, 0x25);
            this.MaterialPricSale.TabIndex = 0;
            this.MaterialPricSale.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox8.Controls.Add(this.GroupBox14);
            this.GroupBox8.Controls.Add(this.GroupBox17);
            this.GroupBox8.Controls.Add(this.GroupBox16);
            this.GroupBox8.Controls.Add(this.GroupBox15);
            this.GroupBox8.Controls.Add(this.GroupBox13);
            this.GroupBox8.Controls.Add(this.GroupBoxDis);
            this.GroupBox8.Controls.Add(this.GroupBox11);
            this.GroupBox8.Controls.Add(this.GroupBox10);
            this.GroupBox8.Controls.Add(this.GroupBox9);
            this.GroupBox8.Controls.Add(this.GroupBox3);
            this.GroupBox8.Controls.Add(this.GroupBox6);
            this.GroupBox8.Controls.Add(this.GroupBox7);
            this.GroupBox8.Controls.Add(this.GroupBox4);
            this.GroupBox8.Controls.Add(this.GroupBox5);
            this.GroupBox8.Dock = DockStyle.Bottom;
            this.GroupBox8.Location = new Point(0, 0x1a0);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x3bd, 0xeb);
            this.GroupBox8.TabIndex = 90;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "تفاصيل المادة المحددة";
            this.GroupBox14.Controls.Add(this.MSTotal);
            this.GroupBox14.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.GroupBox14.Location = new Point(0x1a8, 0xa4);
            this.GroupBox14.Margin = new Padding(4);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Padding = new Padding(4);
            this.GroupBox14.Size = new Size(0x105, 0x3a);
            this.GroupBox14.TabIndex = 0x5c;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "صافي سعر البيع";
            this.MSTotal.Dock = DockStyle.Fill;
            this.MSTotal.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.MSTotal.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.MSTotal.Location = new Point(4, 20);
            this.MSTotal.Margin = new Padding(4, 0, 4, 0);
            this.MSTotal.Name = "MSTotal";
            this.MSTotal.RightToLeft = RightToLeft.No;
            this.MSTotal.Size = new Size(0xfd, 0x22);
            this.MSTotal.TabIndex = 0;
            this.MSTotal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox17.Controls.Add(this.MaterialNote);
            this.GroupBox17.Location = new Point(4, 0xa3);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(0x19d, 0x3b);
            this.GroupBox17.TabIndex = 0x5b;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "ملاحظات";
            this.MaterialNote.Dock = DockStyle.Fill;
            this.MaterialNote.Location = new Point(3, 0x13);
            this.MaterialNote.Name = "MaterialNote";
            this.MaterialNote.RightToLeft = RightToLeft.No;
            this.MaterialNote.Size = new Size(0x197, 0x25);
            this.MaterialNote.TabIndex = 0;
            this.MaterialNote.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox16.Controls.Add(this.MaterialQuantityOffer);
            this.GroupBox16.Location = new Point(0x2b0, 0xa3);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(0x109, 0x3b);
            this.GroupBox16.TabIndex = 90;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "تطبيق السعر المخفض تلقائي عندما تكون الكمية تساوي";
            this.MaterialQuantityOffer.Dock = DockStyle.Fill;
            this.MaterialQuantityOffer.Location = new Point(3, 0x13);
            this.MaterialQuantityOffer.Name = "MaterialQuantityOffer";
            this.MaterialQuantityOffer.RightToLeft = RightToLeft.No;
            this.MaterialQuantityOffer.Size = new Size(0x103, 0x25);
            this.MaterialQuantityOffer.TabIndex = 0;
            this.MaterialQuantityOffer.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox15.Controls.Add(this.MaterialExpDate);
            this.GroupBox15.Location = new Point(6, 0x21);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x124, 0x3b);
            this.GroupBox15.TabIndex = 0x59;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "تاريخ الانتهاء";
            this.MaterialExpDate.Dock = DockStyle.Fill;
            this.MaterialExpDate.Location = new Point(3, 0x13);
            this.MaterialExpDate.Name = "MaterialExpDate";
            this.MaterialExpDate.RightToLeft = RightToLeft.No;
            this.MaterialExpDate.Size = new Size(0x11e, 0x25);
            this.MaterialExpDate.TabIndex = 0;
            this.MaterialExpDate.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox13.Controls.Add(this.MaterialIsStop);
            this.GroupBox13.Location = new Point(6, 0x62);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x7a, 0x3b);
            this.GroupBox13.TabIndex = 0x5b;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "مجمدة من البيع";
            this.MaterialIsStop.Dock = DockStyle.Fill;
            this.MaterialIsStop.Location = new Point(3, 0x13);
            this.MaterialIsStop.Name = "MaterialIsStop";
            this.MaterialIsStop.Size = new Size(0x74, 0x25);
            this.MaterialIsStop.TabIndex = 0;
            this.MaterialIsStop.Text = "نعم/ لا";
            this.MaterialIsStop.UseVisualStyleBackColor = true;
            this.GroupBoxDis.Controls.Add(this.MaterialDisMiWi);
            this.GroupBoxDis.Location = new Point(0x86, 0x62);
            this.GroupBoxDis.Name = "GroupBoxDis";
            this.GroupBoxDis.Size = new Size(0x95, 0x3b);
            this.GroupBoxDis.TabIndex = 0x5b;
            this.GroupBoxDis.TabStop = false;
            this.GroupBoxDis.Text = "الخصم%";
            this.MaterialDisMiWi.Dock = DockStyle.Fill;
            this.MaterialDisMiWi.Location = new Point(3, 0x13);
            this.MaterialDisMiWi.Name = "MaterialDisMiWi";
            this.MaterialDisMiWi.RightToLeft = RightToLeft.No;
            this.MaterialDisMiWi.Size = new Size(0x8f, 0x25);
            this.MaterialDisMiWi.TabIndex = 0;
            this.MaterialDisMiWi.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox11.Controls.Add(this.MaterialDarMiWi);
            this.GroupBox11.Location = new Point(0x11e, 0x62);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x83, 0x3b);
            this.GroupBox11.TabIndex = 90;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "الضريبة %";
            this.MaterialDarMiWi.Dock = DockStyle.Fill;
            this.MaterialDarMiWi.Location = new Point(3, 0x13);
            this.MaterialDarMiWi.Name = "MaterialDarMiWi";
            this.MaterialDarMiWi.RightToLeft = RightToLeft.No;
            this.MaterialDarMiWi.Size = new Size(0x7d, 0x25);
            this.MaterialDarMiWi.TabIndex = 0;
            this.MaterialDarMiWi.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox10.Controls.Add(this.MaterialUnit);
            this.GroupBox10.Location = new Point(0x12d, 0x21);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0xa3, 0x3b);
            this.GroupBox10.TabIndex = 90;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "الوحدة";
            this.MaterialUnit.Dock = DockStyle.Fill;
            this.MaterialUnit.Location = new Point(3, 0x13);
            this.MaterialUnit.Name = "MaterialUnit";
            this.MaterialUnit.RightToLeft = RightToLeft.No;
            this.MaterialUnit.Size = new Size(0x9d, 0x25);
            this.MaterialUnit.TabIndex = 0;
            this.MaterialUnit.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox9.Controls.Add(this.MaterialPricLess);
            this.GroupBox9.Location = new Point(0x22a, 0x62);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x83, 0x3b);
            this.GroupBox9.TabIndex = 0x58;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "سعر البيع المخفض";
            this.MaterialPricLess.Dock = DockStyle.Fill;
            this.MaterialPricLess.Location = new Point(3, 0x13);
            this.MaterialPricLess.Name = "MaterialPricLess";
            this.MaterialPricLess.RightToLeft = RightToLeft.No;
            this.MaterialPricLess.Size = new Size(0x7d, 0x25);
            this.MaterialPricLess.TabIndex = 0;
            this.MaterialPricLess.TextAlign = ContentAlignment.MiddleCenter;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AllowUserToOrderColumns = true;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Window;
            style.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.ControlText;
            style.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style.SelectionForeColor = Color.Black;
            style.WrapMode = DataGridViewTriState.False;
            this.GV.DefaultCellStyle = style;
            this.GV.Dock = DockStyle.Fill;
            this.GV.Location = new Point(0, 0x91);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3bd, 0x10f);
            this.GV.TabIndex = 0x1ed36ce;
            this.TimerFocus.Interval = 500;
            this.TabPage2.Controls.Add(this.GroupBox12);
            this.TabPage2.Controls.Add(this.ButtonSortGroup);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x3b5, 0x52);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "فرز حسب المجموعة";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GroupBox12.Controls.Add(this.ComboBoxGroup);
            this.GroupBox12.Location = new Point(0x1d5, 13);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x1ba, 0x37);
            this.GroupBox12.TabIndex = 0x3f;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "حدد المجموعة";
            this.ComboBoxGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxGroup.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxGroup.Dock = DockStyle.Fill;
            this.ComboBoxGroup.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxGroup.FormattingEnabled = true;
            this.ComboBoxGroup.IntegralHeight = false;
            this.ComboBoxGroup.Location = new Point(3, 0x13);
            this.ComboBoxGroup.Name = "ComboBoxGroup";
            this.ComboBoxGroup.Size = new Size(0x1b4, 0x1b);
            this.ComboBoxGroup.TabIndex = 0x3b;
            this.ButtonSortGroup.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortGroup.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortGroup.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortGroup.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortGroup.FlatStyle = FlatStyle.Flat;
            this.ButtonSortGroup.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortGroup.Image = A.F.ImSort;
            this.ButtonSortGroup.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortGroup.Location = new Point(0x10b, 0x15);
            this.ButtonSortGroup.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortGroup.Name = "ButtonSortGroup";
            this.ButtonSortGroup.Size = new Size(0xc4, 0x2f);
            this.ButtonSortGroup.TabIndex = 0x3e;
            this.ButtonSortGroup.Text = "فرز";
            this.ButtonSortGroup.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3bd, 0x2d3);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.GroupBox8);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "MaterialQuery";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "استعلام عن مادة";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBoxDis.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, DataGridViewCellEventArgs R)
        {
            this.Q();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonSearchCodeName.PerformClick();
            }
        }

        private void D(object A, EventArgs R)
        {
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
        }

        private void F(object A, EventArgs R)
        {
        }

        private void G(object A, EventArgs R)
        {
            this.TimerFocus.Enabled = false;
            if (this.ComboBoxSerachWat.SelectedIndex == 0)
            {
                this.TxTSerach.Text = null;
            }
            this.TxTSerach.Focus();
        }

        private void H(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.P();
        }

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void K(object A, EventArgs R)
        {
            this.A = "SELECT * FROM [TaNNMaterial] WHERE (CenterFrontID = @CenterFrontID) AND (GroupIDFrontID = @GroupIDFrontID)";
            this.TimerLoadData.Enabled = true;
        }

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.R();
            this.TimerLoadData.Enabled = true;
        }

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
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
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
        }

        private void R(object A, DataGridViewCellEventArgs R)
        {
        }

        private void T(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    if (Application.OpenForms.OfType<LD>().Any<LD>())
                    {
                        A.D.A.A.TxTBarCodeSelect.Text = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                        A.D.A.A.ButtonSelect.PerformClick();
                    }
                    if (Application.OpenForms.OfType<FF>().Any<FF>())
                    {
                        A.D.A.A.MBarCode.Text = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                        A.D.A.A.R();
                    }
                    if (Application.OpenForms.OfType<A.U>().Any<A.U>())
                    {
                        A.D.A.A.MBarCode.Text = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                        A.D.A.A.Q();
                    }
                    if (Application.OpenForms.OfType<A.L>().Any<A.L>())
                    {
                        A.D.A.A.MBarCode.Text = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                        A.D.A.A.P();
                    }
                    if (Application.OpenForms.OfType<EH>().Any<EH>())
                    {
                        A.D.A.A.TxTBarCode.Text = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                        A.D.A.A.R();
                    }
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

        private void X(object A, EventArgs R)
        {
            this.Q();
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

        internal virtual TextBox XTxTBarCodeLink
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStrip ToolStripButtons
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ToolStripButtonOK
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                ToolStripButton a = this.A;
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

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ToolStripButtonClose
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                ToolStripButton r = this.R;
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

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStrip ToolStripStatus
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripProgressBar ToolStripProgressBar1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripLabel ToolStripLabel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripLabel TxTGVRowCount
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual ComboBox ComboBoxSerachWat
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                ComboBox a = this.A;
                if (a != null)
                {
                    a.SelectedIndexChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.SelectedIndexChanged += handler;
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

        internal virtual TextBox TxTSerach
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual Button ButtonSearchCodeName
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

        internal virtual Timer TimerLoadData
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

        internal virtual Timer TimersStartUp
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

        internal virtual Timer TimerFillGV
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label MaterialBarCode
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual Label MaterialName
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label MaterialQuantity
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label MaterialPricCost
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
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label MaterialPricSale
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
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual GroupBox GroupBoxDis
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual Label MaterialDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
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

        internal virtual Label MaterialDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual Label MaterialUnit
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual Label MaterialPricLess
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual Label MaterialQuantityOffer
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual Label MaterialExpDate
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
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

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual Label MaterialNote
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                DataGridViewCellEventHandler handler2 = new DataGridViewCellEventHandler(this.R);
                DataGridView a = this.A;
                if (a != null)
                {
                    a.SelectionChanged -= handler;
                    a.CellContentClick -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.SelectionChanged += handler;
                    a.CellContentClick += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual Label MSTotal
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual Timer TimerFocus
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                Timer q = this.Q;
                if (q != null)
                {
                    q.Tick -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.Tick += handler;
                }
            }
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

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
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

        internal virtual Button ButtonSortGroup
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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

        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= 0x200;
                return createParams;
            }
        }
    }
}

