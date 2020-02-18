namespace Book.Win
{
    partial class GiveBook
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
            this._txtBookSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnGiveBook = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this._objectListViewBooks = new BrightIdeasSoftware.ObjectListView();
            this._olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnAuthor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnCountPage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnDatePublisher = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnTotalCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnStayCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtBookSearch
            // 
            this._txtBookSearch.Location = new System.Drawing.Point(71, 15);
            this._txtBookSearch.Name = "_txtBookSearch";
            this._txtBookSearch.Size = new System.Drawing.Size(584, 20);
            this._txtBookSearch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtBookSearch);
            this.groupBox1.Controls.Add(this._btnGiveBook);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // _btnGiveBook
            // 
            this._btnGiveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnGiveBook.Location = new System.Drawing.Point(682, 13);
            this._btnGiveBook.Name = "_btnGiveBook";
            this._btnGiveBook.Size = new System.Drawing.Size(157, 23);
            this._btnGiveBook.TabIndex = 4;
            this._btnGiveBook.Text = "Выдать книгу";
            this._btnGiveBook.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 414);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._objectListViewBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выдать книгу";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _objectListViewBooks
            // 
            this._objectListViewBooks.AllColumns.Add(this._olvColumnName);
            this._objectListViewBooks.AllColumns.Add(this._olvColumnAuthor);
            this._objectListViewBooks.AllColumns.Add(this._olvColumnCountPage);
            this._objectListViewBooks.AllColumns.Add(this._olvColumnDatePublisher);
            this._objectListViewBooks.AllColumns.Add(this._olvColumnTotalCount);
            this._objectListViewBooks.AllColumns.Add(this._olvColumnStayCount);
            this._objectListViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._olvColumnName,
            this._olvColumnAuthor,
            this._olvColumnCountPage,
            this._olvColumnDatePublisher,
            this._olvColumnTotalCount,
            this._olvColumnStayCount});
            this._objectListViewBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this._objectListViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this._objectListViewBooks.FullRowSelect = true;
            this._objectListViewBooks.GridLines = true;
            this._objectListViewBooks.Location = new System.Drawing.Point(3, 3);
            this._objectListViewBooks.Name = "_objectListViewBooks";
            this._objectListViewBooks.ShowGroups = false;
            this._objectListViewBooks.Size = new System.Drawing.Size(870, 382);
            this._objectListViewBooks.SortGroupItemsByPrimaryColumn = false;
            this._objectListViewBooks.TabIndex = 8;
            this._objectListViewBooks.UseCompatibleStateImageBehavior = false;
            this._objectListViewBooks.View = System.Windows.Forms.View.Details;
            // 
            // _olvColumnName
            // 
            this._olvColumnName.AspectName = "Name";
            this._olvColumnName.CellPadding = null;
            this._olvColumnName.Text = "Наименование";
            this._olvColumnName.Width = 168;
            // 
            // _olvColumnAuthor
            // 
            this._olvColumnAuthor.AspectName = "Author";
            this._olvColumnAuthor.CellPadding = null;
            this._olvColumnAuthor.Text = "Автор";
            this._olvColumnAuthor.Width = 150;
            // 
            // _olvColumnCountPage
            // 
            this._olvColumnCountPage.AspectName = "CountPage";
            this._olvColumnCountPage.CellPadding = null;
            this._olvColumnCountPage.Text = "Количество страниц";
            this._olvColumnCountPage.Width = 138;
            // 
            // _olvColumnDatePublisher
            // 
            this._olvColumnDatePublisher.AspectName = "DatePublisher";
            this._olvColumnDatePublisher.CellPadding = null;
            this._olvColumnDatePublisher.Text = "Год издания";
            this._olvColumnDatePublisher.Width = 112;
            // 
            // _olvColumnTotalCount
            // 
            this._olvColumnTotalCount.AspectName = "TotalCount";
            this._olvColumnTotalCount.CellPadding = null;
            this._olvColumnTotalCount.IsEditable = false;
            this._olvColumnTotalCount.Text = "Кол-о экземпляров книг";
            this._olvColumnTotalCount.Width = 157;
            // 
            // _olvColumnStayCount
            // 
            this._olvColumnStayCount.AspectName = "StayCount";
            this._olvColumnStayCount.CellPadding = null;
            this._olvColumnStayCount.Text = "Кол-о оставшихся книг";
            this._olvColumnStayCount.Width = 133;
            // 
            // GiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GiveBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _txtBookSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BrightIdeasSoftware.ObjectListView _objectListViewBooks;
        private BrightIdeasSoftware.OLVColumn _olvColumnName;
        private BrightIdeasSoftware.OLVColumn _olvColumnAuthor;
        private BrightIdeasSoftware.OLVColumn _olvColumnCountPage;
        private BrightIdeasSoftware.OLVColumn _olvColumnDatePublisher;
        private System.Windows.Forms.Button _btnGiveBook;
        private BrightIdeasSoftware.OLVColumn _olvColumnTotalCount;
        private BrightIdeasSoftware.OLVColumn _olvColumnStayCount;
    }
}