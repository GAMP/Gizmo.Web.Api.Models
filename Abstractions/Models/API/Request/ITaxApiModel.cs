namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Tax.
    /// </summary>
    public interface ITaxApiModel
    {
        /// <summary>
        /// The name of the tax.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The value of the tax.
        /// </summary>
        decimal Value { get; set; }
    }
}
