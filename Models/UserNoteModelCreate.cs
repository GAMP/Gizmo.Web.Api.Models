using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User note.
    /// </summary>
    [Serializable]
    [DataContract]
    public class UserNoteModelCreate : UserNoteModelBase, IUrlQueryParameters
    {
    }
}
