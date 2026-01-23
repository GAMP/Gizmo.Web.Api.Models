using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(300, typeof(UserBalanceChangedEventMessage))]
    [Union(301, typeof(UserBalanceCloseEventMessage))]
    [Union(302, typeof(UserEnabledChangedEventMessage))]
    [Union(303, typeof(UserEmailChangedEventMessage))]
    [Union(304, typeof(UserNegativeBalanceEnabledEventMessage))]
    [Union(305, typeof(UserUsageSessionUsageChangedEventMessage))]
    [Union(306, typeof(UserGroupChangedEventMessage))]
    [Union(307, typeof(UserPictureChangedEventMessage))]
    [Union(308, typeof(UserSmartCardChangeEventMessage))]
    [Union(309, typeof(UserRenamedEventMessage))]
    [Union(310, typeof(UserPasswordChangedEventMessage))]
    [Union(311, typeof(UserBillingOptionsChangedEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
