using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(2600, typeof(UserAchievementCompletedEventMessage))]
    [Union(2601, typeof(UserAchievementLevelChangedEventMessage))]
    [Union(2602, typeof(UserAchievementChallengeCompletedEventMessage))]
    [Union(2603, typeof(UserAchievementRewardStatusChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
