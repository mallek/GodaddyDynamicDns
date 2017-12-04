﻿using System.Reflection;
using GodaddyDnsWrapper.Attributes;
using Newtonsoft.Json;

namespace GodaddyDnsWrapper.Helper
{
    internal class QueryStringBuilder
    {
        public static string RequestObjectToQueryString(object RequestObject)
        {
            var url = "?";
            foreach (var property in RequestObject.GetType().GetRuntimeProperties())
            {

                if (property.GetValue(RequestObject) != null)
                {
                    if (IsSimple(property.PropertyType.GetTypeInfo()))
                    {
                        var queryStringToUpperAttribute = property.GetCustomAttribute(typeof(QueryStringToUpperAttribute)) as QueryStringToUpperAttribute;
                        if (queryStringToUpperAttribute == null)
                            url += $"{property.Name}={property.GetValue(RequestObject).ToString().ToLower()}&";
                        else
                            url += $"{property.Name}={property.GetValue(RequestObject).ToString().ToUpper()}&";
                    }
                    else
                        url += $"{property.Name}={JsonConvert.SerializeObject(property.GetValue(RequestObject), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })}&";
                }
            }
            return url;
        }

        static bool IsSimple(TypeInfo type)
        {
            return type.IsPrimitive
              || type.IsEnum
              || type.Equals(typeof(string))
              || type.Equals(typeof(decimal));
        }
    }
}
