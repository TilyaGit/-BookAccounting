using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace Book.Core
{
    public class Book
    {
        public Book()
        {
            Readers = new List<Reader>();
        }

        public Book(
                [NotNull] string name,
                [NotNull] string author,
                int countPage,
                DateTime datePublisher,
                int totalCount) : this()
        {

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrEmpty(author))
                throw new ArgumentNullException(nameof(author));
            if (countPage == 0)
                throw new ArgumentException("Количество страниц не может быть = 0");
            if (totalCount < 1)
                throw new ArgumentException("Количество экземпляров не может быть меньше 1");
            Name = name;
            Author = author;
            DatePublisher = datePublisher;
            CountPage = countPage;
            TotalCount = totalCount;
            StayCount = totalCount;
        }

        public int Id { get; protected set; }
        public string Name { get; set; }
        public string Author { get;  set; }
        public DateTime DatePublisher { get;  set; }
        public int CountPage { get;  set; }
        public virtual IList<Reader> Readers { get; protected set; }
        public int TotalCount { get; set; }
        public int StayCount { get; set; }

    }
}
