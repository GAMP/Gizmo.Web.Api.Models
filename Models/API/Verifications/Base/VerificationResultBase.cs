﻿using MessagePack;
using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base class for verfication results.
    /// </summary>
    /// <typeparam name="T">Result type.</typeparam>
    [MessagePackObject()]
    [Union(0, typeof(EmailVerificationStartResult))]
    [Union(1, typeof(MobilePhoneVerificationStartResult))]
    [Union(2, typeof(AccountCreationByMobilePhoneResult))]
    [Union(3, typeof(AccountCreationByEmailResult))]
    [Union(4, typeof(AccountCreationByTokenCompleteResult))]
    public abstract class VerificationResultBase<T> where T : Enum
    {
        #region PROPERTIES

        /// <summary>
        /// Verification result code.
        /// </summary>
        [Key(0)]
        public T Result
        {
            get; set;
        }

        /// <summary>
        /// Confirmation code.
        /// </summary>
        [Key(1)]
        public string ConfirmationCode
        {
            get; set;
        }

        /// <summary>
        /// Token value.
        /// </summary>
        [Key(2)]
        public string Token
        {
            get; set;
        }

        /// <summary>
        /// Token id.
        /// </summary>
        [Key(3)]
        public int? TokenId
        {
            get; set;
        }   

        #endregion
    }
}
