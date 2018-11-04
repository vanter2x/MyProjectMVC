using System;
using System.ComponentModel.DataAnnotations;
using MyMvcProject.Models;

namespace MyMvcProject.ViewModels
{
    public class PostVM
    {
        public PostVM()
        {
        }

        public PostVM(PostDTO postDto)
        {
            Id = postDto.Id;
            Title = postDto.Title;
            PostText = postDto.PostText;
            PostDate = postDto.PostDate;
            PostEditDate = postDto.PostEditDate;
        }

        public int Id { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Niepoprawny tytuł(min. 5/max. 40) znaków.")]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 5, ErrorMessage = "Niepoprawny tytuł(min. 5/max. 40) znaków.")]
        [Display(Name = "Treść posta")]
        public string PostText { get; set; }

        [Display(Name = "Data utworzenia")]
        public DateTime PostDate { get; set; }

        [Display(Name = "Data edycji")]
        public DateTime PostEditDate { get; set; }
    }
}