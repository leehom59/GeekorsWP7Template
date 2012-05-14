using System.Text;
using System.Security.Cryptography;

namespace Geekors.GWP7.Core.Extensions
{
   
    using Security;
 
    public static class StringExtension
    {
        /// <summary>
        /// Convert to MD5 hash string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToMD5Hash(this string value)
        {
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(value);
            MD5Managed md5 = new MD5Managed();
            byte[] hash = md5.ComputeHash(bs);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in bs)
            {
                sb.Append(b.ToString("x2").ToLower());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Convert to SHA1 enctyp string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToSHA1(this string value)
        {
            byte[] StrRes = Encoding.UTF8.GetBytes(value);

            SHA1Managed d = new SHA1Managed();
            StrRes = d.ComputeHash(StrRes);

            StringBuilder EnText = new StringBuilder();
            foreach (byte iByte in StrRes)
            {
                EnText.AppendFormat("{0:x2}", iByte);
            }
            return EnText.ToString();
        }
    }
}
