using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class MemberDto
    {
        public MemberDto() { }
        public int Id { get; set; }

        [Required(ErrorMessage = "IdCard is required")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "IdCard should be 9 digits")]
        public string IdCard { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name should only consist of letters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name should only consist of letters")]
        public string LastName { get; set; }


        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "City should only consist of letters")]
        public string City { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Street should only consist of letters")]
        public string Street { get; set; }

        [Range(1, 999, ErrorMessage = "Street number should be between 1 and 999")]
        public int? StreetNumber { get; set; }

        [RegularExpression(@"^\d{0,10}$", ErrorMessage = "Phone should consist of numbers only with a maximum length of 10")]
        public string Phone { get; set; }

        [RegularExpression(@"^\d{0,10}$", ErrorMessage = "Cell phone should consist of numbers only with a maximum length of 10")]
        public string CellPhone { get; set; }

        [Required(ErrorMessage = "Positive result date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Positive Result Date")]
        public DateTime PositiveResultDate { get; set; }

        [Required(ErrorMessage = "Recovery date is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Recovery Date")]
        public DateTime RecoveryDate { get; set; }

        public string Picture { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (RecoveryDate.Date < PositiveResultDate.Date.AddDays(5))
            {
                yield return new ValidationResult("Recovery date should be at least 5 days after positive result date", new[] { "RecoveryDate" });
            }
        }
    }
}
