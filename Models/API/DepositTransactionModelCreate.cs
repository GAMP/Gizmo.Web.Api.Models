﻿using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Deposit transaction.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class DepositTransactionModelCreate : DepositTransactionModelBase
    {
        #region PROPERTIES
        
        /// <summary>
        /// Whether to override the receipt.
        /// </summary>
        [Key(100)]
        public bool ReceiptOverride { get; set; } 

        #endregion
    }
}