namespace A
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;

    [StandardModule]
    internal sealed class S
    {
        public static string A(string A)
        {
            int start = 1;
            string str2 = "";
            string str3 = "";
            while (true)
            {
                str2 = str2 + Conversions.ToString(Strings.Chr((int) Math.Round((double) (Conversion.Val(Strings.Mid(A, start, 2)) + 32.0))));
                start += 2;
                str3 = Strings.Mid(A, start, 1);
                if ((start >= Strings.Len(A)) || (str3 == ""))
                {
                    return str2;
                }
            }
        }

        public static Image A(string A, string R)
        {
            int num;
            int num2;
            string expression = "";
            if ((R == "A") | (R == "a"))
            {
                num2 = 0x67;
                expression = "00101111011";
            }
            if ((R == "B") | (R == "b"))
            {
                num2 = 0x68;
                expression = "00101101111";
            }
            if ((R == "C") | (R == "c"))
            {
                num2 = 0x69;
                expression = "00101100011";
            }
            int num3 = Strings.Len(A);
            for (num = 1; num <= num3; num++)
            {
                num2 += (Strings.Asc(Strings.Mid(A, num, 1)) - 0x20) * num;
                int num4 = Strings.Asc(Strings.Mid(A, num, 1));
                switch (num4)
                {
                    case 0x20:
                        expression = expression + "00100110011";
                        break;

                    case 0x21:
                        expression = expression + "00110010011";
                        break;

                    case 0x22:
                        expression = expression + "00110011001";
                        break;

                    case 0x23:
                        expression = expression + "01101100111";
                        break;

                    case 0x24:
                        expression = expression + "01101110011";
                        break;

                    case 0x25:
                        expression = expression + "01110110011";
                        break;

                    case 0x26:
                        expression = expression + "01100110111";
                        break;

                    case 0x27:
                        expression = expression + "01100111011";
                        break;

                    case 40:
                        expression = expression + "01110011011";
                        break;

                    case 0x29:
                        expression = expression + "00110110111";
                        break;

                    case 0x2a:
                        expression = expression + "00110111011";
                        break;

                    case 0x2b:
                        expression = expression + "00111011011";
                        break;

                    case 0x2c:
                        expression = expression + "01001100011";
                        break;

                    case 0x2d:
                        expression = expression + "01100100011";
                        break;

                    case 0x2e:
                        expression = expression + "01100110001";
                        break;

                    case 0x2f:
                        expression = expression + "01000110011";
                        break;

                    case 0x30:
                        expression = expression + "01100010011";
                        break;

                    case 0x31:
                        expression = expression + "01100011001";
                        break;

                    case 50:
                        expression = expression + "00110001101";
                        break;

                    case 0x33:
                        expression = expression + "00110100011";
                        break;

                    case 0x34:
                        expression = expression + "00110110001";
                        break;

                    case 0x35:
                        expression = expression + "00100011011";
                        break;

                    case 0x36:
                        expression = expression + "00110001011";
                        break;

                    case 0x37:
                        expression = expression + "00010010001";
                        break;

                    case 0x38:
                        expression = expression + "00010110011";
                        break;

                    case 0x39:
                        expression = expression + "00011010011";
                        break;

                    case 0x3a:
                        expression = expression + "00011011001";
                        break;

                    case 0x3b:
                        expression = expression + "00010011011";
                        break;

                    case 60:
                        expression = expression + "00011001011";
                        break;

                    case 0x3d:
                        expression = expression + "00011001101";
                        break;

                    case 0x3e:
                        expression = expression + "00100100111";
                        break;

                    case 0x3f:
                        expression = expression + "00100111001";
                        break;

                    case 0x40:
                        expression = expression + "00111001001";
                        break;

                    case 0x41:
                        expression = expression + "01011100111";
                        break;

                    case 0x42:
                        expression = expression + "01110100111";
                        break;

                    case 0x43:
                        expression = expression + "01110111001";
                        break;

                    case 0x44:
                        expression = expression + "01001110111";
                        break;

                    case 0x45:
                        expression = expression + "01110010111";
                        break;

                    case 70:
                        expression = expression + "01110011101";
                        break;

                    case 0x47:
                        expression = expression + "00101110111";
                        break;

                    case 0x48:
                        expression = expression + "00111010111";
                        break;

                    case 0x49:
                        expression = expression + "00111011101";
                        break;

                    case 0x4a:
                        expression = expression + "01001000111";
                        break;

                    case 0x4b:
                        expression = expression + "01001110001";
                        break;

                    case 0x4c:
                        expression = expression + "01110010001";
                        break;

                    case 0x4d:
                        expression = expression + "01000100111";
                        break;

                    case 0x4e:
                        expression = expression + "01000111001";
                        break;

                    case 0x4f:
                        expression = expression + "01110001001";
                        break;

                    case 80:
                        expression = expression + "00010001001";
                        break;

                    case 0x51:
                        expression = expression + "00101110001";
                        break;

                    case 0x52:
                        expression = expression + "00111010001";
                        break;

                    case 0x53:
                        expression = expression + "00100010111";
                        break;

                    case 0x54:
                        expression = expression + "00100011101";
                        break;

                    case 0x55:
                        expression = expression + "00100010001";
                        break;

                    case 0x56:
                        expression = expression + "00010100111";
                        break;

                    case 0x57:
                        expression = expression + "00010111001";
                        break;

                    case 0x58:
                        expression = expression + "00011101001";
                        break;

                    case 0x59:
                        expression = expression + "00010010111";
                        break;

                    case 90:
                        expression = expression + "00010011101";
                        break;

                    case 0x5b:
                        expression = expression + "00011100101";
                        break;

                    case 0x5c:
                        expression = expression + "00010000101";
                        break;

                    case 0x5d:
                        expression = expression + "00110111101";
                        break;

                    case 0x5e:
                        expression = expression + "00001110101";
                        break;

                    case 0x5f:
                        expression = expression + "01011001111";
                        break;

                    case 0x60:
                        expression = expression + "01011110011";
                        break;

                    case 0x61:
                        expression = expression + "01101001111";
                        break;

                    case 0x62:
                        expression = expression + "01101111001";
                        break;

                    case 0x63:
                        expression = expression + "01111010011";
                        break;

                    case 100:
                        expression = expression + "01111011001";
                        break;

                    case 0x65:
                        expression = expression + "01001101111";
                        break;

                    case 0x66:
                        expression = expression + "01001111011";
                        break;

                    case 0x67:
                        expression = expression + "01100101111";
                        break;

                    case 0x68:
                        expression = expression + "01100111101";
                        break;

                    case 0x69:
                        expression = expression + "01111001011";
                        break;

                    case 0x6a:
                        expression = expression + "01111001101";
                        break;

                    case 0x6b:
                        expression = expression + "00111101101";
                        break;

                    case 0x6c:
                        expression = expression + "00110101111";
                        break;

                    case 0x6d:
                        expression = expression + "00001000101";
                        break;

                    case 110:
                        expression = expression + "00111101011";
                        break;

                    case 0x6f:
                        expression = expression + "01110000101";
                        break;

                    case 0x70:
                        expression = expression + "01011000011";
                        break;

                    case 0x71:
                        expression = expression + "01101000011";
                        break;

                    case 0x72:
                        expression = expression + "01101100001";
                        break;

                    case 0x73:
                        expression = expression + "01000011011";
                        break;

                    case 0x74:
                        expression = expression + "01100001011";
                        break;

                    case 0x75:
                        expression = expression + "01100001101";
                        break;

                    case 0x76:
                        expression = expression + "00001011011";
                        break;

                    case 0x77:
                        expression = expression + "00001101011";
                        break;

                    case 120:
                        expression = expression + "00001101101";
                        break;

                    case 0x79:
                        expression = expression + "00100100001";
                        break;

                    case 0x7a:
                        expression = expression + "00100001001";
                        break;

                    case 0x7b:
                        expression = expression + "00001001001";
                        break;

                    case 0x7c:
                        expression = expression + "01010000111";
                        break;

                    case 0x7d:
                        expression = expression + "01011100001";
                        break;

                    case 0x7e:
                        expression = expression + "01110100001";
                        break;

                    case 0x7f:
                        expression = expression + "01000010111";
                        break;

                    case 0x80:
                        expression = expression + "01000011101";
                        break;

                    case 0x81:
                        expression = expression + "00001010111";
                        break;

                    case 130:
                        expression = expression + "00001011101";
                        break;

                    case 0x83:
                        expression = expression + "01000100001";
                        break;

                    case 0x84:
                        expression = expression + "01000010001";
                        break;

                    case 0x85:
                        expression = expression + "00010100001";
                        break;

                    case 0x86:
                        expression = expression + "00001010001";
                        break;

                    case 0x87:
                        expression = expression + "00101111011";
                        break;

                    case 0x88:
                        expression = expression + "00101101111";
                        break;

                    case 0x89:
                        expression = expression + "00101100011";
                        break;

                    case 0x8a:
                        expression = expression + "0011100010100";
                        break;

                    default:
                        break;
                }
            }
            switch ((num2 % 0x67))
            {
                case 0:
                    expression = expression + "00100110011";
                    break;

                case 1:
                    expression = expression + "00110010011";
                    break;

                case 2:
                    expression = expression + "00110011001";
                    break;

                case 3:
                    expression = expression + "01101100111";
                    break;

                case 4:
                    expression = expression + "01101110011";
                    break;

                case 5:
                    expression = expression + "01110110011";
                    break;

                case 6:
                    expression = expression + "01100110111";
                    break;

                case 7:
                    expression = expression + "01100111011";
                    break;

                case 8:
                    expression = expression + "01110011011";
                    break;

                case 9:
                    expression = expression + "00110110111";
                    break;

                case 10:
                    expression = expression + "00110111011";
                    break;

                case 11:
                    expression = expression + "00111011011";
                    break;

                case 12:
                    expression = expression + "01001100011";
                    break;

                case 13:
                    expression = expression + "01100100011";
                    break;

                case 14:
                    expression = expression + "01100110001";
                    break;

                case 15:
                    expression = expression + "01000110011";
                    break;

                case 0x10:
                    expression = expression + "01100010011";
                    break;

                case 0x11:
                    expression = expression + "01100011001";
                    break;

                case 0x12:
                    expression = expression + "00110001101";
                    break;

                case 0x13:
                    expression = expression + "00110100011";
                    break;

                case 20:
                    expression = expression + "00110110001";
                    break;

                case 0x15:
                    expression = expression + "00100011011";
                    break;

                case 0x16:
                    expression = expression + "00110001011";
                    break;

                case 0x17:
                    expression = expression + "00010010001";
                    break;

                case 0x18:
                    expression = expression + "00010110011";
                    break;

                case 0x19:
                    expression = expression + "00011010011";
                    break;

                case 0x1a:
                    expression = expression + "00011011001";
                    break;

                case 0x1b:
                    expression = expression + "00010011011";
                    break;

                case 0x1c:
                    expression = expression + "00011001011";
                    break;

                case 0x1d:
                    expression = expression + "00011001101";
                    break;

                case 30:
                    expression = expression + "00100100111";
                    break;

                case 0x1f:
                    expression = expression + "00100111001";
                    break;

                case 0x20:
                    expression = expression + "00111001001";
                    break;

                case 0x21:
                    expression = expression + "01011100111";
                    break;

                case 0x22:
                    expression = expression + "01110100111";
                    break;

                case 0x23:
                    expression = expression + "01110111001";
                    break;

                case 0x24:
                    expression = expression + "01001110111";
                    break;

                case 0x25:
                    expression = expression + "01110010111";
                    break;

                case 0x26:
                    expression = expression + "01110011101";
                    break;

                case 0x27:
                    expression = expression + "00101110111";
                    break;

                case 40:
                    expression = expression + "00111010111";
                    break;

                case 0x29:
                    expression = expression + "00111011101";
                    break;

                case 0x2a:
                    expression = expression + "01001000111";
                    break;

                case 0x2b:
                    expression = expression + "01001110001";
                    break;

                case 0x2c:
                    expression = expression + "01110010001";
                    break;

                case 0x2d:
                    expression = expression + "01000100111";
                    break;

                case 0x2e:
                    expression = expression + "01000111001";
                    break;

                case 0x2f:
                    expression = expression + "01110001001";
                    break;

                case 0x30:
                    expression = expression + "00010001001";
                    break;

                case 0x31:
                    expression = expression + "00101110001";
                    break;

                case 50:
                    expression = expression + "00111010001";
                    break;

                case 0x33:
                    expression = expression + "00100010111";
                    break;

                case 0x34:
                    expression = expression + "00100011101";
                    break;

                case 0x35:
                    expression = expression + "00100010001";
                    break;

                case 0x36:
                    expression = expression + "00010100111";
                    break;

                case 0x37:
                    expression = expression + "00010111001";
                    break;

                case 0x38:
                    expression = expression + "00011101001";
                    break;

                case 0x39:
                    expression = expression + "00010010111";
                    break;

                case 0x3a:
                    expression = expression + "00010011101";
                    break;

                case 0x3b:
                    expression = expression + "00011100101";
                    break;

                case 60:
                    expression = expression + "00010000101";
                    break;

                case 0x3d:
                    expression = expression + "00110111101";
                    break;

                case 0x3e:
                    expression = expression + "00001110101";
                    break;

                case 0x3f:
                    expression = expression + "01011001111";
                    break;

                case 0x40:
                    expression = expression + "01011110011";
                    break;

                case 0x41:
                    expression = expression + "01101001111";
                    break;

                case 0x42:
                    expression = expression + "01101111001";
                    break;

                case 0x43:
                    expression = expression + "01111010011";
                    break;

                case 0x44:
                    expression = expression + "01111011001";
                    break;

                case 0x45:
                    expression = expression + "01001101111";
                    break;

                case 70:
                    expression = expression + "01001111011";
                    break;

                case 0x47:
                    expression = expression + "01100101111";
                    break;

                case 0x48:
                    expression = expression + "01100111101";
                    break;

                case 0x49:
                    expression = expression + "01111001011";
                    break;

                case 0x4a:
                    expression = expression + "01111001101";
                    break;

                case 0x4b:
                    expression = expression + "00111101101";
                    break;

                case 0x4c:
                    expression = expression + "00110101111";
                    break;

                case 0x4d:
                    expression = expression + "00001000101";
                    break;

                case 0x4e:
                    expression = expression + "00111101011";
                    break;

                case 0x4f:
                    expression = expression + "01110000101";
                    break;

                case 80:
                    expression = expression + "01011000011";
                    break;

                case 0x51:
                    expression = expression + "01101000011";
                    break;

                case 0x52:
                    expression = expression + "01101100001";
                    break;

                case 0x53:
                    expression = expression + "01000011011";
                    break;

                case 0x54:
                    expression = expression + "01100001011";
                    break;

                case 0x55:
                    expression = expression + "01100001101";
                    break;

                case 0x56:
                    expression = expression + "00001011011";
                    break;

                case 0x57:
                    expression = expression + "00001101011";
                    break;

                case 0x58:
                    expression = expression + "00001101101";
                    break;

                case 0x59:
                    expression = expression + "00100100001";
                    break;

                case 90:
                    expression = expression + "00100001001";
                    break;

                case 0x5b:
                    expression = expression + "00001001001";
                    break;

                case 0x5c:
                    expression = expression + "01010000111";
                    break;

                case 0x5d:
                    expression = expression + "01011100001";
                    break;

                case 0x5e:
                    expression = expression + "01110100001";
                    break;

                case 0x5f:
                    expression = expression + "01000010111";
                    break;

                case 0x60:
                    expression = expression + "01000011101";
                    break;

                case 0x61:
                    expression = expression + "00001010111";
                    break;

                case 0x62:
                    expression = expression + "00001011101";
                    break;

                case 0x63:
                    expression = expression + "01000100001";
                    break;

                case 100:
                    expression = expression + "01000010001";
                    break;

                case 0x65:
                    expression = expression + "00010100001";
                    break;

                case 0x66:
                    expression = expression + "00001010001";
                    break;

                default:
                    break;
            }
            expression = expression + "0011100010100";
            Bitmap image = new Bitmap(Strings.Len(expression), 0x19, PixelFormat.Format24bppRgb);
            Graphics graphics = Graphics.FromImage(image);
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            graphics.FillRectangle(new LinearGradientBrush(rect, Color.White, Color.White, LinearGradientMode.ForwardDiagonal), rect);
            int num5 = Strings.Len(expression);
            for (num = 1; num <= num5; num++)
            {
                Point point;
                Point point2;
                string str2 = Strings.Mid(expression, num, 1);
                if (str2 == "0")
                {
                    point = new Point(num, 0);
                    point2 = new Point(num, 40);
                    graphics.DrawLine(new Pen(Color.Black, 1f), point, point2);
                }
                else
                {
                    point = new Point(num, 0);
                    point2 = new Point(num, 40);
                    graphics.DrawLine(new Pen(Color.White, 1f), point, point2);
                }
            }
            return image;
        }
    }
}

