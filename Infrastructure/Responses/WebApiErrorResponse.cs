﻿#nullable enable
using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Web api error response model.
    /// </summary>
    [DataContract()]
    [MessagePackObject()]
    public class WebApiErrorResponse : WebApiResponseBase
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        public WebApiErrorResponse()
        {
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="httpStatusCode">Http status code.</param>
        public WebApiErrorResponse(int httpStatusCode) : base(httpStatusCode, true)
        {
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="httpStatusCode">Http status code.</param>
        /// <param name="errorMessage">Error message.</param>
        public WebApiErrorResponse(int httpStatusCode, string errorMessage) : base(httpStatusCode, true)
        {
            Message = errorMessage;
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="httpStatusCode">Http status code.</param>
        /// <param name="errors">Extended errors.</param>
        public WebApiErrorResponse(int httpStatusCode, IEnumerable<WebApiError> errors) : base(httpStatusCode, true)
        {
            Errors = errors ?? Enumerable.Empty<WebApiError>();
        }

        #endregion

        #region CONSTANTS
        private const int HTTP_BAD_REQUEST_ERROR_CODE = 400;
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Optional error code type.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 0)]
        [Key(3)]
        public int? ErrorCodeType
        {
            get; set;
        }

        /// <summary>
        /// Optional error code type in human readable form.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 1)]
        [Key(4)]
        public string? ErrorCodeTypeReadable
        {
            get; set;
        }

        /// <summary>
        /// Optional error code.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 2)]
        [Key(5)]
        public int? ErrorCode
        {
            get; set;
        }

        /// <summary>
        /// Optional error code in human readable form.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 3)]
        [Key(6)]
        public string? ErrorCodeReadable
        {
            get; set;
        }

        /// <summary>
        /// Extended error collection.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 4)]
        [Key(7)]
        public IEnumerable<WebApiError>? Errors
        {
            get; set;
        }

        #endregion

        #region STATIC FUNCTIONS

        /// <summary>
        /// Creates response.
        /// </summary>
        /// <param name="httpStatusCode">Status code.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns>Web api error response.</returns>
        public static WebApiErrorResponse Create(int httpStatusCode,
            string errorMessage)
        {
            return new WebApiErrorResponse(httpStatusCode, errorMessage);
        }

        /// <summary>
        /// Creates bad request response for a specific error code type.
        /// </summary>
        /// <param name="errorMessage">Error message.</param>
        /// <param name="errorCodeType">Error code type.</param>
        /// <returns>Web api error response.</returns>
        public static WebApiErrorResponse CreateBadRequestResponse(string errorMessage, Enum errorCodeType)
        {
            return CreateBadRequestResponse(errorMessage, errorCodeType, null, null);
        }

        /// <summary>
        /// Creates bad request response for a specific error code type.
        /// </summary>
        /// <param name="errorMessage">Error message.</param>
        /// <param name="errorCodeType">Error code type.</param>
        /// <param name="errorCode">Error code.</param>
        /// <returns>Web api error response.</returns>
        public static WebApiErrorResponse CreateBadRequestResponse(string errorMessage, Enum errorCodeType, Enum errorCode)
        {
            return CreateBadRequestResponse(errorMessage, errorCodeType, errorCode, null);
        }

        /// <summary>
        /// Creates bad request response for a specific error code type.
        /// </summary>
        /// <param name="errorCodeType">Error code type.</param>
        /// <returns>Web api error response.</returns>
        public static WebApiErrorResponse CreateBadRequestResponse(Enum errorCodeType)
        {
            return CreateBadRequestResponse(null, errorCodeType, null, null);
        }

        /// <summary>
        /// Creates bad request response for a specific error code type.
        /// </summary>
        /// <param name="errorCodeType">Error code type.</param>
        /// <param name="errors">Extended error collection.</param>
        /// <returns>Web api error response.</returns>
        public static WebApiErrorResponse CreateBadRequestResponse(Enum errorCodeType, IEnumerable<WebApiError> errors)
        {
            return CreateBadRequestResponse(null, errorCodeType, null, errors);
        }

        /// <summary>
        /// Creates bad request response for a specific error code type.
        /// </summary>
        /// <param name="errorCodeType">Error code type.</param>
        /// <param name="errorCode">Error code.</param>
        /// <returns>Web api error response.</returns>
        public static WebApiErrorResponse CreateBadRequestResponse(Enum errorCodeType,
            Enum? errorCode)
        {
            return CreateBadRequestResponse(null, errorCodeType, errorCode, default);
        }

        /// <summary>
        /// Creates bad request response for a specific error code type.
        /// </summary>
        /// <param name="errorMessage">Error message.</param>
        /// <param name="errorCodeType">Error code type.</param>
        /// <param name="errorCode">Error code.</param>
        /// <param name="errors">Extended error collection.</param>
        /// <returns>Web api error response.</returns>
        private static WebApiErrorResponse CreateBadRequestResponse(string? errorMessage,
            Enum? errorCodeType,
            Enum? errorCode,
            IEnumerable<WebApiError>? errors)
        {
            //create and initialize new error response
            var response = new WebApiErrorResponse
            {
                //bad request is default status code
                HttpStatusCode = HTTP_BAD_REQUEST_ERROR_CODE,

                //this is an error, set is error to true
                IsError = true,

                //set our error message
                Message = errorMessage,

                //set error code information
                ErrorCodeType = errorCodeType != null ? Convert.ToInt32(errorCodeType) : null,
                ErrorCodeTypeReadable = errorCodeType?.ToString(),
                ErrorCode = errorCode != null ? Convert.ToInt32(errorCode) : null,
                ErrorCodeReadable = errorCode?.ToString(),

                //add any optional extended errors
                Errors = errors!
            };

            //return response
            return response;
        }

        #endregion
    }
}
