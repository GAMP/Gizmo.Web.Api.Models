using System;
using System.Collections.Generic;
using System.Text;

namespace Gizmo.Web.Api.Models.Models.Messages.CommandMessage.Device
{
    public class FiscalPrinterErrorResponseCommand
    {
        public int? NativeErrorCode
        {
            get;set;
        }

        public string ErrorMessage
        {
            get;set;
        }
    }
}
