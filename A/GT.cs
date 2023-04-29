namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class GT : Form
    {
        private IContainer A;
        public static string A;
        public static string R;

        public GT()
        {
            base.Load += new EventHandler(this.A);
            this.A();
        }

        [DebuggerStepThrough]
        private void A()
        {
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x1d2, 0x7b);
            base.ControlBox = false;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "WatsappSend";
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            this.Text = "WatsappSend";
            base.WindowState = FormWindowState.Maximized;
            base.ResumeLayout(false);
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

        public void R()
        {
            try
            {
                if (A == null)
                {
                    Interaction.MsgBox(" WhatsApp لا يوجد رقم جوال", MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
                }
                else if (A.Substring(0, 1) != "+")
                {
                    Interaction.MsgBox(" WhatsApp يجب ان يكون رقم الجوال كاملاً مع مفتاح الدولة مثلا\r\n+962xxxxxxxxx", MsgBoxStyle.ApplicationModal, null);
                    base.Dispose();
                }
                else
                {
                    Process.Start("https://wa.me/" + A.Replace("+", "") + "?text=" + R.ToString());
                    base.Dispose();
                }
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                base.Dispose();
                ProjectData.ClearProjectError();
            }
        }
    }
}

