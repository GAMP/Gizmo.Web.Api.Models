using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class UserNoteModelCreate : UserNoteModelBase, IUrlQueryParameters
    {
    }
}
