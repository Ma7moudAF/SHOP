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
    public class ZD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("TxT1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        private SqlConnection A;
        public static int A;
        private TextBox A;
        private TextBox R;
        private TextBox P;
        private TextBox Q;
        public static bool A;

        public ZD()
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
            this.TxTTitle = new Label();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.TxT1 = new Label();
            this.Label1 = new Label();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x255, 0x22);
            this.TxTTitle.TabIndex = 30;
            this.TxTTitle.Text = "تحذير سوء الاستخدام";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(4, 0x8d);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x1ba, 0x2c);
            this.ButtonOK.TabIndex = 0x20;
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
            this.ButtonClose.Location = new Point(0x1c4, 0x8d);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x85, 0x2c);
            this.ButtonClose.TabIndex = 0x21;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.TxT1.Dock = DockStyle.Top;
            this.TxT1.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxT1.Location = new Point(0, 0x22);
            this.TxT1.Name = "TxT1";
            this.TxT1.Size = new Size(0x255, 0x5c);
            this.TxT1.TabIndex = 0x22;
            this.TxT1.Text = "---";
            this.TxT1.TextAlign = ContentAlignment.MiddleCenter;
            this.Label1.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.Label1.Dock = DockStyle.Bottom;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Red;
            this.Label1.Location = new Point(0, 0xbd);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x255, 0x39);
            this.Label1.TabIndex = 0x23;
            this.Label1.Text = "تحذير بعض الأنظمة في الحكومية تمنع الحذف والتعديل وعلى مسؤوليتك، مع العلم ان امر الحذف والتعديل يمكن كشفه بسهولة.";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x255, 0xf6);
            base.ControlBox = false;
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxT1);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "InvoicesEditDelete";
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
            this.TxT1.Text = !ZD.A ? "سيتم إعادة معالجة كشف حساب اي عميل مرتبط مع الفاتورة، وذلك بهدف إعادة بناء الفاتورة للمدخلات الجديدة" : "هل انت متأكد من تنفيذ امر حذف الفاتورة؟  ستبقى هذه الفاتورة مقيدة في كشف حساب العميل";
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT TOP(1) * FROM [TaNNInvSale] WHERE ([InvSaleID] = @InvSaleID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("InvSaleID", ZD.A);
                adapter.Fill(dataTable);
                this.A.Close();
                if (dataTable.Rows.Count > 0)
                {
                    this.P.Text = dataTable.Rows[0]["CustomerFrontID"].ToString();
                    this.A.Text = dataTable.Rows[0]["InvSaleTotalNET"].ToString();
                    this.R.Text = dataTable.Rows[0]["InvSaleMonPay"].ToString();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    DataTable table2 = new DataTable();
                    string str2 = "SELECT * FROM TaNNCustomers WHERE (CustomerID = @CustomerID)";
                    table2.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(str2, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CustomerID", this.P.Text);
                    adapter2.Fill(table2);
                    this.A.Close();
                    if (table2.Rows.Count > 0)
                    {
                        this.Q.Text = table2.Rows[0]["CustomerBalance"].ToString();
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
                SqlCommand command = new SqlCommand("UPDATE [TaNNInvSale] SET [InvSaleStatus] = @InvSaleStatus, [InvSaleIsCashCount] =@InvSaleIsCashCount WHERE [InvSaleID] = @InvSaleID", this.A);
                command.Parameters.AddWithValue("InvSaleID", A);
                command.Parameters.AddWithValue("InvSaleStatus", "2");
                command.Parameters.AddWithValue("InvSaleIsCashCount", false);
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("DELETE FROM TaNNCustomersPay WHERE (InvSaleIDFront = @InvSaleIDFront)", this.A);
                command2.Parameters.AddWithValue("InvSaleIDFront", A);
                command2.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT * FROM TaNNCustomersPay WHERE (CustomerFrontID = @CustomerFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CustomerFrontID", this.P.Text);
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
                SqlCommand command3 = new SqlCommand("UPDATE [TaNNCustomers] SET [CustomerDateConfigur] = @CustomerDateConfigur, [CustomerBalance] = @CustomerBalance, [CustomerUserAddBy] = @CustomerUserAddBy WHERE [CustomerID] = @CustomerID", this.A);
                command3.Parameters.AddWithValue("@CustomerID", this.P.Text);
                command3.Parameters.AddWithValue("@CustomerBalance", left.ToString(PR.VR));
                command3.Parameters.AddWithValue("@CustomerDateConfigur", DateTime.Now.ToString("yyyy/MM/dd"));
                command3.Parameters.AddWithValue("@CustomerUserAddBy", D.A.A.TxTUserName.Text);
                command3.ExecuteNonQuery();
                this.A.Close();
                QH.A = true;
                QH.A = A;
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
            if (ZD.A)
            {
                this.R();
            }
            else
            {
                this.P();
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
                SqlCommand command = new SqlCommand("DELETE FROM TaNNInvSaleItems WHERE (InvSaleFrontID = @InvSaleFrontID)", this.A);
                command.Parameters.AddWithValue("InvSaleFrontID", A);
                command.ExecuteNonQuery();
                this.A.Close();
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command2 = new SqlCommand("DELETE FROM TaNNInvSale WHERE (InvSaleID = @InvSaleID)", this.A);
                command2.Parameters.AddWithValue("InvSaleID", A);
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

        internal virtual Button ButtonOK
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

        internal virtual Button ButtonClose
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

        internal virtual Label TxT1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }
    }
}

