using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart creation result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartCreateResultModel : IWebApiModel
    {
        /// <summary>
        /// Created cart id.
        /// </summary>

        [MessagePack.Key(0)]
        public Guid Id { get; init; }
    }
}
