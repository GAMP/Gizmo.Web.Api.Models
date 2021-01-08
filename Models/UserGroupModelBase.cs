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
    public class UserGroupModelBase
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
        /// The Id of the billing profile this user group is associated with.
        /// </summary>
        [DataMember]
        public int? BillingProfileId { get; set; }

        /// <summary>
        /// The required user info object attached to this user group.
        /// </summary>
        [DataMember]
        public RequiredUserInfo RequiredUserInfo { get; set; }

        /// <summary>
        /// Whether to override the default application group.
        /// </summary>
        [DataMember]
        public bool OverrideApplicationGroup { get; set; }

        /// <summary>
        /// The Id of the application profile this user group is associated with.
        /// </summary>
        [DataMember]
        public int? ApplicationGroupId { get; set; }

        /// <summary>
        /// Whether to override the default security profile.
        /// </summary>
        [DataMember]
        public bool OverrideSecurityProfile { get; set; }

        /// <summary>
        /// The Id of the security profile this user group is associated with.
        /// </summary>
        [DataMember]
        public int? SecurityProfileId { get; set; }

        /// <summary>
        /// Whether to override the default age rating.
        /// </summary>
        [DataMember]
        public bool OverrideAgeRating { get; set; }

        /// <summary>
        /// Whether the age rating is enabled for the user group.
        /// </summary>
        [DataMember]
        public bool IsAgeRatingEnabled { get; set; }

        /// <summary>
        /// Enable personal storage.
        /// </summary>
        [DataMember]
        public bool EnablePersonalStorage { get; set; }

        /// <summary>
        /// Hide logout button.
        /// </summary>
        [DataMember]
        public bool HideLogoutButton { get; set; }

        /// <summary>
        /// Disallow login from client.
        /// </summary>
        [DataMember]
        public bool DisallowLoginFromClient { get; set; }

        /// <summary>
        /// Allow guest use.
        /// </summary>
        [DataMember]
        public bool GuestUse { get; set; }

        /// <summary>
        /// Allow only guest use.
        /// </summary>
        [DataMember]
        public bool GuestUseOnly { get; set; }

        /// <summary>
        /// Disallow login from manager.
        /// </summary>
        [DataMember]
        public bool DisallowLoginFromManager { get; set; }

        /// <summary>
        /// Whether the users of this user group are allowed to have negative balance.
        /// </summary>
        [DataMember]
        public bool IsNegativeBalanceAllowed { get; set; }

        /// <summary>
        /// The credit limit of the user group.
        /// </summary>
        [DataMember]
        public decimal CreditLimit { get; set; }

        /// <summary>
        /// The points award options of the user group.
        /// </summary>
        [DataMember]
        public TimePointAwardOptionType PointsAwardOptions { get; set; }

        /// <summary>
        /// The points money ratio.
        /// </summary>
        [DataMember]
        public decimal PointsMoneyRatio { get; set; }

        /// <summary>
        /// The points time ratio.
        /// </summary>
        [DataMember]
        public int PointsTimeRatio { get; set; }

        /// <summary>
        /// The amount of points to award.
        /// </summary>
        [DataMember]
        public int? PointsAward { get; set; }

        /// <summary>
        /// Whether the user group is default for new users.
        /// </summary>
        [DataMember]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Disable use of time offers.
        /// </summary>
        [DataMember]
        public bool DisableTimeOffer { get; set; }

        /// <summary>
        /// Disable use of fixed time purchase.
        /// </summary>
        [DataMember]
        public bool DisableFixedTime { get; set; }

        /// <summary>
        /// Disable use of deposits for time.
        /// </summary>
        [DataMember]
        public bool DisableDeposit { get; set; }

        /// <summary>
        /// Whether the waiting line priority is enabled for the user group.
        /// </summary>
        [DataMember]
        public bool IsWaitingLinePriorityEnabled { get; set; }

        /// <summary>
        /// The waiting line priority of the user group.
        /// </summary>
        [DataMember]
        public int WaitingLinePriority { get; set; }
    }
}