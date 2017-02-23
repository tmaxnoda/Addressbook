using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Addressbook.Web.Models
{
    public class LoginModel
    {
        [EmailAddress,Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public bool RemeberMe { get; set; }
    }
}