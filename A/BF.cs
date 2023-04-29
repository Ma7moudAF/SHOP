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
    public class BF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("TextBoxCatchInvSaleTablNam"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TextBoxCatch")]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTInvIDOpenWat"), CompilerGenerated]
        private TextBox P;
        [AccessedThroughProperty("TxTGVHoldTaName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [AccessedThroughProperty("TxTGVFreeTaName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTGVHoldTaID")]
        private TextBox D;
        [CompilerGenerated, AccessedThroughProperty("TxTGVHoldInvID"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTGVFreeTaID"), CompilerGenerated]
        private TextBox H;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTGVFreeInvID"), CompilerGenerated]
        private TextBox T;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("FlowLayoutPanel1")]
        private FlowLayoutPanel A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("FlowLayoutPanel2")]
        private FlowLayoutPanel R;
        [CompilerGenerated, AccessedThroughProperty("TableLayoutPanel1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableLayoutPanel A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1"), CompilerGenerated]
        private GroupBox R;
        [AccessedThroughProperty("ButtonUpdate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("ButtonFreeAllTable"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [AccessedThroughProperty("ButtonFreeThisTable"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        private SqlConnection A;
        private bool A;

        public BF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = false;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.TextBoxCatchInvSaleTablNam = new TextBox();
            this.TextBoxCatch = new TextBox();
            this.TxTInvIDOpenWat = new TextBox();
            this.TxTGVHoldTaName = new TextBox();
            this.TxTGVFreeTaName = new TextBox();
            this.TxTGVHoldTaID = new TextBox();
            this.TxTGVHoldInvID = new TextBox();
            this.TxTGVFreeTaID = new TextBox();
            this.TxTGVFreeInvID = new TextBox();
            this.ButtonClose = new Button();
            this.FlowLayoutPanel1 = new FlowLayoutPanel();
            this.FlowLayoutPanel2 = new FlowLayoutPanel();
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.GroupBox2 = new GroupBox();
            this.ButtonFreeAllTable = new Button();
            this.GroupBox1 = new GroupBox();
            this.ButtonUpdate = new Button();
            this.ButtonFreeThisTable = new Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3db, 0x29);
            this.TxTTitle.TabIndex = 0x4a;
            this.TxTTitle.Text = "إدارة الصالة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TextBoxCatchInvSaleTablNam.BackColor = SystemColors.InfoText;
            this.TextBoxCatchInvSaleTablNam.ForeColor = Color.Black;
            this.TextBoxCatchInvSaleTablNam.Location = new Point(0x1cf, 0x2ef);
            this.TextBoxCatchInvSaleTablNam.Name = "TextBoxCatchInvSaleTablNam";
            this.TextBoxCatchInvSaleTablNam.Size = new Size(100, 0x17);
            this.TextBoxCatchInvSaleTablNam.TabIndex = 0x5e;
            this.TextBoxCatch.BackColor = SystemColors.InfoText;
            this.TextBoxCatch.ForeColor = Color.Black;
            this.TextBoxCatch.Location = new Point(0x1cf, 0x2d2);
            this.TextBoxCatch.Name = "TextBoxCatch";
            this.TextBoxCatch.Size = new Size(100, 0x17);
            this.TextBoxCatch.TabIndex = 0x5d;
            this.TxTInvIDOpenWat.Location = new Point(0x255, 0x2b9);
            this.TxTInvIDOpenWat.Name = "TxTInvIDOpenWat";
            this.TxTInvIDOpenWat.Size = new Size(100, 0x17);
            this.TxTInvIDOpenWat.TabIndex = 0x5c;
            this.TxTGVHoldTaName.Location = new Point(610, 0x28b);
            this.TxTGVHoldTaName.Name = "TxTGVHoldTaName";
            this.TxTGVHoldTaName.Size = new Size(100, 0x17);
            this.TxTGVHoldTaName.TabIndex = 0x5b;
            this.TxTGVFreeTaName.Location = new Point(0x1cf, 0x28b);
            this.TxTGVFreeTaName.Name = "TxTGVFreeTaName";
            this.TxTGVFreeTaName.Size = new Size(100, 0x17);
            this.TxTGVFreeTaName.TabIndex = 90;
            this.TxTGVHoldTaID.Location = new Point(610, 0x2a0);
            this.TxTGVHoldTaID.Name = "TxTGVHoldTaID";
            this.TxTGVHoldTaID.Size = new Size(100, 0x17);
            this.TxTGVHoldTaID.TabIndex = 0x59;
            this.TxTGVHoldInvID.Location = new Point(610, 0x2ba);
            this.TxTGVHoldInvID.Name = "TxTGVHoldInvID";
            this.TxTGVHoldInvID.Size = new Size(100, 0x17);
            this.TxTGVHoldInvID.TabIndex = 0x58;
            this.TxTGVFreeTaID.Location = new Point(0x1cf, 0x2a0);
            this.TxTGVFreeTaID.Name = "TxTGVFreeTaID";
            this.TxTGVFreeTaID.Size = new Size(100, 0x17);
            this.TxTGVFreeTaID.TabIndex = 0x57;
            this.TxTGVFreeInvID.Location = new Point(0x1cf, 0x2ba);
            this.TxTGVFreeInvID.Name = "TxTGVFreeInvID";
            this.TxTGVFreeInvID.Size = new Size(100, 0x17);
            this.TxTGVFreeInvID.TabIndex = 0x56;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImFinish;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0, 0x24b);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x3db, 0x2c);
            this.ButtonClose.TabIndex = 0x5f;
            this.ButtonClose.Text = "انهاء";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.FlowLayoutPanel1.AutoScroll = true;
            this.FlowLayoutPanel1.Dock = DockStyle.Fill;
            this.FlowLayoutPanel1.Location = new Point(3, 0x13);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new Size(0x1e1, 0x1ca);
            this.FlowLayoutPanel1.TabIndex = 0x60;
            this.FlowLayoutPanel2.AutoScroll = true;
            this.FlowLayoutPanel2.Dock = DockStyle.Fill;
            this.FlowLayoutPanel2.Location = new Point(3, 0x13);
            this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            this.FlowLayoutPanel2.Size = new Size(0x1e2, 0x180);
            this.FlowLayoutPanel2.TabIndex = 0x61;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.GroupBox2, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.GroupBox1, 0, 0);
            this.TableLayoutPanel1.Dock = DockStyle.Top;
            this.TableLayoutPanel1.Location = new Point(0, 0x5c);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 486f));
            this.TableLayoutPanel1.Size = new Size(0x3db, 0x1e6);
            this.TableLayoutPanel1.TabIndex = 0x62;
            this.GroupBox2.Controls.Add(this.FlowLayoutPanel2);
            this.GroupBox2.Controls.Add(this.ButtonFreeThisTable);
            this.GroupBox2.Controls.Add(this.ButtonFreeAllTable);
            this.GroupBox2.Dock = DockStyle.Fill;
            this.GroupBox2.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.GroupBox2.Location = new Point(3, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x1e8, 480);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "طاولات محجوزة";
            this.ButtonFreeAllTable.Dock = DockStyle.Bottom;
            this.ButtonFreeAllTable.Location = new Point(3, 440);
            this.ButtonFreeAllTable.Name = "ButtonFreeAllTable";
            this.ButtonFreeAllTable.Size = new Size(0x1e2, 0x25);
            this.ButtonFreeAllTable.TabIndex = 0x62;
            this.ButtonFreeAllTable.Text = "فك حجز كل الطاولات";
            this.ButtonFreeAllTable.UseVisualStyleBackColor = true;
            this.GroupBox1.BackColor = Color.White;
            this.GroupBox1.Controls.Add(this.FlowLayoutPanel1);
            this.GroupBox1.Dock = DockStyle.Fill;
            this.GroupBox1.ForeColor = Color.DarkGreen;
            this.GroupBox1.Location = new Point(0x1f1, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x1e7, 480);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "طاولات شاغرة";
            this.ButtonUpdate.BackColor = Color.WhiteSmoke;
            this.ButtonUpdate.Dock = DockStyle.Top;
            this.ButtonUpdate.FlatAppearance.BorderColor = Color.Green;
            this.ButtonUpdate.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonUpdate.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonUpdate.FlatStyle = FlatStyle.Flat;
            this.ButtonUpdate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonUpdate.Image = A.F.Im_Refresh;
            this.ButtonUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonUpdate.Location = new Point(0, 0x29);
            this.ButtonUpdate.Margin = new Padding(3, 4, 3, 4);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new Size(0x3db, 0x33);
            this.ButtonUpdate.TabIndex = 0x63;
            this.ButtonUpdate.Text = "تحديث";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonFreeThisTable.Dock = DockStyle.Bottom;
            this.ButtonFreeThisTable.Location = new Point(3, 0x193);
            this.ButtonFreeThisTable.Name = "ButtonFreeThisTable";
            this.ButtonFreeThisTable.Size = new Size(0x1e2, 0x25);
            this.ButtonFreeThisTable.TabIndex = 0x63;
            this.ButtonFreeThisTable.Text = "فك حجز طاولة محددة";
            this.ButtonFreeThisTable.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3db, 0x277);
            base.ControlBox = false;
            base.Controls.Add(this.TableLayoutPanel1);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TextBoxCatchInvSaleTablNam);
            base.Controls.Add(this.TextBoxCatch);
            base.Controls.Add(this.TxTInvIDOpenWat);
            base.Controls.Add(this.TxTGVHoldTaName);
            base.Controls.Add(this.TxTGVFreeTaName);
            base.Controls.Add(this.TxTGVHoldTaID);
            base.Controls.Add(this.TxTGVHoldInvID);
            base.Controls.Add(this.TxTGVFreeTaID);
            base.Controls.Add(this.TxTGVFreeInvID);
            base.Controls.Add(this.ButtonUpdate);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "RestaurantTabls";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "إدارة الصالة";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.R();
            this.P();
        }

        private void A(object A, PaintEventArgs R)
        {
        }

        private void D(object A, EventArgs R)
        {
            if (Interaction.MsgBox("هل انت متأكد من فك حجز كل الطاولات؟", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE TaNNTables SET InvSaleFrontID =@InvSaleFrontID, TableIsBooking =@TableIsBooking WHERE (CenterFrontID = @CenterFrontID)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("InvSaleFrontID", DBNull.Value);
                    command.Parameters.AddWithValue("TableIsBooking", false);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.R();
                    this.P();
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
            Interaction.MsgBox("الأن اضغط على الطاولة المطلوب فك حزها", MsgBoxStyle.ApplicationModal, null);
            this.A = true;
        }

        private void I(object A, EventArgs R)
        {
            this.R();
            this.P();
        }

        public void P()
        {
            // Invalid method body.
        }

        private void P(object A, EventArgs R)
        {
            // Invalid method body.
        }

        public void Q()
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
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

        internal virtual TextBox TextBoxCatchInvSaleTablNam
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TextBoxCatch
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTInvIDOpenWat
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTGVHoldTaName
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTGVFreeTaName
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox TxTGVHoldTaID
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox TxTGVHoldInvID
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual TextBox TxTGVFreeTaID
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox TxTGVFreeInvID
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual FlowLayoutPanel FlowLayoutPanel1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual FlowLayoutPanel FlowLayoutPanel2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                PaintEventHandler handler = new PaintEventHandler(this.A);
                FlowLayoutPanel r = this.R;
                if (r != null)
                {
                    r.Paint -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.Paint += handler;
                }
            }
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual Button ButtonUpdate
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

        internal virtual Button ButtonFreeAllTable
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

        internal virtual Button ButtonFreeThisTable
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                Button q = this.Q;
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
    }
}

