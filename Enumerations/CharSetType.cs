namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Character set type.
    /// </summary>
    public enum CharSetType
    {
        /// <summary>
        /// Digits.
        /// </summary>
        Digits = 0,

        /// <summary>
        /// Upper case letters.
        /// </summary>
        UppercaseLetters = 1,

        /// <summary>
        /// Lower case letters.
        /// </summary>
        LowercaseLetters = 2,

        /// <summary>
        /// Digits and upper case letters.
        /// </summary>
        DigitsAndUppercaseLetters = 3,

        /// <summary>
        /// Digits and lower case letters.
        /// </summary>
        DigitsAndLowercaseLetters = 4,

        /// <summary>
        /// Upper case and lower case.
        /// </summary>
        UppercaseAndLowercaseLetters = 5,

        /// <summary>
        /// All.
        /// </summary>
        All = 6,
    }
}
