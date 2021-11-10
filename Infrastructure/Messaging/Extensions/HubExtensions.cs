using System;
using System.Linq;
using System.Text.Json.Serialization;

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
        /// <exception cref="ArgumentNullException"></exception>
        public static Microsoft.AspNetCore.SignalR.JsonHubProtocolOptions AddConverters(this Microsoft.AspNetCore.SignalR.JsonHubProtocolOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            //get target interfacce
            var targetInterfaceType = typeof(IEventMessage);

            //get target assembly containing event message interface
            var targetAssembly = typeof(IEventMessage).Assembly;

            //get converter type
            var converterType = typeof(EventMessageJsonConverter<>);

            //process all the types
            foreach (Type type in targetAssembly
                .GetTypes()
                .Where(mytype => mytype.GetInterfaces().Contains(targetInterfaceType))
                .Where(myType => myType.IsInterface))
            {
                //create generic type
                var converterGenericType = converterType.MakeGenericType(type);

                //create convert instance
                var converter = Activator.CreateInstance(converterGenericType) as JsonConverter;

                //add to supported serializers
                options.PayloadSerializerOptions.Converters.Add(converter);
            }

            return options;
        }
    }
}
