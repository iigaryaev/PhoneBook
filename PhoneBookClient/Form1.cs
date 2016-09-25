using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.PrepareModel();


        }

        private ContactsSearcherForPage contactsSearcher;

        private PhoneBookManager phoneBookManager;

        private ContactsFilter currentContactsFilter = new ContactsFilter(5);

        private ContactViewModel currentRow = null;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
               senderGrid.Columns[e.ColumnIndex].Name == "ContactActions" &&
                e.RowIndex >= 0)
            {
                //contextMenuStrip1.
                this.currentRow = this.dataGridView1.Rows[e.RowIndex].DataBoundItem as ContactViewModel;
                contactActions_cms.Show(Cursor.Position);
            }
        }

        private void PrepareModel()
        {
            this.phoneBookManager = new PhoneBookManager();
            this.contactsSearcher = new ContactsSearcherForPage(this.currentContactsFilter, new Searcher());
        }

        private void searchContacts_Click(object sender, EventArgs e)
        {
            this.currentContactsFilter.CurrentPage = 0;
            this.currentContactsFilter.SearchFilter = this.searchFilter.Text;

            this.RefreshGrid();
        }

        public void RefreshGrid()
        {
            if (!string.IsNullOrEmpty(this.currentContactsFilter.SearchFilter))
            {
                this.dataGridView1.DataSource = this.contactsSearcher.CurrentPage();
                this.UpdatePageLabel();

                if(this.dataGridView1.RowCount == 0)
                {
                    this.infoLabel.Text = "Найдено 0 контактов";
                }
            }
        }

        private void searchFilter_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(((TextBox)sender).Text))
            {
                this.searchContacts.Enabled = true;
            }
            else
                this.searchContacts.Enabled = false;
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            var count = ((DataGridView)sender).RowCount;

            if(count == 0)
            {
                //this.infoLabel.Text = "Не найдено ни одного конаткта";
                this.nextPage_btn.Enabled = false;
                this.prevPage_btn.Enabled = false;
            }
            else
            {
                if(count == currentContactsFilter.PageSize)
                {
                    this.nextPage_btn.Enabled = true;
                }
            }
        }

        private void prevPage_btn_Click(object sender, EventArgs e)
        {
            if(this.currentContactsFilter.CurrentPage > 0)
            {
                this.currentContactsFilter.CurrentPage--;
                this.RefreshGrid();
            }

            if(this.currentContactsFilter.CurrentPage == 0)
            {
                this.prevPage_btn.Enabled = false;
            }
        }

        private void nextPage_btn_Click(object sender, EventArgs e)
        {
            this.currentContactsFilter.CurrentPage++;
            this.RefreshGrid();

            if(this.dataGridView1.RowCount == 0)
            {
                this.currentContactsFilter.CurrentPage--;
                this.infoLabel.Text = "Достигнута последняя страница";
                this.RefreshGrid();
            }

            if(this.currentContactsFilter.CurrentPage > 0)
            {
                this.prevPage_btn.Enabled = true;
            }
        }

        private void UpdatePageLabel()
        {
            this.page_lbl.Text = (this.currentContactsFilter.CurrentPage + 1).ToString();
        }

        private void deleteContact_menu_Click(object sender, EventArgs e)
        {
            this.phoneBookManager.Delete(this.currentRow.Id);
            this.RefreshGrid();
        }

        private void editContact_menu_Click(object sender, EventArgs e)
        {
            var editForm = new EditContact(this.currentRow, this);
            editForm.ShowDialog();
        }

        private void addContact_btn_Click(object sender, EventArgs e)
        {
            var editForm = new EditContact(this);
            editForm.ShowDialog();
        }
    }
}
