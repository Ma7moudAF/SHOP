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
    public class XT : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtons"), CompilerGenerated]
        private ToolStrip A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonAdd")]
        private ToolStripButton A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripSeparator2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonEdit")]
        private ToolStripButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator R;
        [AccessedThroughProperty("ToolStripButtonDelete"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator P;
        [CompilerGenerated, AccessedThroughProperty("ToolStripButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripButton Q;
        [AccessedThroughProperty("ToolStripStatus"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip R;
        [AccessedThroughProperty("ToolStripSeparator1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStripSeparator Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GV"), CompilerGenerated]
        private DataGridView A;
        private SqlConnection A;

        public XT()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TxTTitle = new Label();
            this.ToolStripButtons = new ToolStrip();
            this.ToolStripButtonAdd = new ToolStripButton();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.ToolStripButtonEdit = new ToolStripButton();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.ToolStripButtonDelete = new ToolStripButton();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ToolStripButtonClose = new ToolStripButton();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.ToolStripStatus = new ToolStrip();
            this.GV = new DataGridView();
            this.ToolStripButtons.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(880, 0x29);
            this.TxTTitle.TabIndex = 0x43;
            this.TxTTitle.Text = "قائمة المستخدمين";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripButtons.AutoSize = false;
            this.ToolStripButtons.BackColor = Color.Ivory;
            this.ToolStripButtons.Dock = DockStyle.Bottom;
            this.ToolStripButtons.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripButtonAdd, this.ToolStripSeparator2, this.ToolStripButtonEdit, this.ToolStripSeparator3, this.ToolStripButtonDelete, this.ToolStripSeparator4, this.ToolStripButtonClose, this.ToolStripSeparator1 };
            this.ToolStripButtons.Items.AddRange(toolStripItems);
            this.ToolStripButtons.Location = new Point(0, 0x100);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Size = new Size(880, 0x2f);
            this.ToolStripButtons.TabIndex = 0x52;
            this.ToolStripButtonAdd.Image = F.ImUserAdd;
            this.ToolStripButtonAdd.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonAdd.Name = "ToolStripButtonAdd";
            this.ToolStripButtonAdd.Size = new Size(0x49, 0x2c);
            this.ToolStripButtonAdd.Text = "اضافة";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new Size(6, 0x2f);
            this.ToolStripButtonEdit.Image = F.ImLogin;
            this.ToolStripButtonEdit.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonEdit.Name = "ToolStripButtonEdit";
            this.ToolStripButtonEdit.Size = new Size(0xa5, 0x2c);
            this.ToolStripButtonEdit.Text = "تعديل وادارة الصلاحيات";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new Size(6, 0x2f);
            this.ToolStripButtonDelete.Image = F.ImUserDelete;
            this.ToolStripButtonDelete.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonDelete.Name = "ToolStripButtonDelete";
            this.ToolStripButtonDelete.Size = new Size(0x47, 0x2c);
            this.ToolStripButtonDelete.Text = "حذف";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new Size(6, 0x2f);
            this.ToolStripButtonClose.Image = F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x2c);
            this.ToolStripButtonClose.Text = "اغلاق";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new Size(6, 0x2f);
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            this.ToolStripStatus.Location = new Point(0, 0x12f);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(880, 0x19);
            this.ToolStripStatus.TabIndex = 0x51;
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
            this.GV.Dock = DockStyle.Top;
            this.GV.Location = new Point(0, 0x29);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(880, 0xd4);
            this.GV.TabIndex = 0x1ed36ce;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(880, 0x148);
            base.ControlBox = false;
            base.Controls.Add(this.GV);
            base.Controls.Add(this.ToolStripButtons);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "UserList";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "قائمة المستخدمين";
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
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
            base.Dispose();
        }

        private void P(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void Q(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    try
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNUsers WHERE (UserID = @UserID)", this.A);
                        command.Parameters.AddWithValue("UserID", this.GV.SelectedRows[0].Cells["UserID"].Value.ToString());
                        command.ExecuteNonQuery();
                        this.A.Close();
                        this.R();
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
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
        }

        public void R()
        {
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            DataTable dataTable = new DataTable();
            string selectCommandText = "SELECT UserID, UserName, UserLog FROM TaNNUsers WHERE (CenterFrontID = @CenterFrontID) AND (UserID <> @UserID)";
            dataTable.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
            adapter.SelectCommand.Parameters.AddWithValue("UserID", "1000000");
            adapter.Fill(dataTable);
            this.A.Close();
            this.GV.DataSource = dataTable;
            this.GV.Refresh();
            this.GV.Columns["UserID"].Visible = false;
            this.GV.Columns["UserName"].HeaderText = "الاسم";
            this.GV.Columns["UserLog"].HeaderText = "رمز الدخول";
            this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (this.GV.RowCount > 0)
            {
                this.ToolStripButtonEdit.Enabled = true;
                this.ToolStripButtonDelete.Enabled = true;
            }
            else
            {
                this.ToolStripButtonEdit.Enabled = false;
                this.ToolStripButtonDelete.Enabled = false;
            }
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

        internal virtual ToolStrip ToolStripButtons
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ToolStripButtonAdd
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

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ToolStripButtonEdit
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ToolStripButton ToolStripButtonDelete
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                ToolStripButton p = this.P;
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

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ToolStripButton ToolStripButtonClose
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                ToolStripButton q = this.Q;
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

        internal virtual ToolStrip ToolStripStatus
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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
    }
}

