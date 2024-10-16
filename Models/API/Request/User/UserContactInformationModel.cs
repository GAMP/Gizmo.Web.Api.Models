using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User contact information.
    /// </summary>
    [MessagePackObject]
    public sealed class UserContactInformationModel
    {
        #region PROPERTIES

        /// <summary>
        /// The email of the user.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Email { get; set; }

        /// <summary>
        /// The mobile phone number of the user.
        /// </summary>
        [MessagePack.Key(1)]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Phone { get; set; }

        #endregion
    }
}
