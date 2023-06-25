using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using System;

namespace BooksLoan.ViewModels.AothorVM
{
    public class EditAuthorViewModel : AEditViewModel<Author>
    {
        #region Fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string pseudonym;
        private string nationality;
        private DateTime dob;
        private string description;
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
        public string Pseudonym
        {
            get => pseudonym;
            set => SetProperty(ref pseudonym, value);
        }
        public string Nationality
        {
            get => nationality;
            set => SetProperty(ref nationality, value);
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public DateTime Dob
        {
            get => dob;
            set => SetProperty(ref dob, value);
        }
        public DateTime MinDate
        {
            get => new DateTime(1969, 12, 31);
        }
        public DateTime MaxDate
        {
            get => DateTime.Now;
        }
        #endregion Properties
        public EditAuthorViewModel()
            : base()
        {
        }
        public override Author SetItem()
        {
            return new Author
            {
                CreationDate = CreationDate,
                CreatedBy = CreatedBy,
                LastModificationDate = DateTime.Now,
                LastModifiedBy = 0,
                IsActive = true,

                FirstName = FirstName,
                LastName = LastName,
                MiddleName = MiddleName,
                Pseudonym = Pseudonym,
                Nationality = Nationality,
                Description = Description,
                Dob = Dob.ToString(),
            };
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(FirstName);
        }

        public override void LoadProperties(Author item)
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
            Pseudonym = item.Pseudonym;
            Nationality = item.Nationality;
        }
    }
}