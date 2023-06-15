using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Books : BaseData
    {
        [MaxLength(50, ErrorMessage = "Tytuł może zawierać maksymalnie 50 znaków ")]
        [Required(ErrorMessage = "Pole Tytuł musi być wypełnione")]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [MaxLength(50, ErrorMessage = "Pod tytuł może zawierać maksymalnie 50 znaków ")]
        [Display(Name = "Pod tytuł")]
        public string SubTitle { get; set; }

        [MaxLength(50, ErrorMessage = "orginal title może zawierać maksymalnie 50 znaków ")]
        [Display(Name = "orginal title")]
        public string OrginalTitle { get; set; }

        [MaxLength(50, ErrorMessage = "ISBN może zawierać maksymalnie 50 znaków ")]
        [Required(ErrorMessage = "Pole ISBN musi być wypełnione")]
        [Display(Name = "ISBN")]
        public string Isbn { get; set; }

        [MaxLength(50, ErrorMessage = "Data publikacj może zawierać maksymalnie 50 znaków ")]
        [Required(ErrorMessage = "Pole Data publikacj musi być wypełnione")]
        public DateTime PublishDate { get; set; }

        [MaxLength(50, ErrorMessage = "Wydawca może zawierać maksymalnie 50 znaków ")]
        [Required(ErrorMessage = "Pole Wydawca musi być wypełnione")]
        public string Publisher { get; set; }

        [MaxLength(50, ErrorMessage = "Język może zawierać maksymalnie 50 znaków ")]
        [Display(Name = "Język")]
        public string Language { get; set; }
    }
}
