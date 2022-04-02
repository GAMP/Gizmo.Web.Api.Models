using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(1,typeof(FiscalPrinterCommandMessage))]
    [Union(2, typeof(FiscalPrinterCommandResponseMessage))]
    public partial interface ICommandMessage
    {
    }
}
