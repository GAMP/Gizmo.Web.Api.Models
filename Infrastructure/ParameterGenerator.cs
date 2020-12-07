using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    public static class ParameterGenerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Generate(IUrlQueryParameters queryParameters)
        {
            if (queryParameters == null)
                return null;

            //get all properties that should be used for parameters
            var targetProperties = GetProperties(queryParameters);

            //create query parameters collection
            var queryCollection = new Dictionary<string, string>();


            //add properties
            foreach (var property in targetProperties)
            {
                //get property value
                var propertyValue = property.GetValue(queryParameters);

                //check if null values should be added
                if(propertyValue!=null)
                {
                    //excludes byte of the ICollection if below
                    if(propertyValue is Byte[] array)
                    {
                        //specific use of byte array(image case)
                        if(property.Name == "Image")
                            queryCollection.Add(property.Name, Convert.ToBase64String(array, 0, array.Length));
                    }
                    else if(propertyValue is System.Collections.ICollection enumerable)
                    {
                        foreach(var s in enumerable)
                        {
                            queryCollection.Add(property.Name, s.ToString());
                        }
                    }
                    else
                    {
                        queryCollection.Add(property.Name, propertyValue.ToString());
                    }                   
                }                   
            }

             return QueryHelpers.AddQueryString(string.Empty, queryCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Generate(IUrlRouteParameters routeParameters)
        {
            if (routeParameters == null)
                return null;

            return null;
        }

        private static IEnumerable<PropertyInfo> GetProperties(object target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            return target.GetType()
                .GetProperties()
                .Where(prop => prop.GetCustomAttribute<DataMemberAttribute>() != null)
                .Select(prop => prop)
                .ToList();
        }
    }
}
