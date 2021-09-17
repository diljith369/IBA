using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecrypt
{
    public partial class CipherOpsForm : Form
    {
        public CipherOpsForm()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //fRZstgVonk1WpSLeb9ZKcoDkGPzHWDqSAMyTxoopGc8=
            //pyve1rU+58PN/2MWEftieA==

            byte[] Key = Convert.FromBase64String(txtKey.Text);
            byte[] IV = Convert.FromBase64String(txtIV.Text);
            if (rdbDecrypt.Checked)
            {
                byte[] baResult = AESDecryptor(Convert.FromBase64String(txtOps.Text), Key, IV);
                string strRes =  Encoding.ASCII.GetString(baResult);
                txtResult.Text =  strRes;
            } else
            {
                txtResult.Text = Convert.ToBase64String(AESEncrypt(Encoding.ASCII.GetBytes(txtOps.Text), Key, IV));
            }
        }

        private  byte[] AESDecryptor(byte[] baEncryptedText, byte[] key, byte[] iv)
        {
            byte[] baResult;
            using (var aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;
                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    baResult =  GetDecryptedStream(baEncryptedText, decryptor);
                }
            }
            return baResult;
        }
        private  byte[] GetDecryptedStream(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();

                return ms.ToArray();
            }
        }

        private  byte[] AESEncrypt(byte[] baPlainText, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                aes.Key = key;
                aes.IV = iv;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    return GetAESEncrypted(baPlainText, encryptor);
                }
            }
        }

        private  byte[] GetAESEncrypted(byte[] baShellcode, ICryptoTransform cryptoTransform)
        {
            using (var msEncShellCode = new MemoryStream())
            using (var cryptoStream = new CryptoStream(msEncShellCode, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(baShellcode, 0, baShellcode.Length);
                cryptoStream.FlushFinalBlock();

                return msEncShellCode.ToArray();
            }
        }
    }
}
