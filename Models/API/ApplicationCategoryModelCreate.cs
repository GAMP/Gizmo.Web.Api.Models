using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application category.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class ApplicationCategoryModelCreate : ApplicationCategoryModelBase
    {
    }
}
