using MessagePack;

using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.MoneySalePreset
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
