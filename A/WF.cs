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
    public class WF : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOk"), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GV")]
        private DataGridView A;
        private SqlConnection A;
        public static int A = 0;
        private TextBox A;
        private TextBox R;
        private TextBox P;
        private TextBox Q;
        private TextBox I;
        private TextBox D;
        private TextBox F;
        private TextBox H;
        private TextBox T;
        private CheckBox A;
        private TextBox X;
        private TextBox G;
        private CheckBox R;
        private TextBox E;
        private TextBox K;
        private TextBox U;
        private TextBox L;
        private TextBox N;
        private TextBox V;
        private TextBox Y;
        private TextBox O;
        private TextBox B;
        private TextBox S;
        private TextBox Z;
        private TextBox M;
        private TextBox C;
        private TextBox J;
        private CheckBox P;
        private TextBox W;

        public WF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new TextBox();
            this.R = new TextBox();
            this.P = new TextBox();
            this.Q = new TextBox();
            this.I = new TextBox();
            this.D = new TextBox();
            this.F = new TextBox();
            this.H = new TextBox();
            this.T = new TextBox();
            this.A = new CheckBox();
            this.X = new TextBox();
            this.G = new TextBox();
            this.R = new CheckBox();
            this.E = new TextBox();
            this.K = new TextBox();
            this.U = new TextBox();
            this.L = new TextBox();
            this.N = new TextBox();
            this.V = new TextBox();
            this.Y = new TextBox();
            this.O = new TextBox();
            this.B = new TextBox();
            this.S = new TextBox();
            this.Z = new TextBox();
            this.M = new TextBox();
            this.C = new TextBox();
            this.J = new TextBox();
            this.P = new CheckBox();
            this.W = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.TxTTitle = new Label();
            this.ButtonOk = new Button();
            this.ButtonClose = new Button();
            this.Label1 = new Label();
            this.GV = new DataGridView();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x33a, 0x29);
            this.TxTTitle.TabIndex = 70;
            this.TxTTitle.Text = "تبديل الوحدة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(12, 0x11d);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x2a9, 0x2c);
            this.ButtonOk.TabIndex = 0x48;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x2bb, 0x11d);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x73, 0x2c);
            this.ButtonClose.TabIndex = 0x47;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.DarkGreen;
            this.Label1.Location = new Point(0, 0x29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x33a, 0x29);
            this.Label1.TabIndex = 0x4a;
            this.Label1.Text = "تم فرز المواد التالية حسب تطابق اسم المادة المطلوب استبدالها";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
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
            this.GV.Location = new Point(0, 0x52);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x33a, 0xc4);
            this.GV.TabIndex = 0x1ed36ce;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x33a, 0x151);
            base.ControlBox = false;
            base.Controls.Add(this.GV);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleEditeChangeUint";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تبديل الوحدة";
            ((ISupportInitialize) this.GV).EndInit();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            QH.Q = true;
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNInvSaleItems] WHERE ([HSaleID] = @HSaleID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("HSaleID", WF.A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    Interaction.MsgBox("خطأ في تحديد المادة من الفاتورة", MsgBoxStyle.ApplicationModal, null);
                    A.D.A.A.TimerFocus.Enabled = true;
                    base.Dispose();
                }
                else
                {
                    this.L.Text = dataTable.Rows[0]["HSaleID"].ToString();
                    this.N.Text = dataTable.Rows[0]["HSaleBarCode"].ToString();
                    this.V.Text = dataTable.Rows[0]["HSaleName"].ToString();
                    this.Y.Text = dataTable.Rows[0]["HSalePrice"].ToString();
                    this.O.Text = dataTable.Rows[0]["HSaleQuantity"].ToString();
                    this.B.Text = dataTable.Rows[0]["HSalePriceTotal"].ToString();
                    this.S.Text = dataTable.Rows[0]["HSaleDisMiaWi"].ToString();
                    this.Z.Text = dataTable.Rows[0]["HSaleDisVal"].ToString();
                    this.M.Text = dataTable.Rows[0]["HSaleDarMiaWi"].ToString();
                    this.C.Text = dataTable.Rows[0]["HSaleDarVal"].ToString();
                    this.J.Text = dataTable.Rows[0]["HSaleNetProft"].ToString();
                    this.P.Checked = Conversions.ToBoolean(dataTable.Rows[0]["HSaleIsDelete"].ToString());
                    this.W.Text = dataTable.Rows[0]["HSaleNETTotal"].ToString();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable table2 = new DataTable();
                    string str2 = "SELECT TOP(1) * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialBarCode] = @MaterialBarCode)";
                    table2.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    adapter2.SelectCommand.Parameters.AddWithValue("MaterialBarCode", this.N.Text);
                    adapter2.Fill(table2);
                    this.A.Close();
                    if (table2.Rows.Count <= 0)
                    {
                        Interaction.MsgBox("لم يتم العثور على المادة في المستودع", MsgBoxStyle.ApplicationModal, null);
                        A.D.A.A.TimerFocus.Enabled = true;
                        base.Dispose();
                    }
                    else
                    {
                        this.A.Text = table2.Rows[0]["MaterialID"].ToString();
                        this.R.Text = table2.Rows[0]["GroupIDFrontID"].ToString();
                        this.P.Text = table2.Rows[0]["MaterialBarCode"].ToString();
                        this.Q.Text = table2.Rows[0]["MaterialName"].ToString();
                        this.I.Text = table2.Rows[0]["MaterialQuantity"].ToString();
                        this.D.Text = table2.Rows[0]["MaterialUnit"].ToString();
                        this.F.Text = table2.Rows[0]["MaterialPricCost"].ToString();
                        this.H.Text = table2.Rows[0]["MaterialPricLess"].ToString();
                        this.T.Text = table2.Rows[0]["MaterialPricSale"].ToString();
                        this.A.Checked = Conversions.ToBoolean(table2.Rows[0]["MaterialIsStop"].ToString());
                        this.X.Text = table2.Rows[0]["MaterialExpDate"].ToString();
                        this.G.Text = table2.Rows[0]["MaterialNote"].ToString();
                        this.R.Checked = Conversions.ToBoolean(table2.Rows[0]["MaterialNotIsView"].ToString());
                        this.E.Text = table2.Rows[0]["MaterialQuantityOffer"].ToString();
                        this.K.Text = table2.Rows[0]["MaterialDisMiWi"].ToString();
                        this.U.Text = table2.Rows[0]["MaterialDarMiWi"].ToString();
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        DataTable table3 = new DataTable();
                        string str3 = "SELECT [MaterialBarCode], [MaterialName], [MaterialUnit], [MaterialPricSale] FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID) AND (MaterialName = @MaterialName) AND (MaterialUnit <> @MaterialUnit)";
                        table3.Clear();
                        SqlDataAdapter adapter3 = new SqlDataAdapter(str3, this.A);
                        adapter3.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                        adapter3.SelectCommand.Parameters.AddWithValue("MaterialName", this.Q.Text);
                        adapter3.SelectCommand.Parameters.AddWithValue("MaterialUnit", this.D.Text);
                        adapter3.Fill(table3);
                        this.A.Close();
                        this.GV.DataSource = table3;
                        this.GV.Refresh();
                        this.GV.Columns["MaterialBarCode"].HeaderText = "باركود/رقم";
                        this.GV.Columns["MaterialName"].HeaderText = "المادة/ الوصف";
                        this.GV.Columns["MaterialUnit"].HeaderText = "الوحدة";
                        this.GV.Columns["MaterialPricSale"].HeaderText = "السعر";
                        this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                A.D.A.A.TimerFocus.Enabled = true;
                base.Dispose();
                ProjectData.ClearProjectError();
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

        private void P(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void R(object A, EventArgs R)
        {
            try
            {
                if (Information.IsNothing(this.GV.CurrentRow))
                {
                    Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    A.D.A.A.TxTBarCode.Text = this.GV.SelectedRows[0].Cells["MaterialBarCode"].Value.ToString();
                    AH.A = WF.A;
                    A.D.A.A.Show();
                    A.D.A.A.D();
                    base.Dispose();
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

        internal virtual Label TxTTitle
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

        internal virtual Button ButtonClose
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

        internal virtual Label Label1
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
    }
}

