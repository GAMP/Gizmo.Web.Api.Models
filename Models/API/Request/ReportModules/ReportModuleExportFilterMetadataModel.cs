using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filter metadata model.
    /// </summary>
    /// <remarks>
    /// This model describes the filter that was used to generate a report.<br></br>
    /// The primary use of this model is to provide information of filter used to the report rendering engine.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ReportModuleExportFilterMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Name of the filter property used.
        /// </summary>
        [MessagePack.Key(0)]
        public string FilterName
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Filter property values used.
        /// </summary>
        [MessagePack.Key(1)]
        public IEnumerable<string?> FilterValues
        {
            get; init;
        } = Enumerable.Empty<string?>();
    }
}
