using System.Windows;

namespace Geekors.GWP7.Core.Extensions
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Convert Dictionary class to query string for navigation ability.
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static string ToQueryString(this ResourceDictionary dict)
        {
            if (dict.Count == 0) return string.Empty;

            string strQuery = "?";

            foreach (var key in dict.Keys)
            {
                string value = dict[key].ToString();

                strQuery += string.Format("{0}={1}&", key, value);
            }

            return strQuery;
        }
    }
}
