using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Variable.
    /// </summary>
    [MessagePackObject]
    public class VariableModelCreate : VariableModelBase, IUrlQueryParameters
    {
    }
}
