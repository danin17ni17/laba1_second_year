namespace Second_One
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
            this.btn_modal = new System.Windows.Forms.Button();
            this.btn_nemodal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_modal
            // 
            this.btn_modal.Location = new System.Drawing.Point(71, 91);
            this.btn_modal.Name = "btn_modal";
            this.btn_modal.Size = new System.Drawing.Size(147, 23);
            this.btn_modal.TabIndex = 0;
            this.btn_modal.Text = "Модальная форма";
            this.btn_modal.UseVisualStyleBackColor = true;
            this.btn_modal.Click += new System.EventHandler(this.btn_modal_Click);
            // 
            // btn_nemodal
            // 
            this.btn_nemodal.Location = new System.Drawing.Point(71, 146);
            this.btn_nemodal.Name = "btn_nemodal";
            this.btn_nemodal.Size = new System.Drawing.Size(147, 23);
            this.btn_nemodal.TabIndex = 1;
            this.btn_nemodal.Text = "Немодальная форма";
            this.btn_nemodal.UseVisualStyleBackColor = true;
            this.btn_nemodal.Click += new System.EventHandler(this.btn_nemodal_Click);
            // 
            // MainForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_nemodal);
            this.Controls.Add(this.btn_modal);
            this.Name = "MainForma";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_modal;
        private System.Windows.Forms.Button btn_nemodal;
    }
}

