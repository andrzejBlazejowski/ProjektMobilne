using BookLoan.Service.Reference;
using BooksLoan.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace BooksLoan.Services
{
    public class CategoryDataStore : AListDataStore<Category>
    {
        public CategoryDataStore()
            :base()
        {
        }

        public override Task<Category> AddItemToService(Category item)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteItemFromService(Category item)
        {
            throw new NotImplementedException();
        }

        public override Task<Category> Find(Category item)
        {
            throw new NotImplementedException();
        }

        public override Task<Category> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateItemInService(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
