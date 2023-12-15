namespace DZ13._12._23_Datepicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Finish = new System.Windows.Forms.DateTimePicker();
            this.label_Start = new System.Windows.Forms.Label();
            this.label_Finish = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_Minimaze = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_Start.Location = new System.Drawing.Point(127, 133);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(187, 26);
            this.dateTimePicker_Start.TabIndex = 0;
            this.dateTimePicker_Start.ValueChanged += new System.EventHandler(this.dateTimePicker_Start_ValueChanged);
            // 
            // dateTimePicker_Finish
            // 
            this.dateTimePicker_Finish.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker_Finish.Location = new System.Drawing.Point(117, 247);
            this.dateTimePicker_Finish.Name = "dateTimePicker_Finish";
            this.dateTimePicker_Finish.Size = new System.Drawing.Size(214, 26);
            this.dateTimePicker_Finish.TabIndex = 1;
            this.dateTimePicker_Finish.ValueChanged += new System.EventHandler(this.dateTimePicker_Finish_ValueChanged);
            // 
            // label_Start
            // 
            this.label_Start.AutoSize = true;
            this.label_Start.BackColor = System.Drawing.Color.White;
            this.label_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Start.Location = new System.Drawing.Point(136, 85);
            this.label_Start.Name = "label_Start";
            this.label_Start.Size = new System.Drawing.Size(159, 25);
            this.label_Start.TabIndex = 2;
            this.label_Start.Text = "Начальная дата";
            // 
            // label_Finish
            // 
            this.label_Finish.AutoSize = true;
            this.label_Finish.BackColor = System.Drawing.Color.White;
            this.label_Finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Finish.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label_Finish.Location = new System.Drawing.Point(136, 192);
            this.label_Finish.Name = "label_Finish";
            this.label_Finish.Size = new System.Drawing.Size(149, 25);
            this.label_Finish.TabIndex = 3;
            this.label_Finish.Text = "Конечная дата";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.White;
            this.label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_Result.Location = new System.Drawing.Point(122, 304);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(173, 25);
            this.label_Result.TabIndex = 4;
            this.label_Result.Text = "Количество дней";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Result.Location = new System.Drawing.Point(151, 351);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(121, 30);
            this.textBox_Result.TabIndex = 5;
            // 
            // button_Minimaze
            // 
            this.button_Minimaze.Location = new System.Drawing.Point(166, 39);
            this.button_Minimaze.Name = "button_Minimaze";
            this.button_Minimaze.Size = new System.Drawing.Size(25, 31);
            this.button_Minimaze.TabIndex = 6;
            this.button_Minimaze.Text = "_";
            this.button_Minimaze.UseVisualStyleBackColor = true;
            this.button_Minimaze.Click += new System.EventHandler(this.button_Minimaze_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(227, 39);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(25, 31);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(450, 450);
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Minimaze);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_Finish);
            this.Controls.Add(this.label_Start);
            this.Controls.Add(this.dateTimePicker_Finish);
            this.Controls.Add(this.dateTimePicker_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Finish;
        private System.Windows.Forms.Label label_Start;
        private System.Windows.Forms.Label label_Finish;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_Minimaze;
        private System.Windows.Forms.Button button_Close;
    }
}

