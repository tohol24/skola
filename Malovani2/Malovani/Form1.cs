using System;
using System.Drawing;
using System.Windows.Forms;

namespace Malovani
{
    public partial class Form1 : Form
    {
        bool moving = false;
        bool isLoading = true;
        static string loc = Application.StartupPath + "\\img.png";
        int function = 0;
        Graphics graphics;
        Pen myPen = new Pen(Color.Black, 12);
        Image newImage = Image.FromFile(loc);
        string importedFile = "";
        string userAnswer = "";
        int mouseXLast = 0;
        int mouseYLast = 0;
        int imgWidth;
        float imgHeight;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.WindowState = FormWindowState.Maximized;

            graphics = this.CreateGraphics();

            panelColor.BackColor = colorDialogSelected.Color;
            labelColorName.Text = colorDialogSelected.Color.Name;

            checkedListBox1.SetItemCheckState(0, CheckState.Checked);
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            colorDialogSelected.ShowDialog();
            panelColor.BackColor = colorDialogSelected.Color;
            labelColorName.Text = colorDialogSelected.Color.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawRectangle(myPen, panelSideMenu.Width, 0, this.Width - panelSideMenu.Width - 35, this.Height - 50);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            FormDialog dialog1 = new FormDialog();
            dialog1.Show();
        }
        public void actionDialog(string Answer)
        {
            userAnswer = Answer;
            switch (userAnswer)
            {
                case "yes":
                    MessageBox.Show("gkkg");
                    this.Show();
                    this.Close();
                    break;
                case "no":
                    break;
                case "save":
                    break;
                default:
                    break;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseXLast = e.X;
            mouseYLast = e.Y;
            moving = true;
            myPen.Color = colorDialogSelected.Color;
            switch (function)
            {
                case 3:
                    graphics.DrawImage(newImage, e.X, e.Y, imgWidth, imgHeight);
                    moving = false;
                    function = 0;
                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            labelX.Text = (e.X - 150).ToString();
            labelY.Text = e.Y.ToString();
            if (moving == true && e.X > panelSideMenu.Width + 1 && e.X < this.Width - 40 && e.Y > 15 && e.Y < panelSideMenu.Height)
            {
                switch (function)
                {
                    case 0:
                        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Cross;
                        Brush myBrush = new SolidBrush(colorDialogSelected.Color);
                        graphics.DrawLine(myPen, e.X, e.Y, mouseXLast, mouseYLast);
                        graphics.FillEllipse(myBrush, e.X - myPen.Width / 2, e.Y - myPen.Width / 2, myPen.Width, myPen.Width);
                        mouseXLast = e.X;
                        mouseYLast = e.Y;
                        break;
                    case 2:
                        Cursor.Position = new Point(e.X,mouseYLast+(e.X-mouseXLast));
                        break;
                    }
            }
            else
            {
                moving = false;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            switch (function)
            {
                case 1:
                    graphics.DrawRectangle(myPen, mouseXLast, mouseYLast, e.X - mouseXLast, e.Y - mouseYLast);
                    break;
                case 2:
                    graphics.DrawRectangle(myPen, mouseXLast, mouseYLast, e.X - mouseXLast, e.Y - mouseYLast);
                    break;
                default:
                    break;
            }
        }
        private void buttonImportImg_Click(object sender, EventArgs e)
        {
            openFileDialogImage.ShowDialog();
            importedFile = openFileDialogImage.FileName;
            newImage = Image.FromFile(importedFile);
            if (newImage.Width > 300 && newImage.Height > 300)
            {
                imgWidth = 300;
                imgHeight = newImage.Height / (newImage.Width / 300);
            }
            MessageBox.Show("Kliknutím vyber pozici obrázku. Vloží se s maximální šířkou 300 pixelů!" + imgWidth.ToString() + imgHeight.ToString());
            function = 3;
        }

        private void trackBarSize_ValueChanged(object sender, EventArgs e)
        {
            labelSize.Text = trackBarSize.Value.ToString();
            myPen.Width = trackBarSize.Value;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lastIndex = 0;
            checkedListBox1.SetItemCheckState(lastIndex, CheckState.Unchecked);
            lastIndex=checkedListBox1.SelectedIndex;
        }
    }
}
