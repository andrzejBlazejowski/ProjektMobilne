using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.Views.LoanV;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.LoanVM
{
    public class LoanViewModel : AListViewModel<Loan>
    {
        public LoanViewModel(string title = "Loan") : base(title)
        {
        }

        public async override void OnItemSelected(Loan item)
        {
            if (item == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(LoanDetailsPage)}?{nameof(LoanDetailsViewModel.ItemId)}={item.Id}");
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(LoanNewPage));
        }
    }
}
