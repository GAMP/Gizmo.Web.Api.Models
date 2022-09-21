#nullable enable
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Payment request creation result.
    /// </summary>
    [MessagePack.MessagePackObject()]
    [MessagePack.Union(0,typeof(PaymentIntentCreateResult))]
    [ProtoBuf.ProtoContract()]
    public class PaymentRequestCreateResult
    {
        #region PROPERTIES

        /// <summary>
        /// Gets payment url.
        /// </summary>
        [MessagePack.Key(0)]
        [ProtoBuf.ProtoMember(1)]
        public string PaymentUrl
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Gets QR Image.
        /// </summary>
        [MessagePack.Key(1)]
        [ProtoBuf.ProtoMember(2)]
        public string QrImage
        {
            get; init;
        } = string.Empty;

        /// <summary>
        /// Native QR Image to be used with payment apps.
        /// </summary>
        /// <remarks>
        /// This value is optional.
        /// </remarks>
        [MessagePack.Key(2)]
        [ProtoBuf.ProtoMember(3)]
        public string? NativeQrImage
        {
            get; init;
        }

        /// <summary>
        /// Gets provider used to create the request.
        /// </summary>
        [MessagePack.Key(3)]
        [ProtoBuf.ProtoMember(4)]
        public Guid Provider
        {
            get; init;
        }

        #endregion
    }
}
