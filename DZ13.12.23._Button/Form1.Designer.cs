namespace DZ13._12._23._Button
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
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_SecondName = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_SecondName = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.label_BirthDate = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_LastName.Location = new System.Drawing.Point(355, 27);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(254, 30);
            this.textBox_LastName.TabIndex = 0;
            this.textBox_LastName.Validated += new System.EventHandler(this.textBox_LastName_Validated);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Name.Location = new System.Drawing.Point(355, 76);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(254, 30);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Name_Validating);
            // 
            // textBox_SecondName
            // 
            this.textBox_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_SecondName.Location = new System.Drawing.Point(355, 126);
            this.textBox_SecondName.Name = "textBox_SecondName";
            this.textBox_SecondName.Size = new System.Drawing.Size(254, 30);
            this.textBox_SecondName.TabIndex = 2;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Name.Location = new System.Drawing.Point(117, 77);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(54, 25);
            this.Label_Name.TabIndex = 3;
            this.Label_Name.Text = "Имя";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_LastName.Location = new System.Drawing.Point(117, 33);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(103, 25);
            this.label_LastName.TabIndex = 4;
            this.label_LastName.Text = "Фамилия";
            // 
            // label_SecondName
            // 
            this.label_SecondName.AutoSize = true;
            this.label_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SecondName.Location = new System.Drawing.Point(117, 127);
            this.label_SecondName.Name = "label_SecondName";
            this.label_SecondName.Size = new System.Drawing.Size(104, 25);
            this.label_SecondName.TabIndex = 5;
            this.label_SecondName.Text = "Отчество";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Gender.Location = new System.Drawing.Point(117, 184);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(49, 25);
            this.label_Gender.TabIndex = 6;
            this.label_Gender.Text = "Пол";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(355, 182);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(99, 24);
            this.radioButton_Male.TabIndex = 7;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Мужской";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(487, 180);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(99, 24);
            this.radioButton_Female.TabIndex = 8;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "Женский";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(355, 235);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_BirthDate.TabIndex = 9;
            // 
            // label_BirthDate
            // 
            this.label_BirthDate.AutoSize = true;
            this.label_BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_BirthDate.Location = new System.Drawing.Point(117, 235);
            this.label_BirthDate.Name = "label_BirthDate";
            this.label_BirthDate.Size = new System.Drawing.Size(161, 25);
            this.label_BirthDate.TabIndex = 10;
            this.label_BirthDate.Text = "Дата рождения";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Status.Location = new System.Drawing.Point(117, 290);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(179, 25);
            this.label_Status.TabIndex = 11;
            this.label_Status.Text = "Семейный статус";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.AllowDrop = true;
            this.comboBox_Status.AutoCompleteCustomSource.AddRange(new string[] {
            "Женат/Замужем"});
            this.comboBox_Status.DisplayMember = "0";
            this.comboBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Женат/Замужем",
            "Не женат/Не замужем",
            "Разведен/Разведена",
            "Вдовец/Вдова"});
            this.comboBox_Status.Location = new System.Drawing.Point(355, 290);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(254, 33);
            this.comboBox_Status.TabIndex = 12;
            this.comboBox_Status.Tag = "";
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Info.Location = new System.Drawing.Point(117, 350);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(185, 25);
            this.label_Info.TabIndex = 13;
            this.label_Info.Text = "Доп. информация";
            // 
            // textBox_Info
            // 
            this.textBox_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Info.Location = new System.Drawing.Point(355, 350);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.Size = new System.Drawing.Size(254, 62);
            this.textBox_Info.TabIndex = 14;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(12, 379);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(117, 33);
            this.button_Save.TabIndex = 15;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 424);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Info);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_BirthDate);
            this.Controls.Add(this.dateTimePicker_BirthDate);
            this.Controls.Add(this.radioButton_Female);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_SecondName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.textBox_SecondName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_LastName);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_SecondName;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_SecondName;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private System.Windows.Forms.Label label_BirthDate;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.TextBox textBox_Info;
        private System.Windows.Forms.Button button_Save;
    }
}

