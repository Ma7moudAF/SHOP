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
    public class QT : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("SuplierName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("DateTimePickerFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker A;
        [AccessedThroughProperty("ButtonSortDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox P;
        [AccessedThroughProperty("DateTimePickerTo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker R;
        [AccessedThroughProperty("ToolStripButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonViewAll"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripButtonAdd")]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator2")]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripButtonDelete"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator6"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton Q;
        [AccessedThroughProperty("ToolStripSeparator7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripStatus")]
        private ToolStrip R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("ToolStripLabel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTGVRowCount")]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated]
        private ToolStripSeparator D;
        [AccessedThroughProperty("TimerLoadData"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerFillGV")]
        private Timer P;
        [AccessedThroughProperty("GV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonPrint")]
        private ToolStripDropDownButton A;
        [AccessedThroughProperty("A4ToolStripMenuItemPrintPay"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("ToolStripSeparator5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator F;
        [AccessedThroughProperty("A4ToolStripMenuItemPrintAll"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTCredit"), CompilerGenerated]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTDebit"), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("GroupBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("TxTBalance"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [CompilerGenerated, AccessedThroughProperty("ButtoSortAll"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("ContextMenuStripGoToInv"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ContextMenuStrip A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CopytoClipToolStripMenuItemToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PrintPSA4ToolStripMenuItem"), CompilerGenerated]
        private ToolStripMenuItem Q;
        [AccessedThroughProperty("PrintPS80ToolStripMenuItem"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator8")]
        private ToolStripSeparator H;
        private SqlConnection A;
        public static int A;
        private DataTable A;
        private string A;
        private int R;

        public QT()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A = "SELECT * FROM TaNNSupliersPay WHERE (SuplierFrontID = @SuplierFrontID)";
            this.R = 0;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(QT));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.ButtoSortAll = new Button();
            this.GroupBox9 = new GroupBox();
            this.TxTCredit = new Label();
            this.GroupBox3 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.GroupBox8 = new GroupBox();
            this.TxTDebit = new Label();
            this.GroupBox2 = new GroupBox();
            this.TxTBalance = new Label();
            this.GroupBox5 = new GroupBox();
            this.SuplierName = new Label();
            this.GroupBox4 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.ButtonSortDate = new Button();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonViewAll = new ToolStripButton();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.A4ToolStripMenuItemPrintPay = new ToolStripMenuItem();
            this.PrintPSA4ToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.PrintPS80ToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.A4ToolStripMenuItemPrintAll = new ToolStripMenuItem();
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
            this.ContextMenuStripGoToInv = new ContextMenuStrip(this.A);
            this.CopytoClipToolStripMenuItemToolStripMenuItem = new ToolStripMenuItem();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.ContextMenuStripGoToInv.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d8, 0x22);
            this.TxTTitle.TabIndex = 0x55;
            this.TxTTitle.Text = "كرت المورد";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 0x95);
            this.TabControl1.TabIndex = 0x65;
            this.TabPage1.Controls.Add(this.ButtoSortAll);
            this.TabPage1.Controls.Add(this.GroupBox9);
            this.TabPage1.Controls.Add(this.GroupBox3);
            this.TabPage1.Controls.Add(this.GroupBox8);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.GroupBox5);
            this.TabPage1.Controls.Add(this.GroupBox4);
            this.TabPage1.Controls.Add(this.ButtonSortDate);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3d0, 120);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الرئيسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtoSortAll.FlatAppearance.BorderColor = Color.Green;
            this.ButtoSortAll.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtoSortAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtoSortAll.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtoSortAll.FlatStyle = FlatStyle.Flat;
            this.ButtoSortAll.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtoSortAll.Image = A.F.ImView;
            this.ButtoSortAll.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtoSortAll.Location = new Point(780, 0x3e);
            this.ButtoSortAll.Margin = new Padding(3, 4, 3, 4);
            this.ButtoSortAll.Name = "ButtoSortAll";
            this.ButtoSortAll.Size = new Size(0xb9, 0x2f);
            this.ButtoSortAll.TabIndex = 0x65;
            this.ButtoSortAll.Text = "عرض كل الحساب";
            this.ButtoSortAll.UseVisualStyleBackColor = true;
            this.GroupBox9.Controls.Add(this.TxTCredit);
            this.GroupBox9.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox9.Location = new Point(8, 11);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x88, 50);
            this.GroupBox9.TabIndex = 100;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "دائن";
            this.TxTCredit.BackColor = Color.White;
            this.TxTCredit.Dock = DockStyle.Fill;
            this.TxTCredit.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTCredit.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.TxTCredit.Location = new Point(3, 0x13);
            this.TxTCredit.Name = "TxTCredit";
            this.TxTCredit.RightToLeft = RightToLeft.No;
            this.TxTCredit.Size = new Size(130, 0x1c);
            this.TxTCredit.TabIndex = 90;
            this.TxTCredit.Text = "0";
            this.TxTCredit.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox3.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox3.Location = new Point(0x30f, 13);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0xb9, 0x2f);
            this.GroupBox3.TabIndex = 0x5c;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "من تاريخ";
            this.DateTimePickerFrom.CustomFormat = "";
            this.DateTimePickerFrom.Dock = DockStyle.Bottom;
            this.DateTimePickerFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePickerFrom.Format = DateTimePickerFormat.Short;
            this.DateTimePickerFrom.Location = new Point(3, 0x15);
            this.DateTimePickerFrom.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.RightToLeft = RightToLeft.No;
            this.DateTimePickerFrom.Size = new Size(0xb3, 0x17);
            this.DateTimePickerFrom.TabIndex = 0x41;
            this.GroupBox8.Controls.Add(this.TxTDebit);
            this.GroupBox8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox8.Location = new Point(0x97, 11);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x88, 50);
            this.GroupBox8.TabIndex = 0x63;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "مدين";
            this.TxTDebit.BackColor = Color.White;
            this.TxTDebit.Dock = DockStyle.Fill;
            this.TxTDebit.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDebit.ForeColor = Color.Red;
            this.TxTDebit.Location = new Point(3, 0x13);
            this.TxTDebit.Name = "TxTDebit";
            this.TxTDebit.RightToLeft = RightToLeft.No;
            this.TxTDebit.Size = new Size(130, 0x1c);
            this.TxTDebit.TabIndex = 90;
            this.TxTDebit.Text = "0";
            this.TxTDebit.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox2.Controls.Add(this.TxTBalance);
            this.GroupBox2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox2.Location = new Point(8, 0x42);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x117, 50);
            this.GroupBox2.TabIndex = 0x62;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "الرصيد";
            this.TxTBalance.Dock = DockStyle.Fill;
            this.TxTBalance.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTBalance.Location = new Point(3, 0x13);
            this.TxTBalance.Name = "TxTBalance";
            this.TxTBalance.RightToLeft = RightToLeft.No;
            this.TxTBalance.Size = new Size(0x111, 0x1c);
            this.TxTBalance.TabIndex = 0;
            this.TxTBalance.Text = "0";
            this.TxTBalance.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox5.Controls.Add(this.SuplierName);
            this.GroupBox5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.GroupBox5.Location = new Point(0x12e, 9);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(280, 0x30);
            this.GroupBox5.TabIndex = 0x5d;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "المورد";
            this.SuplierName.BackColor = Color.White;
            this.SuplierName.Dock = DockStyle.Fill;
            this.SuplierName.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.SuplierName.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.SuplierName.Location = new Point(3, 0x13);
            this.SuplierName.Name = "SuplierName";
            this.SuplierName.Size = new Size(0x112, 0x1a);
            this.SuplierName.TabIndex = 90;
            this.SuplierName.Text = "-";
            this.SuplierName.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox4.Controls.Add(this.DateTimePickerTo);
            this.GroupBox4.Location = new Point(0x254, 10);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0xb5, 0x2f);
            this.GroupBox4.TabIndex = 0x5d;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "الى تاريخ";
            this.DateTimePickerTo.CustomFormat = "";
            this.DateTimePickerTo.Dock = DockStyle.Bottom;
            this.DateTimePickerTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePickerTo.Format = DateTimePickerFormat.Short;
            this.DateTimePickerTo.Location = new Point(3, 0x15);
            this.DateTimePickerTo.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.RightToLeft = RightToLeft.No;
            this.DateTimePickerTo.Size = new Size(0xaf, 0x17);
            this.DateTimePickerTo.TabIndex = 0x41;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(0x254, 0x3e);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(0xb5, 0x2f);
            this.ButtonSortDate.TabIndex = 0x5e;
            this.ButtonSortDate.Text = "فرز حسب الفترة";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[10];
            toolStripItems[0] = this.ToolStripButtonViewAll;
            toolStripItems[1] = this.ToolStripSeparator3;
            toolStripItems[2] = this.ToolStripButtonAdd;
            toolStripItems[3] = this.ToolStripSeparator2;
            toolStripItems[4] = this.ToolStripButtonDelete;
            toolStripItems[5] = this.ToolStripSeparator4;
            toolStripItems[6] = this.ToolStripButtonPrint;
            toolStripItems[7] = this.ToolStripSeparator6;
            toolStripItems[8] = this.ToolStripButtonClose;
            toolStripItems[9] = this.ToolStripSeparator7;
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x1e2);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x66;
            this.ToolStripButtonViewAll.Image = A.F.ImView;
            this.ToolStripButtonViewAll.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonViewAll.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonViewAll.Name = "ToolStripButtonViewAll";
            this.ToolStripButtonViewAll.Size = new Size(0x5b, 0x2c);
            this.ToolStripButtonViewAll.Text = "عرض الكل";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x2f);
            this.ToolStripButtonAdd.Image = A.F.ImAdd;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(0xc2, 0x2c);
            this.ToolStripButtonAdd.Text = "اضافة حركة لكشف الحساب";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
            this.ToolStripButtonDelete.Image = A.F.ImDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(0x9c, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف الحركة المحددة";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.A4ToolStripMenuItemPrintPay, this.ToolStripSeparator5, this.A4ToolStripMenuItemPrintAll };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray2);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x56, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة";
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.PrintPSA4ToolStripMenuItem, this.ToolStripSeparator8, this.PrintPS80ToolStripMenuItem };
            this.A4ToolStripMenuItemPrintPay.DropDownItems.AddRange(itemArray3);
            this.A4ToolStripMenuItemPrintPay.Image = (Image) manager.GetObject("A4ToolStripMenuItemPrintPay.Image");
            this.A4ToolStripMenuItemPrintPay.ImageScaling = ToolStripItemImageScaling.None;
            this.A4ToolStripMenuItemPrintPay.Name = "A4ToolStripMenuItemPrintPay";
            this.A4ToolStripMenuItemPrintPay.Size = new Size(0xdd, 0x26);
            this.A4ToolStripMenuItemPrintPay.Text = "وصل في الدفعة المحددة";
            this.PrintPSA4ToolStripMenuItem.Name = "PrintPSA4ToolStripMenuItem";
            this.PrintPSA4ToolStripMenuItem.Size = new Size(0xba, 0x16);
            this.PrintPSA4ToolStripMenuItem.Text = "ورق قياس A4";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new Size(0xb7, 6);
            this.PrintPS80ToolStripMenuItem.Name = "PrintPS80ToolStripMenuItem";
            this.PrintPS80ToolStripMenuItem.Size = new Size(0xba, 0x16);
            this.PrintPS80ToolStripMenuItem.Text = "ورق حراري قياس 80";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(0xda, 6);
            this.A4ToolStripMenuItemPrintAll.Image = (Image) manager.GetObject("A4ToolStripMenuItemPrintAll.Image");
            this.A4ToolStripMenuItemPrintAll.ImageScaling = ToolStripItemImageScaling.None;
            this.A4ToolStripMenuItemPrintAll.Name = "A4ToolStripMenuItemPrintAll";
            this.A4ToolStripMenuItemPrintAll.Size = new Size(0xdd, 0x26);
            this.A4ToolStripMenuItemPrintAll.Text = "كشف حساب المورد A4";
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
            ToolStripItem[] itemArray4 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray4);
            this.ToolStripStatus.Location = new Point(0, 0x211);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x67;
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
            this.GV.ContextMenuStrip = this.ContextMenuStripGoToInv;
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
            this.GV.Size = new Size(0x3d8, 0x12b);
            this.GV.TabIndex = 0x1ed36ce;
            ToolStripItem[] itemArray5 = new ToolStripItem[] { this.CopytoClipToolStripMenuItemToolStripMenuItem };
            this.ContextMenuStripGoToInv.Items.AddRange(itemArray5);
            this.ContextMenuStripGoToInv.Name = "ContextMenuStripCopyClipBoard";
            this.ContextMenuStripGoToInv.RightToLeft = RightToLeft.Yes;
            this.ContextMenuStripGoToInv.Size = new Size(0xb5, 0x1a);
            this.CopytoClipToolStripMenuItemToolStripMenuItem.Name = "CopytoClipToolStripMenuItemToolStripMenuItem";
            this.CopytoClipToolStripMenuItemToolStripMenuItem.Size = new Size(180, 0x16);
            this.CopytoClipToolStripMenuItemToolStripMenuItem.Text = "عرض تفاصيل الفاتورة";
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3d8, 0x22a);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "SuplierCard";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "كرت المورد";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            this.ContextMenuStripGoToInv.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
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
                        IT.A = QT.A;
                        IT.R = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["SuplierPayID"].Value.ToString());
                        A.D.A.A.ShowDialog();
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
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else if (Conversion.Val(this.GV.SelectedRows[0].Cells["InvPurchIDFront"].Value.ToString()) <= 0.0)
            {
                Interaction.MsgBox("الحركة المحددة لا تتبع لأي فاتورة او انها دفعة عادية", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                GD.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["InvPurchIDFront"].Value.ToString());
                A.D.A.A.ShowDialog();
            }
        }

        private void F(object A, EventArgs R)
        {
            try
            {
                if (!PR.GP)
                {
                    Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
                }
                else if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    A.D.A.A.F();
                    PT.A = QT.A;
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
            XR.A = true;
            this.A = "SELECT * FROM TaNNSupliersPay WHERE (SuplierFrontID = @SuplierFrontID)";
            this.TimerLoadData.Enabled = true;
        }

        private void H(object A, EventArgs R)
        {
            this.A = "SELECT * FROM TaNNSupliersPay WHERE (SuplierFrontID = @SuplierFrontID)";
            this.TimerLoadData.Enabled = true;
        }

        private void I(object A, EventArgs R)
        {
            XR.A = false;
            this.A = "SELECT * FROM TaNNSupliersPay WHERE (SuplierFrontID = @SuplierFrontID) And (PayDateTimer BETWEEN @DF And @DT)";
            this.TimerLoadData.Enabled = true;
        }

        private void K(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                XR.A = QT.A;
                XR.R = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["SuplierPayID"].Value.ToString());
                A.D.A.A.P();
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
                this.A.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("SuplierFrontID", A);
                string text1 = this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd 00:00");
                adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
                string text2 = this.DateTimePickerTo.Value.ToString("yyyy/MM/dd 23:59");
                adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
                adapter.Fill(this.A);
                this.A.Close();
                decimal left = 0M;
                decimal num2 = 0M;
                decimal num3 = 0M;
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
                        object[] arguments = new object[] { "PayMony" };
                        if (Conversion.Val(NewLateBinding.LateIndexGet(current, arguments, null)) > 0.0)
                        {
                            object[] objArray2 = new object[] { "PayMony" };
                            num2 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num2, NewLateBinding.LateIndexGet(current, objArray2, null)));
                        }
                        else
                        {
                            object[] objArray3 = new object[] { "PayMony" };
                            left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, objArray3, null)));
                        }
                        object[] objArray4 = new object[] { "PayMony" };
                        num3 = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(num3, NewLateBinding.LateIndexGet(current, objArray4, null)));
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
                this.TxTBalance.Text = num3.ToString(PR.YR);
                this.GV.DataSource = this.A;
                this.GV.Refresh();
                this.GV.Columns["SuplierPayID"].HeaderText = "رمز الحركة/السند";
                this.GV.Columns["CenterFrontID"].HeaderText = "رمز الفرع";
                this.GV.Columns["SuplierFrontID"].Visible = false;
                this.GV.Columns["InvPurchIDFront"].Visible = false;
                this.GV.Columns["PayType"].HeaderText = "نوع الحركة";
                this.GV.Columns["PayMethods"].Visible = false;
                this.GV.Columns["PayDateTimer"].HeaderText = "التاريخ والوقت";
                this.GV.Columns["PayDesic"].HeaderText = "الوصف";
                this.GV.Columns["PayMony"].HeaderText = "المبلغ";
                this.GV.Columns["PayEmploy"].HeaderText = "الموظف";
                this.GV.Columns["PayNote"].HeaderText = "ملاحظات";
                this.GV.Columns["PayIsCashCount"].HeaderText = "مقيدة على الكاش";
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.ToolStripButtonDelete.Enabled = this.GV.RowCount > 0;
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
                        decimal num4 = new decimal(Conversion.Val(current.Cells["PayMony"].Value.ToString()));
                        if (decimal.Compare(num4, decimal.Zero) > 0)
                        {
                            current.Cells["PayMony"].Style.ForeColor = Color.Blue;
                        }
                        else if (decimal.Compare(num4, decimal.Zero) < 0)
                        {
                            current.Cells["PayMony"].Style.ForeColor = Color.Red;
                        }
                        current.Cells["PayMony"].Value = num4.ToString(PR.YR);
                        decimal num5 = new decimal(Conversion.Val(current.Cells["PayType"].Value.ToString()));
                        if (decimal.Compare(num5, new decimal((long) 100)) == 0)
                        {
                            current.Cells["PayType"].Value = "فاتورة مشتريات";
                        }
                        else if (decimal.Compare(num5, new decimal((long) 0x65)) == 0)
                        {
                            current.Cells["PayType"].Value = "دفعة فاتورة مشتريات";
                        }
                        else if (decimal.Compare(num5, 200M) == 0)
                        {
                            current.Cells["PayType"].Value = "فاتورة مرتجع مشتريات";
                        }
                        else if (decimal.Compare(num5, 201M) == 0)
                        {
                            current.Cells["PayType"].Value = "دفعة فاتورة مرتجع مشتريات";
                        }
                        else if (decimal.Compare(num5, 500M) == 0)
                        {
                            current.Cells["PayType"].Value = "حركة مضافة";
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

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            A.D.A.A.TimerLoadData.Enabled = true;
            base.Dispose();
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerLoadData.Enabled = true;
        }

        private void T(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
            this.P();
        }

        private void U(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                XR.A = QT.A;
                XR.R = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["SuplierPayID"].Value.ToString());
                A.D.A.A.Q();
            }
        }

        private void X(object A, EventArgs R)
        {
            XR.A = QT.A;
            XR.A = this.TxTDebit.Text;
            XR.R = this.TxTCredit.Text;
            XR.P = this.TxTBalance.Text;
            A.D.A.A.R();
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

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label SuplierName
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual DateTimePicker DateTimePickerFrom
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

        internal virtual GroupBox GroupBox4
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual ToolStripSeparator ToolStripSeparator3
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

        internal virtual ToolStripSeparator ToolStripSeparator2
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
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripButton ToolStripButtonClose
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual ToolStripMenuItem A4ToolStripMenuItemPrintPay
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator5
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual ToolStripMenuItem A4ToolStripMenuItemPrintAll
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTCredit
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label TxTDebit
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label TxTBalance
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Button ButtoSortAll
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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

        internal virtual ContextMenuStrip ContextMenuStripGoToInv
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem CopytoClipToolStripMenuItemToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual ToolStripMenuItem PrintPSA4ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
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

        internal virtual ToolStripMenuItem PrintPS80ToolStripMenuItem
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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

        internal virtual ToolStripSeparator ToolStripSeparator8
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

