using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User address model.
    /// </summary>
    [MessagePackObject]
    public sealed class UserAddressModel
    {
        #region PROPERTIES

        /// <summary>
        /// The country of the user.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Country { get; set; }

        /// <summary>
        /// The address of the user.
        /// </summary>
        [MessagePack.Key(1)]
        public string? Address { get; set; }

        /// <summary>
        /// The post code of the user.
        /// </summary>
        [MessagePack.Key(2)]
        public string? PostCode { get; set; }

        /// <summary>
        /// The city of the user.
        /// </summary>
        [MessagePack.Key(3)]
        public string? City { get; set; }

        #endregion
    }
}
