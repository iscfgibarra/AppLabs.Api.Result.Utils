using System;
using System.ComponentModel;
using System.Reflection;

namespace AppLabs.Api.Result.Utils.Extensions
{
    public static class DescriptionAttrExtension
    {
        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString() ?? string.Empty);

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi?.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            return attributes is {Length: > 0} ? attributes[0].Description : source.ToString();
        }
    }
}