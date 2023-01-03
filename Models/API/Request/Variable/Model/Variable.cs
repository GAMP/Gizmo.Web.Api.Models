#nullable enable

using System.ComponentModel.DataAnnotations;

using Gizmo.Web.Api.Models.Abstractions;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Variable.
    /// </summary>
    [MessagePackObject]
    public sealed class Variable : IVariableApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// The name of the variable.
        /// </summary>
        [Required]
        [StringLength(255)]
        [MessagePack.Key(1)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [Required]
        [MessagePack.Key(2)]
        public string Value { get; set; } = null!;

        /// <summary>
        /// Whether the variable is available in server.
        /// </summary>
        [MessagePack.Key(3)]
        public bool AvailableInServer { get; set; }

        /// <summary>
        /// Whether the variable is available in client.
        /// </summary>
        [MessagePack.Key(4)]
        public bool AvailableInClient { get; set; }

        /// <summary>
        /// Whether the variable is available in manager.
        /// </summary>
        [MessagePack.Key(5)]
        public bool AvailableInManager { get; set; }

        #endregion
    }
}
