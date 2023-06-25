using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Rating : BaseData
    {
        [Required(ErrorMessage = "Pole Wartość oceny musi być wypełnione")]
        [Display(Name = "Wartość oceny")]
        public int Value { get; set; }

        [MaxLength(150, ErrorMessage = "Uwagi może zawierać maksymalnie 50 znaków ")]
        [Display(Name = "Uwagi")]
        public string? Notes { get; set; }
        public int ReaderId { get; set; }
        [ForeignKey("ReaderId")]
        public Reader? Reader { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? Book { get; set; }
    }
}
