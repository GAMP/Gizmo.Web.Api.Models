using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Command message.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public abstract class APICommandMessage : CommandMessage
    {
        #region CONSTRUCTOR
        
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public APICommandMessage() : base(ISerializationType)
        { }

        #endregion

        #region READ ONLY FILEDS
        
        /// <summary>
        /// Serialization type.
        /// </summary>
        public static readonly Type ISerializationType = typeof(APICommandMessage); 

        #endregion
    }
}
