using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Abstractions.Models.RequestParameters;

namespace Gizmo.Web.Api.Models.Models.Routes
{
    public class ApplicationCategoriesPath : IRequestParametersPath
    {
        public int Id { get; init; }
    }
}
