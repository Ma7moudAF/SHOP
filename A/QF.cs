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
    public class QF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("ButtonGroup"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("TxTSerQQ"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("TimerLoadData"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("TabControl1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [AccessedThroughProperty("ComboBoxSerachWat"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("TxTSerach"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("ButtonSearchCodeName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("TabPage2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [CompilerGenerated, AccessedThroughProperty("ComboBoxGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [CompilerGenerated, AccessedThroughProperty("ButtonSortGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [AccessedThroughProperty("TabPage3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [AccessedThroughProperty("TxTInputDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [AccessedThroughProperty("DateTimePicker"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private System.Windows.Forms.DateTimePicker A;
        [AccessedThroughProperty("ButtonSortDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button Q;
        [AccessedThroughProperty("TabPage4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage Q;
        [AccessedThroughProperty("ButtonSortQuntty"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button I;
        [AccessedThroughProperty("ButtonSortQunttyAdv"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button D;
        [AccessedThroughProperty("ToolStripLabel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel A;
        [AccessedThroughProperty("TxTGVRowCount"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [AccessedThroughProperty("ToolStripStatus"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("CheckBoxAll"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("ToolStripProgressBar1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("XTxTBarCodeLink"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [AccessedThroughProperty("TimersStartUp"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [AccessedThroughProperty("ToolStripButtonAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripSeparator4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator P;
        [AccessedThroughProperty("ToolStripSeparator5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [AccessedThroughProperty("ToolStripSeparator6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator I;
        [AccessedThroughProperty("ToolStripButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton R;
        [AccessedThroughProperty("ToolStripButtons"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripSeparator3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator D;
        [AccessedThroughProperty("GV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [AccessedThroughProperty("ToolStripSeparator7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator F;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonViewAll"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator11"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator H;
        [CompilerGenerated, AccessedThroughProperty("Panel1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel A;
        [CompilerGenerated, AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [AccessedThroughProperty("GroupBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("GroupBox5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [CompilerGenerated, AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonCard"), CompilerGenerated]
        private ToolStripDropDownButton A;
        [CompilerGenerated, AccessedThroughProperty("CardViewSale"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonEdit"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton R;
        [AccessedThroughProperty("ButtonEditeMulti"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator T;
        [AccessedThroughProperty("ButtonEditSingle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem P;
        [AccessedThroughProperty("ToolStripDropDownButtonTrDe"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton P;
        [AccessedThroughProperty("ToolStripSeparator9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator X;
        [AccessedThroughProperty("ToolStripButtonReport"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton Q;
        [AccessedThroughProperty("ToolStripSeparator10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator G;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator12"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator E;
        [CompilerGenerated, AccessedThroughProperty("CardViewReturnSale"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem Q;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator14"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator K;
        [AccessedThroughProperty("ToolStripSeparator15"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator U;
        [CompilerGenerated, AccessedThroughProperty("CardViewReturnPurch"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem I;
        [CompilerGenerated, AccessedThroughProperty("CardViewPurch"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonTrDsAddDs"), CompilerGenerated]
        private ToolStripMenuItem F;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator16"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator L;
        [AccessedThroughProperty("ButtonTrDsAddTr"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem H;
        [AccessedThroughProperty("ToolStripSeparator17"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator N;
        [AccessedThroughProperty("ButtonTrDsView"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem T;
        [CompilerGenerated, AccessedThroughProperty("CardViewDDs"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem X;
        [CompilerGenerated, AccessedThroughProperty("CardViewTTr"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem G;
        [AccessedThroughProperty("TabPage6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage I;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonDelete"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonDeleteMulti"), CompilerGenerated]
        private ToolStripMenuItem E;
        [AccessedThroughProperty("ToolStripSeparator20"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator V;
        [AccessedThroughProperty("ButtonDeleteOne"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem K;
        [AccessedThroughProperty("ButtonPrivewList"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button F;
        [AccessedThroughProperty("TabPage8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage D;
        [AccessedThroughProperty("Label2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("ButtonCopy"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button H;
        [AccessedThroughProperty("GroupBox8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [AccessedThroughProperty("TxTTotalSale"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button T;
        [AccessedThroughProperty("GroupBox7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [AccessedThroughProperty("TxtTotalCost"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button X;
        [AccessedThroughProperty("ToolStripButtonPrint"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton I;
        [AccessedThroughProperty("BPrintSetting"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem U;
        [AccessedThroughProperty("ToolStripSeparator21"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Y;
        [AccessedThroughProperty("BPrintPrint"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem L;
        [AccessedThroughProperty("ToolStripMenuItemSC"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem N;
        [AccessedThroughProperty("ToolStripSeparator26"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator O;
        [AccessedThroughProperty("ToolStripMenuItemHC"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem V;
        [AccessedThroughProperty("ToolStripSeparator27"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator B;
        [AccessedThroughProperty("ToolStripSeparator28"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator S;
        [AccessedThroughProperty("ToolStripMenuItemSON"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem Y;
        [AccessedThroughProperty("ToolStripSeparator29"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Z;
        [AccessedThroughProperty("ToolStripMenuItemSOG"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem O;
        [AccessedThroughProperty("ContextMenuStripCopyClipBoard"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ContextMenuStrip A;
        [AccessedThroughProperty("CopytoClipToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem B;
        [AccessedThroughProperty("TabPage5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage F;
        [AccessedThroughProperty("ButtonImportExport"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button G;
        [CompilerGenerated, AccessedThroughProperty("PrintListWToolStripMenuItem"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem S;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator22"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator M;
        [AccessedThroughProperty("PrintListHToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem Z;
        [CompilerGenerated, AccessedThroughProperty("QAddOtherToolStripMenuItem"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem M;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator23"), CompilerGenerated]
        private ToolStripSeparator C;
        [AccessedThroughProperty("ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem C;
        [AccessedThroughProperty("ToolStripButtonXSave"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton I;
        [AccessedThroughProperty("ToolStripButtonXNo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton D;
        [AccessedThroughProperty("TimerSaveAll"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer Q;
        [AccessedThroughProperty("ExitHear"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem J;
        [AccessedThroughProperty("ToolStripSeparator13"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator J;
        [AccessedThroughProperty("ToolStripSeparator18"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator W;
        private SqlConnection A;
        private DataTable A;
        private string A;
        private int A;
        private bool A;

        public QF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A = "SELECT * FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)";
            this.A = 0;
            this.A = false;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(QF));
            this.ButtonGroup = new Button();
            this.TxTSerQQ = new TextBox();
            this.TxTTitle = new Label();
            this.TimerLoadData = new Timer(this.A);
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox2 = new GroupBox();
            this.ComboBoxSerachWat = new ComboBox();
            this.GroupBox1 = new GroupBox();
            this.TxTSerach = new TextBox();
            this.XTxTBarCodeLink = new TextBox();
            this.ButtonSearchCodeName = new Button();
            this.TabPage2 = new TabPage();
            this.GroupBox3 = new GroupBox();
            this.ComboBoxGroup = new ComboBox();
            this.ButtonSortGroup = new Button();
            this.TabPage3 = new TabPage();
            this.GroupBox5 = new GroupBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GroupBox4 = new GroupBox();
            this.TxTInputDate = new TextBox();
            this.ButtonSortDate = new Button();
            this.TabPage4 = new TabPage();
            this.GroupBox6 = new GroupBox();
            this.ButtonSortQunttyAdv = new Button();
            this.ButtonSortQuntty = new Button();
            this.TabPage6 = new TabPage();
            this.ButtonPrivewList = new Button();
            this.TabPage8 = new TabPage();
            this.Label2 = new Label();
            this.ButtonCopy = new Button();
            this.TabPage5 = new TabPage();
            this.ButtonImportExport = new Button();
            this.CheckBoxAll = new CheckBox();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowCount = new ToolStripLabel();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.TimersStartUp = new Timer(this.A);
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator11 = new ToolStripSeparator();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripButtonEdit = new ToolStripDropDownButton();
            this.ButtonEditeMulti = new ToolStripMenuItem();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ExitHear = new ToolStripMenuItem();
            this.ToolStripSeparator13 = new ToolStripSeparator();
            this.ButtonEditSingle = new ToolStripMenuItem();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ToolStripButtonDelete = new ToolStripDropDownButton();
            this.ButtonDeleteMulti = new ToolStripMenuItem();
            this.ToolStripSeparator20 = new ToolStripSeparator();
            this.ButtonDeleteOne = new ToolStripMenuItem();
            this.ToolStripButtonCard = new ToolStripDropDownButton();
            this.ToolStripSeparator14 = new ToolStripSeparator();
            this.CardViewReturnSale = new ToolStripMenuItem();
            this.CardViewSale = new ToolStripMenuItem();
            this.ToolStripSeparator15 = new ToolStripSeparator();
            this.ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem = new ToolStripMenuItem();
            this.CardViewReturnPurch = new ToolStripMenuItem();
            this.ToolStripSeparator12 = new ToolStripSeparator();
            this.CardViewDDs = new ToolStripMenuItem();
            this.CardViewTTr = new ToolStripMenuItem();
            this.ToolStripSeparator23 = new ToolStripSeparator();
            this.CardViewPurch = new ToolStripMenuItem();
            this.QAddOtherToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripDropDownButtonTrDe = new ToolStripDropDownButton();
            this.ButtonTrDsAddDs = new ToolStripMenuItem();
            this.ToolStripSeparator16 = new ToolStripSeparator();
            this.ButtonTrDsAddTr = new ToolStripMenuItem();
            this.ToolStripSeparator17 = new ToolStripSeparator();
            this.ButtonTrDsView = new ToolStripMenuItem();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.ToolStripButtonReport = new ToolStripButton();
            this.ToolStripSeparator10 = new ToolStripSeparator();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.BPrintSetting = new ToolStripMenuItem();
            this.ToolStripMenuItemSC = new ToolStripMenuItem();
            this.ToolStripSeparator26 = new ToolStripSeparator();
            this.ToolStripMenuItemHC = new ToolStripMenuItem();
            this.ToolStripSeparator27 = new ToolStripSeparator();
            this.ToolStripSeparator28 = new ToolStripSeparator();
            this.ToolStripMenuItemSON = new ToolStripMenuItem();
            this.ToolStripSeparator29 = new ToolStripSeparator();
            this.ToolStripMenuItemSOG = new ToolStripMenuItem();
            this.ToolStripSeparator21 = new ToolStripSeparator();
            this.BPrintPrint = new ToolStripMenuItem();
            this.PrintListWToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator22 = new ToolStripSeparator();
            this.PrintListHToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripButtonXSave = new ToolStripButton();
            this.ToolStripSeparator18 = new ToolStripSeparator();
            this.ToolStripButtonXNo = new ToolStripButton();
            this.GV = new DataGridView();
            this.ContextMenuStripCopyClipBoard = new ContextMenuStrip(this.A);
            this.CopytoClipToolStripMenuItem = new ToolStripMenuItem();
            this.Panel1 = new Panel();
            this.GroupBox8 = new GroupBox();
            this.TxTTotalSale = new Button();
            this.GroupBox7 = new GroupBox();
            this.TxtTotalCost = new Button();
            this.TimerFillGV = new Timer(this.A);
            this.TimerSaveAll = new Timer(this.A);
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.TabPage8.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.ContextMenuStripCopyClipBoard.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            base.SuspendLayout();
            this.ButtonGroup.FlatAppearance.BorderColor = Color.Green;
            this.ButtonGroup.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonGroup.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonGroup.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonGroup.FlatStyle = FlatStyle.Flat;
            this.ButtonGroup.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonGroup.Image = A.F.ImGroup;
            this.ButtonGroup.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonGroup.Location = new Point(0x12, 0x15);
            this.ButtonGroup.Margin = new Padding(3, 4, 3, 4);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Size = new Size(0x169, 0x2c);
            this.ButtonGroup.TabIndex = 0x39;
            this.ButtonGroup.Text = "إدارة المجموعات";
            this.ButtonGroup.UseVisualStyleBackColor = true;
            this.TxTSerQQ.Dock = DockStyle.Fill;
            this.TxTSerQQ.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTSerQQ.Location = new Point(3, 0x13);
            this.TxTSerQQ.Name = "TxTSerQQ";
            this.TxTSerQQ.Size = new Size(0x1a9, 0x17);
            this.TxTSerQQ.TabIndex = 60;
            this.TxTSerQQ.Text = "1";
            this.TxTSerQQ.TextAlign = HorizontalAlignment.Center;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x413, 0x22);
            this.TxTTitle.TabIndex = 0x3d;
            this.TxTTitle.Text = "جرد وإدارة المستودع";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Controls.Add(this.TabPage8);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x413, 0x6f);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 0x3e;
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.XTxTBarCodeLink);
            this.TabPage1.Controls.Add(this.ButtonSearchCodeName);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x40b, 0x52);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "بحث";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.ComboBoxSerachWat);
            this.GroupBox2.Location = new Point(0x2db, 0x17);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x128, 0x33);
            this.GroupBox2.TabIndex = 0x10;
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
            this.GroupBox1.Location = new Point(0x128, 0x17);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x1ad, 0x33);
            this.GroupBox1.TabIndex = 15;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "نص البحث";
            this.TxTSerach.Dock = DockStyle.Fill;
            this.TxTSerach.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTSerach.Location = new Point(3, 0x13);
            this.TxTSerach.Name = "TxTSerach";
            this.TxTSerach.Size = new Size(0x1a7, 0x1b);
            this.TxTSerach.TabIndex = 11;
            this.XTxTBarCodeLink.Location = new Point(850, 80);
            this.XTxTBarCodeLink.Name = "XTxTBarCodeLink";
            this.XTxTBarCodeLink.Size = new Size(0, 0x17);
            this.XTxTBarCodeLink.TabIndex = 14;
            this.ButtonSearchCodeName.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSearchCodeName.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSearchCodeName.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSearchCodeName.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSearchCodeName.FlatStyle = FlatStyle.Flat;
            this.ButtonSearchCodeName.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSearchCodeName.Image = A.F.ImSearch;
            this.ButtonSearchCodeName.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSearchCodeName.Location = new Point(0x77, 30);
            this.ButtonSearchCodeName.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSearchCodeName.Name = "ButtonSearchCodeName";
            this.ButtonSearchCodeName.Size = new Size(0xab, 0x2c);
            this.ButtonSearchCodeName.TabIndex = 9;
            this.ButtonSearchCodeName.Text = "بحث";
            this.ButtonSearchCodeName.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.ButtonGroup);
            this.TabPage2.Controls.Add(this.GroupBox3);
            this.TabPage2.Controls.Add(this.ButtonSortGroup);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x40b, 0x52);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "فرز حسب المجموعات";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.ComboBoxGroup);
            this.GroupBox3.Location = new Point(0x24b, 10);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x1ba, 0x37);
            this.GroupBox3.TabIndex = 0x3d;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "حدد المجموعة";
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
            this.ButtonSortGroup.Location = new Point(0x181, 0x15);
            this.ButtonSortGroup.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortGroup.Name = "ButtonSortGroup";
            this.ButtonSortGroup.Size = new Size(0xc4, 0x2c);
            this.ButtonSortGroup.TabIndex = 0x3a;
            this.ButtonSortGroup.Text = "فرز";
            this.ButtonSortGroup.UseVisualStyleBackColor = true;
            this.TabPage3.Controls.Add(this.GroupBox5);
            this.TabPage3.Controls.Add(this.GroupBox4);
            this.TabPage3.Controls.Add(this.ButtonSortDate);
            this.TabPage3.Location = new Point(4, 0x19);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x40b, 0x52);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "فرز المواد المنتهية";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.GroupBox5.Controls.Add(this.DateTimePicker);
            this.GroupBox5.Location = new Point(0x1cf, 10);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x105, 0x38);
            this.GroupBox5.TabIndex = 0x41;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "من تاريخ";
            this.DateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DateTimePicker.Dock = DockStyle.Fill;
            this.DateTimePicker.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePicker.Format = DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new Point(3, 0x13);
            this.DateTimePicker.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.RightToLeft = RightToLeft.No;
            this.DateTimePicker.Size = new Size(0xff, 0x17);
            this.DateTimePicker.TabIndex = 60;
            this.GroupBox4.Controls.Add(this.TxTInputDate);
            this.GroupBox4.Location = new Point(730, 10);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x127, 0x38);
            this.GroupBox4.TabIndex = 0x40;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "فرز المواد التي ينتهي تاريخها قبل";
            this.TxTInputDate.Dock = DockStyle.Fill;
            this.TxTInputDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInputDate.Location = new Point(3, 0x13);
            this.TxTInputDate.Name = "TxTInputDate";
            this.TxTInputDate.RightToLeft = RightToLeft.No;
            this.TxTInputDate.Size = new Size(0x121, 0x17);
            this.TxTInputDate.TabIndex = 0x3f;
            this.TxTInputDate.Text = "30";
            this.TxTInputDate.TextAlign = HorizontalAlignment.Center;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(0xef, 0x12);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(0xc4, 0x2c);
            this.ButtonSortDate.TabIndex = 0x3b;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.TabPage4.Controls.Add(this.GroupBox6);
            this.TabPage4.Controls.Add(this.ButtonSortQunttyAdv);
            this.TabPage4.Controls.Add(this.ButtonSortQuntty);
            this.TabPage4.Location = new Point(4, 0x19);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x40b, 0x52);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "فرز حسب الكمية";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.GroupBox6.Controls.Add(this.TxTSerQQ);
            this.GroupBox6.Location = new Point(0x254, 14);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x1af, 0x31);
            this.GroupBox6.TabIndex = 0x40;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "فرز المواد التي تكون كميتها اقل او تساوي من";
            this.ButtonSortQunttyAdv.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortQunttyAdv.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortQunttyAdv.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortQunttyAdv.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortQunttyAdv.FlatStyle = FlatStyle.Flat;
            this.ButtonSortQunttyAdv.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortQunttyAdv.Image = A.F.ImSort;
            this.ButtonSortQunttyAdv.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortQunttyAdv.Location = new Point(0x13, 0x13);
            this.ButtonSortQunttyAdv.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortQunttyAdv.Name = "ButtonSortQunttyAdv";
            this.ButtonSortQunttyAdv.Size = new Size(0x17e, 0x2c);
            this.ButtonSortQunttyAdv.TabIndex = 0x3f;
            this.ButtonSortQunttyAdv.Text = "فرز حسب الحد الأدنى للكمية المحددة";
            this.ButtonSortQunttyAdv.UseVisualStyleBackColor = true;
            this.ButtonSortQuntty.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortQuntty.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortQuntty.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortQuntty.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortQuntty.FlatStyle = FlatStyle.Flat;
            this.ButtonSortQuntty.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortQuntty.Image = A.F.ImSort;
            this.ButtonSortQuntty.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortQuntty.Location = new Point(0x1ab, 0x13);
            this.ButtonSortQuntty.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortQuntty.Name = "ButtonSortQuntty";
            this.ButtonSortQuntty.Size = new Size(0x7f, 0x2c);
            this.ButtonSortQuntty.TabIndex = 0x3b;
            this.ButtonSortQuntty.Text = "فرز";
            this.ButtonSortQuntty.UseVisualStyleBackColor = true;
            this.TabPage6.Controls.Add(this.ButtonPrivewList);
            this.TabPage6.Location = new Point(4, 0x19);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new Size(0x40b, 0x52);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "انشاء نموذج عرض الأسعار";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.ButtonPrivewList.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPrivewList.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPrivewList.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPrivewList.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPrivewList.FlatStyle = FlatStyle.Flat;
            this.ButtonPrivewList.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPrivewList.Image = A.F.ImGroup;
            this.ButtonPrivewList.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPrivewList.Location = new Point(0xd6, 0x13);
            this.ButtonPrivewList.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPrivewList.Name = "ButtonPrivewList";
            this.ButtonPrivewList.Size = new Size(630, 0x2c);
            this.ButtonPrivewList.TabIndex = 0x3a;
            this.ButtonPrivewList.Text = "انشاء نموذج عرض اسعار";
            this.ButtonPrivewList.UseVisualStyleBackColor = true;
            this.TabPage8.Controls.Add(this.Label2);
            this.TabPage8.Controls.Add(this.ButtonCopy);
            this.TabPage8.Location = new Point(4, 0x19);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Padding = new Padding(3);
            this.TabPage8.Size = new Size(0x40b, 0x52);
            this.TabPage8.TabIndex = 7;
            this.TabPage8.Text = "نسخ لمستودع أخر";
            this.TabPage8.UseVisualStyleBackColor = true;
            this.Label2.Dock = DockStyle.Right;
            this.Label2.Location = new Point(0x113, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x2f5, 0x4c);
            this.Label2.TabIndex = 0x3e;
            this.Label2.Text = "يمكنك نسخ كل محتويات المستودع الحالي بما في ذلك المجموعات لأي مستودع او فرع أخر";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonCopy.FlatAppearance.BorderColor = Color.Green;
            this.ButtonCopy.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonCopy.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonCopy.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonCopy.FlatStyle = FlatStyle.Flat;
            this.ButtonCopy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonCopy.Image = A.F.ImGroup;
            this.ButtonCopy.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCopy.Location = new Point(6, 0x13);
            this.ButtonCopy.Margin = new Padding(3, 4, 3, 4);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new Size(0x111, 0x2c);
            this.ButtonCopy.TabIndex = 0x3d;
            this.ButtonCopy.Text = "فتح معالج النسخ";
            this.ButtonCopy.UseVisualStyleBackColor = true;
            this.TabPage5.Controls.Add(this.ButtonImportExport);
            this.TabPage5.Location = new Point(4, 0x19);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new Padding(3);
            this.TabPage5.Size = new Size(0x40b, 0x52);
            this.TabPage5.TabIndex = 8;
            this.TabPage5.Text = "استيراد | تصدير الى ملف";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.ButtonImportExport.FlatAppearance.BorderColor = Color.Green;
            this.ButtonImportExport.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonImportExport.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonImportExport.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonImportExport.FlatStyle = FlatStyle.Flat;
            this.ButtonImportExport.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonImportExport.Image = A.F.ImGroup;
            this.ButtonImportExport.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonImportExport.Location = new Point(0x189, 0x13);
            this.ButtonImportExport.Margin = new Padding(3, 4, 3, 4);
            this.ButtonImportExport.Name = "ButtonImportExport";
            this.ButtonImportExport.Size = new Size(0x111, 0x2c);
            this.ButtonImportExport.TabIndex = 0x3e;
            this.ButtonImportExport.Text = "فتح معالج التصدير والاستيراد";
            this.ButtonImportExport.UseVisualStyleBackColor = true;
            this.CheckBoxAll.AutoSize = true;
            this.CheckBoxAll.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxAll.Dock = DockStyle.Top;
            this.CheckBoxAll.Location = new Point(0, 0x91);
            this.CheckBoxAll.Name = "CheckBoxAll";
            this.CheckBoxAll.Padding = new Padding(5);
            this.CheckBoxAll.Size = new Size(0x413, 30);
            this.CheckBoxAll.TabIndex = 0;
            this.CheckBoxAll.Text = "تحديد/ عدم تحديد الكل";
            this.CheckBoxAll.UseVisualStyleBackColor = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x44, 0x16);
            this.ToolStripLabel1.Text = "عدد المواد:";
            this.TxTGVRowCount.ForeColor = Color.DarkGreen;
            this.TxTGVRowCount.Name = "TxTGVRowCount";
            this.TxTGVRowCount.RightToLeft = RightToLeft.No;
            this.TxTGVRowCount.Size = new Size(0x16, 0x16);
            this.TxTGVRowCount.Text = "00";
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(toolStripItems);
            this.ToolStripStatus.Location = new Point(0, 0x237);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x413, 0x19);
            this.ToolStripStatus.TabIndex = 0x45;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x2f);
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(6, 0x2f);
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new Size(6, 0x2f);
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[0x15];
            itemArray2[0] = this.ToolStripButtonViewAll;
            itemArray2[1] = this.ToolStripSeparator11;
            itemArray2[2] = this.ToolStripButtonAdd;
            itemArray2[3] = this.ToolStripSeparator2;
            itemArray2[4] = this.ToolStripButtonEdit;
            itemArray2[5] = this.ToolStripSeparator3;
            itemArray2[6] = this.ToolStripButtonDelete;
            itemArray2[7] = this.ToolStripSeparator4;
            itemArray2[8] = this.ToolStripButtonCard;
            itemArray2[9] = this.ToolStripSeparator5;
            itemArray2[10] = this.ToolStripDropDownButtonTrDe;
            itemArray2[11] = this.ToolStripSeparator9;
            itemArray2[12] = this.ToolStripButtonReport;
            itemArray2[13] = this.ToolStripSeparator10;
            itemArray2[14] = this.ToolStripButtonPrint;
            itemArray2[15] = this.ToolStripSeparator6;
            itemArray2[0x10] = this.ToolStripButtonClose;
            itemArray2[0x11] = this.ToolStripSeparator7;
            itemArray2[0x12] = this.ToolStripButtonXSave;
            itemArray2[0x13] = this.ToolStripSeparator18;
            itemArray2[20] = this.ToolStripButtonXNo;
            this.ToolStripButtons.Items.AddRange(itemArray2);
            this.ToolStripButtons.Location = new Point(0, 520);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x413, 0x2f);
            this.ToolStripButtons.TabIndex = 80;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new Size(6, 0x2f);
            this.ToolStripButtonAdd.Image = A.F.ImAdd;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(0x49, 0x2c);
            this.ToolStripButtonAdd.Text = "اضافة";
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ButtonEditeMulti, this.ToolStripSeparator8, this.ExitHear, this.ToolStripSeparator13, this.ButtonEditSingle };
            this.ToolStripButtonEdit.DropDownItems.AddRange(itemArray3);
            this.ToolStripButtonEdit.Image = A.F.ImEdit;
            this.ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new Size(0x53, 0x2c);
            this.ToolStripButtonEdit.Text = "تعديل";
            this.ButtonEditeMulti.Image = (Image) manager.GetObject("ButtonEditeMulti.Image");
            this.ButtonEditeMulti.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonEditeMulti.Name = "ButtonEditeMulti";
            this.ButtonEditeMulti.Size = new Size(240, 0x26);
            this.ButtonEditeMulti.Text = "تعديل متعدد للمواد المحددة";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(0xed, 6);
            this.ExitHear.Image = A.F.ImEdit;
            this.ExitHear.ImageScaling = ToolStripItemImageScaling.None;
            this.ExitHear.Name = "ExitHear";
            this.ExitHear.Size = new Size(240, 0x26);
            this.ExitHear.Text = "تعديل القائمة اعلاه هنا";
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            this.ToolStripSeparator13.Size = new Size(0xed, 6);
            this.ButtonEditSingle.Image = (Image) manager.GetObject("ButtonEditSingle.Image");
            this.ButtonEditSingle.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonEditSingle.Name = "ButtonEditSingle";
            this.ButtonEditSingle.Size = new Size(240, 0x26);
            this.ButtonEditSingle.Text = "تعديل المادة المحددة";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.ButtonDeleteMulti, this.ToolStripSeparator20, this.ButtonDeleteOne };
            this.ToolStripButtonDelete.DropDownItems.AddRange(itemArray4);
            this.ToolStripButtonDelete.Image = A.F.ImDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(80, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف";
            this.ButtonDeleteMulti.Image = (Image) manager.GetObject("ButtonDeleteMulti.Image");
            this.ButtonDeleteMulti.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonDeleteMulti.Name = "ButtonDeleteMulti";
            this.ButtonDeleteMulti.Size = new Size(0xed, 0x26);
            this.ButtonDeleteMulti.Text = "حذف متعدد للمواد المحددة";
            this.ToolStripSeparator20.Name = "ToolStripSeparator20";
            this.ToolStripSeparator20.Size = new Size(0xea, 6);
            this.ButtonDeleteOne.Image = (Image) manager.GetObject("ButtonDeleteOne.Image");
            this.ButtonDeleteOne.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonDeleteOne.Name = "ButtonDeleteOne";
            this.ButtonDeleteOne.Size = new Size(0xed, 0x26);
            this.ButtonDeleteOne.Text = "حذف المادة المحددة";
            ToolStripItem[] itemArray5 = new ToolStripItem[12];
            itemArray5[0] = this.ToolStripSeparator14;
            itemArray5[1] = this.CardViewReturnSale;
            itemArray5[2] = this.CardViewSale;
            itemArray5[3] = this.ToolStripSeparator15;
            itemArray5[4] = this.ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem;
            itemArray5[5] = this.CardViewReturnPurch;
            itemArray5[6] = this.ToolStripSeparator12;
            itemArray5[7] = this.CardViewDDs;
            itemArray5[8] = this.CardViewTTr;
            itemArray5[9] = this.ToolStripSeparator23;
            itemArray5[10] = this.CardViewPurch;
            itemArray5[11] = this.QAddOtherToolStripMenuItem;
            this.ToolStripButtonCard.DropDownItems.AddRange(itemArray5);
            this.ToolStripButtonCard.Image = A.F.ImCard;
            this.ToolStripButtonCard.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonCard.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonCard.Name = "ToolStripButtonCard";
            this.ToolStripButtonCard.Size = new Size(0x9d, 0x2c);
            this.ToolStripButtonCard.Text = "كرت المادة المحددة";
            this.ToolStripButtonCard.ToolTipText = "كرت المادة المحددة";
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            this.ToolStripSeparator14.Size = new Size(390, 6);
            this.CardViewReturnSale.Image = (Image) manager.GetObject("CardViewReturnSale.Image");
            this.CardViewReturnSale.ImageScaling = ToolStripItemImageScaling.None;
            this.CardViewReturnSale.Name = "CardViewReturnSale";
            this.CardViewReturnSale.Size = new Size(0x189, 0x26);
            this.CardViewReturnSale.Text = "عرض سجل مرتجع مبيعات المادة";
            this.CardViewSale.Image = (Image) manager.GetObject("CardViewSale.Image");
            this.CardViewSale.ImageScaling = ToolStripItemImageScaling.None;
            this.CardViewSale.Name = "CardViewSale";
            this.CardViewSale.Size = new Size(0x189, 0x26);
            this.CardViewSale.Text = "عرض سجل مبيعات المادة";
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            this.ToolStripSeparator15.Size = new Size(390, 6);
            this.ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem.Image = A.F.ImView;
            this.ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem.Name = "ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem";
            this.ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem.Size = new Size(0x189, 0x26);
            this.ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem.Text = "عرض سجل مشتريات المادة";
            this.CardViewReturnPurch.Image = (Image) manager.GetObject("CardViewReturnPurch.Image");
            this.CardViewReturnPurch.ImageScaling = ToolStripItemImageScaling.None;
            this.CardViewReturnPurch.Name = "CardViewReturnPurch";
            this.CardViewReturnPurch.Size = new Size(0x189, 0x26);
            this.CardViewReturnPurch.Text = "عرض سجل مرتجع مشتريات المادة";
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            this.ToolStripSeparator12.Size = new Size(390, 6);
            this.CardViewDDs.Image = (Image) manager.GetObject("CardViewDDs.Image");
            this.CardViewDDs.ImageScaling = ToolStripItemImageScaling.None;
            this.CardViewDDs.Name = "CardViewDDs";
            this.CardViewDDs.Size = new Size(0x189, 0x26);
            this.CardViewDDs.Text = "عرض سجل حركة اتلاف الكمية";
            this.CardViewTTr.Image = (Image) manager.GetObject("CardViewTTr.Image");
            this.CardViewTTr.ImageScaling = ToolStripItemImageScaling.None;
            this.CardViewTTr.Name = "CardViewTTr";
            this.CardViewTTr.Size = new Size(0x189, 0x26);
            this.CardViewTTr.Text = "عرض سجل حركة ترحيل الكمية ";
            this.ToolStripSeparator23.Name = "ToolStripSeparator23";
            this.ToolStripSeparator23.Size = new Size(390, 6);
            this.CardViewPurch.Image = A.F.ImAdd;
            this.CardViewPurch.ImageScaling = ToolStripItemImageScaling.None;
            this.CardViewPurch.Name = "CardViewPurch";
            this.CardViewPurch.Size = new Size(0x189, 0x26);
            this.CardViewPurch.Text = "زيادة الكمية وتطبيق الاسعار من سجل المشتريات";
            this.QAddOtherToolStripMenuItem.Image = A.F.ImAdd;
            this.QAddOtherToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.QAddOtherToolStripMenuItem.Name = "QAddOtherToolStripMenuItem";
            this.QAddOtherToolStripMenuItem.Size = new Size(0x189, 0x26);
            this.QAddOtherToolStripMenuItem.Text = "زيادة الكمية فقط من مادة مرتبطة ذات وحدة اكبر (كرتونة)";
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.ButtonTrDsAddDs, this.ToolStripSeparator16, this.ButtonTrDsAddTr, this.ToolStripSeparator17, this.ButtonTrDsView };
            this.ToolStripDropDownButtonTrDe.DropDownItems.AddRange(itemArray6);
            this.ToolStripDropDownButtonTrDe.Image = A.F.ImExpense;
            this.ToolStripDropDownButtonTrDe.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripDropDownButtonTrDe.ImageTransparentColor = Color.Magenta;
            this.ToolStripDropDownButtonTrDe.Name = "ToolStripDropDownButtonTrDe";
            this.ToolStripDropDownButtonTrDe.Size = new Size(0xb0, 0x2c);
            this.ToolStripDropDownButtonTrDe.Text = "سجل الاتلاف / الترحيل";
            this.ButtonTrDsAddDs.Image = (Image) manager.GetObject("ButtonTrDsAddDs.Image");
            this.ButtonTrDsAddDs.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonTrDsAddDs.Name = "ButtonTrDsAddDs";
            this.ButtonTrDsAddDs.Size = new Size(0x12e, 0x26);
            this.ButtonTrDsAddDs.Text = "اضافة حركة اتلاف كمية للمادة المحددة";
            this.ToolStripSeparator16.Name = "ToolStripSeparator16";
            this.ToolStripSeparator16.Size = new Size(0x12b, 6);
            this.ButtonTrDsAddTr.Image = (Image) manager.GetObject("ButtonTrDsAddTr.Image");
            this.ButtonTrDsAddTr.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonTrDsAddTr.Name = "ButtonTrDsAddTr";
            this.ButtonTrDsAddTr.Size = new Size(0x12e, 0x26);
            this.ButtonTrDsAddTr.Text = "اضافة حركة ترحيل كمية للمادة المحددة";
            this.ToolStripSeparator17.Name = "ToolStripSeparator17";
            this.ToolStripSeparator17.Size = new Size(0x12b, 6);
            this.ButtonTrDsView.Image = A.F.ImView;
            this.ButtonTrDsView.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonTrDsView.Name = "ButtonTrDsView";
            this.ButtonTrDsView.Size = new Size(0x12e, 0x26);
            this.ButtonTrDsView.Text = "عرض سجل الاتلاف والترحيل الكامل";
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new Size(6, 0x2f);
            this.ToolStripButtonReport.Image = A.F.ImGroup;
            this.ToolStripButtonReport.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonReport.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonReport.Name = "ToolStripButtonReport";
            this.ToolStripButtonReport.Size = new Size(0x8a, 0x2c);
            this.ToolStripButtonReport.Text = "تقرير حركة الكميات";
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.BPrintSetting, this.ToolStripSeparator21, this.BPrintPrint };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray7);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x69, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة A4";
            ToolStripItem[] itemArray8 = new ToolStripItem[] { this.ToolStripMenuItemSC, this.ToolStripSeparator26, this.ToolStripMenuItemHC, this.ToolStripSeparator27, this.ToolStripSeparator28, this.ToolStripMenuItemSON, this.ToolStripSeparator29, this.ToolStripMenuItemSOG };
            this.BPrintSetting.DropDownItems.AddRange(itemArray8);
            this.BPrintSetting.Image = A.F.ImSettingS;
            this.BPrintSetting.ImageScaling = ToolStripItemImageScaling.None;
            this.BPrintSetting.Name = "BPrintSetting";
            this.BPrintSetting.Size = new Size(240, 0x26);
            this.BPrintSetting.Text = "إعدادات القائمة في الطباعة";
            this.ToolStripMenuItemSC.Name = "ToolStripMenuItemSC";
            this.ToolStripMenuItemSC.Size = new Size(0xbb, 0x16);
            this.ToolStripMenuItemSC.Text = "اظهار سعر التكلفة";
            this.ToolStripSeparator26.Name = "ToolStripSeparator26";
            this.ToolStripSeparator26.Size = new Size(0xb8, 6);
            this.ToolStripMenuItemHC.Name = "ToolStripMenuItemHC";
            this.ToolStripMenuItemHC.Size = new Size(0xbb, 0x16);
            this.ToolStripMenuItemHC.Text = "اخفاء سعر التكلفة";
            this.ToolStripSeparator27.Name = "ToolStripSeparator27";
            this.ToolStripSeparator27.Size = new Size(0xb8, 6);
            this.ToolStripSeparator28.Name = "ToolStripSeparator28";
            this.ToolStripSeparator28.Size = new Size(0xb8, 6);
            this.ToolStripMenuItemSON.Name = "ToolStripMenuItemSON";
            this.ToolStripMenuItemSON.Size = new Size(0xbb, 0x16);
            this.ToolStripMenuItemSON.Text = "فرز حسب الاسم";
            this.ToolStripSeparator29.Name = "ToolStripSeparator29";
            this.ToolStripSeparator29.Size = new Size(0xb8, 6);
            this.ToolStripMenuItemSOG.Name = "ToolStripMenuItemSOG";
            this.ToolStripMenuItemSOG.Size = new Size(0xbb, 0x16);
            this.ToolStripMenuItemSOG.Text = "فرز حسب المجموعة";
            this.ToolStripSeparator21.Name = "ToolStripSeparator21";
            this.ToolStripSeparator21.Size = new Size(0xed, 6);
            ToolStripItem[] itemArray9 = new ToolStripItem[] { this.PrintListWToolStripMenuItem, this.ToolStripSeparator22, this.PrintListHToolStripMenuItem };
            this.BPrintPrint.DropDownItems.AddRange(itemArray9);
            this.BPrintPrint.Image = A.F.ImPrint;
            this.BPrintPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.BPrintPrint.Name = "BPrintPrint";
            this.BPrintPrint.Size = new Size(240, 0x26);
            this.BPrintPrint.Text = "طباعة القائمة اعلاه";
            this.PrintListWToolStripMenuItem.Name = "PrintListWToolStripMenuItem";
            this.PrintListWToolStripMenuItem.Size = new Size(0x109, 0x16);
            this.PrintListWToolStripMenuItem.Text = "قياس A4 بشكل عرضي مع تفاصيل";
            this.ToolStripSeparator22.Name = "ToolStripSeparator22";
            this.ToolStripSeparator22.Size = new Size(0x106, 6);
            this.PrintListHToolStripMenuItem.Name = "PrintListHToolStripMenuItem";
            this.PrintListHToolStripMenuItem.Size = new Size(0x109, 0x16);
            this.PrintListHToolStripMenuItem.Text = "قياس A4  بشكل طولي مختصر";
            this.ToolStripButtonClose.Image = A.F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x2c);
            this.ToolStripButtonClose.Text = "اغلاق";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(6, 0x2f);
            this.ToolStripButtonXSave.Image = A.F.ImSave;
            this.ToolStripButtonXSave.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonXSave.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonXSave.Name = "ToolStripButtonXSave";
            this.ToolStripButtonXSave.Size = new Size(0x7a, 0x24);
            this.ToolStripButtonXSave.Text = "حفظ التعديلات";
            this.ToolStripButtonXSave.Visible = false;
            this.ToolStripSeparator18.Name = "ToolStripSeparator18";
            this.ToolStripSeparator18.Size = new Size(6, 0x2f);
            this.ToolStripSeparator18.Visible = false;
            this.ToolStripButtonXNo.Image = A.F.ImFinish;
            this.ToolStripButtonXNo.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonXNo.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonXNo.Name = "ToolStripButtonXNo";
            this.ToolStripButtonXNo.Size = new Size(0x43, 0x24);
            this.ToolStripButtonXNo.Text = "إنهاء";
            this.ToolStripButtonXNo.Visible = false;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.ContextMenuStrip = this.ContextMenuStripCopyClipBoard;
            this.GV.Dock = DockStyle.Fill;
            this.GV.EditMode = DataGridViewEditMode.EditOnEnter;
            this.GV.Location = new Point(0, 0xaf);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x413, 0x11c);
            this.GV.TabIndex = 0x51;
            ToolStripItem[] itemArray10 = new ToolStripItem[] { this.CopytoClipToolStripMenuItem };
            this.ContextMenuStripCopyClipBoard.Items.AddRange(itemArray10);
            this.ContextMenuStripCopyClipBoard.Name = "ContextMenuStripCopyClipBoard";
            this.ContextMenuStripCopyClipBoard.Size = new Size(0xaf, 0x1a);
            this.CopytoClipToolStripMenuItem.Name = "CopytoClipToolStripMenuItem";
            this.CopytoClipToolStripMenuItem.Size = new Size(0xae, 0x16);
            this.CopytoClipToolStripMenuItem.Text = "نسخ القائمة للحافظة";
            this.Panel1.BackColor = SystemColors.HighlightText;
            this.Panel1.BorderStyle = BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox8);
            this.Panel1.Controls.Add(this.GroupBox7);
            this.Panel1.Dock = DockStyle.Bottom;
            this.Panel1.Location = new Point(0, 0x1cb);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x413, 0x3d);
            this.Panel1.TabIndex = 0x52;
            this.GroupBox8.BackColor = Color.White;
            this.GroupBox8.Controls.Add(this.TxTTotalSale);
            this.GroupBox8.Dock = DockStyle.Left;
            this.GroupBox8.Location = new Point(0, 0);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(480, 0x39);
            this.GroupBox8.TabIndex = 0x4b;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "المجموع الكلي لسعر البيع X الكمية:";
            this.TxTTotalSale.Dock = DockStyle.Fill;
            this.TxTTotalSale.FlatAppearance.BorderColor = Color.Green;
            this.TxTTotalSale.FlatAppearance.CheckedBackColor = Color.White;
            this.TxTTotalSale.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.TxTTotalSale.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.TxTTotalSale.FlatStyle = FlatStyle.Flat;
            this.TxTTotalSale.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalSale.Image = A.F.ImCalculater;
            this.TxTTotalSale.ImageAlign = ContentAlignment.MiddleLeft;
            this.TxTTotalSale.Location = new Point(3, 0x13);
            this.TxTTotalSale.Margin = new Padding(3, 4, 3, 4);
            this.TxTTotalSale.Name = "TxTTotalSale";
            this.TxTTotalSale.Size = new Size(0x1da, 0x23);
            this.TxTTotalSale.TabIndex = 0x43;
            this.TxTTotalSale.Text = "احسب";
            this.TxTTotalSale.UseVisualStyleBackColor = true;
            this.GroupBox7.BackColor = Color.White;
            this.GroupBox7.Controls.Add(this.TxtTotalCost);
            this.GroupBox7.Dock = DockStyle.Right;
            this.GroupBox7.Location = new Point(0x22f, 0);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(480, 0x39);
            this.GroupBox7.TabIndex = 0x4a;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "المجموع الكلي لسعر التكلفة X الكمية:";
            this.TxtTotalCost.Dock = DockStyle.Fill;
            this.TxtTotalCost.FlatAppearance.BorderColor = Color.Green;
            this.TxtTotalCost.FlatAppearance.CheckedBackColor = Color.White;
            this.TxtTotalCost.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.TxtTotalCost.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.TxtTotalCost.FlatStyle = FlatStyle.Flat;
            this.TxtTotalCost.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxtTotalCost.Image = A.F.ImCalculater;
            this.TxtTotalCost.ImageAlign = ContentAlignment.MiddleLeft;
            this.TxtTotalCost.Location = new Point(3, 0x13);
            this.TxtTotalCost.Margin = new Padding(3, 4, 3, 4);
            this.TxtTotalCost.Name = "TxtTotalCost";
            this.TxtTotalCost.Size = new Size(0x1da, 0x23);
            this.TxtTotalCost.TabIndex = 0x42;
            this.TxtTotalCost.Text = "احسب";
            this.TxtTotalCost.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x413, 0x250);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.CheckBoxAll);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "MaterialList";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "جرد وإدارة المستودع";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage8.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            this.ContextMenuStripCopyClipBoard.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
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
                this.ButtonSearchCodeName.PerformClick();
            }
        }

        private void AR(object A, EventArgs R)
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
                    EF.R = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                    EF.P = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND  (TrDsBarCode = @TrDsBarCode) AND (TrDsType = 1) ";
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

        private void B(object A, EventArgs R)
        {
            try
            {
                if (!A.PR.WR)
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
                    VD.P = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                    VD.Q = "SELECT TaNNInvSaleItems.*, TaNNCustomers.CustomerName FROM TaNNInvSaleItems LEFT OUTER JOIN TaNNCustomers ON TaNNInvSaleItems.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSaleItems.CenterFrontID = @CenterFrontID) AND (TaNNInvSaleItems.HSaleBarCode = @HSaleBarCode) AND (TaNNInvSaleItems.HSaleType = 1)";
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

        private void BR(object A, EventArgs R)
        {
            try
            {
                if (!A.PR.WR)
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
                    KD.Q = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                    KD.I = "SELECT TaNNInvPurchItems.*, TaNNSupliers.SuplierName FROM TaNNInvPurchItems LEFT OUTER JOIN TaNNSupliers ON TaNNInvPurchItems.SuplierFrontID = TaNNSupliers.SuplierID WHERE (TaNNInvPurchItems.CenterFrontID = @CenterFrontID) AND (TaNNInvPurchItems.PurchMaterialBarCode = @PurchMaterialBarCode) AND (TaNNInvPurchItems.InvPurchType = 0)";
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

        private void C(object A, EventArgs R)
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
                    GF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["MaterialID"].Value.ToString());
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

        private void CR(object A, EventArgs R)
        {
            this.ToolStripButtonViewAll.Visible = true;
            this.ToolStripSeparator11.Visible = true;
            this.ToolStripButtonAdd.Visible = true;
            this.ToolStripSeparator2.Visible = true;
            this.ToolStripButtonEdit.Visible = true;
            this.ToolStripSeparator3.Visible = true;
            this.ToolStripButtonDelete.Visible = true;
            this.ToolStripSeparator4.Visible = true;
            this.ToolStripButtonCard.Visible = true;
            this.ToolStripSeparator5.Visible = true;
            this.ToolStripDropDownButtonTrDe.Visible = true;
            this.ToolStripSeparator9.Visible = true;
            this.ToolStripButtonReport.Visible = true;
            this.ToolStripSeparator10.Visible = true;
            this.ToolStripButtonPrint.Visible = true;
            this.ToolStripSeparator6.Visible = true;
            this.ToolStripButtonClose.Visible = true;
            this.GV.BeginEdit(false);
            this.TabControl1.Enabled = true;
            this.CheckBoxAll.Enabled = true;
            this.Panel1.Enabled = true;
            this.GV.Columns["MaterialPricLess"].Visible = false;
            this.GV.Columns["MaterialQuantity"].ReadOnly = true;
            this.GV.Columns["MaterialPricCost"].ReadOnly = true;
            this.GV.Columns["MaterialPricSale"].ReadOnly = true;
            this.GV.Columns["MaterialPricLess"].ReadOnly = true;
            this.GV.Columns["MaterialQuantity"].DefaultCellStyle.BackColor = Color.White;
            this.GV.Columns["MaterialPricCost"].DefaultCellStyle.BackColor = Color.White;
            this.GV.Columns["MaterialPricSale"].DefaultCellStyle.BackColor = Color.White;
            this.GV.Columns["MaterialPricLess"].DefaultCellStyle.BackColor = Color.White;
            this.ToolStripButtonXSave.Visible = false;
            this.ToolStripSeparator18.Visible = false;
            this.ToolStripButtonXNo.Visible = false;
            this.TimerLoadData.Enabled = true;
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

        private void DR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void E(object A, EventArgs R)
        {
            this.A = "SELECT * FROM [TaNNMaterial] WHERE CenterFrontID = @CenterFrontID AND MaterialExpDate < @MaterialExpDate";
            this.TimerLoadData.Enabled = true;
        }

        private void ER(object A, EventArgs R)
        {
            this.A = false;
            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
        }

        private void F(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = false;
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.R();
            this.TimerLoadData.Enabled = true;
        }

        private void FR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void G(object A, EventArgs R)
        {
            this.A = "SELECT * FROM [TaNNMaterial] WHERE CenterFrontID = @CenterFrontID AND convert (DECIMAL(18, 3), MaterialQuantity) <= @MaterialQuantity";
            this.TimerLoadData.Enabled = true;
        }

        private void GR(object A, EventArgs R)
        {
            this.A = true;
            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
        }

        private void H(object A, EventArgs R)
        {
            A.AR.F = (int) Math.Round(Conversion.Val(this.TxTInputDate.Text));
            base.Dispose();
        }

        private void HR(object A, EventArgs R)
        {
            // Invalid method body.
        }

        public void I()
        {
            IEnumerator enumerator;
            Application.DoEvents();
            this.ToolStripProgressBar1.Maximum = this.GV.Rows.Count;
            this.ToolStripProgressBar1.Value = 0;
            this.ToolStripProgressBar1.Visible = true;
            try
            {
                enumerator = ((IEnumerable) this.GV.Rows).GetEnumerator();
                while (true)
                {
                    if (enumerator.MoveNext())
                    {
                        DataGridViewRow current = (DataGridViewRow) enumerator.Current;
                        this.ToolStripProgressBar1.Value = current.Index;
                        this.GV.Rows[current.Index].Cells[0].Selected = true;
                        int num = Conversions.ToInteger(current.Cells["MaterialID"].Value.ToString());
                        string str = current.Cells["MaterialQuantity"].Value.ToString();
                        string str2 = current.Cells["MaterialPricCost"].Value.ToString();
                        string str3 = current.Cells["MaterialPricLess"].Value.ToString();
                        string str4 = current.Cells["MaterialPricSale"].Value.ToString();
                        string inputStr = current.Cells["MaterialDisMiWi"].Value.ToString();
                        string str6 = current.Cells["MaterialPricSale"].Value.ToString();
                        try
                        {
                            decimal num2 = new decimal(Conversion.Val(str.Replace(",", "")));
                            decimal num3 = new decimal(Conversion.Val(str2.Replace(",", "")));
                            decimal num4 = new decimal(Conversion.Val(str3.Replace(",", "")));
                            decimal num5 = new decimal(Conversion.Val(str4.Replace(",", "")));
                            if (Conversion.Val(str2.Replace(",", "")) > Conversion.Val(str4.Replace(",", "")))
                            {
                                Interaction.MsgBox("خطأ، في احتساب الربح لأن سعر التكلفة اكبر من سعر ##البيع## وهذا يسبب خسارة", MsgBoxStyle.Exclamation, null);
                                if (Interaction.MsgBox("هل تريد الاستمرار على اي حال؟", MsgBoxStyle.OkCancel, "") == MsgBoxResult.Cancel)
                                {
                                    break;
                                }
                            }
                            if (!(Conversion.Val(str3.Replace(",", "")) == 0.0) && (Conversion.Val(str2.Replace(",", "")) > Conversion.Val(str3.Replace(",", ""))))
                            {
                                Interaction.MsgBox("خطأ، في احتساب الربح لأن سعر التكلفة اكبر من السعر ##المخفض## وهذا يسبب خسارة", MsgBoxStyle.Exclamation, null);
                                if (Interaction.MsgBox("هل تريد الاستمرار على اي حال؟", MsgBoxStyle.OkCancel, "") == MsgBoxResult.Cancel)
                                {
                                    break;
                                }
                            }
                            if (Conversion.Val(inputStr) <= 0.0)
                            {
                                goto TR_0006;
                            }
                            else
                            {
                                decimal num6 = new decimal(Conversion.Val(str4.Replace(",", "")) * (Conversion.Val(inputStr) / 100.0));
                                decimal num7 = new decimal(Conversion.Val(str4.Replace(",", "")) - Convert.ToDouble(num6));
                                if (Conversion.Val(str2.Replace(",", "")) <= Convert.ToDouble(num7))
                                {
                                    goto TR_0006;
                                }
                                else
                                {
                                    Interaction.MsgBox("خطأ، في احتساب الربح لأن نسبة الخصم كبيرة وتسبب خسارة", MsgBoxStyle.Exclamation, null);
                                    if (Interaction.MsgBox("هل تريد الاستمرار على اي حال؟", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
                                    {
                                        goto TR_0006;
                                    }
                                }
                            }
                            goto TR_0000;
                        TR_0006:
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity, [MaterialPricCost] = @MaterialPricCost, [MaterialPricLess] = @MaterialPricLess, [MaterialPricSale] = @MaterialPricSale WHERE [MaterialID] = @MaterialID", this.A);
                            command.Parameters.AddWithValue("MaterialID", num);
                            command.Parameters.AddWithValue("MaterialQuantity", num2.ToString(A.PR.OR));
                            command.Parameters.AddWithValue("MaterialPricCost", num3.ToString(A.PR.VR));
                            command.Parameters.AddWithValue("MaterialPricLess", num4.ToString(A.PR.VR));
                            command.Parameters.AddWithValue("MaterialPricSale", num5.ToString(A.PR.VR));
                            command.ExecuteNonQuery();
                            this.A.Close();
                            this.TxTTitle.Text = this.Text;
                            this.TxTTitle.ForeColor = Color.DarkGreen;
                            this.TxTTitle.Font = new Font("Tahoma", 12f);
                            this.ToolStripProgressBar1.Visible = false;
                            continue;
                        }
                        catch (Exception exception1)
                        {
                            Exception ex = exception1;
                            ProjectData.SetProjectError(ex);
                            Exception exception = ex;
                            this.ToolStripProgressBar1.Visible = false;
                            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                            ProjectData.ClearProjectError();
                        }
                    }
                    break;
                }
            }
            finally
            {
                if (enumerator is IDisposable)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
        TR_0000:
            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
        }

        private void I(object A, EventArgs R)
        {
            if (A.PR.E)
            {
                A.D.A.A.ShowDialog();
            }
            if (!A.PR.VR)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                A.D.A.A.D();
                JD.A = 0;
                A.D.A.A.ShowDialog();
            }
        }

        private void IR(object A, EventArgs R)
        {
            this.GV.ClearSelection();
            this.GV.CurrentCell = this.GV.Rows[0].Cells[0];
            this.GV.Rows[0].Cells[0].Selected = true;
            A.D.A.A.ShowDialog();
        }

        private void J(object A, EventArgs R)
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
                    XF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["MaterialID"].Value.ToString());
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

        private void K(object A, EventArgs R)
        {
            this.A = "SELECT * FROM [TaNNMaterial] WHERE CenterFrontID = @CenterFrontID AND GroupIDFrontID = @GroupIDFrontID";
            this.TimerLoadData.Enabled = true;
        }

        private void KR(object A, EventArgs R)
        {
            this.A = this.A.Replace(" ORDER BY [MaterialName]", "");
            this.A = this.A.Replace(" ORDER BY [GroupIDFrontID]", "");
            this.A = this.A + " ORDER BY [MaterialName]";
            this.TimerLoadData.Enabled = true;
            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
        }

        private void L(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.P();
        }

        private void LR(object A, EventArgs R)
        {
            this.GV.MultiSelect = true;
            this.GV.SelectAll();
            Clipboard.SetDataObject(this.GV.GetClipboardContent(), true);
            Interaction.MsgBox("تم نسخ القائمة للحافظة", MsgBoxStyle.ApplicationModal, null);
            this.GV.MultiSelect = false;
        }

        private void M(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void MR(object A, EventArgs R)
        {
            this.TimerSaveAll.Enabled = true;
        }

        private void N(object A, EventArgs R)
        {
        }

        private void NR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void O(object A, EventArgs R)
        {
            if (!A.PR.VR)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                A.D.A.A.ShowDialog();
            }
        }

        private void OR(object A, EventArgs R)
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
                    XH.A = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
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

        public void P()
        {
            try
            {
                IEnumerator enumerator;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                this.A.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                string text1 = this.TxTSerach.Text.Trim();
                adapter.SelectCommand.Parameters.AddWithValue("MaterialBarCode", text1 ?? DBNull.Value);
                string text2 = this.TxTSerach.Text.Trim();
                adapter.SelectCommand.Parameters.AddWithValue("BBMaterialMultBarCode", text2 ?? DBNull.Value);
                string text3 = this.TxTSerach.Text.Trim();
                adapter.SelectCommand.Parameters.AddWithValue("MaterialMultBarCode", text3 ?? DBNull.Value);
                string text4 = this.TxTSerach.Text.Trim();
                adapter.SelectCommand.Parameters.AddWithValue("MaterialName", text4 ?? DBNull.Value);
                string text5 = this.TxTSerach.Text.Trim();
                adapter.SelectCommand.Parameters.AddWithValue("MaterialNote", text5 ?? DBNull.Value);
                string text6 = this.TxTSerQQ.Text.Trim();
                adapter.SelectCommand.Parameters.AddWithValue("MaterialQuantity", text6 ?? DBNull.Value);
                string text7 = this.DateTimePicker.Value.Date.AddDays(Conversion.Val(this.TxTInputDate.Text)).ToString("yyyy/MM/dd 00:00");
                adapter.SelectCommand.Parameters.AddWithValue("MaterialExpDate", text7 ?? DBNull.Value);
                object selectedValue = this.ComboBoxGroup.SelectedValue;
                adapter.SelectCommand.Parameters.AddWithValue("GroupIDFrontID", selectedValue ?? DBNull.Value);
                adapter.Fill(this.A);
                this.A.Close();
                this.GV.DataSource = this.A;
                this.GV.Refresh();
                this.GV.Columns["MaterialID"].Visible = false;
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["GroupIDFrontID"].Visible = false;
                this.GV.Columns["MaterialBarCode"].HeaderText = "رقم/ باركود";
                this.GV.Columns["MaterialName"].HeaderText = "المادة";
                this.GV.Columns["MaterialQuantity"].HeaderText = "الكمية التقريبية";
                this.GV.Columns["MaterialUnit"].HeaderText = "الوحدة";
                this.GV.Columns["MaterialPricCost"].HeaderText = "سعر التكلفة";
                this.GV.Columns["MaterialPricLess"].Visible = false;
                this.GV.Columns["MaterialPricLess"].HeaderText = "السعر المخفض";
                this.GV.Columns["MaterialPricSale"].HeaderText = "سعر البيع";
                this.GV.Columns["MaterialIsStop"].HeaderText = "منع البيع";
                this.GV.Columns["MaterialExpDate"].HeaderText = "تاريخ الانتهاء";
                this.GV.Columns["MaterialNote"].HeaderText = "ملاحظات";
                this.GV.Columns["MaterialNotIsView"].Visible = false;
                this.GV.Columns["MaterialQuantityLess"].Visible = false;
                this.GV.Columns["MaterialQuantityPakeg"].Visible = false;
                this.GV.Columns["MaterialQuantityOffer"].Visible = false;
                this.GV.Columns["MaterialDisMiWi"].HeaderText = "الخصم %";
                this.GV.Columns["MaterialDarMiWi"].HeaderText = "الضريبة %";
                this.GV.Columns["MaterialOtherBarCode"].Visible = false;
                this.GV.Columns["MaterialMultBarCode"].Visible = false;
                this.GV.Columns["MaterialBarcodeBlock"].Visible = false;
                this.GV.Columns["MaterialDisExpDat"].Visible = false;
                this.GV.Columns["MaterialBarCode"].ReadOnly = true;
                this.GV.Columns["MaterialName"].ReadOnly = true;
                this.GV.Columns["MaterialQuantity"].ReadOnly = true;
                this.GV.Columns["MaterialUnit"].ReadOnly = true;
                this.GV.Columns["MaterialPricCost"].ReadOnly = true;
                this.GV.Columns["MaterialPricSale"].ReadOnly = true;
                this.GV.Columns["MaterialIsStop"].ReadOnly = true;
                this.GV.Columns["MaterialExpDate"].ReadOnly = true;
                this.GV.Columns["MaterialNote"].ReadOnly = true;
                this.GV.Columns["MaterialDisMiWi"].ReadOnly = true;
                this.GV.Columns["MaterialDarMiWi"].ReadOnly = true;
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
                this.TxtTotalCost.Text = "احسب";
                this.TxTTotalSale.Text = "احسب";
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
                        decimal num = new decimal(Conversion.Val(current.Cells["MaterialQuantity"].Value.ToString()));
                        decimal num2 = new decimal(Conversion.Val(current.Cells["MaterialPricCost"].Value.ToString()));
                        decimal num3 = new decimal(Conversion.Val(current.Cells["MaterialPricSale"].Value.ToString()));
                        current.Cells["MaterialQuantity"].Value = num.ToString(A.PR.BR);
                        current.Cells["MaterialPricCost"].Value = num2.ToString(A.PR.YR);
                        current.Cells["MaterialPricSale"].Value = num3.ToString(A.PR.YR);
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
                this.Q();
                if (this.ComboBoxSerachWat.SelectedIndex == 0)
                {
                    this.TxTSerach.Text = null;
                    this.TxTSerach.Focus();
                }
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
            if (this.CheckBoxAll.Checked)
            {
                int num = this.GV.Rows.Count - 1;
                for (int i = 0; i <= num; i++)
                {
                    this.GV.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                int num3 = this.GV.Rows.Count - 1;
                for (int i = 0; i <= num3; i++)
                {
                    this.GV.Rows[i].Cells[0].Value = false;
                }
            }
        }

        private void PR(object A, EventArgs R)
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
                        this.A = this.GV.CurrentRow.Index;
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNMaterial WHERE (MaterialID = @MaterialID)", this.A);
                        command.Parameters.AddWithValue("MaterialID", this.GV.SelectedRows[0].Cells["MaterialID"].Value.ToString());
                        command.ExecuteNonQuery();
                        this.A.Close();
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command2 = new SqlCommand("DELETE FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsBarCode = @TrDsBarCode)", this.A);
                        command2.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        command2.Parameters.AddWithValue("TrDsBarCode", this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString());
                        command2.ExecuteNonQuery();
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

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
        }

        private void QR(object A, EventArgs R)
        {
            this.GV.ClearSelection();
            this.GV.CurrentCell = this.GV.Rows[0].Cells[0];
            this.GV.Rows[0].Cells[0].Selected = true;
            if (Interaction.MsgBox(A.PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = this.GV.Rows.Count;
                    int num = this.GV.Rows.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 > num)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                            this.TimerLoadData.Enabled = true;
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num2;
                        int num3 = 0;
                        string str = "";
                        num3 = Conversions.ToInteger(this.GV.Rows[num2].Cells["MaterialID"].Value.ToString());
                        str = this.GV.Rows[num2].Cells["MaterialBarCode"].Value.ToString();
                        if (Conversions.ToBoolean(this.GV.Rows[num2].Cells[0].Value))
                        {
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand("DELETE FROM TaNNMaterial WHERE (MaterialID = @MaterialID)", this.A);
                            command.Parameters.AddWithValue("MaterialID", num3);
                            command.ExecuteNonQuery();
                            this.A.Close();
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command2 = new SqlCommand("DELETE FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsBarCode = @TrDsBarCode)", this.A);
                            command2.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                            command2.Parameters.AddWithValue("TrDsBarCode", str);
                            command2.ExecuteNonQuery();
                            this.A.Close();
                        }
                        num2++;
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
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
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
            A.D.A.A.ShowDialog();
        }

        private void S(object A, EventArgs R)
        {
            try
            {
                if (!A.PR.WR)
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
                    KD.Q = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                    KD.I = "SELECT TaNNInvPurchItems.*, TaNNSupliers.SuplierName FROM TaNNInvPurchItems LEFT OUTER JOIN TaNNSupliers ON TaNNInvPurchItems.SuplierFrontID = TaNNSupliers.SuplierID WHERE (TaNNInvPurchItems.CenterFrontID = @CenterFrontID) AND (TaNNInvPurchItems.PurchMaterialBarCode = @PurchMaterialBarCode) AND (TaNNInvPurchItems.InvPurchType = 0)";
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

        private void SR(object A, EventArgs R)
        {
            this.TimerSaveAll.Enabled = false;
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 12f);
            this.I();
        }

        private void T(object A, EventArgs R)
        {
            if (this.ComboBoxSerachWat.Text == null)
            {
                Interaction.MsgBox(A.PR.G.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.ComboBoxSerachWat.Focus();
            }
            else if (this.TxTSerach.Text == null)
            {
                Interaction.MsgBox(A.PR.E.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TxTSerach.Focus();
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 0)
            {
                this.A = "SELECT * FROM [TaNNMaterial] WHERE (CenterFrontID = @CenterFrontID AND MaterialBarCode = @MaterialBarCode) OR (CenterFrontID = @CenterFrontID AND MaterialMultBarCode Like '%*' + @BBMaterialMultBarCode + '*%')";
                this.TimerLoadData.Enabled = true;
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 1)
            {
                this.A = "SELECT * FROM [TaNNMaterial] WHERE (CenterFrontID = @CenterFrontID) AND (MaterialName LIKE '%' + @MaterialName + '%')";
                this.TimerLoadData.Enabled = true;
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 2)
            {
                this.A = "SELECT * FROM [TaNNMaterial] WHERE (CenterFrontID = @CenterFrontID) AND (MaterialNote LIKE '%' + @MaterialNote + '%')";
                this.TimerLoadData.Enabled = true;
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 3)
            {
                this.A = "SELECT * FROM [TaNNMaterial] WHERE (CenterFrontID = @CenterFrontID) And (MaterialMultBarCode Like '%*' + @MaterialMultBarCode + '*%')";
                this.TimerLoadData.Enabled = true;
            }
        }

        private void TR(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void U(object A, EventArgs R)
        {
            this.A = "SELECT * FROM [TaNNMaterial] WHERE (CenterFrontID = @CenterFrontID)";
            this.TimerLoadData.Enabled = true;
        }

        private void UR(object A, EventArgs R)
        {
            this.A = this.A.Replace(" ORDER BY [MaterialName]", "");
            this.A = this.A.Replace(" ORDER BY [GroupIDFrontID]", "");
            this.A = this.A + "  ORDER BY [GroupIDFrontID]";
            this.TimerLoadData.Enabled = true;
            Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
        }

        private void V(object A, EventArgs R)
        {
            try
            {
                if (!A.PR.WR)
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
                    VD.P = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                    VD.Q = "SELECT TaNNInvSaleItems.*, TaNNCustomers.CustomerName FROM TaNNInvSaleItems LEFT OUTER JOIN TaNNCustomers ON TaNNInvSaleItems.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSaleItems.CenterFrontID = @CenterFrontID) AND (TaNNInvSaleItems.HSaleBarCode = @HSaleBarCode) AND (TaNNInvSaleItems.HSaleType = 0)";
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

        private void VR(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                VI vi = new VI();
                vi.SetDataSource(this.A);
                vi.SetParameterValue("CenterName", A.PR.ER.ToString());
                vi.SetParameterValue("CenterSubName", A.PR.KR.ToString());
                vi.SetParameterValue("ParameterDeimelQ", A.PR.X);
                vi.SetParameterValue("ParameterDeimelS", A.PR.T);
                vi.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (A.PR.NR == null)
                {
                    vi.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    vi.SetParameterValue("CenterCurrencyName", A.PR.NR.ToString());
                }
                if (A.PR.UR == null)
                {
                    vi.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    vi.SetParameterValue("CenterPhone", A.PR.UR.ToString());
                }
                vi.SetParameterValue("TS", this.TxTTotalSale.Text);
                if (this.A)
                {
                    vi.SetParameterValue("TC", this.TxtTotalCost.Text);
                    vi.ReportDefinition.ReportObjects["Text14"].ObjectFormat.EnableSuppress = false;
                    vi.ReportDefinition.ReportObjects["XPriceCost1"].ObjectFormat.EnableSuppress = false;
                }
                else
                {
                    vi.SetParameterValue("TC", "مخفي");
                    vi.ReportDefinition.ReportObjects["Text14"].ObjectFormat.EnableSuppress = true;
                    vi.ReportDefinition.ReportObjects["XPriceCost1"].ObjectFormat.EnableSuppress = true;
                }
                new A.HR { CRViewer = { ReportSource = vi } }.ShowDialog();
                vi.Close();
                vi.Dispose();
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

        private void W(object A, EventArgs R)
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
                    EF.R = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                    EF.P = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND  (TrDsBarCode = @TrDsBarCode) AND (TrDsType = 0) ";
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

        private void X(object A, EventArgs R)
        {
            this.A = "SELECT TaNNMaterial.MaterialID, TaNNMaterial.CenterFrontID, TaNNMaterial.GroupIDFrontID, TaNNMaterial.MaterialBarCode, TaNNMaterial.MaterialName, TaNNMaterial.MaterialQuantity, TaNNMaterial.MaterialUnit, TaNNMaterial.MaterialPricCost, TaNNMaterial.MaterialPricLess, TaNNMaterial.MaterialPricSale, TaNNMaterial.MaterialIsStop, TaNNMaterial.MaterialExpDate, TaNNMaterial.MaterialNote, TaNNMaterial.MaterialNotIsView, TaNNMaterial.MaterialQuantityLess, TaNNMaterial.MaterialQuantityPakeg, TaNNMaterial.MaterialQuantityOffer, TaNNMaterial.MaterialDisMiWi, TaNNMaterial.MaterialDarMiWi, TaNNMaterial.MaterialOtherBarCode, TaNNMaterial.MaterialMultBarCode, TaNNMaterial.MaterialBarcodeBlock FROM TaNNMaterial INNER JOIN TaNNMaterial AS TaNNMaterial_1 ON TaNNMaterial.MaterialID = TaNNMaterial_1.MaterialID AND convert (DECIMAL(18, 3), TaNNMaterial.MaterialQuantity) <= convert (DECIMAL(18, 3), TaNNMaterial_1.MaterialQuantityLess) WHERE (TaNNMaterial.CenterFrontID = @CenterFrontID)";
            this.TimerLoadData.Enabled = true;
        }

        private void XR(object A, EventArgs R)
        {
        }

        private void Y(object A, EventArgs R)
        {
            if (!A.PR.VR)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
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
                        JD.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["MaterialID"].Value.ToString());
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

        private void YR(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                FQ fq = new FQ();
                fq.SetDataSource(this.A);
                fq.SetParameterValue("CenterName", A.PR.ER.ToString());
                fq.SetParameterValue("CenterSubName", A.PR.KR.ToString());
                fq.SetParameterValue("ParameterDeimelQ", A.PR.X);
                fq.SetParameterValue("ParameterDeimelS", A.PR.T);
                fq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (A.PR.NR == null)
                {
                    fq.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    fq.SetParameterValue("CenterCurrencyName", A.PR.NR.ToString());
                }
                if (A.PR.UR == null)
                {
                    fq.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    fq.SetParameterValue("CenterPhone", A.PR.UR.ToString());
                }
                fq.SetParameterValue("TS", this.TxTTotalSale.Text);
                if (this.A)
                {
                    fq.SetParameterValue("TC", this.TxtTotalCost.Text);
                    fq.ReportDefinition.ReportObjects["Text14"].ObjectFormat.EnableSuppress = false;
                    fq.ReportDefinition.ReportObjects["XPriceCost1"].ObjectFormat.EnableSuppress = false;
                }
                else
                {
                    fq.SetParameterValue("TC", "مخفي");
                    fq.ReportDefinition.ReportObjects["Text14"].ObjectFormat.EnableSuppress = true;
                    fq.ReportDefinition.ReportObjects["XPriceCost1"].ObjectFormat.EnableSuppress = true;
                }
                new A.HR { CRViewer = { ReportSource = fq } }.ShowDialog();
                fq.Close();
                fq.Dispose();
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
            try
            {
                if (!A.PR.WR)
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
                    KD.Q = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                    KD.I = "SELECT TaNNInvPurchItems.*, TaNNSupliers.SuplierName FROM TaNNInvPurchItems LEFT OUTER JOIN TaNNSupliers ON TaNNInvPurchItems.SuplierFrontID = TaNNSupliers.SuplierID WHERE (TaNNInvPurchItems.CenterFrontID = @CenterFrontID) AND (TaNNInvPurchItems.PurchMaterialBarCode = @PurchMaterialBarCode) AND (TaNNInvPurchItems.InvPurchType = 1)";
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

        private void ZR(object A, EventArgs R)
        {
            this.ToolStripButtonViewAll.Visible = false;
            this.ToolStripSeparator11.Visible = false;
            this.ToolStripButtonAdd.Visible = false;
            this.ToolStripSeparator2.Visible = false;
            this.ToolStripButtonEdit.Visible = false;
            this.ToolStripSeparator3.Visible = false;
            this.ToolStripButtonDelete.Visible = false;
            this.ToolStripSeparator4.Visible = false;
            this.ToolStripButtonCard.Visible = false;
            this.ToolStripSeparator5.Visible = false;
            this.ToolStripDropDownButtonTrDe.Visible = false;
            this.ToolStripSeparator9.Visible = false;
            this.ToolStripButtonReport.Visible = false;
            this.ToolStripSeparator10.Visible = false;
            this.ToolStripButtonPrint.Visible = false;
            this.ToolStripSeparator6.Visible = false;
            this.ToolStripButtonClose.Visible = false;
            this.GV.BeginEdit(true);
            this.TabControl1.Enabled = false;
            this.CheckBoxAll.Enabled = false;
            this.Panel1.Enabled = false;
            this.GV.Columns["MaterialPricLess"].Visible = true;
            this.GV.Columns["MaterialQuantity"].ReadOnly = false;
            this.GV.Columns["MaterialPricCost"].ReadOnly = false;
            this.GV.Columns["MaterialPricSale"].ReadOnly = false;
            this.GV.Columns["MaterialPricLess"].ReadOnly = false;
            this.GV.Columns["MaterialQuantity"].DefaultCellStyle.BackColor = Color.GhostWhite;
            this.GV.Columns["MaterialPricCost"].DefaultCellStyle.BackColor = Color.GhostWhite;
            this.GV.Columns["MaterialPricSale"].DefaultCellStyle.BackColor = Color.GhostWhite;
            this.GV.Columns["MaterialPricLess"].DefaultCellStyle.BackColor = Color.GhostWhite;
            this.ToolStripButtonXSave.Visible = true;
            this.ToolStripSeparator18.Visible = true;
            this.ToolStripButtonXNo.Visible = true;
        }

        internal virtual Button ButtonGroup
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual TextBox TxTSerQQ
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual Timer TimerLoadData
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual ComboBox ComboBoxSerachWat
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTSerach
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                EventHandler handler2 = new EventHandler(this.N);
                TextBox r = this.R;
                if (r != null)
                {
                    r.KeyPress -= handler;
                    r.TextChanged -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.KeyPress += handler;
                    r.TextChanged += handler2;
                }
            }
        }

        internal virtual Button ButtonSearchCodeName
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

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTInputDate
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual System.Windows.Forms.DateTimePicker DateTimePicker
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonSortQuntty
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual Button ButtonSortQunttyAdv
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual ToolStrip ToolStripStatus
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxAll
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

        internal virtual ToolStripProgressBar ToolStripProgressBar1
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Timer TimersStartUp
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ToolStripButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual ToolStrip ToolStripButtons
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual ToolStripButton ToolStripButtonViewAll
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual ToolStripSeparator ToolStripSeparator11
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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

        internal virtual Timer TimerFillGV
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
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

        internal virtual GroupBox GroupBox2
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

        internal virtual GroupBox GroupBox3
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual ToolStripDropDownButton ToolStripButtonCard
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem CardViewSale
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
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

        internal virtual ToolStripDropDownButton ToolStripButtonEdit
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                ToolStripDropDownButton r = this.R;
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

        internal virtual ToolStripMenuItem ButtonEditeMulti
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
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

        internal virtual ToolStripSeparator ToolStripSeparator8
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual ToolStripMenuItem ButtonEditSingle
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
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

        internal virtual ToolStripDropDownButton ToolStripDropDownButtonTrDe
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator9
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual ToolStripButton ToolStripButtonReport
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.IR);
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

        internal virtual ToolStripSeparator ToolStripSeparator10
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator12
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual ToolStripMenuItem CardViewReturnSale
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.B);
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

        internal virtual ToolStripSeparator ToolStripSeparator14
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator15
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual ToolStripMenuItem CardViewReturnPurch
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

        internal virtual ToolStripMenuItem CardViewPurch
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
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

        internal virtual ToolStripMenuItem ButtonTrDsAddDs
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.J);
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

        internal virtual ToolStripSeparator ToolStripSeparator16
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual ToolStripMenuItem ButtonTrDsAddTr
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.C);
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

        internal virtual ToolStripSeparator ToolStripSeparator17
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual ToolStripMenuItem ButtonTrDsView
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.M);
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

        internal virtual ToolStripMenuItem CardViewDDs
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.AR);
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

        internal virtual ToolStripMenuItem CardViewTTr
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.W);
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

        internal virtual TabPage TabPage6
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripDropDownButton ToolStripButtonDelete
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripMenuItem ButtonDeleteMulti
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.QR);
                ToolStripMenuItem e = this.E;
                if (e != null)
                {
                    e.Click -= handler;
                }
                this.E = value;
                e = this.E;
                if (e != null)
                {
                    e.Click += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator20
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual ToolStripMenuItem ButtonDeleteOne
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PR);
                ToolStripMenuItem k = this.K;
                if (k != null)
                {
                    k.Click -= handler;
                }
                this.K = value;
                k = this.K;
                if (k != null)
                {
                    k.Click += handler;
                }
            }
        }

        internal virtual Button ButtonPrivewList
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.DR);
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

        internal virtual TabPage TabPage8
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual Button ButtonCopy
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.FR);
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

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Button TxTTotalSale
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.TR);
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

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Button TxtTotalCost
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.HR);
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

        internal virtual ToolStripDropDownButton ToolStripButtonPrint
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripMenuItem BPrintSetting
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator21
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual ToolStripMenuItem BPrintPrint
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.XR);
                ToolStripMenuItem l = this.L;
                if (l != null)
                {
                    l.Click -= handler;
                }
                this.L = value;
                l = this.L;
                if (l != null)
                {
                    l.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem ToolStripMenuItemSC
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.GR);
                ToolStripMenuItem n = this.N;
                if (n != null)
                {
                    n.Click -= handler;
                }
                this.N = value;
                n = this.N;
                if (n != null)
                {
                    n.Click += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator26
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual ToolStripMenuItem ToolStripMenuItemHC
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ER);
                ToolStripMenuItem v = this.V;
                if (v != null)
                {
                    v.Click -= handler;
                }
                this.V = value;
                v = this.V;
                if (v != null)
                {
                    v.Click += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator27
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator28
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual ToolStripMenuItem ToolStripMenuItemSON
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.KR);
                ToolStripMenuItem y = this.Y;
                if (y != null)
                {
                    y.Click -= handler;
                }
                this.Y = value;
                y = this.Y;
                if (y != null)
                {
                    y.Click += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator29
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual ToolStripMenuItem ToolStripMenuItemSOG
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.UR);
                ToolStripMenuItem o = this.O;
                if (o != null)
                {
                    o.Click -= handler;
                }
                this.O = value;
                o = this.O;
                if (o != null)
                {
                    o.Click += handler;
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

        internal virtual ToolStripMenuItem CopytoClipToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.LR);
                ToolStripMenuItem b = this.B;
                if (b != null)
                {
                    b.Click -= handler;
                }
                this.B = value;
                b = this.B;
                if (b != null)
                {
                    b.Click += handler;
                }
            }
        }

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Button ButtonImportExport
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.NR);
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

        internal virtual ToolStripMenuItem PrintListWToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.VR);
                ToolStripMenuItem s = this.S;
                if (s != null)
                {
                    s.Click -= handler;
                }
                this.S = value;
                s = this.S;
                if (s != null)
                {
                    s.Click += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator22
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual ToolStripMenuItem PrintListHToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.YR);
                ToolStripMenuItem z = this.Z;
                if (z != null)
                {
                    z.Click -= handler;
                }
                this.Z = value;
                z = this.Z;
                if (z != null)
                {
                    z.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem QAddOtherToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.OR);
                ToolStripMenuItem m = this.M;
                if (m != null)
                {
                    m.Click -= handler;
                }
                this.M = value;
                m = this.M;
                if (m != null)
                {
                    m.Click += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator23
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual ToolStripMenuItem ViewReturnPurchaseLogToolStripMenuItemToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.BR);
                ToolStripMenuItem c = this.C;
                if (c != null)
                {
                    c.Click -= handler;
                }
                this.C = value;
                c = this.C;
                if (c != null)
                {
                    c.Click += handler;
                }
            }
        }

        internal virtual ToolStripButton ToolStripButtonXSave
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.MR);
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

        internal virtual ToolStripButton ToolStripButtonXNo
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.CR);
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

        internal virtual Timer TimerSaveAll
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.SR);
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

        internal virtual ToolStripMenuItem ExitHear
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ZR);
                ToolStripMenuItem j = this.J;
                if (j != null)
                {
                    j.Click -= handler;
                }
                this.J = value;
                j = this.J;
                if (j != null)
                {
                    j.Click += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator13
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator18
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
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

