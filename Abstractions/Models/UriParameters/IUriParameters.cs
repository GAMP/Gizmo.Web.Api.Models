namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Base interface for URI parameters.
    /// </summary>
    /// <remarks>
    /// We can use the interface class to identified between different url parameter classes if required.
    /// </remarks>
    public interface IUriParameters
    {
        string Query { get; }
        string Path { get; }
    }
}
