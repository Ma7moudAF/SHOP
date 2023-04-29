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
    public class EH : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label1")]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonClose")]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [AccessedThroughProperty("Panel1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Panel A;
        [AccessedThroughProperty("TxTBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [AccessedThroughProperty("PictureBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private PictureBox A;
        [AccessedThroughProperty("GroupBox14"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MSTotal")]
        private Label P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox12")]
        private GroupBox R;
        [AccessedThroughProperty("MaterialDisMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBox11"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("MaterialDarMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox10")]
        private GroupBox Q;
        [AccessedThroughProperty("MaterialUnit"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label D;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [AccessedThroughProperty("MaterialBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        [AccessedThroughProperty("GroupBox7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [CompilerGenerated, AccessedThroughProperty("MaterialPricSale"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox4"), CompilerGenerated]
        private GroupBox F;
        [AccessedThroughProperty("MaterialName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonSBarCode")]
        private Button R;
        [AccessedThroughProperty("TxTTip"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label X;
        [AccessedThroughProperty("TableLayoutPanel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableLayoutPanel A;
        [AccessedThroughProperty("GroupBox17"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MaterialNote"), CompilerGenerated]
        private Label G;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonAdva")]
        private Button P;
        [AccessedThroughProperty("TableLayoutPanel3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableLayoutPanel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2"), CompilerGenerated]
        private GroupBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("MDarVal")]
        private Label E;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox X;
        [AccessedThroughProperty("MDisVal"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label K;
        private SqlConnection A;
        private TextBox R;

        public EH()
        {
            base.Load += new EventHandler(this.R);
            base.Shown += new EventHandler(this.I);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.R = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label1 = new Label();
            this.TxTTitle = new Label();
            this.ButtonClose = new Button();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.ButtonAdva = new Button();
            this.ButtonSBarCode = new Button();
            this.Panel1 = new Panel();
            this.TxTBarCode = new TextBox();
            this.PictureBox2 = new PictureBox();
            this.GroupBox14 = new GroupBox();
            this.MSTotal = new Label();
            this.GroupBox12 = new GroupBox();
            this.MaterialDisMiWi = new Label();
            this.GroupBox11 = new GroupBox();
            this.MaterialDarMiWi = new Label();
            this.GroupBox10 = new GroupBox();
            this.MaterialUnit = new Label();
            this.GroupBox3 = new GroupBox();
            this.MaterialBarCode = new Label();
            this.GroupBox7 = new GroupBox();
            this.MaterialPricSale = new Label();
            this.GroupBox4 = new GroupBox();
            this.MaterialName = new Label();
            this.TxTTip = new Label();
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.GroupBox17 = new GroupBox();
            this.MaterialNote = new Label();
            this.TableLayoutPanel3 = new TableLayoutPanel();
            this.GroupBox2 = new GroupBox();
            this.MDarVal = new Label();
            this.GroupBox1 = new GroupBox();
            this.MDisVal = new Label();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            this.GroupBox14.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.GroupBox17.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.Label1.BackColor = Color.WhiteSmoke;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0, 90);
            this.Label1.Margin = new Padding(7, 0, 7, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x757, 0x54);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "شاشة استعلام الزوار | استعلم عن الأسعار هنا";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTTitle.BackColor = Color.FromArgb(0, 0x40, 0);
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.White;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Margin = new Padding(7, 0, 7, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x757, 90);
            this.TxTTitle.TabIndex = 3;
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.Location = new Point(0, 0x3a6);
            this.ButtonClose.Margin = new Padding(6, 6, 6, 6);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x757, 0xa6);
            this.ButtonClose.TabIndex = 0x1ed36d3;
            this.ButtonClose.Text = "الخروج من النظام";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0xae);
            this.TabControl1.Margin = new Padding(6, 6, 6, 6);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 10);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x757, 0xa2);
            this.TabControl1.TabIndex = 0x1ed36d4;
            this.TabPage1.Controls.Add(this.ButtonAdva);
            this.TabPage1.Controls.Add(this.ButtonSBarCode);
            this.TabPage1.Controls.Add(this.Panel1);
            this.TabPage1.Location = new Point(4, 0x34);
            this.TabPage1.Margin = new Padding(6, 6, 6, 6);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(6, 6, 6, 6);
            this.TabPage1.Size = new Size(0x74f, 0x6a);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الاستعلام من خلال  رقم/الباركود";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtonAdva.Dock = DockStyle.Right;
            this.ButtonAdva.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdva.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdva.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdva.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdva.FlatStyle = FlatStyle.Flat;
            this.ButtonAdva.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdva.Image = A.F.ImView;
            this.ButtonAdva.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdva.Location = new Point(480, 6);
            this.ButtonAdva.Margin = new Padding(6, 8, 6, 8);
            this.ButtonAdva.Name = "ButtonAdva";
            this.ButtonAdva.Size = new Size(390, 0x5e);
            this.ButtonAdva.TabIndex = 0x1ed36d6;
            this.ButtonAdva.Text = "بحث متقدم";
            this.ButtonAdva.UseVisualStyleBackColor = true;
            this.ButtonSBarCode.Dock = DockStyle.Right;
            this.ButtonSBarCode.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSBarCode.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSBarCode.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSBarCode.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSBarCode.FlatStyle = FlatStyle.Flat;
            this.ButtonSBarCode.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSBarCode.Image = A.F.ImSearch;
            this.ButtonSBarCode.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSBarCode.Location = new Point(870, 6);
            this.ButtonSBarCode.Margin = new Padding(6, 8, 6, 8);
            this.ButtonSBarCode.Name = "ButtonSBarCode";
            this.ButtonSBarCode.Size = new Size(390, 0x5e);
            this.ButtonSBarCode.TabIndex = 70;
            this.ButtonSBarCode.Text = "بحث";
            this.ButtonSBarCode.UseVisualStyleBackColor = true;
            this.Panel1.Controls.Add(this.TxTBarCode);
            this.Panel1.Controls.Add(this.PictureBox2);
            this.Panel1.Dock = DockStyle.Right;
            this.Panel1.Location = new Point(0x4ec, 6);
            this.Panel1.Margin = new Padding(6, 6, 6, 6);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x25d, 0x5e);
            this.Panel1.TabIndex = 0x1ed36d5;
            this.TxTBarCode.BackColor = SystemColors.Info;
            this.TxTBarCode.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTBarCode.Location = new Point(0xa9, 30);
            this.TxTBarCode.Margin = new Padding(6, 6, 6, 6);
            this.TxTBarCode.Name = "TxTBarCode";
            this.TxTBarCode.RightToLeft = RightToLeft.No;
            this.TxTBarCode.Size = new Size(420, 0x24);
            this.TxTBarCode.TabIndex = 0;
            this.TxTBarCode.TextAlign = HorizontalAlignment.Center;
            this.PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox2.Image = A.F.BarCodeSS;
            this.PictureBox2.Location = new Point(5, 30);
            this.PictureBox2.Margin = new Padding(6, 6, 6, 6);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new Size(0xb2, 0x24);
            this.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 0x45;
            this.PictureBox2.TabStop = false;
            this.GroupBox14.Controls.Add(this.MSTotal);
            this.GroupBox14.Dock = DockStyle.Top;
            this.GroupBox14.Font = new Font("Tahoma", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.GroupBox14.Location = new Point(0, 0x248);
            this.GroupBox14.Margin = new Padding(6, 6, 6, 6);
            this.GroupBox14.Name = "GroupBox14";
            this.GroupBox14.Padding = new Padding(6, 6, 6, 6);
            this.GroupBox14.Size = new Size(0x757, 110);
            this.GroupBox14.TabIndex = 90;
            this.GroupBox14.TabStop = false;
            this.GroupBox14.Text = "صافي سعر البيع";
            this.MSTotal.Dock = DockStyle.Fill;
            this.MSTotal.Font = new Font("Tahoma", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.MSTotal.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.MSTotal.Location = new Point(6, 0x23);
            this.MSTotal.Margin = new Padding(6, 0, 6, 0);
            this.MSTotal.Name = "MSTotal";
            this.MSTotal.RightToLeft = RightToLeft.No;
            this.MSTotal.Size = new Size(0x74b, 0x45);
            this.MSTotal.TabIndex = 0;
            this.MSTotal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox12.Controls.Add(this.MaterialDisMiWi);
            this.GroupBox12.Dock = DockStyle.Fill;
            this.GroupBox12.Location = new Point(0x46f, 6);
            this.GroupBox12.Margin = new Padding(6, 6, 6, 6);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Padding = new Padding(6, 6, 6, 6);
            this.GroupBox12.Size = new Size(0x16b, 0x4d);
            this.GroupBox12.TabIndex = 0x5b;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "خصم %";
            this.MaterialDisMiWi.Dock = DockStyle.Fill;
            this.MaterialDisMiWi.ForeColor = Color.FromArgb(0, 0xc0, 0);
            this.MaterialDisMiWi.Location = new Point(6, 0x23);
            this.MaterialDisMiWi.Margin = new Padding(6, 0, 6, 0);
            this.MaterialDisMiWi.Name = "MaterialDisMiWi";
            this.MaterialDisMiWi.RightToLeft = RightToLeft.No;
            this.MaterialDisMiWi.Size = new Size(0x15f, 0x24);
            this.MaterialDisMiWi.TabIndex = 0;
            this.MaterialDisMiWi.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox11.Controls.Add(this.MaterialDarMiWi);
            this.GroupBox11.Dock = DockStyle.Fill;
            this.GroupBox11.Location = new Point(0x181, 6);
            this.GroupBox11.Margin = new Padding(6, 6, 6, 6);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Padding = new Padding(6, 6, 6, 6);
            this.GroupBox11.Size = new Size(0x16b, 0x4d);
            this.GroupBox11.TabIndex = 90;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "ضريبة %";
            this.MaterialDarMiWi.Dock = DockStyle.Fill;
            this.MaterialDarMiWi.ForeColor = Color.FromArgb(0, 0xc0, 0);
            this.MaterialDarMiWi.Location = new Point(6, 0x23);
            this.MaterialDarMiWi.Margin = new Padding(6, 0, 6, 0);
            this.MaterialDarMiWi.Name = "MaterialDarMiWi";
            this.MaterialDarMiWi.RightToLeft = RightToLeft.No;
            this.MaterialDarMiWi.Size = new Size(0x15f, 0x24);
            this.MaterialDarMiWi.TabIndex = 0;
            this.MaterialDarMiWi.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox10.Controls.Add(this.MaterialUnit);
            this.GroupBox10.Dock = DockStyle.Fill;
            this.GroupBox10.Location = new Point(6, 6);
            this.GroupBox10.Margin = new Padding(6, 6, 6, 6);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Padding = new Padding(6, 6, 6, 6);
            this.GroupBox10.Size = new Size(0x267, 0x56);
            this.GroupBox10.TabIndex = 90;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "الوحدة";
            this.MaterialUnit.Dock = DockStyle.Fill;
            this.MaterialUnit.ForeColor = Color.FromArgb(0, 0xc0, 0);
            this.MaterialUnit.Location = new Point(6, 0x23);
            this.MaterialUnit.Margin = new Padding(6, 0, 6, 0);
            this.MaterialUnit.Name = "MaterialUnit";
            this.MaterialUnit.RightToLeft = RightToLeft.No;
            this.MaterialUnit.Size = new Size(0x25b, 0x2d);
            this.MaterialUnit.TabIndex = 0;
            this.MaterialUnit.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox3.Controls.Add(this.MaterialBarCode);
            this.GroupBox3.Dock = DockStyle.Fill;
            this.GroupBox3.Location = new Point(0x4eb, 6);
            this.GroupBox3.Margin = new Padding(6, 6, 6, 6);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new Padding(6, 6, 6, 6);
            this.GroupBox3.Size = new Size(0x266, 0x56);
            this.GroupBox3.TabIndex = 0x55;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم/باركود المادة";
            this.MaterialBarCode.Dock = DockStyle.Fill;
            this.MaterialBarCode.ForeColor = Color.FromArgb(0, 0xc0, 0);
            this.MaterialBarCode.Location = new Point(6, 0x23);
            this.MaterialBarCode.Margin = new Padding(6, 0, 6, 0);
            this.MaterialBarCode.Name = "MaterialBarCode";
            this.MaterialBarCode.RightToLeft = RightToLeft.No;
            this.MaterialBarCode.Size = new Size(0x25a, 0x2d);
            this.MaterialBarCode.TabIndex = 0;
            this.MaterialBarCode.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox7.Controls.Add(this.MaterialPricSale);
            this.GroupBox7.Dock = DockStyle.Fill;
            this.GroupBox7.Location = new Point(0x5e6, 6);
            this.GroupBox7.Margin = new Padding(6, 6, 6, 6);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Padding = new Padding(6, 6, 6, 6);
            this.GroupBox7.Size = new Size(0x16b, 0x4d);
            this.GroupBox7.TabIndex = 0x59;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "سعر البيع";
            this.MaterialPricSale.Dock = DockStyle.Fill;
            this.MaterialPricSale.ForeColor = Color.FromArgb(0, 0xc0, 0);
            this.MaterialPricSale.Location = new Point(6, 0x23);
            this.MaterialPricSale.Margin = new Padding(6, 0, 6, 0);
            this.MaterialPricSale.Name = "MaterialPricSale";
            this.MaterialPricSale.RightToLeft = RightToLeft.No;
            this.MaterialPricSale.Size = new Size(0x15f, 0x24);
            this.MaterialPricSale.TabIndex = 0;
            this.MaterialPricSale.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox4.Controls.Add(this.MaterialName);
            this.GroupBox4.Dock = DockStyle.Fill;
            this.GroupBox4.Location = new Point(0x279, 6);
            this.GroupBox4.Margin = new Padding(6, 6, 6, 6);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new Padding(6, 6, 6, 6);
            this.GroupBox4.Size = new Size(0x266, 0x56);
            this.GroupBox4.TabIndex = 0x56;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "اسم المادة/ الوصف";
            this.MaterialName.Dock = DockStyle.Fill;
            this.MaterialName.ForeColor = Color.FromArgb(0, 0xc0, 0);
            this.MaterialName.Location = new Point(6, 0x23);
            this.MaterialName.Margin = new Padding(6, 0, 6, 0);
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.RightToLeft = RightToLeft.No;
            this.MaterialName.Size = new Size(0x25a, 0x2d);
            this.MaterialName.TabIndex = 0;
            this.MaterialName.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTTip.Dock = DockStyle.Top;
            this.TxTTip.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.TxTTip.Location = new Point(0, 0x150);
            this.TxTTip.Margin = new Padding(6, 0, 6, 0);
            this.TxTTip.Name = "TxTTip";
            this.TxTTip.Size = new Size(0x757, 0x3d);
            this.TxTTip.TabIndex = 0x1ed36d6;
            this.TxTTip.TextAlign = ContentAlignment.MiddleCenter;
            this.TableLayoutPanel1.ColumnCount = 3;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
            this.TableLayoutPanel1.Controls.Add(this.GroupBox3, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.GroupBox4, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.GroupBox10, 2, 0);
            this.TableLayoutPanel1.Dock = DockStyle.Top;
            this.TableLayoutPanel1.Location = new Point(0, 0x18d);
            this.TableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98f));
            this.TableLayoutPanel1.Size = new Size(0x757, 0x62);
            this.TableLayoutPanel1.TabIndex = 0x1ed36d7;
            this.GroupBox17.Controls.Add(this.MaterialNote);
            this.GroupBox17.Dock = DockStyle.Top;
            this.GroupBox17.Location = new Point(0, 0x2b6);
            this.GroupBox17.Margin = new Padding(4, 5, 4, 5);
            this.GroupBox17.Name = "GroupBox17";
            this.GroupBox17.Padding = new Padding(4, 5, 4, 5);
            this.GroupBox17.Size = new Size(0x757, 90);
            this.GroupBox17.TabIndex = 0x1ed36d9;
            this.GroupBox17.TabStop = false;
            this.GroupBox17.Text = "ملاحظات";
            this.MaterialNote.Dock = DockStyle.Fill;
            this.MaterialNote.Location = new Point(4, 0x22);
            this.MaterialNote.Margin = new Padding(4, 0, 4, 0);
            this.MaterialNote.Name = "MaterialNote";
            this.MaterialNote.RightToLeft = RightToLeft.No;
            this.MaterialNote.Size = new Size(0x74f, 0x33);
            this.MaterialNote.TabIndex = 0;
            this.MaterialNote.TextAlign = ContentAlignment.MiddleCenter;
            this.TableLayoutPanel3.ColumnCount = 5;
            this.TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            this.TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            this.TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            this.TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            this.TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
            this.TableLayoutPanel3.Controls.Add(this.GroupBox2, 4, 0);
            this.TableLayoutPanel3.Controls.Add(this.GroupBox11, 3, 0);
            this.TableLayoutPanel3.Controls.Add(this.GroupBox1, 2, 0);
            this.TableLayoutPanel3.Controls.Add(this.GroupBox12, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.GroupBox7, 0, 0);
            this.TableLayoutPanel3.Dock = DockStyle.Top;
            this.TableLayoutPanel3.Location = new Point(0, 0x1ef);
            this.TableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 1;
            this.TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel3.Size = new Size(0x757, 0x59);
            this.TableLayoutPanel3.TabIndex = 0x1ed36da;
            this.GroupBox2.Controls.Add(this.MDarVal);
            this.GroupBox2.Dock = DockStyle.Fill;
            this.GroupBox2.Location = new Point(6, 6);
            this.GroupBox2.Margin = new Padding(6, 6, 6, 6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new Padding(6, 6, 6, 6);
            this.GroupBox2.Size = new Size(0x16f, 0x4d);
            this.GroupBox2.TabIndex = 0x5d;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "مبلغ الضريبة";
            this.MDarVal.Dock = DockStyle.Fill;
            this.MDarVal.ForeColor = Color.FromArgb(0, 0xc0, 0);
            this.MDarVal.Location = new Point(6, 0x23);
            this.MDarVal.Margin = new Padding(6, 0, 6, 0);
            this.MDarVal.Name = "MDarVal";
            this.MDarVal.RightToLeft = RightToLeft.No;
            this.MDarVal.Size = new Size(0x163, 0x24);
            this.MDarVal.TabIndex = 0;
            this.MDarVal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox1.Controls.Add(this.MDisVal);
            this.GroupBox1.Dock = DockStyle.Fill;
            this.GroupBox1.Location = new Point(760, 6);
            this.GroupBox1.Margin = new Padding(6, 6, 6, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new Padding(6, 6, 6, 6);
            this.GroupBox1.Size = new Size(0x16b, 0x4d);
            this.GroupBox1.TabIndex = 0x5c;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "مبلغ الخصم";
            this.MDisVal.Dock = DockStyle.Fill;
            this.MDisVal.ForeColor = Color.FromArgb(0, 0xc0, 0);
            this.MDisVal.Location = new Point(6, 0x23);
            this.MDisVal.Margin = new Padding(6, 0, 6, 0);
            this.MDisVal.Name = "MDisVal";
            this.MDisVal.RightToLeft = RightToLeft.No;
            this.MDisVal.Size = new Size(0x15f, 0x24);
            this.MDisVal.TabIndex = 0;
            this.MDisVal.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(13f, 29f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x757, 0x44c);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBox17);
            base.Controls.Add(this.GroupBox14);
            base.Controls.Add(this.TableLayoutPanel3);
            base.Controls.Add(this.TableLayoutPanel1);
            base.Controls.Add(this.TxTTip);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Margin = new Padding(6, 8, 6, 8);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ScreenCustomer";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ScreenCustomer";
            base.WindowState = FormWindowState.Maximized;
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((ISupportInitialize) this.PictureBox2).EndInit();
            this.GroupBox14.ResumeLayout(false);
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.GroupBox17.ResumeLayout(false);
            this.TableLayoutPanel3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void A(object A, EventArgs R)
        {
            ProjectData.EndApp();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonSBarCode.PerformClick();
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

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            this.TxTBarCode.Text = null;
            this.TxTBarCode.Focus();
        }

        public void P()
        {
            Application.DoEvents();
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialMultBarCode] Like '%*' + @MaterialMultBarCode + '*%')";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.SelectCommand.Parameters.AddWithValue("MaterialMultBarCode", this.TxTBarCode.Text);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.R.Text = dataTable.Rows[0]["MaterialID"].ToString();
                    this.Q();
                }
                else
                {
                    this.TxTTip.Text = "لم يتم العثور على المادة ";
                    this.TxTTip.ForeColor = Color.Red;
                    this.TxTBarCode.Text = null;
                    this.TxTBarCode.Focus();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TxTBarCode.Text = null;
                this.TxTBarCode.Focus();
                ProjectData.ClearProjectError();
            }
        }

        private void P(object A, EventArgs R)
        {
            this.R();
        }

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            A.D.A.A.ShowDialog();
        }

        public void R()
        {
            Application.DoEvents();
            this.TxTTip.Text = null;
            this.TxTTip.ForeColor = Color.Green;
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialBarCode] = @MaterialBarCode)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.SelectCommand.Parameters.AddWithValue("MaterialBarCode", this.TxTBarCode.Text);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    this.P();
                }
                else
                {
                    this.R.Text = dataTable.Rows[0]["MaterialID"].ToString();
                    this.Q();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.TxTBarCode.Text = null;
                this.TxTBarCode.Focus();
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, EventArgs R)
        {
            // Invalid method body.
        }

        internal virtual Label Label1
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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

        internal virtual Panel Panel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTBarCode
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual PictureBox PictureBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox14
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label MSTotal
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label MaterialDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label MaterialDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label MaterialUnit
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual Label MaterialBarCode
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label MaterialPricSale
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label MaterialName
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Button ButtonSBarCode
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

        internal virtual Label TxTTip
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TableLayoutPanel TableLayoutPanel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox17
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Label MaterialNote
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual Button ButtonAdva
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual TableLayoutPanel TableLayoutPanel3
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

        internal virtual Label MDarVal
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual Label MDisVal
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }
    }
}

