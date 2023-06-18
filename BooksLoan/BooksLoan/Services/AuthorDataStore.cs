using BookLoan.Service.Reference;
using BooksLoan.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace BooksLoan.Services
{
    public class AuthorDataStore : AListDataStore<Author>
    {
        public AuthorDataStore() 
            :base()
        { 
        }
        public override Task<Author> AddItemToService(Author item)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteItemFromService(Author item)
        {
            throw new NotImplementedException();
        }

        public override Task<Author> Find(Author item)
        {
            throw new NotImplementedException();
        }

        public override Task<Author> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateItemInService(Author item)
        {
            throw new NotImplementedException();
        }
    }
}
