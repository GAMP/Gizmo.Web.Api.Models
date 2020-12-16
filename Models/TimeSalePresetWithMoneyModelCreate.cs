using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Time sale preset with money.
    /// </summary>
    [DataContract]
    [Serializable]
    public class TimeSalePresetWithMoneyModelCreate : TimeSalePresetWithMoneyModelBase, IUrlQueryParameters
    {
    }
}
