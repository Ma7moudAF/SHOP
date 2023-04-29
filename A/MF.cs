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
    public class MF : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle"), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("ButtonOK"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonClose")]
        private Button R;
        [AccessedThroughProperty("GroupBox7"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private GroupBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2")]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MaterialBarCode"), CompilerGenerated]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("CheckBoxRandom")]
        private CheckBox A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox P;
        [AccessedThroughProperty("MaterialName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [CompilerGenerated, AccessedThroughProperty("MaterialUnit"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("GroupBox3"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox5")]
        private GroupBox I;
        [CompilerGenerated, AccessedThroughProperty("MaterialDisMiWi"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox4")]
        private GroupBox D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTDisVal")]
        private TextBox Q;
        [AccessedThroughProperty("GroupBox6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox F;
        [AccessedThroughProperty("GroupBox8"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [AccessedThroughProperty("MaterialDarMiWi"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox I;
        [CompilerGenerated, AccessedThroughProperty("GroupBox9"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox T;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTDarVal"), CompilerGenerated]
        private TextBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox10")]
        private GroupBox X;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("MaterialPricCost")]
        private TextBox F;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox11"), CompilerGenerated]
        private GroupBox G;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("MaterialPricSale"), CompilerGenerated]
        private TextBox H;
        [CompilerGenerated, AccessedThroughProperty("GroupBox12"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox E;
        [AccessedThroughProperty("TxTQuantityName"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox T;
        [CompilerGenerated, AccessedThroughProperty("GroupBox13"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox K;
        [CompilerGenerated, AccessedThroughProperty("MaterialNote"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox X;
        [AccessedThroughProperty("CheckBoxEmpty"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox R;
        private SqlConnection A;

        public MF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.ButtonOK = new Button();
            this.ButtonClose = new Button();
            this.GroupBox7 = new GroupBox();
            this.GroupBox5 = new GroupBox();
            this.MaterialDisMiWi = new TextBox();
            this.GroupBox4 = new GroupBox();
            this.TxTDisVal = new TextBox();
            this.GroupBox2 = new GroupBox();
            this.CheckBoxRandom = new CheckBox();
            this.MaterialBarCode = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.MaterialName = new TextBox();
            this.GroupBox3 = new GroupBox();
            this.MaterialUnit = new ComboBox();
            this.GroupBox6 = new GroupBox();
            this.GroupBox8 = new GroupBox();
            this.MaterialDarMiWi = new TextBox();
            this.GroupBox9 = new GroupBox();
            this.TxTDarVal = new TextBox();
            this.GroupBox10 = new GroupBox();
            this.MaterialPricCost = new TextBox();
            this.GroupBox11 = new GroupBox();
            this.MaterialPricSale = new TextBox();
            this.GroupBox12 = new GroupBox();
            this.TxTQuantityName = new TextBox();
            this.GroupBox13 = new GroupBox();
            this.MaterialNote = new TextBox();
            this.CheckBoxEmpty = new CheckBox();
            this.GroupBox7.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox8.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.GroupBox11.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            this.GroupBox13.SuspendLayout();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1e4, 0x22);
            this.TxTTitle.TabIndex = 0x74;
            this.TxTTitle.Text = "اضافة مادة او خدمة خارج المستودع";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOK.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOK.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOK.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOK.FlatStyle = FlatStyle.Flat;
            this.ButtonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOK.Image = A.F.ImOK;
            this.ButtonOK.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOK.Location = new Point(12, 470);
            this.ButtonOK.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new Size(0x134, 0x2c);
            this.ButtonOK.TabIndex = 11;
            this.ButtonOK.Text = "موافق";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x150, 470);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x85, 0x2c);
            this.ButtonClose.TabIndex = 12;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.GroupBox7.Controls.Add(this.GroupBox5);
            this.GroupBox7.Controls.Add(this.GroupBox4);
            this.GroupBox7.Location = new Point(0xc1, 0xb8);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x117, 0x57);
            this.GroupBox7.TabIndex = 0x7c;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "الخصم";
            this.GroupBox5.Controls.Add(this.MaterialDisMiWi);
            this.GroupBox5.Location = new Point(0x8e, 0x16);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0x7f, 0x34);
            this.GroupBox5.TabIndex = 6;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "نسبة %";
            this.MaterialDisMiWi.BackColor = Color.White;
            this.MaterialDisMiWi.Dock = DockStyle.Fill;
            this.MaterialDisMiWi.Location = new Point(3, 0x13);
            this.MaterialDisMiWi.MaxLength = 20;
            this.MaterialDisMiWi.Name = "MaterialDisMiWi";
            this.MaterialDisMiWi.RightToLeft = RightToLeft.No;
            this.MaterialDisMiWi.Size = new Size(0x79, 0x17);
            this.MaterialDisMiWi.TabIndex = 0;
            this.MaterialDisMiWi.TextAlign = HorizontalAlignment.Center;
            this.GroupBox4.Controls.Add(this.TxTDisVal);
            this.GroupBox4.Location = new Point(9, 0x16);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x7f, 0x34);
            this.GroupBox4.TabIndex = 7;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "مبلغ";
            this.TxTDisVal.BackColor = Color.White;
            this.TxTDisVal.Dock = DockStyle.Fill;
            this.TxTDisVal.Location = new Point(3, 0x13);
            this.TxTDisVal.MaxLength = 20;
            this.TxTDisVal.Name = "TxTDisVal";
            this.TxTDisVal.RightToLeft = RightToLeft.No;
            this.TxTDisVal.Size = new Size(0x79, 0x17);
            this.TxTDisVal.TabIndex = 0;
            this.TxTDisVal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox2.Controls.Add(this.CheckBoxRandom);
            this.GroupBox2.Controls.Add(this.MaterialBarCode);
            this.GroupBox2.Location = new Point(12, 0x25);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(460, 0x33);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "رقم/ باركود المادة";
            this.CheckBoxRandom.AutoSize = true;
            this.CheckBoxRandom.Dock = DockStyle.Left;
            this.CheckBoxRandom.Location = new Point(3, 0x13);
            this.CheckBoxRandom.Name = "CheckBoxRandom";
            this.CheckBoxRandom.Size = new Size(0x4b, 0x1d);
            this.CheckBoxRandom.TabIndex = 1;
            this.CheckBoxRandom.Text = "عشوائي";
            this.CheckBoxRandom.UseVisualStyleBackColor = true;
            this.MaterialBarCode.BackColor = SystemColors.Info;
            this.MaterialBarCode.Dock = DockStyle.Right;
            this.MaterialBarCode.Location = new Point(0x54, 0x13);
            this.MaterialBarCode.MaxLength = 300;
            this.MaterialBarCode.Name = "MaterialBarCode";
            this.MaterialBarCode.Size = new Size(0x175, 0x17);
            this.MaterialBarCode.TabIndex = 0;
            this.MaterialBarCode.TextAlign = HorizontalAlignment.Center;
            this.GroupBox1.Controls.Add(this.MaterialName);
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Location = new Point(12, 0x5e);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(460, 80);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "اسم المادة/ الوصف / الخدمة";
            this.MaterialName.BackColor = SystemColors.Info;
            this.MaterialName.Dock = DockStyle.Right;
            this.MaterialName.Location = new Point(0x98, 0x13);
            this.MaterialName.MaxLength = 300;
            this.MaterialName.Multiline = true;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.Size = new Size(0x131, 0x3a);
            this.MaterialName.TabIndex = 1;
            this.MaterialName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox3.Controls.Add(this.MaterialUnit);
            this.GroupBox3.Location = new Point(10, 0x13);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x8b, 0x37);
            this.GroupBox3.TabIndex = 2;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الوحدة";
            this.MaterialUnit.Dock = DockStyle.Fill;
            this.MaterialUnit.FormattingEnabled = true;
            object[] items = new object[0x19];
            items[0] = "";
            items[1] = "خدمة";
            items[2] = "مساعده";
            items[3] = "وجبة";
            items[4] = "بطاقات";
            items[5] = "شحن";
            items[6] = "صيانة";
            items[7] = "جهاز";
            items[8] = "غرام";
            items[9] = "كيلو";
            items[10] = "رطل";
            items[11] = "طن";
            items[12] = "كرتونة";
            items[13] = "كيس";
            items[14] = "طبق";
            items[15] = "علبة";
            items[0x10] = "صندوق";
            items[0x11] = "باكيت";
            items[0x12] = "قطعة";
            items[0x13] = "درزن";
            items[20] = "متر";
            items[0x15] = "سم";
            items[0x16] = "حبة";
            items[0x17] = "صندوق";
            items[0x18] = "اكتب اي شي اخر";
            this.MaterialUnit.Items.AddRange(items);
            this.MaterialUnit.Location = new Point(3, 0x13);
            this.MaterialUnit.MaxLength = 20;
            this.MaterialUnit.Name = "MaterialUnit";
            this.MaterialUnit.Size = new Size(0x85, 0x18);
            this.MaterialUnit.TabIndex = 2;
            this.GroupBox6.Controls.Add(this.GroupBox8);
            this.GroupBox6.Controls.Add(this.GroupBox9);
            this.GroupBox6.Location = new Point(0xc3, 0x115);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x115, 0x57);
            this.GroupBox6.TabIndex = 0x7e;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "الضريبة";
            this.GroupBox8.Controls.Add(this.MaterialDarMiWi);
            this.GroupBox8.Location = new Point(0x8d, 0x16);
            this.GroupBox8.Name = "GroupBox8";
            this.GroupBox8.Size = new Size(0x7f, 0x34);
            this.GroupBox8.TabIndex = 8;
            this.GroupBox8.TabStop = false;
            this.GroupBox8.Text = "نسبة %";
            this.MaterialDarMiWi.BackColor = Color.White;
            this.MaterialDarMiWi.Dock = DockStyle.Fill;
            this.MaterialDarMiWi.Location = new Point(3, 0x13);
            this.MaterialDarMiWi.MaxLength = 20;
            this.MaterialDarMiWi.Name = "MaterialDarMiWi";
            this.MaterialDarMiWi.RightToLeft = RightToLeft.No;
            this.MaterialDarMiWi.Size = new Size(0x79, 0x17);
            this.MaterialDarMiWi.TabIndex = 0;
            this.MaterialDarMiWi.TextAlign = HorizontalAlignment.Center;
            this.GroupBox9.Controls.Add(this.TxTDarVal);
            this.GroupBox9.Location = new Point(8, 0x16);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Size = new Size(0x7f, 0x34);
            this.GroupBox9.TabIndex = 9;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "مبلغ";
            this.TxTDarVal.BackColor = Color.White;
            this.TxTDarVal.Dock = DockStyle.Fill;
            this.TxTDarVal.Enabled = false;
            this.TxTDarVal.Location = new Point(3, 0x13);
            this.TxTDarVal.MaxLength = 20;
            this.TxTDarVal.Name = "TxTDarVal";
            this.TxTDarVal.RightToLeft = RightToLeft.No;
            this.TxTDarVal.Size = new Size(0x79, 0x17);
            this.TxTDarVal.TabIndex = 0;
            this.TxTDarVal.TextAlign = HorizontalAlignment.Center;
            this.GroupBox10.Controls.Add(this.MaterialPricCost);
            this.GroupBox10.Location = new Point(12, 0xb8);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Size = new Size(0x98, 0x34);
            this.GroupBox10.TabIndex = 3;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "سعر التكلفة";
            this.MaterialPricCost.BackColor = Color.White;
            this.MaterialPricCost.Dock = DockStyle.Fill;
            this.MaterialPricCost.Location = new Point(3, 0x13);
            this.MaterialPricCost.MaxLength = 20;
            this.MaterialPricCost.Name = "MaterialPricCost";
            this.MaterialPricCost.RightToLeft = RightToLeft.No;
            this.MaterialPricCost.Size = new Size(0x92, 0x17);
            this.MaterialPricCost.TabIndex = 0;
            this.MaterialPricCost.TextAlign = HorizontalAlignment.Center;
            this.GroupBox11.Controls.Add(this.MaterialPricSale);
            this.GroupBox11.Location = new Point(12, 0xf2);
            this.GroupBox11.Name = "GroupBox11";
            this.GroupBox11.Size = new Size(0x98, 0x34);
            this.GroupBox11.TabIndex = 4;
            this.GroupBox11.TabStop = false;
            this.GroupBox11.Text = "سعر البيع";
            this.MaterialPricSale.BackColor = SystemColors.Info;
            this.MaterialPricSale.Dock = DockStyle.Fill;
            this.MaterialPricSale.Location = new Point(3, 0x13);
            this.MaterialPricSale.MaxLength = 20;
            this.MaterialPricSale.Name = "MaterialPricSale";
            this.MaterialPricSale.RightToLeft = RightToLeft.No;
            this.MaterialPricSale.Size = new Size(0x92, 0x17);
            this.MaterialPricSale.TabIndex = 0;
            this.MaterialPricSale.TextAlign = HorizontalAlignment.Center;
            this.GroupBox12.Controls.Add(this.TxTQuantityName);
            this.GroupBox12.Location = new Point(12, 0x138);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new Size(0x98, 0x34);
            this.GroupBox12.TabIndex = 5;
            this.GroupBox12.TabStop = false;
            this.GroupBox12.Text = "الكمية";
            this.TxTQuantityName.BackColor = SystemColors.Info;
            this.TxTQuantityName.Dock = DockStyle.Fill;
            this.TxTQuantityName.Location = new Point(3, 0x13);
            this.TxTQuantityName.MaxLength = 20;
            this.TxTQuantityName.Name = "TxTQuantityName";
            this.TxTQuantityName.RightToLeft = RightToLeft.No;
            this.TxTQuantityName.Size = new Size(0x92, 0x17);
            this.TxTQuantityName.TabIndex = 0;
            this.TxTQuantityName.Text = "1";
            this.TxTQuantityName.TextAlign = HorizontalAlignment.Center;
            this.GroupBox13.Controls.Add(this.MaterialNote);
            this.GroupBox13.Location = new Point(12, 370);
            this.GroupBox13.Name = "GroupBox13";
            this.GroupBox13.Size = new Size(460, 80);
            this.GroupBox13.TabIndex = 10;
            this.GroupBox13.TabStop = false;
            this.GroupBox13.Text = "ملاحظات";
            this.MaterialNote.BackColor = Color.White;
            this.MaterialNote.Dock = DockStyle.Fill;
            this.MaterialNote.Location = new Point(3, 0x13);
            this.MaterialNote.MaxLength = 300;
            this.MaterialNote.Multiline = true;
            this.MaterialNote.Name = "MaterialNote";
            this.MaterialNote.Size = new Size(0x1c6, 0x3a);
            this.MaterialNote.TabIndex = 0;
            this.MaterialNote.Text = "مادة مضافة";
            this.MaterialNote.TextAlign = HorizontalAlignment.Center;
            this.CheckBoxEmpty.AutoSize = true;
            this.CheckBoxEmpty.BackColor = Color.WhiteSmoke;
            this.CheckBoxEmpty.Checked = true;
            this.CheckBoxEmpty.CheckState = CheckState.Checked;
            this.CheckBoxEmpty.Dock = DockStyle.Bottom;
            this.CheckBoxEmpty.Location = new Point(0, 0x21b);
            this.CheckBoxEmpty.Name = "CheckBoxEmpty";
            this.CheckBoxEmpty.Size = new Size(0x1e4, 20);
            this.CheckBoxEmpty.TabIndex = 0x7f;
            this.CheckBoxEmpty.Text = "تفريغ الحقول بعد الاضافة";
            this.CheckBoxEmpty.UseVisualStyleBackColor = false;
            base.AcceptButton = this.ButtonOK;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.CancelButton = this.ButtonClose;
            base.ClientSize = new Size(0x1e4, 0x22f);
            base.ControlBox = false;
            base.Controls.Add(this.CheckBoxEmpty);
            base.Controls.Add(this.GroupBox13);
            base.Controls.Add(this.GroupBox12);
            base.Controls.Add(this.GroupBox11);
            base.Controls.Add(this.GroupBox10);
            base.Controls.Add(this.GroupBox6);
            base.Controls.Add(this.GroupBox1);
            base.Controls.Add(this.GroupBox7);
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.ButtonOK);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SaleAddOut";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "اضافة مادة او خدمة خارج المستودع";
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox8.ResumeLayout(false);
            this.GroupBox8.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.GroupBox11.ResumeLayout(false);
            this.GroupBox11.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            this.GroupBox12.PerformLayout();
            this.GroupBox13.ResumeLayout(false);
            this.GroupBox13.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            QH.Q = true;
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

        private void D(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
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

        private void F(object A, EventArgs R)
        {
        }

        private void F(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void G(object A, EventArgs R)
        {
        }

        private void H(object A, EventArgs R)
        {
        }

        private void I(object A, EventArgs R)
        {
        }

        private void I(object A, KeyPressEventArgs R)
        {
            if (((R.KeyChar != '\r') && (Strings.Asc(R.KeyChar) != 8)) && !"1234567890.".Contains(R.KeyChar.ToString().ToLower()))
            {
                R.KeyChar = '\0';
                R.Handled = true;
                Interaction.MsgBox(PR.Q.ToString(), MsgBoxStyle.Exclamation, null);
            }
        }

        private void P(object A, EventArgs R)
        {
            A.D.A.A.L();
            base.Dispose();
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
            if (this.CheckBoxRandom.Checked)
            {
                this.MaterialBarCode.Text = "Out" + DateTime.Now.ToString("yyyyMMddHHmm");
            }
            else
            {
                this.MaterialBarCode.Text = null;
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

        public void R()
        {
            Application.DoEvents();
            try
            {
                decimal num = 0M;
                decimal num2 = 0M;
                decimal num4 = 0M;
                decimal num5 = 0M;
                decimal num6 = 0M;
                decimal num7 = 0M;
                decimal num8 = 0M;
                decimal num9 = 0M;
                decimal num10 = 0M;
                decimal num11 = 0M;
                decimal num12 = 0M;
                decimal num13 = 0M;
                decimal num14 = 0M;
                num = new decimal(Conversion.Val(this.TxTQuantityName.Text.Replace(",", "")));
                num2 = new decimal(Conversion.Val(this.MaterialPricCost.Text.Replace(",", "")));
                num4 = new decimal(Conversion.Val(this.MaterialDisMiWi.Text.Replace(",", "")));
                num5 = new decimal(Conversion.Val(this.MaterialDarMiWi.Text.Replace(",", "")));
                num6 = new decimal(Conversion.Val(this.MaterialPricSale.Text.Replace(",", "")));
                if (Conversion.Val(this.MaterialDisMiWi.Text) <= 0.0)
                {
                    num8 = new decimal(Conversion.Val(this.TxTDisVal.Text));
                }
                else
                {
                    num8 = decimal.Multiply(num6, decimal.Divide(num4, new decimal((long) 100)));
                    this.TxTDisVal.Text = Conversions.ToString(num8);
                }
                num7 = decimal.Subtract(num6, num8);
                if (Conversions.ToDouble(PR.PP) == 0.0)
                {
                    num9 = decimal.Multiply(num7, decimal.Divide(num5, new decimal((long) 100)));
                    num7 = decimal.Add(num7, num9);
                    num2 = decimal.Add(num2, num9);
                }
                else if (Conversions.ToDouble(PR.PP) == 1.0)
                {
                    num9 = decimal.Multiply(decimal.Multiply(new decimal((long) 100), decimal.Divide(num7, decimal.Add(new decimal((long) 100), num5))), decimal.Divide(num5, new decimal((long) 100)));
                    num7 = num7;
                }
                this.TxTDarVal.Text = Conversions.ToString(num9);
                num10 = decimal.Multiply(decimal.Subtract(num7, num2), num);
                num11 = decimal.Multiply(num6, num);
                num12 = decimal.Multiply(num8, num);
                num13 = decimal.Multiply(num9, num);
                num14 = decimal.Multiply(num7, num);
                if ((!PR.S & (decimal.Compare(num10, decimal.Zero) < 0)) & (A.D.A.A.InvSaleType.SelectedIndex == 0))
                {
                    Interaction.MsgBox("سعر التكلفة اكبر من سعر البيع وهذا يسبب الخسارة، وتم منع البيع بالخسارة", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO [TaNNInvSaleItems] ([CenterFrontID], [InvSaleFrontID], [GroupIDFrontID], [CustomerFrontID], [HInvSaleIDMAX], [HSaleType], [HSaleDateTime], [HSaleBarCode], [HSaleName], [HSaleUnit], [HSalePrice], [HSaleQuantity], [HSalePriceTotal], [HSaleDisMiaWi], [HSaleDisVal], [HSaleDarMiaWi], [HSaleDarVal], [HSaleNETTotal], [HSaleIsDelete], [HSaleNetProft], [HSaleNote], [HSaleUserAddBy]) VALUES (@CenterFrontID, @InvSaleFrontID, @GroupIDFrontID, @CustomerFrontID, @HInvSaleIDMAX, @HSaleType, @HSaleDateTime, @HSaleBarCode, @HSaleName, @HSaleUnit, @HSalePrice, @HSaleQuantity, @HSalePriceTotal, @HSaleDisMiaWi, @HSaleDisVal, @HSaleDarMiaWi, @HSaleDarVal, @HSaleNETTotal, @HSaleIsDelete, @HSaleNetProft, @HSaleNote, @HSaleUserAddBy)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("InvSaleFrontID", QH.A);
                    command.Parameters.AddWithValue("GroupIDFrontID", "0");
                    command.Parameters.AddWithValue("CustomerFrontID", "0");
                    command.Parameters.AddWithValue("HInvSaleIDMAX", A.D.A.A.InvSaleIDMAX.Text);
                    command.Parameters.AddWithValue("HSaleType", A.D.A.A.InvSaleType.SelectedIndex);
                    command.Parameters.AddWithValue("HSaleDateTime", A.D.A.A.InvSaleDateTime.Value.ToString("yyyy/MM/dd HH:mm"));
                    command.Parameters.AddWithValue("HSaleBarCode", this.MaterialBarCode.Text);
                    command.Parameters.AddWithValue("HSaleName", this.MaterialName.Text);
                    command.Parameters.AddWithValue("HSaleUnit", this.MaterialUnit.Text);
                    command.Parameters.AddWithValue("HSalePrice", num6.ToString(PR.VR));
                    command.Parameters.AddWithValue("HSaleQuantity", num.ToString(PR.OR));
                    command.Parameters.AddWithValue("HSalePriceTotal", num11.ToString(PR.VR));
                    command.Parameters.AddWithValue("HSaleDisMiaWi", Conversion.Val(this.MaterialDisMiWi.Text));
                    command.Parameters.AddWithValue("HSaleDisVal", num12.ToString(PR.VR));
                    command.Parameters.AddWithValue("HSaleDarMiaWi", num5);
                    command.Parameters.AddWithValue("HSaleDarVal", num13.ToString(PR.VR));
                    command.Parameters.AddWithValue("HSaleNETTotal", num14.ToString(PR.VR));
                    command.Parameters.AddWithValue("HSaleIsDelete", false);
                    command.Parameters.AddWithValue("HSaleNetProft", num10.ToString(PR.VR));
                    command.Parameters.AddWithValue("HSaleNote", this.MaterialNote.Text);
                    command.Parameters.AddWithValue("HSaleUserAddBy", A.D.A.A.TxTUserName.Text);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    if (this.CheckBoxEmpty.Checked)
                    {
                        this.MaterialBarCode.Text = null;
                        this.MaterialName.Text = null;
                        this.MaterialUnit.Text = null;
                        this.MaterialDarMiWi.Text = null;
                        this.MaterialDisMiWi.Text = null;
                        this.TxTDarVal.Text = null;
                        this.TxTDisVal.Text = null;
                        this.MaterialNote.Text = null;
                        this.CheckBoxRandom.Checked = false;
                    }
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
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

        private void R(object A, EventArgs R)
        {
            if (((this.MaterialBarCode.Text == null) | (this.MaterialName.Text == null)) | (this.MaterialPricSale.Text == null))
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else if (A.D.A.A.InvSaleType.SelectedIndex == -1)
            {
                Interaction.MsgBox("يجب تحديد نوع الفاتورة", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                this.R();
            }
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

        internal virtual GroupBox GroupBox7
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox MaterialBarCode
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual CheckBox CheckBoxRandom
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                CheckBox a = this.A;
                if (a != null)
                {
                    a.CheckedChanged -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.CheckedChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox MaterialName
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual ComboBox MaterialUnit
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual TextBox MaterialDisMiWi
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.Q);
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox TxTDisVal
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.I);
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

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.F = value);
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

        internal virtual TextBox MaterialDarMiWi
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.X);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.D);
                TextBox i = this.I;
                if (i != null)
                {
                    i.TextChanged -= handler;
                    i.KeyPress -= handler2;
                }
                this.I = value;
                i = this.I;
                if (i != null)
                {
                    i.TextChanged += handler;
                    i.KeyPress += handler2;
                }
            }
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

        internal virtual TextBox TxTDarVal
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.G);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.F);
                TextBox d = this.D;
                if (d != null)
                {
                    d.TextChanged -= handler;
                    d.KeyPress -= handler2;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.TextChanged += handler;
                    d.KeyPress += handler2;
                }
            }
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

        internal virtual TextBox MaterialPricCost
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.A);
                TextBox f = this.F;
                if (f != null)
                {
                    f.TextChanged -= handler;
                    f.KeyPress -= handler2;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.TextChanged += handler;
                    f.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox11
        {
            [CompilerGenerated]
            get => 
                this.G;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.G = value);
        }

        internal virtual TextBox MaterialPricSale
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.R);
                TextBox h = this.H;
                if (h != null)
                {
                    h.TextChanged -= handler;
                    h.KeyPress -= handler2;
                }
                this.H = value;
                h = this.H;
                if (h != null)
                {
                    h.TextChanged += handler;
                    h.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox12
        {
            [CompilerGenerated]
            get => 
                this.E;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.E = value);
        }

        internal virtual TextBox TxTQuantityName
        {
            [CompilerGenerated]
            get => 
                this.T;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.P);
                TextBox t = this.T;
                if (t != null)
                {
                    t.TextChanged -= handler;
                    t.KeyPress -= handler2;
                }
                this.T = value;
                t = this.T;
                if (t != null)
                {
                    t.TextChanged += handler;
                    t.KeyPress += handler2;
                }
            }
        }

        internal virtual GroupBox GroupBox13
        {
            [CompilerGenerated]
            get => 
                this.K;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.K = value);
        }

        internal virtual TextBox MaterialNote
        {
            [CompilerGenerated]
            get => 
                this.X;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.X = value);
        }

        internal virtual CheckBox CheckBoxEmpty
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

