using System;
using System.Linq;

namespace Geekors.GWP7.Core.Extensions
{
    using Attributes;

    public static class ViewModelExtensions
    {
        /// <summary>
        /// 取得類別自行定義的屬性
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns></returns>
        public static PageDefinitionAttribute PageDefinition(this Type modelType)
        {
            var attribute = modelType.GetCustomAttributes(true).OfType<PageDefinitionAttribute>().FirstOrDefault();

            if (attribute != null) return attribute;

            throw new InvalidOperationException(String.Format("PageDefinition is missing on {0}", modelType.Name));
        }


    }
}
