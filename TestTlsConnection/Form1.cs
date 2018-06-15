using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTlsConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextUrl.Text = "https://";
            ClearText();
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            ClearText();
            TxtScannedSite.Text = TextUrl.Text;
            if (IsValidUri(TextUrl.Text))
            {
                Uri uri = new Uri(TextUrl.Text);
            
            try
            {
                TestUrl(uri);
            }
            catch(Exception ex) {
                LblErrMsg.Visible = true;
                TxtError.Visible = true;
                TxtError.Text = $"Hmm... Looks like something went wrong. Did you type the url correctly? The exception returned was as follows:\n {ex.Message}";
            }
            }
            else
            {
                LblErrMsg.Visible = true;
                TxtError.Visible = true;
                TxtError.Text = $"The value [{TextUrl.Text}] is not a valid URL. Please enter a valid url.";
            }
        }
        Boolean IsValidUri(String uri)
        {
            try
            {
                new Uri(uri);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextUrl.Text = "https://";
            ClearText();
        }
        private void ClearText()
        {
           
            TxtScannedSite.Text = "";
            TxtProtocolVersion.Text = "";
            TxtCipherAlgorithm.Text = "";
            TxtHashAlgorithm.Text = "";
            TxtRemoteCertificate.Text = "";
            LblErrMsg.Visible = false;
            TxtError.Text = "";
            TxtError.Visible = false;
        }


        private void TestUrl(Uri decodedUri)
        {
            //ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            /// Not sure if order makes a difference
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (TcpClient client = new TcpClient(decodedUri.DnsSafeHost, 443))
            using (SslStream sslStream = new SslStream(client.GetStream()))
            {


                // use this overload to ensure SslStream has the same scope of enabled protocol as HttpWebRequest
                sslStream.AuthenticateAsClient(decodedUri.Host, null, (SslProtocols)ServicePointManager.SecurityProtocol, true);

                TlsInfo tlsInfo = new TlsInfo(sslStream);
                Console.WriteLine($"ProtocolVersion: {tlsInfo.ProtocolVersion.ToString()}");
                TxtProtocolVersion.Text = tlsInfo.ProtocolVersion.ToString();
                Console.WriteLine($"CipherAlgorithm: {tlsInfo.CipherAlgorithm.ToString()}");
                TxtCipherAlgorithm.Text = tlsInfo.CipherAlgorithm.ToString();
                Console.WriteLine($"HashAlgorithm: {tlsInfo.HashAlgorithm.ToString()}");
                TxtHashAlgorithm.Text = tlsInfo.HashAlgorithm.ToString();
                Console.WriteLine($"RemoteCertificate: {tlsInfo.RemoteCertificate.Subject}");
                TxtRemoteCertificate.Text = tlsInfo.RemoteCertificate.Subject;

                client.Close();
                sslStream.Close();
            }
        }
    }
}
