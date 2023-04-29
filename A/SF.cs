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
    public class SF : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonDelete")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GV"), CompilerGenerated]
        private DataGridView A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("TxTTableName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [CompilerGenerated, AccessedThroughProperty("ButtonAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("GroupBox1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTTableID")]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose"), CompilerGenerated]
        private Button P;
        private SqlConnection A;
        private DataSet A;
        private string A;

        public SF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = new DataSet();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.ButtonDelete = new Button();
            this.GV = new DataGridView();
            this.TxTTitle = new Label();
            this.TxTTableName = new TextBox();
            this.ButtonAdd = new Button();
            this.GroupBox1 = new GroupBox();
            this.TxTTableID = new TextBox();
            this.ButtonClose = new Button();
            ((ISupportInitialize) this.GV).BeginInit();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.ButtonDelete.BackColor = Color.FromArgb(0xff, 0xc0, 0xc0);
            this.ButtonDelete.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDelete.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDelete.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDelete.FlatStyle = FlatStyle.Flat;
            this.ButtonDelete.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDelete.Image = F.ImDelete;
            this.ButtonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new Point(13, 0x12e);
            this.ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new Size(0xb5, 0x2c);
            this.ButtonDelete.TabIndex = 0x4d;
            this.ButtonDelete.Text = "حذف المحدد";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Dock = DockStyle.Top;
            this.GV.Location = new Point(0, 0x2f);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x1fb, 170);
            this.GV.TabIndex = 80;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1fb, 0x2f);
            this.TxTTitle.TabIndex = 0x4f;
            this.TxTTitle.Text = "إدارة طاولات الطعام";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTTableName.BackColor = SystemColors.Info;
            this.TxTTableName.Location = new Point(0xbd, 0x1f);
            this.TxTTableName.MaxLength = 20;
            this.TxTTableName.Name = "TxTTableName";
            this.TxTTableName.Size = new Size(280, 0x17);
            this.TxTTableName.TabIndex = 0x1f;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Flat;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.Image = F.ImAdd;
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(6, 0x17);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0xa4, 0x26);
            this.ButtonAdd.TabIndex = 0x1d;
            this.ButtonAdd.Text = "اضافة";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.TxTTableName);
            this.GroupBox1.Controls.Add(this.ButtonAdd);
            this.GroupBox1.Location = new Point(12, 0xdf);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x1e6, 0x48);
            this.GroupBox1.TabIndex = 0x4c;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "اسم/ ترميز/ رقم الطاولة";
            this.TxTTableID.Location = new Point(12, 0x18a);
            this.TxTTableID.Name = "TxTTableID";
            this.TxTTableID.Size = new Size(100, 0x17);
            this.TxTTableID.TabIndex = 0x51;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImFinish;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(200, 0x12e);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x12a, 0x2c);
            this.ButtonClose.TabIndex = 0x4e;
            this.ButtonClose.Text = "انهاء";
            this.ButtonClose.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonAdd;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x1fb, 0x161);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonDelete);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.TxTTableID);
            base.Controls.Add(this.ButtonClose);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "RestaurantTaSetting";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "إدارة طاولات الطعام";
            ((ISupportInitialize) this.GV).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
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

        private void P(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void Q(object A, EventArgs R)
        {
            if (this.TxTTableName.Text.Trim() == "")
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO TaNNTables (CenterFrontID, TableName) VALUES (@CenterFrontID, @TableName)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("TableName", this.TxTTableName.Text.Trim());
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.R();
                    this.TxTTableName.Text = "";
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

        private void R()
        {
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            this.A = "SELECT * FROM TaNNTables WHERE (CenterFrontID = @CenterFrontID)";
            this.A.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
            adapter.Fill(this.A, "TaNNTables");
            this.A.Close();
            this.TxTTableID.DataBindings.Clear();
            this.TxTTableID.DataBindings.Add("Text", this.A, "TaNNTables.TableID");
            this.GV.DataSource = this.A;
            this.GV.DataMember = "TaNNTables";
            this.GV.Refresh();
            this.GV.Columns["TableID"].Visible = false;
            this.GV.Columns["CenterFrontID"].Visible = false;
            this.GV.Columns["InvSaleFrontID"].Visible = false;
            this.GV.Columns["TableName"].HeaderText = "اسم/ ترميز/ رقم الطاولة";
            this.GV.Columns["TableIsBooking"].Visible = false;
            this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ButtonDelete.Enabled = this.GV.RowCount > 0;
        }

        private void R(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNTables WHERE (TableID = @TableID)", this.A);
                    command.Parameters.AddWithValue("TableID", this.TxTTableID.Text);
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

        internal virtual Button ButtonDelete
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual TextBox TxTTableName
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTTableID
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonClose
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
    }
}

