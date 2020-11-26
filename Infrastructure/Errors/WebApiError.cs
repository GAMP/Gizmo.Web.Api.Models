using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Represents web api error.
    /// </summary>
    [DataContract()]
    public class WebApiError
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Serialization constructor.
        /// </summary>
        public WebApiError()
        { }

        /// <summary>
        /// Creates new instance.
        /// </summary>
        /// <param name="message"></param>
        public WebApiError(string message)
        {
            Message = message;
        }
        #endregion

        #region PROPERTIES
        
        /// <summary>
        /// Error message.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string Message
        {
            get; set;
        } 

        #endregion
    }
}
