using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Create result.
    /// </summary>
    [Serializable, MessagePackObject]
    public class CreateResult
    {
        /// <summary>
        /// Default result.
        /// </summary>
        public static readonly CreateResult Default = new();

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public CreateResult()
        {
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="id">Entity id.</param>
        public CreateResult(int id)
        {
            Id = id;
        }

        #region PROPERTIES

        /// <summary>
        /// The Id of the newly created object.
        /// </summary>
        [Key(0)]
        public int Id { get; init; } 

        #endregion
    }
}
