using System;
using System.Windows.Forms;
using System.Linq;
using Book.Core;

namespace Book.Win
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            using (var context = new BookContext())
            {
                _objectListViewReaders.SetObjects(context.Readers.OrderByDescending(d => d.Id).Take(100));
            }

            Init();
        }
        public void Init()
        {
            try
            {
                using (var context = new BookContext())
                {
                    _objectListViewReaders.SetObjects(context.Readers);
                }
                _txtReaderSearch.TextChanged += (sender, args) =>
                {
                    using (var context = new BookContext())
                    {
                        if (string.IsNullOrEmpty(_txtReaderSearch.Text))
                        {
                            _objectListViewReaders.SetObjects(context.Readers);
                            return;
                        }
                        var readers = context.Readers.Where(d => d.FirstName.ToLower().StartsWith(_txtReaderSearch.Text.ToLower())
                        || d.SecondName.ToLower().StartsWith(_txtReaderSearch.Text.ToLower())).Take(100);
                        _objectListViewReaders.SetObjects(readers);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            _objectListViewReaders.DoubleClick += (sender, args) =>
            {
                var selectedReader = _objectListViewReaders.SelectedObject as Reader;
                using (var context = new BookContext())
                {
                    selectedReader = context.Readers.Include("Books").First(f => f.Id == selectedReader.Id);
                }

                var giveBook = new GiveBook(selectedReader);
                giveBook.ShowDialog();
                
            };
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var readerForm = new ReaderForm();
            readerForm.ShowDialog();
            using (var context = new BookContext())
            {
                _objectListViewReaders.SetObjects(context.Readers.OrderByDescending(d => d.Id).Take(100));
            }
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewBooks = new ViewBooks();
            viewBooks.ShowDialog();
        }
    }
}
