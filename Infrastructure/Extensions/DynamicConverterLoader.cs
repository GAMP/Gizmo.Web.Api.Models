using System.Linq;
using System;
using System.Reflection;
using System.Text.Json.Serialization;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Dynamically creates Json converter.
    /// </summary>
    public static class DynamicConverterLoader
    {
        /// <summary>
        /// Tries to create MSJPACK json converter.
        /// </summary>
        /// <param name="assemblyName">Assembly name.</param>
        /// <param name="objectType">MsgPack object or interface type.</param>
        /// <param name="converter">Created converter.</param>
        /// <returns>True for success otherwise false.</returns>
        public static bool TryCreate(string assemblyName,string objectType, out JsonConverter? converter)
        {
            converter = null;
            try
            {
                //try to load desired assembly
                var desiredAssembly = Assembly.Load(assemblyName);

                //find desired type inside of that assembly
                var type = desiredAssembly.GetTypes()
                    .Where(type => string.Compare(type.Name, objectType, StringComparison.OrdinalIgnoreCase) == 0)
                    .FirstOrDefault();

                //create generic converter type
                var converterType = typeof(MessagePackUnionMessageJsonConverter<>);

                //make generic with type parameters
                var constructedType = converterType.MakeGenericType(type);

                //create converter
                converter = (JsonConverter)Activator.CreateInstance(constructedType,"CommandType","Command");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
