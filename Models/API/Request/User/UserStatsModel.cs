namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User stats.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public sealed class UserStatsModel : IWebApiModel
    {
        /// <summary>
        /// Points earned.
        /// </summary>
        [MessagePack.Key(0)]
        public int PointsEarned { get; set; }

        /// <summary>
        /// Points used.
        /// </summary>
        [MessagePack.Key(1)]
        public int Redeemed { get; set; }

        /// <summary>
        /// Number of logins.
        /// </summary>
        [MessagePack.Key(2)]
        public int Logins { get; set; }

        /// <summary>
        /// Total session time as text.
        /// </summary>
        [MessagePack.Key(3)]
        public string? LoginTime { get; set; }

        /// <summary>
        /// Total amount of deposits.
        /// </summary>
        [MessagePack.Key(4)]
        public decimal Deposits { get; set; }

        /// <summary>
        /// Total amount of withdrawals.
        /// </summary>
        [MessagePack.Key(5)]
        public decimal Withdrawals { get; set; }

        /// <summary>
        /// Total amount of money spent for products.
        /// </summary>
        [MessagePack.Key(6)]
        public decimal Products { get; set; }

        /// <summary>
        /// Total amount of money spent on fixed time.
        /// </summary>
        [MessagePack.Key(7)]
        public decimal FixedTime { get; set; }

        /// <summary>
        /// Total amount of money spent on session time.
        /// </summary>
        [MessagePack.Key(8)]
        public decimal Sessions { get; set; }

        /// <summary>
        /// Total amount of money spent on time products.
        /// </summary>
        [MessagePack.Key(9)]
        public decimal TimeProducts { get; set; }

        /// <summary>
        /// Total amount of money spent.
        /// </summary>
        [MessagePack.Key(10)]
        public decimal MoneySpend { get; set; }

        /// <summary>
        /// Number of assets checked out.
        /// </summary>
        [MessagePack.Key(11)]
        public int CheckOutItems { get; set; }
    }
}
