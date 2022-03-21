using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt.Algorithms
{
    internal class Vigenere
    {
        public string Key { get; set; }
        public string PlainText { get; set; }
        public string CipherText { get; set; }

        private string VietnameseAlphabet = "AĂÂBCDĐEÊGHIKLMNOÔƠPQRSTUƯVXY?!ÁÀẢÃẠẮẰẲẴẶẤẦẨẪẬÉÈẺẼẸẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌỐỒỔỖỘỚỜỞỠỢÚÙỦŨỤỨỪỬỮỰÝỲỶỸỴ aăâbcdđeêghiklmnoôơpqrstuưvxy?!áàảãạắằẳẵặấầẩẫậéèẻẽẹếềểễệíìỉĩịóòỏõọốồổỗộớờởỡợúùủũụứừửữựýỳỷỹỵ";

        public Vigenere(string k = "", string pText = "", string cText = "")
        {
            Key = k;
            PlainText = pText;
            CipherText = cText;
        }

        public int[] StringToIndex(string s)
        {
            int[] array = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                array[i] = VietnameseAlphabet.IndexOf(s[i]);

            return array;
        }

        public string IndexToString(int[] a)
        {
            string s = "";
            for (int i = 0; i < a.Length; i++)
                s += VietnameseAlphabet[a[i]];

            return s;
        }

        public string Encrypt()
        {
            int[] p = StringToIndex(PlainText);
            int[] k = StringToIndex(Key);

            int[] result = new int[PlainText.Length];
            for (int i = 0, j = 0; i < PlainText.Length; i++)
            {
                result[i] = (p[i] + k[j]) % VietnameseAlphabet.Length;
                j = ++j % k.Length;
            }
            CipherText = IndexToString(result);

            return CipherText;
        }

        public string Decrypt()
        {
            int[] c = StringToIndex(CipherText);
            int[] k = StringToIndex(Key);

            int[] result = new int[CipherText.Length];
            for (int i = 0, j = 0; i < CipherText.Length; i++)
            {
                result[i] = (c[i] - k[j]) % VietnameseAlphabet.Length;
                if (result[i] < 0)
                    result[i] =
                        (c[j] + (VietnameseAlphabet.Length - k[j])) % VietnameseAlphabet.Length;
                
                j = ++j % k.Length;
            }
            PlainText = IndexToString(result);

            return PlainText;
        }
    }
}
