namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// License Info.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class LicenseInfoDTOModel
    {
        /// <summary>
        /// License Id.
        /// </summary>
        [MessagePack.Key(0)]
        public int LicenseId { get; set; }

        /// <summary>
        /// License name.
        /// </summary>
        [MessagePack.Key(1)]
        public string LicenseName { get; set; }

        /// <summary>
        /// Number of active keys.
        /// </summary>
        [MessagePack.Key(2)]
        public int NumberOfActiveKeys { get; set; }

        /// <summary>
        /// Number of disabled keys.
        /// </summary>
        [MessagePack.Key(3)]
        public int NumberOfDisabledKeys { get; set; }

        /// <summary>
        /// Number of executables using this license.
        /// </summary>
        [MessagePack.Key(4)]
        public int NumberOfExecutables { get; set; }
    }
}
