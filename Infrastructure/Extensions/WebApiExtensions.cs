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

            options.Converters.Add(new MessagePackUnionMessageJsonConverter<WebApiErrorBase>("ErrorType", "Error"));

            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIEventMessage>("EventId", "Event"));            
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPICommandMessage>("CommandType", "Command"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<IAPIControlMessage>("ControlType", "Command"));
             
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<UsageSessionUsage>("Type", "Usage"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<UsageModel>("Type", "Usage"));   
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<InventoryModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<InventoryEntryModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<NotificationModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<ScheduleModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<RecipientModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<AgeRestrictionModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<TaskModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<MappingModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<CartEntryModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<PaymentModel>("Type", "Model"));
            options.Converters.Add(new MessagePackUnionMessageJsonConverter<PromotionModel>("Type", "Model"));

            return options;
        }

        #endregion
    }
}
