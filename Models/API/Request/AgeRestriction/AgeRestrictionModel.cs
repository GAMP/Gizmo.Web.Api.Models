using Gizmo.Web.Api.Models.Abstractions;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Age restriction model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    [MessagePack.Union((int)AgeRestrictionType.Login, typeof(AgeRestrictionLoginModel))]
    [MessagePack.Union((int)AgeRestrictionType.Product, typeof(AgeRestrictionProductModel))]
    public abstract class AgeRestrictionModel : IWebApiModel
    {        
    }
}
