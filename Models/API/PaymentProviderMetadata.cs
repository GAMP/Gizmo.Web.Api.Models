#nullable enable
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment provider metdata model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PaymentProviderMetadata
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new payment provider info instance.
        /// </summary>
        /// <param name="type">Type name.</param>
        /// <param name="name">Provider name.</param>
        /// <param name="guid">Provider guid.</param>
        public PaymentProviderMetadata(string type, string name, Guid guid)
        {            
            Type = type;
            Name = name;
            Guid = guid;
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets provider type.
        /// </summary>
        [MessagePack.Key(0)]
        public string Type
        {
            get;
        }

        /// <summary>
        /// Gets provider name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name
        {
            get;
        }

        /// <summary>
        /// Gets provider guid.
        /// </summary>
        [MessagePack.Key(2)]
        public Guid Guid
        {
            get;
        }    

        /// <summary>
        /// Gets provider options type name.
        /// </summary>
        /// <remarks>
        /// This value might be null if payment provider does not have any options associated with it.
        /// </remarks>
        [MessagePack.Key(3)]
        public string? OptionsType
        {
            get; init;
        }    

        /// <summary>
        /// Gets provider description.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Description
        {
            get; init;
        }

        #endregion
    }
}
