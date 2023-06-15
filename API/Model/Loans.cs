using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Loans: BaseData
    {
        [MaxLength(150, ErrorMessage = "Data wypożyczenia może zawierać maksymalnie 150 znaków ")]
        [Required(ErrorMessage = "Pole Data wypożyczenia musi być wypełnione")]
        [Display(Name = "Data wypożyczenia")]
        public DateTime LoanDate { get; set; }

        [MaxLength(150, ErrorMessage = "Data oddania może zawierać maksymalnie 150 znaków ")]
        [Display(Name = "Data oddania")]
        public DateTime ReturnDate { get; set; }

        [MaxLength(150, ErrorMessage = "Data darmowego wypożyczenia może zawierać maksymalnie 150 znaków ")]
        [Display(Name = "Data darmowego wypożyczenia")]
        public string FreeDate { get; set; }
    }
}
