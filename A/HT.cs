namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class HT : Form
    {
        private IContainer A;
        [CompilerGenerated, DebuggerBrowsable(DebuggerBrowsableState.Never), AccessedThroughProperty("ButtonUpdate")]
        private Button A;
        [DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated, AccessedThroughProperty("WebBrowser1")]
        private WebBrowser A;

        public HT()
        {
            base.Load += new EventHandler(this.A);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            this.ButtonUpdate = new Button();
            this.WebBrowser1 = new WebBrowser();
            base.SuspendLayout();
            this.ButtonUpdate.Dock = DockStyle.Bottom;
            this.ButtonUpdate.Enabled = false;
            this.ButtonUpdate.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.ButtonUpdate.Location = new Point(0, 0x1e5);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new Size(0x3a5, 0x43);
            this.ButtonUpdate.TabIndex = 0;
            this.ButtonUpdate.Text = "تحديث الأن";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.WebBrowser1.Dock = DockStyle.Fill;
            this.WebBrowser1.Location = new Point(0, 0);
            this.WebBrowser1.MinimumSize = new Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.ScriptErrorsSuppressed = true;
            this.WebBrowser1.Size = new Size(0x3a5, 0x1e5);
            this.WebBrowser1.TabIndex = 1;
            base.AutoScaleDimensions = new SizeF(7f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x3a5, 0x228);
            base.Controls.Add(this.WebBrowser1);
            base.Controls.Add(this.ButtonUpdate);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Margin = new Padding(3, 4, 3, 4);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "UpdateForm";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "تحديث النظام";
            base.ResumeLayout(false);
        }

        private void A(object A, EventArgs R)
        {
            this.WebBrowser1.Navigate("https://yazsys.com/SaleUpdate4.aspx");
        }

        private void A(object A, WebBrowserDocumentCompletedEventArgs R)
        {
            this.ButtonUpdate.Enabled = true;
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
            Application.DoEvents();
            string file = Application.StartupPath + @"\YAZSYS4Update.exe";
            try
            {
                if (!D.A.FileSystem.FileExists(file))
                {
                    Interaction.MsgBox("تطبيق التحديث مفقود لديك", MsgBoxStyle.ApplicationModal, null);
                }
                else
                {
                    Process.Start(file.ToString());
                    D.A.A.Show();
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

        internal virtual Button ButtonUpdate
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                EventHandler handler = new EventHandler(this.R);
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

        internal virtual WebBrowser WebBrowser1
        {
            [CompilerGenerated]
            get => 
                this.A;
            [MethodImpl(MethodImplOptions.Synchronized), CompilerGenerated]
            set
            {
                WebBrowserDocumentCompletedEventHandler handler = new WebBrowserDocumentCompletedEventHandler(this.A);
                WebBrowser a = this.A;
                if (a != null)
                {
                    a.DocumentCompleted -= handler;
                }
                this.A = value;
                a = this.A;
                if (a != null)
                {
                    a.DocumentCompleted += handler;
                }
            }
        }
    }
}

