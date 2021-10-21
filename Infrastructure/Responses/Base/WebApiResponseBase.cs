using MessagePack;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Base class for web api responses.
    /// </summary>
    [DataContract()]   
    [MessagePackObject()]
    [Union(0,typeof(WebApiResponse<>))]
    [Union(1, typeof(WebApiErrorResponse))]
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
        [Key(0)]
        public int HttpStatusCode
        {
            get; set;
        }

        /// <summary>
        /// Gets response message.
        /// </summary>
        [DefaultValue(null)]
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        [Key(1)]
        public string Message
        {
            get; set;
        }

        /// <summary>
        /// Indicates if object represents an error response.
        /// </summary>
        [DefaultValue(false)]
        [DataMember(EmitDefaultValue =false)]
        [Key(2)]
        public bool IsError
        {
            get;set;
        }
        
        #endregion
    }
}
