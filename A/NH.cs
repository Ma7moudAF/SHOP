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
    public class NH : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonExpee")]
        private ToolStripDropDownButton A;
        [CompilerGenerated, AccessedThroughProperty("ButtonExpeeAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator20")]
        private ToolStripSeparator A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonExpeeList")]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("ToolStripSeparator22"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ButtonRemme"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton R;
        [AccessedThroughProperty("ButtonRemmemAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator21")]
        private ToolStripSeparator P;
        [AccessedThroughProperty("ButtonReammemList"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem Q;
        [AccessedThroughProperty("ToolStripSeparator14"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [CompilerGenerated, AccessedThroughProperty("ButtonEmploy"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator23"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator I;
        [AccessedThroughProperty("ToolStripMenu"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripLabel1")]
        private ToolStripLabel A;
        [CompilerGenerated, AccessedThroughProperty("TxTSubCenterName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButonChangeCenter")]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator D;
        [AccessedThroughProperty("ToolStripLabel2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel P;
        [AccessedThroughProperty("TxTUserName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripLabel Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator2"), CompilerGenerated]
        private ToolStripSeparator F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripLabel4")]
        private ToolStripLabel I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTAccess")]
        private ToolStripLabel D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTip")]
        private Label A;
        [AccessedThroughProperty("ImLogoHome"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripHomeMenu"), CompilerGenerated]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripSeparator4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator T;
        [AccessedThroughProperty("ToolStripSeparator10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator X;
        [AccessedThroughProperty("ToolStripSeparator5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator G;
        [AccessedThroughProperty("ButtonSuplier"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripDropDownButton P;
        [AccessedThroughProperty("ButtonSuplierAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem I;
        [AccessedThroughProperty("ToolStripSeparator17"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator E;
        [AccessedThroughProperty("ButtonSplierAddPay"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem D;
        [AccessedThroughProperty("ToolStripSeparator18"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator K;
        [AccessedThroughProperty("ButtonSplierList"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem F;
        [AccessedThroughProperty("ToolStripSeparator6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator U;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSale")]
        private ToolStripDropDownButton Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSaleSale"), CompilerGenerated]
        private ToolStripMenuItem H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator9")]
        private ToolStripSeparator L;
        [CompilerGenerated, AccessedThroughProperty("ButtonQuerySale"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem T;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator N;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator11"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator V;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonCustmer")]
        private ToolStripDropDownButton I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonCustomerAdd")]
        private ToolStripMenuItem X;
        [AccessedThroughProperty("ToolStripSeparator15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator Y;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonCustumerAddPay")]
        private ToolStripMenuItem G;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator16"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator O;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonCustumerList")]
        private ToolStripMenuItem E;
        [AccessedThroughProperty("ToolStripSeparator8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator B;
        [AccessedThroughProperty("PanelHedar"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonInvSale")]
        private ToolStripDropDownButton D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonIvoSaleList"), CompilerGenerated]
        private ToolStripMenuItem K;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonIvoSaleHistory")]
        private ToolStripMenuItem U;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSetting")]
        private ToolStripDropDownButton F;
        [AccessedThroughProperty("ButtinSubSetting"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem L;
        [AccessedThroughProperty("ButtonMainSetting"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem N;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerChangeColor")]
        private Timer A;
        [AccessedThroughProperty("ButtonInvPursh"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripDropDownButton H;
        [AccessedThroughProperty("ButAddPurch"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem V;
        [AccessedThroughProperty("PutListPurch"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem Y;
        [AccessedThroughProperty("BuChangeUser"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton P;
        [CompilerGenerated, AccessedThroughProperty("TimerStyleHedarTxT"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator28"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator S;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator31")]
        private ToolStripSeparator Z;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator33"), CompilerGenerated]
        private ToolStripSeparator M;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator34"), CompilerGenerated]
        private ToolStripSeparator C;
        [AccessedThroughProperty("ButUserGReport"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator36")]
        private ToolStripSeparator J;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerCheckNumberDate")]
        private Timer P;
        [CompilerGenerated, AccessedThroughProperty("TimerStarts"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer Q;
        [AccessedThroughProperty("UpdateCheck"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator37"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator W;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("BuCuQQ")]
        private ToolStripMenuItem O;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator39")]
        private ToolStripSeparator AR;
        [AccessedThroughProperty("ToolStripSeparator41"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator PR;
        [AccessedThroughProperty("PanelTop"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel A;
        [AccessedThroughProperty("ToolStrip1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonAbout")]
        private ToolStripButton I;
        [AccessedThroughProperty("ToolStripSeparator77"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator QR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSupport")]
        private ToolStripButton D;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator80"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator IR;
        [AccessedThroughProperty("ButtonHelp"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator81")]
        private ToolStripSeparator DR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonUpdate")]
        private ToolStripButton H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonWareHous")]
        private ToolStripDropDownButton T;
        [CompilerGenerated, AccessedThroughProperty("ButtWarehousAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem B;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator29"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator FR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonWareHousM")]
        private ToolStripMenuItem S;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PanelLeft")]
        private Panel R;
        [AccessedThroughProperty("ButtonMenuShow"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonMenuHide")]
        private Button P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator13"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator HR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTVerNumber")]
        private Label P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DateTimeMainValu")]
        private ToolStripLabel F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonCash")]
        private ToolStripButton T;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator12")]
        private ToolStripSeparator TR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("PutListPurchItems")]
        private ToolStripMenuItem Z;
        [CompilerGenerated, AccessedThroughProperty("ButtonBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerLoadRemnber"), CompilerGenerated]
        private Timer I;
        [AccessedThroughProperty("PanelButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Panel P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GV")]
        private DataGridView A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonCloudPrinter"), CompilerGenerated]
        private Button Q;
        [AccessedThroughProperty("LabelDB"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerTiclString"), CompilerGenerated]
        private Timer D;
        [AccessedThroughProperty("TimerRefreshCon"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer F;
        [AccessedThroughProperty("ToolStripSeparator19"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator XR;
        [AccessedThroughProperty("ToolStripMenuItem1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem M;
        [AccessedThroughProperty("ButtonMyFile"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripDropDownButton X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("DBSerViewToolStripMenuItem")]
        private ToolStripMenuItem C;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DBSerRestToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem J;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator24")]
        private ToolStripSeparator GR;
        [CompilerGenerated, AccessedThroughProperty("LabelTr"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PanelStand"), CompilerGenerated]
        private Panel Q;
        [CompilerGenerated, AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [AccessedThroughProperty("ButtonStandHide"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonStandPrint"), CompilerGenerated]
        private Button D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonStandCash"), CompilerGenerated]
        private Button F;
        [AccessedThroughProperty("ButtonStandQuery"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button H;
        [AccessedThroughProperty("ButtonStandPendin"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonStandNewInvoice")]
        private Button X;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxCloseSale"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        private MdiClient A;
        private SqlConnection A;
        private string A;
        private string R;
        private Image A;
        private int A;
        public static bool A = false;
        private string P;
        private string Q;
        private string I;
        private string D;
        private string F;
        private int R;
        private int P;

        public NH()
        {
            IEnumerator enumerator;
            base.Load += new EventHandler(this.A);
            base.FormClosed += new FormClosedEventHandler(this.A);
            base.Shown += new EventHandler(this.K);
            base.KeyUp += new KeyEventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = Application.StartupPath + @"\MaDon";
            this.R = Application.StartupPath + @"\CloudDon";
            this.A = A.F.ImHideAlarm;
            this.A = 1;
            this.P = "* مهم جداً ... يجب عليك اخذ نسخة احتياطية من قاعدة البيانات بشكل منتظم وحفظها في مكان امن خارج هذا الجهاز.";
            this.Q = "* سيتم حفظ النسخ الاحتياطي بشكل تلقائي في مجلد النظام الرئيسي (BackupDB) ويجب عليك نسخه لمكان آمن.";
            this.I = "* يفضل استخدام برنامج (Google Drive) او (Microsoft One Drive) من اجل مزامنة الملفات النسخ الاحتياطي على حسابك.";
            this.D = "* يمكنك استخدام برنامج (Google Drive) او (Microsoft One Drive) من اجل مزامنة مجلد (BackUpDB) بشكل تلقائي.";
            this.F = "* تنبيه: ان مسؤولية امان قاعدة البيانات وحفظها من الفايروسات عليك، نحن نوفر اقصى درجات الأمان للنظام ولكن عليك الحرص من الفايروسات او من تلف المعدات.";
            this.A();
            this.A = null;
            try
            {
                enumerator = base.Controls.GetEnumerator();
                while (true)
                {
                    if (enumerator.MoveNext())
                    {
                        Control current = (Control) enumerator.Current;
                        this.A = current as MdiClient;
                        if (this.A == null)
                        {
                            continue;
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
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(NH));
            this.ToolStripSeparator22 = new ToolStripSeparator();
            this.ToolStripSeparator14 = new ToolStripSeparator();
            this.ToolStripSeparator23 = new ToolStripSeparator();
            this.ToolStripMenu = new ToolStrip();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTSubCenterName = new ToolStripLabel();
            this.ButonChangeCenter = new ToolStripButton();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.ToolStripLabel2 = new ToolStripLabel();
            this.TxTUserName = new ToolStripLabel();
            this.BuChangeUser = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripLabel4 = new ToolStripLabel();
            this.TxTAccess = new ToolStripLabel();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.DateTimeMainValu = new ToolStripLabel();
            this.ToolStripSeparator34 = new ToolStripSeparator();
            this.TxTTip = new Label();
            this.ToolStripHomeMenu = new ToolStrip();
            this.ButtonWareHous = new ToolStripDropDownButton();
            this.ButtWarehousAdd = new ToolStripMenuItem();
            this.ToolStripSeparator29 = new ToolStripSeparator();
            this.ButtonWareHousM = new ToolStripMenuItem();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ButtonBarCode = new ToolStripButton();
            this.ToolStripSeparator10 = new ToolStripSeparator();
            this.ButtonInvPursh = new ToolStripDropDownButton();
            this.ButAddPurch = new ToolStripMenuItem();
            this.ToolStripSeparator28 = new ToolStripSeparator();
            this.PutListPurch = new ToolStripMenuItem();
            this.ToolStripSeparator12 = new ToolStripSeparator();
            this.PutListPurchItems = new ToolStripMenuItem();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ButtonSuplier = new ToolStripDropDownButton();
            this.ButtonSuplierAdd = new ToolStripMenuItem();
            this.ToolStripSeparator17 = new ToolStripSeparator();
            this.ButtonSplierAddPay = new ToolStripMenuItem();
            this.ToolStripSeparator18 = new ToolStripSeparator();
            this.ButtonSplierList = new ToolStripMenuItem();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ButtonSale = new ToolStripDropDownButton();
            this.ButtonSaleSale = new ToolStripMenuItem();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.ButtonQuerySale = new ToolStripMenuItem();
            this.ToolStripSeparator37 = new ToolStripSeparator();
            this.BuCuQQ = new ToolStripMenuItem();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ButtonInvSale = new ToolStripDropDownButton();
            this.ButtonIvoSaleList = new ToolStripMenuItem();
            this.ToolStripSeparator31 = new ToolStripSeparator();
            this.ButtonIvoSaleHistory = new ToolStripMenuItem();
            this.ToolStripSeparator19 = new ToolStripSeparator();
            this.ToolStripMenuItem1 = new ToolStripMenuItem();
            this.ToolStripSeparator11 = new ToolStripSeparator();
            this.ButtonCustmer = new ToolStripDropDownButton();
            this.ButtonCustomerAdd = new ToolStripMenuItem();
            this.ToolStripSeparator15 = new ToolStripSeparator();
            this.ButtonCustumerAddPay = new ToolStripMenuItem();
            this.ToolStripSeparator16 = new ToolStripSeparator();
            this.ButtonCustumerList = new ToolStripMenuItem();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ButtonExpee = new ToolStripDropDownButton();
            this.ButtonExpeeAdd = new ToolStripMenuItem();
            this.ToolStripSeparator20 = new ToolStripSeparator();
            this.ButtonExpeeList = new ToolStripMenuItem();
            this.ButUserGReport = new ToolStripButton();
            this.ButtonCash = new ToolStripButton();
            this.ToolStripSeparator36 = new ToolStripSeparator();
            this.ButtonRemme = new ToolStripDropDownButton();
            this.ButtonRemmemAdd = new ToolStripMenuItem();
            this.ToolStripSeparator21 = new ToolStripSeparator();
            this.ButtonReammemList = new ToolStripMenuItem();
            this.ToolStripSeparator39 = new ToolStripSeparator();
            this.ButtonEmploy = new ToolStripButton();
            this.ButtonSetting = new ToolStripDropDownButton();
            this.ButtinSubSetting = new ToolStripMenuItem();
            this.ToolStripSeparator33 = new ToolStripSeparator();
            this.ButtonMainSetting = new ToolStripMenuItem();
            this.ToolStripSeparator41 = new ToolStripSeparator();
            this.TimerChangeColor = new Timer(this.A);
            this.TimerStyleHedarTxT = new Timer(this.A);
            this.TimerCheckNumberDate = new Timer(this.A);
            this.TimerStarts = new Timer(this.A);
            this.UpdateCheck = new Label();
            this.PanelTop = new Panel();
            this.PanelHedar = new Button();
            this.ToolStrip1 = new ToolStrip();
            this.ButtonAbout = new ToolStripButton();
            this.ToolStripSeparator77 = new ToolStripSeparator();
            this.ButtonSupport = new ToolStripButton();
            this.ToolStripSeparator80 = new ToolStripSeparator();
            this.ButtonMyFile = new ToolStripDropDownButton();
            this.DBSerViewToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator24 = new ToolStripSeparator();
            this.DBSerRestToolStripMenuItem = new ToolStripMenuItem();
            this.ButtonHelp = new ToolStripButton();
            this.ToolStripSeparator81 = new ToolStripSeparator();
            this.ButtonUpdate = new ToolStripButton();
            this.ToolStripSeparator13 = new ToolStripSeparator();
            this.PanelLeft = new Panel();
            this.ImLogoHome = new PictureBox();
            this.TxTVerNumber = new Label();
            this.ButtonMenuShow = new Button();
            this.ButtonMenuHide = new Button();
            this.TimerLoadRemnber = new Timer(this.A);
            this.PanelButtons = new Panel();
            this.GV = new DataGridView();
            this.ButtonCloudPrinter = new Button();
            this.LabelDB = new Label();
            this.TimerTiclString = new Timer(this.A);
            this.TimerRefreshCon = new Timer(this.A);
            this.LabelTr = new Label();
            this.PanelStand = new Panel();
            this.CheckBoxCloseSale = new CheckBox();
            this.ButtonStandHide = new Button();
            this.ButtonStandPrint = new Button();
            this.ButtonStandCash = new Button();
            this.ButtonStandQuery = new Button();
            this.ButtonStandPendin = new Button();
            this.ButtonStandNewInvoice = new Button();
            this.TxTTitle = new Label();
            this.ToolStripMenu.SuspendLayout();
            this.ToolStripHomeMenu.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            ((ISupportInitialize) this.ImLogoHome).BeginInit();
            this.PanelButtons.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.PanelStand.SuspendLayout();
            base.SuspendLayout();
            this.ToolStripSeparator22.Name = "ToolStripSeparator22";
            this.ToolStripSeparator22.Size = new Size(0x156, 6);
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            this.ToolStripSeparator14.Size = new Size(0x156, 6);
            this.ToolStripSeparator23.Name = "ToolStripSeparator23";
            this.ToolStripSeparator23.Size = new Size(0x156, 6);
            this.ToolStripMenu.AutoSize = false;
            this.ToolStripMenu.Dock = DockStyle.Bottom;
            this.ToolStripMenu.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripMenu.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripMenu.ImageScalingSize = new Size(20, 20);
            ToolStripItem[] toolStripItems = new ToolStripItem[13];
            toolStripItems[0] = this.ToolStripLabel1;
            toolStripItems[1] = this.TxTSubCenterName;
            toolStripItems[2] = this.ButonChangeCenter;
            toolStripItems[3] = this.ToolStripSeparator1;
            toolStripItems[4] = this.ToolStripLabel2;
            toolStripItems[5] = this.TxTUserName;
            toolStripItems[6] = this.BuChangeUser;
            toolStripItems[7] = this.ToolStripSeparator2;
            toolStripItems[8] = this.ToolStripLabel4;
            toolStripItems[9] = this.TxTAccess;
            toolStripItems[10] = this.ToolStripSeparator3;
            toolStripItems[11] = this.DateTimeMainValu;
            toolStripItems[12] = this.ToolStripSeparator34;
            this.ToolStripMenu.Items.AddRange(toolStripItems);
            this.ToolStripMenu.Location = new Point(380, 0x31e);
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Size = new Size(0x3c6, 0x23);
            this.ToolStripMenu.Stretch = true;
            this.ToolStripMenu.TabIndex = 10;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x67, 0x20);
            this.ToolStripLabel1.Text = "الفرع/ المستودع:";
            this.TxTSubCenterName.ForeColor = Color.Green;
            this.TxTSubCenterName.Name = "TxTSubCenterName";
            this.TxTSubCenterName.Size = new Size(0x1c, 0x20);
            this.TxTSubCenterName.Text = ".....";
            this.ButonChangeCenter.Enabled = false;
            this.ButonChangeCenter.Image = A.F.ImChange;
            this.ButonChangeCenter.ImageTransparentColor = Color.Magenta;
            this.ButonChangeCenter.Name = "ButonChangeCenter";
            this.ButonChangeCenter.Size = new Size(0x3d, 0x20);
            this.ButonChangeCenter.Text = "تبديل";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x23);
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new Size(0x37, 0x20);
            this.ToolStripLabel2.Text = "الموظف:";
            this.TxTUserName.ForeColor = Color.Green;
            this.TxTUserName.Name = "TxTUserName";
            this.TxTUserName.Size = new Size(0x1c, 0x20);
            this.TxTUserName.Text = ".....";
            this.BuChangeUser.Image = A.F.ImChange;
            this.BuChangeUser.ImageTransparentColor = Color.Magenta;
            this.BuChangeUser.Name = "BuChangeUser";
            this.BuChangeUser.Size = new Size(0x3d, 0x20);
            this.BuChangeUser.Text = "تبديل";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x23);
            this.ToolStripLabel4.Name = "ToolStripLabel4";
            this.ToolStripLabel4.Size = new Size(0x44, 0x20);
            this.ToolStripLabel4.Text = "الصلاحيات:";
            this.TxTAccess.ForeColor = Color.Green;
            this.TxTAccess.Name = "TxTAccess";
            this.TxTAccess.Size = new Size(0x1c, 0x20);
            this.TxTAccess.Text = ".....";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x23);
            this.DateTimeMainValu.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.DateTimeMainValu.Enabled = false;
            this.DateTimeMainValu.Image = A.F.ImCalunder;
            this.DateTimeMainValu.ImageTransparentColor = Color.Magenta;
            this.DateTimeMainValu.Name = "DateTimeMainValu";
            this.DateTimeMainValu.RightToLeft = RightToLeft.No;
            this.DateTimeMainValu.Size = new Size(0x1c, 0x20);
            this.DateTimeMainValu.Text = ".....";
            this.ToolStripSeparator34.Name = "ToolStripSeparator34";
            this.ToolStripSeparator34.Size = new Size(6, 0x23);
            this.TxTTip.BorderStyle = BorderStyle.FixedSingle;
            this.TxTTip.Dock = DockStyle.Bottom;
            this.TxTTip.ForeColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.TxTTip.Location = new Point(380, 0x305);
            this.TxTTip.Name = "TxTTip";
            this.TxTTip.Size = new Size(0x3c6, 0x19);
            this.TxTTip.TabIndex = 11;
            this.ToolStripHomeMenu.BackColor = Color.White;
            this.ToolStripHomeMenu.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripHomeMenu.GripMargin = new Padding(10);
            this.ToolStripHomeMenu.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripHomeMenu.ImageScalingSize = new Size(30, 30);
            ToolStripItem[] itemArray2 = new ToolStripItem[0x1a];
            itemArray2[0] = this.ButtonWareHous;
            itemArray2[1] = this.ToolStripSeparator4;
            itemArray2[2] = this.ButtonBarCode;
            itemArray2[3] = this.ToolStripSeparator10;
            itemArray2[4] = this.ButtonInvPursh;
            itemArray2[5] = this.ToolStripSeparator5;
            itemArray2[6] = this.ButtonSuplier;
            itemArray2[7] = this.ToolStripSeparator6;
            itemArray2[8] = this.ButtonSale;
            itemArray2[9] = this.ToolStripSeparator7;
            itemArray2[10] = this.ButtonInvSale;
            itemArray2[11] = this.ToolStripSeparator11;
            itemArray2[12] = this.ButtonCustmer;
            itemArray2[13] = this.ToolStripSeparator8;
            itemArray2[14] = this.ButtonExpee;
            itemArray2[15] = this.ToolStripSeparator14;
            itemArray2[0x10] = this.ButUserGReport;
            itemArray2[0x11] = this.ToolStripSeparator22;
            itemArray2[0x12] = this.ButtonCash;
            itemArray2[0x13] = this.ToolStripSeparator36;
            itemArray2[20] = this.ButtonRemme;
            itemArray2[0x15] = this.ToolStripSeparator39;
            itemArray2[0x16] = this.ButtonEmploy;
            itemArray2[0x17] = this.ToolStripSeparator23;
            itemArray2[0x18] = this.ButtonSetting;
            itemArray2[0x19] = this.ToolStripSeparator41;
            this.ToolStripHomeMenu.Items.AddRange(itemArray2);
            this.ToolStripHomeMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ToolStripHomeMenu.Location = new Point(0, 0);
            this.ToolStripHomeMenu.Margin = new Padding(10);
            this.ToolStripHomeMenu.Name = "ToolStripHomeMenu";
            this.ToolStripHomeMenu.Padding = new Padding(10);
            this.ToolStripHomeMenu.Size = new Size(0x16b, 0x32f);
            this.ToolStripHomeMenu.Stretch = true;
            this.ToolStripHomeMenu.TabIndex = 0x1f;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ButtWarehousAdd, this.ToolStripSeparator29, this.ButtonWareHousM };
            this.ButtonWareHous.DropDownItems.AddRange(itemArray3);
            this.ButtonWareHous.Enabled = false;
            this.ButtonWareHous.Image = A.F.ImWarehouse;
            this.ButtonWareHous.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonWareHous.ImageTransparentColor = Color.Magenta;
            this.ButtonWareHous.Name = "ButtonWareHous";
            this.ButtonWareHous.Size = new Size(0x156, 0x34);
            this.ButtonWareHous.Text = "جرد وإدارة المستودع | الاصناف";
            this.ButtonWareHous.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtWarehousAdd.Image = A.F.ImAdd;
            this.ButtWarehousAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtWarehousAdd.Name = "ButtWarehousAdd";
            this.ButtWarehousAdd.Size = new Size(0xd1, 0x26);
            this.ButtWarehousAdd.Text = "إضافة مادة";
            this.ToolStripSeparator29.Name = "ToolStripSeparator29";
            this.ToolStripSeparator29.Size = new Size(0xce, 6);
            this.ButtonWareHousM.Image = A.F.ImWarehouse;
            this.ButtonWareHousM.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonWareHousM.Name = "ButtonWareHousM";
            this.ButtonWareHousM.Size = new Size(0xd1, 0x26);
            this.ButtonWareHousM.Text = "الجرد وإدارة المستودع";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(0x156, 6);
            this.ButtonBarCode.Enabled = false;
            this.ButtonBarCode.Image = A.F.ImBarCode;
            this.ButtonBarCode.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonBarCode.ImageTransparentColor = Color.Magenta;
            this.ButtonBarCode.Name = "ButtonBarCode";
            this.ButtonBarCode.Size = new Size(0x156, 0x34);
            this.ButtonBarCode.Text = "صانع ملصقات باركود";
            this.ButtonBarCode.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new Size(0x156, 6);
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.ButAddPurch, this.ToolStripSeparator28, this.PutListPurch, this.ToolStripSeparator12, this.PutListPurchItems };
            this.ButtonInvPursh.DropDownItems.AddRange(itemArray4);
            this.ButtonInvPursh.Enabled = false;
            this.ButtonInvPursh.Image = A.F.ImInvPursh;
            this.ButtonInvPursh.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonInvPursh.ImageTransparentColor = Color.Magenta;
            this.ButtonInvPursh.Name = "ButtonInvPursh";
            this.ButtonInvPursh.Size = new Size(0x156, 0x34);
            this.ButtonInvPursh.Text = "إدارة فواتير المشتريات | مرتجع المشتريات";
            this.ButtonInvPursh.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtonInvPursh.ToolTipText = "إدارة فواتير المشتريات | مرتجع المشتريات";
            this.ButAddPurch.Image = A.F.ImAdd;
            this.ButAddPurch.ImageScaling = ToolStripItemImageScaling.None;
            this.ButAddPurch.Name = "ButAddPurch";
            this.ButAddPurch.Size = new Size(0x16c, 0x26);
            this.ButAddPurch.Text = "اضافة فاتورة مشتريات | مرتجع مشتريات";
            this.ToolStripSeparator28.Name = "ToolStripSeparator28";
            this.ToolStripSeparator28.Size = new Size(0x169, 6);
            this.PutListPurch.Image = A.F.ImInvPursh;
            this.PutListPurch.ImageScaling = ToolStripItemImageScaling.None;
            this.PutListPurch.Name = "PutListPurch";
            this.PutListPurch.Size = new Size(0x16c, 0x26);
            this.PutListPurch.Text = "إدارة قائمة فواتير مشتريات | مرتجع مشتريات";
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            this.ToolStripSeparator12.Size = new Size(0x169, 6);
            this.PutListPurchItems.Image = A.F.ImExpense;
            this.PutListPurchItems.Name = "PutListPurchItems";
            this.PutListPurchItems.Size = new Size(0x16c, 0x26);
            this.PutListPurchItems.Text = "سجل المشتريات |  مرتجع مشتريات حسب المادة";
            this.ToolStripSeparator5.ForeColor = Color.Green;
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(0x156, 6);
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.ButtonSuplierAdd, this.ToolStripSeparator17, this.ButtonSplierAddPay, this.ToolStripSeparator18, this.ButtonSplierList };
            this.ButtonSuplier.DropDownItems.AddRange(itemArray5);
            this.ButtonSuplier.Enabled = false;
            this.ButtonSuplier.Image = A.F.ImSuplier;
            this.ButtonSuplier.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonSuplier.ImageTransparentColor = Color.Magenta;
            this.ButtonSuplier.Name = "ButtonSuplier";
            this.ButtonSuplier.Size = new Size(0x156, 0x34);
            this.ButtonSuplier.Text = "إدارة الموردين";
            this.ButtonSuplier.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtonSuplierAdd.Image = A.F.ImSuplierAdd;
            this.ButtonSuplierAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonSuplierAdd.Name = "ButtonSuplierAdd";
            this.ButtonSuplierAdd.Size = new Size(0xc5, 0x26);
            this.ButtonSuplierAdd.Text = "اضافة مورد جديد";
            this.ToolStripSeparator17.Name = "ToolStripSeparator17";
            this.ToolStripSeparator17.Size = new Size(0xc2, 6);
            this.ButtonSplierAddPay.Image = A.F.ImMoney;
            this.ButtonSplierAddPay.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonSplierAddPay.Name = "ButtonSplierAddPay";
            this.ButtonSplierAddPay.Size = new Size(0xc5, 0x26);
            this.ButtonSplierAddPay.Text = "اضافة دفعة مورد";
            this.ToolStripSeparator18.Name = "ToolStripSeparator18";
            this.ToolStripSeparator18.Size = new Size(0xc2, 6);
            this.ButtonSplierList.Image = A.F.ImSuplier;
            this.ButtonSplierList.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonSplierList.Name = "ButtonSplierList";
            this.ButtonSplierList.Size = new Size(0xc5, 0x26);
            this.ButtonSplierList.Text = "إدارة قائمة الموردين";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new Size(0x156, 6);
            this.ButtonSale.BackColor = SystemColors.Info;
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.ButtonSaleSale, this.ToolStripSeparator9, this.ButtonQuerySale, this.ToolStripSeparator37, this.BuCuQQ };
            this.ButtonSale.DropDownItems.AddRange(itemArray6);
            this.ButtonSale.Enabled = false;
            this.ButtonSale.Image = A.F.ImSale;
            this.ButtonSale.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonSale.ImageTransparentColor = Color.Magenta;
            this.ButtonSale.Name = "ButtonSale";
            this.ButtonSale.Size = new Size(0x156, 0x34);
            this.ButtonSale.Text = "شاشة الاستعلام | شاشة البيع والاسترجاع";
            this.ButtonSale.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtonSaleSale.Image = A.F.ImSale;
            this.ButtonSaleSale.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonSaleSale.Name = "ButtonSaleSale";
            this.ButtonSaleSale.Size = new Size(0x149, 0x26);
            this.ButtonSaleSale.Text = "شاشة الاستعلام | شاشة البيع والاسترجاع";
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new Size(0x146, 6);
            this.ButtonQuerySale.Image = A.F.ImView;
            this.ButtonQuerySale.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonQuerySale.Name = "ButtonQuerySale";
            this.ButtonQuerySale.Size = new Size(0x149, 0x26);
            this.ButtonQuerySale.Text = "شاشة الاستعلام";
            this.ToolStripSeparator37.Name = "ToolStripSeparator37";
            this.ToolStripSeparator37.Size = new Size(0x146, 6);
            this.BuCuQQ.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.BuCuQQ.Name = "BuCuQQ";
            this.BuCuQQ.Size = new Size(0x149, 0x26);
            this.BuCuQQ.Text = "شاشة استعلام الاسعار للزوار المتجر";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(0x156, 6);
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.ButtonIvoSaleList, this.ToolStripSeparator31, this.ButtonIvoSaleHistory, this.ToolStripSeparator19, this.ToolStripMenuItem1 };
            this.ButtonInvSale.DropDownItems.AddRange(itemArray7);
            this.ButtonInvSale.Enabled = false;
            this.ButtonInvSale.Image = A.F.ImInvoice;
            this.ButtonInvSale.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonInvSale.ImageTransparentColor = Color.Magenta;
            this.ButtonInvSale.Name = "ButtonInvSale";
            this.ButtonInvSale.Size = new Size(0x156, 0x34);
            this.ButtonInvSale.Text = "إدارة فواتير المبيعات | مرتجع المبيعات";
            this.ButtonInvSale.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtonInvSale.ToolTipText = "إدارة فواتير المبيعات | مرتجع المبيعات";
            this.ButtonIvoSaleList.Image = A.F.ImInvoice;
            this.ButtonIvoSaleList.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonIvoSaleList.Name = "ButtonIvoSaleList";
            this.ButtonIvoSaleList.Size = new Size(0x12b, 0x26);
            this.ButtonIvoSaleList.Text = "قائمة فواتير المبيعات | مرتجع المبيعات";
            this.ToolStripSeparator31.Name = "ToolStripSeparator31";
            this.ToolStripSeparator31.Size = new Size(0x128, 6);
            this.ButtonIvoSaleHistory.Image = A.F.ImSaleList;
            this.ButtonIvoSaleHistory.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonIvoSaleHistory.Name = "ButtonIvoSaleHistory";
            this.ButtonIvoSaleHistory.Size = new Size(0x12b, 0x26);
            this.ButtonIvoSaleHistory.Text = "سجل البيع | المرتجع (الكامل)";
            this.ToolStripSeparator19.Name = "ToolStripSeparator19";
            this.ToolStripSeparator19.Size = new Size(0x128, 6);
            this.ToolStripMenuItem1.Image = A.F.ImSaleList;
            this.ToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new Size(0x12b, 0x26);
            this.ToolStripMenuItem1.Text = "سجل البيع | المرتجع  (المختصر)";
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new Size(0x156, 6);
            ToolStripItem[] itemArray8 = new ToolStripItem[] { this.ButtonCustomerAdd, this.ToolStripSeparator15, this.ButtonCustumerAddPay, this.ToolStripSeparator16, this.ButtonCustumerList };
            this.ButtonCustmer.DropDownItems.AddRange(itemArray8);
            this.ButtonCustmer.Enabled = false;
            this.ButtonCustmer.Image = A.F.ImCustumer;
            this.ButtonCustmer.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonCustmer.ImageTransparentColor = Color.Magenta;
            this.ButtonCustmer.Name = "ButtonCustmer";
            this.ButtonCustmer.Size = new Size(0x156, 0x34);
            this.ButtonCustmer.Text = "إدارة العملاء";
            this.ButtonCustmer.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtonCustomerAdd.Image = A.F.ImCustomerAdd;
            this.ButtonCustomerAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonCustomerAdd.Name = "ButtonCustomerAdd";
            this.ButtonCustomerAdd.Size = new Size(0xba, 0x26);
            this.ButtonCustomerAdd.Text = "اضافة عميل جديد";
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            this.ToolStripSeparator15.Size = new Size(0xb7, 6);
            this.ButtonCustumerAddPay.Image = A.F.ImMoney;
            this.ButtonCustumerAddPay.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonCustumerAddPay.Name = "ButtonCustumerAddPay";
            this.ButtonCustumerAddPay.Size = new Size(0xba, 0x26);
            this.ButtonCustumerAddPay.Text = "اضافة دفعة لعميل";
            this.ToolStripSeparator16.Name = "ToolStripSeparator16";
            this.ToolStripSeparator16.Size = new Size(0xb7, 6);
            this.ButtonCustumerList.Image = A.F.ImCustumer;
            this.ButtonCustumerList.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonCustumerList.Name = "ButtonCustumerList";
            this.ButtonCustumerList.Size = new Size(0xba, 0x26);
            this.ButtonCustumerList.Text = "إدارة قائمة العملاء";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(0x156, 6);
            ToolStripItem[] itemArray9 = new ToolStripItem[] { this.ButtonExpeeAdd, this.ToolStripSeparator20, this.ButtonExpeeList };
            this.ButtonExpee.DropDownItems.AddRange(itemArray9);
            this.ButtonExpee.Enabled = false;
            this.ButtonExpee.Image = A.F.ImExpense;
            this.ButtonExpee.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonExpee.ImageTransparentColor = Color.Magenta;
            this.ButtonExpee.Name = "ButtonExpee";
            this.ButtonExpee.Size = new Size(0x156, 0x34);
            this.ButtonExpee.Text = "المصروفات والنفقات";
            this.ButtonExpee.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtonExpeeAdd.Image = A.F.ImMoney;
            this.ButtonExpeeAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonExpeeAdd.Name = "ButtonExpeeAdd";
            this.ButtonExpeeAdd.Size = new Size(0x100, 0x26);
            this.ButtonExpeeAdd.Text = "إضافة مصروفات ونفقات";
            this.ToolStripSeparator20.Name = "ToolStripSeparator20";
            this.ToolStripSeparator20.Size = new Size(0xfd, 6);
            this.ButtonExpeeList.Image = A.F.ImExpense;
            this.ButtonExpeeList.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonExpeeList.Name = "ButtonExpeeList";
            this.ButtonExpeeList.Size = new Size(0x100, 0x26);
            this.ButtonExpeeList.Text = "إدارة قائمة المصروفات والنفقات";
            this.ButUserGReport.Enabled = false;
            this.ButUserGReport.Image = A.F.Im_Report;
            this.ButUserGReport.ImageScaling = ToolStripItemImageScaling.None;
            this.ButUserGReport.ImageTransparentColor = Color.Magenta;
            this.ButUserGReport.Name = "ButUserGReport";
            this.ButUserGReport.Size = new Size(0x156, 0x34);
            this.ButUserGReport.Text = "التقرير العام";
            this.ButUserGReport.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtonCash.Enabled = false;
            this.ButtonCash.Image = A.F.ImCashList;
            this.ButtonCash.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonCash.ImageTransparentColor = Color.Magenta;
            this.ButtonCash.Name = "ButtonCash";
            this.ButtonCash.Size = new Size(0x156, 0x34);
            this.ButtonCash.Text = "صندوق الكاش";
            this.ButtonCash.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ToolStripSeparator36.Name = "ToolStripSeparator36";
            this.ToolStripSeparator36.Size = new Size(0x156, 6);
            ToolStripItem[] itemArray10 = new ToolStripItem[] { this.ButtonRemmemAdd, this.ToolStripSeparator21, this.ButtonReammemList };
            this.ButtonRemme.DropDownItems.AddRange(itemArray10);
            this.ButtonRemme.Enabled = false;
            this.ButtonRemme.Image = A.F.ImTimer;
            this.ButtonRemme.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonRemme.ImageTransparentColor = Color.Magenta;
            this.ButtonRemme.Name = "ButtonRemme";
            this.ButtonRemme.Size = new Size(0x156, 0x34);
            this.ButtonRemme.Text = "مذكرات | تنبيهات";
            this.ButtonRemme.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtonRemmemAdd.Image = A.F.ImAdd;
            this.ButtonRemmemAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonRemmemAdd.Name = "ButtonRemmemAdd";
            this.ButtonRemmemAdd.Size = new Size(0x100, 0x26);
            this.ButtonRemmemAdd.Text = "إضافة ملاحظة وتذكير";
            this.ToolStripSeparator21.Name = "ToolStripSeparator21";
            this.ToolStripSeparator21.Size = new Size(0xfd, 6);
            this.ButtonReammemList.Image = A.F.ImTimer;
            this.ButtonReammemList.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonReammemList.Name = "ButtonReammemList";
            this.ButtonReammemList.Size = new Size(0x100, 0x26);
            this.ButtonReammemList.Text = "إدارة قائمة المذكرات والتنبيهات";
            this.ToolStripSeparator39.Name = "ToolStripSeparator39";
            this.ToolStripSeparator39.Size = new Size(0x156, 6);
            this.ButtonEmploy.Enabled = false;
            this.ButtonEmploy.Image = A.F.ImEmploys;
            this.ButtonEmploy.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonEmploy.ImageTransparentColor = Color.Magenta;
            this.ButtonEmploy.Name = "ButtonEmploy";
            this.ButtonEmploy.Size = new Size(0x156, 0x34);
            this.ButtonEmploy.Text = "إدارة المستخدمين والصلاحيات";
            this.ButtonEmploy.TextImageRelation = TextImageRelation.ImageAboveText;
            ToolStripItem[] itemArray11 = new ToolStripItem[] { this.ButtinSubSetting, this.ToolStripSeparator33, this.ButtonMainSetting };
            this.ButtonSetting.DropDownItems.AddRange(itemArray11);
            this.ButtonSetting.Enabled = false;
            this.ButtonSetting.Image = A.F.ImSetting1;
            this.ButtonSetting.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonSetting.ImageTransparentColor = Color.Magenta;
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Size = new Size(0x156, 0x34);
            this.ButtonSetting.Text = "إعدادات النظام العامة";
            this.ButtonSetting.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ButtinSubSetting.Image = A.F.ImSettingS;
            this.ButtinSubSetting.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtinSubSetting.Name = "ButtinSubSetting";
            this.ButtinSubSetting.Size = new Size(0xd4, 0x26);
            this.ButtinSubSetting.Text = "اعدادات المتجر | الفرع";
            this.ToolStripSeparator33.Name = "ToolStripSeparator33";
            this.ToolStripSeparator33.Size = new Size(0xd1, 6);
            this.ButtonMainSetting.Image = A.F.ImSetting;
            this.ButtonMainSetting.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonMainSetting.Name = "ButtonMainSetting";
            this.ButtonMainSetting.Size = new Size(0xd4, 0x26);
            this.ButtonMainSetting.Text = "إعدادات رئيسية عامة";
            this.ToolStripSeparator41.Name = "ToolStripSeparator41";
            this.ToolStripSeparator41.Size = new Size(0x156, 6);
            this.TimerChangeColor.Interval = 0xbb8;
            this.TimerStyleHedarTxT.Enabled = true;
            this.TimerStyleHedarTxT.Interval = 500;
            this.TimerCheckNumberDate.Enabled = true;
            this.TimerCheckNumberDate.Interval = 0x3e8;
            this.TimerStarts.Enabled = true;
            this.UpdateCheck.BackColor = Color.FromArgb(0xc0, 0, 0);
            this.UpdateCheck.Dock = DockStyle.Bottom;
            this.UpdateCheck.ForeColor = Color.White;
            this.UpdateCheck.Location = new Point(380, 0x341);
            this.UpdateCheck.Name = "UpdateCheck";
            this.UpdateCheck.Size = new Size(0x3c6, 0x17);
            this.UpdateCheck.TabIndex = 0x6b;
            this.UpdateCheck.TextAlign = ContentAlignment.MiddleLeft;
            this.UpdateCheck.Visible = false;
            this.PanelTop.BackColor = Color.White;
            this.PanelTop.BorderStyle = BorderStyle.FixedSingle;
            this.PanelTop.Controls.Add(this.PanelHedar);
            this.PanelTop.Dock = DockStyle.Top;
            this.PanelTop.Location = new Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new Size(0x542, 0x3d);
            this.PanelTop.TabIndex = 0x6d;
            this.PanelHedar.BackColor = Color.DarkOliveGreen;
            this.PanelHedar.BackgroundImage = A.F.NHedar;
            this.PanelHedar.BackgroundImageLayout = ImageLayout.Stretch;
            this.PanelHedar.Dock = DockStyle.Fill;
            this.PanelHedar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0x40, 0);
            this.PanelHedar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0x40, 0x40, 0);
            this.PanelHedar.FlatStyle = FlatStyle.Flat;
            this.PanelHedar.Font = new Font("Tahoma", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.PanelHedar.ForeColor = Color.White;
            this.PanelHedar.Location = new Point(0, 0);
            this.PanelHedar.Margin = new Padding(3, 4, 3, 4);
            this.PanelHedar.Name = "PanelHedar";
            this.PanelHedar.Size = new Size(0x540, 0x3b);
            this.PanelHedar.TabIndex = 10;
            this.PanelHedar.Text = "اسم المتجر";
            this.PanelHedar.UseVisualStyleBackColor = false;
            this.ToolStrip1.AutoSize = false;
            this.ToolStrip1.BackColor = Color.White;
            this.ToolStrip1.Dock = DockStyle.Bottom;
            this.ToolStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStrip1.GripMargin = new Padding(10);
            this.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStrip1.ImageScalingSize = new Size(30, 30);
            ToolStripItem[] itemArray12 = new ToolStripItem[9];
            itemArray12[0] = this.ButtonAbout;
            itemArray12[1] = this.ToolStripSeparator77;
            itemArray12[2] = this.ButtonSupport;
            itemArray12[3] = this.ToolStripSeparator80;
            itemArray12[4] = this.ButtonMyFile;
            itemArray12[5] = this.ButtonHelp;
            itemArray12[6] = this.ToolStripSeparator81;
            itemArray12[7] = this.ButtonUpdate;
            itemArray12[8] = this.ToolStripSeparator13;
            this.ToolStrip1.Items.AddRange(itemArray12);
            this.ToolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ToolStrip1.Location = new Point(0, 0x14e);
            this.ToolStrip1.Margin = new Padding(10);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Padding = new Padding(10);
            this.ToolStrip1.RightToLeft = RightToLeft.Yes;
            this.ToolStrip1.Size = new Size(0xef, 0x14e);
            this.ToolStrip1.Stretch = true;
            this.ToolStrip1.TabIndex = 0x1f;
            this.ButtonAbout.Image = A.F.ImLAbout;
            this.ButtonAbout.ImageTransparentColor = Color.Magenta;
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new Size(0xda, 50);
            this.ButtonAbout.Text = "حول النظام";
            this.ButtonAbout.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ToolStripSeparator77.Name = "ToolStripSeparator77";
            this.ToolStripSeparator77.Size = new Size(0xda, 6);
            this.ButtonSupport.Image = A.F.ImSupport;
            this.ButtonSupport.ImageTransparentColor = Color.Magenta;
            this.ButtonSupport.Name = "ButtonSupport";
            this.ButtonSupport.Size = new Size(0xda, 50);
            this.ButtonSupport.Text = "مركز الدعم";
            this.ButtonSupport.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ToolStripSeparator80.Name = "ToolStripSeparator80";
            this.ToolStripSeparator80.Size = new Size(0xda, 6);
            ToolStripItem[] itemArray13 = new ToolStripItem[] { this.DBSerViewToolStripMenuItem, this.ToolStripSeparator24, this.DBSerRestToolStripMenuItem };
            this.ButtonMyFile.DropDownItems.AddRange(itemArray13);
            this.ButtonMyFile.Image = A.F.ImLMyFile;
            this.ButtonMyFile.ImageTransparentColor = Color.Magenta;
            this.ButtonMyFile.Name = "ButtonMyFile";
            this.ButtonMyFile.Size = new Size(0xda, 50);
            this.ButtonMyFile.Text = "معلومات الترخيص";
            this.ButtonMyFile.TextImageRelation = TextImageRelation.ImageAboveText;
            this.DBSerViewToolStripMenuItem.Image = A.F.ImLMyFile;
            this.DBSerViewToolStripMenuItem.Name = "DBSerViewToolStripMenuItem";
            this.DBSerViewToolStripMenuItem.Size = new Size(250, 0x24);
            this.DBSerViewToolStripMenuItem.Text = "عرض وإدارة معلومات الترخيص";
            this.ToolStripSeparator24.Name = "ToolStripSeparator24";
            this.ToolStripSeparator24.Size = new Size(0xf7, 6);
            this.DBSerRestToolStripMenuItem.Name = "DBSerRestToolStripMenuItem";
            this.DBSerRestToolStripMenuItem.Size = new Size(250, 0x24);
            this.DBSerRestToolStripMenuItem.Text = "إعادة ضبط الترخيص";
            this.ButtonHelp.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonHelp.Image = A.F.ImDolarr;
            this.ButtonHelp.ImageTransparentColor = Color.Magenta;
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new Size(0xda, 50);
            this.ButtonHelp.Text = "شراء النظام 300 $";
            this.ButtonHelp.TextAlign = ContentAlignment.BottomCenter;
            this.ButtonHelp.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ToolStripSeparator81.Name = "ToolStripSeparator81";
            this.ToolStripSeparator81.Size = new Size(0xda, 6);
            this.ButtonUpdate.Image = A.F.ImUpdate;
            this.ButtonUpdate.ImageTransparentColor = Color.Magenta;
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new Size(0xda, 50);
            this.ButtonUpdate.Text = "تحديث النظام";
            this.ButtonUpdate.TextImageRelation = TextImageRelation.ImageAboveText;
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            this.ToolStripSeparator13.Size = new Size(0xda, 6);
            this.PanelLeft.AutoScroll = true;
            this.PanelLeft.BackColor = Color.White;
            this.PanelLeft.Controls.Add(this.ImLogoHome);
            this.PanelLeft.Controls.Add(this.ToolStrip1);
            this.PanelLeft.Controls.Add(this.TxTVerNumber);
            this.PanelLeft.Dock = DockStyle.Right;
            this.PanelLeft.Location = new Point(0x453, 0x3d);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new Size(0xef, 0x2c8);
            this.PanelLeft.TabIndex = 0x6f;
            this.ImLogoHome.Dock = DockStyle.Top;
            this.ImLogoHome.Location = new Point(0, 0);
            this.ImLogoHome.Name = "ImLogoHome";
            this.ImLogoHome.Size = new Size(0xef, 0x9d);
            this.ImLogoHome.SizeMode = PictureBoxSizeMode.Zoom;
            this.ImLogoHome.TabIndex = 0;
            this.ImLogoHome.TabStop = false;
            this.TxTVerNumber.Dock = DockStyle.Bottom;
            this.TxTVerNumber.Location = new Point(0, 0x29c);
            this.TxTVerNumber.Name = "TxTVerNumber";
            this.TxTVerNumber.Size = new Size(0xef, 0x2c);
            this.TxTVerNumber.TabIndex = 0x20;
            this.TxTVerNumber.Text = "TxTVerNumber";
            this.TxTVerNumber.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonMenuShow.BackColor = Color.White;
            this.ButtonMenuShow.Dock = DockStyle.Right;
            this.ButtonMenuShow.FlatAppearance.BorderSize = 0;
            this.ButtonMenuShow.FlatStyle = FlatStyle.Flat;
            this.ButtonMenuShow.Location = new Point(0x404, 0x3d);
            this.ButtonMenuShow.Name = "ButtonMenuShow";
            this.ButtonMenuShow.Size = new Size(0x34, 0x2c8);
            this.ButtonMenuShow.TabIndex = 0x71;
            this.ButtonMenuShow.Text = "<< إظهار المزيد";
            this.ButtonMenuShow.UseVisualStyleBackColor = false;
            this.ButtonMenuHide.Dock = DockStyle.Right;
            this.ButtonMenuHide.FlatAppearance.BorderSize = 0;
            this.ButtonMenuHide.FlatStyle = FlatStyle.Flat;
            this.ButtonMenuHide.Location = new Point(0x438, 0x3d);
            this.ButtonMenuHide.Name = "ButtonMenuHide";
            this.ButtonMenuHide.Size = new Size(0x1b, 0x2c8);
            this.ButtonMenuHide.TabIndex = 0x70;
            this.ButtonMenuHide.Text = ">";
            this.ButtonMenuHide.UseVisualStyleBackColor = true;
            this.TimerLoadRemnber.Interval = 0x36ee80;
            this.PanelButtons.AutoScroll = true;
            this.PanelButtons.AutoScrollMinSize = new Size(20, 0);
            this.PanelButtons.BackColor = Color.White;
            this.PanelButtons.Controls.Add(this.ToolStripHomeMenu);
            this.PanelButtons.Dock = DockStyle.Left;
            this.PanelButtons.Location = new Point(0, 0x3d);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new Size(380, 0x31b);
            this.PanelButtons.TabIndex = 9;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AllowUserToOrderColumns = true;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.BackgroundColor = SystemColors.ButtonHighlight;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Window;
            style.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.ControlText;
            style.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style.SelectionForeColor = Color.Black;
            style.WrapMode = DataGridViewTriState.False;
            this.GV.DefaultCellStyle = style;
            this.GV.Dock = DockStyle.Top;
            this.GV.Location = new Point(380, 0x3d);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x288, 0xb8);
            this.GV.TabIndex = 0x1ed36d7;
            this.GV.Visible = false;
            this.ButtonCloudPrinter.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonCloudPrinter.Dock = DockStyle.Bottom;
            this.ButtonCloudPrinter.FlatStyle = FlatStyle.Popup;
            this.ButtonCloudPrinter.Image = A.F.ImPrint;
            this.ButtonCloudPrinter.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCloudPrinter.Location = new Point(380, 0x2c7);
            this.ButtonCloudPrinter.Name = "ButtonCloudPrinter";
            this.ButtonCloudPrinter.Size = new Size(0x288, 0x3e);
            this.ButtonCloudPrinter.TabIndex = 0x1ed36d9;
            this.ButtonCloudPrinter.Text = "فتح نظام استقبال اوامر الطلبية السحابية من نسخة التاب";
            this.ButtonCloudPrinter.UseVisualStyleBackColor = false;
            this.ButtonCloudPrinter.Visible = false;
            this.LabelDB.BackColor = Color.Black;
            this.LabelDB.BorderStyle = BorderStyle.Fixed3D;
            this.LabelDB.Dock = DockStyle.Bottom;
            this.LabelDB.Font = new Font("Tahoma", 11f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelDB.ForeColor = Color.Yellow;
            this.LabelDB.Location = new Point(380, 0x27e);
            this.LabelDB.Name = "LabelDB";
            this.LabelDB.Size = new Size(0x288, 0x49);
            this.LabelDB.TabIndex = 0x1ed36db;
            this.LabelDB.Text = "* يمكنك استخدام برنامج (Google Drive) او (Microsoft One Drive) من اجل مزامنة مجلد (BackUpDB) بشكل تلقائي.";
            this.LabelDB.TextAlign = ContentAlignment.MiddleCenter;
            this.TimerTiclString.Enabled = true;
            this.TimerTiclString.Interval = 0x1388;
            this.TimerRefreshCon.Enabled = true;
            this.TimerRefreshCon.Interval = 0xea60;
            this.LabelTr.BackColor = Color.Maroon;
            this.LabelTr.Dock = DockStyle.Top;
            this.LabelTr.ForeColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.LabelTr.Location = new Point(380, 0xf5);
            this.LabelTr.Name = "LabelTr";
            this.LabelTr.Size = new Size(0x288, 0x29);
            this.LabelTr.TabIndex = 0x1ed36dd;
            this.LabelTr.Text = "نسخة تجريبية، محدودة بعدد السجلات التي يتم ادخالها في النظام ";
            this.LabelTr.TextAlign = ContentAlignment.MiddleLeft;
            this.PanelStand.BackColor = Color.GhostWhite;
            this.PanelStand.Controls.Add(this.CheckBoxCloseSale);
            this.PanelStand.Controls.Add(this.ButtonStandHide);
            this.PanelStand.Controls.Add(this.ButtonStandPrint);
            this.PanelStand.Controls.Add(this.ButtonStandCash);
            this.PanelStand.Controls.Add(this.ButtonStandQuery);
            this.PanelStand.Controls.Add(this.ButtonStandPendin);
            this.PanelStand.Controls.Add(this.ButtonStandNewInvoice);
            this.PanelStand.Controls.Add(this.TxTTitle);
            this.PanelStand.Dock = DockStyle.Left;
            this.PanelStand.Location = new Point(380, 0x11e);
            this.PanelStand.Name = "PanelStand";
            this.PanelStand.Size = new Size(0x178, 0x160);
            this.PanelStand.TabIndex = 0x1ed36df;
            this.PanelStand.Visible = false;
            this.CheckBoxCloseSale.AutoSize = true;
            this.CheckBoxCloseSale.BackColor = Color.WhiteSmoke;
            this.CheckBoxCloseSale.Checked = true;
            this.CheckBoxCloseSale.CheckState = CheckState.Checked;
            this.CheckBoxCloseSale.Dock = DockStyle.Top;
            this.CheckBoxCloseSale.Location = new Point(0, 0x139);
            this.CheckBoxCloseSale.Name = "CheckBoxCloseSale";
            this.CheckBoxCloseSale.Padding = new Padding(8);
            this.CheckBoxCloseSale.Size = new Size(0x178, 0x24);
            this.CheckBoxCloseSale.TabIndex = 0x1ed3702;
            this.CheckBoxCloseSale.Text = "إظهار هذه النافذة دائماً، وعدم انشاء فاتورة جديدة تلقائياً";
            this.CheckBoxCloseSale.UseVisualStyleBackColor = false;
            this.ButtonStandHide.Dock = DockStyle.Top;
            this.ButtonStandHide.FlatAppearance.BorderColor = Color.Green;
            this.ButtonStandHide.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonStandHide.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonStandHide.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonStandHide.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonStandHide.Image = A.F.ImCloseOrang;
            this.ButtonStandHide.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonStandHide.Location = new Point(0, 0x10d);
            this.ButtonStandHide.Margin = new Padding(3, 4, 3, 4);
            this.ButtonStandHide.Name = "ButtonStandHide";
            this.ButtonStandHide.Size = new Size(0x178, 0x2c);
            this.ButtonStandHide.TabIndex = 0x1ed36fd;
            this.ButtonStandHide.Text = "اخفاء F6";
            this.ButtonStandHide.UseVisualStyleBackColor = true;
            this.ButtonStandPrint.Dock = DockStyle.Top;
            this.ButtonStandPrint.Image = A.F.ImPrint;
            this.ButtonStandPrint.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonStandPrint.Location = new Point(0, 0xde);
            this.ButtonStandPrint.Name = "ButtonStandPrint";
            this.ButtonStandPrint.Size = new Size(0x178, 0x2f);
            this.ButtonStandPrint.TabIndex = 0x1ed3701;
            this.ButtonStandPrint.Text = "طباعة فاتورة سابقة F11";
            this.ButtonStandPrint.UseVisualStyleBackColor = true;
            this.ButtonStandCash.Dock = DockStyle.Top;
            this.ButtonStandCash.Image = A.F.ImCashList;
            this.ButtonStandCash.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonStandCash.Location = new Point(0, 0xaf);
            this.ButtonStandCash.Name = "ButtonStandCash";
            this.ButtonStandCash.Size = new Size(0x178, 0x2f);
            this.ButtonStandCash.TabIndex = 0x1ed3700;
            this.ButtonStandCash.Text = "فتح الكاش F1";
            this.ButtonStandCash.UseVisualStyleBackColor = true;
            this.ButtonStandQuery.Dock = DockStyle.Top;
            this.ButtonStandQuery.Image = A.F.ImSearch;
            this.ButtonStandQuery.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonStandQuery.Location = new Point(0, 0x80);
            this.ButtonStandQuery.Name = "ButtonStandQuery";
            this.ButtonStandQuery.Size = new Size(0x178, 0x2f);
            this.ButtonStandQuery.TabIndex = 0x1ed36ff;
            this.ButtonStandQuery.Text = "استعلام عن مادة F7";
            this.ButtonStandQuery.UseVisualStyleBackColor = true;
            this.ButtonStandPendin.Dock = DockStyle.Top;
            this.ButtonStandPendin.Enabled = false;
            this.ButtonStandPendin.Image = A.F.ImPendingNow;
            this.ButtonStandPendin.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonStandPendin.Location = new Point(0, 0x51);
            this.ButtonStandPendin.Name = "ButtonStandPendin";
            this.ButtonStandPendin.Size = new Size(0x178, 0x2f);
            this.ButtonStandPendin.TabIndex = 0x1ed36fe;
            this.ButtonStandPendin.Text = "قائمة الفواتير المعلقة F4";
            this.ButtonStandPendin.UseVisualStyleBackColor = true;
            this.ButtonStandPendin.Visible = false;
            this.ButtonStandNewInvoice.Dock = DockStyle.Top;
            this.ButtonStandNewInvoice.Image = A.F.ImSale;
            this.ButtonStandNewInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonStandNewInvoice.Location = new Point(0, 0x22);
            this.ButtonStandNewInvoice.Name = "ButtonStandNewInvoice";
            this.ButtonStandNewInvoice.Size = new Size(0x178, 0x2f);
            this.ButtonStandNewInvoice.TabIndex = 0x1ed36fc;
            this.ButtonStandNewInvoice.Text = "فاتورة جديدة F2";
            this.ButtonStandNewInvoice.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x178, 0x22);
            this.TxTTitle.TabIndex = 0x1ed36f8;
            this.TxTTitle.Text = "قائمة الاستعداد";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x542, 0x358);
            base.Controls.Add(this.PanelStand);
            base.Controls.Add(this.LabelTr);
            base.Controls.Add(this.LabelDB);
            base.Controls.Add(this.ButtonCloudPrinter);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.ButtonMenuShow);
            base.Controls.Add(this.ButtonMenuHide);
            base.Controls.Add(this.PanelLeft);
            base.Controls.Add(this.TxTTip);
            base.Controls.Add(this.ToolStripMenu);
            base.Controls.Add(this.UpdateCheck);
            base.Controls.Add(this.PanelButtons);
            base.Controls.Add(this.PanelTop);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.IsMdiContainer = true;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.Name = "MainForm";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            base.WindowState = FormWindowState.Maximized;
            this.ToolStripMenu.ResumeLayout(false);
            this.ToolStripMenu.PerformLayout();
            this.ToolStripHomeMenu.ResumeLayout(false);
            this.ToolStripHomeMenu.PerformLayout();
            this.PanelTop.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.PanelLeft.ResumeLayout(false);
            ((ISupportInitialize) this.ImLogoHome).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.PanelButtons.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            this.PanelStand.ResumeLayout(false);
            this.PanelStand.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            this.A.BackColor = Color.WhiteSmoke;
            this.Text = A.PR.R;
            if (A.AR.I)
            {
                this.PanelLeft.Visible = true;
                this.ButtonMenuHide.Visible = true;
                this.ButtonMenuShow.Visible = false;
            }
            else
            {
                this.PanelLeft.Visible = false;
                this.ButtonMenuHide.Visible = false;
                this.ButtonMenuShow.Visible = true;
            }
            this.TxTVerNumber.Text = "الاصدار رقم " + A.PR.Y;
            if (!A.PR.D)
            {
                this.ButtonMyFile.Visible = false;
            }
            else
            {
                this.ButtonHelp.Visible = false;
                this.LabelTr.Visible = false;
            }
            A.D.A.A.ShowDialog();
            DataGridViewImageColumn dataGridViewColumn = new DataGridViewImageColumn();
            this.GV.Columns.Add(dataGridViewColumn);
            dataGridViewColumn.HeaderText = "";
            dataGridViewColumn.Name = "btnH";
            dataGridViewColumn.Image = this.A;
            this.P();
            this.ButtonCloudPrinter.Visible = A.AR.AR;
            if (A.PR.Q)
            {
                this.ButtonHelp.Text = "شراء النظام 300";
                this.ButtonHelp.Image = null;
            }
            new LH().Show();
        }

        private void A(object A, DataGridViewCellEventArgs R)
        {
        }

        private void A(object A, FormClosedEventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, KeyEventArgs R)
        {
            if (R.KeyCode == Keys.F6)
            {
                this.ButtonStandHide.PerformClick();
            }
            if (R.KeyCode == Keys.F2)
            {
                this.ButtonStandNewInvoice.PerformClick();
            }
            if (R.KeyCode == Keys.F4)
            {
                this.ButtonStandPendin.PerformClick();
            }
            if (R.KeyCode == Keys.F1)
            {
                this.ButtonStandCash.PerformClick();
            }
            if (R.KeyCode == Keys.F7)
            {
                this.ButtonStandQuery.PerformClick();
            }
            if (R.KeyCode == Keys.F11)
            {
                this.ButtonStandPrint.PerformClick();
            }
        }

        private void A(object A, MouseEventArgs R)
        {
            if (R.Button == MouseButtons.Right)
            {
                this.D();
            }
        }

        private void A(object A, ToolStripItemClickedEventArgs R)
        {
        }

        private void AP(object A, EventArgs R)
        {
        }

        private void AR(object A, EventArgs R)
        {
            if (!A.PR.GP)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                RT.A = 0;
                A.D.A.A.ShowDialog();
            }
        }

        private void B(object A, EventArgs R)
        {
            this.TimerCheckNumberDate.Enabled = false;
            this.DateTimeMainValu.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm tt dddd");
            A.D.A.A.R();
        }

        private void BR(object A, EventArgs R)
        {
            A.D.A.A.Show();
        }

        private void C(object A, EventArgs R)
        {
            if (A.PR.WR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void CR(object A, EventArgs R)
        {
        }

        public void D()
        {
            if (this.PanelButtons.Dock == DockStyle.Left)
            {
                this.PanelButtons.Dock = DockStyle.Right;
                this.PanelLeft.Dock = DockStyle.Left;
                this.ButtonMenuShow.Dock = DockStyle.Left;
                this.ButtonMenuHide.Dock = DockStyle.Left;
            }
            else
            {
                this.PanelButtons.Dock = DockStyle.Left;
                this.PanelLeft.Dock = DockStyle.Right;
                this.ButtonMenuShow.Dock = DockStyle.Right;
                this.ButtonMenuHide.Dock = DockStyle.Right;
            }
        }

        private void D(object A, EventArgs R)
        {
            this.TimerChangeColor.Enabled = false;
        }

        private void D(object A, MouseEventArgs R)
        {
            if (R.Button == MouseButtons.Right)
            {
                this.D();
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
            if (A.PR.I)
            {
                Interaction.MsgBox("لا يمكن عرض معلومات الترخيص على الجهاز الفرعي", MsgBoxStyle.ApplicationModal, null);
            }
            else if (A.PR.LR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox("فقط المدير العام يمكنه الاطلاع على معلومات الترخيص", MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void DR(object A, EventArgs R)
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

        private void E(object A, EventArgs R)
        {
            this.P = (int) Math.Round((double) (Conversion.Val(this.P) + 1.0));
            if (this.P == 1)
            {
                this.PanelHedar.Font = new Font("Tahoma", 21f);
                this.PanelHedar.ForeColor = Color.White;
            }
            else if (this.P == 2)
            {
                this.PanelHedar.Font = new Font("Tahoma", 22f);
                this.PanelHedar.ForeColor = Color.WhiteSmoke;
            }
            else if (this.P == 3)
            {
                this.PanelHedar.Font = new Font("Tahoma", 23f);
                this.PanelHedar.ForeColor = Color.White;
            }
            else if (this.P == 4)
            {
                this.PanelHedar.Font = new Font("Tahoma", 24f);
                this.PanelHedar.ForeColor = Color.Beige;
            }
            else if (this.P == 5)
            {
                this.PanelHedar.Font = new Font("Tahoma", 23f);
                this.PanelHedar.ForeColor = Color.White;
            }
            else if (this.P == 6)
            {
                this.PanelHedar.Font = new Font("Tahoma", 22f);
                this.PanelHedar.ForeColor = Color.WhiteSmoke;
            }
            else if (this.P == 7)
            {
                this.PanelHedar.Font = new Font("Tahoma", 21f);
                this.PanelHedar.ForeColor = Color.White;
            }
            else if (this.P == 8)
            {
                this.P = 0;
            }
        }

        private void EP(object A, EventArgs R)
        {
            if (A.PR.OR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void ER(object A, EventArgs R)
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

        private void F(object A, EventArgs R)
        {
            this.TimerChangeColor.Enabled = true;
        }

        private void F(object A, MouseEventArgs R)
        {
            if (R.Button == MouseButtons.Right)
            {
                this.D();
            }
        }

        private void FP(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void FR(object A, EventArgs R)
        {
            if (A.PR.WR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void G(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل انت متأكد من تسجيل الخروج وتبديل الموظف؟", MsgBoxStyle.OkCancel, null) == MsgBoxResult.Ok)
            {
                this.PanelStand.Visible = false;
                new LH().Show();
            }
        }

        private void GP(object A, EventArgs R)
        {
            if (A.PR.OR)
            {
                A.W.A();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void GR(object A, EventArgs R)
        {
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

        private void H(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void HP(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void HR(object A, EventArgs R)
        {
            if (A.PR.WR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void I(object A, MouseEventArgs R)
        {
            if (R.Button == MouseButtons.Right)
            {
                this.D();
            }
        }

        private void IP(object A, EventArgs R)
        {
            if (A.PR.I)
            {
                Interaction.MsgBox("لا يمكن عرض معلومات الترخيص على الجهاز الفرعي", MsgBoxStyle.ApplicationModal, null);
            }
            else if (A.PR.LR)
            {
                Process.Start("https://yazsys.com/NNSSActiveQLinSerHome.aspx?DBSerialNumber=" + A.PR.Z.ToString());
            }
            else
            {
                Interaction.MsgBox("فقط المدير العام يمكنه الاطلاع على معلومات الترخيص", MsgBoxStyle.ApplicationModal, null);
            }
        }

        private void IR(object A, EventArgs R)
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

        private void J(object A, EventArgs R)
        {
            if (!A.PR.QP)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                XD.A = 0;
                A.D.A.A.ShowDialog();
            }
        }

        private void JR(object A, EventArgs R)
        {
        }

        private void K(object A, EventArgs R)
        {
            if (!A.AR.Q)
            {
                A.D.A.A.ShowDialog();
            }
        }

        private void KP(object A, EventArgs R)
        {
            if (A.PR.OR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void KR(object A, EventArgs R)
        {
            if (A.PR.UP)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void L(object A, EventArgs R)
        {
        }

        private void LP(object A, EventArgs R)
        {
            A.AR.P = this.CheckBoxCloseSale.Checked;
        }

        private void LR(object A, EventArgs R)
        {
            if (A.PR.WP)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void M(object A, EventArgs R)
        {
            if (A.PR.DP)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void MR(object A, EventArgs R)
        {
        }

        private void N(object A, EventArgs R)
        {
            if (A.PR.Q)
            {
                Interaction.MsgBox("اتصل على رقم المندوب\r\n" + A.PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/SPList.aspx");
            }
        }

        private void NR(object A, EventArgs R)
        {
            if (A.PR.YR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void O(object A, EventArgs R)
        {
            this.PanelLeft.Visible = true;
            this.ButtonMenuShow.Visible = false;
            this.ButtonMenuHide.Visible = true;
            A.AR.I = true;
        }

        private void OR(object A, EventArgs R)
        {
            this.P();
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
                string selectCommandText = "SELECT * FROM TaNNRemember WHERE (CenterFrontID = @CenterFrontID) AND (RemeIsBeeb = @RemeIsBeeb) AND (RemeDateTimeBeeb BETWEEN @DF and @DT)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", A.PR.GR);
                string text1 = DateTime.Now.ToString("yyyy/MM/dd HH:00");
                adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
                string text2 = DateTime.Now.ToString("yyyy/MM/dd HH:59");
                adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("RemeIsBeeb", false);
                adapter.Fill(dataTable);
                this.A.Close();
                this.GV.DataSource = dataTable;
                this.GV.Refresh();
                this.GV.Columns["RemeID"].Visible = false;
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["RemeDateTimeAdd"].HeaderText = "تاريخ/ وقت الاضافة";
                this.GV.Columns["RemeDateTimeBeeb"].HeaderText = "تاريخ/ وقت التنبيه";
                this.GV.Columns["RemeDatils"].HeaderText = "الوصف/العنوان";
                this.GV.Columns["RemeIsBeeb"].HeaderText = "تم اخفاء التنبيه نعم/لا";
                this.GV.Columns["RemeUserAddBy"].HeaderText = "الموظف";
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (this.GV.RowCount <= 0)
                {
                    this.GV.Visible = false;
                }
                else
                {
                    this.I();
                    this.GV.Visible = true;
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
            if (A.PR.LR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void P(object A, MouseEventArgs R)
        {
            if (R.Button == MouseButtons.Right)
            {
                this.D();
            }
        }

        private void PP(object A, EventArgs R)
        {
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
        }

        private void PR(object A, EventArgs R)
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

        public void Q()
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
                    SqlCommand command = new SqlCommand("UPDATE [TaNNRemember] SET [RemeIsBeeb] =@RemeIsBeeb WHERE [RemeID] = @RemeID", this.A);
                    command.Parameters.AddWithValue("@RemeID", this.GV.SelectedRows[0].Cells["RemeID"].Value.ToString());
                    command.Parameters.AddWithValue("@RemeIsBeeb", true);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.P();
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
        }

        private void Q(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void Q(object A, MouseEventArgs R)
        {
            if (R.Button == MouseButtons.Right)
            {
                this.D();
            }
        }

        private void QP(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void QR(object A, EventArgs R)
        {
            if (A.PR.XP)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            Interaction.MsgBox("لتعديل صورة الشعار من اعدادات النظام العامة ", MsgBoxStyle.ApplicationModal, null);
        }

        private void R(object A, DataGridViewCellEventArgs R)
        {
            if (R.ColumnIndex == 0)
            {
                this.Q();
            }
        }

        private void R(object A, MouseEventArgs R)
        {
            if (R.Button == MouseButtons.Right)
            {
                this.D();
            }
        }

        private void RP(object A, EventArgs R)
        {
            if (this.A == 1)
            {
                this.LabelDB.Text = this.P.ToString();
                this.A++;
            }
            else if (this.A == 2)
            {
                this.LabelDB.Text = this.Q.ToString();
                this.A++;
            }
            else if (this.A == 3)
            {
                this.LabelDB.Text = this.I.ToString();
                this.A++;
            }
            else if (this.A == 4)
            {
                this.LabelDB.Text = this.D.ToString();
                this.A++;
            }
            else if (this.A == 5)
            {
                if (!NH.A)
                {
                    this.A = 1;
                }
                else
                {
                    this.LabelDB.Visible = false;
                    this.TimerTiclString.Enabled = false;
                }
            }
        }

        private void S(object A, EventArgs R)
        {
            if (A.PR.NR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void SR(object A, EventArgs R)
        {
            if (A.PR.OR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void T(object A, EventArgs R)
        {
            if (A.PR.Q)
            {
                Interaction.MsgBox("اتصل على رقم المندوب\r\n" + A.PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/About.aspx");
            }
        }

        private void TP(object A, EventArgs R)
        {
            if (A.PR.OR)
            {
                this.ButtonSaleSale.PerformClick();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void TR(object A, EventArgs R)
        {
        }

        private void U(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void UP(object A, EventArgs R)
        {
            this.PanelStand.Visible = false;
        }

        private void UR(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void V(object A, EventArgs R)
        {
            if (A.PR.Q)
            {
                Interaction.MsgBox("اتصل على رقم المندوب\r\n" + A.PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/About.aspx");
            }
        }

        private void VR(object A, EventArgs R)
        {
            if (A.PR.NP)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void W(object A, EventArgs R)
        {
            if (A.PR.PP)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void WR(object A, EventArgs R)
        {
        }

        private void X(object A, EventArgs R)
        {
            if (A.PR.Q)
            {
                Interaction.MsgBox("اتصل على رقم المندوب\r\n" + A.PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/SPList.aspx");
            }
        }

        private void XP(object A, EventArgs R)
        {
            if (A.PR.OR)
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void XR(object A, EventArgs R)
        {
            if (!(A.PR.LR | A.PR.AQ))
            {
                Interaction.MsgBox("لا يوجد لديك صلاحيات التنقل بن الفروع او المستودعات", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                this.PanelStand.Visible = false;
                A.D.A.A.ShowDialog();
            }
        }

        private void Y(object A, EventArgs R)
        {
            this.PanelLeft.Visible = false;
            this.ButtonMenuShow.Visible = true;
            this.ButtonMenuHide.Visible = false;
            A.AR.I = false;
        }

        private void YR(object A, EventArgs R)
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

        private void Z(object A, EventArgs R)
        {
            if (A.PR.E)
            {
                A.D.A.A.ShowDialog();
            }
            if (!A.PR.OR)
            {
                Interaction.MsgBox(A.PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                A.D.A.A.P();
                if (A.AR.T <= 0)
                {
                    A.AR.T = 0;
                }
                else
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable dataTable = new DataTable();
                    string selectCommandText = "SELECT TOP(1) * FROM [TaNNInvSale] WHERE ([InvSaleID] = @InvSaleID)";
                    dataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("InvSaleID", A.AR.T);
                    adapter.Fill(dataTable);
                    this.A.Close();
                    TextBox box = new TextBox();
                    TextBox box2 = new TextBox();
                    if (dataTable.Rows.Count > 0)
                    {
                        box.Text = dataTable.Rows[0]["CenterFrontID"].ToString();
                        box2.Text = dataTable.Rows[0]["InvSaleStatus"].ToString();
                        if (box.Text != A.PR.GR)
                        {
                            A.AR.T = 0;
                        }
                        else if (!(Conversion.Val(box2.Text) == 1.0))
                        {
                            A.AR.T = 0;
                        }
                        else
                        {
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand("UPDATE [TaNNInvSale] SET [InvSaleDateTime] = @InvSaleDateTime WHERE [InvSaleID] = @InvSaleID", this.A);
                            command.Parameters.AddWithValue("InvSaleID", A.AR.T);
                            command.Parameters.AddWithValue("InvSaleDateTime", DateTime.Now.ToString("yyyy/MM/dd HH:mm"));
                            command.ExecuteNonQuery();
                            this.A.Close();
                        }
                    }
                }
                QH.A = false;
                A.D.A.A.ShowDialog();
            }
        }

        private void ZR(object A, EventArgs R)
        {
            if (Interaction.MsgBox("سيتم فتح شاشة خاصة للزوار يمكنك تركها في اي مكان داخل المتجر ليتمكن الزوار من الاستعلام بأنفسهم عن الأسعار، وسيتم فتح الشاشة بعرض كامل", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                A.D.A.A.ShowDialog();
            }
        }

        internal virtual ToolStripDropDownButton ButtonExpee
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.AP);
                MouseEventHandler handler2 = new MouseEventHandler(this.F);
                ToolStripDropDownButton a = this.A;
                if (a != null)
                {
                    a.Click -= handler;
                    a.MouseDown -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Click += handler;
                    a.MouseDown += handler2;
                }
            }
        }

        internal virtual ToolStripMenuItem ButtonExpeeAdd
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ER);
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

        internal virtual ToolStripSeparator ToolStripSeparator20
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem ButtonExpeeList
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.KR);
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

        internal virtual ToolStripSeparator ToolStripSeparator22
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripDropDownButton ButtonRemme
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripMenuItem ButtonRemmemAdd
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.YR);
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

        internal virtual ToolStripSeparator ToolStripSeparator21
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripMenuItem ButtonReammemList
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.VR);
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripButton ButtonEmploy
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual ToolStripSeparator ToolStripSeparator23
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStrip ToolStripMenu
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

        internal virtual ToolStripLabel TxTSubCenterName
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripButton ButonChangeCenter
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.XR);
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

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual ToolStripLabel ToolStripLabel2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripLabel TxTUserName
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual ToolStripLabel ToolStripLabel4
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripLabel TxTAccess
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Label TxTTip
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                Label a = this.A;
                if (a != null)
                {
                    a.TextChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.TextChanged += handler;
                }
            }
        }

        internal virtual PictureBox ImLogoHome
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                PictureBox a = this.A;
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

        internal virtual ToolStrip ToolStripHomeMenu
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                ToolStripItemClickedEventHandler handler = new ToolStripItemClickedEventHandler(this.A);
                ToolStrip r = this.R;
                if (r != null)
                {
                    r.ItemClicked -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.ItemClicked += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
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

        internal virtual ToolStripSeparator ToolStripSeparator5
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual ToolStripDropDownButton ButtonSuplier
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.CR);
                MouseEventHandler handler2 = new MouseEventHandler(this.P);
                ToolStripDropDownButton p = this.P;
                if (p != null)
                {
                    p.Click -= handler;
                    p.MouseDown -= handler2;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.Click += handler;
                    p.MouseDown += handler2;
                }
            }
        }

        internal virtual ToolStripMenuItem ButtonSuplierAdd
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.AR);
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

        internal virtual ToolStripSeparator ToolStripSeparator17
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual ToolStripMenuItem ButtonSplierAddPay
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PR);
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

        internal virtual ToolStripSeparator ToolStripSeparator18
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual ToolStripMenuItem ButtonSplierList
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.QR);
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

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual ToolStripDropDownButton ButtonSale
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.JR);
                MouseEventHandler handler2 = new MouseEventHandler(this.Q);
                ToolStripDropDownButton q = this.Q;
                if (q != null)
                {
                    q.Click -= handler;
                    q.MouseDown -= handler2;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.Click += handler;
                    q.MouseDown += handler2;
                }
            }
        }

        internal virtual ToolStripMenuItem ButtonSaleSale
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Z);
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

        internal virtual ToolStripSeparator ToolStripSeparator9
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual ToolStripMenuItem ButtonQuerySale
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.SR);
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

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator11
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual ToolStripDropDownButton ButtonCustmer
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.WR);
                MouseEventHandler handler2 = new MouseEventHandler(this.D);
                ToolStripDropDownButton i = this.I;
                if (i != null)
                {
                    i.Click -= handler;
                    i.MouseDown -= handler2;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.Click += handler;
                    i.MouseDown += handler2;
                }
            }
        }

        internal virtual ToolStripMenuItem ButtonCustomerAdd
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.IR);
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

        internal virtual ToolStripSeparator ToolStripSeparator15
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual ToolStripMenuItem ButtonCustumerAddPay
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.DR);
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

        internal virtual ToolStripSeparator ToolStripSeparator16
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual ToolStripMenuItem ButtonCustumerList
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.M);
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

        internal virtual ToolStripSeparator ToolStripSeparator8
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual Button PanelHedar
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripDropDownButton ButtonInvSale
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.TR);
                MouseEventHandler handler2 = new MouseEventHandler(this.I);
                ToolStripDropDownButton d = this.D;
                if (d != null)
                {
                    d.Click -= handler;
                    d.MouseDown -= handler2;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.Click += handler;
                    d.MouseDown += handler2;
                }
            }
        }

        internal virtual ToolStripMenuItem ButtonIvoSaleList
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.C);
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

        internal virtual ToolStripMenuItem ButtonIvoSaleHistory
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.FR);
                ToolStripMenuItem u = this.U;
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

        internal virtual ToolStripDropDownButton ButtonSetting
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual ToolStripMenuItem ButtinSubSetting
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual ToolStripMenuItem ButtonMainSetting
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Timer TimerChangeColor
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

        internal virtual ToolStripDropDownButton ButtonInvPursh
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.MR);
                MouseEventHandler handler2 = new MouseEventHandler(this.R);
                ToolStripDropDownButton h = this.H;
                if (h != null)
                {
                    h.Click -= handler;
                    h.MouseDown -= handler2;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.Click += handler;
                    h.MouseDown += handler2;
                }
            }
        }

        internal virtual ToolStripMenuItem ButAddPurch
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.J);
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

        internal virtual ToolStripMenuItem PutListPurch
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.W);
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

        internal virtual ToolStripButton BuChangeUser
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual Timer TimerStyleHedarTxT
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual ToolStripSeparator ToolStripSeparator28
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator31
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator33
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator34
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual ToolStripButton ButUserGReport
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.LR);
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

        internal virtual ToolStripSeparator ToolStripSeparator36
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual Timer TimerCheckNumberDate
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.B);
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

        internal virtual Timer TimerStarts
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label UpdateCheck
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.HP);
                Label r = this.R;
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

        internal virtual ToolStripSeparator ToolStripSeparator37
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }

        internal virtual ToolStripMenuItem BuCuQQ
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.ZR);
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

        internal virtual ToolStripSeparator ToolStripSeparator39
        {
            [CompilerGenerated]
            get => 
                this.AR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.AR = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator41
        {
            [CompilerGenerated]
            get => 
                this.PR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.PR = value);
        }

        internal virtual Panel PanelTop
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual ToolStripButton ButtonAbout
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
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

        internal virtual ToolStripSeparator ToolStripSeparator77
        {
            [CompilerGenerated]
            get => 
                this.QR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.QR = value);
        }

        internal virtual ToolStripButton ButtonSupport
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
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

        internal virtual ToolStripSeparator ToolStripSeparator80
        {
            [CompilerGenerated]
            get => 
                this.IR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.IR = value);
        }

        internal virtual ToolStripButton ButtonHelp
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual ToolStripSeparator ToolStripSeparator81
        {
            [CompilerGenerated]
            get => 
                this.DR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.DR = value);
        }

        internal virtual ToolStripButton ButtonUpdate
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.FP);
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

        internal virtual ToolStripDropDownButton ButtonWareHous
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                MouseEventHandler handler = new MouseEventHandler(this.A);
                ToolStripDropDownButton t = this.T;
                if (t != null)
                {
                    t.MouseDown -= handler;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.MouseDown += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem ButtWarehousAdd
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.GR);
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

        internal virtual ToolStripSeparator ToolStripSeparator29
        {
            [CompilerGenerated]
            get => 
                this.FR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.FR = value);
        }

        internal virtual ToolStripMenuItem ButtonWareHousM
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
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

        internal virtual Panel PanelLeft
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonMenuShow
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
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

        internal virtual Button ButtonMenuHide
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
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

        internal virtual ToolStripSeparator ToolStripSeparator13
        {
            [CompilerGenerated]
            get => 
                this.HR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.HR = value);
        }

        internal virtual Label TxTVerNumber
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripLabel DateTimeMainValu
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual ToolStripButton ButtonCash
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.UR);
                ToolStripButton t = this.T;
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

        internal virtual ToolStripSeparator ToolStripSeparator12
        {
            [CompilerGenerated]
            get => 
                this.TR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.TR = value);
        }

        internal virtual ToolStripMenuItem PutListPurchItems
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.HR);
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

        internal virtual ToolStripButton ButtonBarCode
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.NR);
                ToolStripButton x = this.X;
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

        internal virtual Timer TimerLoadRemnber
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.OR);
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

        internal virtual Panel PanelButtons
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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
                DataGridViewCellEventHandler handler2 = new DataGridViewCellEventHandler(this.R);
                DataGridView a = this.A;
                if (a != null)
                {
                    a.CellContentClick -= handler;
                    a.CellClick -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.CellContentClick += handler;
                    a.CellClick += handler2;
                }
            }
        }

        internal virtual Button ButtonCloudPrinter
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.BR);
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

        internal virtual Label LabelDB
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Timer TimerTiclString
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.RP);
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

        internal virtual Timer TimerRefreshCon
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.PP);
                Timer f = this.F;
                if (f != null)
                {
                    f.Tick -= handler;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.Tick += handler;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator19
        {
            [CompilerGenerated]
            get => 
                this.XR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.XR = value);
        }

        internal virtual ToolStripMenuItem ToolStripMenuItem1
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.QP);
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

        internal virtual ToolStripDropDownButton ButtonMyFile
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
                ToolStripDropDownButton x = this.X;
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

        internal virtual ToolStripMenuItem DBSerViewToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.IP);
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

        internal virtual ToolStripMenuItem DBSerRestToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.DP);
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

        internal virtual ToolStripSeparator ToolStripSeparator24
        {
            [CompilerGenerated]
            get => 
                this.GR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.GR = value);
        }

        internal virtual Label LabelTr
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Panel PanelStand
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Button ButtonStandHide
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.UP);
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

        internal virtual Button ButtonStandPrint
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.KP);
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

        internal virtual Button ButtonStandCash
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.GP);
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

        internal virtual Button ButtonStandQuery
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.EP);
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

        internal virtual Button ButtonStandPendin
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.XP);
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

        internal virtual Button ButtonStandNewInvoice
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.TP);
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

        internal virtual CheckBox CheckBoxCloseSale
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.LP);
                CheckBox a = this.A;
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
    }
}

