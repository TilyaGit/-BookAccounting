namespace Book.Win
{
    partial class ViewBooks
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
            this._objectListViewIssuedBooks = new BrightIdeasSoftware.ObjectListView();
            this._olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnAuthor = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnCountPage = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnDatePublisher = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnTotalCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnStayCount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._objectListViewFreeBooks = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewIssuedBooks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewFreeBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 461);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._objectListViewIssuedBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выданные книги";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // _objectListViewIssuedBooks
            // 
            this._objectListViewIssuedBooks.AllColumns.Add(this._olvColumnName);
            this._objectListViewIssuedBooks.AllColumns.Add(this._olvColumnAuthor);
            this._objectListViewIssuedBooks.AllColumns.Add(this._olvColumnCountPage);
            this._objectListViewIssuedBooks.AllColumns.Add(this._olvColumnDatePublisher);
            this._objectListViewIssuedBooks.AllColumns.Add(this._olvColumnTotalCount);
            this._objectListViewIssuedBooks.AllColumns.Add(this._olvColumnStayCount);
            this._objectListViewIssuedBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._olvColumnName,
            this._olvColumnAuthor,
            this._olvColumnCountPage,
            this._olvColumnDatePublisher,
            this._olvColumnTotalCount,
            this._olvColumnStayCount});
            this._objectListViewIssuedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this._objectListViewIssuedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this._objectListViewIssuedBooks.FullRowSelect = true;
            this._objectListViewIssuedBooks.GridLines = true;
            this._objectListViewIssuedBooks.Location = new System.Drawing.Point(3, 3);
            this._objectListViewIssuedBooks.Name = "_objectListViewIssuedBooks";
            this._objectListViewIssuedBooks.ShowGroups = false;
            this._objectListViewIssuedBooks.Size = new System.Drawing.Size(870, 429);
            this._objectListViewIssuedBooks.SortGroupItemsByPrimaryColumn = false;
            this._objectListViewIssuedBooks.TabIndex = 8;
            this._objectListViewIssuedBooks.UseCompatibleStateImageBehavior = false;
            this._objectListViewIssuedBooks.View = System.Windows.Forms.View.Details;
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
            this._olvColumnCountPage.Width = 119;
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
            this._olvColumnTotalCount.Width = 109;
            // 
            // _olvColumnStayCount
            // 
            this._olvColumnStayCount.AspectName = "StayCount";
            this._olvColumnStayCount.CellPadding = null;
            this._olvColumnStayCount.Text = "Оставшиеся книгу";
            this._olvColumnStayCount.Width = 108;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._objectListViewFreeBooks);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Свободные книги для выдачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _objectListViewFreeBooks
            // 
            this._objectListViewFreeBooks.AllColumns.Add(this.olvColumn1);
            this._objectListViewFreeBooks.AllColumns.Add(this.olvColumn2);
            this._objectListViewFreeBooks.AllColumns.Add(this.olvColumn3);
            this._objectListViewFreeBooks.AllColumns.Add(this.olvColumn4);
            this._objectListViewFreeBooks.AllColumns.Add(this.olvColumn5);
            this._objectListViewFreeBooks.AllColumns.Add(this.olvColumn6);
            this._objectListViewFreeBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this._objectListViewFreeBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this._objectListViewFreeBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this._objectListViewFreeBooks.FullRowSelect = true;
            this._objectListViewFreeBooks.GridLines = true;
            this._objectListViewFreeBooks.Location = new System.Drawing.Point(3, 3);
            this._objectListViewFreeBooks.Name = "_objectListViewFreeBooks";
            this._objectListViewFreeBooks.ShowGroups = false;
            this._objectListViewFreeBooks.Size = new System.Drawing.Size(684, 346);
            this._objectListViewFreeBooks.SortGroupItemsByPrimaryColumn = false;
            this._objectListViewFreeBooks.TabIndex = 9;
            this._objectListViewFreeBooks.UseCompatibleStateImageBehavior = false;
            this._objectListViewFreeBooks.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Name";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.Text = "Наименование";
            this.olvColumn1.Width = 124;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Author";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Автор";
            this.olvColumn2.Width = 79;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "CountPage";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.Text = "Количество страниц";
            this.olvColumn3.Width = 137;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "DatePublisher";
            this.olvColumn4.AspectToStringFormat = "";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.Text = "Год издания";
            this.olvColumn4.Width = 87;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "TotalCount";
            this.olvColumn5.CellPadding = null;
            this.olvColumn5.Text = "Количество книг";
            this.olvColumn5.Width = 92;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "StayCount";
            this.olvColumn6.CellPadding = null;
            this.olvColumn6.Text = "Оставшиеся книгу";
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "ViewBooks";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewIssuedBooks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewFreeBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BrightIdeasSoftware.ObjectListView _objectListViewIssuedBooks;
        private BrightIdeasSoftware.OLVColumn _olvColumnName;
        private BrightIdeasSoftware.OLVColumn _olvColumnAuthor;
        private BrightIdeasSoftware.OLVColumn _olvColumnCountPage;
        private BrightIdeasSoftware.OLVColumn _olvColumnDatePublisher;
        private BrightIdeasSoftware.OLVColumn _olvColumnTotalCount;
        private BrightIdeasSoftware.OLVColumn _olvColumnStayCount;
        private System.Windows.Forms.TabPage tabPage2;
        private BrightIdeasSoftware.ObjectListView _objectListViewFreeBooks;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
    }
}