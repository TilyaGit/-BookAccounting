namespace Book.Win
{
    partial class BooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._objectListViewBook = new BrightIdeasSoftware.ObjectListView();
            this._olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnAuthor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnCountPage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnDatePublisher = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnTotalCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnStayCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtTotalCount = new System.Windows.Forms.TextBox();
            this._btnUpdateBook = new System.Windows.Forms.Button();
            this._dtpPublishDay = new System.Windows.Forms.DateTimePicker();
            this._btnDeleteBook = new System.Windows.Forms.Button();
            this._btnAddBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtCountPage = new System.Windows.Forms.TextBox();
            this._txtAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 461);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._objectListViewBook);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить книгу";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _objectListViewBook
            // 
            this._objectListViewBook.AllColumns.Add(this._olvColumnName);
            this._objectListViewBook.AllColumns.Add(this._olvColumnAuthor);
            this._objectListViewBook.AllColumns.Add(this._olvColumnCountPage);
            this._objectListViewBook.AllColumns.Add(this._olvColumnDatePublisher);
            this._objectListViewBook.AllColumns.Add(this._olvColumnTotalCount);
            this._objectListViewBook.AllColumns.Add(this._olvColumnStayCount);
            this._objectListViewBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._olvColumnName,
            this._olvColumnAuthor,
            this._olvColumnCountPage,
            this._olvColumnDatePublisher,
            this._olvColumnTotalCount,
            this._olvColumnStayCount});
            this._objectListViewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this._objectListViewBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this._objectListViewBook.FullRowSelect = true;
            this._objectListViewBook.GridLines = true;
            this._objectListViewBook.Location = new System.Drawing.Point(305, 3);
            this._objectListViewBook.Name = "_objectListViewBook";
            this._objectListViewBook.ShowGroups = false;
            this._objectListViewBook.Size = new System.Drawing.Size(568, 429);
            this._objectListViewBook.SortGroupItemsByPrimaryColumn = false;
            this._objectListViewBook.TabIndex = 8;
            this._objectListViewBook.UseCompatibleStateImageBehavior = false;
            this._objectListViewBook.View = System.Windows.Forms.View.Details;
            // 
            // _olvColumnName
            // 
            this._olvColumnName.AspectName = "Name";
            this._olvColumnName.CellPadding = null;
            this._olvColumnName.Text = "Наименование";
            this._olvColumnName.Width = 124;
            // 
            // _olvColumnAuthor
            // 
            this._olvColumnAuthor.AspectName = "Author";
            this._olvColumnAuthor.CellPadding = null;
            this._olvColumnAuthor.Text = "Автор";
            this._olvColumnAuthor.Width = 79;
            // 
            // _olvColumnCountPage
            // 
            this._olvColumnCountPage.AspectName = "CountPage";
            this._olvColumnCountPage.CellPadding = null;
            this._olvColumnCountPage.Text = "Количество страниц";
            this._olvColumnCountPage.Width = 79;
            // 
            // _olvColumnDatePublisher
            // 
            this._olvColumnDatePublisher.AspectName = "DatePublisher";
            this._olvColumnDatePublisher.AspectToStringFormat = "";
            this._olvColumnDatePublisher.CellPadding = null;
            this._olvColumnDatePublisher.Text = "Год издания";
            this._olvColumnDatePublisher.Width = 87;
            // 
            // _olvColumnTotalCount
            // 
            this._olvColumnTotalCount.AspectName = "TotalCount";
            this._olvColumnTotalCount.CellPadding = null;
            this._olvColumnTotalCount.Text = "Количество книг";
            // 
            // _olvColumnStayCount
            // 
            this._olvColumnStayCount.AspectName = "StayCount";
            this._olvColumnStayCount.CellPadding = null;
            this._olvColumnStayCount.Text = "Оставшиеся книгу";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._txtTotalCount);
            this.groupBox1.Controls.Add(this._btnUpdateBook);
            this.groupBox1.Controls.Add(this._dtpPublishDay);
            this.groupBox1.Controls.Add(this._btnDeleteBook);
            this.groupBox1.Controls.Add(this._btnAddBook);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtCountPage);
            this.groupBox1.Controls.Add(this._txtAuthor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._txtName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 429);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Количество экземпляров книг";
            // 
            // _txtTotalCount
            // 
            this._txtTotalCount.Location = new System.Drawing.Point(31, 229);
            this._txtTotalCount.Name = "_txtTotalCount";
            this._txtTotalCount.Size = new System.Drawing.Size(234, 20);
            this._txtTotalCount.TabIndex = 7;
            // 
            // _btnUpdateBook
            // 
            this._btnUpdateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnUpdateBook.Location = new System.Drawing.Point(31, 305);
            this._btnUpdateBook.Name = "_btnUpdateBook";
            this._btnUpdateBook.Size = new System.Drawing.Size(234, 21);
            this._btnUpdateBook.TabIndex = 5;
            this._btnUpdateBook.Text = "Редактировать";
            this._btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // _dtpPublishDay
            // 
            this._dtpPublishDay.Location = new System.Drawing.Point(31, 175);
            this._dtpPublishDay.Name = "_dtpPublishDay";
            this._dtpPublishDay.Size = new System.Drawing.Size(234, 20);
            this._dtpPublishDay.TabIndex = 3;
            this._dtpPublishDay.Value = new System.DateTime(2019, 1, 26, 1, 56, 23, 0);
            // 
            // _btnDeleteBook
            // 
            this._btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDeleteBook.Location = new System.Drawing.Point(31, 341);
            this._btnDeleteBook.Name = "_btnDeleteBook";
            this._btnDeleteBook.Size = new System.Drawing.Size(234, 21);
            this._btnDeleteBook.TabIndex = 4;
            this._btnDeleteBook.Text = "Удалить";
            this._btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // _btnAddBook
            // 
            this._btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAddBook.Location = new System.Drawing.Point(31, 269);
            this._btnAddBook.Name = "_btnAddBook";
            this._btnAddBook.Size = new System.Drawing.Size(234, 21);
            this._btnAddBook.TabIndex = 4;
            this._btnAddBook.Text = "Добавить";
            this._btnAddBook.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Год издания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Количество страниц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор";
            // 
            // _txtCountPage
            // 
            this._txtCountPage.Location = new System.Drawing.Point(31, 125);
            this._txtCountPage.Name = "_txtCountPage";
            this._txtCountPage.Size = new System.Drawing.Size(234, 20);
            this._txtCountPage.TabIndex = 2;
            // 
            // _txtAuthor
            // 
            this._txtAuthor.Location = new System.Drawing.Point(31, 77);
            this._txtAuthor.Name = "_txtAuthor";
            this._txtAuthor.Size = new System.Drawing.Size(234, 20);
            this._txtAuthor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(31, 32);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(234, 20);
            this._txtName.TabIndex = 0;
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "BooksForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BrightIdeasSoftware.ObjectListView _objectListViewBook;
        private BrightIdeasSoftware.OLVColumn _olvColumnName;
        private BrightIdeasSoftware.OLVColumn _olvColumnAuthor;
        private BrightIdeasSoftware.OLVColumn _olvColumnCountPage;
        private BrightIdeasSoftware.OLVColumn _olvColumnDatePublisher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnDeleteBook;
        private System.Windows.Forms.Button _btnAddBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtCountPage;
        private System.Windows.Forms.TextBox _txtAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        protected System.Windows.Forms.DateTimePicker _dtpPublishDay;
        private System.Windows.Forms.Button _btnUpdateBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtTotalCount;
        private BrightIdeasSoftware.OLVColumn _olvColumnTotalCount;
        private BrightIdeasSoftware.OLVColumn _olvColumnStayCount;
    }
}