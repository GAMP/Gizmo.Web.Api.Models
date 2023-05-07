using Gizmo.Web.Api.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Binds <see cref="PaginationCursor"/> class from a base64 encoded json string.
    /// </summary>
    public sealed class CursorModelBinder : IModelBinder
    {
        private static readonly Type SupportedType = typeof(ModelFilterPagination);

        /// <inheritdoc/>
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            //see if cursor provided as query parameter
            //the parameter should be provided when we want to use cursor, if not provided the cursor model will be set 
            //to its default value which is null on the target object
            if (!bindingContext.HttpContext.Request.Query.TryGetValue("Pagination.Cursor", out var cursor) || !cursor.Any())
                return Task.CompletedTask;

            //check if the type of the model is supported, currently we will only need to use this binder with ModelFilterPagination
            Type? containerType = bindingContext.ModelMetadata.ContainerType;
            if (containerType == null || containerType != SupportedType)
                return Task.CompletedTask;

            try
            {
                var span = Convert.FromBase64String(cursor);
                var reader = new Utf8JsonReader(span);
                var model = CursorBase64Converter.Read(ref reader);
                bindingContext.Result = ModelBindingResult.Success(model);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Invalid paging cursor supplied.");
            }
            catch
            {
                //possibly log

                //we have failed to bind, TODO figure out how this affects the request pipeline
                bindingContext.Result = ModelBindingResult.Failed();
            }

            return Task.CompletedTask;
        }
    }
}
