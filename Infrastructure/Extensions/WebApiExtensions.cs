using Gizmo.Web.Api.Messaging;
using Gizmo.Web.Api.Models;
using Gizmo.Web.Api.Models.Abstractions;
using System;
using System.Text.Json;

namespace Gizmo.Web.Api
{
    /// <summary>
    /// Web api json options configuration extensions.
    /// </summary>
    public static class WebApiExtensions
    {
        #region FUNCTIONS

        /// <summary>
        /// Adds supported Json serializers to the web api json options.
        /// </summary>
        /// <param name="options">Json options.</param>
        /// <returns>Json serializer options.</returns>
        /// <exception cref="ArgumentNullException">thrown in case <paramref name="options"/>being equal to null.</exception>
        public static JsonSerializerOptions AddConverters(this JsonSerializerOptions options)
        {
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            options.Converters.Add(new MessagePackUnionMessageJsonConverter<Models.WebApiErrorBase>("ErrorType", "Error"));

            //add event message converter
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIEventMessage>("EventId", "Event"));

            //add command message converter
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPICommandMessage>("CommandType", "Command"));

            //add control message converter
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIControlMessage>("ControlType", "Command"));

            //add order line converter
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IOrderLineCreateModel>("Type", "Parameters"));

            //add usage converter
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<UsageSessionUsage>("Type", "Usage"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<UsageModel>("Type", "Usage"));

            //add inventory converters
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<InventoryModelCreate>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<InventoryEntryModelCreate>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<InventoryModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<InventoryEntryModel>("Type", "Model"));

            //add discount converters
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<DiscountModelCreate>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<DiscountModel>("Type", "Model"));

            //notifications converter
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<NotificationModel>("Type", "Model"));

            //schedules
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<ScheduleModel>("Type", "Model"));

            //recipient models
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<RecipientModel>("Type", "Model"));

            //age restriction model
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<AgeRestrictionModel>("Type", "Model"));

            //task model
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<TaskModel>("Type", "Model"));

            return options;
        }

        #endregion
    }
}
