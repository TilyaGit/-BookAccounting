namespace Book.Win
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._objectListViewReaders = new BrightIdeasSoftware.ObjectListView();
            this._olvColumnSecondName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnFirstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnThirdName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._txtReaderSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewReaders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.читателиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.читателиToolStripMenuItem.Text = "Читатели";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // _objectListViewReaders
            // 
            this._objectListViewReaders.AllColumns.Add(this._olvColumnSecondName);
            this._objectListViewReaders.AllColumns.Add(this._olvColumnFirstName);
            this._objectListViewReaders.AllColumns.Add(this._olvColumnThirdName);
            this._objectListViewReaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._olvColumnSecondName,
            this._olvColumnFirstName,
            this._olvColumnThirdName});
            this._objectListViewReaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this._objectListViewReaders.FullRowSelect = true;
            this._objectListViewReaders.GridLines = true;
            this._objectListViewReaders.Location = new System.Drawing.Point(0, 77);
            this._objectListViewReaders.Name = "_objectListViewReaders";
            this._objectListViewReaders.ShowGroups = false;
            this._objectListViewReaders.Size = new System.Drawing.Size(884, 384);
            this._objectListViewReaders.TabIndex = 3;
            this._objectListViewReaders.UseCompatibleStateImageBehavior = false;
            this._objectListViewReaders.View = System.Windows.Forms.View.Details;
            // 
            // _olvColumnSecondName
            // 
            this._olvColumnSecondName.AspectName = "SecondName";
            this._olvColumnSecondName.CellPadding = null;
            this._olvColumnSecondName.DisplayIndex = 1;
            this._olvColumnSecondName.Text = "Фамилия";
            this._olvColumnSecondName.Width = 253;
            // 
            // _olvColumnFirstName
            // 
            this._olvColumnFirstName.AspectName = "FirstName";
            this._olvColumnFirstName.CellPadding = null;
            this._olvColumnFirstName.DisplayIndex = 0;
            this._olvColumnFirstName.Text = "Имя";
            this._olvColumnFirstName.Width = 233;
            // 
            // _olvColumnThirdName
            // 
            this._olvColumnThirdName.AspectName = "ThirdName";
            this._olvColumnThirdName.CellPadding = null;
            this._olvColumnThirdName.Text = "Отчество";
            this._olvColumnThirdName.Width = 252;
            // 
            // _txtReaderSearch
            // 
            this._txtReaderSearch.Location = new System.Drawing.Point(151, 17);
            this._txtReaderSearch.Name = "_txtReaderSearch";
            this._txtReaderSearch.Size = new System.Drawing.Size(517, 20);
            this._txtReaderSearch.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._txtReaderSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this._objectListViewReaders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewReaders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private BrightIdeasSoftware.ObjectListView _objectListViewReaders;
        private BrightIdeasSoftware.OLVColumn _olvColumnFirstName;
        private BrightIdeasSoftware.OLVColumn _olvColumnSecondName;
        private BrightIdeasSoftware.OLVColumn _olvColumnThirdName;
        private System.Windows.Forms.TextBox _txtReaderSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
    }
}