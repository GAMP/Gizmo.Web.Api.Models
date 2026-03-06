using Gizmo.Web.Api.Models.Abstractions;
using System.IO;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Simple path query parameter.
    /// </summary>
    public sealed class PathQueryModel : IUriParametersQuery
    {
        public required string Path { get; init; }
    }

    /// <summary>
    /// Delete entry query parameters.
    /// </summary>
    public sealed class FileSystemDeleteQueryModel : IUriParametersQuery
    {
        public required string Path { get; init; }
        public bool Recursive { get; init; }
    }

    /// <summary>
    /// Set attributes query parameters.
    /// </summary>
    public sealed class FileSystemSetAttributesQueryModel : IUriParametersQuery
    {
        public required string Path { get; init; }
        public FileAttributes Attributes { get; init; }
    }

    /// <summary>
    /// Set length query parameters.
    /// </summary>
    public sealed class FileSystemSetLengthQueryModel : IUriParametersQuery
    {
        public required string Path { get; init; }
        public long Length { get; init; }
    }
}
