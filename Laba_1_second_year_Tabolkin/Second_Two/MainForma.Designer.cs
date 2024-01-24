namespace Second_Two
{
    partial class MainForma
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
            this.btn_podch_forma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_podch_forma
            // 
            this.btn_podch_forma.Location = new System.Drawing.Point(68, 116);
            this.btn_podch_forma.Name = "btn_podch_forma";
            this.btn_podch_forma.Size = new System.Drawing.Size(152, 23);
            this.btn_podch_forma.TabIndex = 0;
            this.btn_podch_forma.Text = "Подчиненная форма";
            this.btn_podch_forma.UseVisualStyleBackColor = true;
            this.btn_podch_forma.Click += new System.EventHandler(this.btn_podch_forma_Click);
            // 
            // MainForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_podch_forma);
            this.Name = "MainForma";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_podch_forma;
    }
}

