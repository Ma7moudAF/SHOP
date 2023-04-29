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
    public class SD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("GroupBox1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("DateTimePickerFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker R;
        [AccessedThroughProperty("GroupBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [AccessedThroughProperty("DateTimePickerTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker P;
        [AccessedThroughProperty("PickerTimeTo"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker Q;
        [AccessedThroughProperty("GroupBox9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("HSaleType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("ButtonSortDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("GV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [AccessedThroughProperty("ToolStripButtons"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripSeparator6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [AccessedThroughProperty("ToolStripButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator R;
        [AccessedThroughProperty("TimerM"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("GroupBox3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("ComboBoxSortType"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox R;
        [AccessedThroughProperty("TimerG"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [AccessedThroughProperty("ToolStripButtonPrint"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripDropDownButton A;
        [AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator P;
        [AccessedThroughProperty("PrintRoll80ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("PrintA4ToolStripMenuItem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("TimerS"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [AccessedThroughProperty("TxTTip"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel A;
        [AccessedThroughProperty("ToolStripProgressBar1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("Panel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel A;
        [AccessedThroughProperty("TimerXSS"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer Q;
        [AccessedThroughProperty("Panel2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Panel R;
        [AccessedThroughProperty("GroupBox16"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("TxTTotalQu"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [AccessedThroughProperty("GroupBox14"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("TxTNetTotal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBox13"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [CompilerGenerated, AccessedThroughProperty("TxTTotalProft"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label I;
        [CompilerGenerated, AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [CompilerGenerated, AccessedThroughProperty("TxTTotalDar"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [AccessedThroughProperty("GroupBox11"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [CompilerGenerated, AccessedThroughProperty("TxTTotalDis"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox10"), CompilerGenerated]
        private GroupBox X;
        [CompilerGenerated, AccessedThroughProperty("TxTTotalTotal"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label H;
        public static int A = 0;
        public static string A = "-";
        private int R;
        private int P;
        private int Q;
        private int I;
        private bool A;
        private SqlConnection A;
        private DataTable A;

        public SD()
        {
            base.Load += new EventHandler(this.A);
            this.R = 0;
            this.P = 0;
            this.Q = 0;
            this.I = 0;
            this.A = false;
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(SD));
            this.TxTTitle = new Label();
            this.GroupBox3 = new GroupBox();
            this.ComboBoxSortType = new ComboBox();
            this.GroupBox1 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBox2 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.GroupBox9 = new GroupBox();
            this.HSaleType = new ComboBox();
            this.GV = new DataGridView();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.PrintRoll80ToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.PrintA4ToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.TxTTip = new ToolStripLabel();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.TimerM = new Timer(this.A);
            this.TimerG = new Timer(this.A);
            this.TimerS = new Timer(this.A);
            this.ButtonSortDate = new Button();
            this.Label1 = new Label();
            this.Panel1 = new Panel();
            this.TimerXSS = new Timer(this.A);
            this.Panel2 = new Panel();
            this.GroupBox16 = new GroupBox();
            this.TxTTotalQu = new Label();
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
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.ToolStripButtons.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3f7, 0x22);
            this.TxTTitle.TabIndex = 0x6f;
            this.TxTTitle.Text = "سجل البيع المختصر / تجميعي";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox3.Controls.Add(this.ComboBoxSortType);
            this.GroupBox3.Location = new Point(0xf9, 0x1d);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0xa7, 0x35);
            this.GroupBox3.TabIndex = 0x1ed36cd;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "معيار التجميع";
            this.ComboBoxSortType.Dock = DockStyle.Fill;
            this.ComboBoxSortType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxSortType.FormattingEnabled = true;
            object[] items = new object[] { "حسب المادة", "حسب  المجموعة", "حسب المورد" };
            this.ComboBoxSortType.Items.AddRange(items);
            this.ComboBoxSortType.Location = new Point(3, 0x13);
            this.ComboBoxSortType.Name = "ComboBoxSortType";
            this.ComboBoxSortType.Size = new Size(0xa1, 0x18);
            this.ComboBoxSortType.TabIndex = 0x2c;
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x326, 13);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb0, 0x4a);
            this.GroupBox1.TabIndex = 0x1ed36ce;
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
            this.GroupBox2.Location = new Point(0x270, 13);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xb0, 0x48);
            this.GroupBox2.TabIndex = 0x1ed36cf;
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
            this.GroupBox9.Controls.Add(this.HSaleType);
            this.GroupBox9.Location = new Point(0x1a6, 0x1d);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0xa7, 0x35);
            this.GroupBox9.TabIndex = 0x1ed36cc;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "النوع";
            this.HSaleType.Dock = DockStyle.Fill;
            this.HSaleType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.HSaleType.FormattingEnabled = true;
            object[] objArray2 = new object[] { "المبيعات", "مرتجع المبيعات" };
            this.HSaleType.Items.AddRange(objArray2);
            this.HSaleType.Location = new Point(3, 0x13);
            this.HSaleType.Name = "HSaleType";
            this.HSaleType.Size = new Size(0xa1, 0x18);
            this.HSaleType.TabIndex = 0x2c;
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
            this.GV.Location = new Point(0, 0xc9);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3f7, 0x178);
            this.GV.TabIndex = 0x1ed36d1;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonPrint, this.ToolStripSeparator6, this.ToolStripButtonClose, this.ToolStripSeparator7, this.TxTTip, this.ToolStripProgressBar1 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x27b);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3f7, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36d2;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.PrintRoll80ToolStripMenuItem, this.ToolStripSeparator1, this.PrintA4ToolStripMenuItem };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray2);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x56, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة";
            this.PrintRoll80ToolStripMenuItem.Image = (Image) manager.GetObject("PrintRoll80ToolStripMenuItem.Image");
            this.PrintRoll80ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.PrintRoll80ToolStripMenuItem.Name = "PrintRoll80ToolStripMenuItem";
            this.PrintRoll80ToolStripMenuItem.Size = new Size(0xca, 0x26);
            this.PrintRoll80ToolStripMenuItem.Text = "قياس حراري Roll 80";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(0xc7, 6);
            this.PrintA4ToolStripMenuItem.Image = (Image) manager.GetObject("PrintA4ToolStripMenuItem.Image");
            this.PrintA4ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.PrintA4ToolStripMenuItem.Name = "PrintA4ToolStripMenuItem";
            this.PrintA4ToolStripMenuItem.Size = new Size(0xca, 0x26);
            this.PrintA4ToolStripMenuItem.Text = "قياس A4";
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
            this.TxTTip.Name = "TxTTip";
            this.TxTTip.Size = new Size(13, 0x2c);
            this.TxTTip.Text = "-";
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x2c);
            this.ToolStripProgressBar1.Visible = false;
            this.TimerM.Interval = 500;
            this.TimerG.Interval = 500;
            this.TimerS.Interval = 500;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(0x23, 0x1c);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(0xbb, 0x36);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.Label1.BackColor = SystemColors.Info;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label1.Location = new Point(0, 0x22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x3f7, 0x43);
            this.Label1.TabIndex = 0x1ed36d3;
            this.Label1.Text = manager.GetString("Label1.Text");
            this.Label1.TextAlign = ContentAlignment.MiddleLeft;
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.GroupBox9);
            this.Panel1.Controls.Add(this.ButtonSortDate);
            this.Panel1.Controls.Add(this.GroupBox3);
            this.Panel1.Controls.Add(this.GroupBox2);
            this.Panel1.Dock = DockStyle.Top;
            this.Panel1.Location = new Point(0, 0x65);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x3f7, 100);
            this.Panel1.TabIndex = 0x1ed36d4;
            this.TimerXSS.Interval = 500;
            this.Panel2.BackColor = SystemColors.HighlightText;
            this.Panel2.BorderStyle = BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.GroupBox16);
            this.Panel2.Controls.Add(this.GroupBox14);
            this.Panel2.Controls.Add(this.GroupBox13);
            this.Panel2.Controls.Add(this.GroupBox12);
            this.Panel2.Controls.Add(this.GroupBox11);
            this.Panel2.Controls.Add(this.GroupBox10);
            this.Panel2.Dock = DockStyle.Bottom;
            this.Panel2.Location = new Point(0, 0x241);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new Size(0x3f7, 0x3a);
            this.Panel2.TabIndex = 0x1ed36d5;
            this.GroupBox16.Controls.Add(this.TxTTotalQu);
            this.GroupBox16.Dock = DockStyle.Right;
            this.GroupBox16.Location = new Point(0x33, 0);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(160, 0x36);
            this.GroupBox16.TabIndex = 6;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "مجموع الكمية";
            this.TxTTotalQu.Dock = DockStyle.Fill;
            this.TxTTotalQu.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTotalQu.Location = new Point(3, 0x13);
            this.TxTTotalQu.Name = "TxTTotalQu";
            this.TxTTotalQu.Size = new Size(0x9a, 0x20);
            this.TxTTotalQu.TabIndex = 0;
            this.TxTTotalQu.Text = "0";
            this.TxTTotalQu.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox14.Controls.Add(this.TxTNetTotal);
            this.GroupBox14.Dock = DockStyle.Right;
            this.GroupBox14.Location = new Point(0xd3, 0);
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
            this.GroupBox13.Location = new Point(0x173, 0);
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
            this.GroupBox12.Location = new Point(0x213, 0);
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
            this.GroupBox11.Location = new Point(0x2b3, 0);
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
            this.GroupBox10.Location = new Point(0x353, 0);
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
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3f7, 0x2aa);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.Panel2);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "InvoiceSaleMinItems";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "سجل البيع المختصر / تجميعي";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                IQ iq = new IQ();
                iq.SetDataSource(this.A);
                iq.SetParameterValue("CenterName", PR.ER.ToString());
                iq.SetParameterValue("CenterSubName", PR.KR.ToString());
                iq.SetParameterValue("ParameterDeimelQ", PR.X);
                iq.SetParameterValue("ParameterDeimelS", PR.T);
                iq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (PR.NR == null)
                {
                    iq.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    iq.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                }
                if (PR.UR == null)
                {
                    iq.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    iq.SetParameterValue("CenterPhone", PR.UR.ToString());
                }
                DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
                DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
                iq.SetParameterValue("RPTitle", this.HSaleType.Text);
                iq.SetParameterValue("DF", time.ToString());
                iq.SetParameterValue("DT", time2.ToString());
                iq.SetParameterValue("SoTyp", this.TxTTip.Text);
                iq.SetParameterValue("XTotalTotal", this.TxTTotalTotal.Text);
                iq.SetParameterValue("XTotalDis", this.TxTTotalDis.Text);
                iq.SetParameterValue("XTotalDar", this.TxTTotalDar.Text);
                iq.SetParameterValue("XTotalProft", this.TxTTotalProft.Text);
                iq.SetParameterValue("XTotalNetSale", this.TxTNetTotal.Text);
                iq.SetParameterValue("XTotalQuantityt", this.TxTTotalQu.Text);
                new HR { CRViewer = { ReportSource = iq } }.ShowDialog();
                iq.Close();
                iq.Dispose();
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

        private void F(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                PQ pq = new PQ {
                    PrintOptions = { NoPrinter = AR.J }
                };
                pq.SetDataSource(this.A);
                pq.SetParameterValue("CenterName", PR.ER.ToString());
                pq.SetParameterValue("CenterSubName", PR.KR.ToString());
                pq.SetParameterValue("ParameterDeimelQ", PR.X);
                pq.SetParameterValue("ParameterDeimelS", PR.T);
                pq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (PR.NR == null)
                {
                    pq.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    pq.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                }
                if (PR.UR == null)
                {
                    pq.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    pq.SetParameterValue("CenterPhone", PR.UR.ToString());
                }
                DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
                DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
                pq.SetParameterValue("RPTitle", this.HSaleType.Text);
                pq.SetParameterValue("DF", time.ToString());
                pq.SetParameterValue("DT", time2.ToString());
                pq.SetParameterValue("SoTyp", this.TxTTip.Text);
                pq.SetParameterValue("XTotalTotal", this.TxTTotalTotal.Text);
                pq.SetParameterValue("XTotalDis", this.TxTTotalDis.Text);
                pq.SetParameterValue("XTotalDar", this.TxTTotalDar.Text);
                pq.SetParameterValue("XTotalProft", this.TxTTotalProft.Text);
                pq.SetParameterValue("XTotalNetSale", this.TxTNetTotal.Text);
                pq.SetParameterValue("XTotalQuantityt", this.TxTTotalQu.Text);
                HR hr = new HR {
                    CRViewer = { ReportSource = pq }
                };
                if (AR.U)
                {
                    hr.ShowDialog();
                }
                else if (AR.L)
                {
                    hr.CRViewer.PrintReport();
                }
                else
                {
                    pq.PrintOptions.PrinterName = AR.X;
                    pq.PrintToPrinter(AR.I, false, 0, 0);
                }
                pq.Close();
                pq.Dispose();
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

        private void H(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            this.R = 0;
            this.P = 0;
            this.Q = 0;
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            SqlCommand command = new SqlCommand("DELETE FROM TaNNHSaleMini WHERE (CenterFrontID = @CenterFrontID)", this.A);
            command.Parameters.AddWithValue("CenterFrontID", PR.GR);
            command.ExecuteNonQuery();
            this.A.Close();
            if (this.ComboBoxSortType.SelectedIndex == 0)
            {
                this.TimerM.Enabled = true;
            }
            else if (this.ComboBoxSortType.SelectedIndex == 1)
            {
                this.TimerG.Enabled = true;
            }
            else if (this.ComboBoxSortType.SelectedIndex == 2)
            {
                A.D.A.A.ShowDialog();
            }
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void R()
        {
            this.TimerG.Enabled = false;
            this.TimerM.Enabled = false;
            this.TimerS.Enabled = false;
            this.ToolStripProgressBar1.Visible = false;
            this.TxTTitle.Text = this.Text.ToString();
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Font = new Font("Tahoma", 12f);
            try
            {
                IEnumerator enumerator;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string selectCommandText = "SELECT * FROM TaNNHSaleMini WHERE (CenterFrontID = @CenterFrontID)";
                this.A.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(this.A);
                this.A.Close();
                this.GV.DataSource = this.A;
                this.GV.Refresh();
                this.GV.Columns["IDH"].Visible = false;
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["HTitle"].HeaderText = "الوصف";
                this.GV.Columns["TotalQ"].HeaderText = "مجموع الكمية";
                this.GV.Columns["TotalSub"].HeaderText = "المجموع الفرعي";
                this.GV.Columns["TotalDis"].HeaderText = "مجموع الخصم";
                this.GV.Columns["TotalDar"].HeaderText = "مجموع الضريبة";
                this.GV.Columns["TotalNet"].HeaderText = "صافي المجموع";
                this.GV.Columns["TotalProft"].HeaderText = "مجموع الربح";
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                decimal num = 0M;
                decimal num2 = 0M;
                decimal num3 = 0M;
                decimal num4 = 0M;
                decimal num5 = 0M;
                decimal num6 = 0M;
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
                        object[] arguments = new object[] { "TotalSub" };
                        num = new decimal(Convert.ToDouble(num) + Conversions.ToDouble(NewLateBinding.LateIndexGet(current, arguments, null).ToString().Replace(",", "")));
                        object[] objArray2 = new object[] { "TotalDis" };
                        num2 = new decimal(Convert.ToDouble(num2) + Conversions.ToDouble(NewLateBinding.LateIndexGet(current, objArray2, null).ToString().Replace(",", "")));
                        object[] objArray3 = new object[] { "TotalDar" };
                        num3 = new decimal(Convert.ToDouble(num3) + Conversions.ToDouble(NewLateBinding.LateIndexGet(current, objArray3, null).ToString().Replace(",", "")));
                        object[] objArray4 = new object[] { "TotalProft" };
                        num4 = new decimal(Convert.ToDouble(num4) + Conversions.ToDouble(NewLateBinding.LateIndexGet(current, objArray4, null).ToString().Replace(",", "")));
                        object[] objArray5 = new object[] { "TotalNet" };
                        num5 = new decimal(Convert.ToDouble(num5) + Conversions.ToDouble(NewLateBinding.LateIndexGet(current, objArray5, null).ToString().Replace(",", "")));
                        object[] objArray6 = new object[] { "TotalQ" };
                        num6 = new decimal(Convert.ToDouble(num6) + Conversions.ToDouble(NewLateBinding.LateIndexGet(current, objArray6, null).ToString().Replace(",", "")));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                this.TxTTotalTotal.Text = num.ToString(PR.YR);
                this.TxTTotalDis.Text = num2.ToString(PR.YR);
                this.TxTTotalDar.Text = num3.ToString(PR.YR);
                this.TxTTotalProft.Text = !PR.BP ? "مخفي" : num4.ToString(PR.YR);
                this.TxTNetTotal.Text = num5.ToString(PR.YR);
                this.TxTTotalQu.Text = num6.ToString(PR.BR);
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
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
            // Invalid method body.
        }

        private void T(object A, EventArgs R)
        {
        }

        private void X(object A, EventArgs R)
        {
            // Invalid method body.
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ComboBox HSaleType
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
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual DataGridView GV
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
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual Timer TimerM
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ComboBox ComboBoxSortType
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual Timer TimerG
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual ToolStripDropDownButton ToolStripButtonPrint
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

        internal virtual ToolStripMenuItem PrintRoll80ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual ToolStripMenuItem PrintA4ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual Timer TimerS
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual ToolStripLabel TxTTip
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual Timer TimerXSS
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual Panel Panel2
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
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
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
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

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
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

