namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Member Counters.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class MemberCountersDTOModel
    {
        /// <summary>
        /// Number of new members.
        /// </summary>
        [MessagePack.Key(0)]
        public int NewMembers { get; set; }

        /// <summary>
        /// Total number of members.
        /// </summary>
        [MessagePack.Key(1)]
        public int TotalMembers { get; set; }

        /// <summary>
        /// Number of banned members.
        /// </summary>
        [MessagePack.Key(2)]
        public int BannedMembers { get; set; }
    }
}
