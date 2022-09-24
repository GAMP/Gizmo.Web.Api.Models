using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ReservationModelCreate : ReservationModelBase, IUrlQueryParameters
    {
    }
}
