using JetBrains.Annotations;
using System;
using System.Collections.Generic;
namespace Book.Core
{
    public class Reader
    {
        public Reader()
        {
            Books = new List<Book>();
        }
        public Reader(
            [NotNull] string firstName,
            [NotNull] string secondName,
            [NotNull] string thirdName,
            [NotNull] string address,
            int ticketNumber,
            [NotNull] string phoneNumber,
            DateTime birthDay) : this()
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentNullException(nameof(firstName));
            if (string.IsNullOrEmpty(secondName))
                throw new ArgumentNullException(nameof(secondName));
            if (string.IsNullOrEmpty(thirdName))
                throw new ArgumentNullException(nameof(thirdName));
            if (string.IsNullOrEmpty(address))
                throw new ArgumentNullException(nameof(address));
            if (ticketNumber == 0)
                throw new ArgumentException("Номер билета не может быть = 0");
            if (string.IsNullOrEmpty(phoneNumber))
                throw new ArgumentNullException(nameof(phoneNumber));
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            Address = address;
            TicketNumber = ticketNumber;
            BirthDay = birthDay;
            PhoneNumber = phoneNumber;

        }
        public int Id { get; set; }
        public string FirstName { get;  set; }
        public string SecondName { get;  set; }
        public string ThirdName { get;  set; }
        public string Address { get;  set; }
        public int TicketNumber { get;  set; }
        public DateTime BirthDay { get;  set; }
        public string PhoneNumber { get;  set; }
        public virtual IList<Book> Books { get; protected set; }

        public void AddBook(Book book)
        {
            if(book == null)
                throw new ArgumentNullException(nameof(book));
            book.StayCount -= 1;
            Books.Add(book);
        }
    }
}
