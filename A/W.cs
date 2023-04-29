namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Drawing.Printing;
    using System.Runtime.InteropServices;

    [StandardModule]
    internal sealed class W
    {
        public static void A()
        {
            try
            {
                string str3;
                string printerName = new PrinterSettings().PrinterName;
                string r = "\x001bp0@@";
                if (AR.U)
                {
                    str3 = printerName;
                }
                else
                {
                    str3 = !AR.L ? AR.X : printerName;
                }
                J.A(str3, r);
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                ProjectData.ClearProjectError();
            }
        }

        public class J
        {
            [DllImport("winspool.drv", EntryPoint="ClosePrinter", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Unicode, SetLastError=true, ExactSpelling=true)]
            public static extern bool A(IntPtr A);
            public static bool A(string A, string R)
            {
                bool flag;
                C p = new C();
                int length = R.Length;
                IntPtr r = Marshal.StringToCoTaskMemAnsi(R);
                p.A = "OpenDrawer";
                p.P = "RAW";
                try
                {
                    IntPtr ptr;
                    int num2;
                    W.J.A(A, ref ptr, 0);
                    W.J.A(ptr, 1, ref p);
                    P(ptr);
                    W.J.A(ptr, r, length, ref num2);
                    Q(ptr);
                    W.J.R(ptr);
                    W.J.A(ptr);
                    flag = true;
                }
                catch (Exception exception1)
                {
                    Exception ex = exception1;
                    ProjectData.SetProjectError(ex);
                    Interaction.MsgBox("Error occurred: " + ex.ToString(), MsgBoxStyle.ApplicationModal, null);
                    flag = false;
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    Marshal.FreeCoTaskMem(r);
                }
                return flag;
            }

            [DllImport("winspool.drv", EntryPoint="StartDocPrinterW", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Unicode, SetLastError=true, ExactSpelling=true)]
            public static extern bool A(IntPtr A, int R, ref C P);
            [DllImport("winspool.drv", EntryPoint="OpenPrinterW", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Unicode, SetLastError=true, ExactSpelling=true)]
            public static extern bool A(string A, ref IntPtr R, int P);
            [DllImport("winspool.drv", EntryPoint="WritePrinter", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Unicode, SetLastError=true, ExactSpelling=true)]
            public static extern bool A(IntPtr A, IntPtr R, int P, ref int Q);
            [DllImport("winspool.drv", EntryPoint="StartPagePrinter", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Unicode, SetLastError=true, ExactSpelling=true)]
            public static extern bool P(IntPtr A);
            [DllImport("winspool.drv", EntryPoint="EndPagePrinter", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Unicode, SetLastError=true, ExactSpelling=true)]
            public static extern bool Q(IntPtr A);
            [DllImport("winspool.drv", EntryPoint="EndDocPrinter", CallingConvention=CallingConvention.StdCall, CharSet=CharSet.Unicode, SetLastError=true, ExactSpelling=true)]
            public static extern bool R(IntPtr A);

            [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
            public struct C
            {
                [MarshalAs(UnmanagedType.LPWStr)]
                public string A;
                [MarshalAs(UnmanagedType.LPWStr)]
                public string R;
                [MarshalAs(UnmanagedType.LPWStr)]
                public string P;
            }
        }
    }
}

