namespace Gizmo.Web.Api.Models.Abstractions
{
    /// <summary>
    /// Register.
    /// </summary>
    public interface IRegisterModel : IWebApiModel
    {
        /// <summary>
        /// The number of the register.
        /// </summary>
        int Number { get; }

        /// <summary>
        /// The name of the register.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The idle timeout of the register.
        /// </summary>
        int? IdleTimeout { get; }

        /// <summary>
        /// The start cash of the register.
        /// </summary>
        decimal StartCash { get;  }

        /// <summary>
        /// Payment terminal number.
        /// </summary>
        int? PaymentTerminalNumber { get; }

        /// <summary>
        /// Fiscal receipt printer number.
        /// </summary>
        int? FiscalReceiptPrinterNumber { get; }

        /// <summary>
        /// Stock id.
        /// </summary>
        int? StockId { get; }

        /// <summary>
        /// Companion id.
        /// </summary>
        int? CompanionId { get; }

        /// <summary>
        /// Branch id.
        /// </summary>
        int BranchId { get; }

        /// <summary>
        /// Qr display number.
        /// </summary>
        int? QrDisplayNumber { get; }

        /// <summary>
        /// Indicates default register for the branch. Only one register can be default for a branch.
        /// </summary>
        bool IsDefault {  get; }

        /// <summary>
        /// Indicates global default register for the system. Only one register can be default for the system.
        /// </summary>
        bool IsGlobalDefault { get; }
    }
}
