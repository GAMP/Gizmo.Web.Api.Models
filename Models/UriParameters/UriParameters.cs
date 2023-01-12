#nullable enable

using Gizmo.Web.Api.Models.Abstractions;

using Microsoft.AspNetCore.WebUtilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    public sealed class UriParameters : IUriParameters
    {
        /// <inheritdoc/>
        public string? Query { get; }
        /// <inheritdoc/>
        public string? Path { get; }

        /// <inheritdoc/>
        public UriParameters() { }

        /// <inheritdoc/>
        public UriParameters(int id) 
        {
            Path= $"/{id}";
        }
        /// <inheritdoc/>
        public UriParameters(object[] pathParameters) =>
            Path = GetPath(pathParameters);

        /// <inheritdoc/>
        public UriParameters(IUriParametersQuery queryParameters) =>
            Query = GetQuery(queryParameters);

        /// <inheritdoc/>
        public UriParameters(object[] pathParameters, IUriParametersQuery queryParameters)
        {
            Path = GetPath(pathParameters);
            Query = GetQuery(queryParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetQuery(IUriParametersQuery queryParameters, string? prefix = null)
        {
            var properties = queryParameters.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                //.Where(prop => prop.GetCustomAttribute<JsonIgnoreAttribute>() == null)
                .ToList();


            //create query parameters collection
            var queryCollection = new Dictionary<string, string>();

            var paramPrefix = string.IsNullOrEmpty(prefix) ? "" : $"{prefix}.";

            var subObjectQueries = new List<string>();

            //add properties
            foreach (var property in properties)
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
                            if (s is IUriParametersQuery subObject)
                            {
                                var subObjectQuery = GetQuery(subObject, $"{paramPrefix}{property.Name}[{index}]");
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
                    else if (propertyValue is IUriParametersQuery subObject)
                    {
                        var subObjectQuery = GetQuery(subObject, $"{paramPrefix}{property.Name}");
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
        private static string GetPath(object[] pathParameters)
        {
            return string.Join("/", pathParameters.Select(x => x.ToString()));
        }
    }
}
