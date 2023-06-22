using BooksLoan.ViewModels.LoanVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.LoanV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoanDetailsPage : ContentPage
    {
        public LoanDetailsPage()
        {
            InitializeComponent();
            BindingContext = new LoanDetailsViewModel();
        }
    }
}