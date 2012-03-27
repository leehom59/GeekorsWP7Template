using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Geekors.GWP7.Core.Attributes
{
    /// <summary>
    /// Definite the url of each page.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PageDefinitionAttribute : Attribute
    {
        /// <summary>
        /// Get or set relative path.
        /// </summary>
        public string RelativePath { get; set; }

        public PageDefinitionAttribute(string relativePath)
        {
            RelativePath = relativePath;
        }

        /// <summary>
        /// Relative Uri.
        /// </summary>
        public Uri RelativeUri
        {
            get
            {
                return new Uri(RelativePath, UriKind.Relative);
            }
        }
    }
}
