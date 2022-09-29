using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User recovery method get result.
    /// </summary>
    /// <remarks>
    /// Default <see cref="ResultCodeBase{T}.Result"/> code value is <see cref="UserRecoverMethodGetResultCode.Success"/>.
    /// </remarks>
    [MessagePackObject()]
    public sealed class UserRecoveryMethodGetResult : ResultCodeBase<UserRecoverMethodGetResultCode>
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets available recovery method.
        /// </summary>
        /// <remarks>
        /// Default value <see cref="UserRecoveryMethod.None"/>.
        /// </remarks>
        [Key(1)]
        public UserRecoveryMethod RecoveryMethod
        {
            get; init;
        } = UserRecoveryMethod.None; 

        #endregion
    }
}
