namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class G : Form
    {
        private IContainer A;
        [AccessedThroughProperty("LabelTxT"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("OpenFileDialog1"), CompilerGenerated]
        private OpenFileDialog A;
        [AccessedThroughProperty("SaveFileDialog1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private SaveFileDialog A;
        [CompilerGenerated, AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [AccessedThroughProperty("ButtonBackUp"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [AccessedThroughProperty("ButtonRestor"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerBackUp"), CompilerGenerated]
        private Timer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TimerRestore"), CompilerGenerated]
        private Timer R;
        [AccessedThroughProperty("FolderBrowserDialog1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private FolderBrowserDialog A;
        private SqlConnection A;

        public G()
        {
            base.Load += new EventHandler(this.D);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(G));
            this.LabelTxT = new Label();
            this.OpenFileDialog1 = new OpenFileDialog();
            this.SaveFileDialog1 = new SaveFileDialog();
            this.TxTTitle = new Label();
            this.ButtonClose = new Button();
            this.ButtonRestor = new Button();
            this.ButtonBackUp = new Button();
            this.TimerBackUp = new Timer(this.A);
            this.TimerRestore = new Timer(this.A);
            this.FolderBrowserDialog1 = new FolderBrowserDialog();
            base.SuspendLayout();
            this.LabelTxT.BackColor = Color.WhiteSmoke;
            this.LabelTxT.Dock = DockStyle.Bottom;
            this.LabelTxT.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.LabelTxT.Location = new Point(0, 0xdb);
            this.LabelTxT.Name = "LabelTxT";
            this.LabelTxT.Size = new Size(0x228, 0x43);
            this.LabelTxT.TabIndex = 120;
            this.LabelTxT.Text = "في حال الاتصال مع الخادم سيتوقف النظام عن اخذ النسخ الاحتياطية لقاعدة البيانات بشكل تلقائي، يجب عليك اخذ نسخة احتياطية من قواعد البينات بشكل دوري.";
            this.LabelTxT.TextAlign = ContentAlignment.MiddleLeft;
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x228, 0x2f);
            this.TxTTitle.TabIndex = 0x19;
            this.TxTTitle.Text = "النسخ الاحتياطي والاستعادة";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImFinish;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0x10, 0xa3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x20c, 0x2d);
            this.ButtonClose.TabIndex = 0x18;
            this.ButtonClose.Text = "انهاء";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonRestor.FlatAppearance.BorderColor = Color.Green;
            this.ButtonRestor.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonRestor.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonRestor.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonRestor.FlatStyle = FlatStyle.Flat;
            this.ButtonRestor.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonRestor.Image = F.ImDataRefresh;
            this.ButtonRestor.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonRestor.Location = new Point(0x10, 0x6f);
            this.ButtonRestor.Name = "ButtonRestor";
            this.ButtonRestor.Size = new Size(0x20c, 0x2d);
            this.ButtonRestor.TabIndex = 0x16;
            this.ButtonRestor.Text = "استعادة نسخة احتياطية على هذا الجهاز";
            this.ButtonRestor.UseVisualStyleBackColor = true;
            this.ButtonBackUp.FlatAppearance.BorderColor = Color.Green;
            this.ButtonBackUp.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonBackUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonBackUp.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonBackUp.FlatStyle = FlatStyle.Flat;
            this.ButtonBackUp.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonBackUp.Image = F.ImDataOk;
            this.ButtonBackUp.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonBackUp.Location = new Point(0x10, 0x3b);
            this.ButtonBackUp.Name = "ButtonBackUp";
            this.ButtonBackUp.Size = new Size(0x20c, 0x2d);
            this.ButtonBackUp.TabIndex = 0x17;
            this.ButtonBackUp.Text = "اخذ نسخة احتياطية لقاعدة البيانات الحالية";
            this.ButtonBackUp.UseVisualStyleBackColor = true;
            this.TimerBackUp.Interval = 500;
            this.TimerRestore.Interval = 500;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x228, 0x11e);
            base.ControlBox = false;
            base.Controls.Add(this.LabelTxT);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.ButtonBackUp);
            base.Controls.Add(this.ButtonRestor);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "BackUpDB";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "النسخ الاحتياطي والاستعادة";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            base.Dispose();
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

        private void I(object A, EventArgs R)
        {
            this.TimerRestore.Enabled = false;
            this.TxTTitle.Text = PR.A.ToString();
            this.TxTTitle.ForeColor = Color.Red;
            this.TxTTitle.Font = new Font("Tahoma", 15f);
            this.P();
        }

        public void P()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Connect Timeout=30;");
            string str = "";
            string str2 = "";
            try
            {
                string str5;
                OpenFileDialog dialog = this.OpenFileDialog1;
                dialog.DefaultExt = "BAK";
                dialog.FileName = "";
                dialog.Filter = "BAK files (*.BAK)|*.BAK|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.Title = "Open BackUp";
                dialog = null;
                if (this.OpenFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    this.TxTTitle.Text = this.Text;
                    this.TxTTitle.ForeColor = Color.DarkGreen;
                    this.TxTTitle.Font = new Font("Tahoma", 12f);
                    return;
                }
                else
                {
                    string fileName = this.OpenFileDialog1.FileName;
                    string file = Application.StartupPath + @"\TempBack.BAK";
                    if (A.D.A.FileSystem.FileExists(file))
                    {
                        A.D.A.FileSystem.DeleteFile(file);
                    }
                    A.D.A.FileSystem.CopyFile(fileName, file);
                    str5 = file.ToString();
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    using (SqlCommand command = new SqlCommand("RESTORE FILELISTONLY FROM DISK = '" + str5.ToString() + "'", connection))
                    {
                        IEnumerator enumerator;
                        DataTable dataTable = new DataTable();
                        new SqlDataAdapter(command).Fill(dataTable);
                        try
                        {
                            enumerator = dataTable.Rows.GetEnumerator();
                            while (true)
                            {
                                if (!enumerator.MoveNext())
                                {
                                    break;
                                }
                                DataRow current = (DataRow) enumerator.Current;
                                str2 = Conversions.ToString(current["LogicalName"]);
                                str = str2.Replace("_log", "");
                            }
                        }
                        finally
                        {
                            if (enumerator is IDisposable)
                            {
                                (enumerator as IDisposable).Dispose();
                            }
                        }
                    }
                }
                connection.Close();
                try
                {
                    string str7 = Application.StartupPath + @"\DB\DB.mdf";
                    string str8 = Application.StartupPath + @"\DB\DB.mdf";
                    string str9 = Application.StartupPath + @"\DB\DB.ldf";
                    SqlConnection.ClearAllPools();
                    SqlConnection connection2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; Connect Timeout=30;");
                    if (connection2.State == ConnectionState.Closed)
                    {
                        connection2.Open();
                    }
                    new SqlCommand("USE [master] ALTER DATABASE [" + str7.ToString() + "] SET OFFLINE WITH ROLLBACK IMMEDIATE", connection2) { CommandTimeout = 0 }.ExecuteNonQuery();
                    connection2.Close();
                    if (connection2.State == ConnectionState.Closed)
                    {
                        connection2.Open();
                    }
                    string[] textArray1 = new string[13];
                    textArray1[0] = "USE [master] RESTORE DATABASE [";
                    textArray1[1] = str7.ToString();
                    textArray1[2] = "] FROM DISK = '";
                    textArray1[3] = str5.ToString();
                    textArray1[4] = "' WITH MOVE '";
                    textArray1[5] = str.ToString();
                    textArray1[6] = "' TO '";
                    textArray1[7] = str8.ToString();
                    textArray1[8] = "', MOVE '";
                    textArray1[9] = str2.ToString();
                    textArray1[10] = "' TO '";
                    textArray1[11] = str9.ToString();
                    textArray1[12] = "', REPLACE ;";
                    new SqlCommand(string.Concat(textArray1), connection2) { CommandTimeout = 0 }.ExecuteNonQuery();
                    connection2.Close();
                    if (connection2.State == ConnectionState.Closed)
                    {
                        connection2.Open();
                    }
                    new SqlCommand("USE [master] ALTER DATABASE [" + str7.ToString() + "] SET ONLINE WITH ROLLBACK IMMEDIATE", connection2) { CommandTimeout = 0 }.ExecuteNonQuery();
                    connection2.Close();
                    this.TxTTitle.Text = this.Text;
                    this.TxTTitle.ForeColor = Color.DarkGreen;
                    this.TxTTitle.Font = new Font("Tahoma", 12f);
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    Interaction.MsgBox("تم الاستعادة على قاعدة البيانات في المسار  " + (Application.StartupPath + @"\DB\DB.mdf").ToString(), MsgBoxStyle.ApplicationModal, null);
                    A.D.A.A.Show();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Exception exception = ex;
                    this.TxTTitle.Text = this.Text;
                    this.TxTTitle.ForeColor = Color.DarkGreen;
                    this.TxTTitle.Font = new Font("Tahoma", 12f);
                    Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                }
            }
            catch (Exception exception3)
            {
                Exception ex = exception3;
                ProjectData.SetProjectError(ex);
                Exception exception2 = ex;
                this.TxTTitle.Text = this.Text;
                this.TxTTitle.ForeColor = Color.DarkGreen;
                this.TxTTitle.Font = new Font("Tahoma", 12f);
                Interaction.MsgBox("تعذر فتح ملف النسخة الاحتياطية المحدد", MsgBoxStyle.ApplicationModal, null);
                Interaction.MsgBox(exception2.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void P(object A, EventArgs R)
        {
            this.ButtonBackUp.Text = PR.A.ToString();
            this.TimerBackUp.Enabled = true;
        }

        private void Q(object A, EventArgs R)
        {
            this.TimerBackUp.Enabled = false;
            this.R();
        }

        private void R()
        {
            Application.DoEvents();
            string i = AR.I;
            if (AR.P == PR.U)
            {
                try
                {
                    if ((PR.Z == null) | (PR.Z == ""))
                    {
                        Interaction.MsgBox("انت تستخدم اتصال سحابي، يجب تفعيل هذا الجهاز برقم متسلسل", MsgBoxStyle.ApplicationModal, null);
                        base.Dispose();
                    }
                    else
                    {
                        Interaction.MsgBox("انت تستخدم اتصال سحابي سيتم تحويلك لصفحة انشاء نسخة احتياطية لتحميلها", MsgBoxStyle.ApplicationModal, null);
                        string str6 = "https://yazsys.com/CloudkBackUpDB.aspx?DBSerialNumber=" + PR.Z.ToString();
                        base.Dispose();
                    }
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    MessageBox.Show(ex.Message);
                    base.Dispose();
                    ProjectData.ClearProjectError();
                }
            }
            else
            {
                string fileName = this.SaveFileDialog1.FileName;
                try
                {
                    SaveFileDialog dialog = this.SaveFileDialog1;
                    dialog.DefaultExt = "BAK";
                    dialog.FileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                    dialog.Filter = "BAK files (*.BAK)|*.BAK|All files (*.*)|*.*";
                    dialog.FilterIndex = 1;
                    dialog.OverwritePrompt = true;
                    dialog.Title = "Save BackUp";
                    dialog = null;
                    if (this.SaveFileDialog1.ShowDialog() != DialogResult.OK)
                    {
                        base.Dispose();
                    }
                    else
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        SqlConnection.ClearAllPools();
                        string[] textArray1 = new string[] { "USE [master] BACKUP DATABASE [", i.ToString(), "] TO DISK = '", this.SaveFileDialog1.FileName, "' WITH CHECKSUM, COPY_ONLY, FORMAT, INIT, STATS = 10;" };
                        new SqlCommand(string.Concat(textArray1), this.A) { CommandTimeout = 0 }.ExecuteNonQuery();
                        this.A.Close();
                        MessageBox.Show(PR.P.ToString(), " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        base.Dispose();
                    }
                }
                catch (Exception exception3)
                {
                    Exception ex = exception3;
                    ProjectData.SetProjectError(ex);
                    MessageBox.Show(ex.Message);
                    base.Dispose();
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void R(object A, EventArgs R)
        {
            // Invalid method body.
        }

        internal virtual Label LabelTxT
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual OpenFileDialog OpenFileDialog1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual SaveFileDialog SaveFileDialog1
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonClose
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

        internal virtual Button ButtonBackUp
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

        internal virtual Button ButtonRestor
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

        internal virtual Timer TimerBackUp
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual Timer TimerRestore
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
                Timer r = this.R;
                if (r != null)
                {
                    r.Tick -= handler;
                }
                this.R = value;
                r = this.R;
                if (r != null)
                {
                    r.Tick += handler;
                }
            }
        }

        internal virtual FolderBrowserDialog FolderBrowserDialog1
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

