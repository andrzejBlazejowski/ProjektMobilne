using BookLoan.Service.Reference;
using System;
using System.Threading.Tasks;

namespace BooksLoan.Helpers
{
    public static class Helpers
    {
        public async static Task<bool> HandleRequest(this Task serviceMethod)
        {
            try
            {
                await serviceMethod;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static string GetAuthorAcronym(Author author)
        {
            return author.FirstName.Substring(0, 1) +
                (author.MiddleName != null ? " " + author.FirstName.Substring(0, 1) + " " : " ") +
                author.LastName;
        }
    }
}
