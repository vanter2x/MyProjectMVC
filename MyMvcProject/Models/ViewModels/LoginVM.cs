﻿using System.ComponentModel.DataAnnotations;

namespace MyMvcProject.ViewModels
{
    public class LoginVM
    {
        [Required]
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}