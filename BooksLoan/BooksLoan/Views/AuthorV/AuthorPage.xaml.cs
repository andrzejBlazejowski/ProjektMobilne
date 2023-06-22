using BooksLoan.ViewModels.AothorVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.AuthorV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorPage : ContentPage
    {
        private AuthorViewModel _viewModel;

        public AuthorPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new AuthorViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}