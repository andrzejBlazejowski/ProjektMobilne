using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.Views.ReaderV;
using System;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.ReaderVM
{
    public class EditReaderViewModel : AEditViewModel<Reader>
    {
        #region Fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string nick;
        private string email;
        private DateTime dob;
        private string nationality;
        #endregion Fields
        #region Properties
        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value);
        }
        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }
        public string MiddleName
        {
            get => middleName;
            set => SetProperty(ref middleName, value);
        }
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        public DateTime Dob
        {
            get => dob;
            set => SetProperty(ref dob, value);
        }
        public string Nick
        {
            get => nick;
            set => SetProperty(ref nick, value);
        }
        public string Nationality
        {
            get => nationality;
            set => SetProperty(ref nationality, value);
        }
        #endregion Properties
        public EditReaderViewModel()
            : base()
        {
        }
        public override Reader SetItem()
        {
            return new Reader
            {
                CreationDate = DateTime.Now,
                CreatedBy = 0,
                LastModificationDate = DateTime.Now,
                LastModifiedBy = 0,
                IsActive = true,

                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                MiddleName = MiddleName,
                Nick = Nick,
                Email = Email,

            };
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(FirstName);
        }
        public async override void RedirectBack()
        {
            await Shell.Current.GoToAsync($"//ReaderPage/{nameof(ReaderDetailsPage)}?{nameof(ReaderDetailsViewModel.ItemId)}={Id}");
        }
        public override void LoadProperties(Reader item)
        {
            CreatedBy = item.CreatedBy;
            CreationDate = item.CreationDate.DateTime;
            Description = item.Description;
            Id = item.Id;
            IsActive = item.IsActive;
            LastModifiedBy = item.LastModifiedBy;
            LastModificationDate = item.LastModificationDate.DateTime;
            FirstName = item.FirstName;
            LastName = item.LastName;
            MiddleName = item.MiddleName;
            Nick = item.Nick;
            Email = item.Email;
            Dob = DateTime.Parse(item.Dob);
            Nationality = item.Nationality;
        }
    }
}