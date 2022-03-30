using System;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Correlation message interface.
    /// </summary>
    public interface ICorrelationMessage
    {
        #region PROPERTIES

        /// <summary>
        /// Gets correlation id.
        /// </summary>
        public Guid CorrelationId { get; }

        /// <summary>
        /// Gets server timeout.
        /// </summary>
        int? ServerTimeout { get; }

        #endregion
    }
}
