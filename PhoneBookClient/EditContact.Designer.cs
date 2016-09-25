namespace PhoneBookClient
{
    partial class EditContact
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
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.infoMessage_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Enabled = false;
            this.save_btn.Location = new System.Drawing.Point(25, 90);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "OK";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(148, 90);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Отмена";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(112, 13);
            this.name_tb.MaxLength = 255;
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(248, 20);
            this.name_tb.TabIndex = 4;
            this.name_tb.TextChanged += new System.EventHandler(this.name_tb_TextChanged);
            // 
            // phone_tb
            // 
            this.phone_tb.Location = new System.Drawing.Point(112, 44);
            this.phone_tb.MaxLength = 20;
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(248, 20);
            this.phone_tb.TabIndex = 5;
            this.phone_tb.TextChanged += new System.EventHandler(this.phone_tb_TextChanged);
            // 
            // infoMessage_lbl
            // 
            this.infoMessage_lbl.AutoSize = true;
            this.infoMessage_lbl.Location = new System.Drawing.Point(25, 71);
            this.infoMessage_lbl.Name = "infoMessage_lbl";
            this.infoMessage_lbl.Size = new System.Drawing.Size(0, 13);
            this.infoMessage_lbl.TabIndex = 6;
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 131);
            this.Controls.Add(this.infoMessage_lbl);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditContact";
            this.Text = "Создание/редактирование контакта";
            this.Shown += new System.EventHandler(this.EditContact_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.Label infoMessage_lbl;
    }
}