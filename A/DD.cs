namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class DD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("Label11"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [AccessedThroughProperty("TabPage3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage R;
        [AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("GroupBox4"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("RadioButton1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private RadioButton A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("RadioButton2"), CompilerGenerated]
        private RadioButton R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox3"), CompilerGenerated]
        private GroupBox R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("LabelTIP"), CompilerGenerated]
        private GroupBox P;
        [AccessedThroughProperty("TxTNetTotal"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("GroupBox5"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox Q;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTDarVal")]
        private Label P;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2")]
        private GroupBox I;
        [AccessedThroughProperty("TxTInput"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1")]
        private GroupBox D;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTMiWi"), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("ButtonTAX"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [CompilerGenerated, AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox7"), CompilerGenerated]
        private GroupBox F;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label2")]
        private Label I;
        [AccessedThroughProperty("TxTResulMid"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label D;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonMid")]
        private Button P;
        [AccessedThroughProperty("GroupBox6"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox H;
        [CompilerGenerated, AccessedThroughProperty("TxTMidCount"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox P;

        public DD()
        {
            base.Load += new EventHandler(this.I);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label11 = new Label();
            this.TabControl1 = new TabControl();
            this.TabPage2 = new TabPage();
            this.ButtonTAX = new Button();
            this.GroupBox4 = new GroupBox();
            this.RadioButton1 = new RadioButton();
            this.RadioButton2 = new RadioButton();
            this.GroupBox3 = new GroupBox();
            this.LabelTIP = new GroupBox();
            this.Label1 = new Label();
            this.TxTNetTotal = new Label();
            this.GroupBox5 = new GroupBox();
            this.TxTDarVal = new Label();
            this.GroupBox2 = new GroupBox();
            this.TxTInput = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.TxTMiWi = new TextBox();
            this.TabPage3 = new TabPage();
            this.GroupBox7 = new GroupBox();
            this.Label2 = new Label();
            this.TxTResulMid = new Label();
            this.ButtonMid = new Button();
            this.GroupBox6 = new GroupBox();
            this.TxTMidCount = new TextBox();
            this.ButtonFinish = new Button();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.LabelTIP.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.GroupBox7.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            base.SuspendLayout();
            this.Label11.Dock = DockStyle.Top;
            this.Label11.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label11.ForeColor = Color.Green;
            this.Label11.Location = new Point(0, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new Size(0x2a2, 0x24);
            this.Label11.TabIndex = 0x1ed36d5;
            this.Label11.Text = "حاسبة المعادلات";
            this.Label11.TextAlign = ContentAlignment.MiddleCenter;
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x24);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(8, 8);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x2a2, 0x158);
            this.TabControl1.TabIndex = 0x1ed36d6;
            this.TabPage2.Controls.Add(this.ButtonTAX);
            this.TabPage2.Controls.Add(this.GroupBox4);
            this.TabPage2.Controls.Add(this.GroupBox3);
            this.TabPage2.Controls.Add(this.GroupBox2);
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Location = new Point(4, 0x23);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x29a, 0x131);
            this.TabPage2.TabIndex = 4;
            this.TabPage2.Text = "حاسبة الضريبة";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonTAX.Dock = DockStyle.Bottom;
            this.ButtonTAX.FlatAppearance.BorderColor = Color.Green;
            this.ButtonTAX.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonTAX.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonTAX.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonTAX.FlatStyle = FlatStyle.Flat;
            this.ButtonTAX.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonTAX.Image = A.F.ImHelp;
            this.ButtonTAX.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonTAX.Location = new Point(3, 0x100);
            this.ButtonTAX.Margin = new Padding(3, 4, 3, 4);
            this.ButtonTAX.Name = "ButtonTAX";
            this.ButtonTAX.Size = new Size(660, 0x2e);
            this.ButtonTAX.TabIndex = 3;
            this.ButtonTAX.Text = "احسب";
            this.ButtonTAX.UseVisualStyleBackColor = true;
            this.GroupBox4.Controls.Add(this.RadioButton1);
            this.GroupBox4.Controls.Add(this.RadioButton2);
            this.GroupBox4.Location = new Point(0x126, 0x98);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new Size(0x15f, 0x56);
            this.GroupBox4.TabIndex = 2;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "طريقة الحساب";
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new Point(6, 0x1f);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new Size(0x149, 20);
            this.RadioButton1.TabIndex = 2;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "السعر غير شامل الضريبة، اضافة نسبة الضريبة مع المبلغ";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new Point(0x12, 0x39);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new Size(0x13d, 20);
            this.RadioButton2.TabIndex = 3;
            this.RadioButton2.Text = "السعر شامل الضريبة، استخرج اصل المبلغ قبل الضريبة";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.GroupBox3.Controls.Add(this.LabelTIP);
            this.GroupBox3.Controls.Add(this.GroupBox5);
            this.GroupBox3.Location = new Point(8, 0x12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x10a, 220);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الناتج";
            this.LabelTIP.Controls.Add(this.Label1);
            this.LabelTIP.Controls.Add(this.TxTNetTotal);
            this.LabelTIP.Location = new Point(6, 0x6d);
            this.LabelTIP.Name = "LabelTIP";
            this.LabelTIP.Size = new Size(0xfe, 0x69);
            this.LabelTIP.TabIndex = 1;
            this.LabelTIP.TabStop = false;
            this.LabelTIP.Text = "المجموع";
            this.Label1.Dock = DockStyle.Bottom;
            this.Label1.Location = new Point(3, 0x56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0xf8, 0x10);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "انقر على السعر للنسخ";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTNetTotal.Dock = DockStyle.Top;
            this.TxTNetTotal.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTNetTotal.ForeColor = Color.Blue;
            this.TxTNetTotal.Location = new Point(3, 0x13);
            this.TxTNetTotal.Name = "TxTNetTotal";
            this.TxTNetTotal.Size = new Size(0xf8, 0x43);
            this.TxTNetTotal.TabIndex = 1;
            this.TxTNetTotal.Text = "0";
            this.TxTNetTotal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox5.Controls.Add(this.TxTDarVal);
            this.GroupBox5.Location = new Point(6, 0x19);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new Size(0xfe, 0x4c);
            this.GroupBox5.TabIndex = 0;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "مبلغ الضريبة";
            this.TxTDarVal.Dock = DockStyle.Fill;
            this.TxTDarVal.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDarVal.ForeColor = Color.Blue;
            this.TxTDarVal.Location = new Point(3, 0x13);
            this.TxTDarVal.Name = "TxTDarVal";
            this.TxTDarVal.Size = new Size(0xf8, 0x36);
            this.TxTDarVal.TabIndex = 0;
            this.TxTDarVal.Text = "0";
            this.TxTDarVal.TextAlign = ContentAlignment.MiddleCenter;
            this.GroupBox2.Controls.Add(this.TxTInput);
            this.GroupBox2.Location = new Point(0x126, 0x58);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x15f, 0x33);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "السعر | المبلغ";
            this.TxTInput.BackColor = SystemColors.Info;
            this.TxTInput.Dock = DockStyle.Bottom;
            this.TxTInput.Location = new Point(3, 0x19);
            this.TxTInput.Name = "TxTInput";
            this.TxTInput.RightToLeft = RightToLeft.No;
            this.TxTInput.Size = new Size(0x159, 0x17);
            this.TxTInput.TabIndex = 0;
            this.TxTInput.TextAlign = HorizontalAlignment.Center;
            this.GroupBox1.Controls.Add(this.TxTMiWi);
            this.GroupBox1.Location = new Point(0x126, 0x12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x162, 0x33);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "نسبة الضريبة %";
            this.TxTMiWi.BackColor = SystemColors.Info;
            this.TxTMiWi.Dock = DockStyle.Bottom;
            this.TxTMiWi.Location = new Point(3, 0x19);
            this.TxTMiWi.Name = "TxTMiWi";
            this.TxTMiWi.RightToLeft = RightToLeft.No;
            this.TxTMiWi.Size = new Size(0x15c, 0x17);
            this.TxTMiWi.TabIndex = 0;
            this.TxTMiWi.TextAlign = HorizontalAlignment.Center;
            this.TabPage3.Controls.Add(this.GroupBox7);
            this.TabPage3.Controls.Add(this.ButtonMid);
            this.TabPage3.Controls.Add(this.GroupBox6);
            this.TabPage3.Location = new Point(4, 0x23);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new Padding(3);
            this.TabPage3.Size = new Size(0x29a, 0x131);
            this.TabPage3.TabIndex = 5;
            this.TabPage3.Text = "حاسبة الوسط الحسابي";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.GroupBox7.Controls.Add(this.Label2);
            this.GroupBox7.Controls.Add(this.TxTResulMid);
            this.GroupBox7.Location = new Point(8, 0x4f);
            this.GroupBox7.Name = "GroupBox7";
            this.GroupBox7.Size = new Size(0x27c, 0x69);
            this.GroupBox7.TabIndex = 5;
            this.GroupBox7.TabStop = false;
            this.GroupBox7.Text = "الوسط الحسابي للاسعار هو";
            this.Label2.Dock = DockStyle.Bottom;
            this.Label2.Location = new Point(3, 0x56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(630, 0x10);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "انقر على السعر للنسخ";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTResulMid.Dock = DockStyle.Top;
            this.TxTResulMid.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTResulMid.ForeColor = Color.Blue;
            this.TxTResulMid.Location = new Point(3, 0x13);
            this.TxTResulMid.Name = "TxTResulMid";
            this.TxTResulMid.Size = new Size(630, 0x43);
            this.TxTResulMid.TabIndex = 1;
            this.TxTResulMid.Text = "0";
            this.TxTResulMid.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonMid.FlatAppearance.BorderColor = Color.Green;
            this.ButtonMid.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonMid.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonMid.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonMid.FlatStyle = FlatStyle.Flat;
            this.ButtonMid.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonMid.Image = A.F.ImHelp;
            this.ButtonMid.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonMid.Location = new Point(8, 0x1a);
            this.ButtonMid.Margin = new Padding(3, 4, 3, 4);
            this.ButtonMid.Name = "ButtonMid";
            this.ButtonMid.Size = new Size(0x114, 0x2e);
            this.ButtonMid.TabIndex = 4;
            this.ButtonMid.Text = "احسب";
            this.ButtonMid.UseVisualStyleBackColor = true;
            this.GroupBox6.Controls.Add(this.TxTMidCount);
            this.GroupBox6.Location = new Point(290, 0x15);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new Size(0x162, 0x33);
            this.GroupBox6.TabIndex = 1;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "احسب الوسط الحساب بين عدد الأسعار التالية";
            this.TxTMidCount.BackColor = SystemColors.Info;
            this.TxTMidCount.Dock = DockStyle.Bottom;
            this.TxTMidCount.Location = new Point(3, 0x19);
            this.TxTMidCount.Name = "TxTMidCount";
            this.TxTMidCount.RightToLeft = RightToLeft.No;
            this.TxTMidCount.Size = new Size(0x15c, 0x17);
            this.TxTMidCount.TabIndex = 0;
            this.TxTMidCount.Text = "2";
            this.TxTMidCount.TextAlign = HorizontalAlignment.Center;
            this.ButtonFinish.Dock = DockStyle.Bottom;
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = A.F.ImCloseOrang;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(0, 0x19c);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x2a2, 0x2e);
            this.ButtonFinish.TabIndex = 0x1ed36d7;
            this.ButtonFinish.Text = "اغلاق";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2a2, 0x1ca);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.Label11);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "FX";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            this.Text = "حاسبة المعادلات";
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.LabelTIP.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox7.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void D(object A, EventArgs R)
        {
            Clipboard.SetText(this.TxTNetTotal.Text.Replace(",", ""));
            Interaction.MsgBox("تم النسخ للحافظة", MsgBoxStyle.ApplicationModal, null);
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
            try
            {
                if (Conversion.Val(this.TxTMidCount.Text) < 2.0)
                {
                    Interaction.MsgBox("يجب ان لا يقل عدد الآسعار عن 2", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    decimal expression = 0M;
                    int num3 = (int) Math.Round(Conversion.Val(this.TxTMidCount.Text));
                    int num4 = 1;
                    while (true)
                    {
                        if (num4 <= num3)
                        {
                            string str = "ادخل السعر رقم " + num4.ToString();
                            decimal num5 = new decimal(Conversion.Val(Interaction.InputBox(str.ToString(), "", "", -1, -1)));
                            if (decimal.Compare(num5, decimal.Zero) != 0)
                            {
                                expression = new decimal(Conversion.Val(expression) + Convert.ToDouble(num5));
                                num4++;
                                continue;
                            }
                            Interaction.MsgBox("لقد ادخلت قيمة صفر وهذا سيؤدي الى الغاء المعادلة", MsgBoxStyle.ApplicationModal, null);
                            expression = 0M;
                        }
                        if (decimal.Compare(expression, decimal.Zero) == 0)
                        {
                            this.TxTResulMid.Text = "0";
                        }
                        else
                        {
                            this.TxTResulMid.Text = new decimal(Convert.ToDouble(expression) / Conversion.Val(this.TxTMidCount.Text)).ToString(PR.VR);
                        }
                        break;
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

        private void H(object A, EventArgs R)
        {
            Clipboard.SetText(this.TxTResulMid.Text.Replace(",", ""));
            Interaction.MsgBox("تم النسخ للحافظة", MsgBoxStyle.ApplicationModal, null);
        }

        private void I(object A, EventArgs R)
        {
            this.TxTMiWi.Text = PR.AP;
            this.TxTInput.Focus();
        }

        private void P(object A, EventArgs R)
        {
            if (this.RadioButton1.Checked)
            {
                this.RadioButton2.Checked = false;
                this.LabelTIP.Text = "صافي المبلغ شامل الضريبة:";
                this.TxTDarVal.Text = "0";
                this.TxTNetTotal.Text = "0";
            }
        }

        private void Q(object A, EventArgs R)
        {
            if (this.RadioButton2.Checked)
            {
                this.RadioButton1.Checked = false;
                this.LabelTIP.Text = "صافي المبلغ قبل الضريبة (اصل المبلغ):";
                this.TxTDarVal.Text = "0";
                this.TxTNetTotal.Text = "0";
            }
        }

        private void R(object A, EventArgs R)
        {
            try
            {
                decimal num = new decimal(Conversion.Val(this.TxTMiWi.Text.Replace(",", "")));
                decimal num2 = new decimal(Conversion.Val(this.TxTInput.Text.Replace(",", "")));
                if (this.RadioButton1.Checked)
                {
                    decimal num3 = decimal.Multiply(num2, decimal.Divide(num, new decimal((long) 100)));
                    decimal num4 = decimal.Add(num2, num3);
                    this.TxTDarVal.Text = num3.ToString(PR.VR);
                    this.TxTNetTotal.Text = num4.ToString(PR.VR);
                    this.LabelTIP.Text = "صافي المبلغ شامل الضريبة:";
                }
                if (this.RadioButton2.Checked)
                {
                    decimal num5 = decimal.Multiply(new decimal((long) 100), decimal.Divide(num2, decimal.Add(new decimal((long) 100), num)));
                    this.TxTNetTotal.Text = num5.ToString(PR.VR);
                    this.TxTDarVal.Text = decimal.Multiply(num5, decimal.Divide(num, new decimal((long) 100))).ToString(PR.VR);
                    this.LabelTIP.Text = "صافي المبلغ قبل الضريبة (اصل المبلغ):";
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

        internal virtual Label Label11
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual TabPage TabPage2
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonFinish
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
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

        internal virtual GroupBox GroupBox4
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual RadioButton RadioButton1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                RadioButton a = this.A;
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

        internal virtual RadioButton RadioButton2
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
                RadioButton r = this.R;
                if (r != null)
                {
                    r.CheckedChanged -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.CheckedChanged += handler;
                }
            }
        }

        internal virtual GroupBox GroupBox3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual GroupBox LabelTIP
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Label TxTNetTotal
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
                Label r = this.R;
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

        internal virtual GroupBox GroupBox5
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label TxTDarVal
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
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
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

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.D = value);
        }

        internal virtual TextBox TxTMiWi
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonTAX
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Label TxTResulMid
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
                Label d = this.D;
                if (d != null)
                {
                    d.Click -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.Click += handler;
                }
            }
        }

        internal virtual Button ButtonMid
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual GroupBox GroupBox6
        {
            [CompilerGenerated]
            get => 
                this.H;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.H = value);
        }

        internal virtual TextBox TxTMidCount
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

