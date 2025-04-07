namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Active usage unknown model.
    /// </summary>
    /// <remarks>
    /// This model serves as a proxy for an cases where there are orphaned records in the database and helps to avoid query errors.<br></br>
    /// The orphaned records should not be common but can be found in some databases.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class UsageUnknownModel : UsageModel
    {
    }
}
