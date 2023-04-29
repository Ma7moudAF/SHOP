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
    public class GD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage1"), CompilerGenerated]
        private TabPage A;
        [AccessedThroughProperty("GroupBox23"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("UserAddBy")]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2")]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("InvPurchID")]
        private Label P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox8")]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ComboBoxSuplier"), CompilerGenerated]
        private ComboBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3")]
        private GroupBox Q;
        [AccessedThroughProperty("InvPurchNumber"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [AccessedThroughProperty("InvPurchType"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox R;
        [AccessedThroughProperty("GroupBox20"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchMonRod"), CompilerGenerated]
        private Label I;
        [AccessedThroughProperty("GroupBox19"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [AccessedThroughProperty("InvPurchMonDem"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [AccessedThroughProperty("GroupBox21"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [CompilerGenerated, AccessedThroughProperty("InvPurchNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        [CompilerGenerated, AccessedThroughProperty("GroupBox18"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [AccessedThroughProperty("InvPurchMonBak"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox7")]
        private GroupBox X;
        [CompilerGenerated, AccessedThroughProperty("GroupBox17"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox G;
        [AccessedThroughProperty("InvPurchMonPay"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label T;
        [AccessedThroughProperty("GroupBox5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox E;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchStatus")]
        private ComboBox P;
        [AccessedThroughProperty("GroupBox22"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox K;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchOtherCuru")]
        private Label X;
        [AccessedThroughProperty("GroupBox16"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox U;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchMonBas"), CompilerGenerated]
        private Label G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox6")]
        private GroupBox L;
        [CompilerGenerated, AccessedThroughProperty("InvPurchPayType"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox9"), CompilerGenerated]
        private GroupBox N;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchItems"), CompilerGenerated]
        private Label E;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox14")]
        private GroupBox V;
        [AccessedThroughProperty("InvPurchDarMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label K;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox13")]
        private GroupBox Y;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchDarVal"), CompilerGenerated]
        private Label U;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox15")]
        private GroupBox O;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchTotalNET")]
        private Label L;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox10")]
        private GroupBox B;
        [AccessedThroughProperty("InvPurchTotalAmount"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label N;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox11")]
        private GroupBox S;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchDisMaWi")]
        private Label V;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox12")]
        private GroupBox Z;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("InvPurchDisVal"), CompilerGenerated]
        private Label Y;
        [AccessedThroughProperty("TabPage2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label O;
        [AccessedThroughProperty("ToolStripButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonAdd"), CompilerGenerated]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonDelete"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonAdd")]
        private Button A;
        [AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView A;
        [AccessedThroughProperty("InvPurchDateTime"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker A;
        [AccessedThroughProperty("TimerLoadData"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimersStartUp")]
        private Timer R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerFillGV"), CompilerGenerated]
        private Timer P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripProgressBar1")]
        private ToolStripProgressBar A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTotals"), CompilerGenerated]
        private ToolStripLabel A;
        [CompilerGenerated, AccessedThroughProperty("TXTTotalCost"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated]
        private ToolStripSeparator P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripLabel2")]
        private ToolStripLabel P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TXTTotalSale")]
        private ToolStripLabel Q;
        private SqlConnection A;
        public static int A;

        public GD()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage2 = new TabPage();
            this.GV = new DataGridView();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.TabPage1 = new TabPage();
            this.ButtonAdd = new Button();
            this.GroupBox23 = new GroupBox();
            this.UserAddBy = new Label();
            this.GroupBox2 = new GroupBox();
            this.InvPurchID = new Label();
            this.GroupBox8 = new GroupBox();
            this.ComboBoxSuplier = new ComboBox();
            this.GroupBox3 = new GroupBox();
            this.InvPurchNumber = new Label();
            this.GroupBox4 = new GroupBox();
            this.InvPurchType = new ComboBox();
            this.GroupBox20 = new GroupBox();
            this.InvPurchMonRod = new Label();
            this.GroupBox19 = new GroupBox();
            this.InvPurchMonDem = new Label();
            this.GroupBox21 = new GroupBox();
            this.InvPurchNote = new Label();
            this.GroupBox18 = new GroupBox();
            this.InvPurchMonBak = new Label();
            this.GroupBox7 = new GroupBox();
            this.InvPurchDateTime = new DateTimePicker();
            this.GroupBox17 = new GroupBox();
            this.InvPurchMonPay = new Label();
            this.GroupBox5 = new GroupBox();
            this.InvPurchStatus = new ComboBox();
            this.GroupBox22 = new GroupBox();
            this.InvPurchOtherCuru = new Label();
            this.GroupBox16 = new GroupBox();
            this.InvPurchMonBas = new Label();
            this.GroupBox6 = new GroupBox();
            this.InvPurchPayType = new ComboBox();
            this.GroupBox9 = new GroupBox();
            this.InvPurchItems = new Label();
            this.GroupBox14 = new GroupBox();
            this.InvPurchDarMiWi = new Label();
            this.GroupBox13 = new GroupBox();
            this.InvPurchDarVal = new Label();
            this.GroupBox15 = new GroupBox();
            this.InvPurchTotalNET = new Label();
            this.GroupBox10 = new GroupBox();
            this.InvPurchTotalAmount = new Label();
            this.GroupBox11 = new GroupBox();
            this.InvPurchDisMaWi = new Label();
            this.GroupBox12 = new GroupBox();
            this.InvPurchDisVal = new Label();
            this.Label1 = new Label();
            this.ButtonClose = new Button();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TimerFillGV = new Timer(this.A);
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.TxTTotals = new ToolStripLabel();
            this.TXTTotalCost = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.ToolStripLabel2 = new ToolStripLabel();
            this.TXTTotalSale = new ToolStripLabel();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.ToolStripButtons.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox23.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox20.SuspendLayout();
            this.GroupBox19.SuspendLayout();
            this.GroupBox21.SuspendLayout();
            this.GroupBox18.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox22.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d8, 0x22);
            this.TxTTitle.TabIndex = 0x74;
            this.TxTTitle.Text = "تفاصيل الفاتورة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = DockStyle.Fill;
            this.TabControl1.Location = new Point(0, 0x42);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 0x201);
            this.TabControl1.TabIndex = 0x7a;
            this.TabPage2.Controls.Add(this.GV);
            this.TabPage2.Controls.Add(this.ToolStripButtons);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x3d0, 0x1e4);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "المواد/ الاصناف";
            this.TabPage2.UseVisualStyleBackColor = true;
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
            this.GV.Location = new Point(3, 3);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(970, 0x1af);
            this.GV.TabIndex = 0x1ed36ce;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonAdd, this.ToolStripSeparator2, this.ToolStripButtonDelete, this.ToolStripSeparator4 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(3, 0x1b2);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(970, 0x2f);
            this.ToolStripButtons.TabIndex = 0x75;
            this.ToolStripButtonAdd.Image = A.F.ImAdd;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(0x90, 0x2c);
            this.ToolStripButtonAdd.Text = "إضافة مواد للفاتورة";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
            this.ToolStripButtonDelete.Image = A.F.ImDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(0x99, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف المادة المحددة";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x2f);
            this.TabPage1.Controls.Add(this.ButtonAdd);
            this.TabPage1.Controls.Add(this.GroupBox23);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox8);
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.GroupBox4);
            this.TabPage1.Controls.Add(this.GroupBox20);
            this.TabPage1.Controls.Add(this.GroupBox19);
            this.TabPage1.Controls.Add(this.GroupBox21);
            this.TabPage1.Controls.Add(this.GroupBox18);
            this.TabPage1.Controls.Add(this.GroupBox7);
            this.TabPage1.Controls.Add(this.GroupBox17);
            this.TabPage1.Controls.Add(this.GroupBox5);
            this.TabPage1.Controls.Add(this.GroupBox22);
            this.TabPage1.Controls.Add(this.GroupBox16);
            this.TabPage1.Controls.Add(this.GroupBox6);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.GroupBox14);
            this.TabPage1.Controls.Add(this.GroupBox13);
            this.TabPage1.Controls.Add(this.GroupBox15);
            this.TabPage1.Controls.Add(this.GroupBox10);
            this.TabPage1.Controls.Add(this.GroupBox11);
            this.TabPage1.Controls.Add(this.GroupBox12);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3d0, 0x1e4);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "تفاصيل الفاتورة";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtonAdd.BackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Flat;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.Image = A.F.ImCard;
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(13, 0x1a3);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0x3b3, 60);
            this.ButtonAdd.TabIndex = 30;
            this.ButtonAdd.Text = "إدارة وإدخال المواد الفاتورة";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.GroupBox23.Controls.Add(this.UserAddBy);
            this.GroupBox23.Location = new Point(14, 190);
            this.GroupBox23.Name = "GroupBox23";
            this.GroupBox23.Size = new Size(0x9b, 50);
            this.GroupBox23.TabIndex = 0x11;
            this.GroupBox23.TabStop = false;
            this.GroupBox23.Text = "الموظف";
            this.UserAddBy.Dock = DockStyle.Fill;
            this.UserAddBy.Location = new Point(3, 0x13);
            this.UserAddBy.Name = "UserAddBy";
            this.UserAddBy.RightToLeft = RightToLeft.No;
            this.UserAddBy.Size = new Size(0x95, 0x1c);
            this.UserAddBy.TabIndex = 0;
            this.UserAddBy.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox2.Controls.Add(this.InvPurchID);
            this.GroupBox2.Location = new Point(0x323, 0x16);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x9b, 50);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "ترميز الفاتورة";
            this.InvPurchID.Dock = DockStyle.Fill;
            this.InvPurchID.Location = new Point(3, 0x13);
            this.InvPurchID.Name = "InvPurchID";
            this.InvPurchID.RightToLeft = RightToLeft.No;
            this.InvPurchID.Size = new Size(0x95, 0x1c);
            this.InvPurchID.TabIndex = 0;
            this.InvPurchID.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox8.Controls.Add(this.ComboBoxSuplier);
            this.GroupBox8.Location = new Point(12, 0x4e);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x273, 50);
            this.GroupBox8.TabIndex = 2;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "المورد";
            this.ComboBoxSuplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ComboBoxSuplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.ComboBoxSuplier.Dock = DockStyle.Fill;
            this.ComboBoxSuplier.Enabled = false;
            this.ComboBoxSuplier.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxSuplier.FormattingEnabled = true;
            this.ComboBoxSuplier.IntegralHeight = false;
            this.ComboBoxSuplier.Location = new Point(3, 0x13);
            this.ComboBoxSuplier.Name = "ComboBoxSuplier";
            this.ComboBoxSuplier.Size = new Size(0x26d, 0x18);
            this.ComboBoxSuplier.TabIndex = 0x45;
            this.GroupBox3.Controls.Add(this.InvPurchNumber);
            this.GroupBox3.Location = new Point(0x285, 0x16);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x9b, 50);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم الفاتورة";
            this.InvPurchNumber.Dock = DockStyle.Fill;
            this.InvPurchNumber.Location = new Point(3, 0x13);
            this.InvPurchNumber.Name = "InvPurchNumber";
            this.InvPurchNumber.RightToLeft = RightToLeft.No;
            this.InvPurchNumber.Size = new Size(0x95, 0x1c);
            this.InvPurchNumber.TabIndex = 0;
            this.InvPurchNumber.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox4.Controls.Add(this.InvPurchType);
            this.GroupBox4.Location = new Point(0x1bb, 0x16);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0xc9, 50);
            this.GroupBox4.TabIndex = 1;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "نوع الفاتورة";
            this.InvPurchType.Dock = DockStyle.Fill;
            this.InvPurchType.Enabled = false;
            this.InvPurchType.FormattingEnabled = true;
            object[] items = new object[] { "فاتورة مشتريات", "مرتجع مشتريات" };
            this.InvPurchType.Items.AddRange(items);
            this.InvPurchType.Location = new Point(3, 0x13);
            this.InvPurchType.Name = "InvPurchType";
            this.InvPurchType.Size = new Size(0xc3, 0x18);
            this.InvPurchType.TabIndex = 0x2d;
            this.GroupBox20.Controls.Add(this.InvPurchMonRod);
            this.GroupBox20.Location = new Point(0xad, 190);
            this.GroupBox20.Name = "GroupBox20";
            this.GroupBox20.Size = new Size(0x9b, 50);
            this.GroupBox20.TabIndex = 14;
            this.GroupBox20.TabStop = false;
            this.GroupBox20.Text = "مبلغ رصيد مدور";
            this.InvPurchMonRod.Dock = DockStyle.Fill;
            this.InvPurchMonRod.Location = new Point(3, 0x13);
            this.InvPurchMonRod.Name = "InvPurchMonRod";
            this.InvPurchMonRod.RightToLeft = RightToLeft.No;
            this.InvPurchMonRod.Size = new Size(0x95, 0x1c);
            this.InvPurchMonRod.TabIndex = 0;
            this.InvPurchMonRod.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox19.Controls.Add(this.InvPurchMonDem);
            this.GroupBox19.Location = new Point(0x14c, 190);
            this.GroupBox19.Name = "GroupBox19";
            this.GroupBox19.Size = new Size(0x9b, 50);
            this.GroupBox19.TabIndex = 13;
            this.GroupBox19.TabStop = false;
            this.GroupBox19.Text = "مبلغ الذمم";
            this.InvPurchMonDem.Dock = DockStyle.Fill;
            this.InvPurchMonDem.Location = new Point(3, 0x13);
            this.InvPurchMonDem.Name = "InvPurchMonDem";
            this.InvPurchMonDem.RightToLeft = RightToLeft.No;
            this.InvPurchMonDem.Size = new Size(0x95, 0x1c);
            this.InvPurchMonDem.TabIndex = 0;
            this.InvPurchMonDem.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox21.Controls.Add(this.InvPurchNote);
            this.GroupBox21.Location = new Point(13, 0xf6);
            this.GroupBox21.Name = "GroupBox21";
            this.GroupBox21.Size = new Size(0x1d8, 0xa6);
            this.GroupBox21.TabIndex = 15;
            this.GroupBox21.TabStop = false;
            this.GroupBox21.Text = "ملاحظات";
            this.InvPurchNote.Dock = DockStyle.Fill;
            this.InvPurchNote.Location = new Point(3, 0x13);
            this.InvPurchNote.Name = "InvPurchNote";
            this.InvPurchNote.RightToLeft = RightToLeft.No;
            this.InvPurchNote.Size = new Size(0x1d2, 0x90);
            this.InvPurchNote.TabIndex = 0;
            this.InvPurchNote.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox18.Controls.Add(this.InvPurchMonBak);
            this.GroupBox18.Location = new Point(490, 190);
            this.GroupBox18.Name = "GroupBox18";
            this.GroupBox18.Size = new Size(0x9b, 50);
            this.GroupBox18.TabIndex = 12;
            this.GroupBox18.TabStop = false;
            this.GroupBox18.Text = "المبلغ المرتجع";
            this.InvPurchMonBak.Dock = DockStyle.Fill;
            this.InvPurchMonBak.Location = new Point(3, 0x13);
            this.InvPurchMonBak.Name = "InvPurchMonBak";
            this.InvPurchMonBak.RightToLeft = RightToLeft.No;
            this.InvPurchMonBak.Size = new Size(0x95, 0x1c);
            this.InvPurchMonBak.TabIndex = 0;
            this.InvPurchMonBak.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox7.Controls.Add(this.InvPurchDateTime);
            this.GroupBox7.Location = new Point(0xac, 0x16);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x10c, 50);
            this.GroupBox7.TabIndex = 2;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "التاريخ والوقت";
            this.InvPurchDateTime.CustomFormat = "yyyy/MM/dd";
            this.InvPurchDateTime.Dock = DockStyle.Fill;
            this.InvPurchDateTime.Enabled = false;
            this.InvPurchDateTime.Format = DateTimePickerFormat.Custom;
            this.InvPurchDateTime.Location = new Point(3, 0x13);
            this.InvPurchDateTime.Name = "InvPurchDateTime";
            this.InvPurchDateTime.RightToLeft = RightToLeft.No;
            this.InvPurchDateTime.Size = new Size(0x106, 0x17);
            this.InvPurchDateTime.TabIndex = 3;
            this.GroupBox17.Controls.Add(this.InvPurchMonPay);
            this.GroupBox17.Location = new Point(0x288, 190);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(0x9b, 50);
            this.GroupBox17.TabIndex = 11;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "المبلغ المسدد الفعلي";
            this.InvPurchMonPay.Dock = DockStyle.Fill;
            this.InvPurchMonPay.Location = new Point(3, 0x13);
            this.InvPurchMonPay.Name = "InvPurchMonPay";
            this.InvPurchMonPay.RightToLeft = RightToLeft.No;
            this.InvPurchMonPay.Size = new Size(0x95, 0x1c);
            this.InvPurchMonPay.TabIndex = 0;
            this.InvPurchMonPay.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox5.Controls.Add(this.InvPurchStatus);
            this.GroupBox5.Location = new Point(14, 0x16);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x9b, 50);
            this.GroupBox5.TabIndex = 1;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "الحالة";
            this.InvPurchStatus.Dock = DockStyle.Fill;
            this.InvPurchStatus.Enabled = false;
            this.InvPurchStatus.FormattingEnabled = true;
            object[] objArray2 = new object[] { "مكتملة", "معلقة", "قيد التعديل", "معدلة" };
            this.InvPurchStatus.Items.AddRange(objArray2);
            this.InvPurchStatus.Location = new Point(3, 0x13);
            this.InvPurchStatus.Name = "InvPurchStatus";
            this.InvPurchStatus.Size = new Size(0x95, 0x18);
            this.InvPurchStatus.TabIndex = 0x1ed36cd;
            this.GroupBox22.Controls.Add(this.InvPurchOtherCuru);
            this.GroupBox22.Location = new Point(0x1e8, 0xf6);
            this.GroupBox22.Name = "GroupBox22";
            this.GroupBox22.Size = new Size(0x1d8, 0xa6);
            this.GroupBox22.TabIndex = 0x10;
            this.GroupBox22.TabStop = false;
            this.GroupBox22.Text = "عملات اخرى";
            this.InvPurchOtherCuru.Dock = DockStyle.Fill;
            this.InvPurchOtherCuru.Location = new Point(3, 0x13);
            this.InvPurchOtherCuru.Name = "InvPurchOtherCuru";
            this.InvPurchOtherCuru.RightToLeft = RightToLeft.No;
            this.InvPurchOtherCuru.Size = new Size(0x1d2, 0x90);
            this.InvPurchOtherCuru.TabIndex = 0;
            this.InvPurchOtherCuru.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox16.Controls.Add(this.InvPurchMonBas);
            this.GroupBox16.Location = new Point(0x326, 190);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(0x9b, 50);
            this.GroupBox16.TabIndex = 10;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "المبلغ المدفوع المستلم";
            this.InvPurchMonBas.Dock = DockStyle.Fill;
            this.InvPurchMonBas.Location = new Point(3, 0x13);
            this.InvPurchMonBas.Name = "InvPurchMonBas";
            this.InvPurchMonBas.RightToLeft = RightToLeft.No;
            this.InvPurchMonBas.Size = new Size(0x95, 0x1c);
            this.InvPurchMonBas.TabIndex = 0;
            this.InvPurchMonBas.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox6.Controls.Add(this.InvPurchPayType);
            this.GroupBox6.Location = new Point(0x323, 0x4e);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x9b, 50);
            this.GroupBox6.TabIndex = 2;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "طريقة الدفع";
            this.InvPurchPayType.Dock = DockStyle.Fill;
            this.InvPurchPayType.Enabled = false;
            this.InvPurchPayType.FormattingEnabled = true;
            object[] objArray3 = new object[] { "نقدا", "ذمم", "شبكة", "تحويل", "الرصيد المدور", "شيك", "إئتمان" };
            this.InvPurchPayType.Items.AddRange(objArray3);
            this.InvPurchPayType.Location = new Point(3, 0x13);
            this.InvPurchPayType.Name = "InvPurchPayType";
            this.InvPurchPayType.Size = new Size(0x95, 0x18);
            this.InvPurchPayType.TabIndex = 0x1ed36cd;
            this.GroupBox9.Controls.Add(this.InvPurchItems);
            this.GroupBox9.Location = new Point(0x285, 0x4e);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x9b, 50);
            this.GroupBox9.TabIndex = 3;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "عدد المواد";
            this.InvPurchItems.Dock = DockStyle.Fill;
            this.InvPurchItems.Location = new Point(3, 0x13);
            this.InvPurchItems.Name = "InvPurchItems";
            this.InvPurchItems.RightToLeft = RightToLeft.No;
            this.InvPurchItems.Size = new Size(0x95, 0x1c);
            this.InvPurchItems.TabIndex = 0;
            this.InvPurchItems.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox14.Controls.Add(this.InvPurchDarMiWi);
            this.GroupBox14.Location = new Point(0x14b, 0x86);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0x9b, 50);
            this.GroupBox14.TabIndex = 7;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "ضريبة %";
            this.InvPurchDarMiWi.Dock = DockStyle.Fill;
            this.InvPurchDarMiWi.Location = new Point(3, 0x13);
            this.InvPurchDarMiWi.Name = "InvPurchDarMiWi";
            this.InvPurchDarMiWi.RightToLeft = RightToLeft.No;
            this.InvPurchDarMiWi.Size = new Size(0x95, 0x1c);
            this.InvPurchDarMiWi.TabIndex = 0;
            this.InvPurchDarMiWi.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox13.Controls.Add(this.InvPurchDarVal);
            this.GroupBox13.Location = new Point(0xad, 0x86);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x9b, 50);
            this.GroupBox13.TabIndex = 8;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "مجموع الضريبة";
            this.InvPurchDarVal.Dock = DockStyle.Fill;
            this.InvPurchDarVal.Location = new Point(3, 0x13);
            this.InvPurchDarVal.Name = "InvPurchDarVal";
            this.InvPurchDarVal.RightToLeft = RightToLeft.No;
            this.InvPurchDarVal.Size = new Size(0x95, 0x1c);
            this.InvPurchDarVal.TabIndex = 0;
            this.InvPurchDarVal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox15.Controls.Add(this.InvPurchTotalNET);
            this.GroupBox15.Location = new Point(14, 0x86);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x9b, 50);
            this.GroupBox15.TabIndex = 9;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "صافي مبلغ الفاتورة";
            this.InvPurchTotalNET.Dock = DockStyle.Fill;
            this.InvPurchTotalNET.Location = new Point(3, 0x13);
            this.InvPurchTotalNET.Name = "InvPurchTotalNET";
            this.InvPurchTotalNET.RightToLeft = RightToLeft.No;
            this.InvPurchTotalNET.Size = new Size(0x95, 0x1c);
            this.InvPurchTotalNET.TabIndex = 0;
            this.InvPurchTotalNET.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox10.Controls.Add(this.InvPurchTotalAmount);
            this.GroupBox10.Location = new Point(0x325, 0x86);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x9b, 50);
            this.GroupBox10.TabIndex = 4;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "مبلغ الفاتورة";
            this.InvPurchTotalAmount.Dock = DockStyle.Fill;
            this.InvPurchTotalAmount.Location = new Point(3, 0x13);
            this.InvPurchTotalAmount.Name = "InvPurchTotalAmount";
            this.InvPurchTotalAmount.RightToLeft = RightToLeft.No;
            this.InvPurchTotalAmount.Size = new Size(0x95, 0x1c);
            this.InvPurchTotalAmount.TabIndex = 0;
            this.InvPurchTotalAmount.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox11.Controls.Add(this.InvPurchDisMaWi);
            this.GroupBox11.Location = new Point(0x287, 0x86);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x9b, 50);
            this.GroupBox11.TabIndex = 5;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "خصم %";
            this.InvPurchDisMaWi.Dock = DockStyle.Fill;
            this.InvPurchDisMaWi.Location = new Point(3, 0x13);
            this.InvPurchDisMaWi.Name = "InvPurchDisMaWi";
            this.InvPurchDisMaWi.RightToLeft = RightToLeft.No;
            this.InvPurchDisMaWi.Size = new Size(0x95, 0x1c);
            this.InvPurchDisMaWi.TabIndex = 0;
            this.InvPurchDisMaWi.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox12.Controls.Add(this.InvPurchDisVal);
            this.GroupBox12.Location = new Point(0x1e9, 0x86);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x9b, 50);
            this.GroupBox12.TabIndex = 6;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "مجموع الخصم";
            this.InvPurchDisVal.Dock = DockStyle.Fill;
            this.InvPurchDisVal.Location = new Point(3, 0x13);
            this.InvPurchDisVal.Name = "InvPurchDisVal";
            this.InvPurchDisVal.RightToLeft = RightToLeft.No;
            this.InvPurchDisVal.Size = new Size(0x95, 0x1c);
            this.InvPurchDisVal.TabIndex = 0;
            this.InvPurchDisVal.TextAlign = ContentAlignment.MiddleCenter;
            this.Label1.BackColor = Color.WhiteSmoke;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.Label1.Location = new Point(0, 0x22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x3d8, 0x20);
            this.Label1.TabIndex = 0x7b;
            this.Label1.Text = "*ملاحظة: انت غير ملزم بأدخال مواد فاتورة المشتريات يمكنك فقط إدارة الكميات في المستودع مباشرة ان كانت مدخلة مسبقاً.";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0, 0x25c);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x3d8, 0x2c);
            this.ButtonClose.TabIndex = 0x7c;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.ToolStripProgressBar1, this.TxTTotals, this.TXTTotalCost, this.ToolStripSeparator1, this.ToolStripLabel2, this.TXTTotalSale };
            this.ToolStripStatus.Items.AddRange(itemArray2);
            this.ToolStripStatus.Location = new Point(0, 0x243);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x7d;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.TxTTotals.ForeColor = Color.Black;
            this.TxTTotals.Name = "TxTTotals";
            this.TxTTotals.Size = new Size(0xab, 0x16);
            this.TxTTotals.Text = "مجموع سعر التكلفة X الكمية:";
            this.TXTTotalCost.ForeColor = Color.Green;
            this.TXTTotalCost.Name = "TXTTotalCost";
            this.TXTTotalCost.Size = new Size(15, 0x16);
            this.TXTTotalCost.Text = "0";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new Size(0x9e, 0x16);
            this.ToolStripLabel2.Text = "مجموع سعر البيع X الكمية:";
            this.TXTTotalSale.ForeColor = Color.Green;
            this.TXTTotalSale.Name = "TXTTotalSale";
            this.TXTTotalSale.Size = new Size(15, 0x16);
            this.TXTTotalSale.Text = "0";
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3d8, 0x288);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.ButtonClose);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "InvoicePurchCard";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الفاتورة";
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.GroupBox23.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox20.ResumeLayout(false);
            this.GroupBox19.ResumeLayout(false);
            this.GroupBox21.ResumeLayout(false);
            this.GroupBox18.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox22.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
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

        private void F(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
        }

        private void H(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
            this.P();
        }

        private void I(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
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
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT * FROM [TaNNInvPurchItems] WHERE ([InvPurchIDFrontID] = @InvPurchIDFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("InvPurchIDFrontID", A);
                adapter.Fill(dataTable);
                this.A.Close();
                this.GV.DataSource = dataTable;
                this.GV.Refresh();
                this.GV.Columns["MaterialPurchID"].Visible = false;
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["InvPurchIDFrontID"].Visible = false;
                this.GV.Columns["InvPurchType"].HeaderText = "نوع الفاتورة";
                this.GV.Columns["SuplierFrontID"].Visible = false;
                this.GV.Columns["InvPurchPurchDate"].Visible = false;
                this.GV.Columns["PurchMaterialBarCode"].HeaderText = "باركود/رقم";
                this.GV.Columns["PurchMaterialName"].HeaderText = "المادة/ الوصف";
                this.GV.Columns["PurchMaterialQuantity"].HeaderText = "الكمية";
                this.GV.Columns["PurchMaterialUnit"].HeaderText = "الوحدة";
                this.GV.Columns["PurchMaterialPricCost"].HeaderText = "سعر التكلفة الافرادي";
                this.GV.Columns["PurchMaterialDisMiWi"].HeaderText = "الخصم %";
                this.GV.Columns["PurchMaterialDisVAL"].HeaderText = "مبلغ الخصم";
                this.GV.Columns["PurchMaterialDarMiWi"].HeaderText = "الضربية %";
                this.GV.Columns["PurchMaterialDarVAL"].HeaderText = "مبلغ الضريبة";
                this.GV.Columns["PurchMaterialPricTotal"].HeaderText = "مجموع سعر التكلفة";
                this.GV.Columns["PurchMaterialSalePrice"].HeaderText = "سعر البيع الافرادي";
                this.GV.Columns["PurchMaterialExpDate"].HeaderText = "تاريخ الانتهاء";
                this.GV.Columns["PurchMaterialNote"].HeaderText = "ملاحظات";
                this.GV.Columns["PurchIsApplyStor"].HeaderText = "مطبقة في المستودع";
                this.GV.Columns["PurchUserAddBy"].Visible = false;
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                        decimal num = new decimal(Conversion.Val(current.Cells["PurchMaterialQuantity"].Value.ToString()));
                        decimal num2 = new decimal(Conversion.Val(current.Cells["PurchMaterialPricCost"].Value.ToString()));
                        decimal num3 = new decimal(Conversion.Val(current.Cells["PurchMaterialDisVAL"].Value.ToString()));
                        decimal num4 = new decimal(Conversion.Val(current.Cells["PurchMaterialDarVAL"].Value.ToString()));
                        decimal num5 = new decimal(Conversion.Val(current.Cells["PurchMaterialPricTotal"].Value.ToString()));
                        decimal num6 = new decimal(Conversion.Val(current.Cells["PurchMaterialSalePrice"].Value.ToString()));
                        current.Cells["PurchMaterialQuantity"].Value = num.ToString(PR.BR);
                        current.Cells["PurchMaterialPricCost"].Value = num2.ToString(PR.YR);
                        current.Cells["PurchMaterialDisVAL"].Value = num3.ToString(PR.YR);
                        current.Cells["PurchMaterialDarVAL"].Value = num4.ToString(PR.YR);
                        current.Cells["PurchMaterialPricTotal"].Value = num5.ToString(PR.YR);
                        current.Cells["PurchMaterialSalePrice"].Value = num6.ToString(PR.YR);
                        decimal num7 = new decimal(Conversion.Val(current.Cells["InvPurchType"].Value.ToString()));
                        if (decimal.Compare(num7, decimal.Zero) == 0)
                        {
                            current.Cells["InvPurchType"].Value = "فاتورة مشتريات";
                            continue;
                        }
                        if (decimal.Compare(num7, decimal.One) == 0)
                        {
                            current.Cells["InvPurchType"].Value = "مرتجع مشتريات";
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
                this.TxTTitle.Text = this.Text;
                this.TxTTitle.ForeColor = Color.DarkGreen;
                this.TxTTitle.Font = new Font("Tahoma", 12f);
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

        private void P(object A, EventArgs R)
        {
            A.D.A.A.TimerLoadData.Enabled = true;
            base.Dispose();
        }

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
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
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNInvPurchItems WHERE (MaterialPurchID = @MaterialPurchID)", this.A);
                        command.Parameters.AddWithValue("MaterialPurchID", this.GV.SelectedRows[0].Cells["MaterialPurchID"].Value.ToString());
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

        public void R()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT [SuplierID], [SuplierName], [SuplierBalance] FROM TaNNSupliers";
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
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable table2 = new DataTable();
                string str2 = "SELECT TOP(1) * FROM [TaNNInvPurch] WHERE ([InvPurchID] = @InvPurchID)";
                table2.Clear();
                SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                adapter2.SelectCommand.Parameters.AddWithValue("InvPurchID", A);
                adapter2.Fill(table2);
                this.A.Close();
                if (table2.Rows.Count > 0)
                {
                    this.InvPurchID.Text = table2.Rows[0]["InvPurchID"].ToString();
                    this.ComboBoxSuplier.SelectedValue = table2.Rows[0]["SuplierFrontID"].ToString();
                    this.InvPurchNumber.Text = table2.Rows[0]["InvPurchNumber"].ToString();
                    this.InvPurchDateTime.Value = Conversions.ToDate(table2.Rows[0]["InvPurchDateTime"].ToString());
                    this.InvPurchType.SelectedIndex = Conversions.ToInteger(table2.Rows[0]["InvPurchType"].ToString());
                    this.InvPurchStatus.SelectedIndex = Conversions.ToInteger(table2.Rows[0]["InvPurchStatus"].ToString());
                    this.InvPurchPayType.SelectedIndex = Conversions.ToInteger(table2.Rows[0]["InvPurchPayType"].ToString());
                    this.InvPurchItems.Text = table2.Rows[0]["InvPurchItems"].ToString();
                    this.InvPurchTotalAmount.Text = table2.Rows[0]["InvPurchTotalAmount"].ToString();
                    this.InvPurchDisMaWi.Text = table2.Rows[0]["InvPurchDisMaWi"].ToString();
                    this.InvPurchDisVal.Text = table2.Rows[0]["InvPurchDisVal"].ToString();
                    this.InvPurchDarMiWi.Text = table2.Rows[0]["InvPurchDarMiWi"].ToString();
                    this.InvPurchDarVal.Text = table2.Rows[0]["InvPurchDarVal"].ToString();
                    this.InvPurchTotalNET.Text = table2.Rows[0]["InvPurchTotalNET"].ToString();
                    this.InvPurchMonBas.Text = table2.Rows[0]["InvPurchMonBas"].ToString();
                    this.InvPurchMonPay.Text = table2.Rows[0]["InvPurchMonPay"].ToString();
                    this.InvPurchMonBak.Text = table2.Rows[0]["InvPurchMonBak"].ToString();
                    this.InvPurchMonDem.Text = table2.Rows[0]["InvPurchMonDem"].ToString();
                    this.InvPurchMonRod.Text = table2.Rows[0]["InvPurchMonRod"].ToString();
                    this.InvPurchNote.Text = table2.Rows[0]["InvPurchNote"].ToString();
                    this.UserAddBy.Text = table2.Rows[0]["InvPurchUserAddBy"].ToString();
                    this.InvPurchOtherCuru.Text = table2.Rows[0]["InvPurchOtherCuru"].ToString();
                }
                decimal num = new decimal(Conversion.Val(this.InvPurchTotalAmount.Text.Replace(",", "")));
                decimal num2 = new decimal(Conversion.Val(this.InvPurchDisVal.Text.Replace(",", "")));
                decimal num3 = new decimal(Conversion.Val(this.InvPurchDarVal.Text.Replace(",", "")));
                decimal num4 = new decimal(Conversion.Val(this.InvPurchTotalNET.Text.Replace(",", "")));
                decimal num5 = new decimal(Conversion.Val(this.InvPurchMonBas.Text.Replace(",", "")));
                decimal num6 = new decimal(Conversion.Val(this.InvPurchMonPay.Text.Replace(",", "")));
                decimal num7 = new decimal(Conversion.Val(this.InvPurchMonBak.Text.Replace(",", "")));
                decimal num8 = new decimal(Conversion.Val(this.InvPurchMonDem.Text.Replace(",", "")));
                decimal num9 = new decimal(Conversion.Val(this.InvPurchMonRod.Text.Replace(",", "")));
                this.InvPurchTotalAmount.Text = num.ToString(PR.YR);
                this.InvPurchDisVal.Text = num2.ToString(PR.YR);
                this.InvPurchDarVal.Text = num3.ToString(PR.YR);
                this.InvPurchTotalNET.Text = num4.ToString(PR.YR);
                this.InvPurchMonBas.Text = num5.ToString(PR.YR);
                this.InvPurchMonPay.Text = num6.ToString(PR.YR);
                this.InvPurchMonBak.Text = num7.ToString(PR.YR);
                this.InvPurchMonDem.Text = num8.ToString(PR.YR);
                this.InvPurchMonRod.Text = num9.ToString(PR.YR);
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
            this.TabControl1.SelectedTab = this.TabPage2;
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

        internal virtual GroupBox GroupBox23
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label UserAddBy
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

        internal virtual Label InvPurchID
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual ComboBox ComboBoxSuplier
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

        internal virtual Label InvPurchNumber
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

        internal virtual ComboBox InvPurchType
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox20
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label InvPurchMonRod
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox19
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label InvPurchMonDem
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBox21
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Label InvPurchNote
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual GroupBox GroupBox18
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Label InvPurchMonBak
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual Label InvPurchMonPay
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual ComboBox InvPurchStatus
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox22
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual Label InvPurchOtherCuru
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual Label InvPurchMonBas
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual ComboBox InvPurchPayType
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
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual Label InvPurchItems
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual Label InvPurchDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual Label InvPurchDarVal
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual Label InvPurchTotalNET
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual Label InvPurchTotalAmount
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual Label InvPurchDisMaWi
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual Label InvPurchDisVal
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
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

        internal virtual ToolStripButton ToolStripButtonDelete
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonAdd
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

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DateTimePicker InvPurchDateTime
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
                EventHandler handler = new EventHandler(this.F);
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
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual ToolStripLabel TxTTotals
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripLabel TXTTotalCost
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

        internal virtual ToolStripLabel ToolStripLabel2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripLabel TXTTotalSale
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }
    }
}

