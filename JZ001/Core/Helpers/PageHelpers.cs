using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Geekors.GWP7.Core.Helpers
{
    using Attributes;
    using ViewModels;

    /// <summary>
    /// Helper of page
    /// </summary>
    public static class PageHelpers
    {
        /// <summary>
        /// Get your view model by the given uri
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static BaseViewModel FindCurrentView(Uri uri)
        {
            var type = TryToFindPageWithReflection(uri);
            if (type != null)
            {
                return Activator.CreateInstance(type) as BaseViewModel;
            }
            else
            {
                return null;
            }
        }


        private static Type TryToFindPageWithReflection(Uri uri)
        {
            var page = FindSubClassesOf<BaseViewModel>().FirstOrDefault(c => c.GetCustomAttributes(true).OfType<PageDefinitionAttribute>().Any(p => p.RelativeUri == uri));
            return page;
        }


        public static IEnumerable<Type> FindSubClassesOf<TBaseType>()
        {
            var baseType = typeof(TBaseType);
            return Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(baseType));
        }
    }
}
