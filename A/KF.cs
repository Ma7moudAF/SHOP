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
    public class KF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("ComboBoxTyp"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTCurName")]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTResult"), CompilerGenerated]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("Label4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOk")]
        private Button A;
        [AccessedThroughProperty("CurenSaleXchange"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label3")]
        private Label P;
        [AccessedThroughProperty("TxTMaster"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label I;
        [AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        private SqlConnection A;
        private DataSet A;
        private string A;
        private string R;

        public KF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = new DataSet();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            this.ComboBoxTyp = new TextBox();
            this.TxTCurName = new TextBox();
            this.TxTResult = new Label();
            this.Label4 = new Label();
            this.ButtonOk = new Button();
            this.CurenSaleXchange = new TextBox();
            this.Label3 = new Label();
            this.TxTMaster = new TextBox();
            this.Label1 = new Label();
            this.TxTTitle = new Label();
            this.ButtonClose = new Button();
            this.GV = new DataGridView();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.ComboBoxTyp.BackColor = Color.White;
            this.ComboBoxTyp.BorderStyle = BorderStyle.None;
            this.ComboBoxTyp.ForeColor = Color.White;
            this.ComboBoxTyp.Location = new Point(-39, 0x28b);
            this.ComboBoxTyp.Name = "ComboBoxTyp";
            this.ComboBoxTyp.Size = new Size(100, 0x10);
            this.ComboBoxTyp.TabIndex = 0x5d;
            this.TxTCurName.BackColor = Color.White;
            this.TxTCurName.BorderStyle = BorderStyle.None;
            this.TxTCurName.Dock = DockStyle.Top;
            this.TxTCurName.Enabled = false;
            this.TxTCurName.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTCurName.Location = new Point(0, 330);
            this.TxTCurName.MaxLength = 20;
            this.TxTCurName.Name = "TxTCurName";
            this.TxTCurName.Size = new Size(0x198, 20);
            this.TxTCurName.TabIndex = 0x58;
            this.TxTCurName.TextAlign = HorizontalAlignment.Center;
            this.TxTResult.BackColor = Color.WhiteSmoke;
            this.TxTResult.Dock = DockStyle.Top;
            this.TxTResult.Font = new Font("Tahoma", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTResult.ForeColor = Color.Maroon;
            this.TxTResult.Location = new Point(0, 0x100);
            this.TxTResult.Name = "TxTResult";
            this.TxTResult.Size = new Size(0x198, 0x2f);
            this.TxTResult.TabIndex = 0x5c;
            this.TxTResult.Text = "0";
            this.TxTResult.TextAlign = ContentAlignment.MiddleCenter;
            this.Label4.Dock = DockStyle.Top;
            this.Label4.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.ForeColor = Color.Black;
            this.Label4.Location = new Point(0, 0xe5);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x198, 0x1b);
            this.Label4.TabIndex = 0x5b;
            this.Label4.Text = "المبلغ المطلوب بالعملة المحددة اعلاه هو";
            this.Label4.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOk.Dock = DockStyle.Bottom;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(0, 0x16d);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x198, 0x29);
            this.ButtonOk.TabIndex = 90;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.CurenSaleXchange.BackColor = Color.White;
            this.CurenSaleXchange.BorderStyle = BorderStyle.None;
            this.CurenSaleXchange.ForeColor = Color.White;
            this.CurenSaleXchange.Location = new Point(-94, 0x2a1);
            this.CurenSaleXchange.MaxLength = 20;
            this.CurenSaleXchange.Name = "CurenSaleXchange";
            this.CurenSaleXchange.Size = new Size(0x61, 0x10);
            this.CurenSaleXchange.TabIndex = 0x59;
            this.Label3.Dock = DockStyle.Top;
            this.Label3.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.ForeColor = Color.Black;
            this.Label3.Location = new Point(0, 0x21);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x198, 0x1b);
            this.Label3.TabIndex = 0x57;
            this.Label3.Text = "قائمة العملات المتوفرة";
            this.Label3.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTMaster.BackColor = SystemColors.Info;
            this.TxTMaster.Dock = DockStyle.Top;
            this.TxTMaster.Font = new Font("Tahoma", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTMaster.Location = new Point(0, 60);
            this.TxTMaster.Name = "TxTMaster";
            this.TxTMaster.RightToLeft = RightToLeft.No;
            this.TxTMaster.Size = new Size(0x198, 0x20);
            this.TxTMaster.TabIndex = 0x53;
            this.TxTMaster.TextAlign = HorizontalAlignment.Center;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Black;
            this.Label1.Location = new Point(0, 0x12f);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x198, 0x1b);
            this.Label1.TabIndex = 0x56;
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x198, 0x21);
            this.TxTTitle.TabIndex = 0x54;
            this.TxTTitle.Text = "إدارة العملات الاخرى";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0, 0x196);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x198, 0x2c);
            this.ButtonClose.TabIndex = 0x5e;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
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
            this.GV.Location = new Point(0, 0x5c);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x198, 0x89);
            this.GV.TabIndex = 0x1ed36ce;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x198, 450);
            base.ControlBox = false;
            base.Controls.Add(this.ComboBoxTyp);
            base.Controls.Add(this.TxTCurName);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.CurenSaleXchange);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTResult);
            base.Controls.Add(this.Label4);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.TxTMaster);
            base.Controls.Add(this.Label3);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "OtherCur";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تحديد العملة";
            base.TopMost = true;
            ((ISupportInitialize) this.GV).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            try
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
                this.TxTCurName.DataBindings.Clear();
                this.CurenSaleXchange.DataBindings.Clear();
                this.ComboBoxTyp.DataBindings.Clear();
                this.TxTCurName.DataBindings.Add("Text", this.A, "TaNNOtherCuren.CurenName");
                this.CurenSaleXchange.DataBindings.Add("Text", this.A, "TaNNOtherCuren.CurenSaleXchange");
                this.ComboBoxTyp.DataBindings.Add("Text", this.A, "TaNNOtherCuren.Calculater");
                this.GV.DataSource = this.A;
                this.GV.DataMember = "TaNNOtherCuren";
                this.GV.Refresh();
                this.GV.Columns["CurenID"].Visible = false;
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["CurenName"].HeaderText = "العملة";
                this.GV.Columns["CurenSaleXchange"].HeaderText = "سعر الصرف";
                this.GV.Columns["Calculater"].HeaderText = "المعادلة ( * ضرب) - ( / قسمة)";
                this.ButtonOk.Enabled = this.GV.RowCount > 0;
                this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.TxTMaster.Focus();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void A(object A, DataGridViewCellEventArgs R)
        {
            this.R();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Microsoft.VisualBasic.Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
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
            this.R();
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void R()
        {
            decimal expression = new decimal(Conversion.Val(this.TxTMaster.Text.Replace(",", "")));
            decimal num2 = new decimal(Conversion.Val(this.CurenSaleXchange.Text.Replace(",", "")));
            if (this.ComboBoxTyp.Text == "*")
            {
                this.TxTResult.Text = new decimal(Conversion.Val(expression) * Conversion.Val(num2)).ToString(PR.YR);
            }
            if (this.ComboBoxTyp.Text == "/")
            {
                this.TxTResult.Text = decimal.Divide(expression, num2).ToString(PR.YR);
            }
            string[] textArray1 = new string[10];
            textArray1[0] = " المبلغ في العملة المحلية ";
            textArray1[1] = this.TxTMaster.Text;
            textArray1[2] = " بسعر صرف ";
            textArray1[3] = this.ComboBoxTyp.Text;
            textArray1[4] = " ";
            textArray1[5] = this.CurenSaleXchange.Text;
            textArray1[6] = " = ";
            textArray1[7] = this.TxTResult.Text;
            textArray1[8] = " ";
            textArray1[9] = this.TxTCurName.Text;
            this.R = string.Concat(textArray1);
        }

        private void R(object A, EventArgs R)
        {
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else if (Conversion.Val(this.TxTResult.Text) == 0.0)
            {
                Interaction.MsgBox("يجب تحديد العملة او تحديد المبلغ", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                if (Application.OpenForms.OfType<IH>().Any<IH>())
                {
                    D.A.A.InvSaleOtherCuru.Text = this.R.ToString();
                    base.Dispose();
                }
                if (Application.OpenForms.OfType<BI>().Any<BI>())
                {
                    D.A.A.PayNote.Text = D.A.A.PayNote.Text + " " + this.R.ToString();
                    base.Dispose();
                }
                if (Application.OpenForms.OfType<XD>().Any<XD>())
                {
                    D.A.A.InvPurchNote.Text = D.A.A.InvPurchNote.Text + " " + this.R.ToString();
                }
                if (Application.OpenForms.OfType<PT>().Any<PT>())
                {
                    D.A.A.PayNote.Text = this.R.ToString();
                }
                base.Dispose();
            }
        }

        internal virtual TextBox ComboBoxTyp
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual Label TxTResult
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual TextBox CurenSaleXchange
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual TextBox TxTMaster
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox q = this.Q;
                if (q != null)
                {
                    q.TextChanged -= handler;
                    q.KeyPress -= handler2;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.TextChanged += handler;
                    q.KeyPress += handler2;
                }
            }
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTTitle
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Button ButtonClose
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                DataGridViewCellEventHandler handler = new DataGridViewCellEventHandler(this.A);
                DataGridView a = this.A;
                if (a != null)
                {
                    a.CellContentClick -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.CellContentClick += handler;
                }
            }
        }
    }
}

