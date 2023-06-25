using BooksLoan.Services.Abstract;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.Abstract
{
    public abstract class AEditViewModel<T> : AItemDetailsViewModel<T>
    {
        public IDataStore<T> DataStore => DependencyService.Get<IDataStore<T>>();
        public AEditViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }
        public abstract bool ValidateSave();
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }
        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
        public abstract T SetItem();
        private async void OnSave()
        {
            await DataStore.UpdateItemAsync(SetItem());
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        protected async override void OnEdit()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}