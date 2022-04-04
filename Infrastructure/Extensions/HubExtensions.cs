using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Singal R Hub extensions.
    /// </summary>
    public static class HubExtensions
    {
        /// <summary>
        /// Adds supported Json serializers to the hub options.
        /// </summary>
        /// <param name="options">Json hub options.</param>
        /// <returns>Json hub options.</returns>
        /// <exception cref="ArgumentNullException">thrown in case <paramref name="options"/>being equal to null.</exception>
        public static Microsoft.AspNetCore.SignalR.JsonHubProtocolOptions AddConverters(this Microsoft.AspNetCore.SignalR.JsonHubProtocolOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            //add event message converter
            options.PayloadSerializerOptions.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIEventMessage>("EventType", "Event"));

            //add command message converter
            options.PayloadSerializerOptions.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPICommandMessage>("CommandType", "Command"));

            //add control message converter
            options.PayloadSerializerOptions.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIControlMessage>("ControlType", "Command"));

            if (DynamicConverterLoader.TryCreate("Gizmo.Companion.Shared", "ICompanionCommandMessage", out var converter))
            {
                options.PayloadSerializerOptions.Converters.Add(converter);
            }

            return options;
        }
    }
}
