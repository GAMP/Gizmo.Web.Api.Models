namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// An object containing a name and a decimal value.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class NamedDecimalContainerDTOModel
    {
        /// <summary>
        /// Name of the object.
        /// </summary>
        [MessagePack.Key(0)]
        public string? Name { get; set; }

        /// <summary>
        /// Value of the object.
        /// </summary>
        [MessagePack.Key(1)]
        public decimal Value { get; set; }
    }
}
