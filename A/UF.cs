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
    public class UF : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("Label5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("ComboBoxTyp"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [CompilerGenerated, AccessedThroughProperty("Label4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label2"), CompilerGenerated]
        private Label I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CurenSaleXchange"), CompilerGenerated]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonDelete")]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("ButtonAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label3")]
        private Label D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTCurName")]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonClose")]
        private Button P;
        [CompilerGenerated, AccessedThroughProperty("TxTCurenID"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GV")]
        private DataGridView A;
        private SqlConnection A;
        private DataSet A;
        private string A;

        public UF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = new DataSet();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(UF));
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TxTTitle = new Label();
            this.Label1 = new Label();
            this.Label5 = new Label();
            this.ComboBoxTyp = new ComboBox();
            this.Label4 = new Label();
            this.Label2 = new Label();
            this.CurenSaleXchange = new TextBox();
            this.ButtonDelete = new Button();
            this.ButtonAdd = new Button();
            this.Label3 = new Label();
            this.TxTCurName = new TextBox();
            this.ButtonClose = new Button();
            this.TxTCurenID = new TextBox();
            this.GV = new DataGridView();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x293, 0x27);
            this.TxTTitle.TabIndex = 0x45;
            this.TxTTitle.Text = "إدارة العملات الاخرى";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Location = new Point(0, 0x27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x293, 0x30);
            this.Label1.TabIndex = 0x4c;
            this.Label1.Text = manager.GetString("Label1.Text");
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.Label5.AutoSize = true;
            this.Label5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label5.Location = new Point(0x11a, 0x14b);
            this.Label5.Name = "Label5";
            this.Label5.Size = new Size(0x45, 0x10);
            this.Label5.TabIndex = 0x5c;
            this.Label5.Text = "سعر الصرف";
            this.ComboBoxTyp.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxTyp.FormattingEnabled = true;
            object[] items = new object[] { "*", "/" };
            this.ComboBoxTyp.Items.AddRange(items);
            this.ComboBoxTyp.Location = new Point(0xb3, 0x148);
            this.ComboBoxTyp.Name = "ComboBoxTyp";
            this.ComboBoxTyp.RightToLeft = RightToLeft.No;
            this.ComboBoxTyp.Size = new Size(0x61, 0x18);
            this.ComboBoxTyp.TabIndex = 0x55;
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.Location = new Point(0x38, 0x14b);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x6b, 0x10);
            this.Label4.TabIndex = 0x5b;
            this.Label4.Text = "احسب المعادلة ب";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0x5e, 0x12e);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x45, 0x10);
            this.Label2.TabIndex = 90;
            this.Label2.Text = "سعر الصرف";
            this.CurenSaleXchange.BackColor = SystemColors.Info;
            this.CurenSaleXchange.Location = new Point(0xb3, 0x12b);
            this.CurenSaleXchange.MaxLength = 20;
            this.CurenSaleXchange.Name = "CurenSaleXchange";
            this.CurenSaleXchange.RightToLeft = RightToLeft.No;
            this.CurenSaleXchange.Size = new Size(0xd5, 0x17);
            this.CurenSaleXchange.TabIndex = 0x54;
            this.CurenSaleXchange.TextAlign = HorizontalAlignment.Center;
            this.ButtonDelete.BackColor = Color.FromArgb(0xff, 0xc0, 0xc0);
            this.ButtonDelete.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDelete.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDelete.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDelete.FlatStyle = FlatStyle.Flat;
            this.ButtonDelete.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDelete.Image = F.ImDelete;
            this.ButtonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new Point(0x18e, 270);
            this.ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new Size(0xf8, 0x51);
            this.ButtonDelete.TabIndex = 0x59;
            this.ButtonDelete.Text = "حذف العملة المحددة";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Flat;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.Image = F.ImAdd;
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(0xb3, 0x167);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0xd5, 0x26);
            this.ButtonAdd.TabIndex = 0x57;
            this.ButtonAdd.Text = "اضافة";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.Location = new Point(0x2f, 0x111);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x74, 0x10);
            this.Label3.TabIndex = 0x58;
            this.Label3.Text = "اسم العملة الاجنبية";
            this.TxTCurName.BackColor = SystemColors.Info;
            this.TxTCurName.Location = new Point(0xb3, 270);
            this.TxTCurName.MaxLength = 20;
            this.TxTCurName.Name = "TxTCurName";
            this.TxTCurName.Size = new Size(0xd5, 0x17);
            this.TxTCurName.TabIndex = 0x53;
            this.TxTCurName.TextAlign = HorizontalAlignment.Center;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImFinish;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x18e, 0x167);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xf8, 0x26);
            this.ButtonClose.TabIndex = 0x56;
            this.ButtonClose.Text = "انهاء";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.TxTCurenID.Location = new Point(0xfb, 0x202);
            this.TxTCurenID.Name = "TxTCurenID";
            this.TxTCurenID.Size = new Size(100, 0x17);
            this.TxTCurenID.TabIndex = 0x5d;
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
            this.GV.Location = new Point(0, 0x57);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x293, 0xb0);
            this.GV.TabIndex = 0x1ed36ce;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x293, 0x195);
            base.ControlBox = false;
            base.Controls.Add(this.GV);
            base.Controls.Add(this.TxTCurenID);
            base.Controls.Add(this.Label5);
            base.Controls.Add(this.ComboBoxTyp);
            base.Controls.Add(this.Label4);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.CurenSaleXchange);
            base.Controls.Add(this.ButtonDelete);
            base.Controls.Add(this.ButtonAdd);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.TxTCurName);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "OtherCurenList";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "إدارة العملات الآخرى";
            ((ISupportInitialize) this.GV).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.R();
            this.ComboBoxTyp.SelectedIndex = 0;
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
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

        private void I(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNOtherCuren WHERE (CurenID = @CurenID)", this.A);
                    command.Parameters.AddWithValue("CurenID", this.TxTCurenID.Text);
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

        private void P(object A, EventArgs R)
        {
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void R()
        {
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            this.A = "SELECT * FROM TaNNOtherCuren WHERE (CenterFrontID = @CenterFrontID)";
            this.A.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
            adapter.Fill(this.A, "TaNNOtherCuren");
            this.A.Close();
            this.TxTCurenID.DataBindings.Clear();
            this.TxTCurenID.DataBindings.Add("Text", this.A, "TaNNOtherCuren.CurenID");
            this.GV.DataSource = this.A;
            this.GV.DataMember = "TaNNOtherCuren";
            this.GV.Refresh();
            this.GV.Columns["CurenID"].Visible = false;
            this.GV.Columns["CenterFrontID"].Visible = false;
            this.GV.Columns["CurenName"].HeaderText = "العملة";
            this.GV.Columns["CurenSaleXchange"].HeaderText = "سعر الصرف";
            this.GV.Columns["Calculater"].HeaderText = "المعادلة ( * ضرب) - ( / قسمة)";
            this.ButtonDelete.Enabled = this.GV.RowCount > 0;
            this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void R(object A, EventArgs R)
        {
            if ((this.TxTCurName.Text == null) | (this.CurenSaleXchange.Text == null))
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
                    SqlCommand command = new SqlCommand("INSERT INTO TaNNOtherCuren (CenterFrontID, CurenName, CurenSaleXchange, Calculater) VALUES (@CenterFrontID, @CurenName, @CurenSaleXchange, @Calculater)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("CurenName", this.TxTCurName.Text.Trim());
                    command.Parameters.AddWithValue("CurenSaleXchange", this.CurenSaleXchange.Text.Trim());
                    command.Parameters.AddWithValue("Calculater", this.ComboBoxTyp.Text);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.R();
                    this.TxTCurName.Text = null;
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

        internal virtual Label TxTTitle
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label5
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual ComboBox ComboBoxTyp
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox CurenSaleXchange
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual Button ButtonDelete
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

        internal virtual Button ButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox TxTCurName
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
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual TextBox TxTCurenID
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

