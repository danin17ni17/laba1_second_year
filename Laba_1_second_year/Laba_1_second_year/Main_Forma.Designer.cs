namespace Laba_1_second_year
{
    partial class Main_Forma
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_podch_form = new System.Windows.Forms.Button();
            this.btn_ris_form = new System.Windows.Forms.Button();
            this.btn_files_form = new System.Windows.Forms.Button();
            this.btn_graf_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_podch_form
            // 
            this.btn_podch_form.Location = new System.Drawing.Point(63, 52);
            this.btn_podch_form.Name = "btn_podch_form";
            this.btn_podch_form.Size = new System.Drawing.Size(163, 23);
            this.btn_podch_form.TabIndex = 0;
            this.btn_podch_form.Text = "Подчиненная форма";
            this.btn_podch_form.UseVisualStyleBackColor = true;
            this.btn_podch_form.Click += new System.EventHandler(this.btn_podch_form_Click);
            // 
            // btn_ris_form
            // 
            this.btn_ris_form.Location = new System.Drawing.Point(63, 96);
            this.btn_ris_form.Name = "btn_ris_form";
            this.btn_ris_form.Size = new System.Drawing.Size(163, 23);
            this.btn_ris_form.TabIndex = 1;
            this.btn_ris_form.Text = "Рисование фигур";
            this.btn_ris_form.UseVisualStyleBackColor = true;
            this.btn_ris_form.Click += new System.EventHandler(this.btn_ris_form_Click);
            // 
            // btn_files_form
            // 
            this.btn_files_form.Location = new System.Drawing.Point(63, 141);
            this.btn_files_form.Name = "btn_files_form";
            this.btn_files_form.Size = new System.Drawing.Size(163, 23);
            this.btn_files_form.TabIndex = 2;
            this.btn_files_form.Text = "Работа с файлами";
            this.btn_files_form.UseVisualStyleBackColor = true;
            this.btn_files_form.Click += new System.EventHandler(this.btn_files_form_Click);
            // 
            // btn_graf_form
            // 
            this.btn_graf_form.Location = new System.Drawing.Point(63, 182);
            this.btn_graf_form.Name = "btn_graf_form";
            this.btn_graf_form.Size = new System.Drawing.Size(163, 23);
            this.btn_graf_form.TabIndex = 3;
            this.btn_graf_form.Text = "Работа с графикой";
            this.btn_graf_form.UseVisualStyleBackColor = true;
            this.btn_graf_form.Click += new System.EventHandler(this.btn_graf_form_Click);
            // 
            // Main_Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_graf_form);
            this.Controls.Add(this.btn_files_form);
            this.Controls.Add(this.btn_ris_form);
            this.Controls.Add(this.btn_podch_form);
            this.Name = "Main_Forma";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_podch_form;
        private System.Windows.Forms.Button btn_ris_form;
        private System.Windows.Forms.Button btn_files_form;
        private System.Windows.Forms.Button btn_graf_form;
    }
}

