using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Loan: BaseData
    {
        [MaxLength(150, ErrorMessage = "Data wypożyczenia może zawierać maksymalnie 150 znaków ")]
        [Required(ErrorMessage = "Pole Data wypożyczenia musi być wypełnione")]
        [Display(Name = "Data wypożyczenia")]
        public DateTime LoanDate { get; set; }

        [MaxLength(150, ErrorMessage = "Data oddania może zawierać maksymalnie 150 znaków ")]
        [Display(Name = "Data oddania")]
        public DateTime? ReturnDate { get; set; }

        [MaxLength(150, ErrorMessage = "Data darmowego wypożyczenia może zawierać maksymalnie 150 znaków ")]
        [Display(Name = "Data darmowego wypożyczenia")]
        public string? FreeDate { get; set; }

        public int ReaderId { get; set; }
        [ForeignKey("ReaderId")]
        public virtual Reader? Reader { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book? Book { get; set; }

    }
}
