namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Promotion code model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class PromotionCodeModel
    {
        /// <summary>
        /// Promotion code id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Promotion id.
        /// </summary>
        [MessagePack.Key(1)]
        public int PromotionId { get; set; }

        /// <summary>
        /// Promotion code value.
        /// </summary>
        [MessagePack.Key(2)]
        public string Value { get; set; } = null!;

        /// <summary>
        /// Promotion code status.
        /// </summary>
        [MessagePack.Key(3)]
        public PromotionCodeStatus Status { get; set; }
    }
}
