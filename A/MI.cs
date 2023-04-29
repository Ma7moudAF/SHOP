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
    public class MI : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtons"), CompilerGenerated]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonDelete")]
        private ToolStripButton R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator P;
        [AccessedThroughProperty("ToolStripSeparator5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator6")]
        private ToolStripSeparator I;
        [AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripStatus")]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripProgressBar A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripLabel1")]
        private ToolStripLabel A;
        [CompilerGenerated, AccessedThroughProperty("TxTGVRowCount"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [AccessedThroughProperty("ToolStripSeparator1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerLoadData")]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [CompilerGenerated, AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxAllCenter")]
        private CheckBox A;
        [AccessedThroughProperty("ComboBoxSerachWat"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTSerach")]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSearchCodeName"), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage R;
        [AccessedThroughProperty("DateTimePickerTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ComboBoxWat")]
        private ComboBox R;
        [AccessedThroughProperty("DateTimePickerFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker R;
        [AccessedThroughProperty("ButtonSortDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage3"), CompilerGenerated]
        private TabPage P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtoSCredit")]
        private Button P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2")]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3")]
        private GroupBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1")]
        private GroupBox P;
        [CompilerGenerated, AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtoSDebit")]
        private Button Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSZero")]
        private Button I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox5")]
        private GroupBox I;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonViewAll"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator8")]
        private ToolStripSeparator H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Panel1")]
        private Panel A;
        [AccessedThroughProperty("TimerFillGV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GV")]
        private DataGridView A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripButtonPrint")]
        private ToolStripDropDownButton A;
        [CompilerGenerated, AccessedThroughProperty("A4ToolStripMenuItemPrintList"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTCredit")]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTDebit")]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripDropDownButtonEmail"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator9")]
        private ToolStripSeparator T;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripMenuItemEmailList")]
        private ToolStripMenuItem R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator10"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator X;
        [AccessedThroughProperty("ToolStripMenuItemEmailOne"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripMenuItemEmilChek")]
        private ToolStripMenuItem Q;
        [AccessedThroughProperty("ToolStripSeparator11"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator12")]
        private ToolStripSeparator E;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStrWatssApp")]
        private ToolStripDropDownButton P;
        [AccessedThroughProperty("ButWatsBalance"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator13")]
        private ToolStripSeparator K;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButWatsNormal"), CompilerGenerated]
        private ToolStripMenuItem D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonEdit")]
        private ToolStripDropDownButton Q;
        [CompilerGenerated, AccessedThroughProperty("EdMulti"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator14")]
        private ToolStripSeparator U;
        [AccessedThroughProperty("EdSelect"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxSAll"), CompilerGenerated]
        private CheckBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripButtonCard")]
        private ToolStripDropDownButton I;
        [AccessedThroughProperty("ButCusDetials"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem T;
        [AccessedThroughProperty("ToolStripSeparator15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator L;
        [CompilerGenerated, AccessedThroughProperty("ButCusStatment"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem X;
        private SqlConnection A;
        private DataTable A;
        private string A;
        private int A;
        private string R;

        public MI()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A = 0;
            this.R = "";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(MI));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox5 = new GroupBox();
            this.TxTSerach = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.ComboBoxSerachWat = new ComboBox();
            this.ButtonSearchCodeName = new Button();
            this.TabPage2 = new TabPage();
            this.GroupBox2 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.GroupBox3 = new GroupBox();
            this.ComboBoxWat = new ComboBox();
            this.GroupBox1 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.ButtonSortDate = new Button();
            this.TabPage3 = new TabPage();
            this.ButtonSZero = new Button();
            this.ButtoSDebit = new Button();
            this.ButtoSCredit = new Button();
            this.TxTTitle = new Label();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripButtonEdit = new ToolStripDropDownButton();
            this.EdMulti = new ToolStripMenuItem();
            this.ToolStripSeparator14 = new ToolStripSeparator();
            this.EdSelect = new ToolStripMenuItem();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ToolStripButtonCard = new ToolStripDropDownButton();
            this.ButCusDetials = new ToolStripMenuItem();
            this.ToolStripSeparator15 = new ToolStripSeparator();
            this.ButCusStatment = new ToolStripMenuItem();
            this.ToolStripSeparator12 = new ToolStripSeparator();
            this.ToolStrWatssApp = new ToolStripDropDownButton();
            this.ButWatsBalance = new ToolStripMenuItem();
            this.ToolStripSeparator13 = new ToolStripSeparator();
            this.ButWatsNormal = new ToolStripMenuItem();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ToolStripDropDownButtonEmail = new ToolStripDropDownButton();
            this.ToolStripMenuItemEmilChek = new ToolStripMenuItem();
            this.ToolStripSeparator11 = new ToolStripSeparator();
            this.ToolStripMenuItemEmailList = new ToolStripMenuItem();
            this.ToolStripSeparator10 = new ToolStripSeparator();
            this.ToolStripMenuItemEmailOne = new ToolStripMenuItem();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.A4ToolStripMenuItemPrintList = new ToolStripMenuItem();
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
            this.CheckBoxAllCenter = new CheckBox();
            this.Panel1 = new Panel();
            this.GroupBox9 = new GroupBox();
            this.TxTCredit = new Label();
            this.GroupBox8 = new GroupBox();
            this.TxTDebit = new Label();
            this.CheckBoxSAll = new CheckBox();
            this.TimerFillGV = new Timer(this.A);
            this.GV = new DataGridView();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 0x6f);
            this.TabControl1.TabIndex = 0x63;
            this.TabPage1.Controls.Add(this.GroupBox5);
            this.TabPage1.Controls.Add(this.GroupBox4);
            this.TabPage1.Controls.Add(this.ButtonSearchCodeName);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3d0, 0x52);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "بحث";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox5.Controls.Add(this.TxTSerach);
            this.GroupBox5.Location = new Point(0x13e, 13);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x120, 0x35);
            this.GroupBox5.TabIndex = 0x6b;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "نص البحث";
            this.TxTSerach.Dock = DockStyle.Fill;
            this.TxTSerach.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTSerach.Location = new Point(3, 0x13);
            this.TxTSerach.Name = "TxTSerach";
            this.TxTSerach.Size = new Size(0x11a, 0x17);
            this.TxTSerach.TabIndex = 15;
            this.GroupBox4.Controls.Add(this.ComboBoxSerachWat);
            this.GroupBox4.Location = new Point(0x296, 13);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x12e, 0x35);
            this.GroupBox4.TabIndex = 0x6b;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "البحث في";
            this.ComboBoxSerachWat.Dock = DockStyle.Fill;
            this.ComboBoxSerachWat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxSerachWat.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxSerachWat.FormattingEnabled = true;
            object[] items = new object[] { "اسم العميل", "عنوان العميل", "رقم الهاتف", "ملاحظات" };
            this.ComboBoxSerachWat.Items.AddRange(items);
            this.ComboBoxSerachWat.Location = new Point(3, 0x13);
            this.ComboBoxSerachWat.Name = "ComboBoxSerachWat";
            this.ComboBoxSerachWat.Size = new Size(0x128, 0x18);
            this.ComboBoxSerachWat.TabIndex = 0x10;
            this.ButtonSearchCodeName.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSearchCodeName.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSearchCodeName.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSearchCodeName.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSearchCodeName.FlatStyle = FlatStyle.Flat;
            this.ButtonSearchCodeName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSearchCodeName.Image = A.F.ImSearch;
            this.ButtonSearchCodeName.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSearchCodeName.Location = new Point(0x9c, 0x15);
            this.ButtonSearchCodeName.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSearchCodeName.Name = "ButtonSearchCodeName";
            this.ButtonSearchCodeName.Size = new Size(0x8f, 0x2c);
            this.ButtonSearchCodeName.TabIndex = 14;
            this.ButtonSearchCodeName.Text = "بحث";
            this.ButtonSearchCodeName.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.GroupBox2);
            this.TabPage2.Controls.Add(this.GroupBox3);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Controls.Add(this.ButtonSortDate);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x3d0, 0x52);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "فرز حسب تاريخ اخر اجراء";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.DateTimePickerTo);
            this.GroupBox2.Location = new Point(0x103, 13);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xb0, 0x34);
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
            this.GroupBox3.Controls.Add(this.ComboBoxWat);
            this.GroupBox3.Location = new Point(0x26e, 13);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x148, 0x34);
            this.GroupBox3.TabIndex = 90;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "فرز العملاء الذين";
            this.ComboBoxWat.Dock = DockStyle.Fill;
            this.ComboBoxWat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxWat.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxWat.FormattingEnabled = true;
            object[] objArray2 = new object[] { "تم اجراء حركات عليهم", "لم يتم اجراء حركات عليهم" };
            this.ComboBoxWat.Items.AddRange(objArray2);
            this.ComboBoxWat.Location = new Point(3, 0x13);
            this.ComboBoxWat.Name = "ComboBoxWat";
            this.ComboBoxWat.Size = new Size(0x142, 0x18);
            this.ComboBoxWat.TabIndex = 0x43;
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Location = new Point(0x1ba, 13);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb0, 0x34);
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
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(0x7f, 0x15);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(0x6f, 0x2c);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.TabPage3.Controls.Add(this.ButtonSZero);
            this.TabPage3.Controls.Add(this.ButtoSDebit);
            this.TabPage3.Controls.Add(this.ButtoSCredit);
            this.TabPage3.Location = new Point(4, 0x19);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x3d0, 0x52);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "فرز حسب الرصيد";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.ButtonSZero.BackColor = Color.White;
            this.ButtonSZero.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSZero.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSZero.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSZero.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSZero.FlatStyle = FlatStyle.Flat;
            this.ButtonSZero.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSZero.Image = A.F.ImSort;
            this.ButtonSZero.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSZero.Location = new Point(0x3b, 15);
            this.ButtonSZero.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSZero.Name = "ButtonSZero";
            this.ButtonSZero.Size = new Size(0x114, 0x2c);
            this.ButtonSZero.TabIndex = 0x42;
            this.ButtonSZero.Text = "فرز العملاء الذين لديهم رصيد صفر";
            this.ButtonSZero.UseVisualStyleBackColor = false;
            this.ButtoSDebit.BackColor = Color.FromArgb(0xff, 0xe0, 0xc0);
            this.ButtoSDebit.FlatAppearance.BorderColor = Color.Green;
            this.ButtoSDebit.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtoSDebit.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtoSDebit.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtoSDebit.FlatStyle = FlatStyle.Flat;
            this.ButtoSDebit.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtoSDebit.Image = A.F.ImSort;
            this.ButtoSDebit.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtoSDebit.Location = new Point(0x153, 15);
            this.ButtoSDebit.Margin = new Padding(3, 4, 3, 4);
            this.ButtoSDebit.Name = "ButtoSDebit";
            this.ButtoSDebit.Size = new Size(0x114, 0x2c);
            this.ButtoSDebit.TabIndex = 0x41;
            this.ButtoSDebit.Text = "فرز العملاء الذين لديهم رصيد مدين";
            this.ButtoSDebit.UseVisualStyleBackColor = false;
            this.ButtoSCredit.BackColor = Color.FromArgb(0xc0, 0xff, 0xc0);
            this.ButtoSCredit.FlatAppearance.BorderColor = Color.Green;
            this.ButtoSCredit.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtoSCredit.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtoSCredit.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtoSCredit.FlatStyle = FlatStyle.Flat;
            this.ButtoSCredit.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtoSCredit.Image = A.F.ImSort;
            this.ButtoSCredit.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtoSCredit.Location = new Point(0x26d, 15);
            this.ButtoSCredit.Margin = new Padding(3, 4, 3, 4);
            this.ButtoSCredit.Name = "ButtoSCredit";
            this.ButtoSCredit.Size = new Size(0x114, 0x2c);
            this.ButtoSCredit.TabIndex = 0x40;
            this.ButtoSCredit.Text = "فرز العملاء الذين لديهم رصيد دائن";
            this.ButtoSCredit.UseVisualStyleBackColor = false;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d8, 0x22);
            this.TxTTitle.TabIndex = 0x53;
            this.TxTTitle.Text = "قائمة العملاء";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[0x12];
            toolStripItems[0] = this.ToolStripButtonViewAll;
            toolStripItems[1] = this.ToolStripSeparator8;
            toolStripItems[2] = this.ToolStripButtonAdd;
            toolStripItems[3] = this.ToolStripSeparator2;
            toolStripItems[4] = this.ToolStripButtonEdit;
            toolStripItems[5] = this.ToolStripSeparator3;
            toolStripItems[6] = this.ToolStripButtonDelete;
            toolStripItems[7] = this.ToolStripSeparator4;
            toolStripItems[8] = this.ToolStripButtonCard;
            toolStripItems[9] = this.ToolStripSeparator12;
            toolStripItems[10] = this.ToolStrWatssApp;
            toolStripItems[11] = this.ToolStripSeparator5;
            toolStripItems[12] = this.ToolStripDropDownButtonEmail;
            toolStripItems[13] = this.ToolStripSeparator9;
            toolStripItems[14] = this.ToolStripButtonPrint;
            toolStripItems[15] = this.ToolStripSeparator6;
            toolStripItems[0x10] = this.ToolStripButtonClose;
            toolStripItems[0x11] = this.ToolStripSeparator7;
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x20a);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x57;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(6, 0x2f);
            this.ToolStripButtonAdd.Image = A.F.ImCustomerAdd;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(0x49, 0x2c);
            this.ToolStripButtonAdd.Text = "اضافة";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.EdMulti, this.ToolStripSeparator14, this.EdSelect };
            this.ToolStripButtonEdit.DropDownItems.AddRange(itemArray2);
            this.ToolStripButtonEdit.Image = A.F.ImCustomerEdit;
            this.ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new Size(0x53, 0x2c);
            this.ToolStripButtonEdit.Text = "تعديل";
            this.EdMulti.Image = (Image) manager.GetObject("EdMulti.Image");
            this.EdMulti.ImageScaling = ToolStripItemImageScaling.None;
            this.EdMulti.Name = "EdMulti";
            this.EdMulti.Size = new Size(0xca, 0x26);
            this.EdMulti.Text = "تعديل متعدد";
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            this.ToolStripSeparator14.Size = new Size(0xc7, 6);
            this.EdSelect.Image = (Image) manager.GetObject("EdSelect.Image");
            this.EdSelect.ImageScaling = ToolStripItemImageScaling.None;
            this.EdSelect.Name = "EdSelect";
            this.EdSelect.Size = new Size(0xca, 0x26);
            this.EdSelect.Text = "تعديل العميل المحدد";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x2f);
            this.ToolStripButtonDelete.Image = A.F.ImCustomerDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(0x47, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ButCusDetials, this.ToolStripSeparator15, this.ButCusStatment };
            this.ToolStripButtonCard.DropDownItems.AddRange(itemArray3);
            this.ToolStripButtonCard.Image = A.F.ImCustomerCard;
            this.ToolStripButtonCard.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonCard.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonCard.Name = "ToolStripButtonCard";
            this.ToolStripButtonCard.Size = new Size(0x72, 0x2c);
            this.ToolStripButtonCard.Text = "كرت العميل";
            this.ButCusDetials.Image = (Image) manager.GetObject("ButCusDetials.Image");
            this.ButCusDetials.ImageScaling = ToolStripItemImageScaling.None;
            this.ButCusDetials.Name = "ButCusDetials";
            this.ButCusDetials.Size = new Size(0xcd, 0x26);
            this.ButCusDetials.Text = "تفاصيل العميل";
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            this.ToolStripSeparator15.Size = new Size(0xca, 6);
            this.ButCusStatment.Image = (Image) manager.GetObject("ButCusStatment.Image");
            this.ButCusStatment.ImageScaling = ToolStripItemImageScaling.None;
            this.ButCusStatment.Name = "ButCusStatment";
            this.ButCusStatment.Size = new Size(0xcd, 0x26);
            this.ButCusStatment.Text = "كشف حساب العميل";
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            this.ToolStripSeparator12.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.ButWatsBalance, this.ToolStripSeparator13, this.ButWatsNormal };
            this.ToolStrWatssApp.DropDownItems.AddRange(itemArray4);
            this.ToolStrWatssApp.Image = A.F.ImSWatsapp;
            this.ToolStrWatssApp.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStrWatssApp.ImageTransparentColor = Color.Magenta;
            this.ToolStrWatssApp.Name = "ToolStrWatssApp";
            this.ToolStrWatssApp.Size = new Size(0x7b, 0x2c);
            this.ToolStrWatssApp.Text = "إرسال واتساب";
            this.ButWatsBalance.Image = (Image) manager.GetObject("ButWatsBalance.Image");
            this.ButWatsBalance.ImageScaling = ToolStripItemImageScaling.None;
            this.ButWatsBalance.Name = "ButWatsBalance";
            this.ButWatsBalance.Size = new Size(0xf8, 30);
            this.ButWatsBalance.Text = "رسالة بالرصيد للعميل المحددة";
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            this.ToolStripSeparator13.Size = new Size(0xf5, 6);
            this.ButWatsNormal.Image = (Image) manager.GetObject("ButWatsNormal.Image");
            this.ButWatsNormal.ImageScaling = ToolStripItemImageScaling.None;
            this.ButWatsNormal.Name = "ButWatsNormal";
            this.ButWatsNormal.Size = new Size(0xf8, 30);
            this.ButWatsNormal.Text = "رسالة عادية للعميل المحدد";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.ToolStripMenuItemEmilChek, this.ToolStripSeparator11, this.ToolStripMenuItemEmailList, this.ToolStripSeparator10, this.ToolStripMenuItemEmailOne };
            this.ToolStripDropDownButtonEmail.DropDownItems.AddRange(itemArray5);
            this.ToolStripDropDownButtonEmail.Image = A.F.EmailButton;
            this.ToolStripDropDownButtonEmail.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripDropDownButtonEmail.ImageTransparentColor = Color.Magenta;
            this.ToolStripDropDownButtonEmail.Name = "ToolStripDropDownButtonEmail";
            this.ToolStripDropDownButtonEmail.Size = new Size(0x89, 0x2c);
            this.ToolStripDropDownButtonEmail.Text = "إرسال إشعار بريد";
            this.ToolStripMenuItemEmilChek.Image = A.F.EmailButton;
            this.ToolStripMenuItemEmilChek.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripMenuItemEmilChek.Name = "ToolStripMenuItemEmilChek";
            this.ToolStripMenuItemEmilChek.Size = new Size(0x137, 30);
            this.ToolStripMenuItemEmilChek.Text = "ارسال رسالة/اشعار لمجموعة ضمن تحديد";
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new Size(0x134, 6);
            this.ToolStripMenuItemEmailList.Image = (Image) manager.GetObject("ToolStripMenuItemEmailList.Image");
            this.ToolStripMenuItemEmailList.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripMenuItemEmailList.Name = "ToolStripMenuItemEmailList";
            this.ToolStripMenuItemEmailList.Size = new Size(0x137, 30);
            this.ToolStripMenuItemEmailList.Text = "ارسال رسالة/اشعار لكل القائمة اعلاه";
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new Size(0x134, 6);
            this.ToolStripMenuItemEmailOne.Image = (Image) manager.GetObject("ToolStripMenuItemEmailOne.Image");
            this.ToolStripMenuItemEmailOne.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripMenuItemEmailOne.Name = "ToolStripMenuItemEmailOne";
            this.ToolStripMenuItemEmailOne.Size = new Size(0x137, 30);
            this.ToolStripMenuItemEmailOne.Text = "ارسال رسالة/اشعار للعميل المحدد";
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray6 = new ToolStripItem[] { this.A4ToolStripMenuItemPrintList };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray6);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x56, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة";
            this.A4ToolStripMenuItemPrintList.Image = (Image) manager.GetObject("A4ToolStripMenuItemPrintList.Image");
            this.A4ToolStripMenuItemPrintList.ImageScaling = ToolStripItemImageScaling.None;
            this.A4ToolStripMenuItemPrintList.Name = "A4ToolStripMenuItemPrintList";
            this.A4ToolStripMenuItemPrintList.Size = new Size(0xb2, 0x26);
            this.A4ToolStripMenuItemPrintList.Text = "القائمة اعلاه A4";
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
            ToolStripItem[] itemArray7 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray7);
            this.ToolStripStatus.Location = new Point(0, 0x239);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x56;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x44, 0x16);
            this.ToolStripLabel1.Text = "عدد العملاء";
            this.TxTGVRowCount.ForeColor = Color.DarkGreen;
            this.TxTGVRowCount.Name = "TxTGVRowCount";
            this.TxTGVRowCount.RightToLeft = RightToLeft.No;
            this.TxTGVRowCount.Size = new Size(0x16, 0x16);
            this.TxTGVRowCount.Text = "00";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
            this.CheckBoxAllCenter.AutoSize = true;
            this.CheckBoxAllCenter.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxAllCenter.Checked = true;
            this.CheckBoxAllCenter.CheckState = CheckState.Checked;
            this.CheckBoxAllCenter.Dock = DockStyle.Top;
            this.CheckBoxAllCenter.Location = new Point(0, 0x91);
            this.CheckBoxAllCenter.Name = "CheckBoxAllCenter";
            this.CheckBoxAllCenter.Padding = new Padding(5);
            this.CheckBoxAllCenter.Size = new Size(0x3d8, 30);
            this.CheckBoxAllCenter.TabIndex = 0x6a;
            this.CheckBoxAllCenter.Text = "عرض العملاء من كل الفروع";
            this.CheckBoxAllCenter.UseVisualStyleBackColor = false;
            this.Panel1.BackColor = SystemColors.HighlightText;
            this.Panel1.BorderStyle = BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox9);
            this.Panel1.Controls.Add(this.GroupBox8);
            this.Panel1.Controls.Add(this.CheckBoxSAll);
            this.Panel1.Dock = DockStyle.Bottom;
            this.Panel1.Location = new Point(0, 0x1c6);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x3d8, 0x44);
            this.Panel1.TabIndex = 0x6d;
            this.GroupBox9.Controls.Add(this.TxTCredit);
            this.GroupBox9.Dock = DockStyle.Left;
            this.GroupBox9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox9.Location = new Point(0x127, 0);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0xb8, 0x40);
            this.GroupBox9.TabIndex = 0x6d;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "مجموع الارصيدة الدائنة";
            this.TxTCredit.BackColor = Color.White;
            this.TxTCredit.Dock = DockStyle.Fill;
            this.TxTCredit.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTCredit.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.TxTCredit.Location = new Point(3, 0x13);
            this.TxTCredit.Name = "TxTCredit";
            this.TxTCredit.RightToLeft = RightToLeft.No;
            this.TxTCredit.Size = new Size(0xb2, 0x2a);
            this.TxTCredit.TabIndex = 90;
            this.TxTCredit.Text = "0";
            this.TxTCredit.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox8.Controls.Add(this.TxTDebit);
            this.GroupBox8.Dock = DockStyle.Left;
            this.GroupBox8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox8.Location = new Point(0x5f, 0);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(200, 0x40);
            this.GroupBox8.TabIndex = 0x6c;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "مجموع الارصدة المدينة";
            this.TxTDebit.BackColor = Color.White;
            this.TxTDebit.Dock = DockStyle.Fill;
            this.TxTDebit.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDebit.ForeColor = Color.Red;
            this.TxTDebit.Location = new Point(3, 0x13);
            this.TxTDebit.Name = "TxTDebit";
            this.TxTDebit.RightToLeft = RightToLeft.No;
            this.TxTDebit.Size = new Size(0xc2, 0x2a);
            this.TxTDebit.TabIndex = 90;
            this.TxTDebit.Text = "0";
            this.TxTDebit.TextAlign = ContentAlignment.MiddleCenter;
            this.CheckBoxSAll.AutoSize = true;
            this.CheckBoxSAll.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxSAll.Dock = DockStyle.Left;
            this.CheckBoxSAll.Location = new Point(0, 0);
            this.CheckBoxSAll.Name = "CheckBoxSAll";
            this.CheckBoxSAll.Padding = new Padding(5);
            this.CheckBoxSAll.Size = new Size(0x5f, 0x40);
            this.CheckBoxSAll.TabIndex = 110;
            this.CheckBoxSAll.Text = "تحديد الكل";
            this.CheckBoxSAll.UseVisualStyleBackColor = false;
            this.CheckBoxSAll.Visible = false;
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
            this.GV.Location = new Point(0, 0xaf);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3d8, 0x117);
            this.GV.TabIndex = 0x1ed36ce;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3d8, 0x252);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.CheckBoxAllCenter);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "CustomerList";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "قائمة العملاء";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
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

        private void B(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    GT.A = this.GV.SelectedRows[0].Cells["CustomerPhone"].Value.ToString();
                    GT.R = "";
                    A.D.A.A.R();
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
            if (this.CheckBoxSAll.Checked)
            {
                int num = this.GV.Rows.Count - 1;
                for (int i = 0; i <= num; i++)
                {
                    this.GV.Rows[i].Cells["GVCheckBox"].Value = true;
                }
            }
            else
            {
                int num3 = this.GV.Rows.Count - 1;
                for (int i = 0; i <= num3; i++)
                {
                    this.GV.Rows[i].Cells["GVCheckBox"].Value = false;
                }
            }
        }

        private void D(object A, EventArgs R)
        {
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
            if (this.CheckBoxAllCenter.Checked)
            {
                this.A = "SELECT * FROM TaNNCustomers WHERE convert (DECIMAL(18, 3), CustomerBalance) = 0";
                this.TimerLoadData.Enabled = true;
            }
            else
            {
                this.A = "SELECT * FROM TaNNCustomers WHERE CenterFrontID = @CenterFrontID AND convert (DECIMAL(18, 3), CustomerBalance) = 0";
                this.TimerLoadData.Enabled = true;
            }
        }

        private void F(object A, EventArgs R)
        {
            try
            {
                if (!PR.TP)
                {
                    Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
                }
                else if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
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
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNCustomersPay WHERE (CustomerFrontID = @CustomerFrontID)", this.A);
                        command.Parameters.AddWithValue("CustomerFrontID", this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString());
                        command.ExecuteNonQuery();
                        this.A.Close();
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command2 = new SqlCommand("DELETE FROM TaNNCustomers WHERE (CustomerID = @CustomerID)", this.A);
                        command2.Parameters.AddWithValue("CustomerID", this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString());
                        command2.ExecuteNonQuery();
                        this.A.Close();
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        this.TimerLoadData.Enabled = true;
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

        private void G(object A, EventArgs R)
        {
            if (this.CheckBoxAllCenter.Checked)
            {
                this.A = "SELECT * FROM TaNNCustomers WHERE convert (DECIMAL(18, 3), CustomerBalance) < 0";
                this.TimerLoadData.Enabled = true;
            }
            else
            {
                this.A = "SELECT * FROM TaNNCustomers WHERE CenterFrontID = @CenterFrontID AND convert (DECIMAL(18, 3), CustomerBalance) < 0";
                this.TimerLoadData.Enabled = true;
            }
        }

        private void H(object A, EventArgs R)
        {
            if (this.ComboBoxSerachWat.Text == null)
            {
                Interaction.MsgBox(PR.G.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else if (this.TxTSerach.Text == null)
            {
                Interaction.MsgBox(PR.E.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 0)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CustomerName LIKE '%' + @CustomerName + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CenterFrontID = @CenterFrontID) AND (CustomerName LIKE '%' + @CustomerName + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 1)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CustomerAddress LIKE '%' + @CustomerAddress + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CenterFrontID = @CenterFrontID) AND (CustomerAddress LIKE '%' + @CustomerAddress + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 2)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CustomerPhone LIKE '%' + @CustomerPhone + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CenterFrontID = @CenterFrontID) AND (CustomerPhone LIKE '%' + @CustomerPhone + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 3)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CustomerNote LIKE '%' + @CustomerNote + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CenterFrontID = @CenterFrontID) AND (CustomerNote LIKE '%' + @CustomerNote + '%'))";
                    this.TimerLoadData.Enabled = true;
                }
            }
        }

        private void I(object A, EventArgs R)
        {
            if (PR.E)
            {
                A.D.A.A.ShowDialog();
            }
            if (!PR.FP)
            {
                Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                OI.A = 0;
                A.D.A.A.ShowDialog();
            }
        }

        private void J(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    SI.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString());
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
            this.A = !this.CheckBoxAllCenter.Checked ? "SELECT * FROM TaNNCustomers WHERE (CenterFrontID = @CenterFrontID)" : "SELECT * FROM TaNNCustomers";
            this.TimerLoadData.Enabled = true;
        }

        private void L(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
        }

        private void M(object A, EventArgs R)
        {
            if (this.GV.Rows.Count <= 0)
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else if (this.GV.Columns.Contains("GVCheckBox"))
            {
                A.D.A.A.ShowDialog();
            }
            else
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                DataGridViewCheckBoxColumn dataGridViewColumn = new DataGridViewCheckBoxColumn();
                this.GV.Columns.Add(dataGridViewColumn);
                dataGridViewColumn.HeaderText = "";
                dataGridViewColumn.DefaultCellStyle.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
                dataGridViewColumn.Name = "GVCheckBox";
                this.GV.ReadOnly = false;
                this.CheckBoxSAll.Visible = true;
            }
        }

        private void N(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                PI pi = new PI();
                pi.SetDataSource(this.A);
                pi.SetParameterValue("CenterName", PR.ER.ToString());
                pi.SetParameterValue("CenterSubName", PR.KR.ToString());
                pi.SetParameterValue("ParameterDeimelQ", PR.X);
                pi.SetParameterValue("ParameterDeimelS", PR.T);
                pi.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (PR.NR == null)
                {
                    pi.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    pi.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                }
                if (PR.UR == null)
                {
                    pi.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    pi.SetParameterValue("CenterPhone", PR.UR.ToString());
                }
                new HR { CRViewer = { ReportSource = pi } }.ShowDialog();
                pi.Close();
                pi.Dispose();
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

        private void O(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    this.R = null;
                    this.R = this.GV.SelectedRows[0].Cells["CustomerEmail"].Value.ToString();
                    this.Q();
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
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
        }

        public void Q()
        {
            try
            {
                PR.HR = this.R.ToString();
                PR.TR = " ";
                PR.XR = " ";
                A.D.A.A.Show();
                if (this.GV.Columns.Contains("GVCheckBox"))
                {
                    this.GV.Columns.Remove("GVCheckBox");
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                Interaction.MsgBox("خطأ في عملية ضبط اعدادات البريد الالكتروني", MsgBoxStyle.ApplicationModal, null);
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void R()
        {
            try
            {
                IEnumerator enumerator;
                IEnumerator enumerator2;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                this.A.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                string text = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("CustomerName", text ?? DBNull.Value);
                string text2 = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("CustomerAddress", text2 ?? DBNull.Value);
                string text3 = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("CustomerPhone", text3 ?? DBNull.Value);
                string text4 = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("CustomerNote", text4 ?? DBNull.Value);
                string text5 = this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd 00:00");
                adapter.SelectCommand.Parameters.AddWithValue("DF", text5 ?? DBNull.Value);
                string text6 = this.DateTimePickerTo.Value.ToString("yyyy/MM/dd 23:59");
                adapter.SelectCommand.Parameters.AddWithValue("DT", text6 ?? DBNull.Value);
                adapter.Fill(this.A);
                this.A.Close();
                decimal left = 0M;
                decimal num2 = 0M;
                try
                {
                    enumerator = this.A.Rows.GetEnumerator();
                    while (true)
                    {
                        if (!enumerator.MoveNext())
                        {
                            break;
                        }
                        object current = enumerator.Current;
                        object[] arguments = new object[] { "CustomerBalance" };
                        if (Conversion.Val(NewLateBinding.LateIndexGet(current, arguments, null)) > 0.0)
                        {
                            object[] objArray2 = new object[] { "CustomerBalance" };
                            num2 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num2, NewLateBinding.LateIndexGet(current, objArray2, null)));
                            continue;
                        }
                        object[] objArray3 = new object[] { "CustomerBalance" };
                        left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, objArray3, null)));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                this.TxTDebit.Text = left.ToString(PR.YR);
                this.TxTCredit.Text = num2.ToString(PR.YR);
                this.GV.DataSource = this.A;
                this.GV.Refresh();
                this.GV.Columns["CustomerID"].Visible = false;
                this.GV.Columns["CenterFrontID"].HeaderText = "رمز الفرع";
                this.GV.Columns["CustomerName"].HeaderText = "اسم العميل";
                this.GV.Columns["CustomerAddress"].HeaderText = "العنوان";
                this.GV.Columns["CustomerPhone"].HeaderText = "الهاتف";
                this.GV.Columns["CustomerNote"].HeaderText = "ملاحظات";
                this.GV.Columns["CustomerBalance"].HeaderText = "الرصيد";
                this.GV.Columns["CustomerDiscount"].HeaderText = "الخصم %";
                this.GV.Columns["CustomerPoints"].HeaderText = "النقاط الحالية";
                this.GV.Columns["CustomerPriceType"].HeaderText = "تطبيق سعر البيع";
                this.GV.Columns["CustomerApplyIfPoints"].Visible = false;
                this.GV.Columns["CustomerDateConfigur"].HeaderText = "تاريخ اخر اجراء";
                this.GV.Columns["CustomerUserAddBy"].HeaderText = "الموظف";
                this.GV.Columns["CustomerGiftBarcode"].Visible = false;
                this.GV.Columns["CustomerGiftExpDate"].Visible = false;
                this.GV.Columns["CustomerGiftDisMiWi"].Visible = false;
                this.GV.Columns["CustomerGiftDisVal"].Visible = false;
                this.GV.Columns["CustomerGiftCount"].Visible = false;
                this.GV.Columns["CustomerGiftNote"].Visible = false;
                this.GV.Columns["CustomerEmail"].HeaderText = "بريد الاشعارات";
                this.GV.Columns["CuSchemeID"].Visible = false;
                this.GV.Columns["CuSchemeTy"].Visible = false;
                this.GV.Columns["CuStreetName"].Visible = false;
                this.GV.Columns["CuBuildingNumber"].Visible = false;
                this.GV.Columns["CuPlotIdentification"].Visible = false;
                this.GV.Columns["CuCitySubdivisionName"].Visible = false;
                this.GV.Columns["CuCityName"].Visible = false;
                this.GV.Columns["CuCountrySubentity"].Visible = false;
                this.GV.Columns["CuCompanyID"].Visible = false;
                this.GV.Columns["CuExpDat"].Visible = false;
                this.GV.Columns["CuPostCode"].Visible = false;
                this.GV.Columns["CuMorID"].Visible = false;
                this.GV.Columns["CusLimitDebit"].Visible = false;
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
                        decimal num3 = new decimal(Conversion.Val(current.Cells["CustomerBalance"].Value.ToString()));
                        if (decimal.Compare(num3, decimal.Zero) > 0)
                        {
                            current.Cells["CustomerBalance"].Style.ForeColor = Color.Blue;
                        }
                        else if (decimal.Compare(num3, decimal.Zero) < 0)
                        {
                            current.Cells["CustomerBalance"].Style.ForeColor = Color.Red;
                        }
                        current.Cells["CustomerBalance"].Value = num3.ToString(PR.YR);
                        decimal num4 = new decimal(Conversion.Val(current.Cells["CustomerPriceType"].Value.ToString()));
                        if (decimal.Compare(num4, decimal.Zero) == 0)
                        {
                            current.Cells["CustomerPriceType"].Value = "العادي";
                        }
                        else if (decimal.Compare(num4, decimal.One) == 0)
                        {
                            current.Cells["CustomerPriceType"].Value = "المخفض";
                        }
                        else if (decimal.Compare(num4, 2M) == 0)
                        {
                            current.Cells["CustomerPriceType"].Value = "التكلفة";
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
                this.P();
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

        private void R(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerLoadData.Enabled = true;
        }

        private void S(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    string str = this.GV.SelectedRows[0].Cells["CustomerPhone"].Value.ToString();
                    string str2 = this.GV.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                    string str3 = this.GV.SelectedRows[0].Cells["CustomerBalance"].Value.ToString();
                    decimal num = new decimal(Conversion.Val(str3.ToString().Replace(",", "")));
                    string str4 = "";
                    if (decimal.Compare(num, decimal.Zero) > 0)
                    {
                        str4 = "دائن";
                    }
                    else
                    {
                        str4 = (decimal.Compare(num, decimal.Zero) >= 0) ? "" : "مدين";
                    }
                    string[] textArray1 = new string[] { str2.ToString(), " نحيطكم علماً بأن رصيدكم هو ", str3.ToString(), " ", str4.ToString(), "   -   ", PR.ER.ToString() };
                    string str5 = string.Concat(textArray1);
                    GT.A = str.ToString();
                    GT.R = str5.ToString();
                    A.D.A.A.R();
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

        private void T(object A, EventArgs R)
        {
            if (this.ComboBoxWat.SelectedIndex == 0)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM TaNNCustomers WHERE (CustomerDateConfigur BETWEEN @DF and @DT)";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM TaNNCustomers WHERE (CenterFrontID = @CenterFrontID) AND (CustomerDateConfigur BETWEEN @DF and @DT)";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.CheckBoxAllCenter.Checked)
            {
                this.A = "SELECT * FROM TaNNCustomers WHERE (CustomerDateConfigur NOT BETWEEN @DF and @DT)";
                this.TimerLoadData.Enabled = true;
            }
            else
            {
                this.A = "SELECT * FROM TaNNCustomers WHERE (CenterFrontID = @CenterFrontID) AND (CustomerDateConfigur NOT BETWEEN @DF and @DT)";
                this.TimerLoadData.Enabled = true;
            }
        }

        private void U(object A, EventArgs R)
        {
            this.A = !this.CheckBoxAllCenter.Checked ? "SELECT * FROM TaNNCustomers WHERE (CenterFrontID = @CenterFrontID)" : "SELECT * FROM TaNNCustomers";
            this.TimerLoadData.Enabled = true;
        }

        private void V(object A, EventArgs R)
        {
            if (this.GV.Rows.Count <= 0)
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    IEnumerator enumerator;
                    this.R = null;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = this.GV.Rows.Count;
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
                            string str = current.Cells["CustomerEmail"].Value.ToString();
                            if (str != null)
                            {
                                this.R = this.R + ";" + str.ToString();
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
                    this.ToolStripProgressBar1.Visible = false;
                    char[] trimChars = new char[] { ';' };
                    this.R = this.R.TrimStart(trimChars);
                    this.Q();
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

        private void W(object A, EventArgs R)
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
                    OI.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString());
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
            if (this.CheckBoxAllCenter.Checked)
            {
                this.A = "SELECT * FROM TaNNCustomers WHERE convert (DECIMAL(18, 3), CustomerBalance) > 0";
                this.TimerLoadData.Enabled = true;
            }
            else
            {
                this.A = "SELECT * FROM TaNNCustomers WHERE CenterFrontID = @CenterFrontID AND convert (DECIMAL(18, 3), CustomerBalance) > 0";
                this.TimerLoadData.Enabled = true;
            }
        }

        private void Y(object A, EventArgs R)
        {
            try
            {
                if (this.GV.Rows.Count <= 0)
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else if (!this.GV.Columns.Contains("GVCheckBox"))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                    DataGridViewCheckBoxColumn dataGridViewColumn = new DataGridViewCheckBoxColumn();
                    this.GV.Columns.Add(dataGridViewColumn);
                    dataGridViewColumn.HeaderText = "";
                    dataGridViewColumn.DefaultCellStyle.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
                    dataGridViewColumn.Name = "GVCheckBox";
                    this.GV.ReadOnly = false;
                    this.CheckBoxSAll.Visible = true;
                }
                else
                {
                    this.GV.ClearSelection();
                    this.GV.CurrentCell = this.GV.Rows[0].Cells["GVCheckBox"];
                    this.GV.Rows[0].Cells["GVCheckBox"].Selected = true;
                    this.R = null;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = this.GV.Rows.Count;
                    int num = this.GV.Rows.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        if (num2 > num)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            char[] trimChars = new char[] { ';' };
                            this.R = this.R.TrimStart(trimChars);
                            this.Q();
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num2;
                        if (Conversions.ToBoolean(this.GV.Rows[num2].Cells["GVCheckBox"].Value))
                        {
                            string str = this.GV.Rows[num2].Cells["CustomerEmail"].Value.ToString();
                            if (str != null)
                            {
                                this.R = this.R + ";" + str.ToString();
                            }
                        }
                        num2++;
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

        private void Z(object A, EventArgs R)
        {
            try
            {
                if (!PR.TP)
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
                    OI.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString());
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

        internal virtual Label TxTTitle
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

        internal virtual ToolStripButton ToolStripButtonDelete
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual CheckBox CheckBoxAllCenter
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox a = this.A;
                if (a != null)
                {
                    a.KeyPress -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.KeyPress += handler;
                }
            }
        }

        internal virtual Button ButtonSearchCodeName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual DateTimePicker DateTimePickerTo
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox ComboBoxWat
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual DateTimePicker DateTimePickerFrom
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonSortDate
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

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtoSCredit
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtoSDebit
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual Button ButtonSZero
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripButton ToolStripButtonViewAll
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

        internal virtual ToolStripSeparator ToolStripSeparator8
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual ToolStripMenuItem A4ToolStripMenuItemPrintList
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
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

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label TxTCredit
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
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label TxTDebit
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripDropDownButton ToolStripDropDownButtonEmail
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual ToolStripMenuItem ToolStripMenuItemEmailList
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
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

        internal virtual ToolStripSeparator ToolStripSeparator10
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual ToolStripMenuItem ToolStripMenuItemEmailOne
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
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

        internal virtual ToolStripMenuItem ToolStripMenuItemEmilChek
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
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

        internal virtual ToolStripSeparator ToolStripSeparator11
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

        internal virtual ToolStripDropDownButton ToolStrWatssApp
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripMenuItem ButWatsBalance
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.S);
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

        internal virtual ToolStripSeparator ToolStripSeparator13
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual ToolStripMenuItem ButWatsNormal
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.B);
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

        internal virtual ToolStripDropDownButton ToolStripButtonEdit
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                ToolStripDropDownButton q = this.Q;
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

        internal virtual ToolStripMenuItem EdMulti
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.M);
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

        internal virtual ToolStripSeparator ToolStripSeparator14
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual ToolStripMenuItem EdSelect
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

        internal virtual CheckBox CheckBoxSAll
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.C);
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

        internal virtual ToolStripDropDownButton ToolStripButtonCard
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripMenuItem ButCusDetials
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

        internal virtual ToolStripSeparator ToolStripSeparator15
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual ToolStripMenuItem ButCusStatment
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.J);
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

