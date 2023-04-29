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
    public class U : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTTitle")]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripButtons")]
        private ToolStrip A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonDelete"), CompilerGenerated]
        private ToolStripDropDownButton A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonDeleteMulti")]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("ToolStripSeparator20"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [AccessedThroughProperty("ButtonDeleteOne"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("ToolStripSeparator9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator6")]
        private ToolStripSeparator P;
        [AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator7")]
        private ToolStripSeparator Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox A;
        [AccessedThroughProperty("GroupBox15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("MDarVal")]
        private TextBox A;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Button2Q")]
        private Button A;
        [AccessedThroughProperty("MName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox13"), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("MDarMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("GroupBox14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [CompilerGenerated, AccessedThroughProperty("MDisVal"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3"), CompilerGenerated]
        private GroupBox D;
        [AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [AccessedThroughProperty("MSale"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [AccessedThroughProperty("MDisMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [CompilerGenerated, AccessedThroughProperty("GroupBox11"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MSTotal")]
        private TextBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerLoadData")]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimersStartUp")]
        private Timer R;
        [AccessedThroughProperty("TimerFillGV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer P;
        [AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonAdd")]
        private Button R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox6")]
        private GroupBox X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTLoop"), CompilerGenerated]
        private TextBox F;
        [AccessedThroughProperty("GroupBox4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MNote")]
        private TextBox H;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MBarCode")]
        private TextBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonPrint"), CompilerGenerated]
        private ToolStripDropDownButton R;
        [CompilerGenerated, AccessedThroughProperty("ToolStripMenuItem33"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem P;
        [AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripMenuItem22"), CompilerGenerated]
        private ToolStripMenuItem Q;
        private SqlConnection A;
        private DataTable A;
        private string A;

        public U()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A = "SELECT * FROM TaNNBarCodeMult WHERE (CenterFrontID = @CenterFrontID)";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(A.U));
            this.TxTTitle = new Label();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonDelete = new ToolStripDropDownButton();
            this.ButtonDeleteMulti = new ToolStripMenuItem();
            this.ToolStripSeparator20 = new ToolStripSeparator();
            this.ButtonDeleteOne = new ToolStripMenuItem();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.ToolStripButtonPrint = new ToolStripDropDownButton();
            this.ToolStripMenuItem33 = new ToolStripMenuItem();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.ToolStripMenuItem22 = new ToolStripMenuItem();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.GroupBox1 = new GroupBox();
            this.GroupBox11 = new GroupBox();
            this.MSTotal = new TextBox();
            this.GroupBox15 = new GroupBox();
            this.MDarVal = new TextBox();
            this.GroupBox2 = new GroupBox();
            this.Button2Q = new Button();
            this.MName = new ComboBox();
            this.GroupBox13 = new GroupBox();
            this.MDarMiWi = new TextBox();
            this.GroupBox14 = new GroupBox();
            this.MDisVal = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.MBarCode = new TextBox();
            this.GroupBox8 = new GroupBox();
            this.MSale = new TextBox();
            this.GroupBox12 = new GroupBox();
            this.MDisMiWi = new TextBox();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TimerFillGV = new Timer(this.A);
            this.GV = new DataGridView();
            this.GroupBox6 = new GroupBox();
            this.TxTLoop = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.MNote = new TextBox();
            this.ButtonAdd = new Button();
            this.ToolStripButtons.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.GroupBox6.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x2a7, 0x22);
            this.TxTTitle.TabIndex = 0x3e;
            this.TxTTitle.Text = "باركود متعدد";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonDelete, this.ToolStripSeparator9, this.ToolStripButtonPrint, this.ToolStripSeparator6, this.ToolStripButtonClose, this.ToolStripSeparator7 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x1c7);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x2a7, 0x2f);
            this.ToolStripButtons.TabIndex = 0x51;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.ButtonDeleteMulti, this.ToolStripSeparator20, this.ButtonDeleteOne };
            this.ToolStripButtonDelete.DropDownItems.AddRange(itemArray2);
            this.ToolStripButtonDelete.Image = A.F.ImDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(80, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف";
            this.ButtonDeleteMulti.Name = "ButtonDeleteMulti";
            this.ButtonDeleteMulti.Size = new Size(0xbb, 0x16);
            this.ButtonDeleteMulti.Text = "حذف كل القائمة";
            this.ToolStripSeparator20.Name = "ToolStripSeparator20";
            this.ToolStripSeparator20.Size = new Size(0xb8, 6);
            this.ButtonDeleteOne.Name = "ButtonDeleteOne";
            this.ButtonDeleteOne.Size = new Size(0xbb, 0x16);
            this.ButtonDeleteOne.Text = "حذف السجل المحدد";
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ToolStripMenuItem33, this.ToolStripSeparator1, this.ToolStripMenuItem22 };
            this.ToolStripButtonPrint.DropDownItems.AddRange(itemArray3);
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x56, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة";
            this.ToolStripMenuItem33.Image = (Image) manager.GetObject("ToolStripMenuItem33.Image");
            this.ToolStripMenuItem33.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripMenuItem33.Name = "ToolStripMenuItem33";
            this.ToolStripMenuItem33.Size = new Size(0xf6, 0x26);
            this.ToolStripMenuItem33.Text = "ورق قياس A4 عدد الأعمدة 3";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(0xf3, 6);
            this.ToolStripMenuItem22.Image = (Image) manager.GetObject("ToolStripMenuItem22.Image");
            this.ToolStripMenuItem22.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripMenuItem22.Name = "ToolStripMenuItem22";
            this.ToolStripMenuItem22.Size = new Size(0xf6, 0x26);
            this.ToolStripMenuItem22.Text = "ورق قياس A4 عدد الأعمدة 2";
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
            this.GroupBox1.Controls.Add(this.GroupBox11);
            this.GroupBox1.Controls.Add(this.GroupBox15);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.GroupBox13);
            this.GroupBox1.Controls.Add(this.GroupBox14);
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.GroupBox8);
            this.GroupBox1.Controls.Add(this.GroupBox12);
            this.GroupBox1.Dock = DockStyle.Top;
            this.GroupBox1.Location = new Point(0, 0x22);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x2a7, 0x94);
            this.GroupBox1.TabIndex = 0x52;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "تفصيلات المادة";
            this.GroupBox11.Controls.Add(this.MSTotal);
            this.GroupBox11.Location = new Point(9, 0x51);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x8d, 0x35);
            this.GroupBox11.TabIndex = 0x1ed36cb;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "صافي السعر";
            this.MSTotal.BackColor = SystemColors.Info;
            this.MSTotal.Dock = DockStyle.Fill;
            this.MSTotal.Enabled = false;
            this.MSTotal.Location = new Point(3, 0x13);
            this.MSTotal.MaxLength = 50;
            this.MSTotal.Name = "MSTotal";
            this.MSTotal.RightToLeft = RightToLeft.No;
            this.MSTotal.Size = new Size(0x87, 0x17);
            this.MSTotal.TabIndex = 0;
            this.MSTotal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox15.Controls.Add(this.MDarVal);
            this.GroupBox15.Location = new Point(0x9c, 0x51);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x5f, 0x35);
            this.GroupBox15.TabIndex = 0x1ed36cf;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "مبلغ الضريبة";
            this.MDarVal.BackColor = Color.White;
            this.MDarVal.Dock = DockStyle.Fill;
            this.MDarVal.Enabled = false;
            this.MDarVal.Location = new Point(3, 0x13);
            this.MDarVal.MaxLength = 5;
            this.MDarVal.Name = "MDarVal";
            this.MDarVal.RightToLeft = RightToLeft.No;
            this.MDarVal.Size = new Size(0x59, 0x17);
            this.MDarVal.TabIndex = 0;
            this.MDarVal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox2.Controls.Add(this.Button2Q);
            this.GroupBox2.Controls.Add(this.MName);
            this.GroupBox2.Location = new Point(9, 0x16);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x185, 0x35);
            this.GroupBox2.TabIndex = 0x1ed36c6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "اسم المادة";
            this.Button2Q.FlatAppearance.BorderColor = Color.Green;
            this.Button2Q.FlatAppearance.CheckedBackColor = Color.White;
            this.Button2Q.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Button2Q.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.Button2Q.FlatStyle = FlatStyle.Flat;
            this.Button2Q.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Button2Q.Image = A.F.ImView;
            this.Button2Q.Location = new Point(6, 15);
            this.Button2Q.Margin = new Padding(3, 4, 3, 4);
            this.Button2Q.Name = "Button2Q";
            this.Button2Q.Size = new Size(0x2d, 0x1f);
            this.Button2Q.TabIndex = 0x1ed36d0;
            this.Button2Q.UseVisualStyleBackColor = true;
            this.MName.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.MName.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.MName.BackColor = SystemColors.Info;
            this.MName.Dock = DockStyle.Right;
            this.MName.FormattingEnabled = true;
            this.MName.IntegralHeight = false;
            this.MName.Location = new Point(0x39, 0x13);
            this.MName.Name = "MName";
            this.MName.Size = new Size(0x149, 0x18);
            this.MName.TabIndex = 1;
            this.GroupBox13.Controls.Add(this.MDarMiWi);
            this.GroupBox13.Location = new Point(0x101, 0x51);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(0x4d, 0x35);
            this.GroupBox13.TabIndex = 0x1ed36cd;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "الضريبة %";
            this.MDarMiWi.BackColor = Color.White;
            this.MDarMiWi.Dock = DockStyle.Fill;
            this.MDarMiWi.Location = new Point(3, 0x13);
            this.MDarMiWi.MaxLength = 5;
            this.MDarMiWi.Name = "MDarMiWi";
            this.MDarMiWi.RightToLeft = RightToLeft.No;
            this.MDarMiWi.Size = new Size(0x47, 0x17);
            this.MDarMiWi.TabIndex = 0;
            this.MDarMiWi.TextAlign = HorizontalAlignment.Center;
            this.GroupBox14.Controls.Add(this.MDisVal);
            this.GroupBox14.Location = new Point(0x15f, 0x51);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Size = new Size(0x5f, 0x35);
            this.GroupBox14.TabIndex = 0x1ed36ce;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "مبلغ الخصم";
            this.MDisVal.BackColor = Color.White;
            this.MDisVal.Dock = DockStyle.Fill;
            this.MDisVal.Location = new Point(3, 0x13);
            this.MDisVal.MaxLength = 5;
            this.MDisVal.Name = "MDisVal";
            this.MDisVal.RightToLeft = RightToLeft.No;
            this.MDisVal.Size = new Size(0x59, 0x17);
            this.MDisVal.TabIndex = 0;
            this.MDisVal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.MBarCode);
            this.GroupBox3.Location = new Point(0x194, 0x16);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x106, 0x35);
            this.GroupBox3.TabIndex = 0x1ed36c7;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم المادة";
            this.MBarCode.BackColor = SystemColors.Info;
            this.MBarCode.Dock = DockStyle.Fill;
            this.MBarCode.Location = new Point(3, 0x13);
            this.MBarCode.MaxLength = 50;
            this.MBarCode.Name = "MBarCode";
            this.MBarCode.RightToLeft = RightToLeft.No;
            this.MBarCode.Size = new Size(0x100, 0x17);
            this.MBarCode.TabIndex = 1;
            this.MBarCode.TextAlign = HorizontalAlignment.Center;
            this.GroupBox8.Controls.Add(this.MSale);
            this.GroupBox8.Location = new Point(0x217, 0x51);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x83, 0x35);
            this.GroupBox8.TabIndex = 0x1ed36ca;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "السعر";
            this.MSale.BackColor = SystemColors.Info;
            this.MSale.Dock = DockStyle.Fill;
            this.MSale.Location = new Point(3, 0x13);
            this.MSale.MaxLength = 50;
            this.MSale.Name = "MSale";
            this.MSale.RightToLeft = RightToLeft.No;
            this.MSale.Size = new Size(0x7d, 0x17);
            this.MSale.TabIndex = 0;
            this.MSale.TextAlign = HorizontalAlignment.Center;
            this.GroupBox12.Controls.Add(this.MDisMiWi);
            this.GroupBox12.Location = new Point(0x1c4, 0x51);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x4d, 0x35);
            this.GroupBox12.TabIndex = 0x1ed36cc;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "الخصم %";
            this.MDisMiWi.BackColor = Color.White;
            this.MDisMiWi.Dock = DockStyle.Fill;
            this.MDisMiWi.Location = new Point(3, 0x13);
            this.MDisMiWi.MaxLength = 5;
            this.MDisMiWi.Name = "MDisMiWi";
            this.MDisMiWi.RightToLeft = RightToLeft.No;
            this.MDisMiWi.Size = new Size(0x47, 0x17);
            this.MDisMiWi.TabIndex = 0;
            this.MDisMiWi.TextAlign = HorizontalAlignment.Center;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Dock = DockStyle.Bottom;
            this.GV.Location = new Point(0, 0x102);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x2a7, 0xc5);
            this.GV.TabIndex = 0x1ed36cb;
            this.GroupBox6.Controls.Add(this.TxTLoop);
            this.GroupBox6.Location = new Point(0xd3, 190);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x80, 0x3e);
            this.GroupBox6.TabIndex = 0x1ed36cf;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "عدد الملصقات";
            this.TxTLoop.BackColor = SystemColors.Info;
            this.TxTLoop.Dock = DockStyle.Fill;
            this.TxTLoop.Location = new Point(3, 0x13);
            this.TxTLoop.Name = "TxTLoop";
            this.TxTLoop.RightToLeft = RightToLeft.No;
            this.TxTLoop.Size = new Size(0x7a, 0x17);
            this.TxTLoop.TabIndex = 0x1ed36cd;
            this.TxTLoop.Text = "1";
            this.TxTLoop.TextAlign = HorizontalAlignment.Center;
            this.GroupBox4.Controls.Add(this.MNote);
            this.GroupBox4.Location = new Point(13, 190);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0xc3, 0x3e);
            this.GroupBox4.TabIndex = 0x1ed36d0;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "ملاحظات";
            this.MNote.BackColor = SystemColors.Info;
            this.MNote.Dock = DockStyle.Fill;
            this.MNote.Location = new Point(3, 0x13);
            this.MNote.MaxLength = 0xbb8;
            this.MNote.Name = "MNote";
            this.MNote.RightToLeft = RightToLeft.No;
            this.MNote.Size = new Size(0xbd, 0x17);
            this.MNote.TabIndex = 0x1ed36cd;
            this.MNote.TextAlign = HorizontalAlignment.Center;
            this.ButtonAdd.BackColor = SystemColors.Window;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.Image = A.F.Im_Below;
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(0x159, 0xbd);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0x145, 0x3e);
            this.ButtonAdd.TabIndex = 0x1ed36ca;
            this.ButtonAdd.Text = "اضافة";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2a7, 0x1f6);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.GroupBox6);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.ButtonAdd);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "BarCodeMultipl";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "باركود متعدد";
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox15.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox13.PerformLayout();
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox14.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = true;
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void D(object A, EventArgs R)
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
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNBarCodeMult WHERE (BID = @BID)", this.A);
                        command.Parameters.AddWithValue("BID", this.GV.SelectedRows[0].Cells["BID"].Value.ToString());
                        command.ExecuteNonQuery();
                        this.A.Close();
                        this.TimerLoadData.Enabled = true;
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
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

        private void D(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
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
            this.R();
        }

        private void F(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNBarCodeMult WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.TimerLoadData.Enabled = true;
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
        }

        private void F(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void G(object A, EventArgs R)
        {
            this.R();
        }

        private void H(object A, EventArgs R)
        {
            this.R();
        }

        private void H(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.Q();
            }
        }

        private void I(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void I(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void K(object A, EventArgs R)
        {
        }

        private void L(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        private void N(object A, EventArgs R)
        {
        }

        private void O(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                A.SR sr = new A.SR();
                sr.SetDataSource(this.A);
                new HR { CRViewer = { ReportSource = sr } }.ShowDialog();
                sr.Close();
                sr.Dispose();
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
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                this.A.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(this.A);
                this.A.Close();
                this.GV.DataSource = this.A;
                this.GV.Refresh();
                this.GV.Columns["BID"].Visible = false;
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["MBarCode"].HeaderText = "رقم/باركود";
                this.GV.Columns["MName"].HeaderText = "المادة";
                this.GV.Columns["MPrice"].HeaderText = "السعر";
                this.GV.Columns["MNote"].HeaderText = "ملاحظات";
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.ToolStripButtonDelete.Enabled = this.GV.RowCount > 0;
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
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
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

        private void Q(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
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
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataSet dataSet = new DataSet();
                string selectCommandText = "SELECT * FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)";
                dataSet.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataSet, "TaNNMaterial");
                this.A.Close();
                this.MName.ValueMember = "MaterialBarCode";
                this.MName.DisplayMember = "MaterialName";
                this.MName.DataSource = dataSet.Tables[0];
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
                return;
            }
            this.TimerLoadData.Enabled = true;
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void T(object A, EventArgs R)
        {
            this.R();
        }

        private void U(object A, EventArgs R)
        {
            if (!((this.MBarCode.Text == null) | (this.MName.Text == null)))
            {
                int num2 = (int) Math.Round((double) (Conversion.Val(this.TxTLoop.Text.Trim()) - 1.0));
                for (int i = 0; i <= num2; i++)
                {
                    try
                    {
                        string str = "*" + this.MBarCode.Text + "*";
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("INSERT INTO [TaNNBarCodeMult] ([CenterFrontID], [MBarCode], [MName], [MPrice], [MNote]) VALUES (@CenterFrontID, @MBarCode, @MName, @MPrice, @MNote)", this.A);
                        command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                        command.Parameters.AddWithValue("MBarCode", str.ToString());
                        command.Parameters.AddWithValue("MName", this.MName.Text.ToString());
                        command.Parameters.AddWithValue("MPrice", this.MSTotal.Text.Trim());
                        command.Parameters.AddWithValue("MNote", this.MNote.Text.Trim());
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    catch (Exception exception1)
                    {
                        Exception ex = exception1;
                        ProjectData.SetProjectError(ex);
                        Exception exception = ex;
                        ProjectData.ClearProjectError();
                        break;
                    }
                }
            }
            else
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
                return;
            }
            this.TimerLoadData.Enabled = true;
        }

        private void V(object A, EventArgs R)
        {
            this.MBarCode.Text = Conversions.ToString(this.MName.SelectedValue);
            this.Q();
        }

        private void X(object A, EventArgs R)
        {
            this.R();
        }

        private void Y(object A, EventArgs R)
        {
            Application.DoEvents();
            try
            {
                OR or = new OR();
                or.SetDataSource(this.A);
                new HR { CRViewer = { ReportSource = or } }.ShowDialog();
                or.Close();
                or.Dispose();
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

        internal virtual ToolStripDropDownButton ToolStripButtonDelete
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem ButtonDeleteMulti
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

        internal virtual ToolStripSeparator ToolStripSeparator20
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem ButtonDeleteOne
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

        internal virtual ToolStripSeparator ToolStripSeparator9
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripButton ToolStripButtonClose
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

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox MDarVal
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.I);
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button Button2Q
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
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

        internal virtual ComboBox MName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.V);
                ComboBox a = this.A;
                if (a != null)
                {
                    a.SelectedValueChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.SelectedValueChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox MDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
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

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox MDisVal
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual TextBox MSale
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.TextChanged -= handler;
                    q.KeyPress -= handler2;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.TextChanged += handler;
                    q.KeyPress += handler2;
                }
            }
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

        internal virtual TextBox MDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
                TextBox i = this.I;
                if (i != null)
                {
                    i.TextChanged -= handler;
                    i.KeyPress -= handler2;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.TextChanged += handler;
                    i.KeyPress += handler2;
                }
            }
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

        internal virtual TextBox MSTotal
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.D);
                TextBox d = this.D;
                if (d != null)
                {
                    d.TextChanged -= handler;
                    d.KeyPress -= handler2;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.TextChanged += handler;
                    d.KeyPress += handler2;
                }
            }
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
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
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TextBox TxTLoop
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.F);
                TextBox f = this.F;
                if (f != null)
                {
                    f.TextChanged -= handler;
                    f.KeyPress -= handler2;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.TextChanged += handler;
                    f.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TextBox MNote
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox MBarCode
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.H);
                TextBox t = this.T;
                if (t != null)
                {
                    t.KeyPress -= handler;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.KeyPress += handler;
                }
            }
        }

        internal virtual ToolStripDropDownButton ToolStripButtonPrint
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripMenuItem ToolStripMenuItem33
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Y);
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

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripMenuItem ToolStripMenuItem22
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.O);
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
    }
}

