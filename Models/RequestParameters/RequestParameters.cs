#nullable enable

using Gizmo.Web.Api.Models.Abstractions.Models.RequestParameters;

using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Gizmo.Web.Api.Models
{
    /// <inheritdoc/>
    public sealed class RequestParameters : IRequestParameters
    {
        /// <inheritdoc/>
        public string? Query { get; }
        /// <inheritdoc/>
        public string? Path { get; }

        /// <inheritdoc/>
        public RequestParameters() { }

        /// <inheritdoc/>
        public RequestParameters(IRequestParametersPath pathParameters) =>
            Path = GetPath(pathParameters);

        /// <inheritdoc/>
        public RequestParameters(IRequestParametersQuery queryParameters) =>
            Query = GetQuery(queryParameters);

        /// <inheritdoc/>
        public RequestParameters(IRequestParametersPath pathParameters, IRequestParametersQuery queryParameters)
        {
            Path = GetPath(pathParameters);
            Query = GetQuery(queryParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetQuery(IRequestParametersQuery queryParameters)
        {
            var properties = queryParameters.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                //.Where(prop => prop.GetCustomAttribute<JsonIgnoreAttribute>() == null)
                .ToList();

            return string.Empty;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static string GetPath(IRequestParametersPath pathParameters)
        {
            return string.Empty;
        }
    }
}
