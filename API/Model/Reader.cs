using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Reader : BaseData
    {
        [MaxLength(150, ErrorMessage = "Imie może zawierać maksymalnie 150 znaków ")]
        [Required(ErrorMessage = "Pole Imie musi być wypełnione")]
        [Display(Name = "Imie")]
        public string FirstName { get; set; }

        [MaxLength(150, ErrorMessage = "Nazwisko może zawierać maksymalnie 150 znaków ")]
        [Required(ErrorMessage = "Pole Nazwisko musi być wypełnione")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [MaxLength(150, ErrorMessage = "Drugie Imie może zawierać maksymalnie 150 znaków ")]
        [Display(Name = "Drugie Imie")]
        public string? MiddleName { get; set; }


        [MaxLength(150, ErrorMessage = "Email może zawierać maksymalnie 150 znaków ")]
        [Required(ErrorMessage = "Pole Email musi być wypełnione")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [MaxLength(150, ErrorMessage = "Nik może zawierać maksymalnie 150 znaków ")]
        [Display(Name = "Nik")]
        public string? Nick { get; set; }

        [MaxLength(150, ErrorMessage = "Data urodzenia może zawierać maksymalnie 150 znaków ")]
        [Display(Name = "Data urodzenia")]
        public string? Dob { get; set; }

        [MaxLength(150, ErrorMessage = "Narodowość może zawierać maksymalnie 150 znaków ")]
        [Display(Name = "Narodowość")]
        public string? Nationality { get; set; }

        public virtual ICollection<Rating>? Rating { get; set; }
        public virtual ICollection<Loan>? Loan { get; set; }
    }
}
