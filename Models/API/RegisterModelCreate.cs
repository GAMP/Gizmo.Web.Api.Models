using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Register.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class RegisterModelCreate : RegisterModelBase, IUrlQueryParameters
    {
    }
}
