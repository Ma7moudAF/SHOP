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
    public class TR : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("GVPList")]
        private DataGridView A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("TxTInvoicID")]
        private TextBox A;
        private SqlConnection A;
        private string A;
        private string R;
        private OleDbConnection A;
        private string P;

        public TR()
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
            this.GVPList = new DataGridView();
            this.TxTInvoicID = new TextBox();
            ((ISupportInitialize) this.GVPList).BeginInit();
            base.SuspendLayout();
            this.GVPList.AllowUserToAddRows = false;
            this.GVPList.AllowUserToDeleteRows = false;
            this.GVPList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.GVPList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPList.Location = new Point(14, 0xd4);
            this.GVPList.Margin = new Padding(3, 4, 3, 4);
            this.GVPList.MultiSelect = false;
            this.GVPList.Name = "GVPList";
            this.GVPList.ReadOnly = true;
            this.GVPList.RowHeadersVisible = false;
            this.GVPList.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.GVPList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.GVPList.Size = new Size(0x221, 0x147);
            this.GVPList.TabIndex = 0x6b;
            this.TxTInvoicID.Location = new Point(14, 0x91);
            this.TxTInvoicID.Margin = new Padding(3, 4, 3, 4);
            this.TxTInvoicID.Name = "TxTInvoicID";
            this.TxTInvoicID.RightToLeft = RightToLeft.No;
            this.TxTInvoicID.Size = new Size(0x74, 0x17);
            this.TxTInvoicID.TabIndex = 0x6c;
            this.TxTInvoicID.Text = "1000141";
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x22f, 0x31);
            base.ControlBox = false;
            base.Controls.Add(this.TxTInvoicID);
            base.Controls.Add(this.GVPList);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CRPrintOrdarGroups";
            base.ShowIcon = false;
            this.Text = "Print Ordar MultiGroup";
            base.WindowState = FormWindowState.Minimized;
            ((ISupportInitialize) this.GVPList).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void A(object A, EventArgs R)
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

        public void P()
        {
            // Invalid method body.
        }

        public void R()
        {
            try
            {
                Application.DoEvents();
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
                if (this.GVPList.Rows.Count > 0)
                {
                    this.P();
                }
                else
                {
                    Interaction.MsgBox("لا يوجد ملف تعريف لطباعة المجموعات على الطابعات المتعددة يجب إعاة تعريف الملف", MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
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

        internal virtual DataGridView GVPList
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set => 
                (this.A = value);
        }

        internal virtual TextBox TxTInvoicID
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

