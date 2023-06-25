using BooksLoan.ViewModels.LoanVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.LoanV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoanEditPage : ContentPage
    {
        public BookLoan.Service.Reference.Loan Item { get; set; }
        public LoanEditPage()
        {
            InitializeComponent();
            BindingContext = new EditLoanViewModel();
        }
    }
}