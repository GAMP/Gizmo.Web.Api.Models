using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.User.Note
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
