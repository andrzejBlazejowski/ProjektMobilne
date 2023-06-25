using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.Views.BookV;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.BookVM
{
    public class BookViewModel : AListViewModel<Book>
    {
        public BookViewModel(string title = "Book") : base(title)
        {
        }

        public async override void OnItemSelected(Book item)
        {
            if (item == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(BookDetailsPage)}?{nameof(BookDetailsViewModel.Id)}={item.Id}");
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(BookNewPage));
        }
    }
}
