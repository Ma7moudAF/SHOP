namespace A
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    public class M
    {
        public string A(string A)
        {
            string password = "MAKV3SPBNI99213";
            byte[] buffer = Encoding.Unicode.GetBytes(A);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, new byte[] { 0x49, 0x76, 0x61, 110, 0x20, 0x4d, 0x65, 100, 0x76, 0x65, 100, 0x65, 0x76 });
                aes.Key = bytes.GetBytes(0x20);
                aes.IV = bytes.GetBytes(0x10);
                using (MemoryStream stream = new MemoryStream())
                {
                    using (CryptoStream stream2 = new CryptoStream(stream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        stream2.Write(buffer, 0, buffer.Length);
                        stream2.Close();
                    }
                    A = Convert.ToBase64String(stream.ToArray());
                }
            }
            return A;
        }

        public string R(string A)
        {
            string password = "MAKV3SPBNI99213";
            byte[] buffer = Convert.FromBase64String(A);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, new byte[] { 0x49, 0x76, 0x61, 110, 0x20, 0x4d, 0x65, 100, 0x76, 0x65, 100, 0x65, 0x76 });
                aes.Key = bytes.GetBytes(0x20);
                aes.IV = bytes.GetBytes(0x10);
                using (MemoryStream stream = new MemoryStream())
                {
                    using (CryptoStream stream2 = new CryptoStream(stream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        stream2.Write(buffer, 0, buffer.Length);
                        stream2.Close();
                    }
                    A = Encoding.Unicode.GetString(stream.ToArray());
                }
            }
            return A;
        }
    }
}

