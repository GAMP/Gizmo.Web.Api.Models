using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
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
