using BookLoan.Service.Reference;
using BooksLoan.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace BooksLoan.Services
{
    public class BookDataStore : AListDataStore<Book>
    {
        public BookDataStore()
            :base()
        {
        }

        public override Task<Book> AddItemToService(Book item)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteItemFromService(Book item)
        {
            throw new NotImplementedException();
        }

        public override Task<Book> Find(Book item)
        {
            throw new NotImplementedException();
        }

        public override Task<Book> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateItemInService(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
