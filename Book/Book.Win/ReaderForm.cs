using Book.Core;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Migrations;


namespace Book.Win
{
    public partial class ReaderForm : Form
    {
        public ReaderForm()
        {
            InitializeComponent();

            Load += (sender, args) =>
            {
                using (var context = new BookContext())
                {
                    _objectListViewReader.SetObjects(context.Readers.OrderByDescending(f => f.Id).Take(100));
                }
            };

            InitReader();
        }

        private void InitReader()
        {
            _btnAddReader.Click += (sender, args) =>
            {
                if (string.IsNullOrEmpty(_txtFName.Text) || string.IsNullOrEmpty(_txtSName.Text) || string.IsNullOrEmpty(_txtTName.Text) || string.IsNullOrEmpty(_txtAdres.Text) || string.IsNullOrEmpty(_txtTicketNumber.Text) || string.IsNullOrEmpty(_txtPhone.Text))
                {
                    MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (_dtpBirthDay.Value > new DateTime(2020, 1, 1))
                {
                    MessageBox.Show("Неправильно указан день рождения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                    using (var context = new BookContext())
                    {
                        var selectedReader = new Reader(_txtFName.Text, _txtSName.Text, _txtTName.Text, _txtAdres.Text, Convert.ToInt32(_txtTicketNumber.Text), _txtPhone.Text, _dtpBirthDay.Value);
                        context.Readers.AddOrUpdate(selectedReader);
                        context.SaveChanges();
                        _objectListViewReader.SetObjects(context.Readers);
                        ResetReader();

                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            };
            _btnUpdateReader.Click += (sender, args) =>
            {
                try
                {
                    using (var context = new BookContext())
                    {
                        var readerForUpdate = _objectListViewReader.SelectedObject as Reader;
                        if (readerForUpdate == null)
                        {
                            MessageBox.Show("Укажите читателя для редактирования", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        readerForUpdate.SecondName = _txtSName.Text;
                        readerForUpdate.FirstName = _txtFName.Text;
                        readerForUpdate.ThirdName = _txtTName.Text;
                        readerForUpdate.Address = _txtAdres.Text;
                        readerForUpdate.TicketNumber = Convert.ToInt32(_txtTicketNumber.Text);
                        readerForUpdate.PhoneNumber = _txtPhone.Text;
                        readerForUpdate.BirthDay = _dtpBirthDay.Value;
                        context.Readers.AddOrUpdate(readerForUpdate);
                        context.SaveChanges();
                        _objectListViewReader.SetObjects(context.Readers);
                        ResetReader();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            };

            _btnDeleteReader.Click += (sender, args) =>
            {

                try
                {
                    using (var context = new BookContext())
                    {
                        var deleteReader = _objectListViewReader.SelectedObject as Reader;
                        if (deleteReader == null)
                        {
                            MessageBox.Show("Укажите читателя", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (MessageBox.Show($"Удалить книгу '{deleteReader.SecondName}','{deleteReader.FirstName}','{deleteReader.ThirdName}' ?",
                                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            return;
                        }
                        deleteReader = context.Readers.First(r => r.Id == deleteReader.Id);
                        context.Readers.Remove(deleteReader);
                        context.SaveChanges();
                        _objectListViewReader.SetObjects(context.Readers);
                        ResetReader();
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            };

            _objectListViewReader.SelectedIndexChanged += (sender, args) =>
            {
                Reader selectedReder = _objectListViewReader.SelectedObject as Reader;
                if (selectedReder == null) return;
                _txtFName.Text = selectedReder.FirstName;
                _txtSName.Text = selectedReder.SecondName;
                _txtTName.Text = selectedReder.ThirdName;
                _txtAdres.Text = selectedReder.Address;
                _txtTicketNumber.Text = Convert.ToString(selectedReder.TicketNumber);
                _txtPhone.Text = selectedReder.PhoneNumber;
                _dtpBirthDay.Value = selectedReder.BirthDay;
            };

        }
        private void ResetReader()
        {
            _txtFName.Text = "";
            _txtSName.Text = "";
            _txtTName.Text = "";
            _txtAdres.Text = "";
            _txtTicketNumber.Text = "";
            _txtPhone.Text = "";
            _dtpBirthDay.Value = DateTime.Now;
        }
    }
}
