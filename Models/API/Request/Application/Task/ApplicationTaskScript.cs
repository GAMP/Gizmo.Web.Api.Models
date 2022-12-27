using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Task
{
    /// <summary>
    /// Application task script.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationTaskScript
    {
        #region PROPERTIES

        /// <summary>
        /// The type of the script.
        /// </summary>
        [EnumValueValidation]
        [MessagePack.Key(0)]
        public ScriptTypes ScriptType { get; set; }

        /// <summary>
        /// The data of the script.
        /// </summary>
        [Required]
        [StringLength(65535)]
        [MessagePack.Key(1)]
        public string Data { get; set; }

        /// <summary>
        /// Whether the script is awaited until exit.
        /// </summary>
        [MessagePack.Key(2)]
        public bool Wait { get; set; }

        /// <summary>
        /// Whether the script is invisible.
        /// </summary>
        [MessagePack.Key(3)]
        public bool NoWindow { get; set; }

        #endregion
    }
}