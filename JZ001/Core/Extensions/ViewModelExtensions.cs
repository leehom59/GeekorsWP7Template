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
using System.Reflection;
using System.Linq;

namespace Geekors.GWP7.Core.Extensions
{
    using Attributes;

    public static class ViewModelExtensions
    {
        public static PageDefinitionAttribute PageDefinition(this Type modelType)
        {
            var attribute = modelType.GetCustomAttributes(true).OfType<PageDefinitionAttribute>().FirstOrDefault();

            if (attribute != null) return attribute;

            throw new InvalidOperationException(String.Format("PageDefinition is missing on {0}", modelType.Name));
        }


    }
}
