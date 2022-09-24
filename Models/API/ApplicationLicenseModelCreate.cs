using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application license.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationLicenseModelCreate : ApplicationLicenseModelBase
    {
    }
}
