using System.ComponentModel.DataAnnotations;

namespace Gizmo.Web.Api.Models;

/// <summary>
/// Requests a non-fiscal receipt print on the caller's effective register.
/// </summary>
public sealed class NonFiscalReceiptPrintRequestModel
{
    [Required]
    [EnumDataType(typeof(NonFiscalReceiptKind))]
    public NonFiscalReceiptKind? Kind { get; set; }

    [Range(1, int.MaxValue)]
    public int EntityId { get; set; }

    [Required]
    [StringLength(32, MinimumLength = 2)]
    public string? Culture { get; set; }

    [Range(1, 10)]
    public int Copies { get; set; }
}
