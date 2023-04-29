namespace A
{
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
    public class X : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Label1")]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerW")]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("CheckBoxTDB")]
        private CheckBox A;
        [AccessedThroughProperty("ButtonExit"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        private SqlConnection A;
        private string A;
        private string R;
        private string P;
        private string Q;
        private string I;
        private string D;
        private string F;
        private int A;

        public X()
        {
            base.Load += new EventHandler(this.Q);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = Application.StartupPath + @"\BackUpDB\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".BAK";
            this.R = AR.P;
            this.P = AR.I;
            this.I = "";
            this.D = "";
            this.F = "";
            this.A = 0;
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.Label1 = new Label();
            this.TimerW = new Timer(this.A);
            this.CheckBoxTDB = new CheckBox();
            this.ButtonExit = new Button();
            base.SuspendLayout();
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Green;
            this.Label1.ImageAlign = ContentAlignment.TopCenter;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x2b5, 0x8d);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "خيارات النسخ الاحتياطي قبل الخروج";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.TimerW.Interval = 0x3e8;
            this.CheckBoxTDB.AutoSize = true;
            this.CheckBoxTDB.BackColor = Color.WhiteSmoke;
            this.CheckBoxTDB.Checked = true;
            this.CheckBoxTDB.CheckState = CheckState.Checked;
            this.CheckBoxTDB.Dock = DockStyle.Bottom;
            this.CheckBoxTDB.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.CheckBoxTDB.Location = new Point(0, 0xe4);
            this.CheckBoxTDB.Name = "CheckBoxTDB";
            this.CheckBoxTDB.Padding = new Padding(8);
            this.CheckBoxTDB.Size = new Size(0x2b5, 0x27);
            this.CheckBoxTDB.TabIndex = 0x12;
            this.CheckBoxTDB.Text = "اخذ نسخة احتياطية من قاعدة البيانات قبل الخروج";
            this.CheckBoxTDB.UseVisualStyleBackColor = false;
            this.ButtonExit.Dock = DockStyle.Bottom;
            this.ButtonExit.FlatStyle = FlatStyle.Flat;
            this.ButtonExit.Image = A.F.ImExit;
            this.ButtonExit.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new Point(0, 0xa4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new Size(0x2b5, 0x40);
            this.ButtonExit.TabIndex = 0x13;
            this.ButtonExit.Text = "خروج واخذ نسخة احتياطية";
            this.ButtonExit.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2b5, 0x10b);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonExit);
            base.Controls.Add(this.CheckBoxTDB);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedDialog;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "BackUpClose";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "   ";
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.TimerW.Enabled = false;
            if (this.R == PR.U)
            {
                if (!((PR.Z == null) | (PR.Z == "")))
                {
                    this.F = "https://yazsys.com/CloudkBackUpDB.aspx?DBSerialNumber=" + PR.Z.ToString();
                    this.Label1.Text = "سيتم تحويلك لصفحة انشاء وتحميل نسخة احتياطية من السحابة";
                }
                else
                {
                    this.Label1.ForeColor = Color.Red;
                    this.Label1.Text = "يجب تفعيل الجهاز في رقم المتسلسل الخاص بك";
                    this.F = null;
                }
                this.ButtonExit.Enabled = true;
                this.ButtonExit.Text = "إذهب للتحميل";
            }
            else
            {
                try
                {
                    this.P = AR.I;
                    this.Q = this.A;
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    string[] textArray1 = new string[] { "USE [master] BACKUP DATABASE [", this.P.ToString(), "] TO DISK = '", this.Q.ToString(), "' WITH CHECKSUM, COPY_ONLY, FORMAT, INIT, STATS = 10;" };
                    new SqlCommand(string.Concat(textArray1), this.A) { CommandTimeout = 0 }.ExecuteNonQuery();
                    this.A.Close();
                    this.Label1.ForeColor = Color.Green;
                    this.Label1.Text = "تم اخذ نسخة احتياطية " + this.A.ToString() + " ";
                    this.ButtonExit.Enabled = true;
                    this.ButtonExit.Text = "موافق";
                    this.R();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    this.Label1.Text = "لم يتم اخذ نسخة احتياطية";
                    this.Label1.ForeColor = Color.Red;
                    this.ButtonExit.Enabled = true;
                    this.ButtonExit.Text = "موافق";
                    ProjectData.ClearProjectError();
                }
                this.ButtonExit.Enabled = true;
                this.ButtonExit.Text = "موافق";
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
            this.ButtonExit.Text = !this.CheckBoxTDB.Checked ? "خروج بدون اخذ نسخة احتياطية" : "خروج واخذ نسخة احتياطية";
        }

        private void Q(object A, EventArgs R)
        {
        }

        public void R()
        {
            // Invalid method body.
        }

        private void R(object A, EventArgs R)
        {
            // Invalid method body.
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

        internal virtual Timer TimerW
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
                Timer a = this.A;
                if (a != null)
                {
                    a.Tick -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.Tick += handler;
                }
            }
        }

        internal virtual CheckBox CheckBoxTDB
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
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

        internal virtual Button ButtonExit
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

