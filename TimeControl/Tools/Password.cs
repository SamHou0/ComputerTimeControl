using System.Security.Cryptography;
using System.Text;

namespace TimeControl.Tools
{
    internal static class Password
    {
        public static string ComputeHash(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            MD5 md5 = MD5.Create();
            md5.ComputeHash(bytes);
            return Encoding.UTF8.GetString(md5.ComputeHash(bytes));
        }
    }
}