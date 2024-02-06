namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Filter metadata model.
    /// </summary>
    /// <remarks>
    /// This model describes the filter that was used to generate a report.<br></br>
    /// The primary use of this model is to provide information of filter used to the report rendering engine.
    /// </remarks>
    [MessagePack.MessagePackObject()]
    public sealed class ReportModuleFilterMetadataModel : IWebApiModel
    {
        /// <summary>
        /// Name of the filter property used.
        /// </summary>
        [MessagePack.Key(0)]
        public string FilterName
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Filter property value used.
        /// </summary>
        [MessagePack.Key(1)]
        public string? FilterValue
        {
            get; init;
        }

        /// <summary>
        /// Filter property value display value used.
        /// </summary>
        [MessagePack.Key(2)]
        public string? FilterDisplayValue
        {
            get; init;
        }
    }
}
