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
    using System.Management;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class SH : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerStart"), CompilerGenerated]
        private Timer A;
        [AccessedThroughProperty("TxTCenterName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("PictureBox1")]
        private PictureBox A;
        [AccessedThroughProperty("ProgressBar"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private System.Windows.Forms.ProgressBar A;
        [AccessedThroughProperty("ProgressBarCreate"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private System.Windows.Forms.ProgressBar R;
        [CompilerGenerated, AccessedThroughProperty("TimerCreatTa"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TempThems")]
        private TextBox R;
        [CompilerGenerated, AccessedThroughProperty("TempFontSize"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TempThemsArial"), CompilerGenerated]
        private TextBox Q;
        [CompilerGenerated, AccessedThroughProperty("TempValuM"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [AccessedThroughProperty("CodeValuSizeInSecreen"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CodeValuSizeMaSecreen")]
        private TextBox F;
        [AccessedThroughProperty("CodeValuSizePaySecreen"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("InsertEditPaySup")]
        private TextBox T;
        [AccessedThroughProperty("CodeValuSizePaySupSecreen"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStrip1")]
        private ToolStrip A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("LableState")]
        private ToolStripLabel A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripLabel1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripLabel R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonOption"), CompilerGenerated]
        private ToolStripDropDownButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButMor")]
        private ToolStripMenuItem A;
        [AccessedThroughProperty("ButDownlaodSql"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem R;
        [AccessedThroughProperty("ToolStripSeparator1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripSeparator2"), CompilerGenerated]
        private ToolStripSeparator R;
        [CompilerGenerated, AccessedThroughProperty("ButtonFixCon"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem P;
        [AccessedThroughProperty("ButRestor"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripMenuItem Q;
        [AccessedThroughProperty("ToolStripSeparator3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ClearCashMe"), CompilerGenerated]
        private ToolStripMenuItem I;
        [AccessedThroughProperty("ToolStripSeparator5"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripSeparator I;
        [AccessedThroughProperty("ButtAdvance"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ToolStripMenuItem D;
        private string A;
        private string R;
        private string P;
        private A.M A;
        private A.M R;
        public int A;
        public int R;

        public SH()
        {
            base.Disposed += new EventHandler(this.A);
            base.Load += new EventHandler(this.R);
            base.Closed += new EventHandler(this.H);
            base.Shown += new EventHandler(this.X);
            this.A = Application.StartupPath + @"\DB\DB.mdf";
            this.R = Application.StartupPath + @"\NewDB.mdf";
            this.P = Application.StartupPath + @"\TmpSerial.txt";
            this.A = new A.M();
            this.R = new A.M();
            this.A = 0;
            this.R = 0;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(SH));
            this.TimerStart = new Timer(this.A);
            this.TxTCenterName = new TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressBarCreate = new System.Windows.Forms.ProgressBar();
            this.TimerCreatTa = new Timer(this.A);
            this.TempThems = new TextBox();
            this.TempFontSize = new TextBox();
            this.TempThemsArial = new TextBox();
            this.TempValuM = new TextBox();
            this.CodeValuSizeInSecreen = new TextBox();
            this.CodeValuSizeMaSecreen = new TextBox();
            this.CodeValuSizePaySecreen = new TextBox();
            this.InsertEditPaySup = new TextBox();
            this.CodeValuSizePaySupSecreen = new TextBox();
            this.ToolStrip1 = new ToolStrip();
            this.LableState = new ToolStripLabel();
            this.ToolStripLabel1 = new ToolStripLabel();
            this.ToolStripButtonOption = new ToolStripDropDownButton();
            this.ButMor = new ToolStripMenuItem();
            this.ButDownlaodSql = new ToolStripMenuItem();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.ButRestor = new ToolStripMenuItem();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ClearCashMe = new ToolStripMenuItem();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ButtAdvance = new ToolStripMenuItem();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ButtonFixCon = new ToolStripMenuItem();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.PictureBox1 = new PictureBox();
            this.ToolStrip1.SuspendLayout();
            ((ISupportInitialize) this.PictureBox1).BeginInit();
            base.SuspendLayout();
            this.TimerStart.Interval = 50;
            this.TxTCenterName.Location = new Point(0x109, 0x253);
            this.TxTCenterName.Name = "TxTCenterName";
            this.TxTCenterName.Size = new Size(190, 0x17);
            this.TxTCenterName.TabIndex = 7;
            this.ProgressBar.BackColor = Color.WhiteSmoke;
            this.ProgressBar.Dock = DockStyle.Bottom;
            this.ProgressBar.Location = new Point(0, 0x17e);
            this.ProgressBar.Maximum = 10;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new Size(0x248, 20);
            this.ProgressBar.TabIndex = 9;
            this.ProgressBarCreate.Dock = DockStyle.Bottom;
            this.ProgressBarCreate.Location = new Point(0, 0x192);
            this.ProgressBarCreate.Maximum = 30;
            this.ProgressBarCreate.Name = "ProgressBarCreate";
            this.ProgressBarCreate.Size = new Size(0x248, 20);
            this.ProgressBarCreate.TabIndex = 10;
            this.ProgressBarCreate.Visible = false;
            this.TempThems.Location = new Point(0x8d, 0x24a);
            this.TempThems.Name = "TempThems";
            this.TempThems.Size = new Size(100, 0x17);
            this.TempThems.TabIndex = 11;
            this.TempFontSize.Location = new Point(0x8d, 0x268);
            this.TempFontSize.Name = "TempFontSize";
            this.TempFontSize.Size = new Size(100, 0x17);
            this.TempFontSize.TabIndex = 12;
            this.TempThemsArial.Location = new Point(0x10, 0x255);
            this.TempThemsArial.Name = "TempThemsArial";
            this.TempThemsArial.Size = new Size(100, 0x17);
            this.TempThemsArial.TabIndex = 13;
            this.TempValuM.Location = new Point(5, 0x26a);
            this.TempValuM.Name = "TempValuM";
            this.TempValuM.Size = new Size(100, 0x17);
            this.TempValuM.TabIndex = 14;
            this.CodeValuSizeInSecreen.Location = new Point(0x11e, 0x26a);
            this.CodeValuSizeInSecreen.Name = "CodeValuSizeInSecreen";
            this.CodeValuSizeInSecreen.Size = new Size(100, 0x17);
            this.CodeValuSizeInSecreen.TabIndex = 0x10;
            this.CodeValuSizeMaSecreen.Location = new Point(0x11e, 0x287);
            this.CodeValuSizeMaSecreen.Name = "CodeValuSizeMaSecreen";
            this.CodeValuSizeMaSecreen.Size = new Size(100, 0x17);
            this.CodeValuSizeMaSecreen.TabIndex = 0x11;
            this.CodeValuSizePaySecreen.Location = new Point(0xa9, 0x287);
            this.CodeValuSizePaySecreen.Name = "CodeValuSizePaySecreen";
            this.CodeValuSizePaySecreen.Size = new Size(100, 0x17);
            this.CodeValuSizePaySecreen.TabIndex = 0x12;
            this.InsertEditPaySup.Location = new Point(40, 0x2ac);
            this.InsertEditPaySup.Name = "InsertEditPaySup";
            this.InsertEditPaySup.Size = new Size(100, 0x17);
            this.InsertEditPaySup.TabIndex = 0x13;
            this.CodeValuSizePaySupSecreen.Location = new Point(0xa9, 0x2c8);
            this.CodeValuSizePaySupSecreen.Name = "CodeValuSizePaySupSecreen";
            this.CodeValuSizePaySupSecreen.Size = new Size(100, 0x17);
            this.CodeValuSizePaySupSecreen.TabIndex = 20;
            this.ToolStrip1.BackColor = Color.WhiteSmoke;
            this.ToolStrip1.Dock = DockStyle.Bottom;
            this.ToolStrip1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.LableState, this.ToolStripLabel1, this.ToolStripButtonOption };
            this.ToolStrip1.Items.AddRange(toolStripItems);
            this.ToolStrip1.Location = new Point(0, 0x1a6);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new Size(0x248, 0x27);
            this.ToolStrip1.TabIndex = 0x16;
            this.ToolStrip1.Text = "ToolStrip1";
            this.LableState.Name = "LableState";
            this.LableState.Size = new Size(20, 0x24);
            this.LableState.Text = "...";
            this.ToolStripLabel1.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new Size(0, 0x24);
            ToolStripItem[] itemArray2 = new ToolStripItem[] { this.ButMor, this.ToolStripSeparator3, this.ButtonFixCon, this.ToolStripSeparator2 };
            this.ToolStripButtonOption.DropDownItems.AddRange(itemArray2);
            this.ToolStripButtonOption.Image = A.F.ImLAbout;
            this.ToolStripButtonOption.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonOption.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonOption.Name = "ToolStripButtonOption";
            this.ToolStripButtonOption.Size = new Size(0x6c, 0x24);
            this.ToolStripButtonOption.Text = "اتخاذ اجراء";
            ToolStripItem[] itemArray3 = new ToolStripItem[] { this.ButDownlaodSql, this.ToolStripSeparator1, this.ButRestor, this.ToolStripSeparator4, this.ClearCashMe, this.ToolStripSeparator5, this.ButtAdvance };
            this.ButMor.DropDownItems.AddRange(itemArray3);
            this.ButMor.Name = "ButMor";
            this.ButMor.Size = new Size(0xc4, 0x26);
            this.ButMor.Text = "المزيد من الاجراءات";
            this.ButDownlaodSql.Name = "ButDownlaodSql";
            this.ButDownlaodSql.Size = new Size(0xf5, 0x16);
            this.ButDownlaodSql.Text = "تحميل مشغل LocalSQLServer";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(0xf2, 6);
            this.ButRestor.Name = "ButRestor";
            this.ButRestor.Size = new Size(0xf5, 0x16);
            this.ButRestor.Text = "استعادة قاعدة بيانات احتياطية";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(0xf2, 6);
            this.ClearCashMe.Name = "ClearCashMe";
            this.ClearCashMe.Size = new Size(0xf5, 0x16);
            this.ClearCashMe.Text = "تنظيف سجل العمليات";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new Size(0xf2, 6);
            this.ButtAdvance.Name = "ButtAdvance";
            this.ButtAdvance.Size = new Size(0xf5, 0x16);
            this.ButtAdvance.Text = "اداوت الصيانة المتقدمة";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(0xc1, 6);
            this.ButtonFixCon.Image = A.F.ImDataError;
            this.ButtonFixCon.ImageScaling = ToolStripItemImageScaling.None;
            this.ButtonFixCon.Name = "ButtonFixCon";
            this.ButtonFixCon.Size = new Size(0xc4, 0x26);
            this.ButtonFixCon.Text = "فحص جملة الاتصال";
            this.ButtonFixCon.Visible = false;
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(0xc1, 6);
            this.PictureBox1.Dock = DockStyle.Fill;
            this.PictureBox1.Image = A.F.NNLogFF;
            this.PictureBox1.Location = new Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new Size(0x248, 0x17e);
            this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0x15;
            this.PictureBox1.TabStop = false;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x248, 0x1cd);
            base.Controls.Add(this.PictureBox1);
            base.Controls.Add(this.CodeValuSizePaySupSecreen);
            base.Controls.Add(this.InsertEditPaySup);
            base.Controls.Add(this.CodeValuSizePaySecreen);
            base.Controls.Add(this.CodeValuSizeMaSecreen);
            base.Controls.Add(this.CodeValuSizeInSecreen);
            base.Controls.Add(this.TempValuM);
            base.Controls.Add(this.TempThemsArial);
            base.Controls.Add(this.TempFontSize);
            base.Controls.Add(this.TempThems);
            base.Controls.Add(this.ProgressBar);
            base.Controls.Add(this.ProgressBarCreate);
            base.Controls.Add(this.TxTCenterName);
            base.Controls.Add(this.ToolStrip1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "StartPoint";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((ISupportInitialize) this.PictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private object A(string A, string R)
        {
            string str = "";
            int num2 = Strings.Asc(R);
            short num3 = (short) Strings.Len(A);
            for (short i = 1; i <= num3; i = (short) (i + 1))
            {
                str = str + Conversions.ToString(Strings.Chr(num2 ^ Strings.Asc(Strings.Mid(A, i, 1))));
            }
            return str;
        }

        public void AP()
        {
            // Invalid method body.
        }

        public void AR()
        {
            // Invalid method body.
        }

        public void B()
        {
            // Invalid method body.
        }

        public void BR()
        {
            // Invalid method body.
        }

        public void C()
        {
            // Invalid method body.
        }

        public void CR()
        {
            // Invalid method body.
        }

        public void D()
        {
            if (!A.PR.T)
            {
                this.Q();
                A.PR.V = true;
                A.PR.V = true;
            }
        }

        private void D(object A, EventArgs R)
        {
            Process.Start("https://yazsys.com/RFSQLServerLocal.aspx");
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

        public void DP()
        {
            // Invalid method body.
        }

        public void DR()
        {
            this.TimerCreatTa.Enabled = true;
            this.ProgressBarCreate.Visible = true;
            this.LableState.Text = "انتظر يتم انشاء جداول قاعدة البيانات";
        }

        public void E()
        {
            Application.DoEvents();
            try
            {
                if (A.D.A.FileSystem.FileExists(this.A))
                {
                    this.TimerStart.Enabled = true;
                }
                else
                {
                    A.D.A.FileSystem.CopyFile(this.R, this.A);
                    this.LableState.Text = A.PR.A.ToString();
                    this.TimerStart.Enabled = true;
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.TimerStart.Enabled = false;
                Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.LableState.Text = "فشل نسخ ملف قاعدة البيانات الرئيسية في مجلد النظام لأنه محمي من الكتابة";
                this.ProgressBar.Visible = false;
                this.ProgressBar.Value = 0;
                ProjectData.ClearProjectError();
            }
        }

        public void ER()
        {
            // Invalid method body.
        }

        public void F()
        {
            if (!A.PR.G)
            {
                this.Q();
                A.PR.V = true;
            }
        }

        private void F(object A, EventArgs R)
        {
            base.TopMost = false;
            A.D.A.A.ShowDialog();
        }

        public void FR()
        {
            // Invalid method body.
        }

        public void G()
        {
            // Invalid method body.
        }

        public void GR()
        {
            // Invalid method body.
        }

        public void H()
        {
            if (!A.PR.X)
            {
                this.Q();
                A.PR.V = true;
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void H(object A, EventArgs R)
        {
            // Invalid method body.
        }

        public void HR()
        {
            // Invalid method body.
        }

        public void I()
        {
            A.D.A.A.ShowDialog();
        }

        private void I(object A, EventArgs R)
        {
            this.R = (int) Math.Round((double) (Conversion.Val(this.R) + 1.0));
            this.TimerCreatTa.Enabled = false;
            if (this.R == 1)
            {
                this.HR();
            }
            else if (this.R == 2)
            {
                this.TR();
            }
            else if (this.R == 3)
            {
                this.XR();
            }
            else if (this.R == 4)
            {
                this.GR();
            }
            else if (this.R == 5)
            {
                this.ER();
            }
            else if (this.R == 6)
            {
                this.KR();
            }
            else if (this.R == 7)
            {
                this.UR();
            }
            else if (this.R == 8)
            {
                this.LR();
            }
            else if (this.R == 9)
            {
                this.NR();
            }
            else if (this.R == 10)
            {
                this.VR();
            }
            else if (this.R == 11)
            {
                this.YR();
            }
            else if (this.R == 12)
            {
                this.OR();
            }
            else if (this.R == 13)
            {
                this.BR();
            }
            else if (this.R == 14)
            {
                this.SR();
            }
            else if (this.R == 15)
            {
                this.ZR();
            }
            else if (this.R == 0x10)
            {
                this.MR();
            }
            else if (this.R == 0x11)
            {
                this.CR();
            }
            else if (this.R == 0x12)
            {
                this.JR();
            }
            else if (this.R == 0x13)
            {
                this.WR();
            }
            else if (this.R == 20)
            {
                this.AP();
            }
            else if (this.R == 0x15)
            {
                this.RP();
            }
            else if (this.R == 0x16)
            {
                this.PP();
            }
            else if (this.R == 0x17)
            {
                this.QP();
                this.TimerCreatTa.Enabled = true;
            }
            else if (this.R == 0x18)
            {
                this.IP();
                this.TimerCreatTa.Enabled = true;
            }
            else if (this.R == 0x19)
            {
                this.DP();
                this.TimerCreatTa.Enabled = true;
            }
            else if (this.R == 0x1a)
            {
                this.ProgressBarCreate.Visible = false;
                this.ProgressBar.Value = 2;
                this.A = 2;
                this.TimerStart.Enabled = true;
            }
        }

        public void IP()
        {
            // Invalid method body.
        }

        public void IR()
        {
            Application.DoEvents();
            try
            {
                SqlConnection selectConnection = new SqlConnection(A.H.Settings.DBConnectionString);
                DataSet dataSet = new DataSet();
                if (selectConnection.State == ConnectionState.Closed)
                {
                    selectConnection.Open();
                }
                string selectCommandText = "SELECT * FROM TaNNCenters";
                dataSet.Clear();
                new SqlDataAdapter(selectCommandText, selectConnection).Fill(dataSet, "TaNNCenters");
                selectConnection.Close();
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    this.TimerStart.Enabled = true;
                }
                else
                {
                    base.TopMost = false;
                    A.D.A.A.ShowDialog();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.DR();
                ProjectData.ClearProjectError();
            }
        }

        public void J()
        {
            try
            {
                SqlConnection connection = new SqlConnection(A.H.Settings.DBConnectionString);
                SqlCommand command = new SqlCommand("ALTER TABLE TaNNCustomers ADD [CuPostCode] NVARCHAR(50), [CuMorID] NVARCHAR(500)", connection);
                SqlCommand command2 = new SqlCommand("ALTER TABLE TaNNCenters ADD [CcSchemeID] NVARCHAR(50), [CcSchemeTy] NVARCHAR(50) NOT NULL DEFAULT 'CRN', [CcCityName] NVARCHAR(50), [CcStreetName] NVARCHAR(50), [CcBuildingNumber] NVARCHAR(50), [CcPlotIdentification] NVARCHAR(50), [CcCitySubdivisionName] NVARCHAR(50), [CcCountrySubentity] NVARCHAR(50), [CcPostCode] NVARCHAR(50), [CcMorID] NVARCHAR(500)", connection);
                SqlCommand command3 = new SqlCommand("UPDATE TaNNCustomers SET CuSchemeTy = 'NAT' WHERE CuSchemeTy = 'SAG'", connection);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                connection.Close();
                this.W();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.W();
                ProjectData.ClearProjectError();
            }
        }

        public void JR()
        {
            // Invalid method body.
        }

        public void K()
        {
            Application.DoEvents();
            try
            {
                SqlConnection connection = new SqlConnection(A.H.Settings.DBConnectionString);
                Application.DoEvents();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                this.TimerStart.Enabled = true;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.TimerStart.Enabled = false;
                this.LableState.Text = "فشل الاتصال مع قاعدة البيانات";
                this.ToolStripButtonOption.Visible = true;
                this.ButtonFixCon.Visible = true;
                this.ProgressBar.Visible = false;
                this.ProgressBar.Value = 0;
                A.D.A.A.TextBoxError.Text = exception.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        public void KR()
        {
            // Invalid method body.
        }

        public void L()
        {
            // Invalid method body.
        }

        public void LR()
        {
            // Invalid method body.
        }

        public void M()
        {
            // Invalid method body.
        }

        public void MR()
        {
            // Invalid method body.
        }

        public void N()
        {
            // Invalid method body.
        }

        public void NR()
        {
            // Invalid method body.
        }

        public void O()
        {
            // Invalid method body.
        }

        public void OR()
        {
            // Invalid method body.
        }

        public void P()
        {
            if (!A.PR.H)
            {
                this.Q();
                A.PR.V = true;
            }
        }

        private void P(object A, EventArgs R)
        {
            this.ProgressBar.Visible = true;
            this.ProgressBar.Value = (int) Math.Round((double) (Conversion.Val(this.ProgressBar.Value) + 1.0));
            Application.DoEvents();
            this.A = (int) Math.Round((double) (Conversion.Val(this.A) + 1.0));
            if (this.A == 1)
            {
                this.LableState.Text = "انتظر ... يتم فحص مجلدات النظام";
                this.TimerStart.Enabled = false;
                this.X();
            }
            else if (this.A == 2)
            {
                this.LableState.Text = "فحص وجود قاعدة البيانات";
                this.TimerStart.Enabled = false;
                this.E();
            }
            else if (this.A == 3)
            {
                this.LableState.Text = "محاولة الاتصال مع قاعدة البيانات";
                this.TimerStart.Enabled = false;
                this.K();
            }
            else if (this.A == 4)
            {
                this.TimerStart.Enabled = false;
                this.LableState.Text = "انتظر .. يتم تحديث قاعدة البيانات";
                this.U();
            }
            else if (this.A == 5)
            {
                this.TimerStart.Enabled = false;
                this.LableState.Text = "انتظر يتم تحديد حالة النظام";
                this.IR();
            }
            else if (this.A == 6)
            {
                this.TimerStart.Enabled = false;
                this.LableState.Text = "انتظر تحميل الاعدادات";
                A.D.A.A.Size = new Size(0, 0);
                A.D.A.A.Show();
                A.D.A.A.Visible = false;
                A.D.A.A.TxTSortCenterID.Text = A.PR.GR;
                A.D.A.A.R();
                this.TimerStart.Enabled = true;
            }
            else if (this.A == 7)
            {
                this.TimerStart.Enabled = false;
                this.PR();
            }
            else if (this.A == 8)
            {
                this.TimerStart.Enabled = false;
                base.TopMost = false;
                base.Hide();
                A.D.A.A.ShowDialog();
            }
        }

        public void PP()
        {
            // Invalid method body.
        }

        public void PR()
        {
            try
            {
                ManagementObjectCollection instances = new ManagementClass(A.PR.AR).GetInstances();
                using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
                {
                    if (enumerator.MoveNext())
                    {
                        A.PR.M = ((ManagementObject) enumerator.Current).Properties[A.PR.QR].Value.ToString();
                    }
                }
                A.PR.M = A.PR.M;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(new SelectQuery(A.PR.IR));
                ManagementObject obj2 = new ManagementObject();
                using (ManagementObjectCollection.ManagementObjectEnumerator enumerator2 = searcher.Get().GetEnumerator())
                {
                    while (true)
                    {
                        if (!enumerator2.MoveNext())
                        {
                            break;
                        }
                        ManagementBaseObject current = enumerator2.Current;
                        A.PR.C = current[A.PR.DR].ToString();
                    }
                }
                A.PR.W = A.PR.M + Regex.Replace(A.PR.C.ToString(), @"[^\d]", "");
                A.PR.A = false;
                this.QR();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                A.PR.A = false;
                A.PR.M = "PC-Error";
                A.PR.C = "Encrypt-Error";
                A.PR.W = "PC-Net3.5";
                this.QR();
                ProjectData.ClearProjectError();
            }
        }

        public void Q()
        {
            A.D.A.A.ShowDialog();
            A.PR.V = true;
        }

        private void Q(object A, EventArgs R)
        {
            base.TopMost = false;
            A.D.A.A.ShowDialog();
        }

        public void QP()
        {
            // Invalid method body.
        }

        public void QR()
        {
            Application.DoEvents();
            try
            {
                SqlConnection selectConnection = new SqlConnection(A.H.Settings.DBConnectionString);
                DataSet dataSet = new DataSet();
                if (selectConnection.State == ConnectionState.Closed)
                {
                    selectConnection.Open();
                }
                string selectCommandText = "SELECT * FROM TaNNStyleAndThemes WHERE (DBFontStyle = @DBFontStyle)";
                dataSet.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, selectConnection);
                adapter.SelectCommand.Parameters.AddWithValue(Conversions.ToString(this.A("\b\x000e\n#\"8\x001f85 )", "LCLSnRrpQinBEZjkGmtAfov")), A.PR.W ?? DBNull.Value);
                adapter.Fill(dataSet, Conversions.ToString(this.A("7\x0010\x001d\b\x0001%\n\00\f\x0001\t\x0001\x0017", "dkUmBQCqPdcZEosjqiRJlkh")));
                selectConnection.Close();
                this.TempThems.DataBindings.Clear();
                this.TempThems.DataBindings.Add(Conversions.ToString(this.A("\x00023.\"", "VHswnVlTIGfLTfUEIAlAlUK")), dataSet, Conversions.ToString(this.A(">\x0019\x0014\x0001\b,\x0003\t9\x0005\b\0\b\x001eC)/+\x0002\x0003\x00199\x0005\b\0\b\x001e", "mpETBVuUHBUjTveErtJKrRt")));
                this.TempFontSize.DataBindings.Clear();
                this.TempFontSize.DataBindings.Add(Conversions.ToString(this.A("\x00023.\"", "VHswnVlTIGfLTfUEIAlAlUK")), dataSet, Conversions.ToString(this.A("\x001b<1$-\t&,\x001c -%-;f\f\n\x000e'&<\x001b!2-", "HaNnMUFVGtKKTOnDepfTANe")));
                A.PR.Z = this.TempFontSize.Text;
                A.PR.J = this.TempThems.Text;
                this.TempThemsArial.Text = A.QR.A(A.PR.W, A.PR.Z);
                A.PR.D = this.TempThems.Text == this.TempThemsArial.Text;
                this.FR();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.DR();
                ProjectData.ClearProjectError();
            }
        }

        public void R()
        {
            A.D.A.A.ShowDialog();
        }

        private void R(object A, EventArgs R)
        {
        }

        public void RP()
        {
            // Invalid method body.
        }

        public void S()
        {
            // Invalid method body.
        }

        public void SR()
        {
            // Invalid method body.
        }

        public void T()
        {
            // Invalid method body.
        }

        private void T(object A, EventArgs R)
        {
            base.TopMost = false;
            A.D.A.A.ShowDialog();
        }

        public void TR()
        {
            // Invalid method body.
        }

        public void U()
        {
            // Invalid method body.
        }

        public void UR()
        {
            // Invalid method body.
        }

        public void V()
        {
            // Invalid method body.
        }

        public void VR()
        {
            // Invalid method body.
        }

        public void W()
        {
            // Invalid method body.
        }

        public void WR()
        {
            // Invalid method body.
        }

        public void X()
        {
            Application.DoEvents();
            try
            {
                if (!A.D.A.FileSystem.DirectoryExists(Application.StartupPath + @"\BackUpDB"))
                {
                    try
                    {
                        A.D.A.FileSystem.CreateDirectory(Application.StartupPath + @"\BackUpDB");
                    }
                    catch (Exception exception1)
                    {
                        Exception ex = exception1;
                        ProjectData.SetProjectError(ex);
                        Exception exception = ex;
                        this.TimerStart.Enabled = false;
                        this.LableState.Text = "فشل انشاء مجلد النسخ الاحتياطي في مجلد النظام لأن المجلد محمي من الكتابة";
                        this.ProgressBar.Visible = false;
                        this.ProgressBar.Value = 0;
                        ProjectData.ClearProjectError();
                    }
                }
                goto TR_0019;
            TR_0008:
                if (!A.D.A.FileSystem.FileExists(Application.StartupPath + @"\SettingApp\SetDBNam.txt"))
                {
                    A.D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SetDBNam.txt", Application.StartupPath + @"\DB\DB.mdf", false);
                }
                if (!A.D.A.FileSystem.FileExists(Application.StartupPath + @"\SettingApp\SetDBServ.txt"))
                {
                    A.D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SetDBServ.txt", @"(LocalDB)\MSSQLLocalDB", false);
                }
                if (!A.D.A.FileSystem.FileExists(Application.StartupPath + @"\SettingApp\SetDBCon.txt"))
                {
                    string a = @"Data Source= (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB\DB.mdf;";
                    A.D.A.FileSystem.WriteAllText(Application.StartupPath + @"\SetDBCon.txt", A.Z.A(a, "1200"), false);
                }
                this.G();
                return;
            TR_0015:
                if (!A.D.A.FileSystem.DirectoryExists(Application.StartupPath + @"\SettingApp"))
                {
                    try
                    {
                        A.D.A.FileSystem.CreateDirectory(Application.StartupPath + @"\SettingApp");
                        if (!A.D.A.FileSystem.FileExists(Application.StartupPath + @"\SettingApp\SetDBServ.txt") && A.D.A.FileSystem.FileExists(Application.StartupPath + @"\NaSR"))
                        {
                            A.D.A.FileSystem.CopyFile(Application.StartupPath + @"\NaSR", Application.StartupPath + @"\SettingApp\SetDBServ.txt");
                        }
                        if (!A.D.A.FileSystem.FileExists(Application.StartupPath + @"\SettingApp\SetDBNam.txt") && A.D.A.FileSystem.FileExists(Application.StartupPath + @"\NaDB"))
                        {
                            A.D.A.FileSystem.CopyFile(Application.StartupPath + @"\NaDB", Application.StartupPath + @"\SettingApp\SetDBNam.txt");
                        }
                        if (!A.D.A.FileSystem.FileExists(Application.StartupPath + @"\SettingApp\SetDBCon.txt") && A.D.A.FileSystem.FileExists(Application.StartupPath + @"\CoDB"))
                        {
                            A.D.A.FileSystem.CopyFile(Application.StartupPath + @"\CoDB", Application.StartupPath + @"\SettingApp\SetDBCon.txt");
                        }
                    }
                    catch (Exception exception6)
                    {
                        Exception ex = exception6;
                        ProjectData.SetProjectError(ex);
                        Exception exception3 = ex;
                        this.TimerStart.Enabled = false;
                        this.LableState.Text = "فشل انشاء مجلد الفواتير في مجلد النظام لأن المجلد محمي من الكتابة";
                        this.ProgressBar.Visible = false;
                        this.ProgressBar.Value = 0;
                        ProjectData.ClearProjectError();
                    }
                }
                goto TR_0008;
            TR_0019:
                if (!A.D.A.FileSystem.DirectoryExists(Application.StartupPath + @"\DB"))
                {
                    try
                    {
                        A.D.A.FileSystem.CreateDirectory(Application.StartupPath + @"\DB");
                    }
                    catch (Exception exception5)
                    {
                        Exception ex = exception5;
                        ProjectData.SetProjectError(ex);
                        Exception exception2 = ex;
                        this.TimerStart.Enabled = false;
                        this.LableState.Text = "فشل انشاء مجلد قاعدة البيانات في مجلد النظام لأن المجلد محمي من الكتابة";
                        this.ProgressBar.Visible = false;
                        this.ProgressBar.Value = 0;
                        ProjectData.ClearProjectError();
                    }
                }
                goto TR_0015;
            }
            catch (Exception exception7)
            {
                Exception ex = exception7;
                ProjectData.SetProjectError(ex);
                Exception exception4 = ex;
                this.TimerStart.Enabled = false;
                Interaction.MsgBox(exception4.ToString(), MsgBoxStyle.ApplicationModal, null);
                this.LableState.Text = "";
                ProjectData.ClearProjectError();
            }
        }

        private void X(object A, EventArgs R)
        {
            // Invalid method body.
        }

        public void XR()
        {
            // Invalid method body.
        }

        public void Y()
        {
            SqlConnection connection = new SqlConnection(A.H.Settings.DBConnectionString);
            try
            {
                SqlCommand command = new SqlCommand("ALTER TABLE TaNNCenters ADD [CenterIsFixPass] BIT NOT NULL DEFAULT 1", connection);
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                command.ExecuteNonQuery();
                connection.Close();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT UserID, UserPass FROM TaNNUsers";
                dataTable.Clear();
                new SqlDataAdapter(selectCommandText, connection).Fill(dataTable);
                connection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    IEnumerator enumerator;
                    try
                    {
                        enumerator = dataTable.Rows.GetEnumerator();
                        while (true)
                        {
                            if (!enumerator.MoveNext())
                            {
                                break;
                            }
                            DataRow current = (DataRow) enumerator.Current;
                            int num = Conversions.ToInteger(current["UserID"]);
                            string str3 = Conversions.ToString(current["UserPass"]);
                            if (connection.State == ConnectionState.Closed)
                            {
                                connection.Open();
                            }
                            SqlCommand command2 = new SqlCommand("UPDATE [TaNNUsers] SET [UserPass] = @UserPass WHERE [UserID] = @UserID", connection);
                            command2.Parameters.AddWithValue("UserID", num);
                            command2.Parameters.AddWithValue("UserPass", this.A.A(str3.ToString()));
                            command2.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    finally
                    {
                        if (enumerator is IDisposable)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                }
                this.O();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                this.O();
                ProjectData.ClearProjectError();
            }
        }

        public void YR()
        {
            // Invalid method body.
        }

        public void Z()
        {
            // Invalid method body.
        }

        public void ZR()
        {
            // Invalid method body.
        }

        internal virtual Timer TimerStart
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

        internal virtual TextBox TxTCenterName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual PictureBox PictureBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual System.Windows.Forms.ProgressBar ProgressBar
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual System.Windows.Forms.ProgressBar ProgressBarCreate
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Timer TimerCreatTa
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual TextBox TempThems
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TempFontSize
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TempThemsArial
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TempValuM
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox CodeValuSizeInSecreen
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox CodeValuSizeMaSecreen
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox CodeValuSizePaySecreen
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox InsertEditPaySup
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual TextBox CodeValuSizePaySupSecreen
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual ToolStrip ToolStrip1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripLabel LableState
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripDropDownButton ToolStripButtonOption
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem ButMor
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripMenuItem ButDownlaodSql
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

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual ToolStripMenuItem ButtonFixCon
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual ToolStripMenuItem ButRestor
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual ToolStripMenuItem ClearCashMe
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripSeparator ToolStripSeparator5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ToolStripMenuItem ButtAdvance
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                ToolStripMenuItem d = this.D;
                if (d != null)
                {
                    d.Click -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.Click += handler;
                }
            }
        }
    }
}

