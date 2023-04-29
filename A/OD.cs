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
    public class OD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("ToolStripButtons"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonViewAll"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [AccessedThroughProperty("ToolStripButtonEdit"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton R;
        [AccessedThroughProperty("ToolStripSeparator3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripButtonDelete"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton P;
        [AccessedThroughProperty("ToolStripSeparator4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator P;
        [AccessedThroughProperty("ToolStripButtonCard"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton Q;
        [AccessedThroughProperty("ToolStripSeparator5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [AccessedThroughProperty("ToolStripSeparator6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator I;
        [AccessedThroughProperty("ToolStripButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton I;
        [AccessedThroughProperty("ToolStripSeparator7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator D;
        [AccessedThroughProperty("ToolStripStatus"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripProgressBar1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("ToolStripLabel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel A;
        [AccessedThroughProperty("TxTGVRowCount"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator F;
        [AccessedThroughProperty("TimerLoadData"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [AccessedThroughProperty("TabControl1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [AccessedThroughProperty("TabPage2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [AccessedThroughProperty("TabPage3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [AccessedThroughProperty("ButtonSortDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("GroupBoxUsers"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("ComboBoxUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("TabPage4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage Q;
        [AccessedThroughProperty("TabPage5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage I;
        [AccessedThroughProperty("TabPage6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage D;
        [AccessedThroughProperty("TabPage7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage F;
        [AccessedThroughProperty("GroupBox5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [AccessedThroughProperty("Label2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [AccessedThroughProperty("TxTMaxSerch2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("TxTMaxSerch1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("ButtonBetwenMax"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("GroupBox4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("SBBButtonBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [AccessedThroughProperty("SBBTxTBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [AccessedThroughProperty("PictureBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PictureBox A;
        [AccessedThroughProperty("GroupBox6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("ComboBoxCustomer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [AccessedThroughProperty("GroupBox3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("TxTNoSe"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [AccessedThroughProperty("GroupBox7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("InvSalePayType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox P;
        [AccessedThroughProperty("GroupBox8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [AccessedThroughProperty("InvSaleStatus"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox Q;
        [AccessedThroughProperty("GroupBox9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [AccessedThroughProperty("InvSaleType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox I;
        [AccessedThroughProperty("ButtonCustomer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button Q;
        [AccessedThroughProperty("ButtonUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button I;
        [AccessedThroughProperty("ButtonNote"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button D;
        [AccessedThroughProperty("ButtonPayType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button F;
        [AccessedThroughProperty("ButtonState"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button H;
        [AccessedThroughProperty("Panel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel A;
        [AccessedThroughProperty("GroupBox10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [AccessedThroughProperty("GroupBox14"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox X;
        [AccessedThroughProperty("TxTNetTotal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [AccessedThroughProperty("GroupBox13"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox G;
        [AccessedThroughProperty("TxTTotalProft"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label I;
        [AccessedThroughProperty("GroupBox12"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox E;
        [AccessedThroughProperty("TxTTotalDar"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [AccessedThroughProperty("GroupBox11"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [AccessedThroughProperty("TxTTotalDis"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        [AccessedThroughProperty("TxTTotalTotal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label H;
        [AccessedThroughProperty("TimerFillGV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [AccessedThroughProperty("GV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [AccessedThroughProperty("ToolStripButtonPrint"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton A;
        [AccessedThroughProperty("A4ToolStripMenuItemInvos"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("ToolStripSeparator2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator H;
        [AccessedThroughProperty("A4ToolStripMenuItemList"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("CheckBoxDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("ButtonSortAdvance"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button T;
        [AccessedThroughProperty("ButPrintArA4ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem P;
        [AccessedThroughProperty("ButPrintArA5ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem Q;
        [AccessedThroughProperty("ButPrintArRoll80ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem I;
        [AccessedThroughProperty("ButPrinteEnA4ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem D;
        [AccessedThroughProperty("ButPrintEnA5ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem F;
        [AccessedThroughProperty("ButPrintEnRoll80ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem H;
        [AccessedThroughProperty("ContextMenuStripCopyClipBoard"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ContextMenuStrip A;
        [AccessedThroughProperty("CopytoClipToolStripMenuItemToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem T;
        [AccessedThroughProperty("Label3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label T;
        [AccessedThroughProperty("ButtonAdVSort"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button X;
        [AccessedThroughProperty("ToolStripSeparator9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator T;
        [AccessedThroughProperty("ButPrintTAXAR"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem X;
        [AccessedThroughProperty("ButPrintTAXEN"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem G;
        [AccessedThroughProperty("GroupBox1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox U;
        [AccessedThroughProperty("DateTimePickerFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker R;
        [AccessedThroughProperty("GroupBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox L;
        [AccessedThroughProperty("DateTimePickerTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker P;
        [AccessedThroughProperty("PickerTimeTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker Q;
        [AccessedThroughProperty("ToolStripSeparator10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator X;
        [AccessedThroughProperty("ToolStripButtonE"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton D;
        private SqlConnection A;
        private int A;
        private DataTable A;
        private DataTable R;
        public static string A = "SELECT TaNNInvSale.*, TaNNCustomers.CustomerName FROM TaNNInvSale LEFT OUTER JOIN TaNNCustomers ON TaNNInvSale.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSale.CenterFrontID = @CenterFrontID) AND (TaNNInvSale.InvSaleType = @InvSaleType)";
        public static string R = "";
        private bool A;

        public OD()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = 0;
            this.A = new DataTable();
            this.R = new DataTable();
            this.A = false;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(OD));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ToolStripButtonEdit = new ToolStripButton();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ToolStripButtonCard = new ToolStripButton();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.A4ToolStripMenuItemInvos = new ToolStripMenuItem();
            this.ButPrintArA4ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrintArA5ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrintArRoll80ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrinteEnA4ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrintEnA5ToolStripMenuItem = new ToolStripMenuItem();
            this.ButPrintEnRoll80ToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.ButPrintTAXAR = new ToolStripMenuItem();
            this.ButPrintTAXEN = new ToolStripMenuItem();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.A4ToolStripMenuItemList = new ToolStripMenuItem();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator10 = new ToolStripSeparator();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowCount = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox1 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBox2 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.ButtonSortAdvance = new Button();
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
            this.TabPage6 = new TabPage();
            this.ButtonPayType = new Button();
            this.GroupBox7 = new GroupBox();
            this.InvSalePayType = new ComboBox();
            this.TabPage7 = new TabPage();
            this.ButtonState = new Button();
            this.GroupBox8 = new GroupBox();
            this.InvSaleStatus = new ComboBox();
            this.TxTTitle = new Label();
            this.Panel1 = new Panel();
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
            this.TimerFillGV = new Timer(this.A);
            this.GV = new DataGridView();
            this.ContextMenuStripCopyClipBoard = new ContextMenuStrip(this.A);
            this.CopytoClipToolStripMenuItemToolStripMenuItem = new ToolStripMenuItem();
            this.CheckBoxDate = new CheckBox();
            this.ToolStripButtonE = new ToolStripButton();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            this.TabPage3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBoxUsers.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.ContextMenuStripCopyClipBoard.SuspendLayout();
            base.SuspendLayout();
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[14];
            toolStripItems[0] = this.ToolStripButtonViewAll;
            toolStripItems[1] = this.ToolStripSeparator8;
            toolStripItems[2] = this.ToolStripButtonEdit;
            toolStripItems[3] = this.ToolStripSeparator3;
            toolStripItems[4] = this.ToolStripButtonDelete;
            toolStripItems[5] = this.ToolStripSeparator4;
            toolStripItems[6] = this.ToolStripButtonCard;
            toolStripItems[7] = this.ToolStripSeparator5;
            toolStripItems[8] = this.ToolStripButtonPrint;
            toolStripItems[9] = this.ToolStripSeparator6;
            toolStripItems[10] = this.ToolStripButtonE;
            toolStripItems[11] = this.ToolStripSeparator7;
            toolStripItems[12] = this.ToolStripButtonClose;
            toolStripItems[13] = this.ToolStripSeparator10;
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x24d);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x59;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(6, 0x2f);
            this.ToolStripButtonEdit.Image = A.F.ImEdit;
            this.ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new Size(0xa4, 0x2c);
            this.ToolStripButtonEdit.Text = "تعديل الفاتورة المحددة";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x2f);
            this.ToolStripButtonDelete.Image = A.F.ImDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(0xa1, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف الفاتورة المحددة";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x2f);
            this.ToolStripButtonCard.Image = A.F.ImCard;
            this.ToolStripButtonCard.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonCard.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonCard.Name = "ToolStripButtonCard";
            this.ToolStripButtonCard.Size = new Size(0xcd, 0x2c);
            this.ToolStripButtonCard.Text = "عرض تفاصيل الفاتورة المحددة";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.A4ToolStripMenuItemInvos, this.ToolStripSeparator2, this.A4ToolStripMenuItemList };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray2);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x56, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة";
            ToolStripItem[] itemArray3 = new ToolStripItem[9];
            itemArray3[0] = this.ButPrintArA4ToolStripMenuItem;
            itemArray3[1] = this.ButPrintArA5ToolStripMenuItem;
            itemArray3[2] = this.ButPrintArRoll80ToolStripMenuItem;
            itemArray3[3] = this.ButPrinteEnA4ToolStripMenuItem;
            itemArray3[4] = this.ButPrintEnA5ToolStripMenuItem;
            itemArray3[5] = this.ButPrintEnRoll80ToolStripMenuItem;
            itemArray3[6] = this.ToolStripSeparator9;
            itemArray3[7] = this.ButPrintTAXAR;
            itemArray3[8] = this.ButPrintTAXEN;
            this.A4ToolStripMenuItemInvos.DropDownItems.AddRange(itemArray3);
            this.A4ToolStripMenuItemInvos.Image = (Image) manager.GetObject("A4ToolStripMenuItemInvos.Image");
            this.A4ToolStripMenuItemInvos.ImageScaling = ToolStripItemImageScaling.None;
            this.A4ToolStripMenuItemInvos.Name = "A4ToolStripMenuItemInvos";
            this.A4ToolStripMenuItemInvos.Size = new Size(0xb2, 0x26);
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
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new Size(0xe7, 6);
            this.ButPrintTAXAR.Name = "ButPrintTAXAR";
            this.ButPrintTAXAR.Size = new Size(0xea, 0x16);
            this.ButPrintTAXAR.Text = "فاتورة ضريبية رسمية عربي";
            this.ButPrintTAXEN.Name = "ButPrintTAXEN";
            this.ButPrintTAXEN.Size = new Size(0xea, 0x16);
            this.ButPrintTAXEN.Text = "فاتورة ضريبية رسمية انجليزي";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(0xaf, 6);
            this.A4ToolStripMenuItemList.Image = (Image) manager.GetObject("A4ToolStripMenuItemList.Image");
            this.A4ToolStripMenuItemList.ImageScaling = ToolStripItemImageScaling.None;
            this.A4ToolStripMenuItemList.Name = "A4ToolStripMenuItemList";
            this.A4ToolStripMenuItemList.Size = new Size(0xb2, 0x26);
            this.A4ToolStripMenuItemList.Text = "القائمة اعلاه A4";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new Size(6, 0x2f);
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(6, 0x2f);
            this.ToolStripButtonClose.Image = A.F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x2c);
            this.ToolStripButtonClose.Text = "اغلاق";
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new Size(6, 0x2f);
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray4);
            this.ToolStripStatus.Location = new Point(0, 0x27c);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x58;
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
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Controls.Add(this.TabPage7);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 120);
            this.TabControl1.TabIndex = 110;
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.ButtonSortAdvance);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.ButtonSortDate);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3d0, 0x5b);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الرئيسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x218, 7);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb0, 0x4a);
            this.GroupBox1.TabIndex = 0x1ed36cd;
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
            this.GroupBox2.Location = new Point(340, 9);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xb0, 0x48);
            this.GroupBox2.TabIndex = 0x1ed36ce;
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
            this.ButtonSortAdvance.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortAdvance.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortAdvance.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortAdvance.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortAdvance.FlatStyle = FlatStyle.Flat;
            this.ButtonSortAdvance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortAdvance.Image = A.F.ImSort;
            this.ButtonSortAdvance.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortAdvance.Location = new Point(0x11, 0x19);
            this.ButtonSortAdvance.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortAdvance.Name = "ButtonSortAdvance";
            this.ButtonSortAdvance.Size = new Size(0xa7, 0x35);
            this.ButtonSortAdvance.TabIndex = 0x40;
            this.ButtonSortAdvance.Text = "فرز متقدم";
            this.ButtonSortAdvance.UseVisualStyleBackColor = true;
            this.GroupBox9.Controls.Add(this.InvSaleType);
            this.GroupBox9.Location = new Point(0x2ce, 9);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(250, 0x35);
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
            this.InvSaleType.Size = new Size(0xf4, 0x18);
            this.InvSaleType.TabIndex = 0x2c;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(190, 0x19);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(0x90, 0x35);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.GroupBox5);
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x3d0, 0x5b);
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
            this.TabPage3.Controls.Add(this.ButtonAdVSort);
            this.TabPage3.Controls.Add(this.Label3);
            this.TabPage3.Controls.Add(this.ButtonCustomer);
            this.TabPage3.Controls.Add(this.GroupBox6);
            this.TabPage3.Location = new Point(4, 0x19);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x3d0, 0x5b);
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
            this.ButtonAdVSort.Location = new Point(0x15b, 0x11);
            this.ButtonAdVSort.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdVSort.Name = "ButtonAdVSort";
            this.ButtonAdVSort.Size = new Size(0x97, 0x2c);
            this.ButtonAdVSort.TabIndex = 0x4a;
            this.ButtonAdVSort.Text = "فرز متقدم";
            this.ButtonAdVSort.UseVisualStyleBackColor = true;
            this.Label3.Dock = DockStyle.Left;
            this.Label3.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label3.Location = new Point(0, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x14b, 0x5b);
            this.Label3.TabIndex = 0x47;
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
            this.ButtonCustomer.Location = new Point(0x1f5, 0x11);
            this.ButtonCustomer.Margin = new Padding(3, 4, 3, 4);
            this.ButtonCustomer.Name = "ButtonCustomer";
            this.ButtonCustomer.Size = new Size(0x7d, 0x2c);
            this.ButtonCustomer.TabIndex = 70;
            this.ButtonCustomer.Text = "فرز";
            this.ButtonCustomer.UseVisualStyleBackColor = true;
            this.GroupBox6.Controls.Add(this.ComboBoxCustomer);
            this.GroupBox6.Location = new Point(0x286, 9);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(320, 0x36);
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
            this.ComboBoxCustomer.Size = new Size(0x13a, 0x18);
            this.ComboBoxCustomer.TabIndex = 0x44;
            this.TabPage4.Controls.Add(this.ButtonUser);
            this.TabPage4.Controls.Add(this.GroupBoxUsers);
            this.TabPage4.Location = new Point(4, 0x19);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x3d0, 0x5b);
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
            this.ButtonUser.Location = new Point(0x158, 0x11);
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
            this.TabPage5.Size = new Size(0x3d0, 0x5b);
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
            this.TabPage6.Controls.Add(this.ButtonPayType);
            this.TabPage6.Controls.Add(this.GroupBox7);
            this.TabPage6.Location = new Point(4, 0x19);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new Size(0x3d0, 0x5b);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "فرز حسب  طريقة الدفع";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.ButtonPayType.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPayType.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPayType.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPayType.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPayType.FlatStyle = FlatStyle.Flat;
            this.ButtonPayType.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPayType.Image = A.F.ImSort;
            this.ButtonPayType.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPayType.Location = new Point(0x15c, 14);
            this.ButtonPayType.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPayType.Name = "ButtonPayType";
            this.ButtonPayType.Size = new Size(280, 0x2c);
            this.ButtonPayType.TabIndex = 0x1ed36ce;
            this.ButtonPayType.Text = "فرز";
            this.ButtonPayType.UseVisualStyleBackColor = true;
            this.GroupBox7.Controls.Add(this.InvSalePayType);
            this.GroupBox7.Location = new Point(0x2a3, 8);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x11a, 0x33);
            this.GroupBox7.TabIndex = 0x1ed36cd;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "طريقة الدفع";
            this.InvSalePayType.Dock = DockStyle.Fill;
            this.InvSalePayType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvSalePayType.FormattingEnabled = true;
            object[] objArray2 = new object[] { "نقدا", "ذمم", "شبكة", "تحويل", "الرصيد المدور", "شيك", "إئتمان" };
            this.InvSalePayType.Items.AddRange(objArray2);
            this.InvSalePayType.Location = new Point(3, 0x13);
            this.InvSalePayType.Name = "InvSalePayType";
            this.InvSalePayType.Size = new Size(0x114, 0x18);
            this.InvSalePayType.TabIndex = 0x1ed36cc;
            this.TabPage7.Controls.Add(this.ButtonState);
            this.TabPage7.Controls.Add(this.GroupBox8);
            this.TabPage7.Location = new Point(4, 0x19);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Size = new Size(0x3d0, 0x5b);
            this.TabPage7.TabIndex = 6;
            this.TabPage7.Text = "فرز حسب الحالة";
            this.TabPage7.UseVisualStyleBackColor = true;
            this.ButtonState.FlatAppearance.BorderColor = Color.Green;
            this.ButtonState.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonState.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonState.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonState.FlatStyle = FlatStyle.Flat;
            this.ButtonState.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonState.Image = A.F.ImSort;
            this.ButtonState.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonState.Location = new Point(0x164, 0x13);
            this.ButtonState.Margin = new Padding(3, 4, 3, 4);
            this.ButtonState.Name = "ButtonState";
            this.ButtonState.Size = new Size(280, 0x2c);
            this.ButtonState.TabIndex = 0x1ed36cf;
            this.ButtonState.Text = "فرز";
            this.ButtonState.UseVisualStyleBackColor = true;
            this.GroupBox8.Controls.Add(this.InvSaleStatus);
            this.GroupBox8.Location = new Point(0x2ae, 11);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x11a, 0x33);
            this.GroupBox8.TabIndex = 0x1ed36ce;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "حالة الفاتورة";
            this.InvSaleStatus.Dock = DockStyle.Fill;
            this.InvSaleStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvSaleStatus.FormattingEnabled = true;
            object[] objArray3 = new object[] { "مكتملة", "معلقة", "قيد التعديل", "معدلة" };
            this.InvSaleStatus.Items.AddRange(objArray3);
            this.InvSaleStatus.Location = new Point(3, 0x13);
            this.InvSaleStatus.Name = "InvSaleStatus";
            this.InvSaleStatus.Size = new Size(0x114, 0x18);
            this.InvSaleStatus.TabIndex = 0x1ed36cc;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d8, 0x22);
            this.TxTTitle.TabIndex = 0x6d;
            this.TxTTitle.Text = "قائمة فواتير المبيعات/ مرتجع المبيعات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Panel1.BackColor = SystemColors.HighlightText;
            this.Panel1.BorderStyle = BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox14);
            this.Panel1.Controls.Add(this.GroupBox13);
            this.Panel1.Controls.Add(this.GroupBox12);
            this.Panel1.Controls.Add(this.GroupBox11);
            this.Panel1.Controls.Add(this.GroupBox10);
            this.Panel1.Dock = DockStyle.Bottom;
            this.Panel1.Location = new Point(0, 0x213);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x3d8, 0x3a);
            this.Panel1.TabIndex = 0x1ed36cc;
            this.GroupBox14.Controls.Add(this.TxTNetTotal);
            this.GroupBox14.Dock = DockStyle.Right;
            this.GroupBox14.Location = new Point(180, 0);
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
            this.GroupBox13.Location = new Point(340, 0);
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
            this.GroupBox12.Location = new Point(500, 0);
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
            this.GroupBox11.Location = new Point(660, 0);
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
            this.GroupBox10.Location = new Point(820, 0);
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
            this.GV.Location = new Point(0, 0xb6);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3d8, 0x15d);
            this.GV.TabIndex = 0x1ed36cf;
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.CopytoClipToolStripMenuItemToolStripMenuItem };
            this.ContextMenuStripCopyClipBoard.Items.AddRange(itemArray5);
            this.ContextMenuStripCopyClipBoard.Name = "ContextMenuStripCopyClipBoard";
            this.ContextMenuStripCopyClipBoard.Size = new Size(0xaf, 0x1a);
            this.CopytoClipToolStripMenuItemToolStripMenuItem.Name = "CopytoClipToolStripMenuItemToolStripMenuItem";
            this.CopytoClipToolStripMenuItemToolStripMenuItem.Size = new Size(0xae, 0x16);
            this.CopytoClipToolStripMenuItemToolStripMenuItem.Text = "نسخ القائمة للحافظة";
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxDate.Checked = true;
            this.CheckBoxDate.CheckState = CheckState.Checked;
            this.CheckBoxDate.Dock = DockStyle.Top;
            this.CheckBoxDate.Location = new Point(0, 0x9a);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Padding = new Padding(4);
            this.CheckBoxDate.Size = new Size(0x3d8, 0x1c);
            this.CheckBoxDate.TabIndex = 0x1ed36cb;
            this.CheckBoxDate.Text = "تضمين فترة التاريخ دائماً مع كل عمليات الفرز";
            this.CheckBoxDate.UseVisualStyleBackColor = false;
            this.ToolStripButtonE.Image = A.F.ImPendingList;
            this.ToolStripButtonE.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonE.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonE.Name = "ToolStripButtonE";
            this.ToolStripButtonE.Size = new Size(0x4a, 0x2c);
            this.ToolStripButtonE.Text = "تصدير";
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3d8, 0x295);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.CheckBoxDate);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "InvoiceSaleList";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "قائمة فواتير المبيعات/ مرتجع المبيعات";
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((ISupportInitialize) this.PictureBox2).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.GroupBoxUsers.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.TabPage7.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
            this.ContextMenuStripCopyClipBoard.ResumeLayout(false);
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

        private void AR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void B(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.Q();
            }
        }

        private void C(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.H();
            }
        }

        private void D(object A, EventArgs R)
        {
            OD.R = OD.A;
            if (!this.CheckBoxDate.Checked)
            {
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleIDMAX BETWEEN @MAXDF and @MAXDT)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSale.InvSaleIDMAX BETWEEN @MAXDF and @MAXDT)";
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

        private void DR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void E(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void F(object A, EventArgs R)
        {
            OD.R = OD.A;
            if (!this.CheckBoxDate.Checked)
            {
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleUserAddBy = @InvSaleUserAddBy)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSale.InvSaleUserAddBy = @InvSaleUserAddBy)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void G(object A, EventArgs R)
        {
            OD.R = OD.A;
            if (!this.CheckBoxDate.Checked)
            {
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleStatus = @InvSaleStatus)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSale.InvSaleStatus = @InvSaleStatus)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void H(object A, EventArgs R)
        {
            OD.R = OD.A;
            if (!this.CheckBoxDate.Checked)
            {
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleID = @InvSaleID)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSale.InvSaleID = @InvSaleID)";
            }
            this.TimerLoadData.Enabled = true;
        }

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            OD.R = OD.A;
            if (!this.CheckBoxDate.Checked)
            {
                OD.R = OD.A + " AND (TaNNInvSale.CustomerFrontID = @CustomerFrontID)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSale.CustomerFrontID = @CustomerFrontID)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void IR(object A, EventArgs R)
        {
            string str2 = DateTime.Now.ToString("dd");
            if (Interaction.InputBox("", "Admin", "", -1, -1) == ("120030811017" + str2))
            {
                this.A = true;
                Interaction.MsgBox("Admin Mode Active", MsgBoxStyle.ApplicationModal, null);
                this.GV.Columns["InvSaleMonBas"].Visible = true;
                this.GV.Columns["InvSaleMonPay"].Visible = true;
                this.GV.Columns["InvSaleMonBak"].Visible = true;
                this.GV.Columns["InvSaleMonDem"].Visible = true;
                this.GV.Columns["InvSaleMonRod"].Visible = true;
                this.GV.Columns["InvSaleIsMonRod"].Visible = true;
            }
        }

        private void J(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.T();
            }
        }

        private void K(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    this.A = this.GV.CurrentRow.Index;
                    ND.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
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

        private void L(object A, EventArgs R)
        {
            if ((A.PR.KR & A.PR.DR) && !A.PR.R)
            {
                Interaction.MsgBox("حسب التعليمات الحكومية، ولكونك تستخدم ادوات الربط الخارجية لا يجوز تنفيذ هذا الأمر", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    if (!A.PR.RP)
                    {
                        Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
                    }
                    else if (Information.IsNothing(this.GV.CurrentRow))
                    {
                        Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                    }
                    else
                    {
                        this.A = this.GV.CurrentRow.Index;
                        ZD.A = true;
                        ZD.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
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
        }

        private void M(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.F();
            }
        }

        private void N(object A, EventArgs R)
        {
            if ((A.PR.KR & A.PR.DR) && !A.PR.R)
            {
                Interaction.MsgBox("حسب التعليمات الحكومية، ولكونك تستخدم ادوات الربط الخارجية لا يجوز تنفيذ هذا الأمر", MsgBoxStyle.ApplicationModal, null);
            }
            else if (!A.PR.AP)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                this.A = this.GV.CurrentRow.Index;
                ZD.A = false;
                ZD.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.ShowDialog();
            }
        }

        private void O(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
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
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            if (OD.R == null)
            {
                OD.R = OD.A;
            }
            this.TimerFillGV.Enabled = true;
        }

        private void PR(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.X();
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

        private void Q(object A, EventArgs R)
        {
            OD.R = OD.A;
            if (this.CheckBoxDate.Checked)
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void QR(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.G();
            }
        }

        public void R()
        {
            try
            {
                IEnumerator enumerator;
                IEnumerator enumerator2;
                DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
                DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                this.R.Clear();
                this.A.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(R, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                string text = this.SBBTxTBarCode.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleID", text ?? DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleType", this.InvSaleType.SelectedIndex);
                string text2 = this.SBBTxTBarCode.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleIDMAX", text2 ?? DBNull.Value);
                string text3 = this.TxTMaxSerch1.Text;
                adapter.SelectCommand.Parameters.AddWithValue("MAXDF", text3 ?? DBNull.Value);
                string text4 = this.TxTMaxSerch2.Text;
                adapter.SelectCommand.Parameters.AddWithValue("MAXDT", text4 ?? DBNull.Value);
                string text5 = this.InvSaleStatus.SelectedIndex.ToString();
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleStatus", text5 ?? DBNull.Value);
                string text6 = this.InvSalePayType.SelectedIndex.ToString();
                adapter.SelectCommand.Parameters.AddWithValue("InvSalePayType", text6 ?? DBNull.Value);
                string text7 = time.ToString("yyyy/MM/dd HH:mm");
                adapter.SelectCommand.Parameters.AddWithValue("DF", text7 ?? DBNull.Value);
                string text8 = time2.ToString("yyyy/MM/dd HH:mm");
                adapter.SelectCommand.Parameters.AddWithValue("DT", text8 ?? DBNull.Value);
                object selectedValue = this.ComboBoxCustomer.SelectedValue;
                adapter.SelectCommand.Parameters.AddWithValue("CustomerFrontID", selectedValue ?? DBNull.Value);
                string text9 = this.ComboBoxUser.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleUserAddBy", text9 ?? DBNull.Value);
                string text10 = this.TxTNoSe.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleNote", text10 ?? DBNull.Value);
                adapter.Fill(this.R);
                adapter.Fill(this.A);
                this.A.Close();
                decimal left = 0M;
                decimal num2 = 0M;
                decimal num3 = 0M;
                decimal num4 = 0M;
                decimal num5 = 0M;
                try
                {
                    enumerator = this.R.Rows.GetEnumerator();
                    while (true)
                    {
                        if (!enumerator.MoveNext())
                        {
                            break;
                        }
                        object current = enumerator.Current;
                        object[] arguments = new object[] { "InvSaleTotalAmount" };
                        left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                        object[] objArray2 = new object[] { "InvSaleDisVal" };
                        num2 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num2, NewLateBinding.LateIndexGet(current, objArray2, null)));
                        object[] objArray3 = new object[] { "InvSaleDarVal" };
                        num3 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num3, NewLateBinding.LateIndexGet(current, objArray3, null)));
                        object[] objArray4 = new object[] { "InvSaleTotalProft" };
                        num4 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num4, NewLateBinding.LateIndexGet(current, objArray4, null)));
                        object[] objArray5 = new object[] { "InvSaleTotalNET" };
                        num5 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num5, NewLateBinding.LateIndexGet(current, objArray5, null)));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                this.TxTTotalTotal.Text = left.ToString(A.PR.YR);
                this.TxTTotalDis.Text = num2.ToString(A.PR.YR);
                this.TxTTotalDar.Text = num3.ToString(A.PR.YR);
                this.TxTTotalProft.Text = !A.PR.BP ? "مخفي" : num4.ToString(A.PR.YR);
                this.TxTNetTotal.Text = num5.ToString(A.PR.YR);
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
                if (A.PR.BP)
                {
                    this.GV.Columns["InvSaleTotalProft"].HeaderText = "الربح";
                }
                else
                {
                    this.GV.Columns["InvSaleTotalProft"].Visible = false;
                }
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
                this.GV.Columns["InvSaleCafeText"].Visible = false;
                this.GV.Columns["InvSaleIsCashCount"].HeaderText = "مقيدة على الكاش";
                this.GV.Columns["InvSaleCusLastBalance"].Visible = false;
                this.GV.Columns["InvSaleCusOrdarNo"].Visible = false;
                this.GV.Columns["CustomerName"].HeaderText = "العميل";
                this.GV.Columns["InvSaleQR"].Visible = false;
                this.GV.Columns["Taxabl"].Visible = false;
                this.GV.Columns["UUID"].Visible = false;
                this.GV.Columns["HashQR"].Visible = false;
                this.GV.Columns["ReID"].Visible = false;
                this.GV.Columns["ReHashQR"].Visible = false;
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (this.GV.RowCount > 0)
                {
                    this.ToolStripButtonEdit.Enabled = true;
                    this.ToolStripButtonDelete.Enabled = true;
                    this.ToolStripButtonCard.Enabled = true;
                }
                else
                {
                    this.ToolStripButtonEdit.Enabled = false;
                    this.ToolStripButtonDelete.Enabled = false;
                    this.ToolStripButtonCard.Enabled = false;
                }
                this.TxTGVRowCount.Text = Conversions.ToString(this.GV.RowCount);
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = this.GV.RowCount;
                this.ToolStripProgressBar1.Minimum = 0;
                try
                {
                    enumerator2 = ((IEnumerable) this.GV.Rows).GetEnumerator();
                    while (true)
                    {
                        if (!enumerator2.MoveNext())
                        {
                            break;
                        }
                        DataGridViewRow current = (DataGridViewRow) enumerator2.Current;
                        this.ToolStripProgressBar1.Value = current.Index;
                        decimal num7 = new decimal(Conversion.Val(current.Cells["InvSaleTotalAmount"].Value.ToString()));
                        decimal num8 = new decimal(Conversion.Val(current.Cells["InvSaleDisVal"].Value.ToString()));
                        decimal num9 = new decimal(Conversion.Val(current.Cells["InvSaleDarVal"].Value.ToString()));
                        decimal num10 = new decimal(Conversion.Val(current.Cells["InvSaleTotalNET"].Value.ToString()));
                        decimal num11 = new decimal(Conversion.Val(current.Cells["InvSaleTotalProft"].Value.ToString()));
                        current.Cells["InvSaleTotalAmount"].Value = num7.ToString(A.PR.YR);
                        current.Cells["InvSaleDisVal"].Value = num8.ToString(A.PR.YR);
                        current.Cells["InvSaleDarVal"].Value = num9.ToString(A.PR.YR);
                        current.Cells["InvSaleTotalNET"].Value = num10.ToString(A.PR.YR);
                        current.Cells["InvSaleTotalProft"].Value = num11.ToString(A.PR.YR);
                        decimal num12 = new decimal(Conversion.Val(current.Cells["InvSaleType"].Value.ToString()));
                        decimal num13 = new decimal(Conversion.Val(current.Cells["InvSaleStatus"].Value.ToString()));
                        decimal num14 = new decimal(Conversion.Val(current.Cells["InvSalePayType"].Value.ToString()));
                        if (decimal.Compare(num12, decimal.Zero) == 0)
                        {
                            current.Cells["InvSaleType"].Value = "فاتورة مبيعات";
                        }
                        else if (decimal.Compare(num12, decimal.One) == 0)
                        {
                            current.Cells["InvSaleType"].Value = "مرتجع مبيعات";
                        }
                        if (decimal.Compare(num14, decimal.Zero) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "نقدا";
                        }
                        else if (decimal.Compare(num14, decimal.One) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "ذمم";
                        }
                        else if (decimal.Compare(num14, 2M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "شبكة";
                        }
                        else if (decimal.Compare(num14, 3M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "تحويل";
                        }
                        else if (decimal.Compare(num14, 4M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "الرصيد المدور";
                        }
                        else if (decimal.Compare(num14, 5M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "شيك";
                        }
                        else if (decimal.Compare(num14, 6M) == 0)
                        {
                            current.Cells["InvSalePayType"].Value = "إئتمان";
                        }
                        if (decimal.Compare(num13, decimal.Zero) == 0)
                        {
                            current.Cells["InvSaleStatus"].Value = "مكتملة";
                        }
                        else if (decimal.Compare(num13, decimal.One) == 0)
                        {
                            current.Cells["InvSaleStatus"].Value = "معلقة";
                        }
                        else if (decimal.Compare(num13, 2M) == 0)
                        {
                            current.Cells["InvSaleStatus"].Value = "قيد التعديل";
                        }
                        else if (decimal.Compare(num13, 3M) == 0)
                        {
                            current.Cells["InvSaleStatus"].Value = "معدلة";
                        }
                    }
                }
                finally
                {
                    if (enumerator2 is IDisposable)
                    {
                        (enumerator2 as IDisposable).Dispose();
                    }
                }
                this.ToolStripProgressBar1.Visible = false;
                this.I();
                this.CheckBoxDate.ForeColor = Color.Black;
                if (this.InvSaleType.SelectedIndex == 0)
                {
                    this.TxTTitle.Text = "قائمة فواتير المبيعات";
                    this.TxTTitle.ForeColor = Color.DarkGreen;
                    this.TxTTitle.Font = new Font("Tahoma", 12f);
                }
                else if (this.InvSaleType.SelectedIndex == 1)
                {
                    this.TxTTitle.Text = "قائمة فواتير مرتجع المبيعات";
                    this.TxTTitle.ForeColor = Color.DarkBlue;
                    this.TxTTitle.Font = new Font("Tahoma", 12f);
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
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.P();
            this.Q();
            this.TimerLoadData.Enabled = true;
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonNote.PerformClick();
            }
        }

        private void S(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.I();
            }
        }

        private void T(object A, EventArgs R)
        {
            OD.R = OD.A;
            if (!this.CheckBoxDate.Checked)
            {
                OD.R = OD.A + " AND (InvSaleNote LIKE '%' + @InvSaleNote + '%')";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT) AND (InvSaleNote LIKE '%' + @InvSaleNote + '%')";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void U(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
        }

        private void V(object A, EventArgs R)
        {
            OD.R = OD.A;
            this.TimerLoadData.Enabled = true;
        }

        private void W(object A, EventArgs R)
        {
            this.GV.MultiSelect = true;
            this.GV.SelectAll();
            Clipboard.SetDataObject(this.GV.GetClipboardContent(), true);
            Interaction.MsgBox("تم نسخ القائمة للحافظة", MsgBoxStyle.ApplicationModal, null);
            this.GV.MultiSelect = false;
        }

        private void X(object A, EventArgs R)
        {
            OD.R = OD.A;
            if (!this.CheckBoxDate.Checked)
            {
                OD.R = OD.A + " AND (TaNNInvSale.InvSalePayType = @InvSalePayType)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                OD.R = OD.A + " AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSale.InvSalePayType = @InvSalePayType)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void Y(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                MQ mq = new MQ();
                mq.SetDataSource(this.A);
                mq.SetParameterValue("CenterName", A.PR.ER.ToString());
                mq.SetParameterValue("CenterSubName", A.PR.KR.ToString());
                mq.SetParameterValue("ParameterDeimelQ", A.PR.X);
                mq.SetParameterValue("ParameterDeimelS", A.PR.T);
                mq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (A.PR.NR == null)
                {
                    mq.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    mq.SetParameterValue("CenterCurrencyName", A.PR.NR.ToString());
                }
                if (A.PR.UR == null)
                {
                    mq.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    mq.SetParameterValue("CenterPhone", A.PR.UR.ToString());
                }
                mq.SetParameterValue("TxTSubTotal", this.TxTTotalTotal.Text);
                mq.SetParameterValue("TXTDar", this.TxTTotalDar.Text);
                mq.SetParameterValue("TXTDis", this.TxTTotalDis.Text);
                mq.SetParameterValue("TxTNetTotal", this.TxTNetTotal.Text);
                mq.SetParameterValue("TxTNetTotal", this.TxTNetTotal.Text);
                mq.SetParameterValue("RPTitle", this.TxTTitle.Text);
                if (A.PR.C)
                {
                    mq.SetParameterValue("TxTProft", this.TxTTotalProft.Text);
                    mq.ReportDefinition.ReportObjects["TextProft"].ObjectFormat.EnableSuppress = false;
                    mq.ReportDefinition.ReportObjects["XProft1"].ObjectFormat.EnableSuppress = false;
                }
                else
                {
                    mq.SetParameterValue("TxTProft", "مخفي");
                    mq.ReportDefinition.ReportObjects["TextProft"].ObjectFormat.EnableSuppress = true;
                    mq.ReportDefinition.ReportObjects["XProft1"].ObjectFormat.EnableSuppress = true;
                }
                new HR { CRViewer = { ReportSource = mq } }.ShowDialog();
                mq.Close();
                mq.Dispose();
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

        private void Z(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                LF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvSaleID"].Value.ToString());
                A.D.A.A.D();
            }
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
                EventHandler handler = new EventHandler(this.V);
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

        internal virtual ToolStripButton ToolStripButtonEdit
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
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

        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripButton ToolStripButtonDelete
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
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

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripButton ToolStripButtonCard
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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

        internal virtual ToolStripSeparator ToolStripSeparator5
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripButton ToolStripButtonClose
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                ToolStripButton i = this.I;
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

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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
            set
            {
                EventHandler handler = new EventHandler(this.IR);
                ToolStripLabel a = this.A;
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
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
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

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBoxUsers
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual TabPage TabPage4
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

        internal virtual TabPage TabPage6
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TabPage TabPage7
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
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
                EventHandler handler = new EventHandler(this.H);
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
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox p = this.P;
                if (p != null)
                {
                    p.KeyPress -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.KeyPress += handler;
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox TxTNoSe
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.R);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.KeyPress -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.KeyPress += handler;
                }
            }
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

        internal virtual ComboBox InvSalePayType
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual ComboBox InvSaleStatus
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual ComboBox InvSaleType
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Button ButtonCustomer
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Button ButtonUser
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

        internal virtual Button ButtonNote
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual Button ButtonPayType
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual Button ButtonState
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual Panel Panel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
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
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
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
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
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
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
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

        internal virtual Label TxTTotalTotal
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Timer TimerFillGV
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual ToolStripDropDownButton ToolStripButtonPrint
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem A4ToolStripMenuItemInvos
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual ToolStripMenuItem A4ToolStripMenuItemList
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
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

        internal virtual CheckBox CheckBoxDate
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonSortAdvance
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
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

        internal virtual ToolStripMenuItem ButPrintArA4ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.B);
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

        internal virtual ToolStripMenuItem ButPrintArA5ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
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

        internal virtual ToolStripMenuItem ButPrintArRoll80ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Z);
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

        internal virtual ToolStripMenuItem ButPrinteEnA4ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.M);
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

        internal virtual ToolStripMenuItem ButPrintEnA5ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.C);
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

        internal virtual ToolStripMenuItem ButPrintEnRoll80ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.J);
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
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.W);
                ToolStripMenuItem t = this.T;
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

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Button ButtonAdVSort
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.AR);
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

        internal virtual ToolStripSeparator ToolStripSeparator9
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual ToolStripMenuItem ButPrintTAXAR
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PR);
                ToolStripMenuItem x = this.X;
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

        internal virtual ToolStripMenuItem ButPrintTAXEN
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.QR);
                ToolStripMenuItem g = this.G;
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
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
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
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
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

        internal virtual ToolStripSeparator ToolStripSeparator10
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual ToolStripButton ToolStripButtonE
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.DR);
                ToolStripButton d = this.D;
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

