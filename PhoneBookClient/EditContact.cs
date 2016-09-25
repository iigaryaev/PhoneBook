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
    public partial class EditContact : Form
    {
        private int? contactId;

        private PhoneBookManager contactManager = new PhoneBookManager();

        private Form1 parentForm;

        public EditContact(Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        public EditContact(ContactViewModel contact, Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            this.contactId = contact.Id;
            this.name_tb.Text = contact.Name;
            this.phone_tb.Text = contact.Phone;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.name_tb.Text))
            {
                this.infoMessage_lbl.Text = "Поле 'Имя' обязательно для заполнения";
                return;
            }

            if (string.IsNullOrEmpty(this.phone_tb.Text))
            {
                this.infoMessage_lbl.Text = "Поле 'Телефон' обязательно для заполнения";
                return;
            }

            if(this.contactId.HasValue)
            {
                this.contactManager.Update(new Contact(this.name_tb.Text, this.phone_tb.Text) { Id = this.contactId.Value });
            }
            else
            {
                this.contactManager.AddIfNotExists(this.name_tb.Text, this.phone_tb.Text);
            }

            this.parentForm.RefreshGrid();
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditContact_Shown(object sender, EventArgs e)
        {
            this.IsSavingAvailable();
        }

        private void name_tb_TextChanged(object sender, EventArgs e)
        {
            this.IsSavingAvailable();
        }

        private void phone_tb_TextChanged(object sender, EventArgs e)
        {
            this.IsSavingAvailable();
        }

        private void IsSavingAvailable()
        {
            if (!string.IsNullOrEmpty(this.name_tb.Text)
                && !string.IsNullOrEmpty(this.phone_tb.Text))
            {
                this.save_btn.Enabled = true;
            }
        }
    }
}
