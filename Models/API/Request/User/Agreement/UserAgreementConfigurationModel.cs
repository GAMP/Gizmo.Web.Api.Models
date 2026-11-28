using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Operator HTTP configuration for a user agreement.
    /// </summary>
    [MessagePackObject]
    public sealed class UserAgreementConfigurationModel : IWebApiModel
    {
        [Key(0)]
        public UserAgreementModel Agreement { get; set; } = new();

        [Key(1)]
        public UserAgreementAudience Audience { get; set; }
    }
}
