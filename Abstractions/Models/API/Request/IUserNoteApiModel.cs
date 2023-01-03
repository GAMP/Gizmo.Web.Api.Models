namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// User note.
    /// </summary>
    public interface IUserNoteApiModel
    {
        /// <summary>
        /// The text of the note.
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// The severity of the note.
        /// </summary>
        NoteSeverity Severity { get; set; }
    }
}