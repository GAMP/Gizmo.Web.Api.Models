namespace Gizmo.Web.Api.Models
{
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutGridPositionModel : IWebApiModel
    {
        /// <summary>
        /// Host Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int HostId
        {
            get; init;
        }

        /// <summary>
        /// Host grid layout row.
        /// </summary>
        [MessagePack.Key(1)]
        public int Row
        {
            get; init;
        }

        /// <summary>
        /// Host grid layout column.
        /// </summary>
        [MessagePack.Key(2)]
        public int Column
        {
            get; init;
        }
    }
}
