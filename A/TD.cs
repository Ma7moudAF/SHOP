namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class TD : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerCreatTa"), CompilerGenerated]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ProgressBarMain"), CompilerGenerated]
        private ProgressBar A;
        [AccessedThroughProperty("ProgressBarCreateTa"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ProgressBar R;
        [CompilerGenerated, AccessedThroughProperty("GroupBoxProssMain"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("GroupBoxCreateTa"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Panel1"), CompilerGenerated]
        private Panel A;
        [AccessedThroughProperty("TimerStart"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Timer R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerDropTa")]
        private Timer P;
        [CompilerGenerated, AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerUser")]
        private Timer Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerCenter")]
        private Timer I;
        [CompilerGenerated, AccessedThroughProperty("TimerGroup"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerMaterials")]
        private Timer F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerCustomer"), CompilerGenerated]
        private Timer H;
        [AccessedThroughProperty("TimerSuplier"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBoxMaterial"), CompilerGenerated]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ProgressBarMaterial")]
        private ProgressBar P;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("GVMaterials"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [CompilerGenerated, AccessedThroughProperty("GVCustomer"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView R;
        [AccessedThroughProperty("GroupBoxCustomer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [CompilerGenerated, AccessedThroughProperty("ProgressBarCustomer"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ProgressBar Q;
        [AccessedThroughProperty("GVSuplier"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView P;
        [AccessedThroughProperty("GroupBoxSuplier"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [AccessedThroughProperty("ProgressBarSuplier"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private ProgressBar I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonExite")]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOk")]
        private Button R;
        private SqlConnection A;
        private int A;
        private int R;

        public TD()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = 0;
            this.R = 0;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(TD));
            this.TimerCreatTa = new Timer(this.A);
            this.ProgressBarMain = new ProgressBar();
            this.ProgressBarCreateTa = new ProgressBar();
            this.GroupBoxProssMain = new GroupBox();
            this.GroupBoxCreateTa = new GroupBox();
            this.Panel1 = new Panel();
            this.ButtonExite = new Button();
            this.ButtonOk = new Button();
            this.TimerStart = new Timer(this.A);
            this.TimerDropTa = new Timer(this.A);
            this.TxTTitle = new Label();
            this.TimerUser = new Timer(this.A);
            this.TimerCenter = new Timer(this.A);
            this.TimerGroup = new Timer(this.A);
            this.TimerMaterials = new Timer(this.A);
            this.TimerCustomer = new Timer(this.A);
            this.TimerSuplier = new Timer(this.A);
            this.GroupBoxMaterial = new GroupBox();
            this.ProgressBarMaterial = new ProgressBar();
            this.Label1 = new Label();
            this.GVMaterials = new DataGridView();
            this.GVCustomer = new DataGridView();
            this.GroupBoxCustomer = new GroupBox();
            this.ProgressBarCustomer = new ProgressBar();
            this.GVSuplier = new DataGridView();
            this.GroupBoxSuplier = new GroupBox();
            this.ProgressBarSuplier = new ProgressBar();
            this.Label2 = new Label();
            this.GroupBoxProssMain.SuspendLayout();
            this.GroupBoxCreateTa.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBoxMaterial.SuspendLayout();
            ((ISupportInitialize) this.GVMaterials).BeginInit();
            ((ISupportInitialize) this.GVCustomer).BeginInit();
            this.GroupBoxCustomer.SuspendLayout();
            ((ISupportInitialize) this.GVSuplier).BeginInit();
            this.GroupBoxSuplier.SuspendLayout();
            base.SuspendLayout();
            this.ProgressBarMain.BackColor = Color.WhiteSmoke;
            this.ProgressBarMain.Dock = DockStyle.Fill;
            this.ProgressBarMain.Location = new Point(3, 0x13);
            this.ProgressBarMain.Maximum = 10;
            this.ProgressBarMain.Name = "ProgressBarMain";
            this.ProgressBarMain.Size = new Size(0x3df, 0x1d);
            this.ProgressBarMain.TabIndex = 11;
            this.ProgressBarCreateTa.Dock = DockStyle.Fill;
            this.ProgressBarCreateTa.Location = new Point(3, 0x13);
            this.ProgressBarCreateTa.Maximum = 30;
            this.ProgressBarCreateTa.Name = "ProgressBarCreateTa";
            this.ProgressBarCreateTa.Size = new Size(0x3df, 0x1d);
            this.ProgressBarCreateTa.TabIndex = 12;
            this.GroupBoxProssMain.Controls.Add(this.ProgressBarMain);
            this.GroupBoxProssMain.Dock = DockStyle.Bottom;
            this.GroupBoxProssMain.Location = new Point(0, 0x23c);
            this.GroupBoxProssMain.Name = "GroupBoxProssMain";
            this.GroupBoxProssMain.Size = new Size(0x3e5, 0x33);
            this.GroupBoxProssMain.TabIndex = 13;
            this.GroupBoxProssMain.TabStop = false;
            this.GroupBoxProssMain.Text = "التقدم الرئيسي";
            this.GroupBoxCreateTa.Controls.Add(this.ProgressBarCreateTa);
            this.GroupBoxCreateTa.Dock = DockStyle.Bottom;
            this.GroupBoxCreateTa.Location = new Point(0, 0x209);
            this.GroupBoxCreateTa.Name = "GroupBoxCreateTa";
            this.GroupBoxCreateTa.Size = new Size(0x3e5, 0x33);
            this.GroupBoxCreateTa.TabIndex = 14;
            this.GroupBoxCreateTa.TabStop = false;
            this.GroupBoxCreateTa.Text = "إعادة انشاء الجداول";
            this.Panel1.Controls.Add(this.ButtonExite);
            this.Panel1.Controls.Add(this.ButtonOk);
            this.Panel1.Dock = DockStyle.Top;
            this.Panel1.Location = new Point(0, 270);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new Size(0x3e5, 0x37);
            this.Panel1.TabIndex = 15;
            this.ButtonExite.DialogResult = DialogResult.Cancel;
            this.ButtonExite.FlatAppearance.BorderColor = Color.Green;
            this.ButtonExite.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonExite.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonExite.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonExite.FlatStyle = FlatStyle.Flat;
            this.ButtonExite.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonExite.Image = A.F.ImCloseOrang;
            this.ButtonExite.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonExite.Location = new Point(12, 7);
            this.ButtonExite.Margin = new Padding(3, 4, 3, 4);
            this.ButtonExite.Name = "ButtonExite";
            this.ButtonExite.Size = new Size(0xbb, 0x2c);
            this.ButtonExite.TabIndex = 0x35;
            this.ButtonExite.Text = "اغلاق، ربما لاحقاً";
            this.ButtonExite.UseVisualStyleBackColor = true;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(0xd8, 7);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x2f4, 0x2c);
            this.ButtonOk.TabIndex = 0x34;
            this.ButtonOk.Text = "نعم، قم بإعادة بناء الجيل الرابع حسب البيانات الموجودة في الجيل الثالث";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.TimerStart.Interval = 0xbb8;
            this.TimerDropTa.Interval = 0x3e8;
            this.TxTTitle.Dock = DockStyle.Bottom;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0x14e);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3e5, 0x22);
            this.TxTTitle.TabIndex = 0x74;
            this.TxTTitle.Text = " ";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TimerUser.Interval = 0x3e8;
            this.TimerCenter.Interval = 0x3e8;
            this.GroupBoxMaterial.Controls.Add(this.ProgressBarMaterial);
            this.GroupBoxMaterial.Dock = DockStyle.Bottom;
            this.GroupBoxMaterial.Location = new Point(0, 470);
            this.GroupBoxMaterial.Name = "GroupBoxMaterial";
            this.GroupBoxMaterial.Size = new Size(0x3e5, 0x33);
            this.GroupBoxMaterial.TabIndex = 0x76;
            this.GroupBoxMaterial.TabStop = false;
            this.GroupBoxMaterial.Text = " استيراد المستودع";
            this.ProgressBarMaterial.Dock = DockStyle.Fill;
            this.ProgressBarMaterial.Location = new Point(3, 0x13);
            this.ProgressBarMaterial.Maximum = 30;
            this.ProgressBarMaterial.Name = "ProgressBarMaterial";
            this.ProgressBarMaterial.Size = new Size(0x3df, 0x1d);
            this.ProgressBarMaterial.TabIndex = 12;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Green;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x3e5, 0x22);
            this.Label1.TabIndex = 0x77;
            this.Label1.Text = "استيراد بيانات الجيل الثالث";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.GVMaterials.AllowUserToAddRows = false;
            this.GVMaterials.AllowUserToDeleteRows = false;
            this.GVMaterials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVMaterials.Location = new Point(0x51a, 0x240);
            this.GVMaterials.Name = "GVMaterials";
            this.GVMaterials.RightToLeft = RightToLeft.Yes;
            this.GVMaterials.RowHeadersVisible = false;
            this.GVMaterials.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVMaterials.Size = new Size(0xae, 0x36);
            this.GVMaterials.TabIndex = 120;
            this.GVCustomer.AllowUserToAddRows = false;
            this.GVCustomer.AllowUserToDeleteRows = false;
            this.GVCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCustomer.Location = new Point(0x51a, 0x20c);
            this.GVCustomer.Name = "GVCustomer";
            this.GVCustomer.RightToLeft = RightToLeft.Yes;
            this.GVCustomer.RowHeadersVisible = false;
            this.GVCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVCustomer.Size = new Size(0xae, 0x2e);
            this.GVCustomer.TabIndex = 0x79;
            this.GroupBoxCustomer.Controls.Add(this.ProgressBarCustomer);
            this.GroupBoxCustomer.Dock = DockStyle.Bottom;
            this.GroupBoxCustomer.Location = new Point(0, 0x1a3);
            this.GroupBoxCustomer.Name = "GroupBoxCustomer";
            this.GroupBoxCustomer.Size = new Size(0x3e5, 0x33);
            this.GroupBoxCustomer.TabIndex = 0x7a;
            this.GroupBoxCustomer.TabStop = false;
            this.GroupBoxCustomer.Text = "استيراد العملاء وانشاء نظام ترصيد";
            this.ProgressBarCustomer.Dock = DockStyle.Fill;
            this.ProgressBarCustomer.Location = new Point(3, 0x13);
            this.ProgressBarCustomer.Maximum = 30;
            this.ProgressBarCustomer.Name = "ProgressBarCustomer";
            this.ProgressBarCustomer.Size = new Size(0x3df, 0x1d);
            this.ProgressBarCustomer.TabIndex = 12;
            this.GVSuplier.AllowUserToAddRows = false;
            this.GVSuplier.AllowUserToDeleteRows = false;
            this.GVSuplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVSuplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVSuplier.Location = new Point(0x51a, 0x1d8);
            this.GVSuplier.Name = "GVSuplier";
            this.GVSuplier.RightToLeft = RightToLeft.Yes;
            this.GVSuplier.RowHeadersVisible = false;
            this.GVSuplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVSuplier.Size = new Size(0xae, 0x2e);
            this.GVSuplier.TabIndex = 0x7b;
            this.GroupBoxSuplier.Controls.Add(this.ProgressBarSuplier);
            this.GroupBoxSuplier.Dock = DockStyle.Bottom;
            this.GroupBoxSuplier.Location = new Point(0, 0x170);
            this.GroupBoxSuplier.Name = "GroupBoxSuplier";
            this.GroupBoxSuplier.Size = new Size(0x3e5, 0x33);
            this.GroupBoxSuplier.TabIndex = 0x7c;
            this.GroupBoxSuplier.TabStop = false;
            this.GroupBoxSuplier.Text = "استيراد الموردين وانشاء نظام ترصيد";
            this.ProgressBarSuplier.Dock = DockStyle.Fill;
            this.ProgressBarSuplier.Location = new Point(3, 0x13);
            this.ProgressBarSuplier.Maximum = 30;
            this.ProgressBarSuplier.Name = "ProgressBarSuplier";
            this.ProgressBarSuplier.Size = new Size(0x3df, 0x1d);
            this.ProgressBarSuplier.TabIndex = 12;
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0, 0x22);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x3e5, 0xec);
            this.Label2.TabIndex = 0x7d;
            this.Label2.Text = manager.GetString("Label2.Text");
            this.Label2.TextAlign = ContentAlignment.MiddleLeft;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3e5, 0x26f);
            base.ControlBox = false;
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.GVCustomer);
            base.Controls.Add(this.GroupBoxSuplier);
            base.Controls.Add(this.GVSuplier);
            base.Controls.Add(this.GroupBoxCustomer);
            base.Controls.Add(this.GVMaterials);
            base.Controls.Add(this.GroupBoxMaterial);
            base.Controls.Add(this.Panel1);
            base.Controls.Add(this.GroupBoxCreateTa);
            base.Controls.Add(this.GroupBoxProssMain);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ImportFrom3YAZ";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "استيراد البيانات";
            this.GroupBoxProssMain.ResumeLayout(false);
            this.GroupBoxCreateTa.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.GroupBoxMaterial.ResumeLayout(false);
            ((ISupportInitialize) this.GVMaterials).EndInit();
            ((ISupportInitialize) this.GVCustomer).EndInit();
            this.GroupBoxCustomer.ResumeLayout(false);
            ((ISupportInitialize) this.GVSuplier).EndInit();
            this.GroupBoxSuplier.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
        }

        public void AR()
        {
            // Invalid method body.
        }

        public void B()
        {
            // Invalid method body.
        }

        public void C()
        {
            // Invalid method body.
        }

        public void D()
        {
            // Invalid method body.
        }

        private void D(object A, EventArgs R)
        {
            this.TimerCenter.Enabled = false;
            this.P();
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

        public void DR()
        {
            // Invalid method body.
        }

        public void E()
        {
            // Invalid method body.
        }

        private void E(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void F()
        {
            // Invalid method body.
        }

        private void F(object A, EventArgs R)
        {
            this.TimerGroup.Enabled = false;
            this.I();
        }

        public void FR()
        {
            // Invalid method body.
        }

        public void G()
        {
            // Invalid method body.
        }

        private void G(object A, EventArgs R)
        {
            // Invalid method body.
        }

        public void H()
        {
            // Invalid method body.
        }

        private void H(object A, EventArgs R)
        {
            this.TimerMaterials.Enabled = false;
            this.D();
        }

        public void HR()
        {
            // Invalid method body.
        }

        public void I()
        {
            // Invalid method body.
        }

        private void I(object A, EventArgs R)
        {
            this.TimerUser.Enabled = false;
            this.Q();
        }

        public void IR()
        {
            // Invalid method body.
        }

        public void J()
        {
            // Invalid method body.
        }

        public void K()
        {
            // Invalid method body.
        }

        public void L()
        {
            // Invalid method body.
        }

        public void M()
        {
            // Invalid method body.
        }

        public void N()
        {
            // Invalid method body.
        }

        public void O()
        {
            // Invalid method body.
        }

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            this.TimerCreatTa.Enabled = false;
            this.R = (int) Math.Round((double) (Conversion.Val(this.R) + 1.0));
            if (this.R == 1)
            {
                this.T();
            }
            else if (this.R == 2)
            {
                this.X();
            }
            else if (this.R == 3)
            {
                this.G();
            }
            else if (this.R == 4)
            {
                this.E();
            }
            else if (this.R == 5)
            {
                this.K();
            }
            else if (this.R == 6)
            {
                this.U();
            }
            else if (this.R == 7)
            {
                this.L();
            }
            else if (this.R == 8)
            {
                this.N();
            }
            else if (this.R == 9)
            {
                this.V();
            }
            else if (this.R == 10)
            {
                this.Y();
            }
            else if (this.R == 11)
            {
                this.O();
            }
            else if (this.R == 12)
            {
                this.B();
            }
            else if (this.R == 13)
            {
                this.S();
            }
            else if (this.R == 14)
            {
                this.Z();
            }
            else if (this.R == 15)
            {
                this.M();
            }
            else if (this.R == 0x10)
            {
                this.C();
            }
            else if (this.R == 0x11)
            {
                this.J();
            }
            else if (this.R == 0x12)
            {
                this.W();
            }
            else if (this.R == 0x13)
            {
                this.AR();
            }
            else if (this.R == 20)
            {
                this.PR();
            }
            else if (this.R == 0x15)
            {
                this.QR();
            }
            else if (this.R == 0x16)
            {
                this.IR();
            }
            else if (this.R == 0x17)
            {
                this.DR();
                this.TimerCreatTa.Enabled = true;
            }
            else if (this.R == 0x18)
            {
                this.FR();
                this.TimerCreatTa.Enabled = true;
            }
            else if (this.R == 0x19)
            {
                this.HR();
                this.TimerCreatTa.Enabled = true;
            }
            else if (this.R == 0x1a)
            {
                this.TimerStart.Enabled = true;
            }
        }

        public void PR()
        {
            // Invalid method body.
        }

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerDropTa.Enabled = false;
            this.R();
        }

        public void QR()
        {
            // Invalid method body.
        }

        public void R()
        {
            // Invalid method body.
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void R(object A, EventArgs R)
        {
            this.TimerStart.Enabled = false;
            this.GroupBoxProssMain.Visible = true;
            this.A++;
            if (this.A == 1)
            {
                this.TxTTitle.Text = "إعادة بناء الجداول";
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                this.ProgressBarMain.Value = this.A;
                this.TimerDropTa.Enabled = true;
            }
            if (this.A == 2)
            {
                this.TxTTitle.Text = "انشاء الجداول";
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                this.GroupBoxCreateTa.Visible = true;
                this.ProgressBarMain.Value = this.A;
                this.TimerCreatTa.Enabled = true;
            }
            if (this.A == 3)
            {
                this.TxTTitle.Text = " نسخ الفروع والمستودعات";
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                this.ProgressBarMain.Value = this.A;
                this.TimerCenter.Enabled = true;
            }
            if (this.A == 4)
            {
                this.TxTTitle.Text = " نسخ المدير";
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                this.ProgressBarMain.Value = this.A;
                this.TimerUser.Enabled = true;
            }
            if (this.A == 5)
            {
                this.TxTTitle.Text = " نسخ المجموعات";
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                this.ProgressBarMain.Value = this.A;
                this.TimerGroup.Enabled = true;
            }
            if (this.A == 6)
            {
                this.TxTTitle.Text = "نسخ المواد من المستودعات";
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                this.GroupBoxMaterial.Visible = true;
                this.ProgressBarMain.Value = this.A;
                this.TimerMaterials.Enabled = true;
            }
            if (this.A == 7)
            {
                this.TxTTitle.Text = "يتم الأن استيراد العملاء";
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                this.GroupBoxCustomer.Visible = true;
                this.ProgressBarMain.Value = this.A;
                this.TimerCustomer.Enabled = true;
            }
            if (this.A == 8)
            {
                this.TxTTitle.Text = "يتم الأن استيراد الموردين";
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                this.GroupBoxSuplier.Visible = true;
                this.ProgressBarMain.Value = this.A;
                this.TimerSuplier.Enabled = true;
            }
            if (this.A == 9)
            {
                this.TxTTitle.Text = " انهاء";
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                Interaction.MsgBox("يجب عليك إعادة تشغيل البرنامج", MsgBoxStyle.ApplicationModal, null);
                ProjectData.EndApp();
            }
        }

        public void S()
        {
            // Invalid method body.
        }

        public void T()
        {
            // Invalid method body.
        }

        private void T(object A, EventArgs R)
        {
            this.TimerCustomer.Enabled = false;
            this.F();
        }

        public void U()
        {
            // Invalid method body.
        }

        public void V()
        {
            // Invalid method body.
        }

        public void W()
        {
            // Invalid method body.
        }

        public void X()
        {
            // Invalid method body.
        }

        private void X(object A, EventArgs R)
        {
            this.TimerSuplier.Enabled = false;
            this.H();
        }

        public void Y()
        {
            // Invalid method body.
        }

        public void Z()
        {
            // Invalid method body.
        }

        internal virtual Timer TimerCreatTa
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

        internal virtual ProgressBar ProgressBarMain
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ProgressBar ProgressBarCreateTa
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBoxProssMain
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBoxCreateTa
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual Timer TimerStart
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

        internal virtual Timer TimerDropTa
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

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Timer TimerUser
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Timer TimerCenter
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                Timer i = this.I;
                if (i != null)
                {
                    i.Tick -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.Tick += handler;
                }
            }
        }

        internal virtual Timer TimerGroup
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                Timer d = this.D;
                if (d != null)
                {
                    d.Tick -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.Tick += handler;
                }
            }
        }

        internal virtual Timer TimerMaterials
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                Timer f = this.F;
                if (f != null)
                {
                    f.Tick -= handler;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.Tick += handler;
                }
            }
        }

        internal virtual Timer TimerCustomer
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                Timer h = this.H;
                if (h != null)
                {
                    h.Tick -= handler;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.Tick += handler;
                }
            }
        }

        internal virtual Timer TimerSuplier
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                Timer t = this.T;
                if (t != null)
                {
                    t.Tick -= handler;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.Tick += handler;
                }
            }
        }

        internal virtual GroupBox GroupBoxMaterial
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ProgressBar ProgressBarMaterial
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual DataGridView GVMaterials
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual DataGridView GVCustomer
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox GroupBoxCustomer
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual ProgressBar ProgressBarCustomer
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual DataGridView GVSuplier
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBoxSuplier
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual ProgressBar ProgressBarSuplier
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonExite
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.E);
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

        internal virtual Button ButtonOk
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
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
    }
}

