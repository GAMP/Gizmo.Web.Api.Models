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
        /// Gets or sets bill profile id.
        /// </summary>
        [DataMember]
        public int? BillProfileId { get; set; }

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
        /// Disallow manual login.
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

        ///// <summary>
        ///// Enables or disables personal files.
        ///// </summary>
        //[DataMember]
        //public bool EnablePersonalFiles { get; set; }

        /// <summary>
        /// Disallow login from manager.
        /// </summary>
        [DataMember]
        public bool DisallowLoginFromManager { get; set; }

        ///// <summary>
        ///// Enable per user credit limit.
        ///// </summary>
        //[DataMember]
        //public bool EnablePerUserCreditLimit { get; set; }

        /// <summary>
        /// Whether the users of this user group are allowed to have negative balance.
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