using System;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// User's Information.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class UserDTOModel
    {
        /// <summary>
        /// User's username.
        /// </summary>
        [MessagePack.Key(0)]
        public string? UserName { get; set; }

        /// <summary>
        /// User's first name.
        /// </summary>
        [MessagePack.Key(1)]
        public string? FirstName { get; set; }

        /// <summary>
        /// User's last name.
        /// </summary>
        [MessagePack.Key(2)]
        public string? LastName { get; set; }

        /// <summary>
        /// User's birth date.
        /// </summary>
        [MessagePack.Key(3)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Registration date of the user.
        /// </summary>
        [MessagePack.Key(4)]
        public DateTime Registered { get; set; }

        /// <summary>
        /// The Id of the group to which the user belongs.
        /// </summary>
        [MessagePack.Key(5)]
        public int GroupId { get; set; }

        /// <summary>
        /// The name of the group to which the user belongs.
        /// </summary>
        [MessagePack.Key(6)]
        public string? GroupName { get; set; }

        /// <summary>
        /// User's country.
        /// </summary>
        [MessagePack.Key(7)]
        public string? Country { get; set; }

        /// <summary>
        /// User's city.
        /// </summary>
        [MessagePack.Key(8)]
        public string? City { get; set; }

        /// <summary>
        /// User's address.
        /// </summary>
        [MessagePack.Key(9)]
        public string? Address { get; set; }

        /// <summary>
        /// User's e-mail.
        /// </summary>
        [MessagePack.Key(10)]
        public string? Email { get; set; }

        /// <summary>
        /// User's phone number.
        /// </summary>
        [MessagePack.Key(11)]
        public string? Phone { get; set; }

        /// <summary>
        /// User's mobile phone number.
        /// </summary>
        [MessagePack.Key(12)]
        public string? MobilePhone { get; set; }

        /// <summary>
        /// User's postal code.
        /// </summary>
        [MessagePack.Key(13)]
        public string? PostCode { get; set; }

        /// <summary>
        /// User Id.
        /// </summary>
        [MessagePack.Key(14)]
        public int Id { get; set; }

        /// <summary>
        /// User's gender.
        /// </summary>
        [MessagePack.Key(15)]
        public Sex Sex { get; set; }

        /// <summary>
        /// User is banned.
        /// </summary>
        [MessagePack.Key(16)]
        public bool IsBanned { get; set; }
    }
}
