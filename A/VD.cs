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
    public class VD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [CompilerGenerated, AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("HSaleType"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("ButtonSortDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox5"), CompilerGenerated]
        private GroupBox R;
        [CompilerGenerated, AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1"), CompilerGenerated]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("TxTMaxSerch2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("TxTMaxSerch1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("ButtonBetwenMax"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("GroupBox4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [CompilerGenerated, AccessedThroughProperty("SBBButtonBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [CompilerGenerated, AccessedThroughProperty("SBBTxTBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [AccessedThroughProperty("PictureBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PictureBox A;
        [CompilerGenerated, AccessedThroughProperty("TabPage3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [AccessedThroughProperty("ButtonCustomer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button Q;
        [AccessedThroughProperty("GroupBox6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("ComboBoxCustomer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [AccessedThroughProperty("TabPage4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage Q;
        [AccessedThroughProperty("ButtonUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button I;
        [AccessedThroughProperty("GroupBoxUsers"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("ComboBoxUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox P;
        [CompilerGenerated, AccessedThroughProperty("TabPage5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage I;
        [CompilerGenerated, AccessedThroughProperty("ButtonNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button D;
        [AccessedThroughProperty("GroupBox3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("TxTNoSe"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [AccessedThroughProperty("CheckBoxDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("Panel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel A;
        [AccessedThroughProperty("GroupBox14"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [AccessedThroughProperty("TxTNetTotal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [AccessedThroughProperty("GroupBox13"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [CompilerGenerated, AccessedThroughProperty("TxTTotalProft"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label I;
        [CompilerGenerated, AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [CompilerGenerated, AccessedThroughProperty("TxTTotalDar"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [CompilerGenerated, AccessedThroughProperty("GroupBox11"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox X;
        [AccessedThroughProperty("TxTTotalDis"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        [CompilerGenerated, AccessedThroughProperty("GroupBox10"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTotalTotal"), CompilerGenerated]
        private Label H;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonViewAll"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonPrint"), CompilerGenerated]
        private ToolStripButton R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonClose"), CompilerGenerated]
        private ToolStripButton P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("ToolStripLabel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel A;
        [CompilerGenerated, AccessedThroughProperty("TxTGVRowCount"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated]
        private ToolStripSeparator Q;
        [CompilerGenerated, AccessedThroughProperty("TabPage8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage D;
        [AccessedThroughProperty("TabPage9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage F;
        [AccessedThroughProperty("TabPage10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage H;
        [AccessedThroughProperty("GV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [CompilerGenerated, AccessedThroughProperty("TimerLoadData"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [CompilerGenerated, AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [CompilerGenerated, AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [AccessedThroughProperty("ButtonGrop"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox7"), CompilerGenerated]
        private GroupBox E;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxGrop"), CompilerGenerated]
        private ComboBox Q;
        [AccessedThroughProperty("ButtonMaterialBarcode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button H;
        [AccessedThroughProperty("GroupBox15"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [CompilerGenerated, AccessedThroughProperty("TxTMaterialBarcode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [CompilerGenerated, AccessedThroughProperty("ButtonMaterialName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox8")]
        private GroupBox U;
        [AccessedThroughProperty("TxTMaterialName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox D;
        [AccessedThroughProperty("GroupBox16"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox L;
        [AccessedThroughProperty("TxTTotalQu"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label T;
        [AccessedThroughProperty("ToolStripSeparator2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator I;
        [AccessedThroughProperty("ToolStripButtonOKReturn"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton Q;
        [AccessedThroughProperty("ButtonAdvance"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button X;
        [AccessedThroughProperty("ContextMenuStripCopyClipBoard"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ContextMenuStrip A;
        [AccessedThroughProperty("CopytoClipToolStripMenuItemToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("Label3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label X;
        [AccessedThroughProperty("ButtonAdVSort"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button G;
        [AccessedThroughProperty("GroupBox1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox N;
        [AccessedThroughProperty("DateTimePickerFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker R;
        [AccessedThroughProperty("GroupBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox V;
        [AccessedThroughProperty("DateTimePickerTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker P;
        [AccessedThroughProperty("PickerTimeTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker Q;
        private SqlConnection A;
        private int A;
        private DataTable A;
        private DataTable R;
        public static string A = "SELECT TaNNInvSaleItems.*, TaNNCustomers.CustomerName FROM TaNNInvSaleItems LEFT OUTER JOIN TaNNCustomers ON TaNNInvSaleItems.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSaleItems.CenterFrontID = @CenterFrontID) AND (TaNNInvSaleItems.HSaleType = @HSaleType)";
        public static string R = "";
        public static string P;
        public static string Q;
        public static string I;
        public static int R = 0;

        public VD()
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
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.ButtonAdvance = new Button();
            this.GroupBox9 = new GroupBox();
            this.HSaleType = new ComboBox();
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
            this.TabPage8 = new TabPage();
            this.ButtonMaterialBarcode = new Button();
            this.GroupBox15 = new GroupBox();
            this.TxTMaterialBarcode = new TextBox();
            this.TabPage9 = new TabPage();
            this.ButtonMaterialName = new Button();
            this.GroupBox8 = new GroupBox();
            this.TxTMaterialName = new TextBox();
            this.TabPage10 = new TabPage();
            this.ButtonGrop = new Button();
            this.GroupBox7 = new GroupBox();
            this.ComboBoxGrop = new ComboBox();
            this.TabPage3 = new TabPage();
            this.ButtonAdVSort = new Button();
            this.Label3 = new Label();
            this.ButtonCustomer = new Button();
            this.GroupBox6 = new GroupBox();
            this.ComboBoxCustomer = new ComboBox();
            this.TabPage4 = new TabPage();
            this.ButtonUser = new Button();
            this.GroupBoxUsers = new GroupBox();
            this.ComboBoxUser = new ComboBox();
            this.TabPage5 = new TabPage();
            this.ButtonNote = new Button();
            this.GroupBox3 = new GroupBox();
            this.TxTNoSe = new TextBox();
            this.CheckBoxDate = new CheckBox();
            this.Panel1 = new Panel();
            this.GroupBox16 = new GroupBox();
            this.TxTTotalQu = new Label();
            this.GroupBox14 = new GroupBox();
            this.TxTNetTotal = new Label();
            this.GroupBox13 = new GroupBox();
            this.TxTTotalProft = new Label();
            this.GroupBox12 = new GroupBox();
            this.TxTTotalDar = new Label();
            this.GroupBox11 = new GroupBox();
            this.TxTTotalDis = new Label();
            this.GroupBox10 = new GroupBox();
            this.TxTTotalTotal = new Label();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripButtonOKReturn = new ToolStripButton();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ToolStripButtonPrint = new ToolStripButton();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowCount = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.GV = new DataGridView();
            this.ContextMenuStripCopyClipBoard = new ContextMenuStrip(this.A);
            this.CopytoClipToolStripMenuItemToolStripMenuItem = new ToolStripMenuItem();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TimerFillGV = new Timer(this.A);
            this.GroupBox1 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBox2 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            this.TabPage8.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.TabPage9.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.TabPage10.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBoxUsers.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.ContextMenuStripCopyClipBoard.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x436, 0x22);
            this.TxTTitle.TabIndex = 110;
            this.TxTTitle.Text = "سجل المبيعات/ مرتجع المبيعات حسب المادة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage8);
            this.TabControl1.Controls.Add(this.TabPage9);
            this.TabControl1.Controls.Add(this.TabPage10);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x436, 0x81);
            this.TabControl1.TabIndex = 0x6f;
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.ButtonAdvance);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.ButtonSortDate);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x42e, 100);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الرئيسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtonAdvance.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdvance.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdvance.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdvance.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdvance.FlatStyle = FlatStyle.Flat;
            this.ButtonAdvance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdvance.Image = A.F.ImSort;
            this.ButtonAdvance.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdvance.Location = new Point(0x12, 0x17);
            this.ButtonAdvance.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdvance.Name = "ButtonAdvance";
            this.ButtonAdvance.Size = new Size(0xc0, 0x35);
            this.ButtonAdvance.TabIndex = 0x1ed36cd;
            this.ButtonAdvance.Text = "فرز متقدم";
            this.ButtonAdvance.UseVisualStyleBackColor = true;
            this.GroupBox9.Controls.Add(this.HSaleType);
            this.GroupBox9.Location = new Point(800, 8);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0xfd, 0x35);
            this.GroupBox9.TabIndex = 0x1ed36cc;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "نوع الفاتورة";
            this.HSaleType.Dock = DockStyle.Fill;
            this.HSaleType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.HSaleType.FormattingEnabled = true;
            object[] items = new object[] { "فاتورة مبيعات", "فاتورة مرتجع مبيعات" };
            this.HSaleType.Items.AddRange(items);
            this.HSaleType.Location = new Point(3, 0x13);
            this.HSaleType.Name = "HSaleType";
            this.HSaleType.Size = new Size(0xf7, 0x18);
            this.HSaleType.TabIndex = 0x2c;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(0xd8, 0x17);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(0xb0, 0x36);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.GroupBox5);
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x42e, 100);
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
            this.TabPage8.Controls.Add(this.ButtonMaterialBarcode);
            this.TabPage8.Controls.Add(this.GroupBox15);
            this.TabPage8.Location = new Point(4, 0x19);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Size = new Size(0x42e, 100);
            this.TabPage8.TabIndex = 6;
            this.TabPage8.Text = "فرز حسب رقم/باركود المادة";
            this.TabPage8.UseVisualStyleBackColor = true;
            this.ButtonMaterialBarcode.FlatAppearance.BorderColor = Color.Green;
            this.ButtonMaterialBarcode.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonMaterialBarcode.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonMaterialBarcode.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonMaterialBarcode.FlatStyle = FlatStyle.Flat;
            this.ButtonMaterialBarcode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonMaterialBarcode.Image = A.F.ImSort;
            this.ButtonMaterialBarcode.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonMaterialBarcode.Location = new Point(190, 0x12);
            this.ButtonMaterialBarcode.Margin = new Padding(3, 4, 3, 4);
            this.ButtonMaterialBarcode.Name = "ButtonMaterialBarcode";
            this.ButtonMaterialBarcode.Size = new Size(280, 0x2c);
            this.ButtonMaterialBarcode.TabIndex = 0x1ed36d0;
            this.ButtonMaterialBarcode.Text = "فرز";
            this.ButtonMaterialBarcode.UseVisualStyleBackColor = true;
            this.GroupBox15.Controls.Add(this.TxTMaterialBarcode);
            this.GroupBox15.Location = new Point(0x1ec, 10);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(360, 0x34);
            this.GroupBox15.TabIndex = 0x1ed36cf;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "رقم/ باركود المادة";
            this.TxTMaterialBarcode.BackColor = SystemColors.Info;
            this.TxTMaterialBarcode.Dock = DockStyle.Fill;
            this.TxTMaterialBarcode.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMaterialBarcode.Location = new Point(3, 0x13);
            this.TxTMaterialBarcode.Name = "TxTMaterialBarcode";
            this.TxTMaterialBarcode.RightToLeft = RightToLeft.No;
            this.TxTMaterialBarcode.Size = new Size(0x162, 0x1b);
            this.TxTMaterialBarcode.TabIndex = 0x1ed36cc;
            this.TxTMaterialBarcode.TextAlign = HorizontalAlignment.Center;
            this.TabPage9.Controls.Add(this.ButtonMaterialName);
            this.TabPage9.Controls.Add(this.GroupBox8);
            this.TabPage9.Location = new Point(4, 0x19);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Size = new Size(0x42e, 100);
            this.TabPage9.TabIndex = 7;
            this.TabPage9.Text = "فرز حسب اسم المادة";
            this.TabPage9.UseVisualStyleBackColor = true;
            this.ButtonMaterialName.FlatAppearance.BorderColor = Color.Green;
            this.ButtonMaterialName.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonMaterialName.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonMaterialName.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonMaterialName.FlatStyle = FlatStyle.Flat;
            this.ButtonMaterialName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonMaterialName.Image = A.F.ImSort;
            this.ButtonMaterialName.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonMaterialName.Location = new Point(190, 0x12);
            this.ButtonMaterialName.Margin = new Padding(3, 4, 3, 4);
            this.ButtonMaterialName.Name = "ButtonMaterialName";
            this.ButtonMaterialName.Size = new Size(280, 0x2c);
            this.ButtonMaterialName.TabIndex = 0x1ed36d0;
            this.ButtonMaterialName.Text = "فرز";
            this.ButtonMaterialName.UseVisualStyleBackColor = true;
            this.GroupBox8.Controls.Add(this.TxTMaterialName);
            this.GroupBox8.Location = new Point(0x1ec, 10);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(360, 0x34);
            this.GroupBox8.TabIndex = 0x1ed36cf;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "اسم المادة";
            this.TxTMaterialName.BackColor = SystemColors.Info;
            this.TxTMaterialName.Dock = DockStyle.Fill;
            this.TxTMaterialName.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMaterialName.Location = new Point(3, 0x13);
            this.TxTMaterialName.Name = "TxTMaterialName";
            this.TxTMaterialName.RightToLeft = RightToLeft.No;
            this.TxTMaterialName.Size = new Size(0x162, 0x1b);
            this.TxTMaterialName.TabIndex = 0x1ed36cc;
            this.TxTMaterialName.TextAlign = HorizontalAlignment.Center;
            this.TabPage10.Controls.Add(this.ButtonGrop);
            this.TabPage10.Controls.Add(this.GroupBox7);
            this.TabPage10.Location = new Point(4, 0x19);
            this.TabPage10.Name = "TabPage10";
            this.TabPage10.Size = new Size(0x42e, 100);
            this.TabPage10.TabIndex = 8;
            this.TabPage10.Text = "فرز حسب المجموعة";
            this.TabPage10.UseVisualStyleBackColor = true;
            this.ButtonGrop.FlatAppearance.BorderColor = Color.Green;
            this.ButtonGrop.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonGrop.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonGrop.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonGrop.FlatStyle = FlatStyle.Flat;
            this.ButtonGrop.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonGrop.Image = A.F.ImSort;
            this.ButtonGrop.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonGrop.Location = new Point(0xa1, 0x11);
            this.ButtonGrop.Margin = new Padding(3, 4, 3, 4);
            this.ButtonGrop.Name = "ButtonGrop";
            this.ButtonGrop.Size = new Size(280, 0x2c);
            this.ButtonGrop.TabIndex = 0x48;
            this.ButtonGrop.Text = "فرز";
            this.ButtonGrop.UseVisualStyleBackColor = true;
            this.GroupBox7.Controls.Add(this.ComboBoxGrop);
            this.GroupBox7.Location = new Point(0x1bf, 9);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x1b2, 0x36);
            this.GroupBox7.TabIndex = 0x47;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "المجموعة";
            this.ComboBoxGrop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxGrop.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxGrop.Dock = DockStyle.Fill;
            this.ComboBoxGrop.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxGrop.FormattingEnabled = true;
            this.ComboBoxGrop.IntegralHeight = false;
            this.ComboBoxGrop.Location = new Point(3, 0x13);
            this.ComboBoxGrop.Name = "ComboBoxGrop";
            this.ComboBoxGrop.Size = new Size(0x1ac, 0x18);
            this.ComboBoxGrop.TabIndex = 0x44;
            this.TabPage3.Controls.Add(this.ButtonAdVSort);
            this.TabPage3.Controls.Add(this.Label3);
            this.TabPage3.Controls.Add(this.ButtonCustomer);
            this.TabPage3.Controls.Add(this.GroupBox6);
            this.TabPage3.Location = new Point(4, 0x19);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x42e, 100);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "فرز حسب العميل";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.ButtonAdVSort.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdVSort.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdVSort.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdVSort.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdVSort.FlatStyle = FlatStyle.Flat;
            this.ButtonAdVSort.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdVSort.Image = A.F.ImSort;
            this.ButtonAdVSort.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdVSort.Location = new Point(0x17f, 14);
            this.ButtonAdVSort.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdVSort.Name = "ButtonAdVSort";
            this.ButtonAdVSort.Size = new Size(0x97, 0x2c);
            this.ButtonAdVSort.TabIndex = 0x49;
            this.ButtonAdVSort.Text = "فرز متقدم";
            this.ButtonAdVSort.UseVisualStyleBackColor = true;
            this.Label3.Dock = DockStyle.Left;
            this.Label3.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label3.Location = new Point(0, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x161, 100);
            this.Label3.TabIndex = 0x48;
            this.Label3.Text = "*ملاحظة: الفواتير التي تم بيعها للعميل من خلال الفروع الآخرى لن يتم فرزها في قائمة الفرع الحالي.";
            this.Label3.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonCustomer.FlatAppearance.BorderColor = Color.Green;
            this.ButtonCustomer.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonCustomer.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonCustomer.FlatStyle = FlatStyle.Flat;
            this.ButtonCustomer.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonCustomer.Image = A.F.ImSort;
            this.ButtonCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCustomer.Location = new Point(540, 14);
            this.ButtonCustomer.Margin = new Padding(3, 4, 3, 4);
            this.ButtonCustomer.Name = "ButtonCustomer";
            this.ButtonCustomer.Size = new Size(0xb5, 0x2c);
            this.ButtonCustomer.TabIndex = 70;
            this.ButtonCustomer.Text = "فرز";
            this.ButtonCustomer.UseVisualStyleBackColor = true;
            this.GroupBox6.Controls.Add(this.ComboBoxCustomer);
            this.GroupBox6.Location = new Point(0x2d7, 7);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x146, 0x36);
            this.GroupBox6.TabIndex = 0x45;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "العميل";
            this.ComboBoxCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxCustomer.Dock = DockStyle.Fill;
            this.ComboBoxCustomer.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxCustomer.FormattingEnabled = true;
            this.ComboBoxCustomer.IntegralHeight = false;
            this.ComboBoxCustomer.Location = new Point(3, 0x13);
            this.ComboBoxCustomer.Name = "ComboBoxCustomer";
            this.ComboBoxCustomer.Size = new Size(320, 0x18);
            this.ComboBoxCustomer.TabIndex = 0x44;
            this.TabPage4.Controls.Add(this.ButtonUser);
            this.TabPage4.Controls.Add(this.GroupBoxUsers);
            this.TabPage4.Location = new Point(4, 0x19);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x42e, 100);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "فرز حسب الموظف";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.ButtonUser.FlatAppearance.BorderColor = Color.Green;
            this.ButtonUser.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonUser.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonUser.FlatStyle = FlatStyle.Flat;
            this.ButtonUser.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonUser.Image = A.F.ImSort;
            this.ButtonUser.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonUser.Location = new Point(0x155, 0x11);
            this.ButtonUser.Margin = new Padding(3, 4, 3, 4);
            this.ButtonUser.Name = "ButtonUser";
            this.ButtonUser.Size = new Size(280, 0x2c);
            this.ButtonUser.TabIndex = 0x72;
            this.ButtonUser.Text = "فرز";
            this.ButtonUser.UseVisualStyleBackColor = true;
            this.GroupBoxUsers.Controls.Add(this.ComboBoxUser);
            this.GroupBoxUsers.Location = new Point(0x273, 8);
            this.GroupBoxUsers.Name = "GroupBoxUsers";
            this.GroupBoxUsers.Size = new Size(0x155, 0x35);
            this.GroupBoxUsers.TabIndex = 0x71;
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
            this.ComboBoxUser.Size = new Size(0x14f, 0x1b);
            this.ComboBoxUser.TabIndex = 0x3b;
            this.TabPage5.Controls.Add(this.ButtonNote);
            this.TabPage5.Controls.Add(this.GroupBox3);
            this.TabPage5.Location = new Point(4, 0x19);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new Size(0x42e, 100);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "البحث في الملاحظات";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.ButtonNote.FlatAppearance.BorderColor = Color.Green;
            this.ButtonNote.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonNote.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonNote.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonNote.FlatStyle = FlatStyle.Flat;
            this.ButtonNote.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonNote.Image = A.F.ImSort;
            this.ButtonNote.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonNote.Location = new Point(0x124, 0x15);
            this.ButtonNote.Margin = new Padding(3, 4, 3, 4);
            this.ButtonNote.Name = "ButtonNote";
            this.ButtonNote.Size = new Size(280, 0x2c);
            this.ButtonNote.TabIndex = 0x1ed36ce;
            this.ButtonNote.Text = "فرز";
            this.ButtonNote.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.TxTNoSe);
            this.GroupBox3.Location = new Point(0x252, 13);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(360, 0x34);
            this.GroupBox3.TabIndex = 0x1ed36cd;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الملاحظات";
            this.TxTNoSe.BackColor = SystemColors.Info;
            this.TxTNoSe.Dock = DockStyle.Fill;
            this.TxTNoSe.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTNoSe.Location = new Point(3, 0x13);
            this.TxTNoSe.Name = "TxTNoSe";
            this.TxTNoSe.RightToLeft = RightToLeft.No;
            this.TxTNoSe.Size = new Size(0x162, 0x1b);
            this.TxTNoSe.TabIndex = 0x1ed36cc;
            this.TxTNoSe.TextAlign = HorizontalAlignment.Center;
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxDate.Checked = true;
            this.CheckBoxDate.CheckState = CheckState.Checked;
            this.CheckBoxDate.Dock = DockStyle.Top;
            this.CheckBoxDate.Location = new Point(0, 0xa3);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Padding = new Padding(4);
            this.CheckBoxDate.Size = new Size(0x436, 0x1c);
            this.CheckBoxDate.TabIndex = 0x1ed36cc;
            this.CheckBoxDate.Text = "تضمين فترة التاريخ دائماً مع كل عمليات الفرز";
            this.CheckBoxDate.UseVisualStyleBackColor = false;
            this.Panel1.BackColor = SystemColors.HighlightText;
            this.Panel1.BorderStyle = BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox16);
            this.Panel1.Controls.Add(this.GroupBox14);
            this.Panel1.Controls.Add(this.GroupBox13);
            this.Panel1.Controls.Add(this.GroupBox12);
            this.Panel1.Controls.Add(this.GroupBox11);
            this.Panel1.Controls.Add(this.GroupBox10);
            this.Panel1.Dock = DockStyle.Bottom;
            this.Panel1.Location = new Point(0, 0x213);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x436, 0x3a);
            this.Panel1.TabIndex = 0x1ed36cf;
            this.GroupBox16.Controls.Add(this.TxTTotalQu);
            this.GroupBox16.Dock = DockStyle.Right;
            this.GroupBox16.Location = new Point(0x72, 0);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(160, 0x36);
            this.GroupBox16.TabIndex = 6;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "مجموع الكمية";
            this.TxTTotalQu.Dock = DockStyle.Fill;
            this.TxTTotalQu.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalQu.Location = new Point(3, 0x13);
            this.TxTTotalQu.Name = "TxTTotalQu";
            this.TxTTotalQu.Size = new Size(0x9a, 0x20);
            this.TxTTotalQu.TabIndex = 0;
            this.TxTTotalQu.Text = "0";
            this.TxTTotalQu.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox14.Controls.Add(this.TxTNetTotal);
            this.GroupBox14.Dock = DockStyle.Right;
            this.GroupBox14.Location = new Point(0x112, 0);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(160, 0x36);
            this.GroupBox14.TabIndex = 4;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "صافي المجموع";
            this.TxTNetTotal.Dock = DockStyle.Fill;
            this.TxTNetTotal.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTNetTotal.Location = new Point(3, 0x13);
            this.TxTNetTotal.Name = "TxTNetTotal";
            this.TxTNetTotal.Size = new Size(0x9a, 0x20);
            this.TxTNetTotal.TabIndex = 0;
            this.TxTNetTotal.Text = "0";
            this.TxTNetTotal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox13.Controls.Add(this.TxTTotalProft);
            this.GroupBox13.Dock = DockStyle.Right;
            this.GroupBox13.Location = new Point(0x1b2, 0);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(160, 0x36);
            this.GroupBox13.TabIndex = 3;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "مجموع الربح";
            this.TxTTotalProft.Dock = DockStyle.Fill;
            this.TxTTotalProft.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalProft.Location = new Point(3, 0x13);
            this.TxTTotalProft.Name = "TxTTotalProft";
            this.TxTTotalProft.Size = new Size(0x9a, 0x20);
            this.TxTTotalProft.TabIndex = 0;
            this.TxTTotalProft.Text = "0";
            this.TxTTotalProft.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox12.Controls.Add(this.TxTTotalDar);
            this.GroupBox12.Dock = DockStyle.Right;
            this.GroupBox12.Location = new Point(0x252, 0);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(160, 0x36);
            this.GroupBox12.TabIndex = 2;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "مجموع الضريبة";
            this.TxTTotalDar.Dock = DockStyle.Fill;
            this.TxTTotalDar.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalDar.Location = new Point(3, 0x13);
            this.TxTTotalDar.Name = "TxTTotalDar";
            this.TxTTotalDar.Size = new Size(0x9a, 0x20);
            this.TxTTotalDar.TabIndex = 0;
            this.TxTTotalDar.Text = "0";
            this.TxTTotalDar.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox11.Controls.Add(this.TxTTotalDis);
            this.GroupBox11.Dock = DockStyle.Right;
            this.GroupBox11.Location = new Point(0x2f2, 0);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(160, 0x36);
            this.GroupBox11.TabIndex = 1;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "مجموع الخصم";
            this.TxTTotalDis.Dock = DockStyle.Fill;
            this.TxTTotalDis.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalDis.Location = new Point(3, 0x13);
            this.TxTTotalDis.Name = "TxTTotalDis";
            this.TxTTotalDis.Size = new Size(0x9a, 0x20);
            this.TxTTotalDis.TabIndex = 0;
            this.TxTTotalDis.Text = "0";
            this.TxTTotalDis.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox10.Controls.Add(this.TxTTotalTotal);
            this.GroupBox10.Dock = DockStyle.Right;
            this.GroupBox10.Location = new Point(0x392, 0);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(160, 0x36);
            this.GroupBox10.TabIndex = 0;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "المجموع الفرعي";
            this.TxTTotalTotal.Dock = DockStyle.Fill;
            this.TxTTotalTotal.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalTotal.Location = new Point(3, 0x13);
            this.TxTTotalTotal.Name = "TxTTotalTotal";
            this.TxTTotalTotal.Size = new Size(0x9a, 0x20);
            this.TxTTotalTotal.TabIndex = 0;
            this.TxTTotalTotal.Text = "0";
            this.TxTTotalTotal.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonViewAll, this.ToolStripSeparator2, this.ToolStripButtonOKReturn, this.ToolStripSeparator8, this.ToolStripButtonPrint, this.ToolStripSeparator6, this.ToolStripButtonClose, this.ToolStripSeparator7 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x24d);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x436, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36ce;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
            this.ToolStripButtonOKReturn.Image = A.F.ImOK;
            this.ToolStripButtonOKReturn.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonOKReturn.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonOKReturn.Name = "ToolStripButtonOKReturn";
            this.ToolStripButtonOKReturn.Size = new Size(0x4d, 0x2c);
            this.ToolStripButtonOKReturn.Text = "موافق";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(6, 0x2f);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x60, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة A4";
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
            this.ToolStripStatus.Size = new Size(0x436, 0x19);
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
            this.GV.ContextMenuStrip = this.ContextMenuStripCopyClipBoard;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Window;
            style.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.ControlText;
            style.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style.SelectionForeColor = Color.Black;
            style.WrapMode = DataGridViewTriState.False;
            this.GV.DefaultCellStyle = style;
            this.GV.Dock = DockStyle.Fill;
            this.GV.Location = new Point(0, 0xbf);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x436, 340);
            this.GV.TabIndex = 0x1ed36d0;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.CopytoClipToolStripMenuItemToolStripMenuItem };
            this.ContextMenuStripCopyClipBoard.Items.AddRange(itemArray3);
            this.ContextMenuStripCopyClipBoard.Name = "ContextMenuStripCopyClipBoard";
            this.ContextMenuStripCopyClipBoard.RightToLeft = RightToLeft.Yes;
            this.ContextMenuStripCopyClipBoard.Size = new Size(0xaf, 0x1a);
            this.CopytoClipToolStripMenuItemToolStripMenuItem.Name = "CopytoClipToolStripMenuItemToolStripMenuItem";
            this.CopytoClipToolStripMenuItemToolStripMenuItem.Size = new Size(0xae, 0x16);
            this.CopytoClipToolStripMenuItemToolStripMenuItem.Text = "نسخ القائمة للحافظة";
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x261, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb0, 0x4a);
            this.GroupBox1.TabIndex = 0x1ed36ce;
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
            this.GroupBox2.Location = new Point(0x19d, 8);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xb0, 0x48);
            this.GroupBox2.TabIndex = 0x1ed36cf;
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
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x436, 0x295);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.CheckBoxDate);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "InvoiceSaleItems";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "سجل المبيعات/ مرتجع المبيعات حسب المادة";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((ISupportInitialize) this.PictureBox2).EndInit();
            this.TabPage8.ResumeLayout(false);
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox15.PerformLayout();
            this.TabPage9.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.TabPage10.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.GroupBoxUsers.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            this.ContextMenuStripCopyClipBoard.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
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

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.SBBButtonBarCode.PerformClick();
            }
        }

        private void B(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                SQ sq = new SQ();
                sq.SetDataSource(this.A);
                sq.SetParameterValue("CenterName", PR.ER.ToString());
                sq.SetParameterValue("CenterSubName", PR.KR.ToString());
                sq.SetParameterValue("ParameterDeimelQ", PR.X);
                sq.SetParameterValue("ParameterDeimelS", PR.T);
                sq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                sq.SetParameterValue("RPTitle", this.TxTTitle.Text);
                if (PR.NR == null)
                {
                    sq.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    sq.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                }
                if (PR.UR == null)
                {
                    sq.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    sq.SetParameterValue("CenterPhone", PR.UR.ToString());
                }
                sq.SetParameterValue("XQ", this.TxTTotalQu.Text);
                sq.SetParameterValue("XTotalSub", this.TxTTotalTotal.Text);
                sq.SetParameterValue("XTotalDar", this.TxTTotalDar.Text);
                sq.SetParameterValue("XTotalDis", this.TxTTotalDis.Text);
                sq.SetParameterValue("XNetTotal", this.TxTNetTotal.Text);
                if (PR.C)
                {
                    sq.SetParameterValue("TxTProft", this.TxTTotalProft.Text);
                    sq.ReportDefinition.ReportObjects["TextProft"].ObjectFormat.EnableSuppress = false;
                    sq.ReportDefinition.ReportObjects["XProft1"].ObjectFormat.EnableSuppress = false;
                }
                else
                {
                    sq.SetParameterValue("TxTProft", "مخفي");
                    sq.ReportDefinition.ReportObjects["TextProft"].ObjectFormat.EnableSuppress = true;
                    sq.ReportDefinition.ReportObjects["XProft1"].ObjectFormat.EnableSuppress = true;
                }
                new HR { CRViewer = { ReportSource = sq } }.ShowDialog();
                sq.Close();
                sq.Dispose();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                A.D.A.A.TxTErorr.Text = ex.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        private void C(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void D(object A, EventArgs R)
        {
            VD.R = VD.A;
            if (this.CheckBoxDate.Checked)
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT)";
            }
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
            VD.R = VD.A;
            if (!this.CheckBoxDate.Checked)
            {
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleName LIKE '%' + @HSaleName + '%')";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSaleItems.HSaleName LIKE '%' + @HSaleName + '%')";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void F(object A, EventArgs R)
        {
            VD.R = VD.A;
            if (!this.CheckBoxDate.Checked)
            {
                VD.R = VD.A + " AND (TaNNInvSaleItems.InvSaleFrontID = @InvSaleFrontID)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSaleItems.InvSaleFrontID = @InvSaleFrontID)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void G(object A, EventArgs R)
        {
            VD.R = VD.A;
            if (!this.CheckBoxDate.Checked)
            {
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleNote LIKE '%' + @HSaleNote + '%')";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSaleItems.HSaleNote LIKE '%' + @HSaleNote + '%')";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void H(object A, EventArgs R)
        {
            VD.R = VD.A;
            if (!this.CheckBoxDate.Checked)
            {
                VD.R = VD.A + " AND (TaNNInvSaleItems.HInvSaleIDMAX BETWEEN @MAXDF and @MAXDT)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSaleItems.HInvSaleIDMAX BETWEEN @MAXDF and @MAXDT)";
            }
            this.TimerLoadData.Enabled = true;
        }

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            P = null;
            Q = null;
            I = null;
            base.Dispose();
        }

        private void K(object A, EventArgs R)
        {
            if (AR.LR && (Strings.Len(this.TxTMaterialBarcode.Text) > 0x10))
            {
                this.TxTMaterialBarcode.Text = Strings.Left(this.TxTMaterialBarcode.Text, 15);
            }
            VD.R = VD.A;
            if (!this.CheckBoxDate.Checked)
            {
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleBarCode = @HSaleBarCode)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSaleItems.HSaleBarCode = @HSaleBarCode)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void L(object A, EventArgs R)
        {
        }

        private void M(object A, EventArgs R)
        {
            this.GV.MultiSelect = true;
            this.GV.SelectAll();
            Clipboard.SetDataObject(this.GV.GetClipboardContent(), true);
            Interaction.MsgBox("تم نسخ القائمة للحافظة", MsgBoxStyle.ApplicationModal, null);
            this.GV.MultiSelect = false;
        }

        private void N(object A, EventArgs R)
        {
        }

        private void O(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else if (Conversions.ToBoolean(this.GV.SelectedRows[0].Cells["HSaleIsDelete"].Value.ToString()))
            {
                Interaction.MsgBox("خطأ يجب تحديد مادة مباعة وليس سجل خصم او ضريبة او عمولة مضافة برمجياً", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable dataTable = new DataTable();
                    string selectCommandText = "SELECT [InvSaleDarMiWi], [InvSaleDisMaWi], [InvSaleDisVal] FROM TaNNInvSale WHERE (InvSaleID = @InvSaleID)";
                    dataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("InvSaleID", this.GV.SelectedRows[0].Cells["InvSaleFrontID"].Value.ToString());
                    adapter.Fill(dataTable);
                    this.A.Close();
                    TextBox box = new TextBox();
                    TextBox box2 = new TextBox();
                    TextBox box3 = new TextBox();
                    if (dataTable.Rows.Count > 0)
                    {
                        box.Text = dataTable.Rows[0]["InvSaleDarMiWi"].ToString();
                        box2.Text = dataTable.Rows[0]["InvSaleDisMaWi"].ToString();
                        box3.Text = dataTable.Rows[0]["InvSaleDisVal"].ToString();
                    }
                    A.D.A.A.InvSaleDarMiWi.Text = box.Text;
                    A.D.A.A.InvSaleDisMaWi.Text = box2.Text;
                    A.D.A.A.InvSaleDisMaWiVAL.Text = box3.Text;
                    A.D.A.A.TxTQuantityName.Text = this.GV.SelectedRows[0].Cells["HSaleQuantity"].Value.ToString();
                    QH.R = this.GV.SelectedRows[0].Cells["HSalePrice"].Value.ToString();
                    A.D.A.A.ComboBoxBarCode.Text = this.GV.SelectedRows[0].Cells["HSaleBarCode"].Value.ToString();
                    A.D.A.A.ButtonSaleCode.PerformClick();
                    base.Dispose();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
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
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            if (VD.R == null)
            {
                VD.R = VD.A;
            }
            this.TimerFillGV.Enabled = true;
        }

        private void P(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonMaterialName.PerformClick();
            }
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
            this.TimerFillGV.Enabled = false;
            this.I();
        }

        private void Q(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonNote.PerformClick();
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
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.R();
            this.P();
            this.Q();
            this.TimerLoadData.Enabled = true;
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonMaterialBarcode.PerformClick();
            }
        }

        private void S(object A, EventArgs R)
        {
            VD.R = VD.A;
            if (!this.CheckBoxDate.Checked)
            {
                VD.R = VD.A + " AND (TaNNInvSaleItems.GroupIDFrontID = @GroupIDFrontID)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSaleItems.GroupIDFrontID = @GroupIDFrontID)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void T(object A, EventArgs R)
        {
            VD.R = VD.A;
            if (!this.CheckBoxDate.Checked)
            {
                VD.R = VD.A + " AND (TaNNInvSaleItems.CustomerFrontID = @CustomerFrontID)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSaleItems.CustomerFrontID = @CustomerFrontID)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void U(object A, EventArgs R)
        {
            VD.R = VD.A;
            this.TimerLoadData.Enabled = true;
        }

        private void V(object A, EventArgs R)
        {
        }

        private void X(object A, EventArgs R)
        {
            VD.R = VD.A;
            if (!this.CheckBoxDate.Checked)
            {
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleUserAddBy = @HSaleUserAddBy)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                VD.R = VD.A + " AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSaleItems.HSaleUserAddBy = @HSaleUserAddBy)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void Y(object A, EventArgs R)
        {
        }

        private void Z(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
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

        internal virtual ComboBox HSaleType
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

        internal virtual TextBox SBBTxTBarCode
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
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

        internal virtual PictureBox PictureBox2
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonCustomer
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

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonUser
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual GroupBox GroupBoxUsers
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Button ButtonNote
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                Button d = this.D;
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox TxTNoSe
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
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

        internal virtual CheckBox CheckBoxDate
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Panel Panel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label TxTNetTotal
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Label TxTTotalProft
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Label TxTTotalDar
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual Label TxTTotalDis
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
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

        internal virtual Label TxTTotalTotal
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual ToolStripButton ToolStripButtonPrint
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.B);
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

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripButton ToolStripButtonClose
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TabPage TabPage8
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TabPage TabPage9
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TabPage TabPage10
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual Button ButtonGrop
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
                Button f = this.F;
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

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual ComboBox ComboBoxGrop
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonMaterialBarcode
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                Button h = this.H;
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

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual TextBox TxTMaterialBarcode
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
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

        internal virtual Button ButtonMaterialName
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                Button t = this.T;
                if (t != null)
                {
                    t.Click -= handler;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.Click += handler;
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

        internal virtual TextBox TxTMaterialName
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
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

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual Label TxTTotalQu
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripButton ToolStripButtonOKReturn
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
                ToolStripButton q = this.Q;
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

        internal virtual Button ButtonAdvance
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Z);
                Button x = this.X;
                if (x != null)
                {
                    x.Click -= handler;
                }
                this.X = value;
                x = this.X;
                if (x != null)
                {
                    x.Click += handler;
                }
            }
        }

        internal virtual ContextMenuStrip ContextMenuStripCopyClipBoard
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem CopytoClipToolStripMenuItemToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.M);
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

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual Button ButtonAdVSort
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.C);
                Button g = this.G;
                if (g != null)
                {
                    g.Click -= handler;
                }
                this.G = value;
                g = this.G;
                if (g != null)
                {
                    g.Click += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
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
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
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

