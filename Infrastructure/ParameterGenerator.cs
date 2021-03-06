﻿using Microsoft.AspNetCore.WebUtilities;
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
        public static string Generate(IUrlQueryParameters queryParameters, string prefix = null)
        {
            if (queryParameters == null)
                return null;

            //get all properties that should be used for parameters
            var targetProperties = GetProperties(queryParameters);

            //create query parameters collection
            var queryCollection = new Dictionary<string, string>();

            var paramPrefix = string.IsNullOrEmpty(prefix) ? "" : $"{prefix}.";

            var subObjectQueries = new List<string>();

            //add properties
            foreach (var property in targetProperties)
            {
                //get property value
                var propertyValue = property.GetValue(queryParameters);

                //check if null values should be added
                if (propertyValue != null)
                {
                    //excludes byte of the ICollection if below
                    if (propertyValue is Byte[] array)
                    {
                        //specific use of byte array(image case)
                        if (property.Name == "Image")
                            queryCollection.Add($"{paramPrefix}{property.Name}", Convert.ToBase64String(array, 0, array.Length));
                    }
                    else if (propertyValue is System.Collections.ICollection enumerable)
                    {
                        int index = 0;
                        foreach (var s in enumerable)
                        {
                            if (s is IUrlQueryParameters subObject)
                            {
                                var subObjectQuery = Generate(subObject, $"{paramPrefix}{property.Name}[{index}]");
                                if (!string.IsNullOrEmpty(subObjectQuery))
                                {
                                    subObjectQuery = subObjectQuery.Substring(1); //Remove question mark.
                                    subObjectQueries.Add(subObjectQuery);
                                }
                            }
                            else
                            {
                                queryCollection.Add($"{paramPrefix}{property.Name}[{index}]", s.ToString());
                            }
                            index += 1;
                        }
                    }
                    else if (propertyValue is IUrlQueryParameters subObject)
                    {
                        var subObjectQuery = Generate(subObject, $"{paramPrefix}{property.Name}");
                        if (!string.IsNullOrEmpty(subObjectQuery))
                        {
                            subObjectQuery = subObjectQuery.Substring(1); //Remove question mark.
                            subObjectQueries.Add(subObjectQuery);
                        }
                    }
                    else
                    {
                        queryCollection.Add($"{paramPrefix}{property.Name}", propertyValue.ToString());
                    }
                }
            }

            var result = QueryHelpers.AddQueryString(string.Empty, queryCollection);

            //Add all subobjects to the query.
            foreach (var subObjectQuery in subObjectQueries)
            {
                //If there is no base query then add question mark.
                if (string.IsNullOrEmpty(result))
                {
                    if (!string.IsNullOrEmpty(subObjectQuery))
                    {
                        result += $"?{subObjectQuery}";
                    }
                }
                else
                {
                    //If there is a base query then add &
                    if (!string.IsNullOrEmpty(subObjectQuery))
                    {
                        result += $"&{subObjectQuery}";
                    }
                }
            }

            return result;
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
