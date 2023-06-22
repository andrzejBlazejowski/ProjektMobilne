using BooksLoan.ViewModels.BookVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.BookV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookNewPage : ContentPage
    {
        public BookLoan.Service.Reference.Book Item { get; set; }
        public BookNewPage()
        {
            InitializeComponent();
            BindingContext = new NewBookViewModel();
        }
    }
}