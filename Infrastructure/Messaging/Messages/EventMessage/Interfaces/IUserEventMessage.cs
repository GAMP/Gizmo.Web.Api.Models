using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// User event message.
    /// </summary>
    [Union(0, typeof(UserBalanceChangeEventMessage))]
    [Union(1, typeof(UserSessionChangedEventMessage))]
    [Union(2, typeof(UserBalanceCloseEventMessage))]
    [Union(3, typeof(UserEnabledChangedEventMessage))]
    [Union(4, typeof(UserEmailChangedEventMessage))]
    [Union(5, typeof(UserEnableNegativeBalanceEventMessage))]
    [Union(6, typeof(UserUsageSessionChangedEventArgs))]
    [Union(7, typeof(UserGroupChangedEventMessage))]
    [Union(8, typeof(UserPictureChangedEventMessage))]
    [Union(9, typeof(UserLoginStateChangedEventMessage))]
    [Union(10, typeof(UserSmartCardChangeEventMessage))]
    [Union(11, typeof(UserRenamedEventMessage))]
    [Union(12, typeof(UserPasswordChangedEventMessage))]
    public interface IUserEventMessage : IEventMessage
    {
    }
}
