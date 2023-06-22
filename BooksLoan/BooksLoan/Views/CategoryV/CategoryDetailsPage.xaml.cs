using BooksLoan.ViewModels.CategoryVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.CategoryV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryDetailsPage : ContentPage
    {
        public CategoryDetailsPage()
        {
            InitializeComponent();
            BindingContext = new CategoryDetailsViewModel();
        }
    }
}