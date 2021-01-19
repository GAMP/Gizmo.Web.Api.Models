using MessagePack;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Base communication message class.
    /// </summary>
    [DataContract()]
    [Union(0, typeof(DetailedMessage))]
    [Union(1, typeof(CommandMessage))]
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
        /// Gets message versiion.
        /// </summary>
        [DefaultValue(1)]
        [DataMember(EmitDefaultValue = true, IsRequired = false, Order = 0)]
        [IgnoreDataMember()]
        public int Version
        {
            get; set;
        }

        #endregion
    }
}
