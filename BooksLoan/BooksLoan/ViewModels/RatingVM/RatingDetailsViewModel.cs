using BookLoan.Service.Reference;

namespace BooksLoan.ViewModels.RatingVM
{
    public class RatingDetailsViewModel : AItemDetailsViewModel<Rating>
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
        public RatingDetailsViewModel() : base()
        {
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
