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
    public class CI : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label A;
        [CompilerGenerated, AccessedThroughProperty("ToolStripStatus"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ToolStrip A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripProgressBar1"), CompilerGenerated]
        private ToolStripProgressBar A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ToolStripButtonClose")]
        private ToolStripButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabControl1"), CompilerGenerated]
        private TabControl A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage4")]
        private TabPage A;
        [AccessedThroughProperty("GroupBox7"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [AccessedThroughProperty("ButtonPrice"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [CompilerGenerated, AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox R;
        [AccessedThroughProperty("CustomerDiscount"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonDisMiWi"), CompilerGenerated]
        private Button R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2")]
        private GroupBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CustomerPoints")]
        private TextBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonPoint"), CompilerGenerated]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerPriceType"), CompilerGenerated]
        private ComboBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage3")]
        private TabPage Q;
        [AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CustomerApplyIfPoints")]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonDisIf")]
        private Button Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TabPage5"), CompilerGenerated]
        private TabPage I;
        [AccessedThroughProperty("GroupBox4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox I;
        [AccessedThroughProperty("CusLimitDebit"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonDeb")]
        private Button I;
        private SqlConnection A;

        public CI()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.ToolStripStatus = new ToolStrip();
            this.ToolStripProgressBar1 = new ToolStripProgressBar();
            this.ToolStripButtonClose = new ToolStripButton();
            this.TabControl1 = new TabControl();
            this.TabPage4 = new TabPage();
            this.GroupBox7 = new GroupBox();
            this.CustomerPriceType = new ComboBox();
            this.ButtonPrice = new Button();
            this.TabPage1 = new TabPage();
            this.GroupBox1 = new GroupBox();
            this.CustomerDiscount = new TextBox();
            this.ButtonDisMiWi = new Button();
            this.TabPage3 = new TabPage();
            this.GroupBox3 = new GroupBox();
            this.CustomerApplyIfPoints = new TextBox();
            this.ButtonDisIf = new Button();
            this.TabPage2 = new TabPage();
            this.GroupBox2 = new GroupBox();
            this.CustomerPoints = new TextBox();
            this.ButtonPoint = new Button();
            this.TabPage5 = new TabPage();
            this.GroupBox4 = new GroupBox();
            this.CusLimitDebit = new TextBox();
            this.ButtonDeb = new Button();
            this.ToolStripStatus.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x24f, 0x22);
            this.TxTTitle.TabIndex = 1;
            this.TxTTitle.Text = "تعديل متعدد";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ToolStripStatus.BackColor = Color.WhiteSmoke;
            this.ToolStripStatus.Dock = DockStyle.Bottom;
            this.ToolStripStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ToolStripStatus.GripStyle = ToolStripGripStyle.Hidden;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.ToolStripProgressBar1, this.ToolStripButtonClose };
            this.ToolStripStatus.Items.AddRange(toolStripItems);
            this.ToolStripStatus.Location = new Point(0, 0xce);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Size = new Size(0x24f, 0x27);
            this.ToolStripStatus.TabIndex = 0x7c;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new Size(100, 0x24);
            this.ToolStripProgressBar1.Visible = false;
            this.ToolStripButtonClose.Image = A.F.ImCloseOrang;
            this.ToolStripButtonClose.ImageScaling = ToolStripItemImageScaling.None;
            this.ToolStripButtonClose.ImageTransparentColor = Color.Magenta;
            this.ToolStripButtonClose.Name = "ToolStripButtonClose";
            this.ToolStripButtonClose.Size = new Size(0x4b, 0x24);
            this.ToolStripButtonClose.Text = "اغلاق";
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Dock = DockStyle.Fill;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 3);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x24f, 0xac);
            this.TabControl1.SizeMode = TabSizeMode.FillToRight;
            this.TabControl1.TabIndex = 0x7d;
            this.TabPage4.Controls.Add(this.GroupBox7);
            this.TabPage4.Location = new Point(4, 0x19);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new Size(0x247, 0x8f);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "السعر الافتراضي";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.GroupBox7.Controls.Add(this.CustomerPriceType);
            this.GroupBox7.Controls.Add(this.ButtonPrice);
            this.GroupBox7.Location = new Point(0x3a, 0x15);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(460, 0x62);
            this.GroupBox7.TabIndex = 0x7b;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "تطبيق السعر";
            this.CustomerPriceType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CustomerPriceType.FormattingEnabled = true;
            object[] items = new object[] { "تطبيق سعر البيع الافتراضي العادي", "تطبيق سعر البيع المخفض", "تطبيق سعر التكلفة" };
            this.CustomerPriceType.Items.AddRange(items);
            this.CustomerPriceType.Location = new Point(0xa3, 0x2d);
            this.CustomerPriceType.Name = "CustomerPriceType";
            this.CustomerPriceType.Size = new Size(0x123, 0x18);
            this.CustomerPriceType.TabIndex = 0x7c;
            this.ButtonPrice.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPrice.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPrice.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPrice.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPrice.FlatStyle = FlatStyle.Flat;
            this.ButtonPrice.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPrice.Image = A.F.ImOK;
            this.ButtonPrice.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPrice.Location = new Point(6, 0x22);
            this.ButtonPrice.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPrice.Name = "ButtonPrice";
            this.ButtonPrice.Size = new Size(0x97, 0x2c);
            this.ButtonPrice.TabIndex = 0x79;
            this.ButtonPrice.Text = "موافق";
            this.ButtonPrice.UseVisualStyleBackColor = true;
            this.TabPage1.Controls.Add(this.GroupBox1);
            this.TabPage1.Location = new Point(4, 0x19);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new Size(0x247, 0x8f);
            this.TabPage1.TabIndex = 4;
            this.TabPage1.Text = "نسبة الخصم";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.GroupBox1.Controls.Add(this.CustomerDiscount);
            this.GroupBox1.Controls.Add(this.ButtonDisMiWi);
            this.GroupBox1.Location = new Point(0x36, 0x15);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(480, 0x62);
            this.GroupBox1.TabIndex = 0x7c;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "نسبة الخصم %";
            this.CustomerDiscount.BackColor = SystemColors.Info;
            this.CustomerDiscount.Location = new Point(0xa3, 0x2d);
            this.CustomerDiscount.MaxLength = 20;
            this.CustomerDiscount.Name = "CustomerDiscount";
            this.CustomerDiscount.RightToLeft = RightToLeft.No;
            this.CustomerDiscount.Size = new Size(0x137, 0x17);
            this.CustomerDiscount.TabIndex = 0x7a;
            this.CustomerDiscount.TextAlign = HorizontalAlignment.Center;
            this.ButtonDisMiWi.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDisMiWi.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDisMiWi.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDisMiWi.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDisMiWi.FlatStyle = FlatStyle.Flat;
            this.ButtonDisMiWi.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDisMiWi.Image = A.F.ImOK;
            this.ButtonDisMiWi.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDisMiWi.Location = new Point(6, 0x22);
            this.ButtonDisMiWi.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDisMiWi.Name = "ButtonDisMiWi";
            this.ButtonDisMiWi.Size = new Size(0x97, 0x2c);
            this.ButtonDisMiWi.TabIndex = 0x79;
            this.ButtonDisMiWi.Text = "موافق";
            this.ButtonDisMiWi.UseVisualStyleBackColor = true;
            this.TabPage3.Controls.Add(this.GroupBox3);
            this.TabPage3.Location = new Point(4, 0x19);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x247, 0x8f);
            this.TabPage3.TabIndex = 6;
            this.TabPage3.Text = "شرط تطبيق الخصم";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.CustomerApplyIfPoints);
            this.GroupBox3.Controls.Add(this.ButtonDisIf);
            this.GroupBox3.Location = new Point(0x2e, 0x18);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(480, 0x62);
            this.GroupBox3.TabIndex = 0x7d;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "طبق نسبة الخصم في حال وصلت عدد النقاط الى";
            this.CustomerApplyIfPoints.BackColor = SystemColors.Info;
            this.CustomerApplyIfPoints.Location = new Point(0xa3, 0x2d);
            this.CustomerApplyIfPoints.MaxLength = 20;
            this.CustomerApplyIfPoints.Name = "CustomerApplyIfPoints";
            this.CustomerApplyIfPoints.RightToLeft = RightToLeft.No;
            this.CustomerApplyIfPoints.Size = new Size(0x137, 0x17);
            this.CustomerApplyIfPoints.TabIndex = 0x7a;
            this.CustomerApplyIfPoints.TextAlign = HorizontalAlignment.Center;
            this.ButtonDisIf.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDisIf.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDisIf.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDisIf.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDisIf.FlatStyle = FlatStyle.Flat;
            this.ButtonDisIf.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDisIf.Image = A.F.ImOK;
            this.ButtonDisIf.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDisIf.Location = new Point(6, 0x22);
            this.ButtonDisIf.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDisIf.Name = "ButtonDisIf";
            this.ButtonDisIf.Size = new Size(0x97, 0x2c);
            this.ButtonDisIf.TabIndex = 0x79;
            this.ButtonDisIf.Text = "موافق";
            this.ButtonDisIf.UseVisualStyleBackColor = true;
            this.TabPage2.Controls.Add(this.GroupBox2);
            this.TabPage2.Location = new Point(4, 0x19);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new Size(0x247, 0x8f);
            this.TabPage2.TabIndex = 5;
            this.TabPage2.Text = "عدد النقاط الحالية";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.GroupBox2.Controls.Add(this.CustomerPoints);
            this.GroupBox2.Controls.Add(this.ButtonPoint);
            this.GroupBox2.Location = new Point(0x35, 20);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(480, 0x62);
            this.GroupBox2.TabIndex = 0x7c;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "عدد النقاط الحالية";
            this.CustomerPoints.BackColor = SystemColors.Info;
            this.CustomerPoints.Location = new Point(0xa3, 0x2d);
            this.CustomerPoints.MaxLength = 20;
            this.CustomerPoints.Name = "CustomerPoints";
            this.CustomerPoints.RightToLeft = RightToLeft.No;
            this.CustomerPoints.Size = new Size(0x137, 0x17);
            this.CustomerPoints.TabIndex = 0x7a;
            this.CustomerPoints.TextAlign = HorizontalAlignment.Center;
            this.ButtonPoint.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPoint.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPoint.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPoint.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPoint.FlatStyle = FlatStyle.Flat;
            this.ButtonPoint.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPoint.Image = A.F.ImOK;
            this.ButtonPoint.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPoint.Location = new Point(6, 0x22);
            this.ButtonPoint.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new Size(0x97, 0x2c);
            this.ButtonPoint.TabIndex = 0x79;
            this.ButtonPoint.Text = "موافق";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            this.TabPage5.Controls.Add(this.GroupBox4);
            this.TabPage5.Location = new Point(4, 0x19);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new Padding(3);
            this.TabPage5.Size = new Size(0x247, 0x8f);
            this.TabPage5.TabIndex = 7;
            this.TabPage5.Text = "رصيد الذمم المسموح";
            this.TabPage5.UseVisualStyleBackColor = true;
            this.GroupBox4.Controls.Add(this.CusLimitDebit);
            this.GroupBox4.Controls.Add(this.ButtonDeb);
            this.GroupBox4.Location = new Point(0x33, 0x16);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(480, 0x62);
            this.GroupBox4.TabIndex = 0x7d;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "وقف التعامل مع هذا العميل عندما يصبح رصيده الذمم يساوي او اكبر من";
            this.CusLimitDebit.BackColor = SystemColors.Info;
            this.CusLimitDebit.Location = new Point(0xa3, 0x2d);
            this.CusLimitDebit.MaxLength = 20;
            this.CusLimitDebit.Name = "CusLimitDebit";
            this.CusLimitDebit.RightToLeft = RightToLeft.No;
            this.CusLimitDebit.Size = new Size(0x137, 0x17);
            this.CusLimitDebit.TabIndex = 0x7a;
            this.CusLimitDebit.TextAlign = HorizontalAlignment.Center;
            this.ButtonDeb.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDeb.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDeb.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDeb.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDeb.FlatStyle = FlatStyle.Flat;
            this.ButtonDeb.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDeb.Image = A.F.ImOK;
            this.ButtonDeb.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDeb.Location = new Point(6, 0x22);
            this.ButtonDeb.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDeb.Name = "ButtonDeb";
            this.ButtonDeb.Size = new Size(0x97, 0x2c);
            this.ButtonDeb.TabIndex = 0x79;
            this.ButtonDeb.Text = "موافق";
            this.ButtonDeb.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x24f, 0xf5);
            base.ControlBox = false;
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ToolStripStatus);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CustomerMultiEdit";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تعديل متعدد";
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage4.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
        }

        private void A(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void D(object A, EventArgs R)
        {
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

        private void F(object A, EventArgs R)
        {
        }

        private void G(object A, EventArgs R)
        {
            try
            {
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                this.ToolStripProgressBar1.Value = 0;
                this.ToolStripProgressBar1.Visible = true;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["CustomerID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells["GVCheckBox"].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNCustomers] SET [CusLimitDebit] = @CusLimitDebit WHERE [CustomerID] = @CustomerID", this.A);
                        command.Parameters.AddWithValue("CustomerID", num3);
                        decimal num4 = new decimal(Conversion.Val(this.CusLimitDebit.Text.Trim()));
                        if (decimal.Compare(num4, decimal.Zero) > 0)
                        {
                            num4 = decimal.Multiply(num4, decimal.MinusOne);
                        }
                        command.Parameters.AddWithValue("CusLimitDebit", num4);
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void H(object A, EventArgs R)
        {
            try
            {
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                this.ToolStripProgressBar1.Value = 0;
                this.ToolStripProgressBar1.Visible = true;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["CustomerID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells["GVCheckBox"].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNCustomers] SET [CustomerDiscount] = @CustomerDiscount WHERE [CustomerID] = @CustomerID", this.A);
                        command.Parameters.AddWithValue("CustomerID", num3);
                        command.Parameters.AddWithValue("CustomerDiscount", this.CustomerDiscount.Text.Trim());
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void I(object A, EventArgs R)
        {
        }

        private void P(object A, EventArgs R)
        {
            try
            {
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                this.ToolStripProgressBar1.Value = 0;
                this.ToolStripProgressBar1.Visible = true;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["CustomerID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells["GVCheckBox"].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNCustomers] SET [CustomerPriceType] = @CustomerPriceType WHERE [CustomerID] = @CustomerID", this.A);
                        command.Parameters.AddWithValue("CustomerID", num3);
                        command.Parameters.AddWithValue("CustomerPriceType", this.CustomerPriceType.SelectedIndex);
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void P(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void Q(object A, EventArgs R)
        {
            try
            {
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                this.ToolStripProgressBar1.Value = 0;
                this.ToolStripProgressBar1.Visible = true;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["CustomerID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells["GVCheckBox"].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNCustomers] SET [CustomerApplyIfPoints] = @CustomerApplyIfPoints WHERE [CustomerID] = @CustomerID", this.A);
                        command.Parameters.AddWithValue("CustomerID", num3);
                        command.Parameters.AddWithValue("CustomerApplyIfPoints", this.CustomerApplyIfPoints.Text.Trim());
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void Q(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void R(object A, EventArgs R)
        {
            A.D.A.A.TimerLoadData.Enabled = true;
            base.Dispose();
        }

        private void R(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void T(object A, EventArgs R)
        {
            try
            {
                this.ToolStripProgressBar1.Maximum = A.D.A.A.GV.Rows.Count;
                this.ToolStripProgressBar1.Value = 0;
                this.ToolStripProgressBar1.Visible = true;
                int num = A.D.A.A.GV.Rows.Count - 1;
                int num2 = 0;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ToolStripProgressBar1.Visible = false;
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        break;
                    }
                    this.ToolStripProgressBar1.Value = num2;
                    int num3 = Conversions.ToInteger(A.D.A.A.GV.Rows[num2].Cells["CustomerID"].Value.ToString());
                    if (Conversions.ToBoolean(A.D.A.A.GV.Rows[num2].Cells["GVCheckBox"].Value))
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlCommand command = new SqlCommand("UPDATE [TaNNCustomers] SET [CustomerPoints] = @CustomerPoints WHERE [CustomerID] = @CustomerID", this.A);
                        command.Parameters.AddWithValue("CustomerID", num3);
                        command.Parameters.AddWithValue("CustomerPoints", this.CustomerPoints.Text.Trim());
                        command.ExecuteNonQuery();
                        this.A.Close();
                    }
                    num2++;
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

        private void X(object A, EventArgs R)
        {
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

        internal virtual ToolStrip ToolStripStatus
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripProgressBar ToolStripProgressBar1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ToolStripButton ToolStripButtonClose
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                ToolStripButton a = this.A;
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

        internal virtual TabControl TabControl1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage4
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonPrice
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

        internal virtual TabPage TabPage1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TabPage TabPage2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual TextBox CustomerDiscount
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
                TextBox a = this.A;
                if (a != null)
                {
                    a.TextChanged -= handler;
                    a.KeyPress -= handler2;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.TextChanged += handler;
                    a.KeyPress += handler2;
                }
            }
        }

        internal virtual Button ButtonDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox CustomerPoints
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
                TextBox r = this.R;
                if (r != null)
                {
                    r.TextChanged -= handler;
                    r.KeyPress -= handler2;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.TextChanged += handler;
                    r.KeyPress += handler2;
                }
            }
        }

        internal virtual Button ButtonPoint
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
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

        internal virtual ComboBox CustomerPriceType
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox CustomerApplyIfPoints
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox p = this.P;
                if (p != null)
                {
                    p.TextChanged -= handler;
                    p.KeyPress -= handler2;
                }
                this.P = value;
                p = this.P;
                if (p != null)
                {
                    p.TextChanged += handler;
                    p.KeyPress += handler2;
                }
            }
        }

        internal virtual Button ButtonDisIf
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                Button q = this.Q;
                if (q != null)
                {
                    q.Click -= handler;
                }
                this.Q = value;
                q = this.Q;
                if (q != null)
                {
                    q.Click += handler;
                }
            }
        }

        internal virtual TabPage TabPage5
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox CusLimitDebit
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
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

        internal virtual Button ButtonDeb
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                Button i = this.I;
                if (i != null)
                {
                    i.Click -= handler;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.Click += handler;
                }
            }
        }
    }
}

