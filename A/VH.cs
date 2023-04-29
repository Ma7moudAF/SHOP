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
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class VH : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox1")]
        private GroupBox A;
        [CompilerGenerated, AccessedThroughProperty("TxTSerial"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TextBox A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOk")]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TimerTick")]
        private System.Windows.Forms.Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTValu")]
        private TextBox R;
        [AccessedThroughProperty("WebPoint"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private WebBrowser A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("Button1")]
        private Button P;
        [AccessedThroughProperty("WebBrowserChaneName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private WebBrowser R;
        private DataSet A;
        private string A;
        private DataSet R;
        private string R;
        private string P;
        private string Q;
        private string I;
        private string D;
        private string F;
        private string H;
        private string T;
        private string X;
        private string G;
        private string E;
        private string K;
        private string U;
        private string L;
        private string N;
        private string V;
        private string Y;
        private string O;
        private string B;
        private string S;
        private string Z;
        private string M;
        private string C;
        private string J;
        private string W;
        private string AR;
        private string PR;
        private string QR;
        private string IR;
        private string DR;
        private string FR;
        private string HR;
        private string TR;
        private string XR;
        private string GR;
        private string ER;
        private SqlConnection A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private object A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private object R;

        public VH()
        {
            base.FormClosed += new FormClosedEventHandler(this.A);
            base.Load += new EventHandler(this.I);
            this.A = new DataSet();
            this.R = new DataSet();
            this.R = "SELECT * FROM TaSetting WHERE ID = 1";
            this.P = Application.StartupPath + @"\NaYaz";
            this.Q = Application.StartupPath + @"\NaYa.txt";
            this.I = Application.StartupPath + @"\NNaYaz";
            this.D = Application.StartupPath + @"\NNaYaz2";
            this.F = Application.StartupPath + @"\NNaYaz3";
            this.H = Application.StartupPath + @"\NNaYaz4";
            this.T = Application.StartupPath + @"\NSal";
            this.X = Application.StartupPath + @"\NSal3";
            this.G = Application.StartupPath + @"\NSalX";
            this.E = Application.StartupPath + @"\NSaIX";
            this.K = Application.StartupPath + @"\NaSaIX";
            this.U = Application.StartupPath + @"\MaT";
            this.L = Application.StartupPath + @"\NaSaLF";
            this.N = Application.StartupPath + @"\BS";
            this.V = Application.StartupPath + @"\NDB.mdb";
            this.Y = Application.StartupPath + @"\NDBCombact.mdb";
            this.O = Application.StartupPath + @"\Sale.dll";
            this.B = Application.StartupPath + @"\NNaYaz44";
            this.S = Application.StartupPath + @"\Qamer";
            this.Z = Application.StartupPath + @"\13388204319247134";
            this.M = Application.StartupPath + @"\18431325651841715";
            this.C = Application.StartupPath + @"\13837293723460";
            this.J = Application.StartupPath + @"\179523726832";
            this.W = Application.StartupPath + @"\14961158080804419";
            this.AR = Application.StartupPath + @"\1496115808080804419";
            this.PR = Application.StartupPath + @"\11586761189197115";
            this.QR = Application.StartupPath + @"\11436929601";
            this.IR = Application.StartupPath + @"\11333895351043817";
            this.DR = Application.StartupPath + @"\179523349544834";
            this.FR = Application.StartupPath + @"\12616697829881";
            this.HR = Application.StartupPath + @"\14772671291096217";
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.GroupBox1 = new GroupBox();
            this.Button1 = new Button();
            this.ButtonClose = new Button();
            this.ButtonOk = new Button();
            this.TxTSerial = new TextBox();
            this.TimerTick = new System.Windows.Forms.Timer(this.A);
            this.TxTValu = new TextBox();
            this.WebPoint = new WebBrowser();
            this.WebBrowserChaneName = new WebBrowser();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.ButtonClose);
            this.GroupBox1.Controls.Add(this.ButtonOk);
            this.GroupBox1.Controls.Add(this.TxTSerial);
            this.GroupBox1.Dock = DockStyle.Top;
            this.GroupBox1.Location = new Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x3d8, 0x3f);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "ادخل الرقم المتسلسل";
            this.Button1.FlatAppearance.BorderColor = Color.Green;
            this.Button1.FlatAppearance.CheckedBackColor = Color.White;
            this.Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.Button1.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.Button1.FlatStyle = FlatStyle.Flat;
            this.Button1.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Button1.ImageAlign = ContentAlignment.MiddleLeft;
            this.Button1.Location = new Point(0xbd, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new Size(0xd7, 0x2d);
            this.Button1.TabIndex = 0x1b;
            this.Button1.Text = "احصل على الرقم";
            this.Button1.UseVisualStyleBackColor = true;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = A.F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(12, 12);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0xa7, 0x2d);
            this.ButtonClose.TabIndex = 0x1b;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = A.F.Im_LogOk;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(410, 12);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0xa7, 0x2d);
            this.ButtonOk.TabIndex = 0x19;
            this.ButtonOk.Text = "موافق";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.TxTSerial.BackColor = SystemColors.Info;
            this.TxTSerial.Font = new Font("Tahoma", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTSerial.Location = new Point(0x247, 0x16);
            this.TxTSerial.Name = "TxTSerial";
            this.TxTSerial.RightToLeft = RightToLeft.No;
            this.TxTSerial.Size = new Size(0x185, 0x20);
            this.TxTSerial.TabIndex = 0;
            this.TxTSerial.TextAlign = HorizontalAlignment.Center;
            this.TimerTick.Interval = 0x3e8;
            this.TxTValu.Location = new Point(60, 800);
            this.TxTValu.Name = "TxTValu";
            this.TxTValu.Size = new Size(0x209, 0x17);
            this.TxTValu.TabIndex = 0x1c;
            this.WebPoint.Dock = DockStyle.Fill;
            this.WebPoint.Location = new Point(0, 0x3f);
            this.WebPoint.MinimumSize = new Size(20, 20);
            this.WebPoint.Name = "WebPoint";
            this.WebPoint.Size = new Size(0x3d8, 0x2af);
            this.WebPoint.TabIndex = 0x1d;
            this.WebBrowserChaneName.Location = new Point(0x29f, 0x319);
            this.WebBrowserChaneName.MinimumSize = new Size(20, 20);
            this.WebBrowserChaneName.Name = "WebBrowserChaneName";
            this.WebBrowserChaneName.Size = new Size(0x74, 0x5c);
            this.WebBrowserChaneName.TabIndex = 0x1f;
            base.AcceptButton = this.ButtonOk;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3d8, 750);
            base.Controls.Add(this.WebPoint);
            base.Controls.Add(this.WebBrowserChaneName);
            base.Controls.Add(this.TxTValu);
            base.Controls.Add(this.GroupBox1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.KeyPreview = true;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "SerialAdd";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "شراء النظام";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        public string A(string A)
        {
            string str2 = "GUAanKEgLhNuYnXvJBVQiXs";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
            }
        }

        private void A(object A, EventArgs R)
        {
            this.TxTSerial.Text = this.TxTSerial.Text.Replace(" ", "").Trim();
            string[] textArray1 = new string[] { "https://yazsys.com/NNSSCheckSerial.aspx?DBSerialNumber=", this.TxTSerial.Text.Trim(), "&DevProsserID=", A.PR.W.ToString(), "&DevProsserBi=", A.PR.C.ToString() };
            this.WebPoint.Navigate(string.Concat(textArray1));
            this.TimerTick.Enabled = true;
        }

        private void A(object A, FormClosedEventArgs R)
        {
            base.Dispose();
        }

        private void A(object A, WebBrowserDocumentCompletedEventArgs R)
        {
            this.V();
        }

        public void D()
        {
            // Invalid method body.
        }

        public string D(string A)
        {
            string str2 = "sspqksGuNeoQZTmiXDXpvXd";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
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

        public void E()
        {
            // Invalid method body.
        }

        public void F()
        {
            // Invalid method body.
        }

        public string F(string A)
        {
            string str2 = "eIWHRpDWIQOYBCMapkqcthb";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
            }
        }

        public void G()
        {
            // Invalid method body.
        }

        public void H()
        {
            // Invalid method body.
        }

        public string H(string A)
        {
            string str2 = "dFwnVPhGfvCqKwGfKYBXmPS";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
            }
        }

        public void I()
        {
            // Invalid method body.
        }

        public string I(string A)
        {
            string str2 = "PWZhMpQvwPOfJCGPqXTWKdq";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
            }
        }

        private void I(object A, EventArgs R)
        {
        }

        protected void K()
        {
            // Invalid method body.
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public void L()
        {
            try
            {
                string str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Application.StartupPath + this.X(":"), NewLateBinding.LateGet(NewLateBinding.LateGet(this.ClassString, null, "ViewLogoImage", new object[0], null, null, null), null, "Trim", new object[0], null, null, null)));
                string str2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Application.StartupPath + this.X(":"), NewLateBinding.LateGet(NewLateBinding.LateGet(this.ClassString, null, "ColorsStyle", new object[0], null, null, null), null, "Trim", new object[0], null, null, null)));
                if ((NewLateBinding.LateGet(this.ClassString, null, "ViewLogoImage", new object[0], null, null, null).ToString() == "") | (NewLateBinding.LateGet(this.ClassString, null, "ColorsStyle", new object[0], null, null, null).ToString() == ""))
                {
                    ProjectData.EndApp();
                }
                if (File.Exists(str.ToString()) & File.Exists(str2.Trim()))
                {
                    object[] arguments = new object[] { this.X(")" + Conversions.ToString(Strings.Chr(0xb8))) };
                    NewLateBinding.LateSetComplex(this.ClassString, null, "ToViewIcon", arguments, null, null, false, true);
                }
                else
                {
                    object[] arguments = new object[] { this.X("(" + Conversions.ToString(Strings.Chr(0xbc))) };
                    NewLateBinding.LateSetComplex(this.ClassString, null, "ToViewIcon", arguments, null, null, false, true);
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.EndApp();
                ProjectData.ClearProjectError();
            }
        }

        public void N()
        {
            // Invalid method body.
        }

        public void P()
        {
            // Invalid method body.
        }

        public string P(string A)
        {
            string str2 = "cdklvIegqKlooHLHYmJeucY";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
            }
        }

        private void P(object A, EventArgs R)
        {
            // Invalid method body.
        }

        public void Q()
        {
            // Invalid method body.
        }

        public string Q(string A)
        {
            string str2 = "SSZWXuQGLOEsFhlwOksthfM";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
            }
        }

        private void Q(object A, EventArgs R)
        {
            if (A.PR.Q)
            {
                Interaction.MsgBox("اتصل على رقم المندوب\r\n" + A.PR.L.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                Process.Start("https://yazsys.com/GetSerialAr.aspx");
                base.Dispose();
            }
        }

        public void R()
        {
            // Invalid method body.
        }

        public string R(string A)
        {
            string str2 = "uswMPsHalUQlHjXWeYuttRQ";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
            }
        }

        private void R(object A, EventArgs R)
        {
            base.Dispose();
        }

        public void T()
        {
            // Invalid method body.
        }

        public string T(string A)
        {
            string str2 = "MIiiZsTGZPLXQNQrukfYrpM";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
            }
        }

        public void U()
        {
            // Invalid method body.
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public void V()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                SqlCommand command = new SqlCommand("UPDATE TaNNCenters SET CenterName =@CenterName WHERE (CenterEditName = @CenterEditName)", this.A);
                command.Parameters.AddWithValue("CenterEditName", "1200");
                command.Parameters.AddWithValue("CenterName", this.WebBrowserChaneName.Document.Title);
                command.ExecuteNonQuery();
                this.A.Close();
                Interaction.MsgBox(A.PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                A.D.A.A.Show();
                ProjectData.EndApp();
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString() + this.WebBrowserChaneName.Document.Title, MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        public void X()
        {
            // Invalid method body.
        }

        public string X(string A)
        {
            string str2 = "QSeUoUkdIUAmWkVQBnDEqYa";
            int index = 0;
            int num2 = 0;
            StringBuilder builder = new StringBuilder();
            string str3 = string.Empty;
            int[] numArray = new int[0x101];
            int[] numArray2 = new int[0x101];
            int length = str2.Length;
            int location = 0;
            while (true)
            {
                if (location > 0xff)
                {
                    int num5 = 0;
                    int num6 = 0;
                    while (true)
                    {
                        if (num6 > 0xff)
                        {
                            location = 1;
                            while (true)
                            {
                                if (location > A.Length)
                                {
                                    str3 = builder.ToString();
                                    builder.Length = 0;
                                    return str3;
                                }
                                index = (index + 1) % 0x100;
                                num2 = (num2 + numArray[index]) % 0x100;
                                numArray[index] = numArray[num2];
                                numArray[num2] = numArray[index];
                                int num9 = numArray[(numArray[index] + numArray[num2]) % 0x100];
                                char ch2 = A.Substring(location - 1, 1).ToCharArray()[0];
                                int charCode = Strings.Asc(ch2) ^ num9;
                                builder.Append(Strings.Chr(charCode));
                                int num12 = Interlocked.Increment(ref location);
                                Math.Max(num12, location - 1);
                            }
                        }
                        num5 = ((num5 + numArray[num6]) + numArray2[num6]) % 0x100;
                        int num7 = numArray[num6];
                        numArray[num6] = numArray[num5];
                        numArray[num5] = num7;
                        int num11 = Interlocked.Increment(ref num6);
                        Math.Max(num11, num6 - 1);
                    }
                }
                char ch = str2.Substring(location % length, 1).ToCharArray()[0];
                numArray2[location] = Strings.Asc(ch);
                numArray[location] = location;
                int num1 = Interlocked.Increment(ref location);
                Math.Max(num1, location - 1);
            }
        }

        internal virtual GroupBox GroupBox1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTSerial
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

        internal virtual Button ButtonClose
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

        internal virtual System.Windows.Forms.Timer TimerTick
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.P);
                System.Windows.Forms.Timer a = this.A;
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

        internal virtual TextBox TxTValu
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual WebBrowser WebPoint
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button Button1
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual WebBrowser WebBrowserChaneName
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                WebBrowserDocumentCompletedEventHandler handler = new WebBrowserDocumentCompletedEventHandler(this.A);
                WebBrowser r = this.R;
                if (r != null)
                {
                    r.DocumentCompleted -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.DocumentCompleted += handler;
                }
            }
        }

        public object ClassString
        {
            [CompilerGenerated]
            get => 
                this.A;
            [CompilerGenerated]
            set => 
                (this.A = value);
        }

        public object FS1
        {
            [CompilerGenerated]
            get => 
                this.R;
            [CompilerGenerated]
            set => 
                (this.R = value);
        }
    }
}

