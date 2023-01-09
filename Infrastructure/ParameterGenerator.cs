using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Web api client parameters generator.
    /// </summary>
    public static class ParameterGenerator
    {
        #region PUBLIC STATIC 
        
        /// <summary>
        /// Generates url query parameters.
        /// </summary>
        /// <param name="queryParameters">Query parameters.</param>
        /// <param name="prefix">Prefix.</param>
        /// <returns>Generated query parameters.</returns>
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

        /// <summary>
        /// Generates route parameters.
        /// </summary>
        /// <param name="routeParameters">Route parameters.</param>
        /// <returns>Generated route parameters.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Generate(IUrlRouteParameters routeParameters)
        {
            if (routeParameters == null)
                return null;

            return null;
        }

        #endregion

        #region PRIVATE STATIC
        
        private static IEnumerable<PropertyInfo> GetProperties(object target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            return target.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                //TODO: How needs excluding the route parameters here
                //.Where(prop => prop.GetCustomAttribute<JsonIgnoreAttribute>() == null)
                .Select(prop => prop)
                .ToList();
        } 

        #endregion
    }
}
