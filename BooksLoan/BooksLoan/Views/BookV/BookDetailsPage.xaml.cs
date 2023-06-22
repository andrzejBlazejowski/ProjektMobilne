using BooksLoan.ViewModels.BookVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.BookV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookDetailsPage : ContentPage
    {
        public BookDetailsPage()
        {
            InitializeComponent();
            BindingContext = new BookDetailsViewModel();
        }
    }
}