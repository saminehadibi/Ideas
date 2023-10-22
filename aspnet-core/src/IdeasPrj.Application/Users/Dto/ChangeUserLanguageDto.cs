using System.ComponentModel.DataAnnotations;

namespace IdeasPrj.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}