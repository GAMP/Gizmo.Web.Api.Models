﻿using System.ComponentModel;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base class for web api responses.
    /// </summary>
    [DataContract()]    
    public class WebApiResponseBase
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public WebApiResponseBase() { }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="statusCode">HTTP Status code.</param>
        /// <param name="isErrorResponse">Indicates if response type is error response.</param>
        public WebApiResponseBase(int statusCode, bool isErrorResponse=false)
        {
            HttpStatusCode = statusCode;
            IsError = isErrorResponse;
        }
        
        #endregion

        #region PROPERTIES

        /// <summary>
        /// HTTP status code.
        /// </summary>
        [DataMember()]
        public int HttpStatusCode
        {
            get; set;
        }

        /// <summary>
        /// Indicates if object represents an error response.
        /// </summary>
        [DefaultValue(false)]
        [DataMember(EmitDefaultValue =false)]
        public bool IsError
        {
            get;set;
        }
        
        #endregion
    }
}
