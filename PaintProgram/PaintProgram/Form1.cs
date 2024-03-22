using PaintProgram.Properties;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace PaintProgram
{
    public partial class Form1 : Form
    {
        int mouseXLast = 0;
        int mouseYLast = 0;
        int function = 0;
        int imgWidth;
        float imgHeight;

        bool moving = false;
        bool fill = false;

        string importedFile = "";
        string userAnswer = "";

        Pen myPen = new Pen(Color.Black, 12);
        Pen Eraser = new Pen(Color.White, 12);
        Image newImage = Resources.img;
        Graphics graphics;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.WindowState = FormWindowState.Maximized;

            openFileDialogImage.FileName = Resources.img.ToString();

            graphics = this.CreateGraphics();

            panelColor.BackColor = colorDialogSelected.Color;
            labelColorName.Text = colorDialogSelected.Color.Name;

            checkedListBox1.SetItemCheckState(0, CheckState.Checked);
        }
        private void panelPainting_MouseDown(object sender, MouseEventArgs e)
        {
            mouseXLast = e.X;
            mouseYLast = e.Y;
            moving = true;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Cross;
            myPen.Color = colorDialogSelected.Color;
            graphics = panelPainting.CreateGraphics();
            if (function==0 ||function==101)
            {
                panelPositition.Hide();

            }
            else
            {
                panelPositition.Show();
                labelA.Text = "0";
                labelB.Text = "0";

            }
            switch (function)
            {  
                case 100:
                    panelPositition.Hide();
                    graphics.DrawImage(newImage, e.X, e.Y, imgWidth, imgHeight);
                    moving = false;
                    function = 0;
                    break;
            }
        }
        private void panelPainting_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Text = e.X.ToString();
            labelY.Text = e.Y.ToString();
            if (function == 2 || function == 4)
            {
                labelInfo.Show();
                int a = Math.Abs(e.X - mouseXLast);
                labelA.Text = a.ToString();
                labelB.Text = a.ToString();
            }
            else
            {
                int a = Math.Abs(e.X - mouseXLast);
                int b = Math.Abs(e.Y - mouseYLast);
                labelA.Text = a.ToString();
                labelB.Text = b.ToString();
            }        
            if (moving == true)
            {
                switch (function)
                {
                    case 0:
                        Brush myBrush = new SolidBrush(colorDialogSelected.Color);
                        graphics.DrawLine(myPen, e.X, e.Y, mouseXLast, mouseYLast);
                        graphics.FillEllipse(myBrush, e.X - myPen.Width / 2, e.Y - myPen.Width / 2, myPen.Width, myPen.Width);
                        mouseXLast = e.X;
                        mouseYLast = e.Y;
                        break;
                    case 2:
                    case 4:
                        labelB.Text = labelB.Text;
                        break;
                    case 101:
                        graphics.DrawLine(Eraser, e.X, e.Y, mouseXLast, mouseYLast);
                        graphics.FillRectangle(Brushes.White, e.X - myPen.Width / 2, e.Y - myPen.Width / 2, myPen.Width, myPen.Width);
                        mouseXLast = e.X;
                        mouseYLast = e.Y;
                        break;
                }
            }
        }

        private void buttonChangeColor_Click(object sender, System.EventArgs e)
        {
            colorDialogSelected.ShowDialog();
            panelColor.BackColor = colorDialogSelected.Color;
            labelColorName.Text = colorDialogSelected.Color.Name;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int UserSelectedIndex = checkedListBox1.SelectedIndex;
            for (int iIndex = 0; iIndex < checkedListBox1.Items.Count; iIndex++)
                checkedListBox1.SetItemCheckState(iIndex, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(UserSelectedIndex, CheckState.Checked);
            function = UserSelectedIndex;
            if (UserSelectedIndex > 0)
            {
                buttonFill.Show();
            }
            else
            {
                buttonFill.Hide();
            }
        }

        private void panelPainting_MouseUp(object sender, MouseEventArgs e)
        {
            panelPositition.Hide();
            labelInfo.Hide();
            moving = false;
            int width;
            int height;
            int startX;
            int startY;
            SolidBrush myBrush = new SolidBrush(colorDialogSelected.Color);
            width = Math.Abs(e.X - mouseXLast);
            height = Math.Abs(e.Y - mouseYLast);
            startX = Math.Min(mouseXLast, e.X);
            startY = Math.Min(mouseYLast, e.Y);
            switch (function)
            {
                case 1:
                    
                    if (fill == true)
                    {
                        graphics.FillRectangle(myBrush, startX, startY, width, height);
                    }
                    else
                    {
                        graphics.DrawRectangle(myPen, startX, startY, width, height);
                    }
                    break;
                case 2:
                    if (fill == true)
                    {
                        graphics.FillRectangle(myBrush, startX, startY, width, width);
                    }
                    else
                    {
                        graphics.DrawRectangle(myPen, startX, startY, width, width);
                    }
                    break;
                case 3:
                    if (fill == true)
                    {
                        graphics.FillEllipse(myBrush, startX, startY, width, height);
                    }
                    else
                    {
                        graphics.DrawEllipse(myPen, startX, startY, width, height);
                    }
                    break;
                case 4:
                    if (fill == true)
                    {
                        graphics.FillEllipse(myBrush, startX, startY, width, width);
                    }
                    else
                    {
                        graphics.DrawEllipse(myPen, startX, startY, width, width);
                    }
                    break;
            }

        }

        private void trackBarSize_ValueChanged(object sender, System.EventArgs e)
        {
            labelSize.Text = trackBarSize.Value.ToString();
            myPen.Width = trackBarSize.Value;
            Eraser.Width = trackBarSize.Value;
        }

        private void buttonImportImg_Click(object sender, System.EventArgs e)
        {
            openFileDialogImage.ShowDialog();
            importedFile = openFileDialogImage.FileName;
            openFileDialogImage.Filter = "BMP|*.BMP;";
            try
            {
                if (importedFile != Resources.img.ToString() || openFileDialogImage.FileName == null)
                {
                    newImage = Image.FromFile(importedFile);
                    if (newImage.Width > 300 && newImage.Height > 300)
                    {
                        imgWidth = 300;
                        imgHeight = newImage.Height / (newImage.Width / 300);
                    }
                    MessageBox.Show("Kliknutím vyber pozici obrázku. Vloží se s maximální šířkou 300 pixelů!");
                    function = 100;
                }
                else
                {
                    MessageBox.Show("Nebyl vybrán žádný soubor. Vložení nebude provedeno.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nastala neočakávaná situace. Přesvěčte se, že jste zvolil obrázkový soubor.");
            }
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            if (function<=4)
            {
                checkedListBox1.SetSelected(1,true);
                checkedListBox1.SetSelected(0, true);
                checkedListBox1.SetItemCheckState(0, CheckState.Unchecked);
            }
            function = 101;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            if (fill==true)
            {
                fill = false;
                buttonFill.Text = "Klikni pro výplň";
            }
            else
            {
                fill = true;
                buttonFill.Text = "Klikni pro nevyplněný";
            }
        }
    }
}

