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
    public class PH : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("TxTInput"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonOk")]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose")]
        private Button R;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        private SqlConnection A;
        public static int A = 0;
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
        private TextBox B;
        private TextBox S;
        private TextBox Z;
        private TextBox M;
        private TextBox C;
        private TextBox J;
        private TextBox W;
        private CheckBox P;
        private TextBox AR;

        public PH()
        {
            base.Load += new EventHandler(this.A);
            base.Shown += new EventHandler(this.P);
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
            this.B = new TextBox();
            this.S = new TextBox();
            this.Z = new TextBox();
            this.M = new TextBox();
            this.C = new TextBox();
            this.J = new TextBox();
            this.W = new TextBox();
            this.P = new CheckBox();
            this.AR = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTInput = new TextBox();
            this.TxTTitle = new Label();
            this.ButtonOk = new Button();
            this.ButtonClose = new Button();
            base.SuspendLayout();
            this.TxTInput.BackColor = SystemColors.Info;
            this.TxTInput.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTInput.Location = new Point(12, 0x37);
            this.TxTInput.MaxLength = 0x9c4;
            this.TxTInput.Multiline = true;
            this.TxTInput.Name = "TxTInput";
            this.TxTInput.RightToLeft = RightToLeft.No;
            this.TxTInput.Size = new Size(0x213, 0x3f);
            this.TxTInput.TabIndex = 80;
            this.TxTInput.TextAlign = HorizontalAlignment.Center;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x22c, 0x29);
            this.TxTTitle.TabIndex = 0x51;
            this.TxTTitle.Text = "تعديل الملاحظات";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.ImOK;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(12, 0x87);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(410, 0x2c);
            this.ButtonOk.TabIndex = 0x53;
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
            this.ButtonClose.Location = new Point(0x1ac, 0x87);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x73, 0x2c);
            this.ButtonClose.TabIndex = 0x52;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x22c, 0xc1);
            base.ControlBox = false;
            base.Controls.Add(this.TxTInput);
            base.Controls.Add(this.ButtonOk);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleEditNote";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تعديل الملاحظات";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
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

        private void P(object A, EventArgs R)
        {
            this.TxTInput.Focus();
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
                }
                else
                {
                    this.N.Text = dataTable.Rows[0]["HSaleID"].ToString();
                    this.TxTInput.Text = dataTable.Rows[0]["HSaleNote"].ToString();
                    this.TxTInput.Focus();
                }
                this.TxTInput.Focus();
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
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE [TaNNInvSaleItems] SET [HSaleNote] = @HSaleNote WHERE [HSaleID] = @HSaleID", this.A);
                command.Parameters.AddWithValue("HSaleID", this.N.Text);
                command.Parameters.AddWithValue("HSaleNote", this.TxTInput.Text.Trim());
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
                ProjectData.ClearProjectError();
            }
        }

        internal virtual TextBox TxTInput
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
            set => 
                (this.R = value);
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
    }
}

