using BookLoan.Service.Reference;

namespace BooksLoan.ViewModels.BookVM
{
    public class BookDetailsViewModel : AItemDetailsViewModel<Book>
    {
        #region Fields
        private string title;
        private string author;
        private string language;
        private string category;
        #endregion Fields
        #region Properties
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
        public string Author
        {
            get => author;
            set => SetProperty(ref author, value);
        }
        public string Language
        {
            get => language;
            set => SetProperty(ref language, value);
        }
        public string Category
        {
            get => category;
            set => SetProperty(ref category, value);
        }
        #endregion Properties
        public BookDetailsViewModel() : base()
        {
        }
        public override void LoadProperties(Book item)
        {
            CreatedBy = item.CreatedBy;
            CreationDate = item.CreationDate.DateTime;
            Description = item.Description;
            Id = item.Id;
            IsActive = item.IsActive;
            LastModifiedBy = item.LastModifiedBy;
            LastModificationDate = item.LastModificationDate.DateTime;
            
            Title = item.Title;
            Author = Helpers.Helpers.GetAuthorAcronym(item.Author);
            Language = item.Language;
            Category = item.Category.Name;
    }
    }
}
