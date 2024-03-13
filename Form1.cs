using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace Signer
{
    public partial class Form1 : Form
    {
        private RSACryptoServiceProvider rsaProvider1, rsaProvider2;
        private X509Certificate2 certificate1, certificate2;

        public Form1()
        {
            InitializeComponent();
        }

        public string source, key1, key2, key3, cert1, cert2, original, signed;
        public string output, saveKey;
        int keySize = 0;

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.Title = "Select a file to Encrypt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                source = openFileDialog1.FileName;
            }
            cmbx_RSAkeysize.SelectedIndex = 0;
        }

        private void btn_LoadKeys_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Key files (*.bin)|*.bin";

            // Nalaganje zasebnega kljuèa za podpis
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                key1 = openFileDialog2.FileName;
                rsaProvider1 = new RSACryptoServiceProvider();
                rsaProvider1.FromXmlString(File.ReadAllText(key1));

                MessageBox.Show("RSA key loaded successfully.");
            }


        }

        private void btn_generateKeys_Click(object sender, EventArgs e)
        {
            keySize = Convert.ToUInt16(cmbx_RSAkeysize.SelectedItem.ToString());

            rsaProvider1 = new RSACryptoServiceProvider(keySize);
            MessageBox.Show($"RSA key pair generated with {keySize}-bit key size.");
        }

        private void btn_SaveKeys_Click(object sender, EventArgs e)
        {
            if (rsaProvider1 == null)
            {
                MessageBox.Show("No RSA key pair generated yet.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog1.Filter = "All files (*.*)|*.*";
            saveFileDialog1.Title = "Save key files";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                key2 = saveFileDialog.FileName;

                // Shranimo javne in zasebne kljuèe v isti imenik

                string directoryPath = Path.GetDirectoryName(key2);
                string private_key = "private_key.bin";
                string public_key = "public_key.bin";
                private_key = Path.Combine(directoryPath, private_key);
                public_key = Path.Combine(directoryPath, public_key);

                // Zapis datotek na disk
                File.WriteAllText(private_key, rsaProvider1.ToXmlString(true));
                File.WriteAllText(public_key, rsaProvider1.ToXmlString(false));

                MessageBox.Show("RSA key pair saved successfully.");
            }
        }

        private void btn_LoadCer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.Filter = "Certificate files (*.pfx)|*.pfx";

            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                cert1 = openFileDialog3.FileName;

                try
                {
                    certificate1 = new X509Certificate2(cert1, cert_pass.Text);
                    MessageBox.Show("Certificate uploaded successfully.");
                }
                catch
                {
                    MessageBox.Show("Invalid certificate file or password.");
                }
            }
        }

        private void btn_VerifyCer_Click(object sender, EventArgs e)
        {
            if (certificate1 == null)
            {
                MessageBox.Show("No certificate uploaded yet.");
                return;
            }

            try
            {
                certificate1.Verify();
                MessageBox.Show("Certificate is valid.");
            }
            catch
            {
                MessageBox.Show("Certificate is invalid.");
            }
        }


        private void btn_SignFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                output = saveFileDialog2.FileName;

                byte[] data = File.ReadAllBytes(source);
                byte[] signature;

                if (radioButton1.Checked)
                {
                    if (rsaProvider1 == null)
                    {
                        MessageBox.Show("No RSA key pair generated yet.");
                        return;
                    }

                    using (SHA256 sha256 = SHA256.Create())
                    {
                        signature = rsaProvider1.SignData(data, sha256);
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (certificate1 == null)
                    {
                        MessageBox.Show("No certificate uploaded yet.");
                        return;
                    }

                    
                    var rsa = certificate1.GetRSAPrivateKey();
                    signature = rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                    File.WriteAllBytes(output, signature);               

                    
                }
                else
                {
                    MessageBox.Show("Please choose a signing method.");
                    return;
                }

                MessageBox.Show("File signed successfully.");
            }

        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {


            byte[] data = File.ReadAllBytes(original);
            byte[] signature = File.ReadAllBytes(signed);

            bool isVerified;

            if (radioButton4.Checked)
            {
                if (rsaProvider2 == null)
                {
                    MessageBox.Show("No RSA key pair generated yet.");
                    return;
                }

                using (SHA256 sha256 = SHA256.Create())
                {
                    isVerified = rsaProvider2.VerifyData(data, sha256, signature);
                    
                }
            }
            else if (radioButton3.Checked)
            {
                if (certificate2 == null)
                {
                    MessageBox.Show("No certificate uploaded yet.");
                    return;
                }

                using (SHA256 sha256 = SHA256.Create())
                {

                    var rsa = certificate2.GetRSAPublicKey();
                    isVerified = rsa.VerifyData(data, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                }
            }
            else
            {
                MessageBox.Show("Please choose a verification method.");
                return;
            }

            if (isVerified)
            {
                MessageBox.Show("Digital signature is VALID.");
            }
            else
            {
                MessageBox.Show("Digital signature is INVALID.");
                return;
            }

        }

        private void btn_LoadOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog4 = new OpenFileDialog();

            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                original = openFileDialog4.FileName;
            }
        }

        private void btn_LoadSigned_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog5 = new OpenFileDialog();

            if (openFileDialog5.ShowDialog() == DialogResult.OK)
            {
                signed = openFileDialog5.FileName;
            }

        }

        private void btn_LoadPubKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog6 = new OpenFileDialog();
            openFileDialog6.Filter = "Key files (*.bin)|*.bin";

            if (openFileDialog6.ShowDialog() == DialogResult.OK)
            {
                key3 = openFileDialog6.FileName;
                rsaProvider2 = new RSACryptoServiceProvider();
                rsaProvider2.FromXmlString(File.ReadAllText(key3));

                MessageBox.Show("RSA key loaded successfully.");
            }
        }

        private void btn_LoadCert2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog7 = new OpenFileDialog();
            openFileDialog7.Filter = "Certificate files (*.cer)|*.cer|All files (*.*)|*.*";

            if (openFileDialog7.ShowDialog() == DialogResult.OK)
            {
                cert2 = openFileDialog7.FileName;
                try
                {
                    certificate2 = new X509Certificate2(cert2);
                    MessageBox.Show("Certificate uploaded successfully.");
                }
                catch
                {
                    MessageBox.Show("Invalid certificate file.");
                }
            }
        }


    }
}
