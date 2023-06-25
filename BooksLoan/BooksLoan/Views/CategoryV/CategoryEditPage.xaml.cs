using BooksLoan.ViewModels.CategoryVM;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan.Views.CategoryV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryEditPage : ContentPage
    {
        public BookLoan.Service.Reference.Category Item { get; set; }
        public CategoryEditPage()
        {
            InitializeComponent();
            BindingContext = new EditCategoryViewModel();

        }
    }
}