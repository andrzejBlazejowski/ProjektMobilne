using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.Views.CategoryV;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.CategoryVM
{
    public class CategoryViewModel : AListViewModel<Category>
    {
        public CategoryViewModel(string title = "Category") : base(title)
        {
        }

        public async override void OnItemSelected(Category item)
        {
            if (item == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(CategoryDetailsPage)}?{nameof(CategoryDetailsViewModel.ItemId)}={item.Id}");
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(CategoryNewPage));
        }
    }
}
