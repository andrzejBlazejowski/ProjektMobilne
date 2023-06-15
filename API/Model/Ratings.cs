using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Ratings : BaseData
    {
        [MaxLength(50, ErrorMessage = "Wartość oceny może zawierać maksymalnie 50 znaków ")]
        [Required(ErrorMessage = "Pole Wartość oceny musi być wypełnione")]
        [Display(Name = "Wartość oceny")]
        public int Value { get; set; }

        [MaxLength(50, ErrorMessage = "Uwagi może zawierać maksymalnie 50 znaków ")]
        [Display(Name = "Uwagi")]
        public int Notes { get; set; }

    }
}
