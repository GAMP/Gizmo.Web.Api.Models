namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Find result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ExistResult
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ExistResult()
        { }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="id">Found entry id.</param>
        public ExistResult(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="id">Found entry id.</param>
        public ExistResult(int? id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets not found result.
        /// </summary>
        public static readonly ExistResult NotFound = new();


        /// <summary>
        /// Existing id.
        /// </summary>
        [MessagePack.Key(0)]
        public int? Id { get; init; }
    }
}
