using BookLoan.Service.Reference;
using BooksLoan.Services;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.Views.RatingV;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.RatingVM
{
    public class EditRatingViewModel : AEditViewModel<Rating>
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
        public EditRatingViewModel()
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

                Id = Id,
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

        public async override void RedirectBack()
        {
            await Shell.Current.GoToAsync($"//RatingPage/{nameof(RatingDetailsPage)}?{nameof(RatingDetailsViewModel.ItemId)}={Id}");
        }

        public override void LoadProperties(Rating item)
        {
            CreatedBy = item.CreatedBy;
            CreationDate = item.CreationDate.DateTime;
            Description = item.Description;
            Id = item.Id;
            IsActive = item.IsActive;
            LastModifiedBy = item.LastModifiedBy;
            LastModificationDate = item.LastModificationDate.DateTime;
            Value = item.Value;
            Notes = item.Notes;
        }
    }
}