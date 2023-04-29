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
    public class DF : Form
    {
        private IContainer A;
        [AccessedThroughProperty("ButtonFinish"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button A;
        [AccessedThroughProperty("TxTTitle"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;
        [AccessedThroughProperty("TabControl1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabControl A;
        [AccessedThroughProperty("TabPage2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage A;
        [AccessedThroughProperty("ButtonAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button R;
        [AccessedThroughProperty("Label3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label R;
        [AccessedThroughProperty("TxTTiteAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox A;
        [AccessedThroughProperty("TxTDetilsAdd"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox R;
        [AccessedThroughProperty("Label4"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label P;
        [AccessedThroughProperty("TabPage1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage R;
        [AccessedThroughProperty("ButtonSave"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button P;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label Q;
        [AccessedThroughProperty("TxTTitleEdite"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox P;
        [AccessedThroughProperty("TxTDetilsEdit"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox Q;
        [AccessedThroughProperty("Label2"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label I;
        [AccessedThroughProperty("TabPage3"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TabPage P;
        [AccessedThroughProperty("ButtonCart"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button Q;
        [AccessedThroughProperty("ButtonDelete"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button I;
        [AccessedThroughProperty("PrivewID"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox I;
        [AccessedThroughProperty("PrivewName"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox D;
        [AccessedThroughProperty("PrivewNote"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private TextBox F;
        [AccessedThroughProperty("GV"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private DataGridView A;
        [AccessedThroughProperty("ButtonPrint"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Button D;
        private SqlConnection A;
        private DataSet A;
        private string A;

        public DF()
        {
            base.Load += new EventHandler(this.Q);
            this.A = new SqlConnection(A.H.Settings.DBConnectionString);
            this.A = new DataSet();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.TxTTitle = new Label();
            this.ButtonFinish = new Button();
            this.TabControl1 = new TabControl();
            this.TabPage3 = new TabPage();
            this.ButtonPrint = new Button();
            this.ButtonCart = new Button();
            this.ButtonDelete = new Button();
            this.TabPage1 = new TabPage();
            this.ButtonSave = new Button();
            this.Label1 = new Label();
            this.TxTTitleEdite = new TextBox();
            this.TxTDetilsEdit = new TextBox();
            this.Label2 = new Label();
            this.TabPage2 = new TabPage();
            this.ButtonAdd = new Button();
            this.Label3 = new Label();
            this.TxTTiteAdd = new TextBox();
            this.TxTDetilsAdd = new TextBox();
            this.Label4 = new Label();
            this.PrivewID = new TextBox();
            this.PrivewName = new TextBox();
            this.PrivewNote = new TextBox();
            this.GV = new DataGridView();
            this.TabControl1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((ISupportInitialize) this.GV).BeginInit();
            base.SuspendLayout();
            this.TxTTitle.Dock = DockStyle.Top;
            this.TxTTitle.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitle.ForeColor = Color.Green;
            this.TxTTitle.Location = new Point(0, 0);
            this.TxTTitle.Name = "TxTTitle";
            this.TxTTitle.Size = new Size(700, 0x22);
            this.TxTTitle.TabIndex = 0x4b;
            this.TxTTitle.Text = "انشاء نموذج عرض سعر";
            this.TxTTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.ButtonFinish.DialogResult = DialogResult.Cancel;
            this.ButtonFinish.FlatAppearance.BorderColor = Color.Green;
            this.ButtonFinish.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonFinish.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonFinish.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonFinish.FlatStyle = FlatStyle.Flat;
            this.ButtonFinish.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonFinish.Image = A.F.ImFinish;
            this.ButtonFinish.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonFinish.Location = new Point(0x222, 0x17a);
            this.ButtonFinish.Margin = new Padding(3, 4, 3, 4);
            this.ButtonFinish.Name = "ButtonFinish";
            this.ButtonFinish.Size = new Size(0x94, 0x2c);
            this.ButtonFinish.TabIndex = 0x4c;
            this.ButtonFinish.Text = "انهاء";
            this.ButtonFinish.UseVisualStyleBackColor = true;
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = DockStyle.Top;
            this.TabControl1.Location = new Point(0, 0xcc);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new Point(8, 6);
            this.TabControl1.RightToLeftLayout = true;
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new Size(700, 0xa5);
            this.TabControl1.TabIndex = 0x1ed36c7;
            this.TabPage3.Controls.Add(this.ButtonPrint);
            this.TabPage3.Controls.Add(this.ButtonCart);
            this.TabPage3.Controls.Add(this.ButtonDelete);
            this.TabPage3.Location = new Point(4, 0x1f);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new Size(0x2b4, 130);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "إدارة العرض المحدد";
            this.TabPage3.UseVisualStyleBackColor = true;
            this.ButtonPrint.BackColor = SystemColors.Info;
            this.ButtonPrint.FlatAppearance.BorderColor = Color.Green;
            this.ButtonPrint.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonPrint.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonPrint.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonPrint.FlatStyle = FlatStyle.Flat;
            this.ButtonPrint.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonPrint.Image = A.F.ImPrint;
            this.ButtonPrint.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonPrint.Location = new Point(6, 0x19);
            this.ButtonPrint.Margin = new Padding(3, 4, 3, 4);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new Size(320, 0x2c);
            this.ButtonPrint.TabIndex = 0x4a;
            this.ButtonPrint.Text = "طباعة العرض المحدد A4";
            this.ButtonPrint.UseVisualStyleBackColor = false;
            this.ButtonCart.BackColor = SystemColors.Info;
            this.ButtonCart.FlatAppearance.BorderColor = Color.Green;
            this.ButtonCart.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonCart.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonCart.FlatStyle = FlatStyle.Flat;
            this.ButtonCart.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonCart.Image = A.F.ImCard;
            this.ButtonCart.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonCart.Location = new Point(350, 0x19);
            this.ButtonCart.Margin = new Padding(3, 4, 3, 4);
            this.ButtonCart.Name = "ButtonCart";
            this.ButtonCart.Size = new Size(320, 0x2c);
            this.ButtonCart.TabIndex = 0x49;
            this.ButtonCart.Text = "إدارة مواد العرض المحدد";
            this.ButtonCart.UseVisualStyleBackColor = false;
            this.ButtonDelete.FlatAppearance.BorderColor = Color.Green;
            this.ButtonDelete.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonDelete.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonDelete.FlatStyle = FlatStyle.Flat;
            this.ButtonDelete.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonDelete.Image = A.F.ImDelete;
            this.ButtonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonDelete.Location = new Point(6, 0x4e);
            this.ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new Size(0x298, 0x2c);
            this.ButtonDelete.TabIndex = 0x48;
            this.ButtonDelete.Text = "حذف العرض المحدد";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.TabPage1.Controls.Add(this.ButtonSave);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.TxTTitleEdite);
            this.TabPage1.Controls.Add(this.TxTDetilsEdit);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Location = new Point(4, 0x1f);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new Padding(3);
            this.TabPage1.Size = new Size(0x2b4, 130);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "تعديل العرض المحدد";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ButtonSave.Enabled = false;
            this.ButtonSave.FlatAppearance.BorderColor = Color.Green;
            this.ButtonSave.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonSave.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonSave.FlatStyle = FlatStyle.Flat;
            this.ButtonSave.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonSave.Image = A.F.ImSave;
            this.ButtonSave.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new Point(0x18, 0x11);
            this.ButtonSave.Margin = new Padding(3, 4, 3, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new Size(160, 0x65);
            this.ButtonSave.TabIndex = 0x1d;
            this.ButtonSave.Text = "حفظ";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0x253, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x4c, 0x10);
            this.Label1.TabIndex = 0x15;
            this.Label1.Text = "عنوان العرض";
            this.TxTTitleEdite.BackColor = SystemColors.Info;
            this.TxTTitleEdite.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTitleEdite.Location = new Point(190, 0x11);
            this.TxTTitleEdite.MaxLength = 300;
            this.TxTTitleEdite.Name = "TxTTitleEdite";
            this.TxTTitleEdite.Size = new Size(0x18f, 0x17);
            this.TxTTitleEdite.TabIndex = 0x1b;
            this.TxTDetilsEdit.BackColor = Color.White;
            this.TxTDetilsEdit.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDetilsEdit.Location = new Point(190, 0x35);
            this.TxTDetilsEdit.MaxLength = 0xbb8;
            this.TxTDetilsEdit.Multiline = true;
            this.TxTDetilsEdit.Name = "TxTDetilsEdit";
            this.TxTDetilsEdit.Size = new Size(0x18f, 0x41);
            this.TxTDetilsEdit.TabIndex = 0x1c;
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label2.Location = new Point(0x253, 0x38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new Size(0x39, 0x10);
            this.Label2.TabIndex = 0x16;
            this.Label2.Text = "ملاحظات";
            this.TabPage2.Controls.Add(this.ButtonAdd);
            this.TabPage2.Controls.Add(this.Label3);
            this.TabPage2.Controls.Add(this.TxTTiteAdd);
            this.TabPage2.Controls.Add(this.TxTDetilsAdd);
            this.TabPage2.Controls.Add(this.Label4);
            this.TabPage2.Location = new Point(4, 0x1f);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new Padding(3);
            this.TabPage2.Size = new Size(0x2b4, 130);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "انشاء عرض جديد";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ButtonAdd.FlatAppearance.BorderColor = Color.Green;
            this.ButtonAdd.FlatAppearance.CheckedBackColor = Color.White;
            this.ButtonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.ButtonAdd.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            this.ButtonAdd.FlatStyle = FlatStyle.Flat;
            this.ButtonAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonAdd.Image = A.F.ImOK;
            this.ButtonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            this.ButtonAdd.Location = new Point(20, 0x12);
            this.ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new Size(160, 0x65);
            this.ButtonAdd.TabIndex = 0x22;
            this.ButtonAdd.Text = "انشاء عرض";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label3.Location = new Point(0x24f, 0x15);
            this.Label3.Name = "Label3";
            this.Label3.Size = new Size(0x4c, 0x10);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "عنوان العرض";
            this.TxTTiteAdd.BackColor = SystemColors.Info;
            this.TxTTiteAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTTiteAdd.Location = new Point(0xba, 0x12);
            this.TxTTiteAdd.MaxLength = 300;
            this.TxTTiteAdd.Name = "TxTTiteAdd";
            this.TxTTiteAdd.Size = new Size(0x18f, 0x17);
            this.TxTTiteAdd.TabIndex = 0x20;
            this.TxTDetilsAdd.BackColor = Color.White;
            this.TxTDetilsAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.TxTDetilsAdd.Location = new Point(0xba, 0x36);
            this.TxTDetilsAdd.MaxLength = 0xbb8;
            this.TxTDetilsAdd.Multiline = true;
            this.TxTDetilsAdd.Name = "TxTDetilsAdd";
            this.TxTDetilsAdd.Size = new Size(0x18f, 0x41);
            this.TxTDetilsAdd.TabIndex = 0x21;
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label4.Location = new Point(0x24f, 0x39);
            this.Label4.Name = "Label4";
            this.Label4.Size = new Size(0x39, 0x10);
            this.Label4.TabIndex = 0x1f;
            this.Label4.Text = "ملاحظات";
            this.PrivewID.Location = new Point(0xd1, 470);
            this.PrivewID.Name = "PrivewID";
            this.PrivewID.Size = new Size(210, 0x17);
            this.PrivewID.TabIndex = 0x1ed36c8;
            this.PrivewName.Location = new Point(0xd1, 0x1f3);
            this.PrivewName.Name = "PrivewName";
            this.PrivewName.Size = new Size(210, 0x17);
            this.PrivewName.TabIndex = 0x1ed36c9;
            this.PrivewNote.Location = new Point(0xd1, 0x210);
            this.PrivewNote.Name = "PrivewNote";
            this.PrivewNote.Size = new Size(210, 0x17);
            this.PrivewNote.TabIndex = 0x1ed36ca;
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            this.GV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Dock = DockStyle.Top;
            this.GV.Location = new Point(0, 0x22);
            this.GV.MultiSelect = false;
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersVisible = false;
            this.GV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GV.Size = new Size(700, 170);
            this.GV.TabIndex = 0x1ed36cb;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(700, 0x1b1);
            base.ControlBox = false;
            base.Controls.Add(this.PrivewNote);
            base.Controls.Add(this.PrivewName);
            base.Controls.Add(this.PrivewID);
            base.Controls.Add(this.TabControl1);
            base.Controls.Add(this.ButtonFinish);
            base.Controls.Add(this.GV);
            base.Controls.Add(this.TxTTitle);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "MaterialPrivew";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "انشاء نموذج عرض سعر";
            this.TabControl1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((ISupportInitialize) this.GV).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
        {
            this.TxTTitleEdite.Text = this.PrivewName.Text;
        }

        private void D(object A, EventArgs R)
        {
            if (Interaction.MsgBox(PR.H.ToString(), MsgBoxStyle.OkCancel, "") != MsgBoxResult.Cancel)
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("DELETE FROM TaNNPrivewList WHERE (PrivewID = @PrivewID)", this.A);
                    command.Parameters.AddWithValue("PrivewID", this.PrivewID.Text);
                    SqlCommand command2 = new SqlCommand("DELETE FROM TaNNPrivewMatrials WHERE (PrivewFrontID = @PrivewFrontID)", this.A);
                    command2.Parameters.AddWithValue("PrivewFrontID", this.PrivewID.Text);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    this.A.Close();
                    this.R();
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
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
            base.Dispose();
        }

        private void H(object A, EventArgs R)
        {
            A.D.A.A.Text = this.TxTTitle.Text;
            A.D.A.A.ShowDialog();
        }

        private void I(object A, EventArgs R)
        {
            if (this.TxTTiteAdd.Text == null)
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("INSERT INTO TaNNPrivewList (CenterFrontID, PrivewName, PrivewDate, PrivewNote, PrivewAddBy) VALUES (@CenterFrontID, @PrivewName, @PrivewDate, @PrivewNote, @PrivewAddBy)", this.A);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("PrivewName", this.TxTTiteAdd.Text.Trim());
                    command.Parameters.AddWithValue("PrivewDate", DateTime.Now.ToString("yyyy/MM/dd"));
                    command.Parameters.AddWithValue("PrivewNote", this.TxTDetilsAdd.Text);
                    command.Parameters.AddWithValue("PrivewAddBy", A.D.A.A.TxTUserName.Text);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.R();
                    this.TxTTiteAdd.Text = null;
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

        private void P(object A, EventArgs R)
        {
            if (this.TxTTitleEdite.Text == null)
            {
                Interaction.MsgBox(PR.F.ToString(), MsgBoxStyle.Exclamation, null);
            }
            else
            {
                this.PrivewName.Text = this.TxTTitleEdite.Text;
                this.PrivewNote.Text = this.TxTDetilsEdit.Text;
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE TaNNPrivewList SET CenterFrontID = @CenterFrontID, PrivewName = @PrivewName, PrivewDate = @PrivewDate, PrivewNote = @PrivewNote, PrivewAddBy = @PrivewAddBy WHERE (PrivewID = @PrivewID)", this.A);
                    command.Parameters.AddWithValue("PrivewID", this.PrivewID.Text);
                    command.Parameters.AddWithValue("CenterFrontID", PR.GR);
                    command.Parameters.AddWithValue("PrivewName", this.TxTTitleEdite.Text.Trim());
                    command.Parameters.AddWithValue("PrivewDate", DateTime.Now.ToString("yyyy/MM/dd"));
                    command.Parameters.AddWithValue("PrivewNote", this.TxTDetilsEdit.Text);
                    command.Parameters.AddWithValue("PrivewAddBy", A.D.A.A.TxTUserName.Text);
                    command.ExecuteNonQuery();
                    this.A.Close();
                    Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    this.R();
                    this.TxTTiteAdd.Text = null;
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
            this.R();
        }

        public void R()
        {
            if (this.A.State == ConnectionState.Closed)
            {
                this.A.Open();
            }
            this.A = "SELECT * FROM TaNNPrivewList WHERE (CenterFrontID = @CenterFrontID)";
            this.A.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(this.A, this.A);
            adapter.SelectCommand.Parameters.AddWithValue("CenterFrontID", PR.GR);
            adapter.Fill(this.A, "TaNNPrivewList");
            this.A.Close();
            this.PrivewID.DataBindings.Clear();
            this.PrivewName.DataBindings.Clear();
            this.PrivewNote.DataBindings.Clear();
            this.PrivewID.DataBindings.Add("Text", this.A, "TaNNPrivewList.PrivewID");
            this.PrivewName.DataBindings.Add("Text", this.A, "TaNNPrivewList.PrivewName");
            this.PrivewNote.DataBindings.Add("Text", this.A, "TaNNPrivewList.PrivewNote");
            this.GV.DataSource = this.A;
            this.GV.DataMember = "TaNNPrivewList";
            this.GV.Refresh();
            this.GV.Columns["PrivewID"].Visible = false;
            this.GV.Columns["CenterFrontID"].Visible = false;
            this.GV.Columns["PrivewName"].HeaderText = "العنوان";
            this.GV.Columns["PrivewDate"].HeaderText = "التاريخ";
            this.GV.Columns["PrivewItems"].HeaderText = "عدد المواد";
            this.GV.Columns["PrivewAmont"].HeaderText = "مجموع المبلغ";
            this.GV.Columns["PrivewNote"].HeaderText = "ملاحظات";
            this.GV.Columns["PrivewAddBy"].HeaderText = "اسم الموظف";
            if (this.GV.RowCount == 0)
            {
                this.ButtonDelete.Enabled = false;
                this.ButtonSave.Enabled = false;
                this.ButtonCart.Enabled = false;
            }
            else
            {
                this.ButtonDelete.Enabled = true;
                this.ButtonSave.Enabled = true;
                this.ButtonCart.Enabled = true;
            }
            this.GV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void R(object A, EventArgs R)
        {
            this.TxTDetilsEdit.Text = this.PrivewNote.Text;
        }

        private void T(object A, EventArgs R)
        {
            Application.DoEvents();
            if (Information.IsNothing(this.GV.CurrentRow))
            {
                Interaction.MsgBox(PR.X.ToString(), MsgBoxStyle.ApplicationModal, null);
            }
            else
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    string selectCommandText = "SELECT        TaNNCenters.*, TaNNPrivewList.*, TaNNPrivewMatrials.*, TaNNPrivewList.CenterFrontID AS Expr1\r\nFROM            TaNNCenters RIGHT OUTER JOIN\r\n                         TaNNPrivewList ON TaNNCenters.CenterID = TaNNPrivewList.CenterFrontID LEFT OUTER JOIN\r\n                         TaNNPrivewMatrials ON TaNNPrivewList.PrivewID = TaNNPrivewMatrials.PrivewFrontID WHERE (TaNNPrivewList.PrivewID = @PrivewID)";
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    dataTable.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCommandText, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("PrivewID", this.GV.SelectedRows[0].Cells["PrivewID"].Value.ToString());
                    adapter.Fill(dataTable);
                    this.A.Close();
                    KI ki = new KI();
                    ki.SetDataSource(dataTable);
                    ki.SetParameterValue("ParameterDeimelQ", PR.X);
                    ki.SetParameterValue("ParameterDeimelS", PR.T);
                    ki.ReportDefinition.Sections["LogoWHedarPP"].SectionFormat.EnableSuppress = !PR.QR;
                    ki.ReportDefinition.Sections["LogoSHedarPP"].SectionFormat.EnableSuppress = !PR.IR;
                    ki.ReportDefinition.Sections["CenterName"].SectionFormat.EnableSuppress = !PR.M;
                    ki.ReportDefinition.Sections["CenterSubName"].SectionFormat.EnableSuppress = !PR.FR;
                    ki.ReportDefinition.Sections["PageHeaderSectionVATNO"].SectionFormat.EnableSuppress = !PR.UR;
                    new HR { CRViewer = { ReportSource = ki } }.ShowDialog();
                    ki.Close();
                    ki.Dispose();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    A.D.A.A.TxTErorr.Text = ex.ToString();
                    A.D.A.A.ShowDialog();
                    ProjectData.ClearProjectError();
                }
            }
        }

        internal virtual Button ButtonFinish
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.F);
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

        internal virtual Label TxTTitle
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

        internal virtual Button ButtonAdd
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.I);
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

        internal virtual Label Label3
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual TextBox TxTTiteAdd
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTDetilsAdd
        {
            [CompilerGenerated]
            get => 
                this.R;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.R = value);
        }

        internal virtual Label Label4
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
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

        internal virtual Button ButtonSave
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

        internal virtual Label Label1
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
        }

        internal virtual TextBox TxTTitleEdite
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual TextBox TxTDetilsEdit
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.Q = value);
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

        internal virtual TabPage TabPage3
        {
            [CompilerGenerated]
            get => 
                this.P;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.P = value);
        }

        internal virtual Button ButtonCart
        {
            [CompilerGenerated]
            get => 
                this.Q;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.H);
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

        internal virtual Button ButtonDelete
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.D);
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

        internal virtual TextBox PrivewID
        {
            [CompilerGenerated]
            get => 
                this.I;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.I = value);
        }

        internal virtual TextBox PrivewName
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.A);
                TextBox d = this.D;
                if (d != null)
                {
                    d.TextChanged -= handler;
                }
                this.D = value;
                d = this.D;
                if (d != null)
                {
                    d.TextChanged += handler;
                }
            }
        }

        internal virtual TextBox PrivewNote
        {
            [CompilerGenerated]
            get => 
                this.F;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
                TextBox f = this.F;
                if (f != null)
                {
                    f.TextChanged -= handler;
                }
                this.F = value;
                f = this.F;
                if (f != null)
                {
                    f.TextChanged += handler;
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

        internal virtual Button ButtonPrint
        {
            [CompilerGenerated]
            get => 
                this.D;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.T);
                Button d = this.D;
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
    }
}

