namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class ED : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxT1"), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        private SqlConnection A;
        public static int A;
        private TextBox A;
        private TextBox R;
        private TextBox P;
        private TextBox Q;
        public static bool A;

        public ED()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = new TextBox();
            this.R = new TextBox();
            this.P = new TextBox();
            this.Q = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxT1 = new Label();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.TxTTitle = new Label();
            base.SuspendLayout();
            this.TxT1.Dock = DockStyle.Top;
            this.TxT1.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxT1.Location = new Point(0, 0x22);
            this.TxT1.Name = "TxT1";
            this.TxT1.Size = new Size(0x1e5, 0x5c);
            this.TxT1.TabIndex = 0x26;
            this.TxT1.Text = "---";
            this.TxT1.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(4, 0x92);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x148, 0x2c);
            this.ButtonOK.TabIndex = 0x24;
            this.ButtonOK.Text = "موافق";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x152, 0x92);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x85, 0x2c);
            this.ButtonClose.TabIndex = 0x25;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1e5, 0x22);
            this.TxTTitle.TabIndex = 0x23;
            this.TxTTitle.Text = "تحذير سوء الاستخدام";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x1e5, 0xc2);
            base.ControlBox = false;
            base.Controls.Add(this.TxT1);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "InvoicePurchEditDelete";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تأكيد الأمر";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            this.TxT1.Text = !ED.A ? "سيتم إعادة معالجة كشف حساب المورد المرتبط مع الفاتورة، وذلك بهدف إعادة بناء الفاتورة للمدخلات الجديدة" : "هل انت متأكد من تنفيذ امر حذف الفاتورة؟ ستبقى هذه الفاتورة مقيدة في كشف حساب المورد";
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNInvPurch] WHERE ([InvPurchID] = @InvPurchID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("InvPurchID", ED.A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.P.Text = dataTable.Rows[0]["SuplierFrontID"].ToString();
                    this.A.Text = dataTable.Rows[0]["InvPurchTotalNET"].ToString();
                    this.R.Text = dataTable.Rows[0]["InvPurchMonPay"].ToString();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable table2 = new DataTable();
                    string str2 = "SELECT * FROM TaNNSupliers WHERE (SuplierID = @SuplierID)";
                    table2.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("SuplierID", this.P.Text);
                    adapter2.Fill(table2);
                    this.A.Close();
                    if (table2.Rows.Count > 0)
                    {
                        this.Q.Text = table2.Rows[0]["SuplierBalance"].ToString();
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
                IEnumerator enumerator;
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [TaNNInvPurch] SET [InvPurchStatus] = @InvPurchStatus, [InvPurchIsCashCount] =@InvPurchIsCashCount WHERE [InvPurchID] = @InvPurchID", this.A);
                command.Parameters.AddWithValue("InvPurchID", A);
                command.Parameters.AddWithValue("InvPurchStatus", "2");
                command.Parameters.AddWithValue("InvPurchIsCashCount", false);
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("DELETE FROM TaNNSupliersPay WHERE (InvPurchIDFront = @InvPurchIDFront)", this.A);
                command2.Parameters.AddWithValue("InvPurchIDFront", A);
                command2.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT * FROM TaNNSupliersPay WHERE (SuplierFrontID = @SuplierFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("SuplierFrontID", this.P.Text);
                adapter.Fill(dataTable);
                this.A.Close();
                decimal left = 0M;
                try
                {
                    enumerator = dataTable.Rows.GetEnumerator();
                    while (true)
                    {
                        if (!enumerator.MoveNext())
                        {
                            break;
                        }
                        object current = enumerator.Current;
                        object[] arguments = new object[] { "PayMony" };
                        left = Conversions.ToDecimal(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(left, NewLateBinding.LateIndexGet(current, arguments, null)));
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command3 = new SqlCommand("UPDATE [TaNNSupliers] SET [SuplierDateConfigur] = @SuplierDateConfigur, [SuplierBalance] = @SuplierBalance, [SuplierUserAddBy] = @SuplierUserAddBy WHERE [SuplierID] = @SuplierID", this.A);
                command3.Parameters.AddWithValue("SuplierID", this.P.Text);
                command3.Parameters.AddWithValue("SuplierBalance", left.ToString(PR.VR));
                command3.Parameters.AddWithValue("SuplierDateConfigur", DateTime.Now.ToString("yyyy/MM/dd"));
                command3.Parameters.AddWithValue("SuplierUserAddBy", D.A.A.TxTUserName.Text);
                command3.ExecuteNonQuery();
                this.A.Close();
                XD.A = A;
                D.A.A.ShowDialog();
                base.Dispose();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void P(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void R()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("DELETE FROM TaNNInvPurchItems WHERE (InvPurchIDFrontID = @InvPurchIDFrontID)", this.A);
                command.Parameters.AddWithValue("InvPurchIDFrontID", A);
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("DELETE FROM TaNNInvPurch WHERE (InvPurchID = @InvPurchID)", this.A);
                command2.Parameters.AddWithValue("InvPurchID", A);
                command2.ExecuteNonQuery();
                this.A.Close();
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                D.A.A.TimerLoadData.Enabled = true;
                base.Dispose();
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
            if (ED.A)
            {
                this.R();
            }
            else
            {
                this.P();
            }
        }

        internal virtual Label TxT1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonOK
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
    }
}

