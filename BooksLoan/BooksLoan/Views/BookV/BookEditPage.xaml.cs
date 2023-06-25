using BooksLoan.ViewModels.BookVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.BookV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookEditPage : ContentPage
    {
        public BookLoan.Service.Reference.Book Item { get; set; }
        public BookEditPage()
        {
            InitializeComponent();
            BindingContext = new EditBookViewModel();
        }
    }
}