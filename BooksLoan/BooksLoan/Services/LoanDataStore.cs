using BooksLoan.Services.Abstract;
using BookLoan.Service.Reference;
using System;
using System.Threading.Tasks;

namespace BooksLoan.Services
{
    public class LoanDataStore : AListDataStore<Loan>
    {
        public LoanDataStore()
            :base() { }
        public override Task<Loan> AddItemToService(Loan item)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> DeleteItemFromService(Loan item)
        {
            throw new NotImplementedException();
        }

        public override Task<Loan> Find(Loan item)
        {
            throw new NotImplementedException();
        }

        public override Task<Loan> Find(int id)
        {
            throw new NotImplementedException();
        }

        public override Task RefreshListFromService()
        {
            throw new NotImplementedException();
        }

        public override Task<bool> UpdateItemInService(Loan item)
        {
            throw new NotImplementedException();
        }
    }
    
}
