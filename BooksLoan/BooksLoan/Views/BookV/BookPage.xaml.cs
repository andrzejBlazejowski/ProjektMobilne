using BooksLoan.ViewModels.BookVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.BookV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        private BookViewModel _viewModel;

        public BookPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new BookViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}