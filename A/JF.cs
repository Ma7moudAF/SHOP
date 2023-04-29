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
    public class JF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("ButtonPending"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonBack")]
        private Button R;
        [AccessedThroughProperty("ButtonDelete"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        private SqlConnection A;
        public static int A;

        public JF()
        {
            base.Load += new EventHandler(this.Q);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label1 = new Label();
            this.ButtonPending = new Button();
            this.ButtonBack = new Button();
            this.ButtonDelete = new Button();
            base.SuspendLayout();
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.FromArgb(0xc0, 0x40, 0);
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x177, 0x48);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "إغلاق شاشة البيع !\r\nيجب عليك إتخاذ اجراء في الفاتورة الحالية";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonPending.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonPending.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPending.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPending.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPending.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPending.FlatStyle = FlatStyle.Flat;
            this.ButtonPending.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPending.Image = F.ImPendingNow;
            this.ButtonPending.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPending.Location = new Point(12, 0x8e);
            this.ButtonPending.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPending.Name = "ButtonPending";
            this.ButtonPending.Size = new Size(0x15f, 0x29);
            this.ButtonPending.TabIndex = 0x5f;
            this.ButtonPending.Text = "أغلاق شاشة البيع، وتعليق الفاتورة الحالية";
            this.ButtonPending.UseVisualStyleBackColor = false;
            this.ButtonBack.FlatAppearance.BorderColor = Color.Green;
            this.ButtonBack.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonBack.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonBack.FlatStyle = FlatStyle.Flat;
            this.ButtonBack.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonBack.Image = F.ImPendingList;
            this.ButtonBack.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonBack.Location = new Point(12, 90);
            this.ButtonBack.Margin = new Padding(3, 4, 3, 4);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new Size(0x15f, 0x2c);
            this.ButtonBack.TabIndex = 0x60;
            this.ButtonBack.Text = "العودة لشاشة البيع";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonDelete.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDelete.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDelete.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDelete.FlatStyle = FlatStyle.Flat;
            this.ButtonDelete.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDelete.Image = F.ImDelete;
            this.ButtonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new Point(0x18, 0x13a);
            this.ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new Size(0x15f, 0x29);
            this.ButtonDelete.TabIndex = 0x62;
            this.ButtonDelete.Text = "حذف الفاتورة الحالية، واغلاق شاشة البيع";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            base.AcceptButton = this.ButtonBack;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x177, 0xc7);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonDelete);
            base.Controls.Add(this.ButtonPending);
            base.Controls.Add(this.ButtonBack);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleCloseMenu";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اغلاق";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            if (D.A.A.GV.RowCount > 0)
            {
                Interaction.MsgBox("الفاتورة الحالية تحتوي على مواد مباعة، يجب عليك ارجاعها لتتمكن من حذف الفاتورة", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    if (PR.O)
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command2 = new SqlCommand("UPDATE TaNNTables SET InvSaleFrontID =@InvSaleFrontID, TableIsBooking =@TableIsBooking WHERE (TableID = @TableID)", this.A);
                        command2.Parameters.AddWithValue("TableID", QH.LR.Text);
                        command2.Parameters.AddWithValue("InvSaleFrontID", DBNull.Value);
                        command2.Parameters.AddWithValue("TableIsBooking", false);
                        command2.ExecuteNonQuery();
                        this.A.Close();
                    }
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNInvSale WHERE (InvSaleID = @InvSaleID)", this.A);
                    command.Parameters.AddWithValue("InvSaleID", JF.A);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox("تم حذف الفاتورة الحالية", MsgBoxStyle.ApplicationModal, null);
                    D.A.A.Dispose();
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

        private void Q(object A, EventArgs R)
        {
        }

        private void R(object A, EventArgs R)
        {
            AR.T = JF.A;
            D.A.A.Dispose();
            base.Dispose();
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

        internal virtual Button ButtonPending
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

        internal virtual Button ButtonBack
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

        internal virtual Button ButtonDelete
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
    }
}

