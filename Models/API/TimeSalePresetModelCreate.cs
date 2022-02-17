using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time sale preset.
    /// </summary>
    [DataContract]
    [Serializable]
    public class TimeSalePresetModelCreate : TimeSalePresetModelBase, IUrlQueryParameters
    {
    }
}
