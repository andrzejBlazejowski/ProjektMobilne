using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using System;

namespace BooksLoan.ViewModels.BookVM
{
    public class NewBookViewModel : ANewViewModel<Book>
    {
        #region Fields
        private string title;
        private string subTitle;
        private string isbn;
        private string publisher;
        private DateTime publishDate;
        private string language;
        #endregion Fields
        #region Properties
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
        public string Language
        {
            get => language;
            set => SetProperty(ref language, value);
        }
        public string SubTitle
        {
            get => subTitle;
            set => SetProperty(ref subTitle, value);
        }
        public string ISBN
        {
            get => isbn;
            set => SetProperty(ref isbn, value);
        }
        public string Publisher
        {
            get => publisher;
            set => SetProperty(ref publisher, value);
        }
        public DateTime PublishDate
        {
            get => publishDate;
            set => SetProperty(ref publishDate, value);
        }
        #endregion Properties
        public NewBookViewModel()
            : base()
        {
        }
        public override Book SetItem()
        {
            return new Book
            {
                CreationDate = DateTime.Now,
                CreatedBy = 0,
                LastModificationDate = DateTime.Now,
                LastModifiedBy = 0,
                IsActive = true,
            };
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(Title);
        }
    }
}