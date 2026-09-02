namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base perk model used for polymorphism — what a ladder level is worth.
    /// </summary>
    /// <remarks>
    /// One subtype per perk kind; the CLR type is the kind, there is no discriminator enum.
    /// Union keys are append-only: adding a kind is a new attribute with the next key, and is
    /// breaking for clients that predate it — acceptable while the server serves both UIs.
    /// </remarks>
    [MessagePack.Union(0, typeof(LadderStandingDiscountPerkModel))]
    [MessagePack.Union(1, typeof(LadderStandingWaitingLinePerkModel))]
    public abstract class LadderStandingPerkModel : IWebApiModel
    {
    }

    /// <summary>
    /// A discount conferred by the level's discount group — one perk per active discount in
    /// the group (a discount group holds many discounts; there is no single discount).
    /// </summary>
    /// <remarks>
    /// Branch and period scoping of the underlying discount is deliberately not carried —
    /// perks are display chips, not discount configuration.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class LadderStandingDiscountPerkModel : LadderStandingPerkModel
    {
        /// <summary>
        /// The discount's operator-authored display name.
        /// </summary>
        [MessagePack.Key(0)]
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// How <see cref="Value"/> reads: a percentage or a fixed amount.
        /// </summary>
        [MessagePack.Key(1)]
        public DiscountCalculationType CalculationType { get; init; }

        /// <summary>
        /// The discount magnitude, in percent or currency per <see cref="CalculationType"/>.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Value { get; init; }

        /// <summary>
        /// Whether the amount is taken off the price or granted as a bonus.
        /// </summary>
        [MessagePack.Key(3)]
        public DiscountRewardType RewardType { get; init; }
    }

    /// <summary>
    /// Waiting-line priority conferred by the level's user group.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class LadderStandingWaitingLinePerkModel : LadderStandingPerkModel
    {
        /// <summary>
        /// The waiting-line priority value.
        /// </summary>
        [MessagePack.Key(0)]
        public int Priority { get; init; }
    }
}
