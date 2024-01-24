namespace Second_One
{
    partial class NeModalForma
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
            this.lb_Books = new System.Windows.Forms.ListBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.tb_Books = new System.Windows.Forms.TextBox();
            this.btn_Dobav_Books = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Books
            // 
            this.lb_Books.FormattingEnabled = true;
            this.lb_Books.Location = new System.Drawing.Point(70, 81);
            this.lb_Books.Name = "lb_Books";
            this.lb_Books.Size = new System.Drawing.Size(139, 82);
            this.lb_Books.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(197, 226);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "button1";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tb_Books
            // 
            this.tb_Books.Location = new System.Drawing.Point(70, 29);
            this.tb_Books.Name = "tb_Books";
            this.tb_Books.Size = new System.Drawing.Size(139, 20);
            this.tb_Books.TabIndex = 5;
            // 
            // btn_Dobav_Books
            // 
            this.btn_Dobav_Books.Location = new System.Drawing.Point(70, 180);
            this.btn_Dobav_Books.Name = "btn_Dobav_Books";
            this.btn_Dobav_Books.Size = new System.Drawing.Size(139, 23);
            this.btn_Dobav_Books.TabIndex = 4;
            this.btn_Dobav_Books.Text = "Добавить книгу";
            this.btn_Dobav_Books.UseVisualStyleBackColor = true;
            this.btn_Dobav_Books.Click += new System.EventHandler(this.btn_Dobav_Books_Click);
            // 
            // NeModalForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb_Books);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tb_Books);
            this.Controls.Add(this.btn_Dobav_Books);
            this.Name = "NeModalForma";
            this.Text = "NeModalForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Books;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tb_Books;
        private System.Windows.Forms.Button btn_Dobav_Books;
    }
}