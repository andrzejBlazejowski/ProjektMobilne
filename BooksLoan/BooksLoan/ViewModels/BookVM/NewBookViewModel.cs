﻿using BookLoan.Service.Reference;
using BooksLoan.Services;
using BooksLoan.ViewModels.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksLoan.ViewModels.BookVM
{
    public class NewBookViewModel : ANewViewModel<Book>
    {
        #region Fields
        private string title;
        private string subTitle;
        private string isbn;
        private string publisher;
        private DateTime publishDate;
        private string language;
        private string orginalTitle;
        private ICollection<Category> categories;
        private Category selectedCategory;
        private ICollection<Author> authors;
        private Author selectedAuthor;
        private AuthorDataStore authorDataStore;
        private CategoryDataStore categoryDataStore;
        #endregion Fields
        #region Properties
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }
        public string Language
        {
            get => language;
            set => SetProperty(ref language, value);
        }
        public string SubTitle
        {
            get => subTitle;
            set => SetProperty(ref subTitle, value);
        }
        public string ISBN
        {
            get => isbn;
            set => SetProperty(ref isbn, value);
        }
        public string Publisher
        {
            get => publisher;
            set => SetProperty(ref publisher, value);
        }
        public string OrginalTitle
        {
            get => orginalTitle;
            set => SetProperty(ref orginalTitle, value);
        }
        public DateTime PublishDate
        {
            get => publishDate;
            set => SetProperty(ref publishDate, value);
        }
        public ICollection<Category> Categories
        {
            get => categories;
            set => SetProperty(ref categories, value);
        }
        public Category SelectedCategory
        {
            get => selectedCategory;
            set => SetProperty(ref selectedCategory, value);
        }
        public ICollection<Author> Authors
        {
            get => authors;
            set => SetProperty(ref authors, value);
        }
        public Author SelectedAuthor
        {
            get => selectedAuthor;
            set => SetProperty(ref selectedAuthor, value);
        }
        public DateTime MinDate
        {
            get => new DateTime(1923, 12, 31);
        }
        public DateTime MaxDate
        {
            get => DateTime.Now;
        }
        #endregion Properties
        public NewBookViewModel()
            : base()
        {
            categoryDataStore = new CategoryDataStore();
            authorDataStore = new AuthorDataStore();

            Categories = categoryDataStore.items;
            Authors = authorDataStore.items;
        }
        public override Book SetItem()
        {
            var book = new Book
            {
                CreationDate = DateTime.Now,
                CreatedBy = 0,
                LastModificationDate = DateTime.Now,
                LastModifiedBy = 0,
                IsActive = true,

                Title = Title,
                SubTitle = SubTitle,
                Isbn = ISBN,
                Publisher = Publisher,
                PublishDate = PublishDate,
                Language = Language,
                AuthorId = SelectedAuthor.Id,
                CategoryId = SelectedCategory.Id,
                OrginalTitle = OrginalTitle,
                Author = SelectedAuthor,
                Category = SelectedCategory

            };

            return book;
        }
        public override bool ValidateSave()
        {
            return !String.IsNullOrEmpty(Title);
        }
    }
}
