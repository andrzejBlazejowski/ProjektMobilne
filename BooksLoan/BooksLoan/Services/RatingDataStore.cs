using BookLoan.Service.Reference;
using BooksLoan.Services.Abstract;
using System;
using System.Threading.Tasks;

namespace BooksLoan.Services
{
    public class RatingDataStore : AListDataStore<Rating>
    {
        public RatingDataStore()
            : base()
        {
        }

        public override Task<Rating> AddItemToService(Rating item)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteItemFromService(Rating item)
        {
            throw new NotImplementedException();
        }

        public override Task<Rating> Find(Rating item)
        {
            throw new NotImplementedException();
        }

        public override Task<Rating> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateItemInService(Rating item)
        {
            throw new NotImplementedException();
        }
    }
}
