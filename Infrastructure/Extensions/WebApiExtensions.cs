using System;
using System.Text.Json;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Web api json options configuration extensions.
    /// </summary>
    public static class WebApiExtensions
    {
        /// <summary>
        /// Adds supported Json serializers to the web api json options.
        /// </summary>
        /// <param name="options">Json options.</param>
        /// <returns>Json serializer options.</returns>
        /// <exception cref="ArgumentNullException">thrown in case <paramref name="options"/>being equal to null.</exception>
        public static JsonSerializerOptions AddConverters(this JsonSerializerOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            options.Converters.Add(new MessagePackUnionMessageJsonConverter<Models.WebApiErrorBase>("ErrorType", "Error"));

            return options;
        }
    }
}
