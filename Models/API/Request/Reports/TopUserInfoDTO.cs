namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Top User Info.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class TopUserInfoDTO
    {
        /// <summary>
        /// User Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// User name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; set; }

        /// <summary>
        /// The score the user achieved.
        /// </summary>
        [MessagePack.Key(2)]
        public decimal Score { get; set; }

        /// <summary>
        /// The score the user achieved as text.
        /// </summary>
        [MessagePack.Key(3)]
        public string ScoreText { get; set; }
    }
}
