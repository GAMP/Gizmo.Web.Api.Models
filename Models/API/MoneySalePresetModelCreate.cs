using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Money sale preset.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class MoneySalePresetModelCreate : MoneySalePresetModelBase, IUrlQueryParameters
    {
    }
}
