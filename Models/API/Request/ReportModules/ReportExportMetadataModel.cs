using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Report export metadata model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class ReportExportMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Gets report preset id used.
        /// </summary>
        [MessagePack.Key(0)]
        public int? ReportPresetId
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets from date.
        /// </summary>
        [MessagePack.Key(1)]
        public DateTime DateFrom
        { 
            get; set; 
        }

        /// <summary>
        /// Gets to date.
        /// </summary>
        [MessagePack.Key(2)]
        public DateTime DateTo
        {  
            get; 
            set; 
        }

        /// <summary>
        /// Gets filters used.
        /// </summary>
        [MessagePack.Key(3)]
        public IEnumerable<ReportExportFilterMetadataModel> Filters 
        {
            get; 
            set; 
        } = Enumerable.Empty<ReportExportFilterMetadataModel>();
    }
}
