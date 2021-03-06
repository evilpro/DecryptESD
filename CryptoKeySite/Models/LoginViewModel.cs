﻿using System.ComponentModel.DataAnnotations;

namespace CryptoKeySite.Models
{
   public class LoginViewModel
   {
      [Display(Name = "Email Address"), DataType(DataType.EmailAddress), Required(ErrorMessage = "Please enter an email address."), EmailAddress(ErrorMessage = "Please enter a valid email address.")]
      public string Username { get; set; }

      [DataType(DataType.Password), Required(ErrorMessage = "Please enter a password.")]
      public string Password { get; set; }

      [Display(Name = "Remember me")]
      public bool RememberMe { get; set; }
   }
}