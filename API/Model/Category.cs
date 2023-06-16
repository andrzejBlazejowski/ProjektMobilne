using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Category: BaseData
    {
        [MaxLength(50, ErrorMessage = "Nazwa może zawierać maksymalnie 50 znaków ")]
        [Required(ErrorMessage = "Pole Nazwa musi być wypełnione")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        public virtual ICollection<Book>? Book { get; set; }
    }
}
