namespace PhoneBookApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.textPhonenumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnCloseSearch = new System.Windows.Forms.Button();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.txtSearchNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panelList = new System.Windows.Forms.Panel();
            this.btnCloseList = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.txtDeleteNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnShowAddPanel = new System.Windows.Forms.Button();
            this.btnShowDeletePanel = new System.Windows.Forms.Button();
            this.btnShowSearchPanel = new System.Windows.Forms.Button();
            this.btnShowListPanel = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.btnAddContact);
            this.panelAdd.Controls.Add(this.textPhonenumber);
            this.panelAdd.Controls.Add(this.txtSurname);
            this.panelAdd.Controls.Add(this.txtName);
            this.panelAdd.Controls.Add(this.txtNo);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAdd.Location = new System.Drawing.Point(155, 44);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(260, 190);
            this.panelAdd.TabIndex = 0;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.Location = new System.Drawing.Point(189, 135);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(57, 30);
            this.btnAddContact.TabIndex = 8;
            this.btnAddContact.Text = "Add";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // textPhonenumber
            // 
            this.textPhonenumber.Location = new System.Drawing.Point(112, 105);
            this.textPhonenumber.Name = "textPhonenumber";
            this.textPhonenumber.Size = new System.Drawing.Size(131, 22);
            this.textPhonenumber.TabIndex = 9;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(112, 78);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(131, 22);
            this.txtSurname.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(131, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(112, 19);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(131, 22);
            this.txtNo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phonenumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnCloseSearch);
            this.panelSearch.Controls.Add(this.btnSearchContact);
            this.panelSearch.Controls.Add(this.txtSearchNo);
            this.panelSearch.Controls.Add(this.label13);
            this.panelSearch.Controls.Add(this.label12);
            this.panelSearch.Controls.Add(this.label11);
            this.panelSearch.Controls.Add(this.label10);
            this.panelSearch.Controls.Add(this.label9);
            this.panelSearch.Controls.Add(this.listBox2);
            this.panelSearch.Location = new System.Drawing.Point(459, 44);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(245, 203);
            this.panelSearch.TabIndex = 1;
            // 
            // btnCloseSearch
            // 
            this.btnCloseSearch.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSearch.Location = new System.Drawing.Point(148, 173);
            this.btnCloseSearch.Name = "btnCloseSearch";
            this.btnCloseSearch.Size = new System.Drawing.Size(57, 30);
            this.btnCloseSearch.TabIndex = 13;
            this.btnCloseSearch.Text = "Close";
            this.btnCloseSearch.UseVisualStyleBackColor = true;
            this.btnCloseSearch.Click += new System.EventHandler(this.btnCloseSearch_Click);
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchContact.Location = new System.Drawing.Point(74, 173);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(57, 30);
            this.btnSearchContact.TabIndex = 12;
            this.btnSearchContact.Text = "Search";
            this.btnSearchContact.UseVisualStyleBackColor = true;
            this.btnSearchContact.Click += new System.EventHandler(this.btnSearchContact_Click);
            // 
            // txtSearchNo
            // 
            this.txtSearchNo.Location = new System.Drawing.Point(74, 140);
            this.txtSearchNo.Name = "txtSearchNo";
            this.txtSearchNo.Size = new System.Drawing.Size(131, 22);
            this.txtSearchNo.TabIndex = 10;
            this.txtSearchNo.TextChanged += new System.EventHandler(this.txtSearchNo_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Search NO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(140, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Phonenumber";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Surname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "NO";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(6, 26);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 100);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.btnCloseList);
            this.panelList.Controls.Add(this.label8);
            this.panelList.Controls.Add(this.label7);
            this.panelList.Controls.Add(this.label5);
            this.panelList.Controls.Add(this.label6);
            this.panelList.Controls.Add(this.listBox1);
            this.panelList.Location = new System.Drawing.Point(155, 253);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(227, 147);
            this.panelList.TabIndex = 2;
            // 
            // btnCloseList
            // 
            this.btnCloseList.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseList.Location = new System.Drawing.Point(167, 114);
            this.btnCloseList.Name = "btnCloseList";
            this.btnCloseList.Size = new System.Drawing.Size(57, 30);
            this.btnCloseList.TabIndex = 14;
            this.btnCloseList.Text = "Close";
            this.btnCloseList.UseVisualStyleBackColor = true;
            this.btnCloseList.Click += new System.EventHandler(this.btnCloseList_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Phonenumber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "NO";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 84);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.btnDeleteContact);
            this.panelDelete.Controls.Add(this.txtDeleteNo);
            this.panelDelete.Controls.Add(this.label14);
            this.panelDelete.Location = new System.Drawing.Point(459, 253);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(245, 169);
            this.panelDelete.TabIndex = 3;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Font = new System.Drawing.Font("Lucida Bright", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.Location = new System.Drawing.Point(181, 73);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(57, 30);
            this.btnDeleteContact.TabIndex = 10;
            this.btnDeleteContact.Text = "Delete";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // txtDeleteNo
            // 
            this.txtDeleteNo.Location = new System.Drawing.Point(44, 73);
            this.txtDeleteNo.Name = "txtDeleteNo";
            this.txtDeleteNo.Size = new System.Drawing.Size(131, 22);
            this.txtDeleteNo.TabIndex = 11;
            this.txtDeleteNo.TextChanged += new System.EventHandler(this.txtDeleteNo_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "NO";
            // 
            // btnShowAddPanel
            // 
            this.btnShowAddPanel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAddPanel.Location = new System.Drawing.Point(27, 97);
            this.btnShowAddPanel.Name = "btnShowAddPanel";
            this.btnShowAddPanel.Size = new System.Drawing.Size(101, 40);
            this.btnShowAddPanel.TabIndex = 4;
            this.btnShowAddPanel.Text = "ADD";
            this.btnShowAddPanel.UseVisualStyleBackColor = true;
            this.btnShowAddPanel.Click += new System.EventHandler(this.btnShowAddPanel_Click);
            // 
            // btnShowDeletePanel
            // 
            this.btnShowDeletePanel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDeletePanel.Location = new System.Drawing.Point(27, 176);
            this.btnShowDeletePanel.Name = "btnShowDeletePanel";
            this.btnShowDeletePanel.Size = new System.Drawing.Size(101, 40);
            this.btnShowDeletePanel.TabIndex = 5;
            this.btnShowDeletePanel.Text = "DELETE";
            this.btnShowDeletePanel.UseVisualStyleBackColor = true;
            this.btnShowDeletePanel.Click += new System.EventHandler(this.btnShowDeletePanel_Click);
            // 
            // btnShowSearchPanel
            // 
            this.btnShowSearchPanel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSearchPanel.Location = new System.Drawing.Point(27, 248);
            this.btnShowSearchPanel.Name = "btnShowSearchPanel";
            this.btnShowSearchPanel.Size = new System.Drawing.Size(101, 40);
            this.btnShowSearchPanel.TabIndex = 6;
            this.btnShowSearchPanel.Text = "SEARCH";
            this.btnShowSearchPanel.UseVisualStyleBackColor = true;
            this.btnShowSearchPanel.Click += new System.EventHandler(this.btnShowSearchPanel_Click);
            // 
            // btnShowListPanel
            // 
            this.btnShowListPanel.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowListPanel.Location = new System.Drawing.Point(27, 326);
            this.btnShowListPanel.Name = "btnShowListPanel";
            this.btnShowListPanel.Size = new System.Drawing.Size(101, 40);
            this.btnShowListPanel.TabIndex = 7;
            this.btnShowListPanel.Text = "LIST";
            this.btnShowListPanel.UseVisualStyleBackColor = true;
            this.btnShowListPanel.Click += new System.EventHandler(this.btnShowListPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 472);
            this.Controls.Add(this.btnShowListPanel);
            this.Controls.Add(this.btnShowSearchPanel);
            this.Controls.Add(this.btnShowDeletePanel);
            this.Controls.Add(this.btnShowAddPanel);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnShowAddPanel;
        private System.Windows.Forms.Button btnShowDeletePanel;
        private System.Windows.Forms.TextBox textPhonenumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtSearchNo;
        private System.Windows.Forms.TextBox txtDeleteNo;
        private System.Windows.Forms.Button btnShowSearchPanel;
        private System.Windows.Forms.Button btnShowListPanel;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnCloseSearch;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnCloseList;
        private System.Windows.Forms.Panel panelAdd;
    }
}

