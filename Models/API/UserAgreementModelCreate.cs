using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User agreement model.
    /// </summary>
    [Serializable]
    [MessagePackObject()]
    public class UserAgreementModelCreate : UserAgreementModelBase
    {
    }
}
