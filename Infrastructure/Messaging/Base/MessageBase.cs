using System.ComponentModel;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Base communication message class.
    /// </summary>
    [DataContract()]
    public abstract class MessageBase : IMessage
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        protected MessageBase()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets message version.
        /// </summary>
        [DefaultValue(1)]
        [DataMember(EmitDefaultValue = false, IsRequired = false, Order = 0)]
        public int Version
        {
            get; set;
        }

        #endregion
    }
}
