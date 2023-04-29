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
    public class AH : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("LaTip")]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonClose")]
        private Button A;
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

        public AH()
        {
            base.Load += new EventHandler(this.A);
            base.FormClosed += new FormClosedEventHandler(this.A);
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
            this.TxTTitle = new Label();
            this.LaTip = new Label();
            this.ButtonClose = new Button();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x272, 0x29);
            this.TxTTitle.TabIndex = 0x45;
            this.TxTTitle.Text = "الغاء بيع";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.LaTip.Dock = DockStyle.Top;
            this.LaTip.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LaTip.ForeColor = Color.Red;
            this.LaTip.Location = new Point(0, 0x29);
            this.LaTip.Name = "LaTip";
            this.LaTip.Size = new Size(0x272, 0x40);
            this.LaTip.TabIndex = 70;
            this.LaTip.Text = "لم يتم منحك المدير العام صلاحيات الغاء المواد المباعة، يمكنك فقط تعديل الكمية لتكون 0 بدلا من حذفها نهائياً من سجل الفاتورة";
            this.LaTip.TextAlign = ContentAlignment.MiddleCenter;
            this.LaTip.Visible = false;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(12, 0x76);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x25a, 0x2c);
            this.ButtonClose.TabIndex = 0x47;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x272, 0xae);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.LaTip);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleEditeCanceItems";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "الغاء بيع";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            QH.Q = true;
            if (!PR.BR)
            {
                this.LaTip.Visible = true;
            }
            else
            {
                this.R();
                this.LaTip.Visible = false;
            }
        }

        private void A(object A, FormClosedEventArgs R)
        {
            base.Dispose();
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

        public void P()
        {
            try
            {
                decimal num = 0M;
                if (A.D.A.A.InvSaleType.SelectedIndex == 0)
                {
                    num = new decimal(Conversion.Val(this.I.Text.Replace(",", "")) + Conversion.Val(this.O.Text.Replace(",", "")));
                }
                else if (A.D.A.A.InvSaleType.SelectedIndex == 1)
                {
                    num = new decimal(Conversion.Val(this.I.Text.Replace(",", "")) - Conversion.Val(this.O.Text.Replace(",", "")));
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [TaNNMaterial] SET [MaterialQuantity] = @MaterialQuantity WHERE [MaterialID] = @MaterialID", this.A);
                command.Parameters.AddWithValue("MaterialID", this.A.Text);
                command.Parameters.AddWithValue("MaterialQuantity", num.ToString(PR.OR));
                command.ExecuteNonQuery();
                this.A.Close();
                this.Q();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
                ProjectData.ClearProjectError();
            }
        }

        public void Q()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                int num = (int) Math.Round(Conversion.Val(this.L.Text));
                SqlCommand command = new SqlCommand("DELETE FROM TaNNInvSaleItems WHERE (HSaleID = @HSaleID)", this.A);
                command.Parameters.AddWithValue("HSaleID", num);
                command.ExecuteNonQuery();
                this.A.Close();
                A.D.A.A.L();
                base.Dispose();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
                ProjectData.ClearProjectError();
            }
        }

        public void R()
        {
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
                adapter.SelectCommand.Parameters.AddWithValue("HSaleID", A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count <= 0)
                {
                    Interaction.MsgBox("خطأ في تحديد المادة من الفاتورة", MsgBoxStyle.ApplicationModal, null);
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
                    if (this.P.Checked)
                    {
                        Interaction.MsgBox("هذه المادة مضافة برمجياً، قد تكون خصم او عمولة يجب عليك إزالة القيم الخصم او العمولات من شاشة البيع", MsgBoxStyle.ApplicationModal, null);
                        base.Dispose();
                    }
                    else
                    {
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
                            this.Q();
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
                            this.P();
                        }
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, EventArgs R)
        {
            base.Dispose();
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

        internal virtual Label LaTip
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
    }
}

