using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt.Algorithms
{
    internal class RSACryptography
    {
        /// <summary>
        /// Generate RSA key pair
        /// </summary>
        /// <param name="keySize">Size of key pair</param>
        /// <returns></returns>
        public static (string privateKey, string publicKey) GenerateKeyPair(int keySize)
        {
            string privateKey, publicKey;
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(keySize);

            privateKey = rsaProvider.ToXmlString(includePrivateParameters: true);
            publicKey = rsaProvider.ToXmlString(includePrivateParameters: false);
            privateKey = RSAKeyConverter.XmlToPem(privateKey);
            publicKey = RSAKeyConverter.XmlToPem(publicKey);

            System.Diagnostics.Debug.WriteLine(publicKey);
            System.Diagnostics.Debug.WriteLine(privateKey);

            return (privateKey, publicKey);
        }
        /// <summary>
        /// RSA Encrypt plain text
        /// </summary>
        /// <param name="strText">Plain text</param>
        /// <param name="publicKey">Public key</param>
        /// <param name="keySize">Size of key pair</param>
        /// <returns>Cipher text</returns>
        public static string Encryption(string strText, string publicKey, int dwKeySize)
        {
            var plainText = Encoding.UTF8.GetBytes(strText);

            using (var rsa = new RSACryptoServiceProvider(dwKeySize))
            {
                try
                {
                    publicKey = RSAKeyConverter.PemToXml(publicKey);
                    rsa.FromXmlString(publicKey.ToString());

                    int keySize = rsa.KeySize / 8;
                    int maxLenght = keySize - 42; //int maxLength = ( keySize ) - 2 - 
                                                   //              ( 2 * SHA1.Create().ComputeHash( rawBytes ).Length );
                    int dataLenght = plainText.Length;
                    int iterations = dataLenght / maxLenght;
                    StringBuilder stringBuilder = new StringBuilder();

                    for (int i = 0; i < iterations; i++)
                    {
                        byte[] tempBytes = new byte[
                            dataLenght - maxLenght * i > maxLenght ? maxLenght :
                            dataLenght - maxLenght * i
                            ];
                        Buffer.BlockCopy(plainText, maxLenght * i, tempBytes, 0, tempBytes.Length);

                        var encryptedData = rsa.Encrypt(tempBytes, true);

                        Array.Reverse(encryptedData);

                        stringBuilder.Append(Convert.ToBase64String(encryptedData));
                    }

                    return stringBuilder.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        /// <summary>
        /// RSA Decrypt cipher text
        /// </summary>
        /// <param name="strText">Cipher text</param>
        /// <param name="privateKey">Private key</param>
        /// <param name="keySize">Size of key pair</param>
        /// <returns>Plain text</returns>
        public static string Decryption(string strText, string privateKey, int dwKeySize)
        {

            using (var rsa = new RSACryptoServiceProvider(dwKeySize))
            {
                try
                {
                    privateKey = RSAKeyConverter.PemToXml(privateKey);
                    rsa.FromXmlString(privateKey);

                    int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ?
                                          (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
                    int iterations = strText.Length / base64BlockSize;
                    ArrayList arrayList = new ArrayList();

                    for(int i = 0; i < iterations; i++)
                    {
                        var base64Encrypted = Convert.FromBase64String(
                            strText.Substring(base64BlockSize * i, base64BlockSize)
                            );
                        Array.Reverse(base64Encrypted);

                        var decryptData = rsa.Decrypt(base64Encrypted, true);

                        arrayList.Add(decryptData);
                    }

                    byte[] decryptedByte = arrayList.Cast<byte[]>().SelectMany(a => a).ToArray();

                    var decryptedData = Encoding.UTF8.GetString(decryptedByte);

                    return decryptedData.ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
    }
}
