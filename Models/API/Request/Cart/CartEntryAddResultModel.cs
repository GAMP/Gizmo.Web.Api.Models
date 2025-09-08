using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Cart entry addition result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class CartEntryAddResultModel : IWebApiModel
    {
        [MessagePack.Key(0)]
        public Guid Id { get; init; }
    }
}
