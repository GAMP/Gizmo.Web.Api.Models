﻿using System;
using Gizmo.Web.Api.Models.Abstractions;
using Gizmo.Web.Api.Models.Enumerations;

namespace Gizmo.Web.Api.Models.Models
{
    /// <summary>
    /// Order line creation error result model.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class OrderLineCreateErrorResultModel
    {
        /// <summary>
        /// Line guid.
        /// </summary>
        [MessagePack.Key(0)]
        public Guid? Guid { get; init; }

        /// <summary>
        /// Validation result.
        /// </summary>
        [MessagePack.Key(1)]
        public OrderLineCreateErrorResult Result
        {
            get; init;
        }

        /// <summary>
        /// Readable result.
        /// </summary>
        [MessagePack.IgnoreMember()]
        public string ResultReadable
        {
            get { return Result.ToString(); }
        }

        /// <summary>
        /// Creates new result.
        /// </summary>
        /// <param name="model">Model.</param>
        /// <param name="result">Result.</param>
        /// <returns>New result model.</returns>
        public static OrderLineCreateErrorResultModel Create(IOrderLineCreateModel model, OrderLineCreateErrorResult result)
        {
            return new OrderLineCreateErrorResultModel() { Guid = model.Guid, Result = result };
        }
    }
}