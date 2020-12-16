using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Variable.
    /// </summary>
    [DataContract]
    [Serializable]
    public class VariableModelCreate : VariableModelBase, IUrlQueryParameters
    {
    }
}
