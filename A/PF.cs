namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class PF : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabControl A;
        [AccessedThroughProperty("TabPage1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage A;
        [AccessedThroughProperty("TabPage2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TabPage R;
        [AccessedThroughProperty("TxTTitle"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("GV"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView A;
        [AccessedThroughProperty("TxTExportPath"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label R;
        [CompilerGenerated, AccessedThroughProperty("ButtonBrows"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button A;
        [CompilerGenerated, AccessedThroughProperty("FolderBrowserDialogExport"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private FolderBrowserDialog A;
        [CompilerGenerated, AccessedThroughProperty("TimerStartExport"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer A;
        [AccessedThroughProperty("CheckExportEmpty"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CheckBox A;
        [CompilerGenerated, AccessedThroughProperty("TxTImporttPath"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label P;
        [CompilerGenerated, AccessedThroughProperty("ButtonImport"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ProgressBar1"), CompilerGenerated]
        private ProgressBar A;
        [AccessedThroughProperty("OpenFileDialogImport"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private OpenFileDialog A;
        [AccessedThroughProperty("TimerImport"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Timer R;
        [AccessedThroughProperty("ProgressBarGroup"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ProgressBar R;
        [AccessedThroughProperty("GVG"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private DataGridView R;
        [AccessedThroughProperty("Label2"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label Q;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label I;
        [AccessedThroughProperty("ButtonClose"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Button P;
        private string A;
        private string R;

        public PF()
        {
            base.Load += new EventHandler(this.D);
            this.A = "خطأ في الاتصال مع نوع الملف المحدد";
            this.R = "حدد ملف قاعدة البيانات";
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.A = new System.ComponentModel.Container();
            this.TabControl1 = new TabControl();
            this.TabPage1 = new TabPage();
            this.CheckExportEmpty = new CheckBox();
            this.TxTExportPath = new Label();
            this.ButtonBrows = new Button();
            this.Label2 = new Label();
            this.TabPage2 = new TabPage();
            this.ProgressBarGroup = new ProgressBar();
            this.TxTImporttPath = new Label();
            this.ButtonImport = new Button();
            this.Label1 = new Label();
            this.TxTTitle = new Label();
            this.GV = new DataGridView();
            this.FolderBrowserDialogExport = new FolderBrowserDialog();
            this.TimerStartExport = new Timer(this.A);
            this.ProgressBar1 = new ProgressBar();
            this.OpenFileDialogImport = new OpenFileDialog();
            this.TimerImport = new Timer(this.A);
            this.GVG = new DataGridView();
            this.ButtonClose = new Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            ((ISupportInitialize) this.GVG).BeginInit();
            base.SuspendLayout();
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0x22);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(10, 5);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(0x3b0, 0xd7);
            this.TabControl1.TabIndex = 0x70;
            this.TabPage1.Controls.Add(this.CheckExportEmpty);
            this.TabPage1.Controls.Add(this.TxTExportPath);
            this.TabPage1.Controls.Add(this.ButtonBrows);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Location = new Point(4, 0x1d);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x3a8, 0xb6);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "تصدير الى ملف";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.CheckExportEmpty.AutoSize = true;
            this.CheckExportEmpty.Location = new Point(0x1ad, 0x8e);
            this.CheckExportEmpty.Name = "CheckExportEmpty";
            this.CheckExportEmpty.Size = new Size(0x1e9, 20);
            this.CheckExportEmpty.TabIndex = 0x5c;
            this.CheckExportEmpty.Text = "انشاء ملف قالب قاعدة بيانات فارغ خارجي، يمكنك استخدامه وتعبئة البيانات من خلاله";
            this.CheckExportEmpty.UseVisualStyleBackColor = true;
            this.TxTExportPath.BackColor = Color.WhiteSmoke;
            this.TxTExportPath.Dock = DockStyle.Top;
            this.TxTExportPath.Location = new Point(3, 0x61);
            this.TxTExportPath.Name = "TxTExportPath";
            this.TxTExportPath.RightToLeft = RightToLeft.Yes;
            this.TxTExportPath.Size = new Size(930, 0x1d);
            this.TxTExportPath.TabIndex = 90;
            this.TxTExportPath.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonBrows.Dock = DockStyle.Top;
            this.ButtonBrows.FlatAppearance.BorderColor = Color.Green;
            this.ButtonBrows.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonBrows.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonBrows.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonBrows.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonBrows.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonBrows.Location = new Point(3, 0x25);
            this.ButtonBrows.Margin = new Padding(3, 4, 3, 4);
            this.ButtonBrows.Name = "ButtonBrows";
            this.ButtonBrows.RightToLeft = RightToLeft.Yes;
            this.ButtonBrows.Size = new Size(930, 60);
            this.ButtonBrows.TabIndex = 0x59;
            this.ButtonBrows.Text = "تحديد مكان حفظ الملف";
            this.ButtonBrows.UseVisualStyleBackColor = true;
            this.Label2.Dock = DockStyle.Top;
            this.Label2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.ForeColor = Color.Green;
            this.Label2.Location = new Point(3, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(930, 0x22);
            this.Label2.TabIndex = 0x72;
            this.Label2.Text = "تصدير";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.TabPage2.Controls.Add(this.ProgressBarGroup);
            this.TabPage2.Controls.Add(this.TxTImporttPath);
            this.TabPage2.Controls.Add(this.ButtonImport);
            this.TabPage2.Controls.Add(this.Label1);
            this.TabPage2.Location = new Point(4, 0x1d);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new Size(0x39d, 0xb6);
            this.TabPage2.TabIndex = 5;
            this.TabPage2.Text = "استيراد من ملف";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ProgressBarGroup.Dock = DockStyle.Bottom;
            this.ProgressBarGroup.Location = new Point(0, 0x8a);
            this.ProgressBarGroup.Name = "ProgressBarGroup";
            this.ProgressBarGroup.Size = new Size(0x39d, 0x2c);
            this.ProgressBarGroup.TabIndex = 0x73;
            this.ProgressBarGroup.Visible = false;
            this.TxTImporttPath.BackColor = Color.WhiteSmoke;
            this.TxTImporttPath.Dock = DockStyle.Top;
            this.TxTImporttPath.Location = new Point(0, 0x5e);
            this.TxTImporttPath.Name = "TxTImporttPath";
            this.TxTImporttPath.RightToLeft = RightToLeft.Yes;
            this.TxTImporttPath.Size = new Size(0x39d, 0x1d);
            this.TxTImporttPath.TabIndex = 0x5b;
            this.TxTImporttPath.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonImport.Dock = DockStyle.Top;
            this.ButtonImport.FlatAppearance.BorderColor = Color.Green;
            this.ButtonImport.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonImport.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonImport.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonImport.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonImport.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonImport.Location = new Point(0, 0x22);
            this.ButtonImport.Margin = new Padding(3, 4, 3, 4);
            this.ButtonImport.Name = "ButtonImport";
            this.ButtonImport.RightToLeft = RightToLeft.Yes;
            this.ButtonImport.Size = new Size(0x39d, 60);
            this.ButtonImport.TabIndex = 90;
            this.ButtonImport.Text = "تحديد الملف";
            this.ButtonImport.UseVisualStyleBackColor = true;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.Green;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x39d, 0x22);
            this.Label1.TabIndex = 0x74;
            this.Label1.Text = "استيراد";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x3b0, 0x22);
            this.TxTTitle.TabIndex = 0x71;
            this.TxTTitle.Text = "استيراد | تصدير";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.Location = new Point(10, 0x238);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.RightToLeft = RightToLeft.Yes;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x677, 0x9d);
            this.GV.TabIndex = 0x52;
            this.TimerStartExport.Interval = 500;
            this.ProgressBar1.Dock = DockStyle.Bottom;
            this.ProgressBar1.Location = new Point(0, 0x13b);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new Size(0x3b0, 0x17);
            this.ProgressBar1.TabIndex = 0x72;
            this.ProgressBar1.Visible = false;
            this.TimerImport.Interval = 500;
            this.GVG.AllowUserToAddRows = false;
            this.GVG.AllowUserToDeleteRows = false;
            this.GVG.Location = new Point(10, 0x246);
            this.GVG.MultiSelect = false;
            this.GVG.Name = "GVG";
            this.GVG.RightToLeft = RightToLeft.Yes;
            this.GVG.RowHeadersVisible = false;
            this.GVG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVG.Size = new Size(0x674, 0x9d);
            this.GVG.TabIndex = 0x74;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0, 0xff);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.RightToLeft = RightToLeft.Yes;
            this.ButtonClose.Size = new Size(0x3b0, 60);
            this.ButtonClose.TabIndex = 0x75;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3b0, 0x152);
            base.ControlBox = false;
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.GVG);
            base.Controls.Add(this.ProgressBar1);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialImportExport";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "استيراد | تصدير";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
            ((ISupportInitialize) this.GVG).EndInit();
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            try
            {
                if (this.FolderBrowserDialogExport.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                else
                {
                    string file = Application.StartupPath + @"\ImportExport.mdb";
                    string destinationFileName = this.FolderBrowserDialogExport.SelectedPath + @"\" + DateTime.Now.ToString("yyyy_MM_dd-HH_mm_ss") + ".mdb";
                    this.TxTExportPath.Text = destinationFileName.ToString();
                    if (A.D.A.FileSystem.FileExists(file))
                    {
                        A.D.A.FileSystem.CopyFile(file, destinationFileName);
                    }
                    else
                    {
                        Interaction.MsgBox("تعذر تحديد الملف الأساسي في مجلد النظام الرئيسي، يجب عليك تحديث النظام او اعادة تثبيت النظام", MsgBoxStyle.ApplicationModal, null);
                        return;
                    }
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
                return;
            }
            if (!this.CheckExportEmpty.Checked)
            {
                try
                {
                    string text1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.TxTExportPath.Text + ";Jet OLEDB:Database Password=";
                    string local3 = text1 ?? "";
                    OleDbConnection connection = new OleDbConnection(local3 ?? "");
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    connection.Close();
                }
                catch (Exception exception3)
                {
                    Exception ex = exception3;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(this.A.ToString() + " " + ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    ProjectData.ClearProjectError();
                    return;
                }
                this.ButtonBrows.Enabled = false;
                this.TxTTitle.Text = PR.A.ToString();
                this.TxTTitle.ForeColor = Color.Red;
                this.TxTTitle.Font = new Font("Tahoma", 15f);
                this.TimerStartExport.Enabled = true;
            }
            else
            {
                Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
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

        private void I(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void P(object A, EventArgs R)
        {
            try
            {
                SqlConnection selectConnection = new SqlConnection(H.Settings.DBConnectionString);
                if (selectConnection.State == ConnectionState.Closed)
                {
                    selectConnection.Open();
                }
                DataTable dataTable = new DataTable();
                string selectCommandText = "SELECT [GroupID] FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)";
                dataTable.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, selectConnection);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataTable);
                selectConnection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    Interaction.MsgBox("هناك مجموعات تابعة للمستودع يجب ان يكون المستودع فارغ من المجموعات والمواد، يجب عليك حذف كل المجموعات والاصناف قبل الاستيراد", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    if (selectConnection.State == ConnectionState.Closed)
                    {
                        selectConnection.Open();
                    }
                    DataTable table2 = new DataTable();
                    string str2 = "SELECT [MaterialID] FROM TaNNMaterial WHERE (CenterFrontID = @CenterFrontID)";
                    table2.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(str2, selectConnection);
                    adapter2.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    adapter2.Fill(table2);
                    selectConnection.Close();
                    if (table2.Rows.Count > 0)
                    {
                        Interaction.MsgBox("هناك مجموعات تابعة للمستودع يجب ان يكون المستودع فارغ من المجموعات والمواد، يجب عليك حذف كل المجموعات والاصناف قبل الاستيراد", MsgBoxStyle.ApplicationModal, null);
                    }
                    else
                    {
                        this.OpenFileDialogImport.Filter = "Access DataBase|*.mdb";
                        this.OpenFileDialogImport.ShowDialog();
                        this.TxTImporttPath.Text = this.OpenFileDialogImport.FileName;
                        if (this.TxTImporttPath.Text == null)
                        {
                            Interaction.MsgBox(this.R.ToString(), MsgBoxStyle.ApplicationModal, null);
                        }
                        else
                        {
                            try
                            {
                                string text1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.TxTImporttPath.Text + ";Jet OLEDB:Database Password=";
                                string local3 = text1 ?? "";
                                OleDbConnection connection2 = new OleDbConnection(local3 ?? "");
                                if (connection2.State == ConnectionState.Closed)
                                {
                                    connection2.Open();
                                }
                                OleDbCommand command = new OleDbCommand {
                                    Connection = connection2,
                                    CommandType = CommandType.Text
                                };
                                string str4 = "";
                                command.CommandText = "UPDATE ImportExport SET GroupName = @GroupName WHERE (GroupName = '" + str4 + "') OR (GroupName IS NULL)";
                                command.Parameters.AddWithValue("GroupName", "****");
                                command.ExecuteNonQuery();
                                connection2.Close();
                            }
                            catch (Exception exception3)
                            {
                                Exception ex = exception3;
                                ProjectData.SetProjectError(ex);
                                Interaction.MsgBox(this.A.ToString() + " " + ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                                base.Dispose();
                                ProjectData.ClearProjectError();
                            }
                            this.ButtonBrows.Enabled = false;
                            this.TxTTitle.Text = PR.A.ToString();
                            this.TxTTitle.ForeColor = Color.Red;
                            this.TxTTitle.Font = new Font("Tahoma", 15f);
                            this.TimerImport.Enabled = true;
                        }
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

        private void Q(object A, EventArgs R)
        {
            this.TimerImport.Enabled = false;
            try
            {
                string text1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.TxTImporttPath.Text + ";Jet OLEDB:Database Password=";
                string local2 = text1 ?? "";
                OleDbConnection selectConnection = new OleDbConnection(local2 ?? "");
                DataSet dataSet = new DataSet();
                if (selectConnection.State == ConnectionState.Closed)
                {
                    selectConnection.Open();
                }
                string selectCommandText = "Select DISTINCT GroupName FROM ImportExport";
                dataSet.Clear();
                new OleDbDataAdapter(selectCommandText, selectConnection).Fill(dataSet, "ImportExport");
                selectConnection.Close();
                this.GVG.DataSource = dataSet;
                this.GVG.DataMember = "ImportExport";
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(this.A.ToString() + " " + ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
                ProjectData.ClearProjectError();
            }
            if (Information.IsNothing(this.GVG.CurrentRow))
            {
                Interaction.MsgBox("لا يوجد اي سجلات في الملف", MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
            }
            this.ProgressBarGroup.Visible = true;
            this.ProgressBarGroup.Maximum = this.GVG.RowCount;
            int num = this.GVG.Rows.Count - 1;
            int num2 = 0;
            while (true)
            {
                int num3;
                SqlConnection connection2;
                int num4;
                int num5;
                while (true)
                {
                    if (num2 > num)
                    {
                        this.ProgressBarGroup.Visible = false;
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                        A.D.A.A.Dispose();
                        base.Dispose();
                        return;
                    }
                    this.ProgressBarGroup.Value = num2;
                    num3 = 0;
                    string str3 = this.GVG.Rows[num2].Cells["GroupName"].Value.ToString();
                    connection2 = new SqlConnection(H.Settings.DBConnectionString);
                    if (connection2.State == ConnectionState.Closed)
                    {
                        connection2.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO TaNNMaterialGroup (CenterFrontID, GroupName) VALUES (@CenterFrontID, @GroupName); SELECT GroupID FROM TaNNMaterialGroup WHERE (GroupID = SCOPE_IDENTITY())", connection2);
                    command.Parameters.AddWithValue("@CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("@GroupName", str3);
                    num3 = Conversions.ToInteger(command.ExecuteScalar());
                    connection2.Close();
                    string text2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.TxTImporttPath.Text + ";Jet OLEDB:Database Password=";
                    string local6 = text2 ?? "";
                    OleDbConnection selectConnection = new OleDbConnection(local6 ?? "");
                    DataSet dataSet = new DataSet();
                    string selectCommandText = "SELECT * FROM ImportExport WHERE GroupName = '" + str3 + "'";
                    if (selectConnection.State == ConnectionState.Closed)
                    {
                        selectConnection.Open();
                    }
                    dataSet.Clear();
                    new OleDbDataAdapter(selectCommandText, selectConnection).Fill(dataSet, "ImportExport");
                    selectConnection.Close();
                    this.GV.DataSource = dataSet;
                    this.GV.DataMember = "ImportExport";
                    this.GV.Refresh();
                    this.ProgressBar1.Visible = true;
                    this.ProgressBar1.Maximum = this.GV.RowCount;
                    num4 = this.GV.Rows.Count - 1;
                    num5 = 0;
                    break;
                }
                while (true)
                {
                    if (num5 > num4)
                    {
                        this.ProgressBar1.Visible = false;
                        num2++;
                        break;
                    }
                    this.ProgressBar1.Value = num5;
                    try
                    {
                        string str7 = this.GV.Rows[num5].Cells["MaterialBarCode"].Value.ToString();
                        string str8 = this.GV.Rows[num5].Cells["MaterialName"].Value.ToString();
                        decimal num6 = new decimal(Conversion.Val(this.GV.Rows[num5].Cells["MaterialQuantity"].Value.ToString()));
                        string str9 = this.GV.Rows[num5].Cells["MaterialUnit"].Value.ToString();
                        decimal num7 = new decimal(Conversion.Val(this.GV.Rows[num5].Cells["MaterialPricCost"].Value.ToString()));
                        decimal num8 = new decimal(Conversion.Val(this.GV.Rows[num5].Cells["MaterialPricSale"].Value.ToString()));
                        decimal num9 = new decimal(Conversion.Val(this.GV.Rows[num5].Cells["MaterialPricLess"].Value.ToString()));
                        bool flag5 = Conversions.ToBoolean(this.GV.Rows[num5].Cells["MaterialIsStop"].Value.ToString());
                        string str10 = this.GV.Rows[num5].Cells["MaterialExpDate"].Value.ToString();
                        string str11 = this.GV.Rows[num5].Cells["MaterialNote"].Value.ToString();
                        bool flag6 = Conversions.ToBoolean(this.GV.Rows[num5].Cells["MaterialNotIsView"].Value.ToString());
                        decimal num10 = new decimal(Conversion.Val(this.GV.Rows[num5].Cells["MaterialQuantityOffer"].Value.ToString()));
                        decimal num11 = new decimal(Conversion.Val(this.GV.Rows[num5].Cells["MaterialQuantityLess"].Value.ToString()));
                        decimal num12 = new decimal(Conversion.Val(this.GV.Rows[num5].Cells["MaterialQuantityPakeg"].Value.ToString()));
                        string inputStr = this.GV.Rows[num5].Cells["MaterialDisMiWi"].Value.ToString();
                        string str13 = this.GV.Rows[num5].Cells["MaterialDarMiWi"].Value.ToString();
                        string str14 = this.GV.Rows[num5].Cells["MaterialOtherBarCode"].Value.ToString();
                        string str15 = this.GV.Rows[num5].Cells["MaterialMultBarCode"].Value.ToString();
                        string str16 = this.GV.Rows[num5].Cells["MaterialDisExpDat"].Value.ToString();
                        if ((str7 != null) & (str8 != null))
                        {
                            if (connection2.State == ConnectionState.Closed)
                            {
                                connection2.Open();
                            }
                            SqlCommand command2 = new SqlCommand("INSERT INTO TaNNMaterial(CenterFrontID, GroupIDFrontID, MaterialBarCode, MaterialName, MaterialQuantity, MaterialUnit, MaterialPricCost, MaterialPricLess, MaterialPricSale, MaterialIsStop, MaterialExpDate, MaterialNote, MaterialNotIsView, MaterialQuantityLess, MaterialQuantityPakeg, MaterialQuantityOffer, MaterialDisMiWi, MaterialDarMiWi, MaterialOtherBarCode, MaterialMultBarCode, MaterialBarcodeBlock, MaterialDisExpDat) VALUES (@CenterFrontID, @GroupIDFrontID, @MaterialBarCode, @MaterialName, @MaterialQuantity, @MaterialUnit, @MaterialPricCost, @MaterialPricLess, @MaterialPricSale, @MaterialIsStop, @MaterialExpDate, @MaterialNote, @MaterialNotIsView, @MaterialQuantityLess, @MaterialQuantityPakeg, @MaterialQuantityOffer, @MaterialDisMiWi, @MaterialDarMiWi, @MaterialOtherBarCode, @MaterialMultBarCode, @MaterialBarcodeBlock, @MaterialDisExpDat)", connection2);
                            command2.Parameters.AddWithValue("CenterFrontID", PR.GR);
                            command2.Parameters.AddWithValue("GroupIDFrontID", num3);
                            command2.Parameters.AddWithValue("MaterialBarCode", str7);
                            command2.Parameters.AddWithValue("MaterialName", str8);
                            command2.Parameters.AddWithValue("MaterialQuantity", num6.ToString(PR.OR));
                            command2.Parameters.AddWithValue("MaterialUnit", str9);
                            command2.Parameters.AddWithValue("MaterialPricCost", num7.ToString(PR.VR));
                            command2.Parameters.AddWithValue("MaterialPricLess", num9.ToString(PR.VR));
                            command2.Parameters.AddWithValue("MaterialPricSale", num8.ToString(PR.VR));
                            command2.Parameters.AddWithValue("MaterialIsStop", flag5);
                            if ((str10 == null) | (str10 == ""))
                            {
                                command2.Parameters.AddWithValue("@MaterialExpDate", DBNull.Value);
                            }
                            else
                            {
                                DateTime time = Conversions.ToDate(str10);
                                command2.Parameters.AddWithValue("@MaterialExpDate", time.ToString("yyyy/MM/dd"));
                            }
                            command2.Parameters.AddWithValue("MaterialNote", str11);
                            command2.Parameters.AddWithValue("MaterialNotIsView", flag6);
                            command2.Parameters.AddWithValue("MaterialQuantityLess", num11.ToString(PR.OR));
                            command2.Parameters.AddWithValue("MaterialQuantityPakeg", num12.ToString(PR.OR));
                            command2.Parameters.AddWithValue("MaterialQuantityOffer", num10.ToString(PR.OR));
                            command2.Parameters.AddWithValue("MaterialDisMiWi", Conversion.Val(inputStr));
                            command2.Parameters.AddWithValue("MaterialDarMiWi", Conversion.Val(str13));
                            command2.Parameters.AddWithValue("MaterialOtherBarCode", str14);
                            command2.Parameters.AddWithValue("MaterialMultBarCode", str15);
                            command2.Parameters.AddWithValue("MaterialBarcodeBlock", PR.GR + str7);
                            if ((str16 == null) | (str16 == ""))
                            {
                                command2.Parameters.AddWithValue("@MaterialDisExpDat", DBNull.Value);
                            }
                            else
                            {
                                DateTime time2 = Conversions.ToDate(str16);
                                command2.Parameters.AddWithValue("@MaterialDisExpDat", time2.ToString("yyyy/MM/dd"));
                            }
                            command2.ExecuteNonQuery();
                            connection2.Close();
                        }
                    }
                    catch (Exception exception3)
                    {
                        Exception ex = exception3;
                        ProjectData.SetProjectError(ex);
                        Exception exception2 = ex;
                        ProjectData.ClearProjectError();
                    }
                    num5++;
                }
            }
        }

        private void R(object A, EventArgs R)
        {
            // Invalid method body.
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

        internal virtual TabPage TabPage1
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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

        internal virtual DataGridView GV
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label TxTExportPath
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonBrows
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

        internal virtual FolderBrowserDialog FolderBrowserDialogExport
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Timer TimerStartExport
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual CheckBox CheckExportEmpty
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Label TxTImporttPath
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonImport
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

        internal virtual ProgressBar ProgressBar1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual OpenFileDialog OpenFileDialogImport
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Timer TimerImport
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.Q);
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

        internal virtual ProgressBar ProgressBarGroup
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual DataGridView GVG
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
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual Button ButtonClose
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

