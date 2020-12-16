using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Monetary unit.
    /// </summary>
    [DataContract]
    [Serializable]
    public class MonetaryUnitModelCreate : MonetaryUnitModelBase, IUrlQueryParameters
    {
    }
}
