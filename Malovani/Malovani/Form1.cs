using System;
using System.Drawing;
using System.Windows.Forms;

namespace Malovani
{
    public partial class Form1 : Form
    {
        int BrushSize = 10;
        bool Fill = false;
        string Shape = "Line";
        Pen myPen = new Pen(Color.Black, 3);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxBrushSize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxBrushSize.Text, out int n))
            {

                int Size = Convert.ToInt32(textBoxBrushSize.Text);
                if (Size > 0)
                {
                    BrushSize = Size;
                }
                else
                {
                    MessageBox.Show("Toto není platná hodnota. Byla změněna na 10");
                    BrushSize = 10;
                    textBoxBrushSize.Text = "10";
                }
            }
            else
            {
                MessageBox.Show("Toto není platná hodnota. Byla změněna na 10");
            }
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            colorDialogColorSelect.ShowDialog();
            panelColorSelected.BackColor = colorDialogColorSelect.Color;
            myPen.Color = colorDialogColorSelect.Color;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = checkedListBox1.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < checkedListBox1.Items.Count; iIndex++)
                checkedListBox1.SetItemCheckState(iIndex, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(iSelectedIndex, CheckState.Checked);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = "Teď je myš nad Panelem";
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            panel1.Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = "Teď je myš nad Formem";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            myGraphics.DrawLine(myPen, MousePosition.X, MousePosition.Y, MousePosition.X, MousePosition.Y);
        }
    }
}
