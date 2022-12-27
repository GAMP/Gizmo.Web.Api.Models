using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Product.TimeProduct.DisallowedHostGroup
{
    /// <summary>
    /// Time product disallowed host group.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TimeProductDisallowedHostGroupModelCreate : TimeProductDisallowedHostGroupModelBase, IUrlQueryParameters
    {
    }
}