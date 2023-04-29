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
    public class KD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox9"), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("InvPurchType"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [AccessedThroughProperty("ButtonSortDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage2"), CompilerGenerated]
        private TabPage R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSorCode")]
        private Button R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox4")]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTMaterialBarCode")]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage3")]
        private TabPage P;
        [CompilerGenerated, AccessedThroughProperty("ButtonSuplier"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox6"), CompilerGenerated]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxSuplier"), CompilerGenerated]
        private ComboBox R;
        [AccessedThroughProperty("TabPage4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonUser"), CompilerGenerated]
        private Button Q;
        [AccessedThroughProperty("GroupBoxUsers"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("ComboBoxUser"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage5")]
        private TabPage I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSorName"), CompilerGenerated]
        private Button I;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTMaterialName"), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("Panel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonViewAll"), CompilerGenerated]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator7"), CompilerGenerated]
        private ToolStripSeparator R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripLabel1")]
        private ToolStripLabel A;
        [AccessedThroughProperty("TxTGVRowCount"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated]
        private ToolStripSeparator P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GV"), CompilerGenerated]
        private DataGridView A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxDate"), CompilerGenerated]
        private CheckBox A;
        [AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerLoadData"), CompilerGenerated]
        private Timer R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimersStartUp")]
        private Timer P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonApply")]
        private ToolStripButton P;
        [CompilerGenerated, AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("TxTTotalS"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("GroupBox16"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [AccessedThroughProperty("TxTTotalQ"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [AccessedThroughProperty("ToolStripButtonOK"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator Q;
        [AccessedThroughProperty("ToolStripButtonPrint"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator I;
        [AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("ButtonAdVSort"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button D;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("DateTimePickerFrom")]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("DateTimePickerTo")]
        private DateTimePicker P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PickerTimeTo"), CompilerGenerated]
        private DateTimePicker Q;
        private SqlConnection A;
        public static string A;
        private DataTable A;
        private DataTable R;
        public static string R = "SELECT TaNNInvPurchItems.*, TaNNSupliers.SuplierName FROM TaNNInvPurchItems LEFT OUTER JOIN TaNNSupliers ON TaNNInvPurchItems.SuplierFrontID = TaNNSupliers.SuplierID WHERE (TaNNInvPurchItems.CenterFrontID = @CenterFrontID) AND (TaNNInvPurchItems.InvPurchType = @InvPurchType)";
        public static string P = "";
        public static string Q;
        public static string I;
        private int A;

        public KD()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.R = new DataTable();
            this.A = 0;
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
            this.GroupBox9 = new GroupBox();
            this.InvPurchType = new ComboBox();
            this.ButtonSortDate = new Button();
            this.TabPage2 = new TabPage();
            this.ButtonSorCode = new Button();
            this.GroupBox4 = new GroupBox();
            this.TxTMaterialBarCode = new TextBox();
            this.TabPage5 = new TabPage();
            this.ButtonSorName = new Button();
            this.GroupBox3 = new GroupBox();
            this.TxTMaterialName = new TextBox();
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
            this.Panel1 = new Panel();
            this.GroupBox5 = new GroupBox();
            this.TxTTotalS = new Label();
            this.GroupBox16 = new GroupBox();
            this.TxTTotalQ = new Label();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripButtonPrint = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ToolStripButtonApply = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripButtonOK = new ToolStripButton();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowCount = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.GV = new DataGridView();
            this.CheckBoxDate = new CheckBox();
            this.TimerFillGV = new Timer(this.A);
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
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
            this.GroupBox4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBoxUsers.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d8, 0x22);
            this.TxTTitle.TabIndex = 0x1ed36d0;
            this.TxTTitle.Text = "سجل المشتريات/مرتجع المشتريات حسب المادة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 0x79);
            this.TabControl1.TabIndex = 0x1ed36d1;
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.ButtonSortDate);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3d0, 0x5c);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الرئيسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox9.Controls.Add(this.InvPurchType);
            this.GroupBox9.Location = new Point(0x2ad, 8);
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
            this.ButtonSortDate.Location = new Point(0x15, 0x1b);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(280, 50);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.ButtonSorCode);
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x3d0, 0x48);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "فرز حسب رقم/ باركود المادة";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonSorCode.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSorCode.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSorCode.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSorCode.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSorCode.FlatStyle = FlatStyle.Flat;
            this.ButtonSorCode.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSorCode.Image = A.F.ImSort;
            this.ButtonSorCode.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSorCode.Location = new Point(310, 0x11);
            this.ButtonSorCode.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSorCode.Name = "ButtonSorCode";
            this.ButtonSorCode.Size = new Size(280, 0x2c);
            this.ButtonSorCode.TabIndex = 0x1ed36d0;
            this.ButtonSorCode.Text = "فرز";
            this.ButtonSorCode.UseVisualStyleBackColor = true;
            this.GroupBox4.Controls.Add(this.TxTMaterialBarCode);
            this.GroupBox4.Location = new Point(0x254, 10);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(360, 0x34);
            this.GroupBox4.TabIndex = 0x1ed36cf;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "رقم/ باركود المادة";
            this.TxTMaterialBarCode.BackColor = SystemColors.Info;
            this.TxTMaterialBarCode.Dock = DockStyle.Fill;
            this.TxTMaterialBarCode.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMaterialBarCode.Location = new Point(3, 0x13);
            this.TxTMaterialBarCode.Name = "TxTMaterialBarCode";
            this.TxTMaterialBarCode.RightToLeft = RightToLeft.No;
            this.TxTMaterialBarCode.Size = new Size(0x162, 0x1b);
            this.TxTMaterialBarCode.TabIndex = 0x1ed36cc;
            this.TxTMaterialBarCode.TextAlign = HorizontalAlignment.Center;
            this.TabPage5.Controls.Add(this.ButtonSorName);
            this.TabPage5.Controls.Add(this.GroupBox3);
            this.TabPage5.Location = new Point(4, 0x19);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new Size(0x3d0, 0x48);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "فرز حسب اسم المادة";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.ButtonSorName.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSorName.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSorName.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSorName.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSorName.FlatStyle = FlatStyle.Flat;
            this.ButtonSorName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSorName.Image = A.F.ImSort;
            this.ButtonSorName.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSorName.Location = new Point(0x134, 20);
            this.ButtonSorName.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSorName.Name = "ButtonSorName";
            this.ButtonSorName.Size = new Size(280, 0x2c);
            this.ButtonSorName.TabIndex = 0x1ed36ce;
            this.ButtonSorName.Text = "فرز";
            this.ButtonSorName.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.TxTMaterialName);
            this.GroupBox3.Location = new Point(0x252, 13);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(360, 0x34);
            this.GroupBox3.TabIndex = 0x1ed36cd;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "اسم المادة";
            this.TxTMaterialName.BackColor = SystemColors.Info;
            this.TxTMaterialName.Dock = DockStyle.Fill;
            this.TxTMaterialName.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMaterialName.Location = new Point(3, 0x13);
            this.TxTMaterialName.Name = "TxTMaterialName";
            this.TxTMaterialName.RightToLeft = RightToLeft.No;
            this.TxTMaterialName.Size = new Size(0x162, 0x1b);
            this.TxTMaterialName.TabIndex = 0x1ed36cc;
            this.TxTMaterialName.TextAlign = HorizontalAlignment.Center;
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
            this.ButtonAdVSort.Location = new Point(0x15d, 0x11);
            this.ButtonAdVSort.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdVSort.Name = "ButtonAdVSort";
            this.ButtonAdVSort.Size = new Size(0x97, 0x2c);
            this.ButtonAdVSort.TabIndex = 0x4b;
            this.ButtonAdVSort.Text = "فرز متقدم";
            this.ButtonAdVSort.UseVisualStyleBackColor = true;
            this.Label3.Dock = DockStyle.Left;
            this.Label3.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label3.Location = new Point(0, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x157, 0x48);
            this.Label3.TabIndex = 0x49;
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
            this.ButtonSuplier.Location = new Point(0x1fa, 0x11);
            this.ButtonSuplier.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSuplier.Name = "ButtonSuplier";
            this.ButtonSuplier.Size = new Size(0x8d, 0x2c);
            this.ButtonSuplier.TabIndex = 70;
            this.ButtonSuplier.Text = "فرز";
            this.ButtonSuplier.UseVisualStyleBackColor = true;
            this.GroupBox6.Controls.Add(this.ComboBoxSuplier);
            this.GroupBox6.Location = new Point(0x28d, 9);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x139, 0x36);
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
            this.ComboBoxSuplier.Size = new Size(0x133, 0x18);
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
            this.Panel1.BackColor = SystemColors.HighlightText;
            this.Panel1.BorderStyle = BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox5);
            this.Panel1.Controls.Add(this.GroupBox16);
            this.Panel1.Dock = DockStyle.Bottom;
            this.Panel1.Location = new Point(0, 0x213);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x3d8, 0x3a);
            this.Panel1.TabIndex = 0x1ed36d6;
            this.GroupBox5.Controls.Add(this.TxTTotalS);
            this.GroupBox5.Dock = DockStyle.Right;
            this.GroupBox5.Location = new Point(660, 0);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(160, 0x36);
            this.GroupBox5.TabIndex = 8;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "مجموع سعر التكلفة";
            this.TxTTotalS.Dock = DockStyle.Fill;
            this.TxTTotalS.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalS.Location = new Point(3, 0x13);
            this.TxTTotalS.Name = "TxTTotalS";
            this.TxTTotalS.Size = new Size(0x9a, 0x20);
            this.TxTTotalS.TabIndex = 0;
            this.TxTTotalS.Text = "0";
            this.TxTTotalS.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox16.Controls.Add(this.TxTTotalQ);
            this.GroupBox16.Dock = DockStyle.Right;
            this.GroupBox16.Location = new Point(820, 0);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(160, 0x36);
            this.GroupBox16.TabIndex = 7;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "مجموع الكمية";
            this.TxTTotalQ.Dock = DockStyle.Fill;
            this.TxTTotalQ.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalQ.Location = new Point(3, 0x13);
            this.TxTTotalQ.Name = "TxTTotalQ";
            this.TxTTotalQ.Size = new Size(0x9a, 0x20);
            this.TxTTotalQ.TabIndex = 0;
            this.TxTTotalQ.Text = "0";
            this.TxTTotalQ.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[9];
            toolStripItems[0] = this.ToolStripButtonViewAll;
            toolStripItems[1] = this.ToolStripSeparator2;
            toolStripItems[2] = this.ToolStripButtonPrint;
            toolStripItems[3] = this.ToolStripSeparator4;
            toolStripItems[4] = this.ToolStripButtonApply;
            toolStripItems[5] = this.ToolStripSeparator7;
            toolStripItems[6] = this.ToolStripButtonOK;
            toolStripItems[7] = this.ToolStripSeparator3;
            toolStripItems[8] = this.ToolStripButtonClose;
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x24d);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36d5;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x60, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة A4";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x2f);
            this.ToolStripButtonApply.Image = A.F.ImOK;
            this.ToolStripButtonApply.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonApply.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonApply.Name = "ToolStripButtonApply";
            this.ToolStripButtonApply.Size = new Size(0x1d7, 0x2c);
            this.ToolStripButtonApply.Text = "تطبيق بيانات المادة المحددة (الكمية، السعر) على المادة الحالية في المستودع";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(6, 0x2f);
            this.ToolStripButtonOK.Image = A.F.ImOK;
            this.ToolStripButtonOK.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonOK.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonOK.Name = "ToolStripButtonOK";
            this.ToolStripButtonOK.Size = new Size(0xb3, 0x2c);
            this.ToolStripButtonOK.Text = "موافق للمرتجع غير مفعل";
            this.ToolStripButtonOK.Visible = false;
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x2f);
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
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray2);
            this.ToolStripStatus.Location = new Point(0, 0x27c);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x1ed36d4;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x3f, 0x16);
            this.ToolStripLabel1.Text = "عدد المواد";
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
            this.GV.Location = new Point(0, 0xb7);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3d8, 0x15c);
            this.GV.TabIndex = 0x1ed36d7;
            this.CheckBoxDate.AutoSize = true;
            this.CheckBoxDate.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxDate.Checked = true;
            this.CheckBoxDate.CheckState = CheckState.Checked;
            this.CheckBoxDate.Dock = DockStyle.Top;
            this.CheckBoxDate.Location = new Point(0, 0x9b);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Padding = new Padding(4);
            this.CheckBoxDate.Size = new Size(0x3d8, 0x1c);
            this.CheckBoxDate.TabIndex = 0x1ed36d8;
            this.CheckBoxDate.Text = "تضمين فترة التاريخ دائماً مع كل عمليات الفرز";
            this.CheckBoxDate.UseVisualStyleBackColor = false;
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x1f7, 6);
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
            this.GroupBox2.Location = new Point(0x133, 8);
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
            base.Controls.Add(this.CheckBoxDate);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "InvoicePurchItems";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "سجل المشتريات/مرتجع المشتريات حسب المادة";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.GroupBoxUsers.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
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
                this.ButtonSorCode.PerformClick();
            }
        }

        private void D(object A, EventArgs R)
        {
            P = KD.R;
            if (this.CheckBoxDate.Checked)
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                P = KD.R + " AND (TaNNInvPurchItems.InvPurchPurchDate BETWEEN @DF and @DT)";
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
        }

        private void F(object A, EventArgs R)
        {
            P = KD.R;
            this.TimerLoadData.Enabled = true;
        }

        private void G(object A, EventArgs R)
        {
        }

        private void H(object A, EventArgs R)
        {
            if (AR.LR && (Strings.Len(this.TxTMaterialBarCode.Text) > 0x10))
            {
                this.TxTMaterialBarCode.Text = Strings.Left(this.TxTMaterialBarCode.Text, 15);
            }
            P = KD.R;
            if (!this.CheckBoxDate.Checked)
            {
                P = KD.R + " AND (TaNNInvPurchItems.PurchMaterialBarCode = @PurchMaterialBarCode)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                P = KD.R + " AND (TaNNInvPurchItems.InvPurchPurchDate BETWEEN @DF and @DT) AND (TaNNInvPurchItems.PurchMaterialBarCode = @PurchMaterialBarCode)";
            }
            this.TimerLoadData.Enabled = true;
        }

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            Q = null;
            I = null;
            base.Dispose();
        }

        private void K(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل تريد تطبيق واعتماد مدخلات المادة المحددة (الاسعار، الكمية، تاريخ الانتهاء، ... الخ) على المادة الموجودة في المستودع", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
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
                        int num = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["MaterialPurchID"].Value.ToString());
                        TextBox box = new TextBox();
                        TextBox box2 = new TextBox();
                        TextBox box3 = new TextBox();
                        TextBox box4 = new TextBox();
                        TextBox box5 = new TextBox();
                        TextBox box6 = new TextBox();
                        CheckBox box7 = new CheckBox();
                        TextBox box8 = new TextBox();
                        TextBox box9 = new TextBox();
                        TextBox box10 = new TextBox();
                        TextBox box11 = new TextBox();
                        TextBox box12 = new TextBox();
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        DataTable dataTable = new DataTable();
                        string selectCommandText = "SELECT * FROM [TaNNInvPurchItems] WHERE ([MaterialPurchID] = @MaterialPurchID)";
                        dataTable.Clear();
                        SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                        adapter.SelectCommand.Parameters.AddWithValue("MaterialPurchID", num);
                        adapter.Fill(dataTable);
                        this.A.Close();
                        if (dataTable.Rows.Count > 0)
                        {
                            box.Text = dataTable.Rows[0]["InvPurchType"].ToString();
                            box2.Text = dataTable.Rows[0]["PurchMaterialBarCode"].ToString();
                            box3.Text = dataTable.Rows[0]["PurchMaterialQuantity"].ToString();
                            box4.Text = dataTable.Rows[0]["PurchMaterialPricCost"].ToString();
                            box5.Text = dataTable.Rows[0]["PurchMaterialSalePrice"].ToString();
                            box6.Text = dataTable.Rows[0]["PurchMaterialExpDate"].ToString();
                            box7.Checked = Conversions.ToBoolean(dataTable.Rows[0]["PurchIsApplyStor"].ToString());
                        }
                        if (box7.Checked)
                        {
                            Interaction.MsgBox("لقد تم اعتماد بيانات المادة المحددة مسبقاً، لا يمكن اعادة تطبيقها", MsgBoxStyle.ApplicationModal, null);
                        }
                        else
                        {
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            DataTable table2 = new DataTable();
                            string str2 = "SELECT * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) AND ([MaterialBarCode] = @MaterialBarCode)";
                            table2.Clear();
                            SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                            adapter2.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                            adapter2.SelectCommand.Parameters.AddWithValue("MaterialBarCode", box2.Text);
                            adapter2.Fill(table2);
                            this.A.Close();
                            if (table2.Rows.Count <= 0)
                            {
                                Interaction.MsgBox("لم يتم العثور على المادة في المستودع", MsgBoxStyle.ApplicationModal, null);
                            }
                            else
                            {
                                DateTime time;
                                box8.Text = table2.Rows[0]["MaterialID"].ToString();
                                box9.Text = table2.Rows[0]["MaterialQuantity"].ToString();
                                box10.Text = table2.Rows[0]["MaterialPricCost"].ToString();
                                box11.Text = table2.Rows[0]["MaterialPricSale"].ToString();
                                box12.Text = table2.Rows[0]["MaterialExpDate"].ToString();
                                decimal num2 = new decimal(Conversion.Val(box9.Text.ToString().Replace(",", "")) + Conversion.Val(box3.Text.ToString().Replace(",", "")));
                                decimal num3 = 0M;
                                decimal num4 = 0M;
                                CheckBox box13 = new CheckBox();
                                if (Conversion.Val(box.Text) == 0.0)
                                {
                                    num3 = new decimal(Conversion.Val(box4.Text.ToString().Replace(",", "")));
                                    num4 = new decimal(Conversion.Val(box5.Text.ToString().Replace(",", "")));
                                    if (box6.Text == null)
                                    {
                                        box13.Checked = false;
                                    }
                                    else
                                    {
                                        box13.Checked = true;
                                        time = Conversions.ToDate(box6.Text);
                                    }
                                }
                                else if (Conversion.Val(box.Text) == 1.0)
                                {
                                    num3 = new decimal(Conversion.Val(box10.Text.ToString().Replace(",", "")));
                                    num4 = new decimal(Conversion.Val(box11.Text.ToString().Replace(",", "")));
                                    if (box12.Text == null)
                                    {
                                        box13.Checked = false;
                                    }
                                    else
                                    {
                                        box13.Checked = true;
                                        time = Conversions.ToDate(box12.Text);
                                    }
                                }
                                if (this.A.State == ConnectionState.Closed)
                                {
                                    this.A.Open();
                                }
                                SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity, [MaterialPricCost] = @MaterialPricCost, [MaterialPricLess] = @MaterialPricLess, [MaterialPricSale] = @MaterialPricSale, [MaterialExpDate] = @MaterialExpDate WHERE [MaterialID] = @MaterialID", this.A);
                                command.Parameters.AddWithValue("MaterialID", box8.Text);
                                command.Parameters.AddWithValue("MaterialQuantity", num2.ToString(PR.OR));
                                command.Parameters.AddWithValue("MaterialPricCost", num3.ToString(PR.VR));
                                command.Parameters.AddWithValue("MaterialPricSale", num4.ToString(PR.VR));
                                command.Parameters.AddWithValue("MaterialPricLess", 0.ToString(PR.VR));
                                if (!box13.Checked)
                                {
                                    command.Parameters.AddWithValue("MaterialExpDate", DBNull.Value);
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("MaterialExpDate", time.ToString("yyyy/MM/dd"));
                                }
                                command.ExecuteNonQuery();
                                this.A.Close();
                                if (this.A.State == ConnectionState.Closed)
                                {
                                    this.A.Open();
                                }
                                SqlCommand command2 = new SqlCommand("UPDATE [TaNNInvPurchItems] SET [PurchIsApplyStor] = @PurchIsApplyStor WHERE [MaterialPurchID] = @MaterialPurchID", this.A);
                                command2.Parameters.AddWithValue("MaterialPurchID", num);
                                command2.Parameters.AddWithValue("PurchIsApplyStor", true);
                                command2.ExecuteNonQuery();
                                this.A.Close();
                                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                                this.TimerLoadData.Enabled = true;
                            }
                        }
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

        private void L(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                AI ai = new AI();
                ai.SetDataSource(this.A);
                ai.SetParameterValue("CenterName", PR.ER.ToString());
                ai.SetParameterValue("CenterSubName", PR.KR.ToString());
                ai.SetParameterValue("ParameterDeimelQ", PR.X);
                ai.SetParameterValue("ParameterDeimelS", PR.T);
                ai.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                ai.SetParameterValue("RPTitle", this.TxTTitle.Text);
                if (PR.NR == null)
                {
                    ai.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    ai.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                }
                if (PR.UR == null)
                {
                    ai.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    ai.SetParameterValue("CenterPhone", PR.UR.ToString());
                }
                ai.SetParameterValue("XQ", this.TxTTotalQ.Text);
                ai.SetParameterValue("XS", this.TxTTotalS.Text);
                new HR { CRViewer = { ReportSource = ai } }.ShowDialog();
                ai.Close();
                ai.Dispose();
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

        private void N(object A, EventArgs R)
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

        private void P(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            if (P == null)
            {
                P = KD.R;
            }
            this.TimerFillGV.Enabled = true;
        }

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.Q();
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
            this.TimerLoadData.Enabled = true;
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonSorName.PerformClick();
            }
        }

        private void T(object A, EventArgs R)
        {
            P = KD.R;
            if (!this.CheckBoxDate.Checked)
            {
                P = KD.R + " AND (TaNNInvPurchItems.PurchMaterialName LIKE '%' + @PurchMaterialName + '%')";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                P = KD.R + " AND (TaNNInvPurchItems.InvPurchPurchDate BETWEEN @DF and @DT) AND (TaNNInvPurchItems.PurchMaterialName LIKE '%' + @PurchMaterialName + '%')";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void U(object A, EventArgs R)
        {
            P = KD.R;
            if (!this.CheckBoxDate.Checked)
            {
                P = KD.R + " AND (TaNNInvPurchItems.PurchUserAddBy = @PurchUserAddBy)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                P = KD.R + " AND (TaNNInvPurchItems.InvPurchPurchDate BETWEEN @DF and @DT) AND (TaNNInvPurchItems.PurchUserAddBy = @PurchUserAddBy)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void X(object A, EventArgs R)
        {
            P = KD.R;
            if (!this.CheckBoxDate.Checked)
            {
                P = KD.R + " AND (TaNNInvPurchItems.SuplierFrontID = @SuplierFrontID)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                P = KD.R + " AND (TaNNInvPurchItems.InvPurchPurchDate BETWEEN @DF and @DT) AND (TaNNInvPurchItems.SuplierFrontID = @SuplierFrontID)";
            }
            this.TimerLoadData.Enabled = true;
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

        internal virtual Button ButtonSorCode
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTMaterialBarCode
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
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

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual GroupBox GroupBoxUsers
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

        internal virtual Button ButtonSorName
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox TxTMaterialName
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
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

        internal virtual Panel Panel1
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

        internal virtual ToolStripSeparator ToolStripSeparator2
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
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual CheckBox CheckBoxDate
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual Timer TimerLoadData
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

        internal virtual Timer TimersStartUp
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual ToolStripButton ToolStripButtonApply
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label TxTTotalS
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label TxTTotalQ
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripButton ToolStripButtonOK
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripButton ToolStripButtonPrint
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
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

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonAdVSort
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
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

