using BooksLoan.ViewModels.ReaderVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.ReaderV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReaderNewPage : ContentPage
    {
        public BookLoan.Service.Reference.Reader Item { get; set; }
        public ReaderNewPage()
        {
            InitializeComponent();
            BindingContext = new NewReaderViewModel();
        }
    }
}