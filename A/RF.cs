namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class RF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("ButtonOk"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("AutoStop"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [AccessedThroughProperty("StatusStrip1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StatusStrip A;
        [AccessedThroughProperty("ToolStripStatusLabel1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripStatusLabel A;
        [AccessedThroughProperty("LBRR"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripStatusLabel R;
        [AccessedThroughProperty("ProssBar"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("ButtonBrows"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("GroupBoxFileName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("GroupBoxAutoAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [AccessedThroughProperty("GroupBox6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("MaterialBarCode"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("GroupBox7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("MaterialName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("GroupBox8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox I;
        [AccessedThroughProperty("MaterialQuantity"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [AccessedThroughProperty("ButtonAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [AccessedThroughProperty("GroupBox10"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox D;
        [AccessedThroughProperty("MaterialPricCost"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [AccessedThroughProperty("GroupBox11"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [CompilerGenerated, AccessedThroughProperty("MaterialPricLess"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [CompilerGenerated, AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [CompilerGenerated, AccessedThroughProperty("MaterialPricSale"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox D;
        [CompilerGenerated, AccessedThroughProperty("OpenFileDialog1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OpenFileDialog A;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [CompilerGenerated, AccessedThroughProperty("MaterialUnit"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox F;
        [AccessedThroughProperty("GroupBox15"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox X;
        [CompilerGenerated, AccessedThroughProperty("MaterialNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox H;
        [CompilerGenerated, AccessedThroughProperty("GVM"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GVG"), CompilerGenerated]
        private DataGridView R;
        [CompilerGenerated, AccessedThroughProperty("TextBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox T;
        [CompilerGenerated, AccessedThroughProperty("TxTCataName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox X;
        [AccessedThroughProperty("Timer1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        private string A;
        private int A;
        private SqlConnection A;
        private int R;

        public RF()
        {
            base.Load += new EventHandler(this.F);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.AutoStop = new CheckBox();
            this.StatusStrip1 = new StatusStrip();
            this.ToolStripStatusLabel1 = new ToolStripStatusLabel();
            this.LBRR = new ToolStripStatusLabel();
            this.ProssBar = new ToolStripProgressBar();
            this.GroupBoxFileName = new GroupBox();
            this.Label1 = new Label();
            this.GroupBoxAutoAdd = new GroupBox();
            this.GroupBox6 = new GroupBox();
            this.MaterialBarCode = new TextBox();
            this.GroupBox7 = new GroupBox();
            this.MaterialName = new TextBox();
            this.GroupBox8 = new GroupBox();
            this.MaterialQuantity = new TextBox();
            this.ButtonAdd = new Button();
            this.GroupBox10 = new GroupBox();
            this.MaterialPricCost = new TextBox();
            this.GroupBox11 = new GroupBox();
            this.MaterialPricLess = new TextBox();
            this.GroupBox12 = new GroupBox();
            this.MaterialPricSale = new TextBox();
            this.GVM = new DataGridView();
            this.OpenFileDialog1 = new OpenFileDialog();
            this.GroupBox9 = new GroupBox();
            this.TextBox1 = new TextBox();
            this.MaterialUnit = new TextBox();
            this.GroupBox15 = new GroupBox();
            this.MaterialNote = new TextBox();
            this.GVG = new DataGridView();
            this.TxTCataName = new TextBox();
            this.Timer1 = new Timer(this.A);
            this.ButtonBrows = new Button();
            this.ButtonOk = new Button();
            this.StatusStrip1.SuspendLayout();
            this.GroupBoxFileName.SuspendLayout();
            this.GroupBoxAutoAdd.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            ((ISupportInitialize) this.GVM).BeginInit();
            this.GroupBox9.SuspendLayout();
            this.GroupBox15.SuspendLayout();
            ((ISupportInitialize) this.GVG).BeginInit();
            base.SuspendLayout();
            this.AutoStop.BackColor = Color.Gainsboro;
            this.AutoStop.Dock = DockStyle.Bottom;
            this.AutoStop.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.AutoStop.Location = new Point(0, 0xf8);
            this.AutoStop.Margin = new Padding(8);
            this.AutoStop.Name = "AutoStop";
            this.AutoStop.Padding = new Padding(10);
            this.AutoStop.Size = new Size(850, 0x43);
            this.AutoStop.TabIndex = 0x57;
            this.AutoStop.Text = "توقف عند كل مادة واترك لي حرية التعديل";
            this.AutoStop.UseVisualStyleBackColor = false;
            this.StatusStrip1.BackColor = Color.WhiteSmoke;
            this.StatusStrip1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripStatusLabel1, this.LBRR, this.ProssBar };
            this.StatusStrip1.Items.AddRange(toolStripItems);
            this.StatusStrip1.Location = new Point(0, 0x13b);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new Size(850, 0x18);
            this.StatusStrip1.TabIndex = 0x58;
            this.StatusStrip1.Text = "StatusStrip1";
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new Size(0x52, 0x13);
            this.ToolStripStatusLabel1.Text = "عدد المواد:";
            this.LBRR.ForeColor = Color.Green;
            this.LBRR.Name = "LBRR";
            this.LBRR.Size = new Size(0x12, 0x13);
            this.LBRR.Text = "0";
            this.ProssBar.Name = "ProssBar";
            this.ProssBar.Size = new Size(100, 0x12);
            this.ProssBar.Visible = false;
            this.GroupBoxFileName.Controls.Add(this.Label1);
            this.GroupBoxFileName.Controls.Add(this.ButtonBrows);
            this.GroupBoxFileName.Controls.Add(this.ButtonOk);
            this.GroupBoxFileName.Location = new Point(12, 12);
            this.GroupBoxFileName.Name = "GroupBoxFileName";
            this.GroupBoxFileName.RightToLeft = RightToLeft.No;
            this.GroupBoxFileName.Size = new Size(0x33c, 0x4f);
            this.GroupBoxFileName.TabIndex = 90;
            this.GroupBoxFileName.TabStop = false;
            this.Label1.Location = new Point(6, 0x11);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.Yes;
            this.Label1.Size = new Size(0x18f, 0x35);
            this.Label1.TabIndex = 90;
            this.Label1.Text = "حدد ملف قاعدة البيانات ImportDB";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBoxAutoAdd.Controls.Add(this.GroupBox6);
            this.GroupBoxAutoAdd.Controls.Add(this.GroupBox7);
            this.GroupBoxAutoAdd.Controls.Add(this.GroupBox8);
            this.GroupBoxAutoAdd.Controls.Add(this.ButtonAdd);
            this.GroupBoxAutoAdd.Controls.Add(this.GroupBox10);
            this.GroupBoxAutoAdd.Controls.Add(this.GroupBox11);
            this.GroupBoxAutoAdd.Controls.Add(this.GroupBox12);
            this.GroupBoxAutoAdd.Enabled = false;
            this.GroupBoxAutoAdd.Location = new Point(12, 0x61);
            this.GroupBoxAutoAdd.Name = "GroupBoxAutoAdd";
            this.GroupBoxAutoAdd.Size = new Size(0x33c, 0x8a);
            this.GroupBoxAutoAdd.TabIndex = 0x5b;
            this.GroupBoxAutoAdd.TabStop = false;
            this.GroupBox6.Controls.Add(this.MaterialBarCode);
            this.GroupBox6.Location = new Point(0x26d, 15);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(200, 0x31);
            this.GroupBox6.TabIndex = 2;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "رقم/ كود المادة";
            this.MaterialBarCode.Dock = DockStyle.Fill;
            this.MaterialBarCode.Enabled = false;
            this.MaterialBarCode.Location = new Point(3, 0x13);
            this.MaterialBarCode.MaxLength = 50;
            this.MaterialBarCode.Name = "MaterialBarCode";
            this.MaterialBarCode.RightToLeft = RightToLeft.No;
            this.MaterialBarCode.Size = new Size(0xc2, 0x17);
            this.MaterialBarCode.TabIndex = 0;
            this.MaterialBarCode.TextAlign = HorizontalAlignment.Center;
            this.GroupBox7.Controls.Add(this.MaterialName);
            this.GroupBox7.Location = new Point(0x19f, 15);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(200, 0x31);
            this.GroupBox7.TabIndex = 3;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "اسم المادة";
            this.MaterialName.Dock = DockStyle.Fill;
            this.MaterialName.Enabled = false;
            this.MaterialName.Location = new Point(3, 0x13);
            this.MaterialName.MaxLength = 50;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Size = new Size(0xc2, 0x17);
            this.MaterialName.TabIndex = 0;
            this.MaterialName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox8.Controls.Add(this.MaterialQuantity);
            this.GroupBox8.Location = new Point(0xd1, 15);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(200, 0x31);
            this.GroupBox8.TabIndex = 4;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "الكمية";
            this.MaterialQuantity.Dock = DockStyle.Fill;
            this.MaterialQuantity.Location = new Point(3, 0x13);
            this.MaterialQuantity.MaxLength = 20;
            this.MaterialQuantity.Name = "MaterialQuantity";
            this.MaterialQuantity.RightToLeft = RightToLeft.No;
            this.MaterialQuantity.Size = new Size(0xc2, 0x17);
            this.MaterialQuantity.TabIndex = 0;
            this.MaterialQuantity.TextAlign = HorizontalAlignment.Center;
            this.ButtonAdd.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Popup;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(14, 0x17);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0xbd, 0x60);
            this.ButtonAdd.TabIndex = 0x54;
            this.ButtonAdd.Text = "استمرار";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.GroupBox10.Controls.Add(this.MaterialPricCost);
            this.GroupBox10.Location = new Point(0x26d, 70);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(200, 0x31);
            this.GroupBox10.TabIndex = 0x4c;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "سعر التكلفة";
            this.MaterialPricCost.Dock = DockStyle.Fill;
            this.MaterialPricCost.Location = new Point(3, 0x13);
            this.MaterialPricCost.MaxLength = 20;
            this.MaterialPricCost.Name = "MaterialPricCost";
            this.MaterialPricCost.RightToLeft = RightToLeft.No;
            this.MaterialPricCost.Size = new Size(0xc2, 0x17);
            this.MaterialPricCost.TabIndex = 0;
            this.MaterialPricCost.TextAlign = HorizontalAlignment.Center;
            this.GroupBox11.Controls.Add(this.MaterialPricLess);
            this.GroupBox11.Location = new Point(0x19f, 70);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(200, 0x31);
            this.GroupBox11.TabIndex = 0x4d;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "سعر البيع المخفض";
            this.MaterialPricLess.Dock = DockStyle.Fill;
            this.MaterialPricLess.Location = new Point(3, 0x13);
            this.MaterialPricLess.MaxLength = 20;
            this.MaterialPricLess.Name = "MaterialPricLess";
            this.MaterialPricLess.RightToLeft = RightToLeft.No;
            this.MaterialPricLess.Size = new Size(0xc2, 0x17);
            this.MaterialPricLess.TabIndex = 0;
            this.MaterialPricLess.TextAlign = HorizontalAlignment.Center;
            this.GroupBox12.Controls.Add(this.MaterialPricSale);
            this.GroupBox12.Location = new Point(0xd4, 70);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(200, 0x31);
            this.GroupBox12.TabIndex = 0x4e;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "سعر البيع";
            this.MaterialPricSale.Dock = DockStyle.Fill;
            this.MaterialPricSale.Location = new Point(3, 0x13);
            this.MaterialPricSale.MaxLength = 20;
            this.MaterialPricSale.Name = "MaterialPricSale";
            this.MaterialPricSale.RightToLeft = RightToLeft.No;
            this.MaterialPricSale.Size = new Size(0xc2, 0x17);
            this.MaterialPricSale.TabIndex = 0;
            this.MaterialPricSale.TextAlign = HorizontalAlignment.Center;
            this.GVM.AllowUserToAddRows = false;
            this.GVM.AllowUserToDeleteRows = false;
            this.GVM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVM.Location = new Point(0x249, 0x1b5);
            this.GVM.MultiSelect = false;
            this.GVM.Name = "GVM";
            this.GVM.ReadOnly = true;
            this.GVM.RowHeadersVisible = false;
            this.GVM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVM.Size = new Size(0xd8, 0x65);
            this.GVM.TabIndex = 100;
            this.GroupBox9.Controls.Add(this.TextBox1);
            this.GroupBox9.Controls.Add(this.MaterialUnit);
            this.GroupBox9.Location = new Point(0xe5, 0x233);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(200, 0x31);
            this.GroupBox9.TabIndex = 0x5d;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "الوحدة";
            this.TextBox1.Dock = DockStyle.Fill;
            this.TextBox1.Location = new Point(3, 0x13);
            this.TextBox1.MaxLength = 50;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new Size(0xc2, 0x17);
            this.TextBox1.TabIndex = 1;
            this.MaterialUnit.Dock = DockStyle.Fill;
            this.MaterialUnit.Location = new Point(3, 0x13);
            this.MaterialUnit.Name = "MaterialUnit";
            this.MaterialUnit.Size = new Size(0xc2, 0x17);
            this.MaterialUnit.TabIndex = 0;
            this.GroupBox15.Controls.Add(this.MaterialNote);
            this.GroupBox15.Location = new Point(0x7f, 0x233);
            this.GroupBox15.Name = "GroupBox15";
            this.GroupBox15.Size = new Size(0x59, 0x31);
            this.GroupBox15.TabIndex = 0x5e;
            this.GroupBox15.TabStop = false;
            this.GroupBox15.Text = "ملاحظات";
            this.MaterialNote.Dock = DockStyle.Fill;
            this.MaterialNote.Location = new Point(3, 0x13);
            this.MaterialNote.MaxLength = 250;
            this.MaterialNote.Name = "MaterialNote";
            this.MaterialNote.Size = new Size(0x53, 0x17);
            this.MaterialNote.TabIndex = 0;
            this.GVG.AllowUserToAddRows = false;
            this.GVG.AllowUserToDeleteRows = false;
            this.GVG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVG.Location = new Point(0x15f, 0x1b5);
            this.GVG.MultiSelect = false;
            this.GVG.Name = "GVG";
            this.GVG.ReadOnly = true;
            this.GVG.RowHeadersVisible = false;
            this.GVG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVG.Size = new Size(0xd8, 0x65);
            this.GVG.TabIndex = 0x65;
            this.TxTCataName.Location = new Point(0x203, 0x24f);
            this.TxTCataName.MaxLength = 50;
            this.TxTCataName.Name = "TxTCataName";
            this.TxTCataName.Size = new Size(100, 0x17);
            this.TxTCataName.TabIndex = 0x66;
            this.Timer1.Interval = 500;
            this.ButtonBrows.FlatAppearance.BorderColor = Color.Green;
            this.ButtonBrows.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonBrows.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonBrows.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonBrows.FlatStyle = FlatStyle.Flat;
            this.ButtonBrows.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonBrows.Image = A.F.ImView;
            this.ButtonBrows.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonBrows.Location = new Point(0x23e, 0x17);
            this.ButtonBrows.Margin = new Padding(3, 4, 3, 4);
            this.ButtonBrows.Name = "ButtonBrows";
            this.ButtonBrows.RightToLeft = RightToLeft.Yes;
            this.ButtonBrows.Size = new Size(0xf4, 0x29);
            this.ButtonBrows.TabIndex = 0x59;
            this.ButtonBrows.Text = "تحديد ملف قاعدة البيانات";
            this.ButtonBrows.UseVisualStyleBackColor = true;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(0x19b, 0x17);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.RightToLeft = RightToLeft.Yes;
            this.ButtonOk.Size = new Size(0x9d, 0x29);
            this.ButtonOk.TabIndex = 0x47;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(850, 0x153);
            base.Controls.Add(this.TxTCataName);
            base.Controls.Add(this.GVG);
            base.Controls.Add(this.GVM);
            base.Controls.Add(this.GroupBox9);
            base.Controls.Add(this.GroupBox15);
            base.Controls.Add(this.GroupBoxAutoAdd);
            base.Controls.Add(this.GroupBoxFileName);
            base.Controls.Add(this.AutoStop);
            base.Controls.Add(this.StatusStrip1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialImport";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "استيراد المستودع";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.GroupBoxFileName.ResumeLayout(false);
            this.GroupBoxAutoAdd.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox7.PerformLayout();
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            ((ISupportInitialize) this.GVM).EndInit();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.GroupBox15.ResumeLayout(false);
            this.GroupBox15.PerformLayout();
            ((ISupportInitialize) this.GVG).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            if (this.GroupBoxFileName.Text == null)
            {
                Interaction.MsgBox("حدد ملف قاعدة البينات", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    string text1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.A + ";Jet OLEDB:Database Password=jood1200";
                    OleDbConnection selectConnection = new OleDbConnection(text1 ?? "");
                    if (selectConnection.State == ConnectionState.Closed)
                    {
                        selectConnection.Open();
                    }
                    OleDbCommand command = new OleDbCommand {
                        Connection = selectConnection,
                        CommandType = CommandType.Text
                    };
                    string str2 = "";
                    command.CommandText = "UPDATE TaMaterial SET CatName = @CatName WHERE CatName = '" + str2 + "'";
                    command.Parameters.AddWithValue("CatName", "بدون non");
                    command.ExecuteNonQuery();
                    selectConnection.Close();
                    DataSet dataSet = new DataSet();
                    if (selectConnection.State == ConnectionState.Closed)
                    {
                        selectConnection.Open();
                    }
                    string selectCommandText = "SELECT MMBarCode FROM TaMaterial";
                    dataSet.Clear();
                    new OleDbDataAdapter(selectCommandText, selectConnection).Fill(dataSet, "TaMaterial");
                    selectConnection.Close();
                    DataSet set2 = new DataSet();
                    if (selectConnection.State == ConnectionState.Closed)
                    {
                        selectConnection.Open();
                    }
                    string str4 = "Select DISTINCT CatName FROM TaMaterial";
                    set2.Clear();
                    new OleDbDataAdapter(str4, selectConnection).Fill(set2, "TaMaterial");
                    selectConnection.Close();
                    this.TxTCataName.DataBindings.Clear();
                    this.TxTCataName.DataBindings.Add("Text", set2, "TaMaterial.CatName");
                    this.GVG.DataSource = set2;
                    this.GVG.DataMember = "TaMaterial";
                    this.GVG.Refresh();
                    this.R();
                    this.A = dataSet.Tables[0].Rows.Count;
                    this.LBRR.Text = Conversions.ToString(this.A);
                    this.ProssBar.Maximum = this.A + 20;
                    this.ProssBar.Visible = true;
                    this.GroupBoxFileName.Enabled = false;
                    this.Timer1.Enabled = true;
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
                    this.GroupBoxFileName.Enabled = true;
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void D(object A, EventArgs R)
        {
            if (Conversion.Val(this.LBRR.Text) < 0.0)
            {
                this.Timer1.Enabled = false;
                this.ProssBar.Visible = false;
                Interaction.MsgBox("انتهى النقل", MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
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
        }

        private void I(object A, EventArgs R)
        {
            if (this.AutoStop.Checked && ((this.MaterialBarCode.Text == null) | (this.MaterialBarCode.Text == "")))
            {
                this.ButtonAdd.Enabled = false;
                this.GroupBoxAutoAdd.Enabled = false;
            }
        }

        public void P()
        {
            try
            {
                decimal num = new decimal(Conversion.Val(this.MaterialQuantity.Text.Replace(",", "")));
                decimal num2 = new decimal(Conversion.Val(this.MaterialPricCost.Text.Replace(",", "")));
                decimal num3 = new decimal(Conversion.Val(this.MaterialPricLess.Text.Replace(",", "")));
                decimal num4 = new decimal(Conversion.Val(this.MaterialPricSale.Text.Replace(",", "")));
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("INSERT INTO TaNNMaterial(CenterFrontID, GroupIDFrontID, MaterialBarCode, MaterialName, MaterialQuantity, MaterialUnit, MaterialPricCost, MaterialPricLess, MaterialPricSale, MaterialIsStop, MaterialExpDate, MaterialNote, MaterialNotIsView, MaterialQuantityLess, MaterialQuantityPakeg, MaterialQuantityOffer, MaterialDisMiWi, MaterialDarMiWi, MaterialOtherBarCode, MaterialMultBarCode, MaterialBarcodeBlock) VALUES (@CenterFrontID, @GroupIDFrontID, @MaterialBarCode, @MaterialName, @MaterialQuantity, @MaterialUnit, @MaterialPricCost, @MaterialPricLess, @MaterialPricSale, @MaterialIsStop, @MaterialExpDate, @MaterialNote, @MaterialNotIsView, @MaterialQuantityLess, @MaterialQuantityPakeg, @MaterialQuantityOffer, @MaterialDisMiWi, @MaterialDarMiWi, @MaterialOtherBarCode, @MaterialMultBarCode, @MaterialBarcodeBlock)", this.A);
                command.Parameters.AddWithValue("@CenterFrontID", PR.GR);
                if (this.R > 10)
                {
                    command.Parameters.AddWithValue("@GroupIDFrontID", this.R);
                }
                else
                {
                    command.Parameters.AddWithValue("@GroupIDFrontID", "0");
                }
                command.Parameters.AddWithValue("@MaterialBarCode", this.MaterialBarCode.Text.Trim());
                command.Parameters.AddWithValue("@MaterialName", this.MaterialName.Text.Trim());
                command.Parameters.AddWithValue("@MaterialQuantity", num.ToString(PR.OR));
                command.Parameters.AddWithValue("@MaterialUnit", this.MaterialUnit.Text.Trim());
                command.Parameters.AddWithValue("@MaterialPricCost", num2.ToString(PR.VR));
                command.Parameters.AddWithValue("@MaterialPricLess", num3.ToString(PR.VR));
                command.Parameters.AddWithValue("@MaterialPricSale", num4.ToString(PR.VR));
                command.Parameters.AddWithValue("@MaterialIsStop", false);
                command.Parameters.AddWithValue("@MaterialExpDate", DBNull.Value);
                command.Parameters.AddWithValue("@MaterialNote", this.MaterialNote.Text.Trim());
                command.Parameters.AddWithValue("@MaterialNotIsView", false);
                command.Parameters.AddWithValue("MaterialQuantityLess", "0");
                command.Parameters.AddWithValue("MaterialQuantityPakeg", "0");
                command.Parameters.AddWithValue("MaterialQuantityOffer", "0");
                command.Parameters.AddWithValue("MaterialDisMiWi", "0");
                command.Parameters.AddWithValue("MaterialDarMiWi", "0");
                command.Parameters.AddWithValue("MaterialOtherBarCode", "");
                command.Parameters.AddWithValue("MaterialMultBarCode", "");
                command.Parameters.AddWithValue("MaterialBarcodeBlock", PR.GR.ToString() + this.MaterialBarCode.Text.Trim());
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.GVM.RowCount > 0)
                {
                    this.ProssBar.Value = (int) Math.Round((double) (Conversion.Val(this.ProssBar.Value) + 1.0));
                    this.LBRR.Text = Conversions.ToString((double) (Conversion.Val(this.LBRR.Text) - 1.0));
                    this.GVM.Rows.Remove(this.GVM.SelectedRows[0]);
                    this.Timer1.Enabled = true;
                }
                else if (this.GVG.RowCount > 0)
                {
                    this.GVG.Rows.Remove(this.GVG.SelectedRows[0]);
                    this.Timer1.Enabled = true;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.GVM.Rows.Remove(this.GVM.SelectedRows[0]);
                this.Timer1.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void P(object A, EventArgs R)
        {
            this.P();
        }

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void Q(object A, EventArgs R)
        {
            this.Timer1.Enabled = false;
            if (!((this.GVM.RowCount > 0) | (this.GVG.RowCount > 0)))
            {
                this.ProssBar.Visible = false;
                Interaction.MsgBox("انتهى النقل", MsgBoxStyle.ApplicationModal, null);
                A.D.A.A.TimerLoadData.Enabled = true;
                base.Dispose();
            }
            else
            {
                try
                {
                    if (this.GVM.RowCount <= 0)
                    {
                        this.GVG.Rows.Remove(this.GVG.SelectedRows[0]);
                        this.R();
                    }
                    else if (this.AutoStop.Checked)
                    {
                        this.GroupBoxAutoAdd.Enabled = true;
                        this.ButtonAdd.Enabled = true;
                    }
                    else
                    {
                        this.GroupBoxAutoAdd.Enabled = false;
                        this.ButtonAdd.Enabled = false;
                        this.P();
                    }
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    if (this.GVM.RowCount > 0)
                    {
                        this.GVM.Rows.Remove(this.GVM.SelectedRows[0]);
                        if (this.AutoStop.Checked)
                        {
                            this.GroupBoxAutoAdd.Enabled = true;
                            this.ButtonAdd.Enabled = true;
                        }
                        else
                        {
                            this.GroupBoxAutoAdd.Enabled = false;
                            this.ButtonAdd.Enabled = false;
                            this.P();
                        }
                    }
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void Q(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        public void R()
        {
            try
            {
                string str2;
                string text1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.A + ";Jet OLEDB:Database Password=jood1200";
                OleDbConnection selectConnection = new OleDbConnection(text1 ?? "");
                DataSet dataSet = new DataSet();
                if (selectConnection.State == ConnectionState.Closed)
                {
                    selectConnection.Open();
                }
                if (this.TxTCataName.Text == null)
                {
                    str2 = "SELECT MMBarCode, MMName, MMQuantity, MMWhPrice, MMSalePrice, MMUnit, MMNote, MMSalePriceLes FROM TaMaterial WHERE CatName  IS NULL";
                    this.R = 0;
                }
                else
                {
                    str2 = "SELECT MMBarCode, MMName, MMQuantity, MMWhPrice, MMSalePrice, MMUnit, MMNote, MMSalePriceLes FROM TaMaterial WHERE CatName = '" + this.TxTCataName.Text + "'";
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO TaNNMaterialGroup (CenterFrontID, GroupName) VALUES (@CenterFrontID, @GroupName); SELECT GroupID FROM TaNNMaterialGroup WHERE (GroupID = SCOPE_IDENTITY())", this.A);
                    command.Parameters.AddWithValue("@CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("@GroupName", this.TxTCataName.Text.Trim());
                    this.R = Conversions.ToInteger(command.ExecuteScalar());
                    this.A.Close();
                }
                dataSet.Clear();
                new OleDbDataAdapter(str2, selectConnection).Fill(dataSet, "TaMaterial");
                selectConnection.Close();
                this.MaterialBarCode.DataBindings.Clear();
                this.MaterialName.DataBindings.Clear();
                this.MaterialQuantity.DataBindings.Clear();
                this.MaterialUnit.DataBindings.Clear();
                this.MaterialPricCost.DataBindings.Clear();
                this.MaterialPricSale.DataBindings.Clear();
                this.MaterialPricLess.DataBindings.Clear();
                this.MaterialNote.DataBindings.Clear();
                this.MaterialBarCode.DataBindings.Add("Text", dataSet, "TaMaterial.MMBarCode");
                this.MaterialName.DataBindings.Add("Text", dataSet, "TaMaterial.MMName");
                this.MaterialQuantity.DataBindings.Add("Text", dataSet, "TaMaterial.MMQuantity");
                this.MaterialUnit.DataBindings.Add("Text", dataSet, "TaMaterial.MMUnit");
                this.MaterialPricCost.DataBindings.Add("Text", dataSet, "TaMaterial.MMWhPrice");
                this.MaterialPricSale.DataBindings.Add("Text", dataSet, "TaMaterial.MMSalePrice");
                this.MaterialPricLess.DataBindings.Add("Text", dataSet, "TaMaterial.MMSalePriceLes");
                this.MaterialNote.DataBindings.Add("Text", dataSet, "TaMaterial.MMNote");
                this.GVM.DataSource = dataSet;
                this.GVM.DataMember = "TaMaterial";
                this.GVM.Refresh();
                this.Timer1.Enabled = true;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.GroupBoxFileName.Enabled = true;
                Interaction.MsgBox("خطأ في فتح ملف قاعدة البيانات", MsgBoxStyle.ApplicationModal, null);
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.GroupBoxFileName.Enabled = true;
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, EventArgs R)
        {
            this.OpenFileDialog1.ShowDialog();
            this.GroupBoxFileName.Text = this.OpenFileDialog1.FileName;
            this.A = this.OpenFileDialog1.FileName;
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.-".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        internal virtual Button ButtonOk
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

        internal virtual CheckBox AutoStop
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual StatusStrip StatusStrip1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripStatusLabel ToolStripStatusLabel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripStatusLabel LBRR
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                ToolStripStatusLabel r = this.R;
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

        internal virtual ToolStripProgressBar ProssBar
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonBrows
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

        internal virtual GroupBox GroupBoxFileName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBoxAutoAdd
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox MaterialBarCode
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                TextBox a = this.A;
                if (a != null)
                {
                    a.TextChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.TextChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox MaterialName
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox MaterialQuantity
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox p = this.P;
                if (p != null)
                {
                    p.KeyPress -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.KeyPress += handler;
                }
            }
        }

        internal virtual Button ButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox MaterialPricCost
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.R);
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

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox MaterialPricLess
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.P);
                TextBox i = this.I;
                if (i != null)
                {
                    i.KeyPress -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.KeyPress += handler;
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

        internal virtual TextBox MaterialPricSale
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.Q);
                TextBox d = this.D;
                if (d != null)
                {
                    d.KeyPress -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.KeyPress += handler;
                }
            }
        }

        internal virtual OpenFileDialog OpenFileDialog1
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TextBox MaterialUnit
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual GroupBox GroupBox15
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual TextBox MaterialNote
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual DataGridView GVM
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DataGridView GVG
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TextBox1
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TextBox TxTCataName
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual Timer Timer1
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
    }
}

