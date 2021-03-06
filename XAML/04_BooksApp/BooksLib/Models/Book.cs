﻿using GenericViewModels.Core;

namespace BooksLib.Models
{
    public class Book : BindableBase
    {
        public int BookId { get; set; }

        private string _title;
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }

        private string _publisher;
        public string Publisher
        {
            get => _publisher;
            set => Set(ref _publisher, value);
        }

        public override string ToString() => Title;
    }
}
