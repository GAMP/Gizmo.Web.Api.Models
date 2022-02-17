using MessagePack;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Represents web api error.
    /// </summary>
    [MessagePackObject()]
    [Union(0,typeof(WebApiValidationError))]
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
        /// <param name="message">Error message.</param>
        public WebApiError(string message)
        {
            Message = message;
        }
        #endregion

        #region PROPERTIES
        
        /// <summary>
        /// Error message.
        /// </summary>
        [Key(0)]
        public string Message
        {
            get; set;
        } 

        #endregion
    }
}
