namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Instance binding result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class InstanceBindingResultModel : IWebApiModel
    {
        /// <summary>
        /// Result code.
        /// </summary>
        [MessagePack.Key(0)]
        public InstanceBindingResultCodes Result { get; init; }
    }
}
