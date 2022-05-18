using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User agreement model.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject()]
    public class UserAgreementModelCreate : UserAgreementModelBase
    {
    }
}
