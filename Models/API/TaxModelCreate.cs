using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
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
