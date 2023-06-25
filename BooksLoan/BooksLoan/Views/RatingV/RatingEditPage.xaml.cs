using BooksLoan.ViewModels.RatingVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.RatingV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingEditPage : ContentPage
    {
        public BookLoan.Service.Reference.Rating Item { get; set; }
        public RatingEditPage()
        {
            InitializeComponent();
            BindingContext = new EditRatingViewModel();
        }
    }
}