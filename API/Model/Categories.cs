using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Categories: BaseData
    {
        [MaxLength(50, ErrorMessage = "Nazwa może zawierać maksymalnie 50 znaków ")]
        [Required(ErrorMessage = "Pole Nazwa musi być wypełnione")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

    }
}
