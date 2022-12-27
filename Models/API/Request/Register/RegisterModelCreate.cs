using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Register
{
    /// <summary>
    /// Register.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class RegisterModelCreate : RegisterModelBase, IUrlQueryParameters
    {
    }
}
