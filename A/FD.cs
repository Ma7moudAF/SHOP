namespace A
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class FD : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Panel2"), CompilerGenerated]
        private Panel A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSortDate"), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripButtons")]
        private ToolStrip A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator6")]
        private ToolStripSeparator A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator R;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage0"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [AccessedThroughProperty("GroupBox15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox16")]
        private GroupBox R;
        [AccessedThroughProperty("TxTSaleProftFinal2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox17")]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTSaleNetFinal2"), CompilerGenerated]
        private Label P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox18")]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTSaleDarFinal2"), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("GroupBox19"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("TxTSaleDisFinal2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label I;
        [AccessedThroughProperty("GroupBox20"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [CompilerGenerated, AccessedThroughProperty("TxTSaleSubTotalFinal2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox10")]
        private GroupBox H;
        [CompilerGenerated, AccessedThroughProperty("TxTSaleProftReturn1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox11")]
        private GroupBox T;
        [AccessedThroughProperty("TxTSaleNetReturn1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox12"), CompilerGenerated]
        private GroupBox X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTSaleDar1"), CompilerGenerated]
        private Label T;
        [AccessedThroughProperty("GroupBox13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox G;
        [AccessedThroughProperty("TxTSaleDis1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label X;
        [AccessedThroughProperty("GroupBox14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox E;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTSaleSubTotal1"), CompilerGenerated]
        private Label G;
        [AccessedThroughProperty("GroupBox3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox8")]
        private GroupBox U;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTSaleProft0")]
        private Label E;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox7")]
        private GroupBox L;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTSaleNetTotal0")]
        private Label K;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox6")]
        private GroupBox N;
        [AccessedThroughProperty("TxTSaleDar0"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label U;
        [CompilerGenerated, AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox V;
        [AccessedThroughProperty("TxTSaleDis0"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label L;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox5")]
        private GroupBox Y;
        [AccessedThroughProperty("TxTSaleSubTotal0"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label N;
        [AccessedThroughProperty("TabPage2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage3")]
        private TabPage P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabPage1")]
        private TabPage Q;
        [AccessedThroughProperty("TimerLoadData"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [CompilerGenerated, AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [AccessedThroughProperty("GroupBox21"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox O;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox23")]
        private GroupBox B;
        [AccessedThroughProperty("TxTPurchNet2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label V;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox24")]
        private GroupBox S;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTPurchDar2"), CompilerGenerated]
        private Label Y;
        [AccessedThroughProperty("GroupBox25"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Z;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTPurchDis2")]
        private Label O;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox26"), CompilerGenerated]
        private GroupBox M;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTPurchSubTotal2")]
        private Label B;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox27"), CompilerGenerated]
        private GroupBox C;
        [AccessedThroughProperty("GroupBox29"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox J;
        [AccessedThroughProperty("TxTPurchNet1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label S;
        [CompilerGenerated, AccessedThroughProperty("GroupBox30"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox W;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTPurchDar1")]
        private Label Z;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox31")]
        private GroupBox AR;
        [CompilerGenerated, AccessedThroughProperty("TxTPurchDis1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label M;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox32")]
        private GroupBox PR;
        [AccessedThroughProperty("TxTPurchSubTotal1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label C;
        [AccessedThroughProperty("GroupBox33"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox QR;
        [CompilerGenerated, AccessedThroughProperty("GroupBox35"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox IR;
        [CompilerGenerated, AccessedThroughProperty("TxTPurchNet0"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label J;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox36"), CompilerGenerated]
        private GroupBox DR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTPurchDar0"), CompilerGenerated]
        private Label W;
        [AccessedThroughProperty("GroupBox37"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox FR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTPurchDis0")]
        private Label AR;
        [AccessedThroughProperty("GroupBox38"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox HR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTPurchSubTotal0")]
        private Label PR;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox28")]
        private GroupBox TR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTCashTotalOut")]
        private Label QR;
        [AccessedThroughProperty("GroupBox22"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox XR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTCashTotalin")]
        private Label IR;
        [AccessedThroughProperty("GroupBox34"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox GR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTExpensse")]
        private Label DR;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripStatus")]
        private ToolStrip R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripProgressBar1")]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("ToolStripSeparator1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator P;
        [AccessedThroughProperty("ToolStripButtonPrint"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripDropDownButton A;
        [AccessedThroughProperty("A4ToolStripMenuItem"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("ToolStripSeparator2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CacheReportRoll80ToolStripMenuItem")]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("ToolStripButtonOpenCash"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator I;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox ER;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("DateTimePickerFrom")]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox2")]
        private GroupBox KR;
        [CompilerGenerated, AccessedThroughProperty("DateTimePickerTo"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker P;
        [CompilerGenerated, AccessedThroughProperty("PickerTimeTo"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DateTimePicker Q;
        private SqlConnection A;

        public FD()
        {
            base.Load += new EventHandler(this.A);
            base.KeyUp += new KeyEventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.TxTTitle = new Label();
            this.Panel2 = new Panel();
            this.ButtonSortDate = new Button();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.A4ToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.CacheReportRoll80ToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripButtonOpenCash = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.TabControl1 = new TabControl();
            this.TabPage0 = new TabPage();
            this.GroupBox15 = new GroupBox();
            this.GroupBox16 = new GroupBox();
            this.TxTSaleProftFinal2 = new Label();
            this.GroupBox17 = new GroupBox();
            this.TxTSaleNetFinal2 = new Label();
            this.GroupBox18 = new GroupBox();
            this.TxTSaleDarFinal2 = new Label();
            this.GroupBox19 = new GroupBox();
            this.TxTSaleDisFinal2 = new Label();
            this.GroupBox20 = new GroupBox();
            this.TxTSaleSubTotalFinal2 = new Label();
            this.GroupBox9 = new GroupBox();
            this.GroupBox10 = new GroupBox();
            this.TxTSaleProftReturn1 = new Label();
            this.GroupBox11 = new GroupBox();
            this.TxTSaleNetReturn1 = new Label();
            this.GroupBox12 = new GroupBox();
            this.TxTSaleDar1 = new Label();
            this.GroupBox13 = new GroupBox();
            this.TxTSaleDis1 = new Label();
            this.GroupBox14 = new GroupBox();
            this.TxTSaleSubTotal1 = new Label();
            this.GroupBox3 = new GroupBox();
            this.GroupBox8 = new GroupBox();
            this.TxTSaleProft0 = new Label();
            this.GroupBox7 = new GroupBox();
            this.TxTSaleNetTotal0 = new Label();
            this.GroupBox6 = new GroupBox();
            this.TxTSaleDar0 = new Label();
            this.GroupBox4 = new GroupBox();
            this.TxTSaleDis0 = new Label();
            this.GroupBox5 = new GroupBox();
            this.TxTSaleSubTotal0 = new Label();
            this.TabPage2 = new TabPage();
            this.GroupBox21 = new GroupBox();
            this.GroupBox23 = new GroupBox();
            this.TxTPurchNet2 = new Label();
            this.GroupBox24 = new GroupBox();
            this.TxTPurchDar2 = new Label();
            this.GroupBox25 = new GroupBox();
            this.TxTPurchDis2 = new Label();
            this.GroupBox26 = new GroupBox();
            this.TxTPurchSubTotal2 = new Label();
            this.GroupBox27 = new GroupBox();
            this.GroupBox29 = new GroupBox();
            this.TxTPurchNet1 = new Label();
            this.GroupBox30 = new GroupBox();
            this.TxTPurchDar1 = new Label();
            this.GroupBox31 = new GroupBox();
            this.TxTPurchDis1 = new Label();
            this.GroupBox32 = new GroupBox();
            this.TxTPurchSubTotal1 = new Label();
            this.GroupBox33 = new GroupBox();
            this.GroupBox35 = new GroupBox();
            this.TxTPurchNet0 = new Label();
            this.GroupBox36 = new GroupBox();
            this.TxTPurchDar0 = new Label();
            this.GroupBox37 = new GroupBox();
            this.TxTPurchDis0 = new Label();
            this.GroupBox38 = new GroupBox();
            this.TxTPurchSubTotal0 = new Label();
            this.TabPage3 = new TabPage();
            this.GroupBox34 = new GroupBox();
            this.TxTExpensse = new Label();
            this.TabPage1 = new TabPage();
            this.GroupBox28 = new GroupBox();
            this.TxTCashTotalOut = new Label();
            this.GroupBox22 = new GroupBox();
            this.TxTCashTotalin = new Label();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TimerFillGV = new Timer(this.A);
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.GroupBox1 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBox2 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.Panel2.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage0.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox16.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.GroupBox18.SuspendLayout();
            this.GroupBox19.SuspendLayout();
            this.GroupBox20.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox21.SuspendLayout();
            this.GroupBox23.SuspendLayout();
            this.GroupBox24.SuspendLayout();
            this.GroupBox25.SuspendLayout();
            this.GroupBox26.SuspendLayout();
            this.GroupBox27.SuspendLayout();
            this.GroupBox29.SuspendLayout();
            this.GroupBox30.SuspendLayout();
            this.GroupBox31.SuspendLayout();
            this.GroupBox32.SuspendLayout();
            this.GroupBox33.SuspendLayout();
            this.GroupBox35.SuspendLayout();
            this.GroupBox36.SuspendLayout();
            this.GroupBox37.SuspendLayout();
            this.GroupBox38.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox34.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox28.SuspendLayout();
            this.GroupBox22.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d8, 0x24);
            this.TxTTitle.TabIndex = 0x1ed36d5;
            this.TxTTitle.Text = "التقرير العام";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Panel2.BackColor = Color.WhiteSmoke;
            this.Panel2.BorderStyle = BorderStyle.Fixed3D;
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Controls.Add(this.GroupBox2);
            this.Panel2.Controls.Add(this.ButtonSortDate);
            this.Panel2.Dock = DockStyle.Top;
            this.Panel2.Location = new Point(0, 0x24);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new Size(0x3d8, 0x5d);
            this.Panel2.TabIndex = 0x1ed36d6;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(0x12b, 0x11);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(280, 0x3d);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonPrint, this.ToolStripSeparator6, this.ToolStripButtonOpenCash, this.ToolStripSeparator7, this.ToolStripButtonClose, this.ToolStripSeparator3 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x24d);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36d8;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.A4ToolStripMenuItem, this.ToolStripSeparator2, this.CacheReportRoll80ToolStripMenuItem };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray2);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x56, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة";
            this.A4ToolStripMenuItem.Image = A.F.ImPrint;
            this.A4ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.A4ToolStripMenuItem.Name = "A4ToolStripMenuItem";
            this.A4ToolStripMenuItem.Size = new Size(180, 0x26);
            this.A4ToolStripMenuItem.Text = "التقرير A4";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(0xb1, 6);
            this.CacheReportRoll80ToolStripMenuItem.Image = A.F.ImPrint;
            this.CacheReportRoll80ToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            this.CacheReportRoll80ToolStripMenuItem.Name = "CacheReportRoll80ToolStripMenuItem";
            this.CacheReportRoll80ToolStripMenuItem.Size = new Size(180, 0x26);
            this.CacheReportRoll80ToolStripMenuItem.Text = "التقرير 80 حراري";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new Size(6, 0x2f);
            this.ToolStripButtonOpenCash.Image = A.F.ImCashMe;
            this.ToolStripButtonOpenCash.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonOpenCash.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonOpenCash.Name = "ToolStripButtonOpenCash";
            this.ToolStripButtonOpenCash.Size = new Size(0x8f, 0x2c);
            this.ToolStripButtonOpenCash.Text = "فتح صندوق الكاش";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(6, 0x2f);
            this.ToolStripButtonClose.Image = A.F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x2c);
            this.ToolStripButtonClose.Text = "اغلاق";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x2f);
            this.TabControl1.Controls.Add(this.TabPage0);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = DockStyle.Fill;
            this.TabControl1.Location = new Point(0, 0x81);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(20, 8);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 460);
            this.TabControl1.TabIndex = 0x1ed36d9;
            this.TabPage0.Controls.Add(this.GroupBox15);
            this.TabPage0.Controls.Add(this.GroupBox9);
            this.TabPage0.Controls.Add(this.GroupBox3);
            this.TabPage0.Location = new Point(4, 0x23);
            this.TabPage0.Name = "TabPage0";
            this.TabPage0.Size = new Size(0x3d0, 0x1a5);
            this.TabPage0.TabIndex = 0;
            this.TabPage0.Text = "المبيعات / مرتجع المبيعات";
            this.TabPage0.UseVisualStyleBackColor = true;
            this.GroupBox15.Controls.Add(this.GroupBox16);
            this.GroupBox15.Controls.Add(this.GroupBox17);
            this.GroupBox15.Controls.Add(this.GroupBox18);
            this.GroupBox15.Controls.Add(this.GroupBox19);
            this.GroupBox15.Controls.Add(this.GroupBox20);
            this.GroupBox15.Dock = DockStyle.Top;
            this.GroupBox15.ForeColor = Color.DarkGreen;
            this.GroupBox15.Location = new Point(0, 0xc2);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x3d0, 0x6b);
            this.GroupBox15.TabIndex = 6;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "صافي المبيعات من مرتجع المبيعات";
            this.GroupBox16.Controls.Add(this.TxTSaleProftFinal2);
            this.GroupBox16.Location = new Point(0x1c, 0x21);
            this.GroupBox16.Name = "GroupBox16";
            this.GroupBox16.Size = new Size(0xb0, 0x38);
            this.GroupBox16.TabIndex = 4;
            this.GroupBox16.TabStop = false;
            this.GroupBox16.Text = "الربح";
            this.TxTSaleProftFinal2.Dock = DockStyle.Fill;
            this.TxTSaleProftFinal2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleProftFinal2.Location = new Point(3, 0x13);
            this.TxTSaleProftFinal2.Name = "TxTSaleProftFinal2";
            this.TxTSaleProftFinal2.RightToLeft = RightToLeft.No;
            this.TxTSaleProftFinal2.Size = new Size(170, 0x22);
            this.TxTSaleProftFinal2.TabIndex = 1;
            this.TxTSaleProftFinal2.Text = "0";
            this.TxTSaleProftFinal2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox17.Controls.Add(this.TxTSaleNetFinal2);
            this.GroupBox17.Location = new Point(210, 0x21);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Size = new Size(0xb0, 0x38);
            this.GroupBox17.TabIndex = 3;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "صافي المجموع";
            this.TxTSaleNetFinal2.Dock = DockStyle.Fill;
            this.TxTSaleNetFinal2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleNetFinal2.Location = new Point(3, 0x13);
            this.TxTSaleNetFinal2.Name = "TxTSaleNetFinal2";
            this.TxTSaleNetFinal2.RightToLeft = RightToLeft.No;
            this.TxTSaleNetFinal2.Size = new Size(170, 0x22);
            this.TxTSaleNetFinal2.TabIndex = 1;
            this.TxTSaleNetFinal2.Text = "0";
            this.TxTSaleNetFinal2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox18.Controls.Add(this.TxTSaleDarFinal2);
            this.GroupBox18.Location = new Point(0x188, 0x21);
            this.GroupBox18.Name = "GroupBox18";
            this.GroupBox18.Size = new Size(0xb0, 0x38);
            this.GroupBox18.TabIndex = 2;
            this.GroupBox18.TabStop = false;
            this.GroupBox18.Text = "مجموع الضريبة";
            this.TxTSaleDarFinal2.Dock = DockStyle.Fill;
            this.TxTSaleDarFinal2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleDarFinal2.Location = new Point(3, 0x13);
            this.TxTSaleDarFinal2.Name = "TxTSaleDarFinal2";
            this.TxTSaleDarFinal2.RightToLeft = RightToLeft.No;
            this.TxTSaleDarFinal2.Size = new Size(170, 0x22);
            this.TxTSaleDarFinal2.TabIndex = 1;
            this.TxTSaleDarFinal2.Text = "0";
            this.TxTSaleDarFinal2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox19.Controls.Add(this.TxTSaleDisFinal2);
            this.GroupBox19.Location = new Point(0x23e, 0x21);
            this.GroupBox19.Name = "GroupBox19";
            this.GroupBox19.Size = new Size(0xb0, 0x38);
            this.GroupBox19.TabIndex = 1;
            this.GroupBox19.TabStop = false;
            this.GroupBox19.Text = "مجموع الخصم";
            this.TxTSaleDisFinal2.Dock = DockStyle.Fill;
            this.TxTSaleDisFinal2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleDisFinal2.Location = new Point(3, 0x13);
            this.TxTSaleDisFinal2.Name = "TxTSaleDisFinal2";
            this.TxTSaleDisFinal2.RightToLeft = RightToLeft.No;
            this.TxTSaleDisFinal2.Size = new Size(170, 0x22);
            this.TxTSaleDisFinal2.TabIndex = 1;
            this.TxTSaleDisFinal2.Text = "0";
            this.TxTSaleDisFinal2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox20.Controls.Add(this.TxTSaleSubTotalFinal2);
            this.GroupBox20.Location = new Point(0x2f4, 0x21);
            this.GroupBox20.Name = "GroupBox20";
            this.GroupBox20.Size = new Size(0xb0, 0x38);
            this.GroupBox20.TabIndex = 0;
            this.GroupBox20.TabStop = false;
            this.GroupBox20.Text = "المجموع الفرعي";
            this.TxTSaleSubTotalFinal2.Dock = DockStyle.Fill;
            this.TxTSaleSubTotalFinal2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleSubTotalFinal2.Location = new Point(3, 0x13);
            this.TxTSaleSubTotalFinal2.Name = "TxTSaleSubTotalFinal2";
            this.TxTSaleSubTotalFinal2.RightToLeft = RightToLeft.No;
            this.TxTSaleSubTotalFinal2.Size = new Size(170, 0x22);
            this.TxTSaleSubTotalFinal2.TabIndex = 0;
            this.TxTSaleSubTotalFinal2.Text = "0";
            this.TxTSaleSubTotalFinal2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox9.Controls.Add(this.GroupBox10);
            this.GroupBox9.Controls.Add(this.GroupBox11);
            this.GroupBox9.Controls.Add(this.GroupBox12);
            this.GroupBox9.Controls.Add(this.GroupBox13);
            this.GroupBox9.Controls.Add(this.GroupBox14);
            this.GroupBox9.Dock = DockStyle.Top;
            this.GroupBox9.ForeColor = Color.Red;
            this.GroupBox9.Location = new Point(0, 0x61);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x3d0, 0x61);
            this.GroupBox9.TabIndex = 5;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "مرتجع المبيعات (-)";
            this.GroupBox10.Controls.Add(this.TxTSaleProftReturn1);
            this.GroupBox10.Location = new Point(0x1c, 0x16);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0xb0, 0x38);
            this.GroupBox10.TabIndex = 4;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "الربح";
            this.TxTSaleProftReturn1.Dock = DockStyle.Fill;
            this.TxTSaleProftReturn1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleProftReturn1.Location = new Point(3, 0x13);
            this.TxTSaleProftReturn1.Name = "TxTSaleProftReturn1";
            this.TxTSaleProftReturn1.RightToLeft = RightToLeft.No;
            this.TxTSaleProftReturn1.Size = new Size(170, 0x22);
            this.TxTSaleProftReturn1.TabIndex = 1;
            this.TxTSaleProftReturn1.Text = "0";
            this.TxTSaleProftReturn1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox11.Controls.Add(this.TxTSaleNetReturn1);
            this.GroupBox11.Location = new Point(210, 0x16);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0xb0, 0x38);
            this.GroupBox11.TabIndex = 3;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "صافي المجموع";
            this.TxTSaleNetReturn1.Dock = DockStyle.Fill;
            this.TxTSaleNetReturn1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleNetReturn1.Location = new Point(3, 0x13);
            this.TxTSaleNetReturn1.Name = "TxTSaleNetReturn1";
            this.TxTSaleNetReturn1.RightToLeft = RightToLeft.No;
            this.TxTSaleNetReturn1.Size = new Size(170, 0x22);
            this.TxTSaleNetReturn1.TabIndex = 1;
            this.TxTSaleNetReturn1.Text = "0";
            this.TxTSaleNetReturn1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox12.Controls.Add(this.TxTSaleDar1);
            this.GroupBox12.Location = new Point(0x188, 0x16);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0xb0, 0x38);
            this.GroupBox12.TabIndex = 2;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "مجموع الضريبة";
            this.TxTSaleDar1.Dock = DockStyle.Fill;
            this.TxTSaleDar1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleDar1.Location = new Point(3, 0x13);
            this.TxTSaleDar1.Name = "TxTSaleDar1";
            this.TxTSaleDar1.RightToLeft = RightToLeft.No;
            this.TxTSaleDar1.Size = new Size(170, 0x22);
            this.TxTSaleDar1.TabIndex = 1;
            this.TxTSaleDar1.Text = "0";
            this.TxTSaleDar1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox13.Controls.Add(this.TxTSaleDis1);
            this.GroupBox13.Location = new Point(0x23e, 0x16);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0xb0, 0x38);
            this.GroupBox13.TabIndex = 1;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "مجموع الخصم";
            this.TxTSaleDis1.Dock = DockStyle.Fill;
            this.TxTSaleDis1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleDis1.Location = new Point(3, 0x13);
            this.TxTSaleDis1.Name = "TxTSaleDis1";
            this.TxTSaleDis1.RightToLeft = RightToLeft.No;
            this.TxTSaleDis1.Size = new Size(170, 0x22);
            this.TxTSaleDis1.TabIndex = 1;
            this.TxTSaleDis1.Text = "0";
            this.TxTSaleDis1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox14.Controls.Add(this.TxTSaleSubTotal1);
            this.GroupBox14.Location = new Point(0x2f4, 0x16);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0xb0, 0x38);
            this.GroupBox14.TabIndex = 0;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "المجموع الفرعي";
            this.TxTSaleSubTotal1.Dock = DockStyle.Fill;
            this.TxTSaleSubTotal1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleSubTotal1.Location = new Point(3, 0x13);
            this.TxTSaleSubTotal1.Name = "TxTSaleSubTotal1";
            this.TxTSaleSubTotal1.RightToLeft = RightToLeft.No;
            this.TxTSaleSubTotal1.Size = new Size(170, 0x22);
            this.TxTSaleSubTotal1.TabIndex = 0;
            this.TxTSaleSubTotal1.Text = "0";
            this.TxTSaleSubTotal1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox3.Controls.Add(this.GroupBox8);
            this.GroupBox3.Controls.Add(this.GroupBox7);
            this.GroupBox3.Controls.Add(this.GroupBox6);
            this.GroupBox3.Controls.Add(this.GroupBox4);
            this.GroupBox3.Controls.Add(this.GroupBox5);
            this.GroupBox3.Dock = DockStyle.Top;
            this.GroupBox3.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.GroupBox3.Location = new Point(0, 0);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x3d0, 0x61);
            this.GroupBox3.TabIndex = 0;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "المبيعات (+)";
            this.GroupBox8.Controls.Add(this.TxTSaleProft0);
            this.GroupBox8.Location = new Point(0x1c, 0x16);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0xb0, 0x38);
            this.GroupBox8.TabIndex = 4;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "الربح";
            this.TxTSaleProft0.Dock = DockStyle.Fill;
            this.TxTSaleProft0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleProft0.Location = new Point(3, 0x13);
            this.TxTSaleProft0.Name = "TxTSaleProft0";
            this.TxTSaleProft0.RightToLeft = RightToLeft.No;
            this.TxTSaleProft0.Size = new Size(170, 0x22);
            this.TxTSaleProft0.TabIndex = 1;
            this.TxTSaleProft0.Text = "0";
            this.TxTSaleProft0.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox7.Controls.Add(this.TxTSaleNetTotal0);
            this.GroupBox7.Location = new Point(210, 0x16);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0xb0, 0x38);
            this.GroupBox7.TabIndex = 3;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "صافي المجموع";
            this.TxTSaleNetTotal0.Dock = DockStyle.Fill;
            this.TxTSaleNetTotal0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleNetTotal0.Location = new Point(3, 0x13);
            this.TxTSaleNetTotal0.Name = "TxTSaleNetTotal0";
            this.TxTSaleNetTotal0.RightToLeft = RightToLeft.No;
            this.TxTSaleNetTotal0.Size = new Size(170, 0x22);
            this.TxTSaleNetTotal0.TabIndex = 1;
            this.TxTSaleNetTotal0.Text = "0";
            this.TxTSaleNetTotal0.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox6.Controls.Add(this.TxTSaleDar0);
            this.GroupBox6.Location = new Point(0x188, 0x16);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0xb0, 0x38);
            this.GroupBox6.TabIndex = 2;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "مجموع الضريبة";
            this.TxTSaleDar0.Dock = DockStyle.Fill;
            this.TxTSaleDar0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleDar0.Location = new Point(3, 0x13);
            this.TxTSaleDar0.Name = "TxTSaleDar0";
            this.TxTSaleDar0.RightToLeft = RightToLeft.No;
            this.TxTSaleDar0.Size = new Size(170, 0x22);
            this.TxTSaleDar0.TabIndex = 1;
            this.TxTSaleDar0.Text = "0";
            this.TxTSaleDar0.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox4.Controls.Add(this.TxTSaleDis0);
            this.GroupBox4.Location = new Point(0x23e, 0x16);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0xb0, 0x38);
            this.GroupBox4.TabIndex = 1;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "مجموع الخصم";
            this.TxTSaleDis0.Dock = DockStyle.Fill;
            this.TxTSaleDis0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleDis0.Location = new Point(3, 0x13);
            this.TxTSaleDis0.Name = "TxTSaleDis0";
            this.TxTSaleDis0.RightToLeft = RightToLeft.No;
            this.TxTSaleDis0.Size = new Size(170, 0x22);
            this.TxTSaleDis0.TabIndex = 1;
            this.TxTSaleDis0.Text = "0";
            this.TxTSaleDis0.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox5.Controls.Add(this.TxTSaleSubTotal0);
            this.GroupBox5.Location = new Point(0x2f4, 0x16);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0xb0, 0x38);
            this.GroupBox5.TabIndex = 0;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "المجموع الفرعي";
            this.TxTSaleSubTotal0.Dock = DockStyle.Fill;
            this.TxTSaleSubTotal0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTSaleSubTotal0.Location = new Point(3, 0x13);
            this.TxTSaleSubTotal0.Name = "TxTSaleSubTotal0";
            this.TxTSaleSubTotal0.RightToLeft = RightToLeft.No;
            this.TxTSaleSubTotal0.Size = new Size(170, 0x22);
            this.TxTSaleSubTotal0.TabIndex = 0;
            this.TxTSaleSubTotal0.Text = "0";
            this.TxTSaleSubTotal0.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage2.Controls.Add(this.GroupBox21);
            this.TabPage2.Controls.Add(this.GroupBox27);
            this.TabPage2.Controls.Add(this.GroupBox33);
            this.TabPage2.Location = new Point(4, 0x23);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new Size(0x3d0, 0x175);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "المشتريات / مرتجع المشتريات";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GroupBox21.Controls.Add(this.GroupBox23);
            this.GroupBox21.Controls.Add(this.GroupBox24);
            this.GroupBox21.Controls.Add(this.GroupBox25);
            this.GroupBox21.Controls.Add(this.GroupBox26);
            this.GroupBox21.Dock = DockStyle.Top;
            this.GroupBox21.ForeColor = Color.DarkGreen;
            this.GroupBox21.Location = new Point(0, 0xc2);
            this.GroupBox21.Name = "GroupBox21";
            this.GroupBox21.Size = new Size(0x3d0, 0x61);
            this.GroupBox21.TabIndex = 9;
            this.GroupBox21.TabStop = false;
            this.GroupBox21.Text = "صافي المشتريات من مرتجع المشتريات";
            this.GroupBox23.Controls.Add(this.TxTPurchNet2);
            this.GroupBox23.Location = new Point(210, 0x16);
            this.GroupBox23.Name = "GroupBox23";
            this.GroupBox23.Size = new Size(0xb0, 0x38);
            this.GroupBox23.TabIndex = 3;
            this.GroupBox23.TabStop = false;
            this.GroupBox23.Text = "صافي المجموع";
            this.TxTPurchNet2.Dock = DockStyle.Fill;
            this.TxTPurchNet2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchNet2.Location = new Point(3, 0x13);
            this.TxTPurchNet2.Name = "TxTPurchNet2";
            this.TxTPurchNet2.RightToLeft = RightToLeft.No;
            this.TxTPurchNet2.Size = new Size(170, 0x22);
            this.TxTPurchNet2.TabIndex = 1;
            this.TxTPurchNet2.Text = "0";
            this.TxTPurchNet2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox24.Controls.Add(this.TxTPurchDar2);
            this.GroupBox24.Location = new Point(0x188, 0x16);
            this.GroupBox24.Name = "GroupBox24";
            this.GroupBox24.Size = new Size(0xb0, 0x38);
            this.GroupBox24.TabIndex = 2;
            this.GroupBox24.TabStop = false;
            this.GroupBox24.Text = "مجموع الضريبة";
            this.TxTPurchDar2.Dock = DockStyle.Fill;
            this.TxTPurchDar2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchDar2.Location = new Point(3, 0x13);
            this.TxTPurchDar2.Name = "TxTPurchDar2";
            this.TxTPurchDar2.RightToLeft = RightToLeft.No;
            this.TxTPurchDar2.Size = new Size(170, 0x22);
            this.TxTPurchDar2.TabIndex = 1;
            this.TxTPurchDar2.Text = "0";
            this.TxTPurchDar2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox25.Controls.Add(this.TxTPurchDis2);
            this.GroupBox25.Location = new Point(0x23e, 0x16);
            this.GroupBox25.Name = "GroupBox25";
            this.GroupBox25.Size = new Size(0xb0, 0x38);
            this.GroupBox25.TabIndex = 1;
            this.GroupBox25.TabStop = false;
            this.GroupBox25.Text = "مجموع الخصم";
            this.TxTPurchDis2.Dock = DockStyle.Fill;
            this.TxTPurchDis2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchDis2.Location = new Point(3, 0x13);
            this.TxTPurchDis2.Name = "TxTPurchDis2";
            this.TxTPurchDis2.RightToLeft = RightToLeft.No;
            this.TxTPurchDis2.Size = new Size(170, 0x22);
            this.TxTPurchDis2.TabIndex = 1;
            this.TxTPurchDis2.Text = "0";
            this.TxTPurchDis2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox26.Controls.Add(this.TxTPurchSubTotal2);
            this.GroupBox26.Location = new Point(0x2f4, 0x16);
            this.GroupBox26.Name = "GroupBox26";
            this.GroupBox26.Size = new Size(0xb0, 0x38);
            this.GroupBox26.TabIndex = 0;
            this.GroupBox26.TabStop = false;
            this.GroupBox26.Text = "المجموع الفرعي";
            this.TxTPurchSubTotal2.Dock = DockStyle.Fill;
            this.TxTPurchSubTotal2.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchSubTotal2.Location = new Point(3, 0x13);
            this.TxTPurchSubTotal2.Name = "TxTPurchSubTotal2";
            this.TxTPurchSubTotal2.RightToLeft = RightToLeft.No;
            this.TxTPurchSubTotal2.Size = new Size(170, 0x22);
            this.TxTPurchSubTotal2.TabIndex = 0;
            this.TxTPurchSubTotal2.Text = "0";
            this.TxTPurchSubTotal2.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox27.Controls.Add(this.GroupBox29);
            this.GroupBox27.Controls.Add(this.GroupBox30);
            this.GroupBox27.Controls.Add(this.GroupBox31);
            this.GroupBox27.Controls.Add(this.GroupBox32);
            this.GroupBox27.Dock = DockStyle.Top;
            this.GroupBox27.ForeColor = Color.Red;
            this.GroupBox27.Location = new Point(0, 0x61);
            this.GroupBox27.Name = "GroupBox27";
            this.GroupBox27.Size = new Size(0x3d0, 0x61);
            this.GroupBox27.TabIndex = 8;
            this.GroupBox27.TabStop = false;
            this.GroupBox27.Text = "مرتجع المشتريات (-)";
            this.GroupBox29.Controls.Add(this.TxTPurchNet1);
            this.GroupBox29.Location = new Point(210, 0x16);
            this.GroupBox29.Name = "GroupBox29";
            this.GroupBox29.Size = new Size(0xb0, 0x38);
            this.GroupBox29.TabIndex = 3;
            this.GroupBox29.TabStop = false;
            this.GroupBox29.Text = "صافي المجموع";
            this.TxTPurchNet1.Dock = DockStyle.Fill;
            this.TxTPurchNet1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchNet1.Location = new Point(3, 0x13);
            this.TxTPurchNet1.Name = "TxTPurchNet1";
            this.TxTPurchNet1.RightToLeft = RightToLeft.No;
            this.TxTPurchNet1.Size = new Size(170, 0x22);
            this.TxTPurchNet1.TabIndex = 1;
            this.TxTPurchNet1.Text = "0";
            this.TxTPurchNet1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox30.Controls.Add(this.TxTPurchDar1);
            this.GroupBox30.Location = new Point(0x188, 0x16);
            this.GroupBox30.Name = "GroupBox30";
            this.GroupBox30.Size = new Size(0xb0, 0x38);
            this.GroupBox30.TabIndex = 2;
            this.GroupBox30.TabStop = false;
            this.GroupBox30.Text = "مجموع الضريبة";
            this.TxTPurchDar1.Dock = DockStyle.Fill;
            this.TxTPurchDar1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchDar1.Location = new Point(3, 0x13);
            this.TxTPurchDar1.Name = "TxTPurchDar1";
            this.TxTPurchDar1.RightToLeft = RightToLeft.No;
            this.TxTPurchDar1.Size = new Size(170, 0x22);
            this.TxTPurchDar1.TabIndex = 1;
            this.TxTPurchDar1.Text = "0";
            this.TxTPurchDar1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox31.Controls.Add(this.TxTPurchDis1);
            this.GroupBox31.Location = new Point(0x23e, 0x16);
            this.GroupBox31.Name = "GroupBox31";
            this.GroupBox31.Size = new Size(0xb0, 0x38);
            this.GroupBox31.TabIndex = 1;
            this.GroupBox31.TabStop = false;
            this.GroupBox31.Text = "مجموع الخصم";
            this.TxTPurchDis1.Dock = DockStyle.Fill;
            this.TxTPurchDis1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchDis1.Location = new Point(3, 0x13);
            this.TxTPurchDis1.Name = "TxTPurchDis1";
            this.TxTPurchDis1.RightToLeft = RightToLeft.No;
            this.TxTPurchDis1.Size = new Size(170, 0x22);
            this.TxTPurchDis1.TabIndex = 1;
            this.TxTPurchDis1.Text = "0";
            this.TxTPurchDis1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox32.Controls.Add(this.TxTPurchSubTotal1);
            this.GroupBox32.Location = new Point(0x2f4, 0x16);
            this.GroupBox32.Name = "GroupBox32";
            this.GroupBox32.Size = new Size(0xb0, 0x38);
            this.GroupBox32.TabIndex = 0;
            this.GroupBox32.TabStop = false;
            this.GroupBox32.Text = "المجموع الفرعي";
            this.TxTPurchSubTotal1.Dock = DockStyle.Fill;
            this.TxTPurchSubTotal1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchSubTotal1.Location = new Point(3, 0x13);
            this.TxTPurchSubTotal1.Name = "TxTPurchSubTotal1";
            this.TxTPurchSubTotal1.RightToLeft = RightToLeft.No;
            this.TxTPurchSubTotal1.Size = new Size(170, 0x22);
            this.TxTPurchSubTotal1.TabIndex = 0;
            this.TxTPurchSubTotal1.Text = "0";
            this.TxTPurchSubTotal1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox33.Controls.Add(this.GroupBox35);
            this.GroupBox33.Controls.Add(this.GroupBox36);
            this.GroupBox33.Controls.Add(this.GroupBox37);
            this.GroupBox33.Controls.Add(this.GroupBox38);
            this.GroupBox33.Dock = DockStyle.Top;
            this.GroupBox33.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.GroupBox33.Location = new Point(0, 0);
            this.GroupBox33.Name = "GroupBox33";
            this.GroupBox33.Size = new Size(0x3d0, 0x61);
            this.GroupBox33.TabIndex = 7;
            this.GroupBox33.TabStop = false;
            this.GroupBox33.Text = "المشتريات (+)";
            this.GroupBox35.Controls.Add(this.TxTPurchNet0);
            this.GroupBox35.Location = new Point(210, 0x16);
            this.GroupBox35.Name = "GroupBox35";
            this.GroupBox35.Size = new Size(0xb0, 0x38);
            this.GroupBox35.TabIndex = 3;
            this.GroupBox35.TabStop = false;
            this.GroupBox35.Text = "صافي المجموع";
            this.TxTPurchNet0.Dock = DockStyle.Fill;
            this.TxTPurchNet0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchNet0.Location = new Point(3, 0x13);
            this.TxTPurchNet0.Name = "TxTPurchNet0";
            this.TxTPurchNet0.RightToLeft = RightToLeft.No;
            this.TxTPurchNet0.Size = new Size(170, 0x22);
            this.TxTPurchNet0.TabIndex = 1;
            this.TxTPurchNet0.Text = "0";
            this.TxTPurchNet0.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox36.Controls.Add(this.TxTPurchDar0);
            this.GroupBox36.Location = new Point(0x188, 0x16);
            this.GroupBox36.Name = "GroupBox36";
            this.GroupBox36.Size = new Size(0xb0, 0x38);
            this.GroupBox36.TabIndex = 2;
            this.GroupBox36.TabStop = false;
            this.GroupBox36.Text = "مجموع الضريبة";
            this.TxTPurchDar0.Dock = DockStyle.Fill;
            this.TxTPurchDar0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchDar0.Location = new Point(3, 0x13);
            this.TxTPurchDar0.Name = "TxTPurchDar0";
            this.TxTPurchDar0.RightToLeft = RightToLeft.No;
            this.TxTPurchDar0.Size = new Size(170, 0x22);
            this.TxTPurchDar0.TabIndex = 1;
            this.TxTPurchDar0.Text = "0";
            this.TxTPurchDar0.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox37.Controls.Add(this.TxTPurchDis0);
            this.GroupBox37.Location = new Point(0x23e, 0x16);
            this.GroupBox37.Name = "GroupBox37";
            this.GroupBox37.Size = new Size(0xb0, 0x38);
            this.GroupBox37.TabIndex = 1;
            this.GroupBox37.TabStop = false;
            this.GroupBox37.Text = "مجموع الخصم";
            this.TxTPurchDis0.Dock = DockStyle.Fill;
            this.TxTPurchDis0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchDis0.Location = new Point(3, 0x13);
            this.TxTPurchDis0.Name = "TxTPurchDis0";
            this.TxTPurchDis0.RightToLeft = RightToLeft.No;
            this.TxTPurchDis0.Size = new Size(170, 0x22);
            this.TxTPurchDis0.TabIndex = 1;
            this.TxTPurchDis0.Text = "0";
            this.TxTPurchDis0.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox38.Controls.Add(this.TxTPurchSubTotal0);
            this.GroupBox38.Location = new Point(0x2f4, 0x16);
            this.GroupBox38.Name = "GroupBox38";
            this.GroupBox38.Size = new Size(0xb0, 0x38);
            this.GroupBox38.TabIndex = 0;
            this.GroupBox38.TabStop = false;
            this.GroupBox38.Text = "المجموع الفرعي";
            this.TxTPurchSubTotal0.Dock = DockStyle.Fill;
            this.TxTPurchSubTotal0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTPurchSubTotal0.Location = new Point(3, 0x13);
            this.TxTPurchSubTotal0.Name = "TxTPurchSubTotal0";
            this.TxTPurchSubTotal0.RightToLeft = RightToLeft.No;
            this.TxTPurchSubTotal0.Size = new Size(170, 0x22);
            this.TxTPurchSubTotal0.TabIndex = 0;
            this.TxTPurchSubTotal0.Text = "0";
            this.TxTPurchSubTotal0.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage3.Controls.Add(this.GroupBox34);
            this.TabPage3.Location = new Point(4, 0x23);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x3d0, 0x175);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "المصروفات";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.GroupBox34.Controls.Add(this.TxTExpensse);
            this.GroupBox34.Dock = DockStyle.Top;
            this.GroupBox34.Location = new Point(0, 0);
            this.GroupBox34.Name = "GroupBox34";
            this.GroupBox34.Size = new Size(0x3d0, 0x38);
            this.GroupBox34.TabIndex = 3;
            this.GroupBox34.TabStop = false;
            this.GroupBox34.Text = "مجموع المصورفات والنفقات (-)";
            this.TxTExpensse.Dock = DockStyle.Fill;
            this.TxTExpensse.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTExpensse.ForeColor = Color.Red;
            this.TxTExpensse.Location = new Point(3, 0x13);
            this.TxTExpensse.Name = "TxTExpensse";
            this.TxTExpensse.RightToLeft = RightToLeft.No;
            this.TxTExpensse.Size = new Size(970, 0x22);
            this.TxTExpensse.TabIndex = 1;
            this.TxTExpensse.Text = "0";
            this.TxTExpensse.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage1.Controls.Add(this.GroupBox28);
            this.TabPage1.Controls.Add(this.GroupBox22);
            this.TabPage1.Location = new Point(4, 0x23);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new Size(0x3d0, 0x175);
            this.TabPage1.TabIndex = 3;
            this.TabPage1.Text = "خزينة الكاش المضافة/ المسحوبة";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox28.Controls.Add(this.TxTCashTotalOut);
            this.GroupBox28.Dock = DockStyle.Top;
            this.GroupBox28.Location = new Point(0, 0x38);
            this.GroupBox28.Name = "GroupBox28";
            this.GroupBox28.Size = new Size(0x3d0, 0x38);
            this.GroupBox28.TabIndex = 3;
            this.GroupBox28.TabStop = false;
            this.GroupBox28.Text = "مجموع المبالغ/الخزينة التي تم سحبها من الكاش (-)";
            this.TxTCashTotalOut.Dock = DockStyle.Fill;
            this.TxTCashTotalOut.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTCashTotalOut.ForeColor = Color.Red;
            this.TxTCashTotalOut.Location = new Point(3, 0x13);
            this.TxTCashTotalOut.Name = "TxTCashTotalOut";
            this.TxTCashTotalOut.RightToLeft = RightToLeft.No;
            this.TxTCashTotalOut.Size = new Size(970, 0x22);
            this.TxTCashTotalOut.TabIndex = 1;
            this.TxTCashTotalOut.Text = "0";
            this.TxTCashTotalOut.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox22.Controls.Add(this.TxTCashTotalin);
            this.GroupBox22.Dock = DockStyle.Top;
            this.GroupBox22.Location = new Point(0, 0);
            this.GroupBox22.Name = "GroupBox22";
            this.GroupBox22.Size = new Size(0x3d0, 0x38);
            this.GroupBox22.TabIndex = 2;
            this.GroupBox22.TabStop = false;
            this.GroupBox22.Text = "مجموع المبالغ/الخزينة التي تم إضافتها في الكاش (+)";
            this.TxTCashTotalin.Dock = DockStyle.Fill;
            this.TxTCashTotalin.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTCashTotalin.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.TxTCashTotalin.Location = new Point(3, 0x13);
            this.TxTCashTotalin.Name = "TxTCashTotalin";
            this.TxTCashTotalin.RightToLeft = RightToLeft.No;
            this.TxTCashTotalin.Size = new Size(970, 0x22);
            this.TxTCashTotalin.TabIndex = 1;
            this.TxTCashTotalin.Text = "0";
            this.TxTCashTotalin.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray3);
            this.ToolStripStatus.Location = new Point(0, 0x27c);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x1ed36da;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x31a, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb0, 0x4a);
            this.GroupBox1.TabIndex = 90;
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
            this.GroupBox2.Location = new Point(0x256, 6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xb0, 0x48);
            this.GroupBox2.TabIndex = 0x5b;
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
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.Panel2);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "GReport";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "التقرير العام";
            this.Panel2.ResumeLayout(false);
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage0.ResumeLayout(false);
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox16.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.GroupBox18.ResumeLayout(false);
            this.GroupBox19.ResumeLayout(false);
            this.GroupBox20.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox21.ResumeLayout(false);
            this.GroupBox23.ResumeLayout(false);
            this.GroupBox24.ResumeLayout(false);
            this.GroupBox25.ResumeLayout(false);
            this.GroupBox26.ResumeLayout(false);
            this.GroupBox27.ResumeLayout(false);
            this.GroupBox29.ResumeLayout(false);
            this.GroupBox30.ResumeLayout(false);
            this.GroupBox31.ResumeLayout(false);
            this.GroupBox32.ResumeLayout(false);
            this.GroupBox33.ResumeLayout(false);
            this.GroupBox35.ResumeLayout(false);
            this.GroupBox36.ResumeLayout(false);
            this.GroupBox37.ResumeLayout(false);
            this.GroupBox38.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.GroupBox34.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox28.ResumeLayout(false);
            this.GroupBox22.ResumeLayout(false);
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, KeyEventArgs R)
        {
            if (R.KeyCode == Keys.F1)
            {
                A.W.A();
            }
        }

        public void D()
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            base.Dispose();
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

        public void F()
        {
            // Invalid method body.
        }

        private void F(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                AQ aq = new AQ();
                aq.SetParameterValue("CenterName", A.PR.ER.ToString());
                aq.SetParameterValue("CenterSubName", A.PR.KR.ToString());
                aq.SetParameterValue("ParameterDeimelQ", A.PR.X);
                aq.SetParameterValue("ParameterDeimelS", A.PR.T);
                aq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (A.PR.NR == null)
                {
                    aq.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    aq.SetParameterValue("CenterCurrencyName", A.PR.NR.ToString());
                }
                if (A.PR.UR == null)
                {
                    aq.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    aq.SetParameterValue("CenterPhone", A.PR.UR.ToString());
                }
                aq.SetParameterValue("TxTSaleSubTotal0", this.TxTSaleSubTotal0.Text.ToString());
                aq.SetParameterValue("TxTSaleDis0", this.TxTSaleDis0.Text.ToString());
                aq.SetParameterValue("TxTSaleDar0", this.TxTSaleDar0.Text.ToString());
                aq.SetParameterValue("TxTSaleNetTotal0", this.TxTSaleNetTotal0.Text.ToString());
                aq.SetParameterValue("TxTSaleProft0", this.TxTSaleProft0.Text.ToString());
                aq.SetParameterValue("TxTSaleSubTotal1", this.TxTSaleSubTotal1.Text.ToString());
                aq.SetParameterValue("TxTSaleDis1", this.TxTSaleDis1.Text.ToString());
                aq.SetParameterValue("TxTSaleDar1", this.TxTSaleDar1.Text.ToString());
                aq.SetParameterValue("TxTSaleNetReturn1", this.TxTSaleNetReturn1.Text.ToString());
                aq.SetParameterValue("TxTSaleProftReturn1", this.TxTSaleProftReturn1.Text.ToString());
                aq.SetParameterValue("TxTSaleSubTotalFinal2", this.TxTSaleSubTotalFinal2.Text.ToString());
                aq.SetParameterValue("TxTSaleDisFinal2", this.TxTSaleDisFinal2.Text.ToString());
                aq.SetParameterValue("TxTSaleDarFinal2", this.TxTSaleDarFinal2.Text.ToString());
                aq.SetParameterValue("TxTSaleNetFinal2", this.TxTSaleNetFinal2.Text.ToString());
                aq.SetParameterValue("TxTSaleProftFinal2", this.TxTSaleProftFinal2.Text.ToString());
                aq.SetParameterValue("TxTPurchSubTotal0", this.TxTPurchSubTotal0.Text.ToString());
                aq.SetParameterValue("TxTPurchDis0", this.TxTPurchDis0.Text.ToString());
                aq.SetParameterValue("TxTPurchDar0", this.TxTPurchDar0.Text.ToString());
                aq.SetParameterValue("TxTPurchNet0", this.TxTPurchNet0.Text.ToString());
                aq.SetParameterValue("TxTPurchSubTotal1", this.TxTPurchSubTotal1.Text.ToString());
                aq.SetParameterValue("TxTPurchDis1", this.TxTPurchDis1.Text.ToString());
                aq.SetParameterValue("TxTPurchDar1", this.TxTPurchDar1.Text.ToString());
                aq.SetParameterValue("TxTPurchNet1", this.TxTPurchNet1.Text.ToString());
                aq.SetParameterValue("TxTPurchSubTotal2", this.TxTPurchSubTotal2.Text.ToString());
                aq.SetParameterValue("TxTPurchDis2", this.TxTPurchDis2.Text.ToString());
                aq.SetParameterValue("TxTPurchDar2", this.TxTPurchDar2.Text.ToString());
                aq.SetParameterValue("TxTPurchNet2", this.TxTPurchNet2.Text.ToString());
                aq.SetParameterValue("TxTExpensse", this.TxTExpensse.Text.ToString());
                aq.SetParameterValue("TxTCashTotalin", this.TxTCashTotalin.Text.ToString());
                aq.SetParameterValue("TxTCashTotalOut", this.TxTCashTotalOut.Text.ToString());
                aq.SetParameterValue("DF", this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd"));
                aq.SetParameterValue("DT", this.DateTimePickerTo.Value.ToString("yyyy/MM/dd"));
                new A.HR { CRViewer = { ReportSource = aq } }.ShowDialog();
                aq.Close();
                aq.Dispose();
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

        public void G()
        {
            // Invalid method body.
        }

        public void H()
        {
            // Invalid method body.
        }

        private void H(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                JP jp = new JP {
                    PrintOptions = { NoPrinter = A.AR.J }
                };
                jp.SetParameterValue("CenterName", A.PR.ER.ToString());
                jp.SetParameterValue("CenterSubName", A.PR.KR.ToString());
                jp.SetParameterValue("ParameterDeimelQ", A.PR.X);
                jp.SetParameterValue("ParameterDeimelS", A.PR.T);
                jp.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (A.PR.NR == null)
                {
                    jp.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    jp.SetParameterValue("CenterCurrencyName", A.PR.NR.ToString());
                }
                if (A.PR.UR == null)
                {
                    jp.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    jp.SetParameterValue("CenterPhone", A.PR.UR.ToString());
                }
                jp.SetParameterValue("TxTSaleSubTotal0", this.TxTSaleSubTotal0.Text.ToString());
                jp.SetParameterValue("TxTSaleDis0", this.TxTSaleDis0.Text.ToString());
                jp.SetParameterValue("TxTSaleDar0", this.TxTSaleDar0.Text.ToString());
                jp.SetParameterValue("TxTSaleNetTotal0", this.TxTSaleNetTotal0.Text.ToString());
                jp.SetParameterValue("TxTSaleProft0", this.TxTSaleProft0.Text.ToString());
                jp.SetParameterValue("TxTSaleSubTotal1", this.TxTSaleSubTotal1.Text.ToString());
                jp.SetParameterValue("TxTSaleDis1", this.TxTSaleDis1.Text.ToString());
                jp.SetParameterValue("TxTSaleDar1", this.TxTSaleDar1.Text.ToString());
                jp.SetParameterValue("TxTSaleNetReturn1", this.TxTSaleNetReturn1.Text.ToString());
                jp.SetParameterValue("TxTSaleProftReturn1", this.TxTSaleProftReturn1.Text.ToString());
                jp.SetParameterValue("TxTSaleSubTotalFinal2", this.TxTSaleSubTotalFinal2.Text.ToString());
                jp.SetParameterValue("TxTSaleDisFinal2", this.TxTSaleDisFinal2.Text.ToString());
                jp.SetParameterValue("TxTSaleDarFinal2", this.TxTSaleDarFinal2.Text.ToString());
                jp.SetParameterValue("TxTSaleNetFinal2", this.TxTSaleNetFinal2.Text.ToString());
                jp.SetParameterValue("TxTSaleProftFinal2", this.TxTSaleProftFinal2.Text.ToString());
                jp.SetParameterValue("TxTPurchSubTotal0", this.TxTPurchSubTotal0.Text.ToString());
                jp.SetParameterValue("TxTPurchDis0", this.TxTPurchDis0.Text.ToString());
                jp.SetParameterValue("TxTPurchDar0", this.TxTPurchDar0.Text.ToString());
                jp.SetParameterValue("TxTPurchNet0", this.TxTPurchNet0.Text.ToString());
                jp.SetParameterValue("TxTPurchSubTotal1", this.TxTPurchSubTotal1.Text.ToString());
                jp.SetParameterValue("TxTPurchDis1", this.TxTPurchDis1.Text.ToString());
                jp.SetParameterValue("TxTPurchDar1", this.TxTPurchDar1.Text.ToString());
                jp.SetParameterValue("TxTPurchNet1", this.TxTPurchNet1.Text.ToString());
                jp.SetParameterValue("TxTPurchSubTotal2", this.TxTPurchSubTotal2.Text.ToString());
                jp.SetParameterValue("TxTPurchDis2", this.TxTPurchDis2.Text.ToString());
                jp.SetParameterValue("TxTPurchDar2", this.TxTPurchDar2.Text.ToString());
                jp.SetParameterValue("TxTPurchNet2", this.TxTPurchNet2.Text.ToString());
                jp.SetParameterValue("TxTExpensse", this.TxTExpensse.Text.ToString());
                jp.SetParameterValue("TxTCashTotalin", this.TxTCashTotalin.Text.ToString());
                jp.SetParameterValue("TxTCashTotalOut", this.TxTCashTotalOut.Text.ToString());
                jp.SetParameterValue("DF", this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd"));
                jp.SetParameterValue("DT", this.DateTimePickerTo.Value.ToString("yyyy/MM/dd"));
                A.HR hr = new A.HR {
                    CRViewer = { ReportSource = jp }
                };
                if (A.AR.U)
                {
                    hr.ShowDialog();
                }
                else if (A.AR.L)
                {
                    hr.CRViewer.PrintReport();
                }
                else
                {
                    jp.PrintOptions.PrinterName = A.AR.X;
                    jp.PrintToPrinter(A.AR.I, false, 0, 0);
                }
                jp.Close();
                jp.Dispose();
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

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = true;
        }

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
        }

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.ToolStripProgressBar1.Visible = true;
            this.ToolStripProgressBar1.Maximum = 15;
            this.R();
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = false;
            this.TxTTitle.Text = A.PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerLoadData.Enabled = true;
        }

        public void T()
        {
            // Invalid method body.
        }

        private void T(object A, EventArgs R)
        {
            A.W.A();
        }

        public void X()
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

        internal virtual Panel Panel2
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

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual TabPage TabPage0
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox16
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label TxTSaleProftFinal2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label TxTSaleNetFinal2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox18
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTSaleDarFinal2
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox19
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label TxTSaleDisFinal2
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual Label TxTSaleSubTotalFinal2
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBox9
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

        internal virtual Label TxTSaleProftReturn1
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
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

        internal virtual Label TxTSaleNetReturn1
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
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

        internal virtual Label TxTSaleDar1
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual Label TxTSaleDis1
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual Label TxTSaleSubTotal1
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual Label TxTSaleProft0
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual Label TxTSaleNetTotal0
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
        }

        internal virtual Label TxTSaleDar0
        {
            [CompilerGenerated]
            get => 
                this.U;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.U = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual Label TxTSaleDis0
        {
            [CompilerGenerated]
            get => 
                this.L;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.L = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual Label TxTSaleSubTotal0
        {
            [CompilerGenerated]
            get => 
                this.N;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.N = value);
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

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual GroupBox GroupBox21
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual GroupBox GroupBox23
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual Label TxTPurchNet2
        {
            [CompilerGenerated]
            get => 
                this.V;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.V = value);
        }

        internal virtual GroupBox GroupBox24
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual Label TxTPurchDar2
        {
            [CompilerGenerated]
            get => 
                this.Y;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Y = value);
        }

        internal virtual GroupBox GroupBox25
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual Label TxTPurchDis2
        {
            [CompilerGenerated]
            get => 
                this.O;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.O = value);
        }

        internal virtual GroupBox GroupBox26
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual Label TxTPurchSubTotal2
        {
            [CompilerGenerated]
            get => 
                this.B;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.B = value);
        }

        internal virtual GroupBox GroupBox27
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual GroupBox GroupBox29
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual Label TxTPurchNet1
        {
            [CompilerGenerated]
            get => 
                this.S;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.S = value);
        }

        internal virtual GroupBox GroupBox30
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }

        internal virtual Label TxTPurchDar1
        {
            [CompilerGenerated]
            get => 
                this.Z;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Z = value);
        }

        internal virtual GroupBox GroupBox31
        {
            [CompilerGenerated]
            get => 
                this.AR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.AR = value);
        }

        internal virtual Label TxTPurchDis1
        {
            [CompilerGenerated]
            get => 
                this.M;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.M = value);
        }

        internal virtual GroupBox GroupBox32
        {
            [CompilerGenerated]
            get => 
                this.PR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.PR = value);
        }

        internal virtual Label TxTPurchSubTotal1
        {
            [CompilerGenerated]
            get => 
                this.C;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.C = value);
        }

        internal virtual GroupBox GroupBox33
        {
            [CompilerGenerated]
            get => 
                this.QR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.QR = value);
        }

        internal virtual GroupBox GroupBox35
        {
            [CompilerGenerated]
            get => 
                this.IR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.IR = value);
        }

        internal virtual Label TxTPurchNet0
        {
            [CompilerGenerated]
            get => 
                this.J;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.J = value);
        }

        internal virtual GroupBox GroupBox36
        {
            [CompilerGenerated]
            get => 
                this.DR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.DR = value);
        }

        internal virtual Label TxTPurchDar0
        {
            [CompilerGenerated]
            get => 
                this.W;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.W = value);
        }

        internal virtual GroupBox GroupBox37
        {
            [CompilerGenerated]
            get => 
                this.FR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.FR = value);
        }

        internal virtual Label TxTPurchDis0
        {
            [CompilerGenerated]
            get => 
                this.AR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.AR = value);
        }

        internal virtual GroupBox GroupBox38
        {
            [CompilerGenerated]
            get => 
                this.HR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.HR = value);
        }

        internal virtual Label TxTPurchSubTotal0
        {
            [CompilerGenerated]
            get => 
                this.PR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.PR = value);
        }

        internal virtual GroupBox GroupBox28
        {
            [CompilerGenerated]
            get => 
                this.TR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.TR = value);
        }

        internal virtual Label TxTCashTotalOut
        {
            [CompilerGenerated]
            get => 
                this.QR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.QR = value);
        }

        internal virtual GroupBox GroupBox22
        {
            [CompilerGenerated]
            get => 
                this.XR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.XR = value);
        }

        internal virtual Label TxTCashTotalin
        {
            [CompilerGenerated]
            get => 
                this.IR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.IR = value);
        }

        internal virtual GroupBox GroupBox34
        {
            [CompilerGenerated]
            get => 
                this.GR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.GR = value);
        }

        internal virtual Label TxTExpensse
        {
            [CompilerGenerated]
            get => 
                this.DR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.DR = value);
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

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual ToolStripMenuItem A4ToolStripMenuItem
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

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripMenuItem CacheReportRoll80ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual ToolStripButton ToolStripButtonOpenCash
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.ER;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.ER = value);
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
                this.KR;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.KR = value);
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

