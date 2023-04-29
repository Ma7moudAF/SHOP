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
    public class HH : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox4"), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("TxTCode"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [AccessedThroughProperty("PictureBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PictureBox A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox5"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTMax")]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1"), CompilerGenerated]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOK")]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        private SqlConnection A;

        public HH()
        {
            base.Load += new EventHandler(this.I);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.GroupBox4 = new GroupBox();
            this.TxTCode = new TextBox();
            this.PictureBox2 = new PictureBox();
            this.GroupBox5 = new GroupBox();
            this.TxTMax = new TextBox();
            this.Label1 = new Label();
            this.ButtonOK = new Button();
            this.ButtonFinish = new Button();
            this.GroupBox4.SuspendLayout();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            this.GroupBox5.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x221, 0x22);
            this.TxTTitle.TabIndex = 0x63;
            this.TxTTitle.Text = "حسب التعليمات يجب تحديد رقم فاتورة المبيعات الاصلية";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox4.BackColor = Color.White;
            this.GroupBox4.Controls.Add(this.TxTCode);
            this.GroupBox4.Controls.Add(this.PictureBox2);
            this.GroupBox4.Location = new Point(12, 0x2f);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x115, 0x3b);
            this.GroupBox4.TabIndex = 0x1ed36cd;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "تحديد الفاتورة حسب باركود/ ترميز الفاتورة";
            this.TxTCode.BackColor = SystemColors.Info;
            this.TxTCode.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTCode.Location = new Point(0x5d, 0x16);
            this.TxTCode.Name = "TxTCode";
            this.TxTCode.RightToLeft = RightToLeft.No;
            this.TxTCode.Size = new Size(0xb0, 0x1b);
            this.TxTCode.TabIndex = 70;
            this.TxTCode.TextAlign = HorizontalAlignment.Center;
            this.PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox2.Image = F.BarCodeSS;
            this.PictureBox2.Location = new Point(8, 0x16);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new Size(0x6c, 0x1b);
            this.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 0x47;
            this.PictureBox2.TabStop = false;
            this.GroupBox5.BackColor = Color.White;
            this.GroupBox5.Controls.Add(this.TxTMax);
            this.GroupBox5.Location = new Point(0x157, 0x2f);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0xbc, 0x3b);
            this.GroupBox5.TabIndex = 0x1ed36ce;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "تحديد الفاتورة حسب رقمها";
            this.TxTMax.BackColor = SystemColors.Info;
            this.TxTMax.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMax.Location = new Point(6, 0x16);
            this.TxTMax.Name = "TxTMax";
            this.TxTMax.RightToLeft = RightToLeft.No;
            this.TxTMax.Size = new Size(0xa6, 0x1b);
            this.TxTMax.TabIndex = 0x51;
            this.TxTMax.TextAlign = HorizontalAlignment.Center;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Red;
            this.Label1.Location = new Point(0x130, 0x48);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(20, 0x13);
            this.Label1.TabIndex = 0x1ed36cf;
            this.Label1.Text = "او";
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(12, 0x86);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x16d, 0x2c);
            this.ButtonOK.TabIndex = 0x1ed36d0;
            this.ButtonOK.Text = "موافق";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonFinish.DialogResult = DialogResult.Cancel;
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = F.ImCloseOrang;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(0x17f, 0x86);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x94, 0x2c);
            this.ButtonFinish.TabIndex = 0x1ed36d1;
            this.ButtonFinish.Text = "اغلاق";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonFinish;
            base.ClientSize = new Size(0x221, 0xbf);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleInvoiceReShow";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تحديد الفاتورة الأصلية";
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((ISupportInitialize) this.PictureBox2).EndInit();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.TxTMax.Text = null;
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
            this.TxTMax.Focus();
        }

        private void P(object A, EventArgs R)
        {
            if (!((this.TxTCode.Text == null) & (this.TxTMax.Text == null)))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    string selectCommandText = "SELECT [InvSaleType], [InvSaleIDMAX], [InvSaleDateTime], [HashQR] FROM TaNNInvSale WHERE (TaNNInvSale.CenterFrontID = @CenterFrontID) AND ((InvSaleID = @InvSaleID) OR (InvSaleIDMAX = @InvSaleIDMAX))";
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    dataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    string text = this.TxTCode.Text;
                    adapter.SelectCommand.Parameters.AddWithValue("InvSaleID", text ?? DBNull.Value);
                    string text2 = this.TxTMax.Text;
                    adapter.SelectCommand.Parameters.AddWithValue("InvSaleIDMAX", text2 ?? DBNull.Value);
                    adapter.Fill(dataTable);
                    this.A.Close();
                    string inputStr = "";
                    string str3 = "";
                    string str4 = "";
                    if (dataTable.Rows.Count <= 0)
                    {
                        Interaction.MsgBox("لم يتم العثور على الفاتورة الاصلية", MsgBoxStyle.ApplicationModal, null);
                        this.TxTCode.Text = null;
                        this.TxTMax.Text = null;
                        this.TxTMax.Focus();
                    }
                    else
                    {
                        IEnumerator enumerator;
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
                                object[] arguments = new object[] { "InvSaleType" };
                                inputStr = NewLateBinding.LateIndexGet(current, arguments, null).ToString();
                                object[] objArray2 = new object[] { "InvSaleIDMAX" };
                                str3 = NewLateBinding.LateIndexGet(current, objArray2, null).ToString();
                                object[] objArray3 = new object[] { "InvSaleDateTime" };
                                str4 = NewLateBinding.LateIndexGet(current, objArray3, null).ToString();
                            }
                        }
                        finally
                        {
                            if (enumerator is IDisposable)
                            {
                                (enumerator as IDisposable).Dispose();
                            }
                        }
                        if (Conversion.Val(inputStr) == 1.0)
                        {
                            Interaction.MsgBox("الفاتورة الاصلية نوعها مرتجع مبيعات، يجب تحديد فاتورة المبيعات الاصلية", MsgBoxStyle.ApplicationModal, null);
                            this.TxTCode.Text = null;
                            this.TxTMax.Text = null;
                            this.TxTMax.Focus();
                        }
                        else
                        {
                            string str6 = "Invoice Number:" + str3.ToString() + ";Invoice Issue Date:" + DateTime.Parse(str4.ToString()).ToString("yyyy-MM-dd");
                            QH.Q = str3.ToString();
                            QH.I = str6.ToString();
                            base.Dispose();
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
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void R(object A, EventArgs R)
        {
            this.TxTCode.Text = null;
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTCode
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
                TextBox a = this.A;
                if (a != null)
                {
                    a.GotFocus -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.GotFocus += handler;
                }
            }
        }

        internal virtual PictureBox PictureBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTMax
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                TextBox r = this.R;
                if (r != null)
                {
                    r.GotFocus -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.GotFocus += handler;
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

        internal virtual Button ButtonFinish
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
    }
}

