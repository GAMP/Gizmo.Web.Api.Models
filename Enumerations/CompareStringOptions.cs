namespace Gizmo.Web.Api.Models
{
    public enum CompareStringOptions
    {
        None = 0,
        Contains = 1,
        IsEqualTo = 2,
        StartsWith = 4,
        EndsWith = 8,
        IsEmpty = 16,
        IsNotEmpty = 32
    }
}
