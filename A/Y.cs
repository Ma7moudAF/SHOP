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
    public class Y : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTCenterSubNameMaster"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose")]
        private Button A;
        [AccessedThroughProperty("ButtonSave"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1"), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTCenterID"), CompilerGenerated]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTCenterSubName")]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label2"), CompilerGenerated]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTCenterIDADD"), CompilerGenerated]
        private TextBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTtCenterSubNameADD"), CompilerGenerated]
        private TextBox I;
        [CompilerGenerated, AccessedThroughProperty("Label4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [AccessedThroughProperty("Label7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TabControl1")]
        private TabControl A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage2")]
        private TabPage R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonAdd")]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label3")]
        private Label I;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GV")]
        private DataGridView A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label D;
        [AccessedThroughProperty("LabelCC"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label F;
        private SqlConnection A;
        private DataSet A;
        private string A;
        private bool A;

        public Y()
        {
            base.Load += new EventHandler(this.R);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = new DataSet();
            this.A = false;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTCenterSubNameMaster = new TextBox();
            this.ButtonClose = new Button();
            this.ButtonSave = new Button();
            this.TabPage1 = new TabPage();
            this.LabelCC = new Label();
            this.Label1 = new Label();
            this.TxTCenterSubName = new TextBox();
            this.Label2 = new Label();
            this.TxTCenterID = new TextBox();
            this.TxTCenterIDADD = new TextBox();
            this.TxTtCenterSubNameADD = new TextBox();
            this.Label4 = new Label();
            this.Label7 = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage2 = new TabPage();
            this.ButtonAdd = new Button();
            this.Label3 = new Label();
            this.GV = new DataGridView();
            this.TxTTitle = new Label();
            this.TabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.TxTCenterSubNameMaster.BackColor = SystemColors.Info;
            this.TxTCenterSubNameMaster.Enabled = false;
            this.TxTCenterSubNameMaster.Location = new Point(300, 0x245);
            this.TxTCenterSubNameMaster.Name = "TxTCenterSubNameMaster";
            this.TxTCenterSubNameMaster.Size = new Size(220, 0x17);
            this.TxTCenterSubNameMaster.TabIndex = 0x3d;
            this.TxTCenterSubNameMaster.Text = "الرئيسي";
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x1d8, 0x1df);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xde, 0x2c);
            this.ButtonClose.TabIndex = 0x3b;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonSave.Enabled = false;
            this.ButtonSave.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSave.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSave.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSave.FlatStyle = FlatStyle.Flat;
            this.ButtonSave.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSave.Image = A.F.ImSave;
            this.ButtonSave.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new Point(0x59, 0x2e);
            this.ButtonSave.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new Size(0xb5, 60);
            this.ButtonSave.TabIndex = 0x1d;
            this.ButtonSave.Text = "حفظ";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.TabPage1.Controls.Add(this.LabelCC);
            this.TabPage1.Controls.Add(this.ButtonSave);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.TxTCenterSubName);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x2ae, 0xcf);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "   تعديل   ";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.LabelCC.ForeColor = Color.FromArgb(0, 0, 0xc0);
            this.LabelCC.Location = new Point(0x128, 0x31);
            this.LabelCC.Name = "LabelCC";
            this.LabelCC.Size = new Size(0xdf, 0x13);
            this.LabelCC.TabIndex = 30;
            this.LabelCC.Text = "0000";
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0x213, 0x31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x77, 0x10);
            this.Label1.TabIndex = 0x15;
            this.Label1.Text = "رمز الفرع/ المستودع";
            this.TxTCenterSubName.BackColor = SystemColors.Info;
            this.TxTCenterSubName.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTCenterSubName.Location = new Point(0x128, 0x52);
            this.TxTCenterSubName.MaxLength = 50;
            this.TxTCenterSubName.Name = "TxTCenterSubName";
            this.TxTCenterSubName.Size = new Size(220, 0x17);
            this.TxTCenterSubName.TabIndex = 0x1c;
            this.TxTCenterSubName.Text = "الرئيسي";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0x213, 0x55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x7f, 0x10);
            this.Label2.TabIndex = 0x16;
            this.Label2.Text = "اسم الفرع/ المستودع";
            this.TxTCenterID.BackColor = SystemColors.Info;
            this.TxTCenterID.Enabled = false;
            this.TxTCenterID.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTCenterID.Location = new Point(0x4a, 0x235);
            this.TxTCenterID.MaxLength = 50;
            this.TxTCenterID.Name = "TxTCenterID";
            this.TxTCenterID.Size = new Size(220, 0x17);
            this.TxTCenterID.TabIndex = 0x1b;
            this.TxTCenterIDADD.BackColor = SystemColors.Info;
            this.TxTCenterIDADD.Enabled = false;
            this.TxTCenterIDADD.Location = new Point(0x124, 0x2d);
            this.TxTCenterIDADD.MaxLength = 50;
            this.TxTCenterIDADD.Name = "TxTCenterIDADD";
            this.TxTCenterIDADD.Size = new Size(220, 0x17);
            this.TxTCenterIDADD.TabIndex = 0x1f;
            this.TxTCenterIDADD.Text = "تلقائي";
            this.TxTtCenterSubNameADD.BackColor = SystemColors.Info;
            this.TxTtCenterSubNameADD.Location = new Point(0x124, 0x51);
            this.TxTtCenterSubNameADD.MaxLength = 50;
            this.TxTtCenterSubNameADD.Name = "TxTtCenterSubNameADD";
            this.TxTtCenterSubNameADD.Size = new Size(220, 0x17);
            this.TxTtCenterSubNameADD.TabIndex = 0x20;
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.Location = new Point(0x210, 0x54);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x85, 0x11);
            this.Label4.TabIndex = 30;
            this.Label4.Text = "اسم الفرع/ المستودع";
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label7.ForeColor = Color.Red;
            this.Label7.Location = new Point(0x1b, 490);
            this.Label7.Name = "Label7";
            this.Label7.Size = new Size(0x153, 0x13);
            this.Label7.TabIndex = 0x40;
            this.Label7.Text = "* يجب اعادة تشغيل النظام بعد تنفيذ اي اجراء هنا";
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Location = new Point(4, 0xec);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x2b6, 0xec);
            this.TabControl1.TabIndex = 0x3f;
            this.TabPage2.Controls.Add(this.ButtonAdd);
            this.TabPage2.Controls.Add(this.Label3);
            this.TabPage2.Controls.Add(this.TxTCenterIDADD);
            this.TabPage2.Controls.Add(this.TxTtCenterSubNameADD);
            this.TabPage2.Controls.Add(this.Label4);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x2ae, 0xcf);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "   اضافة   ";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Flat;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.Image = A.F.ImAdd;
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(0x3a, 0x2d);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(0xc6, 60);
            this.ButtonAdd.TabIndex = 0x1d;
            this.ButtonAdd.Text = "اضافة";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.Location = new Point(0x210, 0x30);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x7c, 0x11);
            this.Label3.TabIndex = 0x1d;
            this.Label3.Text = "رمز الفرع/ المستودع";
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Dock = DockStyle.Top;
            this.GV.Location = new Point(0, 0x25);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x2bd, 0xc1);
            this.GV.TabIndex = 0x3e;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x2bd, 0x25);
            this.TxTTitle.TabIndex = 60;
            this.TxTTitle.Text = "إدارة الفروع/ المستودعات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2bd, 0x213);
            base.ControlBox = false;
            base.Controls.Add(this.TxTCenterSubNameMaster);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTCenterID);
            base.Controls.Add(this.Label7);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CenterListManeger";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "إدارة الفروع/ المستودعات";
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            string inputStr = new SqlCommand("SELECT MAX(CenterID) FROM TaNNCenters", this.A).ExecuteScalar().ToString();
            if (Conversion.Val(inputStr) == 0.0)
            {
                inputStr = Conversions.ToString(0x44c);
            }
            else
            {
                inputStr = Conversions.ToString((int) Math.Round((double) (Conversion.Val(inputStr) + 100.0)));
            }
            if ((this.TxTCenterIDADD.Text == null) | (this.TxTtCenterSubNameADD.Text == null))
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
                    SqlCommand command2 = new SqlCommand("INSERT INTO [TaNNCenters] ([CenterID], [CenterName], [CenterSubName]) VALUES (@CenterID, @CenterName, @CenterSubName)", this.A);
                    command2.Parameters.AddWithValue("CenterID", inputStr);
                    command2.Parameters.AddWithValue("CenterName", PR.ER);
                    command2.Parameters.AddWithValue("CenterSubName", this.TxTtCenterSubNameADD.Text.Trim());
                    command2.ExecuteNonQuery();
                    this.A.Close();
                    this.R();
                    this.TxTtCenterSubNameADD.Text = null;
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

        private void A(object A, DataGridViewBindingCompleteEventArgs R)
        {
            this.ButtonSave.Enabled = this.GV.RowCount > 0;
        }

        private void A(object A, DataGridViewCellEventArgs R)
        {
        }

        private void D(object A, EventArgs R)
        {
            this.LabelCC.Text = this.TxTCenterID.Text;
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
            this.TxTCenterSubName.Text = this.TxTCenterSubNameMaster.Text;
        }

        private void P(object A, EventArgs R)
        {
            if ((this.TxTCenterID.Text.Trim() == "") | (this.TxTCenterSubName.Text.Trim() == ""))
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
                    SqlCommand command = new SqlCommand("UPDATE TaNNCenters SET CenterSubName =@CenterSubName WHERE (CenterID = @CenterID)", this.A);
                    command.Parameters.AddWithValue("CenterID", this.TxTCenterID.Text);
                    command.Parameters.AddWithValue("CenterSubName", this.TxTCenterSubName.Text);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    this.R();
                    Interaction.MsgBox("تم تنفيذ الأمر بنجاح يجب عليك إعادة تشغيل النظام", MsgBoxStyle.ApplicationModal, null);
                    this.A = true;
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

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        private void Q(object A, EventArgs R)
        {
            if (this.A)
            {
                Interaction.MsgBox("لتنفيذ التغيرات يجب عليك اعادة تشغيل النظام", MsgBoxStyle.Exclamation, null);
                ProjectData.EndApp();
            }
            base.Dispose();
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            PR.N = PR.D;
            this.R();
        }

        internal virtual TextBox TxTCenterSubNameMaster
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                TextBox a = this.A;
                if (a != null)
                {
                    a.TextChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.TextChanged += handler;
                }
            }
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

        internal virtual Button ButtonSave
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual TabPage TabPage1
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTCenterID
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                TextBox r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
                }
            }
        }

        internal virtual TextBox TxTCenterSubName
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTCenterIDADD
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTtCenterSubNameADD
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label Label7
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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
                EventHandler handler = new EventHandler(this.A);
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                DataGridViewCellEventHandler handler = new DataGridViewCellEventHandler(this.A);
                DataGridViewBindingCompleteEventHandler handler2 = new DataGridViewBindingCompleteEventHandler(this.A);
                DataGridView a = this.A;
                if (a != null)
                {
                    a.CellContentClick -= handler;
                    a.DataBindingComplete -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.CellContentClick += handler;
                    a.DataBindingComplete += handler2;
                }
            }
        }

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label LabelCC
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }
    }
}

