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
    public class K : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonMulti")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonFinish"), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("ButtonNew"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button P;
        private TextBox A;

        public K()
        {
            base.Load += new EventHandler(this.Q);
            this.A = new TextBox();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.ButtonMulti = new Button();
            this.ButtonFinish = new Button();
            this.TxTTitle = new Label();
            this.ButtonNew = new Button();
            base.SuspendLayout();
            this.ButtonMulti.FlatAppearance.BorderColor = Color.Green;
            this.ButtonMulti.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonMulti.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonMulti.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonMulti.FlatStyle = FlatStyle.Flat;
            this.ButtonMulti.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonMulti.Image = F.ImBarCode;
            this.ButtonMulti.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonMulti.Location = new Point(12, 0x34);
            this.ButtonMulti.Margin = new Padding(3, 4, 3, 4);
            this.ButtonMulti.Name = "ButtonMulti";
            this.ButtonMulti.RightToLeft = RightToLeft.Yes;
            this.ButtonMulti.Size = new Size(0x1ce, 0x2e);
            this.ButtonMulti.TabIndex = 0x92;
            this.ButtonMulti.Text = "صناعة ملصقات باركود متعددة ورق A4";
            this.ButtonMulti.UseVisualStyleBackColor = true;
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = F.ImCloseOrang;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(12, 0x9e);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x1ce, 0x2e);
            this.ButtonFinish.TabIndex = 0x91;
            this.ButtonFinish.Text = "اغلاق";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x1e4, 0x22);
            this.TxTTitle.TabIndex = 0x90;
            this.TxTTitle.Text = "صانع الباركود";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonNew.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.ButtonNew.FlatStyle = FlatStyle.Flat;
            this.ButtonNew.Image = F.ImQR;
            this.ButtonNew.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonNew.Location = new Point(12, 0x69);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new Size(0x1ce, 0x2e);
            this.ButtonNew.TabIndex = 0x93;
            this.ButtonNew.Text = "صانع الملصقات العادي - ملصق";
            this.ButtonNew.UseVisualStyleBackColor = false;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x1e4, 0xd8);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonMulti);
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ButtonNew);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "BarCodeMenu";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "صانع الباركود";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            try
            {
                new FontFamily("Bar-Code 39").Dispose();
                this.A.Font = new Font("Bar-Code 39", 28f);
                D.A.A.ShowDialog();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Interaction.MsgBox("يجب عليك تحميل ملف خط الباركود وتنصيبه ، اضغط موافق للذهاب لصفحة التحميل", MsgBoxStyle.ApplicationModal, null);
                Process.Start("https://yazsys.com/RFFontBarCode.aspx");
                ProjectData.ClearProjectError();
            }
            base.Dispose();
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
            try
            {
                new FontFamily("Bar-Code 39").Dispose();
                this.A.Font = new Font("Bar-Code 39", 28f);
                D.A.A.ShowDialog();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Interaction.MsgBox("يجب عليك تحميل ملف خط الباركود وتنصيبه ، اضغط موافق للذهاب لصفحة التحميل", MsgBoxStyle.ApplicationModal, null);
                Process.Start("https://yazsys.com/RFFontBarCode.aspx");
                ProjectData.ClearProjectError();
            }
            base.Dispose();
        }

        internal virtual Button ButtonMulti
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

        internal virtual Button ButtonFinish
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
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonNew
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

