namespace Gizmo.Web.Api.Models.Abstractions.Models.RequestParameters
{
    /// <inheritdoc/>
    public interface IRequestParameters
    {
        string Query { get; }
        string Path { get; }
    }
}
