using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class OperatorModelCreate : OperatorModelBase, IUrlQueryParameters
    {
        #region PROPERTIES

        /// <summary>
        /// The initial password for the operator, if left empty no password will be set.
        /// </summary>
        [StringLength(24)]
        [MessagePack.Key(100)]
        public string Password { get; set; } 

        #endregion
    }
}
