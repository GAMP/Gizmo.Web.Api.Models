using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models
{
    /// <summary>
    /// <inheritdoc cref="IOperatorPasswordUpdateModel"/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OperatorPasswordUpdateModel : IOperatorPasswordUpdateModel
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(0)]
        [Required()]
        public string Password
        {
            get;init;
        } = string.Empty;
    }
}
