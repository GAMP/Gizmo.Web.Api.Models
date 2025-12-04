using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Registry import model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class SystemRegistryImportModel : IWebApiModel
    {
        /// <summary>
        /// Registry entries.
        /// </summary>
        [Required()]
        [MessagePack.Key(0)]
        public string Entries { get; init; } = null!;
    }
}
