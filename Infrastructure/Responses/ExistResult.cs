namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Find result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ExistResult
    {
        /// <summary>
        /// Gets not foun resuld.
        /// </summary>
        public static readonly ExistResult NotFound = new ExistResult();

        /// <summary>
        /// Existing id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? Id { get; init; }
    }
}
