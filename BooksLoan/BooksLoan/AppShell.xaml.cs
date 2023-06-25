using BooksLoan.Services;
using BooksLoan.ViewModels;
using BooksLoan.Views;
using BooksLoan.Views.AuthorV;
using BooksLoan.Views.BookV;
using BooksLoan.Views.CategoryV;
using BooksLoan.Views.LoanV;
using BooksLoan.Views.RatingV;
using BooksLoan.Views.ReaderV;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BooksLoan
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AuthorPage), typeof(AuthorPage));
            Routing.RegisterRoute(nameof(AuthorNewPage), typeof(AuthorNewPage));
            Routing.RegisterRoute(nameof(AuthorEditPage), typeof(AuthorEditPage));
            Routing.RegisterRoute(nameof(AuthorDetailsPage), typeof(AuthorDetailsPage));

            Routing.RegisterRoute(nameof(BookPage), typeof(BookPage));
            Routing.RegisterRoute(nameof(BookNewPage), typeof(BookNewPage));
            Routing.RegisterRoute(nameof(BookEditPage), typeof(BookEditPage));
            Routing.RegisterRoute(nameof(BookDetailsPage), typeof(BookDetailsPage));

            Routing.RegisterRoute(nameof(CategoryPage), typeof(CategoryPage));
            Routing.RegisterRoute(nameof(CategoryNewPage), typeof(CategoryNewPage));
            Routing.RegisterRoute(nameof(CategoryEditPage), typeof(CategoryEditPage));
            Routing.RegisterRoute(nameof(CategoryDetailsPage), typeof(CategoryDetailsPage));

            Routing.RegisterRoute(nameof(LoanPage), typeof(LoanPage));
            Routing.RegisterRoute(nameof(LoanNewPage), typeof(LoanNewPage));
            Routing.RegisterRoute(nameof(LoanEditPage), typeof(LoanEditPage));
            Routing.RegisterRoute(nameof(LoanDetailsPage), typeof(LoanDetailsPage));

            Routing.RegisterRoute(nameof(RatingPage), typeof(RatingPage));
            Routing.RegisterRoute(nameof(RatingNewPage), typeof(RatingNewPage));
            Routing.RegisterRoute(nameof(RatingEditPage), typeof(RatingEditPage));
            Routing.RegisterRoute(nameof(RatingDetailsPage), typeof(RatingDetailsPage));

            Routing.RegisterRoute(nameof(ReaderPage), typeof(ReaderPage));
            Routing.RegisterRoute(nameof(ReaderNewPage), typeof(ReaderNewPage));
            Routing.RegisterRoute(nameof(ReaderEditPage), typeof(ReaderEditPage));
            Routing.RegisterRoute(nameof(ReaderDetailsPage), typeof(ReaderDetailsPage));

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
