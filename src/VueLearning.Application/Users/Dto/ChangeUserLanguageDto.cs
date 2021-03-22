using System.ComponentModel.DataAnnotations;

namespace VueLearning.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}