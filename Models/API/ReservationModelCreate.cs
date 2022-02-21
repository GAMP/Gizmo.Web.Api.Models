using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Reservation.
    /// </summary>
    [DataContract]
    [Serializable]
    [MessagePackObject]
    public class ReservationModelCreate : ReservationModelBase, IUrlQueryParameters
    {
    }
}
