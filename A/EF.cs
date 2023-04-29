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
    public class EF : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage1")]
        private TabPage A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TrDsType")]
        private ComboBox A;
        [CompilerGenerated, AccessedThroughProperty("ButtonSortDate"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage8"), CompilerGenerated]
        private TabPage R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonMaterialBarcode")]
        private Button R;
        [AccessedThroughProperty("GroupBox15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [CompilerGenerated, AccessedThroughProperty("TxTMaterialBarcode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("TabPage9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonMaterialName")]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox8")]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTMaterialName"), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("TabPage4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage Q;
        [AccessedThroughProperty("ButtonUser"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBoxUsers")]
        private GroupBox Q;
        [CompilerGenerated, AccessedThroughProperty("ComboBoxUser"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage5"), CompilerGenerated]
        private TabPage I;
        [CompilerGenerated, AccessedThroughProperty("ButtonNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox3")]
        private GroupBox I;
        [AccessedThroughProperty("TxTNoSe"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [AccessedThroughProperty("CheckBoxDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("Panel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox11"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTotalPrice"), CompilerGenerated]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox10"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [AccessedThroughProperty("TxTTotalQu"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripButtons")]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonViewAll"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [AccessedThroughProperty("ToolStripButtonPrint"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton R;
        [AccessedThroughProperty("ToolStripSeparator6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator7"), CompilerGenerated]
        private ToolStripSeparator P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripStatus"), CompilerGenerated]
        private ToolStrip R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripLabel1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTGVRowCount")]
        private ToolStripLabel R;
        [AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonDelete"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton Q;
        [AccessedThroughProperty("ToolStripSeparator2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator I;
        [CompilerGenerated, AccessedThroughProperty("TimerLoadData"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [CompilerGenerated, AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1"), CompilerGenerated]
        private GroupBox H;
        [AccessedThroughProperty("DateTimePickerFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("DateTimePickerTo")]
        private DateTimePicker P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PickerTimeTo"), CompilerGenerated]
        private DateTimePicker Q;
        private SqlConnection A;
        private int A;
        private DataTable A;
        private DataTable R;
        private string A;
        private int R;
        public static string R;
        public static string P;

        public EF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = 0;
            this.A = new DataTable();
            this.R = new DataTable();
            this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsDateTime BETWEEN @DF and @DT)";
            this.R = 0;
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
            this.TrDsType = new ComboBox();
            this.ButtonSortDate = new Button();
            this.TabPage8 = new TabPage();
            this.ButtonMaterialBarcode = new Button();
            this.GroupBox15 = new GroupBox();
            this.TxTMaterialBarcode = new TextBox();
            this.TabPage9 = new TabPage();
            this.ButtonMaterialName = new Button();
            this.GroupBox8 = new GroupBox();
            this.TxTMaterialName = new TextBox();
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
            this.GroupBox11 = new GroupBox();
            this.TxTTotalPrice = new Label();
            this.GroupBox10 = new GroupBox();
            this.TxTTotalQu = new Label();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
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
            this.TabPage8.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.TabPage9.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBoxUsers.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
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
            this.TxTTitle.TabIndex = 0x6f;
            this.TxTTitle.Text = "سجل الاتلاف و ترحيل الكميات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage8);
            this.TabControl1.Controls.Add(this.TabPage9);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 0x7b);
            this.TabControl1.TabIndex = 0x70;
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
            this.GroupBox9.Controls.Add(this.TrDsType);
            this.GroupBox9.Location = new Point(0x2ad, 0x18);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x11b, 0x35);
            this.GroupBox9.TabIndex = 0x1ed36cc;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "نوع الحركة";
            this.TrDsType.Dock = DockStyle.Fill;
            this.TrDsType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.TrDsType.FormattingEnabled = true;
            object[] items = new object[] { "حركات الترحيل", "حركات الاتلاف", "الكل" };
            this.TrDsType.Items.AddRange(items);
            this.TrDsType.Location = new Point(3, 0x13);
            this.TrDsType.Name = "TrDsType";
            this.TrDsType.Size = new Size(0x115, 0x18);
            this.TrDsType.TabIndex = 0x2c;
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
            this.ButtonSortDate.Size = new Size(280, 0x2c);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.TabPage8.Controls.Add(this.ButtonMaterialBarcode);
            this.TabPage8.Controls.Add(this.GroupBox15);
            this.TabPage8.Location = new Point(4, 0x19);
            this.TabPage8.Name = "TabPage8";
            this.TabPage8.Size = new Size(0x3d0, 0x48);
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
            this.TabPage9.Size = new Size(0x3d0, 0x48);
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
            this.ButtonUser.Location = new Point(0x15c, 14);
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
            this.CheckBoxDate.Location = new Point(0, 0x9d);
            this.CheckBoxDate.Name = "CheckBoxDate";
            this.CheckBoxDate.Padding = new Padding(4);
            this.CheckBoxDate.Size = new Size(0x3d8, 0x1c);
            this.CheckBoxDate.TabIndex = 0x1ed36cd;
            this.CheckBoxDate.Text = "تضمين فترة التاريخ دائماً مع كل عمليات الفرز";
            this.CheckBoxDate.UseVisualStyleBackColor = false;
            this.Panel1.BackColor = SystemColors.HighlightText;
            this.Panel1.BorderStyle = BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox11);
            this.Panel1.Controls.Add(this.GroupBox10);
            this.Panel1.Dock = DockStyle.Bottom;
            this.Panel1.Location = new Point(0, 0x1c5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x3d8, 0x3a);
            this.Panel1.TabIndex = 0x1ed36d2;
            this.GroupBox11.Controls.Add(this.TxTTotalPrice);
            this.GroupBox11.Dock = DockStyle.Right;
            this.GroupBox11.Location = new Point(0x26e, 0);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0xb3, 0x36);
            this.GroupBox11.TabIndex = 1;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "مجموع سعر التكلفة";
            this.TxTTotalPrice.Dock = DockStyle.Fill;
            this.TxTTotalPrice.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalPrice.Location = new Point(3, 0x13);
            this.TxTTotalPrice.Name = "TxTTotalPrice";
            this.TxTTotalPrice.Size = new Size(0xad, 0x20);
            this.TxTTotalPrice.TabIndex = 0;
            this.TxTTotalPrice.Text = "0";
            this.TxTTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox10.Controls.Add(this.TxTTotalQu);
            this.GroupBox10.Dock = DockStyle.Right;
            this.GroupBox10.Location = new Point(0x321, 0);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0xb3, 0x36);
            this.GroupBox10.TabIndex = 0;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "مجموع الكمية";
            this.TxTTotalQu.Dock = DockStyle.Fill;
            this.TxTTotalQu.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalQu.Location = new Point(3, 0x13);
            this.TxTTotalQu.Name = "TxTTotalQu";
            this.TxTTotalQu.Size = new Size(0xad, 0x20);
            this.TxTTotalQu.TabIndex = 0;
            this.TxTTotalQu.Text = "0";
            this.TxTTotalQu.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonViewAll, this.ToolStripSeparator8, this.ToolStripButtonDelete, this.ToolStripSeparator2, this.ToolStripButtonPrint, this.ToolStripSeparator6, this.ToolStripButtonClose, this.ToolStripSeparator7 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x1ff);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36d1;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(6, 0x2f);
            this.ToolStripButtonDelete.Image = A.F.ImDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(0x9c, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف الحركة المحددة";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
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
            this.ToolStripStatus.Location = new Point(0, 0x22e);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x1ed36d0;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x4b, 0x16);
            this.ToolStripLabel1.Text = "عدد الحركات";
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
            this.GV.Size = new Size(0x3d8, 0x10c);
            this.GV.TabIndex = 0x1ed36d3;
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x1f2, 10);
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
            this.GroupBox2.Location = new Point(0x12e, 12);
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
            base.ClientSize = new Size(0x3d8, 0x247);
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
            base.Name = "MaterialTransferDestroyList";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "سجل الاتلاف و ترحيل الكميات";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.TabPage8.ResumeLayout(false);
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox15.PerformLayout();
            this.TabPage9.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.GroupBoxUsers.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
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

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonMaterialBarcode.PerformClick();
            }
        }

        private void D(object A, EventArgs R)
        {
            if (!this.CheckBoxDate.Checked)
            {
                this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsBarCode = @TrDsBarCode)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsDateTime BETWEEN @DF and @DT) AND (TrDsBarCode = @TrDsBarCode)";
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
            if (!this.CheckBoxDate.Checked)
            {
                this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND ([TrDsNote] LIKE '%' + @TrDsNote + '%')";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsDateTime BETWEEN @DF and @DT) AND ([TrDsNote] LIKE '%' + @TrDsNote + '%')";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void G(object A, EventArgs R)
        {
        }

        private void H(object A, EventArgs R)
        {
            if (!this.CheckBoxDate.Checked)
            {
                this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND ([TrDsName] LIKE '%' + @TrDsName + '%')";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsDateTime BETWEEN @DF and @DT) AND ([TrDsName] LIKE '%' + @TrDsName + '%')";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void I(object A, EventArgs R)
        {
            if (!this.CheckBoxDate.Checked)
            {
                if (this.TrDsType.SelectedIndex == 0)
                {
                    this.R = 0;
                    this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsType = @TrDsType)";
                }
                else if (this.TrDsType.SelectedIndex == 1)
                {
                    this.R = 1;
                    this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsType = @TrDsType)";
                }
                else if (this.TrDsType.SelectedIndex == 2)
                {
                    this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID)";
                }
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                if (this.TrDsType.SelectedIndex == 0)
                {
                    this.R = 0;
                    this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsDateTime BETWEEN @DF and @DT) AND (TrDsType = @TrDsType)";
                }
                else if (this.TrDsType.SelectedIndex == 1)
                {
                    this.R = 1;
                    this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsDateTime BETWEEN @DF and @DT) AND (TrDsType = @TrDsType)";
                }
                else if (this.TrDsType.SelectedIndex == 2)
                {
                    this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsDateTime BETWEEN @DF and @DT)";
                }
            }
            this.TimerLoadData.Enabled = true;
        }

        private void K(object A, EventArgs R)
        {
        }

        private void L(object A, EventArgs R)
        {
            this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID)";
            this.TimerLoadData.Enabled = true;
        }

        private void N(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                GI gi = new GI();
                gi.SetDataSource(this.A);
                gi.SetParameterValue("CenterName", PR.ER.ToString());
                gi.SetParameterValue("CenterSubName", PR.KR.ToString());
                gi.SetParameterValue("ParameterDeimelQ", PR.X);
                gi.SetParameterValue("ParameterDeimelS", PR.T);
                gi.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (PR.NR == null)
                {
                    gi.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    gi.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                }
                if (PR.UR == null)
                {
                    gi.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    gi.SetParameterValue("CenterPhone", PR.UR.ToString());
                }
                gi.SetParameterValue("XQ", this.TxTTotalQu.Text);
                gi.SetParameterValue("XS", this.TxTTotalPrice.Text);
                new HR { CRViewer = { ReportSource = gi } }.ShowDialog();
                gi.Close();
                gi.Dispose();
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

        public void P()
        {
            try
            {
                IEnumerator enumerator;
                IEnumerator enumerator2;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                this.R.Clear();
                this.A.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.SelectCommand.Parameters.AddWithValue("TrDsType", this.R);
                string text1 = this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd 00:00");
                adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
                string text2 = this.DateTimePickerTo.Value.ToString("yyyy/MM/dd 23:59");
                adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
                string text = this.ComboBoxUser.Text;
                adapter.SelectCommand.Parameters.AddWithValue("TrDsUserAddBy", text ?? DBNull.Value);
                string text4 = this.TxTNoSe.Text;
                adapter.SelectCommand.Parameters.AddWithValue("TrDsNote", text4 ?? DBNull.Value);
                string text5 = this.TxTMaterialBarcode.Text;
                adapter.SelectCommand.Parameters.AddWithValue("TrDsBarCode", text5 ?? DBNull.Value);
                string text6 = this.TxTMaterialName.Text;
                adapter.SelectCommand.Parameters.AddWithValue("TrDsName", text6 ?? DBNull.Value);
                adapter.Fill(this.R);
                adapter.Fill(this.A);
                this.A.Close();
                decimal left = 0M;
                decimal num2 = 0M;
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
                        object[] arguments = new object[] { "TrDsQuantity" };
                        left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                        object[] objArray2 = new object[] { "TrDsPriceTotal" };
                        num2 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num2, NewLateBinding.LateIndexGet(current, objArray2, null)));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                this.TxTTotalPrice.Text = num2.ToString(PR.YR);
                this.TxTTotalQu.Text = left.ToString(PR.BR);
                this.GV.DataSource = this.R;
                this.GV.Refresh();
                this.GV.Columns["TrDsID"].Visible = false;
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["TrDsType"].HeaderText = "نوع الحركة";
                this.GV.Columns["TrDsDateTime"].HeaderText = "تاريخ/ وقت";
                this.GV.Columns["TrDsBarCode"].HeaderText = "باركود/رقم";
                this.GV.Columns["TrDsName"].HeaderText = "المادة/ الوصف";
                this.GV.Columns["TrDsUnit"].HeaderText = "الوحدة";
                this.GV.Columns["TrDsPrice"].HeaderText = "سعر الكلفة";
                this.GV.Columns["TrDsQuantity"].HeaderText = "الكمية";
                this.GV.Columns["TrDsPriceTotal"].HeaderText = "المجموع";
                this.GV.Columns["TrDsNote"].HeaderText = "ملاحظات";
                this.GV.Columns["TrDsUserAddBy"].HeaderText = "الموظف";
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                        decimal num3 = new decimal(Conversion.Val(current.Cells["TrDsPrice"].Value.ToString()));
                        decimal num4 = new decimal(Conversion.Val(current.Cells["TrDsQuantity"].Value.ToString()));
                        decimal num5 = new decimal(Conversion.Val(current.Cells["TrDsPriceTotal"].Value.ToString()));
                        current.Cells["TrDsPrice"].Value = num3.ToString(PR.YR);
                        current.Cells["TrDsQuantity"].Value = num4.ToString(PR.BR);
                        current.Cells["TrDsPriceTotal"].Value = num5.ToString(PR.YR);
                        decimal num6 = new decimal(Conversion.Val(current.Cells["TrDsType"].Value.ToString()));
                        if (decimal.Compare(num6, decimal.Zero) == 0)
                        {
                            current.Cells["TrDsType"].Value = "ترحيل";
                            continue;
                        }
                        if (decimal.Compare(num6, decimal.One) == 0)
                        {
                            current.Cells["TrDsType"].Value = "اتلاف";
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
                this.Q();
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

        private void P(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonNote.PerformClick();
            }
        }

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.P();
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
            this.TimerLoadData.Enabled = true;
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonMaterialName.PerformClick();
            }
        }

        private void T(object A, EventArgs R)
        {
            if (!this.CheckBoxDate.Checked)
            {
                this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsUserAddBy = @TrDsUserAddBy)";
            }
            else
            {
                this.CheckBoxDate.ForeColor = Color.Red;
                this.A = "SELECT * FROM TaNNMaterialTrDs WHERE (CenterFrontID = @CenterFrontID) AND (TrDsDateTime BETWEEN @DF and @DT) AND (TrDsUserAddBy = @TrDsUserAddBy)";
            }
            this.TimerLoadData.Enabled = true;
        }

        private void U(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (Information.IsNothing(this.GV.CurrentRow))
                    {
                        Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                    }
                    else
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        this.A = this.GV.CurrentRow.Index;
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNMaterialTrDs WHERE (TrDsID = @TrDsID)", this.A);
                        command.Parameters.AddWithValue("TrDsID", this.GV.SelectedRows[0].Cells["TrDsID"].Value.ToString());
                        command.ExecuteNonQuery();
                        this.A.Close();
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
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

        private void V(object A, EventArgs R)
        {
            A.D.A.A.Show();
            A.D.A.A.Show();
        }

        private void X(object A, EventArgs R)
        {
            EF.R = null;
            P = null;
            base.Dispose();
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

        internal virtual ComboBox TrDsType
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
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual TabPage TabPage8
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonMaterialBarcode
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

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTMaterialBarcode
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

        internal virtual TabPage TabPage9
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonMaterialName
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

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
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

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label TxTTotalPrice
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label TxTTotalQu
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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
                EventHandler handler = new EventHandler(this.L);
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ToolStripButtonDelete
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual ToolStripSeparator ToolStripSeparator2
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

