﻿using Gizmo.Web.Api.Models.Abstractions.Models.API.Request;
using MessagePack;
using System;

namespace Gizmo.Web.Api.Models.Models.API.Request.Transaction.Register
{
    /// <summary>
    /// Register transaction.
    /// </summary>
    [Serializable]
    [MessagePackObject]
    public class RegisterTransaction : RegisterTransactionModelBase, IApiModelIdentifier
    {
        #region PROPERTIES

        /// <summary>
        /// The Id of the object.
        /// </summary>
        [Key(100)]
        public int Id { get; set; }

        /// <summary>
        /// The date that the register transaction was created.
        /// </summary>
        [Key(101)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The Id of the operator this register transaction is associated with.
        /// </summary>
        [Key(102)]
        public int? OperatorId { get; set; }

        /// <summary>
        /// The Id of the shift this register transaction is associated with.
        /// </summary>
        [Key(103)]
        public int? ShiftId { get; set; }

        /// <summary>
        /// The Id of the register this register transaction is associated with.
        /// </summary>
        [Key(104)]
        public int? RegisterId { get; set; }

        #endregion
    }
}