using BookLoan.Service.Reference;

namespace BooksLoan.ViewModels.AothorVM
{
    public class AuthorDetailsViewModel : AItemDetailsViewModel<Author>
    {
        #region Fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string pseudonym;
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

        #endregion Properties
        public AuthorDetailsViewModel() : base()
        {
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
