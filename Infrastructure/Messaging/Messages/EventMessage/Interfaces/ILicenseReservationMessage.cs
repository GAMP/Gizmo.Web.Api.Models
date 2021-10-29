using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// License reservation message interface.
    /// </summary>
    [Union(0, typeof(LicenseReservationMessage))]
    public interface ILicenseReservationMessage
    {
    }
}
