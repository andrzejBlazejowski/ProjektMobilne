using BooksLoan.ViewModels.ReaderVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.ReaderV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReaderPage : ContentPage
    {
        private ReaderViewModel _viewModel;
        public ReaderPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ReaderViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}