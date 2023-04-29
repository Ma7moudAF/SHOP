namespace A
{
    using CrystalDecisions.Windows.Forms;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class HR : Form
    {
        private IContainer A;
        [CompilerGenerated, AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Label A;
        [AccessedThroughProperty("CRViewer"), CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private CrystalReportViewer A;

        public HR()
        {
            base.Load += new EventHandler(this.A);
            base.FormClosed += new FormClosedEventHandler(this.A);
            base.FormClosing += new FormClosingEventHandler(this.A);
            base.Closed += new EventHandler(this.R);
            base.Closing += new CancelEventHandler(this.A);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label1 = new Label();
            this.CRViewer = new CrystalReportViewer();
            base.SuspendLayout();
            this.Label1.BackColor = Color.FromArgb(0xff, 0xff, 0xc0);
            this.Label1.Dock = DockStyle.Top;
            this.Label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = RightToLeft.Yes;
            this.Label1.Size = new Size(0x2ff, 0x1c);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "يمكنك تصدير هذا النموذج لملف (Execl، Word، PDF) من خلال ايقونة التصدير ثم حدد نوع الملف ثم حفظ.";
            this.Label1.TextAlign = ContentAlignment.MiddleLeft;
            this.CRViewer.ActiveViewIndex = -1;
            this.CRViewer.BorderStyle = BorderStyle.FixedSingle;
            this.CRViewer.Cursor = Cursors.Default;
            this.CRViewer.Dock = DockStyle.Fill;
            this.CRViewer.Location = new Point(0, 0x1c);
            this.CRViewer.Name = "CRViewer";
            this.CRViewer.ShowCloseButton = false;
            this.CRViewer.ShowLogo = false;
            this.CRViewer.Size = new Size(0x2ff, 0x2ba);
            this.CRViewer.TabIndex = 1;
            this.CRViewer.ToolPanelView = ToolPanelViewType.None;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2ff, 0x2d6);
            base.Controls.Add(this.CRViewer);
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.Margin = new Padding(3, 4, 3, 4);
            base.Name = "CRPrintForm";
            base.ShowIcon = false;
            this.Text = "طباعة";
            base.ResumeLayout(false);
        }

        private void A(object A, CancelEventArgs R)
        {
            this.CRViewer.Dispose();
            base.Dispose();
        }

        private void A(object A, EventArgs R)
        {
        }

        private void A(object A, FormClosedEventArgs R)
        {
            this.CRViewer.Dispose();
            base.Dispose();
        }

        private void A(object A, FormClosingEventArgs R)
        {
            this.CRViewer.Dispose();
            base.Dispose();
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
            this.CRViewer.Dispose();
            base.Dispose();
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

        internal virtual CrystalReportViewer CRViewer
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

