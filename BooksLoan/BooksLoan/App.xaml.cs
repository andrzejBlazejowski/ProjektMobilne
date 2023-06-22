using BooksLoan.Services;
using BooksLoan.Views.AuthorV;
using BooksLoan.Views.BookV;
using BooksLoan.Views.LoanV;
using BooksLoan.Views.RatingV;
using BooksLoan.Views.ReaderV;
using Xamarin.Forms;

namespace BooksLoan
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<AuthorDataStore>();
            DependencyService.Register<AuthorNewPage>();
            DependencyService.Register<AuthorDetailsPage>();

            DependencyService.Register<BookDataStore>();
            DependencyService.Register<BookNewPage>();
            DependencyService.Register<BookDetailsPage>();

            DependencyService.Register<CategoryDataStore>();
            DependencyService.Register<CategoryDataStore>();
            DependencyService.Register<CategoryDataStore>();

            DependencyService.Register<LoanDataStore>();
            DependencyService.Register<LoanDetailsPage>();
            DependencyService.Register<LoanNewPage>();

            DependencyService.Register<RatingDataStore>();
            DependencyService.Register<RatingDetailsPage>();
            DependencyService.Register<RatingNewPage>();

            DependencyService.Register<ReaderDataStore>();
            DependencyService.Register<ReaderDetailsPage>();
            DependencyService.Register<ReaderNewPage>();

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
