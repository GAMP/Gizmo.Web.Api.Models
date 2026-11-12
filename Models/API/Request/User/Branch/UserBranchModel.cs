using System;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active branch (club) as seen by the user.
    /// </summary>
    [MessagePackObject]
    public sealed class UserBranchModel : IWebApiModel, IModelIntIdentifier
    {
        /// <summary>
        /// Branch id.
        /// </summary>
        [Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// Branch name.
        /// </summary>
        [Key(1)]
        [Sortable]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Country.
        /// </summary>
        [Key(2)]
        public string? Country { get; init; }

        /// <summary>
        /// City.
        /// </summary>
        [Key(3)]
        public string? City { get; init; }

        /// <summary>
        /// Address.
        /// </summary>
        [Key(4)]
        public string? Address { get; init; }

        /// <summary>
        /// Postal code.
        /// </summary>
        [Key(5)]
        public string? PostalCode { get; init; }

        /// <summary>
        /// Region.
        /// </summary>
        [Key(6)]
        public string? Region { get; init; }

        /// <summary>
        /// Phone.
        /// </summary>
        [Key(7)]
        public string? Phone { get; init; }

        /// <summary>
        /// Email.
        /// </summary>
        [Key(8)]
        public string? Email { get; init; }

        /// <summary>
        /// Web site.
        /// </summary>
        [Key(9)]
        public string? WebSite { get; init; }

        /// <summary>
        /// Additional information.
        /// </summary>
        [Key(10)]
        public string? Info { get; init; }

        /// <summary>
        /// IANA time zone id of the branch (the server time zone when the branch has none).
        /// </summary>
        [Key(11)]
        public string TimeZone { get; init; } = string.Empty;

        /// <summary>
        /// Business week start day: the branch value, otherwise the server-wide one.
        /// </summary>
        [Key(12)]
        public DayOfWeek? BusinessStartWeekDay { get; init; }

        /// <summary>
        /// Business week end day: the branch value, otherwise the server-wide one.
        /// </summary>
        [Key(13)]
        public DayOfWeek? BusinessEndWeekDay { get; init; }

        /// <summary>
        /// Business day start (invariant time string): the branch value, otherwise the server-wide one.
        /// </summary>
        [Key(14)]
        public string? BusinessDayStart { get; init; }

        /// <summary>
        /// Business day end (invariant time string): the branch value, otherwise the server-wide one.
        /// </summary>
        [Key(15)]
        public string? BusinessDayEnd { get; init; }
    }
}
