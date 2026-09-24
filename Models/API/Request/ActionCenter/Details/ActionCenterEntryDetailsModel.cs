using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base action center details model used for polymorphism — everything about the subject of an
    /// entry, and which kind of entry it is.
    /// </summary>
    /// <remarks>
    /// The union key is the kind, written as the enum member rather than a bare number so the two
    /// cannot drift apart. That makes one subtype per kind, including for kinds that carry nothing
    /// extra and for kinds that repeat another kind's fields, which is the price of making it
    /// impossible to send an entry whose stated kind disagrees with its payload.
    /// <para>
    /// Keys are append-only, and adding a kind means adding its enum member and its subtype
    /// together. Where kinds genuinely share facts they share an abstract middle type, and a field
    /// sits on that middle type only when it is meaningful for every kind beneath it.
    /// </para>
    /// <para>
    /// The subtypes deliberately do not repeat their kind as a member. The union attributes below
    /// are the mapping, the serializer reads them to hand back the right type, and a consumer that
    /// needs the kind matches on the type it was given. A member would only restate what the type
    /// already is.
    /// </para>
    /// </remarks>
    [MessagePack.Union((int)ActionCenterEntryKind.SessionEnded, typeof(ActionCenterSessionEndedDetailsModel))]
    [MessagePack.Union((int)ActionCenterEntryKind.OrderReceived, typeof(ActionCenterOrderDetailsModel))]
    [MessagePack.Union((int)ActionCenterEntryKind.AssistanceRequested, typeof(ActionCenterAssistanceRequestedDetailsModel))]
    [MessagePack.Union((int)ActionCenterEntryKind.HostSecurityDisabled, typeof(ActionCenterHostSecurityDisabledDetailsModel))]
    [MessagePack.Union((int)ActionCenterEntryKind.HostDisconnected, typeof(ActionCenterHostDisconnectedDetailsModel))]
    [MessagePack.Union((int)ActionCenterEntryKind.UserLoggedIn, typeof(ActionCenterUserLoggedInDetailsModel))]
    public abstract class ActionCenterEntryDetailsModel : IWebApiModel
    {
    }
}
