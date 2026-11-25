using System;
using System.ComponentModel.DataAnnotations;
using Gizmo.Web.Api.Models.Abstractions;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Request of the current user to log in on a host whose QR code was scanned.
    /// </summary>
    [MessagePackObject]
    public sealed class UserHostLoginModel : IWebApiModel
    {
        /// <summary>
        /// Host guid from the host QR code.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid HostGuid { get; set; }

        /// <summary>
        /// Branch guid from the host QR code, when the code has it.
        /// </summary>
        [MessagePack.Key(1)]
        public Guid? BranchGuid { get; set; }

        /// <summary>
        /// Reservation pin, for a host held by a reservation the user is not in.
        /// </summary>
        [MessagePack.Key(2)]
        [StringLength(6)]
        public string? Pin { get; set; }
    }
}
