using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class UserNoteModelCreate : UserNoteModelBase, IUrlQueryParameters
    {
    }
}
