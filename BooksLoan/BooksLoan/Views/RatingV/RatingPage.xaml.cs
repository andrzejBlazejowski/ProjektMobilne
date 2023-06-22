using BooksLoan.ViewModels.RatingVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.RatingV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatingPage : ContentPage
    {
        private RatingViewModel _viewModel;
        public RatingPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new RatingViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}