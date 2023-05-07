using System;
using Gizmo.Web.Api.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Gizmo.Web.Api
{    
    /// <inheritdoc cref="IModelBinderProvider"/>
    public sealed class ModelBinderProvider : IModelBinderProvider
    {
        private readonly IModelBinder _binder = new CursorModelBinder();
        private static readonly Type SupportedType = typeof(PaginationCursor);

        /// <inheritdoc/>
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if(context.Metadata.ModelType == SupportedType)
                return _binder;         

            return null!;
        }
    }
}
