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
    public class CF : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [CompilerGenerated, AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("XTxTBarCodeLink")]
        private TextBox A;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtons"), CompilerGenerated]
        private ToolStrip A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonClose"), CompilerGenerated]
        private ToolStripButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator7")]
        private ToolStripSeparator A;
        [AccessedThroughProperty("AlarmShowSale"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private CheckBox A;
        [AccessedThroughProperty("Panel1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Panel A;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("TxTInputDate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonSortDate")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox5")]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("DateTimePicker"), CompilerGenerated]
        private System.Windows.Forms.DateTimePicker A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GVE")]
        private DataGridView A;
        [CompilerGenerated, AccessedThroughProperty("GVQ"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripProgressBar1"), CompilerGenerated]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("TimerLoadData"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimersStartUp")]
        private Timer R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerFillGV")]
        private Timer P;
        private SqlConnection A;
        private bool A;

        public CF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = false;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle style2 = new DataGridViewCellStyle();
            DataGridViewCellStyle style3 = new DataGridViewCellStyle();
            DataGridViewCellStyle style4 = new DataGridViewCellStyle();
            this.TxTTitle = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GVE = new DataGridView();
            this.Panel1 = new Panel();
            this.GroupBox4 = new GroupBox();
            this.TxTInputDate = new TextBox();
            this.ButtonSortDate = new Button();
            this.GroupBox5 = new GroupBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.XTxTBarCodeLink = new TextBox();
            this.TabPage2 = new TabPage();
            this.GVQ = new DataGridView();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.AlarmShowSale = new CheckBox();
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.TimerFillGV = new Timer(this.A);
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((ISupportInitialize) this.GVE).BeginInit();
            this.Panel1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize) this.GVQ).BeginInit();
            this.ToolStripButtons.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x38a, 0x26);
            this.TxTTitle.TabIndex = 0x3e;
            this.TxTTitle.Text = "فحص تنبيهات المستودع";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = DockStyle.Fill;
            this.TabControl1.Location = new Point(0, 0x26);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 5);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x38a, 0x18e);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 0x3f;
            this.TabPage1.Controls.Add(this.GVE);
            this.TabPage1.Controls.Add(this.Panel1);
            this.TabPage1.Controls.Add(this.XTxTBarCodeLink);
            this.TabPage1.Location = new Point(4, 0x1f);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x382, 0x16b);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "المواد منتهية الصلاحية";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GVE.AllowUserToAddRows = false;
            this.GVE.AllowUserToDeleteRows = false;
            this.GVE.AllowUserToOrderColumns = true;
            this.GVE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Control;
            style.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = Color.Red;
            style.SelectionBackColor = SystemColors.Highlight;
            style.SelectionForeColor = SystemColors.HighlightText;
            style.WrapMode = DataGridViewTriState.True;
            this.GVE.ColumnHeadersDefaultCellStyle = style;
            this.GVE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style2.BackColor = SystemColors.Window;
            style2.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style2.ForeColor = Color.FromArgb(0xc0, 0, 0);
            style2.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style2.SelectionForeColor = Color.Black;
            style2.WrapMode = DataGridViewTriState.False;
            this.GVE.DefaultCellStyle = style2;
            this.GVE.Dock = DockStyle.Fill;
            this.GVE.EnableHeadersVisualStyles = false;
            this.GVE.Location = new Point(3, 0x55);
            this.GVE.MultiSelect = false;
            this.GVE.Name = "GVE";
            this.GVE.ReadOnly = true;
            this.GVE.RightToLeft = RightToLeft.Yes;
            this.GVE.RowHeadersVisible = false;
            this.GVE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVE.Size = new Size(0x37c, 0x113);
            this.GVE.TabIndex = 0x1ed36d0;
            this.Panel1.Controls.Add(this.GroupBox4);
            this.Panel1.Controls.Add(this.ButtonSortDate);
            this.Panel1.Controls.Add(this.GroupBox5);
            this.Panel1.Dock = DockStyle.Top;
            this.Panel1.Location = new Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x37c, 0x52);
            this.Panel1.TabIndex = 0x1ed36d1;
            this.GroupBox4.Controls.Add(this.TxTInputDate);
            this.GroupBox4.Location = new Point(0x245, 15);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x127, 0x38);
            this.GroupBox4.TabIndex = 0x43;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "فرز المواد التي ينتهي تاريخها قبل";
            this.TxTInputDate.Dock = DockStyle.Fill;
            this.TxTInputDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInputDate.Location = new Point(3, 0x16);
            this.TxTInputDate.Name = "TxTInputDate";
            this.TxTInputDate.RightToLeft = RightToLeft.No;
            this.TxTInputDate.Size = new Size(0x121, 0x17);
            this.TxTInputDate.TabIndex = 0x3f;
            this.TxTInputDate.Text = "30";
            this.TxTInputDate.TextAlign = HorizontalAlignment.Center;
            this.ButtonSortDate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSortDate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSortDate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSortDate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSortDate.FlatStyle = FlatStyle.Flat;
            this.ButtonSortDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSortDate.Image = F.ImSort;
            this.ButtonSortDate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSortDate.Location = new Point(0x70, 0x1a);
            this.ButtonSortDate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSortDate.Name = "ButtonSortDate";
            this.ButtonSortDate.Size = new Size(0xc4, 0x2c);
            this.ButtonSortDate.TabIndex = 0x42;
            this.ButtonSortDate.Text = "فرز";
            this.ButtonSortDate.UseVisualStyleBackColor = true;
            this.GroupBox5.Controls.Add(this.DateTimePicker);
            this.GroupBox5.Location = new Point(0x13a, 15);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x105, 0x38);
            this.GroupBox5.TabIndex = 0x44;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "من تاريخ";
            this.DateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DateTimePicker.Dock = DockStyle.Fill;
            this.DateTimePicker.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePicker.Format = DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new Point(3, 0x16);
            this.DateTimePicker.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.RightToLeft = RightToLeft.No;
            this.DateTimePicker.Size = new Size(0xff, 0x17);
            this.DateTimePicker.TabIndex = 60;
            this.XTxTBarCodeLink.Location = new Point(850, 80);
            this.XTxTBarCodeLink.Name = "XTxTBarCodeLink";
            this.XTxTBarCodeLink.Size = new Size(0, 0x1a);
            this.XTxTBarCodeLink.TabIndex = 14;
            this.TabPage2.Controls.Add(this.GVQ);
            this.TabPage2.Location = new Point(4, 0x1f);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x382, 0x16b);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "مواد وصلت للحد الأدنى للكمية";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GVQ.AllowUserToAddRows = false;
            this.GVQ.AllowUserToDeleteRows = false;
            this.GVQ.AllowUserToOrderColumns = true;
            this.GVQ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style3.BackColor = SystemColors.Control;
            style3.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style3.ForeColor = Color.Red;
            style3.SelectionBackColor = SystemColors.Highlight;
            style3.SelectionForeColor = SystemColors.HighlightText;
            style3.WrapMode = DataGridViewTriState.True;
            this.GVQ.ColumnHeadersDefaultCellStyle = style3;
            this.GVQ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            style4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style4.BackColor = SystemColors.Window;
            style4.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style4.ForeColor = Color.FromArgb(0xc0, 0, 0);
            style4.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style4.SelectionForeColor = Color.Black;
            style4.WrapMode = DataGridViewTriState.False;
            this.GVQ.DefaultCellStyle = style4;
            this.GVQ.Dock = DockStyle.Fill;
            this.GVQ.EnableHeadersVisualStyles = false;
            this.GVQ.Location = new Point(3, 3);
            this.GVQ.MultiSelect = false;
            this.GVQ.Name = "GVQ";
            this.GVQ.ReadOnly = true;
            this.GVQ.RightToLeft = RightToLeft.Yes;
            this.GVQ.RowHeadersVisible = false;
            this.GVQ.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVQ.Size = new Size(0x37c, 0x165);
            this.GVQ.TabIndex = 0x1ed36d0;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripButtonClose, this.ToolStripSeparator7 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x1d4);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x38a, 0x2f);
            this.ToolStripButtons.TabIndex = 0x51;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x2c);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripButtonClose.Image = F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x2c);
            this.ToolStripButtonClose.Text = "اغلاق";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new Size(6, 0x2f);
            this.AlarmShowSale.AutoSize = true;
            this.AlarmShowSale.BackColor = Color.WhiteSmoke;
            this.AlarmShowSale.Checked = true;
            this.AlarmShowSale.CheckState = CheckState.Checked;
            this.AlarmShowSale.Dock = DockStyle.Bottom;
            this.AlarmShowSale.Location = new Point(0, 0x1b4);
            this.AlarmShowSale.Name = "AlarmShowSale";
            this.AlarmShowSale.Padding = new Padding(5);
            this.AlarmShowSale.Size = new Size(0x38a, 0x20);
            this.AlarmShowSale.TabIndex = 0x52;
            this.AlarmShowSale.Text = "عرض هذا التنبيه دائمأ قبل فتح شاشة البيع";
            this.AlarmShowSale.UseVisualStyleBackColor = false;
            this.TimersStartUp.Interval = 0x3e8;
            base.AutoScaleDimensions = new SizeF(8f, 18f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Info;
            base.ClientSize = new Size(0x38a, 0x203);
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.AlarmShowSale);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleAlarm";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            this.Text = "فحص تنبيهات المستودع";
            base.TopMost = true;
            base.WindowState = FormWindowState.Minimized;
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((ISupportInitialize) this.GVE).EndInit();
            this.Panel1.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            ((ISupportInitialize) this.GVQ).EndInit();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
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

        private void I(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
        }

        private void P(object A, EventArgs R)
        {
            this.TimersStartUp.Enabled = false;
            this.TimerLoadData.Enabled = true;
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerLoadData.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.TimerFillGV.Enabled = true;
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
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT * FROM [TaNNMaterial] WHERE CenterFrontID = @CenterFrontID AND MaterialExpDate < @MaterialExpDate";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                string text1 = this.DateTimePicker.Value.Date.AddDays(Conversion.Val(this.TxTInputDate.Text)).ToString("yyyy/MM/dd 00:00");
                adapter.SelectCommand.Parameters.AddWithValue("MaterialExpDate", text1 ?? DBNull.Value);
                adapter.Fill(dataTable);
                this.A.Close();
                this.GVE.DataSource = dataTable;
                this.GVE.Refresh();
                this.GVE.Columns["MaterialID"].Visible = false;
                this.GVE.Columns["CenterFrontID"].Visible = false;
                this.GVE.Columns["GroupIDFrontID"].Visible = false;
                this.GVE.Columns["MaterialBarCode"].HeaderText = "رقم/ باركود";
                this.GVE.Columns["MaterialName"].HeaderText = "المادة";
                if (PR.ZP)
                {
                    this.GVE.Columns["MaterialQuantity"].HeaderText = "الكمية";
                }
                else
                {
                    this.GVE.Columns["MaterialQuantity"].Visible = false;
                }
                this.GVE.Columns["MaterialUnit"].HeaderText = "الوحدة";
                this.GVE.Columns["MaterialPricCost"].Visible = false;
                this.GVE.Columns["MaterialPricLess"].Visible = false;
                this.GVE.Columns["MaterialPricSale"].HeaderText = "سعر البيع";
                this.GVE.Columns["MaterialIsStop"].Visible = false;
                this.GVE.Columns["MaterialExpDate"].HeaderText = "تاريخ الانتهاء";
                this.GVE.Columns["MaterialNote"].HeaderText = "ملاحظات";
                this.GVE.Columns["MaterialNotIsView"].Visible = false;
                this.GVE.Columns["MaterialQuantityLess"].Visible = false;
                this.GVE.Columns["MaterialQuantityPakeg"].Visible = false;
                this.GVE.Columns["MaterialQuantityOffer"].Visible = false;
                this.GVE.Columns["MaterialDisMiWi"].Visible = false;
                this.GVE.Columns["MaterialDarMiWi"].Visible = false;
                this.GVE.Columns["MaterialOtherBarCode"].Visible = false;
                this.GVE.Columns["MaterialMultBarCode"].Visible = false;
                this.GVE.Columns["MaterialBarcodeBlock"].Visible = false;
                this.GVE.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = this.GVE.RowCount;
                this.ToolStripProgressBar1.Minimum = 0;
                try
                {
                    enumerator = ((IEnumerable) this.GVE.Rows).GetEnumerator();
                    while (true)
                    {
                        if (!enumerator.MoveNext())
                        {
                            break;
                        }
                        DataGridViewRow current = (DataGridViewRow) enumerator.Current;
                        this.ToolStripProgressBar1.Value = current.Index;
                        decimal num = new decimal(Conversion.Val(current.Cells["MaterialQuantity"].Value.ToString()));
                        decimal num2 = new decimal(Conversion.Val(current.Cells["MaterialPricSale"].Value.ToString()));
                        current.Cells["MaterialQuantity"].Value = num.ToString(PR.BR);
                        current.Cells["MaterialPricSale"].Value = num2.ToString(PR.YR);
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
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable table2 = new DataTable();
                string str2 = "SELECT TaNNMaterial.MaterialID, TaNNMaterial.CenterFrontID, TaNNMaterial.GroupIDFrontID, TaNNMaterial.MaterialBarCode, TaNNMaterial.MaterialName, TaNNMaterial.MaterialQuantity, TaNNMaterial.MaterialUnit, TaNNMaterial.MaterialPricCost, TaNNMaterial.MaterialPricLess, TaNNMaterial.MaterialPricSale, TaNNMaterial.MaterialIsStop, TaNNMaterial.MaterialExpDate, TaNNMaterial.MaterialNote, TaNNMaterial.MaterialNotIsView, TaNNMaterial.MaterialQuantityLess, TaNNMaterial.MaterialQuantityPakeg, TaNNMaterial.MaterialQuantityOffer, TaNNMaterial.MaterialDisMiWi, TaNNMaterial.MaterialDarMiWi, TaNNMaterial.MaterialOtherBarCode, TaNNMaterial.MaterialMultBarCode, TaNNMaterial.MaterialBarcodeBlock FROM TaNNMaterial INNER JOIN TaNNMaterial AS TaNNMaterial_1 ON TaNNMaterial.MaterialID = TaNNMaterial_1.MaterialID AND convert (DECIMAL(18, 3), TaNNMaterial.MaterialQuantity) <= convert (DECIMAL(18, 3), TaNNMaterial_1.MaterialQuantityLess) WHERE (TaNNMaterial.CenterFrontID = @CenterFrontID)";
                table2.Clear();
                SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                adapter2.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter2.Fill(table2);
                this.A.Close();
                this.GVQ.DataSource = table2;
                this.GVQ.Refresh();
                this.GVQ.Columns["MaterialID"].Visible = false;
                this.GVQ.Columns["CenterFrontID"].Visible = false;
                this.GVQ.Columns["GroupIDFrontID"].Visible = false;
                this.GVQ.Columns["MaterialBarCode"].HeaderText = "رقم/ باركود";
                this.GVQ.Columns["MaterialName"].HeaderText = "المادة";
                if (PR.ZP)
                {
                    this.GVQ.Columns["MaterialQuantity"].HeaderText = "الكمية الحالية";
                }
                else
                {
                    this.GVQ.Columns["MaterialQuantity"].Visible = false;
                }
                this.GVQ.Columns["MaterialUnit"].HeaderText = "الوحدة";
                this.GVQ.Columns["MaterialPricCost"].Visible = false;
                this.GVQ.Columns["MaterialPricLess"].Visible = false;
                this.GVQ.Columns["MaterialPricSale"].HeaderText = "سعر البيع";
                this.GVQ.Columns["MaterialIsStop"].Visible = false;
                this.GVQ.Columns["MaterialExpDate"].HeaderText = "تاريخ الانتهاء";
                this.GVQ.Columns["MaterialNote"].HeaderText = "ملاحظات";
                this.GVQ.Columns["MaterialNotIsView"].Visible = false;
                this.GVQ.Columns["MaterialQuantityLess"].HeaderText = "الحد الآدنى للكمية";
                this.GVQ.Columns["MaterialQuantityPakeg"].Visible = false;
                this.GVQ.Columns["MaterialQuantityOffer"].Visible = false;
                this.GVQ.Columns["MaterialDisMiWi"].Visible = false;
                this.GVQ.Columns["MaterialDarMiWi"].Visible = false;
                this.GVQ.Columns["MaterialOtherBarCode"].Visible = false;
                this.GVQ.Columns["MaterialMultBarCode"].Visible = false;
                this.GVQ.Columns["MaterialBarcodeBlock"].Visible = false;
                this.GVQ.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.ToolStripProgressBar1.Visible = true;
                this.ToolStripProgressBar1.Maximum = this.GVQ.RowCount;
                this.ToolStripProgressBar1.Minimum = 0;
                try
                {
                    enumerator2 = ((IEnumerable) this.GVQ.Rows).GetEnumerator();
                    while (true)
                    {
                        if (!enumerator2.MoveNext())
                        {
                            break;
                        }
                        DataGridViewRow current = (DataGridViewRow) enumerator2.Current;
                        this.ToolStripProgressBar1.Value = current.Index;
                        decimal num3 = new decimal(Conversion.Val(current.Cells["MaterialQuantity"].Value.ToString()));
                        decimal num4 = new decimal(Conversion.Val(current.Cells["MaterialQuantityLess"].Value.ToString()));
                        decimal num5 = new decimal(Conversion.Val(current.Cells["MaterialPricSale"].Value.ToString()));
                        current.Cells["MaterialQuantity"].Value = num3.ToString(PR.BR);
                        current.Cells["MaterialQuantityLess"].Value = num4.ToString(PR.BR);
                        current.Cells["MaterialPricSale"].Value = num5.ToString(PR.YR);
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
                if (!((this.GVE.RowCount > 0) | ((this.GVQ.RowCount > 0) & !this.A)))
                {
                    base.Dispose();
                }
                else if (this.A)
                {
                    this.TabControl1.SelectedIndex = 0;
                }
                else
                {
                    if (this.GVE.RowCount > 0)
                    {
                        this.TabControl1.SelectedIndex = 0;
                        base.WindowState = FormWindowState.Normal;
                    }
                    if (this.GVQ.RowCount > 0)
                    {
                        this.TabControl1.SelectedIndex = 1;
                        base.WindowState = FormWindowState.Normal;
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

        private void R(object A, EventArgs R)
        {
            AR.QR = this.AlarmShowSale.Checked;
            AR.F = (int) Math.Round(Conversion.Val(this.TxTInputDate.Text));
            base.Dispose();
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

        internal virtual TabPage TabPage2
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

        internal virtual ToolStripButton ToolStripButtonClose
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox AlarmShowSale
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTInputDate
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

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual System.Windows.Forms.DateTimePicker DateTimePicker
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DataGridView GVE
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DataGridView GVQ
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
    }
}

