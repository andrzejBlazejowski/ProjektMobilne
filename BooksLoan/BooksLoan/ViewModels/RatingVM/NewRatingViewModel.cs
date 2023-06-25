using BookLoan.Service.Reference;
using BooksLoan.Services;
using BooksLoan.ViewModels.Abstract;
using System;
using System.Collections.Generic;

namespace BooksLoan.ViewModels.RatingVM
{
    public class NewRatingViewModel : ANewViewModel<Rating>
    {
        #region Fields
        private int _value;
        private string notes;
        private ICollection<Reader> readers;
        private Reader selectedReader;
        private ReaderDataStore readerDataStore;
        private ICollection<Book> books;
        private Book selectedBook;
        private BookDataStore bookDataStore;
        #endregion Fields
        #region Properties
        public int Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
        public string Notes
        {
            get => notes;
            set => SetProperty(ref notes, value);
        }
        public ICollection<Reader> Readers
        {
            get => readers;
            set => SetProperty(ref readers, value);
        }
        public Reader SelectedReader
        {
            get => selectedReader;
            set => SetProperty(ref selectedReader, value);
        }
        public ICollection<Book> Books
        {
            get => books;
            set => SetProperty(ref books, value);
        }
        public Book SelectedBook
        {
            get => selectedBook;
            set => SetProperty(ref selectedBook, value);
        }
        #endregion Properties
        public NewRatingViewModel()
            : base()
        {
            readerDataStore = new ReaderDataStore();
            bookDataStore = new BookDataStore();

            Readers = readerDataStore.items;
            Books = bookDataStore.items;
        }
        public override Rating SetItem()
        {
            return new Rating
            {
                CreationDate = DateTime.Now,
                CreatedBy = 0,
                LastModificationDate = DateTime.Now,
                LastModifiedBy = 0,
                IsActive = true,

                Value = Value,
                Notes = Notes,
                ReaderId = SelectedReader.Id,
                BookId = SelectedBook.Id
            };
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(Notes);
        }
    }
}