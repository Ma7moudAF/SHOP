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
    public class TF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [AccessedThroughProperty("ButtonSortDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("CheckBoxDr"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox A;
        [AccessedThroughProperty("CheckBoxSale"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox R;
        [AccessedThroughProperty("CheckBoxSaleReturn"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox P;
        [AccessedThroughProperty("CheckBoxTr"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox Q;
        [AccessedThroughProperty("CheckBoxPurch"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox I;
        [AccessedThroughProperty("CheckBoxPurchReturn"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox D;
        [AccessedThroughProperty("ToolStripButtons"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonPrint"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripButton A;
        [AccessedThroughProperty("ToolStripSeparator6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
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
        [AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView A;
        [AccessedThroughProperty("TimerLoadData"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer A;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [AccessedThroughProperty("TimerFillGV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer P;
        [AccessedThroughProperty("TimersStatrReport"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer Q;
        [AccessedThroughProperty("ToolStripProgressBarMaterial"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripProgressBar R;
        [AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("DateTimePickerFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker R;
        [AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("DateTimePickerTo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker P;
        [AccessedThroughProperty("PickerTimeTo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker Q;
        private SqlConnection A;
        private DataTable A;
        private string A;
        private string R;
        private string P;
        private string Q;
        private string I;
        private string D;
        private string F;
        private string H;
        private string T;
        private string X;
        private string G;
        private string E;
        private string K;
        private string U;
        private string L;
        private string N;
        private string V;
        private string Y;
        private string O;

        public TF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A = "SELECT * FROM TaNNMaterialReport WHERE (CenterFrontID = @CenterFrontID)";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.ButtonSortDate = new Button();
            this.CheckBoxDr = new CheckBox();
            this.CheckBoxSale = new CheckBox();
            this.CheckBoxSaleReturn = new CheckBox();
            this.CheckBoxTr = new CheckBox();
            this.CheckBoxPurch = new CheckBox();
            this.CheckBoxPurchReturn = new CheckBox();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonPrint = new ToolStripButton();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripProgressBarMaterial = new ToolStripProgressBar();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowCount = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.GV = new DataGridView();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TimerFillGV = new Timer(this.A);
            this.TimersStatrReport = new Timer(this.A);
            this.GroupBox1 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBox2 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d8, 0x22);
            this.TxTTitle.TabIndex = 110;
            this.TxTTitle.Text = "تقرير حركة الكميات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 0x97);
            this.TabControl1.TabIndex = 0x6f;
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Controls.Add(this.GroupBox2);
            this.TabPage1.Controls.Add(this.ButtonSortDate);
            this.TabPage1.Controls.Add(this.CheckBoxDr);
            this.TabPage1.Controls.Add(this.CheckBoxSale);
            this.TabPage1.Controls.Add(this.CheckBoxSaleReturn);
            this.TabPage1.Controls.Add(this.CheckBoxTr);
            this.TabPage1.Controls.Add(this.CheckBoxPurch);
            this.TabPage1.Controls.Add(this.CheckBoxPurchReturn);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3d0, 0x7a);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "الرئيسية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = A.F.ImOK;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(300, 0x19);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(280, 0x34);
            this.ButtonSortDate.TabIndex = 0x3f;
            this.ButtonSortDate.Text = "انشاء التقرير";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.CheckBoxDr.AutoSize = true;
            this.CheckBoxDr.Location = new Point(0x17e, 0x60);
            this.CheckBoxDr.Name = "CheckBoxDr";
            this.CheckBoxDr.Size = new Size(0x3e, 20);
            this.CheckBoxDr.TabIndex = 0x1ed36d5;
            this.CheckBoxDr.Text = "الاتلاف";
            this.CheckBoxDr.UseVisualStyleBackColor = true;
            this.CheckBoxSale.AutoSize = true;
            this.CheckBoxSale.Checked = true;
            this.CheckBoxSale.CheckState = CheckState.Checked;
            this.CheckBoxSale.Location = new Point(0x37f, 0x60);
            this.CheckBoxSale.Name = "CheckBoxSale";
            this.CheckBoxSale.Size = new Size(0x49, 20);
            this.CheckBoxSale.TabIndex = 0x1ed36d0;
            this.CheckBoxSale.Text = "المبيعات";
            this.CheckBoxSale.UseVisualStyleBackColor = true;
            this.CheckBoxSaleReturn.AutoSize = true;
            this.CheckBoxSaleReturn.Checked = true;
            this.CheckBoxSaleReturn.CheckState = CheckState.Checked;
            this.CheckBoxSaleReturn.Location = new Point(0x30b, 0x60);
            this.CheckBoxSaleReturn.Name = "CheckBoxSaleReturn";
            this.CheckBoxSaleReturn.Size = new Size(110, 20);
            this.CheckBoxSaleReturn.TabIndex = 0x1ed36d1;
            this.CheckBoxSaleReturn.Text = "مرتجع المبيعات";
            this.CheckBoxSaleReturn.UseVisualStyleBackColor = true;
            this.CheckBoxTr.AutoSize = true;
            this.CheckBoxTr.Location = new Point(450, 0x60);
            this.CheckBoxTr.Name = "CheckBoxTr";
            this.CheckBoxTr.Size = new Size(0x68, 20);
            this.CheckBoxTr.TabIndex = 0x1ed36d4;
            this.CheckBoxTr.Text = "الترحيل/ النقل";
            this.CheckBoxTr.UseVisualStyleBackColor = true;
            this.CheckBoxPurch.AutoSize = true;
            this.CheckBoxPurch.Checked = true;
            this.CheckBoxPurch.CheckState = CheckState.Checked;
            this.CheckBoxPurch.Location = new Point(0x2b0, 0x60);
            this.CheckBoxPurch.Name = "CheckBoxPurch";
            this.CheckBoxPurch.Size = new Size(0x55, 20);
            this.CheckBoxPurch.TabIndex = 0x1ed36d2;
            this.CheckBoxPurch.Text = "المشتريات";
            this.CheckBoxPurch.UseVisualStyleBackColor = true;
            this.CheckBoxPurchReturn.AutoSize = true;
            this.CheckBoxPurchReturn.Checked = true;
            this.CheckBoxPurchReturn.CheckState = CheckState.Checked;
            this.CheckBoxPurchReturn.Location = new Point(560, 0x60);
            this.CheckBoxPurchReturn.Name = "CheckBoxPurchReturn";
            this.CheckBoxPurchReturn.Size = new Size(0x7a, 20);
            this.CheckBoxPurchReturn.TabIndex = 0x1ed36d3;
            this.CheckBoxPurchReturn.Text = "مرتجع المشتريات";
            this.CheckBoxPurchReturn.UseVisualStyleBackColor = true;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonPrint, this.ToolStripSeparator6, this.ToolStripButtonClose, this.ToolStripSeparator7, this.ToolStripProgressBarMaterial };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x24d);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x1ed36cf;
            this.ToolStripButtonPrint.Image = A.F.ImPrint;
            this.ToolStripButtonPrint.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrint.Name = "ToolStripButtonPrint";
            this.ToolStripButtonPrint.Size = new Size(0x60, 0x2c);
            this.ToolStripButtonPrint.Text = "طباعة A4";
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
            this.ToolStripProgressBarMaterial.Name = "ToolStripProgressBarMaterial";
            this.ToolStripProgressBarMaterial.Size = new Size(100, 0x2c);
            this.ToolStripProgressBarMaterial.Visible = false;
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray2);
            this.ToolStripStatus.Location = new Point(0, 0x27c);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x1ed36ce;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x53, 0x16);
            this.ToolStripLabel1.Text = "عدد السجلات";
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
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.GV.Location = new Point(0, 0xb9);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3d8, 0x194);
            this.GV.TabIndex = 0x1ed36d0;
            this.GroupBox1.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox1.Controls.Add(this.PickerTimeFrom);
            this.GroupBox1.Location = new Point(0x30b, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0xb0, 0x4a);
            this.GroupBox1.TabIndex = 0x1ed36d6;
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
            this.GroupBox2.Location = new Point(0x247, 8);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0xb0, 0x48);
            this.GroupBox2.TabIndex = 0x1ed36d7;
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
            base.Controls.Add(this.GV);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "MaterialReport";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تقرير حركة الكميات";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        public void D()
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.R();
            this.TimersStatrReport.Enabled = true;
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
            this.TimersStatrReport.Enabled = false;
            try
            {
                A.D.A.A.GV.ClearSelection();
                this.ToolStripProgressBarMaterial.Visible = true;
                this.ToolStripProgressBarMaterial.Maximum = A.D.A.A.GV.Rows.Count;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBarMaterial.Visible = false;
                        this.P();
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        break;
                    }
                    this.ToolStripProgressBarMaterial.Value = num2;
                    this.R = "-";
                    this.P = "-";
                    this.Q = "-";
                    this.I = "-";
                    this.D = "-";
                    this.F = "-";
                    this.H = "-";
                    this.T = "-";
                    this.X = "-";
                    this.G = "-";
                    this.E = "-";
                    this.K = "-";
                    this.U = "-";
                    this.L = "-";
                    this.N = "-";
                    this.V = "-";
                    this.Y = "-";
                    this.O = "-";
                    bool flag = false;
                    flag = Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value);
                    this.R = A.D.A.A.GV.Rows[num2].Cells["MaterialBarCode"].Value.ToString();
                    this.P = A.D.A.A.GV.Rows[num2].Cells["MaterialName"].Value.ToString();
                    this.I = A.D.A.A.GV.Rows[num2].Cells["MaterialQuantity"].Value.ToString();
                    this.Q = A.D.A.A.GV.Rows[num2].Cells["MaterialUnit"].Value.ToString();
                    if (flag)
                    {
                        this.Q();
                    }
                    num2++;
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
                TI ti = new TI();
                ti.SetDataSource(this.A);
                ti.SetParameterValue("CenterName", PR.ER.ToString());
                ti.SetParameterValue("CenterSubName", PR.KR.ToString());
                ti.SetParameterValue("ParameterDeimelQ", PR.X);
                ti.SetParameterValue("ParameterDeimelS", PR.T);
                ti.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (PR.NR == null)
                {
                    ti.SetParameterValue("CenterCurrencyName", " ");
                }
                else
                {
                    ti.SetParameterValue("CenterCurrencyName", PR.NR.ToString());
                }
                if (PR.UR == null)
                {
                    ti.SetParameterValue("CenterPhone", " ");
                }
                else
                {
                    ti.SetParameterValue("CenterPhone", PR.UR.ToString());
                }
                new HR { CRViewer = { ReportSource = ti } }.ShowDialog();
                ti.Close();
                ti.Dispose();
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
            base.Dispose();
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
                this.GV.Columns["ReportID"].Visible = false;
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["MaterialBarCode"].HeaderText = "رقم/ باركود";
                this.GV.Columns["MaterialName"].HeaderText = "المادة";
                this.GV.Columns["MaterialUnit"].HeaderText = "الوحدة";
                this.GV.Columns["QuantityNow"].HeaderText = "الكمية الحالية";
                this.GV.Columns["SaleQuantity"].HeaderText = "كمية المبيعات";
                this.GV.Columns["SalePrice"].HeaderText = "سعر المبيعات";
                this.GV.Columns["SaleProft"].Visible = false;
                this.GV.Columns["SaleReturnQuantity"].HeaderText = "كمية مرتجع المبيعات";
                this.GV.Columns["SaleReturnPrice"].HeaderText = "سعر مرتجع المبيعات";
                this.GV.Columns["SaleReturnProft"].Visible = false;
                this.GV.Columns["PurchQuantity"].HeaderText = "كمية المشتريات";
                this.GV.Columns["PurchPrice"].HeaderText = "سعر المشتريات";
                this.GV.Columns["PurchReturnQuantity"].HeaderText = "كمية مرتجع المشتريات";
                this.GV.Columns["PurchReturnPrice"].HeaderText = "سعر مرتجع المشتريات";
                this.GV.Columns["TrQuantity"].HeaderText = "كمية الترحيل/النقل";
                this.GV.Columns["TrPrice"].HeaderText = "سعر الترحيل/النقل";
                this.GV.Columns["DsQuantity"].HeaderText = "كمية الاتلاف";
                this.GV.Columns["DsPrice"].HeaderText = "سعر الاتلاف";
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            int num = 0;
            while (true)
            {
                if ((num == 0) && this.CheckBoxSale.Checked)
                {
                    this.I();
                }
                if ((num == 1) && this.CheckBoxSaleReturn.Checked)
                {
                    this.D();
                }
                if ((num == 2) && this.CheckBoxPurch.Checked)
                {
                    this.F();
                }
                if ((num == 3) && this.CheckBoxPurchReturn.Checked)
                {
                    this.H();
                }
                if ((num == 4) && this.CheckBoxTr.Checked)
                {
                    this.T();
                }
                if ((num == 5) && this.CheckBoxDr.Checked)
                {
                    this.X();
                }
                if (num == 6)
                {
                    this.G();
                }
                num++;
                if (num > 15)
                {
                    return;
                }
            }
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
            this.P();
        }

        public void R()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("DELETE FROM TaNNMaterialReport WHERE (CenterFrontID = @CenterFrontID)", this.A);
                command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                command.ExecuteNonQuery();
                this.A.Close();
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
            try
            {
                A.D.A.A.GV.ClearSelection();
                A.D.A.A.GV.CurrentCell = A.D.A.A.GV.Rows[0].Cells[0];
                A.D.A.A.GV.Rows[0].Cells[0].Selected = true;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        if (!(Conversion.Val(this.TxTGVRowCount.Text) == 0.0))
                        {
                            this.TimerLoadData.Enabled = true;
                        }
                        else
                        {
                            Interaction.MsgBox("يجب تحديد اكثر من مادة المطلوب اجراء تقرير لها", MsgBoxStyle.ApplicationModal, null);
                            base.Dispose();
                        }
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells[0].Value))
                    {
                        this.TxTGVRowCount.Text = Conversions.ToString((double) (Conversion.Val(this.TxTGVRowCount.Text) + 1.0));
                    }
                    num2++;
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

        public void T()
        {
            // Invalid method body.
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

        internal virtual Button ButtonSortDate
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual CheckBox CheckBoxDr
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxSale
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual CheckBox CheckBoxSaleReturn
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual CheckBox CheckBoxTr
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual CheckBox CheckBoxPurch
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual CheckBox CheckBoxPurchReturn
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
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

        internal virtual ToolStripButton ToolStripButtonPrint
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual DataGridView GV
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

        internal virtual Timer TimersStatrReport
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual ToolStripProgressBar ToolStripProgressBarMaterial
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

