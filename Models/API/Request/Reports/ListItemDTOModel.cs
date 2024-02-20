namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// List Item.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class ListItemDTOModel
    {
        /// <summary>
        /// Item Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int Id { get; set; }

        /// <summary>
        /// Item name.
        /// </summary>
        [MessagePack.Key(1)]
        public string Name { get; set; }
    }
}
