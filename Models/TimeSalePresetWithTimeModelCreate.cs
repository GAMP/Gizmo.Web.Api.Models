using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time sale preset with time.
    /// </summary>
    [DataContract]
    [Serializable]
    public class TimeSalePresetWithTimeModelCreate : TimeSalePresetWithTimeModelBase, IUrlQueryParameters
    {
    }
}
