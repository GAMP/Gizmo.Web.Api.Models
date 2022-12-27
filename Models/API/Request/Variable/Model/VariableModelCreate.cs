using MessagePack;

namespace Gizmo.Web.Api.Models.Models.API.Request.Variable.Model
{
    /// <summary>
    /// Variable.
    /// </summary>
    [MessagePackObject]
    public class VariableModelCreate : VariableModelBase, IUrlQueryParameters
    {
    }
}
