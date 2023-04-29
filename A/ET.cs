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
    public class ET : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox8")]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("DateTimePickerFrom")]
        private DateTimePicker A;
        [AccessedThroughProperty("PickerTimeFrom"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker R;
        [AccessedThroughProperty("GroupBox9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [AccessedThroughProperty("DateTimePickerTo"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DateTimePicker P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PickerTimeTo")]
        private DateTimePicker Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox37"), CompilerGenerated]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("LabPath")]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonBrows"), CompilerGenerated]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("FolderBrowserDialog")]
        private System.Windows.Forms.FolderBrowserDialog A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox42"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [AccessedThroughProperty("ToolStripStatus"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [AccessedThroughProperty("ToolStripProgressBar1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripProgressBar A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripLabel1")]
        private ToolStripLabel A;
        [AccessedThroughProperty("TxTGVRowCount"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerStartXML")]
        private Timer A;
        [CompilerGenerated, AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [AccessedThroughProperty("TimerStartPDF"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("RadioButtonPDF")]
        private RadioButton A;
        [AccessedThroughProperty("TimerStartKSA"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer P;
        [CompilerGenerated, AccessedThroughProperty("CheckBoxNoPendding"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonOk")]
        private Button R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose")]
        private Button P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("OpenFileDialog1")]
        private OpenFileDialog A;
        [CompilerGenerated, AccessedThroughProperty("TxTInvSaleTotalNET"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [CompilerGenerated, AccessedThroughProperty("GVS"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        private SqlConnection A;
        private DataTable A;
        private string A;

        public ET()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.TxTTitle = new Label();
            this.GroupBox8 = new GroupBox();
            this.DateTimePickerFrom = new DateTimePicker();
            this.PickerTimeFrom = new DateTimePicker();
            this.GroupBox9 = new GroupBox();
            this.DateTimePickerTo = new DateTimePicker();
            this.PickerTimeTo = new DateTimePicker();
            this.GroupBox37 = new GroupBox();
            this.LabPath = new Label();
            this.ButtonBrows = new Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.GroupBox42 = new GroupBox();
            this.CheckBoxNoPendding = new CheckBox();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowCount = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.TimerStartXML = new Timer(this.A);
            this.Label1 = new Label();
            this.TimerStartPDF = new Timer(this.A);
            this.RadioButtonPDF = new RadioButton();
            this.TimerStartKSA = new Timer(this.A);
            this.ButtonOk = new Button();
            this.ButtonClose = new Button();
            this.OpenFileDialog1 = new OpenFileDialog();
            this.TxTInvSaleTotalNET = new TextBox();
            this.GVS = new DataGridView();
            this.GroupBox8.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox37.SuspendLayout();
            this.GroupBox42.SuspendLayout();
            this.ToolStripStatus.SuspendLayout();
            ((ISupportInitialize) this.GVS).BeginInit();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x219, 0x21);
            this.TxTTitle.TabIndex = 0x55;
            this.TxTTitle.Text = "تصدير الفواتير الى صيغة ملفات PDF / XLM-UBL";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox8.Controls.Add(this.DateTimePickerFrom);
            this.GroupBox8.Controls.Add(this.PickerTimeFrom);
            this.GroupBox8.Dock = DockStyle.Right;
            this.GroupBox8.Location = new Point(0xd8, 0x13);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(180, 0x4b);
            this.GroupBox8.TabIndex = 0x1ed36cf;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "من تاريخ";
            this.DateTimePickerFrom.CustomFormat = "";
            this.DateTimePickerFrom.Dock = DockStyle.Fill;
            this.DateTimePickerFrom.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePickerFrom.Format = DateTimePickerFormat.Short;
            this.DateTimePickerFrom.Location = new Point(3, 0x13);
            this.DateTimePickerFrom.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.RightToLeft = RightToLeft.No;
            this.DateTimePickerFrom.Size = new Size(0xae, 0x17);
            this.DateTimePickerFrom.TabIndex = 0x40;
            this.PickerTimeFrom.CustomFormat = "hh:mm tt";
            this.PickerTimeFrom.Dock = DockStyle.Bottom;
            this.PickerTimeFrom.Format = DateTimePickerFormat.Custom;
            this.PickerTimeFrom.Location = new Point(3, 0x31);
            this.PickerTimeFrom.Name = "PickerTimeFrom";
            this.PickerTimeFrom.ShowUpDown = true;
            this.PickerTimeFrom.Size = new Size(0xae, 0x17);
            this.PickerTimeFrom.TabIndex = 0x1ed36d3;
            this.GroupBox9.Controls.Add(this.DateTimePickerTo);
            this.GroupBox9.Controls.Add(this.PickerTimeTo);
            this.GroupBox9.Dock = DockStyle.Left;
            this.GroupBox9.Location = new Point(3, 0x13);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0xbd, 0x4b);
            this.GroupBox9.TabIndex = 0x1ed36d0;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "الى تاريخ";
            this.DateTimePickerTo.CustomFormat = "";
            this.DateTimePickerTo.Dock = DockStyle.Fill;
            this.DateTimePickerTo.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.DateTimePickerTo.Format = DateTimePickerFormat.Short;
            this.DateTimePickerTo.Location = new Point(3, 0x13);
            this.DateTimePickerTo.Margin = new Padding(3, 4, 3, 4);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.RightToLeft = RightToLeft.No;
            this.DateTimePickerTo.Size = new Size(0xb7, 0x17);
            this.DateTimePickerTo.TabIndex = 70;
            this.PickerTimeTo.CustomFormat = "hh:mm tt";
            this.PickerTimeTo.Dock = DockStyle.Bottom;
            this.PickerTimeTo.Format = DateTimePickerFormat.Custom;
            this.PickerTimeTo.Location = new Point(3, 0x31);
            this.PickerTimeTo.Name = "PickerTimeTo";
            this.PickerTimeTo.ShowUpDown = true;
            this.PickerTimeTo.Size = new Size(0xb7, 0x17);
            this.PickerTimeTo.TabIndex = 0x1ed36d4;
            this.GroupBox37.Controls.Add(this.LabPath);
            this.GroupBox37.Controls.Add(this.ButtonBrows);
            this.GroupBox37.Location = new Point(12, 0x58);
            this.GroupBox37.Name = "GroupBox37";
            this.GroupBox37.Size = new Size(0x1fd, 0x67);
            this.GroupBox37.TabIndex = 0x22;
            this.GroupBox37.TabStop = false;
            this.GroupBox37.Text = "حدد مكان الحفظ";
            this.LabPath.Dock = DockStyle.Bottom;
            this.LabPath.Location = new Point(3, 0x42);
            this.LabPath.Name = "LabPath";
            this.LabPath.Size = new Size(0x1f7, 0x22);
            this.LabPath.TabIndex = 0x5b;
            this.LabPath.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonBrows.Dock = DockStyle.Top;
            this.ButtonBrows.FlatAppearance.BorderColor = Color.Green;
            this.ButtonBrows.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonBrows.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonBrows.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonBrows.FlatStyle = FlatStyle.Flat;
            this.ButtonBrows.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonBrows.Image = F.ImView;
            this.ButtonBrows.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonBrows.Location = new Point(3, 0x13);
            this.ButtonBrows.Margin = new Padding(3, 4, 3, 4);
            this.ButtonBrows.Name = "ButtonBrows";
            this.ButtonBrows.RightToLeft = RightToLeft.Yes;
            this.ButtonBrows.Size = new Size(0x1f7, 0x2b);
            this.ButtonBrows.TabIndex = 90;
            this.ButtonBrows.Text = "تحديد مكان الحفظ";
            this.ButtonBrows.UseVisualStyleBackColor = true;
            this.GroupBox42.Controls.Add(this.GroupBox8);
            this.GroupBox42.Controls.Add(this.GroupBox9);
            this.GroupBox42.Location = new Point(12, 0xc5);
            this.GroupBox42.Name = "GroupBox42";
            this.GroupBox42.Size = new Size(0x18f, 0x61);
            this.GroupBox42.TabIndex = 0x1ed36da;
            this.GroupBox42.TabStop = false;
            this.GroupBox42.Text = "تصدير الفواتير ضمن الفترة الزمنية";
            this.CheckBoxNoPendding.AutoSize = true;
            this.CheckBoxNoPendding.Checked = true;
            this.CheckBoxNoPendding.CheckState = CheckState.Checked;
            this.CheckBoxNoPendding.Enabled = false;
            this.CheckBoxNoPendding.Location = new Point(12, 0x13d);
            this.CheckBoxNoPendding.Name = "CheckBoxNoPendding";
            this.CheckBoxNoPendding.Size = new Size(0x98, 20);
            this.CheckBoxNoPendding.TabIndex = 0x1ed36e7;
            this.CheckBoxNoPendding.Text = "استثناء الفواتير المعلقة";
            this.CheckBoxNoPendding.UseVisualStyleBackColor = true;
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripLabel1, this.TxTGVRowCount, this.ToolStripSeparator1, this.ToolStripProgressBar1 };
            this.ToolStripStatus.Items.AddRange(toolStripItems);
            this.ToolStripStatus.Location = new Point(0, 0x1c5);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x219, 0x19);
            this.ToolStripStatus.TabIndex = 0x1ed36db;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0x6f, 0x16);
            this.ToolStripLabel1.Text = "عدد الفواتير الكلي:";
            this.TxTGVRowCount.ForeColor = Color.DarkGreen;
            this.TxTGVRowCount.Name = "TxTGVRowCount";
            this.TxTGVRowCount.RightToLeft = RightToLeft.No;
            this.TxTGVRowCount.Size = new Size(0x16, 0x16);
            this.TxTGVRowCount.Text = "00";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x16);
            this.ToolStripProgressBar1.Visible = false;
            this.TimerStartXML.Interval = 500;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Red;
            this.Label1.Location = new Point(0, 0x21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x219, 0x21);
            this.Label1.TabIndex = 0x1ed36e1;
            this.Label1.Text = "نموذج تجريبي غير مكتمل - قيد التجهيز والتطوير";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.TimerStartPDF.Interval = 500;
            this.RadioButtonPDF.AutoSize = true;
            this.RadioButtonPDF.Checked = true;
            this.RadioButtonPDF.Location = new Point(0x1b4, 0xee);
            this.RadioButtonPDF.Name = "RadioButtonPDF";
            this.RadioButtonPDF.Size = new Size(0x52, 20);
            this.RadioButtonPDF.TabIndex = 0x1ed36e4;
            this.RadioButtonPDF.TabStop = true;
            this.RadioButtonPDF.Text = "تصدير PDF";
            this.RadioButtonPDF.UseVisualStyleBackColor = true;
            this.TimerStartKSA.Interval = 500;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(12, 0x161);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x202, 0x2d);
            this.ButtonOk.TabIndex = 0x1ed36ea;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0, 0x198);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x219, 0x2d);
            this.ButtonClose.TabIndex = 0x1ed36e9;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.TxTInvSaleTotalNET.BackColor = SystemColors.Info;
            this.TxTInvSaleTotalNET.Dock = DockStyle.Fill;
            this.TxTInvSaleTotalNET.Location = new Point(3, 0x13);
            this.TxTInvSaleTotalNET.Name = "TxTInvSaleTotalNET";
            this.TxTInvSaleTotalNET.Size = new Size(0x111, 20);
            this.TxTInvSaleTotalNET.TabIndex = 0;
            this.GVS.AllowUserToAddRows = false;
            this.GVS.AllowUserToDeleteRows = false;
            this.GVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVS.Location = new Point(0x3f6, 0x27d);
            this.GVS.Name = "GVS";
            this.GVS.ReadOnly = true;
            this.GVS.Size = new Size(240, 150);
            this.GVS.TabIndex = 0x1ed36eb;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x219, 0x1de);
            base.ControlBox = false;
            base.Controls.Add(this.GVS);
            base.Controls.Add(this.RadioButtonPDF);
            base.Controls.Add(this.CheckBoxNoPendding);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.GroupBox37);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.GroupBox42);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "XMLExport";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تصدير الفواتير الى صيغة ملفات PDF / XLM-UBL";
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox37.ResumeLayout(false);
            this.GroupBox42.ResumeLayout(false);
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            ((ISupportInitialize) this.GVS).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
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

        private void I(object A, EventArgs R)
        {
            if ((this.LabPath.Text == null) | (this.LabPath.Text == ""))
            {
                Interaction.MsgBox("حدد مجلد حفظ الملفات", MsgBoxStyle.ApplicationModal, null);
                this.FolderBrowserDialog.ShowDialog();
                string directory = this.FolderBrowserDialog.SelectedPath + @"\";
                this.LabPath.Text = directory;
                try
                {
                    A.D.A.FileSystem.CreateDirectory(directory);
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
            }
            else
            {
                this.TxTTitle.Text = PR.A.ToString();
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                DateTime time = Conversions.ToDate(this.DateTimePickerFrom.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeFrom.Value.ToString("HH:mm"));
                DateTime time2 = Conversions.ToDate(this.DateTimePickerTo.Value.ToString("yyyy/MM/dd") + " " + this.PickerTimeTo.Value.ToString("HH:mm"));
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                this.A = !this.CheckBoxNoPendding.Checked ? "SELECT TaNNInvSale.*, TaNNCustomers.* FROM TaNNInvSale LEFT OUTER JOIN TaNNCustomers ON TaNNInvSale.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSale.CenterFrontID = @CenterFrontID) AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT) ORDER BY [InvSaleID] ASC" : "SELECT TaNNInvSale.*, TaNNCustomers.* FROM TaNNInvSale LEFT OUTER JOIN TaNNCustomers ON TaNNInvSale.CustomerFrontID = TaNNCustomers.CustomerID WHERE (TaNNInvSale.CenterFrontID = @CenterFrontID) AND (TaNNInvSale.InvSaleDateTime BETWEEN @DF and @DT) AND ((TaNNInvSale.InvSaleStatus = @InvSaleStatus1) OR (TaNNInvSale.InvSaleStatus = @InvSaleStatus2)) ORDER BY [InvSaleID] ASC";
                this.A.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                string text1 = time.ToString("yyyy/MM/dd HH:mm");
                adapter.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
                string text2 = time2.ToString("yyyy/MM/dd HH:mm");
                adapter.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleStatus1", "0" ?? DBNull.Value);
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleStatus2", "3" ?? DBNull.Value);
                adapter.Fill(this.A);
                this.A.Close();
                this.TxTGVRowCount.Text = Conversions.ToString(this.A.Rows.Count);
                this.GVS.DataSource = this.A;
                this.GVS.Refresh();
                this.ToolStripProgressBar1.Value = 0;
                this.ToolStripProgressBar1.Maximum = this.A.Rows.Count;
                this.ToolStripProgressBar1.Visible = true;
                this.TimerStartPDF.Enabled = true;
            }
        }

        private void P(object A, EventArgs R)
        {
            this.TimerStartXML.Enabled = false;
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerStartPDF.Enabled = false;
            this.R();
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            this.FolderBrowserDialog.ShowDialog();
            string directory = this.FolderBrowserDialog.SelectedPath + @"\";
            this.LabPath.Text = directory;
            try
            {
                A.D.A.FileSystem.CreateDirectory(directory);
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
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

        internal virtual GroupBox GroupBox8
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

        internal virtual GroupBox GroupBox9
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

        internal virtual GroupBox GroupBox37
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label LabPath
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonBrows
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox42
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Timer TimerStartXML
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Timer TimerStartPDF
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual RadioButton RadioButtonPDF
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Timer TimerStartKSA
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual CheckBox CheckBoxNoPendding
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonOk
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

        internal virtual Button ButtonClose
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

        internal virtual OpenFileDialog OpenFileDialog1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTInvSaleTotalNET
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DataGridView GVS
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

