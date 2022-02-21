using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Money sale preset.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class MoneySalePresetModelCreate : MoneySalePresetModelBase, IUrlQueryParameters
    {
    }
}
