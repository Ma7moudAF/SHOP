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
    public class CH : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TextBoxError")]
        private TextBox A;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("Label2")]
        private Label P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("ButtonFix")]
        private Button A;
        private string A;

        public CH()
        {
            base.Load += new EventHandler(this.A);
            this.A = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\YAZSYS";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(CH));
            this.TextBoxError = new TextBox();
            this.TxTTitle = new Label();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.ButtonFix = new Button();
            base.SuspendLayout();
            this.TextBoxError.BackColor = Color.WhiteSmoke;
            this.TextBoxError.Dock = DockStyle.Bottom;
            this.TextBoxError.Location = new Point(0, 0xc7);
            this.TextBoxError.Multiline = true;
            this.TextBoxError.Name = "TextBoxError";
            this.TextBoxError.ReadOnly = true;
            this.TextBoxError.RightToLeft = RightToLeft.No;
            this.TextBoxError.Size = new Size(0x3b0, 0x75);
            this.TextBoxError.TabIndex = 0;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3b0, 0x22);
            this.TxTTitle.TabIndex = 0x63;
            this.TxTTitle.Text = "فشل الاتصال مع الخادم";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Black;
            this.Label1.Location = new Point(0, 0x22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x3b0, 0x26);
            this.Label1.TabIndex = 100;
            this.Label1.Text = "تحقق من الامور التالية:";
            this.Label1.TextAlign = ContentAlignment.MiddleLeft;
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = Color.Black;
            this.Label2.Location = new Point(0, 0x48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x3b0, 0x52);
            this.Label2.TabIndex = 0x65;
            this.Label2.Text = manager.GetString("Label2.Text");
            this.ButtonFix.BackColor = Color.WhiteSmoke;
            this.ButtonFix.Dock = DockStyle.Top;
            this.ButtonFix.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFix.ForeColor = Color.FromArgb(0xc0, 0, 0);
            this.ButtonFix.Location = new Point(0, 0x9a);
            this.ButtonFix.Name = "ButtonFix";
            this.ButtonFix.Size = new Size(0x3b0, 0x29);
            this.ButtonFix.TabIndex = 0x66;
            this.ButtonFix.Text = "انقر لفحص الاسباب المحتملة واصلاحها";
            this.ButtonFix.UseVisualStyleBackColor = false;
            this.ButtonFix.Visible = false;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3b0, 0x13c);
            base.Controls.Add(this.ButtonFix);
            base.Controls.Add(this.Label2);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.TextBoxError);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "StartPointError";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "فشل الاتصال";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(string A)
        {
            // Invalid method body.
        }

        private void A(object A, EventArgs R)
        {
            string text = this.TextBoxError.Text;
            if (text.Contains("AppData"))
            {
                this.ButtonFix.Visible = true;
                this.A(this.A);
            }
            else if (text.Contains("attachdbfilename"))
            {
                this.ButtonFix.Visible = true;
            }
            else if (text.Contains("error: 52"))
            {
                this.ButtonFix.Visible = true;
            }
            else if (text.Contains("error: 50"))
            {
                this.ButtonFix.Visible = true;
            }
            else if (text.Contains("Version"))
            {
                this.ButtonFix.Visible = true;
            }
            else
            {
                this.ButtonFix.Visible = text.Contains("DB.MDF");
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

        private void R(object A, EventArgs R)
        {
            string text = this.TextBoxError.Text;
            if (text.Contains("AppData"))
            {
                if (Interaction.MsgBox("قد يكون سبب هذا الخطأ هو مجلد التطبيقات للويندوز يجب عليك تنظيفه، هل تريد تطبيق الاصلاح الان؟", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
                {
                    D.A.A.ShowDialog();
                }
            }
            else if (text.Contains("error: 50"))
            {
                if (Interaction.MsgBox("قد يكون سبب هذا الخطأ هو توقف مشغل قواعد البيانات، هل تريد تطبيق الاصلاح الان؟", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
                {
                    D.A.A.ShowDialog();
                }
            }
            else if (text.Contains("error: 40"))
            {
                Interaction.MsgBox("يجب مراجعة اسم الخادم الذي تتصل به", MsgBoxStyle.ApplicationModal, null);
            }
            else if (text.Contains("attachdbfilename"))
            {
                Interaction.MsgBox("قد يكون سبب هذا الخطأ هو مشكلة  net framework يجب عليك اعادة تنصيب  net framework 3.5   او اصدار احدث ", MsgBoxStyle.ApplicationModal, null);
            }
            else if (text.Contains("Version"))
            {
                Interaction.MsgBox("قد يكون سبب هذا الخطأ هو مشكلة مشغل قواعد البيانات لديك قديم، يجب استخدام مشغل احدث", MsgBoxStyle.ApplicationModal, null);
            }
            else if (!text.Contains("error: 52"))
            {
                this.ButtonFix.Visible = false;
            }
            else if (Interaction.MsgBox("قد يكون سبب هذا الخطأ هو اختلاف اسم الخادم مع الاصدار المتوفر لديك، او عدم تثبيت مشغل قواعد البيانات هل تريد تثبيته", MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                Process.Start("https://yazsys.com/RFSQLServerLocal.aspx");
            }
        }

        internal virtual TextBox TextBoxError
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label2
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonFix
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
    }
}

