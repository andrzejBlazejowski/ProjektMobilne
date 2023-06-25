using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Loan: BaseData
    {
        [Required(ErrorMessage = "Pole Data wypożyczenia musi być wypełnione")]
        [Display(Name = "Data wypożyczenia")]
        public DateTime LoanDate { get; set; }

        [Display(Name = "Data oddania")]
        public DateTime? ReturnDate { get; set; }

        [Display(Name = "Data darmowego wypożyczenia")]
        public DateTime? FreeDate { get; set; }

        public int ReaderId { get; set; }
        [ForeignKey("ReaderId")]
        public Reader? Reader { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? Book { get; set; }

    }
}
