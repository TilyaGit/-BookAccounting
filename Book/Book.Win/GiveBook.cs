using Book.Core;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Book.Win
{
    public partial class GiveBook : Form
    {
        Reader _selectedReader = null;

        public GiveBook(Reader reader)
        {
            InitializeComponent();

            _selectedReader = reader;

            InitGiveBook();
        }
        public void InitGiveBook()
        {
            _olvColumnDatePublisher.AspectToStringConverter = (o) =>
            {
                var date = Convert.ToDateTime(o);
                return date.ToString("yyyy");
            };
            try
            {
                using (var context = new BookContext())
                {
                    _objectListViewBooks.SetObjects(context.Books);
                }
                _txtBookSearch.TextChanged += (sender, args) =>
                {
                    using (var context = new BookContext())
                    {
                        if (string.IsNullOrEmpty(_txtBookSearch.Text))
                        {
                            _objectListViewBooks.SetObjects(context.Books);
                            return;
                        }
                        var books = context.Books.Where(d => d.Name.ToLower().StartsWith(_txtBookSearch.Text.ToLower())
                        || d.Author.ToLower().StartsWith(_txtBookSearch.Text.ToLower())).Take(100);
                        _objectListViewBooks.SetObjects(books);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            
            _objectListViewBooks.SelectedIndexChanged += (sender, args) =>
            {
                Core.Book selectedBook = _objectListViewBooks.SelectedObject as Core.Book;
                if (selectedBook == null) return;
            };

            _btnGiveBook.Click += (sender, args) =>
            {
                try
                {
                    using (var context = new BookContext())
                    {
                        var reader = context.Readers.Include("Books").First(f => f.Id == _selectedReader.Id);
                        Core.Book selectedBook = _objectListViewBooks.SelectedObject as Core.Book;
                        if (selectedBook == null)
                        {
                            MessageBox.Show("Укажите книгу для выдачи", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (MessageBox.Show($"Выдать книгу '{selectedBook.Name}', '{selectedBook.Author}' ?",
                                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            return;
                        }
                        selectedBook = context.Books.First(b => b.Id == selectedBook.Id);

                        if (reader.Books.Any(book => book.Id == selectedBook.Id))
                        {
                            MessageBox.Show("У читателя есть такая книга", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (selectedBook.StayCount < 1)
                        {
                            MessageBox.Show("Все экземпляры книг выданы", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        reader.AddBook(selectedBook);
                        context.SaveChanges();
                        _objectListViewBooks.SetObjects(context.Books);
                        MessageBox.Show("Книга выдана, спасибо!", "Внимание");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
                Close();
            };
        }
    }
}
