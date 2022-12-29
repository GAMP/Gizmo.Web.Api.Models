using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Variable.Model
{
    /// <summary>
    /// Variable.
    /// </summary>
    [MessagePackObject]
    public sealed class VariableModelUpdate : IVariableApiModel, IApiModelIdentifier, IUrlQueryParameters
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
        public string Name { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [Required]
        [MessagePack.Key(2)]
        public string Value { get; set; }

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
