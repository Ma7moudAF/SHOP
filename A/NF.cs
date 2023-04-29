namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class NF : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1"), CompilerGenerated]
        private TabControl A;
        [CompilerGenerated, AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("InvSaleType"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("ButtonSortDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage R;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label P;
        [AccessedThroughProperty("TxTMaxSerch2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [AccessedThroughProperty("TxTMaxSerch1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("ButtonBetwenMax"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [CompilerGenerated, AccessedThroughProperty("SBBButtonBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [AccessedThroughProperty("SBBTxTBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [CompilerGenerated, AccessedThroughProperty("PictureBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PictureBox A;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxDate"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtons")]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonViewAll"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonCard"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton R;
        [AccessedThroughProperty("ToolStripSeparator5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripSeparator6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator7")]
        private ToolStripSeparator Q;
        [AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("ToolStripLabel1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripLabel A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTGVRowCount"), CompilerGenerated]
        private ToolStripLabel R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator I;
        [AccessedThroughProperty("TimerLoadData"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [AccessedThroughProperty("TimerFillGV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GV"), CompilerGenerated]
        private DataGridView A;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxUser"), CompilerGenerated]
        private ComboBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox I;
        [CompilerGenerated, AccessedThroughProperty("DateTimePickerFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PickerTimeFrom")]
        private DateTimePicker R;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DateTimePickerTo"), CompilerGenerated]
        private DateTimePicker P;
        [CompilerGenerated, AccessedThroughProperty("PickerTimeTo"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("A4ToolStripMenuItemInvos")]
        private ToolStripSplitButton A;
        [AccessedThroughProperty("ButPrintArA4ToolStripMenuItem"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButPrintArA5ToolStripMenuItem")]
        private ToolStripMenuItem R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButPrintArRoll80ToolStripMenuItem")]
        private ToolStripMenuItem P;
        [AccessedThroughProperty("ButPrinteEnA4ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem Q;
        [AccessedThroughProperty("ButPrintEnA5ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem I;
        [CompilerGenerated, AccessedThroughProperty("ButPrintEnRoll80ToolStripMenuItem"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem D;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator D;
        [AccessedThroughProperty("ButPrintTAXAR"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem F;
        [AccessedThroughProperty("ButPrintTAXEN"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem H;
        private SqlConnection A;
        private int A;
        private DataTable A;
        private DataTable R;
        public static string A = "SELECT TaNNInvSale.*, TaNNCustomers.CustomerName FROM TaNNInvSale LEFT OUTER JOIN TaNNCustomers ON TaNNInvSale.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSale.CenterFrontID = @CenterFrontID) AND (TaNNInvSale.InvSaleType = @InvSaleType) AND (TaNNInvSale.InvSaleUserAddBy = @InvSaleUserAddBy)";
        public static string R = "";

        public NF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = 0;
            this.A = new DataTable();
            this.R = new DataTable();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(NF));
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox1 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBox2 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.GroupBox3 = new GroupBox();
            this.ComboBoxUser = new ComboBox();
            this.GroupBox9 = new GroupBox();
            this.InvSaleType = new ComboBox();
            this.ButtonSortDate = new Button();
            this.TabPage2 = new TabPage();
            this.GroupBox5 = new GroupBox();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.TxTMaxSerch2 = new TextBox();
            this.TxTMaxSerch1 = new TextBox();
            this.ButtonBetwenMax = new Button();
            this.GroupBox4 = new GroupBox();
            this.SBBButtonBarCode = new Button();
            this.SBBTxTBarCode = new TextBox();
            this.PictureBox2 = new PictureBox();
            this.CheckBoxDate = new CheckBox();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ToolStripButtonCard = new ToolStripButton();
            this.ToolStripSeparator5 = new ToolStripSeparator();
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
            this.GV = new DataGridView();
            this.A4ToolStripMenuItemInvos = new ToolStripSplitButton();
            this.ButPrintArA4ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrintArA5ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrintArRoll80ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrinteEnA4ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrintEnA5ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrintEnRoll80ToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ButPrintTAXAR = new ToolStripMenuItem();
            this.ButPrintTAXEN = new ToolStripMenuItem();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d6, 0x22);
            this.TxTTitle.TabIndex = 110;
            this.TxTTitle.Text = "طباعة فاتورة سابقة ";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d6, 0x7b);
            this.TabControl1.TabIndex = 0x6f;
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.ButtonSortDate);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3ce, 0x5e);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الرئيسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x221, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb0, 0x4a);
            this.GroupBox1.TabIndex = 0x1ed36cf;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "من تاريخ";
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
            this.GroupBox2.Controls.Add(this.DateTimePickerTo);
            this.GroupBox2.Controls.Add(this.PickerTimeTo);
            this.GroupBox2.Location = new Point(0x15d, 8);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xb0, 0x48);
            this.GroupBox2.TabIndex = 0x1ed36d0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "الى تاريخ";
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
            this.GroupBox3.Controls.Add(this.ComboBoxUser);
            this.GroupBox3.Location = new Point(0x95, 10);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0xc5, 0x34);
            this.GroupBox3.TabIndex = 0x1ed36cd;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الموظف";
            this.ComboBoxUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxUser.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxUser.Dock = DockStyle.Top;
            this.ComboBoxUser.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxUser.FormattingEnabled = true;
            this.ComboBoxUser.IntegralHeight = false;
            this.ComboBoxUser.Location = new Point(3, 0x13);
            this.ComboBoxUser.Name = "ComboBoxUser";
            this.ComboBoxUser.Size = new Size(0xbf, 0x1b);
            this.ComboBoxUser.TabIndex = 60;
            this.GroupBox9.Controls.Add(this.InvSaleType);
            this.GroupBox9.Location = new Point(0x2d7, 7);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0xf1, 0x35);
            this.GroupBox9.TabIndex = 0x1ed36cc;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "نوع الفاتورة";
            this.InvSaleType.Dock = DockStyle.Fill;
            this.InvSaleType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvSaleType.FormattingEnabled = true;
            object[] items = new object[] { "فاتورة مبيعات", "فاتورة مرتجع مبيعات" };
            this.InvSaleType.Items.AddRange(items);
            this.InvSaleType.Location = new Point(3, 0x13);
            this.InvSaleType.Name = "InvSaleType";
            this.InvSaleType.Size = new Size(0xeb, 0x18);
            this.InvSaleType.TabIndex = 0x2c;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(8, 15);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(0x87, 0x2c);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.GroupBox5);
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x3ce, 0x5e);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "فرز حسب ترميز/رقم الفاتورة";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GroupBox5.BackColor = Color.White;
            this.GroupBox5.Controls.Add(this.Label2);
            this.GroupBox5.Controls.Add(this.Label1);
            this.GroupBox5.Controls.Add(this.TxTMaxSerch2);
            this.GroupBox5.Controls.Add(this.TxTMaxSerch1);
            this.GroupBox5.Controls.Add(this.ButtonBetwenMax);
            this.GroupBox5.Location = new Point(0x9c, 7);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x16e, 0x3b);
            this.GroupBox5.TabIndex = 0x1ed36cd;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "البحث في تسلسل الفواتير";
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0xbf, 0x1d);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x21, 0x10);
            this.Label2.TabIndex = 0x53;
            this.Label2.Text = "الى:";
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(0x14d, 0x1b);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(30, 0x10);
            this.Label1.TabIndex = 0x52;
            this.Label1.Text = "من:";
            this.TxTMaxSerch2.BackColor = SystemColors.Info;
            this.TxTMaxSerch2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMaxSerch2.Location = new Point(0x5f, 0x16);
            this.TxTMaxSerch2.Name = "TxTMaxSerch2";
            this.TxTMaxSerch2.RightToLeft = RightToLeft.No;
            this.TxTMaxSerch2.Size = new Size(90, 0x1b);
            this.TxTMaxSerch2.TabIndex = 0x51;
            this.TxTMaxSerch2.TextAlign = HorizontalAlignment.Center;
            this.TxTMaxSerch1.BackColor = SystemColors.Info;
            this.TxTMaxSerch1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMaxSerch1.Location = new Point(0xed, 0x16);
            this.TxTMaxSerch1.Name = "TxTMaxSerch1";
            this.TxTMaxSerch1.RightToLeft = RightToLeft.No;
            this.TxTMaxSerch1.Size = new Size(90, 0x1b);
            this.TxTMaxSerch1.TabIndex = 80;
            this.TxTMaxSerch1.TextAlign = HorizontalAlignment.Center;
            this.ButtonBetwenMax.FlatAppearance.BorderColor = Color.Green;
            this.ButtonBetwenMax.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonBetwenMax.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonBetwenMax.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonBetwenMax.FlatStyle = FlatStyle.Flat;
            this.ButtonBetwenMax.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonBetwenMax.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonBetwenMax.Location = new Point(6, 20);
            this.ButtonBetwenMax.Margin = new Padding(3, 4, 3, 4);
            this.ButtonBetwenMax.Name = "ButtonBetwenMax";
            this.ButtonBetwenMax.Size = new Size(0x4a, 30);
            this.ButtonBetwenMax.TabIndex = 0x4f;
            this.ButtonBetwenMax.Text = "فرز";
            this.ButtonBetwenMax.UseVisualStyleBackColor = true;
            this.GroupBox4.BackColor = Color.White;
            this.GroupBox4.Controls.Add(this.SBBButtonBarCode);
            this.GroupBox4.Controls.Add(this.SBBTxTBarCode);
            this.GroupBox4.Controls.Add(this.PictureBox2);
            this.GroupBox4.Location = new Point(610, 7);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x166, 0x3b);
            this.GroupBox4.TabIndex = 0x1ed36cc;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "البحث في باركود/ ترميز الفاتورة";
            this.SBBButtonBarCode.FlatAppearance.BorderColor = Color.Green;
            this.SBBButtonBarCode.FlatAppearance.CheckedBackColor = Color.White;
            this.SBBButtonBarCode.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.SBBButtonBarCode.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.SBBButtonBarCode.FlatStyle = FlatStyle.Flat;
            this.SBBButtonBarCode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.SBBButtonBarCode.ImageAlign = ContentAlignment.MiddleLeft;
            this.SBBButtonBarCode.Location = new Point(6, 0x13);
            this.SBBButtonBarCode.Margin = new Padding(3, 4, 3, 4);
            this.SBBButtonBarCode.Name = "SBBButtonBarCode";
            this.SBBButtonBarCode.Size = new Size(0x4a, 30);
            this.SBBButtonBarCode.TabIndex = 0x4f;
            this.SBBButtonBarCode.Text = "فرز";
            this.SBBButtonBarCode.UseVisualStyleBackColor = true;
            this.SBBTxTBarCode.BackColor = SystemColors.Info;
            this.SBBTxTBarCode.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.SBBTxTBarCode.Location = new Point(0xac, 20);
            this.SBBTxTBarCode.Name = "SBBTxTBarCode";
            this.SBBTxTBarCode.RightToLeft = RightToLeft.No;
            this.SBBTxTBarCode.Size = new Size(0xb0, 0x1b);
            this.SBBTxTBarCode.TabIndex = 70;
            this.SBBTxTBarCode.TextAlign = HorizontalAlignment.Center;
            this.PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox2.Image = A.F.BarCodeSS;
            this.PictureBox2.Location = new Point(0x57, 20);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new Size(0x6c, 0x1b);
            this.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 0x47;
            this.PictureBox2.TabStop = false;
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxDate.Checked = true;
            this.CheckBoxDate.CheckState = CheckState.Checked;
            this.CheckBoxDate.Dock = DockStyle.Top;
            this.CheckBoxDate.Location = new Point(0, 0x9d);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Padding = new Padding(4);
            this.CheckBoxDate.Size = new Size(0x3d6, 0x1c);
            this.CheckBoxDate.TabIndex = 0x1ed36cc;
            this.CheckBoxDate.Text = "تضمين فترة التاريخ دائماً مع كل عمليات الفرز";
            this.CheckBoxDate.UseVisualStyleBackColor = false;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonViewAll, this.ToolStripSeparator8, this.ToolStripButtonCard, this.ToolStripSeparator5, this.A4ToolStripMenuItemInvos, this.ToolStripSeparator6, this.ToolStripButtonClose, this.ToolStripSeparator7 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x24d);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d6, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36ce;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(6, 0x2f);
            this.ToolStripButtonCard.Image = A.F.ImCard;
            this.ToolStripButtonCard.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonCard.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonCard.Name = "ToolStripButtonCard";
            this.ToolStripButtonCard.Size = new Size(0xcd, 0x2c);
            this.ToolStripButtonCard.Text = "عرض تفاصيل الفاتورة المحددة";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(6, 0x2f);
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
            this.ToolStripStatus.Location = new Point(0, 0x27c);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d6, 0x19);
            this.ToolStripStatus.TabIndex = 0x1ed36cd;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(70, 0x16);
            this.ToolStripLabel1.Text = "عدد الفواتير";
            this.TxTGVRowCount.ForeColor = Color.DarkGreen;
            this.TxTGVRowCount.Name = "TxTGVRowCount";
            this.TxTGVRowCount.RightToLeft = RightToLeft.No;
            this.TxTGVRowCount.Size = new Size(0x16, 0x16);
            this.TxTGVRowCount.Text = "00";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
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
            this.GV.Location = new Point(0, 0xb9);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3d6, 0x194);
            this.GV.TabIndex = 0x1ed36d0;
            ToolStripItem[] itemArray3 = new ToolStripItem[9];
            itemArray3[0] = this.ButPrintArA4ToolStripMenuItem;
            itemArray3[1] = this.ButPrintArA5ToolStripMenuItem;
            itemArray3[2] = this.ButPrintArRoll80ToolStripMenuItem;
            itemArray3[3] = this.ButPrinteEnA4ToolStripMenuItem;
            itemArray3[4] = this.ButPrintEnA5ToolStripMenuItem;
            itemArray3[5] = this.ButPrintEnRoll80ToolStripMenuItem;
            itemArray3[6] = this.ToolStripSeparator2;
            itemArray3[7] = this.ButPrintTAXAR;
            itemArray3[8] = this.ButPrintTAXEN;
            this.A4ToolStripMenuItemInvos.DropDownItems.AddRange(itemArray3);
            this.A4ToolStripMenuItemInvos.Image = (Image) manager.GetObject("A4ToolStripMenuItemInvos.Image");
            this.A4ToolStripMenuItemInvos.ImageScaling = ToolStripItemImageScaling.None;
            this.A4ToolStripMenuItemInvos.Name = "A4ToolStripMenuItemInvos";
            this.A4ToolStripMenuItemInvos.Size = new Size(0x8e, 0x2c);
            this.A4ToolStripMenuItemInvos.Text = "الفاتورة المحددة";
            this.ButPrintArA4ToolStripMenuItem.Name = "ButPrintArA4ToolStripMenuItem";
            this.ButPrintArA4ToolStripMenuItem.Size = new Size(0xea, 0x16);
            this.ButPrintArA4ToolStripMenuItem.Text = "عربي قياس A4";
            this.ButPrintArA5ToolStripMenuItem.Name = "ButPrintArA5ToolStripMenuItem";
            this.ButPrintArA5ToolStripMenuItem.Size = new Size(0xea, 0x16);
            this.ButPrintArA5ToolStripMenuItem.Text = "عربي قياس A5";
            this.ButPrintArRoll80ToolStripMenuItem.Name = "ButPrintArRoll80ToolStripMenuItem";
            this.ButPrintArRoll80ToolStripMenuItem.Size = new Size(0xea, 0x16);
            this.ButPrintArRoll80ToolStripMenuItem.Text = "عربي حراري قياس 80";
            this.ButPrinteEnA4ToolStripMenuItem.Name = "ButPrinteEnA4ToolStripMenuItem";
            this.ButPrinteEnA4ToolStripMenuItem.Size = new Size(0xea, 0x16);
            this.ButPrinteEnA4ToolStripMenuItem.Text = "اجليزي قياس A4";
            this.ButPrintEnA5ToolStripMenuItem.Name = "ButPrintEnA5ToolStripMenuItem";
            this.ButPrintEnA5ToolStripMenuItem.Size = new Size(0xea, 0x16);
            this.ButPrintEnA5ToolStripMenuItem.Text = "انجليزي قياس A5";
            this.ButPrintEnRoll80ToolStripMenuItem.Name = "ButPrintEnRoll80ToolStripMenuItem";
            this.ButPrintEnRoll80ToolStripMenuItem.Size = new Size(0xea, 0x16);
            this.ButPrintEnRoll80ToolStripMenuItem.Text = "انجليزي حراري قياس 80";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(0xe7, 6);
            this.ButPrintTAXAR.Name = "ButPrintTAXAR";
            this.ButPrintTAXAR.Size = new Size(0xea, 0x16);
            this.ButPrintTAXAR.Text = "فاتورة ضريبية رسمية عربي";
            this.ButPrintTAXEN.Name = "ButPrintTAXEN";
            this.ButPrintTAXEN.Size = new Size(0xea, 0x16);
            this.ButPrintTAXEN.Text = "فاتورة ضريبية رسمية انجليزي";
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3d6, 0x295);
            base.ControlBox = false;
            base.Controls.Add(this.GV);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.CheckBoxDate);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "PrintLastInvoice";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "طباعة فاتورة سابقة ";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((ISupportInitialize) this.PictureBox2).EndInit();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, DataGridViewCellEventArgs R)
        {
        }

        private void A(object A, DataGridViewDataErrorEventArgs R)
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            NF.R = NF.A;
            this.TimerLoadData.Enabled = true;
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
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.I();
            }
        }

        private void F(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    this.A = this.GV.CurrentRow.Index;
                    ND.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                    A.D.A.A.GroupBox24.Visible = false;
                    A.D.A.A.ShowDialog();
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

        private void G(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.Q();
            }
        }

        private void H(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void I(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.P();
        }

        private void K(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.D();
            }
        }

        private void L(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.H();
            }
        }

        private void N(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.T();
            }
        }

        public void P()
        {
            try
            {
                IEnumerator enumerator;
                DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
                DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                this.R.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(R, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                string text = this.SBBTxTBarCode.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleID", text ?? DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleType", this.InvSaleType.SelectedIndex);
                string text2 = this.SBBTxTBarCode.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleIDMAX", text2 ?? DBNull.Value);
                string text3 = this.TxTMaxSerch1.Text;
                adapter.SelectCommand.Parameters.AddWithValue("MAXDF", text3 ?? DBNull.Value);
                string text4 = this.TxTMaxSerch2.Text;
                adapter.SelectCommand.Parameters.AddWithValue("MAXDT", text4 ?? DBNull.Value);
                string text5 = time.ToString("yyyy/MM/dd HH:mm");
                adapter.SelectCommand.Parameters.AddWithValue("DF", text5 ?? DBNull.Value);
                string text6 = time2.ToString("yyyy/MM/dd HH:mm");
                adapter.SelectCommand.Parameters.AddWithValue("DT", text6 ?? DBNull.Value);
                string text7 = this.ComboBoxUser.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleUserAddBy", text7 ?? DBNull.Value);
                adapter.Fill(this.R);
                this.A.Close();
                this.GV.DataSource = this.R;
                this.GV.Refresh();
                this.GV.Columns["InvSaleID"].HeaderText = "الترميز";
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["CustomerFrontID"].Visible = false;
                this.GV.Columns["InvSaleIDMAX"].HeaderText = "رقم الفاتورة";
                this.GV.Columns["InvSaleDateTime"].HeaderText = "تاريخ/ وقت";
                this.GV.Columns["InvSaleType"].HeaderText = "نوع الفاتورة";
                this.GV.Columns["InvSaleItems"].HeaderText = "عدد المواد";
                this.GV.Columns["InvSaleStatus"].HeaderText = "الحالة";
                this.GV.Columns["InvSalePayType"].HeaderText = "طريقة الدفع";
                this.GV.Columns["InvSaleTotalAmount"].HeaderText = "اجمالي المبلغ";
                this.GV.Columns["InvSaleDisMaWi"].HeaderText = "الخصم %";
                this.GV.Columns["InvSaleDisVal"].HeaderText = "مبلغ الخصم";
                this.GV.Columns["InvSaleDarMiWi"].HeaderText = "الضريبة %";
                this.GV.Columns["InvSaleDarVal"].HeaderText = "مبلغ الضريبة";
                this.GV.Columns["InvSaleTotalNET"].HeaderText = "صافي المجموع";
                this.GV.Columns["InvSaleTotalAmount"].Visible = false;
                this.GV.Columns["InvSaleDisMaWi"].Visible = false;
                this.GV.Columns["InvSaleDisVal"].Visible = false;
                this.GV.Columns["InvSaleDarMiWi"].Visible = false;
                this.GV.Columns["InvSaleTotalNET"].Visible = false;
                if (PR.LR | PR.WR)
                {
                    this.GV.Columns["InvSaleTotalAmount"].Visible = true;
                    this.GV.Columns["InvSaleDisMaWi"].Visible = true;
                    this.GV.Columns["InvSaleDisVal"].Visible = true;
                    this.GV.Columns["InvSaleDarMiWi"].Visible = true;
                    this.GV.Columns["InvSaleTotalNET"].Visible = true;
                }
                this.GV.Columns["InvSaleTotalProft"].Visible = false;
                this.GV.Columns["InvSaleMonBas"].Visible = false;
                this.GV.Columns["InvSaleMonPay"].Visible = false;
                this.GV.Columns["InvSaleMonBak"].Visible = false;
                this.GV.Columns["InvSaleMonDem"].Visible = false;
                this.GV.Columns["InvSaleMonRod"].Visible = false;
                this.GV.Columns["InvSaleIsMonRod"].Visible = false;
                this.GV.Columns["InvSaleNote"].HeaderText = "ملاحظات";
                this.GV.Columns["InvSaleUserAddBy"].HeaderText = "الموظف";
                this.GV.Columns["InvSaleOtherCuru"].Visible = false;
                this.GV.Columns["InvSaleCafeTyp"].Visible = false;
                this.GV.Columns["InvSaleCafeTablID"].Visible = false;
                this.GV.Columns["InvSaleCafeText"].HeaderText = "نوع البيع";
                this.GV.Columns["InvSaleIsCashCount"].HeaderText = "مقيدة على الكاش";
                this.GV.Columns["InvSaleCusLastBalance"].Visible = false;
                this.GV.Columns["InvSaleCusOrdarNo"].HeaderText = "رقم الطلب";
                this.GV.Columns["CustomerName"].HeaderText = "العميل";
                this.GV.Columns["InvSaleQR"].Visible = false;
                this.GV.Columns["Taxabl"].Visible = false;
                this.GV.Columns["UUID"].Visible = false;
                this.GV.Columns["HashQR"].Visible = false;
                this.GV.Columns["ReID"].Visible = false;
                this.GV.Columns["ReHashQR"].Visible = false;
                if (!PR.O)
                {
                    this.GV.Columns["InvSaleCafeText"].Visible = false;
                    this.GV.Columns["InvSaleCusOrdarNo"].Visible = false;
                }
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.ToolStripButtonCard.Enabled = this.GV.RowCount > 0;
                this.TxTGVRowCount.Text = Conversions.ToString(this.GV.RowCount);
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = this.GV.RowCount;
                this.ToolStripProgressBar1.Minimum = 0;
                try
                {
                    enumerator = ((IEnumerable) this.GV.Rows).GetEnumerator();
                    while (true)
                    {
                        if (!enumerator.MoveNext())
                        {
                            break;
                        }
                        DataGridViewRow current = (DataGridViewRow) enumerator.Current;
                        this.ToolStripProgressBar1.Value = current.Index;
                        decimal num = new decimal(Conversion.Val(current.Cells["InvSaleTotalAmount"].Value.ToString()));
                        decimal num2 = new decimal(Conversion.Val(current.Cells["InvSaleDisVal"].Value.ToString()));
                        decimal num3 = new decimal(Conversion.Val(current.Cells["InvSaleDarVal"].Value.ToString()));
                        decimal num4 = new decimal(Conversion.Val(current.Cells["InvSaleTotalNET"].Value.ToString()));
                        if (decimal.Compare(num, decimal.Zero) > 0)
                        {
                            current.Cells["InvSaleTotalAmount"].Style.ForeColor = Color.Blue;
                        }
                        else if (decimal.Compare(num, decimal.Zero) < 0)
                        {
                            current.Cells["InvSaleTotalAmount"].Style.ForeColor = Color.Red;
                        }
                        current.Cells["InvSaleTotalAmount"].Value = num.ToString(PR.YR);
                        if (decimal.Compare(num2, decimal.Zero) > 0)
                        {
                            current.Cells["InvSaleDisVal"].Style.ForeColor = Color.Blue;
                        }
                        else if (decimal.Compare(num2, decimal.Zero) < 0)
                        {
                            current.Cells["InvSaleDisVal"].Style.ForeColor = Color.Red;
                        }
                        current.Cells["InvSaleDisVal"].Value = num2.ToString(PR.YR);
                        if (decimal.Compare(num3, decimal.Zero) > 0)
                        {
                            current.Cells["InvSaleDarVal"].Style.ForeColor = Color.Blue;
                        }
                        else if (decimal.Compare(num3, decimal.Zero) < 0)
                        {
                            current.Cells["InvSaleDarVal"].Style.ForeColor = Color.Red;
                        }
                        current.Cells["InvSaleDarVal"].Value = num3.ToString(PR.YR);
                        if (decimal.Compare(num4, decimal.Zero) > 0)
                        {
                            current.Cells["InvSaleTotalNET"].Style.ForeColor = Color.Blue;
                        }
                        else if (decimal.Compare(num4, decimal.Zero) < 0)
                        {
                            current.Cells["InvSaleTotalNET"].Style.ForeColor = Color.Red;
                        }
                        current.Cells["InvSaleTotalNET"].Value = num4.ToString(PR.YR);
                        decimal num5 = new decimal(Conversion.Val(current.Cells["InvSaleType"].Value.ToString()));
                        decimal num6 = new decimal(Conversion.Val(current.Cells["InvSaleStatus"].Value.ToString()));
                        decimal num7 = new decimal(Conversion.Val(current.Cells["InvSalePayType"].Value.ToString()));
                        if (decimal.Compare(num5, decimal.Zero) == 0)
                        {
                            current.Cells["InvSaleType"].Value = "فاتورة مبيعات";
                        }
                        else if (decimal.Compare(num5, decimal.One) == 0)
                        {
                            current.Cells["InvSaleType"].Value = "مرتجع مبيعات";
                        }
                        if (decimal.Compare(num7, decimal.Zero) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "نقدا";
                        }
                        else if (decimal.Compare(num7, decimal.One) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "ذمم";
                        }
                        else if (decimal.Compare(num7, 2M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "شبكة";
                        }
                        else if (decimal.Compare(num7, 3M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "تحويل";
                        }
                        else if (decimal.Compare(num7, 4M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "الرصيد المدور";
                        }
                        else if (decimal.Compare(num7, 5M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "شيك";
                        }
                        else if (decimal.Compare(num7, 6M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "إئتمان";
                        }
                        if (decimal.Compare(num6, decimal.Zero) == 0)
                        {
                            current.Cells["InvSaleStatus"].Value = "مكتملة";
                        }
                        else if (decimal.Compare(num6, decimal.One) == 0)
                        {
                            current.Cells["InvSaleStatus"].Value = "معلقة";
                        }
                        else if (decimal.Compare(num6, 2M) == 0)
                        {
                            current.Cells["InvSaleStatus"].Value = "قيد التعديل";
                        }
                        else if (decimal.Compare(num6, 3M) == 0)
                        {
                            current.Cells["InvSaleStatus"].Value = "معدلة";
                        }
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                this.ToolStripProgressBar1.Visible = false;
                this.CheckBoxDate.ForeColor = Color.Black;
                this.TxTTitle.Text = this.Text;
                this.TxTTitle.ForeColor = Color.DarkGreen;
                this.TxTTitle.Font = new Font("Tahoma", 12f);
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
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
        }

        private void Q(object A, EventArgs R)
        {
            NF.R = NF.A;
            if (this.CheckBoxDate.Checked)
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                NF.R = NF.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT)";
            }
            this.TimerLoadData.Enabled = true;
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
                this.ComboBoxUser.Text = A.D.A.A.TxTUserName.Text;
                this.ComboBoxUser.Enabled = PR.LR;
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
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerLoadData.Enabled = true;
        }

        private void T(object A, EventArgs R)
        {
            NF.R = NF.A;
            if (this.CheckBoxDate.Checked)
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                NF.R = NF.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT)";
            }
            NF.R = NF.A + " AND (TaNNInvSale.InvSaleIDMAX BETWEEN @MAXDF and @MAXDT)";
            this.TimerLoadData.Enabled = true;
        }

        private void U(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.F();
            }
        }

        private void V(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.X();
            }
        }

        private void X(object A, EventArgs R)
        {
            NF.R = NF.A;
            if (this.CheckBoxDate.Checked)
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                NF.R = NF.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT)";
            }
            NF.R = NF.A + " AND (TaNNInvSale.InvSaleID = @InvSaleID)";
            this.TimerLoadData.Enabled = true;
        }

        private void Y(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.G();
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

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox InvSaleType
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonSortDate
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

        internal virtual TabPage TabPage2
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTMaxSerch1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonBetwenMax
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button SBBButtonBarCode
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual TextBox SBBTxTBarCode
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual PictureBox PictureBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxDate
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

        internal virtual ToolStripButton ToolStripButtonViewAll
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual ToolStripSeparator ToolStripSeparator8
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ToolStripButtonCard
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual ToolStripSeparator ToolStripSeparator5
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripButton ToolStripButtonClose
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                ToolStripButton p = this.P;
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

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Timer TimerLoadData
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

        internal virtual Timer TimersStartUp
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                DataGridViewCellEventHandler handler = new DataGridViewCellEventHandler(this.A);
                DataGridViewDataErrorEventHandler handler2 = new DataGridViewDataErrorEventHandler(this.A);
                DataGridView a = this.A;
                if (a != null)
                {
                    a.CellContentClick -= handler;
                    a.DataError -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.CellContentClick += handler;
                    a.DataError += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ComboBox ComboBoxUser
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual ToolStripSplitButton A4ToolStripMenuItemInvos
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem ButPrintArA4ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                ToolStripMenuItem a = this.A;
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

        internal virtual ToolStripMenuItem ButPrintArA5ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                ToolStripMenuItem r = this.R;
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

        internal virtual ToolStripMenuItem ButPrintArRoll80ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                ToolStripMenuItem p = this.P;
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

        internal virtual ToolStripMenuItem ButPrinteEnA4ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
                ToolStripMenuItem q = this.Q;
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

        internal virtual ToolStripMenuItem ButPrintEnA5ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
                ToolStripMenuItem i = this.I;
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

        internal virtual ToolStripMenuItem ButPrintEnRoll80ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
                ToolStripMenuItem d = this.D;
                if (d != null)
                {
                    d.Click -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.Click += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual ToolStripMenuItem ButPrintTAXAR
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
                ToolStripMenuItem f = this.F;
                if (f != null)
                {
                    f.Click -= handler;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem ButPrintTAXEN
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
                ToolStripMenuItem h = this.H;
                if (h != null)
                {
                    h.Click -= handler;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.Click += handler;
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

