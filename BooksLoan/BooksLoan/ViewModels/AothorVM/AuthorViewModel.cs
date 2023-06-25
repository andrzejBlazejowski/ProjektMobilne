using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.Views.AuthorV;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.AothorVM
{
    public class AuthorViewModel : AListViewModel<Author>
    {
        public AuthorViewModel(string title = "Author") : base(title)
        {
        }

        public async override void OnItemSelected(Author item)
        {
            if (item == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(AuthorDetailsPage)}?{nameof(AuthorDetailsViewModel.ItemId)}={item.Id}");
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(AuthorNewPage));
        }
    }
}
