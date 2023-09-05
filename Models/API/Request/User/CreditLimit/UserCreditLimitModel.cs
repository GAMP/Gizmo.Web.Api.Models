using MessagePack;

using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User credit limit.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserCreditLimitModel
    {
        #region PROPERTIES

        [Key(0)]
        public CreditType SalesCreditType { get; set; }

        [Key(1)]
        public CreditType TimeCreditType { get; set; }

        [Key(2)]
        public decimal CreditLimit { get; set; }

        [Key(3)]
        public bool IsTimeCreditEnabledByDefault { get; set; }

        [Key(4)]
        public bool IsUserTimeCreditEnabled { get; set; }

        #endregion
    }
}
