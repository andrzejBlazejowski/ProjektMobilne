using BooksLoan.Services;
using BooksLoan.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BooksLoan
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<AuthorDataStore>();
            DependencyService.Register<BookDataStore>();
            DependencyService.Register<CategoryDataStore>();
            DependencyService.Register<LoanDataStore>();
            DependencyService.Register<RatingDataStore>();
            DependencyService.Register<ReaderDataStore>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
