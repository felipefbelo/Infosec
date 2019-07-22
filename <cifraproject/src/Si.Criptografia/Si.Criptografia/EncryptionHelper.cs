using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Si.Criptografia
{
    public static class EncryptionHelper
    {
        public static string EncryptASCIIFile(string path, string key)
        {
            string str = File.ReadAllText(path, Encoding.ASCII);
            return Encrypt(str, key);
        }

        public static string DecryptASCIIFile(string path, string key)
        {
            string str = File.ReadAllText(path, Encoding.ASCII);
            return Decrypt(str, key);
        }

        public static string Encrypt(EncryptionInfo info)
        {
            CheckInfo(info);
            return EncryptASCIIFile(info.File, info.Key);
        }

        public static string Decrypt(EncryptionInfo info)
        {
            CheckInfo(info);
            return DecryptASCIIFile(info.File, info.Key);
        }

        private static void CheckInfo(EncryptionInfo info)
        {
            if (!info.IsValidKeyLenght())
            {
                throw new EncryptionException(string.Format("A chave deve conter {0} caracteres.", info.GetRequiredKeyLenght()));
            }

            if (string.IsNullOrEmpty(info.File))
            {
                throw new EncryptionException("O arquivo não foi informado.");
            }
        }

        public static string Encrypt(string str, string key)
        {
            int bits = key.Length * 8;
            string[] blocks = PartitionStringBinary(EncryptionHelper.ToASCIIBinary(str), bits);
            return EncryptPartitionStringBinary(blocks, key);
        }

        public static string Decrypt(string str, string key)
        {
            int bits = key.Length * 8;
            string[] blocks = PartitionStringBinary(str, bits);
            return DecryptPartitionStringBinary(blocks, key);
        }

        private static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }

        private static string ToStringBinary(Byte[] data)
        {
            return string.Join(string.Empty, data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }

        private static string ToASCIIBinary(string str)
        {
            return ToStringBinary(ConvertToByteArray(str, Encoding.ASCII));
        }

        private static string[] PartitionStringBinary(string str, int sizePart)
        {
            int count = str.Length / sizePart;

            if ((str.Length % sizePart) > 0)
            {
                count++;
            }

            var binaryList = Enumerable.Range(0, count).Select(i =>
            {
                int startIndex = i * sizePart;
                int size = sizePart;

                if (startIndex + size > str.Length)
                {
                    size = str.Length - startIndex;
                }

                return str.Substring(startIndex, size);
            })
            .ToList();


            if (binaryList.Count > 0 && binaryList[binaryList.Count - 1].Length < sizePart)
            {
                binaryList[binaryList.Count - 1] = binaryList[binaryList.Count - 1].PadRight(sizePart, '0');
            }

            return binaryList.ToArray();
        }

        private static string BinaryToString(string strBinary)
        {
            int count = strBinary.Length / 8;

            var byteList = Enumerable.Range(0, count).Select(i =>
            {
                int startIndex = i * 8;
                int size = 8;

                if (startIndex + size > strBinary.Length)
                {
                    size = strBinary.Length - startIndex;
                }

                return Convert.ToByte(strBinary.Substring(startIndex, size), 2);

            }).ToList();

            return string.Join(string.Empty, byteList.Select(c => Convert.ToChar(c)));
        }

        private static string EncryptPartitionStringBinary(string[] blocks, string key)
        {
            string strOut = null;
            string binaryKey = ToASCIIBinary(key);

            foreach (var block in blocks)
            {
                string strItem = null;

                for (int i = block.Length - 1; i >= 0; i--)
                {
                    strItem = (block[i] ^ binaryKey[i]) + strItem;
                }

                strOut += strItem;
            }

            return strOut;
        }

        private static string DecryptPartitionStringBinary(string[] blocks, string key)
        {
            string binaryKey = ToASCIIBinary(key);
            string strBinaryOut = null;

            foreach (var block in blocks)
            {
                for (int i = 0; i < binaryKey.Length; i++)
                {
                    strBinaryOut += (block[i] ^ binaryKey[i]);
                }
            }

            if (strBinaryOut.EndsWith("00000000"))
            {
                strBinaryOut = strBinaryOut.Substring(0, strBinaryOut.Length - 8);
            }

            return BinaryToString(strBinaryOut);
        }
    }
}
