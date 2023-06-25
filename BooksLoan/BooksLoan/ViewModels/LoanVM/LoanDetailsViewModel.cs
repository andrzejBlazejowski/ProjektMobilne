using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.Views.LoanV;
using System;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.LoanVM
{
    public class LoanDetailsViewModel : AItemDetailsViewModel<Loan>
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
        public LoanDetailsViewModel() : base()
        {
        }
        public override void LoadProperties(Loan item)
        {
            CreatedBy = item.CreatedBy;
            CreationDate = item.CreationDate.DateTime;
            Description = item.Description;
            Id = item.Id;
            IsActive = item.IsActive;
            LastModifiedBy = item.LastModifiedBy;
            LastModificationDate = item.LastModificationDate.DateTime;

            LoanDate = item.LoanDate.DateTime;
            ReturnDate = item.ReturnDate?.DateTime;
            FreeDate = item.FreeDate?.DateTime;
        }
        protected async override void OnEdit()
        {
            await Shell.Current.GoToAsync($"{nameof(LoanEditPage)}?{nameof(EditLoanViewModel.ItemId)}={Id}");
        }
    }
}
