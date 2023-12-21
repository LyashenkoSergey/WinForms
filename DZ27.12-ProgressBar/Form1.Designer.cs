namespace DZ27._12_ProgressBar
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
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar_Download = new System.Windows.Forms.ProgressBar();
            this.button_Download = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(351, 91);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(404, 26);
            this.textBox_FilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите путь к файлу";
            // 
            // progressBar_Download
            // 
            this.progressBar_Download.Location = new System.Drawing.Point(56, 158);
            this.progressBar_Download.Name = "progressBar_Download";
            this.progressBar_Download.Size = new System.Drawing.Size(699, 48);
            this.progressBar_Download.TabIndex = 2;
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(251, 255);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(301, 79);
            this.button_Download.TabIndex = 3;
            this.button_Download.Text = "Скачать";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(68, 390);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(687, 184);
            this.listBox1.TabIndex = 4;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(728, 390);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(26, 179);
            this.vScrollBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 606);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.progressBar_Download);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_FilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_Download;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

