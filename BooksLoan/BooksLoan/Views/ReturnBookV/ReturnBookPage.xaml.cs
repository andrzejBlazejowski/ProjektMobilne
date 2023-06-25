using BooksLoan.ViewModels.LoanVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.LoanV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoanPage : ContentPage
    {
        private ReturnBookViewModel _viewModel;
        public LoanPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new LoanViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}