using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Book.Win
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();

            using (var context = new BookContext())
            {
                var issuedBooks = context.Books.Where(book => book.StayCount != book.TotalCount);
                _objectListViewIssuedBooks.SetObjects(issuedBooks);
                var freeBooks = context.Books.Where(book => book.StayCount > 0);
                _objectListViewFreeBooks.SetObjects(freeBooks);
            }
        }
    }
}
