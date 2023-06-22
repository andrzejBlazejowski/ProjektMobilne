using BooksLoan.ViewModels.AothorVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.AuthorV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorDetailsPage : ContentPage
    {
        public AuthorDetailsPage()
        {
            InitializeComponent();
            BindingContext = new AuthorDetailsViewModel();
        }
    }
}