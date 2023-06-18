using BooksLoan.Models;
using BooksLoan.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace BooksLoan.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        #region Fields
        protected int id;
        protected string description;
        protected bool isActive;
        protected DateTime lastModificationDate;
        protected int lastModifiedBy;
        protected DateTime creationDate;
        protected int createdBy;
        #endregion Fields
        #region Properties
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public bool IsActive
        {
            get => isActive;
            set => SetProperty(ref isActive, value);
        }
        public DateTime LastModificationDate
        {
            get => lastModificationDate;
            set => SetProperty(ref lastModificationDate, value);
        }
        public int LastModifiedBy
        {
            get => lastModifiedBy;
            set => SetProperty(ref lastModifiedBy, value);
        }
        public DateTime CreationDate
        {
            get => creationDate;
            set => SetProperty(ref creationDate, value);
        }
        public int CreatedBy
        {
            get => createdBy;
            set => SetProperty(ref createdBy, value);
        }
        #endregion Properties

        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
