namespace A
{
    using Microsoft.VisualBasic.ApplicationServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [GeneratedCode("MyTemplate", "11.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)]
    internal class A : WindowsFormsApplicationBase
    {
        [DebuggerStepThrough]
        public A() : base(AuthenticationMode.Windows)
        {
            base.IsSingleInstance = false;
            base.EnableVisualStyles = true;
            base.SaveMySettingsOnExit = true;
            base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining), EditorBrowsable(EditorBrowsableState.Advanced), STAThread, DebuggerHidden]
        internal static void A(string[] A)
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            }
            finally
            {
            }
            D.A.Run(A);
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            base.MainForm = D.A.A;
        }
    }
}

