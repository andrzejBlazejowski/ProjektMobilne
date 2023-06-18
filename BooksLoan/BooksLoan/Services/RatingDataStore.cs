using BookLoan.Service.Reference;
using BooksLoan.Helpers;
using BooksLoan.Services.Abstract;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BooksLoan.Services
{
    public class RatingDataStore : AListDataStore<Rating>
    {
        public RatingDataStore()
            : base()
        {
        }
        public override async Task<Rating> AddItemToService(Rating item)
        {
            return await _service.RatingPOSTAsync(item);
        }

        public override async Task<bool> DeleteItemFromService(Rating item)
        {
            return await _service.RatingDELETEAsync(item.Id).HandleRequest();
        }

        public override async Task<Rating> Find(Rating item)
        {
            return await _service.RatingGETAsync(item.Id);
        }

        public override async Task<Rating> Find(int id)
        {
            return await _service.RatingGETAsync(id);
        }

        public override async Task RefreshListFromService()
        {
            items = _service.RatingAllAsync().Result.ToList();
        }

        public override async Task<bool> UpdateItemInService(Rating item)
        {
            return await _service.RatingPUTAsync(item.Id, item).HandleRequest();
        }
    }

}
