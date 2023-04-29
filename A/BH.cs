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
    public class BH : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TabPage3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label6"), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("CenterDarVATNo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [CompilerGenerated, AccessedThroughProperty("CenterDarMaWi"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage4"), CompilerGenerated]
        private TabPage R;
        [AccessedThroughProperty("CenterDisMaWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [CompilerGenerated, AccessedThroughProperty("TabPage5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterInvIsViewSubNa"), CompilerGenerated]
        private CheckBox A;
        [AccessedThroughProperty("CenterInvIsViewHedar"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterInvIsViewLogo")]
        private CheckBox P;
        [AccessedThroughProperty("CenterInvFotter"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage6")]
        private TabPage Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterIsMezan"), CompilerGenerated]
        private CheckBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage8"), CompilerGenerated]
        private TabPage I;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonLogoImag"), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterDecimelQuantity"), CompilerGenerated]
        private ComboBox A;
        [CompilerGenerated, AccessedThroughProperty("CenterDecimelPrince"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [AccessedThroughProperty("CenterCurrencyName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label9")]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label2"), CompilerGenerated]
        private Label P;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("CenterPhone"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox D;
        [CompilerGenerated, AccessedThroughProperty("CenterLocation"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox F;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterName"), CompilerGenerated]
        private Label I;
        [AccessedThroughProperty("CenterSaleIsSaleeb"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox I;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage F;
        [CompilerGenerated, AccessedThroughProperty("ButtonOk"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterSubName")]
        private Label D;
        [CompilerGenerated, AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [CompilerGenerated, AccessedThroughProperty("CenterIsRestorentCafe"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox D;
        [CompilerGenerated, AccessedThroughProperty("ButtonResturntTabls"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterMezanType"), CompilerGenerated]
        private ComboBox P;
        [AccessedThroughProperty("TabPage13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage H;
        [AccessedThroughProperty("ButtonCurr"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button I;
        [AccessedThroughProperty("CenterInvIsViwOtherCur"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox F;
        [AccessedThroughProperty("CenterInvIsCustomerLast"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox H;
        [AccessedThroughProperty("CenterInvIsViewBCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox T;
        [AccessedThroughProperty("CenterInvIsViewCustomer"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox X;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("CenterDisIFMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox H;
        [AccessedThroughProperty("Label8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label F;
        [CompilerGenerated, AccessedThroughProperty("CenterDisIFVAL"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox T;
        [AccessedThroughProperty("Label7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label H;
        [AccessedThroughProperty("ButtonHelpBar"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button D;
        [AccessedThroughProperty("TabPage7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage T;
        [AccessedThroughProperty("TxTDDCenterNa"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label T;
        [AccessedThroughProperty("Label12"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label X;
        [AccessedThroughProperty("Label10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label G;
        [AccessedThroughProperty("Label14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label E;
        [AccessedThroughProperty("ToolStripDelete"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip A;
        [AccessedThroughProperty("BDeletSame"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripDropDownButton A;
        [AccessedThroughProperty("DTaMaterial"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("ToolStripSeparator5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator A;
        [AccessedThroughProperty("DTaSuplier"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("ToolStripSeparator6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator R;
        [CompilerGenerated, AccessedThroughProperty("DTaCustomers"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator8"), CompilerGenerated]
        private ToolStripSeparator P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DTaInvSale"), CompilerGenerated]
        private ToolStripMenuItem Q;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DTaExpenses"), CompilerGenerated]
        private ToolStripMenuItem I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator9")]
        private ToolStripSeparator I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DTaInvPurch"), CompilerGenerated]
        private ToolStripMenuItem D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripLabel1")]
        private ToolStripLabel A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated]
        private ToolStripSeparator F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripLabel2"), CompilerGenerated]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("BDeleteAll"), CompilerGenerated]
        private ToolStripButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterMorFeeVALDelivary"), CompilerGenerated]
        private TextBox X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label16"), CompilerGenerated]
        private Label K;
        [AccessedThroughProperty("Label15"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label U;
        [AccessedThroughProperty("CenterMorFeeVALTable"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox5"), CompilerGenerated]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CenterDarType0")]
        private RadioButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterDarType"), CompilerGenerated]
        private TextBox E;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterIsAllarmQQExip"), CompilerGenerated]
        private CheckBox G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage10")]
        private TabPage X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CenterMorFeeVALCardPay")]
        private TextBox K;
        [AccessedThroughProperty("Label18"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label L;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label21")]
        private Label N;
        [AccessedThroughProperty("Label20"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label V;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label19")]
        private Label Y;
        [AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("Label24"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label O;
        [AccessedThroughProperty("Label23"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label B;
        [AccessedThroughProperty("CenterMorFeeTaxMiaW"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox U;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CenterMorFeeTaXName")]
        private TextBox L;
        [AccessedThroughProperty("Label22"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label S;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label25")]
        private Label Z;
        [CompilerGenerated, AccessedThroughProperty("Label26"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label M;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label27")]
        private Label C;
        [AccessedThroughProperty("CenterDarType1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RadioButton R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterInvIsViewProft")]
        private CheckBox E;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterDarTXT"), CompilerGenerated]
        private TextBox N;
        [AccessedThroughProperty("CenterDisTXT"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox V;
        [CompilerGenerated, AccessedThroughProperty("CenterInvIsViewDar"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox K;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CenterInvIsViewDis")]
        private CheckBox U;
        [AccessedThroughProperty("Label28"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label J;
        [AccessedThroughProperty("CenterMorFeeVALTaWasi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Y;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label32")]
        private Label W;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CenterSaleIsLoss")]
        private CheckBox L;
        [AccessedThroughProperty("GroupBox8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CenterMezanHalfOn")]
        private ComboBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DTaCash"), CompilerGenerated]
        private ToolStripMenuItem F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterInvIsViewMainName")]
        private CheckBox N;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterInvIsViewSigna"), CompilerGenerated]
        private CheckBox V;
        [CompilerGenerated, AccessedThroughProperty("Label17"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label AR;
        [CompilerGenerated, AccessedThroughProperty("Label13"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label PR;
        [CompilerGenerated, AccessedThroughProperty("CenterInvMAXMIX"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox Y;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage9")]
        private TabPage G;
        [CompilerGenerated, AccessedThroughProperty("ButtonSaleSeet"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button F;
        [CompilerGenerated, AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox10")]
        private GroupBox H;
        [CompilerGenerated, AccessedThroughProperty("Label11"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label QR;
        [AccessedThroughProperty("GroupBox11"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [AccessedThroughProperty("CenterInvSubTotal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox I;
        [AccessedThroughProperty("CenterDarAutoIncud"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox O;
        [AccessedThroughProperty("CenterDisAutoIncud"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox B;
        [AccessedThroughProperty("GroupBox12"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterInvSubTotalTXT"), CompilerGenerated]
        private TextBox O;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1")]
        private GroupBox G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label30")]
        private Label IR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("QRText"), CompilerGenerated]
        private TextBox B;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox7")]
        private GroupBox E;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterPointIFVal")]
        private TextBox S;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label31")]
        private Label DR;
        [AccessedThroughProperty("CenterIsViewDarTax"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox S;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CenterIsQRSDK")]
        private CheckBox Z;
        [AccessedThroughProperty("GroupBox13"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [AccessedThroughProperty("GroupBox14"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox U;
        [AccessedThroughProperty("TabPage11"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage E;
        [CompilerGenerated, AccessedThroughProperty("GroupBox26"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox L;
        [AccessedThroughProperty("CcMorID"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Z;
        [CompilerGenerated, AccessedThroughProperty("GroupBox25"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox N;
        [CompilerGenerated, AccessedThroughProperty("CcPostCode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox M;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox22")]
        private GroupBox V;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CcCountrySubentity")]
        private TextBox C;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox21"), CompilerGenerated]
        private GroupBox Y;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CcCityName")]
        private TextBox J;
        [AccessedThroughProperty("GroupBox20"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox O;
        [AccessedThroughProperty("CcCitySubdivisionName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox W;
        [CompilerGenerated, AccessedThroughProperty("GroupBox17"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox B;
        [AccessedThroughProperty("CcStreetName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox AR;
        [AccessedThroughProperty("GroupBox16"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox S;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CcSchemeID")]
        private TextBox PR;
        [AccessedThroughProperty("GroupBox18"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Z;
        [AccessedThroughProperty("CcBuildingNumber"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox QR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox15")]
        private GroupBox M;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox19")]
        private GroupBox C;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CcPlotIdentification")]
        private TextBox IR;
        [AccessedThroughProperty("CcSchemeTy"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonHelp")]
        private Button H;
        [AccessedThroughProperty("ButtonDisableSDK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button T;
        private bool A;
        private SqlConnection A;

        public BH()
        {
            base.Load += new EventHandler(this.Q);
            this.A = false;
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TabPage3 = new TabPage();
            this.GroupBox11 = new GroupBox();
            this.CenterInvSubTotal = new ComboBox();
            this.CenterDarAutoIncud = new CheckBox();
            this.GroupBox9 = new GroupBox();
            this.CenterDarVATNo = new TextBox();
            this.GroupBox2 = new GroupBox();
            this.CenterDarTXT = new TextBox();
            this.Label25 = new Label();
            this.GroupBox5 = new GroupBox();
            this.CenterDarType1 = new RadioButton();
            this.CenterDarType0 = new RadioButton();
            this.Label6 = new Label();
            this.CenterDarMaWi = new TextBox();
            this.TabPage4 = new TabPage();
            this.GroupBox7 = new GroupBox();
            this.CenterPointIFVal = new TextBox();
            this.Label31 = new Label();
            this.CenterDisAutoIncud = new CheckBox();
            this.Label11 = new Label();
            this.Label26 = new Label();
            this.CenterDisMaWi = new TextBox();
            this.GroupBox10 = new GroupBox();
            this.CenterDisTXT = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.Label27 = new Label();
            this.CenterDisIFMiWi = new TextBox();
            this.Label8 = new Label();
            this.CenterDisIFVAL = new TextBox();
            this.Label7 = new Label();
            this.TabPage5 = new TabPage();
            this.GroupBox14 = new GroupBox();
            this.CenterPhone = new TextBox();
            this.GroupBox13 = new GroupBox();
            this.CenterLocation = new TextBox();
            this.CenterIsViewDarTax = new CheckBox();
            this.GroupBox12 = new GroupBox();
            this.CenterInvSubTotalTXT = new TextBox();
            this.CenterInvIsViewMainName = new CheckBox();
            this.CenterInvIsViewDar = new CheckBox();
            this.CenterInvIsViewDis = new CheckBox();
            this.GroupBox3 = new GroupBox();
            this.CenterInvFotter = new TextBox();
            this.CenterInvIsViewBCode = new CheckBox();
            this.CenterInvIsViewCustomer = new CheckBox();
            this.CenterInvIsViwOtherCur = new CheckBox();
            this.CenterInvIsCustomerLast = new CheckBox();
            this.CenterInvIsViewSubNa = new CheckBox();
            this.CenterInvIsViewHedar = new CheckBox();
            this.CenterInvIsViewLogo = new CheckBox();
            this.GroupBox1 = new GroupBox();
            this.Label30 = new Label();
            this.QRText = new TextBox();
            this.CenterInvIsViewSigna = new CheckBox();
            this.CenterInvIsViewProft = new CheckBox();
            this.TabPage6 = new TabPage();
            this.GroupBox8 = new GroupBox();
            this.Label17 = new Label();
            this.Label13 = new Label();
            this.CenterMezanHalfOn = new ComboBox();
            this.CenterMezanType = new ComboBox();
            this.ButtonHelpBar = new Button();
            this.CenterIsMezan = new CheckBox();
            this.TabPage8 = new TabPage();
            this.Label28 = new Label();
            this.CenterMorFeeVALTaWasi = new TextBox();
            this.Label32 = new Label();
            this.Label21 = new Label();
            this.Label20 = new Label();
            this.CenterMorFeeVALDelivary = new TextBox();
            this.Label16 = new Label();
            this.Label15 = new Label();
            this.CenterMorFeeVALTable = new TextBox();
            this.CenterIsRestorentCafe = new CheckBox();
            this.ButtonResturntTabls = new Button();
            this.TabPage2 = new TabPage();
            this.ButtonLogoImag = new Button();
            this.CenterDecimelQuantity = new ComboBox();
            this.CenterDecimelPrince = new ComboBox();
            this.CenterCurrencyName = new TextBox();
            this.Label9 = new Label();
            this.Label2 = new Label();
            this.Label1 = new Label();
            this.CenterName = new Label();
            this.CenterSaleIsSaleeb = new CheckBox();
            this.TabPage1 = new TabPage();
            this.ButtonSaleSeet = new Button();
            this.CenterInvMAXMIX = new CheckBox();
            this.CenterSaleIsLoss = new CheckBox();
            this.CenterIsAllarmQQExip = new CheckBox();
            this.CenterSubName = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage13 = new TabPage();
            this.ButtonCurr = new Button();
            this.TabPage7 = new TabPage();
            this.ToolStripDelete = new ToolStrip();
            this.BDeletSame = new ToolStripDropDownButton();
            this.DTaMaterial = new ToolStripMenuItem();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.DTaSuplier = new ToolStripMenuItem();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.DTaCustomers = new ToolStripMenuItem();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.DTaInvSale = new ToolStripMenuItem();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.DTaExpenses = new ToolStripMenuItem();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.DTaInvPurch = new ToolStripMenuItem();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.DTaCash = new ToolStripMenuItem();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.ToolStripLabel2 = new ToolStripLabel();
            this.BDeleteAll = new ToolStripButton();
            this.TxTDDCenterNa = new Label();
            this.Label12 = new Label();
            this.Label14 = new Label();
            this.TabPage10 = new TabPage();
            this.GroupBox6 = new GroupBox();
            this.Label24 = new Label();
            this.Label23 = new Label();
            this.CenterMorFeeTaxMiaW = new TextBox();
            this.CenterMorFeeTaXName = new TextBox();
            this.Label22 = new Label();
            this.Label19 = new Label();
            this.CenterMorFeeVALCardPay = new TextBox();
            this.Label18 = new Label();
            this.TabPage9 = new TabPage();
            this.ButtonDisableSDK = new Button();
            this.CenterIsQRSDK = new CheckBox();
            this.TabPage11 = new TabPage();
            this.GroupBox19 = new GroupBox();
            this.CcPlotIdentification = new TextBox();
            this.GroupBox26 = new GroupBox();
            this.CcMorID = new TextBox();
            this.GroupBox25 = new GroupBox();
            this.CcPostCode = new TextBox();
            this.GroupBox22 = new GroupBox();
            this.CcCountrySubentity = new TextBox();
            this.GroupBox21 = new GroupBox();
            this.CcCityName = new TextBox();
            this.GroupBox20 = new GroupBox();
            this.CcCitySubdivisionName = new TextBox();
            this.GroupBox17 = new GroupBox();
            this.CcStreetName = new TextBox();
            this.GroupBox16 = new GroupBox();
            this.CcSchemeID = new TextBox();
            this.GroupBox18 = new GroupBox();
            this.CcBuildingNumber = new TextBox();
            this.GroupBox15 = new GroupBox();
            this.ButtonHelp = new Button();
            this.CcSchemeTy = new ComboBox();
            this.Label10 = new Label();
            this.CenterDarType = new TextBox();
            this.ButtonClose = new Button();
            this.ButtonOk = new Button();
            this.TabPage3.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.TabPage8.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage13.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.ToolStripDelete.SuspendLayout();
            this.TabPage10.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.TabPage9.SuspendLayout();
            this.TabPage11.SuspendLayout();
            this.GroupBox19.SuspendLayout();
            this.GroupBox26.SuspendLayout();
            this.GroupBox25.SuspendLayout();
            this.GroupBox22.SuspendLayout();
            this.GroupBox21.SuspendLayout();
            this.GroupBox20.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox18.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            base.SuspendLayout();
            this.TabPage3.BackColor = Color.White;
            this.TabPage3.Controls.Add(this.GroupBox11);
            this.TabPage3.Controls.Add(this.CenterDarAutoIncud);
            this.TabPage3.Controls.Add(this.GroupBox9);
            this.TabPage3.Controls.Add(this.GroupBox2);
            this.TabPage3.Controls.Add(this.Label25);
            this.TabPage3.Controls.Add(this.GroupBox5);
            this.TabPage3.Controls.Add(this.Label6);
            this.TabPage3.Controls.Add(this.CenterDarMaWi);
            this.TabPage3.Location = new Point(4, 0x2e);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x32b, 0x194);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "الضريبة";
            this.GroupBox11.Controls.Add(this.CenterInvSubTotal);
            this.GroupBox11.Location = new Point(8, 0x145);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(770, 0x3a);
            this.GroupBox11.TabIndex = 60;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "طريقة التعامل مع المجموع الفرعي للفاتورة";
            this.CenterInvSubTotal.Dock = DockStyle.Top;
            this.CenterInvSubTotal.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CenterInvSubTotal.FormattingEnabled = true;
            object[] items = new object[] { "طريقة افتراضية، احسب المجموع الفرعي للمواد فقط بدون خصم مبلغ الضريبة او مبلغ الخصم (مستحسن)", "خصم مبلغ الضريبة من الاسعار واستخراج اصل المبلغ قبل الضريبة، عندما تكون الاسعار شاملة الضريبة" };
            this.CenterInvSubTotal.Items.AddRange(items);
            this.CenterInvSubTotal.Location = new Point(3, 0x13);
            this.CenterInvSubTotal.Name = "CenterInvSubTotal";
            this.CenterInvSubTotal.Size = new Size(0x2fc, 0x18);
            this.CenterInvSubTotal.TabIndex = 0;
            this.CenterDarAutoIncud.Location = new Point(9, 0x95);
            this.CenterDarAutoIncud.Name = "CenterDarAutoIncud";
            this.CenterDarAutoIncud.Size = new Size(0x2fb, 0x2e);
            this.CenterDarAutoIncud.TabIndex = 0x3d;
            this.CenterDarAutoIncud.Text = "بشكل افتراضي، احسب نسبة الضريبة الثابتة للمواد التي لا يوجد لها نسبة خاصة في إظهار صافي السعر.(صانع الباركود، الاستعلام، نموذج عرض الأسعار،.... الخ)";
            this.CenterDarAutoIncud.UseVisualStyleBackColor = true;
            this.GroupBox9.Controls.Add(this.CenterDarVATNo);
            this.GroupBox9.Location = new Point(0x17d, 210);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x18a, 0x35);
            this.GroupBox9.TabIndex = 0x3b;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "الرقم الضريبي";
            this.CenterDarVATNo.Dock = DockStyle.Top;
            this.CenterDarVATNo.Location = new Point(3, 0x13);
            this.CenterDarVATNo.MaxLength = 500;
            this.CenterDarVATNo.Name = "CenterDarVATNo";
            this.CenterDarVATNo.Size = new Size(0x184, 0x17);
            this.CenterDarVATNo.TabIndex = 0x2f;
            this.CenterDarVATNo.TextAlign = HorizontalAlignment.Center;
            this.GroupBox2.Controls.Add(this.CenterDarTXT);
            this.GroupBox2.Location = new Point(8, 210);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(370, 0x56);
            this.GroupBox2.TabIndex = 0x3a;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "نص يظهر عند الضريبة في الفاتورة المطبوعة:";
            this.CenterDarTXT.Dock = DockStyle.Fill;
            this.CenterDarTXT.Location = new Point(3, 0x13);
            this.CenterDarTXT.MaxLength = 500;
            this.CenterDarTXT.Multiline = true;
            this.CenterDarTXT.Name = "CenterDarTXT";
            this.CenterDarTXT.RightToLeft = RightToLeft.No;
            this.CenterDarTXT.Size = new Size(0x16c, 0x40);
            this.CenterDarTXT.TabIndex = 0x38;
            this.CenterDarTXT.TextAlign = HorizontalAlignment.Center;
            this.Label25.AutoSize = true;
            this.Label25.ForeColor = Color.Red;
            this.Label25.Location = new Point(0x178, 0x74);
            this.Label25.Name = "Label25";
            this.Label25.Size = new Size(20, 0x10);
            this.Label25.TabIndex = 0x34;
            this.Label25.Text = "%";
            this.GroupBox5.Controls.Add(this.CenterDarType1);
            this.GroupBox5.Controls.Add(this.CenterDarType0);
            this.GroupBox5.Location = new Point(7, 0x11);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(770, 80);
            this.GroupBox5.TabIndex = 0x33;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "طريقة احتساب الضريبة";
            this.CenterDarType1.AutoSize = true;
            this.CenterDarType1.Location = new Point(0x69, 0x30);
            this.CenterDarType1.Name = "CenterDarType1";
            this.CenterDarType1.Size = new Size(0x266, 20);
            this.CenterDarType1.TabIndex = 2;
            this.CenterDarType1.TabStop = true;
            this.CenterDarType1.Text = "اسعار البيع شاملة الضريبة، لا تجمع قيمة الضريبة مع صافي الفاتورة. استخراج اصل قيمة الفاتورة في الاجمالي";
            this.CenterDarType1.UseVisualStyleBackColor = true;
            this.CenterDarType0.AutoSize = true;
            this.CenterDarType0.Location = new Point(290, 0x16);
            this.CenterDarType0.Name = "CenterDarType0";
            this.CenterDarType0.Size = new Size(0x1ad, 20);
            this.CenterDarType0.TabIndex = 0;
            this.CenterDarType0.TabStop = true;
            this.CenterDarType0.Text = "اسعار البيع غير شاملة الضريبة، اجمع قيمة الضريبة مع صافي قيمة الفاتورة.";
            this.CenterDarType0.UseVisualStyleBackColor = true;
            this.Label6.AutoSize = true;
            this.Label6.Location = new Point(0x217, 0x74);
            this.Label6.Name = "Label6";
            this.Label6.Size = new Size(0xef, 0x10);
            this.Label6.TabIndex = 0x31;
            this.Label6.Text = "نسبة الضريبة الثابتة على اجمالي الفاتورة:";
            this.CenterDarMaWi.Location = new Point(0x192, 0x71);
            this.CenterDarMaWi.MaxLength = 5;
            this.CenterDarMaWi.Name = "CenterDarMaWi";
            this.CenterDarMaWi.RightToLeft = RightToLeft.No;
            this.CenterDarMaWi.Size = new Size(0x7f, 0x17);
            this.CenterDarMaWi.TabIndex = 0x1f;
            this.CenterDarMaWi.TextAlign = HorizontalAlignment.Center;
            this.TabPage4.BackColor = Color.White;
            this.TabPage4.Controls.Add(this.GroupBox7);
            this.TabPage4.Controls.Add(this.CenterDisAutoIncud);
            this.TabPage4.Controls.Add(this.Label11);
            this.TabPage4.Controls.Add(this.Label26);
            this.TabPage4.Controls.Add(this.CenterDisMaWi);
            this.TabPage4.Controls.Add(this.GroupBox10);
            this.TabPage4.Controls.Add(this.GroupBox4);
            this.TabPage4.Location = new Point(4, 0x2e);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x32b, 0x194);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "الخصم";
            this.GroupBox7.Controls.Add(this.CenterPointIFVal);
            this.GroupBox7.Controls.Add(this.Label31);
            this.GroupBox7.Location = new Point(0x12, 0x12d);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x2ef, 0x51);
            this.GroupBox7.TabIndex = 0x40;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "نقاط المكافأت ";
            this.CenterPointIFVal.Location = new Point(0xdf, 0x27);
            this.CenterPointIFVal.MaxLength = 20;
            this.CenterPointIFVal.Name = "CenterPointIFVal";
            this.CenterPointIFVal.RightToLeft = RightToLeft.No;
            this.CenterPointIFVal.Size = new Size(0x97, 0x17);
            this.CenterPointIFVal.TabIndex = 0x37;
            this.CenterPointIFVal.TextAlign = HorizontalAlignment.Center;
            this.Label31.AutoSize = true;
            this.Label31.Location = new Point(380, 0x2a);
            this.Label31.Name = "Label31";
            this.Label31.Size = new Size(0x166, 0x10);
            this.Label31.TabIndex = 0x36;
            this.Label31.Text = "احسب نقطة للعميل عندما تكون قيمة الفاتورة اكبر او تساوي من:";
            this.CenterDisAutoIncud.Location = new Point(13, 0x9b);
            this.CenterDisAutoIncud.Name = "CenterDisAutoIncud";
            this.CenterDisAutoIncud.Size = new Size(0x2f4, 0x2e);
            this.CenterDisAutoIncud.TabIndex = 0x3e;
            this.CenterDisAutoIncud.Text = "بشكل افتراضي، احسب نسبة الخصم الثابتة للمواد التي لا يوجد لها نسبة خاصة في إظهار صافي السعر.(صانع الباركود، الاستعلام، نموذج عرض الأسعار،.... الخ)";
            this.CenterDisAutoIncud.UseVisualStyleBackColor = true;
            this.Label11.AutoSize = true;
            this.Label11.Location = new Point(0x214, 0x37);
            this.Label11.Name = "Label11";
            this.Label11.Size = new Size(240, 0x10);
            this.Label11.TabIndex = 0x3a;
            this.Label11.Text = "نسبة الخصم الثابتة على اجمالي الفاتورة :";
            this.Label26.AutoSize = true;
            this.Label26.ForeColor = Color.Red;
            this.Label26.Location = new Point(0x174, 0x37);
            this.Label26.Name = "Label26";
            this.Label26.Size = new Size(20, 0x10);
            this.Label26.TabIndex = 0x35;
            this.Label26.Text = "%";
            this.CenterDisMaWi.Location = new Point(0x18e, 0x34);
            this.CenterDisMaWi.MaxLength = 5;
            this.CenterDisMaWi.Name = "CenterDisMaWi";
            this.CenterDisMaWi.RightToLeft = RightToLeft.No;
            this.CenterDisMaWi.Size = new Size(0x80, 0x17);
            this.CenterDisMaWi.TabIndex = 0x20;
            this.CenterDisMaWi.TextAlign = HorizontalAlignment.Center;
            this.GroupBox10.Controls.Add(this.CenterDisTXT);
            this.GroupBox10.Location = new Point(0x15, 0x24);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x141, 100);
            this.GroupBox10.TabIndex = 0x38;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "نص يظهر عند الخصم في الفاتورة المطبوعة:";
            this.CenterDisTXT.Dock = DockStyle.Fill;
            this.CenterDisTXT.Location = new Point(3, 0x13);
            this.CenterDisTXT.MaxLength = 500;
            this.CenterDisTXT.Multiline = true;
            this.CenterDisTXT.Name = "CenterDisTXT";
            this.CenterDisTXT.RightToLeft = RightToLeft.No;
            this.CenterDisTXT.Size = new Size(0x13b, 0x4e);
            this.CenterDisTXT.TabIndex = 0x36;
            this.CenterDisTXT.TextAlign = HorizontalAlignment.Center;
            this.GroupBox4.Controls.Add(this.Label27);
            this.GroupBox4.Controls.Add(this.CenterDisIFMiWi);
            this.GroupBox4.Controls.Add(this.Label8);
            this.GroupBox4.Controls.Add(this.CenterDisIFVAL);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Location = new Point(0x12, 0xd8);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x2ef, 0x4b);
            this.GroupBox4.TabIndex = 0x34;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "الخصم المشروط - التلقائي";
            this.Label27.AutoSize = true;
            this.Label27.ForeColor = Color.Red;
            this.Label27.Location = new Point(20, 0x23);
            this.Label27.Name = "Label27";
            this.Label27.Size = new Size(20, 0x10);
            this.Label27.TabIndex = 0x38;
            this.Label27.Text = "%";
            this.CenterDisIFMiWi.Location = new Point(0x2e, 0x20);
            this.CenterDisIFMiWi.MaxLength = 5;
            this.CenterDisIFMiWi.Name = "CenterDisIFMiWi";
            this.CenterDisIFMiWi.RightToLeft = RightToLeft.No;
            this.CenterDisIFMiWi.Size = new Size(0x4b, 0x17);
            this.CenterDisIFMiWi.TabIndex = 0x37;
            this.CenterDisIFMiWi.TextAlign = HorizontalAlignment.Center;
            this.Label8.AutoSize = true;
            this.Label8.Location = new Point(0x76, 0x23);
            this.Label8.Name = "Label8";
            this.Label8.Size = new Size(0xc0, 0x10);
            this.Label8.TabIndex = 0x36;
            this.Label8.Text = "اضف خصم بشكل تلقائي بنسبة: ";
            this.CenterDisIFVAL.Location = new Point(0x151, 0x20);
            this.CenterDisIFVAL.MaxLength = 20;
            this.CenterDisIFVAL.Name = "CenterDisIFVAL";
            this.CenterDisIFVAL.RightToLeft = RightToLeft.No;
            this.CenterDisIFVAL.Size = new Size(0x97, 0x17);
            this.CenterDisIFVAL.TabIndex = 0x35;
            this.CenterDisIFVAL.TextAlign = HorizontalAlignment.Center;
            this.Label7.AutoSize = true;
            this.Label7.Location = new Point(0x1ee, 0x23);
            this.Label7.Name = "Label7";
            this.Label7.Size = new Size(0xdf, 0x10);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "في حال كان مبلغ الفاتورة اكبر او تساوي";
            this.TabPage5.BackColor = Color.White;
            this.TabPage5.Controls.Add(this.GroupBox14);
            this.TabPage5.Controls.Add(this.GroupBox13);
            this.TabPage5.Controls.Add(this.CenterIsViewDarTax);
            this.TabPage5.Controls.Add(this.GroupBox12);
            this.TabPage5.Controls.Add(this.CenterInvIsViewMainName);
            this.TabPage5.Controls.Add(this.CenterInvIsViewDar);
            this.TabPage5.Controls.Add(this.CenterInvIsViewDis);
            this.TabPage5.Controls.Add(this.GroupBox3);
            this.TabPage5.Controls.Add(this.CenterInvIsViewBCode);
            this.TabPage5.Controls.Add(this.CenterInvIsViewCustomer);
            this.TabPage5.Controls.Add(this.CenterInvIsViwOtherCur);
            this.TabPage5.Controls.Add(this.CenterInvIsCustomerLast);
            this.TabPage5.Controls.Add(this.CenterInvIsViewSubNa);
            this.TabPage5.Controls.Add(this.CenterInvIsViewHedar);
            this.TabPage5.Controls.Add(this.CenterInvIsViewLogo);
            this.TabPage5.Location = new Point(4, 0x2e);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new Size(0x32b, 0x194);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "تصميم طباعة الفواتير";
            this.GroupBox14.Controls.Add(this.CenterPhone);
            this.GroupBox14.Location = new Point(0x11, 0x10);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0x16c, 0x36);
            this.GroupBox14.TabIndex = 0x2b;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "رقم الهاتف";
            this.CenterPhone.Dock = DockStyle.Fill;
            this.CenterPhone.Location = new Point(3, 0x13);
            this.CenterPhone.MaxLength = 50;
            this.CenterPhone.Name = "CenterPhone";
            this.CenterPhone.Size = new Size(0x166, 0x17);
            this.CenterPhone.TabIndex = 30;
            this.CenterPhone.TextAlign = HorizontalAlignment.Center;
            this.GroupBox13.Controls.Add(this.CenterLocation);
            this.GroupBox13.Location = new Point(0x11, 0x4c);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x16c, 0x7c);
            this.GroupBox13.TabIndex = 0x2b;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "العنوان";
            this.CenterLocation.Dock = DockStyle.Fill;
            this.CenterLocation.Location = new Point(3, 0x13);
            this.CenterLocation.MaxLength = 500;
            this.CenterLocation.Multiline = true;
            this.CenterLocation.Name = "CenterLocation";
            this.CenterLocation.Size = new Size(0x166, 0x66);
            this.CenterLocation.TabIndex = 0x1d;
            this.CenterLocation.TextAlign = HorizontalAlignment.Center;
            this.CenterIsViewDarTax.AutoSize = true;
            this.CenterIsViewDarTax.Location = new Point(0x266, 0x80);
            this.CenterIsViewDarTax.Name = "CenterIsViewDarTax";
            this.CenterIsViewDarTax.RightToLeft = RightToLeft.Yes;
            this.CenterIsViewDarTax.Size = new Size(0x89, 20);
            this.CenterIsViewDarTax.TabIndex = 0x4c;
            this.CenterIsViewDarTax.Text = "عرض الرقم الضريبي ";
            this.CenterIsViewDarTax.UseVisualStyleBackColor = true;
            this.GroupBox12.Controls.Add(this.CenterInvSubTotalTXT);
            this.GroupBox12.ForeColor = SystemColors.AppWorkspace;
            this.GroupBox12.Location = new Point(0x11, 0x147);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x16c, 0x31);
            this.GroupBox12.TabIndex = 0x4a;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "عبارة تظهر عند المجموع الفرعي في طباعة الفواتير:";
            this.GroupBox12.Visible = false;
            this.CenterInvSubTotalTXT.Dock = DockStyle.Top;
            this.CenterInvSubTotalTXT.Location = new Point(3, 0x13);
            this.CenterInvSubTotalTXT.MaxLength = 50;
            this.CenterInvSubTotalTXT.Name = "CenterInvSubTotalTXT";
            this.CenterInvSubTotalTXT.Size = new Size(0x166, 0x17);
            this.CenterInvSubTotalTXT.TabIndex = 0x49;
            this.CenterInvSubTotalTXT.TextAlign = HorizontalAlignment.Center;
            this.CenterInvIsViewMainName.AutoSize = true;
            this.CenterInvIsViewMainName.Location = new Point(0x241, 0x4c);
            this.CenterInvIsViewMainName.Name = "CenterInvIsViewMainName";
            this.CenterInvIsViewMainName.Size = new Size(0xae, 20);
            this.CenterInvIsViewMainName.TabIndex = 70;
            this.CenterInvIsViewMainName.Text = "عرض اسم المتجر الرئيسي";
            this.CenterInvIsViewMainName.UseVisualStyleBackColor = true;
            this.CenterInvIsViewDar.AutoSize = true;
            this.CenterInvIsViewDar.Location = new Point(0x24c, 0x11b);
            this.CenterInvIsViewDar.Name = "CenterInvIsViewDar";
            this.CenterInvIsViewDar.RightToLeft = RightToLeft.Yes;
            this.CenterInvIsViewDar.Size = new Size(0xa3, 20);
            this.CenterInvIsViewDar.TabIndex = 0x44;
            this.CenterInvIsViewDar.Text = "عرض حيز تفاصيل الضريبة";
            this.CenterInvIsViewDar.UseVisualStyleBackColor = true;
            this.CenterInvIsViewDis.AutoSize = true;
            this.CenterInvIsViewDis.Location = new Point(0x24f, 0x101);
            this.CenterInvIsViewDis.Name = "CenterInvIsViewDis";
            this.CenterInvIsViewDis.RightToLeft = RightToLeft.Yes;
            this.CenterInvIsViewDis.Size = new Size(160, 20);
            this.CenterInvIsViewDis.TabIndex = 0x43;
            this.CenterInvIsViewDis.Text = "عرض حيز تفاصيل الخصم";
            this.CenterInvIsViewDis.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.CenterInvFotter);
            this.GroupBox3.Location = new Point(0x11, 0xce);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x16c, 0x73);
            this.GroupBox3.TabIndex = 0x42;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "عبارة اسفل الفاتورة:";
            this.CenterInvFotter.Dock = DockStyle.Fill;
            this.CenterInvFotter.Location = new Point(3, 0x13);
            this.CenterInvFotter.MaxLength = 0x2710;
            this.CenterInvFotter.Multiline = true;
            this.CenterInvFotter.Name = "CenterInvFotter";
            this.CenterInvFotter.Size = new Size(0x166, 0x5d);
            this.CenterInvFotter.TabIndex = 0x21;
            this.CenterInvFotter.TextAlign = HorizontalAlignment.Center;
            this.CenterInvIsViewBCode.AutoSize = true;
            this.CenterInvIsViewBCode.Location = new Point(550, 180);
            this.CenterInvIsViewBCode.Name = "CenterInvIsViewBCode";
            this.CenterInvIsViewBCode.RightToLeft = RightToLeft.Yes;
            this.CenterInvIsViewBCode.Size = new Size(0xc9, 20);
            this.CenterInvIsViewBCode.TabIndex = 0x41;
            this.CenterInvIsViewBCode.Text = "عرض ترميز الفاتورة كصيغة باركود";
            this.CenterInvIsViewBCode.UseVisualStyleBackColor = true;
            this.CenterInvIsViewCustomer.AutoSize = true;
            this.CenterInvIsViewCustomer.Location = new Point(0x256, 0xce);
            this.CenterInvIsViewCustomer.Name = "CenterInvIsViewCustomer";
            this.CenterInvIsViewCustomer.RightToLeft = RightToLeft.Yes;
            this.CenterInvIsViewCustomer.Size = new Size(0x99, 20);
            this.CenterInvIsViewCustomer.TabIndex = 0x40;
            this.CenterInvIsViewCustomer.Text = "عرض حيز بيانات العميل";
            this.CenterInvIsViewCustomer.UseVisualStyleBackColor = true;
            this.CenterInvIsViwOtherCur.AutoSize = true;
            this.CenterInvIsViwOtherCur.Location = new Point(0x1da, 0x9a);
            this.CenterInvIsViwOtherCur.Name = "CenterInvIsViwOtherCur";
            this.CenterInvIsViwOtherCur.Size = new Size(0x115, 20);
            this.CenterInvIsViwOtherCur.TabIndex = 0x3e;
            this.CenterInvIsViwOtherCur.Text = "عرض بند العملات الاخرى المدفوعة في الفاتورة";
            this.CenterInvIsViwOtherCur.UseVisualStyleBackColor = true;
            this.CenterInvIsCustomerLast.AutoSize = true;
            this.CenterInvIsCustomerLast.Location = new Point(0x1f8, 0xe8);
            this.CenterInvIsCustomerLast.Name = "CenterInvIsCustomerLast";
            this.CenterInvIsCustomerLast.Size = new Size(0xf7, 20);
            this.CenterInvIsCustomerLast.TabIndex = 0x3d;
            this.CenterInvIsCustomerLast.Text = "عرض الرصيد السابق  (ذمم) على العميل";
            this.CenterInvIsCustomerLast.UseVisualStyleBackColor = true;
            this.CenterInvIsViewSubNa.AutoSize = true;
            this.CenterInvIsViewSubNa.Location = new Point(0x241, 0x66);
            this.CenterInvIsViewSubNa.Name = "CenterInvIsViewSubNa";
            this.CenterInvIsViewSubNa.Size = new Size(0xae, 20);
            this.CenterInvIsViewSubNa.TabIndex = 60;
            this.CenterInvIsViewSubNa.Text = "عرض اسم الفرع/المستودع";
            this.CenterInvIsViewSubNa.UseVisualStyleBackColor = true;
            this.CenterInvIsViewHedar.AutoSize = true;
            this.CenterInvIsViewHedar.ForeColor = Color.DarkGreen;
            this.CenterInvIsViewHedar.Location = new Point(0x21d, 0x15);
            this.CenterInvIsViewHedar.Name = "CenterInvIsViewHedar";
            this.CenterInvIsViewHedar.RightToLeft = RightToLeft.Yes;
            this.CenterInvIsViewHedar.Size = new Size(210, 20);
            this.CenterInvIsViewHedar.TabIndex = 0x33;
            this.CenterInvIsViewHedar.Text = "عرض صورة الترويسه على الفاتورة";
            this.CenterInvIsViewHedar.UseVisualStyleBackColor = true;
            this.CenterInvIsViewLogo.AutoSize = true;
            this.CenterInvIsViewLogo.ForeColor = Color.DarkGreen;
            this.CenterInvIsViewLogo.Location = new Point(0x228, 0x30);
            this.CenterInvIsViewLogo.Name = "CenterInvIsViewLogo";
            this.CenterInvIsViewLogo.RightToLeft = RightToLeft.Yes;
            this.CenterInvIsViewLogo.Size = new Size(0xc7, 20);
            this.CenterInvIsViewLogo.TabIndex = 50;
            this.CenterInvIsViewLogo.Text = "عرض صورة الشعار على الفاتورة";
            this.CenterInvIsViewLogo.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.Label30);
            this.GroupBox1.Controls.Add(this.QRText);
            this.GroupBox1.ForeColor = SystemColors.ControlDarkDark;
            this.GroupBox1.Location = new Point(0x180, 120);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x16c, 0x3b);
            this.GroupBox1.TabIndex = 0x4b;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "رمز الاستجابة السريع QR";
            this.Label30.AutoSize = true;
            this.Label30.Location = new Point(0x103, 0x19);
            this.Label30.Name = "Label30";
            this.Label30.Size = new Size(0x4e, 0x10);
            this.Label30.TabIndex = 0x4a;
            this.Label30.Text = "يحتوي على:";
            this.QRText.Location = new Point(6, 0x16);
            this.QRText.MaxLength = 50;
            this.QRText.Name = "QRText";
            this.QRText.Size = new Size(0xf7, 0x17);
            this.QRText.TabIndex = 0x49;
            this.QRText.TextAlign = HorizontalAlignment.Center;
            this.CenterInvIsViewSigna.AutoSize = true;
            this.CenterInvIsViewSigna.Location = new Point(0x180, 0x2b);
            this.CenterInvIsViewSigna.Name = "CenterInvIsViewSigna";
            this.CenterInvIsViewSigna.RightToLeft = RightToLeft.Yes;
            this.CenterInvIsViewSigna.Size = new Size(360, 20);
            this.CenterInvIsViewSigna.TabIndex = 0x47;
            this.CenterInvIsViewSigna.Text = "عرض صورة التوقيع والتوقيع الرقمي | او QR عند طباعة الفاتورة";
            this.CenterInvIsViewSigna.UseVisualStyleBackColor = true;
            this.CenterInvIsViewProft.AutoSize = true;
            this.CenterInvIsViewProft.Location = new Point(0x15d, 0xe1);
            this.CenterInvIsViewProft.Name = "CenterInvIsViewProft";
            this.CenterInvIsViewProft.RightToLeft = RightToLeft.Yes;
            this.CenterInvIsViewProft.Size = new Size(0x18f, 20);
            this.CenterInvIsViewProft.TabIndex = 0x30;
            this.CenterInvIsViewProft.Text = "عرض بند الارباح في قوائم المبيعات وسجل البيع في القوائم المطبوعة";
            this.CenterInvIsViewProft.UseVisualStyleBackColor = true;
            this.TabPage6.BackColor = Color.White;
            this.TabPage6.Controls.Add(this.GroupBox8);
            this.TabPage6.Controls.Add(this.CenterMezanType);
            this.TabPage6.Controls.Add(this.ButtonHelpBar);
            this.TabPage6.Controls.Add(this.CenterIsMezan);
            this.TabPage6.Location = new Point(4, 0x2e);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Size = new Size(0x32b, 0x194);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "الميزان الالكتروني";
            this.GroupBox8.Controls.Add(this.Label17);
            this.GroupBox8.Controls.Add(this.Label13);
            this.GroupBox8.Controls.Add(this.CenterMezanHalfOn);
            this.GroupBox8.Location = new Point(0x22, 0x73);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x2ae, 0x6d);
            this.GroupBox8.TabIndex = 0x33;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "عدد الارقام العشرية التي تظهر في الوزن/السعر على الملصق، الشكل الافتراضي 0.000 ";
            this.Label17.ForeColor = SystemColors.AppWorkspace;
            this.Label17.Location = new Point(0x4e, 0x24);
            this.Label17.Name = "Label17";
            this.Label17.Size = new Size(0x149, 0x38);
            this.Label17.TabIndex = 2;
            this.Label17.Text = "القسمة على 1 بدون ارقام عشرية\r\nالقسمة على 100 الارقام العشرية 0.00\r\nالقسمة على 1000 الارقام العشرية 0.000";
            this.Label13.AutoSize = true;
            this.Label13.Location = new Point(0x250, 0x27);
            this.Label13.Name = "Label13";
            this.Label13.Size = new Size(0x56, 0x10);
            this.Label13.TabIndex = 1;
            this.Label13.Text = "القسمة على:";
            this.CenterMezanHalfOn.FormattingEnabled = true;
            object[] objArray2 = new object[] { "1", "100", "1000" };
            this.CenterMezanHalfOn.Items.AddRange(objArray2);
            this.CenterMezanHalfOn.Location = new Point(0x1af, 0x24);
            this.CenterMezanHalfOn.Name = "CenterMezanHalfOn";
            this.CenterMezanHalfOn.Size = new Size(0x9b, 0x18);
            this.CenterMezanHalfOn.TabIndex = 0;
            this.CenterMezanType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CenterMezanType.FormattingEnabled = true;
            object[] objArray3 = new object[] { "معالجة ملصقات الباركود التي تطبع السعر", "معالجة ملصقات الباركود التي تطبع الوزن" };
            this.CenterMezanType.Items.AddRange(objArray3);
            this.CenterMezanType.Location = new Point(0x155, 0x48);
            this.CenterMezanType.Name = "CenterMezanType";
            this.CenterMezanType.Size = new Size(0x167, 0x18);
            this.CenterMezanType.TabIndex = 0x31;
            this.ButtonHelpBar.FlatAppearance.BorderColor = Color.Green;
            this.ButtonHelpBar.FlatStyle = FlatStyle.Flat;
            this.ButtonHelpBar.Image = A.F.ImHelp;
            this.ButtonHelpBar.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonHelpBar.Location = new Point(14, 0xf3);
            this.ButtonHelpBar.Name = "ButtonHelpBar";
            this.ButtonHelpBar.Size = new Size(0x2e1, 0x36);
            this.ButtonHelpBar.TabIndex = 50;
            this.ButtonHelpBar.Text = "شرح طريقة ربط ملصقات الميزان مع المواد في المستودع";
            this.ButtonHelpBar.UseVisualStyleBackColor = true;
            this.CenterIsMezan.AutoSize = true;
            this.CenterIsMezan.Location = new Point(0x1b0, 0x25);
            this.CenterIsMezan.Name = "CenterIsMezan";
            this.CenterIsMezan.RightToLeft = RightToLeft.Yes;
            this.CenterIsMezan.Size = new Size(0x10c, 20);
            this.CenterIsMezan.TabIndex = 0x30;
            this.CenterIsMezan.Text = "تفعيل قراءة ملصقات باركود الميزان الالكتروني";
            this.CenterIsMezan.UseVisualStyleBackColor = true;
            this.TabPage8.BackColor = Color.White;
            this.TabPage8.Controls.Add(this.Label28);
            this.TabPage8.Controls.Add(this.CenterMorFeeVALTaWasi);
            this.TabPage8.Controls.Add(this.Label32);
            this.TabPage8.Controls.Add(this.Label21);
            this.TabPage8.Controls.Add(this.Label20);
            this.TabPage8.Controls.Add(this.CenterMorFeeVALDelivary);
            this.TabPage8.Controls.Add(this.Label16);
            this.TabPage8.Controls.Add(this.Label15);
            this.TabPage8.Controls.Add(this.CenterMorFeeVALTable);
            this.TabPage8.Controls.Add(this.CenterIsRestorentCafe);
            this.TabPage8.Controls.Add(this.ButtonResturntTabls);
            this.TabPage8.Location = new Point(4, 0x2e);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Size = new Size(0x32b, 0x194);
            this.TabPage8.TabIndex = 7;
            this.TabPage8.Text = "التحويل لنظام مطاعم وحجز طاولات";
            this.Label28.AutoSize = true;
            this.Label28.ForeColor = Color.Red;
            this.Label28.Location = new Point(0x80, 0xd3);
            this.Label28.Name = "Label28";
            this.Label28.Size = new Size(20, 0x10);
            this.Label28.TabIndex = 0x39;
            this.Label28.Text = "%";
            this.CenterMorFeeVALTaWasi.Location = new Point(0x9a, 0xcc);
            this.CenterMorFeeVALTaWasi.MaxLength = 4;
            this.CenterMorFeeVALTaWasi.Name = "CenterMorFeeVALTaWasi";
            this.CenterMorFeeVALTaWasi.RightToLeft = RightToLeft.No;
            this.CenterMorFeeVALTaWasi.Size = new Size(0xbc, 0x17);
            this.CenterMorFeeVALTaWasi.TabIndex = 0x38;
            this.CenterMorFeeVALTaWasi.TextAlign = HorizontalAlignment.Center;
            this.Label32.AutoSize = true;
            this.Label32.Location = new Point(0x165, 0xcc);
            this.Label32.Name = "Label32";
            this.Label32.Size = new Size(0x180, 0x10);
            this.Label32.TabIndex = 0x37;
            this.Label32.Text = "عند تواصي الطلب قم بإضافة عمولة بدل تواصي بشكل تلقائي بنسبة:";
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = Color.Red;
            this.Label21.Location = new Point(0x80, 180);
            this.Label21.Name = "Label21";
            this.Label21.Size = new Size(20, 0x10);
            this.Label21.TabIndex = 50;
            this.Label21.Text = "%";
            this.Label20.AutoSize = true;
            this.Label20.ForeColor = Color.Red;
            this.Label20.Location = new Point(0x80, 0x93);
            this.Label20.Name = "Label20";
            this.Label20.Size = new Size(20, 0x10);
            this.Label20.TabIndex = 0x31;
            this.Label20.Text = "%";
            this.CenterMorFeeVALDelivary.Location = new Point(0x9a, 0xad);
            this.CenterMorFeeVALDelivary.MaxLength = 4;
            this.CenterMorFeeVALDelivary.Name = "CenterMorFeeVALDelivary";
            this.CenterMorFeeVALDelivary.RightToLeft = RightToLeft.No;
            this.CenterMorFeeVALDelivary.Size = new Size(0xbc, 0x17);
            this.CenterMorFeeVALDelivary.TabIndex = 0x2e;
            this.CenterMorFeeVALDelivary.TextAlign = HorizontalAlignment.Center;
            this.Label16.AutoSize = true;
            this.Label16.Location = new Point(0x165, 0xad);
            this.Label16.Name = "Label16";
            this.Label16.Size = new Size(380, 0x10);
            this.Label16.TabIndex = 0x2d;
            this.Label16.Text = "عند توصيل الطلب قم بإضافة عمولة بدل توصيل بشكل تلقائي بنسبة:";
            this.Label15.AutoSize = true;
            this.Label15.Location = new Point(0x165, 0x90);
            this.Label15.Name = "Label15";
            this.Label15.Size = new Size(0x18c, 0x10);
            this.Label15.TabIndex = 0x2c;
            this.Label15.Text = "عند حجز الطاولة قم بإضافة عمولة بدل حجز/خدمة بشكل تلقائي بنسبة:";
            this.CenterMorFeeVALTable.Location = new Point(0x9a, 0x90);
            this.CenterMorFeeVALTable.MaxLength = 4;
            this.CenterMorFeeVALTable.Name = "CenterMorFeeVALTable";
            this.CenterMorFeeVALTable.RightToLeft = RightToLeft.No;
            this.CenterMorFeeVALTable.Size = new Size(0xbc, 0x17);
            this.CenterMorFeeVALTable.TabIndex = 0x2b;
            this.CenterMorFeeVALTable.TextAlign = HorizontalAlignment.Center;
            this.CenterIsRestorentCafe.AutoSize = true;
            this.CenterIsRestorentCafe.Location = new Point(0x15c, 0x18);
            this.CenterIsRestorentCafe.Name = "CenterIsRestorentCafe";
            this.CenterIsRestorentCafe.Size = new Size(0x197, 20);
            this.CenterIsRestorentCafe.TabIndex = 0;
            this.CenterIsRestorentCafe.Text = "تحويل هذا النظام ليتناسب مع نظام المطاعم، وحجوزات الطاولات/الغرف";
            this.CenterIsRestorentCafe.UseVisualStyleBackColor = true;
            this.ButtonResturntTabls.FlatAppearance.BorderColor = Color.Green;
            this.ButtonResturntTabls.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonResturntTabls.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonResturntTabls.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonResturntTabls.FlatStyle = FlatStyle.Flat;
            this.ButtonResturntTabls.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonResturntTabls.Image = A.F.ImResturntTable;
            this.ButtonResturntTabls.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonResturntTabls.Location = new Point(0x178, 0x41);
            this.ButtonResturntTabls.Margin = new Padding(3, 4, 3, 4);
            this.ButtonResturntTabls.Name = "ButtonResturntTabls";
            this.ButtonResturntTabls.Size = new Size(0x176, 0x2c);
            this.ButtonResturntTabls.TabIndex = 0x29;
            this.ButtonResturntTabls.Text = "انشاء ترميز طاولات/الغرف";
            this.ButtonResturntTabls.UseVisualStyleBackColor = true;
            this.TabPage2.BackColor = Color.White;
            this.TabPage2.Controls.Add(this.ButtonLogoImag);
            this.TabPage2.Location = new Point(4, 0x2e);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x32b, 0x194);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "صورة الشعار والترويسه";
            this.ButtonLogoImag.FlatAppearance.BorderColor = Color.Green;
            this.ButtonLogoImag.FlatStyle = FlatStyle.Flat;
            this.ButtonLogoImag.Image = A.F.ImImgs;
            this.ButtonLogoImag.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonLogoImag.Location = new Point(0xe2, 0x58);
            this.ButtonLogoImag.Name = "ButtonLogoImag";
            this.ButtonLogoImag.Size = new Size(0x171, 0x36);
            this.ButtonLogoImag.TabIndex = 0;
            this.ButtonLogoImag.Text = "تعديل صورة الشعار والترويسه";
            this.ButtonLogoImag.UseVisualStyleBackColor = true;
            this.CenterDecimelQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CenterDecimelQuantity.FlatStyle = FlatStyle.System;
            this.CenterDecimelQuantity.FormattingEnabled = true;
            object[] objArray4 = new object[] { "0", "0.0", "0.00", "0.000", "0.0000" };
            this.CenterDecimelQuantity.Items.AddRange(objArray4);
            this.CenterDecimelQuantity.Location = new Point(0x19e, 0x3d);
            this.CenterDecimelQuantity.Name = "CenterDecimelQuantity";
            this.CenterDecimelQuantity.RightToLeft = RightToLeft.No;
            this.CenterDecimelQuantity.Size = new Size(210, 0x18);
            this.CenterDecimelQuantity.TabIndex = 0x24;
            this.CenterDecimelPrince.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CenterDecimelPrince.FlatStyle = FlatStyle.System;
            this.CenterDecimelPrince.FormattingEnabled = true;
            object[] objArray5 = new object[] { "0", "0.0", "0.00", "0.000", "0.0000" };
            this.CenterDecimelPrince.Items.AddRange(objArray5);
            this.CenterDecimelPrince.Location = new Point(0x19e, 0x21);
            this.CenterDecimelPrince.Name = "CenterDecimelPrince";
            this.CenterDecimelPrince.RightToLeft = RightToLeft.No;
            this.CenterDecimelPrince.Size = new Size(210, 0x18);
            this.CenterDecimelPrince.TabIndex = 0x23;
            this.CenterCurrencyName.BackColor = SystemColors.Info;
            this.CenterCurrencyName.Location = new Point(0x19e, 0x5b);
            this.CenterCurrencyName.MaxLength = 50;
            this.CenterCurrencyName.Name = "CenterCurrencyName";
            this.CenterCurrencyName.Size = new Size(210, 0x17);
            this.CenterCurrencyName.TabIndex = 0x22;
            this.CenterCurrencyName.TextAlign = HorizontalAlignment.Center;
            this.Label9.AutoSize = true;
            this.Label9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label9.Location = new Point(0x279, 0x40);
            this.Label9.Name = "Label9";
            this.Label9.Size = new Size(0x85, 0x10);
            this.Label9.TabIndex = 0x21;
            this.Label9.Text = "الارقام العشرية للكمية:";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0x279, 0x24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x84, 0x10);
            this.Label2.TabIndex = 0x20;
            this.Label2.Text = "الارقام العشرية للعملة:";
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0x279, 0x5e);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x4b, 0x10);
            this.Label1.TabIndex = 0x1f;
            this.Label1.Text = "اسم العملة:";
            this.CenterName.BackColor = Color.WhiteSmoke;
            this.CenterName.Dock = DockStyle.Top;
            this.CenterName.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.CenterName.Location = new Point(0, 0);
            this.CenterName.Name = "CenterName";
            this.CenterName.Size = new Size(0x333, 40);
            this.CenterName.TabIndex = 0x25;
            this.CenterName.Text = "اسم الفرع/المستودع";
            this.CenterName.TextAlign = ContentAlignment.MiddleCenter;
            this.CenterSaleIsSaleeb.AutoSize = true;
            this.CenterSaleIsSaleeb.Location = new Point(0xb1, 0x93);
            this.CenterSaleIsSaleeb.Name = "CenterSaleIsSaleeb";
            this.CenterSaleIsSaleeb.RightToLeft = RightToLeft.Yes;
            this.CenterSaleIsSaleeb.Size = new Size(0x23b, 20);
            this.CenterSaleIsSaleeb.TabIndex = 0x2b;
            this.CenterSaleIsSaleeb.Text = "السماح بعملية البيع في حال نفاذ الكمية، واسمح للكمية ان تتحول في السالب - بهدف تعويضها لاحقاً";
            this.CenterSaleIsSaleeb.UseVisualStyleBackColor = true;
            this.TabPage1.BackColor = Color.White;
            this.TabPage1.Controls.Add(this.CenterDecimelQuantity);
            this.TabPage1.Controls.Add(this.CenterDecimelPrince);
            this.TabPage1.Controls.Add(this.ButtonSaleSeet);
            this.TabPage1.Controls.Add(this.CenterCurrencyName);
            this.TabPage1.Controls.Add(this.Label9);
            this.TabPage1.Controls.Add(this.CenterInvMAXMIX);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.CenterSaleIsLoss);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.CenterIsAllarmQQExip);
            this.TabPage1.Controls.Add(this.CenterSaleIsSaleeb);
            this.TabPage1.Controls.Add(this.CenterInvIsViewProft);
            this.TabPage1.Location = new Point(4, 0x2e);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x32b, 0x194);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "إعدادات عامة";
            this.ButtonSaleSeet.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSaleSeet.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSaleSeet.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSaleSeet.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSaleSeet.FlatStyle = FlatStyle.Flat;
            this.ButtonSaleSeet.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSaleSeet.Image = A.F.ImSale;
            this.ButtonSaleSeet.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSaleSeet.Location = new Point(0x1d, 0x12f);
            this.ButtonSaleSeet.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSaleSeet.Name = "ButtonSaleSeet";
            this.ButtonSaleSeet.Size = new Size(0x2cf, 0x2c);
            this.ButtonSaleSeet.TabIndex = 0x29;
            this.ButtonSaleSeet.Text = "ضبط شاشة البيع";
            this.ButtonSaleSeet.UseVisualStyleBackColor = true;
            this.CenterInvMAXMIX.AutoSize = true;
            this.CenterInvMAXMIX.Checked = true;
            this.CenterInvMAXMIX.CheckState = CheckState.Checked;
            this.CenterInvMAXMIX.Enabled = false;
            this.CenterInvMAXMIX.Location = new Point(0x18d, 0xfb);
            this.CenterInvMAXMIX.Name = "CenterInvMAXMIX";
            this.CenterInvMAXMIX.RightToLeft = RightToLeft.Yes;
            this.CenterInvMAXMIX.Size = new Size(0x15f, 20);
            this.CenterInvMAXMIX.TabIndex = 0x31;
            this.CenterInvMAXMIX.Text = "دمج تسلسل ترقيم فواتير المبيعات مع فواتير مرتجع المبيعات";
            this.CenterInvMAXMIX.UseVisualStyleBackColor = true;
            this.CenterSaleIsLoss.AutoSize = true;
            this.CenterSaleIsLoss.Checked = true;
            this.CenterSaleIsLoss.CheckState = CheckState.Checked;
            this.CenterSaleIsLoss.Location = new Point(0x1a8, 0xc7);
            this.CenterSaleIsLoss.Name = "CenterSaleIsLoss";
            this.CenterSaleIsLoss.Size = new Size(0x144, 20);
            this.CenterSaleIsLoss.TabIndex = 0x30;
            this.CenterSaleIsLoss.Text = "السماح بعمليات البيع التي يكون فيها ناتج الربح خسارة";
            this.CenterSaleIsLoss.UseVisualStyleBackColor = true;
            this.CenterIsAllarmQQExip.AutoSize = true;
            this.CenterIsAllarmQQExip.Checked = true;
            this.CenterIsAllarmQQExip.CheckState = CheckState.Checked;
            this.CenterIsAllarmQQExip.Location = new Point(0x179, 0xad);
            this.CenterIsAllarmQQExip.Name = "CenterIsAllarmQQExip";
            this.CenterIsAllarmQQExip.RightToLeft = RightToLeft.Yes;
            this.CenterIsAllarmQQExip.Size = new Size(0x173, 20);
            this.CenterIsAllarmQQExip.TabIndex = 0x2f;
            this.CenterIsAllarmQQExip.Text = "عرض تنبيهات تاريخ انتهاء المواد او الكميات عند فتح شاشة البيع";
            this.CenterIsAllarmQQExip.UseVisualStyleBackColor = true;
            this.CenterSubName.BackColor = Color.WhiteSmoke;
            this.CenterSubName.Dock = DockStyle.Top;
            this.CenterSubName.FlatStyle = FlatStyle.Flat;
            this.CenterSubName.Location = new Point(0, 0x44);
            this.CenterSubName.Name = "CenterSubName";
            this.CenterSubName.Size = new Size(0x333, 0x1c);
            this.CenterSubName.TabIndex = 0x26;
            this.CenterSubName.Text = "اسم الفرع/المستودع";
            this.CenterSubName.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Controls.Add(this.TabPage8);
            this.TabControl1.Controls.Add(this.TabPage13);
            this.TabControl1.Controls.Add(this.TabPage7);
            this.TabControl1.Controls.Add(this.TabPage10);
            this.TabControl1.Controls.Add(this.TabPage9);
            this.TabControl1.Controls.Add(this.TabPage11);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x60);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x333, 0x1c6);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 0x27;
            this.TabPage13.Controls.Add(this.ButtonCurr);
            this.TabPage13.Location = new Point(4, 0x2e);
            this.TabPage13.Name = "TabPage13";
            this.TabPage13.Padding = new Padding(3);
            this.TabPage13.Size = new Size(0x32b, 0x194);
            this.TabPage13.TabIndex = 12;
            this.TabPage13.Text = "إدارة العملات";
            this.TabPage13.UseVisualStyleBackColor = true;
            this.ButtonCurr.FlatAppearance.BorderColor = Color.Green;
            this.ButtonCurr.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonCurr.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonCurr.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonCurr.FlatStyle = FlatStyle.Flat;
            this.ButtonCurr.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonCurr.Image = A.F.ImMoney;
            this.ButtonCurr.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCurr.Location = new Point(0x61, 0x4b);
            this.ButtonCurr.Margin = new Padding(3, 4, 3, 4);
            this.ButtonCurr.Name = "ButtonCurr";
            this.ButtonCurr.Size = new Size(0x25c, 0x2c);
            this.ButtonCurr.TabIndex = 0x2a;
            this.ButtonCurr.Text = "إدارة العملات";
            this.ButtonCurr.UseVisualStyleBackColor = true;
            this.TabPage7.Controls.Add(this.ToolStripDelete);
            this.TabPage7.Controls.Add(this.TxTDDCenterNa);
            this.TabPage7.Controls.Add(this.Label12);
            this.TabPage7.Controls.Add(this.Label14);
            this.TabPage7.Location = new Point(4, 0x2e);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Size = new Size(0x32b, 0x194);
            this.TabPage7.TabIndex = 13;
            this.TabPage7.Text = "حذف البيانات";
            this.TabPage7.UseVisualStyleBackColor = true;
            this.ToolStripDelete.AutoSize = false;
            this.ToolStripDelete.BackColor = Color.White;
            this.ToolStripDelete.Dock = DockStyle.None;
            this.ToolStripDelete.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripDelete.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.BDeletSame, this.ToolStripLabel1, this.ToolStripSeparator1, this.ToolStripLabel2, this.BDeleteAll };
            this.ToolStripDelete.Items.AddRange(toolStripItems);
            this.ToolStripDelete.Location = new Point(130, 0x8d);
            this.ToolStripDelete.Name = "ToolStripDelete";
            this.ToolStripDelete.Size = new Size(0x221, 0x42);
            this.ToolStripDelete.Stretch = true;
            this.ToolStripDelete.TabIndex = 0x2a;
            this.ToolStripDelete.Text = " ";
            this.BDeletSame.BackColor = Color.WhiteSmoke;
            ToolStripItem[] itemArray2 = new ToolStripItem[13];
            itemArray2[0] = this.DTaMaterial;
            itemArray2[1] = this.ToolStripSeparator5;
            itemArray2[2] = this.DTaSuplier;
            itemArray2[3] = this.ToolStripSeparator6;
            itemArray2[4] = this.DTaCustomers;
            itemArray2[5] = this.ToolStripSeparator8;
            itemArray2[6] = this.DTaInvSale;
            itemArray2[7] = this.ToolStripSeparator7;
            itemArray2[8] = this.DTaExpenses;
            itemArray2[9] = this.ToolStripSeparator9;
            itemArray2[10] = this.DTaInvPurch;
            itemArray2[11] = this.ToolStripSeparator4;
            itemArray2[12] = this.DTaCash;
            this.BDeletSame.DropDownItems.AddRange(itemArray2);
            this.BDeletSame.Image = A.F.ImDelete;
            this.BDeletSame.ImageScaling = ToolStripItemImageScaling.None;
            this.BDeletSame.ImageTransparentColor = Color.Magenta;
            this.BDeletSame.Name = "BDeletSame";
            this.BDeletSame.Size = new Size(0xf2, 0x3f);
            this.BDeletSame.Text = "حذف جزء من البيانات للفرع المحدد";
            this.DTaMaterial.Name = "DTaMaterial";
            this.DTaMaterial.Size = new Size(330, 0x16);
            this.DTaMaterial.Text = "حذف المواد في المستودع فقط";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(0x147, 6);
            this.DTaSuplier.Name = "DTaSuplier";
            this.DTaSuplier.Size = new Size(330, 0x16);
            this.DTaSuplier.Text = "حذف الموردين ودفعات الموردين فقط";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new Size(0x147, 6);
            this.DTaCustomers.Name = "DTaCustomers";
            this.DTaCustomers.Size = new Size(330, 0x16);
            this.DTaCustomers.Text = "حذف العملاء ودفعات العملاء فقط";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(0x147, 6);
            this.DTaInvSale.Name = "DTaInvSale";
            this.DTaInvSale.Size = new Size(330, 0x16);
            this.DTaInvSale.Text = "حذف فواتير المبيعات / مرتجع المبيعات فقط";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(0x147, 6);
            this.DTaExpenses.Name = "DTaExpenses";
            this.DTaExpenses.Size = new Size(330, 0x16);
            this.DTaExpenses.Text = "حذف المصروفات والنفقات فقط";
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new Size(0x147, 6);
            this.DTaInvPurch.Name = "DTaInvPurch";
            this.DTaInvPurch.Size = new Size(330, 0x16);
            this.DTaInvPurch.Text = "حذف فواتير المشتريات / مرتجع المشتريات فقط";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(0x147, 6);
            this.DTaCash.Name = "DTaCash";
            this.DTaCash.Size = new Size(330, 0x16);
            this.DTaCash.Text = "حذف سجل دفعات الكاش فقط";
            this.ToolStripLabel1.Enabled = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(20, 0x3f);
            this.ToolStripLabel1.Text = "   ";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x42);
            this.ToolStripLabel2.Enabled = false;
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new Size(20, 0x3f);
            this.ToolStripLabel2.Text = "   ";
            this.BDeleteAll.BackColor = Color.FromArgb(0xff, 0xe0, 0xc0);
            this.BDeleteAll.Image = A.F.ImDelete;
            this.BDeleteAll.ImageScaling = ToolStripItemImageScaling.None;
            this.BDeleteAll.ImageTransparentColor = Color.Magenta;
            this.BDeleteAll.Name = "BDeleteAll";
            this.BDeleteAll.Size = new Size(0xce, 0x3f);
            this.BDeleteAll.Text = "  حذف كل بيانات الفرع المحدد";
            this.TxTDDCenterNa.BackColor = Color.WhiteSmoke;
            this.TxTDDCenterNa.Dock = DockStyle.Top;
            this.TxTDDCenterNa.FlatStyle = FlatStyle.Flat;
            this.TxTDDCenterNa.Location = new Point(0, 0x55);
            this.TxTDDCenterNa.Name = "TxTDDCenterNa";
            this.TxTDDCenterNa.Size = new Size(0x32b, 0x1c);
            this.TxTDDCenterNa.TabIndex = 40;
            this.TxTDDCenterNa.Text = "اسم الفرع/المستودع";
            this.TxTDDCenterNa.TextAlign = ContentAlignment.MiddleCenter;
            this.Label12.BackColor = Color.White;
            this.Label12.Dock = DockStyle.Top;
            this.Label12.FlatStyle = FlatStyle.Flat;
            this.Label12.Location = new Point(0, 0x34);
            this.Label12.Name = "Label12";
            this.Label12.Size = new Size(0x32b, 0x21);
            this.Label12.TabIndex = 0x27;
            this.Label12.Text = "اسم المستودع/ الفرع";
            this.Label12.TextAlign = ContentAlignment.MiddleCenter;
            this.Label14.Dock = DockStyle.Top;
            this.Label14.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label14.ForeColor = Color.Black;
            this.Label14.Image = A.F.ImWarining;
            this.Label14.ImageAlign = ContentAlignment.MiddleLeft;
            this.Label14.Location = new Point(0, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new Size(0x32b, 0x34);
            this.Label14.TabIndex = 0x29;
            this.Label14.Text = "       قد يكون هناك بيانات تم ربطها مع هذا الفرع/المستودع مثل العملاء، الموردين، المواد، فواتير المبيعات، فواتير المشتريات......الخ . فعند الحذف سيتم حذفها.";
            this.Label14.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage10.Controls.Add(this.GroupBox6);
            this.TabPage10.Controls.Add(this.Label19);
            this.TabPage10.Controls.Add(this.CenterMorFeeVALCardPay);
            this.TabPage10.Controls.Add(this.Label18);
            this.TabPage10.Location = new Point(4, 0x2e);
            this.TabPage10.Name = "TabPage10";
            this.TabPage10.Padding = new Padding(3);
            this.TabPage10.Size = new Size(0x32b, 0x194);
            this.TabPage10.TabIndex = 15;
            this.TabPage10.Text = "عمولات/رسوم اضافية";
            this.TabPage10.UseVisualStyleBackColor = true;
            this.GroupBox6.Controls.Add(this.Label24);
            this.GroupBox6.Controls.Add(this.Label23);
            this.GroupBox6.Controls.Add(this.CenterMorFeeTaxMiaW);
            this.GroupBox6.Controls.Add(this.CenterMorFeeTaXName);
            this.GroupBox6.Controls.Add(this.Label22);
            this.GroupBox6.Location = new Point(30, 0x7e);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x2d1, 0x4a);
            this.GroupBox6.TabIndex = 50;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "اضافة رسوم/عمولة اضافية علي قيمة الفاتورة:";
            this.Label24.AutoSize = true;
            this.Label24.ForeColor = Color.Red;
            this.Label24.Location = new Point(0x19, 0x25);
            this.Label24.Name = "Label24";
            this.Label24.Size = new Size(20, 0x10);
            this.Label24.TabIndex = 0x35;
            this.Label24.Text = "%";
            this.Label23.AutoSize = true;
            this.Label23.Location = new Point(0x9d, 0x25);
            this.Label23.Name = "Label23";
            this.Label23.Size = new Size(0x4d, 0x10);
            this.Label23.TabIndex = 0x34;
            this.Label23.Text = "وذلك بنسبة:";
            this.CenterMorFeeTaxMiaW.Location = new Point(0x33, 0x22);
            this.CenterMorFeeTaxMiaW.MaxLength = 4;
            this.CenterMorFeeTaxMiaW.Name = "CenterMorFeeTaxMiaW";
            this.CenterMorFeeTaxMiaW.RightToLeft = RightToLeft.No;
            this.CenterMorFeeTaxMiaW.Size = new Size(100, 0x17);
            this.CenterMorFeeTaxMiaW.TabIndex = 0x33;
            this.CenterMorFeeTaxMiaW.TextAlign = HorizontalAlignment.Center;
            this.CenterMorFeeTaXName.Location = new Point(0x108, 0x22);
            this.CenterMorFeeTaXName.MaxLength = 50;
            this.CenterMorFeeTaXName.Name = "CenterMorFeeTaXName";
            this.CenterMorFeeTaXName.Size = new Size(0xcf, 0x17);
            this.CenterMorFeeTaXName.TabIndex = 50;
            this.Label22.AutoSize = true;
            this.Label22.Location = new Point(0x1dd, 0x25);
            this.Label22.Name = "Label22";
            this.Label22.Size = new Size(0xe4, 0x10);
            this.Label22.TabIndex = 0x31;
            this.Label22.Text = "عنوان او اسم الرسوم او العمولة الاضافية:";
            this.Label19.AutoSize = true;
            this.Label19.ForeColor = Color.Red;
            this.Label19.Location = new Point(9, 0x33);
            this.Label19.Name = "Label19";
            this.Label19.Size = new Size(20, 0x10);
            this.Label19.TabIndex = 0x30;
            this.Label19.Text = "%";
            this.CenterMorFeeVALCardPay.Location = new Point(0x23, 0x30);
            this.CenterMorFeeVALCardPay.MaxLength = 4;
            this.CenterMorFeeVALCardPay.Name = "CenterMorFeeVALCardPay";
            this.CenterMorFeeVALCardPay.RightToLeft = RightToLeft.No;
            this.CenterMorFeeVALCardPay.Size = new Size(0xbc, 0x17);
            this.CenterMorFeeVALCardPay.TabIndex = 0x2c;
            this.CenterMorFeeVALCardPay.TextAlign = HorizontalAlignment.Center;
            this.Label18.AutoSize = true;
            this.Label18.Location = new Point(0xe5, 0x33);
            this.Label18.Name = "Label18";
            this.Label18.Size = new Size(0x20d, 0x10);
            this.Label18.TabIndex = 2;
            this.Label18.Text = "عند البيع من خلال الشبكة (بطاقات فيزا، ماستركارد..الخ) اضف عمولة على قيمة الفاتورة بنسبة:";
            this.TabPage9.Controls.Add(this.ButtonDisableSDK);
            this.TabPage9.Controls.Add(this.CenterIsQRSDK);
            this.TabPage9.Controls.Add(this.GroupBox1);
            this.TabPage9.Controls.Add(this.CenterInvIsViewSigna);
            this.TabPage9.Location = new Point(4, 0x2e);
            this.TabPage9.Name = "TabPage9";
            this.TabPage9.Size = new Size(0x32b, 0x194);
            this.TabPage9.TabIndex = 0x10;
            this.TabPage9.Text = "إصدار الفواتير الالكترونية و QR";
            this.TabPage9.UseVisualStyleBackColor = true;
            this.ButtonDisableSDK.Location = new Point(0x180, 0xd3);
            this.ButtonDisableSDK.Name = "ButtonDisableSDK";
            this.ButtonDisableSDK.Size = new Size(0x16c, 50);
            this.ButtonDisableSDK.TabIndex = 0x4d;
            this.ButtonDisableSDK.Text = "تفعيل وضع الطواريء";
            this.ButtonDisableSDK.UseVisualStyleBackColor = true;
            this.CenterIsQRSDK.AutoSize = true;
            this.CenterIsQRSDK.Checked = true;
            this.CenterIsQRSDK.CheckState = CheckState.Checked;
            this.CenterIsQRSDK.Location = new Point(0x205, 0x51);
            this.CenterIsQRSDK.Name = "CenterIsQRSDK";
            this.CenterIsQRSDK.Size = new Size(0xe3, 20);
            this.CenterIsQRSDK.TabIndex = 0x4c;
            this.CenterIsQRSDK.Text = "التشفير والربط مع جهات رسمية SDK";
            this.CenterIsQRSDK.UseVisualStyleBackColor = true;
            this.TabPage11.Controls.Add(this.GroupBox19);
            this.TabPage11.Controls.Add(this.GroupBox26);
            this.TabPage11.Controls.Add(this.GroupBox25);
            this.TabPage11.Controls.Add(this.GroupBox22);
            this.TabPage11.Controls.Add(this.GroupBox21);
            this.TabPage11.Controls.Add(this.GroupBox20);
            this.TabPage11.Controls.Add(this.GroupBox17);
            this.TabPage11.Controls.Add(this.GroupBox16);
            this.TabPage11.Controls.Add(this.GroupBox18);
            this.TabPage11.Controls.Add(this.GroupBox15);
            this.TabPage11.Location = new Point(4, 0x2e);
            this.TabPage11.Name = "TabPage11";
            this.TabPage11.Padding = new Padding(3);
            this.TabPage11.Size = new Size(0x32b, 0x194);
            this.TabPage11.TabIndex = 0x11;
            this.TabPage11.Text = "معلومات قانونية";
            this.TabPage11.UseVisualStyleBackColor = true;
            this.GroupBox19.Controls.Add(this.CcPlotIdentification);
            this.GroupBox19.Location = new Point(90, 0xba);
            this.GroupBox19.Name = "GroupBox19";
            this.GroupBox19.Size = new Size(120, 0x34);
            this.GroupBox19.TabIndex = 0x8b;
            this.GroupBox19.TabStop = false;
            this.GroupBox19.Text = "رقم الطابق";
            this.CcPlotIdentification.Dock = DockStyle.Bottom;
            this.CcPlotIdentification.Location = new Point(3, 0x1a);
            this.CcPlotIdentification.MaxLength = 50;
            this.CcPlotIdentification.Name = "CcPlotIdentification";
            this.CcPlotIdentification.RightToLeft = RightToLeft.No;
            this.CcPlotIdentification.Size = new Size(0x72, 0x17);
            this.CcPlotIdentification.TabIndex = 6;
            this.CcPlotIdentification.TextAlign = HorizontalAlignment.Center;
            this.GroupBox26.Controls.Add(this.CcMorID);
            this.GroupBox26.Location = new Point(90, 0xf4);
            this.GroupBox26.Name = "GroupBox26";
            this.GroupBox26.Size = new Size(0x246, 0x47);
            this.GroupBox26.TabIndex = 0x7e;
            this.GroupBox26.TabStop = false;
            this.GroupBox26.Text = "تفاصيل اخرى";
            this.CcMorID.Dock = DockStyle.Bottom;
            this.CcMorID.Location = new Point(3, 0x16);
            this.CcMorID.MaxLength = 50;
            this.CcMorID.Multiline = true;
            this.CcMorID.Name = "CcMorID";
            this.CcMorID.RightToLeft = RightToLeft.No;
            this.CcMorID.Size = new Size(0x240, 0x2e);
            this.CcMorID.TabIndex = 5;
            this.CcMorID.TextAlign = HorizontalAlignment.Center;
            this.GroupBox25.Controls.Add(this.CcPostCode);
            this.GroupBox25.Location = new Point(0x151, 0xba);
            this.GroupBox25.Name = "GroupBox25";
            this.GroupBox25.Size = new Size(0x76, 0x34);
            this.GroupBox25.TabIndex = 0x7f;
            this.GroupBox25.TabStop = false;
            this.GroupBox25.Text = "الرمز البريدي";
            this.CcPostCode.Dock = DockStyle.Bottom;
            this.CcPostCode.Location = new Point(3, 0x1a);
            this.CcPostCode.MaxLength = 50;
            this.CcPostCode.Name = "CcPostCode";
            this.CcPostCode.RightToLeft = RightToLeft.No;
            this.CcPostCode.Size = new Size(0x70, 0x17);
            this.CcPostCode.TabIndex = 5;
            this.CcPostCode.TextAlign = HorizontalAlignment.Center;
            this.GroupBox22.Controls.Add(this.CcCountrySubentity);
            this.GroupBox22.Location = new Point(280, 0x80);
            this.GroupBox22.Name = "GroupBox22";
            this.GroupBox22.Size = new Size(0xaf, 0x34);
            this.GroupBox22.TabIndex = 0x7b;
            this.GroupBox22.TabStop = false;
            this.GroupBox22.Text = "البلد الفرعي";
            this.CcCountrySubentity.Dock = DockStyle.Bottom;
            this.CcCountrySubentity.Location = new Point(3, 0x1a);
            this.CcCountrySubentity.MaxLength = 50;
            this.CcCountrySubentity.Name = "CcCountrySubentity";
            this.CcCountrySubentity.RightToLeft = RightToLeft.No;
            this.CcCountrySubentity.Size = new Size(0xa9, 0x17);
            this.CcCountrySubentity.TabIndex = 3;
            this.CcCountrySubentity.TextAlign = HorizontalAlignment.Center;
            this.GroupBox21.Controls.Add(this.CcCityName);
            this.GroupBox21.Location = new Point(0x1cd, 0x80);
            this.GroupBox21.Name = "GroupBox21";
            this.GroupBox21.Size = new Size(0xd3, 0x34);
            this.GroupBox21.TabIndex = 0x7a;
            this.GroupBox21.TabStop = false;
            this.GroupBox21.Text = "اسم المدينة";
            this.CcCityName.Dock = DockStyle.Bottom;
            this.CcCityName.Location = new Point(3, 0x1a);
            this.CcCityName.MaxLength = 50;
            this.CcCityName.Name = "CcCityName";
            this.CcCityName.RightToLeft = RightToLeft.No;
            this.CcCityName.Size = new Size(0xcd, 0x17);
            this.CcCityName.TabIndex = 2;
            this.CcCityName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox20.Controls.Add(this.CcCitySubdivisionName);
            this.GroupBox20.Location = new Point(90, 0x80);
            this.GroupBox20.Name = "GroupBox20";
            this.GroupBox20.Size = new Size(0xb8, 0x34);
            this.GroupBox20.TabIndex = 0x7c;
            this.GroupBox20.TabStop = false;
            this.GroupBox20.Text = "الحي";
            this.CcCitySubdivisionName.Dock = DockStyle.Bottom;
            this.CcCitySubdivisionName.Location = new Point(3, 0x1a);
            this.CcCitySubdivisionName.MaxLength = 50;
            this.CcCitySubdivisionName.Name = "CcCitySubdivisionName";
            this.CcCitySubdivisionName.RightToLeft = RightToLeft.No;
            this.CcCitySubdivisionName.Size = new Size(0xb2, 0x17);
            this.CcCitySubdivisionName.TabIndex = 4;
            this.CcCitySubdivisionName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox17.Controls.Add(this.CcStreetName);
            this.GroupBox17.Location = new Point(0x1cd, 0xba);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(0xd3, 0x34);
            this.GroupBox17.TabIndex = 0x7d;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "اسم الشارع";
            this.CcStreetName.Dock = DockStyle.Bottom;
            this.CcStreetName.Location = new Point(3, 0x1a);
            this.CcStreetName.MaxLength = 50;
            this.CcStreetName.Name = "CcStreetName";
            this.CcStreetName.RightToLeft = RightToLeft.No;
            this.CcStreetName.Size = new Size(0xcd, 0x17);
            this.CcStreetName.TabIndex = 5;
            this.CcStreetName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox16.Controls.Add(this.CcSchemeID);
            this.GroupBox16.Location = new Point(90, 70);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(0x1a1, 0x34);
            this.GroupBox16.TabIndex = 0x79;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "رقم التسجيل/ التسلسل";
            this.CcSchemeID.Dock = DockStyle.Bottom;
            this.CcSchemeID.Location = new Point(3, 0x1a);
            this.CcSchemeID.MaxLength = 50;
            this.CcSchemeID.Name = "CcSchemeID";
            this.CcSchemeID.RightToLeft = RightToLeft.No;
            this.CcSchemeID.Size = new Size(0x19b, 0x17);
            this.CcSchemeID.TabIndex = 1;
            this.CcSchemeID.TextAlign = HorizontalAlignment.Center;
            this.GroupBox18.Controls.Add(this.CcBuildingNumber);
            this.GroupBox18.Location = new Point(0xd5, 0xba);
            this.GroupBox18.Name = "GroupBox18";
            this.GroupBox18.Size = new Size(120, 0x34);
            this.GroupBox18.TabIndex = 0x80;
            this.GroupBox18.TabStop = false;
            this.GroupBox18.Text = "رقم البناء";
            this.CcBuildingNumber.Dock = DockStyle.Bottom;
            this.CcBuildingNumber.Location = new Point(3, 0x1a);
            this.CcBuildingNumber.MaxLength = 50;
            this.CcBuildingNumber.Name = "CcBuildingNumber";
            this.CcBuildingNumber.RightToLeft = RightToLeft.No;
            this.CcBuildingNumber.Size = new Size(0x72, 0x17);
            this.CcBuildingNumber.TabIndex = 7;
            this.CcBuildingNumber.TextAlign = HorizontalAlignment.Center;
            this.GroupBox15.Controls.Add(this.ButtonHelp);
            this.GroupBox15.Controls.Add(this.CcSchemeTy);
            this.GroupBox15.Location = new Point(0x201, 70);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x9e, 0x34);
            this.GroupBox15.TabIndex = 0x77;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "نوع التسجيل";
            this.ButtonHelp.Location = new Point(0x7b, 0x17);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new Size(0x1d, 0x1b);
            this.ButtonHelp.TabIndex = 120;
            this.ButtonHelp.Text = "?";
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.CcSchemeTy.FormattingEnabled = true;
            object[] objArray6 = new object[10];
            objArray6[0] = "SAG";
            objArray6[1] = "CRN";
            objArray6[2] = "MOM";
            objArray6[3] = "MLS";
            objArray6[4] = "OTH";
            objArray6[5] = "NAT";
            objArray6[6] = "PAS";
            objArray6[7] = "GCC";
            objArray6[8] = "MOM";
            objArray6[9] = "IQA";
            this.CcSchemeTy.Items.AddRange(objArray6);
            this.CcSchemeTy.Location = new Point(3, 0x19);
            this.CcSchemeTy.Name = "CcSchemeTy";
            this.CcSchemeTy.RightToLeft = RightToLeft.No;
            this.CcSchemeTy.Size = new Size(0x77, 0x18);
            this.CcSchemeTy.TabIndex = 2;
            this.CcSchemeTy.Text = "CRN";
            this.Label10.BackColor = Color.WhiteSmoke;
            this.Label10.Dock = DockStyle.Top;
            this.Label10.FlatStyle = FlatStyle.Flat;
            this.Label10.Location = new Point(0, 40);
            this.Label10.Name = "Label10";
            this.Label10.Size = new Size(0x333, 0x1c);
            this.Label10.TabIndex = 0x29;
            this.Label10.Text = "اسم الفرع/المستودع";
            this.Label10.TextAlign = ContentAlignment.MiddleCenter;
            this.CenterDarType.Location = new Point(0x1df, 770);
            this.CenterDarType.Name = "CenterDarType";
            this.CenterDarType.Size = new Size(100, 0x17);
            this.CenterDarType.TabIndex = 0x2a;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x286, 0x22d);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xa1, 0x2c);
            this.ButtonClose.TabIndex = 0x22;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(3, 0x22d);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x25c, 0x2c);
            this.ButtonOk.TabIndex = 40;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x333, 0x265);
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.CenterDarType);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.CenterSubName);
            base.Controls.Add(this.Label10);
            base.Controls.Add(this.CenterName);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SettingForm";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اعدادات الفرع/المستودع";
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox14.PerformLayout();
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox13.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.TabPage8.ResumeLayout(false);
            this.TabPage8.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage13.ResumeLayout(false);
            this.TabPage7.ResumeLayout(false);
            this.ToolStripDelete.ResumeLayout(false);
            this.ToolStripDelete.PerformLayout();
            this.TabPage10.ResumeLayout(false);
            this.TabPage10.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.TabPage9.ResumeLayout(false);
            this.TabPage9.PerformLayout();
            this.TabPage11.ResumeLayout(false);
            this.GroupBox19.ResumeLayout(false);
            this.GroupBox19.PerformLayout();
            this.GroupBox26.ResumeLayout(false);
            this.GroupBox26.PerformLayout();
            this.GroupBox25.ResumeLayout(false);
            this.GroupBox25.PerformLayout();
            this.GroupBox22.ResumeLayout(false);
            this.GroupBox22.PerformLayout();
            this.GroupBox21.ResumeLayout(false);
            this.GroupBox21.PerformLayout();
            this.GroupBox20.ResumeLayout(false);
            this.GroupBox20.PerformLayout();
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox17.PerformLayout();
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox16.PerformLayout();
            this.GroupBox18.ResumeLayout(false);
            this.GroupBox18.PerformLayout();
            this.GroupBox15.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void A(object A, EventArgs R)
        {
            if (this.A)
            {
                Interaction.MsgBox("لتنفيذ التغيرات يجب عليك اعادة تشغيل النظام", MsgBoxStyle.Exclamation, null);
                ProjectData.EndApp();
            }
            base.Dispose();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void AR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void B(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل انت متأكد من حذف  ## " + this.DTaMaterial.Text + " ## في الفرع المحدد", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    SqlCommand command2 = new SqlCommand("DELETE FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command2.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    SqlCommand command3 = new SqlCommand("DELETE FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command3.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
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

        private void C(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل انت متأكد من حذف  ## " + this.DTaExpenses.Text + " ## في الفرع المحدد", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNExpenses WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
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

        private void D(object A, EventArgs R)
        {
            if (this.CenterInvIsViewLogo.Checked)
            {
                this.CenterInvIsViewHedar.Checked = false;
            }
        }

        private void D(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
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

        private void DR(object A, EventArgs R)
        {
            this.CenterDarType.Text = "0";
        }

        private void E(object A, EventArgs R)
        {
        }

        private void ER(object A, EventArgs R)
        {
            Interaction.MsgBox("نوع التسجل مطلوب وهو نوع الرقم المسجل هل هو (CRN - رقم السجل التجاري)، (NAT - الرقم الوطني)، (PAS - رقم جواز السفر)، (TIN - رقم ضريبي)..الخ", MsgBoxStyle.ApplicationModal, null);
        }

        private void F(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل انت متأكد من حذف الفرع المحدد وكافة البيانات المرتبطة", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                if (A.PR.GR == "1100")
                {
                    Interaction.MsgBox("هذا المستودع / الفرع رئيسي لا يمكن حذفه كاملا", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    try
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNBarCodeMult WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command2 = new SqlCommand("DELETE FROM TaNNCash WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command2.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command3 = new SqlCommand("DELETE FROM TaNNCustomers WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command3.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command4 = new SqlCommand("DELETE FROM TaNNCustomersPay WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command4.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command5 = new SqlCommand("DELETE FROM TaNNExpenses WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command5.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command6 = new SqlCommand("DELETE FROM TaNNInvPurch WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command6.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command7 = new SqlCommand("DELETE FROM TaNNInvPurchItems WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command7.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command8 = new SqlCommand("DELETE FROM TaNNInvSale WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command8.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command9 = new SqlCommand("DELETE FROM TaNNInvSaleItems WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command9.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command10 = new SqlCommand("DELETE FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command10.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command11 = new SqlCommand("DELETE FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command11.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command12 = new SqlCommand("DELETE FROM TaNNMaterialReport WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command12.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command13 = new SqlCommand("DELETE FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command13.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command14 = new SqlCommand("DELETE FROM TaNNOtherCuren WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command14.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command15 = new SqlCommand("DELETE FROM TaNNPrivewList WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command15.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command16 = new SqlCommand("DELETE FROM TaNNPrivewMatrials WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command16.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command17 = new SqlCommand("DELETE FROM TaNNRemember WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command17.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command18 = new SqlCommand("DELETE FROM TaNNSupliers WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command18.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command19 = new SqlCommand("DELETE FROM TaNNSupliersPay WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command19.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command20 = new SqlCommand("DELETE FROM TaNNTables WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command20.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command21 = new SqlCommand("DELETE FROM TaNNUsers WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command21.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command22 = new SqlCommand("DELETE FROM TaNNCloudPrint WHERE (CenterFrontID = @CenterFrontID)", this.A);
                        command22.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                        SqlCommand command23 = new SqlCommand("DELETE FROM TaNNCenters WHERE (CenterID = @CenterID)", this.A);
                        command23.Parameters.AddWithValue("CenterID", A.PR.GR);
                        command.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();
                        command4.ExecuteNonQuery();
                        command5.ExecuteNonQuery();
                        command6.ExecuteNonQuery();
                        command7.ExecuteNonQuery();
                        command8.ExecuteNonQuery();
                        command9.ExecuteNonQuery();
                        command10.ExecuteNonQuery();
                        command11.ExecuteNonQuery();
                        command12.ExecuteNonQuery();
                        command13.ExecuteNonQuery();
                        command14.ExecuteNonQuery();
                        command15.ExecuteNonQuery();
                        command16.ExecuteNonQuery();
                        command17.ExecuteNonQuery();
                        command18.ExecuteNonQuery();
                        command19.ExecuteNonQuery();
                        command20.ExecuteNonQuery();
                        command21.ExecuteNonQuery();
                        command22.ExecuteNonQuery();
                        command23.ExecuteNonQuery();
                        this.A.Close();
                        Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        this.A = true;
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

        private void FR(object A, EventArgs R)
        {
            if (!this.CenterDarType1.Checked && (this.CenterInvSubTotal.SelectedIndex == 1))
            {
                Interaction.MsgBox("يجب ان تكون معادلة حساب الضريبة على اساس ان الاسعار شاملة الضريبة", MsgBoxStyle.ApplicationModal, null);
                this.CenterInvSubTotal.SelectedIndex = 0;
            }
        }

        private void G(object A, EventArgs R)
        {
        }

        private void G(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void GR(object A, EventArgs R)
        {
            if (!this.CenterIsQRSDK.Checked & (Conversion.Val(this.CenterDarMaWi.Text) == 15.0))
            {
                Interaction.MsgBox("خطأ في ازلة العنصر ضمن تعليمات الحكومة", MsgBoxStyle.ApplicationModal, null);
                this.CenterIsQRSDK.Checked = true;
            }
        }

        private void H(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void H(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void HR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void I(object A, EventArgs R)
        {
            if (this.CenterInvIsViewHedar.Checked)
            {
                this.CenterInvIsViewLogo.Checked = false;
            }
        }

        private void I(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void IR(object A, EventArgs R)
        {
            this.CenterDarType.Text = "1";
            this.CenterDarTXT.Text = "اسعار البيع شاملة الضريبة";
            this.CenterInvSubTotal.SelectedIndex = 1;
        }

        private void J(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل انت متأكد من حذف  ## " + this.DTaInvPurch.Text + " ## في الفرع المحدد", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNInvPurch WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    SqlCommand command2 = new SqlCommand("DELETE FROM TaNNInvPurchItems WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command2.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
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

        private void K(object A, EventArgs R)
        {
        }

        private void KR(object A, EventArgs R)
        {
            string str2 = DateTime.Now.ToString("dd");
            if (Interaction.InputBox("", "Admin", "", -1, -1) == ("120030811017" + str2))
            {
                A.PR.R = true;
                Interaction.MsgBox("Admin Mode Active", MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void L(object A, EventArgs R)
        {
        }

        private void M(object A, EventArgs R)
        {
            if ((A.PR.KR & A.PR.DR) && !A.PR.R)
            {
                Interaction.MsgBox("حسب التعليمات الحكومية، ولكونك تستخدم ادوات الربط الخارجية لا يجوز تنفيذ هذا الأمر", MsgBoxStyle.ApplicationModal, null);
            }
            else if (Interaction.MsgBox("هل انت متأكد من حذف  ## " + this.DTaInvSale.Text + " ## في الفرع المحدد", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNInvSale WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    SqlCommand command2 = new SqlCommand("DELETE FROM TaNNInvSaleItems WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command2.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
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

        private void N(object A, EventArgs R)
        {
        }

        private void O(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void P(object A, EventArgs R)
        {
            try
            {
                if (Conversion.Val(this.CenterMezanHalfOn.Text) < 0.0)
                {
                    this.CenterMezanHalfOn.Text = "1000";
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [TaNNCenters] SET [CenterPhone] = @CenterPhone, [CenterLocation] = @CenterLocation, [CenterCurrencyName] = @CenterCurrencyName, [CenterDecimelPrince] = @CenterDecimelPrince, [CenterDecimelQuantity] = @CenterDecimelQuantity, [CenterIsMezan] = @CenterIsMezan, [CenterMezanType] = @CenterMezanType, [CenterMezanHalfOn] = @CenterMezanHalfOn, [CenterIsRestorentCafe] = @CenterIsRestorentCafe, [CenterDisTXT] = @CenterDisTXT, [CenterDisMaWi] = @CenterDisMaWi, [CenterDisIFVAL] = @CenterDisIFVAL, [CenterDisIFMiWi] = @CenterDisIFMiWi, [CenterDarVATNo] = @CenterDarVATNo, [CenterDarMaWi] = @CenterDarMaWi, [CenterDarTXT] = @CenterDarTXT, [CenterDarType] = @CenterDarType, [CenterSaleIsSaleeb] = @CenterSaleIsSaleeb, [CenterSaleIsLoss] = @CenterSaleIsLoss, [CenterIsAllarmQQExip] = @CenterIsAllarmQQExip, [CenterInvIsViewProft] = @CenterInvIsViewProft, [CenterInvIsViewCustomer] = @CenterInvIsViewCustomer, [CenterInvIsCustomerLast] = @CenterInvIsCustomerLast, [CenterInvIsViewBCode] = @CenterInvIsViewBCode, [CenterInvIsViwOtherCur] = @CenterInvIsViwOtherCur, [CenterInvIsViewHedar] = @CenterInvIsViewHedar, [CenterInvIsViewLogo] = @CenterInvIsViewLogo, [CenterInvIsViewSigna] = @CenterInvIsViewSigna, [CenterInvIsViewSubNa] = @CenterInvIsViewSubNa, [CenterInvIsViewDis] = @CenterInvIsViewDis, [CenterInvIsViewDar] = @CenterInvIsViewDar, [CenterInvFotter] = @CenterInvFotter, [CenterMorFeeTaXName] = @CenterMorFeeTaXName, [CenterMorFeeTaXMiaW] = @CenterMorFeeTaXMiaW, [CenterMorFeeVALDelivary] = @CenterMorFeeVALDelivary, [CenterMorFeeVALTaWasi] = @CenterMorFeeVALTaWasi, [CenterMorFeeVALTable] = @CenterMorFeeVALTable, [CenterMorFeeVALCardPay] = @CenterMorFeeVALCardPay, [CenterInvIsViewMainName] = @CenterInvIsViewMainName, [CenterInvMAXMIX] = @CenterInvMAXMIX, [CenterInvSubTotal] = @CenterInvSubTotal, [CenterDisAutoIncud] = @CenterDisAutoIncud, [CenterDarAutoIncud] = @CenterDarAutoIncud, [CenterInvSubTotalTXT] = @CenterInvSubTotalTXT, [QRText] = @QRText, [CenterPointIFVal] = @CenterPointIFVal, [CenterIsViewDarTax] = @CenterIsViewDarTax, [CenterIsQRSDK] =@CenterIsQRSDK, [CcSchemeID] = @CcSchemeID, [CcSchemeTy] = @CcSchemeTy, [CcCityName] = @CcCityName, [CcStreetName] = @CcStreetName, [CcBuildingNumber] = @CcBuildingNumber, [CcPlotIdentification] = @CcPlotIdentification, [CcCitySubdivisionName] = @CcCitySubdivisionName, [CcCountrySubentity] = @CcCountrySubentity, [CcPostCode] = @CcPostCode, [CcMorID] = @CcMorID WHERE [CenterID] = @CenterID", this.A);
                command.Parameters.AddWithValue("CenterID", A.PR.GR);
                command.Parameters.AddWithValue("CenterPhone", this.CenterPhone.Text);
                command.Parameters.AddWithValue("CenterLocation", this.CenterLocation.Text);
                command.Parameters.AddWithValue("CenterCurrencyName", this.CenterCurrencyName.Text);
                command.Parameters.AddWithValue("CenterDecimelPrince", this.CenterDecimelPrince.SelectedItem);
                command.Parameters.AddWithValue("CenterDecimelQuantity", this.CenterDecimelQuantity.SelectedItem);
                command.Parameters.AddWithValue("CenterIsMezan", this.CenterIsMezan.Checked);
                command.Parameters.AddWithValue("CenterMezanType", this.CenterMezanType.SelectedIndex);
                command.Parameters.AddWithValue("CenterMezanHalfOn", Conversion.Val(this.CenterMezanHalfOn.Text));
                command.Parameters.AddWithValue("CenterIsRestorentCafe", this.CenterIsRestorentCafe.Checked);
                command.Parameters.AddWithValue("CenterDisTXT", this.CenterDisTXT.Text);
                command.Parameters.AddWithValue("CenterDisMaWi", Conversion.Val(this.CenterDisMaWi.Text));
                command.Parameters.AddWithValue("CenterDisIFVAL", Conversion.Val(this.CenterDisIFVAL.Text));
                command.Parameters.AddWithValue("CenterDisIFMiWi", Conversion.Val(this.CenterDisIFMiWi.Text));
                command.Parameters.AddWithValue("CenterDarVATNo", this.CenterDarVATNo.Text);
                command.Parameters.AddWithValue("CenterDarMaWi", Conversion.Val(this.CenterDarMaWi.Text));
                command.Parameters.AddWithValue("CenterDarTXT", this.CenterDarTXT.Text);
                command.Parameters.AddWithValue("CenterDarType", Conversion.Val(this.CenterDarType.Text));
                command.Parameters.AddWithValue("CenterSaleIsSaleeb", this.CenterSaleIsSaleeb.Checked);
                command.Parameters.AddWithValue("CenterSaleIsLoss", this.CenterSaleIsLoss.Checked);
                command.Parameters.AddWithValue("CenterIsAllarmQQExip", this.CenterIsAllarmQQExip.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewMainName", this.CenterInvIsViewMainName.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewProft", this.CenterInvIsViewProft.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewCustomer", this.CenterInvIsViewCustomer.Checked);
                command.Parameters.AddWithValue("CenterInvIsCustomerLast", this.CenterInvIsCustomerLast.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewBCode", this.CenterInvIsViewBCode.Checked);
                command.Parameters.AddWithValue("CenterInvIsViwOtherCur", this.CenterInvIsViwOtherCur.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewHedar", this.CenterInvIsViewHedar.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewLogo", this.CenterInvIsViewLogo.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewSigna", this.CenterInvIsViewSigna.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewSubNa", this.CenterInvIsViewSubNa.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewDis", this.CenterInvIsViewDis.Checked);
                command.Parameters.AddWithValue("CenterInvIsViewDar", this.CenterInvIsViewDar.Checked);
                command.Parameters.AddWithValue("CenterInvFotter", this.CenterInvFotter.Text);
                command.Parameters.AddWithValue("CenterMorFeeTaXName", this.CenterMorFeeTaXName.Text);
                command.Parameters.AddWithValue("CenterMorFeeTaXMiaW", Conversion.Val(this.CenterMorFeeTaxMiaW.Text));
                command.Parameters.AddWithValue("CenterMorFeeVALDelivary", Conversion.Val(this.CenterMorFeeVALDelivary.Text));
                command.Parameters.AddWithValue("CenterMorFeeVALTaWasi", Conversion.Val(this.CenterMorFeeVALTaWasi.Text));
                command.Parameters.AddWithValue("CenterMorFeeVALTable", Conversion.Val(this.CenterMorFeeVALTable.Text));
                command.Parameters.AddWithValue("CenterMorFeeVALCardPay", Conversion.Val(this.CenterMorFeeVALCardPay.Text));
                command.Parameters.AddWithValue("CenterInvMAXMIX", this.CenterInvMAXMIX.Checked);
                command.Parameters.AddWithValue("CenterInvSubTotal", this.CenterInvSubTotal.SelectedIndex);
                command.Parameters.AddWithValue("CenterDisAutoIncud", this.CenterDisAutoIncud.Checked);
                command.Parameters.AddWithValue("CenterDarAutoIncud", this.CenterDarAutoIncud.Checked);
                command.Parameters.AddWithValue("CenterInvSubTotalTXT", this.CenterInvSubTotalTXT.Text);
                command.Parameters.AddWithValue("QRText", this.QRText.Text);
                command.Parameters.AddWithValue("CenterPointIFVal", Conversion.Val(this.CenterPointIFVal.Text));
                command.Parameters.AddWithValue("CenterIsViewDarTax", this.CenterIsViewDarTax.Checked);
                command.Parameters.AddWithValue("CenterIsQRSDK", this.CenterIsQRSDK.Checked);
                command.Parameters.AddWithValue("CcSchemeTy", this.CcSchemeTy.Text);
                command.Parameters.AddWithValue("CcSchemeID", this.CcSchemeID.Text);
                command.Parameters.AddWithValue("CcCityName", this.CcCityName.Text);
                command.Parameters.AddWithValue("CcStreetName", this.CcStreetName.Text);
                command.Parameters.AddWithValue("CcBuildingNumber", this.CcBuildingNumber.Text);
                command.Parameters.AddWithValue("CcPlotIdentification", this.CcPlotIdentification.Text);
                command.Parameters.AddWithValue("CcCitySubdivisionName", this.CcCitySubdivisionName.Text);
                command.Parameters.AddWithValue("CcCountrySubentity", this.CcCountrySubentity.Text);
                command.Parameters.AddWithValue("CcPostCode", this.CcPostCode.Text);
                command.Parameters.AddWithValue("CcMorID", this.CcMorID.Text);
                command.ExecuteNonQuery();
                this.A.Close();
                A.PR.ER = this.CenterName.Text;
                A.PR.KR = this.CenterSubName.Text;
                A.PR.UR = this.CenterPhone.Text;
                A.PR.LR = this.CenterLocation.Text;
                A.PR.KR = this.CenterSubName.Text;
                A.PR.VR = Conversions.ToString(this.CenterDecimelPrince.SelectedItem);
                if (this.CenterDecimelPrince.Text == "0")
                {
                    A.PR.YR = "N0";
                    A.PR.T = 0;
                }
                else if (this.CenterDecimelPrince.Text == "0.0")
                {
                    A.PR.YR = "N1";
                    A.PR.T = 1;
                }
                else if (this.CenterDecimelPrince.Text == "0.00")
                {
                    A.PR.YR = "N2";
                    A.PR.T = 2;
                }
                else if (this.CenterDecimelPrince.Text == "0.000")
                {
                    A.PR.YR = "N3";
                    A.PR.T = 3;
                }
                else if (this.CenterDecimelPrince.Text == "0.0000")
                {
                    A.PR.YR = "N4";
                    A.PR.T = 4;
                }
                A.PR.OR = Conversions.ToString(this.CenterDecimelQuantity.SelectedItem);
                if (this.CenterDecimelQuantity.Text == "0")
                {
                    A.PR.BR = "N0";
                    A.PR.X = 0;
                }
                else if (this.CenterDecimelQuantity.Text == "0.0")
                {
                    A.PR.BR = "N1";
                    A.PR.X = 1;
                }
                else if (this.CenterDecimelQuantity.Text == "0.00")
                {
                    A.PR.BR = "N2";
                    A.PR.X = 2;
                }
                else if (this.CenterDecimelQuantity.Text == "0.000")
                {
                    A.PR.BR = "N3";
                    A.PR.X = 3;
                }
                else if (this.CenterDecimelQuantity.Text == "0.0000")
                {
                    A.PR.BR = "N4";
                    A.PR.X = 4;
                }
                A.PR.Y = this.CenterIsMezan.Checked;
                A.PR.SR = Conversions.ToString(this.CenterMezanType.SelectedIndex);
                A.PR.G = (int) Math.Round(Conversion.Val(this.CenterMezanHalfOn.Text));
                A.PR.O = this.CenterIsRestorentCafe.Checked;
                A.PR.ZR = this.CenterDisTXT.Text;
                A.PR.MR = Conversions.ToString(Conversion.Val(this.CenterDisMaWi.Text));
                A.PR.CR = Conversions.ToString(Conversion.Val(this.CenterDisIFVAL.Text));
                A.PR.JR = Conversions.ToString(Conversion.Val(this.CenterDisIFMiWi.Text));
                A.PR.WR = this.CenterDarVATNo.Text;
                A.PR.AP = Conversions.ToString(Conversion.Val(this.CenterDarMaWi.Text));
                A.PR.RP = this.CenterDarTXT.Text;
                A.PR.B = this.CenterSaleIsSaleeb.Checked;
                A.PR.S = this.CenterSaleIsLoss.Checked;
                A.PR.Z = this.CenterIsAllarmQQExip.Checked;
                A.PR.M = this.CenterInvIsViewMainName.Checked;
                A.PR.C = this.CenterInvIsViewProft.Checked;
                A.PR.J = this.CenterInvIsViewCustomer.Checked;
                A.PR.W = this.CenterInvIsCustomerLast.Checked;
                A.PR.AR = this.CenterInvIsViewBCode.Checked;
                A.PR.PR = this.CenterInvIsViwOtherCur.Checked;
                A.PR.QR = this.CenterInvIsViewHedar.Checked;
                A.PR.IR = this.CenterInvIsViewLogo.Checked;
                A.PR.DR = this.CenterInvIsViewSigna.Checked;
                A.PR.FR = this.CenterInvIsViewSubNa.Checked;
                A.PR.HR = this.CenterInvIsViewDis.Checked;
                A.PR.TR = this.CenterInvIsViewDar.Checked;
                A.PR.TR = this.CenterInvIsViewDar.Checked;
                A.PR.QP = this.CenterMorFeeTaXName.Text;
                A.PR.IP = Conversions.ToString(Conversion.Val(this.CenterMorFeeTaxMiaW.Text));
                A.PR.DP = Conversions.ToString(Conversion.Val(this.CenterMorFeeVALDelivary.Text));
                A.PR.FP = Conversions.ToString(Conversion.Val(this.CenterMorFeeVALTaWasi.Text));
                A.PR.HP = Conversions.ToString(Conversion.Val(this.CenterMorFeeVALTable.Text));
                A.PR.TP = Conversions.ToString(Conversion.Val(this.CenterMorFeeVALCardPay.Text));
                A.PR.XR = this.CenterInvMAXMIX.Checked;
                A.PR.E = this.CenterInvSubTotal.SelectedIndex;
                A.PR.GR = this.CenterDisAutoIncud.Checked;
                A.PR.ER = this.CenterDarAutoIncud.Checked;
                A.PR.XP = this.QRText.Text;
                A.PR.GP = Conversions.ToString(Conversion.Val(this.CenterPointIFVal.Text));
                A.PR.UR = this.CenterIsViewDarTax.Checked;
                A.PR.KR = this.CenterIsQRSDK.Checked;
                if (this.CenterDarType0.Checked)
                {
                    A.PR.PP = "0";
                }
                if (this.CenterDarType1.Checked)
                {
                    A.PR.PP = "1";
                }
                Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                if (this.A)
                {
                    Interaction.MsgBox("يجب عليك إعادة تشغيل النظام", MsgBoxStyle.ApplicationModal, null);
                    ProjectData.EndApp();
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

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void PR(object A, EventArgs R)
        {
            this.CenterDarType.Text = "0";
            this.CenterDarTXT.Text = null;
            this.CenterInvSubTotal.SelectedIndex = 0;
        }

        private void Q(object A, EventArgs R)
        {
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.SelectedIndex = 1;
            this.TabControl1.SelectedIndex = 2;
            this.TabControl1.SelectedIndex = 3;
            this.TabControl1.SelectedIndex = 4;
            this.TabControl1.SelectedIndex = 5;
            this.TabControl1.SelectedIndex = 6;
            this.TabControl1.SelectedIndex = 7;
            this.TabControl1.SelectedIndex = 8;
            this.TabControl1.SelectedIndex = 9;
            this.TabControl1.SelectedIndex = 10;
            this.TabControl1.SelectedIndex = 11;
            this.TabControl1.SelectedIndex = 12;
            this.TabControl1.SelectedIndex = 13;
            this.TabControl1.SelectedIndex = 14;
            this.TabControl1.SelectedIndex = 15;
            this.TabControl1.SelectedIndex = 0x10;
            this.TabControl1.SelectedIndex = 0;
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DataTable dataTable = new DataTable();
            string selectCommandText = "SELECT * FROM TaNNCenters WHERE (CenterID = @CenterID)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterID", A.PR.GR);
            adapter.Fill(dataTable);
            this.A.Close();
            this.CenterName.Text = dataTable.Rows[0]["CenterName"].ToString();
            this.CenterSubName.Text = dataTable.Rows[0]["CenterSubName"].ToString();
            this.CenterPhone.Text = dataTable.Rows[0]["CenterPhone"].ToString();
            this.CenterLocation.Text = dataTable.Rows[0]["CenterLocation"].ToString();
            this.CenterCurrencyName.Text = dataTable.Rows[0]["CenterCurrencyName"].ToString();
            this.CenterDecimelPrince.SelectedItem = dataTable.Rows[0]["CenterDecimelPrince"].ToString();
            this.CenterDecimelQuantity.SelectedItem = dataTable.Rows[0]["CenterDecimelQuantity"].ToString();
            this.CenterIsMezan.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterIsMezan"].ToString());
            this.CenterMezanType.SelectedIndex = Conversions.ToInteger(dataTable.Rows[0]["CenterMezanType"].ToString());
            this.CenterMezanHalfOn.Text = dataTable.Rows[0]["CenterMezanHalfOn"].ToString();
            this.CenterIsRestorentCafe.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterIsRestorentCafe"].ToString());
            this.CenterDisTXT.Text = dataTable.Rows[0]["CenterDisTXT"].ToString();
            this.CenterDisMaWi.Text = dataTable.Rows[0]["CenterDisMaWi"].ToString();
            this.CenterDisIFVAL.Text = dataTable.Rows[0]["CenterDisIFVAL"].ToString();
            this.CenterDisIFMiWi.Text = dataTable.Rows[0]["CenterDisIFMiWi"].ToString();
            this.CenterDarVATNo.Text = dataTable.Rows[0]["CenterDarVATNo"].ToString();
            this.CenterDarTXT.Text = dataTable.Rows[0]["CenterDarTXT"].ToString();
            this.CenterDarMaWi.Text = dataTable.Rows[0]["CenterDarMaWi"].ToString();
            this.CenterDarType.Text = dataTable.Rows[0]["CenterDarType"].ToString();
            this.CenterSaleIsSaleeb.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterSaleIsSaleeb"].ToString());
            this.CenterSaleIsLoss.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterSaleIsLoss"].ToString());
            this.CenterIsAllarmQQExip.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterIsAllarmQQExip"].ToString());
            this.CenterInvIsViewMainName.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewMainName"].ToString());
            this.CenterInvIsViewProft.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewProft"].ToString());
            this.CenterInvIsViewCustomer.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewCustomer"].ToString());
            this.CenterInvIsCustomerLast.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsCustomerLast"].ToString());
            this.CenterInvIsViewBCode.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewBCode"].ToString());
            this.CenterInvIsViwOtherCur.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViwOtherCur"].ToString());
            this.CenterInvIsViewHedar.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewHedar"].ToString());
            this.CenterInvIsViewLogo.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewLogo"].ToString());
            this.CenterInvIsViewSigna.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewSigna"].ToString());
            this.CenterInvIsViewSubNa.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewSubNa"].ToString());
            this.CenterInvIsViewDis.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewDis"].ToString());
            this.CenterInvIsViewDar.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvIsViewDar"].ToString());
            this.CenterInvFotter.Text = dataTable.Rows[0]["CenterInvFotter"].ToString();
            this.CenterMorFeeTaXName.Text = dataTable.Rows[0]["CenterMorFeeTaXName"].ToString();
            this.CenterMorFeeTaxMiaW.Text = dataTable.Rows[0]["CenterMorFeeTaxMiaW"].ToString();
            this.CenterMorFeeVALDelivary.Text = dataTable.Rows[0]["CenterMorFeeVALDelivary"].ToString();
            this.CenterMorFeeVALTaWasi.Text = dataTable.Rows[0]["CenterMorFeeVALTaWasi"].ToString();
            this.CenterMorFeeVALTable.Text = dataTable.Rows[0]["CenterMorFeeVALTable"].ToString();
            this.CenterMorFeeVALCardPay.Text = dataTable.Rows[0]["CenterMorFeeVALCardPay"].ToString();
            this.CenterInvMAXMIX.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterInvMAXMIX"].ToString());
            this.CenterDisAutoIncud.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterDisAutoIncud"].ToString());
            this.CenterDarAutoIncud.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterDarAutoIncud"].ToString());
            this.CenterInvSubTotalTXT.Text = dataTable.Rows[0]["CenterInvSubTotalTXT"].ToString();
            this.CenterIsViewDarTax.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterIsViewDarTax"].ToString());
            this.CenterIsQRSDK.Checked = Conversions.ToBoolean(dataTable.Rows[0]["CenterIsQRSDK"].ToString());
            this.CcSchemeTy.Text = dataTable.Rows[0]["CcSchemeTy"].ToString();
            this.CcSchemeID.Text = dataTable.Rows[0]["CcSchemeID"].ToString();
            this.CcPostCode.Text = dataTable.Rows[0]["CcPostCode"].ToString();
            this.CcCityName.Text = dataTable.Rows[0]["CcCityName"].ToString();
            this.CcCountrySubentity.Text = dataTable.Rows[0]["CcCountrySubentity"].ToString();
            this.CcCitySubdivisionName.Text = dataTable.Rows[0]["CcCitySubdivisionName"].ToString();
            this.CcStreetName.Text = dataTable.Rows[0]["CcStreetName"].ToString();
            this.CcBuildingNumber.Text = dataTable.Rows[0]["CcBuildingNumber"].ToString();
            this.CcPlotIdentification.Text = dataTable.Rows[0]["CcPlotIdentification"].ToString();
            this.CcMorID.Text = dataTable.Rows[0]["CcMorID"].ToString();
            this.TxTDDCenterNa.Text = this.CenterSubName.Text;
            if (Conversion.Val(this.CenterDarType.Text) == 0.0)
            {
                this.CenterDarType0.Checked = true;
            }
            if (Conversion.Val(this.CenterDarType.Text) == 1.0)
            {
                this.CenterDarType1.Checked = true;
            }
            this.CenterInvSubTotal.SelectedIndex = Conversions.ToInteger(dataTable.Rows[0]["CenterInvSubTotal"].ToString());
            this.QRText.Text = dataTable.Rows[0]["QRText"].ToString();
            this.CenterPointIFVal.Text = dataTable.Rows[0]["CenterPointIFVal"].ToString();
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

        private void QR(object A, EventArgs R)
        {
            this.CenterDarType.Text = "1";
        }

        private void R(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
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

        private void S(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل انت متأكد من حذف  ## " + this.DTaSuplier.Text + " ## في الفرع المحدد", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNSupliers WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    SqlCommand command2 = new SqlCommand("DELETE FROM TaNNSupliersPay WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command2.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
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

        private void T(object A, EventArgs R)
        {
        }

        private void T(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void TR(object A, EventArgs R)
        {
        }

        private void U(object A, EventArgs R)
        {
        }

        private void V(object A, EventArgs R)
        {
        }

        private void W(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل انت متأكد من حذف  ## " + this.DTaCash.Text + " ## في الفرع المحدد", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNCash WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
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

        private void X(object A, EventArgs R)
        {
        }

        private void X(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(A.PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void XR(object A, EventArgs R)
        {
        }

        private void Y(object A, EventArgs R)
        {
        }

        private void Z(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل انت متأكد من حذف  ## " + this.DTaCustomers.Text + " ## في الفرع المحدد", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNCustomers WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    SqlCommand command2 = new SqlCommand("DELETE FROM TaNNCustomersPay WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command2.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
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

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label Label6
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox CenterDarVATNo
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox CenterDarMaWi
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox CenterDisMaWi
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
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

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual CheckBox CenterInvIsViewSubNa
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CenterInvIsViewHedar
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                CheckBox r = this.R;
                if (r != null)
                {
                    r.CheckedChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox CenterInvIsViewLogo
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual TextBox CenterInvFotter
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TabPage TabPage6
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual CheckBox CenterIsMezan
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual Button ButtonLogoImag
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

        internal virtual ComboBox CenterDecimelQuantity
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox CenterDecimelPrince
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox CenterCurrencyName
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label Label9
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox CenterPhone
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox CenterLocation
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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

        internal virtual Label CenterName
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox CenterSaleIsSaleeb
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Button ButtonOk
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual Label CenterSubName
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual CheckBox CenterIsRestorentCafe
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Button ButtonResturntTabls
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
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

        internal virtual ComboBox CenterMezanType
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TabPage TabPage13
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Button ButtonCurr
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual CheckBox CenterInvIsViwOtherCur
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual CheckBox CenterInvIsCustomerLast
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual CheckBox CenterInvIsViewBCode
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual CheckBox CenterInvIsViewCustomer
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox CenterDisIFMiWi
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
                TextBox h = this.H;
                if (h != null)
                {
                    h.TextChanged -= handler;
                    h.KeyPress -= handler2;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.TextChanged += handler;
                    h.KeyPress += handler2;
                }
            }
        }

        internal virtual Label Label8
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox CenterDisIFVAL
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
                TextBox t = this.T;
                if (t != null)
                {
                    t.TextChanged -= handler;
                    t.KeyPress -= handler2;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.TextChanged += handler;
                    t.KeyPress += handler2;
                }
            }
        }

        internal virtual Label Label7
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Button ButtonHelpBar
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.HR);
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

        internal virtual TabPage TabPage7
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Label TxTDDCenterNa
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Label Label12
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual Label Label10
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual Label Label14
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual ToolStrip ToolStripDelete
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripDropDownButton BDeletSame
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem DTaMaterial
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.B);
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

        internal virtual ToolStripSeparator ToolStripSeparator5
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem DTaSuplier
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
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

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripMenuItem DTaCustomers
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Z);
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

        internal virtual ToolStripSeparator ToolStripSeparator8
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripMenuItem DTaInvSale
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.M);
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

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripMenuItem DTaExpenses
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.C);
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

        internal virtual ToolStripSeparator ToolStripSeparator9
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripMenuItem DTaInvPurch
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.J);
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

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual ToolStripLabel ToolStripLabel2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripButton BDeleteAll
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual TextBox CenterMorFeeVALDelivary
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.T);
                TextBox x = this.X;
                if (x != null)
                {
                    x.TextChanged -= handler;
                    x.KeyPress -= handler2;
                }
                this.X = value;
                x = this.X;
                if (x != null)
                {
                    x.TextChanged += handler;
                    x.KeyPress += handler2;
                }
            }
        }

        internal virtual Label Label16
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual Label Label15
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual TextBox CenterMorFeeVALTable
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.H);
                TextBox g = this.G;
                if (g != null)
                {
                    g.TextChanged -= handler;
                    g.KeyPress -= handler2;
                }
                this.G = value;
                g = this.G;
                if (g != null)
                {
                    g.TextChanged += handler;
                    g.KeyPress += handler2;
                }
            }
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

        internal virtual RadioButton CenterDarType0
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PR);
                EventHandler handler2 = new EventHandler(this.DR);
                RadioButton a = this.A;
                if (a != null)
                {
                    a.Click -= handler;
                    a.CheckedChanged -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Click += handler;
                    a.CheckedChanged += handler2;
                }
            }
        }

        internal virtual TextBox CenterDarType
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual CheckBox CenterIsAllarmQQExip
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TabPage TabPage10
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TextBox CenterMorFeeVALCardPay
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.I);
                TextBox k = this.K;
                if (k != null)
                {
                    k.TextChanged -= handler;
                    k.KeyPress -= handler2;
                }
                this.K = value;
                k = this.K;
                if (k != null)
                {
                    k.TextChanged += handler;
                    k.KeyPress += handler2;
                }
            }
        }

        internal virtual Label Label18
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual Label Label21
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual Label Label20
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual Label Label19
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
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

        internal virtual Label Label24
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual Label Label23
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual TextBox CenterMorFeeTaxMiaW
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.D);
                TextBox u = this.U;
                if (u != null)
                {
                    u.TextChanged -= handler;
                    u.KeyPress -= handler2;
                }
                this.U = value;
                u = this.U;
                if (u != null)
                {
                    u.TextChanged += handler;
                    u.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox CenterMorFeeTaXName
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual Label Label22
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual Label Label25
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual Label Label26
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual Label Label27
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual RadioButton CenterDarType1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.QR);
                EventHandler handler2 = new EventHandler(this.IR);
                RadioButton r = this.R;
                if (r != null)
                {
                    r.CheckedChanged -= handler;
                    r.Click -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.CheckedChanged += handler;
                    r.Click += handler2;
                }
            }
        }

        internal virtual CheckBox CenterInvIsViewProft
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual TextBox CenterDarTXT
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual TextBox CenterDisTXT
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual CheckBox CenterInvIsViewDar
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual CheckBox CenterInvIsViewDis
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual Label Label28
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual TextBox CenterMorFeeVALTaWasi
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.X);
                TextBox y = this.Y;
                if (y != null)
                {
                    y.TextChanged -= handler;
                    y.KeyPress -= handler2;
                }
                this.Y = value;
                y = this.Y;
                if (y != null)
                {
                    y.TextChanged += handler;
                    y.KeyPress += handler2;
                }
            }
        }

        internal virtual Label Label32
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }

        internal virtual CheckBox CenterSaleIsLoss
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ComboBox CenterMezanHalfOn
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripMenuItem DTaCash
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.W);
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

        internal virtual CheckBox CenterInvIsViewMainName
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual CheckBox CenterInvIsViewSigna
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual Label Label17
        {
            [CompilerGenerated]
            get => 
                this.AR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.AR = value);
        }

        internal virtual Label Label13
        {
            [CompilerGenerated]
            get => 
                this.PR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.PR = value);
        }

        internal virtual CheckBox CenterInvMAXMIX
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual TabPage TabPage9
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual Button ButtonSaleSeet
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.AR);
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

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Label Label11
        {
            [CompilerGenerated]
            get => 
                this.QR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.QR = value);
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual ComboBox CenterInvSubTotal
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.FR);
                ComboBox i = this.I;
                if (i != null)
                {
                    i.SelectedIndexChanged -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual CheckBox CenterDarAutoIncud
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual CheckBox CenterDisAutoIncud
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TextBox CenterInvSubTotalTXT
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual Label Label30
        {
            [CompilerGenerated]
            get => 
                this.IR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.IR = value);
        }

        internal virtual TextBox QRText
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
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

        internal virtual TextBox CenterPointIFVal
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.TR);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.G);
                TextBox s = this.S;
                if (s != null)
                {
                    s.TextChanged -= handler;
                    s.KeyPress -= handler2;
                }
                this.S = value;
                s = this.S;
                if (s != null)
                {
                    s.TextChanged += handler;
                    s.KeyPress += handler2;
                }
            }
        }

        internal virtual Label Label31
        {
            [CompilerGenerated]
            get => 
                this.DR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.DR = value);
        }

        internal virtual CheckBox CenterIsViewDarTax
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual CheckBox CenterIsQRSDK
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.XR);
                EventHandler handler2 = new EventHandler(this.GR);
                CheckBox z = this.Z;
                if (z != null)
                {
                    z.CheckedChanged -= handler;
                    z.Click -= handler2;
                }
                this.Z = value;
                z = this.Z;
                if (z != null)
                {
                    z.CheckedChanged += handler;
                    z.Click += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual TabPage TabPage11
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual GroupBox GroupBox26
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual TextBox CcMorID
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual GroupBox GroupBox25
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual TextBox CcPostCode
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual GroupBox GroupBox22
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual TextBox CcCountrySubentity
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual GroupBox GroupBox21
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual TextBox CcCityName
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual GroupBox GroupBox20
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual TextBox CcCitySubdivisionName
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual TextBox CcStreetName
        {
            [CompilerGenerated]
            get => 
                this.AR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.AR = value);
        }

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual TextBox CcSchemeID
        {
            [CompilerGenerated]
            get => 
                this.PR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.PR = value);
        }

        internal virtual GroupBox GroupBox18
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual TextBox CcBuildingNumber
        {
            [CompilerGenerated]
            get => 
                this.QR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.QR = value);
        }

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual GroupBox GroupBox19
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual TextBox CcPlotIdentification
        {
            [CompilerGenerated]
            get => 
                this.IR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.IR = value);
        }

        internal virtual ComboBox CcSchemeTy
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Button ButtonHelp
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ER);
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

        internal virtual Button ButtonDisableSDK
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.KR);
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
    }
}

