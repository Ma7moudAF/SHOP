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
    using System.Threading;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class V : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage1"), CompilerGenerated]
        private TabPage A;
        [AccessedThroughProperty("ButtonSortDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("GroupBox1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("DateTimePickerFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DateTimePickerTo"), CompilerGenerated]
        private DateTimePicker R;
        [AccessedThroughProperty("TabPage4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [CompilerGenerated, AccessedThroughProperty("GroupBoxUsers"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxUser"), CompilerGenerated]
        private ComboBox A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripSeparator6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripButtonClose")]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripStatus")]
        private ToolStrip R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PickerTimeFrom"), CompilerGenerated]
        private DateTimePicker P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PickerTimeTo"), CompilerGenerated]
        private DateTimePicker Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerLoadData")]
        private System.Windows.Forms.Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimersStartUp"), CompilerGenerated]
        private System.Windows.Forms.Timer R;
        [AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private System.Windows.Forms.Timer P;
        [AccessedThroughProperty("GroupBox13"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("TxTTotalCashOut"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox12")]
        private GroupBox I;
        [AccessedThroughProperty("TxTTotalCashAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label P;
        [AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTotalPurchReturn")]
        private Label Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTFinalNetPurch")]
        private Label I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox8")]
        private GroupBox H;
        [AccessedThroughProperty("TxTTotalSaleReturn"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label D;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox T;
        [AccessedThroughProperty("TxTTotalPurch"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox4"), CompilerGenerated]
        private GroupBox X;
        [AccessedThroughProperty("TxTTotalCustomerPay"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox3")]
        private GroupBox G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTTotalSale")]
        private Label T;
        [AccessedThroughProperty("ToolStrip1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip P;
        [AccessedThroughProperty("ToolStripButtonAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator5"), CompilerGenerated]
        private ToolStripSeparator Q;
        [AccessedThroughProperty("ToolStripButtonDelete"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton P;
        [AccessedThroughProperty("ToolStripSeparator9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator I;
        [AccessedThroughProperty("Panel2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel A;
        [CompilerGenerated, AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxAllUser")]
        private CheckBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox9")]
        private GroupBox E;
        [CompilerGenerated, AccessedThroughProperty("TxTFCash"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label X;
        [AccessedThroughProperty("GroupBox14"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [AccessedThroughProperty("TxTTotalExpenes"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label G;
        [AccessedThroughProperty("GroupBox11"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox U;
        [AccessedThroughProperty("TxTTotalSuplierPay"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label E;
        [CompilerGenerated, AccessedThroughProperty("GroupBox10"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox L;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTFinalNetSale")]
        private Label K;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label11")]
        private Label U;
        [AccessedThroughProperty("ToolStripButtonPrint"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("A4ToolStripMenuItem")]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("ToolStripSeparator2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator D;
        [CompilerGenerated, AccessedThroughProperty("CacheReportToolStripMenuItem"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonOpenCash"), CompilerGenerated]
        private ToolStripButton Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage2"), CompilerGenerated]
        private TabPage P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox15"), CompilerGenerated]
        private GroupBox N;
        [AccessedThroughProperty("TXT0S"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label L;
        [AccessedThroughProperty("GroupBox21"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox V;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TXT6S"), CompilerGenerated]
        private Label N;
        [AccessedThroughProperty("GroupBox20"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Y;
        [CompilerGenerated, AccessedThroughProperty("TXT5S"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label V;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox19")]
        private GroupBox O;
        [AccessedThroughProperty("TXT4S"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Y;
        [CompilerGenerated, AccessedThroughProperty("GroupBox18"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox B;
        [CompilerGenerated, AccessedThroughProperty("TXT3S"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label O;
        [CompilerGenerated, AccessedThroughProperty("GroupBox17"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox S;
        [CompilerGenerated, AccessedThroughProperty("TXT2S"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label B;
        [CompilerGenerated, AccessedThroughProperty("GroupBox16"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Z;
        [AccessedThroughProperty("TXT1S"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label S;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonSortType")]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox31"), CompilerGenerated]
        private GroupBox M;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox32"), CompilerGenerated]
        private GroupBox C;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TXTN0")]
        private Label Z;
        [CompilerGenerated, AccessedThroughProperty("GroupBox33"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox J;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TXTN6")]
        private Label M;
        [CompilerGenerated, AccessedThroughProperty("GroupBox34"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox W;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TXTN1")]
        private Label C;
        [CompilerGenerated, AccessedThroughProperty("GroupBox35"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox AR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TXTN5")]
        private Label J;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox36")]
        private GroupBox PR;
        [AccessedThroughProperty("TXTN2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label W;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox37")]
        private GroupBox QR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TXTN4")]
        private Label AR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox38")]
        private GroupBox IR;
        [AccessedThroughProperty("TXTN3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label PR;
        [CompilerGenerated, AccessedThroughProperty("GroupBox23"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox DR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox24")]
        private GroupBox FR;
        [AccessedThroughProperty("TXT0R"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label QR;
        [CompilerGenerated, AccessedThroughProperty("GroupBox25"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox HR;
        [AccessedThroughProperty("TXT6R"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label IR;
        [AccessedThroughProperty("GroupBox26"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox TR;
        [CompilerGenerated, AccessedThroughProperty("TXT1R"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label DR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox27")]
        private GroupBox XR;
        [AccessedThroughProperty("TXT5R"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label FR;
        [CompilerGenerated, AccessedThroughProperty("GroupBox28"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox GR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TXT2R")]
        private Label HR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox29")]
        private GroupBox ER;
        [AccessedThroughProperty("TXT4R"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label TR;
        [CompilerGenerated, AccessedThroughProperty("GroupBox30"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox KR;
        [AccessedThroughProperty("TXT3R"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label XR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox22")]
        private GroupBox UR;
        [AccessedThroughProperty("TimerSortType"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private System.Windows.Forms.Timer Q;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label GR;
        private SqlConnection A;
        private DataTable A;
        private string A;
        private int A;
        private int R;

        public V()
        {
            base.Load += new EventHandler(this.A);
            base.KeyUp += new KeyEventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(A.V));
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox14 = new GroupBox();
            this.TxTTotalExpenes = new Label();
            this.GroupBox11 = new GroupBox();
            this.TxTTotalSuplierPay = new Label();
            this.GroupBox10 = new GroupBox();
            this.TxTFinalNetSale = new Label();
            this.GroupBox9 = new GroupBox();
            this.TxTFCash = new Label();
            this.GroupBox13 = new GroupBox();
            this.TxTTotalCashOut = new Label();
            this.GroupBox12 = new GroupBox();
            this.TxTTotalCashAdd = new Label();
            this.GroupBox7 = new GroupBox();
            this.TxTTotalPurchReturn = new Label();
            this.GroupBox6 = new GroupBox();
            this.TxTFinalNetPurch = new Label();
            this.GroupBox8 = new GroupBox();
            this.TxTTotalSaleReturn = new Label();
            this.GroupBox5 = new GroupBox();
            this.TxTTotalPurch = new Label();
            this.GroupBox4 = new GroupBox();
            this.TxTTotalCustomerPay = new Label();
            this.GroupBox3 = new GroupBox();
            this.TxTTotalSale = new Label();
            this.TabPage4 = new TabPage();
            this.GV = new DataGridView();
            this.ToolStrip1 = new ToolStrip();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.ButtonSortDate = new Button();
            this.GroupBox1 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBox2 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.GroupBoxUsers = new GroupBox();
            this.CheckBoxAllUser = new CheckBox();
            this.ComboBoxUser = new ComboBox();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.A4ToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.CacheReportToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripButtonOpenCash = new ToolStripButton();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.TimerLoadData = new System.Windows.Forms.Timer(this.A);
            this.TimersStartUp = new System.Windows.Forms.Timer(this.A);
            this.TimerFillGV = new System.Windows.Forms.Timer(this.A);
            this.Panel2 = new Panel();
            this.Label11 = new Label();
            this.TabPage2 = new TabPage();
            this.GroupBox15 = new GroupBox();
            this.TXT0S = new Label();
            this.GroupBox16 = new GroupBox();
            this.TXT1S = new Label();
            this.GroupBox17 = new GroupBox();
            this.TXT2S = new Label();
            this.GroupBox18 = new GroupBox();
            this.TXT3S = new Label();
            this.GroupBox19 = new GroupBox();
            this.TXT4S = new Label();
            this.GroupBox20 = new GroupBox();
            this.TXT5S = new Label();
            this.GroupBox21 = new GroupBox();
            this.TXT6S = new Label();
            this.GroupBox22 = new GroupBox();
            this.GroupBox23 = new GroupBox();
            this.GroupBox24 = new GroupBox();
            this.TXT0R = new Label();
            this.GroupBox25 = new GroupBox();
            this.TXT6R = new Label();
            this.GroupBox26 = new GroupBox();
            this.TXT1R = new Label();
            this.GroupBox27 = new GroupBox();
            this.TXT5R = new Label();
            this.GroupBox28 = new GroupBox();
            this.TXT2R = new Label();
            this.GroupBox29 = new GroupBox();
            this.TXT4R = new Label();
            this.GroupBox30 = new GroupBox();
            this.TXT3R = new Label();
            this.GroupBox31 = new GroupBox();
            this.GroupBox32 = new GroupBox();
            this.TXTN0 = new Label();
            this.GroupBox33 = new GroupBox();
            this.TXTN6 = new Label();
            this.GroupBox34 = new GroupBox();
            this.TXTN1 = new Label();
            this.GroupBox35 = new GroupBox();
            this.TXTN5 = new Label();
            this.GroupBox36 = new GroupBox();
            this.TXTN2 = new Label();
            this.GroupBox37 = new GroupBox();
            this.TXTN4 = new Label();
            this.GroupBox38 = new GroupBox();
            this.TXTN3 = new Label();
            this.ButtonSortType = new Button();
            this.TimerSortType = new System.Windows.Forms.Timer(this.A);
            this.Label1 = new Label();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBoxUsers.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.GroupBox18.SuspendLayout();
            this.GroupBox19.SuspendLayout();
            this.GroupBox20.SuspendLayout();
            this.GroupBox21.SuspendLayout();
            this.GroupBox22.SuspendLayout();
            this.GroupBox23.SuspendLayout();
            this.GroupBox24.SuspendLayout();
            this.GroupBox25.SuspendLayout();
            this.GroupBox26.SuspendLayout();
            this.GroupBox27.SuspendLayout();
            this.GroupBox28.SuspendLayout();
            this.GroupBox29.SuspendLayout();
            this.GroupBox30.SuspendLayout();
            this.GroupBox31.SuspendLayout();
            this.GroupBox32.SuspendLayout();
            this.GroupBox33.SuspendLayout();
            this.GroupBox34.SuspendLayout();
            this.GroupBox35.SuspendLayout();
            this.GroupBox36.SuspendLayout();
            this.GroupBox37.SuspendLayout();
            this.GroupBox38.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.BackColor = Color.WhiteSmoke;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.TxTTitle.Location = new Point(0, 0x24);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3ea, 0x24);
            this.TxTTitle.TabIndex = 0x6f;
            this.TxTTitle.Text = "هنا سيتم فرز كل العمليات التي تم قيدها على الكاش من فواتير، دفعات، مصروفات، خزينة مضافة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Dock = DockStyle.Fill;
            this.TabControl1.Location = new Point(0, 0xb7);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(8, 8);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3ea, 0x196);
            this.TabControl1.TabIndex = 0x70;
            this.TabPage1.Controls.Add(this.GroupBox14);
            this.TabPage1.Controls.Add(this.GroupBox11);
            this.TabPage1.Controls.Add(this.GroupBox10);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.GroupBox13);
            this.TabPage1.Controls.Add(this.GroupBox12);
            this.TabPage1.Controls.Add(this.GroupBox7);
            this.TabPage1.Controls.Add(this.GroupBox6);
            this.TabPage1.Controls.Add(this.GroupBox8);
            this.TabPage1.Controls.Add(this.GroupBox5);
            this.TabPage1.Controls.Add(this.GroupBox4);
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Location = new Point(4, 0x23);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3e2, 0x16f);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الرئيسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox14.Controls.Add(this.TxTTotalExpenes);
            this.GroupBox14.ForeColor = Color.Black;
            this.GroupBox14.Location = new Point(8, 0x12d);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0x1e8, 0x35);
            this.GroupBox14.TabIndex = 0x80;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "المصروفات (-)";
            this.TxTTotalExpenes.Dock = DockStyle.Fill;
            this.TxTTotalExpenes.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTotalExpenes.ForeColor = Color.Red;
            this.TxTTotalExpenes.Location = new Point(3, 0x13);
            this.TxTTotalExpenes.Name = "TxTTotalExpenes";
            this.TxTTotalExpenes.RightToLeft = RightToLeft.No;
            this.TxTTotalExpenes.Size = new Size(0x1e2, 0x1f);
            this.TxTTotalExpenes.TabIndex = 0;
            this.TxTTotalExpenes.Text = "0";
            this.TxTTotalExpenes.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox11.Controls.Add(this.TxTTotalSuplierPay);
            this.GroupBox11.ForeColor = Color.Black;
            this.GroupBox11.Location = new Point(8, 0xb7);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x1e8, 0x35);
            this.GroupBox11.TabIndex = 0x74;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "صافي دفعات الموردين (السحب / الايداع) بما فيها دفعات الفواتير السابقة (-)";
            this.TxTTotalSuplierPay.Dock = DockStyle.Fill;
            this.TxTTotalSuplierPay.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTotalSuplierPay.ForeColor = Color.Red;
            this.TxTTotalSuplierPay.Location = new Point(3, 0x13);
            this.TxTTotalSuplierPay.Name = "TxTTotalSuplierPay";
            this.TxTTotalSuplierPay.RightToLeft = RightToLeft.No;
            this.TxTTotalSuplierPay.Size = new Size(0x1e2, 0x1f);
            this.TxTTotalSuplierPay.TabIndex = 0;
            this.TxTTotalSuplierPay.Text = "0";
            this.TxTTotalSuplierPay.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox10.Controls.Add(this.TxTFinalNetSale);
            this.GroupBox10.ForeColor = Color.Black;
            this.GroupBox10.Location = new Point(0x1f6, 0x7c);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x1e4, 0x35);
            this.GroupBox10.TabIndex = 0x77;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "صافي المبيعات من مرتجع المبيعات (+)";
            this.TxTFinalNetSale.Dock = DockStyle.Fill;
            this.TxTFinalNetSale.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTFinalNetSale.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.TxTFinalNetSale.Location = new Point(3, 0x13);
            this.TxTFinalNetSale.Name = "TxTFinalNetSale";
            this.TxTFinalNetSale.RightToLeft = RightToLeft.No;
            this.TxTFinalNetSale.Size = new Size(0x1de, 0x1f);
            this.TxTFinalNetSale.TabIndex = 0;
            this.TxTFinalNetSale.Text = "0";
            this.TxTFinalNetSale.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox9.Controls.Add(this.TxTFCash);
            this.GroupBox9.ForeColor = Color.Black;
            this.GroupBox9.Location = new Point(0x1f6, 0x12d);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x1e4, 0x35);
            this.GroupBox9.TabIndex = 0x7f;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "صافي في صندوق الكاش";
            this.TxTFCash.Dock = DockStyle.Fill;
            this.TxTFCash.Font = new Font("Tahoma", 20.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTFCash.ForeColor = Color.Green;
            this.TxTFCash.Location = new Point(3, 0x13);
            this.TxTFCash.Name = "TxTFCash";
            this.TxTFCash.RightToLeft = RightToLeft.No;
            this.TxTFCash.Size = new Size(0x1de, 0x1f);
            this.TxTFCash.TabIndex = 0;
            this.TxTFCash.Text = "0";
            this.TxTFCash.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox13.Controls.Add(this.TxTTotalCashOut);
            this.GroupBox13.ForeColor = Color.Black;
            this.GroupBox13.Location = new Point(8, 0xf2);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x1e8, 0x35);
            this.GroupBox13.TabIndex = 0x7b;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "مجموع خزينة الكاش - سحب (-)";
            this.TxTTotalCashOut.Dock = DockStyle.Fill;
            this.TxTTotalCashOut.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTotalCashOut.ForeColor = Color.Red;
            this.TxTTotalCashOut.Location = new Point(3, 0x13);
            this.TxTTotalCashOut.Name = "TxTTotalCashOut";
            this.TxTTotalCashOut.RightToLeft = RightToLeft.No;
            this.TxTTotalCashOut.Size = new Size(0x1e2, 0x1f);
            this.TxTTotalCashOut.TabIndex = 0;
            this.TxTTotalCashOut.Text = "0";
            this.TxTTotalCashOut.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox12.Controls.Add(this.TxTTotalCashAdd);
            this.GroupBox12.ForeColor = Color.Black;
            this.GroupBox12.Location = new Point(0x1f6, 0xf2);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x1e4, 0x35);
            this.GroupBox12.TabIndex = 120;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "مجموع خزينة الكاش المضافة (+)";
            this.TxTTotalCashAdd.Dock = DockStyle.Fill;
            this.TxTTotalCashAdd.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTotalCashAdd.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.TxTTotalCashAdd.Location = new Point(3, 0x13);
            this.TxTTotalCashAdd.Name = "TxTTotalCashAdd";
            this.TxTTotalCashAdd.RightToLeft = RightToLeft.No;
            this.TxTTotalCashAdd.Size = new Size(0x1de, 0x1f);
            this.TxTTotalCashAdd.TabIndex = 0;
            this.TxTTotalCashAdd.Text = "0";
            this.TxTTotalCashAdd.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox7.Controls.Add(this.TxTTotalPurchReturn);
            this.GroupBox7.ForeColor = Color.Black;
            this.GroupBox7.Location = new Point(8, 0x41);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x1e8, 0x35);
            this.GroupBox7.TabIndex = 0x79;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "مجموع دفعات فواتير مرتجع المشتريات (+)";
            this.TxTTotalPurchReturn.Dock = DockStyle.Fill;
            this.TxTTotalPurchReturn.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTotalPurchReturn.ForeColor = Color.Black;
            this.TxTTotalPurchReturn.Location = new Point(3, 0x13);
            this.TxTTotalPurchReturn.Name = "TxTTotalPurchReturn";
            this.TxTTotalPurchReturn.RightToLeft = RightToLeft.No;
            this.TxTTotalPurchReturn.Size = new Size(0x1e2, 0x1f);
            this.TxTTotalPurchReturn.TabIndex = 0;
            this.TxTTotalPurchReturn.Text = "0";
            this.TxTTotalPurchReturn.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox6.Controls.Add(this.TxTFinalNetPurch);
            this.GroupBox6.ForeColor = Color.Black;
            this.GroupBox6.Location = new Point(8, 0x7c);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x1e8, 0x35);
            this.GroupBox6.TabIndex = 0x7a;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "صافي المشتريات من مرتجع المشتريات (-)";
            this.TxTFinalNetPurch.Dock = DockStyle.Fill;
            this.TxTFinalNetPurch.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTFinalNetPurch.ForeColor = Color.Red;
            this.TxTFinalNetPurch.Location = new Point(3, 0x13);
            this.TxTFinalNetPurch.Name = "TxTFinalNetPurch";
            this.TxTFinalNetPurch.RightToLeft = RightToLeft.No;
            this.TxTFinalNetPurch.Size = new Size(0x1e2, 0x1f);
            this.TxTFinalNetPurch.TabIndex = 0;
            this.TxTFinalNetPurch.Text = "0";
            this.TxTFinalNetPurch.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox8.Controls.Add(this.TxTTotalSaleReturn);
            this.GroupBox8.ForeColor = Color.Black;
            this.GroupBox8.Location = new Point(0x1f6, 0x41);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x1e4, 0x35);
            this.GroupBox8.TabIndex = 0x76;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "مجموع دفعات فواتير مرتجع المبيعات (-)";
            this.TxTTotalSaleReturn.Dock = DockStyle.Fill;
            this.TxTTotalSaleReturn.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTotalSaleReturn.ForeColor = Color.Black;
            this.TxTTotalSaleReturn.Location = new Point(3, 0x13);
            this.TxTTotalSaleReturn.Name = "TxTTotalSaleReturn";
            this.TxTTotalSaleReturn.RightToLeft = RightToLeft.No;
            this.TxTTotalSaleReturn.Size = new Size(0x1de, 0x1f);
            this.TxTTotalSaleReturn.TabIndex = 0;
            this.TxTTotalSaleReturn.Text = "0";
            this.TxTTotalSaleReturn.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox5.Controls.Add(this.TxTTotalPurch);
            this.GroupBox5.ForeColor = Color.Black;
            this.GroupBox5.Location = new Point(8, 6);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x1e8, 0x35);
            this.GroupBox5.TabIndex = 0x77;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "مجموع دفعات فواتير المشتريات (-)";
            this.TxTTotalPurch.Dock = DockStyle.Fill;
            this.TxTTotalPurch.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTotalPurch.ForeColor = Color.Black;
            this.TxTTotalPurch.Location = new Point(3, 0x13);
            this.TxTTotalPurch.Name = "TxTTotalPurch";
            this.TxTTotalPurch.RightToLeft = RightToLeft.No;
            this.TxTTotalPurch.Size = new Size(0x1e2, 0x1f);
            this.TxTTotalPurch.TabIndex = 0;
            this.TxTTotalPurch.Text = "0";
            this.TxTTotalPurch.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox4.Controls.Add(this.TxTTotalCustomerPay);
            this.GroupBox4.ForeColor = Color.Black;
            this.GroupBox4.Location = new Point(0x1f6, 0xb7);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x1e4, 0x35);
            this.GroupBox4.TabIndex = 0x73;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "صافي دفعات العملاء (السحب / الايداع) بما فيها دفعات الفواتير السابقة (+)";
            this.TxTTotalCustomerPay.Dock = DockStyle.Fill;
            this.TxTTotalCustomerPay.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTotalCustomerPay.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.TxTTotalCustomerPay.Location = new Point(3, 0x13);
            this.TxTTotalCustomerPay.Name = "TxTTotalCustomerPay";
            this.TxTTotalCustomerPay.RightToLeft = RightToLeft.No;
            this.TxTTotalCustomerPay.Size = new Size(0x1de, 0x1f);
            this.TxTTotalCustomerPay.TabIndex = 0;
            this.TxTTotalCustomerPay.Text = "0";
            this.TxTTotalCustomerPay.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox3.Controls.Add(this.TxTTotalSale);
            this.GroupBox3.ForeColor = Color.Black;
            this.GroupBox3.Location = new Point(0x1f6, 6);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x1e4, 0x35);
            this.GroupBox3.TabIndex = 0x72;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "مجموع دفعات فواتير المبيعات (+)";
            this.TxTTotalSale.Dock = DockStyle.Fill;
            this.TxTTotalSale.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTotalSale.ForeColor = Color.Black;
            this.TxTTotalSale.Location = new Point(3, 0x13);
            this.TxTTotalSale.Name = "TxTTotalSale";
            this.TxTTotalSale.RightToLeft = RightToLeft.No;
            this.TxTTotalSale.Size = new Size(0x1de, 0x1f);
            this.TxTTotalSale.TabIndex = 0;
            this.TxTTotalSale.Text = "0";
            this.TxTTotalSale.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage4.Controls.Add(this.GV);
            this.TabPage4.Controls.Add(this.ToolStrip1);
            this.TabPage4.Location = new Point(4, 0x23);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x3e2, 0x16f);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "حركات (إضافة | سحب) مبلغ خزينة من الصندوق";
            this.TabPage4.UseVisualStyleBackColor = true;
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
            this.GV.Location = new Point(0, 0);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3e2, 320);
            this.GV.TabIndex = 0x1ed36d3;
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.BackColor = Color.WhiteSmoke;
            this.ToolStrip1.Dock = DockStyle.Bottom;
            this.ToolStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonAdd, this.ToolStripSeparator5, this.ToolStripButtonDelete, this.ToolStripSeparator9 };
            this.ToolStrip1.Items.AddRange(toolStripItems);
            this.ToolStrip1.Location = new Point(0, 320);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new Size(0x3e2, 0x2f);
            this.ToolStrip1.TabIndex = 0x1ed36d2;
            this.ToolStripButtonAdd.Image = A.F.ImAdd;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(0x11c, 0x2c);
            this.ToolStripButtonAdd.Text = "اضافة حركة ( ايداع | سحب) مبلغ في الكاش";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(6, 0x2f);
            this.ToolStripButtonDelete.Image = A.F.ImDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(0x9c, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف الحركة المحددة";
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new Size(6, 0x2f);
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(9, 0x19);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(280, 0x3d);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x317, 15);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb0, 0x4a);
            this.GroupBox1.TabIndex = 0x58;
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
            this.GroupBox2.Location = new Point(0x253, 0x11);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xb0, 0x48);
            this.GroupBox2.TabIndex = 0x59;
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
            this.GroupBoxUsers.Controls.Add(this.CheckBoxAllUser);
            this.GroupBoxUsers.Controls.Add(this.ComboBoxUser);
            this.GroupBoxUsers.Location = new Point(0x13d, 0x11);
            this.GroupBoxUsers.Name = "GroupBoxUsers";
            this.GroupBoxUsers.Size = new Size(0x105, 0x48);
            this.GroupBoxUsers.TabIndex = 0x71;
            this.GroupBoxUsers.TabStop = false;
            this.GroupBoxUsers.Text = "الموظف";
            this.CheckBoxAllUser.AutoSize = true;
            this.CheckBoxAllUser.Dock = DockStyle.Bottom;
            this.CheckBoxAllUser.Location = new Point(3, 0x31);
            this.CheckBoxAllUser.Name = "CheckBoxAllUser";
            this.CheckBoxAllUser.Size = new Size(0xff, 20);
            this.CheckBoxAllUser.TabIndex = 60;
            this.CheckBoxAllUser.Text = "عرض كل الصناديق بدون الموظفين";
            this.CheckBoxAllUser.UseVisualStyleBackColor = true;
            this.ComboBoxUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxUser.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxUser.Dock = DockStyle.Top;
            this.ComboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxUser.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxUser.FormattingEnabled = true;
            this.ComboBoxUser.IntegralHeight = false;
            this.ComboBoxUser.Location = new Point(3, 0x13);
            this.ComboBoxUser.Name = "ComboBoxUser";
            this.ComboBoxUser.Size = new Size(0xff, 0x1b);
            this.ComboBoxUser.TabIndex = 0x3b;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.ToolStripButtonPrint, this.ToolStripSeparator7, this.ToolStripButtonOpenCash, this.ToolStripSeparator6, this.ToolStripButtonClose };
            this.ToolStripButtons.Items.AddRange(itemArray2);
            this.ToolStripButtons.Location = new Point(0, 0x24d);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3ea, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36d1;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.A4ToolStripMenuItem, this.ToolStripSeparator2, this.CacheReportToolStripMenuItem };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray3);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x56, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة";
            this.A4ToolStripMenuItem.Image = A.F.ImPrint;
            this.A4ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.A4ToolStripMenuItem.Name = "A4ToolStripMenuItem";
            this.A4ToolStripMenuItem.Size = new Size(210, 0x26);
            this.A4ToolStripMenuItem.Text = "تقرير الكاش A4";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(0xcf, 6);
            this.CacheReportToolStripMenuItem.Image = A.F.ImPrint;
            this.CacheReportToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.CacheReportToolStripMenuItem.Name = "CacheReportToolStripMenuItem";
            this.CacheReportToolStripMenuItem.Size = new Size(210, 0x26);
            this.CacheReportToolStripMenuItem.Text = "تقرير الكاش 80 حراري";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(6, 0x2f);
            this.ToolStripButtonOpenCash.Image = A.F.ImCashMe;
            this.ToolStripButtonOpenCash.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonOpenCash.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonOpenCash.Name = "ToolStripButtonOpenCash";
            this.ToolStripButtonOpenCash.Size = new Size(0x8f, 0x2c);
            this.ToolStripButtonOpenCash.Text = "فتح صندوق الكاش";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new Size(6, 0x2f);
            this.ToolStripButtonClose.Image = A.F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x2c);
            this.ToolStripButtonClose.Text = "اغلاق";
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray4);
            this.ToolStripStatus.Location = new Point(0, 0x27c);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3ea, 0x19);
            this.ToolStripStatus.TabIndex = 0x1ed36d0;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
            this.Panel2.BackColor = Color.WhiteSmoke;
            this.Panel2.BorderStyle = BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Controls.Add(this.ButtonSortDate);
            this.Panel2.Controls.Add(this.GroupBox2);
            this.Panel2.Controls.Add(this.GroupBoxUsers);
            this.Panel2.Dock = DockStyle.Top;
            this.Panel2.Location = new Point(0, 0x48);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new Size(0x3ea, 0x6f);
            this.Panel2.TabIndex = 0x1ed36d3;
            this.Label11.Dock = DockStyle.Top;
            this.Label11.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label11.ForeColor = Color.Green;
            this.Label11.Location = new Point(0, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new Size(0x3ea, 0x24);
            this.Label11.TabIndex = 0x1ed36d4;
            this.Label11.Text = "صندوق الكاش";
            this.Label11.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage2.Controls.Add(this.Label1);
            this.TabPage2.Controls.Add(this.ButtonSortType);
            this.TabPage2.Controls.Add(this.GroupBox31);
            this.TabPage2.Controls.Add(this.GroupBox23);
            this.TabPage2.Controls.Add(this.GroupBox22);
            this.TabPage2.Location = new Point(4, 0x23);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x3e2, 0x16f);
            this.TabPage2.TabIndex = 4;
            this.TabPage2.Text = "فرز فواتير المبيعات حسب طرق الدفع";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GroupBox15.Controls.Add(this.TXT0S);
            this.GroupBox15.ForeColor = Color.Black;
            this.GroupBox15.Location = new Point(0x33a, 0x17);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(130, 0x35);
            this.GroupBox15.TabIndex = 0x73;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "نقدا";
            this.TXT0S.Dock = DockStyle.Fill;
            this.TXT0S.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT0S.ForeColor = Color.Blue;
            this.TXT0S.Location = new Point(3, 0x13);
            this.TXT0S.Name = "TXT0S";
            this.TXT0S.RightToLeft = RightToLeft.No;
            this.TXT0S.Size = new Size(0x7c, 0x1f);
            this.TXT0S.TabIndex = 0;
            this.TXT0S.Text = "0";
            this.TXT0S.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox16.Controls.Add(this.TXT1S);
            this.GroupBox16.ForeColor = Color.Black;
            this.GroupBox16.Location = new Point(690, 0x17);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(130, 0x35);
            this.GroupBox16.TabIndex = 0x74;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "ذمم";
            this.TXT1S.Dock = DockStyle.Fill;
            this.TXT1S.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT1S.ForeColor = Color.Blue;
            this.TXT1S.Location = new Point(3, 0x13);
            this.TXT1S.Name = "TXT1S";
            this.TXT1S.RightToLeft = RightToLeft.No;
            this.TXT1S.Size = new Size(0x7c, 0x1f);
            this.TXT1S.TabIndex = 0;
            this.TXT1S.Text = "0";
            this.TXT1S.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox17.Controls.Add(this.TXT2S);
            this.GroupBox17.ForeColor = Color.Black;
            this.GroupBox17.Location = new Point(0x22a, 0x17);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(130, 0x35);
            this.GroupBox17.TabIndex = 0x75;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "شبكة";
            this.TXT2S.Dock = DockStyle.Fill;
            this.TXT2S.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT2S.ForeColor = Color.Blue;
            this.TXT2S.Location = new Point(3, 0x13);
            this.TXT2S.Name = "TXT2S";
            this.TXT2S.RightToLeft = RightToLeft.No;
            this.TXT2S.Size = new Size(0x7c, 0x1f);
            this.TXT2S.TabIndex = 0;
            this.TXT2S.Text = "0";
            this.TXT2S.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox18.Controls.Add(this.TXT3S);
            this.GroupBox18.ForeColor = Color.Black;
            this.GroupBox18.Location = new Point(0x1a2, 0x17);
            this.GroupBox18.Name = "GroupBox18";
            this.GroupBox18.Size = new Size(130, 0x35);
            this.GroupBox18.TabIndex = 0x76;
            this.GroupBox18.TabStop = false;
            this.GroupBox18.Text = "تحويل";
            this.TXT3S.Dock = DockStyle.Fill;
            this.TXT3S.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT3S.ForeColor = Color.Blue;
            this.TXT3S.Location = new Point(3, 0x13);
            this.TXT3S.Name = "TXT3S";
            this.TXT3S.RightToLeft = RightToLeft.No;
            this.TXT3S.Size = new Size(0x7c, 0x1f);
            this.TXT3S.TabIndex = 0;
            this.TXT3S.Text = "0";
            this.TXT3S.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox19.Controls.Add(this.TXT4S);
            this.GroupBox19.ForeColor = Color.Black;
            this.GroupBox19.Location = new Point(0x11a, 0x17);
            this.GroupBox19.Name = "GroupBox19";
            this.GroupBox19.Size = new Size(130, 0x35);
            this.GroupBox19.TabIndex = 0x77;
            this.GroupBox19.TabStop = false;
            this.GroupBox19.Text = "رصيد مدور";
            this.TXT4S.Dock = DockStyle.Fill;
            this.TXT4S.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT4S.ForeColor = Color.Blue;
            this.TXT4S.Location = new Point(3, 0x13);
            this.TXT4S.Name = "TXT4S";
            this.TXT4S.RightToLeft = RightToLeft.No;
            this.TXT4S.Size = new Size(0x7c, 0x1f);
            this.TXT4S.TabIndex = 0;
            this.TXT4S.Text = "0";
            this.TXT4S.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox20.Controls.Add(this.TXT5S);
            this.GroupBox20.ForeColor = Color.Black;
            this.GroupBox20.Location = new Point(0x92, 0x17);
            this.GroupBox20.Name = "GroupBox20";
            this.GroupBox20.Size = new Size(130, 0x35);
            this.GroupBox20.TabIndex = 120;
            this.GroupBox20.TabStop = false;
            this.GroupBox20.Text = "شيك";
            this.TXT5S.Dock = DockStyle.Fill;
            this.TXT5S.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT5S.ForeColor = Color.Blue;
            this.TXT5S.Location = new Point(3, 0x13);
            this.TXT5S.Name = "TXT5S";
            this.TXT5S.RightToLeft = RightToLeft.No;
            this.TXT5S.Size = new Size(0x7c, 0x1f);
            this.TXT5S.TabIndex = 0;
            this.TXT5S.Text = "0";
            this.TXT5S.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox21.Controls.Add(this.TXT6S);
            this.GroupBox21.ForeColor = Color.Black;
            this.GroupBox21.Location = new Point(10, 0x17);
            this.GroupBox21.Name = "GroupBox21";
            this.GroupBox21.Size = new Size(130, 0x35);
            this.GroupBox21.TabIndex = 0x79;
            this.GroupBox21.TabStop = false;
            this.GroupBox21.Text = "إئتمان";
            this.TXT6S.Dock = DockStyle.Fill;
            this.TXT6S.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT6S.ForeColor = Color.Blue;
            this.TXT6S.Location = new Point(3, 0x13);
            this.TXT6S.Name = "TXT6S";
            this.TXT6S.RightToLeft = RightToLeft.No;
            this.TXT6S.Size = new Size(0x7c, 0x1f);
            this.TXT6S.TabIndex = 0;
            this.TXT6S.Text = "0";
            this.TXT6S.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox22.Controls.Add(this.GroupBox15);
            this.GroupBox22.Controls.Add(this.GroupBox21);
            this.GroupBox22.Controls.Add(this.GroupBox16);
            this.GroupBox22.Controls.Add(this.GroupBox20);
            this.GroupBox22.Controls.Add(this.GroupBox17);
            this.GroupBox22.Controls.Add(this.GroupBox19);
            this.GroupBox22.Controls.Add(this.GroupBox18);
            this.GroupBox22.ForeColor = Color.Blue;
            this.GroupBox22.Location = new Point(8, 0x51);
            this.GroupBox22.Name = "GroupBox22";
            this.GroupBox22.Size = new Size(980, 0x51);
            this.GroupBox22.TabIndex = 0x7a;
            this.GroupBox22.TabStop = false;
            this.GroupBox22.Text = "المبيعات (+)";
            this.GroupBox23.Controls.Add(this.GroupBox24);
            this.GroupBox23.Controls.Add(this.GroupBox25);
            this.GroupBox23.Controls.Add(this.GroupBox26);
            this.GroupBox23.Controls.Add(this.GroupBox27);
            this.GroupBox23.Controls.Add(this.GroupBox28);
            this.GroupBox23.Controls.Add(this.GroupBox29);
            this.GroupBox23.Controls.Add(this.GroupBox30);
            this.GroupBox23.ForeColor = Color.Red;
            this.GroupBox23.Location = new Point(8, 0xa8);
            this.GroupBox23.Name = "GroupBox23";
            this.GroupBox23.Size = new Size(980, 0x51);
            this.GroupBox23.TabIndex = 0x7b;
            this.GroupBox23.TabStop = false;
            this.GroupBox23.Text = "مرتجع المبيعات (-)";
            this.GroupBox24.Controls.Add(this.TXT0R);
            this.GroupBox24.ForeColor = Color.Black;
            this.GroupBox24.Location = new Point(0x33a, 0x17);
            this.GroupBox24.Name = "GroupBox24";
            this.GroupBox24.Size = new Size(130, 0x35);
            this.GroupBox24.TabIndex = 0x73;
            this.GroupBox24.TabStop = false;
            this.GroupBox24.Text = "نقدا";
            this.TXT0R.Dock = DockStyle.Fill;
            this.TXT0R.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT0R.ForeColor = Color.Red;
            this.TXT0R.Location = new Point(3, 0x13);
            this.TXT0R.Name = "TXT0R";
            this.TXT0R.RightToLeft = RightToLeft.No;
            this.TXT0R.Size = new Size(0x7c, 0x1f);
            this.TXT0R.TabIndex = 0;
            this.TXT0R.Text = "0";
            this.TXT0R.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox25.Controls.Add(this.TXT6R);
            this.GroupBox25.ForeColor = Color.Black;
            this.GroupBox25.Location = new Point(10, 0x17);
            this.GroupBox25.Name = "GroupBox25";
            this.GroupBox25.Size = new Size(130, 0x35);
            this.GroupBox25.TabIndex = 0x79;
            this.GroupBox25.TabStop = false;
            this.GroupBox25.Text = "إئتمان";
            this.TXT6R.Dock = DockStyle.Fill;
            this.TXT6R.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT6R.ForeColor = Color.Red;
            this.TXT6R.Location = new Point(3, 0x13);
            this.TXT6R.Name = "TXT6R";
            this.TXT6R.RightToLeft = RightToLeft.No;
            this.TXT6R.Size = new Size(0x7c, 0x1f);
            this.TXT6R.TabIndex = 0;
            this.TXT6R.Text = "0";
            this.TXT6R.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox26.Controls.Add(this.TXT1R);
            this.GroupBox26.ForeColor = Color.Black;
            this.GroupBox26.Location = new Point(690, 0x17);
            this.GroupBox26.Name = "GroupBox26";
            this.GroupBox26.Size = new Size(130, 0x35);
            this.GroupBox26.TabIndex = 0x74;
            this.GroupBox26.TabStop = false;
            this.GroupBox26.Text = "ذمم";
            this.TXT1R.Dock = DockStyle.Fill;
            this.TXT1R.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT1R.ForeColor = Color.Red;
            this.TXT1R.Location = new Point(3, 0x13);
            this.TXT1R.Name = "TXT1R";
            this.TXT1R.RightToLeft = RightToLeft.No;
            this.TXT1R.Size = new Size(0x7c, 0x1f);
            this.TXT1R.TabIndex = 0;
            this.TXT1R.Text = "0";
            this.TXT1R.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox27.Controls.Add(this.TXT5R);
            this.GroupBox27.ForeColor = Color.Black;
            this.GroupBox27.Location = new Point(0x92, 0x17);
            this.GroupBox27.Name = "GroupBox27";
            this.GroupBox27.Size = new Size(130, 0x35);
            this.GroupBox27.TabIndex = 120;
            this.GroupBox27.TabStop = false;
            this.GroupBox27.Text = "شيك";
            this.TXT5R.Dock = DockStyle.Fill;
            this.TXT5R.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT5R.ForeColor = Color.Red;
            this.TXT5R.Location = new Point(3, 0x13);
            this.TXT5R.Name = "TXT5R";
            this.TXT5R.RightToLeft = RightToLeft.No;
            this.TXT5R.Size = new Size(0x7c, 0x1f);
            this.TXT5R.TabIndex = 0;
            this.TXT5R.Text = "0";
            this.TXT5R.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox28.Controls.Add(this.TXT2R);
            this.GroupBox28.ForeColor = Color.Black;
            this.GroupBox28.Location = new Point(0x22a, 0x17);
            this.GroupBox28.Name = "GroupBox28";
            this.GroupBox28.Size = new Size(130, 0x35);
            this.GroupBox28.TabIndex = 0x75;
            this.GroupBox28.TabStop = false;
            this.GroupBox28.Text = "شبكة";
            this.TXT2R.Dock = DockStyle.Fill;
            this.TXT2R.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT2R.ForeColor = Color.Red;
            this.TXT2R.Location = new Point(3, 0x13);
            this.TXT2R.Name = "TXT2R";
            this.TXT2R.RightToLeft = RightToLeft.No;
            this.TXT2R.Size = new Size(0x7c, 0x1f);
            this.TXT2R.TabIndex = 0;
            this.TXT2R.Text = "0";
            this.TXT2R.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox29.Controls.Add(this.TXT4R);
            this.GroupBox29.ForeColor = Color.Black;
            this.GroupBox29.Location = new Point(0x11a, 0x17);
            this.GroupBox29.Name = "GroupBox29";
            this.GroupBox29.Size = new Size(130, 0x35);
            this.GroupBox29.TabIndex = 0x77;
            this.GroupBox29.TabStop = false;
            this.GroupBox29.Text = "رصيد مدور";
            this.TXT4R.Dock = DockStyle.Fill;
            this.TXT4R.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT4R.ForeColor = Color.Red;
            this.TXT4R.Location = new Point(3, 0x13);
            this.TXT4R.Name = "TXT4R";
            this.TXT4R.RightToLeft = RightToLeft.No;
            this.TXT4R.Size = new Size(0x7c, 0x1f);
            this.TXT4R.TabIndex = 0;
            this.TXT4R.Text = "0";
            this.TXT4R.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox30.Controls.Add(this.TXT3R);
            this.GroupBox30.ForeColor = Color.Black;
            this.GroupBox30.Location = new Point(0x1a2, 0x17);
            this.GroupBox30.Name = "GroupBox30";
            this.GroupBox30.Size = new Size(130, 0x35);
            this.GroupBox30.TabIndex = 0x76;
            this.GroupBox30.TabStop = false;
            this.GroupBox30.Text = "تحويل";
            this.TXT3R.Dock = DockStyle.Fill;
            this.TXT3R.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXT3R.ForeColor = Color.Red;
            this.TXT3R.Location = new Point(3, 0x13);
            this.TXT3R.Name = "TXT3R";
            this.TXT3R.RightToLeft = RightToLeft.No;
            this.TXT3R.Size = new Size(0x7c, 0x1f);
            this.TXT3R.TabIndex = 0;
            this.TXT3R.Text = "0";
            this.TXT3R.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox31.Controls.Add(this.GroupBox32);
            this.GroupBox31.Controls.Add(this.GroupBox33);
            this.GroupBox31.Controls.Add(this.GroupBox34);
            this.GroupBox31.Controls.Add(this.GroupBox35);
            this.GroupBox31.Controls.Add(this.GroupBox36);
            this.GroupBox31.Controls.Add(this.GroupBox37);
            this.GroupBox31.Controls.Add(this.GroupBox38);
            this.GroupBox31.Location = new Point(8, 0x105);
            this.GroupBox31.Name = "GroupBox31";
            this.GroupBox31.Size = new Size(980, 0x51);
            this.GroupBox31.TabIndex = 0x7c;
            this.GroupBox31.TabStop = false;
            this.GroupBox31.Text = "صافي المبيعات من مرتجع المبيعات";
            this.GroupBox32.Controls.Add(this.TXTN0);
            this.GroupBox32.ForeColor = Color.Black;
            this.GroupBox32.Location = new Point(0x33a, 0x17);
            this.GroupBox32.Name = "GroupBox32";
            this.GroupBox32.Size = new Size(130, 0x35);
            this.GroupBox32.TabIndex = 0x73;
            this.GroupBox32.TabStop = false;
            this.GroupBox32.Text = "نقدا";
            this.TXTN0.Dock = DockStyle.Fill;
            this.TXTN0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXTN0.ForeColor = Color.Black;
            this.TXTN0.Location = new Point(3, 0x13);
            this.TXTN0.Name = "TXTN0";
            this.TXTN0.RightToLeft = RightToLeft.No;
            this.TXTN0.Size = new Size(0x7c, 0x1f);
            this.TXTN0.TabIndex = 0;
            this.TXTN0.Text = "0";
            this.TXTN0.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox33.Controls.Add(this.TXTN6);
            this.GroupBox33.ForeColor = Color.Black;
            this.GroupBox33.Location = new Point(10, 0x17);
            this.GroupBox33.Name = "GroupBox33";
            this.GroupBox33.Size = new Size(130, 0x35);
            this.GroupBox33.TabIndex = 0x79;
            this.GroupBox33.TabStop = false;
            this.GroupBox33.Text = "إئتمان";
            this.TXTN6.Dock = DockStyle.Fill;
            this.TXTN6.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXTN6.ForeColor = Color.Black;
            this.TXTN6.Location = new Point(3, 0x13);
            this.TXTN6.Name = "TXTN6";
            this.TXTN6.RightToLeft = RightToLeft.No;
            this.TXTN6.Size = new Size(0x7c, 0x1f);
            this.TXTN6.TabIndex = 0;
            this.TXTN6.Text = "0";
            this.TXTN6.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox34.Controls.Add(this.TXTN1);
            this.GroupBox34.ForeColor = Color.Black;
            this.GroupBox34.Location = new Point(690, 0x17);
            this.GroupBox34.Name = "GroupBox34";
            this.GroupBox34.Size = new Size(130, 0x35);
            this.GroupBox34.TabIndex = 0x74;
            this.GroupBox34.TabStop = false;
            this.GroupBox34.Text = "ذمم";
            this.TXTN1.Dock = DockStyle.Fill;
            this.TXTN1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXTN1.ForeColor = Color.Black;
            this.TXTN1.Location = new Point(3, 0x13);
            this.TXTN1.Name = "TXTN1";
            this.TXTN1.RightToLeft = RightToLeft.No;
            this.TXTN1.Size = new Size(0x7c, 0x1f);
            this.TXTN1.TabIndex = 0;
            this.TXTN1.Text = "0";
            this.TXTN1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox35.Controls.Add(this.TXTN5);
            this.GroupBox35.ForeColor = Color.Black;
            this.GroupBox35.Location = new Point(0x92, 0x17);
            this.GroupBox35.Name = "GroupBox35";
            this.GroupBox35.Size = new Size(130, 0x35);
            this.GroupBox35.TabIndex = 120;
            this.GroupBox35.TabStop = false;
            this.GroupBox35.Text = "شيك";
            this.TXTN5.Dock = DockStyle.Fill;
            this.TXTN5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXTN5.ForeColor = Color.Black;
            this.TXTN5.Location = new Point(3, 0x13);
            this.TXTN5.Name = "TXTN5";
            this.TXTN5.RightToLeft = RightToLeft.No;
            this.TXTN5.Size = new Size(0x7c, 0x1f);
            this.TXTN5.TabIndex = 0;
            this.TXTN5.Text = "0";
            this.TXTN5.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox36.Controls.Add(this.TXTN2);
            this.GroupBox36.ForeColor = Color.Black;
            this.GroupBox36.Location = new Point(0x22a, 0x17);
            this.GroupBox36.Name = "GroupBox36";
            this.GroupBox36.Size = new Size(130, 0x35);
            this.GroupBox36.TabIndex = 0x75;
            this.GroupBox36.TabStop = false;
            this.GroupBox36.Text = "شبكة";
            this.TXTN2.Dock = DockStyle.Fill;
            this.TXTN2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXTN2.ForeColor = Color.Black;
            this.TXTN2.Location = new Point(3, 0x13);
            this.TXTN2.Name = "TXTN2";
            this.TXTN2.RightToLeft = RightToLeft.No;
            this.TXTN2.Size = new Size(0x7c, 0x1f);
            this.TXTN2.TabIndex = 0;
            this.TXTN2.Text = "0";
            this.TXTN2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox37.Controls.Add(this.TXTN4);
            this.GroupBox37.ForeColor = Color.Black;
            this.GroupBox37.Location = new Point(0x11a, 0x17);
            this.GroupBox37.Name = "GroupBox37";
            this.GroupBox37.Size = new Size(130, 0x35);
            this.GroupBox37.TabIndex = 0x77;
            this.GroupBox37.TabStop = false;
            this.GroupBox37.Text = "رصيد مدور";
            this.TXTN4.Dock = DockStyle.Fill;
            this.TXTN4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXTN4.ForeColor = Color.Black;
            this.TXTN4.Location = new Point(3, 0x13);
            this.TXTN4.Name = "TXTN4";
            this.TXTN4.RightToLeft = RightToLeft.No;
            this.TXTN4.Size = new Size(0x7c, 0x1f);
            this.TXTN4.TabIndex = 0;
            this.TXTN4.Text = "0";
            this.TXTN4.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox38.Controls.Add(this.TXTN3);
            this.GroupBox38.ForeColor = Color.Black;
            this.GroupBox38.Location = new Point(0x1a2, 0x17);
            this.GroupBox38.Name = "GroupBox38";
            this.GroupBox38.Size = new Size(130, 0x35);
            this.GroupBox38.TabIndex = 0x76;
            this.GroupBox38.TabStop = false;
            this.GroupBox38.Text = "تحويل";
            this.TXTN3.Dock = DockStyle.Fill;
            this.TXTN3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TXTN3.ForeColor = Color.Black;
            this.TXTN3.Location = new Point(3, 0x13);
            this.TXTN3.Name = "TXTN3";
            this.TXTN3.RightToLeft = RightToLeft.No;
            this.TXTN3.Size = new Size(0x7c, 0x1f);
            this.TXTN3.TabIndex = 0;
            this.TXTN3.Text = "0";
            this.TXTN3.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonSortType.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortType.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortType.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortType.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortType.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortType.Image = A.F.ImSort;
            this.ButtonSortType.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortType.Location = new Point(0x201, 15);
            this.ButtonSortType.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortType.Name = "ButtonSortType";
            this.ButtonSortType.Size = new Size(0x1cf, 0x3b);
            this.ButtonSortType.TabIndex = 0x7d;
            this.ButtonSortType.Text = "فرز دفعات (فواتير المبيعات فقط) حسب طرق الدفع";
            this.ButtonSortType.UseVisualStyleBackColor = true;
            this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label1.Location = new Point(8, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x1cf, 0x4d);
            this.Label1.TabIndex = 0x7e;
            this.Label1.Text = manager.GetString("Label1.Text");
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3ea, 0x295);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.Panel2);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.Label11);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "CashList";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "صندوق الكاش";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBoxUsers.ResumeLayout(false);
            this.GroupBoxUsers.PerformLayout();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox18.ResumeLayout(false);
            this.GroupBox19.ResumeLayout(false);
            this.GroupBox20.ResumeLayout(false);
            this.GroupBox21.ResumeLayout(false);
            this.GroupBox22.ResumeLayout(false);
            this.GroupBox23.ResumeLayout(false);
            this.GroupBox24.ResumeLayout(false);
            this.GroupBox25.ResumeLayout(false);
            this.GroupBox26.ResumeLayout(false);
            this.GroupBox27.ResumeLayout(false);
            this.GroupBox28.ResumeLayout(false);
            this.GroupBox29.ResumeLayout(false);
            this.GroupBox30.ResumeLayout(false);
            this.GroupBox31.ResumeLayout(false);
            this.GroupBox32.ResumeLayout(false);
            this.GroupBox33.ResumeLayout(false);
            this.GroupBox34.ResumeLayout(false);
            this.GroupBox35.ResumeLayout(false);
            this.GroupBox36.ResumeLayout(false);
            this.GroupBox37.ResumeLayout(false);
            this.GroupBox38.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, KeyEventArgs R)
        {
            if (R.KeyCode == Keys.F1)
            {
                A.W.A();
            }
        }

        public void D()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT [InvSaleMonPay] FROM TaNNInvSale WHERE (CenterFrontID = @CenterFrontID) AND (InvSaleDateTime BETWEEN @DF and @DT) AND (InvSaleIsCashCount = @InvSaleIsCashCount) AND (InvSaleType = @InvSaleType) AND (InvSaleUserAddBy = @InvSaleUserAddBy)" : "SELECT [InvSaleMonPay] FROM TaNNInvSale WHERE (CenterFrontID = @CenterFrontID) AND (InvSaleDateTime BETWEEN @DF and @DT) AND (InvSaleIsCashCount = @InvSaleIsCashCount) AND (InvSaleType = @InvSaleType)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("InvSaleType", "1");
            adapter.SelectCommand.Parameters.AddWithValue("InvSaleIsCashCount", true);
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("InvSaleUserAddBy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            this.A.Close();
            decimal left = 0M;
            try
            {
                enumerator = dataTable.Rows.GetEnumerator();
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    object current = enumerator.Current;
                    object[] arguments = new object[] { "InvSaleMonPay" };
                    left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            this.TxTTotalSaleReturn.Text = left.ToString(A.PR.YR);
        }

        private void D(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
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

        public void E()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT [CashAmont] FROM TaNNCash WHERE (CenterFrontID = @CenterFrontID) AND (CashDateTime BETWEEN @DF and @DT) AND (CashType = @CashType) AND (CashUserAddBy = @CashUserAddBy)" : "SELECT [CashAmont] FROM TaNNCash WHERE (CenterFrontID = @CenterFrontID) AND (CashDateTime BETWEEN @DF and @DT) AND (CashType = @CashType)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("CashType", "1");
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("CashUserAddBy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            this.A.Close();
            decimal left = 0M;
            try
            {
                enumerator = dataTable.Rows.GetEnumerator();
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    object current = enumerator.Current;
                    object[] arguments = new object[] { "CashAmont" };
                    left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            if (decimal.Compare(left, decimal.Zero) < 0)
            {
                left = decimal.Multiply(left, decimal.MinusOne);
            }
            this.TxTTotalCashOut.Text = left.ToString(A.PR.YR);
        }

        private void E(object A, EventArgs R)
        {
            A.W.A();
        }

        public void F()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT [InvPurchMonPay] FROM TaNNInvPurch WHERE (CenterFrontID = @CenterFrontID) AND (InvPurchDateTime BETWEEN @DF and @DT) AND (InvPurchIsCashCount = @InvPurchIsCashCount) AND (InvPurchType = @InvPurchType) AND (InvPurchUserAddBy = @InvPurchUserAddBy)" : "SELECT [InvPurchMonPay] FROM TaNNInvPurch WHERE (CenterFrontID = @CenterFrontID) AND (InvPurchDateTime BETWEEN @DF and @DT) AND (InvPurchIsCashCount = @InvPurchIsCashCount) AND (InvPurchType = @InvPurchType)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("InvPurchType", "0");
            adapter.SelectCommand.Parameters.AddWithValue("InvPurchIsCashCount", true);
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("InvPurchUserAddBy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            this.A.Close();
            decimal left = 0M;
            try
            {
                enumerator = dataTable.Rows.GetEnumerator();
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    object current = enumerator.Current;
                    object[] arguments = new object[] { "InvPurchMonPay" };
                    left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            this.TxTTotalPurch.Text = left.ToString(A.PR.YR);
        }

        private void F(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.ToolStripProgressBar1.Visible = true;
            this.P();
        }

        public void G()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT [CashAmont] FROM TaNNCash WHERE (CenterFrontID = @CenterFrontID) AND (CashDateTime BETWEEN @DF and @DT) AND (CashType = @CashType) AND (CashUserAddBy = @CashUserAddBy)" : "SELECT [CashAmont] FROM TaNNCash WHERE (CenterFrontID = @CenterFrontID) AND (CashDateTime BETWEEN @DF and @DT) AND (CashType = @CashType)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("CashType", "0");
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("CashUserAddBy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            this.A.Close();
            decimal left = 0M;
            try
            {
                enumerator = dataTable.Rows.GetEnumerator();
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    object current = enumerator.Current;
                    object[] arguments = new object[] { "CashAmont" };
                    left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            if (decimal.Compare(left, decimal.Zero) < 0)
            {
                left = decimal.Multiply(left, decimal.One);
            }
            this.TxTTotalCashAdd.Text = left.ToString(A.PR.YR);
        }

        private void G(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                GP gp = new GP {
                    PrintOptions = { NoPrinter = A.AR.J }
                };
                gp.SetDataSource(this.A);
                gp.SetParameterValue("CenterName", A.PR.ER.ToString());
                gp.SetParameterValue("CenterSubName", A.PR.KR.ToString());
                gp.SetParameterValue("ParameterDeimelQ", A.PR.X);
                gp.SetParameterValue("ParameterDeimelS", A.PR.T);
                gp.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (A.PR.NR == null)
                {
                    gp.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    gp.SetParameterValue("CenterCurrencyName", A.PR.NR.ToString());
                }
                if (A.PR.UR == null)
                {
                    gp.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    gp.SetParameterValue("CenterPhone", A.PR.UR.ToString());
                }
                gp.SetParameterValue("TxTTotalSale", this.TxTTotalSale.Text.ToString());
                gp.SetParameterValue("TxTTotalPurch", this.TxTTotalPurch.Text.ToString());
                gp.SetParameterValue("TxTTotalSaleReturn", this.TxTTotalSaleReturn.Text.ToString());
                gp.SetParameterValue("TxTTotalPurchReturn", this.TxTTotalPurchReturn.Text.ToString());
                gp.SetParameterValue("TxTFinalNetSale", this.TxTFinalNetSale.Text.ToString());
                gp.SetParameterValue("TxTFinalNetPurch", this.TxTFinalNetPurch.Text.ToString());
                gp.SetParameterValue("TxTTotalCustomerPay", this.TxTTotalCustomerPay.Text.ToString());
                gp.SetParameterValue("TxTTotalSuplierPay", this.TxTTotalSuplierPay.Text.ToString());
                gp.SetParameterValue("TxTTotalCashAdd", this.TxTTotalCashAdd.Text.ToString());
                gp.SetParameterValue("TxTTotalCashOut", this.TxTTotalCashOut.Text.ToString());
                gp.SetParameterValue("TxTTotalExpenes", this.TxTTotalExpenes.Text.ToString());
                gp.SetParameterValue("TxTFCash", this.TxTFCash.Text.ToString());
                gp.SetParameterValue("DF", this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd"));
                gp.SetParameterValue("DT", this.DateTimePickerTo.Value.ToString("yyyy/MM/dd"));
                if (this.CheckBoxAllUser.Checked)
                {
                    gp.SetParameterValue("ComboBoxUser", "الكل");
                }
                else
                {
                    gp.SetParameterValue("ComboBoxUser", this.ComboBoxUser.Text);
                }
                A.HR hr = new A.HR {
                    CRViewer = { ReportSource = gp }
                };
                if (A.AR.U)
                {
                    hr.ShowDialog();
                }
                else if (A.AR.L)
                {
                    hr.CRViewer.PrintReport();
                }
                else
                {
                    gp.PrintOptions.PrinterName = A.AR.X;
                    gp.PrintToPrinter(A.AR.I, false, 0, 0);
                }
                gp.Close();
                gp.Dispose();
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

        public void H()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT [InvPurchMonPay] FROM TaNNInvPurch WHERE (CenterFrontID = @CenterFrontID) AND (InvPurchDateTime BETWEEN @DF and @DT) AND (InvPurchIsCashCount = @InvPurchIsCashCount) AND (InvPurchType = @InvPurchType) AND (InvPurchUserAddBy = @InvPurchUserAddBy)" : "SELECT [InvPurchMonPay] FROM TaNNInvPurch WHERE (CenterFrontID = @CenterFrontID) AND (InvPurchDateTime BETWEEN @DF and @DT) AND (InvPurchIsCashCount = @InvPurchIsCashCount) AND (InvPurchType = @InvPurchType)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("InvPurchType", "1");
            adapter.SelectCommand.Parameters.AddWithValue("InvPurchIsCashCount", true);
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("InvPurchUserAddBy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            this.A.Close();
            decimal left = 0M;
            try
            {
                enumerator = dataTable.Rows.GetEnumerator();
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    object current = enumerator.Current;
                    object[] arguments = new object[] { "InvPurchMonPay" };
                    left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            this.TxTTotalPurchReturn.Text = left.ToString(A.PR.YR);
        }

        private void H(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void I()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT [InvSaleMonPay] FROM TaNNInvSale WHERE (CenterFrontID = @CenterFrontID) AND (InvSaleDateTime BETWEEN @DF and @DT) AND (InvSaleIsCashCount = @InvSaleIsCashCount) AND (InvSaleType = @InvSaleType) AND (InvSaleUserAddBy = @InvSaleUserAddBy)" : "SELECT [InvSaleMonPay] FROM TaNNInvSale WHERE (CenterFrontID = @CenterFrontID) AND (InvSaleDateTime BETWEEN @DF and @DT) AND (InvSaleIsCashCount = @InvSaleIsCashCount) AND (InvSaleType = @InvSaleType)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("InvSaleType", "0");
            adapter.SelectCommand.Parameters.AddWithValue("InvSaleIsCashCount", true);
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("InvSaleUserAddBy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            this.A.Close();
            decimal left = 0M;
            try
            {
                enumerator = dataTable.Rows.GetEnumerator();
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    object current = enumerator.Current;
                    object[] arguments = new object[] { "InvSaleMonPay" };
                    left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            this.TxTTotalSale.Text = left.ToString(A.PR.YR);
        }

        private void I(object A, EventArgs R)
        {
            if (Interaction.MsgBox(A.PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (Information.IsNothing(this.GV.CurrentRow))
                    {
                        Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                    }
                    else
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNCash WHERE (CashID = @CashID)", this.A);
                        command.Parameters.AddWithValue("CashID", this.GV.SelectedRows[0].Cells["CashID"].Value.ToString());
                        command.ExecuteNonQuery();
                        this.A.Close();
                        Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        this.TimerLoadData.Enabled = true;
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
        }

        public void K()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT [ExMoney] FROM TaNNExpenses WHERE (CenterFrontID = @CenterFrontID) AND (ExDate BETWEEN @DF and @DT) AND (ExIsCashCount = @ExIsCashCount) AND (ExUserAddBy = @ExUserAddBy)" : "SELECT [ExMoney] FROM TaNNExpenses WHERE (CenterFrontID = @CenterFrontID) AND (ExDate BETWEEN @DF and @DT) AND (ExIsCashCount = @ExIsCashCount)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("ExIsCashCount", true);
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("ExUserAddBy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            this.A.Close();
            decimal left = 0M;
            try
            {
                enumerator = dataTable.Rows.GetEnumerator();
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    object current = enumerator.Current;
                    object[] arguments = new object[] { "ExMoney" };
                    left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            if (decimal.Compare(left, decimal.Zero) < 0)
            {
                left = decimal.Multiply(left, decimal.One);
            }
            this.TxTTotalExpenes.Text = left.ToString(A.PR.YR);
        }

        private void K(object A, EventArgs R)
        {
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerSortType.Enabled = true;
        }

        public void L()
        {
            // Invalid method body.
        }

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            if (A.PR.MP)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void Q()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT * FROM TaNNCash WHERE (CenterFrontID = @CenterFrontID) AND (CashDateTime BETWEEN @DF and @DT) AND (CashUserAddBy = @CashUserAddBy)" : "SELECT * FROM TaNNCash WHERE (CenterFrontID = @CenterFrontID) AND (CashDateTime BETWEEN @DF and @DT)";
            this.A.Clear();
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("CashUserAddBy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            adapter.Fill(this.A);
            this.A.Close();
            this.GV.DataSource = dataTable;
            this.GV.Refresh();
            this.GV.Columns["CashID"].Visible = false;
            this.GV.Columns["CenterFrontID"].Visible = false;
            this.GV.Columns["CashDateTime"].HeaderText = "التاريخ/الوقت";
            this.GV.Columns["CashType"].HeaderText = "النوع";
            this.GV.Columns["CashDesic"].HeaderText = "الوصف";
            this.GV.Columns["CashAmont"].HeaderText = "المبلغ";
            this.GV.Columns["CashNote"].HeaderText = "ملاحظات";
            this.GV.Columns["CashUserAddBy"].HeaderText = "الموظف";
            this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ToolStripButtonDelete.Enabled = this.GV.RowCount > 0;
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
                    decimal num = new decimal(Conversion.Val(current.Cells["CashAmont"].Value.ToString()));
                    if (decimal.Compare(num, decimal.Zero) > 0)
                    {
                        current.Cells["CashAmont"].Style.ForeColor = Color.Blue;
                    }
                    else if (decimal.Compare(num, decimal.Zero) < 0)
                    {
                        current.Cells["CashAmont"].Style.ForeColor = Color.Red;
                    }
                    current.Cells["CashAmont"].Value = num.ToString(A.PR.YR);
                    decimal num2 = new decimal(Conversion.Val(current.Cells["CashType"].Value.ToString()));
                    if (decimal.Compare(num2, decimal.Zero) == 0)
                    {
                        current.Cells["CashType"].Value = "اضافة/ايداع";
                    }
                    else if (decimal.Compare(num2, decimal.One) == 0)
                    {
                        current.Cells["CashType"].Value = "سحب";
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
        }

        private void Q(object A, EventArgs R)
        {
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
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
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
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.R();
            this.TimerLoadData.Enabled = true;
        }

        public void T()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT [PayMony] FROM TaNNCustomersPay WHERE (CenterFrontID = @CenterFrontID) AND (PayDateTimer BETWEEN @DF and @DT) AND (PayIsCashCount = @PayIsCashCount) AND (PayType = @PayType) AND (PayEmploy = @PayEmploy)" : "SELECT [PayMony] FROM TaNNCustomersPay WHERE (CenterFrontID = @CenterFrontID) AND (PayDateTimer BETWEEN @DF and @DT) AND (PayIsCashCount = @PayIsCashCount) AND (PayType = @PayType)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("PayType", "500");
            adapter.SelectCommand.Parameters.AddWithValue("PayIsCashCount", true);
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("PayEmploy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            this.A.Close();
            decimal left = 0M;
            try
            {
                enumerator = dataTable.Rows.GetEnumerator();
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    object current = enumerator.Current;
                    object[] arguments = new object[] { "PayMony" };
                    left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            this.TxTTotalCustomerPay.Text = left.ToString(A.PR.YR);
        }

        private void T(object A, EventArgs R)
        {
            this.ComboBoxUser.Text = !this.CheckBoxAllUser.Checked ? A.D.A.A.TxTUserName.Text : null;
        }

        public void U()
        {
            // Invalid method body.
        }

        private void U(object A, EventArgs R)
        {
            this.TimerSortType.Enabled = false;
            this.ToolStripProgressBar1.Visible = true;
            this.U();
        }

        public void X()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            Thread.Sleep(50);
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
            DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
            DataTable dataTable = new DataTable();
            string selectCommandText = !this.CheckBoxAllUser.Checked ? "SELECT [PayMony] FROM TaNNSupliersPay WHERE (CenterFrontID = @CenterFrontID) AND (PayDateTimer BETWEEN @DF and @DT) AND (PayIsCashCount = @PayIsCashCount) AND (PayType = @PayType) AND (PayEmploy = @PayEmploy)" : "SELECT [PayMony] FROM TaNNSupliersPay WHERE (CenterFrontID = @CenterFrontID) AND (PayDateTimer BETWEEN @DF and @DT) AND (PayIsCashCount = @PayIsCashCount) AND (PayType = @PayType)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("PayType", "500");
            adapter.SelectCommand.Parameters.AddWithValue("PayIsCashCount", true);
            string text1 = time.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
            string text2 = time2.ToString("yyyy/MM/dd HH:mm");
            adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
            string text = this.ComboBoxUser.Text;
            adapter.SelectCommand.Parameters.AddWithValue("PayEmploy", text ?? DBNull.Value);
            adapter.Fill(dataTable);
            this.A.Close();
            decimal left = 0M;
            try
            {
                enumerator = dataTable.Rows.GetEnumerator();
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    object current = enumerator.Current;
                    object[] arguments = new object[] { "PayMony" };
                    left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            this.TxTTotalSuplierPay.Text = left.ToString(A.PR.YR);
        }

        private void X(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                MP mp = new MP();
                mp.SetDataSource(this.A);
                mp.SetParameterValue("CenterName", A.PR.ER.ToString());
                mp.SetParameterValue("CenterSubName", A.PR.KR.ToString());
                mp.SetParameterValue("ParameterDeimelQ", A.PR.X);
                mp.SetParameterValue("ParameterDeimelS", A.PR.T);
                mp.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (A.PR.NR == null)
                {
                    mp.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    mp.SetParameterValue("CenterCurrencyName", A.PR.NR.ToString());
                }
                if (A.PR.UR == null)
                {
                    mp.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    mp.SetParameterValue("CenterPhone", A.PR.UR.ToString());
                }
                mp.SetParameterValue("TxTTotalSale", this.TxTTotalSale.Text.ToString());
                mp.SetParameterValue("TxTTotalPurch", this.TxTTotalPurch.Text.ToString());
                mp.SetParameterValue("TxTTotalSaleReturn", this.TxTTotalSaleReturn.Text.ToString());
                mp.SetParameterValue("TxTTotalPurchReturn", this.TxTTotalPurchReturn.Text.ToString());
                mp.SetParameterValue("TxTFinalNetSale", this.TxTFinalNetSale.Text.ToString());
                mp.SetParameterValue("TxTFinalNetPurch", this.TxTFinalNetPurch.Text.ToString());
                mp.SetParameterValue("TxTTotalCustomerPay", this.TxTTotalCustomerPay.Text.ToString());
                mp.SetParameterValue("TxTTotalSuplierPay", this.TxTTotalSuplierPay.Text.ToString());
                mp.SetParameterValue("TxTTotalCashAdd", this.TxTTotalCashAdd.Text.ToString());
                mp.SetParameterValue("TxTTotalCashOut", this.TxTTotalCashOut.Text.ToString());
                mp.SetParameterValue("TxTTotalExpenes", this.TxTTotalExpenes.Text.ToString());
                mp.SetParameterValue("TxTFCash", this.TxTFCash.Text.ToString());
                mp.SetParameterValue("DF", this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd"));
                mp.SetParameterValue("DT", this.DateTimePickerTo.Value.ToString("yyyy/MM/dd"));
                if (this.CheckBoxAllUser.Checked)
                {
                    mp.SetParameterValue("ComboBoxUser", "الكل");
                }
                else
                {
                    mp.SetParameterValue("ComboBoxUser", this.ComboBoxUser.Text);
                }
                new A.HR { CRViewer = { ReportSource = mp } }.ShowDialog();
                mp.Close();
                mp.Dispose();
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual DateTimePicker DateTimePickerTo
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBoxUsers
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual ToolStrip ToolStripButtons
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual DateTimePicker PickerTimeFrom
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

        internal virtual System.Windows.Forms.Timer TimerLoadData
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                System.Windows.Forms.Timer a = this.A;
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

        internal virtual System.Windows.Forms.Timer TimersStartUp
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                System.Windows.Forms.Timer r = this.R;
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

        internal virtual System.Windows.Forms.Timer TimerFillGV
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                System.Windows.Forms.Timer p = this.P;
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

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTTotalCashOut
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label TxTTotalCashAdd
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual Label TxTTotalPurchReturn
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
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label TxTFinalNetPurch
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual Label TxTTotalSaleReturn
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Label TxTTotalPurch
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
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

        internal virtual Label TxTTotalCustomerPay
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual Label TxTTotalSale
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual ToolStrip ToolStrip1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripButton ToolStripButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripButton ToolStripButtonDelete
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

        internal virtual ToolStripSeparator ToolStripSeparator9
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Panel Panel2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxAllUser
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual Label TxTFCash
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
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

        internal virtual Label TxTTotalExpenes
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual Label TxTTotalSuplierPay
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual Label TxTFinalNetSale
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual Label Label11
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual ToolStripDropDownButton ToolStripButtonPrint
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem A4ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual ToolStripMenuItem CacheReportToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual ToolStripButton ToolStripButtonOpenCash
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual Label TXT0S
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual GroupBox GroupBox21
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual Label TXT6S
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual GroupBox GroupBox20
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual Label TXT5S
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual GroupBox GroupBox19
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual Label TXT4S
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual GroupBox GroupBox18
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual Label TXT3S
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual Label TXT2S
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual Label TXT1S
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual Button ButtonSortType
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

        internal virtual GroupBox GroupBox31
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual GroupBox GroupBox32
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual Label TXTN0
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual GroupBox GroupBox33
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual Label TXTN6
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual GroupBox GroupBox34
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }

        internal virtual Label TXTN1
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual GroupBox GroupBox35
        {
            [CompilerGenerated]
            get => 
                this.AR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.AR = value);
        }

        internal virtual Label TXTN5
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual GroupBox GroupBox36
        {
            [CompilerGenerated]
            get => 
                this.PR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.PR = value);
        }

        internal virtual Label TXTN2
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }

        internal virtual GroupBox GroupBox37
        {
            [CompilerGenerated]
            get => 
                this.QR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.QR = value);
        }

        internal virtual Label TXTN4
        {
            [CompilerGenerated]
            get => 
                this.AR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.AR = value);
        }

        internal virtual GroupBox GroupBox38
        {
            [CompilerGenerated]
            get => 
                this.IR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.IR = value);
        }

        internal virtual Label TXTN3
        {
            [CompilerGenerated]
            get => 
                this.PR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.PR = value);
        }

        internal virtual GroupBox GroupBox23
        {
            [CompilerGenerated]
            get => 
                this.DR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.DR = value);
        }

        internal virtual GroupBox GroupBox24
        {
            [CompilerGenerated]
            get => 
                this.FR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.FR = value);
        }

        internal virtual Label TXT0R
        {
            [CompilerGenerated]
            get => 
                this.QR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.QR = value);
        }

        internal virtual GroupBox GroupBox25
        {
            [CompilerGenerated]
            get => 
                this.HR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.HR = value);
        }

        internal virtual Label TXT6R
        {
            [CompilerGenerated]
            get => 
                this.IR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.IR = value);
        }

        internal virtual GroupBox GroupBox26
        {
            [CompilerGenerated]
            get => 
                this.TR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.TR = value);
        }

        internal virtual Label TXT1R
        {
            [CompilerGenerated]
            get => 
                this.DR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.DR = value);
        }

        internal virtual GroupBox GroupBox27
        {
            [CompilerGenerated]
            get => 
                this.XR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.XR = value);
        }

        internal virtual Label TXT5R
        {
            [CompilerGenerated]
            get => 
                this.FR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.FR = value);
        }

        internal virtual GroupBox GroupBox28
        {
            [CompilerGenerated]
            get => 
                this.GR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.GR = value);
        }

        internal virtual Label TXT2R
        {
            [CompilerGenerated]
            get => 
                this.HR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.HR = value);
        }

        internal virtual GroupBox GroupBox29
        {
            [CompilerGenerated]
            get => 
                this.ER;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.ER = value);
        }

        internal virtual Label TXT4R
        {
            [CompilerGenerated]
            get => 
                this.TR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.TR = value);
        }

        internal virtual GroupBox GroupBox30
        {
            [CompilerGenerated]
            get => 
                this.KR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.KR = value);
        }

        internal virtual Label TXT3R
        {
            [CompilerGenerated]
            get => 
                this.XR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.XR = value);
        }

        internal virtual GroupBox GroupBox22
        {
            [CompilerGenerated]
            get => 
                this.UR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.UR = value);
        }

        internal virtual System.Windows.Forms.Timer TimerSortType
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
                System.Windows.Forms.Timer q = this.Q;
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.GR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.GR = value);
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

