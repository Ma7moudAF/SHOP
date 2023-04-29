namespace A
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public class Z
    {
        private static TripleDESCryptoServiceProvider A = new TripleDESCryptoServiceProvider();
        private static MD5CryptoServiceProvider A = new MD5CryptoServiceProvider();

        public static byte[] A(string A) => 
            Z.A.ComputeHash(Encoding.ASCII.GetBytes(A));

        public static string A(string A, string R)
        {
            Z.A.Key = QR.A(R);
            Z.A.Mode = CipherMode.ECB;
            byte[] bytes = Encoding.ASCII.GetBytes(A);
            return Convert.ToBase64String(Z.A.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
        }

        public static string R(string A, string R)
        {
            try
            {
                Z.A.Key = QR.A(R);
                Z.A.Mode = CipherMode.ECB;
                byte[] inputBuffer = Convert.FromBase64String(A);
                return Encoding.ASCII.GetString(Z.A.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length));
            }
            catch (Exception exception1)
            {
                Exception ex = exception1;
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                ProjectData.ClearProjectError();
            }
            return Conversions.ToString(false);
        }
    }
}

