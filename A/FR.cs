namespace A
{
    using CrystalDecisions.Shared;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class FR : Form
    {
        private IContainer A;
        private SqlConnection A;
        public static int A = 0;
        public static int R = 0;
        public static bool A = true;
        public static string A;
        public static string R;
        public static string P;
        public static string Q;
        private DataTable A;
        private string I;
        private DataTable R;
        private string D;
        private DataTable P;
        private string F;
        public static bool R = false;

        public FR()
        {
            base.Disposed += new EventHandler(this.A);
            base.Closed += new EventHandler(this.R);
            base.Load += new EventHandler(this.P);
            this.A = new SqlConnection(H.Settings.DBConnectionString);
            this.A = new DataTable();
            this.R = new DataTable();
            this.P = new DataTable();
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2c7, 0x99);
            base.ControlBox = false;
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CRPrintCustomer";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            this.Text = "CRPrintCustomer";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            FR.A = true;
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

        public void I()
        {
            try
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.I = "SELECT * FROM TaNNCenters WHERE (CenterID = @CenterID)";
                    this.A.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(this.I, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterID", PR.GR);
                    adapter.Fill(this.A);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.D = "SELECT * FROM TaNNCustomers WHERE (CustomerID = @CustomerID)";
                    this.R.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(this.D, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CustomerID", A);
                    adapter2.Fill(this.R);
                    this.A.Close();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
                    ProjectData.ClearProjectError();
                }
                LP lp = new LP();
                lp.Database.Tables["TaNNCenters"].SetDataSource(this.A);
                lp.Database.Tables["TaNNCustomers"].SetDataSource(this.R);
                lp.SetParameterValue("ParameterDeimelQ", PR.X);
                lp.SetParameterValue("ParameterDeimelS", PR.T);
                lp.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                lp.SetParameterValue("BBGiftBB", "*" + Q.ToString() + "*");
                lp.ReportDefinition.Sections["LogoWHedarPP"].SectionFormat.EnableSuppress = !PR.QR;
                lp.ReportDefinition.Sections["LogoSHedarPP"].SectionFormat.EnableSuppress = !PR.IR;
                lp.ReportDefinition.Sections["CenterName"].SectionFormat.EnableSuppress = !PR.M;
                lp.ReportDefinition.Sections["CenterSubName"].SectionFormat.EnableSuppress = !PR.FR;
                lp.ReportDefinition.Sections["PageHeaderSectionVATNO"].SectionFormat.EnableSuppress = !PR.UR;
                new HR { CRViewer = { ReportSource = lp } }.ShowDialog();
                lp.Close();
                lp.Dispose();
            }
            catch (Exception exception3)
            {
                Exception ex = exception3;
                ProjectData.SetProjectError(ex);
                A.D.A.A.TxTErorr.Text = ex.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        public void P()
        {
            try
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.I = "SELECT * FROM TaNNCenters WHERE (CenterID = @CenterID)";
                    this.A.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(this.I, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterID", PR.GR);
                    adapter.Fill(this.A);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.D = "SELECT * FROM TaNNCustomers WHERE (CustomerID = @CustomerID)";
                    this.R.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(this.D, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CustomerID", A);
                    adapter2.Fill(this.R);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.F = "SELECT * FROM TaNNCustomersPay WHERE (CustomerPayID = @CustomerPayID)";
                    this.P.Clear();
                    SqlDataAdapter adapter3 = new SqlDataAdapter(this.F, this.A);
                    adapter3.SelectCommand.Parameters.AddWithValue("CustomerPayID", R);
                    adapter3.Fill(this.P);
                    this.A.Close();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
                    ProjectData.ClearProjectError();
                }
                OP op = new OP();
                op.Database.Tables["TaNNCenters"].SetDataSource(this.A);
                op.Database.Tables["TaNNCustomers"].SetDataSource(this.R);
                op.Database.Tables["TaNNCustomersPay"].SetDataSource(this.P);
                op.SetParameterValue("ParameterDeimelQ", PR.X);
                op.SetParameterValue("ParameterDeimelS", PR.T);
                op.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                op.ReportDefinition.Sections["LogoWHedarPP"].SectionFormat.EnableSuppress = !PR.QR;
                op.ReportDefinition.Sections["LogoSHedarPP"].SectionFormat.EnableSuppress = !PR.IR;
                op.ReportDefinition.Sections["CenterName"].SectionFormat.EnableSuppress = !PR.M;
                op.ReportDefinition.Sections["CenterSubName"].SectionFormat.EnableSuppress = !PR.FR;
                op.ReportDefinition.Sections["PageHeaderSectionVATNO"].SectionFormat.EnableSuppress = !PR.UR;
                new HR { CRViewer = { ReportSource = op } }.ShowDialog();
                op.Close();
                op.Dispose();
            }
            catch (Exception exception3)
            {
                Exception ex = exception3;
                ProjectData.SetProjectError(ex);
                A.D.A.A.TxTErorr.Text = ex.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        private void P(object A, EventArgs R)
        {
        }

        public void Q()
        {
            try
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.I = "SELECT * FROM TaNNCenters WHERE (CenterID = @CenterID)";
                    this.A.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(this.I, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterID", PR.GR);
                    adapter.Fill(this.A);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.D = "SELECT * FROM TaNNCustomers WHERE (CustomerID = @CustomerID)";
                    this.R.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(this.D, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CustomerID", A);
                    adapter2.Fill(this.R);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.F = "SELECT * FROM TaNNCustomersPay WHERE (CustomerPayID = @CustomerPayID)";
                    this.P.Clear();
                    SqlDataAdapter adapter3 = new SqlDataAdapter(this.F, this.A);
                    adapter3.SelectCommand.Parameters.AddWithValue("CustomerPayID", R);
                    adapter3.Fill(this.P);
                    this.A.Close();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
                    ProjectData.ClearProjectError();
                }
                VP vp = new VP {
                    PrintOptions = { NoPrinter = AR.J }
                };
                vp.Database.Tables["TaNNCenters"].SetDataSource(this.A);
                vp.Database.Tables["TaNNCustomers"].SetDataSource(this.R);
                vp.Database.Tables["TaNNCustomersPay"].SetDataSource(this.P);
                vp.SetParameterValue("ParameterDeimelQ", PR.X);
                vp.SetParameterValue("ParameterDeimelS", PR.T);
                vp.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                vp.ReportDefinition.Sections["LogoWHedarPP"].SectionFormat.EnableSuppress = !PR.QR;
                vp.ReportDefinition.Sections["LogoSHedarPP"].SectionFormat.EnableSuppress = !PR.IR;
                vp.ReportDefinition.Sections["CenterName"].SectionFormat.EnableSuppress = !PR.M;
                vp.ReportDefinition.Sections["CenterSubName"].SectionFormat.EnableSuppress = !PR.FR;
                vp.ReportDefinition.Sections["PageHeaderSectionVATNO"].SectionFormat.EnableSuppress = !PR.UR;
                HR hr = new HR {
                    CRViewer = { ReportSource = vp }
                };
                if (AR.U)
                {
                    hr.ShowDialog();
                }
                else if (AR.L)
                {
                    hr.CRViewer.PrintReport();
                }
                else
                {
                    vp.PrintOptions.PrinterName = AR.X;
                    vp.PrintToPrinter(AR.I, false, 0, 0);
                }
                vp.Close();
                vp.Dispose();
            }
            catch (Exception exception3)
            {
                Exception ex = exception3;
                ProjectData.SetProjectError(ex);
                A.D.A.A.TxTErorr.Text = ex.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        public void R()
        {
            try
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.I = "SELECT * FROM TaNNCenters WHERE (CenterID = @CenterID)";
                    this.A.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(this.I, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterID", PR.GR);
                    adapter.Fill(this.A);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.D = "SELECT * FROM TaNNCustomers WHERE (CustomerID = @CustomerID)";
                    this.R.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(this.D, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("CustomerID", A);
                    adapter2.Fill(this.R);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.F = !A ? "SELECT * FROM TaNNCustomersPay WHERE (CustomerFrontID = @CustomerFrontID) AND (PayDateTimer BETWEEN @DF And @DT)" : "SELECT * FROM TaNNCustomersPay WHERE (CustomerFrontID = @CustomerFrontID)";
                    this.P.Clear();
                    SqlDataAdapter adapter3 = new SqlDataAdapter(this.F, this.A);
                    adapter3.SelectCommand.Parameters.AddWithValue("CustomerFrontID", A);
                    string text1 = A.D.A.A.DateTimePickerFrom.Value.ToString("yyyy/MM/dd 00:00");
                    adapter3.SelectCommand.Parameters.AddWithValue("DF", text1 ?? DBNull.Value);
                    string text2 = A.D.A.A.DateTimePickerTo.Value.ToString("yyyy/MM/dd 23:59");
                    adapter3.SelectCommand.Parameters.AddWithValue("DT", text2 ?? DBNull.Value);
                    adapter3.Fill(this.P);
                    this.A.Close();
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
                    ProjectData.ClearProjectError();
                }
                OQ oq = new OQ();
                oq.Database.Tables["TaNNCenters"].SetDataSource(this.A);
                oq.Database.Tables["TaNNCustomers"].SetDataSource(this.R);
                oq.Database.Tables["TaNNCustomersPay"].SetDataSource(this.P);
                oq.SetParameterValue("ParameterDeimelQ", PR.X);
                oq.SetParameterValue("ParameterDeimelS", PR.T);
                oq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (A)
                {
                    oq.SetParameterValue("XDFrom", "كل الفترة");
                    oq.SetParameterValue("XDTo", "كل الفترة");
                }
                else
                {
                    oq.SetParameterValue("XDFrom", A.D.A.A.DateTimePickerFrom.Value.ToString("yyyy/MM/dd"));
                    oq.SetParameterValue("XDTo", A.D.A.A.DateTimePickerTo.Value.ToString("yyyy/MM/dd"));
                }
                oq.SetParameterValue("TDebit", A.ToString());
                oq.SetParameterValue("TCredit", R.ToString());
                oq.SetParameterValue("TBalance", P.ToString());
                oq.ReportDefinition.Sections["LogoWHedarPP"].SectionFormat.EnableSuppress = !PR.QR;
                oq.ReportDefinition.Sections["LogoSHedarPP"].SectionFormat.EnableSuppress = !PR.IR;
                oq.ReportDefinition.Sections["CenterName"].SectionFormat.EnableSuppress = !PR.M;
                oq.ReportDefinition.Sections["CenterSubName"].SectionFormat.EnableSuppress = !PR.FR;
                oq.ReportDefinition.Sections["PageHeaderSectionVATNO"].SectionFormat.EnableSuppress = !PR.UR;
                if (!R)
                {
                    new HR { CRViewer = { ReportSource = oq } }.ShowDialog();
                }
                else
                {
                    SaveFileDialog dialog = new SaveFileDialog {
                        Title = "Select PDFFile",
                        Filter = "PDF(*.pdf)|*.pdf",
                        InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    };
                    dialog.ShowDialog();
                    if (dialog.FileName != null)
                    {
                        oq.ExportToDisk(ExportFormatType.PortableDocFormat, dialog.FileName.ToString());
                        Interaction.MsgBox(PR.P.ToString(), MsgBoxStyle.ApplicationModal, null);
                    }
                }
                R = false;
                oq.Close();
                oq.Dispose();
            }
            catch (Exception exception3)
            {
                Exception ex = exception3;
                ProjectData.SetProjectError(ex);
                A.D.A.A.TxTErorr.Text = ex.ToString();
                A.D.A.A.ShowDialog();
                ProjectData.ClearProjectError();
            }
        }

        private void R(object A, EventArgs R)
        {
            FR.A = true;
        }
    }
}

