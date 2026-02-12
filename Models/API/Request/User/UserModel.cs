using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base user model used for polymorphism.
    /// </summary>
    [MessagePack.Union((int)UserMemberType.Member, typeof(UserMemberModel))]
    [MessagePack.Union((int)UserMemberType.Guest, typeof(UserGuestModel))]
    public abstract class UserModel : IWebApiModel
    {
        /// <summary>
        /// The username of the user.
        /// </summary>
        [MessagePack.IgnoreMember]
        [Sortable()]
        public abstract string Username { get; set; }

        /// <summary>
        /// The first name of the user.
        /// </summary>
        [MessagePack.IgnoreMember]
        [Sortable()]
        public abstract string? FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [MessagePack.IgnoreMember]
        [Sortable()]
        public abstract string? LastName { get; set; }

        /// <summary>
        /// The birth date of the user.
        /// </summary>
        [MessagePack.IgnoreMember]
        [Sortable()]
        public abstract DateTime? BirthDate { get; set; }
    }

    /// <summary>
    /// User member model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserMemberModel : UserModel, IWebApiModel
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The GUID of the user.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        [Sortable()]
        public override required string Username { get; set; }

        /// <summary>
        /// The email of the user.
        /// </summary>
        [MessagePack.Key(3)]
        public string? Email { get; set; }

        /// <summary>
        /// The Id of the users group id this user belongs to.
        /// </summary>
        [MessagePack.Key(4)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether the user is allowed to have negative balance.
        /// </summary>
        [MessagePack.Key(5)]
        public bool? IsNegativeBalanceAllowed { get; set; }

        /// <summary>
        /// Whether the personal info has been requested from the user.
        /// </summary>
        [MessagePack.Key(6)]
        public bool IsPersonalInfoRequested { get; set; }

        /// <summary>
        /// The date the user will be enabled again.
        /// </summary>
        [MessagePack.Key(7)]
        public DateTime? EnableDate { get; set; }

        /// <summary>
        /// The date the user has been disabled.
        /// </summary>
        [MessagePack.Key(8)]
        public DateTime? DisabledDate { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        [Sortable()]
        public override string? FirstName { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        [Sortable()]
        public override string? LastName { get; set; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        [Sortable()]
        public override DateTime? BirthDate { get; set; }

        /// <summary>
        /// The address of the user.
        /// </summary>
        [MessagePack.Key(12)]
        public string? Address { get; set; }

        /// <summary>
        /// The city of the user.
        /// </summary>
        [MessagePack.Key(13)]
        public string? City { get; set; }

        /// <summary>
        /// The country of the user.
        /// </summary>
        [MessagePack.Key(14)]
        public string? Country { get; set; }

        /// <summary>
        /// The post code of the user.
        /// </summary>
        [MessagePack.Key(15)]
        public string? PostCode { get; set; }

        /// <summary>
        /// The phone number of the user.
        /// </summary>
        [MessagePack.Key(16)]
        public string? Phone { get; set; }

        /// <summary>
        /// The mobile phone number of the user.
        /// </summary>
        [MessagePack.Key(17)]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// The sex of the user.
        /// </summary>
        [MessagePack.Key(18)]
        public Sex Sex { get; set; }

        /// <summary>
        /// Whether the user is deleted.
        /// </summary>
        [MessagePack.Key(19)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Whether the user is disabled.
        /// </summary>
        [MessagePack.Key(20)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// The SmartCard UID of the user.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(21)]
        public string? SmartCardUid { get; set; }

        /// <summary>
        /// The identification number of the user.
        /// </summary>
        [StringLength(255)]
        [MessagePack.Key(22)]
        public string? Identification { get; set; }

        /// <summary>
        /// The registration date of the user.
        /// </summary>
        [MessagePack.Key(23)]
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Whether the user is verified.
        /// </summary>
        [MessagePack.Key(24)]
        public bool IsVerified { get; set; }

        /// <summary>
        /// Whether the user has notes.
        /// </summary>
        [MessagePack.Key(25)]
        public bool HasNotes { get; set; }

        /// <summary>
        /// Whether the user has checked out assets.
        /// </summary>
        [MessagePack.Key(26)]
        public bool HasCheckedOutAssets { get; set; }

        /// <summary>
        /// Billing options.
        /// </summary>
        [MessagePack.Key(27)]
        public BillingOption? BillingOptions
        {
            get; set;
        }
    }

    /// <summary>
    /// User guest model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserGuestModel : UserModel, IWebApiModel 
    {
        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The GUID of the user.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid Guid { get; set; }

        /// <summary>
        /// The username of the user.
        /// </summary>
        [MessagePack.Key(2)]
        [Sortable()]
        public override required string Username { get; set; }

        /// <summary>
        /// The Id of the users group id this user belongs to.
        /// </summary>
        [MessagePack.Key(3)]
        public int UserGroupId { get; set; }

        /// <summary>
        /// Whether the user is allowed to have negative balance.
        /// </summary>
        [MessagePack.Key(4)]
        public bool? IsNegativeBalanceAllowed { get; set; } 

        /// <summary>
        /// Whether the user is deleted.
        /// </summary>
        [MessagePack.Key(5)]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Whether the user has notes.
        /// </summary>
        [MessagePack.Key(6)]
        public bool HasNotes { get; set; }

        /// <summary>
        /// Whether the user has checked out assets.
        /// </summary>
        [MessagePack.Key(7)]
        public bool HasCheckedOutAssets { get; set; }

        /// <summary>
        /// Reserved host id if the user is guest.
        /// </summary>
        [MessagePack.Key(8)]
        public int? ReservedHostId { get; set; }

        /// <summary>
        /// Reserved slot if the user is guest.
        /// </summary>
        [MessagePack.Key(9)]
        public int? ReservedSlot { get; set; }

        /// <summary>
        /// Indicates joined guest.
        /// </summary>
        [MessagePack.Key(10)]
        public bool IsJoined { get; set; }

        /// <summary>
        /// Billing options.
        /// </summary>
        [MessagePack.Key(11)]
        public BillingOption? BillingOptions
        {
            get; set;
        }

        /// <inheritdoc/>
        [System.Text.Json.Serialization.JsonIgnore()]
        [MessagePack.IgnoreMember]
        public override string? FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <inheritdoc/>
        [System.Text.Json.Serialization.JsonIgnore()]
        [MessagePack.IgnoreMember]
        public override string? LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <inheritdoc/>
        [System.Text.Json.Serialization.JsonIgnore()]
        [MessagePack.IgnoreMember]
        public override DateTime? BirthDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
