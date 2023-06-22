using BooksLoan.ViewModels.LoanVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.LoanV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoanNewPage : ContentPage
    {
        public BookLoan.Service.Reference.Loan Item { get; set; }
        public LoanNewPage()
        {
            InitializeComponent();
            BindingContext = new NewLoanViewModel();
        }
    }
}