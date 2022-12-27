using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Tax
{
    /// <summary>
    /// Tax.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TaxModelCreate : TaxModelBase, IUrlQueryParameters
    {
    }
}
