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
    public class FH : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3")]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MaterialBarCode")]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("TxTBarCode"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("PictureBox2")]
        private PictureBox A;
        [CompilerGenerated, AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("ButtonSearchCodeName"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [CompilerGenerated, AccessedThroughProperty("GroupBox1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerGiftBarcode")]
        private Label P;
        [AccessedThroughProperty("GroupBox2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox P;
        [AccessedThroughProperty("CustomerName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [CompilerGenerated, AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CustomerAddress")]
        private Label I;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox5")]
        private GroupBox I;
        [AccessedThroughProperty("CustomerPhone"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label D;
        [AccessedThroughProperty("GroupBox6"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox D;
        [AccessedThroughProperty("CustomerGiftExpDate"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label F;
        [CompilerGenerated, AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [AccessedThroughProperty("CustomerGiftDisMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label H;
        [AccessedThroughProperty("GroupBox8"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox H;
        [CompilerGenerated, AccessedThroughProperty("CustomerGiftDisVal"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label T;
        [AccessedThroughProperty("GroupBox9"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerGiftCount")]
        private Label X;
        [CompilerGenerated, AccessedThroughProperty("GroupBox10"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox X;
        [AccessedThroughProperty("CustomerGiftNote"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label G;
        private SqlConnection A;
        private TextBox R;

        public FH()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.R = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.GroupBox3 = new GroupBox();
            this.TxTBarCode = new TextBox();
            this.ButtonSearchCodeName = new Button();
            this.PictureBox2 = new PictureBox();
            this.MaterialBarCode = new Label();
            this.ButtonOK = new Button();
            this.ButtonFinish = new Button();
            this.GroupBox1 = new GroupBox();
            this.CustomerGiftBarcode = new Label();
            this.GroupBox2 = new GroupBox();
            this.CustomerName = new Label();
            this.GroupBox4 = new GroupBox();
            this.CustomerAddress = new Label();
            this.GroupBox5 = new GroupBox();
            this.CustomerPhone = new Label();
            this.GroupBox6 = new GroupBox();
            this.CustomerGiftExpDate = new Label();
            this.GroupBox7 = new GroupBox();
            this.CustomerGiftDisMiWi = new Label();
            this.GroupBox8 = new GroupBox();
            this.CustomerGiftDisVal = new Label();
            this.GroupBox9 = new GroupBox();
            this.CustomerGiftCount = new Label();
            this.GroupBox10 = new GroupBox();
            this.CustomerGiftNote = new Label();
            this.GroupBox3.SuspendLayout();
            ((ISupportInitialize) this.PictureBox2).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x368, 0x22);
            this.TxTTitle.TabIndex = 0x3f;
            this.TxTTitle.Text = "الخصم من بطاقة الهدية";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox3.Controls.Add(this.TxTBarCode);
            this.GroupBox3.Controls.Add(this.ButtonSearchCodeName);
            this.GroupBox3.Controls.Add(this.PictureBox2);
            this.GroupBox3.Controls.Add(this.MaterialBarCode);
            this.GroupBox3.Dock = DockStyle.Top;
            this.GroupBox3.Location = new Point(0, 0x22);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x368, 0x4c);
            this.GroupBox3.TabIndex = 0;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "رقم/باركود البطاقة";
            this.TxTBarCode.BackColor = SystemColors.Info;
            this.TxTBarCode.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTBarCode.Location = new Point(0x1dc, 0x20);
            this.TxTBarCode.Margin = new Padding(4);
            this.TxTBarCode.Name = "TxTBarCode";
            this.TxTBarCode.RightToLeft = RightToLeft.No;
            this.TxTBarCode.Size = new Size(0x17a, 0x1b);
            this.TxTBarCode.TabIndex = 0;
            this.TxTBarCode.TextAlign = HorizontalAlignment.Center;
            this.ButtonSearchCodeName.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSearchCodeName.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSearchCodeName.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSearchCodeName.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSearchCodeName.FlatStyle = FlatStyle.Flat;
            this.ButtonSearchCodeName.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSearchCodeName.Image = A.F.ImSearch;
            this.ButtonSearchCodeName.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSearchCodeName.Location = new Point(0x9b, 0x17);
            this.ButtonSearchCodeName.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSearchCodeName.Name = "ButtonSearchCodeName";
            this.ButtonSearchCodeName.Size = new Size(0xab, 0x2c);
            this.ButtonSearchCodeName.TabIndex = 1;
            this.ButtonSearchCodeName.Text = "بحث";
            this.ButtonSearchCodeName.UseVisualStyleBackColor = true;
            this.PictureBox2.BorderStyle = BorderStyle.FixedSingle;
            this.PictureBox2.Image = A.F.BarCodeSS;
            this.PictureBox2.Location = new Point(0x14d, 0x20);
            this.PictureBox2.Margin = new Padding(4);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new Size(0x9b, 0x1b);
            this.PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 0x47;
            this.PictureBox2.TabStop = false;
            this.MaterialBarCode.Dock = DockStyle.Fill;
            this.MaterialBarCode.Location = new Point(3, 0x13);
            this.MaterialBarCode.Name = "MaterialBarCode";
            this.MaterialBarCode.RightToLeft = RightToLeft.No;
            this.MaterialBarCode.Size = new Size(0x362, 0x36);
            this.MaterialBarCode.TabIndex = 0;
            this.MaterialBarCode.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(15, 0x144);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x2b7, 0x2c);
            this.ButtonOK.TabIndex = 0x57;
            this.ButtonOK.Text = "موافق";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonFinish.DialogResult = DialogResult.Cancel;
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = A.F.ImFinish;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(0x2cc, 0x144);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x94, 0x2c);
            this.ButtonFinish.TabIndex = 0x58;
            this.ButtonFinish.Text = "انهاء";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.CustomerGiftBarcode);
            this.GroupBox1.Location = new Point(15, 0x74);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(210, 0x3b);
            this.GroupBox1.TabIndex = 0x59;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "رقم/باركود البطاقة";
            this.CustomerGiftBarcode.Dock = DockStyle.Fill;
            this.CustomerGiftBarcode.Location = new Point(3, 0x13);
            this.CustomerGiftBarcode.Name = "CustomerGiftBarcode";
            this.CustomerGiftBarcode.RightToLeft = RightToLeft.No;
            this.CustomerGiftBarcode.Size = new Size(0xcc, 0x25);
            this.CustomerGiftBarcode.TabIndex = 0;
            this.CustomerGiftBarcode.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox2.Controls.Add(this.CustomerName);
            this.GroupBox2.Location = new Point(0xe4, 0x74);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(210, 0x3b);
            this.GroupBox2.TabIndex = 90;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "اسم المالك";
            this.CustomerName.Dock = DockStyle.Fill;
            this.CustomerName.Location = new Point(3, 0x13);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.RightToLeft = RightToLeft.No;
            this.CustomerName.Size = new Size(0xcc, 0x25);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox4.Controls.Add(this.CustomerAddress);
            this.GroupBox4.Location = new Point(0x1b9, 0x74);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(210, 0x3b);
            this.GroupBox4.TabIndex = 0x5b;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "العنوان";
            this.CustomerAddress.Dock = DockStyle.Fill;
            this.CustomerAddress.Location = new Point(3, 0x13);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.RightToLeft = RightToLeft.No;
            this.CustomerAddress.Size = new Size(0xcc, 0x25);
            this.CustomerAddress.TabIndex = 0;
            this.CustomerAddress.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox5.Controls.Add(this.CustomerPhone);
            this.GroupBox5.Location = new Point(0x28e, 0x74);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(210, 0x3b);
            this.GroupBox5.TabIndex = 0x5c;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "رقم الهاتف";
            this.CustomerPhone.Dock = DockStyle.Fill;
            this.CustomerPhone.Location = new Point(3, 0x13);
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.RightToLeft = RightToLeft.No;
            this.CustomerPhone.Size = new Size(0xcc, 0x25);
            this.CustomerPhone.TabIndex = 0;
            this.CustomerPhone.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox6.Controls.Add(this.CustomerGiftExpDate);
            this.GroupBox6.Location = new Point(15, 0xb5);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(210, 0x3b);
            this.GroupBox6.TabIndex = 0x5d;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "تاريخ انتهاء البطاقة";
            this.CustomerGiftExpDate.Dock = DockStyle.Fill;
            this.CustomerGiftExpDate.Location = new Point(3, 0x13);
            this.CustomerGiftExpDate.Name = "CustomerGiftExpDate";
            this.CustomerGiftExpDate.RightToLeft = RightToLeft.No;
            this.CustomerGiftExpDate.Size = new Size(0xcc, 0x25);
            this.CustomerGiftExpDate.TabIndex = 0;
            this.CustomerGiftExpDate.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox7.Controls.Add(this.CustomerGiftDisMiWi);
            this.GroupBox7.Location = new Point(0xe4, 0xb5);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(210, 0x3b);
            this.GroupBox7.TabIndex = 0x5e;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "نسبة الخصم%";
            this.CustomerGiftDisMiWi.Dock = DockStyle.Fill;
            this.CustomerGiftDisMiWi.Location = new Point(3, 0x13);
            this.CustomerGiftDisMiWi.Name = "CustomerGiftDisMiWi";
            this.CustomerGiftDisMiWi.RightToLeft = RightToLeft.No;
            this.CustomerGiftDisMiWi.Size = new Size(0xcc, 0x25);
            this.CustomerGiftDisMiWi.TabIndex = 0;
            this.CustomerGiftDisMiWi.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox8.Controls.Add(this.CustomerGiftDisVal);
            this.GroupBox8.Location = new Point(0x1bb, 0xb5);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(210, 0x3b);
            this.GroupBox8.TabIndex = 0x5f;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "مبلغ الخصم";
            this.CustomerGiftDisVal.Dock = DockStyle.Fill;
            this.CustomerGiftDisVal.Location = new Point(3, 0x13);
            this.CustomerGiftDisVal.Name = "CustomerGiftDisVal";
            this.CustomerGiftDisVal.RightToLeft = RightToLeft.No;
            this.CustomerGiftDisVal.Size = new Size(0xcc, 0x25);
            this.CustomerGiftDisVal.TabIndex = 0;
            this.CustomerGiftDisVal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox9.Controls.Add(this.CustomerGiftCount);
            this.GroupBox9.Location = new Point(0x290, 0xb5);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(210, 0x3b);
            this.GroupBox9.TabIndex = 0x60;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "عدد مرات الاستخدام المتاحة الأن";
            this.CustomerGiftCount.Dock = DockStyle.Fill;
            this.CustomerGiftCount.Location = new Point(3, 0x13);
            this.CustomerGiftCount.Name = "CustomerGiftCount";
            this.CustomerGiftCount.RightToLeft = RightToLeft.No;
            this.CustomerGiftCount.Size = new Size(0xcc, 0x25);
            this.CustomerGiftCount.TabIndex = 0;
            this.CustomerGiftCount.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox10.Controls.Add(this.CustomerGiftNote);
            this.GroupBox10.Location = new Point(15, 0xf6);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x353, 0x3b);
            this.GroupBox10.TabIndex = 0x61;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "ملاحظات البطاقة";
            this.CustomerGiftNote.Dock = DockStyle.Fill;
            this.CustomerGiftNote.Location = new Point(3, 0x13);
            this.CustomerGiftNote.Name = "CustomerGiftNote";
            this.CustomerGiftNote.RightToLeft = RightToLeft.No;
            this.CustomerGiftNote.Size = new Size(0x34d, 0x25);
            this.CustomerGiftNote.TabIndex = 0;
            this.CustomerGiftNote.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonFinish;
            base.ClientSize = new Size(0x368, 0x17b);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBox10);
            base.Controls.Add(this.GroupBox9);
            base.Controls.Add(this.GroupBox8);
            base.Controls.Add(this.GroupBox7);
            base.Controls.Add(this.GroupBox6);
            base.Controls.Add(this.GroupBox5);
            base.Controls.Add(this.GroupBox4);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleGift";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "حدد بطاقة الهدية";
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((ISupportInitialize) this.PictureBox2).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox10.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            this.TxTBarCode.Focus();
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (R.KeyChar == '\r')
            {
                this.ButtonSearchCodeName.PerformClick();
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

        private void I(object A, EventArgs R)
        {
        }

        private void P(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void Q(object A, EventArgs R)
        {
            if (this.CustomerGiftExpDate.Text == null)
            {
                Interaction.MsgBox("يجب تحديد البطاقة", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                DateTime time = Conversions.ToDate(this.CustomerGiftExpDate.Text);
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(DateTime.Now.ToString("yyyy/MM/dd"), time.ToString("yyyy/MM/dd"), false) >= 0)
                {
                    Interaction.MsgBox("تاريخ البطاقة منتهي", MsgBoxStyle.ApplicationModal, null);
                }
                else if (Conversion.Val(this.CustomerGiftCount.Text) == 0.0)
                {
                    Interaction.MsgBox("عدد استخدامات البطاقة المحدد لها 0", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    if (Conversion.Val(this.CustomerGiftDisMiWi.Text) > 0.0)
                    {
                        A.D.A.A.InvSaleDisMaWi.Text = this.CustomerGiftDisMiWi.Text;
                    }
                    if (Conversion.Val(this.CustomerGiftDisVal.Text) > 0.0)
                    {
                        A.D.A.A.InvSaleDisMaWiVAL.Text = this.CustomerGiftDisVal.Text;
                    }
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE [TaNNCustomers] SET [CustomerGiftCount] = @CustomerGiftCount WHERE [CustomerID] = @CustomerID", this.A);
                    command.Parameters.AddWithValue("CustomerID", this.R.Text);
                    command.Parameters.AddWithValue("CustomerGiftCount", Conversion.Val(this.CustomerGiftCount.Text) - 1.0);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    QH.D = "خصم بطاقة الهدية رقم " + this.CustomerGiftBarcode.Text;
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    A.D.A.A.ButtonDis.PerformClick();
                    base.Dispose();
                }
            }
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            this.R();
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

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label MaterialBarCode
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTBarCode
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.A);
                EventHandler handler2 = new EventHandler(this.I);
                TextBox a = this.A;
                if (a != null)
                {
                    a.KeyPress -= handler;
                    a.TextChanged -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.KeyPress += handler;
                    a.TextChanged += handler2;
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

        internal virtual Button ButtonOK
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

        internal virtual Button ButtonSearchCodeName
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

        internal virtual Button ButtonFinish
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label CustomerGiftBarcode
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label CustomerName
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label CustomerAddress
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label CustomerPhone
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual Label CustomerGiftExpDate
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
        }

        internal virtual Label CustomerGiftDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual GroupBox GroupBox8
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual Label CustomerGiftDisVal
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual GroupBox GroupBox9
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.T = value);
        }

        internal virtual Label CustomerGiftCount
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual GroupBox GroupBox10
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual Label CustomerGiftNote
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }
    }
}

