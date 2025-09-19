using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Display order entry.
    /// </summary>
    [MessagePackObject]
    public sealed class DisplayOrderEntryModel
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The display order of the entry.
        /// </summary>
        [MessagePack.Key(1)]
        public int DisplayOrder { get; set; }

        #endregion
    }
}
