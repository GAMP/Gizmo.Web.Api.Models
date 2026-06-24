using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Public (user-facing) user agreement model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class PublicUserAgreementModel : IWebApiModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The name of the user agreement.
        /// </summary>
        [Key(1)]
        public string? Name { get; set; }

        /// <summary>
        /// The user agreement text.
        /// </summary>
        [Key(2)]
        public string? Agreement { get; set; }

        /// <summary>
        /// The display order of the user agreement.
        /// </summary>
        [Key(3)]
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Whether the user agreement is rejectable.
        /// </summary>
        [Key(4)]
        public bool IsRejectable { get; set; }

        #endregion
    }
}
