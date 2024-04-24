﻿namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Order created event message.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Created", "ORDER_CREATED_EVENT_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Indicates creation of an order", "ORDER_CREATED_EVENT_DESCRIPTION")]
    [MessagePack.MessagePackObject()]
    public sealed class OrderCreatedEventMessage : OrderEventMessageBase
    {
        /// <summary>
        /// Gets order status.
        /// </summary>
        [MessagePack.Key(2)]
        public OrderStatus Status { get; init; }
    }
}