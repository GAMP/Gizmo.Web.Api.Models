using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Variable.Model
{
    /// <summary>
    /// Variable.
    /// </summary>
    [MessagePackObject]
    public class VariableModelBase
    {
        #region PROPERTIES

        /// <summary>
        /// The name of the variable.
        /// </summary>
        [Required]
        [StringLength(255)]
        [MessagePack.Key(0)]
        public string Name { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [Required]
        [MessagePack.Key(1)]
        public string Value { get; set; }

        /// <summary>
        /// Whether the variable is available in server.
        /// </summary>
        [MessagePack.Key(2)]
        public bool AvailableInServer { get; set; }

        /// <summary>
        /// Whether the variable is available in client.
        /// </summary>
        [MessagePack.Key(3)]
        public bool AvailableInClient { get; set; }

        /// <summary>
        /// Whether the variable is available in manager.
        /// </summary>
        [MessagePack.Key(4)]
        public bool AvailableInManager { get; set; }

        #endregion
    }
}