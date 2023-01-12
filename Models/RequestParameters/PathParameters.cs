using System.Collections.Generic;
using Gizmo.Web.Api.Models.Abstractions.Models.RequestParameters;

namespace Gizmo.Web.Api.Models.Models.Routes
{
    public class PathParameters : IRequestParametersPath
    {
        public Queue<Dictionary<string,string>> Parameters { get; set; }
    }
}
