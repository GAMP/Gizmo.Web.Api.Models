using MessagePack;

namespace Gizmo.Web.Api.Models
{
    [MessagePackObject]
    public sealed class PhoneCountryModel
    {
        [Key(0)]
        public string RegionCode { get; init; } = string.Empty;

        [Key(1)]
        public string CountryName { get; init; } = string.Empty;

        [Key(2)]
        public string CallingCode { get; init; } = string.Empty;

        [Key(3)]
        public string? ExampleNational { get; init; }

        [Key(4)]
        public string? Placeholder { get; init; }

        [Key(5)]
        public string? InputMask { get; init; }

        [Key(6)]
        public int MaxLength { get; init; }

        /// <summary>Unicode emoji flag, e.g. "🇷🇺". Null if RegionCode is not a valid ISO 3166-1 alpha-2 code.</summary>
        [Key(7)]
        public string? Flag { get; init; }
    }
}
