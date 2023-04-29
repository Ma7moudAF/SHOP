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
    public class IR : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("LabelErrSingle")]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LabelErrMulti")]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStrip")]
        private System.Windows.Forms.ToolStrip A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripLabel1"), CompilerGenerated]
        private ToolStripLabel A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTGVRowsCount")]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated]
        private ToolStripSeparator A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripLabel2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TXTCounTS")]
        private ToolStripLabel Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator2")]
        private ToolStripSeparator R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonStop")]
        private ToolStripButton A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonRun"), CompilerGenerated]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator4"), CompilerGenerated]
        private ToolStripSeparator Q;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonPrints"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton P;
        [AccessedThroughProperty("TimerStart"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        private SqlConnection A;
        private string A;
        private string R;
        private string P;

        public IR()
        {
            base.Load += new EventHandler(this.A);
            base.FormClosed += new FormClosedEventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.LabelErrSingle = new Label();
            this.LabelErrMulti = new Label();
            this.GV = new DataGridView();
            this.Label1 = new Label();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.TxTGVRowsCount = new ToolStripLabel();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.ToolStripLabel2 = new ToolStripLabel();
            this.TXTCounTS = new ToolStripLabel();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripButtonStop = new ToolStripButton();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ToolStripButtonRun = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ToolStripButtonPrints = new ToolStripButton();
            this.TimerStart = new Timer(this.A);
            ((ISupportInitialize) this.GV).BeginInit();
            this.ToolStrip.SuspendLayout();
            base.SuspendLayout();
            this.LabelErrSingle.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.LabelErrSingle.Dock = DockStyle.Top;
            this.LabelErrSingle.ForeColor = Color.Red;
            this.LabelErrSingle.Location = new Point(0, 0x180);
            this.LabelErrSingle.Name = "LabelErrSingle";
            this.LabelErrSingle.Size = new Size(0x3a5, 0x21);
            this.LabelErrSingle.TabIndex = 0x72;
            this.LabelErrSingle.Text = "خطأ في طباعة، لعدم تحديد الطابعة الافتراضية ، انقر لضبط اعدادات الطابعة.";
            this.LabelErrSingle.TextAlign = ContentAlignment.MiddleLeft;
            this.LabelErrSingle.Visible = false;
            this.LabelErrMulti.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.LabelErrMulti.Dock = DockStyle.Top;
            this.LabelErrMulti.ForeColor = Color.Red;
            this.LabelErrMulti.Location = new Point(0, 0x15f);
            this.LabelErrMulti.Name = "LabelErrMulti";
            this.LabelErrMulti.Size = new Size(0x3a5, 0x21);
            this.LabelErrMulti.TabIndex = 0x71;
            this.LabelErrMulti.Text = "خطأ في طباعة حسب المجموعات والطابعات، لعدم وجود ملف تعريف مجموعة المواد مع الطابعة. انقر لضبط اعدادات الطابعة.";
            this.LabelErrMulti.TextAlign = ContentAlignment.MiddleLeft;
            this.LabelErrMulti.Visible = false;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Dock = DockStyle.Top;
            this.GV.Location = new Point(0, 0x41);
            this.GV.Margin = new Padding(3, 5, 3, 5);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x3a5, 0x11e);
            this.GV.TabIndex = 0x6f;
            this.Label1.BackColor = Color.WhiteSmoke;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.ForeColor = Color.DarkGreen;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x3a5, 0x41);
            this.Label1.TabIndex = 0x70;
            this.Label1.Text = "هنا سيتم استقبال اي امر طباعة من نسخة الويب، حيث سيتم مزامنة الأوامر كل 5 ثواني.";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStrip.BackColor = Color.WhiteSmoke;
            this.ToolStrip.Dock = DockStyle.Bottom;
            this.ToolStrip.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStrip.ImageScalingSize = new Size(20, 20);
            ToolStripItem[] toolStripItems = new ToolStripItem[11];
            toolStripItems[0] = this.ToolStripLabel1;
            toolStripItems[1] = this.TxTGVRowsCount;
            toolStripItems[2] = this.ToolStripSeparator1;
            toolStripItems[3] = this.ToolStripLabel2;
            toolStripItems[4] = this.TXTCounTS;
            toolStripItems[5] = this.ToolStripSeparator2;
            toolStripItems[6] = this.ToolStripButtonStop;
            toolStripItems[7] = this.ToolStripSeparator3;
            toolStripItems[8] = this.ToolStripButtonRun;
            toolStripItems[9] = this.ToolStripSeparator4;
            toolStripItems[10] = this.ToolStripButtonPrints;
            this.ToolStrip.Items.AddRange(toolStripItems);
            this.ToolStrip.Location = new Point(0, 0x1b5);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new Size(0x3a5, 0x19);
            this.ToolStrip.TabIndex = 0x73;
            this.ToolStrip.Text = "ToolStrip1";
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(110, 0x16);
            this.ToolStripLabel1.Text = "عدد مرات المزامنة:";
            this.TxTGVRowsCount.ForeColor = Color.DarkGreen;
            this.TxTGVRowsCount.Name = "TxTGVRowsCount";
            this.TxTGVRowsCount.RightToLeft = RightToLeft.No;
            this.TxTGVRowsCount.Size = new Size(15, 0x16);
            this.TxTGVRowsCount.Text = "0";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x19);
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new Size(0x45, 0x16);
            this.ToolStripLabel2.Text = "عدد الأوامر:";
            this.TXTCounTS.Name = "TXTCounTS";
            this.TXTCounTS.Size = new Size(15, 0x16);
            this.TXTCounTS.Text = "0";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x19);
            this.ToolStripButtonStop.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonStop.Enabled = false;
            this.ToolStripButtonStop.ForeColor = Color.Red;
            this.ToolStripButtonStop.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonStop.Name = "ToolStripButtonStop";
            this.ToolStripButtonStop.Size = new Size(0xac, 0x16);
            this.ToolStripButtonStop.Text = "ايقاف المهام ومسح كل الأوامر";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x19);
            this.ToolStripButtonRun.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonRun.ForeColor = Color.Blue;
            this.ToolStripButtonRun.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonRun.Name = "ToolStripButtonRun";
            this.ToolStripButtonRun.Size = new Size(140, 0x16);
            this.ToolStripButtonRun.Text = "بدء مهام مزامنة الطباعة";
            this.ToolStripButtonRun.ToolTipText = "تشغيل المهام ومسح كل الأوامر";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x19);
            this.ToolStripButtonPrints.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.ToolStripButtonPrints.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonPrints.Name = "ToolStripButtonPrints";
            this.ToolStripButtonPrints.Size = new Size(0x66, 0x16);
            this.ToolStripButtonPrints.Text = "إعدادات الطابعات";
            this.TimerStart.Interval = 0x1388;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3a5, 0x1ce);
            base.Controls.Add(this.ToolStrip);
            base.Controls.Add(this.LabelErrSingle);
            base.Controls.Add(this.LabelErrMulti);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.Name = "CRCloudPrint";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            this.Text = "مزامنة الطباعة من نسخة التاب";
            ((ISupportInitialize) this.GV).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.ToolStripButtonRun.PerformClick();
        }

        private void A(object A, FormClosedEventArgs R)
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

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            Application.DoEvents();
            this.ToolStripButtonRun.Enabled = true;
            this.ToolStripButtonStop.Enabled = false;
            this.TimerStart.Enabled = false;
            try
            {
                DataSet dataSet = new DataSet();
                string selectCommandText = "SELECT * FROM TaNNCloudPrint WHERE (CenterFrontID = @CenterFrontID)";
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                dataSet.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataSet, "TaMultiPrint");
                this.A.Close();
                this.GV.DataSource = dataSet;
                this.GV.DataMember = "TaNNCloudPrint";
                this.GV.Refresh();
                this.GV.Columns["ID"].HeaderText = "رقم الطباعة";
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["InvID"].HeaderText = "رمز الفاتورة";
                this.GV.Columns["TypID"].Visible = false;
                int num2 = this.GV.Rows.Count - 1;
                while (true)
                {
                    if (num2 < 0)
                    {
                        DataSet set2 = new DataSet();
                        string str2 = "SELECT * FROM TaNNCloudPrint WHERE (CenterFrontID = @CenterFrontID)";
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        set2.Clear();
                        SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                        adapter2.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                        adapter2.Fill(set2, "TaNNCloudPrint");
                        this.A.Close();
                        this.GV.DataSource = set2;
                        this.GV.DataMember = "TaNNCloudPrint";
                        this.GV.Refresh();
                        this.GV.Columns["ID"].HeaderText = "رقم الطباعة";
                        this.GV.Columns["CenterFrontID"].Visible = false;
                        this.GV.Columns["InvID"].HeaderText = "رمز الفاتورة";
                        this.GV.Columns["TypID"].Visible = false;
                        break;
                    }
                    this.A = Conversions.ToString(this.GV.Rows[num2].Cells[0].Value);
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNCloudPrint WHERE (ID = @ID)", this.A);
                    command.Parameters.AddWithValue("ID", this.A);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    num2 += -1;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.TimerStart.Enabled = false;
                this.ToolStripButtonRun.Enabled = true;
                this.ToolStripButtonStop.Enabled = false;
                ProjectData.ClearProjectError();
            }
        }

        private void Q(object A, EventArgs R)
        {
            this.ToolStripButtonRun.Enabled = false;
            this.ToolStripButtonStop.Enabled = true;
            this.TimerStart.Enabled = true;
        }

        public void R()
        {
            Application.DoEvents();
            try
            {
                DataSet dataSet = new DataSet();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                string selectCommandText = "SELECT * FROM TaNNCloudPrint WHERE (CenterFrontID = @CenterFrontID)";
                dataSet.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataSet, "TaNNCloudPrint");
                this.A.Close();
                this.GV.DataSource = dataSet;
                this.GV.DataMember = "TaNNCloudPrint";
                this.GV.Refresh();
                this.GV.Columns["ID"].HeaderText = "رقم الطباعة";
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["InvID"].HeaderText = "رمز الفاتورة";
                this.GV.Columns["TypID"].Visible = false;
                if (this.GV.Rows.Count > 0)
                {
                    this.P();
                }
                else
                {
                    this.TimerStart.Enabled = true;
                }
                this.TXTCounTS.Text = Conversions.ToString(this.GV.Rows.Count);
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.TimerStart.Enabled = false;
                this.ToolStripButtonRun.Enabled = true;
                this.ToolStripButtonStop.Enabled = false;
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, EventArgs R)
        {
            this.TxTGVRowsCount.Text = Conversions.ToString(Conversion.Val(Conversions.ToDouble(this.TxTGVRowsCount.Text) + 1.0));
            this.TimerStart.Enabled = false;
            this.R();
        }

        internal virtual Label LabelErrSingle
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label LabelErrMulti
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual System.Windows.Forms.ToolStrip ToolStrip
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

        internal virtual ToolStripLabel TxTGVRowsCount
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

        internal virtual ToolStripLabel ToolStripLabel2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripLabel TXTCounTS
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual ToolStripButton ToolStripButtonStop
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripButton ToolStripButtonRun
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

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ToolStripButton ToolStripButtonPrints
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Timer TimerStart
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

