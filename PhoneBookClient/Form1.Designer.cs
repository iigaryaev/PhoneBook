namespace PhoneBookClient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactActions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contactActions_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteContact_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.editContact_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFilter = new System.Windows.Forms.TextBox();
            this.searchContacts = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.prevPage_btn = new System.Windows.Forms.Button();
            this.nextPage_btn = new System.Windows.Forms.Button();
            this.page_lbl = new System.Windows.Forms.Label();
            this.addContact_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contactActions_cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactId,
            this.ContactName,
            this.ContactPhone,
            this.ContactActions});
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(859, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "Id";
            this.ContactId.HeaderText = "ContactId";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            this.ContactId.Visible = false;
            // 
            // ContactName
            // 
            this.ContactName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContactName.DataPropertyName = "Name";
            this.ContactName.HeaderText = "Имя";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            // 
            // ContactPhone
            // 
            this.ContactPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContactPhone.DataPropertyName = "Phone";
            this.ContactPhone.HeaderText = "Телефон";
            this.ContactPhone.Name = "ContactPhone";
            this.ContactPhone.ReadOnly = true;
            // 
            // ContactActions
            // 
            this.ContactActions.HeaderText = "Действия";
            this.ContactActions.Name = "ContactActions";
            this.ContactActions.ReadOnly = true;
            this.ContactActions.Text = "Действия";
            this.ContactActions.UseColumnTextForButtonValue = true;
            this.ContactActions.Width = 60;
            // 
            // contactActions_cms
            // 
            this.contactActions_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteContact_menu,
            this.editContact_menu});
            this.contactActions_cms.Name = "contextMenuStrip1";
            this.contactActions_cms.Size = new System.Drawing.Size(155, 48);
            // 
            // deleteContact_menu
            // 
            this.deleteContact_menu.Name = "deleteContact_menu";
            this.deleteContact_menu.Size = new System.Drawing.Size(154, 22);
            this.deleteContact_menu.Text = "Удалить";
            this.deleteContact_menu.Click += new System.EventHandler(this.deleteContact_menu_Click);
            // 
            // editContact_menu
            // 
            this.editContact_menu.Name = "editContact_menu";
            this.editContact_menu.Size = new System.Drawing.Size(154, 22);
            this.editContact_menu.Text = "Редактировать";
            this.editContact_menu.Click += new System.EventHandler(this.editContact_menu_Click);
            // 
            // searchFilter
            // 
            this.searchFilter.Location = new System.Drawing.Point(12, 39);
            this.searchFilter.MaxLength = 255;
            this.searchFilter.Name = "searchFilter";
            this.searchFilter.Size = new System.Drawing.Size(206, 20);
            this.searchFilter.TabIndex = 1;
            this.searchFilter.Text = "введите имя контакта для поиска";
            this.searchFilter.TextChanged += new System.EventHandler(this.searchFilter_TextChanged);
            // 
            // searchContacts
            // 
            this.searchContacts.Enabled = false;
            this.searchContacts.Location = new System.Drawing.Point(224, 37);
            this.searchContacts.Name = "searchContacts";
            this.searchContacts.Size = new System.Drawing.Size(75, 23);
            this.searchContacts.TabIndex = 2;
            this.searchContacts.Text = "Найти";
            this.searchContacts.UseVisualStyleBackColor = true;
            this.searchContacts.Click += new System.EventHandler(this.searchContacts_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(13, 78);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 4;
            // 
            // prevPage_btn
            // 
            this.prevPage_btn.Enabled = false;
            this.prevPage_btn.Location = new System.Drawing.Point(780, 67);
            this.prevPage_btn.Name = "prevPage_btn";
            this.prevPage_btn.Size = new System.Drawing.Size(31, 23);
            this.prevPage_btn.TabIndex = 5;
            this.prevPage_btn.Text = "<";
            this.prevPage_btn.UseVisualStyleBackColor = true;
            this.prevPage_btn.Click += new System.EventHandler(this.prevPage_btn_Click);
            // 
            // nextPage_btn
            // 
            this.nextPage_btn.Enabled = false;
            this.nextPage_btn.Location = new System.Drawing.Point(840, 67);
            this.nextPage_btn.Name = "nextPage_btn";
            this.nextPage_btn.Size = new System.Drawing.Size(31, 23);
            this.nextPage_btn.TabIndex = 6;
            this.nextPage_btn.Text = ">";
            this.nextPage_btn.UseVisualStyleBackColor = true;
            this.nextPage_btn.Click += new System.EventHandler(this.nextPage_btn_Click);
            // 
            // page_lbl
            // 
            this.page_lbl.AutoSize = true;
            this.page_lbl.Location = new System.Drawing.Point(817, 72);
            this.page_lbl.Name = "page_lbl";
            this.page_lbl.Size = new System.Drawing.Size(13, 13);
            this.page_lbl.TabIndex = 7;
            this.page_lbl.Text = "1";
            // 
            // addContact_btn
            // 
            this.addContact_btn.Location = new System.Drawing.Point(368, 36);
            this.addContact_btn.Name = "addContact_btn";
            this.addContact_btn.Size = new System.Drawing.Size(111, 23);
            this.addContact_btn.TabIndex = 8;
            this.addContact_btn.Text = "Создать конаткт";
            this.addContact_btn.UseVisualStyleBackColor = true;
            this.addContact_btn.Click += new System.EventHandler(this.addContact_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 412);
            this.Controls.Add(this.addContact_btn);
            this.Controls.Add(this.page_lbl);
            this.Controls.Add(this.nextPage_btn);
            this.Controls.Add(this.prevPage_btn);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.searchContacts);
            this.Controls.Add(this.searchFilter);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Телефонный справочник";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contactActions_cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contactActions_cms;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPhone;
        private System.Windows.Forms.DataGridViewButtonColumn ContactActions;
        private System.Windows.Forms.TextBox searchFilter;
        private System.Windows.Forms.Button searchContacts;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button prevPage_btn;
        private System.Windows.Forms.Button nextPage_btn;
        private System.Windows.Forms.Label page_lbl;
        private System.Windows.Forms.ToolStripMenuItem deleteContact_menu;
        private System.Windows.Forms.ToolStripMenuItem editContact_menu;
        private System.Windows.Forms.Button addContact_btn;
    }
}

