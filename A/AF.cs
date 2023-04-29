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
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class AF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [AccessedThroughProperty("ButtonSave"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("ButtonDelete"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("TxTGropEdit"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("TabPage2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [CompilerGenerated, AccessedThroughProperty("ButtonAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [CompilerGenerated, AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [AccessedThroughProperty("TxTGropAdd"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox R;
        [AccessedThroughProperty("TxTGropEditMaster"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [AccessedThroughProperty("TxTGroupID"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button Q;
        [AccessedThroughProperty("TabControl1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [AccessedThroughProperty("GV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        private SqlConnection A;

        public AF()
        {
            base.Load += new EventHandler(this.D);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TabPage1 = new TabPage();
            this.Label1 = new Label();
            this.ButtonSave = new Button();
            this.TxTGropEdit = new TextBox();
            this.ButtonDelete = new Button();
            this.TxTTitle = new Label();
            this.TabPage2 = new TabPage();
            this.ButtonAdd = new Button();
            this.Label3 = new Label();
            this.TxTGropAdd = new TextBox();
            this.TxTGropEditMaster = new TextBox();
            this.TxTGroupID = new TextBox();
            this.TabControl1 = new TabControl();
            this.GV = new DataGridView();
            this.ButtonClose = new Button();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabControl1.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.ButtonSave);
            this.TabPage1.Controls.Add(this.TxTGropEdit);
            this.TabPage1.Controls.Add(this.ButtonDelete);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x1e1, 0x7c);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "تعديل";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0x167, 0x1b);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(90, 0x10);
            this.Label1.TabIndex = 0x15;
            this.Label1.Text = "اسم المجموعة";
            this.ButtonSave.Enabled = false;
            this.ButtonSave.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSave.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSave.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSave.FlatStyle = FlatStyle.Flat;
            this.ButtonSave.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSave.Image = F.ImSave;
            this.ButtonSave.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new Point(0xb0, 0x39);
            this.ButtonSave.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new Size(0xae, 0x27);
            this.ButtonSave.TabIndex = 30;
            this.ButtonSave.Text = "حفظ";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.TxTGropEdit.BackColor = SystemColors.Info;
            this.TxTGropEdit.Location = new Point(0x1f, 0x1b);
            this.TxTGropEdit.MaxLength = 20;
            this.TxTGropEdit.Name = "TxTGropEdit";
            this.TxTGropEdit.Size = new Size(0x13f, 0x17);
            this.TxTGropEdit.TabIndex = 0x1b;
            this.ButtonDelete.BackColor = Color.FromArgb(0xff, 0xc0, 0xc0);
            this.ButtonDelete.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDelete.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDelete.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDelete.FlatStyle = FlatStyle.Flat;
            this.ButtonDelete.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDelete.Image = F.ImDelete;
            this.ButtonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new Point(0x1f, 0x39);
            this.ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new Size(0x8b, 40);
            this.ButtonDelete.TabIndex = 20;
            this.ButtonDelete.Text = "حذف";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1fb, 0x2f);
            this.TxTTitle.TabIndex = 0x42;
            this.TxTTitle.Text = "إدارة مجموعات المواد";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage2.Controls.Add(this.ButtonAdd);
            this.TabPage2.Controls.Add(this.Label3);
            this.TabPage2.Controls.Add(this.TxTGropAdd);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x1f3, 0x7c);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "اضافة";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Flat;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.Image = F.ImAdd;
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(100, 0x40);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(220, 0x26);
            this.ButtonAdd.TabIndex = 0x1d;
            this.ButtonAdd.Text = "اضافة";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.Location = new Point(0x151, 0x25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(90, 0x10);
            this.Label3.TabIndex = 0x1d;
            this.Label3.Text = "اسم المجموعة";
            this.TxTGropAdd.BackColor = SystemColors.Info;
            this.TxTGropAdd.Location = new Point(100, 0x22);
            this.TxTGropAdd.MaxLength = 20;
            this.TxTGropAdd.Name = "TxTGropAdd";
            this.TxTGropAdd.Size = new Size(220, 0x17);
            this.TxTGropAdd.TabIndex = 0x1f;
            this.TxTGropEditMaster.BackColor = SystemColors.Info;
            this.TxTGropEditMaster.Enabled = false;
            this.TxTGropEditMaster.Location = new Point(0xa5, 0x22f);
            this.TxTGropEditMaster.Name = "TxTGropEditMaster";
            this.TxTGropEditMaster.Size = new Size(0x125, 0x17);
            this.TxTGropEditMaster.TabIndex = 0x40;
            this.TxTGroupID.Location = new Point(0x3b, 0x22f);
            this.TxTGroupID.Name = "TxTGroupID";
            this.TxTGroupID.Size = new Size(100, 0x17);
            this.TxTGroupID.TabIndex = 0x45;
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x10f);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x1fb, 0x99);
            this.TabControl1.TabIndex = 0x44;
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
            this.GV.Location = new Point(0, 0x2f);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x1fb, 0xe0);
            this.GV.TabIndex = 0x1ed36ce;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImFinish;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(12, 0x1af);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x1e5, 0x2c);
            this.ButtonClose.TabIndex = 0x41;
            this.ButtonClose.Text = "انهاء";
            this.ButtonClose.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x1fb, 0x1dd);
            base.ControlBox = false;
            base.Controls.Add(this.TxTGropEditMaster);
            base.Controls.Add(this.TxTGroupID);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialGrop";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "إدارة مجموعات المواد";
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            if (Application.OpenForms.OfType<JD>().Any<JD>())
            {
                A.D.A.A.R();
            }
            if (Application.OpenForms.OfType<QF>().Any<QF>())
            {
                A.D.A.A.R();
            }
            base.Dispose();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonAdd.PerformClick();
            }
        }

        private void D(object A, EventArgs R)
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
            if (this.TxTGropAdd.Text == null)
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
                    SqlCommand command = new SqlCommand("INSERT INTO TaNNMaterialGroup (CenterFrontID, GroupName) VALUES (@CenterFrontID, @GroupName)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("GroupName", this.TxTGropAdd.Text.Trim());
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.R();
                    this.TxTGropAdd.Text = null;
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

        private void P(object A, EventArgs R)
        {
            if (this.TxTGropEdit.Text == null)
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
                    SqlCommand command = new SqlCommand("UPDATE TaNNMaterialGroup SET GroupName =@GroupName WHERE (GroupID = @GroupID)", this.A);
                    command.Parameters.AddWithValue("GroupID", this.TxTGroupID.Text);
                    command.Parameters.AddWithValue("GroupName", this.TxTGropEdit.Text);
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

        private void Q(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable dataTable = new DataTable();
                    string selectCommandText = "SELECT * FROM [TaNNMaterial] WHERE CenterFrontID = @CenterFrontID AND GroupIDFrontID = @GroupIDFrontID";
                    dataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    string text = this.TxTGroupID.Text;
                    adapter.SelectCommand.Parameters.AddWithValue("GroupIDFrontID", text ?? DBNull.Value);
                    adapter.Fill(dataTable);
                    this.A.Close();
                    if (dataTable.Rows.Count > 0)
                    {
                        Interaction.MsgBox("هناك مواد في المستودع مرتبطة مع هذه المجموعة لا يمكنك حذفها", MsgBoxStyle.Exclamation, null);
                    }
                    else
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("DELETE FROM TaNNMaterialGroup WHERE (GroupID = @GroupID)", this.A);
                        command.Parameters.AddWithValue("GroupID", this.TxTGroupID.Text);
                        command.ExecuteNonQuery();
                        this.A.Close();
                        this.R();
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
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
        }

        private void R()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT [GroupID], [GroupName] FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                this.A.Close();
                this.TxTGroupID.DataBindings.Clear();
                this.TxTGropEditMaster.DataBindings.Clear();
                this.TxTGroupID.DataBindings.Add("Text", dataTable, "GroupID");
                this.TxTGropEditMaster.DataBindings.Add("Text", dataTable, "GroupName");
                this.GV.DataSource = dataTable;
                this.GV.Refresh();
                this.GV.Columns["GroupID"].HeaderText = "الترميز";
                this.GV.Columns["GroupName"].HeaderText = "المجموعة";
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (this.GV.RowCount > 0)
                {
                    this.ButtonDelete.Enabled = true;
                    this.ButtonSave.Enabled = true;
                }
                else
                {
                    this.ButtonDelete.Enabled = false;
                    this.ButtonSave.Enabled = false;
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
            this.TxTGropEdit.Text = this.TxTGropEditMaster.Text;
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

        internal virtual Button ButtonSave
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonDelete
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

        internal virtual TextBox TxTGropEdit
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual Button ButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTGropAdd
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox r = this.R;
                if (r != null)
                {
                    r.KeyPress -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.KeyPress += handler;
                }
            }
        }

        internal virtual TextBox TxTGropEditMaster
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                TextBox p = this.P;
                if (p != null)
                {
                    p.TextChanged -= handler;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.TextChanged += handler;
                }
            }
        }

        internal virtual TextBox TxTGroupID
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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

        internal virtual TabControl TabControl1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

