using BooksLoan.ViewModels.RatingVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.RatingV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingDetailsPage : ContentPage
    {
        public RatingDetailsPage()
        {
            InitializeComponent();
            BindingContext = new RatingDetailsViewModel();
        }
    }
}