using Gizmo.Web.Api.Models.Abstractions;

using Microsoft.AspNetCore.WebUtilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// URI parameters converter
    /// </summary>
    public readonly struct UriParameters : IUriParameters
    {
        /// <summary>
        /// Query parameters from ModelFilter as string
        /// </summary>
        public string? Query { get; }
        /// <summary>
        /// Path parameters from WebClient API as string
        /// </summary>
        public string? Path { get; }

        /// <summary>
        /// An instance sets the Query property as NULL and the Path property as NULL.
        /// </summary>
        public UriParameters()
        {
            Path = null;
            Query = null;
        }

        /// <summary>
        /// An instance sets the Path property as /{id} and the Query property as NULL.
        /// </summary>
        /// <param name="id">Identifier entity</param>
        public UriParameters(int id)
        {
            Path = $"/{id}";
            Query = null;
        }

        /// <summary>
        /// An instance sets the Path property as /{pathParameters[0]}/{pathParameters[1]}/...} and the Query property as NULL.
        /// </summary>
        /// <param name="pathParameters">An array which will be serialized to the string for URI.Path</param>
        public UriParameters(object[] pathParameters)
        {
            Path = GetPath(pathParameters);
            Query = null;
        }

        /// <summary>
        /// An instance sets the Query property as ?{prop.name}={prop.value} and the Path property as NULL.
        /// </summary>
        /// <param name="queryParameters">An object which will be serialized to the string for URI.Query.</param>
        public UriParameters(IUriParametersQuery queryParameters)
        {
            Query = GetQuery(queryParameters);
            Path = null;
        }

        /// <summary>
        /// An instance sets the Query property as ?{prop.name}={prop.value}and the Path property as /{pathParameters[0]}/{pathParameters[1]}/...}
        /// </summary>
        /// <param name="pathParameters">An array which will be serialized to the string for URI.Path</param>
        /// <param name="queryParameters">An object which will be serialized to the string for URI.Query.</param>
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
                            queryCollection.Add(paramPrefix + property.Name, Convert.ToBase64String(array, 0, array.Length));
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
                            index++;
                        }
                    }
                    else if (propertyValue is IUriParametersQuery subObject)
                    {
                        var subObjectQuery = GetQuery(subObject, paramPrefix + property.Name);
                        if (!string.IsNullOrEmpty(subObjectQuery))
                        {
                            subObjectQuery = subObjectQuery.Substring(1); //Remove question mark.
                            subObjectQueries.Add(subObjectQuery);
                        }
                    }
                    else
                    {
                        queryCollection.Add(paramPrefix + property.Name, propertyValue.ToString());
                    }
                }
            }

            var result = new StringBuilder(QueryHelpers.AddQueryString(string.Empty, queryCollection));

            //Add all subobjects to the query.
            foreach (var subObjectQuery in subObjectQueries)
                if (!string.IsNullOrEmpty(subObjectQuery))
                {
                    result.Append(result.Length == 0 ? '?' : '$');
                    result.Append(subObjectQuery);
                }

            return result.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetPath(object[] pathParameters) => '/' + string.Join("/", pathParameters);
    }
}
