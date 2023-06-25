using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using BooksLoan.ViewModels.AothorVM;
using BooksLoan.Views.AuthorV;
using BooksLoan.Views.CategoryV;
using System;
using Xamarin.Forms;

namespace BooksLoan.ViewModels.CategoryVM
{
    public class EditCategoryViewModel : AEditViewModel<Category>
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
        public EditCategoryViewModel()
            : base()
        {
        }
        public override Category SetItem()
        {
            return new Category
            {
                CreationDate = DateTime.Now,
                CreatedBy = 0,
                LastModificationDate = DateTime.Now,
                LastModifiedBy = 0,
                IsActive = true,
                Id = Id,
                Name = Name,
                Description = Description
            };
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(Name);
        }

        public async override void RedirectBack()
        {
            await Shell.Current.GoToAsync($"//CategoryPage/{nameof(CategoryDetailsPage)}?{nameof(CategoryDetailsViewModel.ItemId)}={Id}");
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
    }
}