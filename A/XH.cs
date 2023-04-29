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
    public class XH : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GV"), CompilerGenerated]
        private DataGridView A;
        [AccessedThroughProperty("ButtonOk"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose")]
        private Button R;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1")]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("TxTGropEdit"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        private SqlConnection A;
        public static string A;
        private TextBox R;
        private TextBox P;
        private TextBox Q;
        private TextBox I;
        private TextBox D;
        private TextBox F;
        private TextBox H;
        private TextBox T;
        private TextBox X;
        private CheckBox A;
        private TextBox G;
        private TextBox E;
        private CheckBox R;
        private TextBox K;
        private TextBox U;
        private TextBox L;
        private TextBox N;
        private TextBox V;
        private TextBox Y;
        private TextBox O;

        public XH()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.R = new TextBox();
            this.P = new TextBox();
            this.Q = new TextBox();
            this.I = new TextBox();
            this.D = new TextBox();
            this.F = new TextBox();
            this.H = new TextBox();
            this.T = new TextBox();
            this.X = new TextBox();
            this.A = new CheckBox();
            this.G = new TextBox();
            this.E = new TextBox();
            this.R = new CheckBox();
            this.K = new TextBox();
            this.U = new TextBox();
            this.L = new TextBox();
            this.N = new TextBox();
            this.V = new TextBox();
            this.Y = new TextBox();
            this.O = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label1 = new Label();
            this.GV = new DataGridView();
            this.TxTTitle = new Label();
            this.ButtonOk = new Button();
            this.ButtonClose = new Button();
            this.GroupBox1 = new GroupBox();
            this.TxTGropEdit = new TextBox();
            ((ISupportInitialize) this.GV).BeginInit();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.DarkGreen;
            this.Label1.Location = new Point(0, 0x29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x32c, 0x27);
            this.Label1.TabIndex = 0x4f;
            this.Label1.Text = "المادة ذات الوحدة الأكبر المرتبطة مع المادة المطلوب تزويدها بالحبات";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Dock = DockStyle.Top;
            this.GV.Location = new Point(0, 80);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x32c, 180);
            this.GV.TabIndex = 0x4e;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x32c, 0x29);
            this.TxTTitle.TabIndex = 0x4b;
            this.TxTTitle.Text = "تزويد وترحيل الكميات بين الوحدات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(320, 0x11c);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x16b, 0x2c);
            this.ButtonOk.TabIndex = 0x4d;
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
            this.ButtonClose.Location = new Point(0x2b1, 0x11c);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x73, 0x2c);
            this.ButtonClose.TabIndex = 0x4c;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.TxTGropEdit);
            this.GroupBox1.Location = new Point(4, 0x116);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(310, 50);
            this.GroupBox1.TabIndex = 80;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "عدد الكراتين المطلوب فتحها";
            this.TxTGropEdit.BackColor = SystemColors.Info;
            this.TxTGropEdit.Dock = DockStyle.Fill;
            this.TxTGropEdit.Location = new Point(3, 0x13);
            this.TxTGropEdit.MaxLength = 20;
            this.TxTGropEdit.Name = "TxTGropEdit";
            this.TxTGropEdit.RightToLeft = RightToLeft.No;
            this.TxTGropEdit.Size = new Size(0x130, 0x17);
            this.TxTGropEdit.TabIndex = 0x1c;
            this.TxTGropEdit.Text = "1";
            this.TxTGropEdit.TextAlign = HorizontalAlignment.Center;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x32c, 340);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleQuantityOpen";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تزويد وترحيل الكميات بين الوحدات";
            ((ISupportInitialize) this.GV).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
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
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialBarCode] = @MaterialBarCode)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.SelectCommand.Parameters.AddWithValue("MaterialBarCode", XH.A.ToString());
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    Interaction.MsgBox("لم يتم العثور على المادة في المستودع", MsgBoxStyle.ApplicationModal, null);
                    A.D.A.A.TimerFocus.Enabled = true;
                    base.Dispose();
                }
                else
                {
                    this.R.Text = dataTable.Rows[0]["MaterialID"].ToString();
                    this.P.Text = dataTable.Rows[0]["GroupIDFrontID"].ToString();
                    this.Q.Text = dataTable.Rows[0]["MaterialBarCode"].ToString();
                    this.I.Text = dataTable.Rows[0]["MaterialName"].ToString();
                    this.D.Text = dataTable.Rows[0]["MaterialQuantity"].ToString();
                    this.F.Text = dataTable.Rows[0]["MaterialUnit"].ToString();
                    this.H.Text = dataTable.Rows[0]["MaterialPricCost"].ToString();
                    this.T.Text = dataTable.Rows[0]["MaterialPricLess"].ToString();
                    this.X.Text = dataTable.Rows[0]["MaterialPricSale"].ToString();
                    this.A.Checked = Conversions.ToBoolean(dataTable.Rows[0]["MaterialIsStop"].ToString());
                    this.G.Text = dataTable.Rows[0]["MaterialExpDate"].ToString();
                    this.E.Text = dataTable.Rows[0]["MaterialNote"].ToString();
                    this.R.Checked = Conversions.ToBoolean(dataTable.Rows[0]["MaterialNotIsView"].ToString());
                    this.K.Text = dataTable.Rows[0]["MaterialQuantityOffer"].ToString();
                    this.U.Text = dataTable.Rows[0]["MaterialDisMiWi"].ToString();
                    this.L.Text = dataTable.Rows[0]["MaterialDarMiWi"].ToString();
                    this.V.Text = dataTable.Rows[0]["MaterialQuantityPakeg"].ToString();
                    this.N.Text = dataTable.Rows[0]["MaterialOtherBarCode"].ToString();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable table2 = new DataTable();
                    string str2 = "SELECT TOP(1) [MaterialID], [MaterialQuantity], [MaterialBarCode], [MaterialName], [MaterialUnit], [MaterialPricSale] FROM [TaNNMaterial] WHERE ([CenterFrontID] = @CenterFrontID) And ([MaterialBarCode] = @MaterialBarCode)";
                    table2.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    adapter2.SelectCommand.Parameters.AddWithValue("MaterialBarCode", this.N.Text);
                    adapter2.Fill(table2);
                    this.A.Close();
                    if (table2.Rows.Count <= 0)
                    {
                        Interaction.MsgBox("لا يوجد ربط بين الوحدات او لم يتم تحديد المادة ذات الوحدة الأكبر لهذه المادة", MsgBoxStyle.ApplicationModal, null);
                        A.D.A.A.TimerFocus.Enabled = true;
                        base.Dispose();
                    }
                    else
                    {
                        this.Y.Text = table2.Rows[0]["MaterialID"].ToString();
                        this.O.Text = table2.Rows[0]["MaterialQuantity"].ToString();
                        this.GV.DataSource = table2;
                        this.GV.Refresh();
                        this.GV.Columns["MaterialID"].Visible = false;
                        this.GV.Columns["MaterialQuantity"].Visible = false;
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

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890".Contains(R.KeyChar.ToString().ToLower()))
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
                else if (!(Conversion.Val(this.O.Text.Replace(",", "")) != 0.0))
                {
                    Interaction.MsgBox("الكمية الحالية للمادة ذات الوحدة الأكبر هي 0", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    decimal num = new decimal(Conversion.Val(this.TxTGropEdit.Text.Replace(",", "")));
                    decimal num2 = new decimal(Conversion.Val(this.D.Text.Replace(",", "")) + (Conversion.Val(this.V.Text.Replace(",", "")) * Convert.ToDouble(num)));
                    decimal num3 = new decimal(Conversion.Val(this.O.Text.Replace(",", "")) - Convert.ToDouble(num));
                    if (Conversion.Val(this.V.Text.Replace(",", "")) == 0.0)
                    {
                        Interaction.MsgBox("لم يتم تحديد عدد الحبات/القطع الموجودة في المادة ذات الوحدة الأكبر ليتم ترحيلها", MsgBoxStyle.ApplicationModal, null);
                    }
                    else
                    {
                        string[] textArray1 = new string[9];
                        textArray1[0] = "سيتم ترحيل  ";
                        textArray1[1] = Conversions.ToString(Conversion.Val(this.V.Text.Replace(",", "")));
                        textArray1[2] = " حبة/قطعة";
                        textArray1[3] = Environment.NewLine;
                        textArray1[4] = "من عدد الكراتين المطلوب فتحها ";
                        textArray1[5] = Conversions.ToString(num);
                        textArray1[6] = Environment.NewLine;
                        textArray1[7] = "الأجمالي ";
                        textArray1[8] = Conversions.ToString((double) (Conversion.Val(this.V.Text.Replace(",", "")) * Convert.ToDouble(num)));
                        if (Interaction.MsgBox(string.Concat(textArray1).ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
                        {
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                            command.Parameters.AddWithValue("MaterialID", this.R.Text);
                            command.Parameters.AddWithValue("MaterialQuantity", num2.ToString(PR.OR));
                            SqlCommand command2 = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                            command2.Parameters.AddWithValue("MaterialID", this.Y.Text);
                            command2.Parameters.AddWithValue("MaterialQuantity", num3.ToString(PR.OR));
                            command.ExecuteNonQuery();
                            command2.ExecuteNonQuery();
                            this.A.Close();
                            Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                            if (Application.OpenForms.OfType<QF>().Any<QF>())
                            {
                                A.D.A.A.TimerLoadData.Enabled = true;
                            }
                            base.Dispose();
                        }
                    }
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

        internal virtual Label Label1
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

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual TextBox TxTGropEdit
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                TextBox a = this.A;
                if (a != null)
                {
                    a.KeyPress -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.KeyPress += handler;
                }
            }
        }
    }
}

