using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black, 10);
        bool moves = false;
        bool inside = false;
        int mouseX = 0;
        int mouseY = 0;
        int shape = 0;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            colorDialogColorSelect.ShowDialog();
            panelColorSelected.BackColor = colorDialogColorSelect.Color;
            myPen.Color = colorDialogColorSelect.Color;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = checkedListBox1.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < checkedListBox1.Items.Count; iIndex++)
                checkedListBox1.SetItemCheckState(iIndex, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(iSelectedIndex, CheckState.Checked);
            shape = iSelectedIndex;
        }

        private void textBoxBrushSize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxBrushSize.Text, out int n))
            {

                int Size = Convert.ToInt32(textBoxBrushSize.Text);
                if (Size > 0)
                {
                    myPen.Width = Size;
                }
                else
                {
                    myPen.Width = 10;
                    textBoxBrushSize.Text = "10";
                    MessageBox.Show("Toto není platná hodnota. Byla změněna na 10");
                }
            }
            else
            {
                MessageBox.Show("Toto není platná hodnota. Byla změněna na 10");
            }
        }

        private void panelTemp_MouseDown(object sender, MouseEventArgs e)
        {
            moves = true;
        }

        private void panelTemp_MouseMove(object sender, MouseEventArgs e)
        {
            switch (shape)
            {
                case 0:
                    mouseX = e.X;
                    mouseY = e.Y;
                    if (moves == true)
                    {
                        g = panelTemp.CreateGraphics();
                        g.DrawEllipse(myPen, mouseX, mouseY, myPen.Width, myPen.Width);
                    }
                    break;
                case 1:
                    mouseX = e.X;
                    mouseY = e.Y;
                    if (moves == true)
                    {
                        g = panelTemp.CreateGraphics();
                        g.DrawLine(myPen, mouseX, mouseY, mouseX+5, mouseY+5);
                    }
                    break;
                case 2:
                    mouseX = e.X;
                    mouseY = e.Y;
                    if (moves == true)
                    {
                        g = panelTemp.CreateGraphics();
                        g.DrawRectangle(myPen, mouseX, mouseY, myPen.Width, myPen.Width);
                    }
                    break;
                case 3:
                    mouseX = e.X;
                    mouseY = e.Y;
                    if (moves == true)
                    {
                        g = panelTemp.CreateGraphics();
                        g.DrawEllipse(myPen, mouseX, mouseY, myPen.Width, myPen.Width);
                    }
                    break;
            }
            
        }

        private void panelTemp_MouseUp(object sender, MouseEventArgs e)
        {
            moves = false;
        }
        private void panelTemp_MouseHover(object sender, EventArgs e)
        {
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelTemp.Invalidate();
        }
    }
}

