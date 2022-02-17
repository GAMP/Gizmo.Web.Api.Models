using MessagePack;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Variable.
    /// </summary>
    [DataContract]
    [MessagePackObject]
    public class VariableModelCreate : VariableModelBase, IUrlQueryParameters
    {
    }
}
