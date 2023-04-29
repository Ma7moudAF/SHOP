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
    public class FF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("ButtonAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("MSale"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox P;
        [AccessedThroughProperty("MNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [AccessedThroughProperty("MUnit"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [AccessedThroughProperty("GroupBox11"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox F;
        [AccessedThroughProperty("MSTotal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Q;
        [AccessedThroughProperty("GroupBox10"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox H;
        [AccessedThroughProperty("MQantity"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox I;
        [AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView A;
        [AccessedThroughProperty("GroupBox13"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox T;
        [AccessedThroughProperty("MDarMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox D;
        [AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox X;
        [AccessedThroughProperty("MDisMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox F;
        [AccessedThroughProperty("MName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ComboBox A;
        [AccessedThroughProperty("GroupBox15"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox G;
        [AccessedThroughProperty("MDarVal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox H;
        [AccessedThroughProperty("Button2Q"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("GroupBox14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox E;
        [AccessedThroughProperty("MDisVal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox T;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("ToolStripButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonDelete"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator A;
        [AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton R;
        [AccessedThroughProperty("ToolStripSeparator7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("ToolStripLabel1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripLabel A;
        [AccessedThroughProperty("TxTGVRowCount"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripLabel R;
        [AccessedThroughProperty("ToolStripSeparator1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator P;
        [AccessedThroughProperty("TimerLoadData"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer P;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox K;
        [AccessedThroughProperty("TxTNetTotal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("MBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox X;
        private SqlConnection A;

        public FF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.ButtonAdd = new Button();
            this.GroupBox1 = new GroupBox();
            this.GroupBox10 = new GroupBox();
            this.MQantity = new TextBox();
            this.GroupBox7 = new GroupBox();
            this.MNote = new TextBox();
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
            this.GroupBox6 = new GroupBox();
            this.MUnit = new TextBox();
            this.GroupBox8 = new GroupBox();
            this.MSale = new TextBox();
            this.GroupBox12 = new GroupBox();
            this.MDisMiWi = new TextBox();
            this.GV = new DataGridView();
            this.TxTTitle = new Label();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
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
            this.GroupBox4 = new GroupBox();
            this.TxTNetTotal = new Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            this.GroupBox14.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            base.SuspendLayout();
            this.ButtonAdd.BackColor = Color.WhiteSmoke;
            this.ButtonAdd.Dock = DockStyle.Top;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.Image = A.F.Im_Below;
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(0, 0xb6);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0x3b9, 60);
            this.ButtonAdd.TabIndex = 0x44;
            this.ButtonAdd.Text = "اضافة";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.GroupBox1.Controls.Add(this.GroupBox10);
            this.GroupBox1.Controls.Add(this.GroupBox7);
            this.GroupBox1.Controls.Add(this.GroupBox11);
            this.GroupBox1.Controls.Add(this.GroupBox15);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.GroupBox13);
            this.GroupBox1.Controls.Add(this.GroupBox14);
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.GroupBox6);
            this.GroupBox1.Controls.Add(this.GroupBox8);
            this.GroupBox1.Controls.Add(this.GroupBox12);
            this.GroupBox1.Dock = DockStyle.Top;
            this.GroupBox1.Location = new Point(0, 0x22);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x3b9, 0x94);
            this.GroupBox1.TabIndex = 0x47;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "تفصيلات المادة";
            this.GroupBox10.Controls.Add(this.MQantity);
            this.GroupBox10.Location = new Point(0x1ef, 0x55);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x4f, 0x35);
            this.GroupBox10.TabIndex = 0x1ed36ca;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "الكمية";
            this.MQantity.BackColor = SystemColors.Info;
            this.MQantity.Dock = DockStyle.Fill;
            this.MQantity.Location = new Point(3, 0x13);
            this.MQantity.MaxLength = 50;
            this.MQantity.Name = "MQantity";
            this.MQantity.RightToLeft = RightToLeft.No;
            this.MQantity.Size = new Size(0x49, 0x17);
            this.MQantity.TabIndex = 0;
            this.MQantity.Text = "1";
            this.MQantity.TextAlign = HorizontalAlignment.Center;
            this.GroupBox7.Controls.Add(this.MNote);
            this.GroupBox7.Location = new Point(10, 0x55);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x14e, 0x35);
            this.GroupBox7.TabIndex = 0x1ed36ca;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "ملاحظات";
            this.MNote.BackColor = Color.White;
            this.MNote.Dock = DockStyle.Fill;
            this.MNote.Location = new Point(3, 0x13);
            this.MNote.MaxLength = 0xbb8;
            this.MNote.Multiline = true;
            this.MNote.Name = "MNote";
            this.MNote.Size = new Size(0x148, 0x1f);
            this.MNote.TabIndex = 0;
            this.GroupBox11.Controls.Add(this.MSTotal);
            this.GroupBox11.Location = new Point(0x15c, 0x55);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x8d, 0x35);
            this.GroupBox11.TabIndex = 0x1ed36cb;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "مجموع السعر";
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
            this.GroupBox15.Location = new Point(10, 0x1a);
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
            this.GroupBox2.Location = new Point(580, 0x55);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x175, 0x35);
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
            this.MName.Size = new Size(0x139, 0x18);
            this.MName.TabIndex = 1;
            this.GroupBox13.Controls.Add(this.MDarMiWi);
            this.GroupBox13.Location = new Point(0x6f, 0x1a);
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
            this.GroupBox14.Location = new Point(0xcd, 0x1a);
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
            this.GroupBox3.Location = new Point(0x28f, 0x1a);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x12a, 0x35);
            this.GroupBox3.TabIndex = 0x1ed36c7;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم المادة";
            this.MBarCode.BackColor = SystemColors.Info;
            this.MBarCode.Dock = DockStyle.Fill;
            this.MBarCode.Location = new Point(3, 0x13);
            this.MBarCode.MaxLength = 300;
            this.MBarCode.Name = "MBarCode";
            this.MBarCode.RightToLeft = RightToLeft.No;
            this.MBarCode.Size = new Size(0x124, 0x17);
            this.MBarCode.TabIndex = 1;
            this.MBarCode.TextAlign = HorizontalAlignment.Center;
            this.GroupBox6.Controls.Add(this.MUnit);
            this.GroupBox6.Location = new Point(0x214, 0x1a);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x75, 0x35);
            this.GroupBox6.TabIndex = 0x1ed36c9;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "الوحدة";
            this.MUnit.BackColor = Color.White;
            this.MUnit.Dock = DockStyle.Fill;
            this.MUnit.Location = new Point(3, 0x13);
            this.MUnit.MaxLength = 50;
            this.MUnit.Name = "MUnit";
            this.MUnit.Size = new Size(0x6f, 0x17);
            this.MUnit.TabIndex = 0;
            this.GroupBox8.Controls.Add(this.MSale);
            this.GroupBox8.Location = new Point(0x185, 0x1a);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x89, 0x35);
            this.GroupBox8.TabIndex = 0x1ed36ca;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "السعر الافرادي";
            this.MSale.BackColor = SystemColors.Info;
            this.MSale.Dock = DockStyle.Fill;
            this.MSale.Location = new Point(3, 0x13);
            this.MSale.MaxLength = 50;
            this.MSale.Name = "MSale";
            this.MSale.RightToLeft = RightToLeft.No;
            this.MSale.Size = new Size(0x83, 0x17);
            this.MSale.TabIndex = 0;
            this.MSale.TextAlign = HorizontalAlignment.Center;
            this.GroupBox12.Controls.Add(this.MDisMiWi);
            this.GroupBox12.Location = new Point(0x132, 0x1a);
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
            this.GV.Dock = DockStyle.Top;
            this.GV.Location = new Point(0, 0xf2);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3b9, 0x106);
            this.GV.TabIndex = 0x1ed36c9;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3b9, 0x22);
            this.TxTTitle.TabIndex = 0x1ed36ca;
            this.TxTTitle.Text = "اضافة مادة في العرض";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonDelete, this.ToolStripSeparator4, this.ToolStripButtonClose, this.ToolStripSeparator7 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x1fc);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3b9, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36cc;
            this.ToolStripButtonDelete.Image = A.F.ImDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(0xd3, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف المادة المحددة من العرض";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x2f);
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
            this.ToolStripStatus.Location = new Point(0, 0x22b);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3b9, 0x19);
            this.ToolStripStatus.TabIndex = 0x1ed36cb;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x3f, 0x16);
            this.ToolStripLabel1.Text = "غدد المواد";
            this.TxTGVRowCount.ForeColor = Color.DarkGreen;
            this.TxTGVRowCount.Name = "TxTGVRowCount";
            this.TxTGVRowCount.RightToLeft = RightToLeft.No;
            this.TxTGVRowCount.Size = new Size(0x16, 0x16);
            this.TxTGVRowCount.Text = "00";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
            this.GroupBox4.Controls.Add(this.TxTNetTotal);
            this.GroupBox4.Dock = DockStyle.Bottom;
            this.GroupBox4.Location = new Point(0, 0x1bc);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x3b9, 0x40);
            this.GroupBox4.TabIndex = 0x1ed36cd;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "صافي المجموع";
            this.TxTNetTotal.Dock = DockStyle.Fill;
            this.TxTNetTotal.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTNetTotal.Location = new Point(3, 0x13);
            this.TxTNetTotal.Name = "TxTNetTotal";
            this.TxTNetTotal.Size = new Size(0x3b3, 0x2a);
            this.TxTNetTotal.TabIndex = 0;
            this.TxTNetTotal.Text = "0";
            this.TxTNetTotal.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3b9, 580);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.ButtonAdd);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialPrivewAdd";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة مادة في العرض";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
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
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
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
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNPrivewMatrials WHERE (ItemsID = @ItemsID)", this.A);
                        command.Parameters.AddWithValue("ItemsID", this.GV.SelectedRows[0].Cells["ItemsID"].Value.ToString());
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
            this.Q();
        }

        private void F(object A, EventArgs R)
        {
            decimal num = new decimal(Conversion.Val(this.TxTNetTotal.Text.Replace(",", "")));
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE TaNNPrivewList SET PrivewAmont = @PrivewAmont, PrivewItems =@PrivewItems WHERE (PrivewID = @PrivewID)", this.A);
                command.Parameters.AddWithValue("PrivewID", A.D.A.A.PrivewID.Text);
                command.Parameters.AddWithValue("PrivewAmont", num.ToString(PR.VR));
                command.Parameters.AddWithValue("PrivewItems", this.TxTGVRowCount.Text);
                command.ExecuteNonQuery();
                this.A.Close();
                A.D.A.A.R();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
                return;
            }
            base.Dispose();
        }

        private void F(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void G(object A, EventArgs R)
        {
            this.Q();
        }

        private void H(object A, EventArgs R)
        {
            if ((this.MBarCode.Text == null) | (this.MName.Text == null))
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    decimal num = new decimal(Conversion.Val(this.MSale.Text.Replace(",", "")));
                    decimal num2 = new decimal(Conversion.Val(this.MQantity.Text.Replace(",", "")));
                    decimal num3 = new decimal(Conversion.Val(this.MDisVal.Text.Replace(",", "")));
                    decimal num4 = new decimal(Conversion.Val(this.MDarVal.Text.Replace(",", "")));
                    decimal num5 = new decimal(Conversion.Val(this.MSTotal.Text.Replace(",", "")));
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO [TaNNPrivewMatrials] ([CenterFrontID], [PrivewFrontID], [MBarCode], [MName], [MUnit], [MSale], [MQantity], [MDisMiWi], [MDisVal], [MDarMiWi], [MDarVal], [MSTotal], [MNote]) VALUES (@CenterFrontID, @PrivewFrontID, @MBarCode, @MName, @MUnit, @MSale, @MQantity, @MDisMiWi, @MDisVal, @MDarMiWi, @MDarVal, @MSTotal, @MNote)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("PrivewFrontID", A.D.A.A.PrivewID.Text);
                    command.Parameters.AddWithValue("MBarCode", this.MBarCode.Text.Trim());
                    command.Parameters.AddWithValue("MName", this.MName.Text.Trim());
                    command.Parameters.AddWithValue("MUnit", this.MUnit.Text.Trim());
                    command.Parameters.AddWithValue("MSale", num.ToString(PR.VR));
                    command.Parameters.AddWithValue("MQantity", num2.ToString(PR.OR));
                    command.Parameters.AddWithValue("MDisMiWi", Conversion.Val(this.MDisMiWi.Text.Trim()));
                    command.Parameters.AddWithValue("MDisVal", num3.ToString(PR.VR));
                    command.Parameters.AddWithValue("MDarMiWi", Conversion.Val(this.MDarMiWi.Text.Trim()));
                    command.Parameters.AddWithValue("MDarVal", num4.ToString(PR.VR));
                    command.Parameters.AddWithValue("MSTotal", num5.ToString(PR.VR));
                    command.Parameters.AddWithValue("MNote", this.MNote.Text.Trim());
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.TimerLoadData.Enabled = true;
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

        private void H(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.R();
            }
        }

        private void I(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.P();
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
            this.Q();
        }

        private void L(object A, EventArgs R)
        {
        }

        private void N(object A, EventArgs R)
        {
            this.MBarCode.Text = Conversions.ToString(this.MName.SelectedValue);
            this.R();
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
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT * FROM TaNNPrivewMatrials WHERE (CenterFrontID = @CenterFrontID) AND (PrivewFrontID = @PrivewFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                string text = A.D.A.A.PrivewID.Text;
                adapter.SelectCommand.Parameters.AddWithValue("PrivewFrontID", text ?? DBNull.Value);
                adapter.Fill(dataTable);
                this.A.Close();
                decimal left = 0M;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    while (true)
                    {
                        if (!enumerator.MoveNext())
                        {
                            break;
                        }
                        object current = enumerator.Current;
                        object[] arguments = new object[] { "MSTotal" };
                        left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                this.TxTNetTotal.Text = left.ToString(PR.YR);
                this.GV.DataSource = dataTable;
                this.GV.Refresh();
                this.GV.Columns["ItemsID"].Visible = false;
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["PrivewFrontID"].Visible = false;
                this.GV.Columns["MBarCode"].HeaderText = "رقم/باركود";
                this.GV.Columns["MName"].HeaderText = "المادة";
                this.GV.Columns["MUnit"].HeaderText = "الوحدة";
                this.GV.Columns["MSale"].HeaderText = "السعر الافرادي";
                this.GV.Columns["MQantity"].HeaderText = "الكمية";
                this.GV.Columns["MDisMiWi"].HeaderText = "نسبة الخصم";
                this.GV.Columns["MDisVal"].HeaderText = "مبلغ الخصم";
                this.GV.Columns["MDarMiWi"].HeaderText = "نسبة الضريبة";
                this.GV.Columns["MDarVal"].HeaderText = "مبلغ الضريبة";
                this.GV.Columns["MSTotal"].HeaderText = "مجموع السعر";
                this.GV.Columns["MNote"].HeaderText = "الملاحظات";
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
                        decimal num2 = new decimal(Conversion.Val(current.Cells["MSale"].Value.ToString()));
                        decimal num3 = new decimal(Conversion.Val(current.Cells["MQantity"].Value.ToString()));
                        decimal num4 = new decimal(Conversion.Val(current.Cells["MDisVal"].Value.ToString()));
                        decimal num5 = new decimal(Conversion.Val(current.Cells["MDarVal"].Value.ToString()));
                        decimal num6 = new decimal(Conversion.Val(current.Cells["MSTotal"].Value.ToString()));
                        current.Cells["MSale"].Value = num2.ToString(PR.YR);
                        current.Cells["MQantity"].Value = num3.ToString(PR.BR);
                        current.Cells["MDisVal"].Value = num4.ToString(PR.YR);
                        current.Cells["MDarVal"].Value = num5.ToString(PR.YR);
                        current.Cells["MSTotal"].Value = num6.ToString(PR.YR);
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
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
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
            A.D.A.A.ShowDialog();
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
            this.Q();
        }

        private void U(object A, EventArgs R)
        {
        }

        private void V(object A, EventArgs R)
        {
        }

        private void X(object A, EventArgs R)
        {
            this.Q();
        }

        internal virtual Button ButtonAdd
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox MSale
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox MNote
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox MUnit
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox MSTotal
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.L);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.D);
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

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox MQantity
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.K);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.F);
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TextBox MDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
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

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TextBox MDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
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

        internal virtual ComboBox MName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.N);
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

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TextBox MDarVal
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.U);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.I);
                TextBox h = this.H;
                if (h != null)
                {
                    h.TextChanged -= handler;
                    h.KeyPress -= handler2;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.TextChanged += handler;
                    h.KeyPress += handler2;
                }
            }
        }

        internal virtual Button Button2Q
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual TextBox MDisVal
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
                TextBox t = this.T;
                if (t != null)
                {
                    t.TextChanged -= handler;
                    t.KeyPress -= handler2;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.TextChanged += handler;
                    t.KeyPress += handler2;
                }
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

        internal virtual ToolStripSeparator ToolStripSeparator4
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

        internal virtual Timer TimerLoadData
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

        internal virtual Timer TimersStartUp
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

        internal virtual Timer TimerFillGV
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual Label TxTNetTotal
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox MBarCode
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.H);
                EventHandler handler2 = new EventHandler(this.V);
                TextBox x = this.X;
                if (x != null)
                {
                    x.KeyPress -= handler;
                    x.TextChanged -= handler2;
                }
                this.X = value;
                x = this.X;
                if (x != null)
                {
                    x.KeyPress += handler;
                    x.TextChanged += handler2;
                }
            }
        }
    }
}

