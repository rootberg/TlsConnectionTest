using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace TestTlsConnection
{
    public class TlsInfo
    {
        public TlsInfo(SslStream SecureStream)
        {
            this.ProtocolVersion = SecureStream.SslProtocol;
            this.CipherAlgorithm = SecureStream.CipherAlgorithm;
            this.HashAlgorithm = SecureStream.HashAlgorithm;
            this.RemoteCertificate = SecureStream.RemoteCertificate;
        }

        public SslProtocols ProtocolVersion { get; set; }
        public CipherAlgorithmType CipherAlgorithm { get; set; }
        public HashAlgorithmType HashAlgorithm { get; set; }
        public X509Certificate RemoteCertificate { get; set; }
    }
}
