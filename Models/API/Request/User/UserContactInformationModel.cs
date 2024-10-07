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
        /// The first name of the user.
        /// </summary>
        [MessagePack.Key(0)]
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [MessagePack.Key(1)]
        public string? LastName { get; set; }

        /// <summary>
        /// The username of the user.
        /// </summary>
        [MessagePack.Key(2)]
        public string? Username { get; set; }

        /// <summary>
        /// The email of the user.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Email { get; set; }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        [MessagePack.Key(4)]
        public string? Phone { get; set; }

        #endregion
    }
}
