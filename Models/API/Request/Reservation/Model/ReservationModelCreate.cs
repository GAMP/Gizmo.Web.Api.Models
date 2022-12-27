using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Reservation.Model
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
