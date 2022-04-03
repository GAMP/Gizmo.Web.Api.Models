using System.Linq;
using System;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Dynimcally creates Json converter.
    /// </summary>
    public static class DynamicConverterLoader
    {
        /// <summary>
        /// Tries to create Msjpack json converter.
        /// </summary>
        /// <param name="assemblyName">Assembly name.</param>
        /// <param name="objectType">MsgPack object or interface type.</param>
        /// <param name="converter">Created converter.</param>
        /// <returns>True for success otherwise false.</returns>
        public static bool TryCreate(string assemblyName,string objectType,out JsonConverter converter)
        {
            converter = null;
            try
            {
                var desiredAssmbly = Assembly.Load(assemblyName);
                var type = desiredAssmbly.GetTypes()
                    .Where(type => string.Compare(type.Name, objectType, System.StringComparison.OrdinalIgnoreCase) == 0)
                    .FirstOrDefault();

                var converterType = typeof(MessagePackUnionMessageJsonConverter<>);
                var constructedType = converterType.MakeGenericType(type);
                converter = Activator.CreateInstance(constructedType) as JsonConverter;
                return true;
            }
            catch
            {
                //treat all exceptions as failures
            }
            return false;
        }
    }
}
