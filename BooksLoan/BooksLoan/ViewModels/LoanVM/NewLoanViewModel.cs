using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using System;

namespace BooksLoan.ViewModels.LoanVM
{
    public class NewLoanViewModel : ANewViewModel<Author>
    {
        #region Fields
        private DateTime loanDate;
        private DateTime? returnDate;
        private DateTime? freeDate;
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
        #endregion Properties
        public NewLoanViewModel()
            : base()
        {
        }
        public override Author SetItem()
        {
            return new Author
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
            return LoanDate != null;
        }
    }
}