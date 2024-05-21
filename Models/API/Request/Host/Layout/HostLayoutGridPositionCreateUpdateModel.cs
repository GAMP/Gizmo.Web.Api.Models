namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Host layout position create/update model.
    /// </summary>
    ///<remarks>
    ///This model is used to set grid based host position within a host layout group.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class HostLayoutGridPositionCreateUpdateModel : IWebApiModel
    {
        /// <summary>
        /// Host layout row.
        /// </summary>
        [MessagePack.Key(0)]
        public int Row
        {
            get; init;
        }

        /// <summary>
        /// Host layout column.
        /// </summary>
        [MessagePack.Key(1)]
        public int Column
        {
            get; init;
        }
    }
}
