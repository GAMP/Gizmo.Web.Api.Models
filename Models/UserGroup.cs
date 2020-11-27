using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class UserGroup : EntityBase
    {
        /// <summary>
        /// The name of the user group.
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the user group.
        /// </summary>
        [DataMember]
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// The Id of the application profile this user group is associated with.
        /// </summary>
        [DataMember]
        public int? ApplicationGroup { get; set; }

        /// <summary>
        /// The Id of the security profile this user group is associated with.
        /// </summary>
        [DataMember]
        public int? SecurityProfile { get; set; }

        /// <summary>
        /// Gets or sets bill profile id.
        /// </summary>
        [DataMember]
        public int? BillProfileId { get; set; }

        /// <summary>
        /// Gets or sets required user info.
        /// </summary>
        [DataMember]
        public UserInfoTypes RequiredUserInfo { get; set; }

        /// <summary>
        /// Gets or sets ovverides.
        /// </summary>
        [DataMember]
        public GroupOverrides Overrides { get; set; }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember]
        public UserGroupOptionType Options { get; set; }

        /// <summary>
        /// Gets or sets credit limit options.
        /// </summary>
        [DataMember]
        public CreditLimitOptionType CreditLimitOptions { get; set; }

        /// <summary>
        /// Gets or sets if user group allows negative balance.
        /// </summary>
        [DataMember]
        public bool IsNegativeBalanceAllowed { get; set; }

        /// <summary>
        /// Gets or sets credit limit.
        /// </summary>
        [DataMember]
        public decimal CreditLimit { get; set; }

        /// <summary>
        /// Gets or sets time point award options.
        /// </summary>
        [DataMember]
        public TimePointAwardOptionType PointsAwardOptions { get; set; }

        /// <summary>
        /// Gets or sets points money ratio. 
        /// </summary>
        [DataMember]
        public decimal PointsMoneyRatio { get; set; }

        /// <summary>
        /// Gets or sets points time multiplier.
        /// </summary>
        [DataMember]
        public int PointsTimeRatio { get; set; }

        /// <summary>
        /// Gets or sets amount of points to award.
        /// </summary>
        [DataMember]
        public int? Points { get; set; }

        /// <summary>
        /// Gets or sets if user group is default for new users.
        /// </summary>
        [DataMember]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or sets if age rating is enabled for the group.
        /// </summary>
        [DataMember]
        public bool IsAgeRatingEnabled { get; set; }

        ///// <summary>
        ///// Gets or sets user billing option.
        ///// </summary>
        //[DataMember]
        //public BillingOption BillingOptions { get; set; }

        /// <summary>
        /// Gets or sets user group priority.
        /// </summary>
        [DataMember]
        public int WaitingLinePriority { get; set; }

        /// <summary>
        /// Gets or sets if waiting line priority enabled.
        /// </summary>
        [DataMember]
        public bool IsWaitingLinePriorityEnabled { get; set; }
    }
}