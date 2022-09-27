using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Account creation by email result model.
    /// </summary>
    [MessagePackObject()]
    public class AccountCreationByEmailResult : TokenResultWithCodeBase<VerificationStartResultCode>
    {
        #region PROPERTIES

        /// <summary>
        /// Email address used.
        /// </summary>
        [Key(5)]
        public string EmailAddress
        {
            get; set;
        }

        #endregion
    }
}
