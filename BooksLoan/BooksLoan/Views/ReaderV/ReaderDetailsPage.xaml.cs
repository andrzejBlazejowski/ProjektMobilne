using BooksLoan.ViewModels.ReaderVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.ReaderV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReaderDetailsPage : ContentPage
    {
        public ReaderDetailsPage()
        {
            InitializeComponent();
            BindingContext = new ReaderDetailsViewModel();
        }
    }
}