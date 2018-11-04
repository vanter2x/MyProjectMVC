using MyMvcProject.Models;
using MyMvcProject.ViewModels;

namespace MyMvcProject.DataMapper
{
    public static class PostMapper
    {
        public static PostDTO MapVMtoDTO(this PostVM model)
        {
            PostDTO resultDto = new PostDTO
            {
                Id = model.Id,
                Title = model.Title,
                PostText = model.PostText,
                PostDate = model.PostDate,
                PostEditDate = model.PostEditDate
            };
            return resultDto;
        }

        public static PostVM MapDTOtoVM(this PostDTO model)
        {
            return new PostVM(model);
        }
    }
}