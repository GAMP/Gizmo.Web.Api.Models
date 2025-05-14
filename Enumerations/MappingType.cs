using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Mapping type.
    /// </summary>
    public enum MappingType
    {
        /// <summary>
        /// Virtual drive.
        /// </summary>
        [Name("Virtual Drive", "MAPPING_TYPE_VIRTUAL_DRIVE")]
        VirtualDrive = 0,

        /// <summary>
        /// Virtual folder.
        /// </summary>
        [Name("Virtual Folder", "MAPPING_TYPE_VIRTUAL_FOLDER")]
        VirtualFolder = 1,

        /// <summary>
        /// Network drive.
        /// </summary>
        [Name("Network Drive", "MAPPING_TYPE_NETWORK_DRIVE")]
        NetworkDrive = 2,
    }
}
