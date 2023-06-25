using BookLoan.Service.Reference;
using BooksLoan.ViewModels.Abstract;
using System;

namespace BooksLoan.ViewModels.CategoryVM
{
    public class NewCategoryViewModel : ANewViewModel<Category>
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
        public NewCategoryViewModel()
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
                Name = Name,
                Description = Description
            };
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(Name);
        }
    }
}