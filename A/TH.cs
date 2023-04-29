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
    public class TH : Form
    {
        private IContainer A;
        [AccessedThroughProperty("GV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [CompilerGenerated, AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage1")]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("XTxTBarCodeLink"), CompilerGenerated]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxAll")]
        private CheckBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxS"), CompilerGenerated]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTS"), CompilerGenerated]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSale"), CompilerGenerated]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripStatus"), CompilerGenerated]
        private ToolStrip A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonClose")]
        private ToolStripButton A;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage R;
        [CompilerGenerated, AccessedThroughProperty("TabPage3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage4"), CompilerGenerated]
        private TabPage Q;
        [AccessedThroughProperty("ButtonSaleMult"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("RadioButton3")]
        private RadioButton A;
        [AccessedThroughProperty("RadioButton2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RadioButton R;
        [AccessedThroughProperty("RadioButton1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RadioButton P;
        [AccessedThroughProperty("ButtonDis"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [CompilerGenerated, AccessedThroughProperty("GroupBoxDis2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTDisVal")]
        private TextBox P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxDis1")]
        private GroupBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTDisMiWi")]
        private TextBox Q;
        [AccessedThroughProperty("ButtonNot"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [CompilerGenerated, AccessedThroughProperty("TxTNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage5")]
        private TabPage I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonDAR"), CompilerGenerated]
        private Button I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3"), CompilerGenerated]
        private GroupBox D;
        [AccessedThroughProperty("TxTDarMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox D;
        private SqlConnection A;
        public static int A;
        public static bool A = false;

        public TH()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.X);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.GV = new DataGridView();
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.ButtonSale = new Button();
            this.GroupBoxS = new GroupBox();
            this.TxTS = new TextBox();
            this.XTxTBarCodeLink = new TextBox();
            this.TabPage2 = new TabPage();
            this.ButtonSaleMult = new Button();
            this.GroupBox1 = new GroupBox();
            this.RadioButton3 = new RadioButton();
            this.RadioButton2 = new RadioButton();
            this.RadioButton1 = new RadioButton();
            this.TabPage3 = new TabPage();
            this.ButtonDis = new Button();
            this.GroupBoxDis2 = new GroupBox();
            this.TxTDisVal = new TextBox();
            this.GroupBoxDis1 = new GroupBox();
            this.TxTDisMiWi = new TextBox();
            this.TabPage5 = new TabPage();
            this.ButtonDAR = new Button();
            this.GroupBox3 = new GroupBox();
            this.TxTDarMiWi = new TextBox();
            this.TabPage4 = new TabPage();
            this.ButtonNot = new Button();
            this.GroupBox2 = new GroupBox();
            this.TxTNote = new TextBox();
            this.CheckBoxAll = new CheckBox();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripButtonClose = new ToolStripButton();
            ((ISupportInitialize) this.GV).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBoxS.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBoxDis2.SuspendLayout();
            this.GroupBoxDis1.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            base.SuspendLayout();
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Dock = DockStyle.Fill;
            this.GV.Location = new Point(0, 0xa9);
            this.GV.Name = "GV";
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3a5, 0x15a);
            this.GV.TabIndex = 0x52;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3a5, 0x22);
            this.TxTTitle.TabIndex = 0x53;
            this.TxTTitle.Text = "تعديل متعدد";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3a5, 0x69);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 0x54;
            this.TabPage1.Controls.Add(this.ButtonSale);
            this.TabPage1.Controls.Add(this.GroupBoxS);
            this.TabPage1.Controls.Add(this.XTxTBarCodeLink);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x39d, 0x4c);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "تعديل السعر";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtonSale.FlatStyle = FlatStyle.Flat;
            this.ButtonSale.Image = A.F.ImOK;
            this.ButtonSale.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSale.Location = new Point(0x147, 0x11);
            this.ButtonSale.Name = "ButtonSale";
            this.ButtonSale.Size = new Size(0x121, 0x2f);
            this.ButtonSale.TabIndex = 2;
            this.ButtonSale.Text = "موافق";
            this.ButtonSale.UseVisualStyleBackColor = true;
            this.GroupBoxS.Controls.Add(this.TxTS);
            this.GroupBoxS.Location = new Point(0x26e, 13);
            this.GroupBoxS.Name = "GroupBoxS";
            this.GroupBoxS.Size = new Size(0x127, 0x39);
            this.GroupBoxS.TabIndex = 15;
            this.GroupBoxS.TabStop = false;
            this.GroupBoxS.Text = "السعر";
            this.TxTS.BackColor = SystemColors.Info;
            this.TxTS.Dock = DockStyle.Top;
            this.TxTS.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTS.Location = new Point(3, 0x13);
            this.TxTS.MaxLength = 20;
            this.TxTS.Name = "TxTS";
            this.TxTS.RightToLeft = RightToLeft.No;
            this.TxTS.Size = new Size(0x121, 0x1a);
            this.TxTS.TabIndex = 1;
            this.TxTS.TextAlign = HorizontalAlignment.Center;
            this.XTxTBarCodeLink.Location = new Point(850, 80);
            this.XTxTBarCodeLink.Name = "XTxTBarCodeLink";
            this.XTxTBarCodeLink.Size = new Size(0, 0x17);
            this.XTxTBarCodeLink.TabIndex = 14;
            this.TabPage2.Controls.Add(this.ButtonSaleMult);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new Size(0x39d, 0x4c);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "الاسعار الاساسية";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonSaleMult.FlatStyle = FlatStyle.Flat;
            this.ButtonSaleMult.Image = A.F.ImOK;
            this.ButtonSaleMult.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSaleMult.Location = new Point(0x1c, 0x16);
            this.ButtonSaleMult.Name = "ButtonSaleMult";
            this.ButtonSaleMult.Size = new Size(0x121, 0x30);
            this.ButtonSaleMult.TabIndex = 0x10;
            this.ButtonSaleMult.Text = "موافق";
            this.ButtonSaleMult.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.RadioButton3);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Location = new Point(0x143, 13);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x252, 0x39);
            this.GroupBox1.TabIndex = 0x11;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "السعر";
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new Point(70, 0x17);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new Size(0x87, 20);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = " تطبيق سعر التكلفة";
            this.RadioButton3.UseVisualStyleBackColor = true;
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new Point(0xe7, 0x17);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new Size(0xa8, 20);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "تطبيق سعر البيع المخفض";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new Point(0x1a2, 0x17);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new Size(170, 20);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "تطبيع سعر البيع الافتراضي";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.TabPage3.Controls.Add(this.ButtonDis);
            this.TabPage3.Controls.Add(this.GroupBoxDis2);
            this.TabPage3.Controls.Add(this.GroupBoxDis1);
            this.TabPage3.Location = new Point(4, 0x19);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x39d, 0x4c);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "الخصم";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.ButtonDis.FlatStyle = FlatStyle.Flat;
            this.ButtonDis.Image = A.F.ImOK;
            this.ButtonDis.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDis.Location = new Point(0x9a, 0x12);
            this.ButtonDis.Name = "ButtonDis";
            this.ButtonDis.Size = new Size(0x121, 0x30);
            this.ButtonDis.TabIndex = 0x11;
            this.ButtonDis.Text = "موافق";
            this.ButtonDis.UseVisualStyleBackColor = true;
            this.GroupBoxDis2.Controls.Add(this.TxTDisVal);
            this.GroupBoxDis2.Location = new Point(0x2b1, 10);
            this.GroupBoxDis2.Name = "GroupBoxDis2";
            this.GroupBoxDis2.Size = new Size(0xe4, 0x39);
            this.GroupBoxDis2.TabIndex = 6;
            this.GroupBoxDis2.TabStop = false;
            this.GroupBoxDis2.Text = "مبلغ الخصم";
            this.TxTDisVal.BackColor = SystemColors.Info;
            this.TxTDisVal.Dock = DockStyle.Fill;
            this.TxTDisVal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDisVal.Location = new Point(3, 0x13);
            this.TxTDisVal.MaxLength = 20;
            this.TxTDisVal.Name = "TxTDisVal";
            this.TxTDisVal.RightToLeft = RightToLeft.No;
            this.TxTDisVal.Size = new Size(0xde, 0x1a);
            this.TxTDisVal.TabIndex = 2;
            this.TxTDisVal.TextAlign = HorizontalAlignment.Center;
            this.GroupBoxDis1.Controls.Add(this.TxTDisMiWi);
            this.GroupBoxDis1.Location = new Point(0x1c1, 10);
            this.GroupBoxDis1.Name = "GroupBoxDis1";
            this.GroupBoxDis1.Size = new Size(0xea, 0x39);
            this.GroupBoxDis1.TabIndex = 5;
            this.GroupBoxDis1.TabStop = false;
            this.GroupBoxDis1.Text = "الخصم %";
            this.TxTDisMiWi.BackColor = SystemColors.Info;
            this.TxTDisMiWi.Dock = DockStyle.Fill;
            this.TxTDisMiWi.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDisMiWi.Location = new Point(3, 0x13);
            this.TxTDisMiWi.MaxLength = 20;
            this.TxTDisMiWi.Name = "TxTDisMiWi";
            this.TxTDisMiWi.RightToLeft = RightToLeft.No;
            this.TxTDisMiWi.Size = new Size(0xe4, 0x1a);
            this.TxTDisMiWi.TabIndex = 1;
            this.TxTDisMiWi.TextAlign = HorizontalAlignment.Center;
            this.TabPage5.Controls.Add(this.ButtonDAR);
            this.TabPage5.Controls.Add(this.GroupBox3);
            this.TabPage5.Location = new Point(4, 0x19);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new Padding(3);
            this.TabPage5.Size = new Size(0x39d, 0x4c);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "الضريبة";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.ButtonDAR.FlatStyle = FlatStyle.Flat;
            this.ButtonDAR.Image = A.F.ImOK;
            this.ButtonDAR.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDAR.Location = new Point(0xc6, 0x12);
            this.ButtonDAR.Name = "ButtonDAR";
            this.ButtonDAR.Size = new Size(0x121, 0x30);
            this.ButtonDAR.TabIndex = 0x13;
            this.ButtonDAR.Text = "موافق";
            this.ButtonDAR.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.TxTDarMiWi);
            this.GroupBox3.Location = new Point(0x1ed, 10);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0xea, 0x39);
            this.GroupBox3.TabIndex = 0x12;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الضريبة %";
            this.TxTDarMiWi.BackColor = SystemColors.Info;
            this.TxTDarMiWi.Dock = DockStyle.Fill;
            this.TxTDarMiWi.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDarMiWi.Location = new Point(3, 0x13);
            this.TxTDarMiWi.MaxLength = 20;
            this.TxTDarMiWi.Name = "TxTDarMiWi";
            this.TxTDarMiWi.RightToLeft = RightToLeft.No;
            this.TxTDarMiWi.Size = new Size(0xe4, 0x1a);
            this.TxTDarMiWi.TabIndex = 1;
            this.TxTDarMiWi.TextAlign = HorizontalAlignment.Center;
            this.TabPage4.Controls.Add(this.ButtonNot);
            this.TabPage4.Controls.Add(this.GroupBox2);
            this.TabPage4.Location = new Point(4, 0x19);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x39d, 0x4c);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "الملاحظات";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.ButtonNot.FlatStyle = FlatStyle.Flat;
            this.ButtonNot.Image = A.F.ImOK;
            this.ButtonNot.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonNot.Location = new Point(8, 0x15);
            this.ButtonNot.Name = "ButtonNot";
            this.ButtonNot.Size = new Size(0xd0, 0x30);
            this.ButtonNot.TabIndex = 0x13;
            this.ButtonNot.Text = "موافق";
            this.ButtonNot.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.TxTNote);
            this.GroupBox2.Location = new Point(0xde, 13);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x2b7, 0x39);
            this.GroupBox2.TabIndex = 0x12;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "الملاحظات";
            this.TxTNote.BackColor = SystemColors.Info;
            this.TxTNote.Dock = DockStyle.Fill;
            this.TxTNote.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTNote.Location = new Point(3, 0x13);
            this.TxTNote.MaxLength = 300;
            this.TxTNote.Name = "TxTNote";
            this.TxTNote.RightToLeft = RightToLeft.No;
            this.TxTNote.Size = new Size(0x2b1, 0x1a);
            this.TxTNote.TabIndex = 2;
            this.TxTNote.TextAlign = HorizontalAlignment.Center;
            this.CheckBoxAll.AutoSize = true;
            this.CheckBoxAll.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxAll.Dock = DockStyle.Top;
            this.CheckBoxAll.Location = new Point(0, 0x8b);
            this.CheckBoxAll.Name = "CheckBoxAll";
            this.CheckBoxAll.Padding = new Padding(5);
            this.CheckBoxAll.Size = new Size(0x3a5, 30);
            this.CheckBoxAll.TabIndex = 0x55;
            this.CheckBoxAll.Text = "تحديد/ عدم تحديد الكل";
            this.CheckBoxAll.UseVisualStyleBackColor = false;
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripButtonClose };
            this.ToolStripStatus.Items.AddRange(toolStripItems);
            this.ToolStripStatus.Location = new Point(0, 0x203);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3a5, 0x27);
            this.ToolStripStatus.TabIndex = 0x7c;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x24);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripButtonClose.Image = A.F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x24);
            this.ToolStripButtonClose.Text = "اغلاق";
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3a5, 0x22a);
            base.ControlBox = false;
            base.Controls.Add(this.GV);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.CheckBoxAll);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleMultiEdit";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تعديل متعدد";
            ((ISupportInitialize) this.GV).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.GroupBoxS.ResumeLayout(false);
            this.GroupBoxS.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.GroupBoxDis2.ResumeLayout(false);
            this.GroupBoxDis2.PerformLayout();
            this.GroupBoxDis1.ResumeLayout(false);
            this.GroupBoxDis1.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
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

        public void D()
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            if (!PR.MR)
            {
                Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else if ((this.TxTDisVal.Text == null) & (this.TxTDisMiWi.Text == null))
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    this.GV.ClearSelection();
                    this.GV.CurrentCell = this.GV.Rows[0].Cells[0];
                    this.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = this.GV.Rows.Count;
                    int num = 0;
                    int num2 = this.GV.Rows.Count - 1;
                    int num3 = 0;
                    while (true)
                    {
                        if (num3 > num2)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            if (num > 0)
                            {
                                this.I();
                            }
                            else
                            {
                                Interaction.MsgBox("يجب تحديد اكثر من سجل", MsgBoxStyle.ApplicationModal, null);
                            }
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num3;
                        if (Conversions.ToBoolean(this.GV.Rows[num3].Cells[0].Value))
                        {
                            num++;
                        }
                        num3++;
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
            // Invalid method body.
        }

        private void G(object A, EventArgs R)
        {
            if (!PR.CR)
            {
                Interaction.MsgBox(PR.T.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                try
                {
                    this.GV.ClearSelection();
                    this.GV.CurrentCell = this.GV.Rows[0].Cells[0];
                    this.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = this.GV.Rows.Count;
                    int num = 0;
                    int num2 = this.GV.Rows.Count - 1;
                    int num3 = 0;
                    while (true)
                    {
                        if (num3 > num2)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            if (num > 0)
                            {
                                this.D();
                            }
                            else
                            {
                                Interaction.MsgBox("يجب تحديد اكثر من سجل", MsgBoxStyle.ApplicationModal, null);
                            }
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num3;
                        if (Conversions.ToBoolean(this.GV.Rows[num3].Cells[0].Value))
                        {
                            num++;
                        }
                        num3++;
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

        private void H(object A, EventArgs R)
        {
        }

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            if (!PR.SP & this.RadioButton3.Checked)
            {
                Interaction.MsgBox("غير مسموح لك بعرض سعر التكلفة من صلاحيات المسؤول", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    this.GV.ClearSelection();
                    this.GV.CurrentCell = this.GV.Rows[0].Cells[0];
                    this.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = this.GV.Rows.Count;
                    int num = 0;
                    int num2 = this.GV.Rows.Count - 1;
                    int num3 = 0;
                    while (true)
                    {
                        if (num3 > num2)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            if (num > 0)
                            {
                                this.Q();
                            }
                            else
                            {
                                Interaction.MsgBox("يجب تحديد اكثر من سجل", MsgBoxStyle.ApplicationModal, null);
                            }
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num3;
                        if (Conversions.ToBoolean(this.GV.Rows[num3].Cells[0].Value))
                        {
                            num++;
                        }
                        num3++;
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

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            if (this.TxTS.Text == null)
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TxTS.Focus();
            }
            else
            {
                try
                {
                    this.GV.ClearSelection();
                    this.GV.CurrentCell = this.GV.Rows[0].Cells[0];
                    this.GV.Rows[0].Cells[0].Selected = true;
                    this.ToolStripProgressBar1.Visible = true;
                    this.ToolStripProgressBar1.Maximum = this.GV.Rows.Count;
                    int num = 0;
                    int num2 = this.GV.Rows.Count - 1;
                    int num3 = 0;
                    while (true)
                    {
                        if (num3 > num2)
                        {
                            this.ToolStripProgressBar1.Visible = false;
                            if (num > 0)
                            {
                                this.P();
                            }
                            else
                            {
                                Interaction.MsgBox("يجب تحديد اكثر من سجل", MsgBoxStyle.ApplicationModal, null);
                            }
                            break;
                        }
                        this.ToolStripProgressBar1.Value = num3;
                        if (Conversions.ToBoolean(this.GV.Rows[num3].Cells[0].Value))
                        {
                            num++;
                        }
                        num3++;
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
            try
            {
                this.GV.ClearSelection();
                this.GV.CurrentCell = this.GV.Rows[0].Cells[0];
                this.GV.Rows[0].Cells[0].Selected = true;
                A = false;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = this.GV.Rows.Count;
                int num = this.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if ((num2 <= num) && !A)
                    {
                        this.ToolStripProgressBar1.Value = num2;
                        int num3 = 0;
                        num3 = Conversions.ToInteger(this.GV.Rows[num2].Cells["HSaleID"].Value.ToString());
                        string str = this.GV.Rows[num2].Cells["HSaleBarCode"].Value.ToString();
                        if (Conversions.ToBoolean(this.GV.Rows[num2].Cells[0].Value))
                        {
                            if (Information.IsNothing(this.GV.CurrentRow))
                            {
                                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                                break;
                            }
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            DataTable dataTable = new DataTable();
                            string selectCommandText = "SELECT TOP(1) * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialBarCode] = @MaterialBarCode)";
                            dataTable.Clear();
                            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                            adapter.SelectCommand.Parameters.AddWithValue("MaterialBarCode", str);
                            adapter.Fill(dataTable);
                            this.A.Close();
                            if (dataTable.Rows.Count > 0)
                            {
                                if (this.RadioButton1.Checked)
                                {
                                    this.TxTS.Text = dataTable.Rows[0]["MaterialPricSale"].ToString();
                                }
                                if (this.RadioButton2.Checked)
                                {
                                    this.TxTS.Text = dataTable.Rows[0]["MaterialPricLess"].ToString();
                                    if (this.TxTS.Text == null)
                                    {
                                        this.TxTS.Text = dataTable.Rows[0]["MaterialPricSale"].ToString();
                                    }
                                }
                                if (this.RadioButton3.Checked)
                                {
                                    this.TxTS.Text = dataTable.Rows[0]["MaterialPricCost"].ToString();
                                }
                            }
                            RH.A = num3;
                            RH.R = 0;
                            A.D.A.A.Show();
                            A.D.A.A.TxTS.Text = this.TxTS.Text;
                            A.D.A.A.ButtonOk.PerformClick();
                        }
                        num2++;
                        continue;
                    }
                    this.ToolStripProgressBar1.Visible = false;
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    A.D.A.A.L();
                    base.Dispose();
                    break;
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

        private void Q(object A, EventArgs R)
        {
            A.D.A.A.L();
            base.Dispose();
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            if (this.CheckBoxAll.Checked)
            {
                int num = this.GV.Rows.Count - 1;
                for (int i = 0; i <= num; i++)
                {
                    this.GV.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                int num3 = this.GV.Rows.Count - 1;
                for (int i = 0; i <= num3; i++)
                {
                    this.GV.Rows[i].Cells[0].Value = false;
                }
            }
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
        }

        private void X(object A, EventArgs R)
        {
            this.CheckBoxAll.Checked = true;
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

        internal virtual TextBox XTxTBarCodeLink
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxAll
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual GroupBox GroupBoxS
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTS
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                TextBox r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
                }
            }
        }

        internal virtual Button ButtonSale
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

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonSaleMult
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual RadioButton RadioButton3
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual RadioButton RadioButton2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual RadioButton RadioButton1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonDis
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual GroupBox GroupBoxDis2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTDisVal
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
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

        internal virtual GroupBox GroupBoxDis1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.P);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.KeyPress -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.KeyPress += handler;
                }
            }
        }

        internal virtual Button ButtonNot
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                Button q = this.Q;
                if (q != null)
                {
                    q.Click -= handler;
                    q.KeyPress -= handler2;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.Click += handler;
                    q.KeyPress += handler2;
                }
            }
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

        internal virtual TextBox TxTNote
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual Button ButtonDAR
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox TxTDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }
    }
}

