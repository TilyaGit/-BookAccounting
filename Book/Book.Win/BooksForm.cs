using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace Book.Win
{
    public partial class BooksForm : Form
    {
        Core.Book _selectedBook = null;
        public BooksForm()
        {
            InitializeComponent();

            Load += (sender, args) =>
            {
                using (var context = new BookContext())
                {
                    _objectListViewBook.SetObjects(context.Books.OrderByDescending(d => d.Id).Take(100));
                }
            };

            InitBook();
        }

        private void InitBook()
        {
            _dtpPublishDay.Format = DateTimePickerFormat.Custom;
            _dtpPublishDay.CustomFormat = "yyyy";
            _olvColumnDatePublisher.AspectToStringConverter = (o) =>
            {
                var date = Convert.ToDateTime(o);
                return date.ToString("yyyy");
            };

            if (_selectedBook != null)
            {
                _txtName.Text = _selectedBook.Name;
                _txtAuthor.Text = _selectedBook.Author;
                _dtpPublishDay.Value = _selectedBook.DatePublisher;
                _txtCountPage.Text = _selectedBook.CountPage.ToString();
                _txtTotalCount.Text = _selectedBook.TotalCount.ToString();
            }

            _btnAddBook.Click += (sender, args) =>
            {
                if (string.IsNullOrEmpty(_txtName.Text) || string.IsNullOrEmpty(_txtAuthor.Text) || string.IsNullOrEmpty(_txtCountPage.Text)|| string.IsNullOrEmpty(_txtTotalCount.Text))
                {
                    MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    using (var context = new BookContext())
                    {
                        _selectedBook = new Core.Book(_txtName.Text, _txtAuthor.Text, Convert.ToInt32(_txtCountPage.Text), _dtpPublishDay.Value, Convert.ToInt32(_txtTotalCount.Text));
                        context.Books.AddOrUpdate(_selectedBook);
                        context.SaveChanges();
                        _objectListViewBook.SetObjects(context.Books);
                        ResetBook();
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            };
            _btnUpdateBook.Click += (sender, args) =>
            {
                try
                {
                    using (var context = new BookContext())
                    {
                        var bookForUpdate = _objectListViewBook.SelectedObject as Core.Book;
                        if (bookForUpdate == null)
                        {
                            MessageBox.Show("Укажите книгу для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        bookForUpdate.Name = _txtName.Text;
                        bookForUpdate.Author = _txtAuthor.Text;
                        bookForUpdate.CountPage = Convert.ToInt32(_txtCountPage.Text);
                        bookForUpdate.DatePublisher = _dtpPublishDay.Value;
                        bookForUpdate.TotalCount = Convert.ToInt32(_txtTotalCount.Text);
                        context.Books.AddOrUpdate(bookForUpdate);
                        context.SaveChanges();
                        _objectListViewBook.SetObjects(context.Books);
                        ResetBook();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            };
            _btnDeleteBook.Click += (sender, args) =>
            {
                try
                {
                    using (var context = new BookContext())
                    {
                        var deleteBook = _objectListViewBook.SelectedObject as Core.Book;
                        if (deleteBook == null)
                        {
                            MessageBox.Show("Укажите книгу", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (MessageBox.Show($"Удалить книгу '{deleteBook.Name}' ?",
                                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            return;
                        }
                        deleteBook = context.Books.First(w => w.Id == deleteBook.Id);
                        context.Books.Remove(deleteBook);
                        context.SaveChanges();
                        _objectListViewBook.SetObjects(context.Books);
                        ResetBook();
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            };

            _objectListViewBook.SelectedIndexChanged += (sender, args) =>
            {
                Core.Book selectedBook = _objectListViewBook.SelectedObject as Core.Book;
                if (selectedBook == null) return;
                _txtName.Text = selectedBook.Name;
                _txtAuthor.Text = selectedBook.Author;
                _txtCountPage.Text = selectedBook.CountPage.ToString();
                _dtpPublishDay.Value = selectedBook.DatePublisher;
                _txtTotalCount.Text = selectedBook.TotalCount.ToString();
            };
        }

        private void ResetBook()
        {
            _txtName.Text = "";
            _txtAuthor.Text = "";
            _txtCountPage.Text = "";
            _dtpPublishDay.Value = DateTime.Now;
            _txtTotalCount.Text = "";
        }
    }
}
