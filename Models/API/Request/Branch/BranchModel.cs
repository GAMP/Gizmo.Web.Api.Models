#nullable enable

using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Branch model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class BranchModel : IModelIntIdentifier, IBranchModel
    {
        /// <inheritdoc/>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(1)]
        [StringLength(45)]
        public string Name { get; init; } = string.Empty;

        /// <inheritdoc/>
        [MessagePack.Key(2)]
        public string? Country { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(3)]
        public string? City { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(4)]
        public string? Address { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(5)]
        public string? Phone { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(6)]
        public string? Email { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(7)]
        public string? PostalCode { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(8)]
        public string? Region { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(9)]
        public string? WebSite { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(10)]
        public string? Info { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        [StringLength(45)]
        public string? TimeZone { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(12)]
        public bool HasWorkingSchedule { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(13)]
        public int? BusinessStartWeekDay { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(14)]
        public int? BusinessEndWeekDay { get; init; }

        ///<inheritdoc/>
        [MessagePack.Key(15)]
        public string? BusinessDayStart { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(16)]
        public string? BusinessDayEnd { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(11)]
        public bool IsEnabled { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(12)]
        public bool IsDeleted { get; init; }

        /// <inheritdoc/>
        [MessagePack.Key(13)]
        public Guid Guid { get; init; }     
    }
}
