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
    using System.IO.Ports;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class QH : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonSaleCode")]
        private Button A;
        [AccessedThroughProperty("PictureBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTBarCode")]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonFinishSave")]
        private Button R;
        [AccessedThroughProperty("ButtonPendingList"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonFinishIn")]
        private Button Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonPendingNow")]
        private Button I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerFocus")]
        private Timer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripFotter")]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripSeparator2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [AccessedThroughProperty("ToolStripSeparator3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator6")]
        private ToolStripSeparator I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonCanceInv")]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator D;
        [AccessedThroughProperty("ButtonQPrint"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonEditQQ"), CompilerGenerated]
        private ToolStripButton P;
        [CompilerGenerated, AccessedThroughProperty("ButtonSetting"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator8")]
        private ToolStripSeparator F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("SerialPortPoly"), CompilerGenerated]
        private SerialPort A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOpenCash"), CompilerGenerated]
        private ToolStripButton I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerStartUpLoad")]
        private Timer R;
        [AccessedThroughProperty("Panel5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Panel A;
        [CompilerGenerated, AccessedThroughProperty("PanelFotter"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("SplitContainer3"), CompilerGenerated]
        private SplitContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtEditeAll"), CompilerGenerated]
        private ToolStripButton D;
        [AccessedThroughProperty("ToolStripSeparator9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator10")]
        private ToolStripSeparator T;
        [CompilerGenerated, AccessedThroughProperty("ButPrintLast"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton F;
        [AccessedThroughProperty("Panel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPageX1")]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("SplitContainer1"), CompilerGenerated]
        private SplitContainer R;
        [AccessedThroughProperty("GVGroups"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView A;
        [CompilerGenerated, AccessedThroughProperty("GVMaterials"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPageX2")]
        private TabPage R;
        [AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("ComboBoxM"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("ComboBoxG"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPageX4")]
        private TabPage P;
        [CompilerGenerated, AccessedThroughProperty("SplitContainer2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private SplitContainer P;
        [AccessedThroughProperty("FlowLayoutPanel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FlowLayoutPanel A;
        [AccessedThroughProperty("TabPageX3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("SplitContainer4"), CompilerGenerated]
        private SplitContainer Q;
        [CompilerGenerated, AccessedThroughProperty("ButtonbySerch"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button D;
        [AccessedThroughProperty("TxTSerch"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("RadioButtonName"), CompilerGenerated]
        private RadioButton A;
        [CompilerGenerated, AccessedThroughProperty("RadioButtonNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RadioButton R;
        [AccessedThroughProperty("RadioButtonCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private RadioButton P;
        [AccessedThroughProperty("GVMMAdva"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonQPlus"), CompilerGenerated]
        private Button F;
        [AccessedThroughProperty("ButtonButtonQMinus"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTQuantityName")]
        private TextBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("FlowLayoutPanel2")]
        private FlowLayoutPanel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxQ"), CompilerGenerated]
        private GroupBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvSaleType")]
        private ComboBox P;
        [AccessedThroughProperty("Panel2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Panel Q;
        [AccessedThroughProperty("PanelMataem"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Panel I;
        [AccessedThroughProperty("ButtonMataNormal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button T;
        [AccessedThroughProperty("ButtonMataDelivary"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button X;
        [AccessedThroughProperty("ButtonMataTables"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvSaleCafeText")]
        private Label A;
        [AccessedThroughProperty("ButtonMataTawasi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button E;
        [AccessedThroughProperty("GroupBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("TabControl2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage1")]
        private TabPage I;
        [CompilerGenerated, AccessedThroughProperty("InvSaleDateTime"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [AccessedThroughProperty("InvSalePayType"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [CompilerGenerated, AccessedThroughProperty("InvSaleTotalNET"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("GroupBoxMAX"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox5")]
        private GroupBox F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvSaleTotalAmount"), CompilerGenerated]
        private Label P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox11")]
        private GroupBox H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvSaleItems")]
        private Label Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage2")]
        private TabPage D;
        [AccessedThroughProperty("InvSaleDisFinal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [AccessedThroughProperty("GroupBoxDis"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("InvSaleDisMaWiVAL")]
        private TextBox I;
        [AccessedThroughProperty("InvSaleDisMaWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label11")]
        private Label I;
        [CompilerGenerated, AccessedThroughProperty("Label10"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage3")]
        private TabPage F;
        [CompilerGenerated, AccessedThroughProperty("InvSaleDarFinal"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox F;
        [AccessedThroughProperty("InvSaleDarMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox H;
        [AccessedThroughProperty("TabPage5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage H;
        [AccessedThroughProperty("InvSaleNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label F;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label H;
        [AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label T;
        [AccessedThroughProperty("Button1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button K;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonEditSale")]
        private ToolStripButton H;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox X;
        [AccessedThroughProperty("TabPage4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage T;
        [AccessedThroughProperty("ButtonSerch"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button U;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonAdd")]
        private Button L;
        [CompilerGenerated, AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerNewOrOpenInvoice"), CompilerGenerated]
        private Timer P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Button2")]
        private Button N;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxCustomer"), CompilerGenerated]
        private ComboBox I;
        [AccessedThroughProperty("TimerGotoFinish"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBoxTxTBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox G;
        [AccessedThroughProperty("ToolStripMore"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripDropDownButton1"), CompilerGenerated]
        private ToolStripDropDownButton A;
        [CompilerGenerated, AccessedThroughProperty("TipAddOut"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("ToolStripSeparator11"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator X;
        [CompilerGenerated, AccessedThroughProperty("TipAddRemem"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator12")]
        private ToolStripSeparator G;
        [AccessedThroughProperty("TipCusAddAm"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem P;
        [AccessedThroughProperty("ToolStripSeparator13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator E;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TipSupAddAm")]
        private ToolStripMenuItem Q;
        [AccessedThroughProperty("ToolStripSeparator14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator K;
        [CompilerGenerated, AccessedThroughProperty("TipAddExp"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem I;
        [AccessedThroughProperty("ToolStripSeparator15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator U;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TipSetting"), CompilerGenerated]
        private ToolStripMenuItem D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonReMAX")]
        private Button V;
        [CompilerGenerated, AccessedThroughProperty("InvSaleIDMAX"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox4")]
        private GroupBox E;
        [AccessedThroughProperty("ButtonOrdarNo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Y;
        [AccessedThroughProperty("TxTOrdarNo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox G;
        [AccessedThroughProperty("ButtonQery"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripDropDownButton R;
        [AccessedThroughProperty("F12ToolStripMenuIQC"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem F;
        [AccessedThroughProperty("ToolStripSeparator1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator L;
        [AccessedThroughProperty("F7ToolStripMenuIQM"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem H;
        [CompilerGenerated, AccessedThroughProperty("ButtonGift"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button O;
        [CompilerGenerated, AccessedThroughProperty("ButtonRemoveCustomer"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button B;
        [AccessedThroughProperty("ComboBoxBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox D;
        [CompilerGenerated, AccessedThroughProperty("TimerWelcomeBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStrip1"), CompilerGenerated]
        private ToolStrip P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSplitButton1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton P;
        [AccessedThroughProperty("ButtonDis"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator16"), CompilerGenerated]
        private ToolStripSeparator N;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonDisRemve")]
        private ToolStripMenuItem X;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator17")]
        private ToolStripSeparator V;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonDisChange")]
        private ToolStripMenuItem G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerGotoSave"), CompilerGenerated]
        private Timer D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator18")]
        private ToolStripSeparator Y;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("AddFreeM")]
        private ToolStripMenuItem E;
        private SqlConnection A;
        public static string A;
        private Image A;
        public static int A;
        public static bool A;
        private bool R;
        public static string R;
        private bool P;
        public static bool Q = true;
        public static bool I = false;
        private int R;
        public static string P = "0";
        public static string Q = "0";
        public static string I = "0";
        private TextBox E;
        private TextBox K;
        private TextBox U;
        private TextBox L;
        private TextBox N;
        private TextBox V;
        private TextBox Y;
        private TextBox O;
        private TextBox B;
        private TextBox S;
        private CheckBox A;
        private TextBox Z;
        private TextBox M;
        private CheckBox R;
        private TextBox C;
        private TextBox J;
        private TextBox W;
        private TextBox AR;
        private TextBox PR;
        private TextBox QR;
        private TextBox IR;
        private TextBox DR;
        private TextBox FR;
        private TextBox HR;
        private TextBox TR;
        private TextBox XR;
        private TextBox GR;
        private TextBox ER;
        private TextBox KR;
        private CheckBox P;
        private TextBox UR;
        public static TextBox LR = new TextBox();
        private TextBox NR;
        private TextBox VR;
        private TextBox YR;
        private TextBox OR;
        private TextBox BR;
        private int P;
        private TextBox SR;
        public static string D = "خصم على اجمالي الفاتورة";
        private bool D;
        private TextBox ZR;

        public QH()
        {
            base.Load += new EventHandler(this.R);
            base.KeyUp += new KeyEventHandler(this.A);
            base.Closed += new EventHandler(this.NR);
            base.Shown += new EventHandler(this.SR);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = A.F.SaleX;
            this.R = false;
            this.P = false;
            this.R = 0;
            this.E = new TextBox();
            this.K = new TextBox();
            this.U = new TextBox();
            this.L = new TextBox();
            this.N = new TextBox();
            this.V = new TextBox();
            this.Y = new TextBox();
            this.O = new TextBox();
            this.B = new TextBox();
            this.S = new TextBox();
            this.A = new CheckBox();
            this.Z = new TextBox();
            this.M = new TextBox();
            this.R = new CheckBox();
            this.C = new TextBox();
            this.J = new TextBox();
            this.W = new TextBox();
            this.AR = new TextBox();
            this.PR = new TextBox();
            this.QR = new TextBox();
            this.IR = new TextBox();
            this.DR = new TextBox();
            this.FR = new TextBox();
            this.HR = new TextBox();
            this.TR = new TextBox();
            this.XR = new TextBox();
            this.GR = new TextBox();
            this.ER = new TextBox();
            this.KR = new TextBox();
            this.P = new CheckBox();
            this.UR = new TextBox();
            this.NR = new TextBox();
            this.VR = new TextBox();
            this.YR = new TextBox();
            this.OR = new TextBox();
            this.BR = new TextBox();
            this.P = 0;
            this.SR = new TextBox();
            this.D = false;
            this.ZR = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(QH));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.TxTBarCode = new TextBox();
            this.TimerFocus = new Timer(this.A);
            this.ToolStripFotter = new ToolStrip();
            this.ButtonSetting = new ToolStripButton();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ButtonQPrint = new ToolStripButton();
            this.ToolStripSeparator10 = new ToolStripSeparator();
            this.ButPrintLast = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ButtonQery = new ToolStripDropDownButton();
            this.F12ToolStripMenuIQC = new ToolStripMenuItem();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.F7ToolStripMenuIQM = new ToolStripMenuItem();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ButtEditeAll = new ToolStripButton();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.ButtonOpenCash = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ButtonEditSale = new ToolStripButton();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ButtonEditQQ = new ToolStripButton();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ButtonCanceInv = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.SerialPortPoly = new SerialPort(this.A);
            this.TimerStartUpLoad = new Timer(this.A);
            this.PanelFotter = new Panel();
            this.ButtonFinishIn = new Button();
            this.ButtonFinishSave = new Button();
            this.ButtonPendingList = new Button();
            this.ButtonPendingNow = new Button();
            this.Panel5 = new Panel();
            this.Panel2 = new Panel();
            this.GroupBoxTxTBarCode = new GroupBox();
            this.ComboBoxBarCode = new ComboBox();
            this.PictureBox2 = new PictureBox();
            this.ToolStripMore = new ToolStrip();
            this.ToolStripDropDownButton1 = new ToolStripDropDownButton();
            this.TipAddOut = new ToolStripMenuItem();
            this.ToolStripSeparator18 = new ToolStripSeparator();
            this.AddFreeM = new ToolStripMenuItem();
            this.ToolStripSeparator11 = new ToolStripSeparator();
            this.TipAddRemem = new ToolStripMenuItem();
            this.ToolStripSeparator12 = new ToolStripSeparator();
            this.TipCusAddAm = new ToolStripMenuItem();
            this.ToolStripSeparator13 = new ToolStripSeparator();
            this.TipSupAddAm = new ToolStripMenuItem();
            this.ToolStripSeparator14 = new ToolStripSeparator();
            this.TipAddExp = new ToolStripMenuItem();
            this.ToolStripSeparator15 = new ToolStripSeparator();
            this.TipSetting = new ToolStripMenuItem();
            this.GroupBoxQ = new GroupBox();
            this.ButtonButtonQMinus = new Button();
            this.TxTQuantityName = new TextBox();
            this.ButtonQPlus = new Button();
            this.GroupBox2 = new GroupBox();
            this.InvSaleType = new ComboBox();
            this.ButtonSaleCode = new Button();
            this.Panel1 = new Panel();
            this.TabControl2 = new TabControl();
            this.TabPage1 = new TabPage();
            this.InvSaleDateTime = new DateTimePicker();
            this.InvSalePayType = new ComboBox();
            this.GroupBoxMAX = new GroupBox();
            this.ButtonReMAX = new Button();
            this.InvSaleIDMAX = new TextBox();
            this.GroupBox5 = new GroupBox();
            this.InvSaleTotalAmount = new Label();
            this.GroupBox11 = new GroupBox();
            this.InvSaleItems = new Label();
            this.TabPage2 = new TabPage();
            this.GroupBox3 = new GroupBox();
            this.InvSaleDisFinal = new TextBox();
            this.ButtonGift = new Button();
            this.Label3 = new Label();
            this.GroupBoxDis = new GroupBox();
            this.ToolStrip1 = new ToolStrip();
            this.ToolStripSplitButton1 = new ToolStripDropDownButton();
            this.ButtonDis = new ToolStripMenuItem();
            this.ToolStripSeparator16 = new ToolStripSeparator();
            this.ButtonDisRemve = new ToolStripMenuItem();
            this.ToolStripSeparator17 = new ToolStripSeparator();
            this.ButtonDisChange = new ToolStripMenuItem();
            this.InvSaleDisMaWiVAL = new TextBox();
            this.InvSaleDisMaWi = new TextBox();
            this.Label11 = new Label();
            this.Label10 = new Label();
            this.TabPage3 = new TabPage();
            this.Label2 = new Label();
            this.InvSaleDarFinal = new TextBox();
            this.InvSaleDarMiWi = new TextBox();
            this.Label1 = new Label();
            this.TabPage5 = new TabPage();
            this.Button1 = new Button();
            this.InvSaleNote = new TextBox();
            this.TabPage4 = new TabPage();
            this.ButtonRemoveCustomer = new Button();
            this.ComboBoxCustomer = new ComboBox();
            this.Button2 = new Button();
            this.ButtonSerch = new Button();
            this.ButtonAdd = new Button();
            this.GroupBox1 = new GroupBox();
            this.InvSaleTotalNET = new Label();
            this.SplitContainer3 = new SplitContainer();
            this.TabControl1 = new TabControl();
            this.TabPageX1 = new TabPage();
            this.SplitContainer1 = new SplitContainer();
            this.GVGroups = new DataGridView();
            this.GVMaterials = new DataGridView();
            this.TabPageX2 = new TabPage();
            this.GroupBox8 = new GroupBox();
            this.ComboBoxM = new ComboBox();
            this.GroupBox6 = new GroupBox();
            this.ComboBoxG = new ComboBox();
            this.TabPageX4 = new TabPage();
            this.SplitContainer2 = new SplitContainer();
            this.FlowLayoutPanel1 = new FlowLayoutPanel();
            this.FlowLayoutPanel2 = new FlowLayoutPanel();
            this.TabPageX3 = new TabPage();
            this.SplitContainer4 = new SplitContainer();
            this.TxTSerch = new TextBox();
            this.RadioButtonName = new RadioButton();
            this.RadioButtonNote = new RadioButton();
            this.RadioButtonCode = new RadioButton();
            this.ButtonbySerch = new Button();
            this.GVMMAdva = new DataGridView();
            this.GV = new DataGridView();
            this.PanelMataem = new Panel();
            this.GroupBox4 = new GroupBox();
            this.ButtonOrdarNo = new Button();
            this.TxTOrdarNo = new TextBox();
            this.ButtonMataTawasi = new Button();
            this.ButtonMataDelivary = new Button();
            this.ButtonMataTables = new Button();
            this.ButtonMataNormal = new Button();
            this.InvSaleCafeText = new Label();
            this.TimerNewOrOpenInvoice = new Timer(this.A);
            this.TimerGotoFinish = new Timer(this.A);
            this.TimerWelcomeBarCode = new Timer(this.A);
            this.TimerGotoSave = new Timer(this.A);
            this.ToolStripFotter.SuspendLayout();
            this.PanelFotter.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.GroupBoxTxTBarCode.SuspendLayout();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            this.ToolStripMore.SuspendLayout();
            this.GroupBoxQ.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBoxMAX.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBoxDis.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SplitContainer3.BeginInit();
            this.SplitContainer3.Panel1.SuspendLayout();
            this.SplitContainer3.Panel2.SuspendLayout();
            this.SplitContainer3.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPageX1.SuspendLayout();
            this.SplitContainer1.BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((ISupportInitialize) this.GVGroups).BeginInit();
            ((ISupportInitialize) this.GVMaterials).BeginInit();
            this.TabPageX2.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.TabPageX4.SuspendLayout();
            this.SplitContainer2.BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.TabPageX3.SuspendLayout();
            this.SplitContainer4.BeginInit();
            this.SplitContainer4.Panel1.SuspendLayout();
            this.SplitContainer4.Panel2.SuspendLayout();
            this.SplitContainer4.SuspendLayout();
            ((ISupportInitialize) this.GVMMAdva).BeginInit();
            ((ISupportInitialize) this.GV).BeginInit();
            this.PanelMataem.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            base.SuspendLayout();
            this.TxTBarCode.BackColor = SystemColors.Info;
            this.TxTBarCode.Enabled = false;
            this.TxTBarCode.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTBarCode.Location = new Point(3, 0x61);
            this.TxTBarCode.Name = "TxTBarCode";
            this.TxTBarCode.RightToLeft = RightToLeft.No;
            this.TxTBarCode.Size = new Size(0, 0x1b);
            this.TxTBarCode.TabIndex = 0;
            this.TxTBarCode.TextAlign = HorizontalAlignment.Center;
            this.ToolStripFotter.BackColor = Color.WhiteSmoke;
            this.ToolStripFotter.Dock = DockStyle.Bottom;
            this.ToolStripFotter.Enabled = false;
            this.ToolStripFotter.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripFotter.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[0x12];
            toolStripItems[0] = this.ButtonSetting;
            toolStripItems[1] = this.ToolStripSeparator8;
            toolStripItems[2] = this.ButtonQPrint;
            toolStripItems[3] = this.ToolStripSeparator10;
            toolStripItems[4] = this.ButPrintLast;
            toolStripItems[5] = this.ToolStripSeparator2;
            toolStripItems[6] = this.ButtonQery;
            toolStripItems[7] = this.ToolStripSeparator3;
            toolStripItems[8] = this.ButtEditeAll;
            toolStripItems[9] = this.ToolStripSeparator9;
            toolStripItems[10] = this.ButtonOpenCash;
            toolStripItems[11] = this.ToolStripSeparator4;
            toolStripItems[12] = this.ButtonEditSale;
            toolStripItems[13] = this.ToolStripSeparator5;
            toolStripItems[14] = this.ButtonEditQQ;
            toolStripItems[15] = this.ToolStripSeparator6;
            toolStripItems[0x10] = this.ButtonCanceInv;
            toolStripItems[0x11] = this.ToolStripSeparator7;
            this.ToolStripFotter.Items.AddRange(toolStripItems);
            this.ToolStripFotter.Location = new Point(0, 0x265);
            this.ToolStripFotter.Name = "ToolStripFotter";
            this.ToolStripFotter.Size = new Size(0x431, 0x27);
            this.ToolStripFotter.TabIndex = 0x1ed36bb;
            this.ButtonSetting.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonSetting.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSetting.Image = A.F.ImSettingS;
            this.ButtonSetting.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonSetting.ImageTransparentColor = Color.Magenta;
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Size = new Size(0x4a, 0x24);
            this.ButtonSetting.Text = "اعدادات";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(6, 0x27);
            this.ButtonQPrint.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ButtonQPrint.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonQPrint.ForeColor = Color.Blue;
            this.ButtonQPrint.ImageTransparentColor = Color.Magenta;
            this.ButtonQPrint.Name = "ButtonQPrint";
            this.ButtonQPrint.Size = new Size(0x86, 0x24);
            this.ButtonQPrint.Text = "طباعة القائمة/طلبية F10";
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new Size(6, 0x27);
            this.ButPrintLast.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ButPrintLast.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButPrintLast.ForeColor = Color.Blue;
            this.ButPrintLast.ImageTransparentColor = Color.Magenta;
            this.ButPrintLast.Name = "ButPrintLast";
            this.ButPrintLast.Size = new Size(130, 0x24);
            this.ButPrintLast.Text = "طباعة فواتير سابقة F11";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x27);
            this.ButtonQery.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.F12ToolStripMenuIQC, this.ToolStripSeparator1, this.F7ToolStripMenuIQM };
            this.ButtonQery.DropDownItems.AddRange(itemArray2);
            this.ButtonQery.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonQery.ForeColor = Color.Blue;
            this.ButtonQery.ImageTransparentColor = Color.Magenta;
            this.ButtonQery.Name = "ButtonQery";
            this.ButtonQery.Size = new Size(0x3d, 0x24);
            this.ButtonQery.Text = "استعلام";
            this.F12ToolStripMenuIQC.Name = "F12ToolStripMenuIQC";
            this.F12ToolStripMenuIQC.Size = new Size(190, 0x16);
            this.F12ToolStripMenuIQC.Text = "استعلام عن عميل F12";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(0xbb, 6);
            this.F7ToolStripMenuIQM.Name = "F7ToolStripMenuIQM";
            this.F7ToolStripMenuIQM.Size = new Size(190, 0x16);
            this.F7ToolStripMenuIQM.Text = "استعلام عن مادة F7";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x27);
            this.ButtEditeAll.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ButtEditeAll.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtEditeAll.ForeColor = Color.Blue;
            this.ButtEditeAll.ImageTransparentColor = Color.Magenta;
            this.ButtEditeAll.Name = "ButtEditeAll";
            this.ButtEditeAll.Size = new Size(0x48, 0x24);
            this.ButtEditeAll.Text = "تعديل متعدد";
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new Size(6, 0x27);
            this.ButtonOpenCash.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ButtonOpenCash.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOpenCash.ForeColor = Color.Blue;
            this.ButtonOpenCash.ImageTransparentColor = Color.Magenta;
            this.ButtonOpenCash.Name = "ButtonOpenCash";
            this.ButtonOpenCash.Size = new Size(80, 0x24);
            this.ButtonOpenCash.Text = "فتح الكاش F1";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x27);
            this.ButtonEditSale.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ButtonEditSale.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonEditSale.ForeColor = Color.Blue;
            this.ButtonEditSale.Image = (Image) manager.GetObject("ButtonEditSale.Image");
            this.ButtonEditSale.ImageTransparentColor = Color.Magenta;
            this.ButtonEditSale.Name = "ButtonEditSale";
            this.ButtonEditSale.Size = new Size(90, 0x24);
            this.ButtonEditSale.Text = "تعديل السعر F9";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(6, 0x27);
            this.ButtonEditQQ.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ButtonEditQQ.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonEditQQ.ForeColor = Color.Blue;
            this.ButtonEditQQ.ImageTransparentColor = Color.Magenta;
            this.ButtonEditQQ.Name = "ButtonEditQQ";
            this.ButtonEditQQ.Size = new Size(90, 0x24);
            this.ButtonEditQQ.Text = "تعديل الكمية F8";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new Size(6, 0x27);
            this.ButtonCanceInv.BackColor = Color.WhiteSmoke;
            this.ButtonCanceInv.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonCanceInv.Image = A.F.ImCancelSale;
            this.ButtonCanceInv.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonCanceInv.ImageTransparentColor = Color.Magenta;
            this.ButtonCanceInv.Name = "ButtonCanceInv";
            this.ButtonCanceInv.Size = new Size(0x59, 0x24);
            this.ButtonCanceInv.Text = "اغلاق F6";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(6, 0x27);
            this.TimerStartUpLoad.Interval = 500;
            this.PanelFotter.BackColor = Color.WhiteSmoke;
            this.PanelFotter.Controls.Add(this.ButtonFinishIn);
            this.PanelFotter.Controls.Add(this.ButtonFinishSave);
            this.PanelFotter.Controls.Add(this.ButtonPendingList);
            this.PanelFotter.Controls.Add(this.ButtonPendingNow);
            this.PanelFotter.Dock = DockStyle.Bottom;
            this.PanelFotter.Enabled = false;
            this.PanelFotter.Location = new Point(0, 0x23e);
            this.PanelFotter.Name = "PanelFotter";
            this.PanelFotter.Size = new Size(0x431, 0x27);
            this.PanelFotter.TabIndex = 0x1ed36c2;
            this.ButtonFinishIn.BackColor = Color.White;
            this.ButtonFinishIn.Dock = DockStyle.Right;
            this.ButtonFinishIn.Image = A.F.ImsaleFinish;
            this.ButtonFinishIn.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinishIn.Location = new Point(590, 0);
            this.ButtonFinishIn.Name = "ButtonFinishIn";
            this.ButtonFinishIn.Size = new Size(0x137, 0x27);
            this.ButtonFinishIn.TabIndex = 0x1ed36a6;
            this.ButtonFinishIn.Text = "   إنهاء البيع وفتح الصندوق | العملاء | اجراءات F2";
            this.ButtonFinishIn.UseVisualStyleBackColor = false;
            this.ButtonFinishSave.BackColor = Color.White;
            this.ButtonFinishSave.Dock = DockStyle.Right;
            this.ButtonFinishSave.Image = A.F.ImSave;
            this.ButtonFinishSave.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinishSave.Location = new Point(0x385, 0);
            this.ButtonFinishSave.Name = "ButtonFinishSave";
            this.ButtonFinishSave.Size = new Size(0xac, 0x27);
            this.ButtonFinishSave.TabIndex = 0x1ed36a9;
            this.ButtonFinishSave.Text = "حفظ التعديلات F5";
            this.ButtonFinishSave.UseVisualStyleBackColor = false;
            this.ButtonFinishSave.Visible = false;
            this.ButtonPendingList.BackColor = Color.White;
            this.ButtonPendingList.Cursor = Cursors.Default;
            this.ButtonPendingList.Dock = DockStyle.Left;
            this.ButtonPendingList.ForeColor = Color.FromArgb(0x40, 0, 0);
            this.ButtonPendingList.Image = A.F.ImPendingList;
            this.ButtonPendingList.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPendingList.Location = new Point(0x10f, 0);
            this.ButtonPendingList.Name = "ButtonPendingList";
            this.ButtonPendingList.Size = new Size(0x10f, 0x27);
            this.ButtonPendingList.TabIndex = 0x1ed36a8;
            this.ButtonPendingList.Text = "قائمة الفواتير المعلقة F4";
            this.ButtonPendingList.UseVisualStyleBackColor = false;
            this.ButtonPendingNow.BackColor = Color.White;
            this.ButtonPendingNow.Cursor = Cursors.Default;
            this.ButtonPendingNow.Dock = DockStyle.Left;
            this.ButtonPendingNow.ForeColor = Color.FromArgb(0x40, 0, 0);
            this.ButtonPendingNow.Image = A.F.ImPendingNow;
            this.ButtonPendingNow.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPendingNow.Location = new Point(0, 0);
            this.ButtonPendingNow.Name = "ButtonPendingNow";
            this.ButtonPendingNow.Size = new Size(0x10f, 0x27);
            this.ButtonPendingNow.TabIndex = 0x1ed36a7;
            this.ButtonPendingNow.Text = "تعليق هذه الفاتورة وفتح فاتورة جديدة F3";
            this.ButtonPendingNow.TextAlign = ContentAlignment.MiddleRight;
            this.ButtonPendingNow.UseVisualStyleBackColor = false;
            this.Panel5.BackColor = Color.White;
            this.Panel5.BorderStyle = BorderStyle.Fixed3D;
            this.Panel5.Controls.Add(this.Panel2);
            this.Panel5.Controls.Add(this.Panel1);
            this.Panel5.Dock = DockStyle.Top;
            this.Panel5.Location = new Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new Size(0x431, 0x83);
            this.Panel5.TabIndex = 0x1ed36c4;
            this.Panel2.Controls.Add(this.TxTBarCode);
            this.Panel2.Controls.Add(this.GroupBoxTxTBarCode);
            this.Panel2.Controls.Add(this.ToolStripMore);
            this.Panel2.Controls.Add(this.GroupBoxQ);
            this.Panel2.Controls.Add(this.GroupBox2);
            this.Panel2.Controls.Add(this.ButtonSaleCode);
            this.Panel2.Dock = DockStyle.Right;
            this.Panel2.Location = new Point(0x24c, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new Size(0x1e1, 0x7f);
            this.Panel2.TabIndex = 0x1ed36c2;
            this.GroupBoxTxTBarCode.Controls.Add(this.ComboBoxBarCode);
            this.GroupBoxTxTBarCode.Controls.Add(this.PictureBox2);
            this.GroupBoxTxTBarCode.Location = new Point(0xd1, 4);
            this.GroupBoxTxTBarCode.Name = "GroupBoxTxTBarCode";
            this.GroupBoxTxTBarCode.Size = new Size(0x105, 60);
            this.GroupBoxTxTBarCode.TabIndex = 0;
            this.GroupBoxTxTBarCode.TabStop = false;
            this.GroupBoxTxTBarCode.Text = "رقم/ باركود المادة";
            this.ComboBoxBarCode.BackColor = SystemColors.Info;
            this.ComboBoxBarCode.FormattingEnabled = true;
            this.ComboBoxBarCode.Location = new Point(0x51, 0x18);
            this.ComboBoxBarCode.MaxLength = 250;
            this.ComboBoxBarCode.Name = "ComboBoxBarCode";
            this.ComboBoxBarCode.RightToLeft = RightToLeft.No;
            this.ComboBoxBarCode.Size = new Size(0xac, 0x18);
            this.ComboBoxBarCode.TabIndex = 0;
            this.PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox2.Image = A.F.BarCodeSS;
            this.PictureBox2.Location = new Point(6, 0x16);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new Size(0x45, 0x1b);
            this.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 0x45;
            this.PictureBox2.TabStop = false;
            this.ToolStripMore.AutoSize = false;
            this.ToolStripMore.Dock = DockStyle.None;
            this.ToolStripMore.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripMore.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ToolStripDropDownButton1 };
            this.ToolStripMore.Items.AddRange(itemArray3);
            this.ToolStripMore.Location = new Point(9, 0x4b);
            this.ToolStripMore.Name = "ToolStripMore";
            this.ToolStripMore.Size = new Size(0x85, 0x24);
            this.ToolStripMore.TabIndex = 0x1ed36ca;
            ToolStripItem[] itemArray4 = new ToolStripItem[13];
            itemArray4[0] = this.TipAddOut;
            itemArray4[1] = this.ToolStripSeparator18;
            itemArray4[2] = this.AddFreeM;
            itemArray4[3] = this.ToolStripSeparator11;
            itemArray4[4] = this.TipAddRemem;
            itemArray4[5] = this.ToolStripSeparator12;
            itemArray4[6] = this.TipCusAddAm;
            itemArray4[7] = this.ToolStripSeparator13;
            itemArray4[8] = this.TipSupAddAm;
            itemArray4[9] = this.ToolStripSeparator14;
            itemArray4[10] = this.TipAddExp;
            itemArray4[11] = this.ToolStripSeparator15;
            itemArray4[12] = this.TipSetting;
            this.ToolStripDropDownButton1.DropDownItems.AddRange(itemArray4);
            this.ToolStripDropDownButton1.Image = A.F.ImWarining;
            this.ToolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            this.ToolStripDropDownButton1.Size = new Size(0x4c, 0x21);
            this.ToolStripDropDownButton1.Text = "أوامر ...";
            this.TipAddOut.Image = A.F.ImsaleFinish;
            this.TipAddOut.ImageScaling = ToolStripItemImageScaling.None;
            this.TipAddOut.Name = "TipAddOut";
            this.TipAddOut.Size = new Size(0xf9, 0x26);
            this.TipAddOut.Text = "إضافة مادة/خدمة غير موجودة";
            this.ToolStripSeparator18.Name = "ToolStripSeparator18";
            this.ToolStripSeparator18.Size = new Size(0xf6, 6);
            this.AddFreeM.Image = A.F.ImAdd;
            this.AddFreeM.ImageScaling = ToolStripItemImageScaling.None;
            this.AddFreeM.Name = "AddFreeM";
            this.AddFreeM.Size = new Size(0xf9, 0x26);
            this.AddFreeM.Text = "اضافة مادة بونص مجانا";
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new Size(0xf6, 6);
            this.TipAddRemem.Image = A.F.ImTimer;
            this.TipAddRemem.ImageScaling = ToolStripItemImageScaling.None;
            this.TipAddRemem.Name = "TipAddRemem";
            this.TipAddRemem.Size = new Size(0xf9, 0x26);
            this.TipAddRemem.Text = "اضافة ملاحظة/ تنبيه";
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            this.ToolStripSeparator12.Size = new Size(0xf6, 6);
            this.TipCusAddAm.Image = A.F.ImCustomerAdd;
            this.TipCusAddAm.ImageScaling = ToolStripItemImageScaling.None;
            this.TipCusAddAm.Name = "TipCusAddAm";
            this.TipCusAddAm.Size = new Size(0xf9, 0x26);
            this.TipCusAddAm.Text = "اضافة دفعة عميل";
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            this.ToolStripSeparator13.Size = new Size(0xf6, 6);
            this.TipSupAddAm.Image = A.F.ImSuplierAdd;
            this.TipSupAddAm.ImageScaling = ToolStripItemImageScaling.None;
            this.TipSupAddAm.Name = "TipSupAddAm";
            this.TipSupAddAm.Size = new Size(0xf9, 0x26);
            this.TipSupAddAm.Text = "اضافة دفعة مورد";
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            this.ToolStripSeparator14.Size = new Size(0xf6, 6);
            this.TipAddExp.Image = A.F.ImLMyFile;
            this.TipAddExp.ImageScaling = ToolStripItemImageScaling.None;
            this.TipAddExp.Name = "TipAddExp";
            this.TipAddExp.Size = new Size(0xf9, 0x26);
            this.TipAddExp.Text = "إضافة مصروفات ونفقات";
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            this.ToolStripSeparator15.Size = new Size(0xf6, 6);
            this.TipSetting.Image = A.F.ImSettingS;
            this.TipSetting.ImageScaling = ToolStripItemImageScaling.None;
            this.TipSetting.Name = "TipSetting";
            this.TipSetting.Size = new Size(0xf9, 0x26);
            this.TipSetting.Text = "إعدادات شاشة البيع";
            this.GroupBoxQ.Controls.Add(this.ButtonButtonQMinus);
            this.GroupBoxQ.Controls.Add(this.TxTQuantityName);
            this.GroupBoxQ.Controls.Add(this.ButtonQPlus);
            this.GroupBoxQ.Location = new Point(0x125, 0x3e);
            this.GroupBoxQ.Name = "GroupBoxQ";
            this.GroupBoxQ.Size = new Size(0xb1, 0x3a);
            this.GroupBoxQ.TabIndex = 1;
            this.GroupBoxQ.TabStop = false;
            this.GroupBoxQ.Text = "الكمية";
            this.ButtonButtonQMinus.Location = new Point(6, 0x16);
            this.ButtonButtonQMinus.Name = "ButtonButtonQMinus";
            this.ButtonButtonQMinus.Size = new Size(40, 0x1b);
            this.ButtonButtonQMinus.TabIndex = 40;
            this.ButtonButtonQMinus.Text = "-";
            this.ButtonButtonQMinus.UseVisualStyleBackColor = true;
            this.TxTQuantityName.BackColor = SystemColors.Info;
            this.TxTQuantityName.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTQuantityName.Location = new Point(0x31, 0x16);
            this.TxTQuantityName.MaxLength = 20;
            this.TxTQuantityName.Name = "TxTQuantityName";
            this.TxTQuantityName.RightToLeft = RightToLeft.No;
            this.TxTQuantityName.Size = new Size(0x4d, 0x1b);
            this.TxTQuantityName.TabIndex = 1;
            this.TxTQuantityName.Text = "1";
            this.TxTQuantityName.TextAlign = HorizontalAlignment.Center;
            this.ButtonQPlus.Location = new Point(0x81, 0x16);
            this.ButtonQPlus.Name = "ButtonQPlus";
            this.ButtonQPlus.Size = new Size(40, 0x1b);
            this.ButtonQPlus.TabIndex = 0x29;
            this.ButtonQPlus.Text = "+";
            this.ButtonQPlus.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.InvSaleType);
            this.GroupBox2.Location = new Point(9, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xc2, 60);
            this.GroupBox2.TabIndex = 0x1ed36c9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "نوع الفاتورة";
            this.InvSaleType.Dock = DockStyle.Fill;
            this.InvSaleType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvSaleType.FormattingEnabled = true;
            object[] items = new object[] { "فاتورة مبيعات", "فاتورة مرتجع مبيعات" };
            this.InvSaleType.Items.AddRange(items);
            this.InvSaleType.Location = new Point(3, 0x13);
            this.InvSaleType.Name = "InvSaleType";
            this.InvSaleType.Size = new Size(0xbc, 0x18);
            this.InvSaleType.TabIndex = 0x2c;
            this.ButtonSaleCode.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSaleCode.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSaleCode.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSaleCode.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSaleCode.FlatStyle = FlatStyle.Flat;
            this.ButtonSaleCode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSaleCode.Image = A.F.ImSale;
            this.ButtonSaleCode.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSaleCode.Location = new Point(0x91, 0x47);
            this.ButtonSaleCode.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSaleCode.Name = "ButtonSaleCode";
            this.ButtonSaleCode.Size = new Size(0x8f, 0x31);
            this.ButtonSaleCode.TabIndex = 2;
            this.ButtonSaleCode.Text = "بيع";
            this.ButtonSaleCode.UseVisualStyleBackColor = true;
            this.Panel1.Controls.Add(this.TabControl2);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Dock = DockStyle.Left;
            this.Panel1.Location = new Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x245, 0x7f);
            this.Panel1.TabIndex = 0x1ed36c1;
            this.TabControl2.Controls.Add(this.TabPage1);
            this.TabControl2.Controls.Add(this.TabPage2);
            this.TabControl2.Controls.Add(this.TabPage3);
            this.TabControl2.Controls.Add(this.TabPage5);
            this.TabControl2.Controls.Add(this.TabPage4);
            this.TabControl2.Dock = DockStyle.Left;
            this.TabControl2.Location = new Point(0xb0, 0);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.Padding = new Point(8, 6);
            this.TabControl2.RightToLeftLayout = true;
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new Size(0x18c, 0x7f);
            this.TabControl2.TabIndex = 0x1ed36c7;
            this.TabPage1.Controls.Add(this.InvSaleDateTime);
            this.TabPage1.Controls.Add(this.InvSalePayType);
            this.TabPage1.Controls.Add(this.GroupBoxMAX);
            this.TabPage1.Controls.Add(this.GroupBox5);
            this.TabPage1.Controls.Add(this.GroupBox11);
            this.TabPage1.Location = new Point(4, 0x1f);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x184, 0x5c);
            this.TabPage1.TabIndex = 6;
            this.TabPage1.Text = "تفاصيل الفاتورة";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.InvSaleDateTime.CustomFormat = "yyyy/MM/dd hh:mm:ss tt";
            this.InvSaleDateTime.Format = DateTimePickerFormat.Custom;
            this.InvSaleDateTime.Location = new Point(0x9d, 0x3b);
            this.InvSaleDateTime.Name = "InvSaleDateTime";
            this.InvSaleDateTime.RightToLeft = RightToLeft.No;
            this.InvSaleDateTime.Size = new Size(0xde, 0x17);
            this.InvSaleDateTime.TabIndex = 0x2710;
            this.InvSalePayType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvSalePayType.FormattingEnabled = true;
            object[] objArray2 = new object[] { "نقدا", "ذمم", "شبكة", "تحويل", "الرصيد المدور", "شيك", "إئتمان" };
            this.InvSalePayType.Items.AddRange(objArray2);
            this.InvSalePayType.Location = new Point(6, 0x3a);
            this.InvSalePayType.Name = "InvSalePayType";
            this.InvSalePayType.Size = new Size(0x91, 0x18);
            this.InvSalePayType.TabIndex = 0;
            this.GroupBoxMAX.BackColor = Color.White;
            this.GroupBoxMAX.Controls.Add(this.ButtonReMAX);
            this.GroupBoxMAX.Controls.Add(this.InvSaleIDMAX);
            this.GroupBoxMAX.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBoxMAX.Location = new Point(0x87, 3);
            this.GroupBoxMAX.Name = "GroupBoxMAX";
            this.GroupBoxMAX.Size = new Size(0x92, 0x2e);
            this.GroupBoxMAX.TabIndex = 0x1ed36c7;
            this.GroupBoxMAX.TabStop = false;
            this.GroupBoxMAX.Text = "رقم الفاتورة";
            this.ButtonReMAX.Dock = DockStyle.Left;
            this.ButtonReMAX.FlatStyle = FlatStyle.Flat;
            this.ButtonReMAX.Image = A.F.ImChange;
            this.ButtonReMAX.Location = new Point(3, 0x13);
            this.ButtonReMAX.Name = "ButtonReMAX";
            this.ButtonReMAX.Size = new Size(0x26, 0x18);
            this.ButtonReMAX.TabIndex = 0x23;
            this.ButtonReMAX.UseVisualStyleBackColor = true;
            this.InvSaleIDMAX.BackColor = SystemColors.Info;
            this.InvSaleIDMAX.Dock = DockStyle.Right;
            this.InvSaleIDMAX.Location = new Point(0x2b, 0x13);
            this.InvSaleIDMAX.Name = "InvSaleIDMAX";
            this.InvSaleIDMAX.RightToLeft = RightToLeft.No;
            this.InvSaleIDMAX.Size = new Size(100, 0x17);
            this.InvSaleIDMAX.TabIndex = 0;
            this.InvSaleIDMAX.TextAlign = HorizontalAlignment.Center;
            this.GroupBox5.BackColor = Color.White;
            this.GroupBox5.Controls.Add(this.InvSaleTotalAmount);
            this.GroupBox5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox5.Location = new Point(6, 3);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x7b, 0x2e);
            this.GroupBox5.TabIndex = 0x1ed36c6;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "مجموع فرعي";
            this.InvSaleTotalAmount.Dock = DockStyle.Fill;
            this.InvSaleTotalAmount.ForeColor = Color.DarkGreen;
            this.InvSaleTotalAmount.Location = new Point(3, 0x13);
            this.InvSaleTotalAmount.Name = "InvSaleTotalAmount";
            this.InvSaleTotalAmount.Size = new Size(0x75, 0x18);
            this.InvSaleTotalAmount.TabIndex = 0x21;
            this.InvSaleTotalAmount.Text = "0";
            this.InvSaleTotalAmount.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox11.BackColor = Color.White;
            this.GroupBox11.Controls.Add(this.InvSaleItems);
            this.GroupBox11.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox11.Location = new Point(0x11f, 3);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x5c, 0x2e);
            this.GroupBox11.TabIndex = 0x1ed36c9;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "عدد المواد";
            this.InvSaleItems.Dock = DockStyle.Fill;
            this.InvSaleItems.ForeColor = Color.DarkGreen;
            this.InvSaleItems.Location = new Point(3, 0x13);
            this.InvSaleItems.Name = "InvSaleItems";
            this.InvSaleItems.Size = new Size(0x56, 0x18);
            this.InvSaleItems.TabIndex = 0x2a;
            this.InvSaleItems.Text = "0";
            this.InvSaleItems.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage2.Controls.Add(this.GroupBox3);
            this.TabPage2.Controls.Add(this.ButtonGift);
            this.TabPage2.Controls.Add(this.Label3);
            this.TabPage2.Controls.Add(this.GroupBoxDis);
            this.TabPage2.Location = new Point(4, 0x1f);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x184, 0x5c);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "الخصم";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.InvSaleDisFinal);
            this.GroupBox3.Location = new Point(6, 3);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x94, 0x2c);
            this.GroupBox3.TabIndex = 6;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "اجمالي الخصم";
            this.InvSaleDisFinal.Dock = DockStyle.Fill;
            this.InvSaleDisFinal.Enabled = false;
            this.InvSaleDisFinal.ForeColor = Color.DarkGreen;
            this.InvSaleDisFinal.Location = new Point(3, 0x13);
            this.InvSaleDisFinal.MaxLength = 20;
            this.InvSaleDisFinal.Name = "InvSaleDisFinal";
            this.InvSaleDisFinal.RightToLeft = RightToLeft.No;
            this.InvSaleDisFinal.Size = new Size(0x8e, 0x17);
            this.InvSaleDisFinal.TabIndex = 3;
            this.InvSaleDisFinal.Text = "0";
            this.InvSaleDisFinal.TextAlign = HorizontalAlignment.Center;
            this.ButtonGift.FlatStyle = FlatStyle.Flat;
            this.ButtonGift.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonGift.Location = new Point(9, 0x34);
            this.ButtonGift.Name = "ButtonGift";
            this.ButtonGift.Size = new Size(0x91, 0x22);
            this.ButtonGift.TabIndex = 0x25;
            this.ButtonGift.Text = "بطاقة الهدية";
            this.ButtonGift.UseVisualStyleBackColor = true;
            this.Label3.AutoSize = true;
            this.Label3.Location = new Point(0x35, 10);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0, 0x10);
            this.Label3.TabIndex = 5;
            this.GroupBoxDis.Controls.Add(this.ToolStrip1);
            this.GroupBoxDis.Controls.Add(this.InvSaleDisMaWiVAL);
            this.GroupBoxDis.Controls.Add(this.InvSaleDisMaWi);
            this.GroupBoxDis.Controls.Add(this.Label11);
            this.GroupBoxDis.Controls.Add(this.Label10);
            this.GroupBoxDis.Dock = DockStyle.Right;
            this.GroupBoxDis.Location = new Point(160, 3);
            this.GroupBoxDis.Name = "GroupBoxDis";
            this.GroupBoxDis.Size = new Size(0xe1, 0x56);
            this.GroupBoxDis.TabIndex = 4;
            this.GroupBoxDis.TabStop = false;
            this.ToolStrip1.BackColor = Color.White;
            this.ToolStrip1.Dock = DockStyle.None;
            this.ToolStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.ToolStripSplitButton1 };
            this.ToolStrip1.Items.AddRange(itemArray5);
            this.ToolStrip1.Location = new Point(9, 0x1b);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new Size(0x30, 0x27);
            this.ToolStrip1.TabIndex = 0x16;
            this.ToolStrip1.Text = "ToolStrip1";
            this.ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.ButtonDis, this.ToolStripSeparator16, this.ButtonDisRemve, this.ToolStripSeparator17, this.ButtonDisChange };
            this.ToolStripSplitButton1.DropDownItems.AddRange(itemArray6);
            this.ToolStripSplitButton1.Image = A.F.ImOK;
            this.ToolStripSplitButton1.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            this.ToolStripSplitButton1.Name = "ToolStripSplitButton1";
            this.ToolStripSplitButton1.Size = new Size(0x2d, 0x24);
            this.ButtonDis.Image = A.F.ImOK;
            this.ButtonDis.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonDis.Name = "ButtonDis";
            this.ButtonDis.Size = new Size(0x113, 0x26);
            this.ButtonDis.Text = "تطبيق نسبة الخصم";
            this.ToolStripSeparator16.Name = "ToolStripSeparator16";
            this.ToolStripSeparator16.Size = new Size(0x110, 6);
            this.ButtonDisRemve.Image = A.F.ImDelete;
            this.ButtonDisRemve.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonDisRemve.Name = "ButtonDisRemve";
            this.ButtonDisRemve.Size = new Size(0x113, 0x26);
            this.ButtonDisRemve.Text = "إزالة الخصم";
            this.ToolStripSeparator17.Name = "ToolStripSeparator17";
            this.ToolStripSeparator17.Size = new Size(0x110, 6);
            this.ButtonDisChange.Image = A.F.Im_Refresh;
            this.ButtonDisChange.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonDisChange.Name = "ButtonDisChange";
            this.ButtonDisChange.Size = new Size(0x113, 0x26);
            this.ButtonDisChange.Text = "تحويل الخصم على مستوى المادة";
            this.InvSaleDisMaWiVAL.ForeColor = Color.DarkGreen;
            this.InvSaleDisMaWiVAL.Location = new Point(0x4a, 0x34);
            this.InvSaleDisMaWiVAL.MaxLength = 20;
            this.InvSaleDisMaWiVAL.Name = "InvSaleDisMaWiVAL";
            this.InvSaleDisMaWiVAL.RightToLeft = RightToLeft.No;
            this.InvSaleDisMaWiVAL.Size = new Size(0x61, 0x17);
            this.InvSaleDisMaWiVAL.TabIndex = 20;
            this.InvSaleDisMaWiVAL.Text = "0";
            this.InvSaleDisMaWiVAL.TextAlign = HorizontalAlignment.Center;
            this.InvSaleDisMaWi.ForeColor = Color.DarkGreen;
            this.InvSaleDisMaWi.Location = new Point(0x4a, 0x17);
            this.InvSaleDisMaWi.MaxLength = 5;
            this.InvSaleDisMaWi.Name = "InvSaleDisMaWi";
            this.InvSaleDisMaWi.RightToLeft = RightToLeft.No;
            this.InvSaleDisMaWi.Size = new Size(0x61, 0x17);
            this.InvSaleDisMaWi.TabIndex = 10;
            this.InvSaleDisMaWi.Text = "0";
            this.InvSaleDisMaWi.TextAlign = HorizontalAlignment.Center;
            this.Label11.ForeColor = Color.DarkGreen;
            this.Label11.Location = new Point(0xb1, 0x1a);
            this.Label11.Name = "Label11";
            this.Label11.Size = new Size(0x26, 0x10);
            this.Label11.TabIndex = 0;
            this.Label11.Text = "نسبة";
            this.Label11.TextAlign = ContentAlignment.TopCenter;
            this.Label10.ForeColor = Color.DarkGreen;
            this.Label10.Location = new Point(0xb1, 0x37);
            this.Label10.Name = "Label10";
            this.Label10.Size = new Size(0x21, 0x10);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "مبلغ";
            this.Label10.TextAlign = ContentAlignment.MiddleLeft;
            this.TabPage3.Controls.Add(this.Label2);
            this.TabPage3.Controls.Add(this.InvSaleDarFinal);
            this.TabPage3.Controls.Add(this.InvSaleDarMiWi);
            this.TabPage3.Controls.Add(this.Label1);
            this.TabPage3.Location = new Point(4, 0x1f);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x184, 0x5c);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "الضريبة";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.Label2.AutoSize = true;
            this.Label2.Location = new Point(0xb1, 0x33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x5d, 0x10);
            this.Label2.TabIndex = 0x20;
            this.Label2.Text = "مجموع الضريبة:";
            this.InvSaleDarFinal.Enabled = false;
            this.InvSaleDarFinal.ForeColor = Color.DarkRed;
            this.InvSaleDarFinal.Location = new Point(15, 0x30);
            this.InvSaleDarFinal.MaxLength = 20;
            this.InvSaleDarFinal.Name = "InvSaleDarFinal";
            this.InvSaleDarFinal.RightToLeft = RightToLeft.No;
            this.InvSaleDarFinal.Size = new Size(0x9c, 0x17);
            this.InvSaleDarFinal.TabIndex = 20;
            this.InvSaleDarFinal.Text = "0";
            this.InvSaleDarFinal.TextAlign = HorizontalAlignment.Center;
            this.InvSaleDarMiWi.Enabled = false;
            this.InvSaleDarMiWi.ForeColor = Color.DarkRed;
            this.InvSaleDarMiWi.Location = new Point(15, 0x12);
            this.InvSaleDarMiWi.MaxLength = 5;
            this.InvSaleDarMiWi.Name = "InvSaleDarMiWi";
            this.InvSaleDarMiWi.RightToLeft = RightToLeft.No;
            this.InvSaleDarMiWi.Size = new Size(0x9c, 0x17);
            this.InvSaleDarMiWi.TabIndex = 10;
            this.InvSaleDarMiWi.Text = "0";
            this.InvSaleDarMiWi.TextAlign = HorizontalAlignment.Center;
            this.Label1.AutoSize = true;
            this.Label1.Location = new Point(0xb1, 0x15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x79, 0x10);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "نسبة الضريبة الثابتة:";
            this.TabPage5.Controls.Add(this.Button1);
            this.TabPage5.Controls.Add(this.InvSaleNote);
            this.TabPage5.Location = new Point(4, 0x1f);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new Padding(3);
            this.TabPage5.Size = new Size(0x184, 0x5c);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "ملاحظات";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.Button1.FlatStyle = FlatStyle.Flat;
            this.Button1.Image = A.F.ImOkSmall;
            this.Button1.Location = new Point(0x1b, 0x12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0x29, 0x36);
            this.Button1.TabIndex = 0x23;
            this.Button1.UseVisualStyleBackColor = true;
            this.InvSaleNote.Location = new Point(0x59, 12);
            this.InvSaleNote.MaxLength = 0xbb8;
            this.InvSaleNote.Multiline = true;
            this.InvSaleNote.Name = "InvSaleNote";
            this.InvSaleNote.Size = new Size(0xf1, 60);
            this.InvSaleNote.TabIndex = 0;
            this.TabPage4.Controls.Add(this.ButtonRemoveCustomer);
            this.TabPage4.Controls.Add(this.ComboBoxCustomer);
            this.TabPage4.Controls.Add(this.Button2);
            this.TabPage4.Controls.Add(this.ButtonSerch);
            this.TabPage4.Controls.Add(this.ButtonAdd);
            this.TabPage4.Location = new Point(4, 0x1f);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new Padding(3);
            this.TabPage4.Size = new Size(0x184, 0x5c);
            this.TabPage4.TabIndex = 7;
            this.TabPage4.Text = "العميل";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.ButtonRemoveCustomer.FlatAppearance.BorderColor = Color.Green;
            this.ButtonRemoveCustomer.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonRemoveCustomer.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonRemoveCustomer.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonRemoveCustomer.FlatStyle = FlatStyle.Flat;
            this.ButtonRemoveCustomer.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonRemoveCustomer.ForeColor = Color.Red;
            this.ButtonRemoveCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonRemoveCustomer.Location = new Point(6, 6);
            this.ButtonRemoveCustomer.Margin = new Padding(3, 4, 3, 4);
            this.ButtonRemoveCustomer.Name = "ButtonRemoveCustomer";
            this.ButtonRemoveCustomer.Size = new Size(0x2d, 0x1f);
            this.ButtonRemoveCustomer.TabIndex = 0x26;
            this.ButtonRemoveCustomer.Text = "X";
            this.ButtonRemoveCustomer.UseVisualStyleBackColor = true;
            this.ComboBoxCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.ComboBoxCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxCustomer.BackColor = SystemColors.Info;
            this.ComboBoxCustomer.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxCustomer.FormattingEnabled = true;
            this.ComboBoxCustomer.Location = new Point(170, 9);
            this.ComboBoxCustomer.Name = "ComboBoxCustomer";
            this.ComboBoxCustomer.Size = new Size(0xd1, 0x1a);
            this.ComboBoxCustomer.TabIndex = 0x24;
            this.Button2.FlatStyle = FlatStyle.Flat;
            this.Button2.Image = A.F.ImOkSmall;
            this.Button2.ImageAlign = ContentAlignment.MiddleLeft;
            this.Button2.Location = new Point(0x39, 6);
            this.Button2.Name = "Button2";
            this.Button2.Size = new Size(0x6b, 0x1f);
            this.Button2.TabIndex = 0x23;
            this.Button2.Text = "موافق";
            this.Button2.UseVisualStyleBackColor = true;
            this.ButtonSerch.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSerch.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSerch.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSerch.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSerch.FlatStyle = FlatStyle.Flat;
            this.ButtonSerch.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSerch.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSerch.Location = new Point(6, 0x2f);
            this.ButtonSerch.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSerch.Name = "ButtonSerch";
            this.ButtonSerch.Size = new Size(0x9e, 0x22);
            this.ButtonSerch.TabIndex = 12;
            this.ButtonSerch.Text = "بحث متقدم";
            this.ButtonSerch.UseVisualStyleBackColor = true;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Flat;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(170, 0x2e);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0xd1, 0x23);
            this.ButtonAdd.TabIndex = 11;
            this.ButtonAdd.Text = "اضافة عميل";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.GroupBox1.BackColor = Color.White;
            this.GroupBox1.Controls.Add(this.InvSaleTotalNET);
            this.GroupBox1.Dock = DockStyle.Left;
            this.GroupBox1.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox1.ForeColor = Color.Navy;
            this.GroupBox1.Location = new Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb0, 0x7f);
            this.GroupBox1.TabIndex = 0x17;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "صافي المبلغ";
            this.InvSaleTotalNET.Dock = DockStyle.Top;
            this.InvSaleTotalNET.Font = new Font("Tahoma", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.InvSaleTotalNET.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.InvSaleTotalNET.Location = new Point(3, 0x16);
            this.InvSaleTotalNET.Name = "InvSaleTotalNET";
            this.InvSaleTotalNET.RightToLeft = RightToLeft.No;
            this.InvSaleTotalNET.Size = new Size(170, 0x68);
            this.InvSaleTotalNET.TabIndex = 0;
            this.InvSaleTotalNET.Text = "0";
            this.InvSaleTotalNET.TextAlign = ContentAlignment.MiddleCenter;
            this.SplitContainer3.BorderStyle = BorderStyle.Fixed3D;
            this.SplitContainer3.Dock = DockStyle.Fill;
            this.SplitContainer3.Location = new Point(0, 0xb2);
            this.SplitContainer3.Name = "SplitContainer3";
            this.SplitContainer3.Orientation = Orientation.Horizontal;
            this.SplitContainer3.Panel1.BackColor = Color.White;
            this.SplitContainer3.Panel1.Controls.Add(this.TabControl1);
            this.SplitContainer3.Panel1.Padding = new Padding(4);
            this.SplitContainer3.Panel1.RightToLeft = RightToLeft.Yes;
            this.SplitContainer3.Panel2.BackColor = Color.White;
            this.SplitContainer3.Panel2.Controls.Add(this.GV);
            this.SplitContainer3.Panel2.Padding = new Padding(4);
            this.SplitContainer3.Panel2.RightToLeft = RightToLeft.Yes;
            this.SplitContainer3.Size = new Size(0x431, 0x18c);
            this.SplitContainer3.SplitterDistance = 0xb8;
            this.SplitContainer3.SplitterIncrement = 4;
            this.SplitContainer3.TabIndex = 0x1ed36c6;
            this.TabControl1.Controls.Add(this.TabPageX1);
            this.TabControl1.Controls.Add(this.TabPageX2);
            this.TabControl1.Controls.Add(this.TabPageX4);
            this.TabControl1.Controls.Add(this.TabPageX3);
            this.TabControl1.Dock = DockStyle.Fill;
            this.TabControl1.Location = new Point(4, 4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(6, 6);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x425, 0xac);
            this.TabControl1.SizeMode = TabSizeMode.Fixed;
            this.TabControl1.TabIndex = 0x2b;
            this.TabPageX1.Controls.Add(this.SplitContainer1);
            this.TabPageX1.Location = new Point(4, 0x1f);
            this.TabPageX1.Name = "TabPageX1";
            this.TabPageX1.Padding = new Padding(3);
            this.TabPageX1.Size = new Size(0x41d, 0x89);
            this.TabPageX1.TabIndex = 0;
            this.TabPageX1.Text = "قائمة عامودية";
            this.TabPageX1.UseVisualStyleBackColor = true;
            this.SplitContainer1.Dock = DockStyle.Fill;
            this.SplitContainer1.Location = new Point(3, 3);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Panel1.Controls.Add(this.GVGroups);
            this.SplitContainer1.Panel1.RightToLeft = RightToLeft.Yes;
            this.SplitContainer1.Panel2.Controls.Add(this.GVMaterials);
            this.SplitContainer1.Panel2.RightToLeft = RightToLeft.Yes;
            this.SplitContainer1.Size = new Size(0x417, 0x83);
            this.SplitContainer1.SplitterDistance = 0x12d;
            this.SplitContainer1.TabIndex = 0;
            this.GVGroups.AllowUserToAddRows = false;
            this.GVGroups.AllowUserToDeleteRows = false;
            this.GVGroups.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVGroups.BackgroundColor = Color.WhiteSmoke;
            this.GVGroups.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            this.GVGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = SystemColors.Window;
            style.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.ControlText;
            style.NullValue = null;
            style.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style.SelectionForeColor = Color.Black;
            style.WrapMode = DataGridViewTriState.True;
            this.GVGroups.DefaultCellStyle = style;
            this.GVGroups.Dock = DockStyle.Fill;
            this.GVGroups.EnableHeadersVisualStyles = false;
            this.GVGroups.GridColor = Color.Black;
            this.GVGroups.Location = new Point(0, 0);
            this.GVGroups.MultiSelect = false;
            this.GVGroups.Name = "GVGroups";
            this.GVGroups.ReadOnly = true;
            this.GVGroups.RowHeadersVisible = false;
            this.GVGroups.RowTemplate.Height = 0x1c;
            this.GVGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVGroups.ShowEditingIcon = false;
            this.GVGroups.Size = new Size(0x12d, 0x83);
            this.GVGroups.TabIndex = 0x1ed36c3;
            this.GVMaterials.AllowUserToAddRows = false;
            this.GVMaterials.AllowUserToDeleteRows = false;
            this.GVMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVMaterials.BackgroundColor = SystemColors.ButtonFace;
            this.GVMaterials.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            this.GVMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = SystemColors.ControlText;
            style2.NullValue = null;
            style2.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style2.SelectionForeColor = Color.Black;
            style2.WrapMode = DataGridViewTriState.True;
            this.GVMaterials.DefaultCellStyle = style2;
            this.GVMaterials.Dock = DockStyle.Fill;
            this.GVMaterials.EnableHeadersVisualStyles = false;
            this.GVMaterials.GridColor = Color.Black;
            this.GVMaterials.Location = new Point(0, 0);
            this.GVMaterials.MultiSelect = false;
            this.GVMaterials.Name = "GVMaterials";
            this.GVMaterials.ReadOnly = true;
            this.GVMaterials.RowHeadersVisible = false;
            this.GVMaterials.RowTemplate.Height = 0x1c;
            this.GVMaterials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVMaterials.ShowEditingIcon = false;
            this.GVMaterials.Size = new Size(0x2e6, 0x83);
            this.GVMaterials.TabIndex = 0x1ed36c2;
            this.TabPageX2.Controls.Add(this.GroupBox8);
            this.TabPageX2.Controls.Add(this.GroupBox6);
            this.TabPageX2.Location = new Point(4, 0x1c);
            this.TabPageX2.Name = "TabPageX2";
            this.TabPageX2.Padding = new Padding(3);
            this.TabPageX2.Size = new Size(0x41d, 140);
            this.TabPageX2.TabIndex = 2;
            this.TabPageX2.Text = "قائمة منسدلة";
            this.TabPageX2.UseVisualStyleBackColor = true;
            this.GroupBox8.Controls.Add(this.ComboBoxM);
            this.GroupBox8.Dock = DockStyle.Top;
            this.GroupBox8.Location = new Point(3, 0x3d);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x417, 0x3a);
            this.GroupBox8.TabIndex = 2;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "المواد";
            this.ComboBoxM.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxM.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxM.Dock = DockStyle.Fill;
            this.ComboBoxM.FormattingEnabled = true;
            this.ComboBoxM.IntegralHeight = false;
            this.ComboBoxM.Location = new Point(3, 0x13);
            this.ComboBoxM.Name = "ComboBoxM";
            this.ComboBoxM.Size = new Size(0x411, 0x18);
            this.ComboBoxM.TabIndex = 0;
            this.GroupBox6.Controls.Add(this.ComboBoxG);
            this.GroupBox6.Dock = DockStyle.Top;
            this.GroupBox6.Location = new Point(3, 3);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x417, 0x3a);
            this.GroupBox6.TabIndex = 1;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "المجموعة";
            this.ComboBoxG.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.ComboBoxG.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxG.Dock = DockStyle.Fill;
            this.ComboBoxG.FormattingEnabled = true;
            this.ComboBoxG.IntegralHeight = false;
            this.ComboBoxG.Location = new Point(3, 0x13);
            this.ComboBoxG.Name = "ComboBoxG";
            this.ComboBoxG.Size = new Size(0x411, 0x18);
            this.ComboBoxG.TabIndex = 0;
            this.TabPageX4.BackColor = Color.Silver;
            this.TabPageX4.Controls.Add(this.SplitContainer2);
            this.TabPageX4.Location = new Point(4, 0x1c);
            this.TabPageX4.Name = "TabPageX4";
            this.TabPageX4.Padding = new Padding(3);
            this.TabPageX4.Size = new Size(0x41d, 140);
            this.TabPageX4.TabIndex = 3;
            this.TabPageX4.Text = "ازرار لمس";
            this.SplitContainer2.Dock = DockStyle.Fill;
            this.SplitContainer2.Location = new Point(3, 3);
            this.SplitContainer2.Name = "SplitContainer2";
            this.SplitContainer2.Panel1.BackColor = Color.White;
            this.SplitContainer2.Panel1.Controls.Add(this.FlowLayoutPanel1);
            this.SplitContainer2.Panel1.RightToLeft = RightToLeft.Yes;
            this.SplitContainer2.Panel2.BackColor = Color.White;
            this.SplitContainer2.Panel2.Controls.Add(this.FlowLayoutPanel2);
            this.SplitContainer2.Panel2.RightToLeft = RightToLeft.Yes;
            this.SplitContainer2.Size = new Size(0x417, 0x86);
            this.SplitContainer2.SplitterDistance = 0x1a9;
            this.SplitContainer2.TabIndex = 0;
            this.FlowLayoutPanel1.AutoScroll = true;
            this.FlowLayoutPanel1.Dock = DockStyle.Fill;
            this.FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            this.FlowLayoutPanel1.Location = new Point(0, 0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new Size(0x1a9, 0x86);
            this.FlowLayoutPanel1.TabIndex = 1;
            this.FlowLayoutPanel2.AutoScroll = true;
            this.FlowLayoutPanel2.Dock = DockStyle.Fill;
            this.FlowLayoutPanel2.Location = new Point(0, 0);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new Size(0x26a, 0x86);
            this.FlowLayoutPanel2.TabIndex = 0x29;
            this.TabPageX3.BackColor = Color.Silver;
            this.TabPageX3.Controls.Add(this.SplitContainer4);
            this.TabPageX3.Location = new Point(4, 0x1c);
            this.TabPageX3.Name = "TabPageX3";
            this.TabPageX3.Padding = new Padding(3);
            this.TabPageX3.Size = new Size(0x41d, 140);
            this.TabPageX3.TabIndex = 1;
            this.TabPageX3.Text = "بحث متقدم";
            this.SplitContainer4.Dock = DockStyle.Fill;
            this.SplitContainer4.Location = new Point(3, 3);
            this.SplitContainer4.Name = "SplitContainer4";
            this.SplitContainer4.Panel1.BackColor = Color.White;
            this.SplitContainer4.Panel1.Controls.Add(this.TxTSerch);
            this.SplitContainer4.Panel1.Controls.Add(this.RadioButtonName);
            this.SplitContainer4.Panel1.Controls.Add(this.RadioButtonNote);
            this.SplitContainer4.Panel1.Controls.Add(this.RadioButtonCode);
            this.SplitContainer4.Panel1.Controls.Add(this.ButtonbySerch);
            this.SplitContainer4.Panel1.RightToLeft = RightToLeft.Yes;
            this.SplitContainer4.Panel2.BackColor = Color.White;
            this.SplitContainer4.Panel2.Controls.Add(this.GVMMAdva);
            this.SplitContainer4.Panel2.RightToLeft = RightToLeft.Yes;
            this.SplitContainer4.Size = new Size(0x417, 0x86);
            this.SplitContainer4.SplitterDistance = 390;
            this.SplitContainer4.TabIndex = 0x1ed36c3;
            this.TxTSerch.BackColor = SystemColors.Info;
            this.TxTSerch.Dock = DockStyle.Top;
            this.TxTSerch.Location = new Point(0, 60);
            this.TxTSerch.Name = "TxTSerch";
            this.TxTSerch.Size = new Size(390, 0x17);
            this.TxTSerch.TabIndex = 1;
            this.RadioButtonName.AutoSize = true;
            this.RadioButtonName.Checked = true;
            this.RadioButtonName.Dock = DockStyle.Top;
            this.RadioButtonName.Location = new Point(0, 40);
            this.RadioButtonName.Name = "RadioButtonName";
            this.RadioButtonName.Size = new Size(390, 20);
            this.RadioButtonName.TabIndex = 0x1ed36c1;
            this.RadioButtonName.TabStop = true;
            this.RadioButtonName.Text = "بحث في اسم المادة";
            this.RadioButtonName.UseVisualStyleBackColor = true;
            this.RadioButtonNote.AutoSize = true;
            this.RadioButtonNote.Dock = DockStyle.Top;
            this.RadioButtonNote.Location = new Point(0, 20);
            this.RadioButtonNote.Name = "RadioButtonNote";
            this.RadioButtonNote.Size = new Size(390, 20);
            this.RadioButtonNote.TabIndex = 0x1ed36c2;
            this.RadioButtonNote.Text = "بحث في الملاحظات";
            this.RadioButtonNote.UseVisualStyleBackColor = true;
            this.RadioButtonCode.AutoSize = true;
            this.RadioButtonCode.Dock = DockStyle.Top;
            this.RadioButtonCode.Location = new Point(0, 0);
            this.RadioButtonCode.Name = "RadioButtonCode";
            this.RadioButtonCode.Size = new Size(390, 20);
            this.RadioButtonCode.TabIndex = 0x1ed36c0;
            this.RadioButtonCode.Text = "بحث في رقم المادة";
            this.RadioButtonCode.UseVisualStyleBackColor = true;
            this.ButtonbySerch.Dock = DockStyle.Bottom;
            this.ButtonbySerch.FlatAppearance.BorderColor = Color.Green;
            this.ButtonbySerch.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonbySerch.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonbySerch.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonbySerch.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonbySerch.Image = A.F.ImView;
            this.ButtonbySerch.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonbySerch.Location = new Point(0, 0x5c);
            this.ButtonbySerch.Margin = new Padding(3, 4, 3, 4);
            this.ButtonbySerch.Name = "ButtonbySerch";
            this.ButtonbySerch.Size = new Size(390, 0x2a);
            this.ButtonbySerch.TabIndex = 2;
            this.ButtonbySerch.Text = "بحث";
            this.ButtonbySerch.UseVisualStyleBackColor = true;
            this.GVMMAdva.AllowUserToAddRows = false;
            this.GVMMAdva.AllowUserToDeleteRows = false;
            this.GVMMAdva.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVMMAdva.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.GVMMAdva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Window;
            style3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = SystemColors.ControlText;
            style3.NullValue = null;
            style3.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style3.SelectionForeColor = Color.Black;
            style3.WrapMode = DataGridViewTriState.True;
            this.GVMMAdva.DefaultCellStyle = style3;
            this.GVMMAdva.Dock = DockStyle.Fill;
            this.GVMMAdva.EnableHeadersVisualStyles = false;
            this.GVMMAdva.GridColor = Color.Black;
            this.GVMMAdva.Location = new Point(0, 0);
            this.GVMMAdva.MultiSelect = false;
            this.GVMMAdva.Name = "GVMMAdva";
            this.GVMMAdva.ReadOnly = true;
            this.GVMMAdva.RowHeadersVisible = false;
            this.GVMMAdva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVMMAdva.ShowEditingIcon = false;
            this.GVMMAdva.Size = new Size(0x28d, 0x86);
            this.GVMMAdva.TabIndex = 0;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = Color.White;
            style4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = SystemColors.ControlText;
            style4.SelectionBackColor = Color.White;
            style4.SelectionForeColor = Color.Black;
            style4.WrapMode = DataGridViewTriState.True;
            this.GV.DefaultCellStyle = style4;
            this.GV.Dock = DockStyle.Fill;
            this.GV.GridColor = Color.Black;
            this.GV.Location = new Point(4, 4);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.GV.RowTemplate.Height = 0x23;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.ShowEditingIcon = false;
            this.GV.Size = new Size(0x425, 0xc4);
            this.GV.TabIndex = 0x17;
            this.PanelMataem.BackColor = Color.WhiteSmoke;
            this.PanelMataem.BorderStyle = BorderStyle.FixedSingle;
            this.PanelMataem.Controls.Add(this.GroupBox4);
            this.PanelMataem.Controls.Add(this.ButtonMataTawasi);
            this.PanelMataem.Controls.Add(this.ButtonMataDelivary);
            this.PanelMataem.Controls.Add(this.ButtonMataTables);
            this.PanelMataem.Controls.Add(this.ButtonMataNormal);
            this.PanelMataem.Controls.Add(this.InvSaleCafeText);
            this.PanelMataem.Dock = DockStyle.Top;
            this.PanelMataem.Location = new Point(0, 0x83);
            this.PanelMataem.Name = "PanelMataem";
            this.PanelMataem.Size = new Size(0x431, 0x2f);
            this.PanelMataem.TabIndex = 0x16;
            this.PanelMataem.Visible = false;
            this.GroupBox4.BackColor = Color.WhiteSmoke;
            this.GroupBox4.Controls.Add(this.ButtonOrdarNo);
            this.GroupBox4.Controls.Add(this.TxTOrdarNo);
            this.GroupBox4.Dock = DockStyle.Left;
            this.GroupBox4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox4.Location = new Point(0, 0);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(160, 0x2d);
            this.GroupBox4.TabIndex = 0x1ed36c8;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "رقم الطلب";
            this.ButtonOrdarNo.Dock = DockStyle.Left;
            this.ButtonOrdarNo.FlatStyle = FlatStyle.Flat;
            this.ButtonOrdarNo.Image = A.F.ImChange;
            this.ButtonOrdarNo.Location = new Point(3, 0x13);
            this.ButtonOrdarNo.Name = "ButtonOrdarNo";
            this.ButtonOrdarNo.Size = new Size(0x26, 0x17);
            this.ButtonOrdarNo.TabIndex = 0x23;
            this.ButtonOrdarNo.UseVisualStyleBackColor = true;
            this.TxTOrdarNo.BackColor = SystemColors.Info;
            this.TxTOrdarNo.Dock = DockStyle.Right;
            this.TxTOrdarNo.Location = new Point(0x21, 0x13);
            this.TxTOrdarNo.Name = "TxTOrdarNo";
            this.TxTOrdarNo.RightToLeft = RightToLeft.No;
            this.TxTOrdarNo.Size = new Size(0x7c, 0x17);
            this.TxTOrdarNo.TabIndex = 0;
            this.TxTOrdarNo.TextAlign = HorizontalAlignment.Center;
            this.ButtonMataTawasi.BackColor = Color.White;
            this.ButtonMataTawasi.Dock = DockStyle.Right;
            this.ButtonMataTawasi.Location = new Point(0xb2, 0);
            this.ButtonMataTawasi.Name = "ButtonMataTawasi";
            this.ButtonMataTawasi.Size = new Size(190, 0x2d);
            this.ButtonMataTawasi.TabIndex = 4;
            this.ButtonMataTawasi.Text = "تواصي";
            this.ButtonMataTawasi.UseVisualStyleBackColor = false;
            this.ButtonMataDelivary.BackColor = Color.White;
            this.ButtonMataDelivary.Dock = DockStyle.Right;
            this.ButtonMataDelivary.Location = new Point(0x170, 0);
            this.ButtonMataDelivary.Name = "ButtonMataDelivary";
            this.ButtonMataDelivary.Size = new Size(190, 0x2d);
            this.ButtonMataDelivary.TabIndex = 1;
            this.ButtonMataDelivary.Text = "توصيل";
            this.ButtonMataDelivary.UseVisualStyleBackColor = false;
            this.ButtonMataTables.BackColor = Color.White;
            this.ButtonMataTables.Dock = DockStyle.Right;
            this.ButtonMataTables.Location = new Point(0x22e, 0);
            this.ButtonMataTables.Name = "ButtonMataTables";
            this.ButtonMataTables.Size = new Size(190, 0x2d);
            this.ButtonMataTables.TabIndex = 0;
            this.ButtonMataTables.Text = "طاولة";
            this.ButtonMataTables.UseVisualStyleBackColor = false;
            this.ButtonMataNormal.BackColor = Color.White;
            this.ButtonMataNormal.Dock = DockStyle.Right;
            this.ButtonMataNormal.Location = new Point(0x2ec, 0);
            this.ButtonMataNormal.Name = "ButtonMataNormal";
            this.ButtonMataNormal.Size = new Size(190, 0x2d);
            this.ButtonMataNormal.TabIndex = 2;
            this.ButtonMataNormal.Text = "سفري";
            this.ButtonMataNormal.UseVisualStyleBackColor = false;
            this.InvSaleCafeText.BackColor = Color.White;
            this.InvSaleCafeText.Dock = DockStyle.Right;
            this.InvSaleCafeText.ForeColor = Color.Blue;
            this.InvSaleCafeText.Location = new Point(0x3aa, 0);
            this.InvSaleCafeText.Name = "InvSaleCafeText";
            this.InvSaleCafeText.Size = new Size(0x85, 0x2d);
            this.InvSaleCafeText.TabIndex = 3;
            this.InvSaleCafeText.TextAlign = ContentAlignment.MiddleCenter;
            this.TimerWelcomeBarCode.Enabled = true;
            this.TimerWelcomeBarCode.Interval = 200;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            base.ClientSize = new Size(0x431, 0x28c);
            base.Controls.Add(this.SplitContainer3);
            base.Controls.Add(this.PanelMataem);
            base.Controls.Add(this.Panel5);
            base.Controls.Add(this.PanelFotter);
            base.Controls.Add(this.ToolStripFotter);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "SaleForm";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "شاشة البيع";
            this.ToolStripFotter.ResumeLayout(false);
            this.ToolStripFotter.PerformLayout();
            this.PanelFotter.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.GroupBoxTxTBarCode.ResumeLayout(false);
            ((ISupportInitialize) this.PictureBox2).EndInit();
            this.ToolStripMore.ResumeLayout(false);
            this.ToolStripMore.PerformLayout();
            this.GroupBoxQ.ResumeLayout(false);
            this.GroupBoxQ.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.TabControl2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBoxMAX.ResumeLayout(false);
            this.GroupBoxMAX.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBoxDis.ResumeLayout(false);
            this.GroupBoxDis.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.SplitContainer3.Panel1.ResumeLayout(false);
            this.SplitContainer3.Panel2.ResumeLayout(false);
            this.SplitContainer3.EndInit();
            this.SplitContainer3.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPageX1.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((ISupportInitialize) this.GVGroups).EndInit();
            ((ISupportInitialize) this.GVMaterials).EndInit();
            this.TabPageX2.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.TabPageX4.ResumeLayout(false);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            this.SplitContainer2.EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.TabPageX3.ResumeLayout(false);
            this.SplitContainer4.Panel1.ResumeLayout(false);
            this.SplitContainer4.Panel1.PerformLayout();
            this.SplitContainer4.Panel2.ResumeLayout(false);
            this.SplitContainer4.EndInit();
            this.SplitContainer4.ResumeLayout(false);
            ((ISupportInitialize) this.GVMMAdva).EndInit();
            ((ISupportInitialize) this.GV).EndInit();
            this.PanelMataem.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, DataGridViewBindingCompleteEventArgs R)
        {
            this.Y();
        }

        private void A(object A, DataGridViewCellEventArgs R)
        {
            if (!Information.IsNothing(this.GVGroups.CurrentRow))
            {
                this.Y();
            }
        }

        private void A(object A, DataGridViewDataErrorEventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, KeyEventArgs R)
        {
            if (R.KeyCode == Keys.F1)
            {
                A.W.A();
            }
            if (R.KeyCode == Keys.F2)
            {
                this.ButtonFinishIn.PerformClick();
                this.ButtonFinishIn.Enabled = false;
            }
            if (R.KeyCode == Keys.F3)
            {
                this.ButtonPendingNow.PerformClick();
            }
            if (R.KeyCode == Keys.F4)
            {
                this.ButtonPendingList.PerformClick();
            }
            if (R.KeyCode == Keys.F5)
            {
                this.ButtonFinishSave.PerformClick();
            }
            if (R.KeyCode == Keys.F6)
            {
                this.ButtonCanceInv.PerformClick();
            }
            if (R.KeyCode == Keys.F7)
            {
                this.F7ToolStripMenuIQM.PerformClick();
            }
            if (R.KeyCode == Keys.F8)
            {
                this.ButtonEditQQ.PerformClick();
            }
            if (R.KeyCode == Keys.F9)
            {
                this.ButtonEditSale.PerformClick();
            }
            if (R.KeyCode == Keys.F10)
            {
                this.ButtonQPrint.PerformClick();
            }
            if (R.KeyCode == Keys.F11)
            {
                this.ButPrintLast.PerformClick();
            }
            if (R.KeyCode == Keys.F12)
            {
                this.F12ToolStripMenuIQC.PerformClick();
            }
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonbySerch.PerformClick();
            }
        }

        private void A(object A, MouseEventArgs R)
        {
            // Invalid method body.
        }

        private void AP(object A, EventArgs R)
        {
            if (A.AR.LR && (Strings.Len(this.ComboBoxBarCode.Text) > 0x10))
            {
                this.ComboBoxBarCode.Text = Strings.Left(this.ComboBoxBarCode.Text, 15);
            }
            this.ComboBoxBarCode.Items.Add(this.ComboBoxBarCode.Text.ToString());
            this.ComboBoxBarCode.Text = null;
            this.ComboBoxBarCode.Focus();
        }

        private void AR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        public void B()
        {
            Application.DoEvents();
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT [CustomerID], [CustomerName], [CustomerBalance] FROM TaNNCustomers";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    this.ComboBoxCustomer.SelectedValue = 0;
                }
                else
                {
                    this.ComboBoxCustomer.ValueMember = "CustomerID";
                    this.ComboBoxCustomer.DisplayMember = "CustomerName";
                    this.ComboBoxCustomer.DataSource = dataTable;
                    this.ComboBoxCustomer.SelectedValue = 0;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void B(object A, EventArgs R)
        {
            this.NR.Text = "1";
            this.InvSaleCafeText.Text = "تواصي";
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE TaNNTables SET InvSaleFrontID =@InvSaleFrontID, TableIsBooking =@TableIsBooking WHERE (TableID = @TableID)", this.A);
                command.Parameters.AddWithValue("TableID", LR.Text);
                command.Parameters.AddWithValue("InvSaleFrontID", DBNull.Value);
                command.Parameters.AddWithValue("TableIsBooking", false);
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("UPDATE [TaNNInvSale] SET [InvSaleCafeTablID] = @InvSaleCafeTablID, [InvSaleCafeText] = @InvSaleCafeText WHERE [InvSaleID] = @InvSaleID", this.A);
                command2.Parameters.AddWithValue("InvSaleID", QH.A);
                command2.Parameters.AddWithValue("InvSaleCafeTyp", this.NR.Text);
                command2.Parameters.AddWithValue("InvSaleCafeTablID", "0");
                command2.Parameters.AddWithValue("InvSaleCafeText", this.InvSaleCafeText.Text);
                command2.ExecuteNonQuery();
                this.A.Close();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
            this.L();
        }

        private void BR(object A, EventArgs R)
        {
            if (this.InvSaleType.SelectedIndex == 1)
            {
                Interaction.MsgBox("لا يمكنك استخدام بطاقة الهدية في حال مرتجع المبيعات", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                A.D.A.A.ShowDialog();
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
                RH.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["HSaleID"].Value.ToString());
                RH.R = 1;
                A.D.A.A.ShowDialog();
            }
        }

        private void CR(object A, EventArgs R)
        {
            if (!A.PR.HP)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                JI.A = true;
                A.D.A.A.ShowDialog();
            }
        }

        public void D()
        {
            if (this.TxTBarCode.Text == null)
            {
                Interaction.MsgBox("يجب تحديد / ادخال كود رقم المادة", MsgBoxStyle.ApplicationModal, null);
                this.ComboBoxBarCode.Focus();
                this.L();
            }
            else if (!(!A.PR.QQ & (Conversion.Val(this.TxTQuantityName.Text.Replace(",", "")) == 0.0)))
            {
                this.PanelFotter.Enabled = false;
                Q = true;
                this.F();
            }
            else
            {
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox("غير مسموح لك في بيع مواد عندما تكون الكمية 0", MsgBoxStyle.ApplicationModal, null);
                this.ComboBoxBarCode.Focus();
                this.L();
            }
        }

        private void D(object A, EventArgs R)
        {
            decimal num = new decimal(Conversion.Val(this.TxTQuantityName.Text.Replace(",", "")));
            num = decimal.Add(num, decimal.One);
            this.TxTQuantityName.Text = Conversions.ToString(num);
        }

        private void D(object A, DataGridViewCellEventArgs R)
        {
        }

        private void D(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                if (A.AR.LR && (Strings.Len(this.ComboBoxBarCode.Text) > 0x10))
                {
                    this.ComboBoxBarCode.Text = Strings.Left(this.ComboBoxBarCode.Text, 15);
                }
                this.ComboBoxBarCode.Items.Add(this.ComboBoxBarCode.Text.ToString());
                this.ComboBoxBarCode.Text = null;
                this.ComboBoxBarCode.Focus();
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

        private void DP(object A, EventArgs R)
        {
            Interaction.MsgBox(A.AR.T, MsgBoxStyle.ApplicationModal, null);
        }

        private void DR(object A, EventArgs R)
        {
            this.TimerGotoFinish.Enabled = false;
            if (A.PR.KR)
            {
                try
                {
                    P = Guid.NewGuid().ToString();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    Interaction.MsgBox("خطأ في عملية توليد كود uuid", MsgBoxStyle.ApplicationModal, null);
                    this.ButtonFinishIn.Enabled = true;
                    this.ButtonFinishIn.Text = "   إنهاء البيع وفتح الصندوق | العملاء | اجراءات F2";
                    Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.TimerFocus.Enabled = true;
                    ProjectData.ClearProjectError();
                    return;
                }
                if ((this.InvSaleType.SelectedIndex == 1) & ((Q == null) | (Conversion.Val(Q) == 0.0)))
                {
                    this.ButtonFinishIn.Enabled = true;
                    this.ButtonFinishIn.Text = "   إنهاء البيع وفتح الصندوق | العملاء | اجراءات F2";
                    A.D.A.A.ShowDialog();
                    return;
                }
            }
            try
            {
                IEnumerator enumerator;
                IEnumerator enumerator2;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT [HSaleID], [HSalePriceTotal], [HSaleDisVal], [HSaleDarVal] FROM [TaNNInvSaleItems] WHERE ([InvSaleFrontID] = @InvSaleFrontID) AND ([HSaleIsDelete] = @HSaleIsDelete)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleFrontID", QH.A);
                adapter.SelectCommand.Parameters.AddWithValue("HSaleIsDelete", false);
                adapter.Fill(dataTable);
                this.A.Close();
                int num = 0;
                decimal num2 = 0M;
                decimal num3 = 0M;
                decimal num4 = 0M;
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
                        object[] arguments = new object[] { "HSaleID" };
                        num = Conversions.ToInteger(NewLateBinding.LateIndexGet(current, arguments, null));
                        object[] objArray2 = new object[] { "HSalePriceTotal" };
                        num2 = Conversions.ToDecimal(NewLateBinding.LateIndexGet(current, objArray2, null));
                        object[] objArray3 = new object[] { "HSaleDisVal" };
                        num3 = Conversions.ToDecimal(NewLateBinding.LateIndexGet(current, objArray3, null));
                        object[] objArray4 = new object[] { "HSaleDarVal" };
                        num4 = Conversions.ToDecimal(NewLateBinding.LateIndexGet(current, objArray4, null));
                        decimal num6 = 0M;
                        if (decimal.Compare(num4, decimal.Zero) <= 0)
                        {
                            num6 = 0M;
                        }
                        else if (Conversions.ToDouble(A.PR.PP) == 0.0)
                        {
                            num6 = decimal.Subtract(num2, num3);
                        }
                        else if (Conversions.ToDouble(A.PR.PP) == 1.0)
                        {
                            num6 = decimal.Subtract(decimal.Subtract(num2, num3), num4);
                        }
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNInvSaleItems] SET [Taxabl] = @Taxabl WHERE [HSaleID] = @HSaleID", this.A);
                        command.Parameters.AddWithValue("HSaleID", num);
                        command.Parameters.AddWithValue("Taxabl", num6.ToString(A.PR.VR));
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable table2 = new DataTable();
                string str2 = "SELECT [Taxabl] FROM [TaNNInvSaleItems] WHERE ([InvSaleFrontID] = @InvSaleFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                adapter2.SelectCommand.Parameters.AddWithValue("InvSaleFrontID", QH.A);
                adapter2.Fill(table2);
                this.A.Close();
                decimal left = 0M;
                try
                {
                    enumerator2 = table2.Rows.GetEnumerator();
                    while (true)
                    {
                        if (!enumerator2.MoveNext())
                        {
                            break;
                        }
                        object current = enumerator2.Current;
                        object[] arguments = new object[] { "Taxabl" };
                        left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                    }
                }
                finally
                {
                    if (enumerator2 is IDisposable)
                    {
                        (enumerator2 as IDisposable).Dispose();
                    }
                }
                this.E.Text = Conversions.ToString(left);
            }
            catch (Exception exception4)
            {
                Exception ex = exception4;
                ProjectData.SetProjectError(ex);
                Exception exception2 = ex;
                this.ButtonFinishIn.Enabled = true;
                this.ButtonFinishIn.Text = "   إنهاء البيع وفتح الصندوق | العملاء | اجراءات F2";
                Interaction.MsgBox(exception2.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
                return;
            }
            try
            {
                decimal num7 = 0M;
                decimal num8 = 0M;
                decimal num9 = 0M;
                decimal num10 = 0M;
                decimal num11 = 0M;
                num7 = new decimal(Conversion.Val(this.InvSaleTotalAmount.Text.Replace(",", "")));
                num8 = new decimal(Conversion.Val(this.InvSaleDisFinal.Text.Replace(",", "")));
                num9 = new decimal(Conversion.Val(this.InvSaleDarFinal.Text.Replace(",", "")));
                num10 = new decimal(Conversion.Val(this.InvSaleTotalNET.Text.Replace(",", "")));
                num11 = new decimal(Conversion.Val(this.VR.Text.Replace(",", "")));
                decimal num12 = new decimal(Conversion.Val(this.E.Text.Replace(",", "")));
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("UPDATE [TaNNInvSale] SET [CustomerFrontID] = @CustomerFrontID, [InvSaleDateTime] = @InvSaleDateTime, [InvSaleType] = @InvSaleType, [InvSaleStatus] = @InvSaleStatus, [InvSalePayType] = @InvSalePayType, [InvSaleItems] = @InvSaleItems, [InvSaleTotalAmount] = @InvSaleTotalAmount, [InvSaleDisMaWi] = @InvSaleDisMaWi, [InvSaleDisVal] = @InvSaleDisVal, [InvSaleDarMiWi] = @InvSaleDarMiWi, [InvSaleDarVal] = @InvSaleDarVal, [InvSaleTotalNET] = @InvSaleTotalNET, [InvSaleTotalProft] = @InvSaleTotalProft, [InvSaleNote] = @InvSaleNote, [InvSaleUserAddBy] = @InvSaleUserAddBy, [InvSaleCusOrdarNo] = @InvSaleCusOrdarNo, [InvSaleCafeTyp] = @InvSaleCafeTyp, [InvSaleCafeTablID] = @InvSaleCafeTablID, [InvSaleCafeText] = @InvSaleCafeText, [Taxabl] = @Taxabl, [UUID] = @UUID, [HashQR] = @HashQR, [ReID] = @ReID, [ReHashQR] = @ReHashQR WHERE [InvSaleID] = @InvSaleID", this.A);
                command2.Parameters.AddWithValue("InvSaleID", QH.A);
                command2.Parameters.AddWithValue("CustomerFrontID", this.P);
                command2.Parameters.AddWithValue("InvSaleDateTime", this.InvSaleDateTime.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                command2.Parameters.AddWithValue("InvSaleType", this.InvSaleType.SelectedIndex);
                command2.Parameters.AddWithValue("InvSaleStatus", "1");
                command2.Parameters.AddWithValue("InvSalePayType", this.InvSalePayType.SelectedIndex);
                command2.Parameters.AddWithValue("InvSaleItems", this.InvSaleItems.Text);
                command2.Parameters.AddWithValue("InvSaleTotalAmount", num7.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleDisMaWi", Conversion.Val(this.InvSaleDisMaWi.Text));
                command2.Parameters.AddWithValue("InvSaleDisVal", num8.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleDarMiWi", Conversion.Val(this.InvSaleDarMiWi.Text));
                command2.Parameters.AddWithValue("InvSaleDarVal", num9.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleTotalNET", num10.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleTotalProft", num11.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleNote", this.InvSaleNote.Text);
                command2.Parameters.AddWithValue("InvSaleUserAddBy", A.D.A.A.TxTUserName.Text);
                command2.Parameters.AddWithValue("InvSaleCusOrdarNo", Conversion.Val(this.TxTOrdarNo.Text));
                command2.Parameters.AddWithValue("InvSaleCafeTyp", this.NR.Text);
                command2.Parameters.AddWithValue("InvSaleCafeTablID", "0");
                command2.Parameters.AddWithValue("InvSaleCafeText", this.InvSaleCafeText.Text);
                command2.Parameters.AddWithValue("Taxabl", num12.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("UUID", P.ToString());
                command2.Parameters.AddWithValue("HashQR", "0");
                command2.Parameters.AddWithValue("ReID", Q.ToString());
                command2.Parameters.AddWithValue("ReHashQR", I.ToString());
                command2.ExecuteNonQuery();
                this.A.Close();
                IH.A = QH.A;
                IH.A = QH.A;
                A.D.A.A.ShowDialog();
            }
            catch (Exception exception5)
            {
                Exception ex = exception5;
                ProjectData.SetProjectError(ex);
                Exception exception3 = ex;
                this.ButtonFinishIn.Enabled = true;
                this.ButtonFinishIn.Text = "   إنهاء البيع وفتح الصندوق | العملاء | اجراءات F2";
                Interaction.MsgBox(exception3.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        public void E()
        {
            Application.DoEvents();
            try
            {
                decimal one = 0M;
                decimal num2 = 0M;
                decimal num3 = 0M;
                decimal num4 = 0M;
                decimal num5 = 0M;
                decimal num6 = 0M;
                decimal num7 = 0M;
                decimal num8 = 0M;
                decimal num9 = 0M;
                decimal num10 = 0M;
                decimal num11 = 0M;
                decimal num12 = 0M;
                decimal num13 = 0M;
                decimal num14 = 0M;
                decimal num15 = 0M;
                decimal num16 = 0M;
                if (R != null)
                {
                    this.S.Text = Conversions.ToString(Conversion.Val(R.Replace(",", "")));
                    this.B.Text = Conversions.ToString(Conversion.Val(R.Replace(",", "")));
                }
                one = new decimal(Conversion.Val(this.TxTQuantityName.Text.Replace(",", "")));
                num2 = new decimal(Conversion.Val(this.C.Text.Replace(",", "")));
                num3 = new decimal(Conversion.Val(this.O.Text.Replace(",", "")));
                num4 = new decimal(Conversion.Val(this.S.Text.Replace(",", "")));
                num5 = new decimal(Conversion.Val(this.B.Text.Replace(",", "")));
                if (this.R)
                {
                    one = decimal.One;
                    num2 = 0M;
                    this.S.Text = "0";
                    this.B.Text = "0";
                    this.R.Checked = true;
                    this.M.Text = "بونص مادة مجانية";
                }
                if (this.AR.Text == null)
                {
                    num6 = new decimal(Conversion.Val(this.J.Text.Replace(",", "")));
                }
                else if (DateTime.Compare(Conversions.ToDate(this.AR.Text), DateTime.Now) >= 0)
                {
                    num6 = new decimal(Conversion.Val(this.J.Text.Replace(",", "")));
                }
                else
                {
                    this.J.Text = "0";
                    num6 = Conversions.ToDecimal("0");
                }
                num7 = (Conversion.Val(this.InvSaleDarMiWi.Text) <= 0.0) ? new decimal(Conversion.Val(this.W.Text.Replace(",", ""))) : new decimal(Conversion.Val(this.InvSaleDarMiWi.Text.Replace(",", "")));
                if ((decimal.Compare(num2, decimal.Zero) > 0) & (decimal.Compare(num5, decimal.Zero) > 0))
                {
                    num8 = (decimal.Compare(one, num2) < 0) ? num4 : num5;
                }
                else
                {
                    if (Conversion.Val(this.SR.Text) == 0.0)
                    {
                        num8 = new decimal(Conversion.Val(this.S.Text.Replace(",", "")));
                    }
                    else if (Conversion.Val(this.SR.Text) == 1.0)
                    {
                        num8 = new decimal(Conversion.Val(this.B.Text.Replace(",", "")));
                    }
                    else if (Conversion.Val(this.SR.Text) == 2.0)
                    {
                        num8 = new decimal(Conversion.Val(this.O.Text.Replace(",", "")));
                    }
                    if (decimal.Compare(num8, decimal.Zero) == 0)
                    {
                        num8 = new decimal(Conversion.Val(this.S.Text.Replace(",", "")));
                    }
                }
                num10 = decimal.Multiply(num8, decimal.Divide(num6, new decimal((long) 100)));
                num9 = decimal.Subtract(num8, num10);
                if (Conversions.ToDouble(A.PR.PP) == 0.0)
                {
                    num11 = decimal.Multiply(num9, decimal.Divide(num7, new decimal((long) 100)));
                    num9 = decimal.Add(num9, num11);
                    num3 = decimal.Add(num3, num11);
                }
                else if (Conversions.ToDouble(A.PR.PP) == 1.0)
                {
                    num11 = decimal.Multiply(decimal.Multiply(new decimal((long) 100), decimal.Divide(num9, decimal.Add(new decimal((long) 100), num7))), decimal.Divide(num7, new decimal((long) 100)));
                    num9 = num9;
                }
                num12 = decimal.Multiply(decimal.Subtract(num9, num3), one);
                num13 = decimal.Multiply(num8, one);
                num14 = decimal.Multiply(num10, one);
                num15 = decimal.Multiply(num11, one);
                num16 = decimal.Multiply(num9, one);
                if ((!A.PR.S & (decimal.Compare(num12, decimal.Zero) < 0)) & (this.InvSaleType.SelectedIndex == 0))
                {
                    this.ComboBoxBarCode.Items.Clear();
                    Interaction.MsgBox("سعر التكلفة اكبر من سعر البيع وهذا يسبب الخسارة، وتم منع البيع بالخسارة " + this.TxTBarCode.Text + " " + this.N.Text, MsgBoxStyle.ApplicationModal, null);
                    this.TimerFocus.Enabled = true;
                }
                else if ((A == 0) | (A == 0))
                {
                    Interaction.MsgBox("حدث خطأ غير متوقع في جلب ترميز الفاتورة القيمة فارغة او 0 ", MsgBoxStyle.ApplicationModal, null);
                    this.ComboBoxBarCode.Items.Clear();
                    this.TimerFocus.Enabled = true;
                }
                else
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO [TaNNInvSaleItems] ([CenterFrontID], [InvSaleFrontID], [GroupIDFrontID], [CustomerFrontID], [HInvSaleIDMAX], [HSaleType], [HSaleDateTime], [HSaleBarCode], [HSaleName], [HSaleUnit], [HSalePrice], [HSaleQuantity], [HSalePriceTotal], [HSaleDisMiaWi], [HSaleDisVal], [HSaleDarMiaWi], [HSaleDarVal], [HSaleNETTotal], [HSaleIsDelete], [HSaleNetProft], [HSaleNote], [HSaleUserAddBy]) VALUES (@CenterFrontID, @InvSaleFrontID, @GroupIDFrontID, @CustomerFrontID, @HInvSaleIDMAX, @HSaleType, @HSaleDateTime, @HSaleBarCode, @HSaleName, @HSaleUnit, @HSalePrice, @HSaleQuantity, @HSalePriceTotal, @HSaleDisMiaWi, @HSaleDisVal, @HSaleDarMiaWi, @HSaleDarVal, @HSaleNETTotal, @HSaleIsDelete, @HSaleNetProft, @HSaleNote, @HSaleUserAddBy)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    command.Parameters.AddWithValue("InvSaleFrontID", A);
                    command.Parameters.AddWithValue("GroupIDFrontID", this.U.Text);
                    command.Parameters.AddWithValue("CustomerFrontID", this.P);
                    command.Parameters.AddWithValue("HInvSaleIDMAX", this.InvSaleIDMAX.Text);
                    command.Parameters.AddWithValue("HSaleType", this.InvSaleType.SelectedIndex);
                    command.Parameters.AddWithValue("HSaleDateTime", this.InvSaleDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                    command.Parameters.AddWithValue("HSaleBarCode", this.L.Text);
                    command.Parameters.AddWithValue("HSaleName", this.N.Text);
                    command.Parameters.AddWithValue("HSaleUnit", this.Y.Text);
                    command.Parameters.AddWithValue("HSalePrice", num8.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleQuantity", one.ToString(A.PR.OR));
                    command.Parameters.AddWithValue("HSalePriceTotal", num13.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleDisMiaWi", Conversion.Val(this.J.Text));
                    command.Parameters.AddWithValue("HSaleDisVal", num14.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleDarMiaWi", num7);
                    command.Parameters.AddWithValue("HSaleDarVal", num15.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleNETTotal", num16.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleIsDelete", false);
                    command.Parameters.AddWithValue("HSaleNetProft", num12.ToString(A.PR.VR));
                    if (this.R.Checked)
                    {
                        command.Parameters.AddWithValue("HSaleNote", this.M.Text);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("HSaleNote", "");
                    }
                    command.Parameters.AddWithValue("HSaleUserAddBy", A.D.A.A.TxTUserName.Text);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.U();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void E(object A, EventArgs R)
        {
            A.W.A();
            this.ComboBoxBarCode.Focus();
        }

        private void ER(object A, EventArgs R)
        {
            if (A.PR.VP)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void F()
        {
            Application.DoEvents();
            if ((A == 0) | (A == 0))
            {
                Interaction.MsgBox("InvovieSaleIDToOpen = 0, An error occurred in the process of opening the invoice, the sales screen must be closed and reopened ", MsgBoxStyle.ApplicationModal, null);
                A.AR.T = 0;
                base.Dispose();
            }
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialBarCode] = @MaterialBarCode)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                adapter.SelectCommand.Parameters.AddWithValue("MaterialBarCode", this.TxTBarCode.Text);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    this.H();
                }
                else
                {
                    this.K.Text = dataTable.Rows[0]["MaterialID"].ToString();
                    this.U.Text = dataTable.Rows[0]["GroupIDFrontID"].ToString();
                    this.L.Text = dataTable.Rows[0]["MaterialBarCode"].ToString();
                    this.N.Text = dataTable.Rows[0]["MaterialName"].ToString();
                    this.V.Text = dataTable.Rows[0]["MaterialQuantity"].ToString();
                    this.Y.Text = dataTable.Rows[0]["MaterialUnit"].ToString();
                    this.O.Text = dataTable.Rows[0]["MaterialPricCost"].ToString();
                    this.B.Text = dataTable.Rows[0]["MaterialPricLess"].ToString();
                    this.S.Text = dataTable.Rows[0]["MaterialPricSale"].ToString();
                    this.A.Checked = Conversions.ToBoolean(dataTable.Rows[0]["MaterialIsStop"].ToString());
                    this.Z.Text = dataTable.Rows[0]["MaterialExpDate"].ToString();
                    this.M.Text = dataTable.Rows[0]["MaterialNote"].ToString();
                    this.R.Checked = Conversions.ToBoolean(dataTable.Rows[0]["MaterialNotIsView"].ToString());
                    this.C.Text = dataTable.Rows[0]["MaterialQuantityOffer"].ToString();
                    this.J.Text = dataTable.Rows[0]["MaterialDisMiWi"].ToString();
                    this.W.Text = dataTable.Rows[0]["MaterialDarMiWi"].ToString();
                    this.AR.Text = dataTable.Rows[0]["MaterialDisExpDat"].ToString();
                    this.G();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void F(object A, EventArgs R)
        {
            decimal num = new decimal(Conversion.Val(this.TxTQuantityName.Text.Replace(",", "")));
            num = decimal.Subtract(num, decimal.One);
            this.TxTQuantityName.Text = Conversions.ToString(num);
        }

        private void F(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void FP(object A, EventArgs R)
        {
        }

        private void FR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        public void G()
        {
            Application.DoEvents();
            try
            {
                if (((this.InvSaleType.SelectedIndex == 0) && !A.PR.B) && (Conversion.Val(this.TxTQuantityName.Text.Replace(",", "")) > Conversion.Val(this.V.Text.Replace(",", ""))))
                {
                    this.P();
                    Interaction.MsgBox("الكمية المطلوب بيعها اكبر من الكمية الحالية في المستودع " + this.TxTBarCode.Text + " " + this.N.Text, MsgBoxStyle.ApplicationModal, null);
                    if (Interaction.MsgBox("هل تريد فتح نافذة استعراض الوحدات لتحديد مواد مرتبطة معها (كرتونه، رزمة..الخ) لفتحها وترحيل كميتها لهذه المادة", MsgBoxStyle.OkCancel, "") == MsgBoxResult.Cancel)
                    {
                        this.ComboBoxBarCode.Items.Clear();
                        this.TimerFocus.Enabled = true;
                    }
                    else
                    {
                        this.ComboBoxBarCode.Items.Clear();
                        XH.A = this.TxTBarCode.Text;
                        A.D.A.A.ShowDialog();
                        this.TimerFocus.Enabled = true;
                    }
                }
                else if (!this.A.Checked)
                {
                    if (this.Z.Text != null)
                    {
                        DateTime time = Conversions.ToDate(this.Z.Text);
                        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(DateTime.Now.ToString("yyyy/MM/dd"), time.ToString("yyyy/MM/dd"), false) >= 0)
                        {
                            this.R();
                            this.ComboBoxBarCode.Items.Clear();
                            Interaction.MsgBox("تاريخ هذه المادة منتهي الصلاحية " + this.TxTBarCode.Text + " " + this.N.Text, MsgBoxStyle.ApplicationModal, null);
                            this.TimerFocus.Enabled = true;
                            return;
                        }
                    }
                    if (A.AR.X | this.R)
                    {
                        this.E();
                    }
                    else
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        DataTable dataTable = new DataTable();
                        string selectCommandText = "SELECT TOP(1) * FROM [TaNNInvSaleItems] WHERE (([InvSaleFrontID] = @InvSaleFrontID) And ([HSaleBarCode] = @HSaleBarCode))";
                        dataTable.Clear();
                        SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                        adapter.SelectCommand.Parameters.AddWithValue("InvSaleFrontID", A);
                        adapter.SelectCommand.Parameters.AddWithValue("HSaleBarCode", this.TxTBarCode.Text);
                        adapter.Fill(dataTable);
                        this.A.Close();
                        if (dataTable.Rows.Count <= 0)
                        {
                            this.E();
                        }
                        else
                        {
                            this.PR.Text = dataTable.Rows[0]["HSaleID"].ToString();
                            this.DR.Text = dataTable.Rows[0]["HSalePrice"].ToString();
                            this.FR.Text = dataTable.Rows[0]["HSaleQuantity"].ToString();
                            this.HR.Text = dataTable.Rows[0]["HSalePriceTotal"].ToString();
                            this.TR.Text = dataTable.Rows[0]["HSaleDisMiaWi"].ToString();
                            this.XR.Text = dataTable.Rows[0]["HSaleDisVal"].ToString();
                            this.GR.Text = dataTable.Rows[0]["HSaleDarMiaWi"].ToString();
                            this.ER.Text = dataTable.Rows[0]["HSaleDarVal"].ToString();
                            this.KR.Text = dataTable.Rows[0]["HSaleNetProft"].ToString();
                            this.P.Checked = Conversions.ToBoolean(dataTable.Rows[0]["HSaleIsDelete"].ToString());
                            this.UR.Text = dataTable.Rows[0]["HSaleNETTotal"].ToString();
                            if (I)
                            {
                                this.E();
                            }
                            else
                            {
                                this.K();
                            }
                        }
                    }
                }
                else
                {
                    this.P();
                    this.ComboBoxBarCode.Items.Clear();
                    Interaction.MsgBox("لقد تم وقف بيع هذه المادة " + this.TxTBarCode.Text + " " + this.N.Text, MsgBoxStyle.ApplicationModal, null);
                    this.TimerFocus.Enabled = true;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void G(object A, EventArgs R)
        {
            Application.DoEvents();
            if (this.GV.RowCount != 0)
            {
                if (!A.PR.S & (Conversion.Val(this.VR.Text.Replace(",", "")) < 0.0))
                {
                    this.ComboBoxBarCode.Items.Clear();
                    Interaction.MsgBox("قيمة الخصم يسبب خسارة في ربح الفاتورة، وتم منع البيع بالخسارة", MsgBoxStyle.ApplicationModal, null);
                }
                else if (Conversion.Val(this.InvSaleDarFinal.Text.Replace(",", "")) < 0.0)
                {
                    this.ComboBoxBarCode.Items.Clear();
                    Interaction.MsgBox("هناك خطأ في حساب معامل الضريبة سالبة يجب عليك ازالة الخصم على اجمالي الفاتورة", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    this.ButtonFinishSave.Enabled = false;
                    this.ButtonFinishSave.Text = "انتظر ... ";
                    this.TimerGotoSave.Enabled = true;
                }
            }
        }

        private void GR(object A, EventArgs R)
        {
            Application.DoEvents();
            if (!A.PR.PQ)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else if (this.GV.RowCount > 0)
            {
                Interaction.MsgBox("يجب ان تكون الفاتورة خالية من المواد المباعة لتنفيذ امر إعادة الترقيم", MsgBoxStyle.ApplicationModal, null);
            }
            else if (Interaction.MsgBox("سيتم إعادة ضبط تسلسل الفواتير حسب الرقم الذي حددته، لن يؤثر ذلك على أي عمليات حسابية او خلل في الكشوفات وإنما إعادة تسلسل للفواتير مع الإحتفاظ بالفواتير السابقة هل تريد الاستمرار", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                if (Conversion.Val(this.InvSaleIDMAX.Text) < 0.0)
                {
                    Interaction.MsgBox("يجب ان يبدأ التسلسل من 1", MsgBoxStyle.ApplicationModal, null);
                    this.InvSaleIDMAX.Text = "1";
                }
                else
                {
                    try
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNInvSale] SET [InvSaleIDMAX] =@InvSaleIDMAX WHERE [InvSaleID] = @InvSaleID", this.A);
                        command.Parameters.AddWithValue("@InvSaleID", QH.A);
                        command.Parameters.AddWithValue("@InvSaleIDMAX", this.InvSaleIDMAX.Text);
                        command.ExecuteNonQuery();
                        this.A.Close();
                        Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    }
                    catch (Exception exception1)
                    {
                        Exception ex = exception1;
                        ProjectData.SetProjectError(ex);
                        Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                        base.Dispose();
                        ProjectData.ClearProjectError();
                    }
                }
            }
        }

        public void H()
        {
            Application.DoEvents();
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialMultBarCode] Like '%*' + @MaterialMultBarCode + '*%')";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                adapter.SelectCommand.Parameters.AddWithValue("MaterialMultBarCode", this.TxTBarCode.Text);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    if (A.PR.Y)
                    {
                        this.X();
                    }
                    else
                    {
                        this.ComboBoxBarCode.Items.Clear();
                        this.T();
                        Interaction.MsgBox("لم يتم العثور على المادة في المستودع " + this.TxTBarCode.Text, MsgBoxStyle.ApplicationModal, null);
                        this.TimerFocus.Enabled = true;
                    }
                }
                else
                {
                    this.K.Text = dataTable.Rows[0]["MaterialID"].ToString();
                    this.U.Text = dataTable.Rows[0]["GroupIDFrontID"].ToString();
                    this.L.Text = dataTable.Rows[0]["MaterialBarCode"].ToString();
                    this.N.Text = dataTable.Rows[0]["MaterialName"].ToString();
                    this.V.Text = dataTable.Rows[0]["MaterialQuantity"].ToString();
                    this.Y.Text = dataTable.Rows[0]["MaterialUnit"].ToString();
                    this.O.Text = dataTable.Rows[0]["MaterialPricCost"].ToString();
                    this.B.Text = dataTable.Rows[0]["MaterialPricLess"].ToString();
                    this.S.Text = dataTable.Rows[0]["MaterialPricSale"].ToString();
                    this.A.Checked = Conversions.ToBoolean(dataTable.Rows[0]["MaterialIsStop"].ToString());
                    this.Z.Text = dataTable.Rows[0]["MaterialExpDate"].ToString();
                    this.M.Text = dataTable.Rows[0]["MaterialNote"].ToString();
                    this.R.Checked = Conversions.ToBoolean(dataTable.Rows[0]["MaterialNotIsView"].ToString());
                    this.C.Text = dataTable.Rows[0]["MaterialQuantityOffer"].ToString();
                    this.J.Text = dataTable.Rows[0]["MaterialDisMiWi"].ToString();
                    this.W.Text = dataTable.Rows[0]["MaterialDarMiWi"].ToString();
                    this.AR.Text = dataTable.Rows[0]["MaterialDisExpDat"].ToString();
                    this.TxTBarCode.Text = this.L.Text;
                    this.G();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void H(object A, EventArgs R)
        {
            if (this.TxTSerch.Text == null)
            {
                this.TxTSerch.Focus();
            }
            else
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataSet dataSet = new DataSet();
                    string selectCommandText = "";
                    if (this.RadioButtonCode.Checked)
                    {
                        selectCommandText = "Select MaterialBarCode, MaterialName, MaterialUnit FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID) And ([MaterialBarCode] Like '%' + @MaterialBarCode + '%')";
                    }
                    if (this.RadioButtonName.Checked)
                    {
                        selectCommandText = "Select MaterialBarCode, MaterialName, MaterialUnit FROM [TaNNMaterial] WHERE (([CenterFrontID] = @CenterFrontID) And ([MaterialName] Like '%' + @MaterialName + '%'))";
                    }
                    if (this.RadioButtonNote.Checked)
                    {
                        selectCommandText = "SELECT MaterialBarCode, MaterialName, MaterialUnit FROM [TaNNMaterial] WHERE (([CenterFrontID] = @CenterFrontID) AND ([MaterialNote] LIKE '%' + @MaterialNote + '%'))";
                    }
                    dataSet.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    string text = this.TxTSerch.Text;
                    adapter.SelectCommand.Parameters.AddWithValue("MaterialBarCode", text ?? DBNull.Value);
                    string text2 = this.TxTSerch.Text;
                    adapter.SelectCommand.Parameters.AddWithValue("MaterialName", text2 ?? DBNull.Value);
                    string text3 = this.TxTSerch.Text;
                    adapter.SelectCommand.Parameters.AddWithValue("MaterialNote", text3 ?? DBNull.Value);
                    adapter.Fill(dataSet, "TaNNMaterial");
                    this.A.Close();
                    this.GVMMAdva.DataSource = dataSet;
                    this.GVMMAdva.DataMember = "TaNNMaterial";
                    this.GVMMAdva.Refresh();
                    this.GVMMAdva.Columns[0].Visible = false;
                    this.GVMMAdva.Columns[1].HeaderText = "المادة";
                    this.GVMMAdva.Columns[2].HeaderText = "الوحدة";
                    this.GVMMAdva.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    this.ComboBoxBarCode.Items.Clear();
                    Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.TimerFocus.Enabled = true;
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void HP(object A, EventArgs R)
        {
        }

        private void HR(object A, EventArgs R)
        {
            this.Z();
            if (this.GV.Rows.Count == 0)
            {
                Interaction.MsgBox("لا يمكن ارسال امر طباعة طلبية فارغ", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                if (A.AR.AR)
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO TaNNCloudPrint (CenterFrontID, InvID, TypID) VALUES (@CenterFrontID, @InvID, @TypID)", this.A);
                    command.Parameters.AddWithValue("@CenterFrontID", A.PR.GR);
                    command.Parameters.AddWithValue("@InvID", QH.A);
                    command.Parameters.AddWithValue("@TypID", "2");
                    command.ExecuteNonQuery();
                    this.A.Close();
                }
                else if (A.AR.W)
                {
                    A.D.A.A.TxTInvoicID.Text = Conversions.ToString(QH.A);
                    A.D.A.A.R();
                }
                else
                {
                    LF.A = QH.A;
                    A.D.A.A.P();
                }
                Interaction.MsgBox("تم ارسال امر طباعة الطلب للطابعة", MsgBoxStyle.ApplicationModal, null);
            }
        }

        public void I()
        {
            Application.DoEvents();
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNInvSale] WHERE ([InvSaleID] = @InvSaleID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleID", A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    Interaction.MsgBox("رمز الفاتورة = 0،  حدث خطأ في عملية فتح الفاتورة، يجب اغلاق شاشة البيع وإعادة فتحها", MsgBoxStyle.ApplicationModal, null);
                    A.AR.T = 0;
                    base.Dispose();
                }
                else
                {
                    this.ComboBoxCustomer.SelectedValue = dataTable.Rows[0]["CustomerFrontID"].ToString();
                    this.InvSaleIDMAX.Text = dataTable.Rows[0]["InvSaleIDMAX"].ToString();
                    this.InvSaleDateTime.Value = Conversions.ToDate(dataTable.Rows[0]["InvSaleDateTime"].ToString());
                    this.InvSaleType.SelectedIndex = Conversions.ToInteger(dataTable.Rows[0]["InvSaleType"].ToString());
                    this.ZR.Text = dataTable.Rows[0]["InvSaleStatus"].ToString();
                    this.InvSalePayType.SelectedIndex = Conversions.ToInteger(dataTable.Rows[0]["InvSalePayType"].ToString());
                    this.InvSaleDisMaWi.Text = dataTable.Rows[0]["InvSaleDisMaWi"].ToString();
                    this.InvSaleDisMaWiVAL.Text = dataTable.Rows[0]["InvSaleDisVal"].ToString();
                    this.InvSaleDarMiWi.Text = dataTable.Rows[0]["InvSaleDarMiWi"].ToString();
                    this.InvSaleDarFinal.Text = dataTable.Rows[0]["InvSaleDarVal"].ToString();
                    this.InvSaleTotalNET.Text = dataTable.Rows[0]["InvSaleTotalNET"].ToString();
                    this.InvSaleNote.Text = dataTable.Rows[0]["InvSaleNote"].ToString();
                    this.NR.Text = dataTable.Rows[0]["InvSaleCafeTyp"].ToString();
                    LR.Text = dataTable.Rows[0]["InvSaleCafeTablID"].ToString();
                    this.InvSaleCafeText.Text = dataTable.Rows[0]["InvSaleCafeText"].ToString();
                    this.TxTOrdarNo.Text = dataTable.Rows[0]["InvSaleCusOrdarNo"].ToString();
                    if (((A.PR.PP == null) | (A.PR.VR == null)) | (A.PR.OR == null))
                    {
                        Interaction.MsgBox("ملف ClassSahre. لا يحتوي على قيم ، يجب عليك اعادة تشغيل النظام", MsgBoxStyle.ApplicationModal, null);
                        A.AR.T = 0;
                        base.Dispose();
                    }
                    else if ((this.ZR.Text == "0") | (this.ZR.Text == "3"))
                    {
                        Interaction.MsgBox("خطأ في حالة الفاتورة لأنها مكتملة لا يمكن إعادة فتحها من نفس شاشة البيع", MsgBoxStyle.ApplicationModal, null);
                        A.AR.T = 0;
                        base.Dispose();
                    }
                    else
                    {
                        if (!A)
                        {
                            DateTime time = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                            DateTime time2 = Conversions.ToDate(this.InvSaleDateTime.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                            if (time.ToString("yyyy/MM/dd") == time2.ToString("yyyy/MM/dd"))
                            {
                                this.InvSaleDateTime.Value = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                            }
                            else if (Interaction.MsgBox("تاريخ شاشة البيع لا يتطابق مع تاريخ الكمبيوتر ربما تم بداية يوم جديد هل تريد تحديث تاريخ شاشة البيع؟", MsgBoxStyle.OkCancel, "") == MsgBoxResult.Ok)
                            {
                                this.InvSaleDateTime.Value = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                            }
                        }
                        this.P = Conversions.ToInteger(this.ComboBoxCustomer.SelectedValue);
                        if (this.P > 0)
                        {
                            this.S();
                        }
                        else
                        {
                            this.L();
                        }
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void I(object A, EventArgs R)
        {
            Application.DoEvents();
            if (!A.PR.IQ)
            {
                this.P();
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else if (Interaction.MsgBox("هل تريد تعليق هذه الفاتورة؟ وفتح فاتورة جديدة !", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                if (this.GV.RowCount == 0)
                {
                    this.P();
                    Interaction.MsgBox("هذه الفاتورة فارغة لا يمكن تعليقها", MsgBoxStyle.ApplicationModal, null);
                }
                else if (this.InvSaleType.SelectedIndex == 1)
                {
                    this.P();
                    Interaction.MsgBox("لا يجوز تعليق فاتورة مرتجع مبيعات", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    A.AR.T = QH.A;
                    this.Z();
                    this.Q();
                }
            }
        }

        private void I(object A, DataGridViewCellEventArgs R)
        {
        }

        private void I(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void IP(object A, EventArgs R)
        {
            if ((Conversion.Val(this.InvSaleDisMaWi.Text) == 0.0) & (Conversion.Val(this.InvSaleDisMaWiVAL.Text) == 0.0))
            {
                Interaction.MsgBox("لا يوجد نسبة خصم او مبلغ حصم", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                TH.A = QH.A;
                A.D.A.A.TxTDisMiWi.Text = this.InvSaleDisMaWi.Text;
                A.D.A.A.TxTDisVal.Text = this.InvSaleDisMaWiVAL.Text;
                this.P = true;
                this.YR.Text = "0";
                this.InvSaleDisMaWi.Text = "0";
                this.InvSaleDisMaWiVAL.Text = "0";
                D = "خصم على اجمالي الفاتورة";
                A.D.A.A.ShowDialog();
            }
        }

        private void IR(object A, EventArgs R)
        {
            if (!Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.ComboBoxCustomer.SelectedValue, null, false), this.ComboBoxCustomer.Text == null)))
            {
                this.P = Conversions.ToInteger(this.ComboBoxCustomer.SelectedValue);
                this.S();
            }
            else
            {
                this.ComboBoxCustomer.SelectedValue = -1;
                this.InvSaleDisMaWi.Text = "0";
                this.InvSaleDisMaWiVAL.Text = "0";
                this.P = 0;
                D = "خصم على اجمالي الفاتورة";
                this.L();
            }
        }

        private void J(object A, EventArgs R)
        {
            if (this.InvSaleType.SelectedIndex == 0)
            {
                this.TxTQuantityName.Text = "1";
                this.InvSaleTotalNET.ForeColor = Color.Blue;
                this.TxTBarCode.ForeColor = Color.Black;
                this.TxTQuantityName.ForeColor = Color.Black;
                this.ButtonSaleCode.Text = "بيع";
                this.ButtonSaleCode.ForeColor = Color.Black;
                this.ButtonSaleCode.FlatAppearance.BorderColor = Color.Green;
                this.GroupBoxTxTBarCode.Text = "رقم/ باركود المادة";
                this.GroupBoxTxTBarCode.ForeColor = Color.Black;
                if (Conversions.ToDouble(A.PR.MR) > 0.0)
                {
                    this.InvSaleDisMaWi.Text = A.PR.MR;
                }
            }
            else if (!A.PR.YP)
            {
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox("غير مسموح لك بأضافة مرتجع مبيعات من مدير المتجر", MsgBoxStyle.ApplicationModal, null);
                this.InvSaleType.SelectedIndex = 0;
            }
            else
            {
                this.TxTQuantityName.Text = "1";
                this.InvSaleTotalNET.ForeColor = Color.Red;
                this.TxTBarCode.ForeColor = Color.Red;
                this.TxTQuantityName.ForeColor = Color.Red;
                this.ButtonSaleCode.Text = "ارجاع";
                this.ButtonSaleCode.ForeColor = Color.Red;
                this.ButtonSaleCode.FlatAppearance.BorderColor = Color.Red;
                this.GroupBoxTxTBarCode.Text = "انقر هنا للاستعانة في سجل البيع السابق";
                this.GroupBoxTxTBarCode.ForeColor = Color.Red;
                this.InvSaleDisMaWi.Text = "0";
                this.InvSaleDisMaWiVAL.Text = "0";
            }
        }

        private void JR(object A, EventArgs R)
        {
            if (A.PR.LP)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void K()
        {
            Application.DoEvents();
            try
            {
                decimal num = 0M;
                decimal num2 = 0M;
                decimal num3 = 0M;
                decimal num4 = 0M;
                decimal num5 = 0M;
                decimal num6 = 0M;
                decimal num7 = 0M;
                decimal num8 = 0M;
                decimal num9 = 0M;
                decimal num10 = 0M;
                decimal num11 = 0M;
                decimal num12 = 0M;
                decimal num13 = 0M;
                decimal num14 = 0M;
                decimal num15 = 0M;
                decimal num16 = 0M;
                num = new decimal(Conversion.Val(this.TxTQuantityName.Text.Replace(",", "")) + Conversion.Val(this.FR.Text.Replace(",", "")));
                num2 = new decimal(Conversion.Val(this.C.Text.Replace(",", "")));
                num3 = new decimal(Conversion.Val(this.O.Text.Replace(",", "")));
                num4 = new decimal(Conversion.Val(this.DR.Text.Replace(",", "")));
                num5 = new decimal(Conversion.Val(this.B.Text.Replace(",", "")));
                num6 = new decimal(Conversion.Val(this.TR.Text.Replace(",", "")));
                num7 = new decimal(Conversion.Val(this.GR.Text.Replace(",", "")));
                if ((decimal.Compare(num2, decimal.Zero) > 0) & (decimal.Compare(num5, decimal.Zero) > 0))
                {
                    num8 = (decimal.Compare(num, num2) < 0) ? num4 : num5;
                }
                else
                {
                    num8 = num4;
                }
                num10 = decimal.Multiply(num8, decimal.Divide(num6, new decimal((long) 100)));
                num9 = decimal.Subtract(num8, num10);
                if (Conversions.ToDouble(A.PR.PP) == 0.0)
                {
                    num11 = decimal.Multiply(num9, decimal.Divide(num7, new decimal((long) 100)));
                    num9 = decimal.Add(num9, num11);
                    num3 = decimal.Add(num3, num11);
                }
                else if (Conversions.ToDouble(A.PR.PP) == 1.0)
                {
                    num11 = decimal.Multiply(decimal.Multiply(new decimal((long) 100), decimal.Divide(num9, decimal.Add(new decimal((long) 100), num7))), decimal.Divide(num7, new decimal((long) 100)));
                    num9 = num9;
                }
                num12 = decimal.Multiply(decimal.Subtract(num9, num3), num);
                num13 = decimal.Multiply(num8, num);
                num14 = decimal.Multiply(num10, num);
                num15 = decimal.Multiply(num11, num);
                num16 = decimal.Multiply(num9, num);
                if ((!A.PR.S & (decimal.Compare(num12, decimal.Zero) < 0)) & (this.InvSaleType.SelectedIndex == 0))
                {
                    this.ComboBoxBarCode.Items.Clear();
                    Interaction.MsgBox("سعر التكلفة اكبر من سعر البيع وهذا يسبب الخسارة، وتم منع البيع بالخسارة " + this.TxTBarCode.Text + " " + this.N.Text, MsgBoxStyle.ApplicationModal, null);
                    this.TimerFocus.Enabled = true;
                }
                else
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE [TaNNInvSaleItems] SET [GroupIDFrontID] = @GroupIDFrontID, [CustomerFrontID] = @CustomerFrontID, [HSaleType] = @HSaleType, [HSaleDateTime] = @HSaleDateTime, [HSalePrice] = @HSalePrice, [HSaleQuantity] = @HSaleQuantity, [HSalePriceTotal] = @HSalePriceTotal, [HSaleDisMiaWi] = @HSaleDisMiaWi, [HSaleDisVal] = @HSaleDisVal, [HSaleDarMiaWi] = @HSaleDarMiaWi, [HSaleDarVal] = @HSaleDarVal, [HSaleNETTotal] = @HSaleNETTotal, [HSaleIsDelete] = @HSaleIsDelete, [HSaleNetProft] = @HSaleNetProft, [HSaleNote] = @HSaleNote, [HSaleUserAddBy] = @HSaleUserAddBy WHERE [HSaleID] = @HSaleID", this.A);
                    command.Parameters.AddWithValue("HSaleID", this.PR.Text);
                    command.Parameters.AddWithValue("GroupIDFrontID", this.U.Text);
                    command.Parameters.AddWithValue("CustomerFrontID", this.P);
                    command.Parameters.AddWithValue("HSaleType", this.InvSaleType.SelectedIndex);
                    command.Parameters.AddWithValue("HSaleDateTime", this.InvSaleDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                    command.Parameters.AddWithValue("HSalePrice", num8.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleQuantity", num.ToString(A.PR.OR));
                    command.Parameters.AddWithValue("HSalePriceTotal", num13.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleDisMiaWi", Conversion.Val(this.TR.Text));
                    command.Parameters.AddWithValue("HSaleDisVal", num14.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleDarMiaWi", Conversion.Val(this.GR.Text));
                    command.Parameters.AddWithValue("HSaleDarVal", num15.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleNETTotal", num16.ToString(A.PR.VR));
                    command.Parameters.AddWithValue("HSaleIsDelete", false);
                    command.Parameters.AddWithValue("HSaleNetProft", num12.ToString(A.PR.VR));
                    if (this.R.Checked)
                    {
                        command.Parameters.AddWithValue("HSaleNote", this.M.Text);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("HSaleNote", "");
                    }
                    command.Parameters.AddWithValue("HSaleUserAddBy", A.D.A.A.TxTUserName.Text);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.U();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void K(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void KR(object A, EventArgs R)
        {
            if (Conversion.Val(this.TxTOrdarNo.Text) < 0.0)
            {
                Interaction.MsgBox("يجب ان يبدأ التسلسل من 1", MsgBoxStyle.ApplicationModal, null);
                this.TxTOrdarNo.Text = "1";
            }
            else
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE [TaNNInvSale] SET [InvSaleCusOrdarNo] =@InvSaleCusOrdarNo WHERE [InvSaleID] = @InvSaleID", this.A);
                    command.Parameters.AddWithValue("@InvSaleID", QH.A);
                    command.Parameters.AddWithValue("@InvSaleCusOrdarNo", this.TxTOrdarNo.Text);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
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

        public void L()
        {
            // Invalid method body.
        }

        private void L(object A, EventArgs R)
        {
            this.Y();
            this.O();
        }

        private void LR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void M(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(A.PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                RH.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["HSaleID"].Value.ToString());
                RH.R = 0;
                A.D.A.A.ShowDialog();
            }
        }

        private void MR(object A, EventArgs R)
        {
            if (!A.PR.EP)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                FT.A = true;
                A.D.A.A.ShowDialog();
            }
        }

        public void N()
        {
            decimal num = new decimal(Conversion.Val(this.InvSaleTotalNET.Text.Replace(",", "")));
            this.InvSaleType.SelectedIndex = (decimal.Compare(num, decimal.Zero) < 0) ? 1 : 0;
        }

        private void N(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void NR(object A, EventArgs R)
        {
            QH.A = 0;
        }

        public void O()
        {
            // Invalid method body.
        }

        private void O(object A, EventArgs R)
        {
            this.NR.Text = "3";
            A.D.A.A.ShowDialog();
        }

        private void OR(object A, EventArgs R)
        {
            TH.A = QH.A;
            A.D.A.A.ShowDialog();
        }

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void P(object A, DataGridViewCellEventArgs R)
        {
        }

        private void P(object A, DataGridViewDataErrorEventArgs R)
        {
            // Invalid method body.
        }

        private void P(object A, KeyEventArgs R)
        {
            // Invalid method body.
        }

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void P(object A, MouseEventArgs R)
        {
            // Invalid method body.
        }

        private void PP(object A, EventArgs R)
        {
            if (Conversion.Val(this.InvSaleDisMaWi.Text) > 0.0)
            {
                this.InvSaleDisMaWiVAL.Text = "";
            }
            this.L();
        }

        private void PR(object A, EventArgs R)
        {
            Application.DoEvents();
            if (!A.PR.IQ)
            {
                this.P();
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                this.Z();
                A.D.A.A.ShowDialog();
            }
        }

        public void Q()
        {
            Application.DoEvents();
            this.P = false;
            try
            {
                A = 0;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) [InvSaleIDMAX], [InvSaleCusOrdarNo] FROM [TaNNInvSale] WHERE ([CenterFrontID] = @CenterFrontID) ORDER BY [InvSaleID] DESC";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                int num = 0;
                int num2 = 0;
                if (dataTable.Rows.Count > 0)
                {
                    num = (int) Math.Round((double) (Conversion.Val(Conversions.ToInteger(dataTable.Rows[0]["InvSaleIDMAX"].ToString())) + 1.0));
                    num2 = (int) Math.Round((double) (Conversion.Val(Conversions.ToInteger(dataTable.Rows[0]["InvSaleCusOrdarNo"].ToString())) + 1.0));
                }
                else
                {
                    num = 1;
                    num2 = 1;
                }
                this.InvSaleIDMAX.Text = Conversions.ToString(num);
                this.TxTOrdarNo.Text = Conversions.ToString(num2);
                DateTime time = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                DateTime time2 = Conversions.ToDate(this.InvSaleDateTime.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                if (time.ToString("yyyy/MM/dd") == time2.ToString("yyyy/MM/dd"))
                {
                    this.InvSaleDateTime.Value = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                }
                else if (Interaction.MsgBox("تاريخ شاشة البيع لا يتطابق مع تاريخ الكمبيوتر ربما تم بداية يوم جديد هل تريد تحديث تاريخ شاشة البيع؟", MsgBoxStyle.OkCancel, "") == MsgBoxResult.Ok)
                {
                    this.InvSaleDateTime.Value = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                }
                if (A.PR.A == num)
                {
                    Interaction.MsgBox("Error, System Need Create New Invoice Same MAX ID, Restart System", MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("INSERT INTO [TaNNInvSale] ([CenterFrontID], [CustomerFrontID], [InvSaleIDMAX], [InvSaleDateTime], [InvSaleType], [InvSaleStatus], [InvSalePayType], [InvSaleItems], [InvSaleTotalAmount], [InvSaleDisMaWi], [InvSaleDisVal], [InvSaleDarMiWi], [InvSaleDarVal], [InvSaleTotalNET], [InvSaleTotalProft], [InvSaleMonBas], [InvSaleMonPay], [InvSaleMonBak], [InvSaleMonDem], [InvSaleMonRod], [InvSaleIsMonRod], [InvSaleNote], [InvSaleUserAddBy], [InvSaleOtherCuru], [InvSaleCafeTyp], [InvSaleCafeTablID], [InvSaleCafeText], [InvSaleCusOrdarNo]) VALUES (@CenterFrontID, @CustomerFrontID, @InvSaleIDMAX, @InvSaleDateTime, @InvSaleType, @InvSaleStatus, @InvSalePayType, @InvSaleItems, @InvSaleTotalAmount, @InvSaleDisMaWi, @InvSaleDisVal, @InvSaleDarMiWi, @InvSaleDarVal, @InvSaleTotalNET, @InvSaleTotalProft, @InvSaleMonBas, @InvSaleMonPay, @InvSaleMonBak, @InvSaleMonDem, @InvSaleMonRod, @InvSaleIsMonRod, @InvSaleNote, @InvSaleUserAddBy, @InvSaleOtherCuru, @InvSaleCafeTyp, @InvSaleCafeTablID, @InvSaleCafeText, @InvSaleCusOrdarNo); SELECT InvSaleID FROM TaNNInvSale WHERE (InvSaleID = SCOPE_IDENTITY())", this.A);
                command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                command.Parameters.AddWithValue("CustomerFrontID", "0");
                command.Parameters.AddWithValue("InvSaleIDMAX", num);
                command.Parameters.AddWithValue("InvSaleDateTime", this.InvSaleDateTime.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                command.Parameters.AddWithValue("InvSaleType", "0");
                command.Parameters.AddWithValue("InvSaleStatus", "1");
                command.Parameters.AddWithValue("InvSalePayType", "0");
                command.Parameters.AddWithValue("InvSaleItems", "0");
                command.Parameters.AddWithValue("InvSaleTotalAmount", "0");
                command.Parameters.AddWithValue("InvSaleDisMaWi", A.PR.MR);
                command.Parameters.AddWithValue("InvSaleDisVal", "0");
                command.Parameters.AddWithValue("InvSaleDarMiWi", A.PR.AP);
                command.Parameters.AddWithValue("InvSaleDarVal", "0");
                command.Parameters.AddWithValue("InvSaleTotalNET", "0");
                command.Parameters.AddWithValue("InvSaleTotalProft", "0");
                command.Parameters.AddWithValue("InvSaleMonBas", "0");
                command.Parameters.AddWithValue("InvSaleMonPay", "0");
                command.Parameters.AddWithValue("InvSaleMonBak", "0");
                command.Parameters.AddWithValue("InvSaleMonDem", "0");
                command.Parameters.AddWithValue("InvSaleMonRod", "0");
                command.Parameters.AddWithValue("InvSaleIsMonRod", false);
                command.Parameters.AddWithValue("InvSaleNote", "");
                command.Parameters.AddWithValue("InvSaleUserAddBy", A.D.A.A.TxTUserName.Text);
                command.Parameters.AddWithValue("InvSaleOtherCuru", "");
                command.Parameters.AddWithValue("InvSaleCafeTyp", "0");
                command.Parameters.AddWithValue("InvSaleCafeTablID", "0");
                command.Parameters.AddWithValue("InvSaleCafeText", "سفري");
                command.Parameters.AddWithValue("InvSaleCusOrdarNo", num2);
                A = Conversions.ToInteger(command.ExecuteScalar());
                this.A.Close();
                this.SR.Text = "0";
                if (A.PR.O)
                {
                    this.NR.Text = "0";
                    this.InvSaleCafeText.Text = "سفري";
                }
                A = false;
                if (A >= 0xf4240)
                {
                    this.I();
                }
                else
                {
                    Interaction.MsgBox("Error: the Invoice InvovieSaleIDToOpen Less Then Orginal", MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void Q(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void Q(object A, DataGridViewCellEventArgs R)
        {
        }

        private void Q(object A, DataGridViewDataErrorEventArgs R)
        {
            // Invalid method body.
        }

        private void Q(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void Q(object A, MouseEventArgs R)
        {
            // Invalid method body.
        }

        private void QP(object A, EventArgs R)
        {
            this.P = true;
            this.YR.Text = "0";
            this.InvSaleDisMaWi.Text = "0";
            this.InvSaleDisMaWiVAL.Text = "0";
            D = "خصم على اجمالي الفاتورة";
            this.L();
        }

        private void QR(object A, EventArgs R)
        {
            this.TimerNewOrOpenInvoice.Enabled = false;
            P = "0";
            Q = "0";
            I = "0";
            this.E.Text = "0";
            if (QH.A)
            {
                this.InvSaleType.Enabled = false;
                this.I();
            }
            else if (A.AR.T > 0)
            {
                QH.A = A.AR.T;
                this.I();
            }
            else
            {
                this.InvSaleTotalAmount.Text = "";
                this.InvSaleTotalAmount.Text = "";
                this.VR.Text = "";
                this.InvSaleDisFinal.Text = "";
                this.InvSaleDarFinal.Text = "";
                this.Q();
            }
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void R(object A, DataGridViewCellEventArgs R)
        {
            if (this.GV.RowCount == 0)
            {
                Interaction.MsgBox("لا يوجد مبيعات", MsgBoxStyle.ApplicationModal, null);
                this.TxTBarCode.Text = "";
                this.TxTBarCode.Focus();
            }
            else
            {
                if (R.ColumnIndex == 0)
                {
                    AH.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["HSaleID"].Value.ToString());
                    A.D.A.A.ShowDialog();
                }
                if (R.ColumnIndex == 11)
                {
                    WF.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["HSaleID"].Value.ToString());
                    A.D.A.A.ShowDialog();
                }
                if (R.ColumnIndex == 12)
                {
                    this.ButtonEditSale.PerformClick();
                }
                if (R.ColumnIndex == 13)
                {
                    this.ButtonEditQQ.PerformClick();
                }
                if ((R.ColumnIndex == 15) | (R.ColumnIndex == 0x10))
                {
                    RH.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["HSaleID"].Value.ToString());
                    RH.R = 2;
                    A.D.A.A.ShowDialog();
                }
                if ((R.ColumnIndex == 0x11) | (R.ColumnIndex == 0x12))
                {
                    RH.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["HSaleID"].Value.ToString());
                    RH.R = 3;
                    A.D.A.A.ShowDialog();
                }
                if (R.ColumnIndex == 0x16)
                {
                    PH.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["HSaleID"].Value.ToString());
                    A.D.A.A.ShowDialog();
                }
            }
        }

        private void R(object A, DataGridViewDataErrorEventArgs R)
        {
            // Invalid method body.
        }

        private void R(object A, KeyEventArgs R)
        {
            // Invalid method body.
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void R(object A, MouseEventArgs R)
        {
            // Invalid method body.
        }

        private void RP(object A, EventArgs R)
        {
            // Invalid method body.
        }

        public void S()
        {
            Application.DoEvents();
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT [CustomerID], [CustomerName], [CustomerBalance], [CustomerDiscount], [CustomerPoints], [CustomerApplyIfPoints], [CustomerPriceType], [CuExpDat] FROM TaNNCustomers WHERE (CustomerID = @CustomerID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CustomerID", this.P);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    this.ComboBoxCustomer.SelectedValue = -1;
                    this.InvSaleDisMaWi.Text = A.PR.MR;
                    this.InvSaleDisMaWiVAL.Text = "0";
                    this.YR.Text = "0";
                    D = "خصم على اجمالي الفاتورة";
                    this.P = 0;
                    this.SR.Text = "0";
                    this.L();
                }
                else
                {
                    this.YR.Text = dataTable.Rows[0]["CustomerDiscount"].ToString();
                    this.OR.Text = dataTable.Rows[0]["CustomerPoints"].ToString();
                    this.BR.Text = dataTable.Rows[0]["CustomerApplyIfPoints"].ToString();
                    this.SR.Text = dataTable.Rows[0]["CustomerPriceType"].ToString();
                    if (!A)
                    {
                        TextBox box = new TextBox {
                            Text = dataTable.Rows[0]["CuExpDat"].ToString()
                        };
                        if (box.Text != null)
                        {
                            DateTime time = Conversions.ToDate(DateTime.Now.ToString("yyyy/MM/dd"));
                            DateTime time2 = Conversions.ToDate(box.Text);
                            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(time.ToString("yyyy/MM/dd"), time2.ToString("yyyy/MM/dd"), false) >= 0)
                            {
                                Interaction.MsgBox("تاريخ التعامل مع بيانات العميل القانونية منتهي", MsgBoxStyle.ApplicationModal, null);
                                this.ComboBoxCustomer.SelectedIndex = -1;
                                this.InvSaleDisMaWi.Text = "0";
                                this.InvSaleDisMaWiVAL.Text = "0";
                                this.SR.Text = "0";
                                this.YR.Text = "0";
                                D = "Discount on Total Invoice";
                                return;
                            }
                        }
                    }
                    if (Conversion.Val(this.YR.Text) <= 0.0)
                    {
                        this.InvSaleDisMaWi.Text = A.PR.MR;
                        this.InvSaleDisMaWiVAL.Text = "0";
                        this.YR.Text = "0";
                        D = "خصم على اجمالي الفاتورة";
                        this.L();
                    }
                    else if (Conversion.Val(this.BR.Text) <= 0.0)
                    {
                        this.InvSaleDisMaWi.Text = this.YR.Text;
                        D = "خصم خاص للعميل";
                        this.L();
                    }
                    else if (Conversion.Val(this.OR.Text) >= Conversion.Val(this.BR.Text))
                    {
                        this.InvSaleDisMaWi.Text = this.YR.Text;
                        D = "خصم تلقائي للعميل لنقاط المكافأة";
                        this.L();
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void S(object A, EventArgs R)
        {
            this.NR.Text = "2";
            this.InvSaleCafeText.Text = "توصيل";
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE TaNNTables SET InvSaleFrontID =@InvSaleFrontID, TableIsBooking =@TableIsBooking WHERE (TableID = @TableID)", this.A);
                command.Parameters.AddWithValue("TableID", LR.Text);
                command.Parameters.AddWithValue("InvSaleFrontID", DBNull.Value);
                command.Parameters.AddWithValue("TableIsBooking", false);
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("UPDATE [TaNNInvSale] SET [InvSaleCafeTablID] = @InvSaleCafeTablID, [InvSaleCafeText] = @InvSaleCafeText WHERE [InvSaleID] = @InvSaleID", this.A);
                command2.Parameters.AddWithValue("InvSaleID", QH.A);
                command2.Parameters.AddWithValue("InvSaleCafeTyp", this.NR.Text);
                command2.Parameters.AddWithValue("InvSaleCafeTablID", "0");
                command2.Parameters.AddWithValue("InvSaleCafeText", this.InvSaleCafeText.Text);
                command2.ExecuteNonQuery();
                this.A.Close();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
            this.L();
        }

        private void SR(object A, EventArgs R)
        {
            if (A.PR.V)
            {
                base.Dispose();
            }
            if (A.AR.QR)
            {
                A.D.A.A.Show();
            }
        }

        public void T()
        {
            // Invalid method body.
        }

        private void T(object A, EventArgs R)
        {
            if (this.GV.RowCount != 0)
            {
                if (!A.PR.S & (Conversion.Val(this.VR.Text.Replace(",", "")) < 0.0))
                {
                    this.ComboBoxBarCode.Items.Clear();
                    Interaction.MsgBox("قيمة الخصم يسبب خسارة في ربح الفاتورة، وتم منع البيع بالخسارة", MsgBoxStyle.ApplicationModal, null);
                    this.ButtonFinishIn.Enabled = true;
                    this.ButtonFinishIn.Text = "   إنهاء البيع وفتح الصندوق | العملاء | اجراءات F2";
                }
                else if (Conversion.Val(this.InvSaleDarFinal.Text.Replace(",", "")) >= 0.0)
                {
                    this.ButtonFinishIn.Enabled = false;
                    this.ButtonFinishIn.Text = "في الانتظار | الانتهاء | امر الطباعة ...";
                    this.TimerGotoFinish.Enabled = true;
                }
                else
                {
                    this.ComboBoxBarCode.Items.Clear();
                    Interaction.MsgBox("هناك خطأ في حساب معامل الضريبة سالبة يجب عليك ازالة الخصم على اجمالي الفاتورة", MsgBoxStyle.ApplicationModal, null);
                    this.ButtonFinishIn.Enabled = true;
                    this.ButtonFinishIn.Text = "   إنهاء البيع وفتح الصندوق | العملاء | اجراءات F2";
                }
            }
        }

        private void TP(object A, EventArgs R)
        {
            this.TimerGotoSave.Enabled = false;
            if (A.PR.KR)
            {
                try
                {
                    P = Guid.NewGuid().ToString();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    Interaction.MsgBox("خطأ في عملية توليد كود uuid", MsgBoxStyle.ApplicationModal, null);
                    this.ButtonFinishSave.Enabled = true;
                    this.ButtonFinishSave.Text = "حفظ التعديلات F5";
                    Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.TimerFocus.Enabled = true;
                    ProjectData.ClearProjectError();
                    return;
                }
                if ((this.InvSaleType.SelectedIndex == 1) & ((Q == null) | (Conversion.Val(Q) == 0.0)))
                {
                    this.ButtonFinishSave.Enabled = true;
                    this.ButtonFinishSave.Text = "حفظ التعديلات F5";
                    A.D.A.A.ShowDialog();
                    return;
                }
            }
            try
            {
                IEnumerator enumerator;
                IEnumerator enumerator2;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT [HSaleID], [HSalePriceTotal], [HSaleDisVal], [HSaleDarVal] FROM [TaNNInvSaleItems] WHERE ([InvSaleFrontID] = @InvSaleFrontID) AND ([HSaleIsDelete] = @HSaleIsDelete)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleFrontID", QH.A);
                adapter.SelectCommand.Parameters.AddWithValue("HSaleIsDelete", false);
                adapter.Fill(dataTable);
                this.A.Close();
                int num = 0;
                decimal num2 = 0M;
                decimal num3 = 0M;
                decimal num4 = 0M;
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
                        object[] arguments = new object[] { "HSaleID" };
                        num = Conversions.ToInteger(NewLateBinding.LateIndexGet(current, arguments, null));
                        object[] objArray2 = new object[] { "HSalePriceTotal" };
                        num2 = Conversions.ToDecimal(NewLateBinding.LateIndexGet(current, objArray2, null));
                        object[] objArray3 = new object[] { "HSaleDisVal" };
                        num3 = Conversions.ToDecimal(NewLateBinding.LateIndexGet(current, objArray3, null));
                        object[] objArray4 = new object[] { "HSaleDarVal" };
                        num4 = Conversions.ToDecimal(NewLateBinding.LateIndexGet(current, objArray4, null));
                        decimal num6 = 0M;
                        if (decimal.Compare(num4, decimal.Zero) <= 0)
                        {
                            num6 = 0M;
                        }
                        else if (Conversions.ToDouble(A.PR.PP) == 0.0)
                        {
                            num6 = decimal.Subtract(num2, num3);
                        }
                        else if (Conversions.ToDouble(A.PR.PP) == 1.0)
                        {
                            num6 = decimal.Subtract(decimal.Subtract(num2, num3), num4);
                        }
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNInvSaleItems] SET [Taxabl] = @Taxabl WHERE [HSaleID] = @HSaleID", this.A);
                        command.Parameters.AddWithValue("HSaleID", num);
                        command.Parameters.AddWithValue("Taxabl", num6.ToString(A.PR.VR));
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable table2 = new DataTable();
                string str2 = "SELECT [Taxabl] FROM [TaNNInvSaleItems] WHERE ([InvSaleFrontID] = @InvSaleFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                adapter2.SelectCommand.Parameters.AddWithValue("InvSaleFrontID", QH.A);
                adapter2.Fill(table2);
                this.A.Close();
                decimal left = 0M;
                try
                {
                    enumerator2 = table2.Rows.GetEnumerator();
                    while (true)
                    {
                        if (!enumerator2.MoveNext())
                        {
                            break;
                        }
                        object current = enumerator2.Current;
                        object[] arguments = new object[] { "Taxabl" };
                        left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                    }
                }
                finally
                {
                    if (enumerator2 is IDisposable)
                    {
                        (enumerator2 as IDisposable).Dispose();
                    }
                }
                this.E.Text = Conversions.ToString(left);
            }
            catch (Exception exception4)
            {
                Exception ex = exception4;
                ProjectData.SetProjectError(ex);
                Exception exception2 = ex;
                this.ButtonFinishSave.Enabled = true;
                this.ButtonFinishSave.Text = "حفظ التعديلات F5";
                Interaction.MsgBox(exception2.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
                return;
            }
            try
            {
                decimal num7 = 0M;
                decimal num8 = 0M;
                decimal num9 = 0M;
                decimal num10 = 0M;
                decimal num11 = 0M;
                decimal num12 = 0M;
                num7 = new decimal(Conversion.Val(this.InvSaleTotalAmount.Text.Replace(",", "")));
                num8 = new decimal(Conversion.Val(this.InvSaleDisFinal.Text.Replace(",", "")));
                num9 = new decimal(Conversion.Val(this.InvSaleDarFinal.Text.Replace(",", "")));
                num10 = new decimal(Conversion.Val(this.InvSaleTotalNET.Text.Replace(",", "")));
                num11 = new decimal(Conversion.Val(this.VR.Text.Replace(",", "")));
                num12 = new decimal(Conversion.Val(this.E.Text.Replace(",", "")));
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("UPDATE [TaNNInvSale] SET [CustomerFrontID] = @CustomerFrontID, [InvSaleDateTime] = @InvSaleDateTime, [InvSaleType] = @InvSaleType, [InvSaleStatus] = @InvSaleStatus, [InvSalePayType] = @InvSalePayType, [InvSaleItems] = @InvSaleItems, [InvSaleTotalAmount] = @InvSaleTotalAmount, [InvSaleDisMaWi] = @InvSaleDisMaWi, [InvSaleDisVal] = @InvSaleDisVal, [InvSaleDarMiWi] = @InvSaleDarMiWi, [InvSaleDarVal] = @InvSaleDarVal, [InvSaleTotalNET] = @InvSaleTotalNET, [InvSaleTotalProft] = @InvSaleTotalProft, [InvSaleNote] = @InvSaleNote, [InvSaleUserAddBy] = @InvSaleUserAddBy, [InvSaleCafeTyp] = @InvSaleCafeTyp, [InvSaleCafeTablID] = @InvSaleCafeTablID, [InvSaleCafeText] = @InvSaleCafeText, [Taxabl] = @Taxabl, [UUID] = @UUID, [HashQR] = @HashQR, [ReID] = @ReID, [ReHashQR] = @ReHashQR WHERE [InvSaleID] = @InvSaleID", this.A);
                command2.Parameters.AddWithValue("InvSaleID", QH.A);
                command2.Parameters.AddWithValue("CustomerFrontID", this.P);
                command2.Parameters.AddWithValue("InvSaleDateTime", this.InvSaleDateTime.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                command2.Parameters.AddWithValue("InvSaleType", this.InvSaleType.SelectedIndex);
                command2.Parameters.AddWithValue("InvSaleStatus", "3");
                command2.Parameters.AddWithValue("InvSalePayType", this.InvSalePayType.SelectedIndex);
                command2.Parameters.AddWithValue("InvSaleItems", this.InvSaleItems.Text);
                command2.Parameters.AddWithValue("InvSaleTotalAmount", num7.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleDisMaWi", Conversion.Val(this.InvSaleDisMaWi.Text));
                command2.Parameters.AddWithValue("InvSaleDisVal", num8.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleDarMiWi", Conversion.Val(this.InvSaleDarMiWi.Text));
                command2.Parameters.AddWithValue("InvSaleDarVal", num9.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleTotalNET", num10.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleTotalProft", num11.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("InvSaleNote", this.InvSaleNote.Text);
                command2.Parameters.AddWithValue("InvSaleUserAddBy", A.D.A.A.TxTUserName.Text);
                command2.Parameters.AddWithValue("InvSaleCafeTyp", this.NR.Text);
                command2.Parameters.AddWithValue("InvSaleCafeTablID", "0");
                command2.Parameters.AddWithValue("InvSaleCafeText", this.InvSaleCafeText.Text);
                command2.Parameters.AddWithValue("Taxabl", num12.ToString(A.PR.VR));
                command2.Parameters.AddWithValue("UUID", P.ToString());
                command2.Parameters.AddWithValue("HashQR", "0");
                command2.Parameters.AddWithValue("ReID", Q.ToString());
                command2.Parameters.AddWithValue("ReHashQR", I.ToString());
                command2.ExecuteNonQuery();
                this.A.Close();
                IH.A = QH.A;
                IH.A = QH.A;
                A.D.A.A.ShowDialog();
            }
            catch (Exception exception5)
            {
                Exception ex = exception5;
                ProjectData.SetProjectError(ex);
                Exception exception3 = ex;
                this.ButtonFinishSave.Enabled = true;
                this.ButtonFinishSave.Text = "حفظ التعديلات F5";
                Interaction.MsgBox(exception3.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void TR(object A, EventArgs R)
        {
            Application.DoEvents();
            if (!this.P && !QH.A)
            {
                decimal num = new decimal(Conversion.Val(this.InvSaleTotalNET.Text.Replace(",", "")));
                if ((((Conversion.Val(A.PR.JR) > 0.0) & (Conversion.Val(A.PR.CR) > 0.0)) && (Conversion.Val(this.YR.Text) == 0.0)) && Q)
                {
                    if (Convert.ToDouble(num) < Conversion.Val(A.PR.CR))
                    {
                        if (Convert.ToDouble(num) < Conversion.Val(A.PR.CR))
                        {
                            this.InvSaleDisMaWiVAL.Text = "0";
                            this.InvSaleDisMaWi.Text = "0";
                            D = "خصم على اجمالي الفاتورة";
                            this.TabControl2.SelectedTab = this.TabPage2;
                            Q = false;
                            this.L();
                            return;
                        }
                    }
                    else
                    {
                        this.InvSaleDisMaWi.Text = Conversions.ToString(Conversion.Val(A.PR.JR));
                        D = "خصم مشروط على اجمالي الفاتورة";
                        this.TabControl2.SelectedTab = this.TabPage2;
                        Q = false;
                        this.L();
                        return;
                    }
                }
            }
            if (A.AR.H)
            {
                try
                {
                    this.SerialPortPoly.PortName = A.AR.T;
                    this.SerialPortPoly.Open();
                    this.SerialPortPoly.Write("\n\n\x001b@\n");
                    this.SerialPortPoly.Write("\n\n\x001b0\n");
                    this.SerialPortPoly.Write("\n");
                    this.SerialPortPoly.Write("\r");
                    this.SerialPortPoly.Write(this.InvSaleTotalNET.Text);
                    this.SerialPortPoly.Close();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    A.AR.H = false;
                    Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
            }
        }

        public void U()
        {
            Application.DoEvents();
            try
            {
                decimal num = 0M;
                if (this.InvSaleType.SelectedIndex == 0)
                {
                    num = new decimal(Conversion.Val(this.V.Text.Replace(",", "")) - Conversion.Val(this.TxTQuantityName.Text.Replace(",", "")));
                }
                else if (this.InvSaleType.SelectedIndex == 1)
                {
                    num = new decimal(Conversion.Val(this.V.Text.Replace(",", "")) + Conversion.Val(this.TxTQuantityName.Text.Replace(",", "")));
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                command.Parameters.AddWithValue("MaterialID", this.K.Text);
                command.Parameters.AddWithValue("MaterialQuantity", num.ToString(A.PR.OR));
                command.ExecuteNonQuery();
                this.A.Close();
                this.L();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void U(object A, EventArgs R)
        {
            this.O();
        }

        private void UR(object A, EventArgs R)
        {
            if (A.PR.JR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void V()
        {
            // Invalid method body.
        }

        private void V(object A, EventArgs R)
        {
            this.InvSaleDisMaWi.Text = A.PR.MR;
            this.InvSaleDarMiWi.Text = A.PR.AP;
            this.L();
        }

        private void VR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void W(object A, EventArgs R)
        {
            if (!A.PR.FP)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                OI.A = 0;
                A.D.A.A.ShowDialog();
            }
        }

        private void WR(object A, EventArgs R)
        {
            if (this.ComboBoxBarCode.Items.Count > 0)
            {
                base.KeyPreview = false;
                this.ToolStripFotter.Enabled = false;
                this.PanelFotter.Enabled = false;
                this.TabControl1.Enabled = false;
                this.TabControl2.Enabled = false;
                this.PanelMataem.Enabled = false;
                this.ToolStripMore.Enabled = false;
                this.ButtonSaleCode.Enabled = false;
                this.GroupBoxQ.Enabled = false;
                this.GV.Enabled = false;
                this.TxTBarCode.Text = this.ComboBoxBarCode.Items[0].ToString();
                this.ComboBoxBarCode.Items.RemoveAt(0);
                this.D();
            }
            if (this.ComboBoxBarCode.Items.Count > 0)
            {
                this.Text = "في الانتظار بيع   " + this.ComboBoxBarCode.Items.Count.ToString() + "   عنصر";
            }
            else
            {
                this.Text = "شاشة البيع";
            }
        }

        public void X()
        {
            try
            {
                string str = Strings.Left(this.TxTBarCode.Text, 7);
                string str2 = Strings.Right(this.TxTBarCode.Text, 6);
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialBarCode] = @MaterialBarCode)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                adapter.SelectCommand.Parameters.AddWithValue("MaterialBarCode", str);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    this.ComboBoxBarCode.Items.Clear();
                    this.T();
                    Interaction.MsgBox("لم يتم العثور على المادة في المستودع " + this.TxTBarCode.Text, MsgBoxStyle.ApplicationModal, null);
                    this.TimerFocus.Enabled = true;
                }
                else
                {
                    this.K.Text = dataTable.Rows[0]["MaterialID"].ToString();
                    this.U.Text = dataTable.Rows[0]["GroupIDFrontID"].ToString();
                    this.L.Text = dataTable.Rows[0]["MaterialBarCode"].ToString();
                    this.N.Text = dataTable.Rows[0]["MaterialName"].ToString();
                    this.V.Text = dataTable.Rows[0]["MaterialQuantity"].ToString();
                    this.Y.Text = dataTable.Rows[0]["MaterialUnit"].ToString();
                    this.O.Text = dataTable.Rows[0]["MaterialPricCost"].ToString();
                    this.B.Text = dataTable.Rows[0]["MaterialPricLess"].ToString();
                    this.S.Text = dataTable.Rows[0]["MaterialPricSale"].ToString();
                    this.A.Checked = Conversions.ToBoolean(dataTable.Rows[0]["MaterialIsStop"].ToString());
                    this.Z.Text = dataTable.Rows[0]["MaterialExpDate"].ToString();
                    this.M.Text = dataTable.Rows[0]["MaterialNote"].ToString();
                    this.R.Checked = Conversions.ToBoolean(dataTable.Rows[0]["MaterialNotIsView"].ToString());
                    this.C.Text = dataTable.Rows[0]["MaterialQuantityOffer"].ToString();
                    this.J.Text = dataTable.Rows[0]["MaterialDisMiWi"].ToString();
                    this.W.Text = dataTable.Rows[0]["MaterialDarMiWi"].ToString();
                    this.AR.Text = dataTable.Rows[0]["MaterialDisExpDat"].ToString();
                    decimal num = 0M;
                    if (Conversions.ToDouble(A.PR.SR) == 0.0)
                    {
                        num = new decimal(Convert.ToDouble(new decimal(Conversions.ToDouble(Strings.Left(str2, 5)) / Conversion.Val(this.S.Text))) / Conversion.Val(A.PR.G));
                    }
                    else if (Conversions.ToDouble(A.PR.SR) == 1.0)
                    {
                        num = new decimal(Conversions.ToDouble(Strings.Left(str2, 5)) / Conversion.Val(A.PR.G));
                    }
                    this.TxTQuantityName.Text = Conversions.ToString(num);
                    this.TxTBarCode.Text = str;
                    I = true;
                    this.G();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void X(object A, EventArgs R)
        {
            A.AR.F = A.AR.F;
        }

        private void XP(object A, EventArgs R)
        {
            if (!A.PR.S)
            {
                Interaction.MsgBox("غير مسموح لك في بيع مواد تسبب الخسارة، تسجيل المواد المجانية تؤدي لربح سالب", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Interaction.MsgBox("يمكنك الأن اختيار المادة، سيتم احتساب سعرها 0 مجانية", MsgBoxStyle.ApplicationModal, null);
                this.R = true;
            }
        }

        private void XR(object A, EventArgs R)
        {
            if (this.InvSaleType.SelectedIndex == 1)
            {
                VD.I = "SELECT TaNNInvSaleItems.*, TaNNCustomers.CustomerName FROM TaNNInvSaleItems LEFT OUTER JOIN TaNNCustomers ON TaNNInvSaleItems.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSaleItems.CenterFrontID = @CenterFrontID) AND (TaNNInvSaleItems.HSaleDateTime BETWEEN @DF and @DT) AND (TaNNInvSaleItems.HSaleType = 0)";
                A.D.A.A.ShowDialog();
            }
        }

        public void Y()
        {
            // Invalid method body.
        }

        private void Y(object A, EventArgs R)
        {
            this.Z();
            if (!(!A.PR.IQ & (this.GV.RowCount > 0)))
            {
                JF.A = QH.A;
                A.D.A.A.ShowDialog();
            }
            else
            {
                this.P();
                this.ComboBoxBarCode.Items.Clear();
                Interaction.MsgBox("هذه الفاتورة تحتوي على مواد، ولا يمكن اغلاق شاشة البيع لعدم وجود صلاحيات تعليق الفواتير لديك، يجب عليك انهاء الفاتورة", MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void YR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        public void Z()
        {
            Application.DoEvents();
            try
            {
                decimal num = 0M;
                decimal num2 = 0M;
                decimal num3 = 0M;
                decimal num4 = 0M;
                decimal num5 = 0M;
                num = new decimal(Conversion.Val(this.InvSaleTotalAmount.Text.Replace(",", "")));
                num2 = new decimal(Conversion.Val(this.InvSaleDisMaWiVAL.Text.Replace(",", "")));
                num3 = new decimal(Conversion.Val(this.InvSaleDarFinal.Text.Replace(",", "")));
                num4 = new decimal(Conversion.Val(this.InvSaleTotalNET.Text.Replace(",", "")));
                num5 = new decimal(Conversion.Val(this.VR.Text.Replace(",", "")));
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [TaNNInvSale] SET [CustomerFrontID] = @CustomerFrontID, [InvSaleDateTime] = @InvSaleDateTime, [InvSaleType] = @InvSaleType, [InvSaleStatus] = @InvSaleStatus, [InvSalePayType] = @InvSalePayType, [InvSaleItems] = @InvSaleItems, [InvSaleTotalAmount] = @InvSaleTotalAmount, [InvSaleDisMaWi] = @InvSaleDisMaWi, [InvSaleDisVal] = @InvSaleDisVal, [InvSaleDarMiWi] = @InvSaleDarMiWi, [InvSaleDarVal] = @InvSaleDarVal, [InvSaleTotalNET] = @InvSaleTotalNET, [InvSaleTotalProft] = @InvSaleTotalProft, [InvSaleNote] = @InvSaleNote, [InvSaleUserAddBy] = @InvSaleUserAddBy, [InvSaleCusOrdarNo] =@InvSaleCusOrdarNo, [InvSaleCafeTyp] = @InvSaleCafeTyp, [InvSaleCafeTablID] = @InvSaleCafeTablID, [InvSaleCafeText] = @InvSaleCafeText WHERE [InvSaleID] = @InvSaleID", this.A);
                command.Parameters.AddWithValue("InvSaleID", A);
                command.Parameters.AddWithValue("CustomerFrontID", this.P);
                command.Parameters.AddWithValue("InvSaleDateTime", this.InvSaleDateTime.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                command.Parameters.AddWithValue("InvSaleType", this.InvSaleType.SelectedIndex);
                command.Parameters.AddWithValue("InvSaleStatus", "1");
                command.Parameters.AddWithValue("InvSalePayType", this.InvSalePayType.SelectedIndex);
                command.Parameters.AddWithValue("InvSaleItems", this.InvSaleItems.Text);
                command.Parameters.AddWithValue("InvSaleTotalAmount", num.ToString(A.PR.VR));
                command.Parameters.AddWithValue("InvSaleDisMaWi", Conversion.Val(this.InvSaleDisMaWi.Text));
                command.Parameters.AddWithValue("InvSaleDisVal", num2.ToString(A.PR.VR));
                command.Parameters.AddWithValue("InvSaleDarMiWi", Conversion.Val(this.InvSaleDarMiWi.Text));
                command.Parameters.AddWithValue("InvSaleDarVal", num3.ToString(A.PR.VR));
                command.Parameters.AddWithValue("InvSaleTotalNET", num4.ToString(A.PR.VR));
                command.Parameters.AddWithValue("InvSaleTotalProft", num5.ToString(A.PR.VR));
                command.Parameters.AddWithValue("InvSaleNote", this.InvSaleNote.Text);
                command.Parameters.AddWithValue("InvSaleUserAddBy", A.D.A.A.TxTUserName.Text);
                command.Parameters.AddWithValue("InvSaleCusOrdarNo", Conversion.Val(this.TxTOrdarNo.Text));
                command.Parameters.AddWithValue("InvSaleCafeTyp", this.NR.Text);
                command.Parameters.AddWithValue("InvSaleCafeTablID", LR.Text);
                command.Parameters.AddWithValue("InvSaleCafeText", this.InvSaleCafeText.Text);
                command.ExecuteNonQuery();
                this.A.Close();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TimerFocus.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void Z(object A, EventArgs R)
        {
            this.NR.Text = "0";
            this.InvSaleCafeText.Text = "سفري";
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE TaNNTables SET InvSaleFrontID =@InvSaleFrontID, TableIsBooking =@TableIsBooking WHERE (TableID = @TableID)", this.A);
                command.Parameters.AddWithValue("TableID", LR.Text);
                command.Parameters.AddWithValue("InvSaleFrontID", DBNull.Value);
                command.Parameters.AddWithValue("TableIsBooking", false);
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("UPDATE [TaNNInvSale] SET [InvSaleCafeTablID] = @InvSaleCafeTablID, [InvSaleCafeText] = @InvSaleCafeText WHERE [InvSaleID] = @InvSaleID", this.A);
                command2.Parameters.AddWithValue("InvSaleID", QH.A);
                command2.Parameters.AddWithValue("InvSaleCafeTyp", this.NR.Text);
                command2.Parameters.AddWithValue("InvSaleCafeTablID", "0");
                command2.Parameters.AddWithValue("InvSaleCafeText", this.InvSaleCafeText.Text);
                command2.ExecuteNonQuery();
                this.A.Close();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
            this.L();
        }

        private void ZR(object A, EventArgs R)
        {
            this.ComboBoxCustomer.SelectedIndex = -1;
            this.InvSaleDisMaWi.Text = "0";
            this.InvSaleDisMaWiVAL.Text = "0";
            this.SR.Text = "0";
            this.YR.Text = "0";
            D = "خصم على اجمالي الفاتورة";
            this.L();
        }

        internal virtual Button ButtonSaleCode
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.AP);
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

        internal virtual PictureBox PictureBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTBarCode
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonFinishSave
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual Button ButtonPendingList
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PR);
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

        internal virtual Button ButtonFinishIn
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

        internal virtual Button ButtonPendingNow
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Timer TimerFocus
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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

        internal virtual ToolStrip ToolStripFotter
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual ToolStripButton ButtonCanceInv
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
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
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual ToolStripButton ButtonQPrint
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.HR);
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

        internal virtual ToolStripButton ButtonEditQQ
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.C);
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

        internal virtual ToolStripButton ButtonSetting
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
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

        internal virtual ToolStripSeparator ToolStripSeparator8
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual SerialPort SerialPortPoly
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ButtonOpenCash
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

        internal virtual Timer TimerStartUpLoad
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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

        internal virtual Panel Panel5
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Panel PanelFotter
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual SplitContainer SplitContainer3
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ButtEditeAll
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.OR);
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

        internal virtual ToolStripSeparator ToolStripSeparator9
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator10
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual ToolStripButton ButPrintLast
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.FR);
                ToolStripButton f = this.F;
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

        internal virtual Panel Panel1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual TabPage TabPageX1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual SplitContainer SplitContainer1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual DataGridView GVGroups
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                DataGridViewBindingCompleteEventHandler handler = new DataGridViewBindingCompleteEventHandler(this.A);
                DataGridViewCellEventHandler handler2 = new DataGridViewCellEventHandler(this.A);
                DataGridViewCellEventHandler handler3 = new DataGridViewCellEventHandler(this.P);
                DataGridViewDataErrorEventHandler handler4 = new DataGridViewDataErrorEventHandler(this.P);
                DataGridView a = this.A;
                if (a != null)
                {
                    a.DataBindingComplete -= handler;
                    a.CellClick -= handler2;
                    a.CellContentClick -= handler3;
                    a.DataError -= handler4;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.DataBindingComplete += handler;
                    a.CellClick += handler2;
                    a.CellContentClick += handler3;
                    a.DataError += handler4;
                }
            }
        }

        internal virtual DataGridView GVMaterials
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.A);
                MouseEventHandler handler2 = new MouseEventHandler(this.R);
                DataGridViewCellEventHandler handler3 = new DataGridViewCellEventHandler(this.Q);
                DataGridViewDataErrorEventHandler handler4 = new DataGridViewDataErrorEventHandler(this.R);
                DataGridView r = this.R;
                if (r != null)
                {
                    r.MouseClick -= handler;
                    r.MouseDoubleClick -= handler2;
                    r.CellContentClick -= handler3;
                    r.DataError -= handler4;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.MouseClick += handler;
                    r.MouseDoubleClick += handler2;
                    r.CellContentClick += handler3;
                    r.DataError += handler4;
                }
            }
        }

        internal virtual TabPage TabPageX2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox ComboBoxM
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyEventHandler handler = new KeyEventHandler(this.P);
                EventHandler handler2 = new EventHandler(this.RP);
                ComboBox a = this.A;
                if (a != null)
                {
                    a.KeyDown -= handler;
                    a.SelectedIndexChanged -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.KeyDown += handler;
                    a.SelectedIndexChanged += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ComboBox ComboBoxG
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual TabPage TabPageX4
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual SplitContainer SplitContainer2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual FlowLayoutPanel FlowLayoutPanel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPageX3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual SplitContainer SplitContainer4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonbySerch
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual TextBox TxTSerch
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox r = this.R;
                if (r != null)
                {
                    r.KeyPress -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.KeyPress += handler;
                }
            }
        }

        internal virtual RadioButton RadioButtonName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual RadioButton RadioButtonNote
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual RadioButton RadioButtonCode
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual DataGridView GVMMAdva
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.P);
                MouseEventHandler handler2 = new MouseEventHandler(this.Q);
                KeyEventHandler handler3 = new KeyEventHandler(this.R);
                DataGridViewCellEventHandler handler4 = new DataGridViewCellEventHandler(this.I);
                DataGridViewDataErrorEventHandler handler5 = new DataGridViewDataErrorEventHandler(this.Q);
                DataGridView p = this.P;
                if (p != null)
                {
                    p.MouseDoubleClick -= handler;
                    p.MouseClick -= handler2;
                    p.KeyDown -= handler3;
                    p.CellContentClick -= handler4;
                    p.DataError -= handler5;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.MouseDoubleClick += handler;
                    p.MouseClick += handler2;
                    p.KeyDown += handler3;
                    p.CellContentClick += handler4;
                    p.DataError += handler5;
                }
            }
        }

        internal virtual Button ButtonQPlus
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual Button ButtonButtonQMinus
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual TextBox TxTQuantityName
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.R);
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

        internal virtual FlowLayoutPanel FlowLayoutPanel2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBoxQ
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ComboBox InvSaleType
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.J);
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

        internal virtual Panel Panel2
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Panel PanelMataem
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Button ButtonMataNormal
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Z);
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

        internal virtual Button ButtonMataDelivary
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
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

        internal virtual Button ButtonMataTables
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
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

        internal virtual Label InvSaleCafeText
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonMataTawasi
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.B);
                Button e = this.E;
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TabControl TabControl2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual DateTimePicker InvSaleDateTime
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox InvSalePayType
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual Label InvSaleTotalNET
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.TR);
                EventHandler handler2 = new EventHandler(this.DP);
                Label r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                    r.Click -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
                    r.Click += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBoxMAX
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
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label InvSaleTotalAmount
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Label InvSaleItems
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox InvSaleDisFinal
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBoxDis
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TextBox InvSaleDisMaWiVAL
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.Q);
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

        internal virtual TextBox InvSaleDisMaWi
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.P);
                TextBox d = this.D;
                if (d != null)
                {
                    d.KeyPress -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.KeyPress += handler;
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

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox InvSaleDarFinal
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox InvSaleDarMiWi
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

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox InvSaleNote
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
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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

        internal virtual Button Button1
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual ToolStripButton ButtonEditSale
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.M);
                ToolStripButton h = this.H;
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Button ButtonSerch
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.AR);
                Button u = this.U;
                if (u != null)
                {
                    u.Click -= handler;
                }
                this.U = value;
                u = this.U;
                if (u != null)
                {
                    u.Click += handler;
                }
            }
        }

        internal virtual Button ButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.W);
                Button l = this.L;
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                DataGridViewCellEventHandler handler = new DataGridViewCellEventHandler(this.R);
                DataGridViewCellEventHandler handler2 = new DataGridViewCellEventHandler(this.D);
                DataGridView q = this.Q;
                if (q != null)
                {
                    q.CellClick -= handler;
                    q.CellContentClick -= handler2;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.CellClick += handler;
                    q.CellContentClick += handler2;
                }
            }
        }

        internal virtual Timer TimerNewOrOpenInvoice
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.QR);
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

        internal virtual Button Button2
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.IR);
                Button n = this.N;
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

        internal virtual ComboBox ComboBoxCustomer
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Timer TimerGotoFinish
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.DR);
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

        internal virtual GroupBox GroupBoxTxTBarCode
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.XR);
                GroupBox g = this.G;
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

        internal virtual ToolStrip ToolStripMore
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripDropDownButton ToolStripDropDownButton1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem TipAddOut
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.UR);
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

        internal virtual ToolStripSeparator ToolStripSeparator11
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual ToolStripMenuItem TipAddRemem
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ER);
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

        internal virtual ToolStripSeparator ToolStripSeparator12
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual ToolStripMenuItem TipCusAddAm
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.CR);
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

        internal virtual ToolStripSeparator ToolStripSeparator13
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual ToolStripMenuItem TipSupAddAm
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.MR);
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

        internal virtual ToolStripMenuItem TipAddExp
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.JR);
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

        internal virtual ToolStripSeparator ToolStripSeparator15
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual ToolStripMenuItem TipSetting
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.LR);
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

        internal virtual Button ButtonReMAX
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.GR);
                Button v = this.V;
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

        internal virtual TextBox InvSaleIDMAX
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual Button ButtonOrdarNo
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.KR);
                Button y = this.Y;
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

        internal virtual TextBox TxTOrdarNo
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual ToolStripDropDownButton ButtonQery
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripMenuItem F12ToolStripMenuIQC
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.YR);
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

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual ToolStripMenuItem F7ToolStripMenuIQM
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.VR);
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

        internal virtual Button ButtonGift
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.BR);
                Button o = this.O;
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

        internal virtual Button ButtonRemoveCustomer
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ZR);
                Button b = this.B;
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

        internal virtual ComboBox ComboBoxBarCode
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.D);
                EventHandler handler2 = new EventHandler(this.FP);
                ComboBox d = this.D;
                if (d != null)
                {
                    d.KeyPress -= handler;
                    d.SelectedIndexChanged -= handler2;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.KeyPress += handler;
                    d.SelectedIndexChanged += handler2;
                }
            }
        }

        internal virtual Timer TimerWelcomeBarCode
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.WR);
                Timer i = this.I;
                if (i != null)
                {
                    i.Tick -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.Tick += handler;
                }
            }
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

        internal virtual ToolStripDropDownButton ToolStripSplitButton1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.HP);
                ToolStripDropDownButton p = this.P;
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

        internal virtual ToolStripMenuItem ButtonDis
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PP);
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

        internal virtual ToolStripSeparator ToolStripSeparator16
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual ToolStripMenuItem ButtonDisRemve
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.QP);
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

        internal virtual ToolStripSeparator ToolStripSeparator17
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual ToolStripMenuItem ButtonDisChange
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.IP);
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

        internal virtual Timer TimerGotoSave
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.TP);
                Timer d = this.D;
                if (d != null)
                {
                    d.Tick -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.Tick += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator18
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual ToolStripMenuItem AddFreeM
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.XP);
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

