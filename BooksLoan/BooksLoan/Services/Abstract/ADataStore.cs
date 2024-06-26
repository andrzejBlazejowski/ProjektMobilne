﻿using BookLoan.Service.Reference;
using System.Net.Http;

namespace BooksLoan.Services.Abstract
{
    public abstract class ADataStore
    {
        protected readonly BookLoanServices _service;
        public ADataStore()
        {
            //Use this code to test locally - localhost do not have certificate
            var handler = new HttpClientHandler();
#if DEBUG
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };
#endif
            var client = new HttpClient(handler);
            _service = new BookLoanServices("https://localhost:7296", client);
        }
    }
}
