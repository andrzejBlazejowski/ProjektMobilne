using BookLoan.Service.Reference;
using System;

namespace BooksLoan.ViewModels.ReaderVM
{
    public class ReaderDetailsViewModel : AItemDetailsViewModel<Reader>
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
        public ReaderDetailsViewModel() : base()
        {
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
            //Dob = item.Dob;
            Nationality = item.Nationality;
        }
    }
}
