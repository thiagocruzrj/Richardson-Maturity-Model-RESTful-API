using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace LibraryApi.Security.Configuration
{
    public class SigningConfiguration
    {
        public SecurityKey Key { get; }
        public SigningCredentials SigningCredentitals { get; }

        public SigningConfiguration()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                Key = new RsaSecurityKey(provider.ExportParameters(true));
            }

            SigningCredentitals = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}