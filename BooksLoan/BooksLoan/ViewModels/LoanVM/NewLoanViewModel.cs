using BookLoan.Service.Reference;
using BooksLoan.Services;
using BooksLoan.ViewModels.Abstract;
using System;
using System.Collections.Generic;

namespace BooksLoan.ViewModels.LoanVM
{
    public class NewLoanViewModel : ANewViewModel<Loan>
    {
        #region Fields
        private DateTime loanDate;
        private DateTime? returnDate;
        private DateTime? freeDate;
        private ICollection<Book> books;
        private Book selectedBook;
        private ICollection<Reader> readers;
        private Reader selectedReader;
        private ReaderDataStore readerDataStore;
        private BookDataStore bookDataStore;
        #endregion Fields
        #region Properties
        public DateTime LoanDate
        {
            get => loanDate;
            set => SetProperty(ref loanDate, value);
        }
        public DateTime? ReturnDate
        {
            get => returnDate;
            set => SetProperty(ref returnDate, value);
        }
        public DateTime? FreeDate
        {
            get => freeDate;
            set => SetProperty(ref freeDate, value);
        }
        public DateTime MinDate
        {
            get => new DateTime(2023, 01, 01);
        }
        public DateTime Today
        {
            get => DateTime.Now;
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
        #endregion Properties
        public NewLoanViewModel()
            : base()
        {
            readerDataStore = new ReaderDataStore();
            bookDataStore = new BookDataStore();

            Books = bookDataStore.items;
            Readers = readerDataStore.items;

            LoanDate = DateTime.Now;
            FreeDate = DateTime.Now.AddDays(60);
            returnDate = null;
        }
        public override Loan SetItem()
        {
            return new Loan
            {
                CreationDate = DateTime.Now,  
                CreatedBy = 0,
                LastModificationDate = DateTime.Now,
                LastModifiedBy = 0,
                IsActive = true,

                LoanDate = LoanDate,
                ReturnDate = ReturnDate,
                FreeDate = FreeDate,
                BookId = SelectedBook.Id,
                ReaderId = SelectedReader.Id

            };
        }
        public override bool ValidateSave()
        {
            return LoanDate != null;
        }
    }
}