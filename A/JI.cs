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
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class JI : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxAllCenter")]
        private CheckBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1"), CompilerGenerated]
        private TabControl A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage1")]
        private TabPage A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox5")]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("TxTSerach"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("GroupBox4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ComboBoxSerachWat")]
        private ComboBox A;
        [CompilerGenerated, AccessedThroughProperty("ButtonSearchCodeName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("ToolStripButtons"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripButtonOK"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripButtonClose")]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator7")]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripStatus"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripProgressBar A;
        [AccessedThroughProperty("ToolStripLabel1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripLabel A;
        [AccessedThroughProperty("TxTGVRowCount"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator P;
        [AccessedThroughProperty("TimerFillGV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerLoadData"), CompilerGenerated]
        private Timer R;
        [AccessedThroughProperty("TimersStartUp"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer P;
        [AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripButtonCard")]
        private ToolStripDropDownButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButCusDetials"), CompilerGenerated]
        private ToolStripMenuItem A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator15"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButCusStatment")]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("ToolStripSeparator2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator I;
        private SqlConnection A;
        private DataTable A;
        private string A;
        public static bool A = false;
        public static bool R = false;

        public JI()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(JI));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.CheckBoxAllCenter = new CheckBox();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.GroupBox5 = new GroupBox();
            this.TxTSerach = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.ComboBoxSerachWat = new ComboBox();
            this.ButtonSearchCodeName = new Button();
            this.TxTTitle = new Label();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonOK = new ToolStripButton();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ToolStripButtonCard = new ToolStripDropDownButton();
            this.ButCusDetials = new ToolStripMenuItem();
            this.ToolStripSeparator15 = new ToolStripSeparator();
            this.ButCusStatment = new ToolStripMenuItem();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowCount = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.TimerFillGV = new Timer(this.A);
            this.TimerLoadData = new Timer(this.A);
            this.TimersStartUp = new Timer(this.A);
            this.GV = new DataGridView();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.CheckBoxAllCenter.AutoSize = true;
            this.CheckBoxAllCenter.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.CheckBoxAllCenter.Checked = true;
            this.CheckBoxAllCenter.CheckState = CheckState.Checked;
            this.CheckBoxAllCenter.Dock = DockStyle.Top;
            this.CheckBoxAllCenter.Location = new Point(0, 0x91);
            this.CheckBoxAllCenter.Name = "CheckBoxAllCenter";
            this.CheckBoxAllCenter.Padding = new Padding(5);
            this.CheckBoxAllCenter.Size = new Size(0x3d8, 30);
            this.CheckBoxAllCenter.TabIndex = 0x6f;
            this.CheckBoxAllCenter.Text = "عرض العملاء من كل الفروع";
            this.CheckBoxAllCenter.UseVisualStyleBackColor = false;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3d8, 0x6f);
            this.TabControl1.TabIndex = 110;
            this.TabPage1.Controls.Add(this.GroupBox5);
            this.TabPage1.Controls.Add(this.GroupBox4);
            this.TabPage1.Controls.Add(this.ButtonSearchCodeName);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3d0, 0x52);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "بحث";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox5.Controls.Add(this.TxTSerach);
            this.GroupBox5.Location = new Point(0x13e, 13);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x120, 0x35);
            this.GroupBox5.TabIndex = 0x6b;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "نص البحث";
            this.TxTSerach.Dock = DockStyle.Fill;
            this.TxTSerach.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTSerach.Location = new Point(3, 0x13);
            this.TxTSerach.Name = "TxTSerach";
            this.TxTSerach.Size = new Size(0x11a, 0x17);
            this.TxTSerach.TabIndex = 15;
            this.GroupBox4.Controls.Add(this.ComboBoxSerachWat);
            this.GroupBox4.Location = new Point(0x296, 13);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x12e, 0x35);
            this.GroupBox4.TabIndex = 0x6b;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "البحث في";
            this.ComboBoxSerachWat.Dock = DockStyle.Fill;
            this.ComboBoxSerachWat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxSerachWat.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ComboBoxSerachWat.FormattingEnabled = true;
            object[] items = new object[] { "اسم العميل", "عنوان العميل", "رقم الهاتف", "ملاحظات" };
            this.ComboBoxSerachWat.Items.AddRange(items);
            this.ComboBoxSerachWat.Location = new Point(3, 0x13);
            this.ComboBoxSerachWat.Name = "ComboBoxSerachWat";
            this.ComboBoxSerachWat.Size = new Size(0x128, 0x18);
            this.ComboBoxSerachWat.TabIndex = 0x10;
            this.ButtonSearchCodeName.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSearchCodeName.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSearchCodeName.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSearchCodeName.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSearchCodeName.FlatStyle = FlatStyle.Flat;
            this.ButtonSearchCodeName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSearchCodeName.Image = A.F.ImSearch;
            this.ButtonSearchCodeName.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSearchCodeName.Location = new Point(0x9c, 0x15);
            this.ButtonSearchCodeName.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSearchCodeName.Name = "ButtonSearchCodeName";
            this.ButtonSearchCodeName.Size = new Size(0x8f, 0x2c);
            this.ButtonSearchCodeName.TabIndex = 14;
            this.ButtonSearchCodeName.Text = "بحث";
            this.ButtonSearchCodeName.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3d8, 0x22);
            this.TxTTitle.TabIndex = 0x6d;
            this.TxTTitle.Text = "استعلام عن عميل";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonOK, this.ToolStripSeparator5, this.ToolStripButtonCard, this.ToolStripSeparator2, this.ToolStripButtonClose, this.ToolStripSeparator7 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x1e2);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(0x3d8, 0x2f);
            this.ToolStripButtons.TabIndex = 0x72;
            this.ToolStripButtonOK.Image = A.F.ImOK;
            this.ToolStripButtonOK.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonOK.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonOK.Name = "ToolStripButtonOK";
            this.ToolStripButtonOK.Size = new Size(0x4d, 0x2c);
            this.ToolStripButtonOK.Text = "موافق";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(6, 0x2f);
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.ButCusDetials, this.ToolStripSeparator15, this.ButCusStatment };
            this.ToolStripButtonCard.DropDownItems.AddRange(itemArray2);
            this.ToolStripButtonCard.Image = A.F.ImCustomerCard;
            this.ToolStripButtonCard.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonCard.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonCard.Name = "ToolStripButtonCard";
            this.ToolStripButtonCard.Size = new Size(0x72, 0x2c);
            this.ToolStripButtonCard.Text = "كرت العميل";
            this.ButCusDetials.Image = (Image) manager.GetObject("ButCusDetials.Image");
            this.ButCusDetials.ImageScaling = ToolStripItemImageScaling.None;
            this.ButCusDetials.Name = "ButCusDetials";
            this.ButCusDetials.Size = new Size(0xcd, 0x26);
            this.ButCusDetials.Text = "تفاصيل العميل";
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            this.ToolStripSeparator15.Size = new Size(0xca, 6);
            this.ButCusStatment.Image = (Image) manager.GetObject("ButCusStatment.Image");
            this.ButCusStatment.ImageScaling = ToolStripItemImageScaling.None;
            this.ButCusStatment.Name = "ButCusStatment";
            this.ButCusStatment.Size = new Size(0xcd, 0x26);
            this.ButCusStatment.Text = "كشف حساب العميل";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
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
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1 };
            this.ToolStripStatus.Items.AddRange(itemArray3);
            this.ToolStripStatus.Location = new Point(0, 0x211);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x3d8, 0x19);
            this.ToolStripStatus.TabIndex = 0x71;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x44, 0x16);
            this.ToolStripLabel1.Text = "عدد العملاء";
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
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.BackColor = SystemColors.Window;
            style.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            style.ForeColor = SystemColors.ControlText;
            style.SelectionBackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            style.SelectionForeColor = Color.Black;
            style.WrapMode = DataGridViewTriState.False;
            this.GV.DefaultCellStyle = style;
            this.GV.Dock = DockStyle.Fill;
            this.GV.Location = new Point(0, 0xaf);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3d8, 0x133);
            this.GV.TabIndex = 0x1ed36ce;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3d8, 0x22a);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.CheckBoxAllCenter);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MinimizeBox = false;
            base.Name = "CustomerQuery";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "استعلام عن عميل";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.A = !this.CheckBoxAllCenter.Checked ? "SELECT * FROM TaNNCustomers WHERE (CenterFrontID = @CenterFrontID)" : "SELECT * FROM TaNNCustomers";
            this.ComboBoxSerachWat.SelectedIndex = 0;
            this.TimersStartUp.Enabled = true;
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonSearchCodeName.PerformClick();
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

        private void F(object A, EventArgs R)
        {
            this.TimerFillGV.Enabled = false;
            this.R();
        }

        private void H(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    if (JI.A)
                    {
                        A.D.A.A.H();
                        BI.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString());
                        A.D.A.A.ShowDialog();
                    }
                    else
                    {
                        if (Application.OpenForms.OfType<IH>().Any<IH>())
                        {
                            A.D.A.A.P();
                            A.D.A.A.ComboBoxCustomer.SelectedValue = this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString();
                            base.Dispose();
                        }
                        if (Application.OpenForms.OfType<QH>().Any<QH>())
                        {
                            A.D.A.A.B();
                            A.D.A.A.ComboBoxCustomer.SelectedValue = this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString();
                            base.Dispose();
                        }
                        if (Application.OpenForms.OfType<OD>().Any<OD>())
                        {
                            A.D.A.A.ComboBoxCustomer.SelectedValue = this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString();
                            base.Dispose();
                        }
                        if (Application.OpenForms.OfType<VD>().Any<VD>())
                        {
                            A.D.A.A.ComboBoxCustomer.SelectedValue = this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString();
                            base.Dispose();
                        }
                    }
                    JI.R = false;
                    JI.A = false;
                    base.Dispose();
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

        private void I(object A, EventArgs R)
        {
            if (this.ComboBoxSerachWat.Text == null)
            {
                Interaction.MsgBox(PR.G.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else if (this.TxTSerach.Text == null)
            {
                Interaction.MsgBox(PR.E.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 0)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CustomerName LIKE '%' + @CustomerName + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CenterFrontID = @CenterFrontID) AND (CustomerName LIKE '%' + @CustomerName + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 1)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CustomerAddress LIKE '%' + @CustomerAddress + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CenterFrontID = @CenterFrontID) AND (CustomerAddress LIKE '%' + @CustomerAddress + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 2)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CustomerPhone LIKE '%' + @CustomerPhone + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CenterFrontID = @CenterFrontID) AND (CustomerPhone LIKE '%' + @CustomerPhone + '%')";
                    this.TimerLoadData.Enabled = true;
                }
            }
            else if (this.ComboBoxSerachWat.SelectedIndex == 3)
            {
                if (this.CheckBoxAllCenter.Checked)
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CustomerNote LIKE '%' + @CustomerNote + '%')";
                    this.TimerLoadData.Enabled = true;
                }
                else
                {
                    this.A = "SELECT * FROM [TaNNCustomers] WHERE (CenterFrontID = @CenterFrontID) AND (CustomerNote LIKE '%' + @CustomerNote + '%')";
                    this.TimerLoadData.Enabled = true;
                }
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

        private void Q(object A, EventArgs R)
        {
            JI.R = false;
            JI.A = false;
            base.Dispose();
        }

        public void R()
        {
            try
            {
                IEnumerator enumerator;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                this.A.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                string text = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("CustomerName", text ?? DBNull.Value);
                string text2 = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("CustomerAddress", text2 ?? DBNull.Value);
                string text3 = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("CustomerPhone", text3 ?? DBNull.Value);
                string text4 = this.TxTSerach.Text;
                adapter.SelectCommand.Parameters.AddWithValue("CustomerNote", text4 ?? DBNull.Value);
                adapter.Fill(this.A);
                this.A.Close();
                this.GV.DataSource = this.A;
                this.GV.Refresh();
                this.GV.Columns["CustomerID"].Visible = false;
                this.GV.Columns["CenterFrontID"].HeaderText = "رمز الفرع";
                this.GV.Columns["CustomerName"].HeaderText = "اسم العميل";
                this.GV.Columns["CustomerAddress"].HeaderText = "العنوان";
                this.GV.Columns["CustomerPhone"].HeaderText = "الهاتف";
                this.GV.Columns["CustomerNote"].HeaderText = "ملاحظات";
                this.GV.Columns["CustomerBalance"].HeaderText = "الرصيد";
                this.GV.Columns["CustomerDiscount"].HeaderText = "الخصم %";
                this.GV.Columns["CustomerPoints"].HeaderText = "النقاط الحالية";
                this.GV.Columns["CustomerPriceType"].Visible = false;
                this.GV.Columns["CustomerApplyIfPoints"].Visible = false;
                this.GV.Columns["CustomerDateConfigur"].HeaderText = "تاريخ اخر اجراء";
                this.GV.Columns["CustomerUserAddBy"].HeaderText = "الموظف";
                this.GV.Columns["CustomerGiftBarcode"].Visible = false;
                this.GV.Columns["CustomerGiftExpDate"].Visible = false;
                this.GV.Columns["CustomerGiftDisMiWi"].Visible = false;
                this.GV.Columns["CustomerGiftDisVal"].Visible = false;
                this.GV.Columns["CustomerGiftCount"].Visible = false;
                this.GV.Columns["CustomerGiftNote"].Visible = false;
                this.GV.Columns["CustomerEmail"].HeaderText = "بريد الاشعارات";
                this.GV.Columns["CuSchemeID"].Visible = false;
                this.GV.Columns["CuSchemeTy"].Visible = false;
                this.GV.Columns["CuStreetName"].Visible = false;
                this.GV.Columns["CuBuildingNumber"].Visible = false;
                this.GV.Columns["CuPlotIdentification"].Visible = false;
                this.GV.Columns["CuCitySubdivisionName"].Visible = false;
                this.GV.Columns["CuCityName"].Visible = false;
                this.GV.Columns["CuCountrySubentity"].Visible = false;
                this.GV.Columns["CuCompanyID"].Visible = false;
                this.GV.Columns["CuExpDat"].Visible = false;
                this.GV.Columns["CuPostCode"].Visible = false;
                this.GV.Columns["CuMorID"].Visible = false;
                this.GV.Columns["CusLimitDebit"].Visible = false;
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.ToolStripButtonOK.Enabled = this.GV.RowCount > 0;
                if (R)
                {
                    this.ToolStripButtonOK.Enabled = false;
                }
                this.TxTGVRowCount.Text = Conversions.ToString(this.GV.RowCount);
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
                        decimal num = new decimal(Conversion.Val(current.Cells["CustomerBalance"].Value.ToString()));
                        if (decimal.Compare(num, decimal.Zero) > 0)
                        {
                            current.Cells["CustomerBalance"].Style.ForeColor = Color.Blue;
                        }
                        else if (decimal.Compare(num, decimal.Zero) < 0)
                        {
                            current.Cells["CustomerBalance"].Style.ForeColor = Color.Red;
                        }
                        current.Cells["CustomerBalance"].Value = num.ToString(PR.YR);
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
            this.TimerLoadData.Enabled = true;
        }

        private void T(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    SI.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString());
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

        private void X(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    OI.A = Conversions.ToInteger(this.GV.SelectedRows[0].Cells["CustomerID"].Value.ToString());
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

        internal virtual CheckBox CheckBoxAllCenter
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

        internal virtual TextBox TxTSerach
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ComboBox ComboBoxSerachWat
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonSearchCodeName
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

        internal virtual ToolStripButton ToolStripButtonOK
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

        internal virtual ToolStripSeparator ToolStripSeparator5
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

        internal virtual Timer TimerFillGV
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

        internal virtual Timer TimerLoadData
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

        internal virtual Timer TimersStartUp
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual ToolStripDropDownButton ToolStripButtonCard
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem ButCusDetials
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
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

        internal virtual ToolStripSeparator ToolStripSeparator15
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripMenuItem ButCusStatment
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

