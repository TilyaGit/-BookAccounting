namespace Book.Win
{
    partial class ReaderForm
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this._objectListViewReader = new BrightIdeasSoftware.ObjectListView();
            this._olvColumnFName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnSName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnTName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnAdres = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnTicketNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnBirthDay = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._olvColumnPhoneNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._btnUpdateReader = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this._txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._txtSName = new System.Windows.Forms.TextBox();
            this._dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this._btnDeleteReader = new System.Windows.Forms.Button();
            this._btnAddReader = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this._txtTicketNumber = new System.Windows.Forms.TextBox();
            this._txtTName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this._txtFName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewReader)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 461);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this._objectListViewReader);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 435);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Добавить читателей";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // _objectListViewReader
            // 
            this._objectListViewReader.AllColumns.Add(this._olvColumnFName);
            this._objectListViewReader.AllColumns.Add(this._olvColumnSName);
            this._objectListViewReader.AllColumns.Add(this._olvColumnTName);
            this._objectListViewReader.AllColumns.Add(this._olvColumnAdres);
            this._objectListViewReader.AllColumns.Add(this._olvColumnTicketNumber);
            this._objectListViewReader.AllColumns.Add(this._olvColumnBirthDay);
            this._objectListViewReader.AllColumns.Add(this._olvColumnPhoneNumber);
            this._objectListViewReader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._olvColumnFName,
            this._olvColumnSName,
            this._olvColumnTName,
            this._olvColumnAdres,
            this._olvColumnTicketNumber,
            this._olvColumnBirthDay,
            this._olvColumnPhoneNumber});
            this._objectListViewReader.Cursor = System.Windows.Forms.Cursors.Hand;
            this._objectListViewReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this._objectListViewReader.FullRowSelect = true;
            this._objectListViewReader.GridLines = true;
            this._objectListViewReader.Location = new System.Drawing.Point(317, 3);
            this._objectListViewReader.Name = "_objectListViewReader";
            this._objectListViewReader.ShowGroups = false;
            this._objectListViewReader.Size = new System.Drawing.Size(556, 429);
            this._objectListViewReader.SortGroupItemsByPrimaryColumn = false;
            this._objectListViewReader.TabIndex = 9;
            this._objectListViewReader.UseCompatibleStateImageBehavior = false;
            this._objectListViewReader.View = System.Windows.Forms.View.Details;
            // 
            // _olvColumnFName
            // 
            this._olvColumnFName.AspectName = "FirstName ";
            this._olvColumnFName.CellPadding = null;
            this._olvColumnFName.Text = "Фамилия";
            this._olvColumnFName.Width = 80;
            // 
            // _olvColumnSName
            // 
            this._olvColumnSName.AspectName = "SecondName";
            this._olvColumnSName.CellPadding = null;
            this._olvColumnSName.Text = "Имя";
            this._olvColumnSName.Width = 72;
            // 
            // _olvColumnTName
            // 
            this._olvColumnTName.AspectName = "ThirdName ";
            this._olvColumnTName.CellPadding = null;
            this._olvColumnTName.Text = "Отчество";
            this._olvColumnTName.Width = 77;
            // 
            // _olvColumnAdres
            // 
            this._olvColumnAdres.AspectName = "Adres";
            this._olvColumnAdres.CellPadding = null;
            this._olvColumnAdres.Text = "Адрес";
            this._olvColumnAdres.Width = 70;
            // 
            // _olvColumnTicketNumber
            // 
            this._olvColumnTicketNumber.AspectName = "TicketNumber";
            this._olvColumnTicketNumber.CellPadding = null;
            this._olvColumnTicketNumber.Text = "Номер билета";
            this._olvColumnTicketNumber.Width = 89;
            // 
            // _olvColumnBirthDay
            // 
            this._olvColumnBirthDay.AspectName = "BirthDay";
            this._olvColumnBirthDay.CellPadding = null;
            this._olvColumnBirthDay.Text = "Дата рождения";
            this._olvColumnBirthDay.Width = 93;
            // 
            // _olvColumnPhoneNumber
            // 
            this._olvColumnPhoneNumber.AspectName = "PhoneNumber";
            this._olvColumnPhoneNumber.CellPadding = null;
            this._olvColumnPhoneNumber.Text = "Телефон";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._btnUpdateReader);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this._txtPhone);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this._txtAdres);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this._txtSName);
            this.groupBox5.Controls.Add(this._dtpBirthDay);
            this.groupBox5.Controls.Add(this._btnDeleteReader);
            this.groupBox5.Controls.Add(this._btnAddReader);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this._txtTicketNumber);
            this.groupBox5.Controls.Add(this._txtTName);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this._txtFName);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 429);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // _btnUpdateReader
            // 
            this._btnUpdateReader.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnUpdateReader.Location = new System.Drawing.Point(31, 350);
            this._btnUpdateReader.Name = "_btnUpdateReader";
            this._btnUpdateReader.Size = new System.Drawing.Size(234, 24);
            this._btnUpdateReader.TabIndex = 11;
            this._btnUpdateReader.Text = "Редактировать";
            this._btnUpdateReader.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Телефон";
            // 
            // _txtPhone
            // 
            this._txtPhone.Location = new System.Drawing.Point(31, 235);
            this._txtPhone.Name = "_txtPhone";
            this._txtPhone.Size = new System.Drawing.Size(234, 20);
            this._txtPhone.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Адрес";
            // 
            // _txtAdres
            // 
            this._txtAdres.Location = new System.Drawing.Point(31, 155);
            this._txtAdres.Name = "_txtAdres";
            this._txtAdres.Size = new System.Drawing.Size(234, 20);
            this._txtAdres.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Фамилия";
            // 
            // _txtSName
            // 
            this._txtSName.Location = new System.Drawing.Point(31, 38);
            this._txtSName.Name = "_txtSName";
            this._txtSName.Size = new System.Drawing.Size(234, 20);
            this._txtSName.TabIndex = 5;
            // 
            // _dtpBirthDay
            // 
            this._dtpBirthDay.Location = new System.Drawing.Point(31, 278);
            this._dtpBirthDay.Name = "_dtpBirthDay";
            this._dtpBirthDay.Size = new System.Drawing.Size(234, 20);
            this._dtpBirthDay.TabIndex = 3;
            // 
            // _btnDeleteReader
            // 
            this._btnDeleteReader.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnDeleteReader.Location = new System.Drawing.Point(31, 380);
            this._btnDeleteReader.Name = "_btnDeleteReader";
            this._btnDeleteReader.Size = new System.Drawing.Size(234, 24);
            this._btnDeleteReader.TabIndex = 4;
            this._btnDeleteReader.Text = "Удалить";
            this._btnDeleteReader.UseVisualStyleBackColor = true;
            // 
            // _btnAddReader
            // 
            this._btnAddReader.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnAddReader.Location = new System.Drawing.Point(31, 316);
            this._btnAddReader.Name = "_btnAddReader";
            this._btnAddReader.Size = new System.Drawing.Size(234, 24);
            this._btnAddReader.TabIndex = 4;
            this._btnAddReader.Text = "Добавить";
            this._btnAddReader.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(99, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Дата рождения";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(104, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Номер билета";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(114, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Отчество";
            // 
            // _txtTicketNumber
            // 
            this._txtTicketNumber.Location = new System.Drawing.Point(31, 196);
            this._txtTicketNumber.Name = "_txtTicketNumber";
            this._txtTicketNumber.Size = new System.Drawing.Size(234, 20);
            this._txtTicketNumber.TabIndex = 2;
            // 
            // _txtTName
            // 
            this._txtTName.Location = new System.Drawing.Point(31, 116);
            this._txtTName.Name = "_txtTName";
            this._txtTName.Size = new System.Drawing.Size(234, 20);
            this._txtTName.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(122, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Имя";
            // 
            // _txtFName
            // 
            this._txtFName.Location = new System.Drawing.Point(31, 77);
            this._txtFName.Name = "_txtFName";
            this._txtFName.Size = new System.Drawing.Size(234, 20);
            this._txtFName.TabIndex = 0;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReaderForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._objectListViewReader)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private BrightIdeasSoftware.ObjectListView _objectListViewReader;
        private BrightIdeasSoftware.OLVColumn _olvColumnFName;
        private BrightIdeasSoftware.OLVColumn _olvColumnSName;
        private BrightIdeasSoftware.OLVColumn _olvColumnTName;
        private BrightIdeasSoftware.OLVColumn _olvColumnAdres;
        private BrightIdeasSoftware.OLVColumn _olvColumnTicketNumber;
        private BrightIdeasSoftware.OLVColumn _olvColumnBirthDay;
        private BrightIdeasSoftware.OLVColumn _olvColumnPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtSName;
        private System.Windows.Forms.DateTimePicker _dtpBirthDay;
        private System.Windows.Forms.Button _btnDeleteReader;
        private System.Windows.Forms.Button _btnAddReader;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox _txtTicketNumber;
        private System.Windows.Forms.TextBox _txtTName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox _txtFName;
        private System.Windows.Forms.Button _btnUpdateReader;
    }
}