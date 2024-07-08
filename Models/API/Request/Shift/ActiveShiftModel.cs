using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// <inheritdoc cref="IActiveShiftModel"/>
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ActiveShiftModel : IWebApiModel, IModelIntIdentifier, IActiveShiftModel
    {
        /// <summary>
        /// <inheritdoc cref="IActiveShiftModel.Id"/>
        /// </summary>
        [MessagePack.Key(0)]
        public int Id
        {
            get; init;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(1)]
        public int RegisterId
        {
            get; init;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [MessagePack.Key(2)]
        public int BranchId
        {
            get; init;
        }
    }
}
