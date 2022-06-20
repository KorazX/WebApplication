using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class Contact
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        public string Firstname { get; set; } = "";
        [Display(Name = "Last name")]
        public string Lastname { get; set; } = "";
        // [Index(IsUnique =true)] nie działa :/
        [Display(Name = "e-mail address")]
        public string Email { get; set; } = "";

        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = "";
        [Display(Name = "Category")]
        public Category? Categories { get; set; }
        [Display(Name = "Category")]
        public int CategoriesID { get; set; }
        [Display(Name = "Phone number")]
        public int PhoneNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
