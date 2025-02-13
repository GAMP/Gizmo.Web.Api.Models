namespace Gizmo.Web.Api.Messaging
{
    /// <summary>
    /// Asset event message base.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Name("Asset", "ASSET_EVENT_GROUP_NAME")]
    [System.ComponentModel.DataAnnotations.ExtendedDescription("Asset related events", "ASSET_EVENT_GROUP_DESCRIPTION")]
    [EventGroup(24)]
    public abstract class AssetEventMessageBase : APIEventMessage
    {
        /// <inheritdoc/>
        public AssetEventMessageBase() : base() { }
    }
}
