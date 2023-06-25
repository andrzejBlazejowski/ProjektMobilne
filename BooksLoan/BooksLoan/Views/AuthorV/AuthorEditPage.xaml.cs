using BooksLoan.ViewModels.AothorVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.AuthorV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorEditPage : ContentPage
    {
        public BookLoan.Service.Reference.Author Item { get; set; }
        public AuthorEditPage()
        {
            InitializeComponent();
            BindingContext = new EditAuthorViewModel();
        }
    }
}