namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class OF : Form
    {
        private IContainer A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GroupBox2"), CompilerGenerated]
        private GroupBox A;
        [AccessedThroughProperty("ComboBoxPrinter"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ComboBox A;
        [AccessedThroughProperty("ButtonClose"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("Label1"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("TxTTitle")]
        private Label R;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonOk")]
        private Button R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GV"), CompilerGenerated]
        private DataGridView A;
        [CompilerGenerated, AccessedThroughProperty("GroupBox3"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private GroupBox R;
        [AccessedThroughProperty("ButtonDelete"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button P;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GVPList"), CompilerGenerated]
        private DataGridView R;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("GroupBox1")]
        private GroupBox P;
        private SqlConnection A;
        private string A;
        private string R;
        private OleDbConnection A;

        public OF()
        {
            base.Load += new EventHandler(this.A);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = Application.StartupPath + @"\PrinterSetting.mdb";
            string text1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.A + ";Jet OLEDB:Database Password=";
            string local2 = text1 ?? "";
            this.R = local2 ?? "";
            this.A = new OleDbConnection(this.R);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(OF));
            this.GroupBox2 = new GroupBox();
            this.ComboBoxPrinter = new ComboBox();
            this.ButtonClose = new Button();
            this.Label1 = new Label();
            this.TxTTitle = new Label();
            this.ButtonOk = new Button();
            this.GV = new DataGridView();
            this.GroupBox3 = new GroupBox();
            this.ButtonDelete = new Button();
            this.GVPList = new DataGridView();
            this.GroupBox1 = new GroupBox();
            this.GroupBox2.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((ISupportInitialize) this.GVPList).BeginInit();
            this.GroupBox1.SuspendLayout();
            base.SuspendLayout();
            this.GroupBox2.Controls.Add(this.ComboBoxPrinter);
            this.GroupBox2.Location = new Point(12, 0x7c);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new Size(0x17a, 0x37);
            this.GroupBox2.TabIndex = 0x70;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "حدد الطابعة:";
            this.ComboBoxPrinter.Dock = DockStyle.Fill;
            this.ComboBoxPrinter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboBoxPrinter.FormattingEnabled = true;
            this.ComboBoxPrinter.Location = new Point(3, 0x13);
            this.ComboBoxPrinter.Name = "ComboBoxPrinter";
            this.ComboBoxPrinter.Size = new Size(0x174, 0x18);
            this.ComboBoxPrinter.TabIndex = 0x69;
            this.ButtonClose.DialogResult = DialogResult.Cancel;
            this.ButtonClose.Dock = DockStyle.Bottom;
            this.ButtonClose.FlatAppearance.BorderColor = Color.Green;
            this.ButtonClose.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonClose.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonClose.FlatStyle = FlatStyle.Flat;
            this.ButtonClose.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonClose.Image = F.ImCloseOrang;
            this.ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new Point(0, 0x1d2);
            this.ButtonClose.Margin = new Padding(3, 4, 3, 4);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new Size(0x36b, 0x2d);
            this.ButtonClose.TabIndex = 0x6f;
            this.ButtonClose.Text = "اغلاق";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.Label1.BackColor = Color.WhiteSmoke;
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.ForeColor = Color.DarkGreen;
            this.Label1.Location = new Point(0, 0x22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x36b, 0x49);
            this.Label1.TabIndex = 110;
            this.Label1.Text = manager.GetString("Label1.Text");
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.DarkGreen;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(0x36b, 0x22);
            this.TxTTitle.TabIndex = 0x6d;
            this.TxTTitle.Text = "ضبط تعريف الطابعات المتعددة حسب المجموعة ";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonOk.BackColor = Color.WhiteSmoke;
            this.ButtonOk.Dock = DockStyle.Bottom;
            this.ButtonOk.FlatAppearance.BorderColor = Color.Green;
            this.ButtonOk.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonOk.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonOk.FlatStyle = FlatStyle.Flat;
            this.ButtonOk.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonOk.Image = F.ImAdd;
            this.ButtonOk.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonOk.Location = new Point(3, 0xdf);
            this.ButtonOk.Margin = new Padding(3, 4, 3, 4);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new Size(0x174, 0x2d);
            this.ButtonOk.TabIndex = 0x69;
            this.ButtonOk.Text = "إضافة التعريف";
            this.ButtonOk.UseVisualStyleBackColor = false;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Dock = DockStyle.Top;
            this.GV.Location = new Point(3, 0x13);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(0x174, 0xc5);
            this.GV.TabIndex = 0x6a;
            this.GroupBox3.Controls.Add(this.ButtonDelete);
            this.GroupBox3.Controls.Add(this.GVPList);
            this.GroupBox3.Location = new Point(0x18c, 0x7c);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new Size(0x1d9, 0x14f);
            this.GroupBox3.TabIndex = 0x72;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "الطابعات والمجموعات المعرفة:";
            this.ButtonDelete.BackColor = Color.FromArgb(0xff, 0xc0, 0xc0);
            this.ButtonDelete.Dock = DockStyle.Bottom;
            this.ButtonDelete.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDelete.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDelete.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDelete.FlatStyle = FlatStyle.Flat;
            this.ButtonDelete.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDelete.Image = F.ImDelete;
            this.ButtonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new Point(3, 0x124);
            this.ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new Size(0x1d3, 40);
            this.ButtonDelete.TabIndex = 0x6d;
            this.ButtonDelete.Text = "حذف التعريف المحدد";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.GVPList.AllowUserToAddRows = false;
            this.GVPList.AllowUserToDeleteRows = false;
            this.GVPList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVPList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPList.Dock = DockStyle.Top;
            this.GVPList.Location = new Point(3, 0x13);
            this.GVPList.MultiSelect = false;
            this.GVPList.Name = "GVPList";
            this.GVPList.ReadOnly = true;
            this.GVPList.RowHeadersVisible = false;
            this.GVPList.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.GVPList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVPList.Size = new Size(0x1d3, 0x10a);
            this.GVPList.TabIndex = 0x6a;
            this.GroupBox1.Controls.Add(this.GV);
            this.GroupBox1.Controls.Add(this.ButtonOk);
            this.GroupBox1.Location = new Point(12, 0xb9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new Size(0x17a, 0x10f);
            this.GroupBox1.TabIndex = 0x71;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "حدد المجموعة:";
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x36b, 0x1ff);
            base.ControlBox = false;
            base.Controls.Add(this.GroupBox2);
            base.Controls.Add(this.ButtonClose);
            base.Controls.Add(this.Label1);
            base.Controls.Add(this.TxTTitle);
            base.Controls.Add(this.GroupBox3);
            base.Controls.Add(this.GroupBox1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "RestaurantPrinterSetting";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ضبط الطابعات المتعددة حسب المجموعة";
            this.GroupBox2.ResumeLayout(false);
            ((ISupportInitialize) this.GV).EndInit();
            this.GroupBox3.ResumeLayout(false);
            ((ISupportInitialize) this.GVPList).EndInit();
            this.GroupBox1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            PrinterSettings settings = new PrinterSettings();
            try
            {
                IEnumerator enumerator;
                try
                {
                    enumerator = PrinterSettings.InstalledPrinters.GetEnumerator();
                    while (true)
                    {
                        if (!enumerator.MoveNext())
                        {
                            break;
                        }
                        string item = Conversions.ToString(enumerator.Current);
                        this.ComboBoxPrinter.Items.Add(item);
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
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
            this.GV.ReadOnly = false;
            DataGridViewCheckBoxColumn dataGridViewColumn = new DataGridViewCheckBoxColumn();
            this.GV.Columns.Insert(0, dataGridViewColumn);
            dataGridViewColumn.HeaderText = "تحديد";
            this.R();
            this.P();
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

        private void P()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataSet dataSet = new DataSet();
                string selectCommandText = "SELECT * FROM PrintMultDriver";
                dataSet.Clear();
                new OleDbDataAdapter(selectCommandText, this.A).Fill(dataSet, "PrintMultDriver");
                this.A.Close();
                this.GVPList.DataSource = dataSet;
                this.GVPList.DataMember = "PrintMultDriver";
                this.GVPList.Refresh();
                this.GVPList.Columns["ID"].Visible = false;
                this.GVPList.Columns["PrinterName"].HeaderText = "الطابعة";
                this.GVPList.Columns["IDsGroup"].HeaderText = "رمز المجموعة | المجموعات";
                this.ButtonDelete.Enabled = this.GVPList.Rows.Count > 0;
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        private void P(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (Information.IsNothing(this.GVPList.CurrentRow))
                    {
                        Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
                    }
                    else
                    {
                        if (this.A.State == ConnectionState.Closed)
                        {
                            this.A.Open();
                        }
                        OleDbCommand command = new OleDbCommand {
                            Connection = this.A,
                            CommandType = CommandType.Text,
                            CommandText = "DELETE FROM PrintMultDriver WHERE (ID = @ID)"
                        };
                        command.Parameters.AddWithValue("ID", this.GVPList.SelectedRows[0].Cells["ID"].Value.ToString());
                        command.ExecuteNonQuery();
                        this.A.Close();
                        this.P();
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
        }

        private void Q(object A, EventArgs R)
        {
            base.Dispose();
        }

        private void R()
        {
            try
            {
                if (this.A.State == ConnectionState.Closed)
                {
                    this.A.Open();
                }
                DataSet dataSet = new DataSet();
                string selectCommandText = "SELECT * FROM TaNNMaterialGroup WHERE (CenterFrontID = @CenterFrontID)";
                dataSet.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
                adapter.Fill(dataSet, "TaNNMaterialGroup");
                this.A.Close();
                this.GV.DataSource = dataSet;
                this.GV.DataMember = "TaNNMaterialGroup";
                this.GV.Refresh();
                this.GV.Columns["GroupID"].HeaderText = "الترميز";
                this.GV.Columns["CenterFrontID"].Visible = false;
                this.GV.Columns["GroupName"].HeaderText = "المجموعة";
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
            if (this.ComboBoxPrinter.Text == null)
            {
                Interaction.MsgBox("يجب تحديد الطابعة", MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                string expression = "";
                int num2 = this.GV.Rows.Count - 1;
                while (true)
                {
                    if (num2 < 0)
                    {
                        if (Strings.Len(expression) < 5)
                        {
                            Interaction.MsgBox("يجب تحديد المجموعة او المجموعات", MsgBoxStyle.ApplicationModal, null);
                        }
                        else
                        {
                            if (this.A.State == ConnectionState.Closed)
                            {
                                this.A.Open();
                            }
                            OleDbCommand command = new OleDbCommand {
                                Connection = this.A,
                                CommandType = CommandType.Text,
                                CommandText = "INSERT INTO PrintMultDriver (PrinterName, IDsGroup) VALUES (@PrinterName, @IDsGroup)"
                            };
                            command.Parameters.AddWithValue("@PrinterName", this.ComboBoxPrinter.Text.Trim());
                            char[] trimChars = new char[] { ',' };
                            command.Parameters.AddWithValue("@IDsGroup", expression.TrimEnd(trimChars));
                            command.ExecuteNonQuery();
                            this.A.Close();
                            this.P();
                            this.R();
                        }
                        break;
                    }
                    if (Conversions.ToBoolean(this.GV.Rows[num2].Cells[0].Value))
                    {
                        string str2 = Conversions.ToString(this.GV.Rows[num2].Cells[1].Value);
                        expression = expression + "'" + str2 + "',";
                    }
                    num2 += -1;
                }
            }
        }

        internal virtual GroupBox GroupBox2
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual ComboBox ComboBoxPrinter
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual Button ButtonClose
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

        internal virtual Label Label1
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

        internal virtual Button ButtonOk
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

        internal virtual DataGridView GV
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
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Button ButtonDelete
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

        internal virtual DataGridView GVPList
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
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
    }
}

