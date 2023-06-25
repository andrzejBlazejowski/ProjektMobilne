using BookLoan.Service.Reference;

namespace BooksLoan.ViewModels.CategoryVM
{
    public class CategoryDetailsViewModel : AItemDetailsViewModel<Category>
    {
        #region Fields
        private string name;
        private string description;
        #endregion Fields
        #region Properties
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        #endregion Properties
        public CategoryDetailsViewModel() : base()
        {
        }
        public override void LoadProperties(Category item)
        {
            CreatedBy = item.CreatedBy;
            CreationDate = item.CreationDate.DateTime;
            Description = item.Description;
            Id = item.Id;
            IsActive = item.IsActive;
            LastModifiedBy = item.LastModifiedBy;
            LastModificationDate = item.LastModificationDate.DateTime;

            Name = item.Name;
            Description = item.Description;
        }
        protected async override void OnEdit()
        {
            //await Shell.Current.GoToAsync($"{nameof(EditCategoryPage)}?{nameof(EditCategoryViewModel.ItemId)}={item.Id}");
        }
    }
}
