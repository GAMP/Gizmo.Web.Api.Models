using System;
using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// License Usage Info.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class LicenseUsageInfoDTOModel
    {
        /// <summary>
        /// License info.
        /// </summary>
        [MessagePack.Key(0)]
        public LicenseInfoDTOModel LicenseInfo { get; set; } = new LicenseInfoDTOModel();

        /// <summary>
        /// Total seconds the license was in use.
        /// </summary>
        [MessagePack.Key(1)]
        public long TotalRunTimeSeconds { get; set; }

        /// <summary>
        /// Total time the license was in use as text.
        /// </summary>
        [MessagePack.Key(2)]
        public string? TotalRunTime { get; set; }

        /// <summary>
        /// Time of license last usage.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime? LastUse { get; set; }

        /// <summary>
        /// List of executables that use the license and ran within the reporting period.
        /// </summary>
        [MessagePack.Key(4)]
        public List<ExecutableInfoDTOModel> Executables { get; set; } = new List<ExecutableInfoDTOModel>();
    }
}
