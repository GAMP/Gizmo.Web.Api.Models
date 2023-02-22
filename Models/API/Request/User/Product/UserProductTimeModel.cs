using System;
using System.Collections.Generic;
using System.Text;
using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User product time model.
    /// </summary>
    [Serializable, MessagePackObject]
    public sealed class UserProductTimeModel
    {
        /// <summary>
        /// The number of minutes of the time product.
        /// </summary>
        [Key(0)]
        public int Minutes { get; set; }
    }
}
