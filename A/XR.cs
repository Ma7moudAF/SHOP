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
    using System.Windows.Forms;

    [DesignerGenerated]
    public class XR : Form
    {
        private IContainer A;
        private SqlConnection A;
        public static int A = 0;
        public static int R = 0;
        public static bool A = true;
        public static string A;
        public static string R;
        public static string P;
        private DataTable A;
        private string Q;
        private DataTable R;
        private string I;
        private DataTable P;
        private string D;

        public XR()
        {
            base.Closed += new EventHandler(this.A);
            base.Disposed += new EventHandler(this.R);
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
            base.ClientSize = new Size(800, 0x83);
            base.ControlBox = false;
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "CRPrintSuplier";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            this.Text = "CRPrintSuplier";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            XR.A = true;
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
            try
            {
                try
                {
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.Q = "SELECT * FROM TaNNCenters WHERE (CenterID = @CenterID)";
                    this.A.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(this.Q, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterID", PR.GR);
                    adapter.Fill(this.A);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.I = "SELECT * FROM TaNNSupliers WHERE (SuplierID = @SuplierID)";
                    this.R.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(this.I, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("SuplierID", A);
                    adapter2.Fill(this.R);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.D = "SELECT * FROM TaNNSupliersPay WHERE (SuplierPayID = @SuplierPayID)";
                    this.P.Clear();
                    SqlDataAdapter adapter3 = new SqlDataAdapter(this.D, this.A);
                    adapter3.SelectCommand.Parameters.AddWithValue("SuplierPayID", R);
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
                KQ kq = new KQ();
                kq.Database.Tables["TaNNCenters"].SetDataSource(this.A);
                kq.Database.Tables["TaNNSupliers"].SetDataSource(this.R);
                kq.Database.Tables["TaNNSupliersPay"].SetDataSource(this.P);
                kq.SetParameterValue("ParameterDeimelQ", PR.X);
                kq.SetParameterValue("ParameterDeimelS", PR.T);
                kq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                kq.ReportDefinition.Sections["LogoWHedarPP"].SectionFormat.EnableSuppress = !PR.QR;
                kq.ReportDefinition.Sections["LogoSHedarPP"].SectionFormat.EnableSuppress = !PR.IR;
                kq.ReportDefinition.Sections["CenterName"].SectionFormat.EnableSuppress = !PR.M;
                kq.ReportDefinition.Sections["CenterSubName"].SectionFormat.EnableSuppress = !PR.FR;
                kq.ReportDefinition.Sections["PageHeaderSectionVATNO"].SectionFormat.EnableSuppress = !PR.UR;
                new HR { CRViewer = { ReportSource = kq } }.ShowDialog();
                kq.Close();
                kq.Dispose();
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
                    this.Q = "SELECT * FROM TaNNCenters WHERE (CenterID = @CenterID)";
                    this.A.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(this.Q, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterID", PR.GR);
                    adapter.Fill(this.A);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.I = "SELECT * FROM TaNNSupliers WHERE (SuplierID = @SuplierID)";
                    this.R.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(this.I, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("SuplierID", A);
                    adapter2.Fill(this.R);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.D = "SELECT * FROM TaNNSupliersPay WHERE (SuplierPayID = @SuplierPayID)";
                    this.P.Clear();
                    SqlDataAdapter adapter3 = new SqlDataAdapter(this.D, this.A);
                    adapter3.SelectCommand.Parameters.AddWithValue("SuplierPayID", R);
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
                GQ gq = new GQ {
                    PrintOptions = { NoPrinter = AR.J }
                };
                gq.Database.Tables["TaNNCenters"].SetDataSource(this.A);
                gq.Database.Tables["TaNNSupliers"].SetDataSource(this.R);
                gq.Database.Tables["TaNNSupliersPay"].SetDataSource(this.P);
                gq.SetParameterValue("ParameterDeimelQ", PR.X);
                gq.SetParameterValue("ParameterDeimelS", PR.T);
                gq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                gq.ReportDefinition.Sections["LogoWHedarPP"].SectionFormat.EnableSuppress = !PR.QR;
                gq.ReportDefinition.Sections["LogoSHedarPP"].SectionFormat.EnableSuppress = !PR.IR;
                gq.ReportDefinition.Sections["CenterName"].SectionFormat.EnableSuppress = !PR.M;
                gq.ReportDefinition.Sections["CenterSubName"].SectionFormat.EnableSuppress = !PR.FR;
                gq.ReportDefinition.Sections["PageHeaderSectionVATNO"].SectionFormat.EnableSuppress = !PR.UR;
                HR hr = new HR {
                    CRViewer = { ReportSource = gq }
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
                    gq.PrintOptions.PrinterName = AR.X;
                    gq.PrintToPrinter(AR.I, false, 0, 0);
                }
                gq.Close();
                gq.Dispose();
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
                    this.Q = "SELECT * FROM TaNNCenters WHERE (CenterID = @CenterID)";
                    this.A.Clear();
                    SqlDataAdapter adapter = new SqlDataAdapter(this.Q, this.A);
                    adapter.SelectCommand.Parameters.AddWithValue("CenterID", PR.GR);
                    adapter.Fill(this.A);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.I = "SELECT * FROM TaNNSupliers WHERE (SuplierID = @SuplierID)";
                    this.R.Clear();
                    SqlDataAdapter adapter2 = new SqlDataAdapter(this.I, this.A);
                    adapter2.SelectCommand.Parameters.AddWithValue("SuplierID", A);
                    adapter2.Fill(this.R);
                    this.A.Close();
                    if (this.A.State == ConnectionState.Closed)
                    {
                        this.A.Open();
                    }
                    this.D = !A ? "SELECT * FROM TaNNSupliersPay WHERE (SuplierFrontID = @SuplierFrontID) AND (PayDateTimer BETWEEN @DF And @DT)" : "SELECT * FROM TaNNSupliersPay WHERE (SuplierFrontID = @SuplierFrontID)";
                    this.P.Clear();
                    SqlDataAdapter adapter3 = new SqlDataAdapter(this.D, this.A);
                    adapter3.SelectCommand.Parameters.AddWithValue("SuplierFrontID", A);
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
                LQ lq = new LQ();
                lq.Database.Tables["TaNNCenters"].SetDataSource(this.A);
                lq.Database.Tables["TaNNSupliers"].SetDataSource(this.R);
                lq.Database.Tables["TaNNSupliersPay"].SetDataSource(this.P);
                lq.SetParameterValue("ParameterDeimelQ", PR.X);
                lq.SetParameterValue("ParameterDeimelS", PR.T);
                lq.SetParameterValue("EmployName", A.D.A.A.TxTUserName.Text.ToString());
                if (A)
                {
                    lq.SetParameterValue("XDFrom", "كل الفترة");
                    lq.SetParameterValue("XDTo", "كل الفترة");
                }
                else
                {
                    lq.SetParameterValue("XDFrom", A.D.A.A.DateTimePickerFrom.Value.ToString("yyyy/MM/dd"));
                    lq.SetParameterValue("XDTo", A.D.A.A.DateTimePickerTo.Value.ToString("yyyy/MM/dd"));
                }
                lq.SetParameterValue("TDebit", A.ToString());
                lq.SetParameterValue("TCredit", R.ToString());
                lq.SetParameterValue("TBalance", P.ToString());
                lq.ReportDefinition.Sections["LogoWHedarPP"].SectionFormat.EnableSuppress = !PR.QR;
                lq.ReportDefinition.Sections["LogoSHedarPP"].SectionFormat.EnableSuppress = !PR.IR;
                lq.ReportDefinition.Sections["CenterName"].SectionFormat.EnableSuppress = !PR.M;
                lq.ReportDefinition.Sections["CenterSubName"].SectionFormat.EnableSuppress = !PR.FR;
                lq.ReportDefinition.Sections["PageHeaderSectionVATNO"].SectionFormat.EnableSuppress = !PR.UR;
                new HR { CRViewer = { ReportSource = lq } }.ShowDialog();
                lq.Close();
                lq.Dispose();
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
            XR.A = true;
        }
    }
}

