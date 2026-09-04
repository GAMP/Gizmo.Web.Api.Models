using System;
using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// One earned challenge reward with its fulfillment state — the row behind the user's own
    /// rewards list and the operator claim queue alike.
    /// </summary>
    /// <remarks>
    /// Deliberately id-only: the reward payload identifies a product by id and the row
    /// identifies its user and challenge by id, resolved through the consuming UI's lookups.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementRewardModel : IWebApiModel, IModelIntIdentifier
    {
        /// <summary>
        /// Reward id — the subject of the claim, decline and re-offer calls.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; init; }

        /// <summary>
        /// The user that earned the reward.
        /// </summary>
        [MessagePack.Key(1)]
        public int UserId { get; init; }

        /// <summary>
        /// The challenge that awarded it.
        /// </summary>
        [MessagePack.Key(2)]
        public int ChallengeId { get; init; }

        /// <summary>
        /// The challenge completion that awarded it.
        /// </summary>
        [MessagePack.Key(3)]
        public int CompletionId { get; init; }

        /// <summary>
        /// UTC time the reward was earned — the completion's crossing moment.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime IssuedTime { get; init; }

        /// <summary>
        /// Lifecycle status — what the reward is waiting on, or how it was delivered.
        /// </summary>
        [MessagePack.Key(5)]
        public AchievementChallengeRewardStatus Status { get; init; }

        /// <summary>
        /// UTC time the reward reached its terminal status (delivered, claimed or declined);
        /// null while it is still pending or awaiting claim.
        /// </summary>
        [MessagePack.Key(6)]
        public DateTime? ProcessedTime { get; init; }

        /// <summary>
        /// The operator that processed the reward, when one acted for the user; null for
        /// system acts, for anything the user did themselves, and while unprocessed. Audit
        /// only — the status says what happened.
        /// </summary>
        [MessagePack.Key(7)]
        public int? ProcessedById { get; init; }

        /// <summary>
        /// What was won — the concrete type is the reward kind.
        /// </summary>
        [MessagePack.Key(8)]
        public UserAchievementRewardDetailsModel Reward { get; init; } = default!;
    }

    /// <summary>
    /// Base reward details model used for polymorphism — what a reward is worth.
    /// </summary>
    /// <remarks>
    /// One subtype per reward kind; the CLR type is the kind, there is no discriminator enum.
    /// Union keys are append-only: adding a kind is a new attribute with the next key, and is
    /// breaking for clients that predate it.
    /// </remarks>
    [MessagePack.Union(0, typeof(UserAchievementPointsRewardDetailsModel))]
    [MessagePack.Union(1, typeof(UserAchievementProductRewardDetailsModel))]
    [MessagePack.Union(2, typeof(UserAchievementTimeRewardDetailsModel))]
    public abstract class UserAchievementRewardDetailsModel : IWebApiModel
    {
    }

    /// <summary>
    /// A points reward — credited automatically unless it was configured to be claimed.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementPointsRewardDetailsModel : UserAchievementRewardDetailsModel
    {
        /// <summary>
        /// Points amount.
        /// </summary>
        [MessagePack.Key(0)]
        public int Amount { get; init; }
    }

    /// <summary>
    /// A product reward — always handed over by an operator.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementProductRewardDetailsModel : UserAchievementRewardDetailsModel
    {
        /// <summary>
        /// Rewarded product id.
        /// </summary>
        [MessagePack.Key(0)]
        public int ProductId { get; init; }

        /// <summary>
        /// Rewarded quantity — one, since a reward row is a single unit.
        /// </summary>
        [MessagePack.Key(1)]
        public int Quantity { get; init; }
    }

    /// <summary>
    /// A time reward.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserAchievementTimeRewardDetailsModel : UserAchievementRewardDetailsModel
    {
        /// <summary>
        /// Credited time amount in seconds.
        /// </summary>
        [MessagePack.Key(0)]
        public int Seconds { get; init; }
    }
}
