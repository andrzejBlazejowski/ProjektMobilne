using BooksLoan.Services.Abstract;
using BookLoan.Service.Reference;
using System;
using System.Threading.Tasks;
using BooksLoan.Helpers;
using System.Linq;

namespace BooksLoan.Services
{
    public class LoanDataStore : AListDataStore<Loan>
    {
        public LoanDataStore()
            :base() { }
        public override async Task<Loan> AddItemToService(Loan item)
        {
            return await _service.LoanPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(Loan item)
        {
            return await _service.LoanDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<Loan> Find(Loan item)
        {
            return await _service.LoanGETAsync(item.Id);
        }

        public override async Task<Loan> Find(int id)
        {
            return await _service.LoanGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            items = _service.LoanAllAsync().Result.ToList();
        }

        public override async Task<bool> UpdateItemInService(Loan item)
        {
            return await _service.LoanPUTAsync(item.Id, item).HandleRequest();
        }
    }
    
}
