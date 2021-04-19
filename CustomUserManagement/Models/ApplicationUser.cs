using Microsoft.AspNetCore.Identity;
using System;

namespace CustomUserManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        public byte[] ProfilePicture { get; set; }
        public string ProfilePictureBase64 => ProfilePicture == null ? ""
            : $"data:image/*;base64,{Convert.ToBase64String(ProfilePicture)}";
    }
}
