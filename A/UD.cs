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
    public class UD : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Panel1"), CompilerGenerated]
        private Panel A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox14")]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTNetTotal")]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [AccessedThroughProperty("TxTTotalDar"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox11")]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTotalDis"), CompilerGenerated]
        private Label P;
        [AccessedThroughProperty("GroupBox10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("TxTTotalTotal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxDate")]
        private CheckBox A;
        [CompilerGenerated, AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox9")]
        private GroupBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchType"), CompilerGenerated]
        private ComboBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonSortDate")]
        private Button A;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage R;
        [AccessedThroughProperty("TabPage3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage P;
        [AccessedThroughProperty("ButtonSuplier"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox6")]
        private GroupBox D;
        [AccessedThroughProperty("ComboBoxSuplier"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage4")]
        private TabPage Q;
        [CompilerGenerated, AccessedThroughProperty("ButtonUser"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [AccessedThroughProperty("GroupBoxUsers"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxUser")]
        private ComboBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage5")]
        private TabPage I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonNote"), CompilerGenerated]
        private Button Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox3")]
        private GroupBox H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTNoSe")]
        private TextBox A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonViewAll"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator8"), CompilerGenerated]
        private ToolStripSeparator A;
        [AccessedThroughProperty("ToolStripButtonEdit"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripButtonDelete"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonCard")]
        private ToolStripButton Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator5")]
        private ToolStripSeparator Q;
        [AccessedThroughProperty("ToolStripSeparator6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator I;
        [AccessedThroughProperty("ToolStripButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton I;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator D;
        [AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripProgressBar1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripLabel1"), CompilerGenerated]
        private ToolStripLabel A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTGVRowCount")]
        private ToolStripLabel R;
        [AccessedThroughProperty("ToolStripSeparator1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator F;
        [AccessedThroughProperty("TimerLoadData"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [CompilerGenerated, AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [CompilerGenerated, AccessedThroughProperty("ButtonMAX"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button I;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox T;
        [CompilerGenerated, AccessedThroughProperty("TxTNumberInvoice"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("ToolStripSeparator2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator H;
        [AccessedThroughProperty("ToolStripButtonAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GV"), CompilerGenerated]
        private DataGridView A;
        [AccessedThroughProperty("ToolStripButtonPrint"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripDropDownButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonPrintList"), CompilerGenerated]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("ToolStripSeparator10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator T;
        [CompilerGenerated, AccessedThroughProperty("ButtonPrintInvoice"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("Label3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonAdVSort"), CompilerGenerated]
        private Button D;
        [AccessedThroughProperty("TabPage6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage D;
        [AccessedThroughProperty("TabPage7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage F;
        [AccessedThroughProperty("ButtonPayType"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox7"), CompilerGenerated]
        private GroupBox X;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvSalePayType")]
        private ComboBox Q;
        [CompilerGenerated, AccessedThroughProperty("ButtonState"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button H;
        [AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox G;
        [AccessedThroughProperty("InvSaleStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox E;
        [AccessedThroughProperty("DateTimePickerFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PickerTimeFrom")]
        private DateTimePicker R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2")]
        private GroupBox K;
        [CompilerGenerated, AccessedThroughProperty("DateTimePickerTo"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PickerTimeTo"), CompilerGenerated]
        private DateTimePicker Q;
        private SqlConnection A;
        private int A;
        private DataTable A;
        private DataTable R;
        public static string A = "SELECT TaNNInvPurch.*, TaNNSupliers.SuplierName FROM TaNNInvPurch LEFT OUTER JOIN TaNNSupliers ON TaNNInvPurch.SuplierFrontID = TaNNSupliers.SuplierID WHERE (TaNNInvPurch.CenterFrontID = @CenterFrontID) AND (TaNNInvPurch.InvPurchType = @InvPurchType)";
        public static string R = "";

        public UD()
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
            this.Panel1 = new Panel();
            this.GroupBox14 = new GroupBox();
            this.TxTNetTotal = new Label();
            this.GroupBox12 = new GroupBox();
            this.TxTTotalDar = new Label();
            this.GroupBox11 = new GroupBox();
            this.TxTTotalDis = new Label();
            this.GroupBox10 = new GroupBox();
            this.TxTTotalTotal = new Label();
            this.CheckBoxDate = new CheckBox();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox9 = new GroupBox();
            this.InvPurchType = new ComboBox();
            this.ButtonSortDate = new Button();
            this.TabPage2 = new TabPage();
            this.ButtonMAX = new Button();
            this.GroupBox4 = new GroupBox();
            this.TxTNumberInvoice = new TextBox();
            this.TabPage3 = new TabPage();
            this.ButtonAdVSort = new Button();
            this.Label3 = new Label();
            this.ButtonSuplier = new Button();
            this.GroupBox6 = new GroupBox();
            this.ComboBoxSuplier = new ComboBox();
            this.TabPage4 = new TabPage();
            this.ButtonUser = new Button();
            this.GroupBoxUsers = new GroupBox();
            this.ComboBoxUser = new ComboBox();
            this.TabPage5 = new TabPage();
            this.ButtonNote = new Button();
            this.GroupBox3 = new GroupBox();
            this.TxTNoSe = new TextBox();
            this.TabPage7 = new TabPage();
            this.ButtonPayType = new Button();
            this.GroupBox7 = new GroupBox();
            this.InvSalePayType = new ComboBox();
            this.TabPage6 = new TabPage();
            this.ButtonState = new Button();
            this.GroupBox8 = new GroupBox();
            this.InvSaleStatus = new ComboBox();
            this.TxTTitle = new Label();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ToolStripButtonEdit = new ToolStripButton();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ToolStripButtonCard = new ToolStripButton();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.ButtonPrintInvoice = new ToolStripMenuItem();
            this.ToolStripSeparator10 = new ToolStripSeparator();
            this.ButtonPrintList = new ToolStripMenuItem();
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
            this.GroupBox1 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBox2 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.Panel1.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBoxUsers.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage7.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            base.SuspendLayout();
            this.Panel1.BackColor = SystemColors.HighlightText;
            this.Panel1.BorderStyle = BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox14);
            this.Panel1.Controls.Add(this.GroupBox12);
            this.Panel1.Controls.Add(this.GroupBox11);
            this.Panel1.Controls.Add(this.GroupBox10);
            this.Panel1.Dock = DockStyle.Bottom;
            this.Panel1.Location = new Point(0, 0x213);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x3d8, 0x3a);
            this.Panel1.TabIndex = 0x1ed36d3;
            this.GroupBox14.Controls.Add(this.TxTNetTotal);
            this.GroupBox14.Dock = DockStyle.Right;
            this.GroupBox14.Location = new Point(0x108, 0);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0xb3, 0x36);
            this.GroupBox14.TabIndex = 4;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "صافي المجموع";
            this.TxTNetTotal.Dock = DockStyle.Fill;
            this.TxTNetTotal.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTNetTotal.Location = new Point(3, 0x13);
            this.TxTNetTotal.Name = "TxTNetTotal";
            this.TxTNetTotal.Size = new Size(0xad, 0x20);
            this.TxTNetTotal.TabIndex = 0;
            this.TxTNetTotal.Text = "0";
            this.TxTNetTotal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox12.Controls.Add(this.TxTTotalDar);
            this.GroupBox12.Dock = DockStyle.Right;
            this.GroupBox12.Location = new Point(0x1bb, 0);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0xb3, 0x36);
            this.GroupBox12.TabIndex = 2;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "مجموع الضريبة";
            this.TxTTotalDar.Dock = DockStyle.Fill;
            this.TxTTotalDar.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalDar.Location = new Point(3, 0x13);
            this.TxTTotalDar.Name = "TxTTotalDar";
            this.TxTTotalDar.Size = new Size(0xad, 0x20);
            this.TxTTotalDar.TabIndex = 0;
            this.TxTTotalDar.Text = "0";
            this.TxTTotalDar.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox11.Controls.Add(this.TxTTotalDis);
            this.GroupBox11.Dock = DockStyle.Right;
            this.GroupBox11.Location = new Point(0x26e, 0);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0xb3, 0x36);
            this.GroupBox11.TabIndex = 1;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "مجموع الخصم";
            this.TxTTotalDis.Dock = DockStyle.Fill;
            this.TxTTotalDis.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalDis.Location = new Point(3, 0x13);
            this.TxTTotalDis.Name = "TxTTotalDis";
            this.TxTTotalDis.Size = new Size(0xad, 0x20);
            this.TxTTotalDis.TabIndex = 0;
            this.TxTTotalDis.Text = "0";
            this.TxTTotalDis.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox10.Controls.Add(this.TxTTotalTotal);
            this.GroupBox10.Dock = DockStyle.Right;
            this.GroupBox10.Location = new Point(0x321, 0);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0xb3, 0x36);
            this.GroupBox10.TabIndex = 0;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "المجموع الفرعي";
            this.TxTTotalTotal.Dock = DockStyle.Fill;
            this.TxTTotalTotal.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalTotal.Location = new Point(3, 0x13);
            this.TxTTotalTotal.Name = "TxTTotalTotal";
            this.TxTTotalTotal.Size = new Size(0xad, 0x20);
            this.TxTTotalTotal.TabIndex = 0;
            this.TxTTotalTotal.Text = "0";
            this.TxTTotalTotal.TextAlign = ContentAlignment.MiddleCenter;
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxDate.Checked = true;
            this.CheckBoxDate.CheckState = CheckState.Checked;
            this.CheckBoxDate.Dock = DockStyle.Top;
            this.CheckBoxDate.Location = new Point(0, 0x9d);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Padding = new Padding(4);
            this.CheckBoxDate.Size = new Size(0x3d8, 0x1c);
            this.CheckBoxDate.TabIndex = 0x1ed36d2;
            this.CheckBoxDate.Text = "تضمين فترة التاريخ دائماً مع كل عمليات الفرز";
            this.CheckBoxDate.UseVisualStyleBackColor = false;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage7);
            this.TabControl1.Controls.Add(this.TabPage6);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 0x7b);
            this.TabControl1.TabIndex = 0x1ed36d0;
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.ButtonSortDate);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3d0, 0x5e);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الرئيسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox9.Controls.Add(this.InvPurchType);
            this.GroupBox9.Location = new Point(0x2ad, 12);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x11b, 0x35);
            this.GroupBox9.TabIndex = 0x1ed36cc;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "نوع الفاتورة";
            this.InvPurchType.Dock = DockStyle.Fill;
            this.InvPurchType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.InvPurchType.FormattingEnabled = true;
            object[] items = new object[] { "فاتورة مشتريات", "فاتورة مرتجع مشتريات" };
            this.InvPurchType.Items.AddRange(items);
            this.InvPurchType.Location = new Point(3, 0x13);
            this.InvPurchType.Name = "InvPurchType";
            this.InvPurchType.Size = new Size(0x115, 0x18);
            this.InvPurchType.TabIndex = 0x2c;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(6, 0x1f);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(280, 50);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.ButtonMAX);
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x3d0, 0x48);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "فرز حسب رقم الفاتورة";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonMAX.FlatAppearance.BorderColor = Color.Green;
            this.ButtonMAX.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonMAX.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonMAX.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonMAX.FlatStyle = FlatStyle.Flat;
            this.ButtonMAX.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonMAX.Image = A.F.ImSort;
            this.ButtonMAX.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonMAX.Location = new Point(310, 0x11);
            this.ButtonMAX.Margin = new Padding(3, 4, 3, 4);
            this.ButtonMAX.Name = "ButtonMAX";
            this.ButtonMAX.Size = new Size(280, 0x2c);
            this.ButtonMAX.TabIndex = 0x1ed36d0;
            this.ButtonMAX.Text = "فرز";
            this.ButtonMAX.UseVisualStyleBackColor = true;
            this.GroupBox4.Controls.Add(this.TxTNumberInvoice);
            this.GroupBox4.Location = new Point(0x254, 10);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(360, 0x34);
            this.GroupBox4.TabIndex = 0x1ed36cf;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "رقم الفاتورة";
            this.TxTNumberInvoice.BackColor = SystemColors.Info;
            this.TxTNumberInvoice.Dock = DockStyle.Fill;
            this.TxTNumberInvoice.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTNumberInvoice.Location = new Point(3, 0x13);
            this.TxTNumberInvoice.Name = "TxTNumberInvoice";
            this.TxTNumberInvoice.RightToLeft = RightToLeft.No;
            this.TxTNumberInvoice.Size = new Size(0x162, 0x1b);
            this.TxTNumberInvoice.TabIndex = 0x1ed36cc;
            this.TxTNumberInvoice.TextAlign = HorizontalAlignment.Center;
            this.TabPage3.Controls.Add(this.ButtonAdVSort);
            this.TabPage3.Controls.Add(this.Label3);
            this.TabPage3.Controls.Add(this.ButtonSuplier);
            this.TabPage3.Controls.Add(this.GroupBox6);
            this.TabPage3.Location = new Point(4, 0x19);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x3d0, 0x48);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "فرز حسب المورد";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.ButtonAdVSort.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdVSort.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdVSort.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdVSort.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdVSort.FlatStyle = FlatStyle.Flat;
            this.ButtonAdVSort.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdVSort.Image = A.F.ImSort;
            this.ButtonAdVSort.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdVSort.Location = new Point(0x138, 0x11);
            this.ButtonAdVSort.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdVSort.Name = "ButtonAdVSort";
            this.ButtonAdVSort.Size = new Size(0x91, 0x2c);
            this.ButtonAdVSort.TabIndex = 0x4b;
            this.ButtonAdVSort.Text = "فرز متقدم";
            this.ButtonAdVSort.UseVisualStyleBackColor = true;
            this.Label3.Dock = DockStyle.Left;
            this.Label3.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label3.Location = new Point(0, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x132, 0x48);
            this.Label3.TabIndex = 0x48;
            this.Label3.Text = "*ملاحظة: الفواتير التي تم شراؤها من المورد من خلال الفروع الآخرى لن يتم فرزها في قائمة الفرع الحالي.";
            this.Label3.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonSuplier.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSuplier.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSuplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSuplier.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSuplier.FlatStyle = FlatStyle.Flat;
            this.ButtonSuplier.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSuplier.Image = A.F.ImSort;
            this.ButtonSuplier.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSuplier.Location = new Point(0x1cf, 0x11);
            this.ButtonSuplier.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSuplier.Name = "ButtonSuplier";
            this.ButtonSuplier.Size = new Size(0x84, 0x2c);
            this.ButtonSuplier.TabIndex = 70;
            this.ButtonSuplier.Text = "فرز";
            this.ButtonSuplier.UseVisualStyleBackColor = true;
            this.GroupBox6.Controls.Add(this.ComboBoxSuplier);
            this.GroupBox6.Location = new Point(0x259, 9);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x16d, 0x36);
            this.GroupBox6.TabIndex = 0x45;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "المورد";
            this.ComboBoxSuplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxSuplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxSuplier.Dock = DockStyle.Fill;
            this.ComboBoxSuplier.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxSuplier.FormattingEnabled = true;
            this.ComboBoxSuplier.IntegralHeight = false;
            this.ComboBoxSuplier.Location = new Point(3, 0x13);
            this.ComboBoxSuplier.Name = "ComboBoxSuplier";
            this.ComboBoxSuplier.Size = new Size(0x167, 0x18);
            this.ComboBoxSuplier.TabIndex = 0x44;
            this.TabPage4.Controls.Add(this.ButtonUser);
            this.TabPage4.Controls.Add(this.GroupBoxUsers);
            this.TabPage4.Location = new Point(4, 0x19);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x3d0, 0x48);
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
            this.ButtonUser.Location = new Point(0x155, 14);
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
            this.TabPage5.Size = new Size(0x3d0, 0x48);
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
            this.ButtonNote.Location = new Point(0x134, 20);
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
            this.TabPage7.Controls.Add(this.ButtonPayType);
            this.TabPage7.Controls.Add(this.GroupBox7);
            this.TabPage7.Location = new Point(4, 0x19);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new Padding(3);
            this.TabPage7.Size = new Size(0x3d0, 0x48);
            this.TabPage7.TabIndex = 6;
            this.TabPage7.Text = "فرز حسب طريقة الدفع";
            this.TabPage7.UseVisualStyleBackColor = true;
            this.ButtonPayType.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPayType.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPayType.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPayType.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPayType.FlatStyle = FlatStyle.Flat;
            this.ButtonPayType.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPayType.Image = A.F.ImSort;
            this.ButtonPayType.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPayType.Location = new Point(0x15d, 0x11);
            this.ButtonPayType.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPayType.Name = "ButtonPayType";
            this.ButtonPayType.Size = new Size(280, 0x2c);
            this.ButtonPayType.TabIndex = 0x1ed36d0;
            this.ButtonPayType.Text = "فرز";
            this.ButtonPayType.UseVisualStyleBackColor = true;
            this.GroupBox7.Controls.Add(this.InvSalePayType);
            this.GroupBox7.Location = new Point(0x2a4, 11);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x11a, 0x33);
            this.GroupBox7.TabIndex = 0x1ed36cf;
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
            this.TabPage6.Controls.Add(this.ButtonState);
            this.TabPage6.Controls.Add(this.GroupBox8);
            this.TabPage6.Location = new Point(4, 0x19);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new Padding(3);
            this.TabPage6.Size = new Size(0x3d0, 0x48);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "فرز حسب الحالة";
            this.TabPage6.UseVisualStyleBackColor = true;
            this.ButtonState.FlatAppearance.BorderColor = Color.Green;
            this.ButtonState.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonState.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonState.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonState.FlatStyle = FlatStyle.Flat;
            this.ButtonState.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonState.Image = A.F.ImSort;
            this.ButtonState.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonState.Location = new Point(0x152, 14);
            this.ButtonState.Margin = new Padding(3, 4, 3, 4);
            this.ButtonState.Name = "ButtonState";
            this.ButtonState.Size = new Size(280, 0x2c);
            this.ButtonState.TabIndex = 0x1ed36d1;
            this.ButtonState.Text = "فرز";
            this.ButtonState.UseVisualStyleBackColor = true;
            this.GroupBox8.Controls.Add(this.InvSaleStatus);
            this.GroupBox8.Location = new Point(0x2a4, 11);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x11a, 0x33);
            this.GroupBox8.TabIndex = 0x1ed36d0;
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
            this.TxTTitle.TabIndex = 0x1ed36cf;
            this.TxTTitle.Text = "قائمة فواتير المشتريات/ مرتجع المشتريات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[14];
            toolStripItems[0] = this.ToolStripButtonViewAll;
            toolStripItems[1] = this.ToolStripSeparator2;
            toolStripItems[2] = this.ToolStripButtonAdd;
            toolStripItems[3] = this.ToolStripSeparator8;
            toolStripItems[4] = this.ToolStripButtonEdit;
            toolStripItems[5] = this.ToolStripSeparator3;
            toolStripItems[6] = this.ToolStripButtonDelete;
            toolStripItems[7] = this.ToolStripSeparator4;
            toolStripItems[8] = this.ToolStripButtonCard;
            toolStripItems[9] = this.ToolStripSeparator5;
            toolStripItems[10] = this.ToolStripButtonPrint;
            toolStripItems[11] = this.ToolStripSeparator6;
            toolStripItems[12] = this.ToolStripButtonClose;
            toolStripItems[13] = this.ToolStripSeparator7;
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x24d);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36ce;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
            this.ToolStripButtonAdd.Image = A.F.ImAdd;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(0x49, 0x2c);
            this.ToolStripButtonAdd.Text = "اضافة";
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
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.ButtonPrintInvoice, this.ToolStripSeparator10, this.ButtonPrintList };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray2);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x69, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة A4";
            this.ButtonPrintInvoice.Image = A.F.ImPrint;
            this.ButtonPrintInvoice.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonPrintInvoice.Name = "ButtonPrintInvoice";
            this.ButtonPrintInvoice.Size = new Size(0xb2, 0x26);
            this.ButtonPrintInvoice.Text = "الفاتورة المحددة";
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new Size(0xaf, 6);
            this.ButtonPrintList.Image = A.F.ImPrint;
            this.ButtonPrintList.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonPrintList.Name = "ButtonPrintList";
            this.ButtonPrintList.Size = new Size(0xb2, 0x26);
            this.ButtonPrintList.Text = "القائمة اعلاه";
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
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray3);
            this.ToolStripStatus.Location = new Point(0, 0x27c);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
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
            this.GV.Size = new Size(0x3d8, 0x15a);
            this.GV.TabIndex = 0x1ed36d4;
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x1ee, 10);
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
            this.GroupBox2.Location = new Point(0x12a, 12);
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
            base.Name = "InvoicePurchList";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "قائمة فواتير المشتريات/ مرتجع المشتريات";
            this.Panel1.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.GroupBoxUsers.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.TabPage7.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
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
                this.ButtonMAX.PerformClick();
            }
        }

        private void B(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void D(object A, EventArgs R)
        {
            UD.R = UD.A;
            if (!this.CheckBoxDate.Checked)
            {
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchUserAddBy = @InvPurchUserAddBy)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchDateTime BETWEEN @DF and @DT) AND (TaNNInvPurch.InvPurchUserAddBy = @InvPurchUserAddBy)";
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
            if (!PR.QP)
            {
                Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                XD.A = 0;
                A.D.A.A.ShowDialog();
            }
        }

        private void F(object A, EventArgs R)
        {
            UD.R = UD.A;
            if (!this.CheckBoxDate.Checked)
            {
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchNote LIKE '%' + @InvPurchNote + '%')";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchDateTime BETWEEN @DF and @DT) AND (TaNNInvPurch.InvPurchNote LIKE '%' + @InvPurchNote + '%')";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void G(object A, EventArgs R)
        {
            try
            {
                if (!PR.QP)
                {
                    Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
                }
                else if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    this.A = this.GV.CurrentRow.Index;
                    ED.A = false;
                    ED.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvPurchID"].Value.ToString());
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

        private void H(object A, EventArgs R)
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
                    GD.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvPurchID"].Value.ToString());
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

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            UD.R = UD.A;
            if (!this.CheckBoxDate.Checked)
            {
                UD.R = UD.A + " AND (TaNNInvPurch.SuplierFrontID = @SuplierFrontID)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchDateTime BETWEEN @DF and @DT) AND (TaNNInvPurch.SuplierFrontID = @SuplierFrontID)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void K(object A, EventArgs R)
        {
            UD.R = UD.A;
            this.TimerLoadData.Enabled = true;
        }

        private void L(object A, EventArgs R)
        {
            UD.R = UD.A;
            if (!this.CheckBoxDate.Checked)
            {
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchNumber = @InvPurchNumber)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchDateTime BETWEEN @DF and @DT) AND (TaNNInvPurch.InvPurchNumber = @InvPurchNumber)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void N(object A, EventArgs R)
        {
        }

        private void O(object A, EventArgs R)
        {
            Application.DoEvents();
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    string selectCommandText = "SELECT TaNNInvPurch.*, TaNNSupliers.*, TaNNInvPurchItems.*\r\nFROM            TaNNInvPurch LEFT OUTER JOIN\r\n                         TaNNSupliers ON TaNNInvPurch.SuplierFrontID = TaNNSupliers.SuplierID LEFT OUTER JOIN\r\n                         TaNNInvPurchItems ON TaNNInvPurch.InvPurchID = TaNNInvPurchItems.InvPurchIDFrontID\r\nWHERE        (TaNNInvPurch.InvPurchID = @InvPurchID)";
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    dataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("InvPurchID", this.GV.SelectedRows[0].Cells["InvPurchID"].Value.ToString());
                    adapter.Fill(dataTable);
                    this.A.Close();
                    JQ jq = new JQ();
                    jq.SetDataSource(dataTable);
                    jq.SetParameterValue("CenterName", PR.ER.ToString());
                    jq.SetParameterValue("CenterSubName", PR.KR.ToString());
                    jq.SetParameterValue("ParameterDeimelQ", PR.X);
                    jq.SetParameterValue("ParameterDeimelS", PR.T);
                    jq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                    if (PR.NR == null)
                    {
                        jq.SetParameterValue("CenterCurrencyName", " ");
                    }
                    else
                    {
                        jq.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                    }
                    if (PR.UR == null)
                    {
                        jq.SetParameterValue("CenterPhone", " ");
                    }
                    else
                    {
                        jq.SetParameterValue("CenterPhone", PR.UR.ToString());
                    }
                    new HR { CRViewer = { ReportSource = jq } }.ShowDialog();
                    jq.Close();
                    jq.Dispose();
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

        private void P(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            if (UD.R == null)
            {
                UD.R = UD.A;
            }
            this.TimerFillGV.Enabled = true;
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
                string selectCommandText = "SELECT [SuplierID], [SuplierName] FROM TaNNSupliers";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.ComboBoxSuplier.ValueMember = "SuplierID";
                    this.ComboBoxSuplier.DisplayMember = "SuplierName";
                    this.ComboBoxSuplier.DataSource = dataTable;
                    this.ComboBoxSuplier.SelectedIndex = -1;
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
            UD.R = UD.A;
            if (this.CheckBoxDate.Checked)
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchDateTime BETWEEN @DF and @DT)";
            }
            this.TimerLoadData.Enabled = true;
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
                this.A.Clear();
                this.R.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(R, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.SelectCommand.Parameters.AddWithValue("InvPurchType", this.InvPurchType.SelectedIndex);
                string text = this.TxTNumberInvoice.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvPurchNumber", text ?? DBNull.Value);
                string text2 = this.InvSaleStatus.SelectedIndex.ToString();
                adapter.SelectCommand.Parameters.AddWithValue("InvPurchStatus", text2 ?? DBNull.Value);
                string text3 = this.InvSalePayType.SelectedIndex.ToString();
                adapter.SelectCommand.Parameters.AddWithValue("InvPurchPayType", text3 ?? DBNull.Value);
                string text4 = time.ToString("yyyy/MM/dd HH:mm");
                adapter.SelectCommand.Parameters.AddWithValue("DF", text4 ?? DBNull.Value);
                string text5 = time2.ToString("yyyy/MM/dd HH:mm");
                adapter.SelectCommand.Parameters.AddWithValue("DT", text5 ?? DBNull.Value);
                object selectedValue = this.ComboBoxSuplier.SelectedValue;
                adapter.SelectCommand.Parameters.AddWithValue("SuplierFrontID", selectedValue ?? DBNull.Value);
                string text6 = this.ComboBoxUser.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvPurchUserAddBy", text6 ?? DBNull.Value);
                string text7 = this.TxTNoSe.Text;
                adapter.SelectCommand.Parameters.AddWithValue("InvPurchNote", text7 ?? DBNull.Value);
                adapter.Fill(this.R);
                adapter.Fill(this.A);
                this.A.Close();
                decimal left = 0M;
                decimal num2 = 0M;
                decimal num3 = 0M;
                decimal num4 = 0M;
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
                        object[] arguments = new object[] { "InvPurchTotalAmount" };
                        left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                        object[] objArray2 = new object[] { "InvPurchDisVal" };
                        num2 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num2, NewLateBinding.LateIndexGet(current, objArray2, null)));
                        object[] objArray3 = new object[] { "InvPurchDarVal" };
                        num3 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num3, NewLateBinding.LateIndexGet(current, objArray3, null)));
                        object[] objArray4 = new object[] { "InvPurchTotalNET" };
                        num4 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num4, NewLateBinding.LateIndexGet(current, objArray4, null)));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                this.TxTTotalTotal.Text = left.ToString(PR.YR);
                this.TxTTotalDis.Text = num2.ToString(PR.YR);
                this.TxTTotalDar.Text = num3.ToString(PR.YR);
                this.TxTNetTotal.Text = num4.ToString(PR.YR);
                this.GV.DataSource = this.R;
                this.GV.Refresh();
                this.GV.Columns["InvPurchID"].HeaderText = "الترميز";
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["SuplierFrontID"].Visible = false;
                this.GV.Columns["InvPurchNumber"].HeaderText = "رقم الفاتورة";
                this.GV.Columns["InvPurchDateTime"].HeaderText = "تاريخ/ وقت";
                this.GV.Columns["InvPurchType"].HeaderText = "نوع الفاتورة";
                this.GV.Columns["InvPurchStatus"].HeaderText = "الحالة";
                this.GV.Columns["InvPurchPayType"].HeaderText = "طريقة الدفع";
                this.GV.Columns["InvPurchItems"].HeaderText = "عدد المواد";
                this.GV.Columns["InvPurchTotalAmount"].HeaderText = "اجمالي المبلغ";
                this.GV.Columns["InvPurchDisMaWi"].HeaderText = "الخصم %";
                this.GV.Columns["InvPurchDisVal"].HeaderText = "مبلغ الخصم";
                this.GV.Columns["InvPurchDarMiWi"].HeaderText = "الضريبة %";
                this.GV.Columns["InvPurchDarVal"].HeaderText = "مبلغ الضريبة";
                this.GV.Columns["InvPurchTotalNET"].HeaderText = "صافي المجموع";
                this.GV.Columns["InvPurchMonBas"].Visible = false;
                this.GV.Columns["InvPurchMonPay"].Visible = false;
                this.GV.Columns["InvPurchMonBak"].Visible = false;
                this.GV.Columns["InvPurchMonDem"].Visible = false;
                this.GV.Columns["InvPurchMonRod"].Visible = false;
                this.GV.Columns["InvPurchIsMonRod"].Visible = false;
                this.GV.Columns["InvPurchOtherCuru"].Visible = false;
                this.GV.Columns["InvPurchNote"].HeaderText = "ملاحظات";
                this.GV.Columns["InvPurchUserAddBy"].HeaderText = "الموظف";
                this.GV.Columns["InvPurchIsCashCount"].HeaderText = "مقيدة على الكاش";
                this.GV.Columns["SuplierName"].HeaderText = "المورد";
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
                        decimal num6 = new decimal(Conversion.Val(current.Cells["InvPurchTotalAmount"].Value.ToString()));
                        decimal num7 = new decimal(Conversion.Val(current.Cells["InvPurchDisVal"].Value.ToString()));
                        decimal num8 = new decimal(Conversion.Val(current.Cells["InvPurchDarVal"].Value.ToString()));
                        decimal num9 = new decimal(Conversion.Val(current.Cells["InvPurchTotalNET"].Value.ToString()));
                        current.Cells["InvPurchTotalAmount"].Value = num6.ToString(PR.YR);
                        current.Cells["InvPurchDisVal"].Value = num7.ToString(PR.YR);
                        current.Cells["InvPurchDarVal"].Value = num8.ToString(PR.YR);
                        current.Cells["InvPurchTotalNET"].Value = num9.ToString(PR.YR);
                        decimal num10 = new decimal(Conversion.Val(current.Cells["InvPurchType"].Value.ToString()));
                        decimal num11 = new decimal(Conversion.Val(current.Cells["InvPurchStatus"].Value.ToString()));
                        decimal num12 = new decimal(Conversion.Val(current.Cells["InvPurchPayType"].Value.ToString()));
                        if (decimal.Compare(num10, decimal.Zero) == 0)
                        {
                            current.Cells["InvPurchType"].Value = "فاتورة مشتريات";
                        }
                        else if (decimal.Compare(num10, decimal.One) == 0)
                        {
                            current.Cells["InvPurchType"].Value = "مرتجع مشتريات";
                        }
                        if (decimal.Compare(num12, decimal.Zero) == 0)
                        {
                            current.Cells["InvPurchPayType"].Value = "نقدا";
                        }
                        else if (decimal.Compare(num12, decimal.One) == 0)
                        {
                            current.Cells["InvPurchPayType"].Value = "ذمم";
                        }
                        else if (decimal.Compare(num12, 2M) == 0)
                        {
                            current.Cells["InvPurchPayType"].Value = "شبكة";
                        }
                        else if (decimal.Compare(num12, 3M) == 0)
                        {
                            current.Cells["InvPurchPayType"].Value = "تحويل";
                        }
                        else if (decimal.Compare(num12, 4M) == 0)
                        {
                            current.Cells["InvPurchPayType"].Value = "الرصيد المدور";
                        }
                        else if (decimal.Compare(num12, 5M) == 0)
                        {
                            current.Cells["InvPurchPayType"].Value = "شيك";
                        }
                        else if (decimal.Compare(num12, 6M) == 0)
                        {
                            current.Cells["InvPurchPayType"].Value = "إئتمان";
                        }
                        if (decimal.Compare(num11, decimal.Zero) == 0)
                        {
                            current.Cells["InvPurchStatus"].Value = "مكتملة";
                        }
                        else if (decimal.Compare(num11, decimal.One) == 0)
                        {
                            current.Cells["InvPurchStatus"].Value = "معلقة";
                        }
                        else if (decimal.Compare(num11, 2M) == 0)
                        {
                            current.Cells["InvPurchStatus"].Value = "قيد التعديل";
                        }
                        else if (decimal.Compare(num11, 3M) == 0)
                        {
                            current.Cells["InvPurchStatus"].Value = "معدلة";
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
                if (this.InvPurchType.SelectedIndex == 0)
                {
                    this.TxTTitle.Text = "قائمة فواتير المشتريات";
                    this.TxTTitle.ForeColor = Color.DarkGreen;
                    this.TxTTitle.Font = new Font("Tahoma", 12f);
                }
                else if (this.InvPurchType.SelectedIndex == 1)
                {
                    this.TxTTitle.Text = "قائمة فواتير مرتجع المشتريات";
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
            this.TxTTitle.Text = PR.A.ToString();
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
            UD.R = UD.A;
            if (!this.CheckBoxDate.Checked)
            {
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchPayType = @InvPurchPayType)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchDateTime BETWEEN @DF and @DT) AND (TaNNInvPurch.InvPurchPayType = @InvPurchPayType)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void T(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
        }

        private void U(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void V(object A, EventArgs R)
        {
        }

        private void X(object A, EventArgs R)
        {
            try
            {
                if (!PR.PP)
                {
                    Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
                }
                else if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    this.A = this.GV.CurrentRow.Index;
                    ED.A = true;
                    ED.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvPurchID"].Value.ToString());
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

        private void Y(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                FI fi = new FI();
                fi.SetDataSource(this.A);
                fi.SetParameterValue("CenterName", PR.ER.ToString());
                fi.SetParameterValue("CenterSubName", PR.KR.ToString());
                fi.SetParameterValue("ParameterDeimelQ", PR.X);
                fi.SetParameterValue("ParameterDeimelS", PR.T);
                fi.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                fi.SetParameterValue("RPTitle", this.TxTTitle.Text);
                if (PR.NR == null)
                {
                    fi.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    fi.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                }
                if (PR.UR == null)
                {
                    fi.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    fi.SetParameterValue("CenterPhone", PR.UR.ToString());
                }
                fi.SetParameterValue("TxTSubTotal", this.TxTTotalTotal.Text);
                fi.SetParameterValue("TXTDar", this.TxTTotalDar.Text);
                fi.SetParameterValue("TXTDis", this.TxTTotalDis.Text);
                fi.SetParameterValue("TxTNetTotal", this.TxTNetTotal.Text);
                new HR { CRViewer = { ReportSource = fi } }.ShowDialog();
                fi.Close();
                fi.Dispose();
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
            UD.R = UD.A;
            if (!this.CheckBoxDate.Checked)
            {
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchStatus = @InvPurchStatus)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                UD.R = UD.A + " AND (TaNNInvPurch.InvPurchDateTime BETWEEN @DF and @DT) AND (TaNNInvPurch.InvPurchStatus = @InvPurchStatus)";
            }
            this.TimerLoadData.Enabled = true;
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label TxTNetTotal
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label TxTTotalDar
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label TxTTotalDis
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTTotalTotal
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ComboBox InvPurchType
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

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonSuplier
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual ComboBox ComboBoxSuplier
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual GroupBox GroupBoxUsers
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox TxTNoSe
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
                TextBox a = this.A;
                if (a != null)
                {
                    a.TextChanged -= handler;
                    a.KeyPress -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.TextChanged += handler;
                    a.KeyPress += handler2;
                }
            }
        }

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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
                EventHandler handler = new EventHandler(this.K);
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
                EventHandler handler = new EventHandler(this.G);
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
                EventHandler handler = new EventHandler(this.X);
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
                EventHandler handler = new EventHandler(this.H);
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
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual Timer TimerFillGV
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual Button ButtonMAX
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TextBox TxTNumberInvoice
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
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

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual ToolStripButton ToolStripButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual ToolStripMenuItem ButtonPrintList
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
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

        internal virtual ToolStripSeparator ToolStripSeparator10
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual ToolStripMenuItem ButtonPrintInvoice
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

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Button ButtonAdVSort
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.B);
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

        internal virtual Button ButtonPayType
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
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
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

        internal virtual Button ButtonState
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Z);
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
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual ComboBox InvSaleStatus
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
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
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
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

