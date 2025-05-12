using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Restriction type.
    /// </summary>
    public enum RestrictionType
    {
        /// <summary>
        /// Unset.
        /// </summary>
        [Name("Unset", "RESTRICTION_TYPE_UNSET")]
        Unset = 0,

        /// <summary>
        /// File name.
        /// </summary>
        [Name("File Name", "RESTRICTION_TYPE_FILE_NAME")]
        FileName = 1,

        /// <summary>
        /// Window class name.
        /// </summary>
        [Name("Class Name", "RESTRICTION_TYPE_CLASS_NAME")]
        ClassName = 2,

        /// <summary>
        /// Window name.
        /// </summary>
        [Name("Window Name", "RESTRICTION_TYPE_WINDOW_NAME")]
        WindowName = 3,

        /// <summary>
        /// Tray icon.
        /// </summary>
        [Name("Tray Icon", "RESTRICTION_TYPE_TRAY_ICON")]
        TrayIcon = 4
    }
}
