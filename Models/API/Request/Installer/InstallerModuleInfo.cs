namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Installer module info.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class InstallerModuleInfo : IWebApiModel
    {
        /// <summary>
        /// Full path.
        /// </summary>
        [MessagePack.Key(0)]
        public required string FullPath
        {
            get; set;
        }

        /// <summary>
        /// Version.
        /// </summary>
        [MessagePack.Key(1)]
        public System.Version? Version
        {
            get; set;
        } 
    }
}
