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
    public class DT : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator2")]
        private ToolStripSeparator A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator3"), CompilerGenerated]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripButtonDelete"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxAllCenter")]
        private CheckBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator4"), CompilerGenerated]
        private ToolStripSeparator P;
        [AccessedThroughProperty("ToolStripButtonCard"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton R;
        [AccessedThroughProperty("ToolStripSeparator5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator Q;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator I;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator D;
        [CompilerGenerated, AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripProgressBar A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripLabel1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel A;
        [CompilerGenerated, AccessedThroughProperty("TxTGVRowCount"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerLoadData")]
        private Timer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimersStartUp")]
        private Timer R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonEdit"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerFillGV")]
        private Timer P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonAdd")]
        private ToolStripButton I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1"), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox5")]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTSerach")]
        private TextBox A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [AccessedThroughProperty("ComboBoxSerachWat"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [CompilerGenerated, AccessedThroughProperty("ButtonSearchCodeName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage2")]
        private TabPage R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2")]
        private GroupBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DateTimePickerTo")]
        private DateTimePicker A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3"), CompilerGenerated]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ComboBoxWat")]
        private ComboBox R;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DateTimePickerFrom"), CompilerGenerated]
        private DateTimePicker R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSortDate")]
        private Button R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage3")]
        private TabPage P;
        [AccessedThroughProperty("ButtonSZero"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtoSDebit")]
        private Button Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtoSCredit")]
        private Button I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtons")]
        private ToolStrip R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonViewAll"), CompilerGenerated]
        private ToolStripButton D;
        [AccessedThroughProperty("ToolStripSeparator8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator H;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Panel1")]
        private Panel A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GV")]
        private DataGridView A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonPrint")]
        private ToolStripDropDownButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("A4ToolStripMenuItemPrintList"), CompilerGenerated]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("GroupBox9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("TxTCredit"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox8"), CompilerGenerated]
        private GroupBox F;
        [CompilerGenerated, AccessedThroughProperty("TxTDebit"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripDropDownButtonEmail")]
        private ToolStripDropDownButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripMenuItemEmilChek")]
        private ToolStripMenuItem R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator11")]
        private ToolStripSeparator T;
        [CompilerGenerated, AccessedThroughProperty("ToolStripMenuItemEmailList"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator10")]
        private ToolStripSeparator X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripMenuItemEmailOne"), CompilerGenerated]
        private ToolStripMenuItem Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator9")]
        private ToolStripSeparator G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStrWatssApp"), CompilerGenerated]
        private ToolStripDropDownButton P;
        [CompilerGenerated, AccessedThroughProperty("ButSendSupWatsapp"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem I;
        private SqlConnection A;
        private DataTable A;
        private string A;
        private int A;
        private string R;

        public DT()
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(DT));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.CheckBoxAllCenter = new CheckBox();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowCount = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TimerFillGV = new Timer(this.A);
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
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripButtonEdit = new ToolStripButton();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripButtonCard = new ToolStripButton();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.A4ToolStripMenuItemPrintList = new ToolStripMenuItem();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.ToolStrWatssApp = new ToolStripDropDownButton();
            this.ButSendSupWatsapp = new ToolStripMenuItem();
            this.ToolStripDropDownButtonEmail = new ToolStripDropDownButton();
            this.ToolStripMenuItemEmilChek = new ToolStripMenuItem();
            this.ToolStripSeparator11 = new ToolStripSeparator();
            this.ToolStripMenuItemEmailList = new ToolStripMenuItem();
            this.ToolStripSeparator10 = new ToolStripSeparator();
            this.ToolStripMenuItemEmailOne = new ToolStripMenuItem();
            this.ToolStripButtonClose = new ToolStripButton();
            this.TxTTitle = new Label();
            this.Panel1 = new Panel();
            this.GroupBox9 = new GroupBox();
            this.TxTCredit = new Label();
            this.GroupBox8 = new GroupBox();
            this.TxTDebit = new Label();
            this.GV = new DataGridView();
            this.ToolStripStatus.SuspendLayout();
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
            this.Panel1.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x2f);
            this.CheckBoxAllCenter.AutoSize = true;
            this.CheckBoxAllCenter.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxAllCenter.Checked = true;
            this.CheckBoxAllCenter.CheckState = CheckState.Checked;
            this.CheckBoxAllCenter.Dock = DockStyle.Top;
            this.CheckBoxAllCenter.Location = new Point(0, 0x91);
            this.CheckBoxAllCenter.Name = "CheckBoxAllCenter";
            this.CheckBoxAllCenter.Padding = new Padding(5);
            this.CheckBoxAllCenter.Size = new Size(0x3d8, 30);
            this.CheckBoxAllCenter.TabIndex = 0x72;
            this.CheckBoxAllCenter.Text = "عرض الموردين من كل الفروع";
            this.CheckBoxAllCenter.UseVisualStyleBackColor = false;
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x2f);
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(6, 0x2f);
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new Size(6, 0x2f);
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(6, 0x2f);
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(toolStripItems);
            this.ToolStripStatus.Location = new Point(0, 0x211);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x6f;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x4f, 0x16);
            this.ToolStripLabel1.Text = "عدد الموردين";
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
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 0x6f);
            this.TabControl1.TabIndex = 0x71;
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
            object[] items = new object[] { "اسم المورد", "عنوان المورد", "رقم الهاتف", "ملاحظات" };
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
            this.GroupBox3.Text = "فرز الموردين الذين";
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
            this.TabPage3.Text = "الفرز حسب الرصيد";
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
            this.ButtonSZero.Size = new Size(0x115, 0x2c);
            this.ButtonSZero.TabIndex = 0x42;
            this.ButtonSZero.Text = "فرز الموردين الذين لديهم رصيد صفر";
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
            this.ButtoSDebit.Location = new Point(0x155, 15);
            this.ButtoSDebit.Margin = new Padding(3, 4, 3, 4);
            this.ButtoSDebit.Name = "ButtoSDebit";
            this.ButtoSDebit.Size = new Size(0x115, 0x2c);
            this.ButtoSDebit.TabIndex = 0x41;
            this.ButtoSDebit.Text = "فرز الموردين الذين لديهم رصيد مدين";
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
            this.ButtoSCredit.Location = new Point(0x270, 15);
            this.ButtoSCredit.Margin = new Padding(3, 4, 3, 4);
            this.ButtoSCredit.Name = "ButtoSCredit";
            this.ButtoSCredit.Size = new Size(0x158, 0x2c);
            this.ButtoSCredit.TabIndex = 0x40;
            this.ButtoSCredit.Text = "فرز الموردين الذين لديهم رصيد دائن";
            this.ButtoSCredit.UseVisualStyleBackColor = false;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[0x11];
            itemArray2[0] = this.ToolStripButtonViewAll;
            itemArray2[1] = this.ToolStripSeparator8;
            itemArray2[2] = this.ToolStripButtonAdd;
            itemArray2[3] = this.ToolStripSeparator2;
            itemArray2[4] = this.ToolStripButtonEdit;
            itemArray2[5] = this.ToolStripSeparator3;
            itemArray2[6] = this.ToolStripButtonDelete;
            itemArray2[7] = this.ToolStripSeparator4;
            itemArray2[8] = this.ToolStripButtonCard;
            itemArray2[9] = this.ToolStripSeparator5;
            itemArray2[10] = this.ToolStripButtonPrint;
            itemArray2[11] = this.ToolStripSeparator9;
            itemArray2[12] = this.ToolStrWatssApp;
            itemArray2[13] = this.ToolStripSeparator7;
            itemArray2[14] = this.ToolStripDropDownButtonEmail;
            itemArray2[15] = this.ToolStripSeparator6;
            itemArray2[0x10] = this.ToolStripButtonClose;
            this.ToolStripButtons.Items.AddRange(itemArray2);
            this.ToolStripButtons.Location = new Point(0, 0x1e2);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x70;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(6, 0x2f);
            this.ToolStripButtonAdd.Image = A.F.ImSuplierAdd;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(0x49, 0x2c);
            this.ToolStripButtonAdd.Text = "اضافة";
            this.ToolStripButtonEdit.Image = A.F.ImSuplierEdite;
            this.ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new Size(0x4a, 0x2c);
            this.ToolStripButtonEdit.Text = "تعديل";
            this.ToolStripButtonDelete.Image = A.F.ImSuplierDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(0x47, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف";
            this.ToolStripButtonCard.Image = A.F.ImSuplierCard;
            this.ToolStripButtonCard.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonCard.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonCard.Name = "ToolStripButtonCard";
            this.ToolStripButtonCard.Size = new Size(0x66, 0x2c);
            this.ToolStripButtonCard.Text = "كرت المورد";
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.A4ToolStripMenuItemPrintList };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray3);
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
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.ButSendSupWatsapp };
            this.ToolStrWatssApp.DropDownItems.AddRange(itemArray4);
            this.ToolStrWatssApp.Image = A.F.ImSWatsapp;
            this.ToolStrWatssApp.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStrWatssApp.ImageTransparentColor = Color.Magenta;
            this.ToolStrWatssApp.Name = "ToolStrWatssApp";
            this.ToolStrWatssApp.Size = new Size(0x7b, 0x2c);
            this.ToolStrWatssApp.Text = "إرسال واتساب";
            this.ButSendSupWatsapp.Image = A.F.ImSWatsapp;
            this.ButSendSupWatsapp.ImageScaling = ToolStripItemImageScaling.None;
            this.ButSendSupWatsapp.Name = "ButSendSupWatsapp";
            this.ButSendSupWatsapp.Size = new Size(0xc4, 30);
            this.ButSendSupWatsapp.Text = "رسالة للمورد المحدد";
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
            this.ToolStripMenuItemEmailOne.Text = "ارسال رسالة/اشعار للمورد المحدد";
            this.ToolStripButtonClose.Image = A.F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x2c);
            this.ToolStripButtonClose.Text = "اغلاق";
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d8, 0x22);
            this.TxTTitle.TabIndex = 110;
            this.TxTTitle.Text = "قائمة الموردين";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Panel1.BackColor = SystemColors.HighlightText;
            this.Panel1.BorderStyle = BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this.GroupBox9);
            this.Panel1.Controls.Add(this.GroupBox8);
            this.Panel1.Dock = DockStyle.Bottom;
            this.Panel1.Location = new Point(0, 0x19e);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x3d8, 0x44);
            this.Panel1.TabIndex = 0x74;
            this.GroupBox9.Controls.Add(this.TxTCredit);
            this.GroupBox9.Dock = DockStyle.Left;
            this.GroupBox9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox9.Location = new Point(200, 0);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0xb8, 0x40);
            this.GroupBox9.TabIndex = 0x6f;
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
            this.GroupBox8.Location = new Point(0, 0);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(200, 0x40);
            this.GroupBox8.TabIndex = 110;
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
            this.GV.Size = new Size(0x3d8, 0xef);
            this.GV.TabIndex = 0x1ed36ce;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3d8, 0x22a);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.CheckBoxAllCenter);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "SuplierList";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "قائمة الموردين";
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
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
            this.Panel1.ResumeLayout(false);
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
                    this.R = null;
                    this.R = this.GV.SelectedRows[0].Cells["SuplierEmail"].Value.ToString();
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

        private void D(object A, EventArgs R)
        {
            try
            {
                if (!PR.KP)
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
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNSupliersPay WHERE (SuplierFrontID = @SuplierFrontID)", this.A);
                        command.Parameters.AddWithValue("SuplierFrontID", this.GV.SelectedRows[0].Cells["SuplierID"].Value.ToString());
                        command.ExecuteNonQuery();
                        this.A.Close();
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command2 = new SqlCommand("DELETE FROM TaNNSupliers WHERE (SuplierID = @SuplierID)", this.A);
                        command2.Parameters.AddWithValue("SuplierID", this.GV.SelectedRows[0].Cells["SuplierID"].Value.ToString());
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
                this.A = "SELECT * FROM TaNNSupliers WHERE convert (DECIMAL(18, 3), SuplierBalance) = 0";
                this.TimerLoadData.Enabled = true;
            }
            else
            {
                this.A = "SELECT * FROM TaNNSupliers WHERE CenterFrontID = @CenterFrontID AND convert (DECIMAL(18, 3), SuplierBalance) = 0";
                this.TimerLoadData.Enabled = true;
            }
        }

        private void F(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    QT.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["SuplierID"].Value.ToString());
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

        private void G(object A, EventArgs R)
        {
            if (this.CheckBoxAllCenter.Checked)
            {
                this.A = "SELECT * FROM TaNNSupliers WHERE convert (DECIMAL(18, 3), SuplierBalance) < 0";
                this.TimerLoadData.Enabled = true;
            }
            else
            {
                this.A = "SELECT * FROM TaNNSupliers WHERE CenterFrontID = @CenterFrontID AND convert (DECIMAL(18, 3), SuplierBalance) < 0";
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
                    this.A = "SELECT * FROM [TaNNSupliers] WHERE (SuplierName LIKE '%' + @SuplierName + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNSupliers] WHERE (CenterFrontID = @CenterFrontID) AND (SuplierName LIKE '%' + @SuplierName + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 1)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNSupliers] WHERE (SuplierAddress LIKE '%' + @SuplierAddress + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNSupliers] WHERE (CenterFrontID = @CenterFrontID) AND (SuplierAddress LIKE '%' + @SuplierAddress + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 2)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNSupliers] WHERE (SuplierPhone LIKE '%' + @SuplierPhone + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNSupliers] WHERE (CenterFrontID = @CenterFrontID) AND (SuplierPhone LIKE '%' + @SuplierPhone + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 3)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNSupliers] WHERE (SuplierNote LIKE '%' + @SuplierNote + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNSupliers] WHERE (CenterFrontID = @CenterFrontID) AND (SuplierNote LIKE '%' + @SuplierNote + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
        }

        private void I(object A, EventArgs R)
        {
            if (!PR.KP)
            {
                Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                this.A = this.GV.CurrentRow.Index;
                RT.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["SuplierID"].Value.ToString());
                A.D.A.A.ShowDialog();
            }
        }

        private void K(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
        }

        private void L(object A, EventArgs R)
        {
            this.A = !this.CheckBoxAllCenter.Checked ? "SELECT * FROM TaNNSupliers WHERE (CenterFrontID = @CenterFrontID)" : "SELECT * FROM TaNNSupliers";
            this.TimerLoadData.Enabled = true;
        }

        private void N(object A, EventArgs R)
        {
            this.A = !this.CheckBoxAllCenter.Checked ? "SELECT * FROM TaNNSupliers WHERE (CenterFrontID = @CenterFrontID)" : "SELECT * FROM TaNNSupliers";
            this.TimerLoadData.Enabled = true;
        }

        private void O(object A, EventArgs R)
        {
            try
            {
                if (this.GV.Rows.Count <= 0)
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
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
                            string str = current.Cells["SuplierEmail"].Value.ToString();
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
            base.Dispose();
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
            if (PR.E)
            {
                A.D.A.A.ShowDialog();
            }
            if (!PR.GP)
            {
                Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                RT.A = 0;
                A.D.A.A.ShowDialog();
            }
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
                adapter.SelectCommand.Parameters.AddWithValue("SuplierName", text ?? DBNull.Value);
                string text2 = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("SuplierAddress", text2 ?? DBNull.Value);
                string text3 = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("SuplierPhone", text3 ?? DBNull.Value);
                string text4 = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("SuplierNote", text4 ?? DBNull.Value);
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
                        object[] arguments = new object[] { "SuplierBalance" };
                        if (Conversion.Val(NewLateBinding.LateIndexGet(current, arguments, null)) > 0.0)
                        {
                            object[] objArray2 = new object[] { "SuplierBalance" };
                            num2 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num2, NewLateBinding.LateIndexGet(current, objArray2, null)));
                            continue;
                        }
                        object[] objArray3 = new object[] { "SuplierBalance" };
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
                this.GV.Columns["SuplierID"].Visible = false;
                this.GV.Columns["CenterFrontID"].HeaderText = "رمز الفرع";
                this.GV.Columns["SuplierName"].HeaderText = "اسم المورد";
                this.GV.Columns["SuplierAddress"].HeaderText = "العنوان";
                this.GV.Columns["SuplierPhone"].HeaderText = "الهاتف";
                this.GV.Columns["SuplierNote"].HeaderText = "ملاحظات";
                this.GV.Columns["SuplierBalance"].HeaderText = "الرصيد";
                this.GV.Columns["SuplierDateConfigur"].HeaderText = "تاريخ اخر اجراء";
                this.GV.Columns["SuplierUserAddBy"].HeaderText = "الموظف";
                this.GV.Columns["SuplierEmail"].HeaderText = "بريد الاشعارات";
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
                        decimal num3 = new decimal(Conversion.Val(current.Cells["SuplierBalance"].Value.ToString()));
                        if (decimal.Compare(num3, decimal.Zero) > 0)
                        {
                            current.Cells["SuplierBalance"].Style.ForeColor = Color.Blue;
                        }
                        else if (decimal.Compare(num3, decimal.Zero) < 0)
                        {
                            current.Cells["SuplierBalance"].Style.ForeColor = Color.Red;
                        }
                        current.Cells["SuplierBalance"].Value = num3.ToString(PR.YR);
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
                    GT.A = this.GV.SelectedRows[0].Cells["SuplierPhone"].Value.ToString().ToString();
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

        private void T(object A, EventArgs R)
        {
            if (this.ComboBoxWat.SelectedIndex == 0)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM TaNNSupliers WHERE (SuplierDateConfigur BETWEEN @DF and @DT)";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM TaNNSupliers WHERE (CenterFrontID = @CenterFrontID) AND (SuplierDateConfigur BETWEEN @DF and @DT)";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.CheckBoxAllCenter.Checked)
            {
                this.A = "SELECT * FROM TaNNSupliers WHERE (SuplierDateConfigur NOT BETWEEN @DF and @DT)";
                this.TimerLoadData.Enabled = true;
            }
            else
            {
                this.A = "SELECT * FROM TaNNSupliers WHERE (CenterFrontID = @CenterFrontID) AND (SuplierDateConfigur NOT BETWEEN @DF and @DT)";
                this.TimerLoadData.Enabled = true;
            }
        }

        private void U(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
        }

        private void V(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                VQ vq = new VQ();
                vq.SetDataSource(this.A);
                vq.SetParameterValue("CenterName", PR.ER.ToString());
                vq.SetParameterValue("CenterSubName", PR.KR.ToString());
                vq.SetParameterValue("ParameterDeimelQ", PR.X);
                vq.SetParameterValue("ParameterDeimelS", PR.T);
                vq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (PR.NR == null)
                {
                    vq.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    vq.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                }
                if (PR.UR == null)
                {
                    vq.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    vq.SetParameterValue("CenterPhone", PR.UR.ToString());
                }
                new HR { CRViewer = { ReportSource = vq } }.ShowDialog();
                vq.Close();
                vq.Dispose();
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

        private void X(object A, EventArgs R)
        {
            if (this.CheckBoxAllCenter.Checked)
            {
                this.A = "SELECT * FROM TaNNSupliers WHERE convert (DECIMAL(18, 3), SuplierBalance) > 0";
                this.TimerLoadData.Enabled = true;
            }
            else
            {
                this.A = "SELECT * FROM TaNNSupliers WHERE CenterFrontID = @CenterFrontID AND convert (DECIMAL(18, 3), SuplierBalance) > 0";
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
                            string str = this.GV.Rows[num2].Cells["SuplierEmail"].Value.ToString();
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual CheckBox CheckBoxAllCenter
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
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
                EventHandler handler = new EventHandler(this.P);
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
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual ToolStripButton ToolStripButtonEdit
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Timer TimerFillGV
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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

        internal virtual ToolStripButton ToolStripButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual GroupBox GroupBox5
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

        internal virtual ComboBox ComboBoxSerachWat
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual Button ButtonSZero
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual Button ButtoSCredit
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual ToolStrip ToolStripButtons
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripButton ToolStripButtonViewAll
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
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

        internal virtual ToolStripSeparator ToolStripSeparator8
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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

        internal virtual Panel Panel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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
            set
            {
                EventHandler handler = new EventHandler(this.Z);
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

        internal virtual ToolStripMenuItem ToolStripMenuItemEmilChek
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

        internal virtual ToolStripSeparator ToolStripSeparator11
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

        internal virtual ToolStripSeparator ToolStripSeparator9
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
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

        internal virtual ToolStripMenuItem ButSendSupWatsapp
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

