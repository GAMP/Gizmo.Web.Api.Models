using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Base communication message class.
    /// </summary>
    [DataContract()]
    public abstract class MessageBase : IMessage
    {
        protected MessageBase()
        { }

        #region PROPERTIES

        /// <summary>
        /// Gets message version.
        /// </summary>
        [DataMember(EmitDefaultValue = true, IsRequired = false, Order = 0)]
        public int Version
        {
            get; set;
        }

        #endregion
    }
}
