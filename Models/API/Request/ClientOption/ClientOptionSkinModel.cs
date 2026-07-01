using Gizmo.Client;
using Gizmo.Client.UI.View.Constants;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client option skin.
    /// </summary>
    [MessagePack.MessagePackObject]
    public sealed class ClientOptionSkinModel
    {
        #region ClientInterface

        [MessagePack.Key(0)]
        public string? LoginBackground { get; set; }

        [MessagePack.Key(1)]
        public string? Background { get; set; }

        [MessagePack.Key(2)]
        public string? Logo { get; set; }

        [MessagePack.Key(3)]
        public bool DisableAppDetails { get; set; }

        [MessagePack.Key(4)]
        public bool DisableProductDetails { get; set; }

        [MessagePack.Key(5)]
        public int HomePageMaxItemsPerRow { get; set; }

        [MessagePack.Key(6)]
        public int AppsPageMaxItemsPerRow { get; set; }

        [MessagePack.Key(7)]
        public int ProductsPageMaxItemsPerRow { get; set; }

        [MessagePack.Key(8)]
        public int QuickLaunchMaxItems { get; set; }

        [MessagePack.Key(9)]
        public bool DisableUserLock { get; set; }

        [MessagePack.Key(10)]
        public bool DisableUserPurchaseHistory { get; set; }

        [MessagePack.Key(11)]
        public string? StyleSheet { get; set; }

        #endregion

        #region Feeds

        [MessagePack.Key(12)]
        public bool FeedsDisabled { get; set; }

        [MessagePack.Key(13)]
        public int FeedsRotateEvery { get; set; }

        #endregion

        #region HostQRCode

        [MessagePack.Key(14)]
        public bool HostQRCodeEnabled { get; set; }

        [MessagePack.Key(15)]
        public bool HostQRCodeIsBase64 { get; set; }

        #endregion

        #region LoginRotator

        [MessagePack.Key(16)]
        public bool LoginRotatorEnabled { get; set; }

        [MessagePack.Key(17)]
        public string? LoginRotatorPath { get; set; }

        [MessagePack.Key(18)]
        public int LoginRotatorRotateEvery { get; set; }

        #endregion

        #region PopularItems

        [MessagePack.Key(19)]
        public int MaxPopularProducts { get; set; }

        [MessagePack.Key(20)]
        public int MaxPopularApplications { get; set; }

        #endregion

        #region UserLogin

        [MessagePack.Key(21)]
        public bool UserLoginDisabled { get; set; }

        #endregion

        #region UserOnlineDeposit

        [MessagePack.Key(22)]
        public bool UserOnlineDepositDisabled { get; set; }

        [MessagePack.Key(23)]
        public decimal UserOnlineDepositMaximumAmount { get; set; }

        #endregion

        #region Home

        [MessagePack.Key(24)]
        public bool HomeDisabled { get; set; }

        #endregion

        #region Shop

        [MessagePack.Key(25)]
        public bool ShopDisabled { get; set; }

        #endregion

        #region Apps

        [MessagePack.Key(26)]
        public string? IntegrationId { get; set; }

        [MessagePack.Key(27)]
        public ApplicationSortingOption DefaultSortingOption { get; set; }

        #endregion

        #region AssistanceRequest

        [MessagePack.Key(28)]
        public bool AssistanceRequestDisabled { get; set; }

        #endregion

        [MessagePack.Key(29)]
        public bool HostQRCodeGenerateURL { get; set; }

        [MessagePack.Key(30)]
        public string? HostQRCodeURL { get; set; }

        [MessagePack.Key(31)]
        public string? HostQRCodeTitle { get; set; }

        [MessagePack.Key(32)]
        public string? HostQRCodeDescription { get; set; }

        #region HostNumberOptions

        [MessagePack.Key(33)]
        public bool HostNumberPrefixDisabled { get; set; }

        [MessagePack.Key(34)]
        public string? HostNumberPrefix { get; set; }

        [MessagePack.Key(35)]
        public bool HostNumberShowOnWallpaper { get; set; }

        [MessagePack.Key(36)]
        public bool HostNumberShowOnRotator { get; set; }

        [MessagePack.Key(37)]
        public HostNumberPositioning HostNumberPositioningOnWallpaper { get; set; }

        [MessagePack.Key(38)]
        public HostNumberPositioning HostNumberPositioningOnRotator { get; set; }

        [MessagePack.Key(39)]
        public HostNumberFixedPosition HostNumberFixedPosition { get; set; }

        [MessagePack.Key(40)]
        public int HostNumberTimeoutBetweenPosition { get; set; }

        [MessagePack.Key(41)]
        public double HostNumberAnimationDuration { get; set; }

        #endregion
    }
}
