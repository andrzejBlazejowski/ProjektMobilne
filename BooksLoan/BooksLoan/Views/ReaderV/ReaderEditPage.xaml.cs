using BooksLoan.ViewModels.ReaderVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.ReaderV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReaderEditPage : ContentPage
    {
        public BookLoan.Service.Reference.Reader Item { get; set; }
        public ReaderEditPage()
        {
            InitializeComponent();
            BindingContext = new EditReaderViewModel();
        }
    }
}