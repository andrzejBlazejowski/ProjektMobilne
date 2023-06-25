using BooksLoan.Services.Abstract;
using BooksLoan.ViewModels.AothorVM;
using BooksLoan.Views.AuthorV;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.Abstract
{
    public abstract class AEditViewModel<T> : AItemDetailsViewModel<T>
    {
        public IDataStore<T> DataStore => DependencyService.Get<IDataStore<T>>();
        public AEditViewModel()
        {
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => EditCommand.ChangeCanExecute();
        }
        public abstract bool ValidateSave();
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }
        private async void OnCancel()
        {
            RedirectBack();
        }
        public abstract T SetItem();
        public abstract void RedirectBack();
        protected async override void OnEdit()
        {
            await DataStore.UpdateItemAsync(SetItem());

            RedirectBack();
        }
    }
}