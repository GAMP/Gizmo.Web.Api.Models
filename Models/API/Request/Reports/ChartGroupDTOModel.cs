using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Chart Group.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ChartGroupDTOModel
    {
        /// <summary>
        /// Chart group name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Name { get; set; }

        /// <summary>
        /// List of records for the group.
        /// </summary>
        [MessagePack.Key(1)]
        public List<ChartRecordDTOModel> GroupRecords { get; set; } = new List<ChartRecordDTOModel>();
    }
}
