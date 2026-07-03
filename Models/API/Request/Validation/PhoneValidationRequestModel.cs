using MessagePack;

namespace Gizmo.Web.Api.Models
{
    [MessagePackObject]
    public sealed class PhoneValidationRequestModel
    {
        [Key(0)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Key(1)]
        public string RegionCode { get; set; } = string.Empty;
    }
}
