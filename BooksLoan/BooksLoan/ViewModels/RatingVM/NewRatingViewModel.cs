using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using System;

namespace BooksLoan.ViewModels.RatingVM
{
    public class NewRatingViewModel : ANewViewModel<Rating>
    {
        #region Fields
        private int value;
        private string notes;
        #endregion Fields
        #region Properties
        public int Value
        {
            get => value;
            set => SetProperty(ref value, value);
        }
        public string Notes
        {
            get => notes;
            set => SetProperty(ref notes, value);
        }
        #endregion Properties
        public NewRatingViewModel()
            : base()
        {
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
            };
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(Notes);
        }
    }
}