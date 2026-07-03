using MessagePack;

namespace Gizmo.Web.Api.Models
{
    [MessagePackObject]
    public sealed class PhoneValidationResultModel
    {
        [Key(0)]
        public PhoneValidationResultCode Result { get; init; }

        [Key(1)]
        public bool IsValid { get; init; }

        /// <summary>E.164 form. Null if IsValid is false.</summary>
        [Key(2)]
        public string? E164 { get; init; }

        /// <summary>National format for display. Null if IsValid is false.</summary>
        [Key(3)]
        public string? FormattedNational { get; init; }
    }
}
