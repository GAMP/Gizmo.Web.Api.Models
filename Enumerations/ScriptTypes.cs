using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Task Script enumeration type.
    /// </summary>
    public enum ScriptTypes
    {
        /// <summary>
        /// Batch.
        /// </summary>
        Batch,

        /// <summary>
        /// VB Script.
        /// </summary>
        VbScript,

        /// <summary>
        /// Auto it script.
        /// </summary>
        [Obsolete("AutoIt scripts are no longer supported.")]
        AutoItScript,

        /// <summary>
        /// Registry script.
        /// </summary>
        RegistryScript,
    }
}
