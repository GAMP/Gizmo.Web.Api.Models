using Gizmo.Client;

using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Client option skin.
    /// </summary>
    [MessagePackObject]
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

        #region Currency

        [MessagePack.Key(12)]
        public string? CurrencySymbol { get; set; }

        [MessagePack.Key(13)]
        public int? CurrencyDecimalDigits { get; set; }

        [MessagePack.Key(14)]
        public string? CurrencyDecimalSeparator { get; set; }

        [MessagePack.Key(15)]
        public string? CurrencyGroupSeparator { get; set; }

        [MessagePack.Key(16)]
        public int[]? CurrencyGroupSizes { get; set; }

        [MessagePack.Key(17)]
        public int? CurrencyNegativePattern { get; set; }

        [MessagePack.Key(18)]
        public int? CurrencyPositivePattern { get; set; }

        #endregion

        #region Reservations

        [MessagePack.Key(19)]
        public bool ReservationsEnableLoginBlock { get; set; }

        [MessagePack.Key(20)]
        public int ReservationsLoginBlockTime { get; set; }

        [MessagePack.Key(21)]
        public bool ReservationsEnableLoginUnblock { get; set; }

        [MessagePack.Key(22)]
        public int ReservationsLoginUnblockTime { get; set; }

        #endregion

        #region Feeds

        [MessagePack.Key(23)]
        public bool FeedsDisabled { get; set; }

        [MessagePack.Key(24)]
        public int FeedsRotateEvery { get; set; }

        #endregion

        #region HostQRCode

        [MessagePack.Key(25)]
        public bool HostQRCodeEnabled { get; set; }

        [MessagePack.Key(26)]
        public bool HostQRCodeIsBase64 { get; set; }

        #endregion

        #region LoginRotator

        [MessagePack.Key(27)]
        public bool LoginRotatorEnabled { get; set; }

        [MessagePack.Key(28)]
        public string? LoginRotatorPath { get; set; }

        [MessagePack.Key(29)]
        public int LoginRotatorRotateEvery { get; set; }

        #endregion

        #region PopularItems

        [MessagePack.Key(30)]
        public int MaxPopularProducts { get; set; }

        [MessagePack.Key(31)]
        public int MaxPopularApplications { get; set; }

        #endregion

        #region UserLogin

        [MessagePack.Key(32)]
        public bool UserLoginDisabled { get; set; }

        #endregion

        #region UserOnlineDeposit

        [MessagePack.Key(33)]
        public bool UserOnlineDepositDisabled { get; set; }

        [MessagePack.Key(34)]
        public decimal UserOnlineDepositMaximumAmount { get; set; }

        #endregion

        #region Home

        [MessagePack.Key(35)]
        public bool HomeDisabled { get; set; }

        #endregion

        #region Shop

        [MessagePack.Key(36)]
        public bool ShopDisabled { get; set; }

        #endregion

        #region Validation

        #region Password

        [MessagePack.Key(37)]
        public int? ValidationPasswordMinimumLength { get; set; }

        [MessagePack.Key(38)]
        public int? ValidationPasswordMaximumLength { get; set; }

        [MessagePack.Key(39)]
        public bool ValidationPasswordLowerCaseCharactersRequired { get; set; }

        [MessagePack.Key(40)]
        public bool ValidationPasswordUpperCaseCharactersRequired { get; set; }

        [MessagePack.Key(41)]
        public bool ValidationPasswordNumbersRequired { get; set; }

        [MessagePack.Key(42)]
        public string? IntegrationLocationId { get; set; }

        #endregion

        #region Apps

        [MessagePack.Key(43)]
        public ApplicationSortingOption DefaultSortingOption { get; set; }

        #endregion

        #endregion

        #region AssistanceRequest

        [MessagePack.Key(44)]
        public bool AssistanceRequestDisabled { get; set; }

        #endregion
    }
}
