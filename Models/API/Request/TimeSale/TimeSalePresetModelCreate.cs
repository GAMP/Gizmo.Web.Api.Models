﻿using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.TimeSale
{
    /// <summary>
    /// Time sale preset.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class TimeSalePresetModelCreate : TimeSalePresetModelBase, IUrlQueryParameters
    {
    }
}