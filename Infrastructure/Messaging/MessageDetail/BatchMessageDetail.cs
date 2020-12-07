using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Batch message detail
    /// </summary>
    [DataContract()]
    public class BatchMessageDetail : IMessageDetail
    {
        #region PROPERTIES

        /// <summary>
        /// Gets batched message details.
        /// </summary>
        [DataMember(Order = 0)]
        public IEnumerable<IMessageDetail> Messages { get; set; }

        #endregion
    }
}
