using BookLoan.Service.Reference;
using BooksLoan.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace BooksLoan.Services
{
    public class ReaderDataStore : AListDataStore<Reader>
    {
        public ReaderDataStore()
            : base()
        {
        }

        public override Task<Reader> AddItemToService(Reader item)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteItemFromService(Reader item)
        {
            throw new NotImplementedException();
        }

        public override Task<Reader> Find(Reader item)
        {
            throw new NotImplementedException();
        }

        public override Task<Reader> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateItemInService(Reader item)
        {
            throw new NotImplementedException();
        }
    }
}
