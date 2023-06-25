using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.Views.ReaderV;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.ReaderVM
{
    public class ReaderViewModel : AListViewModel<Reader>
    {
        public ReaderViewModel(string title = "Reader") : base(title)
        {
        }

        public async override void OnItemSelected(Reader item)
        {
            if (item == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(ReaderDetailsPage)}?{nameof(ReaderDetailsViewModel.ItemId)}={item.Id}");
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(ReaderNewPage));
        }
    }
}
