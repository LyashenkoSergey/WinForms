namespace DZ24._12._23_ListBox
{
    partial class Anketa
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Registration = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_LoadInfo = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button_SaveInfoTXT = new System.Windows.Forms.Button();
            this.button_SaveInfoXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(442, 52);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(323, 26);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(442, 120);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(323, 26);
            this.textBox_LastName.TabIndex = 1;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(442, 194);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(323, 26);
            this.textBox_email.TabIndex = 2;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(442, 267);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(323, 26);
            this.textBox_Phone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ваше имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите вашу фамилию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите ваш email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите ваш телефон";
            // 
            // button_Registration
            // 
            this.button_Registration.Location = new System.Drawing.Point(272, 347);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(292, 50);
            this.button_Registration.TabIndex = 8;
            this.button_Registration.Text = "Сохранить данные";
            this.button_Registration.UseVisualStyleBackColor = true;
            this.button_Registration.Click += new System.EventHandler(this.button_Registration_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(58, 431);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(706, 224);
            this.listBox.TabIndex = 12;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // button_LoadInfo
            // 
            this.button_LoadInfo.Location = new System.Drawing.Point(58, 702);
            this.button_LoadInfo.Name = "button_LoadInfo";
            this.button_LoadInfo.Size = new System.Drawing.Size(207, 88);
            this.button_LoadInfo.TabIndex = 13;
            this.button_LoadInfo.Text = "Загрузить данные из базы";
            this.button_LoadInfo.UseVisualStyleBackColor = true;
            this.button_LoadInfo.Click += new System.EventHandler(this.button_LoadInfo_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(557, 702);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(207, 88);
            this.button_Edit.TabIndex = 14;
            this.button_Edit.Text = "Редактировать данные";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(557, 828);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(207, 88);
            this.button_Delete.TabIndex = 15;
            this.button_Delete.Text = "Удалить данные";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(738, 431);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 224);
            this.vScrollBar1.TabIndex = 16;
            // 
            // button_SaveInfoTXT
            // 
            this.button_SaveInfoTXT.Location = new System.Drawing.Point(310, 702);
            this.button_SaveInfoTXT.Name = "button_SaveInfoTXT";
            this.button_SaveInfoTXT.Size = new System.Drawing.Size(207, 88);
            this.button_SaveInfoTXT.TabIndex = 17;
            this.button_SaveInfoTXT.Text = "Сохранить данные в базу в TXT";
            this.button_SaveInfoTXT.UseVisualStyleBackColor = true;
            this.button_SaveInfoTXT.Click += new System.EventHandler(this.button_SaveInfoTXT_Click);
            // 
            // button_SaveInfoXML
            // 
            this.button_SaveInfoXML.Location = new System.Drawing.Point(310, 828);
            this.button_SaveInfoXML.Name = "button_SaveInfoXML";
            this.button_SaveInfoXML.Size = new System.Drawing.Size(207, 88);
            this.button_SaveInfoXML.TabIndex = 18;
            this.button_SaveInfoXML.Text = "Сохранить данные в базу в XML";
            this.button_SaveInfoXML.UseVisualStyleBackColor = true;
            this.button_SaveInfoXML.Click += new System.EventHandler(this.button_SaveInfoXML_Click);
            // 
            // Anketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 950);
            this.Controls.Add(this.button_SaveInfoXML);
            this.Controls.Add(this.button_SaveInfoTXT);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_LoadInfo);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Anketa";
            this.Text = "Анкета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Registration;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button_LoadInfo;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button_SaveInfoTXT;
        private System.Windows.Forms.Button button_SaveInfoXML;
    }
}

