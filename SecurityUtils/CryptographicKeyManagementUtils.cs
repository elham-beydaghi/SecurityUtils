using System.Security.Cryptography;
using System.Text;

namespace SecurityUtils
{
    public static class CryptographicKeyManagementUtils
    {
        public static string HMACComputing(string message, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);

            using (HMACSHA256 hmac = new HMACSHA256(keyBytes))
            {
                byte[] hashBytes = hmac.ComputeHash(messageBytes);
                string hmacString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return hmacString;
            }
        }
    }
}
