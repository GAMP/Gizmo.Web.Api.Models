﻿#nullable enable

using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;

using MessagePack;

using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models.Models.API.Request.Application.Category
{
    /// <summary>
    /// Application category.
    /// </summary>
    [MessagePackObject]
    public sealed class ApplicationCategoryModelUpdate : IApplicationCategoryApiModel, IApiModelIdentifier
    {
        #region PROPERTIES

       /// <summary>
        /// The Id of the object.
        /// </summary>
        [MessagePack.Key(0)]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The name of the application category.
        /// </summary>
        [MessagePack.Key(1)]
        [Required]
        [StringLength(45)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The Id of the parent category if the category is a subcategory, otherwise it will be null.
        /// </summary>
        [MessagePack.Key(2)]
        public int? ParentId { get; set; }

        #endregion
    }
}