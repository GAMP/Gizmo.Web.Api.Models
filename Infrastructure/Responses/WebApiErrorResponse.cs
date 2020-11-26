﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Web api error response model.
    /// </summary>
    [DataContract()]
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
        /// <param name="statusCode">Http status code.</param>
        public WebApiErrorResponse(int statusCode) : base(statusCode,true)
        {
        }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="statusCode">Http status code.</param>
        /// <param name="errors">Extended errors.</param>
        public WebApiErrorResponse(int statusCode,IEnumerable<WebApiError> errors) : base(statusCode,true)
        {
            Errors = errors ?? Enumerable.Empty<WebApiError>();
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Extended error information.
        /// </summary>
        [DataMember(EmitDefaultValue =false)]
        public IEnumerable<WebApiError> Errors
        {
            get; set;
        }

        /// <summary>
        /// Optional error code.
        /// </summary>
        [DataMember(EmitDefaultValue =false)]
        public int? ErrorCode
        {
            get;set;
        }

        /// <summary>
        /// Optional error code in human readable form.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string ErrorCodeReadable
        {
            get;set;
        }

        /// <summary>
        /// Optional error code object type.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string ErrorCodeType
        {
            get;set;
        }

        #endregion

        #region STATIC FUNCTIONS

        /// <summary>
        /// Creates response.
        /// </summary>
        /// <param name="statusCode">Status code.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns>Web api error response.</returns>
        public static WebApiErrorResponse Create(int statusCode, string errorMessage)
        {
            return new WebApiErrorResponse(statusCode, new List<WebApiError>() { new WebApiError(errorMessage) });
        }

        /// <summary>
        /// Creates bad request response.
        /// </summary>
        /// <param name="errorMessage">Error message.</param>
        /// <param name="errorCode">Error code.</param>
        /// <returns>Web api error response.</returns>
        public static WebApiErrorResponse CreateBadRequestResponse(string errorMessage, Enum errorCode)
        {
            var response = Create((int)System.Net.HttpStatusCode.BadRequest, errorMessage);
            response.ErrorCode = Convert.ToInt32(errorCode);
            response.ErrorCodeReadable = errorCode.ToString();
            response.ErrorCodeType = errorCode.GetType().FullName;
            return response;
        }

        #endregion
    }
}
