using System.ComponentModel.DataAnnotations;

namespace HierarchicalTenancyTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}