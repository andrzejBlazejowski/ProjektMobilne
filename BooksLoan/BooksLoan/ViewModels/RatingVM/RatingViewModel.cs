using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.Views.RatingV;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.RatingVM
{
    public class RatingViewModel : AListViewModel<Rating>
    {
        public RatingViewModel(string title = "Rating") : base(title)
        {
        }

        public async override void OnItemSelected(Rating item)
        {
            if (item == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(RatingDetailsPage)}?{nameof(RatingDetailsViewModel.Id)}={item.Id}");
        }

        public override void GoToAddPage()
        {
            Shell.Current.GoToAsync(nameof(RatingNewPage));
        }
    }
}
