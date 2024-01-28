using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 В этом приложении реализована работа с файлами
 с меню и инструментальной панелью на главной форме
 */

namespace Fourth_Two
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;

        public Form1()
        {
            InitializeComponent();
            InitializeToolBar();
        }

        private void InitializeToolBar()
        {
            // Создаем ToolBar
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            //this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();

            imageList1 = new ImageList();
            imageList1.Images.Add(Properties.Resources.open); 
            imageList1.Images.Add(Properties.Resources.save);
            imageList1.Images.Add(Properties.Resources.color);

            // Связываем ImageList с ToolBar
            this.toolBar1.ImageList = this.imageList1;

            // Добавляем ToolBarButton в ToolBar
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
                this.toolBarButton1,
                this.toolBarButton2,
                this.toolBarButton3
            });

            // Настроим свойства ToolBar
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(432, 42);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);

            // Настроим свойства ToolBarButton1
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Text = "OpenFile";
            this.toolBarButton1.ToolTipText = "Диалоговое окно открытия файла";

            // Настроим свойства ToolBarButton2
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Text = "SaveFile";
            this.toolBarButton2.ToolTipText = "Диалоговое окно сохранения файла";

            // Настроим свойства ToolBarButton3
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Text = "Color";
            this.toolBarButton3.ToolTipText = "Диалоговое окно выбора цвета";
        }

        private void toolBar1_ButtonClick(object sender,
                                           System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            int buttonNumber = this.toolBar1.Buttons.IndexOf(e.Button);

            switch (buttonNumber)
            {
                case 0:
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.ShowDialog();
                    //код, показывающий, что делать с открытым файлом
                    textBox1.Text = "Открытие Файла!";
                    break;
                case 1:
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.ShowDialog();
                    //код, анализирующий результат операции сохранения файла
                    textBox1.Text = "Сохранение Файла!";
                    break;
                default:
                    ColorDialog colorDialog1 = new ColorDialog();
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                        this.textBox1.BackColor = colorDialog1.Color;
                    break;
            }
        }
    }
}