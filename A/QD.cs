namespace A
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class QD : Form
    {
        private IContainer A;
        [AccessedThroughProperty("Label1"), DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
        private Label A;

        public QD()
        {
            base.Load += new EventHandler(this.A);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.Label1 = new Label();
            base.SuspendLayout();
            this.Label1.Dock = DockStyle.Fill;
            this.Label1.Location = new Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new Size(0x1ad, 0x39);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Closing";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x1ad, 0x39);
            base.ControlBox = false;
            base.Controls.Add(this.Label1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.Name = "FormEndClose";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Closing";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            // Invalid method body.
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

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public void R()
        {
            ProjectData.EndApp();
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
    }
}

